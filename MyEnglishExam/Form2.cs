using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEnglishExam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=EnglishExam;Integrated Security=True");
        public string id;
        private void execute_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (execute.Text == "AddWord")
            {
                SqlCommand command = new SqlCommand("insert into Word(EnglishWord,TurkishWord,WrongCount,Date) Values('" + englishword.Text + "','" + turkishword.Text +
               "','0','" + DateTime.Now.ToString("ddMMyyyy") + "')", connect);
                command.ExecuteNonQuery();
                englishword.Text = "";
                turkishword.Text = "";
            }
            else
            {
                SqlCommand command = new SqlCommand("Update Word set EnglishWord='"+
                    englishword.Text+"',"+"TurkishWord='"+turkishword.Text+"' where EngId="+id,connect);
                command.ExecuteNonQuery();
            }
            connect.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (execute.Text == "UpdateWord")
            {
                connect.Open();
                SqlCommand command = new SqlCommand("select * from Word where EngId=" + id, connect);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                turkishword.Text = reader[2].ToString();
                englishword.Text = reader[1].ToString();
                reader.Close();
                connect.Close();

            }

        }
    }
}
