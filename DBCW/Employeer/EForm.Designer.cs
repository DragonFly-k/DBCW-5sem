namespace Employeer
{
    partial class EForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tagPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.makeOrder = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.priceBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.repairBox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.UserLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tagPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tagPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 485);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы для обработки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button3.Depth = 0;
            this.button3.HighEmphasis = true;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(413, 384);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button3.Size = new System.Drawing.Size(202, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "Добавить в обработку";
            this.button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button3.UseAccentColor = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(1035, 351);
            this.dataGridView3.TabIndex = 0;
            // 
            // tagPage2
            // 
            this.tagPage2.Controls.Add(this.listBox1);
            this.tagPage2.Controls.Add(this.comboBox1);
            this.tagPage2.Controls.Add(this.makeOrder);
            this.tagPage2.Controls.Add(this.button1);
            this.tagPage2.Controls.Add(this.button2);
            this.tagPage2.Controls.Add(this.priceBox2);
            this.tagPage2.Controls.Add(this.repairBox1);
            this.tagPage2.Controls.Add(this.label4);
            this.tagPage2.Controls.Add(this.label2);
            this.tagPage2.Controls.Add(this.label1);
            this.tagPage2.Controls.Add(this.UserLabel);
            this.tagPage2.Controls.Add(this.dataGridView1);
            this.tagPage2.Location = new System.Drawing.Point(4, 29);
            this.tagPage2.Name = "tagPage2";
            this.tagPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tagPage2.Size = new System.Drawing.Size(1041, 452);
            this.tagPage2.TabIndex = 1;
            this.tagPage2.Text = "Текущие заказы";
            this.tagPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(846, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 104);
            this.listBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(845, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // makeOrder
            // 
            this.makeOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.makeOrder.Depth = 0;
            this.makeOrder.HighEmphasis = true;
            this.makeOrder.Icon = null;
            this.makeOrder.Location = new System.Drawing.Point(861, 396);
            this.makeOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.makeOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.makeOrder.Name = "makeOrder";
            this.makeOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.makeOrder.Size = new System.Drawing.Size(166, 36);
            this.makeOrder.TabIndex = 11;
            this.makeOrder.Text = "Обработать заказ";
            this.makeOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.makeOrder.UseAccentColor = false;
            this.makeOrder.UseVisualStyleBackColor = true;
            this.makeOrder.Click += new System.EventHandler(this.makeOrder_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(662, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button1.Size = new System.Drawing.Size(177, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Удалить из списка ";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(662, 272);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button2.Size = new System.Drawing.Size(176, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить в список";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceBox2
            // 
            this.priceBox2.AnimateReadOnly = false;
            this.priceBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceBox2.Depth = 0;
            this.priceBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceBox2.LeadingIcon = null;
            this.priceBox2.Location = new System.Drawing.Point(846, 137);
            this.priceBox2.MaxLength = 50;
            this.priceBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.priceBox2.Multiline = false;
            this.priceBox2.Name = "priceBox2";
            this.priceBox2.Size = new System.Drawing.Size(182, 50);
            this.priceBox2.TabIndex = 6;
            this.priceBox2.Text = "";
            this.priceBox2.TrailingIcon = null;
            // 
            // repairBox1
            // 
            this.repairBox1.AnimateReadOnly = false;
            this.repairBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.repairBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.repairBox1.Depth = 0;
            this.repairBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.repairBox1.HideSelection = true;
            this.repairBox1.LeadingIcon = null;
            this.repairBox1.Location = new System.Drawing.Point(846, 58);
            this.repairBox1.MaxLength = 32767;
            this.repairBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.repairBox1.Name = "repairBox1";
            this.repairBox1.PasswordChar = '\0';
            this.repairBox1.PrefixSuffixText = null;
            this.repairBox1.ReadOnly = false;
            this.repairBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.repairBox1.SelectedText = "";
            this.repairBox1.SelectionLength = 0;
            this.repairBox1.SelectionStart = 0;
            this.repairBox1.ShortcutsEnabled = true;
            this.repairBox1.Size = new System.Drawing.Size(182, 48);
            this.repairBox1.TabIndex = 5;
            this.repairBox1.TabStop = false;
            this.repairBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.repairBox1.TrailingIcon = null;
            this.repairBox1.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(662, 213);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Запчасти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(658, 139);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость ремонта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(658, 58);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание ремонта";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Depth = 0;
            this.UserLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserLabel.Location = new System.Drawing.Point(658, 16);
            this.UserLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(73, 19);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Работник";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(652, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1041, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Выполненные заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1035, 446);
            this.dataGridView2.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 550);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1055, 550);
            this.MinimumSize = new System.Drawing.Size(1055, 550);
            this.Name = "EForm";
            this.Text = "IRepair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tagPage2.ResumeLayout(false);
            this.tagPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tagPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialButton button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel UserLabel;
        private MaterialSkin.Controls.MaterialTextBox priceBox2;
        private MaterialSkin.Controls.MaterialTextBox2 repairBox1;
        private MaterialSkin.Controls.MaterialButton makeOrder;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}