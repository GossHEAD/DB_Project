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
            this.button_OK = new System.Windows.Forms.Button();
            this.comboBoxTypeAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxSybTypeAdd = new System.Windows.Forms.ComboBox();
            this.textBoxNameAdd = new System.Windows.Forms.RichTextBox();
            this.comboBoxPropEx = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.маршрутTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.маршрутTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(12, 146);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(107, 60);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // comboBoxTypeAdd
            // 
            this.comboBoxTypeAdd.FormattingEnabled = true;
            this.comboBoxTypeAdd.Location = new System.Drawing.Point(12, 67);
            this.comboBoxTypeAdd.Name = "comboBoxTypeAdd";
            this.comboBoxTypeAdd.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTypeAdd.TabIndex = 6;
            this.comboBoxTypeAdd.Text = "Тип";
            // 
            // comboBoxSybTypeAdd
            // 
            this.comboBoxSybTypeAdd.FormattingEnabled = true;
            this.comboBoxSybTypeAdd.Location = new System.Drawing.Point(153, 67);
            this.comboBoxSybTypeAdd.Name = "comboBoxSybTypeAdd";
            this.comboBoxSybTypeAdd.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSybTypeAdd.TabIndex = 7;
            this.comboBoxSybTypeAdd.Text = "Подтип";
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Location = new System.Drawing.Point(13, 30);
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(120, 31);
            this.textBoxNameAdd.TabIndex = 8;
            this.textBoxNameAdd.Text = "Название";
            // 
            // comboBoxPropEx
            // 
            this.comboBoxPropEx.FormattingEnabled = true;
            this.comboBoxPropEx.Location = new System.Drawing.Point(12, 97);
            this.comboBoxPropEx.Name = "comboBoxPropEx";
            this.comboBoxPropEx.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPropEx.TabIndex = 9;
            this.comboBoxPropEx.Text = "Свойства";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(139, 97);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(198, 27);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "Св-ва, которые будут у экстр";
            // 
            // SpecialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 219);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.comboBoxPropEx);
            this.Controls.Add(this.textBoxNameAdd);
            this.Controls.Add(this.comboBoxSybTypeAdd);
            this.Controls.Add(this.comboBoxTypeAdd);
            this.Controls.Add(this.button_OK);
            this.Name = "SpecialWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecialWindow";
            ((System.ComponentModel.ISupportInitialize)(this.маршрутTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //public DataSet1TableAdapters.маршрутTableAdapter маршрутTableAdapter1;
        //public DataSet1TableAdapters.складTableAdapter складTableAdapter1;
        public System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource маршрутTableAdapterBindingSource;
        private System.Windows.Forms.ComboBox comboBoxTypeAdd;
        private System.Windows.Forms.ComboBox comboBoxSybTypeAdd;
        private System.Windows.Forms.RichTextBox textBoxNameAdd;
        private System.Windows.Forms.ComboBox comboBoxPropEx;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}