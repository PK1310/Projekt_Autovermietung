namespace Autovermietung2030
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Einzelansicht = new System.Windows.Forms.Button();
            this.btn_Kundenliste = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Fahrzeugliste = new System.Windows.Forms.Button();
            this.btn_FahrzeugEinzeln = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Einzelansicht);
            this.groupBox1.Controls.Add(this.btn_Kundenliste);
            this.groupBox1.Location = new System.Drawing.Point(33, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_Einzelansicht
            // 
            this.btn_Einzelansicht.Location = new System.Drawing.Point(22, 49);
            this.btn_Einzelansicht.Name = "btn_Einzelansicht";
            this.btn_Einzelansicht.Size = new System.Drawing.Size(88, 23);
            this.btn_Einzelansicht.TabIndex = 1;
            this.btn_Einzelansicht.Text = "Einzelansicht";
            this.btn_Einzelansicht.UseVisualStyleBackColor = true;
            this.btn_Einzelansicht.Click += new System.EventHandler(this.btn_Einzelansicht_Click);
            // 
            // btn_Kundenliste
            // 
            this.btn_Kundenliste.Location = new System.Drawing.Point(22, 19);
            this.btn_Kundenliste.Name = "btn_Kundenliste";
            this.btn_Kundenliste.Size = new System.Drawing.Size(88, 23);
            this.btn_Kundenliste.TabIndex = 0;
            this.btn_Kundenliste.Text = "Kundenliste";
            this.btn_Kundenliste.UseVisualStyleBackColor = true;
            this.btn_Kundenliste.Click += new System.EventHandler(this.btn_Kundenliste_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_FahrzeugEinzeln);
            this.groupBox2.Controls.Add(this.btn_Fahrzeugliste);
            this.groupBox2.Location = new System.Drawing.Point(282, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_Fahrzeugliste
            // 
            this.btn_Fahrzeugliste.Location = new System.Drawing.Point(43, 19);
            this.btn_Fahrzeugliste.Name = "btn_Fahrzeugliste";
            this.btn_Fahrzeugliste.Size = new System.Drawing.Size(126, 23);
            this.btn_Fahrzeugliste.TabIndex = 0;
            this.btn_Fahrzeugliste.Text = "Fahrzeugliste";
            this.btn_Fahrzeugliste.UseVisualStyleBackColor = true;
            this.btn_Fahrzeugliste.Click += new System.EventHandler(this.btn_Fahrzeugliste_Click);
            // 
            // btn_FahrzeugEinzeln
            // 
            this.btn_FahrzeugEinzeln.Location = new System.Drawing.Point(43, 48);
            this.btn_FahrzeugEinzeln.Name = "btn_FahrzeugEinzeln";
            this.btn_FahrzeugEinzeln.Size = new System.Drawing.Size(126, 23);
            this.btn_FahrzeugEinzeln.TabIndex = 0;
            this.btn_FahrzeugEinzeln.Text = "Fahrzeug Einzeln";
            this.btn_FahrzeugEinzeln.UseVisualStyleBackColor = true;
            this.btn_FahrzeugEinzeln.Click += new System.EventHandler(this.btn_FahrzeugEinzeln_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Kundenliste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Einzelansicht;
        private System.Windows.Forms.Button btn_FahrzeugEinzeln;
        private System.Windows.Forms.Button btn_Fahrzeugliste;
    }
}

