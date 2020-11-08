namespace EduToolkits
{
    partial class ToolkitSelector
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolkitSelector));
            this.convertorButton = new System.Windows.Forms.Button();
            this.flipDirPicsButton = new System.Windows.Forms.Button();
            this.jsonViewerButton = new System.Windows.Forms.Button();
            this.SentencesToImagesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertorButton
            // 
            this.convertorButton.Location = new System.Drawing.Point(12, 12);
            this.convertorButton.Name = "convertorButton";
            this.convertorButton.Size = new System.Drawing.Size(195, 107);
            this.convertorButton.TabIndex = 0;
            this.convertorButton.Text = "Image Convertor";
            this.convertorButton.UseVisualStyleBackColor = true;
            this.convertorButton.Click += new System.EventHandler(this.convertorButton_Click);
            // 
            // flipDirPicsButton
            // 
            this.flipDirPicsButton.Location = new System.Drawing.Point(213, 12);
            this.flipDirPicsButton.Name = "flipDirPicsButton";
            this.flipDirPicsButton.Size = new System.Drawing.Size(195, 107);
            this.flipDirPicsButton.TabIndex = 1;
            this.flipDirPicsButton.Text = "Image Flip";
            this.flipDirPicsButton.UseVisualStyleBackColor = true;
            this.flipDirPicsButton.Click += new System.EventHandler(this.flipDirPicsButton_Click);
            // 
            // jsonViewerButton
            // 
            this.jsonViewerButton.Location = new System.Drawing.Point(414, 12);
            this.jsonViewerButton.Name = "jsonViewerButton";
            this.jsonViewerButton.Size = new System.Drawing.Size(195, 107);
            this.jsonViewerButton.TabIndex = 1;
            this.jsonViewerButton.Text = "Json Viewer";
            this.jsonViewerButton.UseVisualStyleBackColor = true;
            this.jsonViewerButton.Click += new System.EventHandler(this.jsonViewerButton_Click);
            // 
            // SentencesToImagesButton
            // 
            this.SentencesToImagesButton.Location = new System.Drawing.Point(12, 125);
            this.SentencesToImagesButton.Name = "SentencesToImagesButton";
            this.SentencesToImagesButton.Size = new System.Drawing.Size(195, 107);
            this.SentencesToImagesButton.TabIndex = 2;
            this.SentencesToImagesButton.Text = "Sentences To Images";
            this.SentencesToImagesButton.UseVisualStyleBackColor = true;
            this.SentencesToImagesButton.Click += new System.EventHandler(this.SentencesToImagesButton_Click);
            // 
            // ToolkitSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 244);
            this.Controls.Add(this.SentencesToImagesButton);
            this.Controls.Add(this.jsonViewerButton);
            this.Controls.Add(this.flipDirPicsButton);
            this.Controls.Add(this.convertorButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolkitSelector";
            this.Text = "Toolkit Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertorButton;
        private System.Windows.Forms.Button flipDirPicsButton;
        private System.Windows.Forms.Button jsonViewerButton;
        private System.Windows.Forms.Button SentencesToImagesButton;
    }
}

