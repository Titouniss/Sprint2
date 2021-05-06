namespace LoupGarou
{
    partial class Plateforme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_RSalle = new System.Windows.Forms.RadioButton();
            this.rb_Osalle = new System.Windows.Forms.RadioButton();
            this.P_OSalle = new System.Windows.Forms.Panel();
            this.p_RSalle = new System.Windows.Forms.Panel();
            this.Tc_Client = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_forumL = new System.Windows.Forms.GroupBox();
            this.gb_forumV = new System.Windows.Forms.GroupBox();
            this.Gb_Vote = new System.Windows.Forms.GroupBox();
            this.gb_Narration = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gb_reseau = new System.Windows.Forms.GroupBox();
            this.tb_AdresseSOS = new System.Windows.Forms.TextBox();
            this.tb_PortPOS = new System.Windows.Forms.TextBox();
            this.tb_Capacite = new System.Windows.Forms.TextBox();
            this.tb_AdresseSRS = new System.Windows.Forms.TextBox();
            this.tb_PortCRs = new System.Windows.Forms.TextBox();
            this.tb_AdresseCRS = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.l_Narration = new System.Windows.Forms.Label();
            this.lb_lesMessagesFV = new System.Windows.Forms.ListBox();
            this.lb_lesMessagesFL = new System.Windows.Forms.ListBox();
            this.lb_lesMessagesR = new System.Windows.Forms.ListBox();
            this.cb_Vote = new System.Windows.Forms.ComboBox();
            this.tb_leMessageFV = new System.Windows.Forms.TextBox();
            this.tb_leMessageFL = new System.Windows.Forms.TextBox();
            this.tb_leMessageR = new System.Windows.Forms.TextBox();
            this.bt_ = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.P_OSalle.SuspendLayout();
            this.p_RSalle.SuspendLayout();
            this.Tc_Client.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_forumL.SuspendLayout();
            this.gb_forumV.SuspendLayout();
            this.Gb_Vote.SuspendLayout();
            this.gb_Narration.SuspendLayout();
            this.gb_reseau.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_RSalle
            // 
            this.rb_RSalle.AutoSize = true;
            this.rb_RSalle.Location = new System.Drawing.Point(36, 143);
            this.rb_RSalle.Name = "rb_RSalle";
            this.rb_RSalle.Size = new System.Drawing.Size(151, 21);
            this.rb_RSalle.TabIndex = 0;
            this.rb_RSalle.TabStop = true;
            this.rb_RSalle.Text = "Rejoindre une salle";
            this.rb_RSalle.UseVisualStyleBackColor = true;
            this.rb_RSalle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Osalle
            // 
            this.rb_Osalle.AutoSize = true;
            this.rb_Osalle.Location = new System.Drawing.Point(36, 27);
            this.rb_Osalle.Name = "rb_Osalle";
            this.rb_Osalle.Size = new System.Drawing.Size(165, 21);
            this.rb_Osalle.TabIndex = 1;
            this.rb_Osalle.TabStop = true;
            this.rb_Osalle.Text = "Ouverture d\'une salle";
            this.rb_Osalle.UseVisualStyleBackColor = true;
            this.rb_Osalle.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // P_OSalle
            // 
            this.P_OSalle.Controls.Add(this.tb_Capacite);
            this.P_OSalle.Controls.Add(this.tb_PortPOS);
            this.P_OSalle.Controls.Add(this.tb_AdresseSOS);
            this.P_OSalle.Location = new System.Drawing.Point(36, 63);
            this.P_OSalle.Name = "P_OSalle";
            this.P_OSalle.Size = new System.Drawing.Size(496, 74);
            this.P_OSalle.TabIndex = 2;
            // 
            // p_RSalle
            // 
            this.p_RSalle.Controls.Add(this.tb_Login);
            this.p_RSalle.Controls.Add(this.tb_AdresseCRS);
            this.p_RSalle.Controls.Add(this.tb_PortCRs);
            this.p_RSalle.Controls.Add(this.tb_AdresseSRS);
            this.p_RSalle.Location = new System.Drawing.Point(36, 170);
            this.p_RSalle.Name = "p_RSalle";
            this.p_RSalle.Size = new System.Drawing.Size(608, 75);
            this.p_RSalle.TabIndex = 3;
            // 
            // Tc_Client
            // 
            this.Tc_Client.Controls.Add(this.tabPage1);
            this.Tc_Client.Controls.Add(this.tabPage2);
            this.Tc_Client.Controls.Add(this.tabPage3);
            this.Tc_Client.Location = new System.Drawing.Point(12, 297);
            this.Tc_Client.Name = "Tc_Client";
            this.Tc_Client.SelectedIndex = 0;
            this.Tc_Client.Size = new System.Drawing.Size(771, 283);
            this.Tc_Client.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_forumL);
            this.tabPage1.Controls.Add(this.gb_forumV);
            this.tabPage1.Controls.Add(this.Gb_Vote);
            this.tabPage1.Controls.Add(this.gb_Narration);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_forumL
            // 
            this.gb_forumL.Controls.Add(this.bt_4);
            this.gb_forumL.Controls.Add(this.tb_leMessageFL);
            this.gb_forumL.Controls.Add(this.lb_lesMessagesFL);
            this.gb_forumL.Location = new System.Drawing.Point(551, 26);
            this.gb_forumL.Name = "gb_forumL";
            this.gb_forumL.Size = new System.Drawing.Size(183, 213);
            this.gb_forumL.TabIndex = 8;
            this.gb_forumL.TabStop = false;
            this.gb_forumL.Text = "Forum Des Loups";
            // 
            // gb_forumV
            // 
            this.gb_forumV.Controls.Add(this.bt_3);
            this.gb_forumV.Controls.Add(this.tb_leMessageFV);
            this.gb_forumV.Controls.Add(this.lb_lesMessagesFV);
            this.gb_forumV.Location = new System.Drawing.Point(346, 25);
            this.gb_forumV.Name = "gb_forumV";
            this.gb_forumV.Size = new System.Drawing.Size(183, 213);
            this.gb_forumV.TabIndex = 7;
            this.gb_forumV.TabStop = false;
            this.gb_forumV.Text = "Forum Des Villageois";
            // 
            // Gb_Vote
            // 
            this.Gb_Vote.Controls.Add(this.bt_2);
            this.Gb_Vote.Controls.Add(this.cb_Vote);
            this.Gb_Vote.Location = new System.Drawing.Point(20, 139);
            this.Gb_Vote.Name = "Gb_Vote";
            this.Gb_Vote.Size = new System.Drawing.Size(293, 100);
            this.Gb_Vote.TabIndex = 6;
            this.Gb_Vote.TabStop = false;
            this.Gb_Vote.Text = "Vote";
            // 
            // gb_Narration
            // 
            this.gb_Narration.Controls.Add(this.l_Narration);
            this.gb_Narration.Location = new System.Drawing.Point(20, 26);
            this.gb_Narration.Name = "gb_Narration";
            this.gb_Narration.Size = new System.Drawing.Size(293, 100);
            this.gb_Narration.TabIndex = 5;
            this.gb_Narration.TabStop = false;
            this.gb_Narration.Text = "Histoire";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(702, 283);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gb_reseau
            // 
            this.gb_reseau.BackColor = System.Drawing.Color.Transparent;
            this.gb_reseau.Controls.Add(this.bt_5);
            this.gb_reseau.Controls.Add(this.tb_leMessageR);
            this.gb_reseau.Controls.Add(this.lb_lesMessagesR);
            this.gb_reseau.Location = new System.Drawing.Point(821, 27);
            this.gb_reseau.Name = "gb_reseau";
            this.gb_reseau.Size = new System.Drawing.Size(206, 553);
            this.gb_reseau.TabIndex = 5;
            this.gb_reseau.TabStop = false;
            this.gb_reseau.Text = "Test Reseau";
            // 
            // tb_AdresseSOS
            // 
            this.tb_AdresseSOS.Location = new System.Drawing.Point(41, 27);
            this.tb_AdresseSOS.Name = "tb_AdresseSOS";
            this.tb_AdresseSOS.Size = new System.Drawing.Size(162, 22);
            this.tb_AdresseSOS.TabIndex = 0;
            this.tb_AdresseSOS.Text = "Adresse du serveur";
            this.tb_AdresseSOS.TextChanged += new System.EventHandler(this.tb_AdresseSOS_TextChanged);
            // 
            // tb_PortPOS
            // 
            this.tb_PortPOS.Location = new System.Drawing.Point(226, 27);
            this.tb_PortPOS.Name = "tb_PortPOS";
            this.tb_PortPOS.Size = new System.Drawing.Size(100, 22);
            this.tb_PortPOS.TabIndex = 1;
            this.tb_PortPOS.Text = "Port";
            // 
            // tb_Capacite
            // 
            this.tb_Capacite.Location = new System.Drawing.Point(368, 27);
            this.tb_Capacite.Name = "tb_Capacite";
            this.tb_Capacite.Size = new System.Drawing.Size(100, 22);
            this.tb_Capacite.TabIndex = 2;
            this.tb_Capacite.Text = "Capacité";
            this.tb_Capacite.TextChanged += new System.EventHandler(this.tb_Capacite_TextChanged);
            // 
            // tb_AdresseSRS
            // 
            this.tb_AdresseSRS.Location = new System.Drawing.Point(41, 30);
            this.tb_AdresseSRS.Name = "tb_AdresseSRS";
            this.tb_AdresseSRS.Size = new System.Drawing.Size(149, 22);
            this.tb_AdresseSRS.TabIndex = 0;
            this.tb_AdresseSRS.Text = "Adresse Serveur";
            this.tb_AdresseSRS.TextChanged += new System.EventHandler(this.tb_AdresseSRS_TextChanged);
            // 
            // tb_PortCRs
            // 
            this.tb_PortCRs.Location = new System.Drawing.Point(209, 30);
            this.tb_PortCRs.Name = "tb_PortCRs";
            this.tb_PortCRs.Size = new System.Drawing.Size(100, 22);
            this.tb_PortCRs.TabIndex = 1;
            this.tb_PortCRs.Text = "Port";
            // 
            // tb_AdresseCRS
            // 
            this.tb_AdresseCRS.Location = new System.Drawing.Point(335, 30);
            this.tb_AdresseCRS.Name = "tb_AdresseCRS";
            this.tb_AdresseCRS.Size = new System.Drawing.Size(121, 22);
            this.tb_AdresseCRS.TabIndex = 2;
            this.tb_AdresseCRS.Text = "Adresse client";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(476, 30);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(100, 22);
            this.tb_Login.TabIndex = 3;
            this.tb_Login.Tag = "";
            this.tb_Login.Text = "Login";
            // 
            // l_Narration
            // 
            this.l_Narration.Location = new System.Drawing.Point(14, 32);
            this.l_Narration.Name = "l_Narration";
            this.l_Narration.Size = new System.Drawing.Size(255, 65);
            this.l_Narration.TabIndex = 0;
            this.l_Narration.Text = "blabla";
            this.l_Narration.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_lesMessagesFV
            // 
            this.lb_lesMessagesFV.FormattingEnabled = true;
            this.lb_lesMessagesFV.ItemHeight = 16;
            this.lb_lesMessagesFV.Location = new System.Drawing.Point(9, 22);
            this.lb_lesMessagesFV.Name = "lb_lesMessagesFV";
            this.lb_lesMessagesFV.Size = new System.Drawing.Size(161, 116);
            this.lb_lesMessagesFV.TabIndex = 0;
            // 
            // lb_lesMessagesFL
            // 
            this.lb_lesMessagesFL.FormattingEnabled = true;
            this.lb_lesMessagesFL.ItemHeight = 16;
            this.lb_lesMessagesFL.Location = new System.Drawing.Point(14, 21);
            this.lb_lesMessagesFL.Name = "lb_lesMessagesFL";
            this.lb_lesMessagesFL.Size = new System.Drawing.Size(150, 116);
            this.lb_lesMessagesFL.TabIndex = 0;
            // 
            // lb_lesMessagesR
            // 
            this.lb_lesMessagesR.FormattingEnabled = true;
            this.lb_lesMessagesR.ItemHeight = 16;
            this.lb_lesMessagesR.Location = new System.Drawing.Point(23, 36);
            this.lb_lesMessagesR.Name = "lb_lesMessagesR";
            this.lb_lesMessagesR.Size = new System.Drawing.Size(160, 404);
            this.lb_lesMessagesR.TabIndex = 0;
            // 
            // cb_Vote
            // 
            this.cb_Vote.FormattingEnabled = true;
            this.cb_Vote.Location = new System.Drawing.Point(17, 28);
            this.cb_Vote.Name = "cb_Vote";
            this.cb_Vote.Size = new System.Drawing.Size(223, 24);
            this.cb_Vote.TabIndex = 0;
            this.cb_Vote.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_leMessageFV
            // 
            this.tb_leMessageFV.Location = new System.Drawing.Point(9, 144);
            this.tb_leMessageFV.Name = "tb_leMessageFV";
            this.tb_leMessageFV.Size = new System.Drawing.Size(161, 22);
            this.tb_leMessageFV.TabIndex = 1;
            // 
            // tb_leMessageFL
            // 
            this.tb_leMessageFL.Location = new System.Drawing.Point(14, 143);
            this.tb_leMessageFL.Name = "tb_leMessageFL";
            this.tb_leMessageFL.Size = new System.Drawing.Size(150, 22);
            this.tb_leMessageFL.TabIndex = 1;
            this.tb_leMessageFL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_leMessageR
            // 
            this.tb_leMessageR.Location = new System.Drawing.Point(23, 451);
            this.tb_leMessageR.Name = "tb_leMessageR";
            this.tb_leMessageR.Size = new System.Drawing.Size(160, 22);
            this.tb_leMessageR.TabIndex = 1;
            // 
            // bt_
            // 
            this.bt_.Location = new System.Drawing.Point(229, 252);
            this.bt_.Name = "bt_";
            this.bt_.Size = new System.Drawing.Size(75, 23);
            this.bt_.TabIndex = 6;
            this.bt_.Text = "VALIDER";
            this.bt_.UseVisualStyleBackColor = true;
            this.bt_.Click += new System.EventHandler(this.bt__Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(90, 58);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(75, 23);
            this.bt_2.TabIndex = 1;
            this.bt_2.Text = "VALIDER";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(55, 172);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(75, 23);
            this.bt_3.TabIndex = 2;
            this.bt_3.Text = "VALIDER";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(47, 171);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(75, 23);
            this.bt_4.TabIndex = 2;
            this.bt_4.Text = "VALIDER";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(57, 503);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(75, 23);
            this.bt_5.TabIndex = 2;
            this.bt_5.Text = "VALIDER";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // Plateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 596);
            this.Controls.Add(this.bt_);
            this.Controls.Add(this.gb_reseau);
            this.Controls.Add(this.Tc_Client);
            this.Controls.Add(this.p_RSalle);
            this.Controls.Add(this.P_OSalle);
            this.Controls.Add(this.rb_Osalle);
            this.Controls.Add(this.rb_RSalle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plateforme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Plateforme_Load);
            this.P_OSalle.ResumeLayout(false);
            this.P_OSalle.PerformLayout();
            this.p_RSalle.ResumeLayout(false);
            this.p_RSalle.PerformLayout();
            this.Tc_Client.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_forumL.ResumeLayout(false);
            this.gb_forumL.PerformLayout();
            this.gb_forumV.ResumeLayout(false);
            this.gb_forumV.PerformLayout();
            this.Gb_Vote.ResumeLayout(false);
            this.gb_Narration.ResumeLayout(false);
            this.gb_reseau.ResumeLayout(false);
            this.gb_reseau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_RSalle;
        private System.Windows.Forms.RadioButton rb_Osalle;
        private System.Windows.Forms.Panel P_OSalle;
        private System.Windows.Forms.Panel p_RSalle;
        private System.Windows.Forms.TabControl Tc_Client;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gb_forumL;
        private System.Windows.Forms.GroupBox gb_forumV;
        private System.Windows.Forms.GroupBox Gb_Vote;
        private System.Windows.Forms.GroupBox gb_Narration;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gb_reseau;
        private System.Windows.Forms.TextBox tb_Capacite;
        private System.Windows.Forms.TextBox tb_PortPOS;
        private System.Windows.Forms.TextBox tb_AdresseSOS;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_AdresseCRS;
        private System.Windows.Forms.TextBox tb_PortCRs;
        private System.Windows.Forms.TextBox tb_AdresseSRS;
        private System.Windows.Forms.Label l_Narration;
        private System.Windows.Forms.ListBox lb_lesMessagesFL;
        private System.Windows.Forms.ListBox lb_lesMessagesFV;
        private System.Windows.Forms.ListBox lb_lesMessagesR;
        private System.Windows.Forms.ComboBox cb_Vote;
        private System.Windows.Forms.TextBox tb_leMessageFL;
        private System.Windows.Forms.TextBox tb_leMessageFV;
        private System.Windows.Forms.TextBox tb_leMessageR;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_;
    }
}

