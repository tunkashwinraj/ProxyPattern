namespace ProxyPattern_1262774
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
            this.cmbPictures = new System.Windows.Forms.ComboBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblShortName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnProtectionProxy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPictures
            // 
            this.cmbPictures.FormattingEnabled = true;
            this.cmbPictures.Location = new System.Drawing.Point(90, 69);
            this.cmbPictures.Name = "cmbPictures";
            this.cmbPictures.Size = new System.Drawing.Size(121, 21);
            this.cmbPictures.TabIndex = 0;
            this.cmbPictures.SelectedIndexChanged += new System.EventHandler(this.cmbPictures_SelectedIndexChanged);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(263, 69);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(293, 192);
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(80, 228);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(131, 23);
            this.btnShowImage.TabIndex = 2;
            this.btnShowImage.Text = "btnShowImage";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(201, 346);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(45, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "lblWidth";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(351, 346);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(48, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "lblHeight";
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Location = new System.Drawing.Point(80, 114);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(70, 13);
            this.lblShortName.TabIndex = 5;
            this.lblShortName.Text = "lblShortName";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(80, 146);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "lblCategory";
            // 
            // btnProtectionProxy
            // 
            this.btnProtectionProxy.Location = new System.Drawing.Point(284, 377);
            this.btnProtectionProxy.Name = "btnProtectionProxy";
            this.btnProtectionProxy.Size = new System.Drawing.Size(75, 23);
            this.btnProtectionProxy.TabIndex = 7;
            this.btnProtectionProxy.Text = "btnProtectionProxy";
            this.btnProtectionProxy.UseVisualStyleBackColor = true;
            this.btnProtectionProxy.Click += new System.EventHandler(this.btnProtectionProxy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProtectionProxy);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblShortName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnShowImage);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.cmbPictures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPictures;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnProtectionProxy;
    }
}

