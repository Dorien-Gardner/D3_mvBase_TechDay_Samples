namespace WindowsFormsApplication_Acme_Soap
{
    partial class Invoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNo,
            this.InvoiceDate,
            this.OrderDate,
            this.SalesRep,
            this.Terms,
            this.TotalGross,
            this.TotalDiscount,
            this.TotalNet,
            this.Comments});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.Location = new System.Drawing.Point(12, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1038, 235);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // InvoiceNo
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue;
            this.InvoiceNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.InvoiceNo.HeaderText = "Invoice #";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.HeaderText = "Invoice Date";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // SalesRep
            // 
            this.SalesRep.HeaderText = "Sales Rep";
            this.SalesRep.MinimumWidth = 150;
            this.SalesRep.Name = "SalesRep";
            this.SalesRep.ReadOnly = true;
            this.SalesRep.Width = 150;
            // 
            // Terms
            // 
            this.Terms.HeaderText = "Terms";
            this.Terms.MinimumWidth = 80;
            this.Terms.Name = "Terms";
            this.Terms.ReadOnly = true;
            this.Terms.Width = 80;
            // 
            // TotalGross
            // 
            dataGridViewCellStyle9.Format = "C0";
            dataGridViewCellStyle9.NullValue = null;
            this.TotalGross.DefaultCellStyle = dataGridViewCellStyle9;
            this.TotalGross.HeaderText = "Total Gross";
            this.TotalGross.Name = "TotalGross";
            this.TotalGross.ReadOnly = true;
            // 
            // TotalDiscount
            // 
            dataGridViewCellStyle10.Format = "C0";
            dataGridViewCellStyle10.NullValue = null;
            this.TotalDiscount.DefaultCellStyle = dataGridViewCellStyle10;
            this.TotalDiscount.HeaderText = "Total Discount";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.ReadOnly = true;
            // 
            // TotalNet
            // 
            dataGridViewCellStyle11.Format = "C0";
            dataGridViewCellStyle11.NullValue = null;
            this.TotalNet.DefaultCellStyle = dataGridViewCellStyle11;
            this.TotalNet.HeaderText = "Total Net";
            this.TotalNet.Name = "TotalNet";
            this.TotalNet.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.MinimumWidth = 200;
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 200;
            // 
            // NewSearch
            // 
            this.NewSearch.Location = new System.Drawing.Point(944, 196);
            this.NewSearch.Name = "NewSearch";
            this.NewSearch.Size = new System.Drawing.Size(106, 23);
            this.NewSearch.TabIndex = 1;
            this.NewSearch.Text = "New Search";
            this.NewSearch.UseVisualStyleBackColor = true;
            this.NewSearch.Click += new System.EventHandler(this.NewSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 171);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 3;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewSearch);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Invoices";
            this.Text = "Customer Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGross;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.Button NewSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}