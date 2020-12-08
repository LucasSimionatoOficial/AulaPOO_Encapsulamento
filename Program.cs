using System;
using POO_Encapsulamento.classes;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.NomeTitular = "Lucas";
            m.numero = "1234567890";//set
            m.Bandeira = "Mastercard";
            Console.WriteLine($"Titular {m.NomeTitular} - {m.Token}");//get
        }
    }
}
