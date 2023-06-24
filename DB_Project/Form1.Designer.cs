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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMaterial = new System.Windows.Forms.Button();
            this.buttonStorage = new System.Windows.Forms.Button();
            this.buttonOffs = new System.Windows.Forms.Button();
            this.buttonStage = new System.Windows.Forms.Button();
            this.buttonStocks = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonDeliveries = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonPath = new System.Windows.Forms.Button();
            this.buttonTravel = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelEverything = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBoss = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.panelStocks = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTakeBaggage = new System.Windows.Forms.Button();
            this.buttonSendBaggage = new System.Windows.Forms.Button();
            this.panelLogist = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.buttonAddDeliver = new System.Windows.Forms.Button();
            this.panelBuyer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCreateSupply = new System.Windows.Forms.Button();
            this.panelSeller = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelEverything.SuspendLayout();
            this.panelBoss.SuspendLayout();
            this.panelStocks.SuspendLayout();
            this.panelLogist.SuspendLayout();
            this.panelBuyer.SuspendLayout();
            this.panelSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 458);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonMaterial);
            this.flowLayoutPanel1.Controls.Add(this.buttonStorage);
            this.flowLayoutPanel1.Controls.Add(this.buttonOffs);
            this.flowLayoutPanel1.Controls.Add(this.buttonStage);
            this.flowLayoutPanel1.Controls.Add(this.buttonStocks);
            this.flowLayoutPanel1.Controls.Add(this.buttonOrder);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeliveries);
            this.flowLayoutPanel1.Controls.Add(this.buttonOutput);
            this.flowLayoutPanel1.Controls.Add(this.buttonPath);
            this.flowLayoutPanel1.Controls.Add(this.buttonTravel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 550);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonMaterial
            // 
            this.buttonMaterial.Location = new System.Drawing.Point(3, 3);
            this.buttonMaterial.Name = "buttonMaterial";
            this.buttonMaterial.Size = new System.Drawing.Size(197, 46);
            this.buttonMaterial.TabIndex = 1;
            this.buttonMaterial.Text = "Материалы";
            this.buttonMaterial.UseVisualStyleBackColor = true;
            this.buttonMaterial.Click += new System.EventHandler(this.buttonMaterial_Click);
            // 
            // buttonStorage
            // 
            this.buttonStorage.Location = new System.Drawing.Point(3, 55);
            this.buttonStorage.Name = "buttonStorage";
            this.buttonStorage.Size = new System.Drawing.Size(197, 46);
            this.buttonStorage.TabIndex = 7;
            this.buttonStorage.Text = "Склады";
            this.buttonStorage.UseVisualStyleBackColor = true;
            this.buttonStorage.Click += new System.EventHandler(this.buttonStorage_Click);
            // 
            // buttonOffs
            // 
            this.buttonOffs.Location = new System.Drawing.Point(3, 107);
            this.buttonOffs.Name = "buttonOffs";
            this.buttonOffs.Size = new System.Drawing.Size(197, 43);
            this.buttonOffs.TabIndex = 8;
            this.buttonOffs.Text = "Списание";
            this.buttonOffs.UseVisualStyleBackColor = true;
            this.buttonOffs.Click += new System.EventHandler(this.buttonOffs_Click);
            // 
            // buttonStage
            // 
            this.buttonStage.Location = new System.Drawing.Point(3, 156);
            this.buttonStage.Name = "buttonStage";
            this.buttonStage.Size = new System.Drawing.Size(197, 48);
            this.buttonStage.TabIndex = 9;
            this.buttonStage.Text = "Этап";
            this.buttonStage.UseVisualStyleBackColor = true;
            this.buttonStage.Click += new System.EventHandler(this.buttonStage_Click);
            // 
            // buttonStocks
            // 
            this.buttonStocks.Location = new System.Drawing.Point(3, 210);
            this.buttonStocks.Name = "buttonStocks";
            this.buttonStocks.Size = new System.Drawing.Size(197, 48);
            this.buttonStocks.TabIndex = 6;
            this.buttonStocks.Text = "Запасы";
            this.buttonStocks.UseVisualStyleBackColor = true;
            this.buttonStocks.Click += new System.EventHandler(this.buttonStocks_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(3, 264);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(197, 49);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "Производство";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonDeliveries
            // 
            this.buttonDeliveries.Location = new System.Drawing.Point(3, 319);
            this.buttonDeliveries.Name = "buttonDeliveries";
            this.buttonDeliveries.Size = new System.Drawing.Size(197, 50);
            this.buttonDeliveries.TabIndex = 3;
            this.buttonDeliveries.Text = "Поставки";
            this.buttonDeliveries.UseVisualStyleBackColor = true;
            this.buttonDeliveries.Click += new System.EventHandler(this.buttonDeliveries_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(3, 375);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(197, 53);
            this.buttonOutput.TabIndex = 5;
            this.buttonOutput.Text = "Выход_ГП";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(3, 434);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(197, 44);
            this.buttonPath.TabIndex = 0;
            this.buttonPath.Text = "Маршрут";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // buttonTravel
            // 
            this.buttonTravel.Location = new System.Drawing.Point(3, 484);
            this.buttonTravel.Name = "buttonTravel";
            this.buttonTravel.Size = new System.Drawing.Size(197, 59);
            this.buttonTravel.TabIndex = 2;
            this.buttonTravel.Text = "Перемещение";
            this.buttonTravel.UseVisualStyleBackColor = true;
            this.buttonTravel.Click += new System.EventHandler(this.buttonTravel_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(3, 7);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(42, 16);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Роль ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRole);
            this.panel1.Location = new System.Drawing.Point(13, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 31);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanelEverything
            // 
            this.flowLayoutPanelEverything.Controls.Add(this.panelBoss);
            this.flowLayoutPanelEverything.Controls.Add(this.panelStocks);
            this.flowLayoutPanelEverything.Controls.Add(this.panelLogist);
            this.flowLayoutPanelEverything.Controls.Add(this.panelBuyer);
            this.flowLayoutPanelEverything.Controls.Add(this.panelSeller);
            this.flowLayoutPanelEverything.Location = new System.Drawing.Point(219, 36);
            this.flowLayoutPanelEverything.Name = "flowLayoutPanelEverything";
            this.flowLayoutPanelEverything.Size = new System.Drawing.Size(908, 68);
            this.flowLayoutPanelEverything.TabIndex = 4;
            // 
            // panelBoss
            // 
            this.panelBoss.Controls.Add(this.buttonUpdateOrder);
            this.panelBoss.Location = new System.Drawing.Point(3, 3);
            this.panelBoss.Name = "panelBoss";
            this.panelBoss.Size = new System.Drawing.Size(175, 55);
            this.panelBoss.TabIndex = 6;
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(3, 3);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(172, 43);
            this.buttonUpdateOrder.TabIndex = 1;
            this.buttonUpdateOrder.Text = "Обновить статус заказа";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // panelStocks
            // 
            this.panelStocks.Controls.Add(this.buttonTakeBaggage);
            this.panelStocks.Controls.Add(this.buttonSendBaggage);
            this.panelStocks.Location = new System.Drawing.Point(184, 3);
            this.panelStocks.Name = "panelStocks";
            this.panelStocks.Size = new System.Drawing.Size(182, 55);
            this.panelStocks.TabIndex = 5;
            // 
            // buttonTakeBaggage
            // 
            this.buttonTakeBaggage.Location = new System.Drawing.Point(3, 3);
            this.buttonTakeBaggage.Name = "buttonTakeBaggage";
            this.buttonTakeBaggage.Size = new System.Drawing.Size(86, 42);
            this.buttonTakeBaggage.TabIndex = 0;
            this.buttonTakeBaggage.Text = "Прием груза";
            this.buttonTakeBaggage.UseVisualStyleBackColor = true;
            this.buttonTakeBaggage.Click += new System.EventHandler(this.buttonTakeBaggage_Click);
            // 
            // buttonSendBaggage
            // 
            this.buttonSendBaggage.Location = new System.Drawing.Point(95, 3);
            this.buttonSendBaggage.Name = "buttonSendBaggage";
            this.buttonSendBaggage.Size = new System.Drawing.Size(83, 43);
            this.buttonSendBaggage.TabIndex = 1;
            this.buttonSendBaggage.Text = "Отправка груза";
            this.buttonSendBaggage.UseVisualStyleBackColor = true;
            this.buttonSendBaggage.Click += new System.EventHandler(this.buttonSendBaggage_Click);
            // 
            // panelLogist
            // 
            this.panelLogist.Controls.Add(this.buttonAddPath);
            this.panelLogist.Controls.Add(this.buttonAddDeliver);
            this.panelLogist.Location = new System.Drawing.Point(372, 3);
            this.panelLogist.Name = "panelLogist";
            this.panelLogist.Size = new System.Drawing.Size(316, 55);
            this.panelLogist.TabIndex = 7;
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.Location = new System.Drawing.Point(3, 3);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(133, 43);
            this.buttonAddPath.TabIndex = 8;
            this.buttonAddPath.Text = "Создать маршрут";
            this.buttonAddPath.UseVisualStyleBackColor = true;
            this.buttonAddPath.Click += new System.EventHandler(this.buttonAddPath_Click);
            // 
            // buttonAddDeliver
            // 
            this.buttonAddDeliver.Location = new System.Drawing.Point(142, 3);
            this.buttonAddDeliver.Name = "buttonAddDeliver";
            this.buttonAddDeliver.Size = new System.Drawing.Size(169, 43);
            this.buttonAddDeliver.TabIndex = 9;
            this.buttonAddDeliver.Text = "Сформировать пер-ние";
            this.buttonAddDeliver.UseVisualStyleBackColor = true;
            this.buttonAddDeliver.Click += new System.EventHandler(this.buttonAddDeliver_Click);
            // 
            // panelBuyer
            // 
            this.panelBuyer.Controls.Add(this.buttonCreateSupply);
            this.panelBuyer.Location = new System.Drawing.Point(694, 3);
            this.panelBuyer.Name = "panelBuyer";
            this.panelBuyer.Size = new System.Drawing.Size(98, 55);
            this.panelBuyer.TabIndex = 8;
            // 
            // buttonCreateSupply
            // 
            this.buttonCreateSupply.Location = new System.Drawing.Point(3, 3);
            this.buttonCreateSupply.Name = "buttonCreateSupply";
            this.buttonCreateSupply.Size = new System.Drawing.Size(95, 43);
            this.buttonCreateSupply.TabIndex = 10;
            this.buttonCreateSupply.Text = "Оформить поставку";
            this.buttonCreateSupply.UseVisualStyleBackColor = true;
            this.buttonCreateSupply.Click += new System.EventHandler(this.buttonCreateSupply_Click);
            // 
            // panelSeller
            // 
            this.panelSeller.Controls.Add(this.buttonCreateOrder);
            this.panelSeller.Location = new System.Drawing.Point(798, 3);
            this.panelSeller.Name = "panelSeller";
            this.panelSeller.Size = new System.Drawing.Size(92, 55);
            this.panelSeller.TabIndex = 11;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(3, 3);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(85, 43);
            this.buttonCreateOrder.TabIndex = 10;
            this.buttonCreateOrder.Text = "Оформить заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 598);
            this.Controls.Add(this.flowLayoutPanelEverything);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelEverything.ResumeLayout(false);
            this.panelBoss.ResumeLayout(false);
            this.panelStocks.ResumeLayout(false);
            this.panelLogist.ResumeLayout(false);
            this.panelBuyer.ResumeLayout(false);
            this.panelSeller.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Button buttonMaterial;
        private System.Windows.Forms.Button buttonTravel;
        private System.Windows.Forms.Button buttonDeliveries;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonStocks;
        private System.Windows.Forms.Button buttonStorage;
        private System.Windows.Forms.Button buttonOffs;
        private System.Windows.Forms.Button buttonStage;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEverything;
        private System.Windows.Forms.Button buttonTakeBaggage;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.FlowLayoutPanel panelBoss;
        private System.Windows.Forms.FlowLayoutPanel panelStocks;
        private System.Windows.Forms.FlowLayoutPanel panelLogist;
        private System.Windows.Forms.Button buttonAddPath;
        private System.Windows.Forms.Button buttonAddDeliver;
        private System.Windows.Forms.FlowLayoutPanel panelBuyer;
        private System.Windows.Forms.Button buttonCreateSupply;
        private System.Windows.Forms.FlowLayoutPanel panelSeller;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonSendBaggage;
    }
}

