using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        public static string _CurrentUserName { get; set; } = "admin";

        public int _userID { get; set; }
        public string _userName { get; set; }
        public string _Password { get; set; }
        public bool _isActive { get; set; }
        public clsPerson _person { get; set; }


        public clsUser()
        {
            _userID = -1;
            _userName = "";
            _Password = "";
            _isActive = false;
            _person = new clsPerson();
            _Mode = enMode.AddNew;
        }

        public clsUser(int userID, string userName, string password, bool isActive)
        {
            _userID = userID;
            _userName = userName;
            _Password = password;
            _isActive = isActive;
            _person = clsPerson.GetPersonByUserID(userID);
            _Mode = enMode.Update;
        }


        public static clsUser GetUserByID(int UserID)
        {
            clsUser user = new clsUser();
            DataTable dataTable = clsUserData.GetUserByUserID(UserID);
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    user._userID = Convert.ToInt32(dataTable.Rows[0]["UserID"]);
                    user._userName = dataTable.Rows[0]["UserName"].ToString();
                    user._Password = dataTable.Rows[0]["Password"].ToString();
                    user._isActive = Convert.ToBoolean(dataTable.Rows[0]["IsActive"]);
                }
            }
            return user;
        }

        public static DataTable GetUsersByFilter(string query)
        {
            return clsUserData.GetUsersByFilter(query);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool IsPersonHasUserByPersonID(int PersonID)
        {
            return clsUserData.IsPersonHasUserByPersonID(PersonID);
        }

        public static bool IsPersonHasUserByNationalNo(string NationalNo)
        {
            return clsUserData.IsPersonHasUserByNationalNo(NationalNo);
        }

        public static bool IsUserExistByNationalNo(string NationalNo)
        {
            return clsUserData.IsUserExistByNationalNo(NationalNo);
        }

        public static bool IsUserExistByUserID(int UserID)
        {
            return clsUserData.IsUserExistByUserID(UserID);
        }


        private bool _AddNewUser(int PersonID)
        {
            this._userID = clsUserData.AddNewUser(PersonID, this._userName, this._Password, this._isActive);
            return true;
        }

        private bool _Update()
        {
            return clsUserData.UpdateUser(this._userID, this._userName, this._Password, this._isActive);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }


        public bool Save(int PersonID)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser(PersonID))
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

        public static bool IsUserNameUsed(string UserName)
        {
            return clsUserData.IsUserNameUsed(UserName);
        }

        public static bool IsUserActive(string UserName)
        {
            return clsUserData.IsUserActive(UserName);
        }

        public static bool Login(string UserName, string Password)
        {
            return clsUserData.Login(UserName, Password);
        }

        public static int GetUserIDbyUserName(string UserName)
        {
            return clsUserData.GetUserIDbyUserName(UserName);
        }

        public static bool IsCorrectPass(int UserID, string Pass)
        {
            return clsUserData.IsCorrectPass(UserID, Pass);
        }

        public static bool UpdatePassword(int UserID, string Pass)
        {
            return clsUserData.UpdatePassword(UserID, Pass);
        }
    }
}
