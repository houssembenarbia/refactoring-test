using System;

namespace LegacyApp
{
    public class UserService:DataValidationService
    {

        public bool AddUser(string firname, string surname, string email, DateTime dateOfBirth, int clientId)
        {
            try
            {
                var clientRepository = new ClientRepository();
                 var user = new User
                    {
                        Client = clientRepository.GetById(clientId),
                        DateOfBirth = dateOfBirth,
                        EmailAddress = email,
                        Firstname = firname,
                        Surname = surname
                    };

                using(user) using(clientRepository)
                {
                    if(checkValidity(user) && checkCredit(user))
                    {
                        UserDataAccess.AddUser(user);
                        return true;

                    }
                    return false;
               
                }
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}