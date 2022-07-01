using System.Data.SqlClient;
using System.Data;

namespace CST4708_Project
{
    public partial class HomePage : Form
    {
        SqlConnection myconn;
        SqlDataAdapter myadapter = new SqlDataAdapter();
        SqlCommand logincmd = new SqlCommand();
        SqlDataReader datareader;

        public HomePage()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 3);
            SolidBrush s = new SolidBrush(Color.LightGreen);
            //'Logo', 'Username' , and 'Password' Label
            logoLbl.BackColor = s.Color;
            userLbl.BackColor = s.Color;
            pwLbl.BackColor = s.Color;

            Rectangle header = new Rectangle(0 , 0, Width, panel1.Location.Y - 1);
            e.Graphics.FillRectangle(s, header);
            s.Color = Color.OrangeRed;

            //Rectangle footer = new Rectangle(0, panel1.Size.Height + 2, Width, Height);
            //e.Graphics.FillRectangle(s, footer);

           // supportpageLbl.BackColor = s.Color;
           // contactusLbl.BackColor = s.Color;

        }

        private void spLbl_Click(object sender, EventArgs e)
        {
            //SupportPage sp = new SupportPage();
            //sp.Show();
            panel1.Controls.Clear();
            SupportPage sp = new SupportPage();
            sp.TopLevel = false;
            panel1.Controls.Add(sp);
            sp.FormBorderStyle = FormBorderStyle.None;
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void spLbl_MouseEnter(object sender, EventArgs e)
        {
            supportpageLbl.ForeColor = Color.Blue;
        }

        private void spLbl_MouseLeave(object sender, EventArgs e)
        {
            supportpageLbl.ForeColor = Color.Black;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            //SignUp su = new SignUp();
            //su.Show();
            panel1.Controls.Clear();
            SignUp su = new SignUp();
            su.TopLevel = false;
            panel1.Controls.Add(su);
            su.FormBorderStyle = FormBorderStyle.None;
            su.Dock = DockStyle.Fill;
            su.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mike\\source\\repos\\jifjeff\\CST4708Project\\FinalProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
            myconn.Open();

            String usertxt = usernameTb.Text;
            String pwtxt = pwTb.Text;
            int uidgrab;

            logincmd.Connection = myconn;

            logincmd.CommandText = "SELECT UserEmail,UserPassword FROM Customer where UserEmail = @UserEmail AND UserPassword = @UserPassword ";
            logincmd.Parameters.AddWithValue("@UserEmail", usernameTb.Text);
            logincmd.Parameters.AddWithValue("@UserPassword", pwTb.Text);
            datareader = logincmd.ExecuteReader();
            if (datareader.Read())
            {
                logincmd.Parameters.Clear();
                myconn.Close();
                MessageBox.Show("Login Success");
                myconn.Open();

                //Grabs UserID
                logincmd.Connection = myconn;
                logincmd.CommandText = "Select UID From Customer where UserEmail = @UserEmail";
                logincmd.Parameters.AddWithValue("UserEmail", usernameTb.Text);
                uidgrab = (Int32)logincmd.ExecuteScalar();
                

                loginBtn.Visible = false;
                signupBtn.Visible = false;
                userLbl.Text = "";
                pwLbl.Text = "Hello " + usernameTb.Text;
                pwLbl.Font = new Font("Arial", 16, FontStyle.Bold);
                usernameTb.Visible = false;
                pwTb.Visible = false;

                ManagePayBttn.Visible = true;
                CartButton.Visible = true;
                /*
                Button cartBtn = new Button();
                this.Controls.Add(cartBtn);
                cartBtn.Location = new Point(signupBtn.Location.X, ramBtn.Location.Y);
                cartBtn.Text = "Cart";
                cartBtn.BackColor = Color.Red;
                cartBtn.Size = new Size(112, 50);
                */
            }
            else
            {
                MessageBox.Show("Login Failed: Check Email/Password!");
                logincmd.Parameters.Clear();
            }

            

            /*
            if (usernameTb.Text == pwTb.Text)
            {
                loginBtn.Visible = false;
                signupBtn.Visible = false;
                userLbl.Text = "";
                pwLbl.Text = "Hello "+ usernameTb.Text;
                pwLbl.Font = new Font("Arial", 16, FontStyle.Bold);
                usernameTb.Visible = false;
                pwTb.Visible = false;
                Button cartBtn = new Button();
                this.Controls.Add(cartBtn);
                cartBtn.Location = new Point(signupBtn.Location.X, ramBtn.Location.Y);
                cartBtn.Text = "Cart";
                cartBtn.BackColor = Color.Red;
                cartBtn.Size = new Size(112, 50);
            }
            else
            {
                MessageBox.Show("Username or Password is not valid. Please try again.");
            }
            */
        }

        private void logoLbl_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            HomePageItems hpi = new HomePageItems();
            hpi.TopLevel = false;
            panel1.Controls.Add(hpi);
            hpi.FormBorderStyle = FormBorderStyle.None;
            hpi.Dock = DockStyle.Fill;
            hpi.Show();
        }

        private void ManagePayBttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Payment pay = new Payment();
            pay.TopLevel = false;
            panel1.Controls.Add(pay);
            pay.FormBorderStyle = FormBorderStyle.None;
            pay.Dock = DockStyle.Fill;
            pay.Show();
        }
    }
}