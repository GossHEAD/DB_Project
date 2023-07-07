namespace DB_Project.Forms.AdminPanel
{
    partial class NewExtractorForm
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
            this.escapeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.manufactureLabel = new System.Windows.Forms.Label();
            this.manufactureBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.subtypeLabel = new System.Windows.Forms.Label();
            this.subtypeBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.operatingModeLabel = new System.Windows.Forms.Label();
            this.operatingModeBox = new System.Windows.Forms.ComboBox();
            this.housingTypeLabel = new System.Windows.Forms.Label();
            this.housingTypeBox = new System.Windows.Forms.ComboBox();
            this.housingLocationLabel = new System.Windows.Forms.Label();
            this.housingLocationBox = new System.Windows.Forms.ComboBox();
            this.typeOfMixingLabel = new System.Windows.Forms.Label();
            this.typeOfMixingBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.bodyLengthLabel = new System.Windows.Forms.Label();
            this.bodyLengthBox = new System.Windows.Forms.TextBox();
            this.caseWidthLabel = new System.Windows.Forms.Label();
            this.caseWidthBox = new System.Windows.Forms.TextBox();
            this.efficiencyLabel = new System.Windows.Forms.Label();
            this.efficiencyBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.informationLabel = new System.Windows.Forms.Label();
            this.informationTextBox = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // escapeButton
            // 
            this.escapeButton.Location = new System.Drawing.Point(21, 629);
            this.escapeButton.Name = "escapeButton";
            this.escapeButton.Size = new System.Drawing.Size(185, 67);
            this.escapeButton.TabIndex = 6;
            this.escapeButton.Text = "Назад";
            this.escapeButton.UseVisualStyleBackColor = true;
            this.escapeButton.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(18, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1447, 545);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameLabel);
            this.flowLayoutPanel1.Controls.Add(this.nameBox);
            this.flowLayoutPanel1.Controls.Add(this.TextLabel);
            this.flowLayoutPanel1.Controls.Add(this.priceBox);
            this.flowLayoutPanel1.Controls.Add(this.manufactureLabel);
            this.flowLayoutPanel1.Controls.Add(this.manufactureBox);
            this.flowLayoutPanel1.Controls.Add(this.groupLabel);
            this.flowLayoutPanel1.Controls.Add(this.groupBox);
            this.flowLayoutPanel1.Controls.Add(this.typeLabel);
            this.flowLayoutPanel1.Controls.Add(this.typeBox);
            this.flowLayoutPanel1.Controls.Add(this.subtypeLabel);
            this.flowLayoutPanel1.Controls.Add(this.subtypeBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 526);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(143, 32);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Название";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(3, 35);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(309, 38);
            this.nameBox.TabIndex = 5;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(3, 76);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(83, 32);
            this.TextLabel.TabIndex = 7;
            this.TextLabel.Text = "Цена";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(3, 111);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(309, 38);
            this.priceBox.TabIndex = 6;
            // 
            // manufactureLabel
            // 
            this.manufactureLabel.AutoSize = true;
            this.manufactureLabel.Location = new System.Drawing.Point(3, 152);
            this.manufactureLabel.Name = "manufactureLabel";
            this.manufactureLabel.Size = new System.Drawing.Size(219, 32);
            this.manufactureLabel.TabIndex = 4;
            this.manufactureLabel.Text = "Производитель";
            // 
            // manufactureBox
            // 
            this.manufactureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufactureBox.FormattingEnabled = true;
            this.manufactureBox.Location = new System.Drawing.Point(3, 187);
            this.manufactureBox.Name = "manufactureBox";
            this.manufactureBox.Size = new System.Drawing.Size(309, 39);
            this.manufactureBox.TabIndex = 3;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(3, 229);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(108, 32);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Группа";
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(3, 264);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(309, 39);
            this.groupBox.TabIndex = 3;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.groupBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 306);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(63, 32);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Тип";
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(3, 341);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(309, 39);
            this.typeBox.TabIndex = 4;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // subtypeLabel
            // 
            this.subtypeLabel.AutoSize = true;
            this.subtypeLabel.Location = new System.Drawing.Point(3, 383);
            this.subtypeLabel.Name = "subtypeLabel";
            this.subtypeLabel.Size = new System.Drawing.Size(111, 32);
            this.subtypeLabel.TabIndex = 2;
            this.subtypeLabel.Text = "Подтип";
            // 
            // subtypeBox
            // 
            this.subtypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtypeBox.FormattingEnabled = true;
            this.subtypeBox.Location = new System.Drawing.Point(3, 418);
            this.subtypeBox.Name = "subtypeBox";
            this.subtypeBox.Size = new System.Drawing.Size(309, 39);
            this.subtypeBox.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.operatingModeLabel);
            this.flowLayoutPanel4.Controls.Add(this.operatingModeBox);
            this.flowLayoutPanel4.Controls.Add(this.housingTypeLabel);
            this.flowLayoutPanel4.Controls.Add(this.housingTypeBox);
            this.flowLayoutPanel4.Controls.Add(this.housingLocationLabel);
            this.flowLayoutPanel4.Controls.Add(this.housingLocationBox);
            this.flowLayoutPanel4.Controls.Add(this.typeOfMixingLabel);
            this.flowLayoutPanel4.Controls.Add(this.typeOfMixingBox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(376, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(355, 526);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // operatingModeLabel
            // 
            this.operatingModeLabel.AutoSize = true;
            this.operatingModeLabel.Location = new System.Drawing.Point(3, 0);
            this.operatingModeLabel.Name = "operatingModeLabel";
            this.operatingModeLabel.Size = new System.Drawing.Size(209, 32);
            this.operatingModeLabel.TabIndex = 8;
            this.operatingModeLabel.Text = "Режим работы";
            // 
            // operatingModeBox
            // 
            this.operatingModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatingModeBox.FormattingEnabled = true;
            this.operatingModeBox.Location = new System.Drawing.Point(3, 35);
            this.operatingModeBox.Name = "operatingModeBox";
            this.operatingModeBox.Size = new System.Drawing.Size(324, 39);
            this.operatingModeBox.TabIndex = 9;
            // 
            // housingTypeLabel
            // 
            this.housingTypeLabel.AutoSize = true;
            this.housingTypeLabel.Location = new System.Drawing.Point(3, 77);
            this.housingTypeLabel.Name = "housingTypeLabel";
            this.housingTypeLabel.Size = new System.Drawing.Size(176, 32);
            this.housingTypeLabel.TabIndex = 11;
            this.housingTypeLabel.Text = "Тип корпуса";
            // 
            // housingTypeBox
            // 
            this.housingTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housingTypeBox.FormattingEnabled = true;
            this.housingTypeBox.Location = new System.Drawing.Point(3, 112);
            this.housingTypeBox.Name = "housingTypeBox";
            this.housingTypeBox.Size = new System.Drawing.Size(324, 39);
            this.housingTypeBox.TabIndex = 10;
            // 
            // housingLocationLabel
            // 
            this.housingLocationLabel.AutoSize = true;
            this.housingLocationLabel.Location = new System.Drawing.Point(3, 154);
            this.housingLocationLabel.Name = "housingLocationLabel";
            this.housingLocationLabel.Size = new System.Drawing.Size(324, 32);
            this.housingLocationLabel.TabIndex = 12;
            this.housingLocationLabel.Text = "Расположение корпуса";
            // 
            // housingLocationBox
            // 
            this.housingLocationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.housingLocationBox.FormattingEnabled = true;
            this.housingLocationBox.Location = new System.Drawing.Point(3, 189);
            this.housingLocationBox.Name = "housingLocationBox";
            this.housingLocationBox.Size = new System.Drawing.Size(324, 39);
            this.housingLocationBox.TabIndex = 13;
            // 
            // typeOfMixingLabel
            // 
            this.typeOfMixingLabel.AutoSize = true;
            this.typeOfMixingLabel.Location = new System.Drawing.Point(3, 231);
            this.typeOfMixingLabel.Name = "typeOfMixingLabel";
            this.typeOfMixingLabel.Size = new System.Drawing.Size(286, 32);
            this.typeOfMixingLabel.TabIndex = 14;
            this.typeOfMixingLabel.Text = "Тип перемешивания";
            // 
            // typeOfMixingBox
            // 
            this.typeOfMixingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfMixingBox.FormattingEnabled = true;
            this.typeOfMixingBox.Location = new System.Drawing.Point(3, 266);
            this.typeOfMixingBox.Name = "typeOfMixingBox";
            this.typeOfMixingBox.Size = new System.Drawing.Size(324, 39);
            this.typeOfMixingBox.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.bodyLengthLabel);
            this.flowLayoutPanel3.Controls.Add(this.bodyLengthBox);
            this.flowLayoutPanel3.Controls.Add(this.caseWidthLabel);
            this.flowLayoutPanel3.Controls.Add(this.caseWidthBox);
            this.flowLayoutPanel3.Controls.Add(this.efficiencyLabel);
            this.flowLayoutPanel3.Controls.Add(this.efficiencyBox);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(737, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(368, 526);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // bodyLengthLabel
            // 
            this.bodyLengthLabel.AutoSize = true;
            this.bodyLengthLabel.Location = new System.Drawing.Point(3, 0);
            this.bodyLengthLabel.Name = "bodyLengthLabel";
            this.bodyLengthLabel.Size = new System.Drawing.Size(268, 32);
            this.bodyLengthLabel.TabIndex = 0;
            this.bodyLengthLabel.Text = "Длина корпуса, мм";
            // 
            // bodyLengthBox
            // 
            this.bodyLengthBox.Location = new System.Drawing.Point(3, 35);
            this.bodyLengthBox.Name = "bodyLengthBox";
            this.bodyLengthBox.Size = new System.Drawing.Size(347, 38);
            this.bodyLengthBox.TabIndex = 3;
            // 
            // caseWidthLabel
            // 
            this.caseWidthLabel.AutoSize = true;
            this.caseWidthLabel.Location = new System.Drawing.Point(3, 76);
            this.caseWidthLabel.Name = "caseWidthLabel";
            this.caseWidthLabel.Size = new System.Drawing.Size(286, 32);
            this.caseWidthLabel.TabIndex = 1;
            this.caseWidthLabel.Text = "Ширина корпуса, мм";
            // 
            // caseWidthBox
            // 
            this.caseWidthBox.Location = new System.Drawing.Point(3, 111);
            this.caseWidthBox.Name = "caseWidthBox";
            this.caseWidthBox.Size = new System.Drawing.Size(347, 38);
            this.caseWidthBox.TabIndex = 4;
            // 
            // efficiencyLabel
            // 
            this.efficiencyLabel.AutoSize = true;
            this.efficiencyLabel.Location = new System.Drawing.Point(3, 152);
            this.efficiencyLabel.Name = "efficiencyLabel";
            this.efficiencyLabel.Size = new System.Drawing.Size(347, 32);
            this.efficiencyLabel.TabIndex = 2;
            this.efficiencyLabel.Text = "Производительность, л/ч";
            // 
            // efficiencyBox
            // 
            this.efficiencyBox.Location = new System.Drawing.Point(3, 187);
            this.efficiencyBox.Name = "efficiencyBox";
            this.efficiencyBox.Size = new System.Drawing.Size(347, 38);
            this.efficiencyBox.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.informationLabel);
            this.flowLayoutPanel5.Controls.Add(this.informationTextBox);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(1111, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(324, 526);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(3, 0);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(146, 32);
            this.informationLabel.TabIndex = 5;
            this.informationLabel.Text = "Описание";
            // 
            // informationTextBox
            // 
            this.informationTextBox.Location = new System.Drawing.Point(3, 35);
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.Size = new System.Drawing.Size(312, 478);
            this.informationTextBox.TabIndex = 7;
            this.informationTextBox.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1268, 629);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(185, 67);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NewExtractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 726);
            this.Controls.Add(this.escapeButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.addButton);
            this.Name = "NewExtractorForm";
            this.Text = "Добавление данных";
            this.Load += new System.EventHandler(this.NewExtractorForm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button escapeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label manufactureLabel;
        private System.Windows.Forms.ComboBox manufactureBox;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label subtypeLabel;
        private System.Windows.Forms.ComboBox subtypeBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label operatingModeLabel;
        private System.Windows.Forms.ComboBox operatingModeBox;
        private System.Windows.Forms.Label housingTypeLabel;
        private System.Windows.Forms.ComboBox housingTypeBox;
        private System.Windows.Forms.Label housingLocationLabel;
        private System.Windows.Forms.ComboBox housingLocationBox;
        private System.Windows.Forms.Label typeOfMixingLabel;
        private System.Windows.Forms.ComboBox typeOfMixingBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label bodyLengthLabel;
        private System.Windows.Forms.TextBox bodyLengthBox;
        private System.Windows.Forms.Label caseWidthLabel;
        private System.Windows.Forms.TextBox caseWidthBox;
        private System.Windows.Forms.Label efficiencyLabel;
        private System.Windows.Forms.TextBox efficiencyBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.RichTextBox informationTextBox;
        private System.Windows.Forms.Button addButton;
    }
}