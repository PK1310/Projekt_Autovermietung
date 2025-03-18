using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovermietung2030
{
    public partial class Fahrzeug_Liste : Form
    {
        public Fahrzeug_Liste()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.auto2030DataSet);

        }

        private void Fahrzeug_Liste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "auto2030DataSet.Fahrzeug". Sie können sie bei Bedarf verschieben oder entfernen.
            this.fahrzeugTableAdapter.Fill(this.auto2030DataSet.Fahrzeug);
            

        }

        private void fahrzeugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fahrzeugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.auto2030DataSet);

        }
    }
}
