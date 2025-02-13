using BackEnd4.Models;


         
            Console.Write("Nome utente: ");
            Utente.User = Console.ReadLine();

            Console.Write("Password: ");
            Utente.Password = Console.ReadLine();

            Console.Write("Conferma password: ");
            Utente.ConfirmPassword = Console.ReadLine();

            if (Utente.Password == Utente.ConfirmPassword)
            {
            
                Utente.Login(); 
                Console.WriteLine("Utente autenticato con successo!");
            }
            else
            {
                
                Console.WriteLine("Password errata. Riprova.");
                return; 
            }

          
            if (Utente.Autentificato)
            {
                Console.WriteLine("Vuoi effettuare il logout? (si/no)");
                string logoutChoice = Console.ReadLine();

                if (logoutChoice.ToLower() == "si")
                {
        
                    Utente.Logout();
                }
                else
                {
                    Console.WriteLine("Non hai effettuato il logout.");
                }
            }
            else
            {
                Console.WriteLine("Non puoi effettuare il logout senza essere autenticato.");
            }

     

