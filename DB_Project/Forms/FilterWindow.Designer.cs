namespace DB_Project
{
    partial class FilterWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.operatingModeLabel = new System.Windows.Forms.Label();
            this.operatingModeBox = new System.Windows.Forms.ComboBox();
            this.housingTypeLabel = new System.Windows.Forms.Label();
            this.housingTypeBox = new System.Windows.Forms.ComboBox();
            this.housingLocationLabel = new System.Windows.Forms.Label();
            this.housingLocationBox = new System.Windows.Forms.ComboBox();
            this.typeOfMixingLabel = new System.Windows.Forms.Label();
            this.typeOfMixingBox = new System.Windows.Forms.ComboBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.group_label = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.subtype_label = new System.Windows.Forms.Label();
            this.subtypeBox = new System.Windows.Forms.ComboBox();
            this.manufacturer_label = new System.Windows.Forms.Label();
            this.manufacturerBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.operatingModeLabel);
            this.flowLayoutPanel1.Controls.Add(this.operatingModeBox);
            this.flowLayoutPanel1.Controls.Add(this.housingTypeLabel);
            this.flowLayoutPanel1.Controls.Add(this.housingTypeBox);
            this.flowLayoutPanel1.Controls.Add(this.housingLocationLabel);
            this.flowLayoutPanel1.Controls.Add(this.housingLocationBox);
            this.flowLayoutPanel1.Controls.Add(this.typeOfMixingLabel);
            this.flowLayoutPanel1.Controls.Add(this.typeOfMixingBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(348, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 389);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // operatingModeLabel
            // 
            this.operatingModeLabel.AutoSize = true;
            this.operatingModeLabel.Location = new System.Drawing.Point(3, 0);
            this.operatingModeLabel.Name = "operatingModeLabel";
            this.operatingModeLabel.Size = new System.Drawing.Size(209, 32);
            this.operatingModeLabel.TabIndex = 0;
            this.operatingModeLabel.Text = "Режим работы";
            // 
            // operatingModeBox
            // 
            this.operatingModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatingModeBox.FormattingEnabled = true;
            this.operatingModeBox.Location = new System.Drawing.Point(3, 35);
            this.operatingModeBox.Name = "operatingModeBox";
            this.operatingModeBox.Size = new System.Drawing.Size(324, 39);
            this.operatingModeBox.TabIndex = 1;
            this.operatingModeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // housingTypeLabel
            // 
            this.housingTypeLabel.AutoSize = true;
            this.housingTypeLabel.Location = new System.Drawing.Point(3, 77);
            this.housingTypeLabel.Name = "housingTypeLabel";
            this.housingTypeLabel.Size = new System.Drawing.Size(176, 32);
            this.housingTypeLabel.TabIndex = 3;
            this.housingTypeLabel.Text = "Тип корпуса";
            // 
            // housingTypeBox
            // 
            this.housingTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housingTypeBox.FormattingEnabled = true;
            this.housingTypeBox.Location = new System.Drawing.Point(3, 112);
            this.housingTypeBox.Name = "housingTypeBox";
            this.housingTypeBox.Size = new System.Drawing.Size(324, 39);
            this.housingTypeBox.TabIndex = 2;
            this.housingTypeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // housingLocationLabel
            // 
            this.housingLocationLabel.AutoSize = true;
            this.housingLocationLabel.Location = new System.Drawing.Point(3, 154);
            this.housingLocationLabel.Name = "housingLocationLabel";
            this.housingLocationLabel.Size = new System.Drawing.Size(324, 32);
            this.housingLocationLabel.TabIndex = 4;
            this.housingLocationLabel.Text = "Расположение корпуса";
            // 
            // housingLocationBox
            // 
            this.housingLocationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housingLocationBox.FormattingEnabled = true;
            this.housingLocationBox.Location = new System.Drawing.Point(3, 189);
            this.housingLocationBox.Name = "housingLocationBox";
            this.housingLocationBox.Size = new System.Drawing.Size(324, 39);
            this.housingLocationBox.TabIndex = 5;
            this.housingLocationBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // typeOfMixingLabel
            // 
            this.typeOfMixingLabel.AutoSize = true;
            this.typeOfMixingLabel.Location = new System.Drawing.Point(3, 231);
            this.typeOfMixingLabel.Name = "typeOfMixingLabel";
            this.typeOfMixingLabel.Size = new System.Drawing.Size(286, 32);
            this.typeOfMixingLabel.TabIndex = 6;
            this.typeOfMixingLabel.Text = "Тип перемешивания";
            // 
            // typeOfMixingBox
            // 
            this.typeOfMixingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfMixingBox.FormattingEnabled = true;
            this.typeOfMixingBox.Location = new System.Drawing.Point(3, 266);
            this.typeOfMixingBox.Name = "typeOfMixingBox";
            this.typeOfMixingBox.Size = new System.Drawing.Size(324, 39);
            this.typeOfMixingBox.TabIndex = 7;
            this.typeOfMixingBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(557, 460);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(209, 58);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Ввод";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.group_label);
            this.flowLayoutPanel3.Controls.Add(this.groupBox);
            this.flowLayoutPanel3.Controls.Add(this.type_label);
            this.flowLayoutPanel3.Controls.Add(this.typeBox);
            this.flowLayoutPanel3.Controls.Add(this.subtype_label);
            this.flowLayoutPanel3.Controls.Add(this.subtypeBox);
            this.flowLayoutPanel3.Controls.Add(this.manufacturer_label);
            this.flowLayoutPanel3.Controls.Add(this.manufacturerBox);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(339, 389);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // group_label
            // 
            this.group_label.AutoSize = true;
            this.group_label.Location = new System.Drawing.Point(3, 0);
            this.group_label.Name = "group_label";
            this.group_label.Size = new System.Drawing.Size(108, 32);
            this.group_label.TabIndex = 0;
            this.group_label.Text = "Группа";
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(3, 35);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(324, 39);
            this.groupBox.TabIndex = 1;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.groupBox_SelectedIndexChanged);
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(3, 77);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(63, 32);
            this.type_label.TabIndex = 2;
            this.type_label.Text = "Тип";
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(3, 112);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(324, 39);
            this.typeBox.TabIndex = 3;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            this.typeBox.EnabledChanged += new System.EventHandler(this.comboBox_EnabledChanged);
            // 
            // subtype_label
            // 
            this.subtype_label.AutoSize = true;
            this.subtype_label.Location = new System.Drawing.Point(3, 154);
            this.subtype_label.Name = "subtype_label";
            this.subtype_label.Size = new System.Drawing.Size(111, 32);
            this.subtype_label.TabIndex = 4;
            this.subtype_label.Text = "Подтип";
            // 
            // subtypeBox
            // 
            this.subtypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtypeBox.FormattingEnabled = true;
            this.subtypeBox.Location = new System.Drawing.Point(3, 189);
            this.subtypeBox.Name = "subtypeBox";
            this.subtypeBox.Size = new System.Drawing.Size(324, 39);
            this.subtypeBox.TabIndex = 5;
            this.subtypeBox.EnabledChanged += new System.EventHandler(this.comboBox_EnabledChanged);
            // 
            // manufacturer_label
            // 
            this.manufacturer_label.AutoSize = true;
            this.manufacturer_label.Location = new System.Drawing.Point(3, 231);
            this.manufacturer_label.Name = "manufacturer_label";
            this.manufacturer_label.Size = new System.Drawing.Size(219, 32);
            this.manufacturer_label.TabIndex = 6;
            this.manufacturer_label.Text = "Производитель";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerBox.FormattingEnabled = true;
            this.manufacturerBox.Location = new System.Drawing.Point(3, 266);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(324, 39);
            this.manufacturerBox.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(46, 40);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(731, 402);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина корпуса(мм) от";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(316, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(442, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(334, 47);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown3.TabIndex = 7;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(460, 47);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Производительность(л/ч) от";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(395, 91);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "до";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(573, 91);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown6.TabIndex = 12;
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 550);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.enterButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FilterWindow";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.FilterWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label operatingModeLabel;
        private System.Windows.Forms.ComboBox operatingModeBox;
        private System.Windows.Forms.Label housingTypeLabel;
        private System.Windows.Forms.ComboBox housingTypeBox;
        private System.Windows.Forms.Label housingLocationLabel;
        private System.Windows.Forms.ComboBox housingLocationBox;
        private System.Windows.Forms.Label typeOfMixingLabel;
        private System.Windows.Forms.ComboBox typeOfMixingBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label group_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label subtype_label;
        private System.Windows.Forms.ComboBox subtypeBox;
        private System.Windows.Forms.Label manufacturer_label;
        private System.Windows.Forms.ComboBox manufacturerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
    }
}