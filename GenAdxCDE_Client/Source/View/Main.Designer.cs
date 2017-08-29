namespace GenAdxCDE.Source.View
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumerHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumerMgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceMgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couponMgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 847);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1251, 40);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumerHistoryToolStripMenuItem,
            this.advertisementToolStripMenuItem,
            this.consumerMgrToolStripMenuItem,
            this.preferenceMgrToolStripMenuItem,
            this.couponMgrToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // consumerHistoryToolStripMenuItem
            // 
            this.consumerHistoryToolStripMenuItem.Name = "consumerHistoryToolStripMenuItem";
            this.consumerHistoryToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.consumerHistoryToolStripMenuItem.Text = "Consumer History Mgr";
            this.consumerHistoryToolStripMenuItem.Click += new System.EventHandler(this.consumerHistoryToolStripMenuItem_Click);
            // 
            // advertisementToolStripMenuItem
            // 
            this.advertisementToolStripMenuItem.Name = "advertisementToolStripMenuItem";
            this.advertisementToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.advertisementToolStripMenuItem.Text = "AdvertisementMgr";
            this.advertisementToolStripMenuItem.Click += new System.EventHandler(this.advertisementToolStripMenuItem_Click);
            // 
            // consumerMgrToolStripMenuItem
            // 
            this.consumerMgrToolStripMenuItem.Name = "consumerMgrToolStripMenuItem";
            this.consumerMgrToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.consumerMgrToolStripMenuItem.Text = "ConsumerMgr";
            this.consumerMgrToolStripMenuItem.Click += new System.EventHandler(this.consumerMgrToolStripMenuItem_Click);
            // 
            // preferenceMgrToolStripMenuItem
            // 
            this.preferenceMgrToolStripMenuItem.Name = "preferenceMgrToolStripMenuItem";
            this.preferenceMgrToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.preferenceMgrToolStripMenuItem.Text = "PreferenceMgr";
            this.preferenceMgrToolStripMenuItem.Click += new System.EventHandler(this.preferenceMgrToolStripMenuItem_Click);
            // 
            // couponMgrToolStripMenuItem
            // 
            this.couponMgrToolStripMenuItem.Name = "couponMgrToolStripMenuItem";
            this.couponMgrToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.couponMgrToolStripMenuItem.Text = "CouponMgr";
            this.couponMgrToolStripMenuItem.Click += new System.EventHandler(this.couponMgrToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1291, 907);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "GenAdx Consumer Decision Engine";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumerHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advertisementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumerMgrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couponMgrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceMgrToolStripMenuItem;
    }
}

