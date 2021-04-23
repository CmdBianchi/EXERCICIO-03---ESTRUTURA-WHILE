using System;
namespace EXERCICIO_03____ESTRUTURA_WHILE{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fechar Conta.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            Console.Write("DIGITE  O CODIGO SEGUIDA DA QUANTIDADE EM LITROS: ");
            int orderNunber = int.Parse(Console.ReadLine());
            int gas = 0, diesel = 0, alcool = 0;
            while (orderNunber != 4)
            {
                if ( orderNunber == 1){
                    gas = gas + 1;
                }
                else if ( orderNunber == 2) {
                    diesel = diesel + 1;
                }
                else if ( orderNunber == 3) {
                    alcool = alcool + 1;
                }
                orderNunber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO! ");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + diesel);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
