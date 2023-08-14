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
                User user =new User(firname,surname,email,dateOfBirth,clientRepository.GetById(clientId));

                using(user) using (clientRepository)
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