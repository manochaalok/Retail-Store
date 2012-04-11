namespace RetailStore
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
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblCustType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrocAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtNonGrocAmount = new System.Windows.Forms.TextBox();
            this.lblTotDiscount = new System.Windows.Forms.Label();
            this.lblNetPayAmount = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblCashDiscount = new System.Windows.Forms.Label();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakePayment.Location = new System.Drawing.Point(201, 190);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(225, 23);
            this.btnMakePayment.TabIndex = 0;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblCustType
            // 
            this.lblCustType.AutoSize = true;
            this.lblCustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustType.Location = new System.Drawing.Point(198, 67);
            this.lblCustType.Name = "lblCustType";
            this.lblCustType.Size = new System.Drawing.Size(72, 13);
            this.lblCustType.TabIndex = 1;
            this.lblCustType.Text = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Groc. Amount";
            // 
            // txtGrocAmount
            // 
            this.txtGrocAmount.Location = new System.Drawing.Point(325, 108);
            this.txtGrocAmount.Name = "txtGrocAmount";
            this.txtGrocAmount.Size = new System.Drawing.Size(121, 20);
            this.txtGrocAmount.TabIndex = 4;
            this.txtGrocAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrocAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "RETAIL STORE";
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.Location = new System.Drawing.Point(198, 149);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(109, 13);
            this.lblItemType.TabIndex = 12;
            this.lblItemType.Text = "Non Groc. Amount";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(326, 67);
            this.txtCustomerID.MaxLength = 5;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerID.TabIndex = 14;
            this.txtCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // txtNonGrocAmount
            // 
            this.txtNonGrocAmount.Location = new System.Drawing.Point(326, 149);
            this.txtNonGrocAmount.Name = "txtNonGrocAmount";
            this.txtNonGrocAmount.Size = new System.Drawing.Size(121, 20);
            this.txtNonGrocAmount.TabIndex = 15;
            this.txtNonGrocAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNonGrocAmount_KeyPress);
            // 
            // lblTotDiscount
            // 
            this.lblTotDiscount.AutoSize = true;
            this.lblTotDiscount.Location = new System.Drawing.Point(17, 9);
            this.lblTotDiscount.Name = "lblTotDiscount";
            this.lblTotDiscount.Size = new System.Drawing.Size(105, 13);
            this.lblTotDiscount.TabIndex = 16;
            this.lblTotDiscount.Text = "Total %age Discount";
            // 
            // lblNetPayAmount
            // 
            this.lblNetPayAmount.AutoSize = true;
            this.lblNetPayAmount.Location = new System.Drawing.Point(17, 69);
            this.lblNetPayAmount.Name = "lblNetPayAmount";
            this.lblNetPayAmount.Size = new System.Drawing.Size(104, 13);
            this.lblNetPayAmount.TabIndex = 17;
            this.lblNetPayAmount.Text = "Net Payable Amount";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblCashDiscount);
            this.pnlSummary.Controls.Add(this.lblTotDiscount);
            this.pnlSummary.Controls.Add(this.lblNetPayAmount);
            this.pnlSummary.Location = new System.Drawing.Point(591, 67);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(204, 102);
            this.pnlSummary.TabIndex = 18;
            // 
            // lblCashDiscount
            // 
            this.lblCashDiscount.AutoSize = true;
            this.lblCashDiscount.Location = new System.Drawing.Point(18, 43);
            this.lblCashDiscount.Name = "lblCashDiscount";
            this.lblCashDiscount.Size = new System.Drawing.Size(76, 13);
            this.lblCashDiscount.TabIndex = 19;
            this.lblCashDiscount.Text = "Cash Discount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 510);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.txtNonGrocAmount);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGrocAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustType);
            this.Controls.Add(this.btnMakePayment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblCustType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrocAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtNonGrocAmount;
        private System.Windows.Forms.Label lblTotDiscount;
        private System.Windows.Forms.Label lblNetPayAmount;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblCashDiscount;
    }
}

