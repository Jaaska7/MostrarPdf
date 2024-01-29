namespace AppPdfViewer
{
    partial class Form1
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
            this.pdfDocumentThumbnail1 = new Spire.PdfViewer.Forms.PdfThumbnails.PdfDocumentThumbnail();
            this.pdfViewer3 = new Spire.PdfViewer.Forms.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfDocumentThumbnail1
            // 
            this.pdfDocumentThumbnail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pdfDocumentThumbnail1.Location = new System.Drawing.Point(0, 0);
            this.pdfDocumentThumbnail1.Name = "pdfDocumentThumbnail1";
            this.pdfDocumentThumbnail1.PageLabelColor = System.Drawing.Color.Black;
            this.pdfDocumentThumbnail1.PageLabelSelectedColor = System.Drawing.Color.Red;
            this.pdfDocumentThumbnail1.Size = new System.Drawing.Size(20, 20);
            this.pdfDocumentThumbnail1.TabIndex = 0;
            this.pdfDocumentThumbnail1.Viewer = null;
            this.pdfDocumentThumbnail1.ZoomPercent = 8;
            // 
            // pdfViewer3
            // 
            this.pdfViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer3.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer3.FormFillEnabled = false;
            this.pdfViewer3.IgnoreCase = false;
            this.pdfViewer3.IsToolBarVisible = true;
            this.pdfViewer3.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer3.MultiPagesThreshold = 60;
            this.pdfViewer3.Name = "pdfViewer3";
            this.pdfViewer3.OnRenderPageExceptionEvent = null;
            this.pdfViewer3.Size = new System.Drawing.Size(742, 253);
            this.pdfViewer3.TabIndex = 1;
            this.pdfViewer3.Text = "pdfViewer3";
            this.pdfViewer3.Threshold = 60;
            this.pdfViewer3.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfViewer3.Click += new System.EventHandler(this.pdfViewer3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(742, 253);
            this.Controls.Add(this.pdfViewer3);
            this.Controls.Add(this.pdfDocumentThumbnail1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer2;
        private Spire.PdfViewer.Forms.PdfThumbnails.PdfDocumentThumbnail pdfDocumentThumbnail1;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer3;
    }
}