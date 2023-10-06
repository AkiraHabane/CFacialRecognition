using KimToo;
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
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;Initial Catalog=facialrecognition;Integrated Security=false");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.ShowDialog();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter ad = new MySqlDataAdapter("select name from departments where name='" + txtDepartment.Text + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (txtDepartment.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field cannot be Empty!");
                return;
            }
            else if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Department Already Exists!");
                return;
            }
            else
                ds = new DataSet();
           adapter = new MySqlDataAdapter("insert into departments(name) VALUES('" + txtDepartment.Text + "')", con);
            adapter.Fill(ds, "departments");
            MessageBox.Show("Added Successfully!");
            GetDepts();
            con.Close();
        }
        private void GetDepts()
        {
          
            datagridDept.Columns.Clear();
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select * from departments", con);
            adapter.Fill(ds, "departments");
            datagridDept.DataSource = ds;
            datagridDept.DataMember = "departments";
            //
            var button = new DataGridViewButtonColumn();
            button.Name = "DeleteButton";
            button.HeaderText = "Action";
            button.Text = "Delete";
            button.UseColumnTextForButtonValue = true;

            this.datagridDept.Columns.Add(button);
            con.Close();
        }

        private void GetEmps()
        {
            datagridEmployees.Columns.Clear();
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select id,employee_no,employee_name,employee_dept from employees", con);
            adapter.Fill(ds, "employees");
            datagridEmployees.DataSource = ds;
            datagridEmployees.DataMember = "employees";
            //
            var button = new DataGridViewButtonColumn();
            button.Name = "DeleteButton";
            button.HeaderText = "Action";
            button.Text = "Delete";
            button.UseColumnTextForButtonValue = true;
            
            this.datagridEmployees.Columns.Add(button);
            con.Close();
        }

        private void GetAttendance()
        {
            datagridAttendance.Columns.Clear();
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select id,employee_no,employee_name,employee_dept,tdate,clocked_in_time from attendance", con);
            adapter.Fill(ds, "attendance");
            datagridAttendance.DataSource = ds;
            datagridAttendance.DataMember = "attendance";
            //
            var button = new DataGridViewButtonColumn();
            button.Name = "DeleteButton";
            button.HeaderText = "Action";
            button.Text = "Delete";
            button.UseColumnTextForButtonValue = true;

            this.datagridAttendance.Columns.Add(button);
            con.Close();
        }
        private void GetReport()
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select id,employee_no,employee_name,employee_dept,tdate,clocked_in_time from attendance", con);
            adapter.Fill(ds, "attendancerep");
            datagridReport.DataSource = ds;
            datagridReport.DataMember = "attendancerep";

            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmps();
            GetDepts();
            GetAttendance();
            GetReport();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Close();
            login lg = new login();
            lg.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT id,employee_no,employee_name,employee_dept,tdate,clocked_in_time FROM attendance WHERE tdate BETWEEN '" + dpFrom.Value.ToString("yyyyMMdd") + "'AND'" + dpTo.Value.ToString("yyyyMMdd") + "'", con);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            DataView SortedDataView = new DataView();
            SortedDataView = sd.DefaultView;
            SortedDataView.Sort = "id DESC";
            datagridReport.DataSource = sd;
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GetReport();
        }

        private void imgBtnPrint_Click(object sender, EventArgs e)
        {
            EasyHTMLReports print = new EasyHTMLReports();
            print.AddLineBreak();
            print.HeaderBackgroundColor = Color.LimeGreen;
            print.AddString("<h2>Employee Attendance Report</h2>");
            print.AddString("<h4>Date: <b>" + DateTime.Now.ToString() + " </b> </h4>");
            print.AddLineBreak();
            print.AddHorizontalRule();
            print.AddDatagridView(datagridReport);
            print.ShowPrintPreviewDialog();
        }

        private void cardEmp_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void cardDept_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void cardAtt_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
        }

        private void cardRept_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);
        }

        private void datagridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridEmployees.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                if (datagridEmployees.Rows.Count < 2)
                {
                    MessageBox.Show("Database cannot be Empty! Add another record to Delete this one");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete this Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        del();
                    }
                }
            }
        }
        void del()
        {
            int i = datagridEmployees.CurrentRow.Index;
            ds = new DataSet();
            adapter = new MySqlDataAdapter("delete from employees where id='" + datagridEmployees[0, i].Value.ToString() + "'", con);
            adapter.Fill(ds, "employees");
           
            GetEmps();
            con.Close();
        }
        void delDept()
        {
            int i = datagridDept.CurrentRow.Index;
            ds = new DataSet();
         adapter = new MySqlDataAdapter("delete from departments where id='" + datagridDept[0, i].Value.ToString()+"'", con);
            adapter.Fill(ds, "departments");

            GetDepts();
            con.Close();
        }
        void delAtt()
        {
            int i = datagridAttendance.CurrentRow.Index;
            ds = new DataSet();
            adapter = new MySqlDataAdapter("delete from attendance where id='" + datagridAttendance[0, i].Value.ToString() + "'", con);
            adapter.Fill(ds, "attendance");

            GetAttendance();
            con.Close();
        }

        private void datagridDept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridDept.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                if (datagridDept.Rows.Count < 2)
                {
                    MessageBox.Show("Database cannot be Empty! Add another record to Delete this one");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete this Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       delDept();
                    }
                }
            }
        }

        private void datagridAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridAttendance.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                if (datagridAttendance.Rows.Count < 2)
                {
                    MessageBox.Show("Database cannot be Empty! Add another record to Delete this one");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete this Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        delAtt();
                    }
                }
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
