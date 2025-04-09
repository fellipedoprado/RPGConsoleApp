# RPGConsoleApp

Reforce seu conhecimento em **Programação Orientada a Objetos (POO)** em C# com um desafio de projeto totalmente prático. Para isso, os pilares da orientação a objetos serão devidamente explorados no contexto de um jogo de RPG. Com isso, você poderá desenvolver sua capacidade de abstração com um problema real e implementar as evoluções que julgar necessárias. 😉

---

## 📌 Descrição do Projeto

O **RPGConsoleApp** é um laboratório prático que simula um sistema de RPG (Role-Playing Game) no console. O projeto foi desenvolvido para explorar os conceitos fundamentais da POO, como **abstração**, **herança**, **polimorfismo** e **encapsulamento**, aplicados no contexto de um jogo.

Neste laboratório, você terá a oportunidade de:

- Criar e gerenciar personagens com atributos e comportamentos específicos.
- Implementar batalhas automáticas entre personagens.
- Persistir dados em arquivos JSON para simular um sistema de armazenamento.
- Evoluir o projeto com novas funcionalidades e melhorias.

---

## 🎮 Funcionalidades

- **Listagem de Personagens**: Visualize todos os personagens disponíveis, com detalhes como nome, nível, classe, HP e MP.
- **Batalhas Automáticas**: Simule batalhas entre dois personagens, com ataques normais, habilidades especiais e ataques críticos.
- **Reset de Atributos**: Após cada batalha, os atributos dos personagens (HP e MP) são restaurados para seus valores iniciais.
- **Persistência de Dados**: Salve e carregue personagens de um arquivo JSON para manter o progresso entre execuções.
- **Classes de Personagens**: Suporte para várias classes, incluindo:
  - Bard
  - Knight
  - Mage
  - Ninja
  - Thief
  - Warrior
  - Wizard

---

## 📁 Estrutura do Projeto

```text
RPGConsoleApp/
├── src/
│   ├── Data/
│   │   └── characters.json       # Arquivo de dados com os personagens
│   ├── Entities/
│   │   ├── Character.cs          # Classe base para personagens
│   │   ├── Bard.cs               # Classe Bard
│   │   ├── Knight.cs             # Classe Knight
│   │   ├── Mage.cs               # Classe Mage
│   │   ├── Ninja.cs              # Classe Ninja
│   │   ├── Thief.cs              # Classe Thief
│   │   ├── Warrior.cs            # Classe Warrior
│   │   ├── Wizard.cs             # Classe Wizard
│   ├── Utils/
│   │   ├── IOFile.cs             # Manipulação de arquivos JSON
│   │   └── Menu.cs               # Menu principal do jogo
├── Program.cs                    # Ponto de entrada do programa
└── RPGConsoleApp.csproj          # Arquivo de configuração do projeto
```

---

## ⚙️ Pré-requisitos

- [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) ou superior
- Editor de código como [Visual Studio Code](https://code.visualstudio.com/) ou Visual Studio

---

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/RPGConsoleApp.git
   cd RPGConsoleApp
   ```

2. Compile o projeto:
   ```bash
   dotnet build
   ```

3. Execute o programa:
   ```bash
   dotnet run --project RPGConsoleApp
   ```

4. Siga as instruções no menu para interagir com o jogo.

---

## 🧩 Como Adicionar Novas Classes de Personagens

1. Crie uma nova classe na pasta `src/Entities` que herde de `Character`.
2. Implemente os métodos `BasicAttack`, `SpecialAttack` e `CriticalAttack` para personalizar os ataques da nova classe.
3. Atualize o método `LoadCharactersFromFile` no arquivo `IOFile.cs` para incluir a nova classe no `switch`.

---

## 📄 Exemplo de Arquivo JSON

O arquivo `characters.json` contém os personagens salvos no seguinte formato:

```json
[
  {
    "Type": "Bard",
    "Name": "Luthien",
    "Level": 5,
    "HP": 80,
    "MP": 120,
    "Attack": 25,
    "Defense": 15
  },
  {
    "Type": "Knight",
    "Name": "Arthur",
    "Level": 10,
    "HP": 200,
    "MP": 50,
    "Attack": 40,
    "Defense": 50
  }
]
```

---

## 🎯 Objetivo do Laboratório

Este projeto foi desenvolvido para reforçar os seguintes conceitos de POO:

- **Abstração**: Representação de personagens e suas características no jogo.
- **Herança**: Criação de subclasses específicas (como Mage, Warrior) que herdam da classe base `Character`.
- **Polimorfismo**: Implementação de métodos como `BasicAttack`, `SpecialAttack` e `CriticalAttack` que se comportam de forma diferente em cada classe.
- **Encapsulamento**: Organização e proteção dos atributos e métodos das classes.

---

## 🤝 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir [issues](https://github.com/seu-usuario/RPGConsoleApp/issues) ou enviar pull requests.

---

## 📜 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

---

## ❤️ Desenvolvido com carinho

Para reforçar os conceitos de POO em C#.
