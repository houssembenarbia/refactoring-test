using System;
namespace LegacyApp
{
    public class Client:IDisposable
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public ClientStatus ClientStatus { get; set; }

        public void Dispose()
        {
            
        }
    }
}