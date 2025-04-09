using RPGConsoleApp.src.Entities;
using static System.Console;


namespace RPGConsoleApp.src.Utils
{
    public class Menu
    {
        static Character[]? characters = new Character[7];

        public static void Iniciar()
        {
            characters = IOFile.LoadCharactersFromFile();
            int option;
            do
            {
                WriteLine("===== MENU RPG =====");
                WriteLine("1 - Listar personagens");
                WriteLine("2 - Batalhar!");
                WriteLine("0 - Sair");
                Write("Escolha: ");
                option = int.Parse(ReadLine());

                switch (option)
                {
                    case 1: List(); break;
                    case 2: Battle(); break;
                    case 0: WriteLine("Saindo..."); break;
                    default: WriteLine("Opção inválida"); break;
                }
            } while (option != 0);
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

        static void Battle()
        {
            WriteLine("===== BATALHA =====");

            // Listar personagens disponíveis
            List();

            // Selecionar os dois personagens para a batalha
            Write("Escolha o índice do primeiro personagem: ");
            int indexPlayer1 = int.Parse(ReadLine()) - 1;
            Write("Escolha o índice do segundo personagem: ");
            int indexPlayer2 = int.Parse(ReadLine()) - 1;

            if (indexPlayer1 < 0 || indexPlayer1 >= characters.Length || indexPlayer2 < 0 || indexPlayer2 >= characters.Length || characters[indexPlayer1] == null || characters[indexPlayer2] == null)
            {
                WriteLine("Índices inválidos ou personagens inexistentes.");
                return;
            }

            Character charPlayer1 = characters[indexPlayer1];
            Character charPlayer2 = characters[indexPlayer2];

            WriteLine($"Batalha entre {charPlayer1.Name} e {charPlayer2.Name}!");

            Random random = new Random();

            // Loop de batalha
            while (charPlayer1.HP > 0 && charPlayer2.HP > 0)
            {
                // Turno do primeiro personagem
                int attackType1 = random.Next(1, 4); // Escolhe aleatoriamente o tipo de ataque (1: Básico, 2: Especial, 3: Crítico)
                int damage1;
                switch (attackType1)
                {
                    case 1:
                        damage1 = charPlayer1.BasicAttack(charPlayer2);
                        WriteLine($"{charPlayer1.Name} usou Ataque Básico causando {damage1} de dano!");
                        break;
                    case 2:
                        damage1 = charPlayer1.SpecialAttack(charPlayer2);
                        WriteLine($"{charPlayer1.Name} usou Habilidade Especial causando {damage1} de dano!");
                        break;
                    case 3:
                        damage1 = charPlayer1.CriticalAttack(charPlayer2);
                        WriteLine($"{charPlayer1.Name} usou Ataque Crítico causando {damage1} de dano!");
                        break;
                }

                WriteLine($"{charPlayer2.Name} tem {charPlayer2.HP} HP restante.");
                if (charPlayer2.HP <= 0)
                {
                    WriteLine($"{charPlayer2.Name} foi derrotado!");
                    break;
                }

                // Turno do segundo personagem
                int attackType2 = random.Next(1, 4); // Escolhe aleatoriamente o tipo de ataque (1: Básico, 2: Especial, 3: Crítico)
                int damage2;
                switch (attackType2)
                {
                    case 1:
                        damage2 = charPlayer2.BasicAttack(charPlayer1);
                        WriteLine($"{charPlayer2.Name} usou Ataque Básico causando {damage2} de dano!");
                        break;
                    case 2:
                        damage2 = charPlayer2.SpecialAttack(charPlayer1);
                        WriteLine($"{charPlayer2.Name} usou Habilidade Especial causando {damage2} de dano!");
                        break;
                    case 3:
                        damage2 = charPlayer2.CriticalAttack(charPlayer1);
                        WriteLine($"{charPlayer2.Name} usou Ataque Crítico causando {damage2} de dano!");
                        break;
                }

                WriteLine($"{charPlayer1.Name} tem {charPlayer1.HP} HP restante.");
                if (charPlayer1.HP <= 0)
                {
                    WriteLine($"{charPlayer1.Name} foi derrotado!");
                    break;
                }
            }

            WriteLine("Batalha encerrada!");
            Reset();
        }

        static void Reset()
        {
            characters = IOFile.LoadCharactersFromFile();
        }
    }
}
