using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTaskFrame132
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server = .\SQLEXPRESS; Database = MatrixWinFromTask; Integrated Security = true";
        int teacherId = 0;
        int studentId = 0;
        int classId = 0;

        public Form1()
        {
            try
            {
                InitializeComponent();
                this.gv_Teacher.SelectionChanged -= new System.EventHandler(this.gv_Teacher_SelectionChanged);
                this.gv_Student.SelectionChanged -= new System.EventHandler(this.gv_Student_SelectionChanged);
                this.gv_Class.SelectionChanged -= new System.EventHandler(this.gv_Class_SelectionChanged);
            }
            catch(Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();                    
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand teacherQuery = new SqlCommand("SELECT * FROM TEACHER", con);
                    SqlCommand studentQuery = new SqlCommand("SELECT * FROM STUDENT", con);
                    SqlCommand classQuery = new SqlCommand("SELECT * FROM CLASS", con);
                    DataTable teacherTable = new DataTable();
                    DataTable studentTable = new DataTable();
                    DataTable classTable = new DataTable();

                    con.Open();
                    SqlDataReader teacherReader = teacherQuery.ExecuteReader();
                    teacherTable.Load(teacherReader);
                    con.Close();

                    classTeacherName.DataSource = teacherTable;
                    classTeacherName.DisplayMember = "TEACHER_NAME";
                    classTeacherName.Text = teacherTable.Rows[0]["TEACHER_NAME"].ToString();

                    con.Open();
                    SqlDataReader classReader = classQuery.ExecuteReader();
                    classTable.Load(classReader);
                    con.Close();

                    con.Open();
                    SqlDataReader studentReader = studentQuery.ExecuteReader();
                    studentTable.Load(studentReader);
                    con.Close();

                    studentClassName.DataSource = classTable;
                    studentClassName.DisplayMember = "CLASS_NAME";

                    studentClassName.Text = classTable.Rows[0]["CLASS_NAME"].ToString();

                    gv_Teacher.DataSource = teacherTable;
                    gv_Student.DataSource = studentTable;
                    gv_Class.DataSource = classTable;
                }

                this.gv_Teacher.SelectionChanged += new System.EventHandler(this.gv_Teacher_SelectionChanged);
                this.gv_Student.SelectionChanged += new System.EventHandler(this.gv_Student_SelectionChanged);
                this.gv_Class.SelectionChanged += new System.EventHandler(this.gv_Class_SelectionChanged);
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }           
        }

        #region TeacherButtonFunctions
        private void addTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string name = teacherName.Text;
                string surName = teacherSurName.Text;
                string entryDate = teacherDate.Text;
                string isActive = teacherIsActive.Text;
                byte oneOrZero = Convert.ToByte(isActive);

                if (oneOrZero != 0 && oneOrZero != 1)
                {
                    MessageBox.Show("Activity pole only accepts two values(1 and 0)");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        DataTable dt = new DataTable();
                        SqlCommand insertQuery = new SqlCommand("INSERT INTO TEACHER VALUES(@name, @surname, @entryDate, @isActive)", con);
                        SqlCommand selectQuery = new SqlCommand("SELECT * FROM TEACHER", con);

                        insertQuery.Parameters.AddWithValue("@name", name);
                        insertQuery.Parameters.AddWithValue("@surname", surName);
                        insertQuery.Parameters.AddWithValue("@entryDate", entryDate);
                        insertQuery.Parameters.AddWithValue("@isActive", isActive);

                        con.Open();
                        _ = insertQuery.ExecuteNonQuery();
                        SqlDataReader dr = selectQuery.ExecuteReader();
                        dt.Load(dr);
                        con.Close();

                        gv_Teacher.DataSource = dt;

                        classTeacherName.DataSource = dt;
                        classTeacherName.ValueMember = "ID";
                        classTeacherName.DisplayMember = "TEACHER_NAME";
                        classTeacherName.Text = dt.Rows[0]["TEACHER_NAME"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
            
        }

        private void deleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand deleteQuery = new SqlCommand("DELETE FROM TEACHER WHERE ID = @id", con);
                    SqlCommand selectQuery = new SqlCommand("SELECT * FROM TEACHER", con);
                    DataTable dt = new DataTable();

                    deleteQuery.Parameters.AddWithValue("@id", teacherId);

                    con.Open();
                    _ = deleteQuery.ExecuteNonQuery();
                    SqlDataReader dr = selectQuery.ExecuteReader();
                    dt.Load(dr);
                    con.Close();

                    gv_Teacher.DataSource = dt;

                    classTeacherName.DataSource = dt;
                    classTeacherName.ValueMember = "ID";
                    classTeacherName.DisplayMember = "TEACHER_NAME";
                    classTeacherName.Text = dt.Rows[0]["TEACHER_NAME"].ToString();
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }

        private void updateTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string name = teacherName.Text;
                string surName = teacherSurName.Text;
                string entryDate = teacherDate.Text;
                string isActive = teacherIsActive.Text;
                byte oneOrZero = Convert.ToByte(isActive);

                if (oneOrZero != 0 && oneOrZero != 1)
                {
                    MessageBox.Show("Activity pole only acceptss two values(1 and 0)");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        DataTable dt = new DataTable();
                        SqlCommand insertQuery = new SqlCommand("UPDATE TEACHER SET TEACHER_NAME = @name, SURNAME = @surname, " +
                        " ENTER_DATE = @entryDate, IS_ACTIVE = @isActive WHERE ID = @id", con);
                        SqlCommand selectQuery = new SqlCommand("SELECT * FROM TEACHER", con);

                        insertQuery.Parameters.AddWithValue("@name", name);
                        insertQuery.Parameters.AddWithValue("@surname", surName);
                        insertQuery.Parameters.AddWithValue("@entryDate", entryDate);
                        insertQuery.Parameters.AddWithValue("@isActive", isActive);
                        insertQuery.Parameters.AddWithValue("@id", teacherId);

                        con.Open();
                        _ = insertQuery.ExecuteNonQuery();
                        SqlDataReader dr = selectQuery.ExecuteReader();
                        dt.Load(dr);
                        con.Close();

                        gv_Teacher.DataSource = dt;

                        classTeacherName.DataSource = dt;
                        classTeacherName.ValueMember = "ID";
                        classTeacherName.DisplayMember = "TEACHER_NAME";
                        classTeacherName.Text = dt.Rows[0]["TEACHER_NAME"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }           
        }

        private void gv_Teacher_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = gv_Teacher.CurrentCell.RowIndex;
                teacherId = (int)gv_Teacher.Rows[rowIndex].Cells["ID"].Value;
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }
        #endregion

        #region StudentButtonFunctions
        private void addStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = studentName.Text;
                string surName = studentSurName.Text;
                string entryDate = studentDate.Text;
                string isActive = studentIsActive.Text;
                studentClassName.ValueMember = "ID";
                int classID = (int)studentClassName.SelectedValue;
                byte oneOrZero = Convert.ToByte(isActive);

                if (oneOrZero != 0 && oneOrZero != 1)
                {
                    MessageBox.Show("Activity pole only accepts two values(1 and 0)");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        //insert function
                        SqlCommand insertQuery = new SqlCommand("INSERT INTO STUDENT VALUES(@name, @surname, @entryDate, @classId, @isActive)", con);
                        SqlCommand selectQuery = new SqlCommand("SELECT * FROM STUDENT", con);
                        DataTable dt = new DataTable();

                        insertQuery.Parameters.AddWithValue("@name", name);
                        insertQuery.Parameters.AddWithValue("@surName", surName);
                        insertQuery.Parameters.AddWithValue("@entryDate", entryDate);
                        insertQuery.Parameters.AddWithValue("@isActive", isActive);
                        insertQuery.Parameters.AddWithValue("@classId", classID);

                        con.Open();
                        _ = insertQuery.ExecuteNonQuery();
                        SqlDataReader dr = selectQuery.ExecuteReader();
                        dt.Load(dr);
                        con.Close();

                        gv_Student.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand deleteQuery = new SqlCommand("DELETE FROM STUDENT WHERE ID = @id", con);
                    SqlCommand selectQuery = new SqlCommand("SELECT * FROM STUDENT", con);
                    DataTable dt = new DataTable();

                    deleteQuery.Parameters.AddWithValue("@id", studentId);

                    con.Open();
                    _ = deleteQuery.ExecuteNonQuery();
                    SqlDataReader dr = selectQuery.ExecuteReader();
                    dt.Load(dr);
                    con.Close();

                    gv_Student.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }           
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = studentName.Text;
                string surName = studentSurName.Text;
                string entryDate = studentDate.Text;
                string isActive = studentIsActive.Text;
                studentClassName.ValueMember = "ID";
                int classId = (int)studentClassName.SelectedValue;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand updateQuery = new SqlCommand("UPDATE STUDENT SET STUDENT_NAME = @name, SURNAME = @surname, " +
                    "ENTER_DATE = @entryDate, CLASS_ID = @classID, IS_ACTIVE = @isActive WHERE ID = @id", con);
                    SqlCommand selectQuery = new SqlCommand("SELECT * FROM STUDENT", con);
                    DataTable dt = new DataTable();

                    updateQuery.Parameters.AddWithValue("@id", studentId);
                    updateQuery.Parameters.AddWithValue("@name", name);
                    updateQuery.Parameters.AddWithValue("@surname", surName);
                    updateQuery.Parameters.AddWithValue("@entryDate", entryDate);
                    updateQuery.Parameters.AddWithValue("@classID", classId);
                    updateQuery.Parameters.AddWithValue("@isActive", isActive);

                    con.Open();
                    _ = updateQuery.ExecuteNonQuery();
                    SqlDataReader dr = selectQuery.ExecuteReader();
                    dt.Load(dr);
                    con.Close();

                    gv_Student.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }          
        }

        private void gv_Student_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = gv_Student.CurrentCell.RowIndex;
                studentId = (int)gv_Student.Rows[rowIndex].Cells["ID"].Value;
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }

        #endregion

        #region ClassButtonFunctions
        private void addClass_Click(object sender, EventArgs e)
        {
            try
            {
                string name = className.Text;
                string creationDate = classDate.Text;
                classTeacherName.ValueMember = "ID";
                int teacherID = (int)classTeacherName.SelectedValue;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand insertQuery = new SqlCommand("INSERT INTO CLASS(CLASS_NAME,CREATE_DATE,TEACHER_ID) " +
                    "VALUES(@name, @creationDate, @teacherID)", con);
                    SqlCommand selectQuery = new SqlCommand("SELECT * FROM CLASS", con);
                    DataTable selectTable = new DataTable();

                    insertQuery.Parameters.AddWithValue("@name", name);
                    insertQuery.Parameters.AddWithValue("@creationDate", creationDate);
                    insertQuery.Parameters.AddWithValue("@teacherID", teacherID);

                    con.Open();
                    _ = insertQuery.ExecuteNonQuery();
                    var selectReader = selectQuery.ExecuteReader();
                    selectTable.Load(selectReader);
                    con.Close();

                    gv_Class.DataSource = selectTable;

                    studentClassName.DataSource = selectTable;
                    studentClassName.ValueMember = "ID";
                    studentClassName.DisplayMember = "CLASS_NAME";
                    studentClassName.Text = selectTable.Rows[0]["CLASS_NAME"].ToString();
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }

        private void deleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand deleteQuery = new SqlCommand("DELETE FROM CLASS WHERE ID = @id", con);
                    SqlCommand selectQuery = new SqlCommand("SELECT * FROM CLASS", con);
                    DataTable classTable = new DataTable();

                    deleteQuery.Parameters.AddWithValue("@id", classId);

                    con.Open();
                    _ = deleteQuery.ExecuteNonQuery();
                    var classReader = selectQuery.ExecuteReader();
                    classTable.Load(classReader);
                    con.Close();

                    gv_Class.DataSource = classTable;

                    studentClassName.DataSource = classTable;
                    studentClassName.ValueMember = "ID";
                    studentClassName.DisplayMember = "CLASS_NAME";
                    studentClassName.Text = classTable.Rows[0]["CLASS_NAME"].ToString();
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }

        private void updateClass_Click(object sender, EventArgs e)
        {
            try
            {
                string name = className.Text;
                string creationDate = classDate.Text;
                classTeacherName.ValueMember = "ID";
                int teacherID = (int)classTeacherName.SelectedValue;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand updateQuery = new SqlCommand("UPDATE CLASS SET CLASS_NAME = @name, CREATE_DATE = @creationDate," +
                        "TEACHER_ID = @teacherID WHERE ID = @id", con);
                    SqlCommand selectQuery = new SqlCommand("SELECT * FROM CLASS", con);
                    DataTable selectTable = new DataTable();

                    updateQuery.Parameters.AddWithValue("@name", name);
                    updateQuery.Parameters.AddWithValue("@creationDate", creationDate);
                    updateQuery.Parameters.AddWithValue("@teacherID", teacherID);
                    updateQuery.Parameters.AddWithValue("@id", classId);

                    con.Open();
                    _ = updateQuery.ExecuteNonQuery();
                    var selectReader = selectQuery.ExecuteReader();
                    selectTable.Load(selectReader);
                    con.Close();

                    gv_Class.DataSource = selectTable;

                    studentClassName.DataSource = selectTable;
                    studentClassName.ValueMember = "ID";
                    studentClassName.DisplayMember = "CLASS_NAME";
                    studentClassName.Text = selectTable.Rows[0]["CLASS_NAME"].ToString();
                }
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }

        private void gv_Class_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = gv_Class.CurrentCell.RowIndex;
                classId = (int)gv_Class.Rows[rowIndex].Cells["ID"].Value;
            }
            catch (Exception ex)
            {
                string exe_Path = Directory.GetCurrentDirectory();
                string log_Path = Path.Combine(exe_Path, @"Log");
                string log_File_Path = Path.Combine(log_Path, @"log.txt");
                Directory.CreateDirectory(log_Path);

                if (File.Exists(log_File_Path))
                {
                    StreamWriter log_Writer = new StreamWriter(log_File_Path);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                }
                else
                {
                    FileStream log_File = File.Create(log_File_Path);
                    StreamWriter log_Writer = new StreamWriter(log_File);
                    log_Writer.WriteLine(ex.Message);
                    log_Writer.Close();
                    log_File.Close();
                }
            }
        }
        #endregion
    }
}
