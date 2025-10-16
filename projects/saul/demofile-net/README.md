# DemoFile.Net ![NuGet](https://img.shields.io/nuget/v/DemoFile) ![Build status](https://github.com/saul/demofile-net/actions/workflows/dotnet.yml/badge.svg)

DemoFile.Net is a blazing fast demo parser library for Source 2 games, written in C#. It is cross-platform, and can be
used on Windows, Mac or Linux. This parser currently supports:

| Game             | NuGet package                                                                     | Getting started            |
|------------------|-----------------------------------------------------------------------------------|----------------------------|
| Counter-Strike 2 | ✅ [DemoFile.Game.Cs](https://www.nuget.org/packages/DemoFile.Game.Cs)             | `new CsDemoParser()`       |
| Deadlock         | ✅ [DemoFile.Game.Deadlock](https://www.nuget.org/packages/DemoFile.Game.Deadlock) | `new DeadlockDemoParser()` |

> [!IMPORTANT]
> `DemoFile` is the base, core library and does not provide support for parsing any specific game.
> Add a reference to one of the `DemoFile.Game.*` packages instead.

![Screenshot of DemoFile.Net](https://raw.githubusercontent.com/saul/demofile-net/main/assets/screenshot-2x.png)

Easy discoverability of available data through your IDE's inbuilt autocompletion:

| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-1.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-2.png) |
|-------------------------|-------------------------|
| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-3.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-4.png) |

## Features

| Feature                                           | Availability   |
|---------------------------------------------------|----------------|
| CSTV / GOTV demos                                 | ✅ Full support |
| POV demos                                         | ✅ Full support |
| HTTP broadcasts                                   | ✅ Full support  |
| Game events (e.g. `player_death`)                 | ✅ Full support |
| Entity updates (player positions, grenades, etc.) | ✅ Full support |
| Seeking forwards/backwards through the demo       | ✅ Full support |

## Getting Started

### Installation

Add the appropriate NuGet package to your project:

```bash
# For Counter-Strike 2
dotnet add package DemoFile.Game.Cs

# For Deadlock
dotnet add package DemoFile.Game.Deadlock
```

### Basic Usage

Here's a simple example that prints kill feed information from a CS2 demo:

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

## Advanced Examples

### Tracking Player Positions

You can track player positions and other entity data throughout the demo:

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

### Working with Game Events

DemoFile.Net provides strongly-typed access to game events:

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

### Parallel Processing for Maximum Performance

For maximum performance, parse demos in parallel using multiple CPU cores:

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllParallelAsync();  // Uses all available CPU cores
```

### HTTP Broadcast Support

DemoFile.Net can parse live HTTP broadcasts:

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = HttpBroadcastReader.Create(demo, "http://localhost:8080/broadcast");
await reader.ReadAllAsync();
```

See the [examples/](https://github.com/saul/demofile-net/tree/main/examples) folder for more complete examples:

- [Basic](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.Basic/Program.cs) - Simple demo parsing
- [MultiThreaded](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.MultiThreaded/Program.cs) - Parallel processing for maximum performance
- [PlayerPositions](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.PlayerPositions/Program.cs) - Tracking player positions and movements
- [HttpBroadcast](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.HttpBroadcast/Program.cs) - Parsing live HTTP broadcasts

## Benchmarks

On an M1 MacBook Pro, DemoFile.Net can read a full competitive game (just under 1 hour of game time) in 1.3 seconds.
When parsing across multiple threads, using the `ReadAllParallelAsync` method, this drops to nearly 500 milliseconds.
This includes parsing all entity data (player positions, velocities, weapon tracking, grenades, etc).

| Method            |           Mean |    Error |   StdDev | Allocated |
|-------------------|---------------:|---------:|---------:|----------:|
| ParseDemo         | **1,294.6 ms** |  3.68 ms |  2.88 ms | 491.48 MB |
| ParseDemoParallel |   **540.1 ms** | 23.99 ms | 22.44 ms | 600.67 MB |

## Author and acknowledgements

DemoFile.Net is developed by [Saul Rennison](https://saul.re). The development of this library would not have been
possible without [demoparser by LaihoE](https://github.com/LaihoE/demoparser)
and [Manta by Dotabuff](https://raw.githubusercontent.com/dotabuff/manta/master/README.md), the latter of which depends
on the efforts of a number of people:

- [Michael Fellinger](https://github.com/manveru) built Dotabuff's Source 1
  parser [yasha](https://github.com/dotabuff/yasha).
- [Robin Dietrich](https://github.com/invokr) built the C++ parser [Alice](https://github.com/AliceStats/Alice).
- [Martin Schrodt](https://github.com/spheenik) built the Java parser [clarity](https://github.com/skadistats/clarity).
- [Drew Schleck](https://github.com/dschleck) built an original C++ parser [edith](https://github.com/dschleck/edith).

A modified version of [Source2Gen by neverlosecc](https://github.com/neverlosecc/source2gen) is used to statically
generate the game schema classes and enums.

See [ACKNOWLEDGEMENTS](./ACKNOWLEDGEMENTS) for license information.
