using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVLD.Classes;

namespace DVLD_Project.Person.Controls
{
    public partial class ctrlAddPerson : UserControl
    {

        public ctrlAddPerson()
        {
            InitializeComponent();
            dropdCountries.DataSource = clsCountry.GetCountries();
        }

        public Bunifu.UI.WinForms.BunifuLabel LblPersonID
        {
            get { return lblPersonID; }
        }


        public void FillForm(int personID)
        {
            lblMainTitle.Text = "Update Person";

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            int Gendor = 0, NationalityCountryID = 0;
            DateTime DateOfBirth = new DateTime(2000, 1, 1);

            if (clsPerson.GetPersonByID(personID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref NationalNo, ref Gendor, ref Email, ref Address,
                ref DateOfBirth, ref Phone, ref NationalityCountryID, ref ImagePath))
            {
                clsPerson person = new clsPerson(personID, FirstName, SecondName, ThirdName,
                    LastName, NationalNo, Gendor, Email, Phone,
                    Address, DateOfBirth, NationalityCountryID, ImagePath);
            }


            txtFirstName.Text = FirstName;
            txtSecondName.Text = SecondName;
            txtThirdName.Text = ThirdName;
            txtLastName.Text = LastName;
            txtNationalNo.Text = NationalNo;
            txtEmail.Text = Email;
            txtPhone.Text = Phone;
            txtAddress.Text = Address;
            dpDateOfBirth.Value = DateOfBirth;
            dropdCountries.SelectedIndex = NationalityCountryID - 1;
            pbPersonImage.ImageLocation = ImagePath == "NULL" ? null : ImagePath;

            if (ImagePath != "NULL") btnAddImage.Text = "Update Image";
            if (rbMale.Checked) pbPersonImage.Image = Properties.Resources.Inquiry_male;
            else if (rbFemale.Checked) pbPersonImage.Image = Properties.Resources.Inquiry_female;

            lblPersonID.Text = personID.ToString();
        }




