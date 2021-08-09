
namespace NoteAppDemo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblNameApplication = new System.Windows.Forms.Label();
            this.tsbAddNote = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.panel2.SuspendLayout();
            this.tsTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(2, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 27);
            this.panel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Gray;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(330, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // lblNameApplication
            // 
            this.lblNameApplication.AutoSize = true;
            this.lblNameApplication.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameApplication.Location = new System.Drawing.Point(0, 30);
            this.lblNameApplication.Name = "lblNameApplication";
            this.lblNameApplication.Size = new System.Drawing.Size(239, 24);
            this.lblNameApplication.TabIndex = 3;
            this.lblNameApplication.Text = "Noté Application Demo";
            // 
            // tsbAddNote
            // 
            this.tsbAddNote.BackColor = System.Drawing.Color.Transparent;
            this.tsbAddNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddNote.Image = global::NoteAppDemo.Properties.Resources.plus;
            this.tsbAddNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNote.Name = "tsbAddNote";
            this.tsbAddNote.Size = new System.Drawing.Size(23, 22);
            this.tsbAddNote.Text = "toolStripButton1";
            this.tsbAddNote.Click += new System.EventHandler(this.tsbAddNote_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbExit.BackColor = System.Drawing.Color.Transparent;
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::NoteAppDemo.Properties.Resources.cancel;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "toolStripButton2";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tsbSettings
            // 
            this.tsbSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSettings.BackColor = System.Drawing.Color.Transparent;
            this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettings.Image = global::NoteAppDemo.Properties.Resources.settings;
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(23, 22);
            this.tsbSettings.Text = "toolStripButton3";
            // 
            // tsTop
            // 
            this.tsTop.AutoSize = false;
            this.tsTop.BackColor = System.Drawing.Color.Transparent;
            this.tsTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNote,
            this.tsbExit,
            this.tsbSettings});
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(334, 25);
            this.tsTop.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(334, 661);
            this.ControlBox = false;
            this.Controls.Add(this.tsTop);
            this.Controls.Add(this.lblNameApplication);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Noté";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblNameApplication;
        private System.Windows.Forms.ToolStripButton tsbAddNote;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbSettings;
        private System.Windows.Forms.ToolStrip tsTop;
    }
}

