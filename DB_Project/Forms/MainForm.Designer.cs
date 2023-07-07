namespace DB_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataExtractor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.traitsPanel = new System.Windows.Forms.Panel();
            this.textBoxProp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.photoPanel = new System.Windows.Forms.Panel();
            this.pictureBoxExtractor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExtractor = new System.Windows.Forms.Button();
            this.buttonCreator = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.buttonValue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchForName_button = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutProgrammMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataExtractor)).BeginInit();
            this.traitsPanel.SuspendLayout();
            this.photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractor)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataExtractor
            // 
            this.dataExtractor.AllowUserToAddRows = false;
            this.dataExtractor.AllowUserToDeleteRows = false;
            this.dataExtractor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataExtractor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataExtractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExtractor.Location = new System.Drawing.Point(444, 49);
            this.dataExtractor.Margin = new System.Windows.Forms.Padding(6);
            this.dataExtractor.Name = "dataExtractor";
            this.dataExtractor.ReadOnly = true;
            this.dataExtractor.RowHeadersWidth = 51;
            this.dataExtractor.RowTemplate.Height = 24;
            this.dataExtractor.Size = new System.Drawing.Size(1792, 407);
            this.dataExtractor.TabIndex = 0;
            this.dataExtractor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataExtractor_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание";
            // 
            // traitsPanel
            // 
            this.traitsPanel.Controls.Add(this.textBoxProp);
            this.traitsPanel.Controls.Add(this.label1);
            this.traitsPanel.Location = new System.Drawing.Point(1615, 481);
            this.traitsPanel.Margin = new System.Windows.Forms.Padding(6);
            this.traitsPanel.Name = "traitsPanel";
            this.traitsPanel.Size = new System.Drawing.Size(643, 399);
            this.traitsPanel.TabIndex = 4;
            // 
            // textBoxProp
            // 
            this.textBoxProp.Location = new System.Drawing.Point(12, 50);
            this.textBoxProp.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxProp.Name = "textBoxProp";
            this.textBoxProp.ReadOnly = true;
            this.textBoxProp.Size = new System.Drawing.Size(609, 310);
            this.textBoxProp.TabIndex = 3;
            this.textBoxProp.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Свойства";
            // 
            // photoPanel
            // 
            this.photoPanel.Controls.Add(this.pictureBoxExtractor);
            this.photoPanel.Controls.Add(this.label2);
            this.photoPanel.Location = new System.Drawing.Point(21, 410);
            this.photoPanel.Margin = new System.Windows.Forms.Padding(6);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(394, 470);
            this.photoPanel.TabIndex = 4;
            // 
            // pictureBoxExtractor
            // 
            this.pictureBoxExtractor.Location = new System.Drawing.Point(6, 59);
            this.pictureBoxExtractor.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxExtractor.Name = "pictureBoxExtractor";
            this.pictureBoxExtractor.Size = new System.Drawing.Size(382, 405);
            this.pictureBoxExtractor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExtractor.TabIndex = 3;
            this.pictureBoxExtractor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фото";
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.buttonUpdate);
            this.adminPanel.Controls.Add(this.buttonAdd);
            this.adminPanel.Controls.Add(this.buttonDelete);
            this.adminPanel.Location = new System.Drawing.Point(1418, 907);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(6);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(840, 113);
            this.adminPanel.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(6, 6);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(268, 101);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(286, 6);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(266, 101);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(564, 6);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(266, 101);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonExtractor);
            this.flowLayoutPanel1.Controls.Add(this.buttonCreator);
            this.flowLayoutPanel1.Controls.Add(this.buttonType);
            this.flowLayoutPanel1.Controls.Add(this.buttonValue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 906);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1119, 114);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // buttonExtractor
            // 
            this.buttonExtractor.Location = new System.Drawing.Point(6, 6);
            this.buttonExtractor.Margin = new System.Windows.Forms.Padding(6);
            this.buttonExtractor.Name = "buttonExtractor";
            this.buttonExtractor.Size = new System.Drawing.Size(268, 101);
            this.buttonExtractor.TabIndex = 1;
            this.buttonExtractor.Text = "Экстрактор";
            this.buttonExtractor.UseVisualStyleBackColor = true;
            this.buttonExtractor.Click += new System.EventHandler(this.buttonExtractor_Click);
            // 
            // buttonCreator
            // 
            this.buttonCreator.Location = new System.Drawing.Point(286, 6);
            this.buttonCreator.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreator.Name = "buttonCreator";
            this.buttonCreator.Size = new System.Drawing.Size(266, 101);
            this.buttonCreator.TabIndex = 9;
            this.buttonCreator.Text = "Производитель";
            this.buttonCreator.UseVisualStyleBackColor = true;
            this.buttonCreator.Click += new System.EventHandler(this.buttonCreator_Click);
            // 
            // buttonType
            // 
            this.buttonType.Location = new System.Drawing.Point(564, 6);
            this.buttonType.Margin = new System.Windows.Forms.Padding(6);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(266, 101);
            this.buttonType.TabIndex = 10;
            this.buttonType.Text = "Тип";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // buttonValue
            // 
            this.buttonValue.Location = new System.Drawing.Point(842, 6);
            this.buttonValue.Margin = new System.Windows.Forms.Padding(6);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(266, 101);
            this.buttonValue.TabIndex = 12;
            this.buttonValue.Text = "Свойства всех экстакторов";
            this.buttonValue.UseVisualStyleBackColor = true;
            this.buttonValue.Click += new System.EventHandler(this.buttonChar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(444, 481);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 399);
            this.panel1.TabIndex = 11;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfo.Location = new System.Drawing.Point(12, 50);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(1118, 310);
            this.textBoxInfo.TabIndex = 4;
            this.textBoxInfo.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // searchForName_button
            // 
            this.searchForName_button.Location = new System.Drawing.Point(88, 66);
            this.searchForName_button.Name = "searchForName_button";
            this.searchForName_button.Size = new System.Drawing.Size(195, 54);
            this.searchForName_button.TabIndex = 12;
            this.searchForName_button.Text = "Найти";
            this.searchForName_button.UseVisualStyleBackColor = true;
            this.searchForName_button.Click += new System.EventHandler(this.searchForName_button_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(35, 18);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(305, 38);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.Text = "Поиск по названию";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(66, 157);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(239, 70);
            this.filterButton.TabIndex = 14;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Controls.Add(this.searchForName_button);
            this.panel2.Location = new System.Drawing.Point(21, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 268);
            this.panel2.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgrammMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2273, 60);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutProgrammMenuItem
            // 
            this.AboutProgrammMenuItem.Name = "AboutProgrammMenuItem";
            this.AboutProgrammMenuItem.Size = new System.Drawing.Size(228, 50);
            this.AboutProgrammMenuItem.Text = "О программе";
            this.AboutProgrammMenuItem.Click += new System.EventHandler(this.AboutProgrammMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2273, 1054);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.photoPanel);
            this.Controls.Add(this.traitsPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataExtractor);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Activated += new System.EventHandler(this.MainFrom_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataExtractor)).EndInit();
            this.traitsPanel.ResumeLayout(false);
            this.traitsPanel.PerformLayout();
            this.photoPanel.ResumeLayout(false);
            this.photoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractor)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataExtractor;
        private System.Windows.Forms.Panel traitsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel adminPanel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonExtractor;
        private System.Windows.Forms.Button buttonCreator;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.RichTextBox textBoxProp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxExtractor;
        private System.Windows.Forms.Button buttonValue;
        private System.Windows.Forms.Button searchForName_button;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutProgrammMenuItem;
    }
}

