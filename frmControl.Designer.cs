namespace SalesManagementSystem
{
    partial class frmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProductReturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductImport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStorageManage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCategoryManage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(938, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.btnCategoryManage);
            this.panel2.Controls.Add(this.btnStorageManage);
            this.panel2.Controls.Add(this.btnProductImport);
            this.panel2.Controls.Add(this.btnProductReturn);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 483);
            this.panel2.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Bán hàng";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 20;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(206, 56);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "     Bán hàng";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(206, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 483);
            this.panel3.TabIndex = 2;
            // 
            // btnProductReturn
            // 
            this.btnProductReturn.Active = false;
            this.btnProductReturn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnProductReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnProductReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductReturn.BorderRadius = 0;
            this.btnProductReturn.ButtonText = "     Đổi trả";
            this.btnProductReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductReturn.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductReturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductReturn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductReturn.Iconimage")));
            this.btnProductReturn.Iconimage_right = null;
            this.btnProductReturn.Iconimage_right_Selected = null;
            this.btnProductReturn.Iconimage_Selected = null;
            this.btnProductReturn.IconMarginLeft = 20;
            this.btnProductReturn.IconMarginRight = 0;
            this.btnProductReturn.IconRightVisible = true;
            this.btnProductReturn.IconRightZoom = 0D;
            this.btnProductReturn.IconVisible = true;
            this.btnProductReturn.IconZoom = 40D;
            this.btnProductReturn.IsTab = false;
            this.btnProductReturn.Location = new System.Drawing.Point(0, 56);
            this.btnProductReturn.Name = "btnProductReturn";
            this.btnProductReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnProductReturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.btnProductReturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductReturn.selected = false;
            this.btnProductReturn.Size = new System.Drawing.Size(206, 56);
            this.btnProductReturn.TabIndex = 1;
            this.btnProductReturn.Text = "     Đổi trả";
            this.btnProductReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductReturn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProductReturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnProductImport
            // 
            this.btnProductImport.Active = false;
            this.btnProductImport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnProductImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnProductImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductImport.BorderRadius = 0;
            this.btnProductImport.ButtonText = "     Nhập hàng";
            this.btnProductImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductImport.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductImport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductImport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductImport.Iconimage")));
            this.btnProductImport.Iconimage_right = null;
            this.btnProductImport.Iconimage_right_Selected = null;
            this.btnProductImport.Iconimage_Selected = null;
            this.btnProductImport.IconMarginLeft = 20;
            this.btnProductImport.IconMarginRight = 0;
            this.btnProductImport.IconRightVisible = true;
            this.btnProductImport.IconRightZoom = 0D;
            this.btnProductImport.IconVisible = true;
            this.btnProductImport.IconZoom = 40D;
            this.btnProductImport.IsTab = false;
            this.btnProductImport.Location = new System.Drawing.Point(0, 112);
            this.btnProductImport.Name = "btnProductImport";
            this.btnProductImport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnProductImport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.btnProductImport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductImport.selected = false;
            this.btnProductImport.Size = new System.Drawing.Size(206, 56);
            this.btnProductImport.TabIndex = 2;
            this.btnProductImport.Text = "     Nhập hàng";
            this.btnProductImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductImport.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProductImport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStorageManage
            // 
            this.btnStorageManage.Active = false;
            this.btnStorageManage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnStorageManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnStorageManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStorageManage.BorderRadius = 0;
            this.btnStorageManage.ButtonText = "     Kiểm kho";
            this.btnStorageManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStorageManage.DisabledColor = System.Drawing.Color.Gray;
            this.btnStorageManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorageManage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStorageManage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStorageManage.Iconimage")));
            this.btnStorageManage.Iconimage_right = null;
            this.btnStorageManage.Iconimage_right_Selected = null;
            this.btnStorageManage.Iconimage_Selected = null;
            this.btnStorageManage.IconMarginLeft = 20;
            this.btnStorageManage.IconMarginRight = 0;
            this.btnStorageManage.IconRightVisible = true;
            this.btnStorageManage.IconRightZoom = 0D;
            this.btnStorageManage.IconVisible = true;
            this.btnStorageManage.IconZoom = 40D;
            this.btnStorageManage.IsTab = false;
            this.btnStorageManage.Location = new System.Drawing.Point(0, 168);
            this.btnStorageManage.Name = "btnStorageManage";
            this.btnStorageManage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnStorageManage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.btnStorageManage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStorageManage.selected = false;
            this.btnStorageManage.Size = new System.Drawing.Size(206, 56);
            this.btnStorageManage.TabIndex = 3;
            this.btnStorageManage.Text = "     Kiểm kho";
            this.btnStorageManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorageManage.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStorageManage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCategoryManage
            // 
            this.btnCategoryManage.Active = false;
            this.btnCategoryManage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnCategoryManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnCategoryManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategoryManage.BorderRadius = 0;
            this.btnCategoryManage.ButtonText = "     Danh mục";
            this.btnCategoryManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryManage.DisabledColor = System.Drawing.Color.Gray;
            this.btnCategoryManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoryManage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCategoryManage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCategoryManage.Iconimage")));
            this.btnCategoryManage.Iconimage_right = null;
            this.btnCategoryManage.Iconimage_right_Selected = null;
            this.btnCategoryManage.Iconimage_Selected = null;
            this.btnCategoryManage.IconMarginLeft = 20;
            this.btnCategoryManage.IconMarginRight = 0;
            this.btnCategoryManage.IconRightVisible = true;
            this.btnCategoryManage.IconRightZoom = 0D;
            this.btnCategoryManage.IconVisible = true;
            this.btnCategoryManage.IconZoom = 40D;
            this.btnCategoryManage.IsTab = false;
            this.btnCategoryManage.Location = new System.Drawing.Point(0, 224);
            this.btnCategoryManage.Name = "btnCategoryManage";
            this.btnCategoryManage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btnCategoryManage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.btnCategoryManage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCategoryManage.selected = false;
            this.btnCategoryManage.Size = new System.Drawing.Size(206, 56);
            this.btnCategoryManage.TabIndex = 4;
            this.btnCategoryManage.Text = "     Danh mục";
            this.btnCategoryManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryManage.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCategoryManage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnCategoryManage;
        private Bunifu.Framework.UI.BunifuFlatButton btnStorageManage;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductImport;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductReturn;
    }
}