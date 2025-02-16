using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Person
{
    public partial class ctrlPersonInformation : UserControl
    {

        public Bunifu.UI.WinForms.BunifuLabel LblPersonID
        {
            get { return lblPesronID; }
            //set { txtFindBy = value; }
        }

        public ctrlPersonInformation()
        {
            InitializeComponent();
            picPerson.Image = Properties.Resources.Inquiry_male;
        }

        public bool LoadPersonInformationByID(int PersonID)
        {

            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string NationalNo = "";
            int Gendor = 0;
            string Email = "";
            string Phone = "";
            string Address = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = 0;
            string ImagePath = "";



            if (clsPerson.GetPersonByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo,
                ref Gendor, ref Email, ref Address, ref DateOfBirth, ref Phone, ref NationalityCountryID, ref ImagePath))
            {

                string FullName = FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
                lblPesronID.Text = PersonID.ToString();
                lblName.Text = FullName;
                lblNationalNo.Text = NationalNo;
                lblGendor.Text = Gendor == 0 ? "Male" : "Female";
                if (lblGendor.Text == "Male")
                {
                    if (string.IsNullOrEmpty(ImagePath) || ImagePath == "NULL") picPerson.Image = Properties.Resources.Inquiry_male;
                    else picPerson.ImageLocation = ImagePath;
                }
                else
                {
                    if (string.IsNullOrEmpty(ImagePath) || ImagePath == "NULL") picPerson.Image = Properties.Resources.Inquiry_female;
                    else picPerson.ImageLocation = ImagePath;
                }

                lblEmail.Text = Email;
                lblPhone.Text = Phone;
                lblAddress.Text = Address;
                lblDateOfBirth.Text = DateOfBirth.ToString("dd/MM/yyyy");
                lblCountry.Text = clsCountry.GetCountryNameByID(NationalityCountryID);

                return true;

            }

            else
            {
                lblPesronID.Text = "???";
                lblName.Text = "???";
                lblNationalNo.Text = "???";
                lblGendor.Text = "???";
                lblEmail.Text = "???";
                lblPhone.Text = "???";
                lblAddress.Text = "???";
                lblDateOfBirth.Text = "???";
                lblCountry.Text = "???";

                if (string.IsNullOrEmpty(ImagePath)) picPerson.Image = Properties.Resources.Inquiry_male;
                else picPerson.ImageLocation = ImagePath;

                return false;
            }
        }



        public bool LoadPersonInformationByNationalNo(string NationalNo)
        {

            int PersonID = 0;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            int Gendor = 0;
            string Email = "";
            string Phone = "";
            string Address = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = 0;
            string ImagePath = "";



            if (clsPerson.GetPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Gendor, ref Email, ref Address, ref DateOfBirth, ref Phone, ref NationalityCountryID, ref ImagePath))
            {

                string FullName = FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
                lblPesronID.Text = PersonID.ToString();
                lblName.Text = FullName;
                lblNationalNo.Text = NationalNo;
                lblGendor.Text = Gendor == 0 ? "Male" : "Female";
                if (lblGendor.Text == "Male")
                {
                    if (string.IsNullOrEmpty(ImagePath) || ImagePath == "NULL") picPerson.Image = Properties.Resources.Inquiry_male;
                    else picPerson.ImageLocation = ImagePath;
                }
                else
                {
                    if (string.IsNullOrEmpty(ImagePath) || ImagePath == "NULL") picPerson.Image = Properties.Resources.Inquiry_female;
                    else picPerson.ImageLocation = ImagePath;
                }


                lblEmail.Text = Email;
                lblPhone.Text = Phone;
                lblAddress.Text = Address;
                lblDateOfBirth.Text = DateOfBirth.ToString("dd/MM/yyyy");
                lblCountry.Text = clsCountry.GetCountryNameByID(NationalityCountryID);

                return true;

            }

            else
            {
                lblPesronID.Text = "???";
                lblName.Text = "???";
                lblNationalNo.Text = "???";
                lblGendor.Text = "???";
                lblEmail.Text = "???";
                lblPhone.Text = "???";
                lblAddress.Text = "???";
                lblDateOfBirth.Text = "???";
                lblCountry.Text = "???";

                if (string.IsNullOrEmpty(ImagePath)) picPerson.Image = Properties.Resources.Inquiry_male;
                else picPerson.ImageLocation = ImagePath;

                return false;
            }
        }

        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPesronID.Text != "???")
            {
                frmAddNewPerson frm = new frmAddNewPerson(Convert.ToInt32(lblPesronID.Text));
                frm.ShowDialog();

                LoadPersonInformationByID(Convert.ToInt32(lblPesronID.Text));
            }
            else
            {
                MessageBox.Show("Please search for a person first", "Edit Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
