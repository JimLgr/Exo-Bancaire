using ConsoleUsersInterface;
using System.Text.RegularExpressions;

BankAccount jim = new BankAccount("Jim", AccountBankTypes.courant);
Console.WriteLine($"{jim.AccountNumber} => {jim.m_nameOwner} => {jim.Type} => {jim.GetBalance()}");
jim.Deposit(1000);
Console.WriteLine($"{jim.m_nameOwner} {jim.Type} {jim.GetBalance()}");
jim.Whithdraw(700);
Console.WriteLine($"{jim.m_nameOwner} {jim.Type} {jim.GetBalance()}");
bool resultat = jim.Whithdraw(500);
Console.WriteLine(resultat);
Console.WriteLine($"{jim}");


BankAccount gomez = new BankAccount("Gomez", AccountBankTypes.epargne);
Console.WriteLine($"{gomez}" );


BankAccount troisieme = new("Leskro", AccountBankTypes.titre);
Console.WriteLine($"{troisieme}");
Console.ReadLine();





//Console.WriteLine("Prenom ?");
//string prenom = Console.ReadLine();
//Console.WriteLine("Nom?");
//string nom = Console.ReadLine();
//Console.WriteLine("Votre date de naissance ?");
//int.TryParse(Console.ReadLine(), out int inDate);
//DateTime dateDeNaissance = DateTime.Parse(Console.ReadLine());
//Console.WriteLine("Quel type de compte voulez vous ouvrir ?");
//string type = Console.ReadLine().ToLower();

