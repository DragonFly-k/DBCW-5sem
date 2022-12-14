namespace Client
{
    partial class CForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.modelBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.makerBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.descsBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.seriaNumBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.nameBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.makeOrder = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.UserLabel = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 620);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.modelBox5);
            this.tabPage1.Controls.Add(this.makerBox4);
            this.tabPage1.Controls.Add(this.descsBox3);
            this.tabPage1.Controls.Add(this.seriaNumBox2);
            this.tabPage1.Controls.Add(this.nameBox1);
            this.tabPage1.Controls.Add(this.makeOrder);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.UserLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оформить заказ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // modelBox5
            // 
            this.modelBox5.AnimateReadOnly = false;
            this.modelBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelBox5.Depth = 0;
            this.modelBox5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modelBox5.LeadingIcon = null;
            this.modelBox5.Location = new System.Drawing.Point(279, 355);
            this.modelBox5.MaxLength = 50;
            this.modelBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.modelBox5.Multiline = false;
            this.modelBox5.Name = "modelBox5";
            this.modelBox5.Size = new System.Drawing.Size(373, 50);
            this.modelBox5.TabIndex = 14;
            this.modelBox5.Text = "";
            this.modelBox5.TrailingIcon = null;
            // 
            // makerBox4
            // 
            this.makerBox4.AnimateReadOnly = false;
            this.makerBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.makerBox4.Depth = 0;
            this.makerBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.makerBox4.LeadingIcon = null;
            this.makerBox4.Location = new System.Drawing.Point(279, 286);
            this.makerBox4.MaxLength = 50;
            this.makerBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.makerBox4.Multiline = false;
            this.makerBox4.Name = "makerBox4";
            this.makerBox4.Size = new System.Drawing.Size(373, 50);
            this.makerBox4.TabIndex = 13;
            this.makerBox4.Text = "";
            this.makerBox4.TrailingIcon = null;
            // 
            // descsBox3
            // 
            this.descsBox3.AnimateReadOnly = false;
            this.descsBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descsBox3.Depth = 0;
            this.descsBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descsBox3.LeadingIcon = null;
            this.descsBox3.Location = new System.Drawing.Point(279, 219);
            this.descsBox3.MaxLength = 50;
            this.descsBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.descsBox3.Multiline = false;
            this.descsBox3.Name = "descsBox3";
            this.descsBox3.Size = new System.Drawing.Size(373, 50);
            this.descsBox3.TabIndex = 12;
            this.descsBox3.Text = "";
            this.descsBox3.TrailingIcon = null;
            // 
            // seriaNumBox2
            // 
            this.seriaNumBox2.AnimateReadOnly = false;
            this.seriaNumBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seriaNumBox2.Depth = 0;
            this.seriaNumBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.seriaNumBox2.LeadingIcon = null;
            this.seriaNumBox2.Location = new System.Drawing.Point(279, 150);
            this.seriaNumBox2.MaxLength = 50;
            this.seriaNumBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.seriaNumBox2.Multiline = false;
            this.seriaNumBox2.Name = "seriaNumBox2";
            this.seriaNumBox2.Size = new System.Drawing.Size(373, 50);
            this.seriaNumBox2.TabIndex = 11;
            this.seriaNumBox2.Text = "";
            this.seriaNumBox2.TrailingIcon = null;
            // 
            // nameBox1
            // 
            this.nameBox1.AnimateReadOnly = false;
            this.nameBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox1.Depth = 0;
            this.nameBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameBox1.LeadingIcon = null;
            this.nameBox1.Location = new System.Drawing.Point(279, 80);
            this.nameBox1.MaxLength = 50;
            this.nameBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.nameBox1.Multiline = false;
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(373, 50);
            this.nameBox1.TabIndex = 10;
            this.nameBox1.Text = "";
            this.nameBox1.TrailingIcon = null;
            // 
            // makeOrder
            // 
            this.makeOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.makeOrder.Depth = 0;
            this.makeOrder.HighEmphasis = true;
            this.makeOrder.Icon = null;
            this.makeOrder.Location = new System.Drawing.Point(388, 501);
            this.makeOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.makeOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.makeOrder.Name = "makeOrder";
            this.makeOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.makeOrder.Size = new System.Drawing.Size(154, 36);
            this.makeOrder.TabIndex = 9;
            this.makeOrder.Text = "Оформить заказ";
            this.makeOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.makeOrder.UseAccentColor = false;
            this.makeOrder.UseVisualStyleBackColor = true;
            this.makeOrder.Click += new System.EventHandler(this.makeOrder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoResize = false;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.Depth = 0;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.DropDownHeight = 174;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 121;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 43;
            this.comboBox1.Location = new System.Drawing.Point(279, 420);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(373, 49);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(89, 424);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Мастер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(89, 357);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Модель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(89, 286);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Производитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(89, 221);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(89, 152);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Серийный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(89, 82);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Lavender;
            this.UserLabel.Depth = 0;
            this.UserLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserLabel.ForeColor = System.Drawing.Color.Indigo;
            this.UserLabel.Location = new System.Drawing.Point(561, 37);
            this.UserLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(108, 19);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(388, 37);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ремонт техники";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Активные заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Lavender;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(868, 581);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(874, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "История Заказов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(868, 581);
            this.dataGridView2.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(892, 694);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(892, 694);
            this.MinimumSize = new System.Drawing.Size(892, 694);
            this.Name = "CForm";
            this.Text = "IRepair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel label10;
        private MaterialSkin.Controls.MaterialLabel label9;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel UserLabel;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialTextBox modelBox5;
        private MaterialSkin.Controls.MaterialTextBox makerBox4;
        private MaterialSkin.Controls.MaterialTextBox descsBox3;
        private MaterialSkin.Controls.MaterialTextBox seriaNumBox2;
        private MaterialSkin.Controls.MaterialTextBox nameBox1;
        private MaterialSkin.Controls.MaterialButton makeOrder;
        private MaterialSkin.Controls.MaterialComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}