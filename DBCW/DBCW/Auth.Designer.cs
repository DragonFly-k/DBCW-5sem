namespace Client
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registered = new System.Windows.Forms.Label();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.passwBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.adressBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.loginBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.phNumBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.fioBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.err = new System.Windows.Forms.Label();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.passwBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.loginBox7 = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(6, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 479);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.registered);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.passwBox5);
            this.tabPage1.Controls.Add(this.adressBox2);
            this.tabPage1.Controls.Add(this.loginBox4);
            this.tabPage1.Controls.Add(this.phNumBox3);
            this.tabPage1.Controls.Add(this.fioBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Регистрация";
            // 
            // registered
            // 
            this.registered.AutoSize = true;
            this.registered.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registered.ForeColor = System.Drawing.Color.Lime;
            this.registered.Location = new System.Drawing.Point(34, 316);
            this.registered.Name = "registered";
            this.registered.Size = new System.Drawing.Size(406, 32);
            this.registered.TabIndex = 40;
            this.registered.Text = "Регистрация прошла успешно!";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(155, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button1.Size = new System.Drawing.Size(191, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Зарегистрироваться";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(34, 248);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(34, 192);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Тел. номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "ФИО";
            // 
            // passwBox5
            // 
            this.passwBox5.AnimateReadOnly = false;
            this.passwBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwBox5.Depth = 0;
            this.passwBox5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwBox5.LeadingIcon = null;
            this.passwBox5.Location = new System.Drawing.Point(155, 246);
            this.passwBox5.MaxLength = 150;
            this.passwBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.passwBox5.Multiline = false;
            this.passwBox5.Name = "passwBox5";
            this.passwBox5.Size = new System.Drawing.Size(285, 50);
            this.passwBox5.TabIndex = 37;
            this.passwBox5.Text = "";
            this.passwBox5.TrailingIcon = null;
            // 
            // adressBox2
            // 
            this.adressBox2.AnimateReadOnly = false;
            this.adressBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressBox2.Depth = 0;
            this.adressBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.adressBox2.LeadingIcon = null;
            this.adressBox2.Location = new System.Drawing.Point(155, 78);
            this.adressBox2.MaxLength = 200;
            this.adressBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.adressBox2.Multiline = false;
            this.adressBox2.Name = "adressBox2";
            this.adressBox2.Size = new System.Drawing.Size(285, 50);
            this.adressBox2.TabIndex = 34;
            this.adressBox2.Text = "";
            this.adressBox2.TrailingIcon = null;
            // 
            // loginBox4
            // 
            this.loginBox4.AnimateReadOnly = false;
            this.loginBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox4.Depth = 0;
            this.loginBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginBox4.LeadingIcon = null;
            this.loginBox4.Location = new System.Drawing.Point(155, 190);
            this.loginBox4.MaxLength = 150;
            this.loginBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.loginBox4.Multiline = false;
            this.loginBox4.Name = "loginBox4";
            this.loginBox4.Size = new System.Drawing.Size(285, 50);
            this.loginBox4.TabIndex = 36;
            this.loginBox4.Text = "";
            this.loginBox4.TrailingIcon = null;
            // 
            // phNumBox3
            // 
            this.phNumBox3.AnimateReadOnly = false;
            this.phNumBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phNumBox3.Depth = 0;
            this.phNumBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phNumBox3.LeadingIcon = null;
            this.phNumBox3.Location = new System.Drawing.Point(155, 134);
            this.phNumBox3.MaxLength = 40;
            this.phNumBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.phNumBox3.Multiline = false;
            this.phNumBox3.Name = "phNumBox3";
            this.phNumBox3.Size = new System.Drawing.Size(285, 50);
            this.phNumBox3.TabIndex = 35;
            this.phNumBox3.Text = "";
            this.phNumBox3.TrailingIcon = null;
            // 
            // fioBox1
            // 
            this.fioBox1.AnimateReadOnly = false;
            this.fioBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fioBox1.Depth = 0;
            this.fioBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fioBox1.LeadingIcon = null;
            this.fioBox1.Location = new System.Drawing.Point(155, 22);
            this.fioBox1.MaxLength = 50;
            this.fioBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.fioBox1.Multiline = false;
            this.fioBox1.Name = "fioBox1";
            this.fioBox1.Size = new System.Drawing.Size(285, 50);
            this.fioBox1.TabIndex = 33;
            this.fioBox1.Text = "";
            this.fioBox1.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.err);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.passwBox6);
            this.tabPage2.Controls.Add(this.loginBox7);
            this.tabPage2.ForeColor = System.Drawing.Color.Red;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Авторизация";
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(103, 222);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(325, 26);
            this.err.TabIndex = 31;
            this.err.Text = "Неверный логин или пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(56, 98);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(56, 154);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Пароль";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(56, 265);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 28;
            this.button2.Text = "Войти";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwBox6
            // 
            this.passwBox6.AnimateReadOnly = false;
            this.passwBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwBox6.Depth = 0;
            this.passwBox6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwBox6.LeadingIcon = null;
            this.passwBox6.Location = new System.Drawing.Point(161, 152);
            this.passwBox6.MaxLength = 50;
            this.passwBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.passwBox6.Multiline = false;
            this.passwBox6.Name = "passwBox6";
            this.passwBox6.Size = new System.Drawing.Size(285, 50);
            this.passwBox6.TabIndex = 26;
            this.passwBox6.Text = "";
            this.passwBox6.TrailingIcon = null;
            // 
            // loginBox7
            // 
            this.loginBox7.AnimateReadOnly = false;
            this.loginBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox7.Depth = 0;
            this.loginBox7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginBox7.LeadingIcon = null;
            this.loginBox7.Location = new System.Drawing.Point(161, 96);
            this.loginBox7.MaxLength = 50;
            this.loginBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.loginBox7.Multiline = false;
            this.loginBox7.Name = "loginBox7";
            this.loginBox7.Size = new System.Drawing.Size(285, 50);
            this.loginBox7.TabIndex = 25;
            this.loginBox7.Text = "";
            this.loginBox7.TrailingIcon = null;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(500, 552);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 552);
            this.MinimumSize = new System.Drawing.Size(500, 552);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IRepair";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialTextBox passwBox5;
        private MaterialSkin.Controls.MaterialTextBox adressBox2;
        private MaterialSkin.Controls.MaterialTextBox loginBox4;
        private MaterialSkin.Controls.MaterialTextBox phNumBox3;
        private MaterialSkin.Controls.MaterialTextBox fioBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialTextBox passwBox6;
        private MaterialSkin.Controls.MaterialTextBox loginBox7;
        private System.Windows.Forms.Label registered;
        private System.Windows.Forms.Label err;
    }
}