# DemoFile.Net ![NuGet](https://img.shields.io/nuget/v/DemoFile) ![Build status](https://github.com/saul/demofile-net/actions/workflows/dotnet.yml/badge.svg)

DemoFile.Net は、C#で書かれた Source 2 ゲーム用の超高速デモパーサーライブラリです。クロスプラットフォーム対応で、Windows、Mac、Linux で使用できます。このパーサーは現在以下をサポートしています：

| ゲーム              | NuGet パッケージ                                                                | はじめに                  |
|---------------------|---------------------------------------------------------------------------------|---------------------------|
| Counter-Strike 2    | ✅ [DemoFile.Game.Cs](https://www.nuget.org/packages/DemoFile.Game.Cs)           | `new CsDemoParser()`       |
| Deadlock            | ✅ [DemoFile.Game.Deadlock](https://www.nuget.org/packages/DemoFile.Game.Deadlock) | `new DeadlockDemoParser()` |

> [!IMPORTANT]
> `DemoFile` は基本となるコアライブラリであり、特定のゲームの解析サポートは提供しません。
> 代わりに `DemoFile.Game.*` パッケージのいずれかを参照に追加してください。

![Screenshot of DemoFile.Net](https://raw.githubusercontent.com/saul/demofile-net/main/assets/screenshot-2x.png)

IDE の組み込みオートコンプリート機能を通じて、利用可能なデータを簡単に発見できます：

| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-1.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-2.png) |
|-------------------------|-------------------------|
| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-3.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-4.png) |

## 特徴

| 機能                                              | 利用可能性       |
|---------------------------------------------------|------------------|
| CSTV / GOTV デモ                                   | ✅ 完全サポート   |
| POV デモ                                           | ✅ 完全サポート   |
| HTTP ブロードキャスト                             | ✅ 完全サポート   |
| ゲームイベント（例：`player_death`）               | ✅ 完全サポート   |
| エンティティ更新（プレイヤー位置、グレネード等）   | ✅ 完全サポート   |
| デモの前後へのシーク                               | ✅ 完全サポート   |

## はじめに

### インストール

プロジェクトに適切な NuGet パッケージを追加してください：


```bash
# For Counter-Strike 2
dotnet add package DemoFile.Game.Cs

# For Deadlock
dotnet add package DemoFile.Game.Deadlock
```

### 基本的な使い方

以下は、CS2デモからキルフィード情報を表示する簡単な例です：

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

## 高度な例

### プレイヤーの位置追跡

デモ全体を通じてプレイヤーの位置やその他のエンティティデータを追跡できます：

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

### ゲームイベントの操作

DemoFile.Netはゲームイベントへの強く型付けされたアクセスを提供します：

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

### 最大パフォーマンスのための並列処理

最大のパフォーマンスを得るために、複数のCPUコアを使用してデモを並列に解析します：

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllParallelAsync();  // Uses all available CPU cores
```

### HTTP ブロードキャストサポート

DemoFile.Net はライブHTTPブロードキャストを解析できます：

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = HttpBroadcastReader.Create(demo, "http://localhost:8080/broadcast");
await reader.ReadAllAsync();
```
[examples/](https://github.com/saul/demofile-net/tree/main/examples) フォルダーには、より完全な例が掲載されています：

- [Basic](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.Basic/Program.cs) - シンプルなデモ解析
- [MultiThreaded](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.MultiThreaded/Program.cs) - 最大パフォーマンスのための並列処理
- [PlayerPositions](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.PlayerPositions/Program.cs) - プレイヤーの位置と動きを追跡
- [HttpBroadcast](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.HttpBroadcast/Program.cs) - ライブHTTP放送の解析

## ベンチマーク

M1 MacBook Pro 上では、DemoFile.Net は競技ゲーム全体（ゲーム時間約1時間弱）を1.3秒で読み込むことができます。
`ReadAllParallelAsync` メソッドを使用して複数スレッドで解析すると、これがほぼ500ミリ秒にまで短縮されます。
これにはすべてのエンティティデータ（プレイヤーの位置、速度、武器の追跡、グレネードなど）の解析が含まれます。

| メソッド           |           平均 |    エラー |   標準偏差 | 割り当て済み |
|-------------------|---------------:|---------:|---------:|----------:|
| ParseDemo         | **1,294.6 ms** |  3.68 ms |  2.88 ms | 491.48 MB |
| ParseDemoParallel |   **540.1 ms** | 23.99 ms | 22.44 ms | 600.67 MB |

## 作者と謝辞

DemoFile.Net は [Saul Rennison](https://saul.re) によって開発されました。このライブラリの開発は、
[demoparser by LaihoE](https://github.com/LaihoE/demoparser)
および [Manta by Dotabuff](https://raw.githubusercontent.com/dotabuff/manta/master/README.md) の存在なしには不可能でした。
後者は以下の多くの方々の努力に依存しています：

- [Michael Fellinger](https://github.com/manveru) は Dotabuff の Source 1
  パーサーである [yasha](https://github.com/dotabuff/yasha) を構築しました。
- [Robin Dietrich](https://github.com/invokr) は C++ パーサー [Alice](https://github.com/AliceStats/Alice) を構築しました。
- [Martin Schrodt](https://github.com/spheenik) は Java パーサー [clarity](https://github.com/skadistats/clarity) を構築しました。
- [Drew Schleck](https://github.com/dschleck) はオリジナルの C++ パーサー [edith](https://github.com/dschleck/edith) を構築しました。

[Source2Gen by neverlosecc](https://github.com/neverlosecc/source2gen) の修正版がゲームスキーマのクラスと列挙型を静的に生成するために使用されています。

ライセンス情報については [ACKNOWLEDGEMENTS](./ACKNOWLEDGEMENTS) を参照してください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---