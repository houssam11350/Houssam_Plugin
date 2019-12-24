namespace Houssam_Plugin.Forms
{
    partial class FrmInput
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
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSurround = new System.Windows.Forms.TabPage();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.rbForEachLine = new System.Windows.Forms.RadioButton();
            this.rbOnlyOne = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.rbForEachLine_replace = new System.Windows.Forms.RadioButton();
            this.rbOnlyOnce_replace = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnchor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSurround.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(240, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 38);
            this.panel1.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSurround);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(794, 213);
            this.tabControl.TabIndex = 5;
            // 
            // tabSurround
            // 
            this.tabSurround.Controls.Add(this.txtTag);
            this.tabSurround.Controls.Add(this.rbForEachLine);
            this.tabSurround.Controls.Add(this.rbOnlyOne);
            this.tabSurround.Location = new System.Drawing.Point(4, 22);
            this.tabSurround.Name = "tabSurround";
            this.tabSurround.Padding = new System.Windows.Forms.Padding(3);
            this.tabSurround.Size = new System.Drawing.Size(786, 187);
            this.tabSurround.TabIndex = 0;
            this.tabSurround.Text = "Surround with Tag";
            this.tabSurround.UseVisualStyleBackColor = true;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(16, 16);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(409, 20);
            this.txtTag.TabIndex = 0;
            this.txtTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTag_KeyDown);
            // 
            // rbForEachLine
            // 
            this.rbForEachLine.AutoSize = true;
            this.rbForEachLine.Location = new System.Drawing.Point(107, 42);
            this.rbForEachLine.Name = "rbForEachLine";
            this.rbForEachLine.Size = new System.Drawing.Size(90, 17);
            this.rbForEachLine.TabIndex = 2;
            this.rbForEachLine.Text = "For each Line";
            this.rbForEachLine.UseVisualStyleBackColor = true;
            // 
            // rbOnlyOne
            // 
            this.rbOnlyOne.AutoSize = true;
            this.rbOnlyOne.Checked = true;
            this.rbOnlyOne.Location = new System.Drawing.Point(16, 42);
            this.rbOnlyOne.Name = "rbOnlyOne";
            this.rbOnlyOne.Size = new System.Drawing.Size(75, 17);
            this.rbOnlyOne.TabIndex = 2;
            this.rbOnlyOne.TabStop = true;
            this.rbOnlyOne.Text = "Only Once";
            this.rbOnlyOne.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.rbForEachLine_replace);
            this.tabPage2.Controls.Add(this.rbOnlyOnce_replace);
            this.tabPage2.Controls.Add(this.txtAnchor);
            this.tabPage2.Controls.Add(this.txtReplace);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Replace";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplace.Location = new System.Drawing.Point(8, 16);
            this.txtReplace.Multiline = true;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplace.Size = new System.Drawing.Size(757, 56);
            this.txtReplace.TabIndex = 1;
            // 
            // rbForEachLine_replace
            // 
            this.rbForEachLine_replace.AutoSize = true;
            this.rbForEachLine_replace.Location = new System.Drawing.Point(135, 78);
            this.rbForEachLine_replace.Name = "rbForEachLine_replace";
            this.rbForEachLine_replace.Size = new System.Drawing.Size(90, 17);
            this.rbForEachLine_replace.TabIndex = 3;
            this.rbForEachLine_replace.Text = "For each Line";
            this.rbForEachLine_replace.UseVisualStyleBackColor = true;
            // 
            // rbOnlyOnce_replace
            // 
            this.rbOnlyOnce_replace.AutoSize = true;
            this.rbOnlyOnce_replace.Checked = true;
            this.rbOnlyOnce_replace.Location = new System.Drawing.Point(44, 78);
            this.rbOnlyOnce_replace.Name = "rbOnlyOnce_replace";
            this.rbOnlyOnce_replace.Size = new System.Drawing.Size(75, 17);
            this.rbOnlyOnce_replace.TabIndex = 4;
            this.rbOnlyOnce_replace.TabStop = true;
            this.rbOnlyOnce_replace.Text = "Only Once";
            this.rbOnlyOnce_replace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text Anchor";
            // 
            // txtAnchor
            // 
            this.txtAnchor.Location = new System.Drawing.Point(42, 127);
            this.txtAnchor.Name = "txtAnchor";
            this.txtAnchor.ReadOnly = true;
            this.txtAnchor.Size = new System.Drawing.Size(279, 20);
            this.txtAnchor.TabIndex = 1;
            this.txtAnchor.Text = "@@@&&@@@";
            // 
            // FrmInput
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 251);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmInput";
            this.Text = "FrmInput";
            this.Activated += new System.EventHandler(this.FrmInput_Activated);
            this.Load += new System.EventHandler(this.FrmInput_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInput_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabSurround.ResumeLayout(false);
            this.tabSurround.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSurround;
        private System.Windows.Forms.TextBox txtTag;
        public System.Windows.Forms.RadioButton rbForEachLine;
        public System.Windows.Forms.RadioButton rbOnlyOne;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtReplace;
        public System.Windows.Forms.RadioButton rbForEachLine_replace;
        public System.Windows.Forms.RadioButton rbOnlyOnce_replace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnchor;
    }
}