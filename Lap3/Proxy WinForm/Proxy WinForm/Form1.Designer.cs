
namespace Proxy_WinForm
{
    partial class MainForm
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
            this.btnRequire = new System.Windows.Forms.Button();
            this.cbSub = new System.Windows.Forms.ComboBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRequire
            // 
            this.btnRequire.Location = new System.Drawing.Point(498, 111);
            this.btnRequire.Name = "btnRequire";
            this.btnRequire.Size = new System.Drawing.Size(159, 42);
            this.btnRequire.TabIndex = 0;
            this.btnRequire.Text = "Require";
            this.btnRequire.UseVisualStyleBackColor = true;
            this.btnRequire.Click += new System.EventHandler(this.btnRequire_Click);
            // 
            // cbSub
            // 
            this.cbSub.FormattingEnabled = true;
            this.cbSub.Items.AddRange(new object[] {
            "Math",
            "Literature"});
            this.cbSub.Location = new System.Drawing.Point(64, 111);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(216, 28);
            this.cbSub.TabIndex = 1;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(64, 199);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(593, 270);
            this.rtbContent.TabIndex = 2;
            this.rtbContent.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.cbSub);
            this.Controls.Add(this.btnRequire);
            this.Name = "MainForm";
            this.Text = "Proxy Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequire;
        private System.Windows.Forms.ComboBox cbSub;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}

