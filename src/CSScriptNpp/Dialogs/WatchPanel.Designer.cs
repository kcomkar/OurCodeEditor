namespace CSScriptNpp.Dialogs
{
    partial class WatchPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchPanel));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addAtCaretBtn = new System.Windows.Forms.ToolStripButton();
            this.addExpressionBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteExpressionBtn = new System.Windows.Forms.ToolStripButton();
            this.reevaluateAllButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Location = new System.Drawing.Point(1, 31);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(373, 288);
            this.contentPanel.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAtCaretBtn,
            this.addExpressionBtn,
            this.deleteExpressionBtn,
            this.reevaluateAllButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addAtCaretBtn
            // 
            this.addAtCaretBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addAtCaretBtn.Image = global::CSScriptNpp.Resources.Resources.dbg_addwatch_at_caret;
            this.addAtCaretBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addAtCaretBtn.Name = "addAtCaretBtn";
            this.addAtCaretBtn.Size = new System.Drawing.Size(24, 24);
            this.addAtCaretBtn.Text = "toolStripButton2";
            this.addAtCaretBtn.ToolTipText = "Add Expression from the caret position";
            this.addAtCaretBtn.Click += new System.EventHandler(this.addAtCaretBtn_Click);
            // 
            // addExpressionBtn
            // 
            this.addExpressionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addExpressionBtn.Image = global::CSScriptNpp.Resources.Resources.dbg_addwatch;
            this.addExpressionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addExpressionBtn.Name = "addExpressionBtn";
            this.addExpressionBtn.Size = new System.Drawing.Size(24, 24);
            this.addExpressionBtn.ToolTipText = "Add Expression";
            this.addExpressionBtn.Click += new System.EventHandler(this.addExpressionBtn_Click);
            // 
            // deleteExpressionBtn
            // 
            this.deleteExpressionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteExpressionBtn.Image = global::CSScriptNpp.Resources.Resources.dbg_removewatch;
            this.deleteExpressionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteExpressionBtn.Name = "deleteExpressionBtn";
            this.deleteExpressionBtn.Size = new System.Drawing.Size(24, 24);
            this.deleteExpressionBtn.Text = "toolStripButton1";
            this.deleteExpressionBtn.ToolTipText = "Delete selected Expression(s)";
            this.deleteExpressionBtn.Click += new System.EventHandler(this.deleteExpressionBtn_Click);
            // 
            // reevaluateAllButton
            // 
            this.reevaluateAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reevaluateAllButton.Image = ((System.Drawing.Image)(resources.GetObject("reevaluateAllButton.Image")));
            this.reevaluateAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reevaluateAllButton.Name = "reevaluateAllButton";
            this.reevaluateAllButton.Size = new System.Drawing.Size(24, 24);
            this.reevaluateAllButton.Text = "Reevaluate All";
            this.reevaluateAllButton.ToolTipText = "Reevaluate all";
            this.reevaluateAllButton.Click += new System.EventHandler(this.reevaluateAllButton_Click);
            // 
            // WatchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.contentPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WatchPanel";
            this.Text = "CS-Script Watch";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addExpressionBtn;
        private System.Windows.Forms.ToolStripButton deleteExpressionBtn;
        private System.Windows.Forms.ToolStripButton addAtCaretBtn;
        private System.Windows.Forms.ToolStripButton reevaluateAllButton;
    }
}