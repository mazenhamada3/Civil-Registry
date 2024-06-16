using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Civil_Registry_2
{
    public partial class extractData : User
    {
        private int nationalID;
        public string ExpireIssueDatePString { get; private set; }
        public string ExpireIssueDateIdString { get; private set; }
        public string ExpireIssueDateDLString { get; private set; }
        public extractData(int nationalID)
        {
            InitializeComponent();
            this.nationalID = nationalID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            string x = comboBox1.Text;




            if (x != "ID" && x != "Birth certifcate" && x != "Driving liscense" && x != "Passport")
                MessageBox.Show("Error, this data isnot found");
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                errorProvider5.SetError(comboBox1, "This Feild  is requird");

            }
            else
            {
                errorProvider5.SetError(comboBox1, string.Empty);
            }

            if (comboBox1.Text == "ID")
            {
                
                string name = GetName(nationalID);
                string address = GetAddress(nationalID);
                string gender = GetUserGender(nationalID);
                string birth = GetUserBirth(nationalID);
                DateTime issueDateID = GetIssueDateId(nationalID);
                DateTime minimumValidDate = new DateTime(1753, 1, 1);
                if (issueDateID == minimumValidDate)
                {
                    DateTime UptadeIssueID = DateTime.Today;
                    SaveIssueDateId(nationalID, UptadeIssueID);
                    if (name != "0" && address != "0" && birth != "0")
                    {
                        DateTime xxx = GetIssueDateId(nationalID);
                        string issueDateIDString = xxx.ToShortDateString();
                        DateTime ExpireIssueDateId = xxx.AddYears(7);
                         ExpireIssueDateIdString = ExpireIssueDateId.ToShortDateString();
                    }
                    else
                        MessageBox.Show("Please complete your data first !");
                }
                else
                {
                    if (name != "0" && address != "0" && birth != "0")
                    {
                        string issueDateIDString = issueDateID.ToShortDateString();
                        DateTime ExpireIssueDateId = issueDateID.AddYears(7);
                         ExpireIssueDateIdString = ExpireIssueDateId.ToShortDateString();
                        this.Hide();
                        frmIDcs f16 = new frmIDcs(nationalID,ExpireIssueDateIdString);
                        f16.ShowDialog();
                        f16 = null;
                        this.Show();
                    }
                    else
                        MessageBox.Show("Please complete your data first !");
                }



            }
            else if (comboBox1.Text == "Driving liscense")
            {
                
                string name = GetName(nationalID);
                string address = GetAddress(nationalID);
                string gender = GetUserGender(nationalID);
                string birth = GetUserBirth(nationalID);
                string bloodtype = GetUserBloodType(nationalID);
                DateTime issueDateDl = GetIssueDateDl(nationalID);
                DateTime minimumValidDate = new DateTime(1753, 1, 1);
                if (issueDateDl == minimumValidDate)
                {
                    DateTime UptadeIssueDl = DateTime.Today;
                    SaveIssueDateDl(nationalID, UptadeIssueDl);
                    if (name != "0" && address != "0" && birth != "0" && bloodtype != "0")
                    {
                        DateTime xxx = GetIssueDateDl(nationalID);
                        string issueDateDLString = xxx.ToShortDateString();
                        DateTime ExpireIssueDateDl = xxx.AddYears(10);
                        ExpireIssueDateDLString = ExpireIssueDateDl.ToShortDateString();
                        
                    }
                    else
                        MessageBox.Show("Please complete your data first !");
                }
                else
                {
                    if (name != "0" && address != "0" && birth != "0" && bloodtype != "0")
                    {
                        string issueDateIDString = issueDateDl.ToShortDateString();
                        DateTime ExpireIssueDateId = issueDateDl.AddYears(10);
                         ExpireIssueDateDLString = ExpireIssueDateId.ToShortDateString();
                        this.Hide();
                        driverliscense f26 = new driverliscense(nationalID, ExpireIssueDateDLString);
                        f26.ShowDialog();
                        f26 = null;
                        this.Show();
                    }
                    else
                        MessageBox.Show("Please complete your data first !");
                }
            }
            else if (comboBox1.Text == "Passport")
            {
                
                string name = GetName(nationalID);
                string address = GetAddress(nationalID);
                string gender = GetUserGender(nationalID);
                string birth = GetUserBirth(nationalID);
                DateTime issueDateP = GetIssueDateP(nationalID);
                DateTime minimumValidDate = new DateTime(1753, 1, 1);
                if (issueDateP == minimumValidDate)
                {
                    DateTime UptadeIssueP = DateTime.Today;
                    SaveIssueDateP(nationalID, UptadeIssueP);
                    if (name != "0" && address != "0" && birth != "0")
                    {
                        DateTime xxx = GetIssueDateP(nationalID);
                        string issueDatePString = xxx.ToShortDateString();
                        DateTime ExpireIssueDateP = xxx.AddYears(10);
                        ExpireIssueDatePString = ExpireIssueDateP.ToShortDateString();
                        this.Hide();
                        passport f19 = new passport(nationalID, ExpireIssueDatePString);
                        f19.ShowDialog();
                        f19 = null;
                        this.Show();
                    }
                    else
                        MessageBox.Show("Please complete your data first !");
                }
                else
                {
                    if (name != "0" && address != "0" && birth != "0")
                    {
                        string issueDatePString = issueDateP.ToShortDateString();
                        DateTime ExpireIssueDateP = issueDateP.AddYears(10);
                         ExpireIssueDatePString = ExpireIssueDateP.ToShortDateString();
                        this.Hide();
                        passport f19 = new passport(nationalID,ExpireIssueDatePString);
                        f19.ShowDialog();
                        f19 = null;
                        this.Show();
                    }
                    else
                        MessageBox.Show("Please complete your data first !");
                }
            }



        }

        private void extractData_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
