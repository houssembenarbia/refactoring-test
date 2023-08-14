using System;

namespace LegacyApp
{
    public class User:IDisposable
    {
        public Client Client { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public bool HasCreditLimit { get; set; }
        public int CreditLimit { get; set; }

        // Injection par constructeur
        public User(string firname, string surname, string email, DateTime dateOfBirth,Client _Client)
        {
            this.Firstname =firname;
            this.Surname =surname;
            this.EmailAddress =email;
            this.DateOfBirth =dateOfBirth;
            this.Client=_Client;
        }
        public void Dispose()
        {

        }
    }
}