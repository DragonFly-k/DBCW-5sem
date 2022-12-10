namespace Employeer
{
    partial class EAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EAuth));
            this.loginBox7 = new MaterialSkin.Controls.MaterialTextBox();
            this.passwBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox7
            // 
            this.loginBox7.AnimateReadOnly = false;
            this.loginBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox7.Depth = 0;
            this.loginBox7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginBox7.LeadingIcon = null;
            this.loginBox7.Location = new System.Drawing.Point(119, 157);
            this.loginBox7.MaxLength = 50;
            this.loginBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.loginBox7.Multiline = false;
            this.loginBox7.Name = "loginBox7";
            this.loginBox7.Size = new System.Drawing.Size(285, 50);
            this.loginBox7.TabIndex = 0;
            this.loginBox7.Text = "";
            this.loginBox7.TrailingIcon = null;
            // 
            // passwBox6
            // 
            this.passwBox6.AnimateReadOnly = false;
            this.passwBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwBox6.Depth = 0;
            this.passwBox6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwBox6.LeadingIcon = null;
            this.passwBox6.Location = new System.Drawing.Point(119, 232);
            this.passwBox6.MaxLength = 50;
            this.passwBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.passwBox6.Multiline = false;
            this.passwBox6.Name = "passwBox6";
            this.passwBox6.Size = new System.Drawing.Size(285, 50);
            this.passwBox6.TabIndex = 1;
            this.passwBox6.Text = "";
            this.passwBox6.TrailingIcon = null;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(31, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Войти";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(31, 159);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(31, 234);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Пароль";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(53, 303);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(314, 25);
            this.err.TabIndex = 22;
            this.err.Text = "Неверный логин или пароль";
            // 
            // EAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.err);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passwBox6);
            this.Controls.Add(this.loginBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(449, 450);
            this.MinimumSize = new System.Drawing.Size(449, 450);
            this.Name = "EAuth";
            this.Text = "IRepair";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox loginBox7;
        private MaterialSkin.Controls.MaterialTextBox passwBox6;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label err;
    }
}