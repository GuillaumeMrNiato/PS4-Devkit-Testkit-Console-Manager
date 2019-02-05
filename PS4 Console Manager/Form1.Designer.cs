namespace PS4_Console_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cTabControl1 = new cTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cButton8 = new cButton();
            this.cButton7 = new cButton();
            this.cButton6 = new cButton();
            this.cButton5 = new cButton();
            this.cButton4 = new cButton();
            this.cButton3 = new cButton();
            this.cButton2 = new cButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cTextBox1 = new cTextBox();
            this.cButton1 = new cButton();
            this.cButton9 = new cButton();
            this.cTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Package|*.pkg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cTabControl1
            // 
            this.cTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.cTabControl1.Controls.Add(this.tabPage1);
            this.cTabControl1.ItemSize = new System.Drawing.Size(40, 170);
            this.cTabControl1.Location = new System.Drawing.Point(1, 0);
            this.cTabControl1.Multiline = true;
            this.cTabControl1.Name = "cTabControl1";
            this.cTabControl1.SelectedIndex = 0;
            this.cTabControl1.Size = new System.Drawing.Size(673, 453);
            this.cTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.cTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.tabPage1.Controls.Add(this.cButton9);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cButton6);
            this.tabPage1.Controls.Add(this.cButton5);
            this.tabPage1.Controls.Add(this.cButton4);
            this.tabPage1.Controls.Add(this.cButton3);
            this.tabPage1.Controls.Add(this.cButton2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cTextBox1);
            this.tabPage1.Controls.Add(this.cButton1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tabPage1.Location = new System.Drawing.Point(174, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Playstation 4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cButton8);
            this.groupBox2.Controls.Add(this.cButton7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(147, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 82);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notifications";
            // 
            // cButton8
            // 
            this.cButton8.Location = new System.Drawing.Point(6, 51);
            this.cButton8.Name = "cButton8";
            this.cButton8.Scheme = cButton.Schemes.Black;
            this.cButton8.Size = new System.Drawing.Size(188, 23);
            this.cButton8.TabIndex = 11;
            this.cButton8.Text = "Disconnect for Notifications";
            this.cButton8.UseVisualStyleBackColor = true;
            this.cButton8.Click += new System.EventHandler(this.cButton8_Click);
            // 
            // cButton7
            // 
            this.cButton7.Location = new System.Drawing.Point(6, 22);
            this.cButton7.Name = "cButton7";
            this.cButton7.Scheme = cButton.Schemes.Black;
            this.cButton7.Size = new System.Drawing.Size(188, 23);
            this.cButton7.TabIndex = 10;
            this.cButton7.Text = "Connect for Notifications";
            this.cButton7.UseVisualStyleBackColor = true;
            this.cButton7.Click += new System.EventHandler(this.cButton7_Click);
            // 
            // cButton6
            // 
            this.cButton6.Location = new System.Drawing.Point(46, 412);
            this.cButton6.Name = "cButton6";
            this.cButton6.Scheme = cButton.Schemes.Black;
            this.cButton6.Size = new System.Drawing.Size(202, 23);
            this.cButton6.TabIndex = 9;
            this.cButton6.Text = "Clear Console Cache";
            this.cButton6.UseVisualStyleBackColor = true;
            this.cButton6.Click += new System.EventHandler(this.cButton6_Click);
            // 
            // cButton5
            // 
            this.cButton5.Location = new System.Drawing.Point(358, 386);
            this.cButton5.Name = "cButton5";
            this.cButton5.Scheme = cButton.Schemes.Black;
            this.cButton5.Size = new System.Drawing.Size(98, 23);
            this.cButton5.TabIndex = 8;
            this.cButton5.Text = "Disconnect";
            this.cButton5.UseVisualStyleBackColor = true;
            this.cButton5.Click += new System.EventHandler(this.cButton5_Click);
            // 
            // cButton4
            // 
            this.cButton4.Location = new System.Drawing.Point(254, 386);
            this.cButton4.Name = "cButton4";
            this.cButton4.Scheme = cButton.Schemes.Black;
            this.cButton4.Size = new System.Drawing.Size(98, 23);
            this.cButton4.TabIndex = 7;
            this.cButton4.Text = "Reboot Console";
            this.cButton4.UseVisualStyleBackColor = true;
            this.cButton4.Click += new System.EventHandler(this.cButton4_Click);
            // 
            // cButton3
            // 
            this.cButton3.Location = new System.Drawing.Point(150, 386);
            this.cButton3.Name = "cButton3";
            this.cButton3.Scheme = cButton.Schemes.Black;
            this.cButton3.Size = new System.Drawing.Size(98, 23);
            this.cButton3.TabIndex = 6;
            this.cButton3.Text = "Turn On Console";
            this.cButton3.UseVisualStyleBackColor = true;
            this.cButton3.Click += new System.EventHandler(this.cButton3_Click);
            // 
            // cButton2
            // 
            this.cButton2.Location = new System.Drawing.Point(46, 386);
            this.cButton2.Name = "cButton2";
            this.cButton2.Scheme = cButton.Schemes.Black;
            this.cButton2.Size = new System.Drawing.Size(98, 23);
            this.cButton2.TabIndex = 5;
            this.cButton2.Text = "Turn Off Console";
            this.cButton2.UseVisualStyleBackColor = true;
            this.cButton2.Click += new System.EventHandler(this.cButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(415, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "???";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(259, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 15);
            this.label19.TabIndex = 24;
            this.label19.Text = "Case Sensitive File Serving :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 137);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 15);
            this.label20.TabIndex = 23;
            this.label20.Text = "???";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 15);
            this.label21.TabIndex = 22;
            this.label21.Text = "Is Busy ? :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(110, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "???";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Default Console :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "???";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Power :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(131, 161);
            this.label10.Name = "label10";
            this.label10.ReadOnly = true;
            this.label10.Size = new System.Drawing.Size(121, 23);
            this.label10.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Expiry Time :";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(388, 75);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(85, 23);
            this.numericUpDown3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(131, 186);
            this.label8.Name = "label8";
            this.label8.ReadOnly = true;
            this.label8.Size = new System.Drawing.Size(342, 23);
            this.label8.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Console Cache Size :";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(388, 46);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 23);
            this.numericUpDown2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Get Connection Info :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Console Cache Index :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(388, 17);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "File Serving Root :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "HostName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(117, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP :";
            // 
            // cTextBox1
            // 
            this.cTextBox1.Location = new System.Drawing.Point(147, 9);
            this.cTextBox1.MaxLength = 32767;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Scheme = cTextBox.Schemes.Black;
            this.cTextBox1.Size = new System.Drawing.Size(184, 30);
            this.cTextBox1.TabIndex = 1;
            this.cTextBox1.Text = "192.168.137.212";
            this.cTextBox1.UseSystemPasswordChar = false;
            // 
            // cButton1
            // 
            this.cButton1.Location = new System.Drawing.Point(147, 45);
            this.cButton1.Name = "cButton1";
            this.cButton1.Scheme = cButton.Schemes.Black;
            this.cButton1.Size = new System.Drawing.Size(184, 23);
            this.cButton1.TabIndex = 0;
            this.cButton1.Text = "Connect";
            this.cButton1.UseVisualStyleBackColor = true;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // cButton9
            // 
            this.cButton9.Location = new System.Drawing.Point(254, 412);
            this.cButton9.Name = "cButton9";
            this.cButton9.Scheme = cButton.Schemes.Black;
            this.cButton9.Size = new System.Drawing.Size(202, 23);
            this.cButton9.TabIndex = 11;
            this.cButton9.Text = "Delete Console";
            this.cButton9.UseVisualStyleBackColor = true;
            this.cButton9.Click += new System.EventHandler(this.cButton9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 451);
            this.Controls.Add(this.cTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Playstation 4 Console Manager By MrNiato";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private cTabControl cTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private cButton cButton1;
        private cTextBox cTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox label10;
        private cButton cButton2;
        private cButton cButton3;
        private cButton cButton4;
        private cButton cButton5;
        private cButton cButton6;
        private System.Windows.Forms.GroupBox groupBox2;
        private cButton cButton7;
        private cButton cButton8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private cButton cButton9;
    }
}

