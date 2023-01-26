using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Validation
    {
        public bool IsInvalid { get; set; }
        public List<string> IsInvalidtext { get; set; } = new List<string>();

        public static Validation IsValidIDNumber(string idNumber)
        {
            Validation idNumberValidation = new Validation();
            idNumberValidation.IsInvalid = false;

            if (string.IsNullOrEmpty(idNumber))
            {
                idNumberValidation.IsInvalid = true;
            }
            foreach (char c in idNumber)
            {
                if (!char.IsNumber(c))
                    idNumberValidation.IsInvalid = true;
            }
            if (idNumberValidation.IsInvalid)
            {
                idNumberValidation.IsInvalidtext.Add("Invalid input! Use numbers only");
            }
            if (idNumber.Length != 13)
            {
                idNumberValidation.IsInvalid = true;
                idNumberValidation.IsInvalidtext.Add("Invalid input! ID Number must be 13 numbers!");
            }
            return idNumberValidation;
        }
    }

    
}
