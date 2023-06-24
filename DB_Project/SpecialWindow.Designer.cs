namespace DB_Project
{
    partial class SpecialWindow
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
            this.textBoxTimePath = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.маршрутTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxToPath = new System.Windows.Forms.ListBox();
            this.listBoxFromPath = new System.Windows.Forms.ListBox();
            this.SpecialPanelPath = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxTransit = new System.Windows.Forms.ListBox();
            this.SpecialPanelDeliver = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxDeliverCount = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeliverCreated = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeliverOffs = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeliverTake = new System.Windows.Forms.DateTimePicker();
            this.listBoxDeliverPath = new System.Windows.Forms.ListBox();
            this.listBoxDeliverMat = new System.Windows.Forms.ListBox();
            this.panelSpecialSeller = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePickerSellerOrder = new System.Windows.Forms.DateTimePicker();
            this.textBoxSellerCount = new System.Windows.Forms.TextBox();
            this.listBoxSellerStage = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSpecialBuyer = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePickerBuyer = new System.Windows.Forms.DateTimePicker();
            this.textBoxBuyer = new System.Windows.Forms.TextBox();
            this.listBoxMatBuyer = new System.Windows.Forms.ListBox();
            this.listBoxStageBuyer = new System.Windows.Forms.ListBox();
            this.specialPanelBoss = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePickerBossOrder = new System.Windows.Forms.DateTimePicker();
            this.listBoxStageBoss = new System.Windows.Forms.ListBox();
            this.listBoxMatBoss = new System.Windows.Forms.ListBox();
            this.specialPanelOffs = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxOffsCount = new System.Windows.Forms.TextBox();
            this.listBoxOffsStorage = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутTableAdapterBindingSource)).BeginInit();
            this.SpecialPanelPath.SuspendLayout();
            this.SpecialPanelDeliver.SuspendLayout();
            this.panelSpecialSeller.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelSpecialBuyer.SuspendLayout();
            this.specialPanelBoss.SuspendLayout();
            this.specialPanelOffs.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTimePath
            // 
            this.textBoxTimePath.Location = new System.Drawing.Point(3, 3);
            this.textBoxTimePath.Name = "textBoxTimePath";
            this.textBoxTimePath.Size = new System.Drawing.Size(121, 22);
            this.textBoxTimePath.TabIndex = 1;
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(12, 236);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(107, 60);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxToPath
            // 
            this.listBoxToPath.FormatString = "N0";
            this.listBoxToPath.FormattingEnabled = true;
            this.listBoxToPath.ItemHeight = 16;
            this.listBoxToPath.Location = new System.Drawing.Point(3, 73);
            this.listBoxToPath.Name = "listBoxToPath";
            this.listBoxToPath.Size = new System.Drawing.Size(120, 36);
            this.listBoxToPath.TabIndex = 6;
            this.listBoxToPath.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxFromPath
            // 
            this.listBoxFromPath.FormatString = "N0";
            this.listBoxFromPath.FormattingEnabled = true;
            this.listBoxFromPath.ItemHeight = 16;
            this.listBoxFromPath.Location = new System.Drawing.Point(3, 31);
            this.listBoxFromPath.Name = "listBoxFromPath";
            this.listBoxFromPath.Size = new System.Drawing.Size(120, 36);
            this.listBoxFromPath.TabIndex = 7;
            // 
            // SpecialPanelPath
            // 
            this.SpecialPanelPath.Controls.Add(this.textBoxTimePath);
            this.SpecialPanelPath.Controls.Add(this.listBoxFromPath);
            this.SpecialPanelPath.Controls.Add(this.listBoxToPath);
            this.SpecialPanelPath.Controls.Add(this.listBoxTransit);
            this.SpecialPanelPath.Location = new System.Drawing.Point(3, 3);
            this.SpecialPanelPath.Name = "SpecialPanelPath";
            this.SpecialPanelPath.Size = new System.Drawing.Size(130, 193);
            this.SpecialPanelPath.TabIndex = 8;
            // 
            // listBoxTransit
            // 
            this.listBoxTransit.FormatString = "N0";
            this.listBoxTransit.FormattingEnabled = true;
            this.listBoxTransit.ItemHeight = 16;
            this.listBoxTransit.Location = new System.Drawing.Point(3, 115);
            this.listBoxTransit.Name = "listBoxTransit";
            this.listBoxTransit.Size = new System.Drawing.Size(120, 36);
            this.listBoxTransit.TabIndex = 8;
            // 
            // SpecialPanelDeliver
            // 
            this.SpecialPanelDeliver.Controls.Add(this.textBoxDeliverCount);
            this.SpecialPanelDeliver.Controls.Add(this.dateTimePickerDeliverCreated);
            this.SpecialPanelDeliver.Controls.Add(this.dateTimePickerDeliverOffs);
            this.SpecialPanelDeliver.Controls.Add(this.dateTimePickerDeliverTake);
            this.SpecialPanelDeliver.Controls.Add(this.listBoxDeliverPath);
            this.SpecialPanelDeliver.Controls.Add(this.listBoxDeliverMat);
            this.SpecialPanelDeliver.Location = new System.Drawing.Point(139, 3);
            this.SpecialPanelDeliver.Name = "SpecialPanelDeliver";
            this.SpecialPanelDeliver.Size = new System.Drawing.Size(175, 193);
            this.SpecialPanelDeliver.TabIndex = 9;
            // 
            // textBoxDeliverCount
            // 
            this.textBoxDeliverCount.Location = new System.Drawing.Point(3, 3);
            this.textBoxDeliverCount.Name = "textBoxDeliverCount";
            this.textBoxDeliverCount.Size = new System.Drawing.Size(166, 22);
            this.textBoxDeliverCount.TabIndex = 1;
            // 
            // dateTimePickerDeliverCreated
            // 
            this.dateTimePickerDeliverCreated.Location = new System.Drawing.Point(3, 31);
            this.dateTimePickerDeliverCreated.Name = "dateTimePickerDeliverCreated";
            this.dateTimePickerDeliverCreated.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerDeliverCreated.TabIndex = 10;
            // 
            // dateTimePickerDeliverOffs
            // 
            this.dateTimePickerDeliverOffs.Location = new System.Drawing.Point(3, 59);
            this.dateTimePickerDeliverOffs.Name = "dateTimePickerDeliverOffs";
            this.dateTimePickerDeliverOffs.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerDeliverOffs.TabIndex = 11;
            // 
            // dateTimePickerDeliverTake
            // 
            this.dateTimePickerDeliverTake.Location = new System.Drawing.Point(3, 87);
            this.dateTimePickerDeliverTake.Name = "dateTimePickerDeliverTake";
            this.dateTimePickerDeliverTake.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerDeliverTake.TabIndex = 12;
            // 
            // listBoxDeliverPath
            // 
            this.listBoxDeliverPath.FormatString = "N0";
            this.listBoxDeliverPath.FormattingEnabled = true;
            this.listBoxDeliverPath.ItemHeight = 16;
            this.listBoxDeliverPath.Location = new System.Drawing.Point(3, 115);
            this.listBoxDeliverPath.Name = "listBoxDeliverPath";
            this.listBoxDeliverPath.Size = new System.Drawing.Size(159, 36);
            this.listBoxDeliverPath.TabIndex = 7;
            // 
            // listBoxDeliverMat
            // 
            this.listBoxDeliverMat.FormatString = "N0";
            this.listBoxDeliverMat.FormattingEnabled = true;
            this.listBoxDeliverMat.ItemHeight = 16;
            this.listBoxDeliverMat.Location = new System.Drawing.Point(3, 157);
            this.listBoxDeliverMat.Name = "listBoxDeliverMat";
            this.listBoxDeliverMat.Size = new System.Drawing.Size(159, 36);
            this.listBoxDeliverMat.TabIndex = 6;
            // 
            // panelSpecialSeller
            // 
            this.panelSpecialSeller.Controls.Add(this.dateTimePickerSellerOrder);
            this.panelSpecialSeller.Controls.Add(this.textBoxSellerCount);
            this.panelSpecialSeller.Controls.Add(this.listBoxSellerStage);
            this.panelSpecialSeller.Location = new System.Drawing.Point(3, 202);
            this.panelSpecialSeller.Name = "panelSpecialSeller";
            this.panelSpecialSeller.Size = new System.Drawing.Size(175, 193);
            this.panelSpecialSeller.TabIndex = 13;
            // 
            // dateTimePickerSellerOrder
            // 
            this.dateTimePickerSellerOrder.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerSellerOrder.Name = "dateTimePickerSellerOrder";
            this.dateTimePickerSellerOrder.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerSellerOrder.TabIndex = 13;
            // 
            // textBoxSellerCount
            // 
            this.textBoxSellerCount.Location = new System.Drawing.Point(3, 31);
            this.textBoxSellerCount.Name = "textBoxSellerCount";
            this.textBoxSellerCount.Size = new System.Drawing.Size(166, 22);
            this.textBoxSellerCount.TabIndex = 13;
            // 
            // listBoxSellerStage
            // 
            this.listBoxSellerStage.FormatString = "N0";
            this.listBoxSellerStage.FormattingEnabled = true;
            this.listBoxSellerStage.ItemHeight = 16;
            this.listBoxSellerStage.Location = new System.Drawing.Point(3, 59);
            this.listBoxSellerStage.Name = "listBoxSellerStage";
            this.listBoxSellerStage.Size = new System.Drawing.Size(159, 36);
            this.listBoxSellerStage.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.SpecialPanelPath);
            this.flowLayoutPanel2.Controls.Add(this.SpecialPanelDeliver);
            this.flowLayoutPanel2.Controls.Add(this.panelSpecialSeller);
            this.flowLayoutPanel2.Controls.Add(this.panelSpecialBuyer);
            this.flowLayoutPanel2.Controls.Add(this.specialPanelBoss);
            this.flowLayoutPanel2.Controls.Add(this.specialPanelOffs);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(411, 227);
            this.flowLayoutPanel2.TabIndex = 14;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panelSpecialBuyer
            // 
            this.panelSpecialBuyer.Controls.Add(this.dateTimePickerBuyer);
            this.panelSpecialBuyer.Controls.Add(this.textBoxBuyer);
            this.panelSpecialBuyer.Controls.Add(this.listBoxMatBuyer);
            this.panelSpecialBuyer.Controls.Add(this.listBoxStageBuyer);
            this.panelSpecialBuyer.Location = new System.Drawing.Point(184, 202);
            this.panelSpecialBuyer.Name = "panelSpecialBuyer";
            this.panelSpecialBuyer.Size = new System.Drawing.Size(175, 193);
            this.panelSpecialBuyer.TabIndex = 16;
            // 
            // dateTimePickerBuyer
            // 
            this.dateTimePickerBuyer.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerBuyer.Name = "dateTimePickerBuyer";
            this.dateTimePickerBuyer.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerBuyer.TabIndex = 13;
            // 
            // textBoxBuyer
            // 
            this.textBoxBuyer.Location = new System.Drawing.Point(3, 31);
            this.textBoxBuyer.Name = "textBoxBuyer";
            this.textBoxBuyer.Size = new System.Drawing.Size(166, 22);
            this.textBoxBuyer.TabIndex = 13;
            // 
            // listBoxMatBuyer
            // 
            this.listBoxMatBuyer.FormatString = "N0";
            this.listBoxMatBuyer.FormattingEnabled = true;
            this.listBoxMatBuyer.ItemHeight = 16;
            this.listBoxMatBuyer.Location = new System.Drawing.Point(3, 59);
            this.listBoxMatBuyer.Name = "listBoxMatBuyer";
            this.listBoxMatBuyer.Size = new System.Drawing.Size(159, 36);
            this.listBoxMatBuyer.TabIndex = 13;
            // 
            // listBoxStageBuyer
            // 
            this.listBoxStageBuyer.FormatString = "N0";
            this.listBoxStageBuyer.FormattingEnabled = true;
            this.listBoxStageBuyer.ItemHeight = 16;
            this.listBoxStageBuyer.Location = new System.Drawing.Point(3, 101);
            this.listBoxStageBuyer.Name = "listBoxStageBuyer";
            this.listBoxStageBuyer.Size = new System.Drawing.Size(159, 36);
            this.listBoxStageBuyer.TabIndex = 14;
            // 
            // specialPanelBoss
            // 
            this.specialPanelBoss.Controls.Add(this.dateTimePickerBossOrder);
            this.specialPanelBoss.Controls.Add(this.listBoxStageBoss);
            this.specialPanelBoss.Controls.Add(this.listBoxMatBoss);
            this.specialPanelBoss.Location = new System.Drawing.Point(3, 401);
            this.specialPanelBoss.Name = "specialPanelBoss";
            this.specialPanelBoss.Size = new System.Drawing.Size(175, 193);
            this.specialPanelBoss.TabIndex = 17;
            // 
            // dateTimePickerBossOrder
            // 
            this.dateTimePickerBossOrder.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerBossOrder.Name = "dateTimePickerBossOrder";
            this.dateTimePickerBossOrder.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerBossOrder.TabIndex = 13;
            // 
            // listBoxStageBoss
            // 
            this.listBoxStageBoss.FormatString = "N0";
            this.listBoxStageBoss.FormattingEnabled = true;
            this.listBoxStageBoss.ItemHeight = 16;
            this.listBoxStageBoss.Location = new System.Drawing.Point(3, 31);
            this.listBoxStageBoss.Name = "listBoxStageBoss";
            this.listBoxStageBoss.Size = new System.Drawing.Size(159, 36);
            this.listBoxStageBoss.TabIndex = 13;
            // 
            // listBoxMatBoss
            // 
            this.listBoxMatBoss.FormatString = "N0";
            this.listBoxMatBoss.FormattingEnabled = true;
            this.listBoxMatBoss.ItemHeight = 16;
            this.listBoxMatBoss.Location = new System.Drawing.Point(3, 73);
            this.listBoxMatBoss.Name = "listBoxMatBoss";
            this.listBoxMatBoss.Size = new System.Drawing.Size(159, 36);
            this.listBoxMatBoss.TabIndex = 14;
            this.listBoxMatBoss.SelectedValueChanged += new System.EventHandler(this.listMatValueChanged);
            // 
            // specialPanelOffs
            // 
            this.specialPanelOffs.Controls.Add(this.textBoxOffsCount);
            this.specialPanelOffs.Controls.Add(this.listBoxOffsStorage);
            this.specialPanelOffs.Location = new System.Drawing.Point(184, 401);
            this.specialPanelOffs.Name = "specialPanelOffs";
            this.specialPanelOffs.Size = new System.Drawing.Size(175, 193);
            this.specialPanelOffs.TabIndex = 18;
            // 
            // textBoxOffsCount
            // 
            this.textBoxOffsCount.Location = new System.Drawing.Point(3, 3);
            this.textBoxOffsCount.Name = "textBoxOffsCount";
            this.textBoxOffsCount.Size = new System.Drawing.Size(166, 22);
            this.textBoxOffsCount.TabIndex = 15;
            // 
            // listBoxOffsStorage
            // 
            this.listBoxOffsStorage.FormatString = "N0";
            this.listBoxOffsStorage.FormattingEnabled = true;
            this.listBoxOffsStorage.ItemHeight = 16;
            this.listBoxOffsStorage.Location = new System.Drawing.Point(3, 31);
            this.listBoxOffsStorage.Name = "listBoxOffsStorage";
            this.listBoxOffsStorage.Size = new System.Drawing.Size(159, 36);
            this.listBoxOffsStorage.TabIndex = 16;
            // 
            // SpecialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 316);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button_OK);
            this.Name = "SpecialWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecialWindow";
            this.Load += new System.EventHandler(this.SpecialWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.маршрутTableAdapterBindingSource)).EndInit();
            this.SpecialPanelPath.ResumeLayout(false);
            this.SpecialPanelPath.PerformLayout();
            this.SpecialPanelDeliver.ResumeLayout(false);
            this.SpecialPanelDeliver.PerformLayout();
            this.panelSpecialSeller.ResumeLayout(false);
            this.panelSpecialSeller.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelSpecialBuyer.ResumeLayout(false);
            this.panelSpecialBuyer.PerformLayout();
            this.specialPanelBoss.ResumeLayout(false);
            this.specialPanelOffs.ResumeLayout(false);
            this.specialPanelOffs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxTimePath;
        public DataSet1TableAdapters.маршрутTableAdapter маршрутTableAdapter1;
        public DataSet1TableAdapters.складTableAdapter складTableAdapter1;
        public System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource маршрутTableAdapterBindingSource;
        public System.Windows.Forms.ListBox listBoxToPath;
        public System.Windows.Forms.ListBox listBoxFromPath;
        public System.Windows.Forms.FlowLayoutPanel SpecialPanelPath;
        public System.Windows.Forms.FlowLayoutPanel SpecialPanelDeliver;
        public System.Windows.Forms.TextBox textBoxDeliverCount;
        public System.Windows.Forms.DateTimePicker dateTimePickerDeliverCreated;
        public System.Windows.Forms.DateTimePicker dateTimePickerDeliverOffs;
        public System.Windows.Forms.DateTimePicker dateTimePickerDeliverTake;
        public System.Windows.Forms.ListBox listBoxDeliverPath;
        public System.Windows.Forms.ListBox listBoxDeliverMat;
        public System.Windows.Forms.FlowLayoutPanel panelSpecialSeller;
        public System.Windows.Forms.ListBox listBoxTransit;
        public System.Windows.Forms.DateTimePicker dateTimePickerSellerOrder;
        public System.Windows.Forms.TextBox textBoxSellerCount;
        public System.Windows.Forms.ListBox listBoxSellerStage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel panelSpecialBuyer;
        public System.Windows.Forms.DateTimePicker dateTimePickerBuyer;
        public System.Windows.Forms.TextBox textBoxBuyer;
        public System.Windows.Forms.ListBox listBoxMatBuyer;
        public System.Windows.Forms.ListBox listBoxStageBuyer;
        public System.Windows.Forms.FlowLayoutPanel specialPanelBoss;
        public System.Windows.Forms.ListBox listBoxStageBoss;
        public System.Windows.Forms.ListBox listBoxMatBoss;
        public System.Windows.Forms.DateTimePicker dateTimePickerBossOrder;
        public System.Windows.Forms.FlowLayoutPanel specialPanelOffs;
        public System.Windows.Forms.TextBox textBoxOffsCount;
        public System.Windows.Forms.ListBox listBoxOffsStorage;
    }
}