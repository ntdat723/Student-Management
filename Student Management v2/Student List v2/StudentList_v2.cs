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
using System.Threading;

namespace Student_List_v2
{
    public partial class StudentManagement : Form
    {
        ThreadStart DatagridUpdate;
        public StudentManagement()
        {
            InitializeComponent();
        }

        
        private void StudentManagement_Load(object sender, EventArgs e)
        {
            ClassBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassBox.Items.Insert(0, "------Select a class------");
            ClassBox.SelectedIndex = 0;
            //DatagridUpdate
        }

        private void ClassBox_DropDown(object sender, EventArgs e)
        {
            SqlConnection StudentDBConnection = new SqlConnection(@"Server=DESKTOP-7R2KB9H; Database=StudentList_Test; User Id=sa; Password=111151244223237");
            
            StudentDBConnection.Open();
            
            string getClassCmd = "SELECT ClassName FROM Class";
            SqlCommand getClass = new SqlCommand(getClassCmd, StudentDBConnection);
            SqlDataAdapter ClassAdapater = new SqlDataAdapter(getClassCmd, StudentDBConnection);
            DataSet ClassIn = new DataSet();
            ClassAdapater.Fill(ClassIn);
            getClass.ExecuteNonQuery();

            StudentDBConnection.Close();
            
            ClassBox.ValueMember = "ClassID";
            ClassBox.DisplayMember = "ClassName";//ClassIn.Tables[0].Columns[0].ToString();
            ClassBox.DataSource = ClassIn.Tables[0];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection StudentListDBConnection = new SqlConnection(@"Server=DESKTOP-7R2KB9H; Database=StudentList_Test; User Id=sa; Password=111151244223237");
            
            DataRowView convertedItem = (DataRowView)ClassBox.SelectedItem;
            string convertedClassName = "";
            if (convertedItem != null)
            {
                convertedClassName = (string)convertedItem.Row["ClassName"];
            }

            StudentListDBConnection.Open();

            string getStudentCmd = "SELECT s.StudentID AS 'ID', s.StudentName AS 'Name', c.ClassName AS 'Class' FROM Student s JOIN Class c ON s.Belong2Class = c.ClassID WHERE c.ClassName = '"
                + convertedClassName + "'";
            SqlCommand getStudent = new SqlCommand(getStudentCmd, StudentListDBConnection);
            SqlDataAdapter StudentAdapter = new SqlDataAdapter(getStudentCmd, StudentListDBConnection);
            DataTable StudentsIn = new DataTable();
            StudentAdapter.Fill(StudentsIn);
            getStudent.ExecuteNonQuery();

            StudentView.DataSource = StudentsIn;
            StudentView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentListDBConnection.Close();
        }
    }
}
