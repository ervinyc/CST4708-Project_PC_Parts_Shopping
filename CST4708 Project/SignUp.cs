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

namespace CST4708_Project
{
    public partial class SignUp : Form
    {
        SqlConnection myconn;
        SqlDataAdapter myadapter = new SqlDataAdapter();
        SqlCommand inscmd = new SqlCommand();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBttn_Click(object sender, EventArgs e)
        {
            if (PhoneNumTB.Text.Length > 10)
            {
                MessageBox.Show("Phone Number too Long");
            }
            if (FirstNameTB.Text == "" || LastNameTB.Text == "" || EmailTB.Text == "" || PhoneNumTB.Text == "" || PWTB.Text == "" || ConfirmPWTB.Text == "")
            {
                MessageBox.Show("Missing Crucial information");
            }

            if (FirstNameTB.Text != "" && LastNameTB.Text != "" && EmailTB.Text != "" && PhoneNumTB.Text != "" && PhoneNumTB.Text.Length < 10 && PWTB.Text == ConfirmPWTB.Text)
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mike\\source\\repos\\jifjeff\\CST4708Project\\FinalProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
                myconn.Open();

                inscmd.Connection = myconn;
                //Dont forget to Connect the UID somehow:
                inscmd.CommandText = "INSERT INTO Customer (UserEmail,UserPassword, UserFirstName,UserMidName, UserLastName, Phone) VALUES(@UserEmail,@UserPassword,@UserFirstName,@UserMidName,@UserLastName,@Phone) ";

                //inscmd.Parameters.Add(new SqlParameter("@PayID", SqlDbType.Int) { Value = Payid});
                //inscmd.Parameters.Add(new SqlParameter("@UID", SqlDbType.Int) { Value = Payid });
                inscmd.Parameters.Add(new SqlParameter("@UserEmail", SqlDbType.VarChar, 100) { Value = EmailTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@UserPassword", SqlDbType.VarChar, 25) { Value = PWTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@UserFirstName", SqlDbType.VarChar, 25) { Value = FirstNameTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@UserMidName", SqlDbType.VarChar, 25) { Value = MidNameTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@UserLastName", SqlDbType.VarChar, 25) { Value = LastNameTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 10) { Value = PhoneNumTB.Text });
                inscmd.ExecuteNonQuery();


                MessageBox.Show("Your account has been created! ");

                FirstNameTB.Clear();
                MidNameTB.Clear();
                LastNameTB.Clear();
                EmailTB.Clear();
                PhoneNumTB.Clear();
                PWTB.Clear();
                ConfirmPWTB.Clear();


            }
        }
    }
}
