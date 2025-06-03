
namespace Raj_mobile_Shopee.Product
{
    partial class frm_Add_Product
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
            this.pnl_Product_Header = new System.Windows.Forms.Panel();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.btn_Update_Product = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.pnl_Product_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Product_Header
            // 
            this.pnl_Product_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Product_Header.Controls.Add(this.btn_View_List);
            this.pnl_Product_Header.Controls.Add(this.btn_Update_Product);
            this.pnl_Product_Header.Controls.Add(this.btn_Add_Product);
            this.pnl_Product_Header.Location = new System.Drawing.Point(0, 1);
            this.pnl_Product_Header.Name = "pnl_Product_Header";
            this.pnl_Product_Header.Size = new System.Drawing.Size(1101, 123);
            this.pnl_Product_Header.TabIndex = 0;
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.Location = new System.Drawing.Point(98, 36);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(207, 59);
            this.btn_Add_Product.TabIndex = 3;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Product
            // 
            this.btn_Update_Product.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product.Location = new System.Drawing.Point(444, 36);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.Size = new System.Drawing.Size(207, 59);
            this.btn_Update_Product.TabIndex = 4;
            this.btn_Update_Product.Text = "Update Product";
            this.btn_Update_Product.UseVisualStyleBackColor = true;
            // 
            // btn_View_List
            // 
            this.btn_View_List.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.Location = new System.Drawing.Point(775, 36);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(207, 59);
            this.btn_View_List.TabIndex = 5;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = true;
            // 
            // frm_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 732);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Product_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Product";
            this.Text = "frm_Add_Product";
            this.pnl_Product_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Product_Header;
        private System.Windows.Forms.Button btn_View_List;
        private System.Windows.Forms.Button btn_Update_Product;
        private System.Windows.Forms.Button btn_Add_Product;
    }
}