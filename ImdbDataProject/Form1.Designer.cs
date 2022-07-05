namespace ImdbDataProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetInfos = new System.Windows.Forms.Button();
            this.pctMovie = new System.Windows.Forms.PictureBox();
            this.richtxtExplanation = new System.Windows.Forms.RichTextBox();
            this.lstDirectors = new System.Windows.Forms.ListBox();
            this.lstWriters = new System.Windows.Forms.ListBox();
            this.lstStars = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(110, 44);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(209, 26);
            this.txtMovieName.TabIndex = 0;
            this.txtMovieName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovieName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // btnGetInfos
            // 
            this.btnGetInfos.BackgroundImage = global::ImdbDataProject.Properties.Resources.findlogo;
            this.btnGetInfos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetInfos.Font = new System.Drawing.Font("Arial Black", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetInfos.Location = new System.Drawing.Point(347, 40);
            this.btnGetInfos.Name = "btnGetInfos";
            this.btnGetInfos.Size = new System.Drawing.Size(84, 43);
            this.btnGetInfos.TabIndex = 2;
            this.btnGetInfos.UseVisualStyleBackColor = true;
            this.btnGetInfos.Click += new System.EventHandler(this.btnGetInfos_Click);
            // 
            // pctMovie
            // 
            this.pctMovie.Location = new System.Drawing.Point(12, 155);
            this.pctMovie.Name = "pctMovie";
            this.pctMovie.Size = new System.Drawing.Size(137, 143);
            this.pctMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMovie.TabIndex = 3;
            this.pctMovie.TabStop = false;
            // 
            // richtxtExplanation
            // 
            this.richtxtExplanation.Location = new System.Drawing.Point(165, 155);
            this.richtxtExplanation.Name = "richtxtExplanation";
            this.richtxtExplanation.Size = new System.Drawing.Size(213, 135);
            this.richtxtExplanation.TabIndex = 5;
            this.richtxtExplanation.Text = "";
            // 
            // lstDirectors
            // 
            this.lstDirectors.FormattingEnabled = true;
            this.lstDirectors.ItemHeight = 19;
            this.lstDirectors.Location = new System.Drawing.Point(12, 339);
            this.lstDirectors.Name = "lstDirectors";
            this.lstDirectors.Size = new System.Drawing.Size(166, 80);
            this.lstDirectors.TabIndex = 10;
            // 
            // lstWriters
            // 
            this.lstWriters.FormattingEnabled = true;
            this.lstWriters.ItemHeight = 19;
            this.lstWriters.Location = new System.Drawing.Point(202, 339);
            this.lstWriters.Name = "lstWriters";
            this.lstWriters.Size = new System.Drawing.Size(176, 80);
            this.lstWriters.TabIndex = 11;
            // 
            // lstStars
            // 
            this.lstStars.FormattingEnabled = true;
            this.lstStars.ItemHeight = 19;
            this.lstStars.Location = new System.Drawing.Point(397, 155);
            this.lstStars.Name = "lstStars";
            this.lstStars.Size = new System.Drawing.Size(186, 99);
            this.lstStars.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Özet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(397, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Oyuncular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yönetmenler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(202, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yazarlar";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Arial", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMovieName.Location = new System.Drawing.Point(12, 121);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(66, 17);
            this.lblMovieName.TabIndex = 13;
            this.lblMovieName.Text = "Film Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstStars);
            this.Controls.Add(this.lstWriters);
            this.Controls.Add(this.lstDirectors);
            this.Controls.Add(this.richtxtExplanation);
            this.Controls.Add(this.pctMovie);
            this.Controls.Add(this.btnGetInfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovieName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetInfos;
        private System.Windows.Forms.PictureBox pctMovie;
        private System.Windows.Forms.RichTextBox richtxtExplanation;
        private System.Windows.Forms.ListBox lstDirectors;
        private System.Windows.Forms.ListBox lstWriters;
        private System.Windows.Forms.ListBox lstStars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMovieName;
    }
}
