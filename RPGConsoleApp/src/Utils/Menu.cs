using RPGConsoleApp.src.Entities;
using static System.Console;


namespace RPGConsoleApp.src.Utils
{
    public class Menu
    {
        static Character[] characters = new Character[7];

        public static void Iniciar()
        {
            characters = IOFile.LoadCharactersFromFile();
            int option;
            do
            {
                WriteLine("===== MENU RPG =====");
                WriteLine("1 - Criar personagem");
                WriteLine("2 - Listar personagens");
                WriteLine("3 - Deletar personagem");
                WriteLine("4 - Batalhar!");
                WriteLine("0 - Sair");
                Write("Escolha: ");
                option = int.Parse(ReadLine());

                switch (option)
                {
                    case 1: Create(); break;
                    case 2: List(); break;
                    case 3: Delete(); break;
                    case 4: Battle(); break;
                    case 0: WriteLine("Saindo..."); break;
                    default: WriteLine("Opção inválida"); break;
                }
            } while (option != 0);
        }

        static void Create()
        {
        }

        static void List()
        {
            WriteLine("===== LISTA DE PERSONAGENS =====");
            if (characters.Length == 0)
            {
                WriteLine("Nenhum personagem criado.");
            }
            else
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    var character = characters[i];
                    if (character != null)
                    {
                        WriteLine($"[{i + 1}] {character.Name} - Nível: {character.Level} - Tipo: {character.GetType().Name} - HP: {character.HP} - MP: {character.MP}");
                    }
                }
                WriteLine("=================================");

            }
        }

        static void Delete()
        {
        }

        static void Battle()
        {
        }
    }
}
