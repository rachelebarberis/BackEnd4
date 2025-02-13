using BackEnd4.Models;



Console.Write("nome utente: ");
Utente.User= Console.ReadLine();

Console.Write("password: ");
Utente.Password = Console.ReadLine();

Console.Write("conferma password: ");
Utente.ConfirmPassword = Console.ReadLine();

if (Utente.Password == Utente.ConfirmPassword)
{
    Console.WriteLine("Utente Autentificato");
}

