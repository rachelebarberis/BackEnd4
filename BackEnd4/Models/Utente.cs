

namespace BackEnd4.Models
{
    static class Utente
    {
        public static string User {  get; set; }
        public static string Password;
        public static string ConfirmPassword { get; set; }
        public static bool Autentificato => User != null && Password != null;

        public static bool Login (string username, string password, string confirmPassword) 
        {

            if (string.IsNullOrWhiteSpace(User))
            
                {
                Console.WriteLine("Inserire qualcosa!");
                return false;
            }

            if (Password !=ConfirmPassword)
            {
                Console.WriteLine("Password non valida");
                    return false;
            }

            return true; 
            
           
        }
         
    }
}
