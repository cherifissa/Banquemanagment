namespace Banquemanagment.views
{
    partial class CreateCompte
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCompteEVP = new System.Windows.Forms.RadioButton();
            this.rdbCompteEnrteprie = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbCompteCourant = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdesses = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTypepiece = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPiece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtSoldeinitial = new System.Windows.Forms.TextBox();
            this.txtCodeSecret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSeuilDecouvert = new System.Windows.Forms.TextBox();
            this.txtNumeroGuichet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPeriodeVersement = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remplissez le formulaire suivant";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCompteEVP);
            this.groupBox1.Controls.Add(this.rdbCompteEnrteprie);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdbCompteCourant);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de Compte";
            // 
            // rdCompteEVP
            // 
            this.rdCompteEVP.AutoSize = true;
            this.rdCompteEVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCompteEVP.Location = new System.Drawing.Point(189, 43);
            this.rdCompteEVP.Name = "rdCompteEVP";
            this.rdCompteEVP.Size = new System.Drawing.Size(103, 20);
            this.rdCompteEVP.TabIndex = 4;
            this.rdCompteEVP.TabStop = true;
            this.rdCompteEVP.Text = "Compte EVP";
            this.rdCompteEVP.UseVisualStyleBackColor = true;
            this.rdCompteEVP.CheckedChanged += new System.EventHandler(this.rdCompteEVP_CheckedChanged);
            // 
            // rdbCompteEnrteprie
            // 
            this.rdbCompteEnrteprie.AutoSize = true;
            this.rdbCompteEnrteprie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompteEnrteprie.Location = new System.Drawing.Point(757, 43);
            this.rdbCompteEnrteprie.Name = "rdbCompteEnrteprie";
            this.rdbCompteEnrteprie.Size = new System.Drawing.Size(137, 20);
            this.rdbCompteEnrteprie.TabIndex = 3;
            this.rdbCompteEnrteprie.TabStop = true;
            this.rdbCompteEnrteprie.Text = "Compte Entreprise";
            this.rdbCompteEnrteprie.UseVisualStyleBackColor = true;
            this.rdbCompteEnrteprie.CheckedChanged += new System.EventHandler(this.rdCompteEntreprise_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(564, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Compte Bloqué";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rdCompteBloque_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(372, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Compte Découvert";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rdCompteDecouvert_CheckedChanged);
            // 
            // rdbCompteCourant
            // 
            this.rdbCompteCourant.AutoSize = true;
            this.rdbCompteCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompteCourant.Location = new System.Drawing.Point(28, 43);
            this.rdbCompteCourant.Name = "rdbCompteCourant";
            this.rdbCompteCourant.Size = new System.Drawing.Size(122, 20);
            this.rdbCompteCourant.TabIndex = 0;
            this.rdbCompteCourant.TabStop = true;
            this.rdbCompteCourant.Text = "Compte Courant";
            this.rdbCompteCourant.UseVisualStyleBackColor = true;
            this.rdbCompteCourant.CheckedChanged += new System.EventHandler(this.rbCompteCourant_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdesses);
            this.groupBox2.Controls.Add(this.txtAdresse);
            this.groupBox2.Controls.Add(this.txtTelephone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrenom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbTypepiece);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNumeroPiece);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "identiiant du itulaire";
            // 
            // txtAdesses
            // 
            this.txtAdesses.Location = new System.Drawing.Point(189, 304);
            this.txtAdesses.Name = "txtAdesses";
            this.txtAdesses.Size = new System.Drawing.Size(250, 22);
            this.txtAdesses.TabIndex = 12;
            // 
            // txtAdresse
            // 
            this.txtAdresse.AutoSize = true;
            this.txtAdresse.Location = new System.Drawing.Point(17, 307);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(66, 16);
            this.txtAdresse.TabIndex = 11;
            this.txtAdresse.Text = "Adresse";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(189, 251);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(250, 22);
            this.txtTelephone.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telephone";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(189, 198);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(250, 22);
            this.txtPrenom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prenon";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(189, 148);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(250, 22);
            this.txtNom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom*";
            // 
            // cmbTypepiece
            // 
            this.cmbTypepiece.FormattingEnabled = true;
            this.cmbTypepiece.Location = new System.Drawing.Point(189, 92);
            this.cmbTypepiece.Name = "cmbTypepiece";
            this.cmbTypepiece.Size = new System.Drawing.Size(250, 24);
            this.cmbTypepiece.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type de piêce*";
            // 
            // txtNumeroPiece
            // 
            this.txtNumeroPiece.Location = new System.Drawing.Point(189, 45);
            this.txtNumeroPiece.Name = "txtNumeroPiece";
            this.txtNumeroPiece.Size = new System.Drawing.Size(250, 22);
            this.txtNumeroPiece.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero du piêce";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtDate);
            this.groupBox3.Controls.Add(this.txtSoldeinitial);
            this.groupBox3.Controls.Add(this.txtCodeSecret);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtSeuilDecouvert);
            this.groupBox3.Controls.Add(this.txtNumeroGuichet);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPeriodeVersement);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(554, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 426);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "information du compte";
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(188, 305);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(250, 22);
            this.dtDate.TabIndex = 26;
            this.dtDate.Value = new System.DateTime(2023, 5, 2, 16, 51, 36, 0);
            // 
            // txtSoldeinitial
            // 
            this.txtSoldeinitial.Location = new System.Drawing.Point(188, 97);
            this.txtSoldeinitial.Name = "txtSoldeinitial";
            this.txtSoldeinitial.Size = new System.Drawing.Size(250, 22);
            this.txtSoldeinitial.TabIndex = 25;
            // 
            // txtCodeSecret
            // 
            this.txtCodeSecret.Location = new System.Drawing.Point(188, 148);
            this.txtCodeSecret.Name = "txtCodeSecret";
            this.txtCodeSecret.Size = new System.Drawing.Size(250, 22);
            this.txtCodeSecret.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Date de délocage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Numero de guichet";
            // 
            // txtSeuilDecouvert
            // 
            this.txtSeuilDecouvert.Location = new System.Drawing.Point(188, 251);
            this.txtSeuilDecouvert.Name = "txtSeuilDecouvert";
            this.txtSeuilDecouvert.Size = new System.Drawing.Size(250, 22);
            this.txtSeuilDecouvert.TabIndex = 22;
            // 
            // txtNumeroGuichet
            // 
            this.txtNumeroGuichet.Location = new System.Drawing.Point(188, 45);
            this.txtNumeroGuichet.Name = "txtNumeroGuichet";
            this.txtNumeroGuichet.Size = new System.Drawing.Size(250, 22);
            this.txtNumeroGuichet.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Seuil de decouvert";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Soldei initial*";
            // 
            // txtPeriodeVersement
            // 
            this.txtPeriodeVersement.Location = new System.Drawing.Point(188, 198);
            this.txtPeriodeVersement.Name = "txtPeriodeVersement";
            this.txtPeriodeVersement.Size = new System.Drawing.Size(250, 22);
            this.txtPeriodeVersement.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Périodede versement";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Code secret";
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.Color.Lime;
            this.btnCreer.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(287, 656);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(151, 31);
            this.btnCreer.TabIndex = 4;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = false;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Red;
            this.btnFermer.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(634, 656);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(151, 31);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // CreateCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 712);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateCompte";
            this.Text = "CreateCompte";
            this.Load += new System.EventHandler(this.CreateCompte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCompteCourant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAdesses;
        private System.Windows.Forms.Label txtAdresse;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTypepiece;
        private System.Windows.Forms.RadioButton rdCompteEVP;
        private System.Windows.Forms.RadioButton rdbCompteEnrteprie;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtSoldeinitial;
        private System.Windows.Forms.TextBox txtCodeSecret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSeuilDecouvert;
        private System.Windows.Forms.TextBox txtNumeroGuichet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPeriodeVersement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnFermer;
    }
}