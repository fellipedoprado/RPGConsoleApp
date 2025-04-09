using System.Text.Json;
using static System.Console;
using RPGConsoleApp.src.Entities;

namespace RPGConsoleApp.src.Utils
{
    public class IOFile
    {
        private static string filePath =Path.Combine(Environment.CurrentDirectory, "src/Data/characters.json");
        public static void SaveCharactersToFile(Character[] characters)
        {
            try
            {
                // Serializa a lista de personagens para JSON
                string json = JsonSerializer.Serialize(characters);
                File.WriteAllText(filePath, json);
                WriteLine("Personagens salvos com sucesso!");
            }
            catch (Exception ex)
            {
                WriteLine($"Erro ao salvar personagens: {ex.Message}");
            }
        }

        public static Character[] LoadCharactersFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    // Desserializa os dados para uma lista de objetos anônimos
                    var characterDataList = JsonSerializer.Deserialize<List<CharacterData>>(json);
                    if (characterDataList == null || characterDataList.Count == 0)
                    {
                        WriteLine("Nenhum personagem encontrado no arquivo.");
                        return new Character[7];
                    }

                    var characters = new Character[7];
                    int index = 0;

                    foreach (var data in characterDataList)
                    {
                         // Instancia a classe correta com base no tipo
                        Character character = data.Type switch
                        {
                            "Bard" => new Bard(data.Name, data.Level, data.HP, data.MP, data.Attack, data.Defense),
                            "Knight" => new Knight(data.Name, data.Level, data.HP, data.MP, data.Attack, data.Defense),
                            "Mage" => new Mage(data.Name, data.Level, data.HP, data.MP, data.Attack, data.Defense),
                            "Ninja" => new Ninja(data.Name, data.Level, data.HP, data.MP, data.Attack, data.Defense),
                            "Thief" => new Thief(data.Name, data.Level, data.HP, data.MP, data.Attack, data.Defense),
                            "Warrior" => new Warrior(data.Name, data.Level, data.HP, data.MP, data.Attack, data.Defense),
                            "Wizard" => new Wizard(data.Name, data.Level, data.HP, data.MP, data.Attack, data.Defense),
                            _ => throw new Exception($"Tipo desconhecido: {data.Type}")
                        };

                        characters[index++] = character;
                    }

                    WriteLine("Personagens carregados com sucesso!");
                    return characters;
                }
                else
                {
                    WriteLine("Nenhum arquivo de personagens encontrado. Criando uma nova lista.");
                    return new Character[7];
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Erro ao carregar personagens: {ex.Message}");
                return new Character[7];
            }
        }

    }
}