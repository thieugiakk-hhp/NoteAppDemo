
namespace NoteAppDemo
{
    partial class frmAddNote
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
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsbAddNote = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tsbSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBot = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.txtContents = new System.Windows.Forms.TextBox();
            this.tblTypeNote = new System.Windows.Forms.Label();
            this.tsTop.SuspendLayout();
            this.tsBot.SuspendLayout();
            this.SuspendLayout();
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
            this.tsTop.Size = new System.Drawing.Size(284, 25);
            this.tsTop.TabIndex = 5;
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
            this.tsbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem,
            this.notesListToolStripMenuItem,
            this.deleteNoteToolStripMenuItem,
            this.setTypeToolStripMenuItem});
            this.tsbSettings.Image = global::NoteAppDemo.Properties.Resources.settings;
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(29, 22);
            this.tsbSettings.Text = "toolStripButton3";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.lightGrayToolStripMenuItem,
            this.darkGrayToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorsToolStripMenuItem.Text = "&Colors";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // lightGrayToolStripMenuItem
            // 
            this.lightGrayToolStripMenuItem.Name = "lightGrayToolStripMenuItem";
            this.lightGrayToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lightGrayToolStripMenuItem.Text = "Light Gray";
            // 
            // darkGrayToolStripMenuItem
            // 
            this.darkGrayToolStripMenuItem.Name = "darkGrayToolStripMenuItem";
            this.darkGrayToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.darkGrayToolStripMenuItem.Text = "Dark Gray";
            // 
            // notesListToolStripMenuItem
            // 
            this.notesListToolStripMenuItem.Name = "notesListToolStripMenuItem";
            this.notesListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notesListToolStripMenuItem.Text = "&Notes List";
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteNoteToolStripMenuItem.Text = "&Delete Note";
            // 
            // setTypeToolStripMenuItem
            // 
            this.setTypeToolStripMenuItem.Name = "setTypeToolStripMenuItem";
            this.setTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setTypeToolStripMenuItem.Text = "&Set Type";
            this.setTypeToolStripMenuItem.Click += new System.EventHandler(this.setTypeToolStripMenuItem_Click);
            // 
            // tsBot
            // 
            this.tsBot.BackColor = System.Drawing.Color.Transparent;
            this.tsBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsBot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.tsBot.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsBot.Location = new System.Drawing.Point(0, 261);
            this.tsBot.Name = "tsBot";
            this.tsBot.Size = new System.Drawing.Size(284, 23);
            this.tsBot.TabIndex = 6;
            this.tsBot.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NoteAppDemo.Properties.Resources.font;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::NoteAppDemo.Properties.Resources.picture;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::NoteAppDemo.Properties.Resources.chat;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 20);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::NoteAppDemo.Properties.Resources.microphone;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // txtContents
            // 
            this.txtContents.BackColor = System.Drawing.Color.DimGray;
            this.txtContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContents.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContents.Location = new System.Drawing.Point(0, 25);
            this.txtContents.Multiline = true;
            this.txtContents.Name = "txtContents";
            this.txtContents.Size = new System.Drawing.Size(284, 236);
            this.txtContents.TabIndex = 7;
            // 
            // tblTypeNote
            // 
            this.tblTypeNote.AutoSize = true;
            this.tblTypeNote.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTypeNote.ForeColor = System.Drawing.Color.White;
            this.tblTypeNote.Location = new System.Drawing.Point(91, 4);
            this.tblTypeNote.Name = "tblTypeNote";
            this.tblTypeNote.Size = new System.Drawing.Size(73, 17);
            this.tblTypeNote.TabIndex = 8;
            this.tblTypeNote.Text = "Type Note";
            this.tblTypeNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.ControlBox = false;
            this.Controls.Add(this.tblTypeNote);
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.tsBot);
            this.Controls.Add(this.tsTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 850);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frmAddNote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Noté";
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.tsBot.ResumeLayout(false);
            this.tsBot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsbAddNote;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripDropDownButton tsbSettings;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsBot;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox txtContents;
        private System.Windows.Forms.ToolStripMenuItem setTypeToolStripMenuItem;
        private System.Windows.Forms.Label tblTypeNote;
    }
}