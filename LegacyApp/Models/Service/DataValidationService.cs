using System;

namespace LegacyApp
{
    class DataValidationService
    {
        private bool ValidateEmail(string email)
        {
            return email.Contains("@") && !email.Contains(".");
        }
        private bool ValidateName(string Firstname, string Surname)
        {
            return string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Surname);
        }

        private bool ValidateAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;

            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day))
            {
                age--;
            }

            if (age < 21)
            {
                return false;
            }
        }
            

        public bool checkValidity(User _User)
        {
            return ValidateEmail(_User.EmailAddress) && ValidateName(_User.Firstname,_User.Surname) && ValidateAge(_User.DateOfBirth);
        }

        public bool checkCredit(User _User)
        {
            if (_User.client.Name == "VeryImportantClient")
            {
                // Skip credit chek
                _User.HasCreditLimit = false;
            }
            else if (_User.client.Name == "ImportantClient")
            {
                // Do credit check and double credit limit
                _User.HasCreditLimit = true;
                using (var userCreditService = new UserCreditServiceClient())
                {
                    var creditLimit = userCreditService.GetCreditLimit(_User.Firstname, _User.Surname, _User.DateOfBirth);
                    creditLimit = creditLimit * 2;
                    _User.CreditLimit = creditLimit;
                }
            }
            else
            {
                // Do credit check
                _User.HasCreditLimit = true;
                using (var userCreditService = new UserCreditServiceClient())
                {
                    var creditLimit = userCreditService.GetCreditLimit(_User.Firstname, _User.Surname, _User.DateOfBirth);
                    _User.CreditLimit = creditLimit;
                }
            }

            if (_User.HasCreditLimit && _User.CreditLimit < 500)
            {
                return false;
            }
        }
    }
}

