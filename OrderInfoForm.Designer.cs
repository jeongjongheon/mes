namespace MES
{
    partial class OrderInfoForm
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
            this.orderInfoHeadDgv = new System.Windows.Forms.DataGridView();
            this.orderInfoBodyDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.excelExportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoHeadDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoBodyDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // orderInfoHeadDgv
            // 
            this.orderInfoHeadDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderInfoHeadDgv.Location = new System.Drawing.Point(25, 52);
            this.orderInfoHeadDgv.Name = "orderInfoHeadDgv";
            this.orderInfoHeadDgv.RowTemplate.Height = 23;
            this.orderInfoHeadDgv.Size = new System.Drawing.Size(559, 348);
            this.orderInfoHeadDgv.TabIndex = 0;
            this.orderInfoHeadDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderInfoHeadDgv_CellClick);
            this.orderInfoHeadDgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.orderInfoHeadDgv_RowPostPaint);
            // 
            // orderInfoBodyDgv
            // 
            this.orderInfoBodyDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderInfoBodyDgv.Location = new System.Drawing.Point(421, 406);
            this.orderInfoBodyDgv.Name = "orderInfoBodyDgv";
            this.orderInfoBodyDgv.Size = new System.Drawing.Size(381, 130);
            this.orderInfoBodyDgv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ORDER_INFO_HEAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ORDER_INFO_BODY";
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(140, 428);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(109, 61);
            this.orderBtn.TabIndex = 4;
            this.orderBtn.Text = "주문";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // excelExportBtn
            // 
            this.excelExportBtn.Location = new System.Drawing.Point(255, 428);
            this.excelExportBtn.Name = "excelExportBtn";
            this.excelExportBtn.Size = new System.Drawing.Size(109, 61);
            this.excelExportBtn.TabIndex = 6;
            this.excelExportBtn.Text = "엑셀출력";
            this.excelExportBtn.UseVisualStyleBackColor = true;
            this.excelExportBtn.Click += new System.EventHandler(this.excelExportBtn_Click);
            // 
            // OrderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 548);
            this.Controls.Add(this.excelExportBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderInfoBodyDgv);
            this.Controls.Add(this.orderInfoHeadDgv);
            this.Name = "OrderInfoForm";
            this.Text = "OrderInfoForm";
            this.Load += new System.EventHandler(this.OrderInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoHeadDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoBodyDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderInfoHeadDgv;
        private System.Windows.Forms.DataGridView orderInfoBodyDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button excelExportBtn;
    }
}