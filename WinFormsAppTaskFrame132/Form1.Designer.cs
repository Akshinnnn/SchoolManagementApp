namespace WinFormsAppTaskFrame132
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_Teacher = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gv_Student = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gv_Class = new System.Windows.Forms.DataGridView();
            this.teacherName = new System.Windows.Forms.RichTextBox();
            this.teacherSurName = new System.Windows.Forms.RichTextBox();
            this.teacherDate = new System.Windows.Forms.RichTextBox();
            this.teacherIsActive = new System.Windows.Forms.RichTextBox();
            this.addTeacher = new System.Windows.Forms.Button();
            this.deleteTeacher = new System.Windows.Forms.Button();
            this.updateTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentIsActive = new System.Windows.Forms.RichTextBox();
            this.studentDate = new System.Windows.Forms.RichTextBox();
            this.studentSurName = new System.Windows.Forms.RichTextBox();
            this.studentName = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.classDate = new System.Windows.Forms.RichTextBox();
            this.className = new System.Windows.Forms.RichTextBox();
            this.updateStudent = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.updateClass = new System.Windows.Forms.Button();
            this.deleteClass = new System.Windows.Forms.Button();
            this.addClass = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.classTeacherName = new System.Windows.Forms.ComboBox();
            this.studentClassName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Teacher)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Student)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Class)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gv_Teacher);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 305);
            this.panel1.TabIndex = 0;
            // 
            // gv_Teacher
            // 
            this.gv_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Teacher.Location = new System.Drawing.Point(0, 0);
            this.gv_Teacher.Name = "gv_Teacher";
            this.gv_Teacher.RowHeadersWidth = 51;
            this.gv_Teacher.Size = new System.Drawing.Size(485, 305);
            this.gv_Teacher.TabIndex = 0;
            this.gv_Teacher.SelectionChanged += new System.EventHandler(this.gv_Teacher_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gv_Student);
            this.panel2.Location = new System.Drawing.Point(518, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 305);
            this.panel2.TabIndex = 1;
            // 
            // gv_Student
            // 
            this.gv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Student.Location = new System.Drawing.Point(0, 0);
            this.gv_Student.Name = "gv_Student";
            this.gv_Student.RowHeadersWidth = 51;
            this.gv_Student.Size = new System.Drawing.Size(498, 305);
            this.gv_Student.TabIndex = 0;
            this.gv_Student.SelectionChanged += new System.EventHandler(this.gv_Student_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gv_Class);
            this.panel3.Location = new System.Drawing.Point(1035, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 305);
            this.panel3.TabIndex = 2;
            // 
            // gv_Class
            // 
            this.gv_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Class.Location = new System.Drawing.Point(0, 0);
            this.gv_Class.Name = "gv_Class";
            this.gv_Class.RowHeadersWidth = 51;
            this.gv_Class.Size = new System.Drawing.Size(489, 305);
            this.gv_Class.TabIndex = 0;
            this.gv_Class.SelectionChanged += new System.EventHandler(this.gv_Class_SelectionChanged);
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(12, 352);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(206, 32);
            this.teacherName.TabIndex = 3;
            this.teacherName.Text = "";
            // 
            // teacherSurName
            // 
            this.teacherSurName.Location = new System.Drawing.Point(12, 407);
            this.teacherSurName.Name = "teacherSurName";
            this.teacherSurName.Size = new System.Drawing.Size(206, 32);
            this.teacherSurName.TabIndex = 4;
            this.teacherSurName.Text = "";
            // 
            // teacherDate
            // 
            this.teacherDate.Location = new System.Drawing.Point(12, 467);
            this.teacherDate.Name = "teacherDate";
            this.teacherDate.Size = new System.Drawing.Size(206, 32);
            this.teacherDate.TabIndex = 5;
            this.teacherDate.Text = "";
            // 
            // teacherIsActive
            // 
            this.teacherIsActive.Location = new System.Drawing.Point(12, 527);
            this.teacherIsActive.Name = "teacherIsActive";
            this.teacherIsActive.Size = new System.Drawing.Size(206, 32);
            this.teacherIsActive.TabIndex = 6;
            this.teacherIsActive.Text = "";
            // 
            // addTeacher
            // 
            this.addTeacher.Location = new System.Drawing.Point(315, 373);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(100, 37);
            this.addTeacher.TabIndex = 7;
            this.addTeacher.Text = "Add";
            this.addTeacher.UseVisualStyleBackColor = true;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // deleteTeacher
            // 
            this.deleteTeacher.Location = new System.Drawing.Point(315, 428);
            this.deleteTeacher.Name = "deleteTeacher";
            this.deleteTeacher.Size = new System.Drawing.Size(100, 37);
            this.deleteTeacher.TabIndex = 8;
            this.deleteTeacher.Text = "Delete";
            this.deleteTeacher.UseVisualStyleBackColor = true;
            this.deleteTeacher.Click += new System.EventHandler(this.deleteTeacher_Click);
            // 
            // updateTeacher
            // 
            this.updateTeacher.Location = new System.Drawing.Point(315, 483);
            this.updateTeacher.Name = "updateTeacher";
            this.updateTeacher.Size = new System.Drawing.Size(100, 37);
            this.updateTeacher.TabIndex = 9;
            this.updateTeacher.Text = "Update";
            this.updateTeacher.UseVisualStyleBackColor = true;
            this.updateTeacher.Click += new System.EventHandler(this.updateTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Teacher Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Entry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Activity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Activity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Entry Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Student Surname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Student Name";
            // 
            // studentIsActive
            // 
            this.studentIsActive.Location = new System.Drawing.Point(518, 527);
            this.studentIsActive.Name = "studentIsActive";
            this.studentIsActive.Size = new System.Drawing.Size(206, 32);
            this.studentIsActive.TabIndex = 17;
            this.studentIsActive.Text = "";
            // 
            // studentDate
            // 
            this.studentDate.Location = new System.Drawing.Point(518, 467);
            this.studentDate.Name = "studentDate";
            this.studentDate.Size = new System.Drawing.Size(206, 32);
            this.studentDate.TabIndex = 16;
            this.studentDate.Text = "";
            // 
            // studentSurName
            // 
            this.studentSurName.Location = new System.Drawing.Point(518, 407);
            this.studentSurName.Name = "studentSurName";
            this.studentSurName.Size = new System.Drawing.Size(206, 32);
            this.studentSurName.TabIndex = 15;
            this.studentSurName.Text = "";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(518, 352);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(206, 32);
            this.studentName.TabIndex = 14;
            this.studentName.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1035, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Creation Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1035, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Class Name";
            // 
            // classDate
            // 
            this.classDate.Location = new System.Drawing.Point(1035, 416);
            this.classDate.Name = "classDate";
            this.classDate.Size = new System.Drawing.Size(206, 32);
            this.classDate.TabIndex = 26;
            this.classDate.Text = "";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(1035, 352);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(206, 32);
            this.className.TabIndex = 25;
            this.className.Text = "";
            // 
            // updateStudent
            // 
            this.updateStudent.Location = new System.Drawing.Point(818, 486);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Size = new System.Drawing.Size(100, 37);
            this.updateStudent.TabIndex = 36;
            this.updateStudent.Text = "Update";
            this.updateStudent.UseVisualStyleBackColor = true;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(818, 431);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(100, 37);
            this.deleteStudent.TabIndex = 35;
            this.deleteStudent.Text = "Delete";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(818, 376);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(100, 37);
            this.addStudent.TabIndex = 34;
            this.addStudent.Text = "Add";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // updateClass
            // 
            this.updateClass.Location = new System.Drawing.Point(1354, 483);
            this.updateClass.Name = "updateClass";
            this.updateClass.Size = new System.Drawing.Size(100, 37);
            this.updateClass.TabIndex = 39;
            this.updateClass.Text = "Update";
            this.updateClass.UseVisualStyleBackColor = true;
            this.updateClass.Click += new System.EventHandler(this.updateClass_Click);
            // 
            // deleteClass
            // 
            this.deleteClass.Location = new System.Drawing.Point(1354, 428);
            this.deleteClass.Name = "deleteClass";
            this.deleteClass.Size = new System.Drawing.Size(100, 37);
            this.deleteClass.TabIndex = 38;
            this.deleteClass.Text = "Delete";
            this.deleteClass.UseVisualStyleBackColor = true;
            this.deleteClass.Click += new System.EventHandler(this.deleteClass_Click);
            // 
            // addClass
            // 
            this.addClass.Location = new System.Drawing.Point(1354, 373);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(100, 37);
            this.addClass.TabIndex = 37;
            this.addClass.Text = "Add";
            this.addClass.UseVisualStyleBackColor = true;
            this.addClass.Click += new System.EventHandler(this.addClass_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1037, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Teacher Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Class Name";
            // 
            // classTeacherName
            // 
            this.classTeacherName.FormattingEnabled = true;
            this.classTeacherName.Location = new System.Drawing.Point(1035, 481);
            this.classTeacherName.Name = "classTeacherName";
            this.classTeacherName.Size = new System.Drawing.Size(206, 28);
            this.classTeacherName.TabIndex = 44;
            // 
            // studentClassName
            // 
            this.studentClassName.FormattingEnabled = true;
            this.studentClassName.Location = new System.Drawing.Point(518, 587);
            this.studentClassName.Name = "studentClassName";
            this.studentClassName.Size = new System.Drawing.Size(206, 28);
            this.studentClassName.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 753);
            this.Controls.Add(this.studentClassName);
            this.Controls.Add(this.classTeacherName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.updateClass);
            this.Controls.Add(this.deleteClass);
            this.Controls.Add(this.addClass);
            this.Controls.Add(this.updateStudent);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.classDate);
            this.Controls.Add(this.className);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentIsActive);
            this.Controls.Add(this.studentDate);
            this.Controls.Add(this.studentSurName);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateTeacher);
            this.Controls.Add(this.deleteTeacher);
            this.Controls.Add(this.addTeacher);
            this.Controls.Add(this.teacherIsActive);
            this.Controls.Add(this.teacherDate);
            this.Controls.Add(this.teacherSurName);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Teacher)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Student)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gv_Teacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gv_Student;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gv_Class;
        private System.Windows.Forms.RichTextBox teacherName;
        private System.Windows.Forms.RichTextBox teacherSurName;
        private System.Windows.Forms.RichTextBox teacherDate;
        private System.Windows.Forms.RichTextBox teacherIsActive;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.Button deleteTeacher;
        private System.Windows.Forms.Button updateTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox studentIsActive;
        private System.Windows.Forms.RichTextBox studentDate;
        private System.Windows.Forms.RichTextBox studentSurName;
        private System.Windows.Forms.RichTextBox studentName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox classDate;
        private System.Windows.Forms.RichTextBox className;
        private System.Windows.Forms.Button updateStudent;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button updateClass;
        private System.Windows.Forms.Button deleteClass;
        private System.Windows.Forms.Button addClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox classTeacherName;
        private System.Windows.Forms.ComboBox studentClassName;
    }
}
