namespace MyEnglishExam
{
    partial class Form2
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
            this.englishword = new System.Windows.Forms.TextBox();
            this.turkishword = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.english = new System.Windows.Forms.Label();
            this.turkish = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // englishword
            // 
            this.englishword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.englishword.Location = new System.Drawing.Point(16, 43);
            this.englishword.Margin = new System.Windows.Forms.Padding(4);
            this.englishword.Name = "englishword";
            this.englishword.Size = new System.Drawing.Size(132, 30);
            this.englishword.TabIndex = 0;
            // 
            // turkishword
            // 
            this.turkishword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkishword.Location = new System.Drawing.Point(224, 43);
            this.turkishword.Margin = new System.Windows.Forms.Padding(4);
            this.turkishword.Name = "turkishword";
            this.turkishword.Size = new System.Drawing.Size(132, 30);
            this.turkishword.TabIndex = 1;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(123, 94);
            this.execute.Margin = new System.Windows.Forms.Padding(4);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(110, 38);
            this.execute.TabIndex = 2;
            this.execute.Text = "AddWord";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Location = new System.Drawing.Point(49, 23);
            this.english.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(54, 17);
            this.english.TabIndex = 3;
            this.english.Text = "English";
            // 
            // turkish
            // 
            this.turkish.AutoSize = true;
            this.turkish.Location = new System.Drawing.Point(279, 23);
            this.turkish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.turkish.Name = "turkish";
            this.turkish.Size = new System.Drawing.Size(55, 17);
            this.turkish.TabIndex = 4;
            this.turkish.Text = "Turkish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turkish);
            this.Controls.Add(this.english);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.turkishword);
            this.Controls.Add(this.englishword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox englishword;
        public System.Windows.Forms.TextBox turkishword;
        public System.Windows.Forms.Button execute;
        public System.Windows.Forms.Label english;
        public System.Windows.Forms.Label turkish;
        public System.Windows.Forms.Label label3;
    }
}