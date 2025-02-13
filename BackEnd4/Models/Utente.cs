namespace BackEnd4.Models
{
    static class Utente
    {
        public static string User { get; set; }
        public static string Password;
        public static string ConfirmPassword { get; set; }

     
        private static List<DateTime> accessiStorici = new List<DateTime>();

        public static bool Autentificato => User != null && Password != null && ConfirmPassword == Password;

        public static DateTime? LoginTime { get; private set; }

 
        public static List<DateTime> GetStoricoAccessi()
        {
            return new List<DateTime>(accessiStorici); 
        }

        public static void Login()
        {
            if (Autentificato)
            {
                LoginTime = DateTime.Now;
                accessiStorici.Add(LoginTime.Value); 
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
