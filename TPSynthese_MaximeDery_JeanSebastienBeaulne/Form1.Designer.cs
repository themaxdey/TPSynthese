﻿namespace TPSynthese_MaximeDery_JeanSebastienBeaulne
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxEmploye = new System.Windows.Forms.ListBox();
            this.listBoxMagasin = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSupprimerBD = new System.Windows.Forms.Button();
            this.buttonUpdateBD = new System.Windows.Forms.Button();
            this.buttonAjouterBD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNumeroEmploye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxNumTel = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.groupBoxMagasin = new System.Windows.Forms.GroupBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBoxPermanence = new System.Windows.Forms.GroupBox();
            this.radioButtonPermanenceNon = new System.Windows.Forms.RadioButton();
            this.radioButtonPermanenceOui = new System.Windows.Forms.RadioButton();
            this.groupBoxSexe = new System.Windows.Forms.GroupBox();
            this.radioButtonSexeFemme = new System.Windows.Forms.RadioButton();
            this.radioButtonSexeHomme = new System.Windows.Forms.RadioButton();
            this.groupBoxPoste = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitre = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxMagasin.SuspendLayout();
            this.groupBoxPermanence.SuspendLayout();
            this.groupBoxSexe.SuspendLayout();
            this.groupBoxPoste.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 526);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.TabControl_Click);
            this.tabControl1.Click += new System.EventHandler(this.TabControl_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonQuitter);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.buttonOuvrir);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxEmploye);
            this.tabPage1.Controls.Add(this.listBoxMagasin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualisation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(701, 460);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 7;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 460);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Exporter vers .txt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRechercher);
            this.groupBox1.Controls.Add(this.buttonSupprimer);
            this.groupBox1.Controls.Add(this.buttonModifier);
            this.groupBox1.Controls.Add(this.buttonAjouter);
            this.groupBox1.Location = new System.Drawing.Point(21, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 368);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(20, 159);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 3;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(20, 120);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(20, 79);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(20, 38);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(21, 34);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(136, 23);
            this.buttonOuvrir.TabIndex = 4;
            this.buttonOuvrir.Text = "Ouvrir base de donnee";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sélection de l\'employé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sélection du magasin :";
            // 
            // listBoxEmploye
            // 
            this.listBoxEmploye.FormattingEnabled = true;
            this.listBoxEmploye.Location = new System.Drawing.Point(540, 70);
            this.listBoxEmploye.Name = "listBoxEmploye";
            this.listBoxEmploye.Size = new System.Drawing.Size(236, 368);
            this.listBoxEmploye.TabIndex = 1;
            // 
            // listBoxMagasin
            // 
            this.listBoxMagasin.FormattingEnabled = true;
            this.listBoxMagasin.Location = new System.Drawing.Point(210, 70);
            this.listBoxMagasin.Name = "listBoxMagasin";
            this.listBoxMagasin.Size = new System.Drawing.Size(236, 368);
            this.listBoxMagasin.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSupprimerBD);
            this.tabPage2.Controls.Add(this.buttonUpdateBD);
            this.tabPage2.Controls.Add(this.buttonAjouterBD);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.labelNumeroEmploye);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxNom);
            this.tabPage2.Controls.Add(this.textBoxNumTel);
            this.tabPage2.Controls.Add(this.textBoxPrenom);
            this.tabPage2.Controls.Add(this.groupBoxMagasin);
            this.tabPage2.Controls.Add(this.groupBoxPermanence);
            this.tabPage2.Controls.Add(this.groupBoxSexe);
            this.tabPage2.Controls.Add(this.groupBoxPoste);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(837, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intéractions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerBD
            // 
            this.buttonSupprimerBD.Location = new System.Drawing.Point(643, 42);
            this.buttonSupprimerBD.Name = "buttonSupprimerBD";
            this.buttonSupprimerBD.Size = new System.Drawing.Size(113, 29);
            this.buttonSupprimerBD.TabIndex = 6;
            this.buttonSupprimerBD.Text = "Supprimer de la BD";
            this.buttonSupprimerBD.UseVisualStyleBackColor = true;
            this.buttonSupprimerBD.Visible = false;
            // 
            // buttonUpdateBD
            // 
            this.buttonUpdateBD.Location = new System.Drawing.Point(643, 42);
            this.buttonUpdateBD.Name = "buttonUpdateBD";
            this.buttonUpdateBD.Size = new System.Drawing.Size(113, 29);
            this.buttonUpdateBD.TabIndex = 6;
            this.buttonUpdateBD.Text = "Mise à jour de la BD";
            this.buttonUpdateBD.UseVisualStyleBackColor = true;
            this.buttonUpdateBD.Visible = false;
            // 
            // buttonAjouterBD
            // 
            this.buttonAjouterBD.Location = new System.Drawing.Point(643, 46);
            this.buttonAjouterBD.Name = "buttonAjouterBD";
            this.buttonAjouterBD.Size = new System.Drawing.Size(113, 29);
            this.buttonAjouterBD.TabIndex = 6;
            this.buttonAjouterBD.Text = "Ajouter dans la BD";
            this.buttonAjouterBD.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date d\'embauche";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date de naissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Commentaire :";
            // 
            // labelNumeroEmploye
            // 
            this.labelNumeroEmploye.AutoSize = true;
            this.labelNumeroEmploye.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEmploye.Location = new System.Drawing.Point(403, 82);
            this.labelNumeroEmploye.Name = "labelNumeroEmploye";
            this.labelNumeroEmploye.Size = new System.Drawing.Size(26, 15);
            this.labelNumeroEmploye.TabIndex = 14;
            this.labelNumeroEmploye.Text = "n/a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Employé # : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(508, 321);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 140);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(556, 244);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(556, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numéro de téléphone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prénom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(39, 100);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(161, 20);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxNumTel
            // 
            this.textBoxNumTel.Location = new System.Drawing.Point(322, 42);
            this.textBoxNumTel.Name = "textBoxNumTel";
            this.textBoxNumTel.Size = new System.Drawing.Size(146, 20);
            this.textBoxNumTel.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(39, 42);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(161, 20);
            this.textBoxPrenom.TabIndex = 1;
            // 
            // groupBoxMagasin
            // 
            this.groupBoxMagasin.Controls.Add(this.radioButton12);
            this.groupBoxMagasin.Controls.Add(this.radioButton11);
            this.groupBoxMagasin.Controls.Add(this.radioButton10);
            this.groupBoxMagasin.Controls.Add(this.radioButton9);
            this.groupBoxMagasin.Controls.Add(this.radioButton8);
            this.groupBoxMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMagasin.Location = new System.Drawing.Point(256, 165);
            this.groupBoxMagasin.Name = "groupBoxMagasin";
            this.groupBoxMagasin.Size = new System.Drawing.Size(189, 169);
            this.groupBoxMagasin.TabIndex = 3;
            this.groupBoxMagasin.TabStop = false;
            this.groupBoxMagasin.Text = "Magasin";
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12.Location = new System.Drawing.Point(8, 125);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(110, 19);
            this.radioButton12.TabIndex = 4;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "St-Martin, Laval";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(8, 102);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(155, 19);
            this.radioButton11.TabIndex = 3;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Ste-Catherine, Montréal";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(8, 79);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(137, 19);
            this.radioButton10.TabIndex = 2;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Rosemont, Montréal";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(8, 56);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(134, 19);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Haute-Ville, Québec";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(8, 33);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(118, 19);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "St-Roch, Québec";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // groupBoxPermanence
            // 
            this.groupBoxPermanence.Controls.Add(this.radioButtonPermanenceNon);
            this.groupBoxPermanence.Controls.Add(this.radioButtonPermanenceOui);
            this.groupBoxPermanence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPermanence.Location = new System.Drawing.Point(264, 359);
            this.groupBoxPermanence.Name = "groupBoxPermanence";
            this.groupBoxPermanence.Size = new System.Drawing.Size(181, 102);
            this.groupBoxPermanence.TabIndex = 2;
            this.groupBoxPermanence.TabStop = false;
            this.groupBoxPermanence.Text = "Permanence";
            // 
            // radioButtonPermanenceNon
            // 
            this.radioButtonPermanenceNon.AutoSize = true;
            this.radioButtonPermanenceNon.Location = new System.Drawing.Point(100, 45);
            this.radioButtonPermanenceNon.Name = "radioButtonPermanenceNon";
            this.radioButtonPermanenceNon.Size = new System.Drawing.Size(51, 20);
            this.radioButtonPermanenceNon.TabIndex = 1;
            this.radioButtonPermanenceNon.TabStop = true;
            this.radioButtonPermanenceNon.Text = "Non";
            this.radioButtonPermanenceNon.UseVisualStyleBackColor = true;
            // 
            // radioButtonPermanenceOui
            // 
            this.radioButtonPermanenceOui.AutoSize = true;
            this.radioButtonPermanenceOui.Location = new System.Drawing.Point(17, 45);
            this.radioButtonPermanenceOui.Name = "radioButtonPermanenceOui";
            this.radioButtonPermanenceOui.Size = new System.Drawing.Size(46, 20);
            this.radioButtonPermanenceOui.TabIndex = 0;
            this.radioButtonPermanenceOui.TabStop = true;
            this.radioButtonPermanenceOui.Text = "Oui";
            this.radioButtonPermanenceOui.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexe
            // 
            this.groupBoxSexe.Controls.Add(this.radioButtonSexeFemme);
            this.groupBoxSexe.Controls.Add(this.radioButtonSexeHomme);
            this.groupBoxSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSexe.Location = new System.Drawing.Point(48, 359);
            this.groupBoxSexe.Name = "groupBoxSexe";
            this.groupBoxSexe.Size = new System.Drawing.Size(139, 102);
            this.groupBoxSexe.TabIndex = 1;
            this.groupBoxSexe.TabStop = false;
            this.groupBoxSexe.Text = "Sexe";
            // 
            // radioButtonSexeFemme
            // 
            this.radioButtonSexeFemme.AutoSize = true;
            this.radioButtonSexeFemme.Location = new System.Drawing.Point(7, 67);
            this.radioButtonSexeFemme.Name = "radioButtonSexeFemme";
            this.radioButtonSexeFemme.Size = new System.Drawing.Size(72, 20);
            this.radioButtonSexeFemme.TabIndex = 1;
            this.radioButtonSexeFemme.TabStop = true;
            this.radioButtonSexeFemme.Text = "Femme";
            this.radioButtonSexeFemme.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexeHomme
            // 
            this.radioButtonSexeHomme.AutoSize = true;
            this.radioButtonSexeHomme.Location = new System.Drawing.Point(7, 33);
            this.radioButtonSexeHomme.Name = "radioButtonSexeHomme";
            this.radioButtonSexeHomme.Size = new System.Drawing.Size(74, 20);
            this.radioButtonSexeHomme.TabIndex = 0;
            this.radioButtonSexeHomme.TabStop = true;
            this.radioButtonSexeHomme.Text = "Homme";
            this.radioButtonSexeHomme.UseVisualStyleBackColor = true;
            // 
            // groupBoxPoste
            // 
            this.groupBoxPoste.Controls.Add(this.radioButton5);
            this.groupBoxPoste.Controls.Add(this.radioButton4);
            this.groupBoxPoste.Controls.Add(this.radioButton3);
            this.groupBoxPoste.Controls.Add(this.radioButton2);
            this.groupBoxPoste.Controls.Add(this.radioButton1);
            this.groupBoxPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPoste.Location = new System.Drawing.Point(48, 165);
            this.groupBoxPoste.Name = "groupBoxPoste";
            this.groupBoxPoste.Size = new System.Drawing.Size(139, 169);
            this.groupBoxPoste.TabIndex = 0;
            this.groupBoxPoste.TabStop = false;
            this.groupBoxPoste.Text = "Poste de l\'employé";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(6, 127);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(75, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Directeur";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(6, 103);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Gérant";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(6, 79);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Analyste";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Conseiller";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vendeur";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.enregistrementToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem,
            this.sauvegarderLaBaseDeDonnéesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirLaBaseDeDonnéesToolStripMenuItem
            // 
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Name = "ouvrirLaBaseDeDonnéesToolStripMenuItem";
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Text = "Ouvrir la base de données";
            this.ouvrirLaBaseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLaBaseDeDonnéesToolStripMenuItem_Click);
            // 
            // sauvegarderLaBaseDeDonnéesToolStripMenuItem
            // 
            this.sauvegarderLaBaseDeDonnéesToolStripMenuItem.Name = "sauvegarderLaBaseDeDonnéesToolStripMenuItem";
            this.sauvegarderLaBaseDeDonnéesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderLaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.sauvegarderLaBaseDeDonnéesToolStripMenuItem.Text = "Exporter vers un fichier texte";
            this.sauvegarderLaBaseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLaBaseDeDonnéesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // enregistrementToolStripMenuItem
            // 
            this.enregistrementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.enregistrementToolStripMenuItem.Name = "enregistrementToolStripMenuItem";
            this.enregistrementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.enregistrementToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.enregistrementToolStripMenuItem.Text = "Enregistrement";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(16, 28);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(56, 25);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Titre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 599);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DB Utilizer 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxMagasin.ResumeLayout(false);
            this.groupBoxMagasin.PerformLayout();
            this.groupBoxPermanence.ResumeLayout(false);
            this.groupBoxPermanence.PerformLayout();
            this.groupBoxSexe.ResumeLayout(false);
            this.groupBoxSexe.PerformLayout();
            this.groupBoxPoste.ResumeLayout(false);
            this.groupBoxPoste.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxMagasin;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.ListBox listBoxEmploye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOuvrir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxMagasin;
        private System.Windows.Forms.GroupBox groupBoxPermanence;
        private System.Windows.Forms.GroupBox groupBoxSexe;
        private System.Windows.Forms.GroupBox groupBoxPoste;
        private System.Windows.Forms.Label labelNumeroEmploye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxNumTel;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButtonPermanenceNon;
        private System.Windows.Forms.RadioButton radioButtonPermanenceOui;
        private System.Windows.Forms.RadioButton radioButtonSexeFemme;
        private System.Windows.Forms.RadioButton radioButtonSexeHomme;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimerBD;
        private System.Windows.Forms.Button buttonUpdateBD;
        private System.Windows.Forms.Button buttonAjouterBD;
    }
}

