namespace Lab4
{
    partial class Bai4
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
            this.urlTB = new System.Windows.Forms.TextBox();
            this.showBT = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.viewSourceBT = new System.Windows.Forms.Button();
            this.downloadBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(28, 21);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(590, 27);
            this.urlTB.TabIndex = 0;
            // 
            // showBT
            // 
            this.showBT.Location = new System.Drawing.Point(636, 20);
            this.showBT.Name = "showBT";
            this.showBT.Size = new System.Drawing.Size(94, 29);
            this.showBT.TabIndex = 1;
            this.showBT.Text = "VIEW";
            this.showBT.UseVisualStyleBackColor = true;
            this.showBT.Click += new System.EventHandler(this.viewBT_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(28, 55);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(960, 575);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            // 
            // viewSourceBT
            // 
            this.viewSourceBT.Location = new System.Drawing.Point(759, 21);
            this.viewSourceBT.Name = "viewSourceBT";
            this.viewSourceBT.Size = new System.Drawing.Size(94, 29);
            this.viewSourceBT.TabIndex = 4;
            this.viewSourceBT.Text = "View HTML";
            this.viewSourceBT.UseVisualStyleBackColor = true;
            this.viewSourceBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // downloadBT
            // 
            this.downloadBT.Enabled = true;
            this.downloadBT.Location = new System.Drawing.Point(881, 20);
            this.downloadBT.Name = "downloadBT";
            this.downloadBT.Size = new System.Drawing.Size(94, 29);
            this.downloadBT.TabIndex = 5;
            this.downloadBT.Text = "Download HTML";
            this.downloadBT.UseVisualStyleBackColor = true;
            this.downloadBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.downloadBT);
            this.Controls.Add(this.viewSourceBT);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.showBT);
            this.Controls.Add(this.urlTB);
            this.Name = "Bai4";
            this.Text = "Bai2";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox urlTB;
        private Button showBT;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button viewSourceBT;
        private Button downloadBT;
    }
}