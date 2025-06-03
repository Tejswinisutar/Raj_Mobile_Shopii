
namespace Raj_mobile_Shopee.Customer
{
    partial class frm_Customer
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
            this.pnl_ = new System.Windows.Forms.Panel();
            this.btn_Add_Customer = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.btn_Update_Customer = new System.Windows.Forms.Button();
            this.pnl_Customer_Header = new System.Windows.Forms.Panel();
            this.pnl_.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_
            // 
            this.pnl_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_.Controls.Add(this.btn_Add_Customer);
            this.pnl_.Controls.Add(this.btn_View_List);
            this.pnl_.Controls.Add(this.btn_Update_Customer);
            this.pnl_.Location = new System.Drawing.Point(0, 1);
            this.pnl_.Name = "pnl_";
            this.pnl_.Size = new System.Drawing.Size(1102, 123);
            this.pnl_.TabIndex = 0;
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Customer.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_Customer.Location = new System.Drawing.Point(102, 32);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Size = new System.Drawing.Size(207, 59);
            this.btn_Add_Customer.TabIndex = 2;
            this.btn_Add_Customer.Text = "Add Customer";
            this.btn_Add_Customer.UseVisualStyleBackColor = true;
            // 
            // btn_View_List
            // 
            this.btn_View_List.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.ForeColor = System.Drawing.Color.Red;
            this.btn_View_List.Location = new System.Drawing.Point(821, 32);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(176, 56);
            this.btn_View_List.TabIndex = 1;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Customer
            // 
            this.btn_Update_Customer.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Customer.ForeColor = System.Drawing.Color.Red;
            this.btn_Update_Customer.Location = new System.Drawing.Point(468, 32);
            this.btn_Update_Customer.Name = "btn_Update_Customer";
            this.btn_Update_Customer.Size = new System.Drawing.Size(225, 56);
            this.btn_Update_Customer.TabIndex = 0;
            this.btn_Update_Customer.Text = "Update Customer";
            this.btn_Update_Customer.UseVisualStyleBackColor = true;
            // 
            // pnl_Customer_Header
            // 
            this.pnl_Customer_Header.Location = new System.Drawing.Point(0, 122);
            this.pnl_Customer_Header.Name = "pnl_Customer_Header";
            this.pnl_Customer_Header.Size = new System.Drawing.Size(1102, 610);
            this.pnl_Customer_Header.TabIndex = 1;
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 732);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Customer_Header);
            this.Controls.Add(this.pnl_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer";
            this.Text = "frm_Customer";
            this.pnl_.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_;
        private System.Windows.Forms.Button btn_Add_Customer;
        private System.Windows.Forms.Button btn_View_List;
        private System.Windows.Forms.Button btn_Update_Customer;
        private System.Windows.Forms.Panel pnl_Customer_Header;
    }
}