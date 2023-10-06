using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricFingerprintAttendanceSystem
{
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;Initial Catalog=facialrecognition;Integrated Security=false");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter ad = new MySqlDataAdapter("select email from users where email='" + txtEmail.Text + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field cannot be Empty!");
                return;
            }
            else if (txtUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field cannot be Empty!");
                return;
            }
            else if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field cannot be Empty!");
                return;
            }
            else if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("User Already Exists!");
                return;
            }
            else
                ds = new DataSet();
            adapter = new MySqlDataAdapter("insert into users(username,email,password) VALUES('" + txtUsername.Text + "','" + txtEmail.Text + "','" + Program.CalculateMD5Hash(txtPassword.Text) + "')", con);
            adapter.Fill(ds, "users");
            MessageBox.Show("User Added Successfully!");
            txtUsername.Text = txtEmail.Text = txtPassword.Text = "";

            con.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int i;
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where username='" + lgtxtUsername.Text + "' and password= MD5('" + lgtxtPassword.Text + "')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Invalid Username or Password");
                con.Close();
                return;
            }
            else
            {
                Form1 f = new Form1();
                f.lblUser.Text = lgtxtUsername.Text;
                f.Show();
                con.Close();
                this.Hide();

                }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            attendance at = new attendance();   
            at.ShowDialog();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void login_Shown(object sender, EventArgs e)
        {
            attendance att = new attendance();
            att.ShowDialog();
        }
    }
}
