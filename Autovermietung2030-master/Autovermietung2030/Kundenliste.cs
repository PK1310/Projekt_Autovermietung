using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Autovermietung2030
{
    public partial class Kundenliste : Form
    {
        public Kundenliste()
        {
            InitializeComponent();
        }

        Color alteFarbe;

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kundeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.auto2030DataSet);
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten! \nBitte überprüfen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Kundenliste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "auto2030DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.auto2030DataSet.Kunde);

        }

        private void kundeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            bool fehlerKeinEintrag = false;
            // überprüft werden nur die Spalten 2-6
            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 6))
            {
                // ist der Eintrag leer?
                if (e.FormattedValue.ToString() == string.Empty)
                {
                    //eine Meldung anzeigen
                    MessageBox.Show("Sie müssen einen Wert für " + kundeDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                    //den Fehlertext setzen
                    kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein!";
                    //die Aktion abbrechen
                    e.Cancel = true;
                }
            }
            //die Detailprüfung für die Postleitzahl
            //sind wir in der Spalte für die Postleitzahl und ist ein
            //Eintrag vorhanden?
            if ((e.ColumnIndex == 4) && (fehlerKeinEintrag == false))
            {
                //ist der Eintrag exakt fünf Zeichen lang?
                //sonst eine Meldung anzeigen und die Verarbeitung abbrechen
                if (e.FormattedValue.ToString().Length != 5)
                {
                    //bitte in einer Zeile eingeben
                    MessageBox.Show("Die Postleitzahl muss 5 Ziffern lang sein!");
                    e.Cancel = true;
                }
                //sind es nur Ziffern
                else
                //bitte jeweils in einer Zeile eingeben
                if (Int32.TryParse(e.FormattedValue.ToString(), out int postleitzahltemp) == false)
                {
                    MessageBox.Show("Das Format der Postleitzahl ist ungültig!");
                    e.Cancel = true;
                }
            }
        }

        private void kundeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
                kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void kundeDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //befindet sich die Maus über einer Zelle?
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].
                Cells[e.ColumnIndex];
                //die alte Farbe sichern
                alteFarbe = zelle.Style.BackColor;
                //die neue Farbe setzen
                zelle.Style.BackColor = Color.LightBlue;
            }

        }

        private void kundeDataGridView_CellMouseLeave(object sender,
        DataGridViewCellEventArgs e)
        {
            //befindet sich die Maus über einer Zelle?
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                //für den leichteren Zugriff
                //bitte in einer Zeile eingeben
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].
                Cells[e.ColumnIndex];
                //die alte Farbe wiederherstellen
                zelle.Style.BackColor = alteFarbe;
            }
        }

        
    }
}