        private void ValidateTextField(Bunifu.UI.WinForms.BunifuTextBox textBox, Func<string, bool> validationFunc, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || !validationFunc(textBox.Text))
            {
                errorProvider1.SetError(textBox, errorMessage);
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }



        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtFirstName, clsValidation.IsValidName, "Please enter a valid first name", e);
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtSecondName, clsValidation.IsValidName, "Please enter a valid second name", e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtLastName, clsValidation.IsValidName, "Please enter a valid last name", e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtEmail, clsValidation.IsValidEmail, "Please enter a valid email", e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtPhone, clsValidation.IsValidPhoneNumber, "Please enter a valid phone number", e);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtAddress, clsValidation.IsValidAddress, "Please enter a valid address", e);
        }



        private void btnAddImage_Click(object sender, EventArgs e)
        {
            clsPerson person = clsPerson.GetPersonByID(int.Parse(lblPersonID.Text));

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;

                if(person.ImagePath != pbPersonImage.ImageLocation)
                {
                    if (File.Exists(person.ImagePath)) File.Delete(person.ImagePath);
                }

                string filePath = openFileDialog1.FileName;
                string uniqueId = Guid.NewGuid().ToString();
                string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string destinationFolder = Path.Combine(documentsFolder, "UploadedImages");
                if (!Directory.Exists(destinationFolder)) Directory.CreateDirectory(destinationFolder);
                string newFileName = uniqueId + Path.GetExtension(filePath);
                string destinationPath = Path.Combine(destinationFolder, newFileName);

                File.Copy(filePath, destinationPath);
                pbPersonImage.ImageLocation = destinationPath;
                btnAddImage.Text = "Update Image";
            }
        }


        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbPersonImage.ImageLocation != null)
                {
                    string imagePath = pbPersonImage.ImageLocation;
                    if (File.Exists(imagePath)) File.Delete(imagePath);

                    pbPersonImage.ImageLocation = null;
                    pbPersonImage.Image = rbMale.Checked ? Properties.Resources.Inquiry_male : Properties.Resources.Inquiry_female;

                    MessageBox.Show("Image deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnAddImage.Text = "Add Image";
                }
                else
                {
                    MessageBox.Show("No image to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbMale_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                if (rbMale.Checked) pbPersonImage.Image = Properties.Resources.Inquiry_male;
            }
        }

        private void rbFemale_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                if (rbMale.Checked) pbPersonImage.Image = Properties.Resources.Inquiry_female;
            }
        }







        public void SaveAddUpdate()
        {

            clsPerson person = new clsPerson();

            if (lblPersonID.Text == "N/A")
            {
                person = new clsPerson()
                {
                    FirstName = txtFirstName.Text,
                    SecondName = txtSecondName.Text,
                    ThirdName = string.IsNullOrWhiteSpace(txtThirdName.Text) ? "" : txtThirdName.Text,
                    LastName = txtLastName.Text,
                    Gendor = rbMale.Checked ? 0 : 1,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    NationalNo = txtNationalNo.Text,
                    DateOfBirth = dpDateOfBirth.Value,
                    CountryNationalityCountryID = clsCountry.GetCountryIDByName(dropdCountries.SelectedItem.ToString()),
                    ImagePath = string.IsNullOrEmpty(pbPersonImage.ImageLocation) ? null : pbPersonImage.ImageLocation

                };
            }

            else
            {
                string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
                int Gendor = 0, NationalityCountryID = 0;
                DateTime DateOfBirth = new DateTime(2004, 6, 11);

                if (clsPerson.GetPersonByID(int.Parse(lblPersonID.Text), ref FirstName, ref SecondName, ref ThirdName,
                    ref LastName, ref NationalNo, ref Gendor, ref Email, ref Address,
                    ref DateOfBirth, ref Phone, ref NationalityCountryID, ref ImagePath))
                {
                    person = new clsPerson(int.Parse(lblPersonID.Text), FirstName, SecondName, ThirdName,
                        LastName, NationalNo, Gendor, Email, Phone,
                        Address, DateOfBirth, NationalityCountryID, ImagePath);
                }

                person.FirstName = txtFirstName.Text;
                person.SecondName = txtSecondName.Text;
                person.ThirdName = string.IsNullOrWhiteSpace(txtThirdName.Text) ? "" : txtThirdName.Text;
                person.LastName = txtLastName.Text;
                person.Gendor = rbMale.Checked ? 0 : 1;
                person.Email = txtEmail.Text;
                person.Phone = txtPhone.Text;
                person.Address = txtAddress.Text;
                person.NationalNo = txtNationalNo.Text;
                person.DateOfBirth = dpDateOfBirth.Value;
                person.CountryNationalityCountryID = clsCountry.GetCountryIDByName(dropdCountries.SelectedItem.ToString());
                person.ImagePath = string.IsNullOrEmpty(pbPersonImage.ImageLocation) ? null : pbPersonImage.ImageLocation;
                if (string.IsNullOrEmpty(person.ImagePath))
                {
                    pbPersonImage.Image = rbMale.Checked ? Properties.Resources.Inquiry_male : Properties.Resources.Inquiry_female;
                }

            }

            if (person.Save())
            {
                MessageBox.Show("Person saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMainTitle.Text = "Update Person";

                txtFirstName.Text = person.FirstName;
                txtSecondName.Text = person.SecondName;
                txtThirdName.Text = person.ThirdName;
                txtLastName.Text = person.LastName;
                txtNationalNo.Text = person.NationalNo;
                txtEmail.Text = person.Email;
                txtPhone.Text = person.Phone;
                txtAddress.Text = person.Address;
                dpDateOfBirth.Value = person.DateOfBirth;
                dropdCountries.SelectedIndex = person.CountryNationalityCountryID - 1;
                pbPersonImage.ImageLocation = person.ImagePath;
                lblPersonID.Text = person.PersonID.ToString();


            }
            else
            {
                MessageBox.Show("Failed to add person", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;

            foreach (Control control in this.Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
                {
                    hasErrors = true;
                    break;
                }
            }

            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtSecondName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtNationalNo.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                hasErrors)
            {
                MessageBox.Show("Please fill in all required fields and correct any errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveAddUpdate();
            }
        }


        private void bunifuLabel18_Click(object sender, EventArgs e)
        {

        }
    }
}
