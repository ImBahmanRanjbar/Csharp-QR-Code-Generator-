namespace QR_Code_Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.bahmanTextbox1 = new BahmanTextBox.BahmanTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bahmanButtonControl1 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl2 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl3 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl4 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl5 = new BahmanButton.BahmanButtonControl();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("W95FA", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR Code Generator";
            // 
            // bahmanTextbox1
            // 
            this.bahmanTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.bahmanTextbox1.BackColorBahman = System.Drawing.Color.WhiteSmoke;
            this.bahmanTextbox1.BorderColor = System.Drawing.Color.Transparent;
            this.bahmanTextbox1.BorderSize = 0;
            this.bahmanTextbox1.Font = new System.Drawing.Font("W95FA", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bahmanTextbox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bahmanTextbox1.Location = new System.Drawing.Point(190, 118);
            this.bahmanTextbox1.Name = "bahmanTextbox1";
            this.bahmanTextbox1.Radius = 50;
            this.bahmanTextbox1.Size = new System.Drawing.Size(435, 50);
            this.bahmanTextbox1.TabIndex = 2;
            this.bahmanTextbox1.UseSystemPasswordChar = false;
            this.bahmanTextbox1.WaterMark = null;
            this.bahmanTextbox1.WaterMarkColor = System.Drawing.Color.Gray;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("W95FA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Link or Text :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(278, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 338);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bahmanButtonControl1
            // 
            this.bahmanButtonControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bahmanButtonControl1.BorderRadius = 25;
            this.bahmanButtonControl1.BorderSize = 0;
            this.bahmanButtonControl1.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl1.Font = new System.Drawing.Font("W95FA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bahmanButtonControl1.ForeColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl1.Location = new System.Drawing.Point(765, 171);
            this.bahmanButtonControl1.Name = "bahmanButtonControl1";
            this.bahmanButtonControl1.Size = new System.Drawing.Size(163, 77);
            this.bahmanButtonControl1.TabIndex = 5;
            this.bahmanButtonControl1.Text = "Generat";
            this.bahmanButtonControl1.TextColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl1.UseVisualStyleBackColor = false;
            this.bahmanButtonControl1.Click += new System.EventHandler(this.bahmanButtonControl1_Click);
            // 
            // bahmanButtonControl2
            // 
            this.bahmanButtonControl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bahmanButtonControl2.BorderRadius = 25;
            this.bahmanButtonControl2.BorderSize = 0;
            this.bahmanButtonControl2.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl2.Font = new System.Drawing.Font("W95FA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bahmanButtonControl2.ForeColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl2.Location = new System.Drawing.Point(765, 254);
            this.bahmanButtonControl2.Name = "bahmanButtonControl2";
            this.bahmanButtonControl2.Size = new System.Drawing.Size(163, 77);
            this.bahmanButtonControl2.TabIndex = 5;
            this.bahmanButtonControl2.Text = "Save";
            this.bahmanButtonControl2.TextColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl2.UseVisualStyleBackColor = false;
            this.bahmanButtonControl2.Click += new System.EventHandler(this.bahmanButtonControl2_Click);
            // 
            // bahmanButtonControl3
            // 
            this.bahmanButtonControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bahmanButtonControl3.BorderRadius = 25;
            this.bahmanButtonControl3.BorderSize = 0;
            this.bahmanButtonControl3.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl3.Font = new System.Drawing.Font("W95FA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bahmanButtonControl3.ForeColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl3.Location = new System.Drawing.Point(765, 337);
            this.bahmanButtonControl3.Name = "bahmanButtonControl3";
            this.bahmanButtonControl3.Size = new System.Drawing.Size(163, 77);
            this.bahmanButtonControl3.TabIndex = 5;
            this.bahmanButtonControl3.Text = "Reset";
            this.bahmanButtonControl3.TextColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl3.UseVisualStyleBackColor = false;
            this.bahmanButtonControl3.Click += new System.EventHandler(this.bahmanButtonControl3_Click);
            // 
            // bahmanButtonControl4
            // 
            this.bahmanButtonControl4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bahmanButtonControl4.BorderRadius = 25;
            this.bahmanButtonControl4.BorderSize = 0;
            this.bahmanButtonControl4.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl4.Font = new System.Drawing.Font("W95FA", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bahmanButtonControl4.ForeColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl4.Location = new System.Drawing.Point(765, 420);
            this.bahmanButtonControl4.Name = "bahmanButtonControl4";
            this.bahmanButtonControl4.Size = new System.Drawing.Size(163, 77);
            this.bahmanButtonControl4.TabIndex = 5;
            this.bahmanButtonControl4.Text = "Exit";
            this.bahmanButtonControl4.TextColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl4.UseVisualStyleBackColor = false;
            this.bahmanButtonControl4.Click += new System.EventHandler(this.bahmanButtonControl4_Click);
            // 
            // bahmanButtonControl5
            // 
            this.bahmanButtonControl5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bahmanButtonControl5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bahmanButtonControl5.BorderRadius = 10;
            this.bahmanButtonControl5.BorderSize = 0;
            this.bahmanButtonControl5.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl5.Font = new System.Drawing.Font("W95FA", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bahmanButtonControl5.ForeColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl5.Location = new System.Drawing.Point(922, 0);
            this.bahmanButtonControl5.Name = "bahmanButtonControl5";
            this.bahmanButtonControl5.Size = new System.Drawing.Size(37, 33);
            this.bahmanButtonControl5.TabIndex = 5;
            this.bahmanButtonControl5.Text = "X";
            this.bahmanButtonControl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bahmanButtonControl5.TextColor = System.Drawing.Color.DimGray;
            this.bahmanButtonControl5.UseVisualStyleBackColor = false;
            this.bahmanButtonControl5.Click += new System.EventHandler(this.bahmanButtonControl5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("W95FA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(352, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "By ImBahmanRanjbar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 561);
            this.Controls.Add(this.bahmanButtonControl4);
            this.Controls.Add(this.bahmanButtonControl3);
            this.Controls.Add(this.bahmanButtonControl2);
            this.Controls.Add(this.bahmanButtonControl5);
            this.Controls.Add(this.bahmanButtonControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bahmanTextbox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("W95FA", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BahmanTextBox.BahmanTextbox bahmanTextbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BahmanButton.BahmanButtonControl bahmanButtonControl1;
        private BahmanButton.BahmanButtonControl bahmanButtonControl2;
        private BahmanButton.BahmanButtonControl bahmanButtonControl3;
        private BahmanButton.BahmanButtonControl bahmanButtonControl4;
        private BahmanButton.BahmanButtonControl bahmanButtonControl5;
        private System.Windows.Forms.Label label3;
    }
}

