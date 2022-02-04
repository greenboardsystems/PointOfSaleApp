
namespace PointOfSaleApp
{
    partial class Form1
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
            this.gbInsertData = new System.Windows.Forms.GroupBox();
            this.gbViewData = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dgvProductData = new System.Windows.Forms.DataGridView();
            this.gbInsertData.SuspendLayout();
            this.gbViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInsertData
            // 
            this.gbInsertData.Controls.Add(this.btnSave);
            this.gbInsertData.Controls.Add(this.lblRemarks);
            this.gbInsertData.Controls.Add(this.lblProductPrice);
            this.gbInsertData.Controls.Add(this.lblProductName);
            this.gbInsertData.Controls.Add(this.txtRemarks);
            this.gbInsertData.Controls.Add(this.txtProductPrice);
            this.gbInsertData.Controls.Add(this.txtProductName);
            this.gbInsertData.Location = new System.Drawing.Point(416, 12);
            this.gbInsertData.Name = "gbInsertData";
            this.gbInsertData.Size = new System.Drawing.Size(398, 282);
            this.gbInsertData.TabIndex = 0;
            this.gbInsertData.TabStop = false;
            this.gbInsertData.Text = "Insert Data";
            // 
            // gbViewData
            // 
            this.gbViewData.Controls.Add(this.dgvProductData);
            this.gbViewData.Controls.Add(this.btnLoadData);
            this.gbViewData.Location = new System.Drawing.Point(12, 12);
            this.gbViewData.Name = "gbViewData";
            this.gbViewData.Size = new System.Drawing.Size(398, 282);
            this.gbViewData.TabIndex = 1;
            this.gbViewData.TabStop = false;
            this.gbViewData.Text = "View Data";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(113, 24);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(257, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(113, 50);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(257, 20);
            this.txtProductPrice.TabIndex = 1;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(113, 76);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(257, 151);
            this.txtRemarks.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(32, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(32, 53);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(32, 79);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "Remarks";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(6, 22);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dgvProductData
            // 
            this.dgvProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductData.Location = new System.Drawing.Point(6, 50);
            this.dgvProductData.Name = "dgvProductData";
            this.dgvProductData.Size = new System.Drawing.Size(386, 206);
            this.dgvProductData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 306);
            this.Controls.Add(this.gbViewData);
            this.Controls.Add(this.gbInsertData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbInsertData.ResumeLayout(false);
            this.gbInsertData.PerformLayout();
            this.gbViewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsertData;
        private System.Windows.Forms.GroupBox gbViewData;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvProductData;
    }
}

