using System.Data.SqlClient;
using System.Data;
namespace CST4708_Project
{
    public partial class SupportPage : Form
    {
        SqlConnection myconn;
        SqlDataAdapter myadapter = new SqlDataAdapter();
        SqlCommand inscmd = new SqlCommand();

        public SupportPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
            
        {
            if (EmailTextBox.Text == "")
            {
                EmailErrorLabel.Visible = true;
            }
            else
            {
                EmailErrorLabel.Visible = false;
            }

            if (OrderNumberTextBox.Text == "")
            {
                OrderNumErrorLable.Visible = true;
            }
            else
            {
                OrderNumErrorLable.Visible= false;
            }

            if (SubjectTextBox.Text == "")
            {
                SubjectErrorLabel.Visible=true;
            }
            else
            {
                SubjectErrorLabel.Visible= false;
            }

            if (DescriptionTextBox.Text == "")
            {
                DescriptionErrorLabel.Visible=true;
            }
            else
            {
                DescriptionErrorLabel.Visible= false;
            }
            if (EmailTextBox.Text != "" && OrderNumberTextBox.Text != "" && SubjectTextBox.Text != "" && DescriptionTextBox.Text != "")
            {
                String CheckedBox = "";
                if (DamagedCheckBox.Checked == true)
                {
                    CheckedBox = DamagedCheckBox.Text;
                }
                if (MissingCheckBox.Checked == true)
                {
                    CheckedBox = MissingCheckBox.Text;
                }
                if(PurchaseErrorCheckBox.Checked == true)
                {
                    CheckedBox = PurchaseErrorCheckBox.Text;
                }
                if(OtherCheckBox.Checked == true)
                {
                    CheckedBox = OtherCheckBox.Text;
                }
                
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mike\\source\\repos\\jifjeff\\CST4708Project\\FinalProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
                myconn.Open();

                inscmd.Connection = myconn;
                inscmd.CommandText = "INSERT INTO Support (UserEmail, OrderNum ,Problem, Subject, Description) VALUES(@UserEmail,@OrderNum,@Problem,@Subject,@Description) ";
                inscmd.Parameters.Add(new SqlParameter("@UserEmail", SqlDbType.VarChar, 25) { Value = EmailTextBox.Text});
                inscmd.Parameters.Add(new SqlParameter("@OrderNum", SqlDbType.VarChar, 25) { Value = OrderNumberTextBox.Text });
                inscmd.Parameters.Add(new SqlParameter("@Problem", SqlDbType.VarChar, 25) { Value = CheckedBox});
                inscmd.Parameters.Add(new SqlParameter("@Subject", SqlDbType.VarChar, 50) { Value = SubjectTextBox.Text });
                inscmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar) { Value = DescriptionTextBox.Text});
                inscmd.ExecuteNonQuery();

                MessageBox.Show("Your request has been sent, please wait 7-10 business days for a response");

                EmailTextBox.Clear();
                OrderNumberTextBox.Clear();
                SubjectTextBox.Clear();
                DescriptionTextBox.Clear();
                DamagedCheckBox.Checked = false;
                MissingCheckBox.Checked = false;
                PurchaseErrorCheckBox.Checked = false;
                OtherCheckBox.Checked = false;

                EmailErrorLabel.Visible = false;
                OrderNumErrorLable.Visible = false;
                SubjectErrorLabel.Visible = false;
                DescriptionErrorLabel.Visible = false;

            }
        }
    }
}