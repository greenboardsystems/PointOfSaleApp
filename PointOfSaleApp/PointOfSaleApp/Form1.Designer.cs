
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.gbViewData = new System.Windows.Forms.GroupBox();
            this.dgvProductData = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbInsertData.SuspendLayout();
            this.gbViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInsertData
            // 
            this.gbInsertData.Controls.Add(this.btnDelete);
            this.gbInsertData.Controls.Add(this.txtProductID);
            this.gbInsertData.Controls.Add(this.lblProductID);
            this.gbInsertData.Controls.Add(this.btnUpdate);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(296, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(33, 99);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(33, 73);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(33, 47);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(114, 96);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(257, 151);
            this.txtRemarks.TabIndex = 2;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(114, 70);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(257, 20);
            this.txtProductPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(114, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(257, 20);
            this.txtProductName.TabIndex = 0;
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
            // dgvProductData
            // 
            this.dgvProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductData.Location = new System.Drawing.Point(6, 50);
            this.dgvProductData.Name = "dgvProductData";
            this.dgvProductData.Size = new System.Drawing.Size(386, 206);
            this.dgvProductData.TabIndex = 1;
            this.dgvProductData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductData_RowHeaderMouseDoubleClick);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(215, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(33, 22);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 9;
            this.lblProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(114, 19);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(257, 20);
            this.txtProductID.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnDelete;
    }
}

