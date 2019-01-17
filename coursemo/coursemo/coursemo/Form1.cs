//
//Multi-User Coursemo application for UIC Course Registrations
//
//Jahnvi Patel (jpate201)
//U. of Illinois, Chicago
//CS480, Summer 2018
//Project #4
//

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

namespace coursemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Transaction Test Menu
         */ 
        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename, connectionInfo;
            SqlConnection db;
            filename = "Coursemo.mdf";

            connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);

            db = new SqlConnection(connectionInfo);
            db.Open();
            string msg = db.State.ToString();
            MessageBox.Show("Filename: " + filename + "\n" + "Status: " + msg);
            db.Close();
        }//end test connection 


        /**
         * RESET
         */
        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SqlTransaction tx = null;
            string filename, connectionInfo;
            SqlConnection db = null ;
            int retry = 0;

            while (retry < 3)
            {
                try
                {
                    filename = "coursemo.mdf";
                    connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);
                    db = new SqlConnection(connectionInfo);
                    db.Open();
                    tx = db.BeginTransaction(IsolationLevel.Serializable);

                    string sql = string.Format(@"update courses set registered = 0, waitlist = 0
truncate table Registered; truncate table waitlist;");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    cmd.CommandText = sql;
                    cmd.Transaction = tx;
                    adapter.Fill(ds);
                    MessageBox.Show("Database " + filename + " has been reset.");

                    int timeinMS = Convert.ToInt32(delayBox.Text);
                    System.Threading.Thread.Sleep(timeinMS);

                    tx.Commit();
                    retry = 3;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 1205) //Handle deadlock
                    {
                        System.Threading.Thread.Sleep(500);
                        retry++;
                    }

                    else
                    {
                        retry = 3;
                    }
                }//catch

                catch (Exception ex)
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                        MessageBox.Show(ex.Message);
                    }

                    retry = 3;

                }//catch

                finally
                {
                    db.Close();
                }    
            }//while 
        }//end reset


        /**
         * About Author menu
         */ 
        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jahnvi Patel, jpate201\n" +
                            "U.of Illinois, Chicago\n" +
                            "CS480, Summer 2018\n" +
                            "Final Project\n");
        }//end about author


        /**
         * Exit Menu
         */ 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end exit


        /**
         * DISPLAY all students button 
         */ 
        private void allStudents_Click(object sender, EventArgs e)
        {
            string filename, connectionInfo;
            SqlConnection db;

            filename = "coursemo.mdf";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);
            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"SELECT lname, fname, netid from Students
                                        order by lname, fname asc;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.CommandText = sql;
            adapter.Fill(ds);
            db.Close();

            this.studentLst.Items.Clear();
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}, {1}, {2}",
                    Convert.ToString(row["lname"]),
                    Convert.ToString(row["fname"]),
                    Convert.ToString(row["netid"]));

                this.studentLst.Items.Add(msg);
            }
        }//end view all students 


        /**
         * Display All Courses
         */ 
        private void allCourses_Click(object sender, EventArgs e)
        {
            string filename, connectionInfo;
            SqlConnection db;

            filename = "coursemo.mdf";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);
            db = new SqlConnection(connectionInfo);

            //Open a connection
            db.Open();

            string sql = string.Format(@"SELECT DID, CID, CRN from Courses
                                        order by DID, CID, CRN asc;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);
            db.Close();

            this.courseLst.Items.Clear();
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}, {1}, {2}",
                       Convert.ToString(row["DID"]),
                       Convert.ToString(row["CID"]),
                        Convert.ToString(row["CRN"]));

                this.courseLst.Items.Add(msg);
            }
        }//end view all courses


        /**
         * ENROLL button - enroll a student to a course 
         */
        private void buttonEnroll_Click(object sender, EventArgs e)
        {

            string filename, connectionInfo;
            SqlConnection db = null;
            DataSet ds = null;
            SqlTransaction tx = null;
            int retry = 0;
            while (retry < 3)
            {
                try
                {
                    filename = "Coursemo.mdf";
                    connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);

                    db = new SqlConnection(connectionInfo);
                    db.Open();
                    tx = db.BeginTransaction(IsolationLevel.Serializable);

                    string netid = this.textBoxNetID.Text;
                    if (netid == "")
                    {
                        MessageBox.Show("Please enter a NetID...");
                        return;
                    }

                    int crn = Convert.ToInt32(this.textBoxCRN.Text);
                    string emptycrn = Convert.ToString(crn);
                    if (emptycrn == "")
                    {
                        MessageBox.Show("Please enter a course number...");
                        return;
                    }

                    //netid to nid 
                    string findNID = string.Format(@"select NID from students where netid = '{0}'; ", netid);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = findNID;
                    cmd.Transaction = tx;
                    object nid = cmd.ExecuteScalar();

                    if (nid == null)
                        MessageBox.Show("Student not found…");
                    else if (nid == DBNull.Value)
                        MessageBox.Show("Value is NULL…");
                    else
                    {
                        //check if student and course already there 
                        string checkStudentSQL = string.Format(@"select nid, crn from Registered where crn = {0} and nid = {1}", crn, nid);
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = db;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                        cmd2.Transaction = tx;
                        ds = new DataSet();
                        cmd2.CommandText = checkStudentSQL;
                        adapter.Fill(ds);

                        if (adapter.Fill(ds) == 0) /*Insert into registered */
                        {
                            string enrollSQL = string.Format(@"

if  exists (select cap, registered from courses where cap <= registered and crn = {0})
begin
insert into Waitlist(CRN, NID) values ({0}, {1})
update Courses set Waitlist = waitlist + 1 where crn = {0}; 
end
else
    begin
        select * from courses where crn = {0}
if not exists (select crn, nid from Registered where crn = {0} and nid = {1}) insert into Registered(CRN, NID) values ({0}, {1}) 
 update Courses set Courses.Registered = Courses.Registered + 1 where crn = {0} and cap >= Registered;
    end
", crn, nid);

                            SqlCommand cmd3 = new SqlCommand();
                            cmd3.Connection = db;
                            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd3);
                            cmd3.CommandText = enrollSQL;
                            cmd3.Transaction = tx;

                            if (adapter2.Fill(ds) == 1)
                            {
                                MessageBox.Show("Student successfully enrolled.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Student is already enrolled in that course.");
                        }//end else 

                    }//end else 
                  
                        int timeinMS = Convert.ToInt32(delayBox.Text);
                        System.Threading.Thread.Sleep(timeinMS);
                    

                    tx.Commit();
                    retry = 3; 

                }//try
                catch (SqlException ex)
                {
                    if (ex.Number == 1205) //Handle deadlock
                    {
                        System.Threading.Thread.Sleep(500);
                        retry++;
                    }

                    else
                    {
                        retry = 3;
                    }
                }
                catch (Exception ex)
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                        MessageBox.Show(ex.Message);

                    }
                }//catch

                finally
                {
                    db.Close();
                }//finally
            }//end while
        }//end enroll button


        /**
         * 
         * DROP a Course
         */
        private void buttonDrop_Click(object sender, EventArgs e)
        {
            string filename, connectionInfo;
            SqlConnection db = null;
            SqlTransaction tx = null;
            int retry = 0;

            while (retry < 3)
            {
                try
                {
                    filename = "coursemo.mdf";
                    connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);
                    db = new SqlConnection(connectionInfo);
                    db.Open();
                    tx = db.BeginTransaction(IsolationLevel.Serializable);

                    string netid = this.textBoxNetID.Text;
                    int crn = Convert.ToInt32(this.textBoxCRN.Text);
                    string emptycrn = Convert.ToString(crn);

                    if (netid == "")
                    {
                        MessageBox.Show("Please enter a NetID...");
                        return;
                    }
                    if (emptycrn == "")
                    {
                        MessageBox.Show("Please enter a course number...");
                        return;
                    }

                    string sql2 = string.Format(@"delete from Registered 
where crn = {0} and nid = (select NID from students where netid = '{1}'); 

update Courses set Registered = Registered - 1
where crn = {0}", crn, netid);

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = db;
                    cmd2.CommandText = sql2;
                    cmd2.Transaction = tx;
                    int rowsmodified = cmd2.ExecuteNonQuery();

                    int timeinMS = Convert.ToInt32(delayBox.Text);
                    System.Threading.Thread.Sleep(timeinMS);

                    tx.Commit();
                    retry = 3;

                    if (rowsmodified == 0)
                    {
                        MessageBox.Show("Dropping the course failed. Please try again.");
                    }
                    else
                    {
                        MessageBox.Show("You have succcessfully dropped the course " + crn + ".");

                    }//end else
                }//try 

                catch (SqlException ex)
                {
                    if (ex.Number == 1205) //Handle deadlock
                    {
                        System.Threading.Thread.Sleep(500);
                        retry++;
                    }

                    else
                    {
                        retry = 3;
                    }
                }
                catch (Exception ex)
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                        MessageBox.Show(ex.Message);
                    }

                    retry = 3;

                }//catch

                finally
                {
                    db.Close();
                }
            }//while 
        }//end drop button 


        /**
         * Display student's history 
         */
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            string filename, connectionInfo;
            SqlConnection db;

            filename = "coursemo.mdf";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);
            db = new SqlConnection(connectionInfo);
            db.Open();

            string netid = this.textBox_history_netid.Text;
            if (netid == "")
            {
                MessageBox.Show("Please enter a NetID...");
                return;
            }

            string sql = string.Format(@"select NID from students where netid = '{0}'; ", netid);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = sql;
            object result = cmd.ExecuteScalar();

            string sql2 = string.Format(@"Select Courses.DID, Courses.CID, Courses.CRN from Courses
Inner join Registered on Courses.CRN = Registered.CRN where NID = {0}
Order by Courses.DID ASC, Courses.CID ASC, Courses.CRN ASC", result);

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();

            cmd2.CommandText = sql2;
            adapter.Fill(ds);

            this.studentInfoBox.Items.Clear();

            this.studentInfoBox.Items.Add("-----------------------Enrollment-------------------------");
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("DID: {0}, CID: {1}, CRN: {2}",
                    Convert.ToString(row["DID"]),
                    Convert.ToInt32(row["CID"]),
                    Convert.ToInt32(row["CRN"]));
                this.studentInfoBox.Items.Add(msg);
            }

            ////Retrieve watilisted 
            string sql3 = string.Format(@"select Courses.did, Courses.cid, Courses.crn from courses 
inner join waitlist on courses.crn = waitlist.crn 
where nid = {0}
order by did asc, cid asc, crn asc; ", result);

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = db;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd3);
            DataSet ds1 = new DataSet();

            cmd3.CommandText = sql3;
            adapter2.Fill(ds1);

            this.studentInfoBox.Items.Add("-----------------------Waitlisted-------------------------");
            foreach (DataRow row in ds1.Tables["TABLE"].Rows)
            {
                string msg = string.Format("DID: {0}, CID: {1}, CRN: {2}",
                    Convert.ToString(row["DID"]),
                    Convert.ToInt32(row["CID"]),
                    Convert.ToInt32(row["CRN"]));
                this.studentInfoBox.Items.Add(msg);
            }

        }//end display student's course history 

        /**
         * TODO: display waitilist in course information
         * display course information, enrollment and waitlist when a course is selected
         */
        private void buttonCourseInfo_Click(object sender, EventArgs e)
        {
            try
            {

                if (courseLst.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a course from above.");
                    return; 
                }

                string value = courseLst.GetItemText(courseLst.SelectedItem);
                string[] token = value.Split(',');
                string crn_stirng = token[2];
                int crn = Convert.ToInt32(crn_stirng);

                string filename, connectionInfo;
                SqlConnection db;

                filename = "coursemo.mdf";
                connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);
                db = new SqlConnection(connectionInfo);

                db.Open();
                string sql = string.Format(@"select crn, sid, year_, tid, day_, time_, cap, Registered from courses where crn = {0}; ", crn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.CommandText = sql;
                adapter.Fill(ds);

                this.courseInfoLst.Items.Clear();
                this.courseInfoLst.Items.Add("--------------------------Course Info-------------------------");
                foreach (DataRow row in ds.Tables["TABLE"].Rows)
                {
                    string crn_val = string.Format("CRN: {0}", Convert.ToInt32(row["CRN"]));
                    string semester = string.Format("Semester: {0}", Convert.ToString(row["SID"]));
                    string Year = string.Format("Year: {0}", Convert.ToInt32(row["Year_"]));
                    string type = string.Format("Type: {0}", Convert.ToString(row["TID"]));
                    string day = string.Format("Day: {0}", Convert.ToString(row["Day_"]));
                    string Time = string.Format("Time: {0}", Convert.ToString(row["Time_"]));
                    string cap = string.Format("Class Size: {0}", Convert.ToInt32(row["cap"]));
                    string current_enrollment = string.Format("Current Enrollment: {0}", Convert.ToInt32(row["Registered"]));
                    this.courseInfoLst.Items.Add(crn_val);
                    this.courseInfoLst.Items.Add(semester);
                    this.courseInfoLst.Items.Add(Year);
                    this.courseInfoLst.Items.Add(type);
                    this.courseInfoLst.Items.Add(day);
                    this.courseInfoLst.Items.Add(Time);
                    this.courseInfoLst.Items.Add(cap);
                    this.courseInfoLst.Items.Add(current_enrollment);
                }//courseinfo loop

                string sql2 = string.Format(@"select netid from Students
inner join Registered on students.nid = Registered.nid
where crn = {0}", crn);
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = db;
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                cmd2.CommandText = sql2;
                adapter2.Fill(ds2);
              
                this.courseInfoLst.Items.Add("--------------------------Enrollment-------------------------");
                foreach (DataRow row in ds2.Tables["TABLE"].Rows)
                {
                    string netid = string.Format("{0}", Convert.ToString(row["netid"]));
                    this.courseInfoLst.Items.Add(netid);

                }//enrollment loop

                string sql3 = string.Format(@"select netid from Students
inner join Waitlist on students.nid = waitlist.nid
where crn = {0}", crn);
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = db;
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
                DataSet ds3 = new DataSet();
                cmd3.CommandText = sql3;
                adapter3.Fill(ds3);
                db.Close();

                this.courseInfoLst.Items.Add("--------------------------Waitlist-------------------------");
                foreach (DataRow row in ds3.Tables["TABLE"].Rows)
                {
                    string netid = string.Format("{0}", Convert.ToString(row["netid"]));
                    this.courseInfoLst.Items.Add(netid);

                }//waitlist loop

            }//try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            
        }//end display course information


        /**
         * SWAP a course with another student 
         */ 
        private void buttonSwap_Click(object sender, EventArgs e)
        {
            string filename, connectionInfo;
            SqlConnection db = null;
            SqlTransaction tx = null;
            int retry = 0;

            while (retry < 3)
            {
                try
                {
                    filename = "Coursemo.mdf";
                    connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);

                    db = new SqlConnection(connectionInfo);
                    db.Open();
                    tx = db.BeginTransaction(IsolationLevel.Serializable);
                    string swap = String.Format(@"
update Registered set crn = {2}, nid = (select nid from students where netID = '{1}') where crn = {3} and nid = (select nid from students where netID = '{1}') 

update Registered set crn = {3}, nid = (select nid from students where netID = '{0}')  where crn = {2} and nid = (select nid from students where netID = '{0}')
", this.comboBoxSN1.SelectedItem.ToString(), this.comboBoxSN2.SelectedItem.ToString(), this.comboBoxSC1.SelectedItem.ToString(), this.comboBoxSC2.SelectedItem.ToString());
               
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = swap;
                    cmd.Transaction = tx;
                    int rowsModified = cmd.ExecuteNonQuery();


                    int timeinMS = Convert.ToInt32(delayBox.Text);
                    System.Threading.Thread.Sleep(timeinMS);

                    tx.Commit();
                    retry = 3;
                    
                    if (rowsModified == 0)
                    {
                        MessageBox.Show("Swap Failed.");
                    }
                    else MessageBox.Show("Courses successfully swapped.");
                }//try 

                catch (SqlException ex)
                {
                    if (ex.Number == 1205) //Handle deadlock
                    {
                        System.Threading.Thread.Sleep(500);
                        retry++;
                    }

                    else
                    {
                        retry = 3;
                    }
                }
                catch (Exception ex)
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    retry = 3;
                }//catch

                finally
                {
                    db.Close();
                }//finally 
             }//while 
        }//end swap function

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxSC1.Text = ""; 
            this.comboBoxSC1.Items.Clear();
           
            string filename, connectionInfo;
            SqlConnection db = null;

            filename = "Coursemo.mdf";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"Select crn From registered where nid = (select nid From students where netID = '{0}')  order by crn ASC;", this.comboBoxSN1.SelectedItem.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.CommandText = sql;
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = Convert.ToString(row["crn"]);
                this.comboBoxSC1.Items.Add(msg);
                this.comboBoxSC1.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename, connectionInfo;
            SqlConnection db = null;

            filename = "Coursemo.mdf";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"Select netid From Students order by netid ASC;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.CommandText = sql;
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = Convert.ToString(row["netid"]);

                this.comboBoxSN1.Items.Add(msg);
                this.comboBoxSN1.SelectedIndex = 0;
                this.comboBoxSN2.Items.Add(msg);
                this.comboBoxSN2.SelectedIndex = 0;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxSC2.Text = "";
            this.comboBoxSC2.Items.Clear();

            string filename, connectionInfo;
            SqlConnection db = null;

            filename = "Coursemo.mdf";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;  AttachDbFilename=|DataDirectory|\{0};
                                           Integrated Security=True;", filename);

            db = new SqlConnection(connectionInfo);
            db.Open();

            string sql = string.Format(@"Select crn From registered where nid = (select nid From students where netID = '{0}')  order by crn ASC;", this.comboBoxSN2.SelectedItem.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.CommandText = sql;
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = Convert.ToString(row["crn"]);
                this.comboBoxSC2.Items.Add(msg);
                this.comboBoxSC2.SelectedIndex = 0;
            }
        }

    }
}
