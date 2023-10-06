using Emgu.CV;
using FaceRecognition;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricFingerprintAttendanceSystem
{
    public partial class attendance : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;Initial Catalog=facialrecognition;Integrated Security=false");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        
        //
       
        public attendance()
        {
            InitializeComponent();
        }
        FaceRec facerec = new FaceRec();
        private void attendance_Load(object sender, EventArgs e)
        {
            populateComboboxDepts();
        }
        private void populateComboboxDepts()
        {
            string selectQuery = "SELECT * FROM departments";
            con.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                drpDepartment.Items.Add(reader.GetString("name"));

            }
            con.Close();
           
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            facerec.isTrained = true;
            if (facerec.isTrained == true)
            {
                btnAttendance.Enabled = true;
                facerec.getPersonName(lblEmp);
               txtEmployeeNo.Text=lblEmp.Text;
            }
            else
            {
                btnAttendance.Enabled = false;
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
           
            //
            MySqlDataAdapter ad = new MySqlDataAdapter("select employee_no from attendance where employee_no='" + lblEmp.Text + "' and tdate='"+DateTime.Now.ToString("yyyyMMdd")+"'", con);
            DataTable dtc = new DataTable();
            ad.Fill(dtc);
            if (lblEmp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field cannot be Empty!");
                return;
            }
            else if (txtEmployeeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field cannot be Empty!");
                return;
            }
            else if (drpDepartment.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field cannot be Empty!");
                return;
            }
            else if (dtc.Rows.Count >= 1)
            {
                MessageBox.Show("Employee Already Marked!");
                //System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Restart();
               
                return;
            }
            else
                ds = new DataSet();
            adapter = new MySqlDataAdapter("insert into attendance(employee_no,employee_name,employee_dept,tdate) VALUES('" + lblEmp.Text + "','" + txtEmployeeName.Text + "','" + drpDepartment.Text + "','" + DateTime.Now.ToString("yyyyMMdd") + "')", con);
            adapter.Fill(ds, "attendance");
            MessageBox.Show("Marked Successfully!");
          
            con.Close();
            
            //clear fields
            lblEmp.Text = txtEmployeeName.Text = drpDepartment.Text = "";
            //
            Application.Restart();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            facerec.openCamera(picFacial, picCaptured);
        }
    }
}
