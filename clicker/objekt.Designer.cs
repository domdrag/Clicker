
namespace dz2
{
    partial class objekt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imamLabel = new System.Windows.Forms.Label();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.kupiButton = new System.Windows.Forms.Button();
            this.imeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imamLabel
            // 
            this.imamLabel.AutoSize = true;
            this.imamLabel.Location = new System.Drawing.Point(27, 93);
            this.imamLabel.Name = "imamLabel";
            this.imamLabel.Size = new System.Drawing.Size(35, 13);
            this.imamLabel.TabIndex = 1;
            this.imamLabel.Text = "label2";
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.Location = new System.Drawing.Point(27, 122);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(35, 13);
            this.cijenaLabel.TabIndex = 2;
            this.cijenaLabel.Text = "label1";
            // 
            // kupiButton
            // 
            this.kupiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kupiButton.Location = new System.Drawing.Point(30, 151);
            this.kupiButton.Name = "kupiButton";
            this.kupiButton.Size = new System.Drawing.Size(60, 27);
            this.kupiButton.TabIndex = 3;
            this.kupiButton.Text = "+1";
            this.kupiButton.UseVisualStyleBackColor = true;
            this.kupiButton.Click += new System.EventHandler(this.kupi_Click);
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(27, 66);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(35, 13);
            this.imeLabel.TabIndex = 4;
            this.imeLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(112, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // objekt
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.kupiButton);
            this.Controls.Add(this.cijenaLabel);
            this.Controls.Add(this.imamLabel);
            this.Name = "objekt";
            this.Size = new System.Drawing.Size(296, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imamLabel;
        private System.Windows.Forms.Label cijenaLabel;
        private System.Windows.Forms.Button kupiButton;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
