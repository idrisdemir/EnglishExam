using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyEnglishExam
{
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }
        Form2 form2;
        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=EnglishExam;Integrated Security=True");
        private void ViewEngRecords(int daycount)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView1.Columns[0].Text = "Turkish Word";
            listView1.Columns[1].Text = "English Word";
            listView2.Columns[0].Text = "Turkish Word";
            listView2.Columns[1].Text = "English Word";
            listView3.Columns[0].Text = "Turkish Word";
            listView3.Columns[1].Text = "English Word";
            ListView list = new ListView();
            DateTime time = DateTime.Today;
            time = time.AddDays(-daycount+1);
            connect.Open();
            int number = 0;
            Random rand = new Random();
            ListViewItem item;
            for (int i = 0; i < daycount; i++)
            {
                
                SqlCommand command = new SqlCommand("select * from Word where Date=" + time.ToString("ddMMyyyy"), connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                     item = new ListViewItem();
                    item.Text = "  ";
                    item.Tag = reader[2].ToString();
                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[0].ToString());
                    item.ToolTipText = item.SubItems[1].Text;
                    list.Items.Add(item);
                }
                reader.Close();
                time = time.AddDays(1);

            }
            connect.Close();
            for(int i = list.Items.Count; i > 0;)
            {
                item = list.Items[rand.Next(i)];
                list.Items.Remove(item);
                switch (number % 3)
                {
                    case 0:                       
                        listView1.Items.Add(item);
                        break;
                    case 1:
                        listView2.Items.Add(item);
                        break;
                    case 2:
                        listView3.Items.Add(item);
                        break;

                }
                number++;
                i--;
            }          
        }

        private void ViewTRRecords(int daycount)
        {

            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView1.Columns[0].Text = "English Word";
            listView1.Columns[1].Text = "Turkish Word";
            listView2.Columns[0].Text = "English Word";
            listView2.Columns[1].Text = "Turkish Word";
            listView3.Columns[0].Text = "English Word";
            listView3.Columns[1].Text = "Turkish Word";
            Random rand = new Random();
            ListView list = new ListView();
            ListViewItem item;
            DateTime time = DateTime.Today;
            time = time.AddDays(-daycount+1);
            connect.Open();
            int number = 0;
            for (int i = 0; i < daycount; i++)
            {

                SqlCommand command = new SqlCommand("select * from Word where Date=" + time.ToString("ddMMyyyy"), connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "  ";
                    item.Tag = reader[1].ToString();
                    item.SubItems.Add(reader[2].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[0].ToString());
                    list.Items.Add(item);
                }
                reader.Close();
                time = time.AddDays(1);

            }
            connect.Close();
            for(int i = list.Items.Count; i > 0;)
            {
                item = list.Items[rand.Next(i)];
                list.Items.Remove(item);
                switch (number % 3)
                {
                    case 0:
                        listView1.Items.Add(item);
                        break;
                    case 1:
                        listView2.Items.Add(item);
                        break;
                    case 2:
                        listView3.Items.Add(item);
                        break;

                }
                number++;
                i--;
            }
        }


        private void forweek_Click(object sender, EventArgs e)
        {
            if (turkish.Checked) ViewTRRecords(7);
            else   ViewEngRecords(7);
            getwrong.Enabled = true;
        }

        private void formonth_Click(object sender, EventArgs e)
        {
            if (turkish.Checked) ViewTRRecords(30);
            else ViewEngRecords(30);
            getwrong.Enabled = true;
        }
        private void GetWrong()
        {
            ListView list = new ListView();
            int i = 0;
           int  total = listView1.Items.Count + listView2.Items.Count + listView3.Items.Count;
            for (int j = 0; j < 3; j++)
            {
                ListViewItem item = new ListViewItem();
                try
                {
                    switch (j % 3)
                    {
                        case 0:
                            if (!listView1.Items[0].Tag.ToString().Contains(listView1.Items[0].Text))
                            {
                                item.Text = listView1.Items[0].Tag.ToString();
                                item.SubItems.Add(listView1.Items[0].SubItems[1].Text);
                                item.SubItems.Add(listView1.Items[0].SubItems[2].Text);
                                item.SubItems.Add(listView1.Items[0].SubItems[3].Text);
                                item.Tag = listView1.Items[0].SubItems[1].Text;
                                listView1.Items.RemoveAt(0);
                                listView1.Items.Add(item);
                            }
                            else listView1.Items.RemoveAt(0);
                            i++;
                            break;
                        case 1:
                            if (!listView2.Items[0].Tag.ToString().Contains(listView2.Items[0].Text))
                            {
                                item.Text = listView2.Items[0].Tag.ToString();
                                item.SubItems.Add(listView2.Items[0].SubItems[1].Text);
                                item.SubItems.Add(listView2.Items[0].SubItems[2].Text);
                                item.SubItems.Add(listView2.Items[0].SubItems[3].Text);
                                item.Tag = listView2.Items[0].SubItems[1].Text;
                                listView2.Items.RemoveAt(0);
                                listView2.Items.Add(item);
                            }
                            else listView2.Items.RemoveAt(0);
                            i++;
                            break;
                        case 2:
                            if (!listView3.Items[0].Tag.ToString().Contains(listView3.Items[0].Text))
                            {
                                item.Text = listView3.Items[0].Tag.ToString();
                                item.SubItems.Add(listView3.Items[0].SubItems[1].Text);
                                item.SubItems.Add(listView3.Items[0].SubItems[2].Text);
                                item.Tag = listView3.Items[0].SubItems[1].Text;
                                item.SubItems.Add(listView3.Items[0].SubItems[3].Text);
                                listView3.Items.RemoveAt(0);
                                listView3.Items.Add(item);
                            }
                            else listView3.Items.RemoveAt(0);
                            j = -1;
                            i++;
                            
                            break;
                    }
                    if (i == total) return;
                }
                catch (Exception e)
                {
                   
                    break; 
                }
            }
        }
        private void UpdateWrong()
        {
            connect.Open();
            SqlCommand command;
            try
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    command = new SqlCommand("update Word set WrongCount=" +(int.Parse( listView1.Items[i].SubItems[2].Text)+1).ToString() + " where EngId=" + listView1.Items[i].SubItems[3].Text, connect);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("update Word set WrongCount=" + (int.Parse(listView2.Items[i].SubItems[2].Text) + 1).ToString() + " where EngId=" + listView2.Items[i].SubItems[3].Text, connect);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("update Word set WrongCount=" + (int.Parse(listView3.Items[i].SubItems[2].Text) + 1).ToString() + " where EngId=" + listView3.Items[i].SubItems[3].Text, connect);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

            }
           
            connect.Close();
        }
        private void getwrong_Click(object sender, EventArgs e)
        {
            GetWrong();
            UpdateWrong();
            getwrong.Enabled = false;
        }

        private void unsuccessful_Click(object sender, EventArgs e)
        {
            getwrong.Enabled = true;
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView1.Columns[0].Text = "Turkish Word";
            listView1.Columns[1].Text = "English Word";
            listView2.Columns[0].Text = "Turkish Word";
            listView2.Columns[1].Text = "English Word";
            listView3.Columns[0].Text = "Turkish Word";
            listView3.Columns[1].Text = "English Word";
            int number = 0;
            connect.Open();
            SqlCommand command = new SqlCommand("select * from Word where WrongCount >= 20", connect);
            SqlDataReader reader = command.ExecuteReader();
            ListViewItem item;
            while (reader.Read())
            {
                item = new ListViewItem();
                item.Text = "  ";
                item.Tag = reader[2].ToString();
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[0].ToString());
                switch (number%3)
                {
                    case 0:
                        listView1.Items.Add(item);
                        break;
                    case 1:
                        listView2.Items.Add(item);
                        break;
                    case 2:
                        listView3.Items.Add(item);
                        break;
                }
                number++;
            }

            connect.Close();

        }

        private void addword_Click(object sender, EventArgs e)
        { 
            form2= new Form2();
            form2.execute.Text = "AddWord";
            form2.Show();
        }
        /*
         selectındex olayına göre iteme eşitleyeceğiz sonra iteme göre iş yapcaz
             
             
             */
        ListViewItem item = new ListViewItem();

        private void updateword_Click(object sender, EventArgs e)
        {
            if (item.Text!="")
            {
                form2 = new Form2();
                form2.id = item.SubItems[3].Text;
                form2.execute.Text = "UpdateWord";
                form2.Show();
            }
            else MessageBox.Show("listeden bir veri seçmelisiniz..");

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            item = listView1.SelectedItems[0];           
          
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            item = listView2.SelectedItems[0];
        }

        private void listView3_MouseClick(object sender, MouseEventArgs e)
        {
            item = listView3.SelectedItems[0];
        }
    }
}