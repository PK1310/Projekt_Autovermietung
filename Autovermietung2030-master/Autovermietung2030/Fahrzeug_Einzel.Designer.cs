namespace Autovermietung2030
{
    partial class Fahrzeug_Einzel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fahrzeug_Einzel));
            System.Windows.Forms.Label fNummerLabel;
            System.Windows.Forms.Label bezeichnungLabel;
            System.Windows.Forms.Label kennzeichenLabel;
            System.Windows.Forms.Label preisProTagLabel;
            System.Windows.Forms.Label typLabel;
            System.Windows.Forms.Label ausgeliehenLabel;
            this.auto2030DataSet = new Autovermietung2030.auto2030DataSet();
            this.fahrzeugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fahrzeugTableAdapter = new Autovermietung2030.auto2030DataSetTableAdapters.FahrzeugTableAdapter();
            this.tableAdapterManager = new Autovermietung2030.auto2030DataSetTableAdapters.TableAdapterManager();
            this.fahrzeugBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.fahrzeugBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fNummerTextBox = new System.Windows.Forms.TextBox();
            this.bezeichnungTextBox = new System.Windows.Forms.TextBox();
            this.kennzeichenTextBox = new System.Windows.Forms.TextBox();
            this.preisProTagTextBox = new System.Windows.Forms.TextBox();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.ausgeliehenCheckBox = new System.Windows.Forms.CheckBox();
            fNummerLabel = new System.Windows.Forms.Label();
            bezeichnungLabel = new System.Windows.Forms.Label();
            kennzeichenLabel = new System.Windows.Forms.Label();
            preisProTagLabel = new System.Windows.Forms.Label();
            typLabel = new System.Windows.Forms.Label();
            ausgeliehenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.auto2030DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingNavigator)).BeginInit();
            this.fahrzeugBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // auto2030DataSet
            // 
            this.auto2030DataSet.DataSetName = "auto2030DataSet";
            this.auto2030DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fahrzeugBindingSource
            // 
            this.fahrzeugBindingSource.DataMember = "Fahrzeug";
            this.fahrzeugBindingSource.DataSource = this.auto2030DataSet;
            // 
            // fahrzeugTableAdapter
            // 
            this.fahrzeugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FahrzeugTableAdapter = this.fahrzeugTableAdapter;
            this.tableAdapterManager.KundeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Autovermietung2030.auto2030DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fahrzeugBindingNavigator
            // 
            this.fahrzeugBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fahrzeugBindingNavigator.BindingSource = this.fahrzeugBindingSource;
            this.fahrzeugBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fahrzeugBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fahrzeugBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fahrzeugBindingNavigatorSaveItem});
            this.fahrzeugBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fahrzeugBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fahrzeugBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fahrzeugBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fahrzeugBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fahrzeugBindingNavigator.Name = "fahrzeugBindingNavigator";
            this.fahrzeugBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fahrzeugBindingNavigator.Size = new System.Drawing.Size(282, 25);
            this.fahrzeugBindingNavigator.TabIndex = 0;
            this.fahrzeugBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 15);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // fahrzeugBindingNavigatorSaveItem
            // 
            this.fahrzeugBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fahrzeugBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fahrzeugBindingNavigatorSaveItem.Image")));
            this.fahrzeugBindingNavigatorSaveItem.Name = "fahrzeugBindingNavigatorSaveItem";
            this.fahrzeugBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fahrzeugBindingNavigatorSaveItem.Text = "Daten speichern";
            this.fahrzeugBindingNavigatorSaveItem.Click += new System.EventHandler(this.fahrzeugBindingNavigatorSaveItem_Click);
            // 
            // fNummerLabel
            // 
            fNummerLabel.AutoSize = true;
            fNummerLabel.Location = new System.Drawing.Point(47, 53);
            fNummerLabel.Name = "fNummerLabel";
            fNummerLabel.Size = new System.Drawing.Size(55, 13);
            fNummerLabel.TabIndex = 1;
            fNummerLabel.Text = "f Nummer:";
            // 
            // fNummerTextBox
            // 
            this.fNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fahrzeugBindingSource, "fNummer", true));
            this.fNummerTextBox.Location = new System.Drawing.Point(122, 50);
            this.fNummerTextBox.Name = "fNummerTextBox";
            this.fNummerTextBox.Size = new System.Drawing.Size(104, 20);
            this.fNummerTextBox.TabIndex = 2;
            // 
            // bezeichnungLabel
            // 
            bezeichnungLabel.AutoSize = true;
            bezeichnungLabel.Location = new System.Drawing.Point(47, 76);
            bezeichnungLabel.Name = "bezeichnungLabel";
            bezeichnungLabel.Size = new System.Drawing.Size(71, 13);
            bezeichnungLabel.TabIndex = 3;
            bezeichnungLabel.Text = "bezeichnung:";
            // 
            // bezeichnungTextBox
            // 
            this.bezeichnungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fahrzeugBindingSource, "bezeichnung", true));
            this.bezeichnungTextBox.Location = new System.Drawing.Point(122, 73);
            this.bezeichnungTextBox.Name = "bezeichnungTextBox";
            this.bezeichnungTextBox.Size = new System.Drawing.Size(104, 20);
            this.bezeichnungTextBox.TabIndex = 4;
            // 
            // kennzeichenLabel
            // 
            kennzeichenLabel.AutoSize = true;
            kennzeichenLabel.Location = new System.Drawing.Point(47, 102);
            kennzeichenLabel.Name = "kennzeichenLabel";
            kennzeichenLabel.Size = new System.Drawing.Size(71, 13);
            kennzeichenLabel.TabIndex = 5;
            kennzeichenLabel.Text = "kennzeichen:";
            // 
            // kennzeichenTextBox
            // 
            this.kennzeichenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fahrzeugBindingSource, "kennzeichen", true));
            this.kennzeichenTextBox.Location = new System.Drawing.Point(122, 99);
            this.kennzeichenTextBox.Name = "kennzeichenTextBox";
            this.kennzeichenTextBox.Size = new System.Drawing.Size(104, 20);
            this.kennzeichenTextBox.TabIndex = 6;
            // 
            // preisProTagLabel
            // 
            preisProTagLabel.AutoSize = true;
            preisProTagLabel.Location = new System.Drawing.Point(47, 128);
            preisProTagLabel.Name = "preisProTagLabel";
            preisProTagLabel.Size = new System.Drawing.Size(73, 13);
            preisProTagLabel.TabIndex = 7;
            preisProTagLabel.Text = "preis Pro Tag:";
            // 
            // preisProTagTextBox
            // 
            this.preisProTagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fahrzeugBindingSource, "preisProTag", true));
            this.preisProTagTextBox.Location = new System.Drawing.Point(122, 125);
            this.preisProTagTextBox.Name = "preisProTagTextBox";
            this.preisProTagTextBox.Size = new System.Drawing.Size(104, 20);
            this.preisProTagTextBox.TabIndex = 8;
            // 
            // typLabel
            // 
            typLabel.AutoSize = true;
            typLabel.Location = new System.Drawing.Point(47, 154);
            typLabel.Name = "typLabel";
            typLabel.Size = new System.Drawing.Size(24, 13);
            typLabel.TabIndex = 9;
            typLabel.Text = "typ:";
            // 
            // typTextBox
            // 
            this.typTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fahrzeugBindingSource, "typ", true));
            this.typTextBox.Location = new System.Drawing.Point(122, 151);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.Size = new System.Drawing.Size(104, 20);
            this.typTextBox.TabIndex = 10;
            // 
            // ausgeliehenLabel
            // 
            ausgeliehenLabel.AutoSize = true;
            ausgeliehenLabel.Location = new System.Drawing.Point(49, 182);
            ausgeliehenLabel.Name = "ausgeliehenLabel";
            ausgeliehenLabel.Size = new System.Drawing.Size(67, 13);
            ausgeliehenLabel.TabIndex = 11;
            ausgeliehenLabel.Text = "ausgeliehen:";
            // 
            // ausgeliehenCheckBox
            // 
            this.ausgeliehenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fahrzeugBindingSource, "ausgeliehen", true));
            this.ausgeliehenCheckBox.Location = new System.Drawing.Point(122, 177);
            this.ausgeliehenCheckBox.Name = "ausgeliehenCheckBox";
            this.ausgeliehenCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ausgeliehenCheckBox.TabIndex = 12;
            this.ausgeliehenCheckBox.Text = "checkBox1";
            this.ausgeliehenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Fahrzeug_Einzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(fNummerLabel);
            this.Controls.Add(this.fNummerTextBox);
            this.Controls.Add(bezeichnungLabel);
            this.Controls.Add(this.bezeichnungTextBox);
            this.Controls.Add(kennzeichenLabel);
            this.Controls.Add(this.kennzeichenTextBox);
            this.Controls.Add(preisProTagLabel);
            this.Controls.Add(this.preisProTagTextBox);
            this.Controls.Add(typLabel);
            this.Controls.Add(this.typTextBox);
            this.Controls.Add(ausgeliehenLabel);
            this.Controls.Add(this.ausgeliehenCheckBox);
            this.Controls.Add(this.fahrzeugBindingNavigator);
            this.Name = "Fahrzeug_Einzel";
            this.Text = "Fahrzeug_Einzel";
            this.Load += new System.EventHandler(this.Fahrzeug_Einzel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auto2030DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingNavigator)).EndInit();
            this.fahrzeugBindingNavigator.ResumeLayout(false);
            this.fahrzeugBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private auto2030DataSet auto2030DataSet;
        private System.Windows.Forms.BindingSource fahrzeugBindingSource;
        private auto2030DataSetTableAdapters.FahrzeugTableAdapter fahrzeugTableAdapter;
        private auto2030DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fahrzeugBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fahrzeugBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fNummerTextBox;
        private System.Windows.Forms.TextBox bezeichnungTextBox;
        private System.Windows.Forms.TextBox kennzeichenTextBox;
        private System.Windows.Forms.TextBox preisProTagTextBox;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.CheckBox ausgeliehenCheckBox;
    }
}