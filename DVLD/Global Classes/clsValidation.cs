using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD.Classes
{
    public class clsValidation
    {

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }


        public static bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^\+?\d{10,15}$");
        }

        public static bool IsValidNationalNumber(string nationalNo)
        {
            return Regex.IsMatch(nationalNo, @"^[A-Za-z]*\d{2,15}$");
        }


        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length >= 2;
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        public static bool IsValidAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address) && address.Length >= 5;
        }

    }
}
