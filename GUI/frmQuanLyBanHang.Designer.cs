namespace GUI
{
    partial class frmQuanLyBanHang
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.rbTabQuanLy = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbTabThongKe = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // rbTabQuanLy
            // 
            this.rbTabQuanLy.Checked = true;
            this.rbTabQuanLy.Name = "rbTabQuanLy";
            this.rbTabQuanLy.Text = "Quản Lý ";
            // 
            // rbTabThongKe
            // 
            this.rbTabThongKe.Checked = true;
            this.rbTabThongKe.Name = "rbTabThongKe";
            this.rbTabThongKe.Text = "Thống Kê ";
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 651);
            this.Name = "frmQuanLyBanHang";
            this.Text = "Hệ Thống ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonTabItem rbTabQuanLy;
        private DevComponents.DotNetBar.RibbonTabItem rbTabThongKe;
        private DevComponents.DotNetBar.StyleManager styleManager2;
    }
}