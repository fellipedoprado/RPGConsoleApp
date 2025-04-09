using RPGConsoleApp.Models;


namespace RPGConsoleApp.Utils
{
    public class Menu
    {
        static Character[] characters = new Character[10];

        public static void Iniciar()
        {
            int option;
            do
            {
                Console.WriteLine("===== MENU RPG =====");
                Console.WriteLine("1 - Criar personagem");
                Console.WriteLine("2 - Listar personagens");
                Console.WriteLine("3 - Deletar personagem");
                Console.WriteLine("4 - Batalhar!");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: Create(); break;
                    case 2: List(); break;
                    case 3: Delete(); break;
                    case 4: Battle(); break;
                    case 0: Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida"); break;
                }
            } while (option != 0);
        }

        static void Create()
        {
        }

        static void List()
        {
        }

        static void Delete()
        {
        }

        static void Battle()
        {
        }
    }
}
