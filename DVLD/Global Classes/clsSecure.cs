﻿using System;
using System.Security.Cryptography;
using System.Text;


namespace DVLD_Project.Global_Classes
{
    class clsSecure
    {

        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

    }
}
