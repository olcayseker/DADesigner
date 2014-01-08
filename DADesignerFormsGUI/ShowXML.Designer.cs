namespace DADesignerFormsGUI
{
    partial class ShowXML
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
            this.rtbXML = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbXML
            // 
            this.rtbXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbXML.Location = new System.Drawing.Point(0, 0);
            this.rtbXML.Name = "rtbXML";
            this.rtbXML.ReadOnly = true;
            this.rtbXML.Size = new System.Drawing.Size(572, 509);
            this.rtbXML.TabIndex = 0;
            this.rtbXML.Text = "";
            this.rtbXML.WordWrap = false;
            // 
            // ShowXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 509);
            this.Controls.Add(this.rtbXML);
            this.Name = "ShowXML";
            this.ShowInTaskbar = false;
            this.Text = "ShowXML";
            this.Load += new System.EventHandler(this.ShowXML_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbXML;
    }
}