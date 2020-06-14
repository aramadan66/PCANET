namespace PCANET
{
    partial class frmMain
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
            this.chartOfAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartOfAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jounalEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartOfAccountToolStripMenuItem,
            this.generalLedgerToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.cashToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // chartOfAccountToolStripMenuItem
            // 
            this.chartOfAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartOfAccountToolStripMenuItem1,
            this.jounalEntryToolStripMenuItem});
            this.chartOfAccountToolStripMenuItem.Name = "chartOfAccountToolStripMenuItem";
            this.chartOfAccountToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.chartOfAccountToolStripMenuItem.Text = "General Ledger";
            // 
            // generalLedgerToolStripMenuItem
            // 
            this.generalLedgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.generalLedgerToolStripMenuItem.Name = "generalLedgerToolStripMenuItem";
            this.generalLedgerToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.generalLedgerToolStripMenuItem.Text = "Purchasing";
            // 
            // chartOfAccountToolStripMenuItem1
            // 
            this.chartOfAccountToolStripMenuItem1.Name = "chartOfAccountToolStripMenuItem1";
            this.chartOfAccountToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.chartOfAccountToolStripMenuItem1.Text = "Chart Of account";
            this.chartOfAccountToolStripMenuItem1.Click += new System.EventHandler(this.chartOfAccountToolStripMenuItem1_Click);
            // 
            // jounalEntryToolStripMenuItem
            // 
            this.jounalEntryToolStripMenuItem.Name = "jounalEntryToolStripMenuItem";
            this.jounalEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jounalEntryToolStripMenuItem.Text = "Jounal Entry";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendorToolStripMenuItem.Text = "Vendor";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.transactionToolStripMenuItem1});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // cashToolStripMenuItem
            // 
            this.cashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem2});
            this.cashToolStripMenuItem.Name = "cashToolStripMenuItem";
            this.cashToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.cashToolStripMenuItem.Text = "Cash";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // transactionToolStripMenuItem1
            // 
            this.transactionToolStripMenuItem1.Name = "transactionToolStripMenuItem1";
            this.transactionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.transactionToolStripMenuItem1.Text = "Transaction";
            // 
            // transactionToolStripMenuItem2
            // 
            this.transactionToolStripMenuItem2.Name = "transactionToolStripMenuItem2";
            this.transactionToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.transactionToolStripMenuItem2.Text = "Transaction";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jounalEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}

