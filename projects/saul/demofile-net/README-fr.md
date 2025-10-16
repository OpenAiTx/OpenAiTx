# DemoFile.Net ![NuGet](https://img.shields.io/nuget/v/DemoFile) ![Build status](https://github.com/saul/demofile-net/actions/workflows/dotnet.yml/badge.svg)

DemoFile.Net est une bibliothèque d'analyse de démos ultra rapide pour les jeux Source 2, écrite en C#. Elle est multiplateforme et peut être utilisée sur Windows, Mac ou Linux. Cet analyseur prend actuellement en charge :

| Jeu               | Package NuGet                                                                    | Pour commencer            |
|-------------------|---------------------------------------------------------------------------------|---------------------------|
| Counter-Strike 2  | ✅ [DemoFile.Game.Cs](https://www.nuget.org/packages/DemoFile.Game.Cs)           | `new CsDemoParser()`       |
| Deadlock          | ✅ [DemoFile.Game.Deadlock](https://www.nuget.org/packages/DemoFile.Game.Deadlock) | `new DeadlockDemoParser()` |

> [!IMPORTANT]
> `DemoFile` est la bibliothèque de base, cœur, et ne fournit pas de support pour l’analyse d’un jeu spécifique.
> Ajoutez une référence à l’un des packages `DemoFile.Game.*` à la place.

![Capture d'écran de DemoFile.Net](https://raw.githubusercontent.com/saul/demofile-net/main/assets/screenshot-2x.png)

Découverte facile des données disponibles grâce à l’auto-complétion intégrée de votre IDE :

| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-1.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-2.png) |
|-------------------------|-------------------------|
| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-3.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-4.png) |

## Fonctionnalités

| Fonctionnalité                                     | Disponibilité  |
|--------------------------------------------------|---------------|
| Démos CSTV / GOTV                                | ✅ Support complet |
| Démos POV                                        | ✅ Support complet |
| Diffusions HTTP                                  | ✅ Support complet |
| Événements du jeu (ex. `player_death`)          | ✅ Support complet |
| Mises à jour des entités (positions joueurs, grenades, etc.) | ✅ Support complet |
| Navigation avant/arrière dans la démo            | ✅ Support complet |

## Pour commencer

### Installation

Ajoutez le package NuGet approprié à votre projet :


```bash
# For Counter-Strike 2
dotnet add package DemoFile.Game.Cs

# For Deadlock
dotnet add package DemoFile.Game.Deadlock
```

### Utilisation de base

Voici un exemple simple qui affiche les informations du feed de kills d'une démo CS2 :

```c#
using DemoFile;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var path = args.SingleOrDefault() ?? throw new Exception("Expected a single argument: <path to .dem>");

        var demo = new CsDemoParser();
        demo.Source1GameEvents.PlayerDeath += e =>
        {
            Console.WriteLine($"{e.Attacker?.PlayerName} [{e.Weapon}] {e.Player?.PlayerName}");
        };

        var reader = DemoFileReader.Create(demo, File.OpenRead(path));
        await reader.ReadAllAsync();

        Console.WriteLine("\nFinished!");
    }
}
```

## Exemples Avancés

### Suivi des Positions des Joueurs

Vous pouvez suivre les positions des joueurs et d'autres données d'entités tout au long de la démo :

```c#
var demo = new CsDemoParser();

// Subscribe to tick events to get data at specific points in time
demo.TickEnd += (_, tick) =>
{
    // Get all active players
    foreach (var player in demo.Entities.Players)
    {
        if (player.Pawn is { } pawn)
        {
            Console.WriteLine($"Player {player.PlayerName} is at position {pawn.CBodyComponent?.Position}");
        }
    }
};

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllAsync();
```

### Travailler avec les événements de jeu

DemoFile.Net offre un accès fortement typé aux événements de jeu :

```c#
var demo = new CsDemoParser();

// Track round wins
demo.Source1GameEvents.RoundEnd += e => 
{
    Console.WriteLine($"Round ended. Winner: {e.Winner}. Reason: {e.Reason}");
};

// Track bomb events
demo.Source1GameEvents.BombPlanted += e => 
{
    Console.WriteLine($"Bomb planted by {e.Player?.PlayerName} at site {e.Site}");
};

demo.Source1GameEvents.BombDefused += e => 
{
    Console.WriteLine($"Bomb defused by {e.Player?.PlayerName}");
};

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllAsync();
```

### Traitement parallèle pour des performances maximales

Pour des performances maximales, analysez les démos en parallèle en utilisant plusieurs cœurs CPU :

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllParallelAsync();  // Uses all available CPU cores
```

### Prise en charge de la diffusion HTTP

DemoFile.Net peut analyser les diffusions HTTP en direct :

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = HttpBroadcastReader.Create(demo, "http://localhost:8080/broadcast");
await reader.ReadAllAsync();
```

Voir le dossier [examples/](https://github.com/saul/demofile-net/tree/main/examples) pour des exemples plus complets :

- [Basic](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.Basic/Program.cs) - Analyse de démonstration simple
- [MultiThreaded](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.MultiThreaded/Program.cs) - Traitement parallèle pour des performances maximales
- [PlayerPositions](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.PlayerPositions/Program.cs) - Suivi des positions et mouvements des joueurs
- [HttpBroadcast](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.HttpBroadcast/Program.cs) - Analyse des diffusions HTTP en direct

## Benchmarks

Sur un MacBook Pro M1, DemoFile.Net peut lire une partie compétitive complète (un peu moins d'une heure de temps de jeu) en 1,3 seconde.
Lors de l’analyse sur plusieurs threads, en utilisant la méthode `ReadAllParallelAsync`, ce temps tombe à presque 500 millisecondes.
Cela inclut l'analyse de toutes les données d'entité (positions des joueurs, vitesses, suivi des armes, grenades, etc.).

| Méthode           |           Moyenne |    Erreur |   ÉcartType | Alloué    |
|-------------------|-----------------:|----------:|------------:|----------:|
| ParseDemo         | **1 294,6 ms**   |  3,68 ms  |  2,88 ms    | 491,48 Mo |
| ParseDemoParallel |   **540,1 ms**   | 23,99 ms  | 22,44 ms    | 600,67 Mo |

## Auteur et remerciements

DemoFile.Net est développé par [Saul Rennison](https://saul.re). Le développement de cette bibliothèque n’aurait pas été
possible sans [demoparser de LaihoE](https://github.com/LaihoE/demoparser)
et [Manta de Dotabuff](https://raw.githubusercontent.com/dotabuff/manta/master/README.md), cette dernière reposant
sur les efforts de plusieurs personnes :

- [Michael Fellinger](https://github.com/manveru) a créé le parseur Source 1 de Dotabuff
  [yasha](https://github.com/dotabuff/yasha).
- [Robin Dietrich](https://github.com/invokr) a développé le parseur C++ [Alice](https://github.com/AliceStats/Alice).
- [Martin Schrodt](https://github.com/spheenik) a construit le parseur Java [clarity](https://github.com/skadistats/clarity).
- [Drew Schleck](https://github.com/dschleck) a réalisé un parseur C++ original [edith](https://github.com/dschleck/edith).

Une version modifiée de [Source2Gen par neverlosecc](https://github.com/neverlosecc/source2gen) est utilisée pour générer statiquement
les classes et énumérations du schéma de jeu.

Voir [ACKNOWLEDGEMENTS](./ACKNOWLEDGEMENTS) pour les informations sur la licence.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---