# DemoFile.Net ![NuGet](https://img.shields.io/nuget/v/DemoFile) ![Build status](https://github.com/saul/demofile-net/actions/workflows/dotnet.yml/badge.svg)

DemoFile.Net 是一个专为 Source 2 游戏设计的超高速演示解析库，使用 C# 编写。它是跨平台的，可以在 Windows、Mac 或 Linux 上使用。该解析器当前支持：

| 游戏              | NuGet 包                                                                            | 入门指南                  |
|-------------------|-------------------------------------------------------------------------------------|---------------------------|
| 反恐精英 2        | ✅ [DemoFile.Game.Cs](https://www.nuget.org/packages/DemoFile.Game.Cs)               | `new CsDemoParser()`       |
| Deadlock          | ✅ [DemoFile.Game.Deadlock](https://www.nuget.org/packages/DemoFile.Game.Deadlock)   | `new DeadlockDemoParser()` |

> [!IMPORTANT]
> `DemoFile` 是基础核心库，不支持解析任何特定游戏。
> 请改为添加对某个 `DemoFile.Game.*` 包的引用。

![DemoFile.Net 截图](https://raw.githubusercontent.com/saul/demofile-net/main/assets/screenshot-2x.png)

通过 IDE 内置的自动补全功能，轻松发现可用数据：

| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-1.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-2.png) |
|-------------------------|-------------------------|
| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-3.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-4.png) |

## 特性

| 特性                                              | 支持情况     |
|--------------------------------------------------|--------------|
| CSTV / GOTV 演示                                  | ✅ 完全支持   |
| POV 演示                                          | ✅ 完全支持   |
| HTTP 广播                                         | ✅ 完全支持   |
| 游戏事件（如 `player_death`）                     | ✅ 完全支持   |
| 实体更新（玩家位置、手雷等）                      | ✅ 完全支持   |
| 向前/向后查找演示                                 | ✅ 完全支持   |

## 入门指南

### 安装

将相应的 NuGet 包添加到您的项目中：


```bash
# For Counter-Strike 2
dotnet add package DemoFile.Game.Cs

# For Deadlock
dotnet add package DemoFile.Game.Deadlock
```

### 基本用法

下面是一个简单的示例，演示如何从CS2演示中打印击杀信息：

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

## 高级示例

### 跟踪玩家位置

您可以在整个演示过程中跟踪玩家位置和其他实体数据：

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

### 使用游戏事件

DemoFile.Net 提供对游戏事件的强类型访问：

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

### 最大性能的并行处理

为了获得最大性能，使用多个CPU核心并行解析演示文件：

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllParallelAsync();  // Uses all available CPU cores
```

### HTTP 广播支持

DemoFile.Net 可以解析实时 HTTP 广播：

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = HttpBroadcastReader.Create(demo, "http://localhost:8080/broadcast");
await reader.ReadAllAsync();
```
请参阅 [examples/](https://github.com/saul/demofile-net/tree/main/examples) 文件夹中的更完整示例：

- [Basic](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.Basic/Program.cs) - 简单的演示解析
- [MultiThreaded](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.MultiThreaded/Program.cs) - 并行处理以获得最大性能
- [PlayerPositions](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.PlayerPositions/Program.cs) - 跟踪玩家位置和移动
- [HttpBroadcast](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.HttpBroadcast/Program.cs) - 解析实时 HTTP 广播

## 基准测试

在 M1 MacBook Pro 上，DemoFile.Net 能够在 1.3 秒内读取完整的竞技比赛（游戏时间不到 1 小时）。
使用 `ReadAllParallelAsync` 方法在多线程解析时，时间降至接近 500 毫秒。
这包括解析所有实体数据（玩家位置、速度、武器追踪、手榴弹等）。

| 方法              |           平均值 |    误差 |   标准差 | 分配内存 |
|-------------------|----------------:|--------:|---------:|---------:|
| ParseDemo         | **1,294.6 毫秒** |  3.68 毫秒 |  2.88 毫秒 | 491.48 MB |
| ParseDemoParallel |   **540.1 毫秒** | 23.99 毫秒 | 22.44 毫秒 | 600.67 MB |

## 作者及致谢

DemoFile.Net 由 [Saul Rennison](https://saul.re) 开发。没有以下项目，这个库的开发是不可能的：
[demoparser by LaihoE](https://github.com/LaihoE/demoparser)
和 [Manta by Dotabuff](https://raw.githubusercontent.com/dotabuff/manta/master/README.md)，后者依赖于许多人的努力：

- [Michael Fellinger](https://github.com/manveru) 构建了 Dotabuff 的 Source 1
  解析器 [yasha](https://github.com/dotabuff/yasha)。
- [Robin Dietrich](https://github.com/invokr) 构建了 C++ 解析器 [Alice](https://github.com/AliceStats/Alice)。
- [Martin Schrodt](https://github.com/spheenik) 构建了 Java 解析器 [clarity](https://github.com/skadistats/clarity)。
- [Drew Schleck](https://github.com/dschleck) 构建了原始的 C++ 解析器 [edith](https://github.com/dschleck/edith)。

一个经过修改的 [Source2Gen by neverlosecc](https://github.com/neverlosecc/source2gen) 被用来静态生成游戏的模式类和枚举。

有关许可信息，请参见 [ACKNOWLEDGEMENTS](./ACKNOWLEDGEMENTS)。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---