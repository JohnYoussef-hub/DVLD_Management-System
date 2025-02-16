using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public int Gendor { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryNationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            NationalNo = "";
            Gendor = 0;
            Email = "";
            Phone = "";
            Address = "";
            DateOfBirth = DateTime.Now;
            CountryNationalityCountryID = 0;
            ImagePath = "";
            _Mode = enMode.AddNew;
        }

        public clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
            int Gendor, string Email, string Phone, string Address, DateTime DateOfBirth, int CountryNationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.Gendor = Gendor;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryNationalityCountryID = CountryNationalityCountryID;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }


        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref string NationalNo,
                ref int Gendor, ref string Email, ref string Address, ref DateTime DateOfBirth,
                ref string Phone, ref int NationalityCountryID, ref string ImagePath)
        {
            return (DataAccessLayer.clsPersonData.GetPersonByID(PersonID, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref NationalNo,
                ref Gendor, ref Email, ref Address, ref DateOfBirth,
                ref Phone, ref NationalityCountryID, ref ImagePath));

        }


        public static bool GetPersonByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName,
        ref int Gendor, ref string Email, ref string Address, ref DateTime DateOfBirth,
        ref string Phone, ref int NationalityCountryID, ref string ImagePath)
        {
            return (DataAccessLayer.clsPersonData.GetPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName,
                ref Gendor, ref Email, ref Address, ref DateOfBirth,
                ref Phone, ref NationalityCountryID, ref ImagePath));

        }


        public static clsPerson GetPersonByID(int PersonID)
        {
            DataTable dt = DataAccessLayer.clsPersonData.GetPersonByID(PersonID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new clsPerson
                {
                    PersonID = Convert.ToInt32(row["PersonID"]),
                    FirstName = row["FirstName"].ToString(),
                    SecondName = row["SecondName"].ToString(),
                    ThirdName = row["ThirdName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    NationalNo = row["NationalNo"].ToString(),
                    Gendor = Convert.ToInt32(row["Gendor"]),
                    Email = row["Email"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Address = row["Address"].ToString(),
                    DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                    CountryNationalityCountryID = Convert.ToInt32(row["NationalityCountryID"]),
                    ImagePath = row["ImagePath"] != DBNull.Value ? row["ImagePath"].ToString() : "NULL"
                };
            }
            else return null;
        }


        public static DataTable GetAllPeople()
        {
            return DataAccessLayer.clsPersonData.GetAllPeople();
        }

        public static DataTable GetPeopleByFilter(string query)
        {
            return DataAccessLayer.clsPersonData.GetPeopleByFilter(query);
        }


        private bool _AddNewPerson()
        {
            this.PersonID = DataAccessLayer.clsPersonData.AddNewPerson(FirstName, SecondName, ThirdName, LastName,
                NationalNo, Gendor, Email, Phone, Address, DateOfBirth, CountryNationalityCountryID, ImagePath);

            if (this.PersonID != -1) return true;
            else return false;
        }

        private bool _Update()
        {
            return DataAccessLayer.clsPersonData.UpdatePerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                NationalNo, Gendor, Email, Phone, Address, DateOfBirth, CountryNationalityCountryID, ImagePath);
        }


        public static bool DeletePerson(int id)
        {
            return DataAccessLayer.clsPersonData.DeletePerson(id);
        }

        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            return DataAccessLayer.clsPersonData.IsPersonExistByNationalNo(NationalNo);
        }

        public static bool IsPersonExistByPersonID(int PersonID)
        {
            return DataAccessLayer.clsPersonData.IsPersonExistByPersonID(PersonID);
        }


        public static clsPerson GetPersonByUserID(int UserID)
        {
            DataTable dt = DataAccessLayer.clsPersonData.GetPersonByUserID(UserID);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new clsPerson
                {
                    PersonID = Convert.ToInt32(row["PersonID"]),
                    FirstName = row["FirstName"].ToString(),
                    SecondName = row["SecondName"].ToString(),
                    ThirdName = row["ThirdName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    NationalNo = row["NationalNo"].ToString(),
                    Gendor = Convert.ToInt32(row["Gendor"]),
                    Email = row["Email"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Address = row["Address"].ToString(),
                    DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                    CountryNationalityCountryID = Convert.ToInt32(row["NationalityCountryID"]),
                    ImagePath = row["ImagePath"] != DBNull.Value ? row["ImagePath"].ToString() : "NULL"
                };
            }
            else
            {
                return null;
            }
        }







        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:
                    if (_Update()) return true;
                    else return false;

                default: return false;
            }
        }

        

        
    }
}
