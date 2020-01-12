namespace WinUI
{
    partial class FormMain
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
            this.groupBoxProductListFromWeb = new System.Windows.Forms.GroupBox();
            this.checkedListMalls = new System.Windows.Forms.CheckedListBox();
            this.btnProductListFromWeb = new System.Windows.Forms.Button();
            this.textBoxProductFilterForWeb = new System.Windows.Forms.TextBox();
            this.groupBoxListFromDb = new System.Windows.Forms.GroupBox();
            this.btnProductListFromDb = new System.Windows.Forms.Button();
            this.textBoxProductFilterForDb = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridProductList = new System.Windows.Forms.DataGridView();
            this.groupBoxProductListFromWeb.SuspendLayout();
            this.groupBoxListFromDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProductListFromWeb
            // 
            this.groupBoxProductListFromWeb.Controls.Add(this.checkedListMalls);
            this.groupBoxProductListFromWeb.Controls.Add(this.btnProductListFromWeb);
            this.groupBoxProductListFromWeb.Controls.Add(this.textBoxProductFilterForWeb);
            this.groupBoxProductListFromWeb.Location = new System.Drawing.Point(12, 521);
            this.groupBoxProductListFromWeb.Name = "groupBoxProductListFromWeb";
            this.groupBoxProductListFromWeb.Size = new System.Drawing.Size(308, 85);
            this.groupBoxProductListFromWeb.TabIndex = 7;
            this.groupBoxProductListFromWeb.TabStop = false;
            this.groupBoxProductListFromWeb.Text = "Ürün Sorgulama";
            // 
            // checkedListMalls
            // 
            this.checkedListMalls.FormattingEnabled = true;
            this.checkedListMalls.Location = new System.Drawing.Point(199, 15);
            this.checkedListMalls.Name = "checkedListMalls";
            this.checkedListMalls.Size = new System.Drawing.Size(103, 64);
            this.checkedListMalls.TabIndex = 8;
            // 
            // btnProductListFromWeb
            // 
            this.btnProductListFromWeb.Location = new System.Drawing.Point(6, 56);
            this.btnProductListFromWeb.Name = "btnProductListFromWeb";
            this.btnProductListFromWeb.Size = new System.Drawing.Size(105, 23);
            this.btnProductListFromWeb.TabIndex = 1;
            this.btnProductListFromWeb.Text = "Ürünleri Listele";
            this.btnProductListFromWeb.UseVisualStyleBackColor = true;
            this.btnProductListFromWeb.Click += new System.EventHandler(this.btnProductListFromWeb_Click);
            // 
            // textBoxProductFilterForWeb
            // 
            this.textBoxProductFilterForWeb.Location = new System.Drawing.Point(6, 26);
            this.textBoxProductFilterForWeb.Name = "textBoxProductFilterForWeb";
            this.textBoxProductFilterForWeb.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductFilterForWeb.TabIndex = 0;
            this.textBoxProductFilterForWeb.Text = "ÜrünAra";
            // 
            // groupBoxListFromDb
            // 
            this.groupBoxListFromDb.Controls.Add(this.btnProductListFromDb);
            this.groupBoxListFromDb.Controls.Add(this.textBoxProductFilterForDb);
            this.groupBoxListFromDb.Location = new System.Drawing.Point(388, 515);
            this.groupBoxListFromDb.Name = "groupBoxListFromDb";
            this.groupBoxListFromDb.Size = new System.Drawing.Size(265, 85);
            this.groupBoxListFromDb.TabIndex = 6;
            this.groupBoxListFromDb.TabStop = false;
            this.groupBoxListFromDb.Text = "Ürün Listeleme";
            // 
            // btnProductListFromDb
            // 
            this.btnProductListFromDb.Location = new System.Drawing.Point(149, 23);
            this.btnProductListFromDb.Name = "btnProductListFromDb";
            this.btnProductListFromDb.Size = new System.Drawing.Size(105, 23);
            this.btnProductListFromDb.TabIndex = 1;
            this.btnProductListFromDb.Text = "Ürünleri Listele";
            this.btnProductListFromDb.UseVisualStyleBackColor = true;
            this.btnProductListFromDb.Click += new System.EventHandler(this.btnProductListFromDb_Click);
            // 
            // textBoxProductFilterForDb
            // 
            this.textBoxProductFilterForDb.Location = new System.Drawing.Point(6, 26);
            this.textBoxProductFilterForDb.Name = "textBoxProductFilterForDb";
            this.textBoxProductFilterForDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductFilterForDb.TabIndex = 0;
            this.textBoxProductFilterForDb.Text = "ÜrünAra";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(225, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Ürün Listeleme";
            // 
            // dataGridProductList
            // 
            this.dataGridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductList.Location = new System.Drawing.Point(12, 56);
            this.dataGridProductList.Name = "dataGridProductList";
            this.dataGridProductList.Size = new System.Drawing.Size(641, 440);
            this.dataGridProductList.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 647);
            this.Controls.Add(this.groupBoxProductListFromWeb);
            this.Controls.Add(this.groupBoxListFromDb);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridProductList);
            this.Name = "FormMain";
            this.Text = "Ürün Listeleme";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxProductListFromWeb.ResumeLayout(false);
            this.groupBoxProductListFromWeb.PerformLayout();
            this.groupBoxListFromDb.ResumeLayout(false);
            this.groupBoxListFromDb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProductListFromWeb;
        private System.Windows.Forms.Button btnProductListFromWeb;
        private System.Windows.Forms.TextBox textBoxProductFilterForWeb;
        private System.Windows.Forms.GroupBox groupBoxListFromDb;
        private System.Windows.Forms.Button btnProductListFromDb;
        private System.Windows.Forms.TextBox textBoxProductFilterForDb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridProductList;
        private System.Windows.Forms.CheckedListBox checkedListMalls;
    }
}

