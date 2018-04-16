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

namespace AtherveCourier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string Employeeid = txt_EmployeeID.Text;

            SqlConnection con = new SqlConnection("Data Source=USHYDPRERNGUPT1\\SQLEXPRESS;Initial Catalog=testConnectionString;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string s = "insert into AtherveEmployee values(@p1)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", Employeeid);
            //cmd.Parameters.AddWithValue("@p2", txtSName.Text);
            //cmd.Parameters.AddWithValue("@p3", txtSCourse.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted ");
            
        }
    }
}
