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
    public partial class employee : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;Initial Catalog=facialrecognition;Integrated Security=false");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        //string imgLoc = @"C:\Users\USER\Downloads\fngprint.png";
      
        public employee()
        {
            InitializeComponent();
        }
        FaceRec facerec = new FaceRec();
        private void btnCapture_Click(object sender, EventArgs e)
        {
            facerec.openCamera(picCamera, picCaptured);
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

        private void employee_Load(object sender, EventArgs e)
        {
            populateComboboxDepts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image myImage = picCamera.Image;
            byte[] data;
            using (MemoryStream ms = new MemoryStream())
            {
                myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                data = ms.ToArray();
            }
            //
            MySqlDataAdapter ad = new MySqlDataAdapter("select employee_no from employees where employee_no='" + txtEmployeeNo.Text + "'", con);
            DataTable dtc = new DataTable();
            ad.Fill(dtc);
            if (txtEmployeeNo.Text.Trim().Length == 0)
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
                MessageBox.Show("Employee Already Exists!");
                return;
            }
            else
            facerec.Save_IMAGE(txtEmployeeNo.Text);
            MessageBox.Show("Saved!");
            //
            ds = new DataSet();
            adapter = new MySqlDataAdapter("insert into employees(employee_no,employee_name,employee_dept) VALUES('" + txtEmployeeNo.Text + "','" + txtEmployeeName.Text + "','" + drpDepartment.Text + "')", con);
            adapter.Fill(ds, "employees");
            MessageBox.Show("Added Successfully!");
            
            con.Close();

            //clear fields
            txtEmployeeNo.Text=txtEmployeeName.Text=drpDepartment.Text="";
        }


    }
}
