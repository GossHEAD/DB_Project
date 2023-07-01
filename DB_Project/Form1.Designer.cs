namespace DB_Project
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.traitsPanel = new System.Windows.Forms.Panel();
            this.textBoxProp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.photoPanel = new System.Windows.Forms.Panel();
            this.pictureBoxExtractor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.adminPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExtractor = new System.Windows.Forms.Button();
            this.buttonTraits = new System.Windows.Forms.Button();
            this.buttonCreator = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.buttonSubType = new System.Windows.Forms.Button();
            this.buttonValue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.traitsPanel.SuspendLayout();
            this.photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание";
            // 
            // traitsPanel
            // 
            this.traitsPanel.Controls.Add(this.textBoxProp);
            this.traitsPanel.Controls.Add(this.label1);
            this.traitsPanel.Location = new System.Drawing.Point(636, 279);
            this.traitsPanel.Name = "traitsPanel";
            this.traitsPanel.Size = new System.Drawing.Size(382, 206);
            this.traitsPanel.TabIndex = 4;
            // 
            // textBoxProp
            // 
            this.textBoxProp.Location = new System.Drawing.Point(6, 26);
            this.textBoxProp.Name = "textBoxProp";
            this.textBoxProp.Size = new System.Drawing.Size(362, 162);
            this.textBoxProp.TabIndex = 3;
            this.textBoxProp.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Свойства";
            // 
            // photoPanel
            // 
            this.photoPanel.Controls.Add(this.pictureBoxExtractor);
            this.photoPanel.Controls.Add(this.label2);
            this.photoPanel.Location = new System.Drawing.Point(12, 34);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(197, 239);
            this.photoPanel.TabIndex = 4;
            // 
            // pictureBoxExtractor
            // 
            this.pictureBoxExtractor.Location = new System.Drawing.Point(3, 26);
            this.pictureBoxExtractor.Name = "pictureBoxExtractor";
            this.pictureBoxExtractor.Size = new System.Drawing.Size(191, 210);
            this.pictureBoxExtractor.TabIndex = 3;
            this.pictureBoxExtractor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фото";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterButton,
            this.searchTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterButton
            // 
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(74, 27);
            this.filterButton.Text = "Фильтр";
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(148, 27);
            this.searchTextBox.Text = "Поиск по названию";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.buttonUpdate);
            this.adminPanel.Controls.Add(this.buttonAdd);
            this.adminPanel.Controls.Add(this.buttonDelete);
            this.adminPanel.Location = new System.Drawing.Point(12, 500);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(431, 55);
            this.adminPanel.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(3, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(134, 43);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(143, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 43);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(282, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 43);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonExtractor);
            this.flowLayoutPanel1.Controls.Add(this.buttonTraits);
            this.flowLayoutPanel1.Controls.Add(this.buttonCreator);
            this.flowLayoutPanel1.Controls.Add(this.buttonType);
            this.flowLayoutPanel1.Controls.Add(this.buttonSubType);
            this.flowLayoutPanel1.Controls.Add(this.buttonValue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1023, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(147, 302);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // buttonExtractor
            // 
            this.buttonExtractor.Location = new System.Drawing.Point(3, 3);
            this.buttonExtractor.Name = "buttonExtractor";
            this.buttonExtractor.Size = new System.Drawing.Size(134, 43);
            this.buttonExtractor.TabIndex = 1;
            this.buttonExtractor.Text = "Экстрактор";
            this.buttonExtractor.UseVisualStyleBackColor = true;
            this.buttonExtractor.Click += new System.EventHandler(this.buttonExtractor_Click);
            // 
            // buttonTraits
            // 
            this.buttonTraits.Location = new System.Drawing.Point(3, 52);
            this.buttonTraits.Name = "buttonTraits";
            this.buttonTraits.Size = new System.Drawing.Size(133, 43);
            this.buttonTraits.TabIndex = 8;
            this.buttonTraits.Text = "Свойства";
            this.buttonTraits.UseVisualStyleBackColor = true;
            this.buttonTraits.Click += new System.EventHandler(this.buttonTrait_Click);
            // 
            // buttonCreator
            // 
            this.buttonCreator.Location = new System.Drawing.Point(3, 101);
            this.buttonCreator.Name = "buttonCreator";
            this.buttonCreator.Size = new System.Drawing.Size(133, 43);
            this.buttonCreator.TabIndex = 9;
            this.buttonCreator.Text = "Производитель";
            this.buttonCreator.UseVisualStyleBackColor = true;
            this.buttonCreator.Click += new System.EventHandler(this.buttonCreator_Click);
            // 
            // buttonType
            // 
            this.buttonType.Location = new System.Drawing.Point(3, 150);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(133, 43);
            this.buttonType.TabIndex = 10;
            this.buttonType.Text = "Тип";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // buttonSubType
            // 
            this.buttonSubType.Location = new System.Drawing.Point(3, 199);
            this.buttonSubType.Name = "buttonSubType";
            this.buttonSubType.Size = new System.Drawing.Size(133, 43);
            this.buttonSubType.TabIndex = 11;
            this.buttonSubType.Text = "Подтип";
            this.buttonSubType.UseVisualStyleBackColor = true;
            this.buttonSubType.Click += new System.EventHandler(this.buttonSubType_Click);
            // 
            // buttonValue
            // 
            this.buttonValue.Location = new System.Drawing.Point(3, 248);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(133, 43);
            this.buttonValue.TabIndex = 12;
            this.buttonValue.Text = "Свойств_знач";
            this.buttonValue.UseVisualStyleBackColor = true;
            this.buttonValue.Click += new System.EventHandler(this.buttonChar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 206);
            this.panel1.TabIndex = 11;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(6, 26);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(594, 162);
            this.textBoxInfo.TabIndex = 4;
            this.textBoxInfo.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.photoPanel);
            this.Controls.Add(this.traitsPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.traitsPanel.ResumeLayout(false);
            this.traitsPanel.PerformLayout();
            this.photoPanel.ResumeLayout(false);
            this.photoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel traitsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterButton;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel adminPanel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonExtractor;
        private System.Windows.Forms.Button buttonTraits;
        private System.Windows.Forms.Button buttonCreator;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.RichTextBox textBoxProp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonSubType;
        private System.Windows.Forms.PictureBox pictureBoxExtractor;
        private System.Windows.Forms.Button buttonValue;
    }
}

