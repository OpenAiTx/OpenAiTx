# DemoFile.Net ![NuGet](https://img.shields.io/nuget/v/DemoFile) ![Estado de compilación](https://github.com/saul/demofile-net/actions/workflows/dotnet.yml/badge.svg)

DemoFile.Net es una biblioteca de análisis de demos ultra rápida para juegos Source 2, escrita en C#. Es multiplataforma y puede
usarse en Windows, Mac o Linux. Este analizador actualmente soporta:

| Juego             | Paquete NuGet                                                                    | Primeros pasos             |
|------------------|----------------------------------------------------------------------------------|----------------------------|
| Counter-Strike 2 | ✅ [DemoFile.Game.Cs](https://www.nuget.org/packages/DemoFile.Game.Cs)            | `new CsDemoParser()`        |
| Deadlock         | ✅ [DemoFile.Game.Deadlock](https://www.nuget.org/packages/DemoFile.Game.Deadlock) | `new DeadlockDemoParser()`  |

> [!IMPORTANTE]
> `DemoFile` es la biblioteca base y principal y no proporciona soporte para analizar ningún juego específico.
> En su lugar, agregue una referencia a uno de los paquetes `DemoFile.Game.*`.

![Captura de pantalla de DemoFile.Net](https://raw.githubusercontent.com/saul/demofile-net/main/assets/screenshot-2x.png)

Fácil descubrimiento de los datos disponibles a través de la autocompletación integrada de su IDE:

| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-1.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-2.png) |
|-------------------------|-------------------------|
| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-3.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-4.png) |

## Características

| Característica                                    | Disponibilidad  |
|--------------------------------------------------|-----------------|
| Demos CSTV / GOTV                                | ✅ Soporte completo |
| Demos POV                                        | ✅ Soporte completo |
| Transmisiones HTTP                               | ✅ Soporte completo  |
| Eventos del juego (p.ej. `player_death`)         | ✅ Soporte completo |
| Actualizaciones de entidades (posiciones de jugadores, granadas, etc.) | ✅ Soporte completo |
| Avanzar/retroceder a través de la demo           | ✅ Soporte completo |

## Primeros pasos

### Instalación

Agregue el paquete NuGet adecuado a su proyecto:

```bash
# For Counter-Strike 2
dotnet add package DemoFile.Game.Cs

# For Deadlock
dotnet add package DemoFile.Game.Deadlock
```

### Uso Básico

Aquí hay un ejemplo simple que imprime información del feed de bajas de una demo de CS2:

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

## Ejemplos Avanzados

### Seguimiento de Posiciones de Jugadores

Puedes rastrear las posiciones de los jugadores y otros datos de entidades a lo largo de la demostración:

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

### Trabajando con Eventos del Juego

DemoFile.Net proporciona acceso fuertemente tipado a los eventos del juego:

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

### Procesamiento Paralelo para Máximo Rendimiento

Para un rendimiento máximo, analiza las demos en paralelo utilizando múltiples núcleos de CPU:

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllParallelAsync();  // Uses all available CPU cores
```

### Soporte de Transmisión HTTP

DemoFile.Net puede analizar transmisiones HTTP en vivo:

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = HttpBroadcastReader.Create(demo, "http://localhost:8080/broadcast");
await reader.ReadAllAsync();
```
Consulta la carpeta [examples/](https://github.com/saul/demofile-net/tree/main/examples) para ejemplos más completos:

- [Basic](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.Basic/Program.cs) - Análisis demo simple
- [MultiThreaded](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.MultiThreaded/Program.cs) - Procesamiento paralelo para máximo rendimiento
- [PlayerPositions](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.PlayerPositions/Program.cs) - Seguimiento de posiciones y movimientos de jugadores
- [HttpBroadcast](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.HttpBroadcast/Program.cs) - Análisis de transmisiones HTTP en vivo

## Benchmarks

En un MacBook Pro M1, DemoFile.Net puede leer una partida competitiva completa (poco menos de 1 hora de juego) en 1.3 segundos.
Al analizar con múltiples hilos, usando el método `ReadAllParallelAsync`, este tiempo baja a casi 500 milisegundos.
Esto incluye el análisis de todos los datos de entidades (posiciones de jugadores, velocidades, seguimiento de armas, granadas, etc.).

| Método            |           Media |    Error |   Desv.Est | Asignado |
|-------------------|----------------:|---------:|-----------:|---------:|
| ParseDemo         | **1,294.6 ms**  |  3.68 ms |  2.88 ms   | 491.48 MB|
| ParseDemoParallel | **540.1 ms**    | 23.99 ms | 22.44 ms   | 600.67 MB|

## Autor y agradecimientos

DemoFile.Net es desarrollado por [Saul Rennison](https://saul.re). El desarrollo de esta biblioteca no habría sido
posible sin [demoparser de LaihoE](https://github.com/LaihoE/demoparser)
y [Manta de Dotabuff](https://raw.githubusercontent.com/dotabuff/manta/master/README.md), este último depende
de los esfuerzos de varias personas:

- [Michael Fellinger](https://github.com/manveru) creó el parser Source 1 de Dotabuff
  llamado [yasha](https://github.com/dotabuff/yasha).
- [Robin Dietrich](https://github.com/invokr) creó el parser en C++ [Alice](https://github.com/AliceStats/Alice).
- [Martin Schrodt](https://github.com/spheenik) creó el parser en Java [clarity](https://github.com/skadistats/clarity).
- [Drew Schleck](https://github.com/dschleck) creó un parser original en C++ llamado [edith](https://github.com/dschleck/edith).

Se usa una versión modificada de [Source2Gen de neverlosecc](https://github.com/neverlosecc/source2gen) para generar
estáticamente las clases y enums del esquema del juego.

Consulta [ACKNOWLEDGEMENTS](./ACKNOWLEDGEMENTS) para información sobre licencias.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---