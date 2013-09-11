namespace SignVerifier
{
    partial class frmDisplaySignature
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
            this.picSignature = new System.Windows.Forms.PictureBox();
            this.btnCalculateBytes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).BeginInit();
            this.SuspendLayout();
            // 
            // picSignature
            // 
            this.picSignature.Image = global::SignVerifier.Properties.Resources.Rose;
            this.picSignature.InitialImage = global::SignVerifier.Properties.Resources.Rose;
            this.picSignature.Location = new System.Drawing.Point(135, 79);
            this.picSignature.Name = "picSignature";
            this.picSignature.Size = new System.Drawing.Size(279, 143);
            this.picSignature.TabIndex = 0;
            this.picSignature.TabStop = false;
            // 
            // btnCalculateBytes
            // 
            this.btnCalculateBytes.Location = new System.Drawing.Point(135, 273);
            this.btnCalculateBytes.Name = "btnCalculateBytes";
            this.btnCalculateBytes.Size = new System.Drawing.Size(152, 61);
            this.btnCalculateBytes.TabIndex = 1;
            this.btnCalculateBytes.Text = "Calculate Bytes";
            this.btnCalculateBytes.UseVisualStyleBackColor = true;
            this.btnCalculateBytes.Click += new System.EventHandler(this.btnCalculateBytes_Click);
            // 
            // frmDisplaySignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 375);
            this.Controls.Add(this.btnCalculateBytes);
            this.Controls.Add(this.picSignature);
            this.Name = "frmDisplaySignature";
            this.Text = "DisplaySignature";
            this.Load += new System.EventHandler(this.frmDisplaySignature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSignature;
        private System.Windows.Forms.Button btnCalculateBytes;
    }
}