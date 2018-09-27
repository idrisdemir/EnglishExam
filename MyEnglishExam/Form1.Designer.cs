namespace MyEnglishExam
{
    partial class Exam
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.getwrong = new System.Windows.Forms.Button();
            this.forweek = new System.Windows.Forms.Button();
            this.formonth = new System.Windows.Forms.Button();
            this.turkish = new System.Windows.Forms.RadioButton();
            this.english = new System.Windows.Forms.RadioButton();
            this.unsuccessful = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addword = new System.Windows.Forms.Button();
            this.updateword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getwrong
            // 
            this.getwrong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.getwrong.Enabled = false;
            this.getwrong.Location = new System.Drawing.Point(1129, 526);
            this.getwrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getwrong.Name = "getwrong";
            this.getwrong.Size = new System.Drawing.Size(117, 33);
            this.getwrong.TabIndex = 3;
            this.getwrong.Text = "GetWrong";
            this.getwrong.UseVisualStyleBackColor = true;
            this.getwrong.Click += new System.EventHandler(this.getwrong_Click);
            // 
            // forweek
            // 
            this.forweek.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.forweek.Location = new System.Drawing.Point(936, 526);
            this.forweek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forweek.Name = "forweek";
            this.forweek.Size = new System.Drawing.Size(108, 33);
            this.forweek.TabIndex = 4;
            this.forweek.Text = "ForWeek";
            this.forweek.UseVisualStyleBackColor = true;
            this.forweek.Click += new System.EventHandler(this.forweek_Click);
            // 
            // formonth
            // 
            this.formonth.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.formonth.Location = new System.Drawing.Point(733, 526);
            this.formonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formonth.Name = "formonth";
            this.formonth.Size = new System.Drawing.Size(109, 31);
            this.formonth.TabIndex = 5;
            this.formonth.Text = "ForMonth";
            this.formonth.UseVisualStyleBackColor = true;
            this.formonth.Click += new System.EventHandler(this.formonth_Click);
            // 
            // turkish
            // 
            this.turkish.AutoSize = true;
            this.turkish.Location = new System.Drawing.Point(525, 536);
            this.turkish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turkish.Name = "turkish";
            this.turkish.Size = new System.Drawing.Size(76, 21);
            this.turkish.TabIndex = 6;
            this.turkish.TabStop = true;
            this.turkish.Text = "Turkish";
            this.turkish.UseVisualStyleBackColor = true;
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Location = new System.Drawing.Point(397, 536);
            this.english.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(75, 21);
            this.english.TabIndex = 7;
            this.english.TabStop = true;
            this.english.Text = "English";
            this.english.UseVisualStyleBackColor = true;
            // 
            // unsuccessful
            // 
            this.unsuccessful.Location = new System.Drawing.Point(1341, 526);
            this.unsuccessful.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unsuccessful.Name = "unsuccessful";
            this.unsuccessful.Size = new System.Drawing.Size(123, 33);
            this.unsuccessful.TabIndex = 11;
            this.unsuccessful.Text = "UnSuccessful";
            this.unsuccessful.UseVisualStyleBackColor = true;
            this.unsuccessful.Click += new System.EventHandler(this.unsuccessful_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.listView1.FullRowSelect = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(16, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(441, 509);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Turkish Word";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "English Word";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mistake";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "No";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader11});
            this.listView2.FullRowSelect = true;
            this.listView2.LabelEdit = true;
            this.listView2.Location = new System.Drawing.Point(488, 4);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(441, 509);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Turkish Word";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "English Word";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mistake";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "No";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader12});
            this.listView3.FullRowSelect = true;
            this.listView3.LabelEdit = true;
            this.listView3.Location = new System.Drawing.Point(963, 4);
            this.listView3.Margin = new System.Windows.Forms.Padding(4);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(441, 509);
            this.listView3.TabIndex = 14;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Turkish Word";
            this.columnHeader7.Width = 128;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "English Word";
            this.columnHeader8.Width = 139;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mistake";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "No";
            // 
            // addword
            // 
            this.addword.Location = new System.Drawing.Point(26, 534);
            this.addword.Name = "addword";
            this.addword.Size = new System.Drawing.Size(93, 36);
            this.addword.TabIndex = 15;
            this.addword.Text = "AddWord";
            this.addword.UseVisualStyleBackColor = true;
            this.addword.Click += new System.EventHandler(this.addword_Click);
            // 
            // updateword
            // 
            this.updateword.Location = new System.Drawing.Point(148, 534);
            this.updateword.Name = "updateword";
            this.updateword.Size = new System.Drawing.Size(102, 36);
            this.updateword.TabIndex = 16;
            this.updateword.Text = "UpdateWord";
            this.updateword.UseVisualStyleBackColor = true;
            this.updateword.Click += new System.EventHandler(this.updateword_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1491, 582);
            this.Controls.Add(this.updateword);
            this.Controls.Add(this.addword);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.unsuccessful);
            this.Controls.Add(this.english);
            this.Controls.Add(this.turkish);
            this.Controls.Add(this.formonth);
            this.Controls.Add(this.forweek);
            this.Controls.Add(this.getwrong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exam";
            this.Text = "Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getwrong;
        private System.Windows.Forms.Button forweek;
        private System.Windows.Forms.Button formonth;
        private System.Windows.Forms.RadioButton turkish;
        private System.Windows.Forms.RadioButton english;
        private System.Windows.Forms.Button unsuccessful;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button addword;
        private System.Windows.Forms.Button updateword;
    }
}

