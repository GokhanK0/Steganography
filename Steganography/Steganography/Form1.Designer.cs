namespace Steganography
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
            this.pct_image = new System.Windows.Forms.PictureBox();
            this.btn_open_file = new System.Windows.Forms.Button();
            this.btn_decode = new System.Windows.Forms.Button();
            this.btn_encode = new System.Windows.Forms.Button();
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_image
            // 
            this.pct_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_image.Location = new System.Drawing.Point(109, 22);
            this.pct_image.Name = "pct_image";
            this.pct_image.Size = new System.Drawing.Size(564, 309);
            this.pct_image.TabIndex = 0;
            this.pct_image.TabStop = false;
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(173, 354);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(75, 23);
            this.btn_open_file.TabIndex = 1;
            this.btn_open_file.Text = "Open File";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.Btn_open_file_Click);
            // 
            // btn_decode
            // 
            this.btn_decode.Location = new System.Drawing.Point(420, 461);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(75, 38);
            this.btn_decode.TabIndex = 1;
            this.btn_decode.Text = "Decode";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.Btn_decode_Click);
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(296, 461);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(75, 38);
            this.btn_encode.TabIndex = 1;
            this.btn_encode.Text = "Encode";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.Btn_encode_Click);
            // 
            // txt_file_path
            // 
            this.txt_file_path.Location = new System.Drawing.Point(273, 357);
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.Size = new System.Drawing.Size(181, 20);
            this.txt_file_path.TabIndex = 2;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(273, 435);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(248, 20);
            this.txt_message.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Message :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_file_path);
            this.Controls.Add(this.btn_encode);
            this.Controls.Add(this.btn_decode);
            this.Controls.Add(this.btn_open_file);
            this.Controls.Add(this.pct_image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_image;
        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.Button btn_decode;
        private System.Windows.Forms.Button btn_encode;
        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label1;
    }
}

