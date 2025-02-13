

namespace BackEnd4.Models
{
    static class Utente
    {
        public static string User { get; set; }
        public static string Password;
        public static string ConfirmPassword { get; set; }

      
        public static bool Autentificato => User != null && Password != null && ConfirmPassword == Password;


        public static DateTime? LoginTime { get; private set; }

        public static void Login()
        {
            if (Autentificato)
            {

                LoginTime = DateTime.Now;
                Console.WriteLine($"Login effettuato con successo. Data e ora: {LoginTime}");
            }
            else
            {
                Console.WriteLine("Errore: Nessun utente autenticato.");
            }
        }
        public static void Logout()
        {
            if (Autentificato)  
            {
           
                User = null;
                Password = null;
                ConfirmPassword = null;
                LoginTime = null; 
                Console.WriteLine("Logout effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Errore: Non sei loggato, impossibile effettuare il logout.");
            }
        }
    }
}
