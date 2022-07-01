using System.Data.SqlClient;
using System.Data;


namespace CST4708_Project
{
    public partial class Payment : Form
    {
        SqlConnection myconn;
        SqlDataAdapter myadapter = new SqlDataAdapter();
        SqlCommand inscmd = new SqlCommand();

        public Payment()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (FullNameTB.Text == "")
            {
                FullNameErrorLbl.Visible = true;
            }
            else
            {
                FullNameErrorLbl.Visible = false;
            }

            if (CardNumTB.Text == "")
            {
                CardNumErrorLbl.Visible = true;
            }
            else
            {
                CardNumErrorLbl.Visible = false;
            }

            if (MonthCB.Text == "MM" || YearCB.Text == "YYYY")
            {
                ExpDateErrorLbl.Visible = true;
            }
            else
            {
                ExpDateErrorLbl.Visible = false;
            }

            if (CSVTB.Text == "")
            {
                CSVErrorLbl.Visible = true;
            }
            else
            {
                CSVErrorLbl.Visible = false;
            }

            if (AddressTB.Text == "")
            {
                AddressErrorLbl.Visible = true;
            }
            else
            {
                AddressErrorLbl.Visible = false;
            }

            if (CityTB.Text == "")
            {
                CityErrorLbl.Visible = true;
            }
            else
            {
                CityErrorLbl.Visible = false;
            }

            if (StateTB.Text == "")
            {
                StateErrorLbl.Visible = true;
            }
            else
            {
                StateErrorLbl.Visible = false;
            }

            if (ZipCodeTB.Text == "")
            {
                ZipCodeErrorLbl.Visible = true;
            }
            else
            {
                ZipCodeErrorLbl.Visible = false;
            }

            if (FullNameTB.Text != "" && CardNumTB.Text != "" && CSVTB.Text != "" && CityTB.Text != "" && StateTB.Text != "" && ZipCodeTB.Text != "")
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mike\\source\\repos\\jifjeff\\CST4708Project\\FinalProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
                myconn.Open();

                int CardNumConvert = int.Parse(CardNumTB.Text);
                int CSVConvert = int.Parse(CSVTB.Text);
                int ZipConvert = int.Parse(ZipCodeTB.Text);
                String ExpCombined = MonthCB.Text + " " + YearCB.Text;

                inscmd.Connection = myconn;
                //Dont forget to Connect the UID somehow:
                inscmd.CommandText = "INSERT INTO Payment (CardName, CardNumber,ExpDateMM,ExpDateYY, CSV, Address, City, State, Zip) VALUES(@CardName,@CardNum,@ExpDateMM, @ExpDateYY,@CSV,@Address,@City,@State,@Zip) ";
                inscmd.Parameters.Add(new SqlParameter("@Cardname", SqlDbType.VarChar, 25) { Value = FullNameTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@CardNum", SqlDbType.Int) { Value = CardNumConvert });
                inscmd.Parameters.Add(new SqlParameter("@ExpDateMM", SqlDbType.Int) { Value = MonthCB.Text });
                inscmd.Parameters.Add(new SqlParameter("@ExpDateYY", SqlDbType.Int) { Value = YearCB.Text });
                inscmd.Parameters.Add(new SqlParameter("@CSV", SqlDbType.Int) { Value = CSVConvert });
                inscmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 100) { Value = AddressTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 25) {Value = CityTB.Text } );
                inscmd.Parameters.Add(new SqlParameter ("@State", SqlDbType.VarChar, 25) { Value = StateTB.Text });
                inscmd.Parameters.Add(new SqlParameter("@Zip", SqlDbType.Int) { Value = ZipConvert } );
                inscmd.ExecuteNonQuery();

                MessageBox.Show("Your Payment Info has been Submitted ");

                FullNameTB.Clear();
                CardNumTB.Clear();
                MonthCB.Text = "MM";
                YearCB.Text = "YYYY";
                CSVTB.Clear();
                AddressTB.Clear();
                CityTB.Clear();
                StateTB.Clear();
                ZipCodeTB.Clear();

                FullNameErrorLbl.Visible = false;
                CardNumErrorLbl.Visible = false;
                CSVErrorLbl.Visible = false;
                AddressErrorLbl.Visible = false;
                CityErrorLbl.Visible = false;
                StateErrorLbl.Visible = false;
                ZipCodeErrorLbl.Visible = false;

            }
        }
    }
}

