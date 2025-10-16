# DemoFile.Net ![NuGet](https://img.shields.io/nuget/v/DemoFile) ![Build status](https://github.com/saul/demofile-net/actions/workflows/dotnet.yml/badge.svg)

DemoFile.Net은 C#으로 작성된 Source 2 게임용 초고속 데모 파서 라이브러리입니다. 크로스 플랫폼으로 Windows, Mac 또는 Linux에서 사용할 수 있습니다. 이 파서는 현재 다음을 지원합니다:

| 게임              | NuGet 패키지                                                                        | 시작하기                   |
|------------------|-----------------------------------------------------------------------------------|----------------------------|
| Counter-Strike 2 | ✅ [DemoFile.Game.Cs](https://www.nuget.org/packages/DemoFile.Game.Cs)             | `new CsDemoParser()`       |
| Deadlock         | ✅ [DemoFile.Game.Deadlock](https://www.nuget.org/packages/DemoFile.Game.Deadlock) | `new DeadlockDemoParser()` |

> [!IMPORTANT]
> `DemoFile`은 기본 핵심 라이브러리로 특정 게임 파싱을 지원하지 않습니다.
> 대신 `DemoFile.Game.*` 패키지 중 하나를 참조에 추가하세요.

![DemoFile.Net 스크린샷](https://raw.githubusercontent.com/saul/demofile-net/main/assets/screenshot-2x.png)

IDE 내장 자동완성 기능을 통한 사용 가능한 데이터의 쉬운 탐색:

| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-1.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-2.png) |
|-------------------------|-------------------------|
| ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-3.png) | ![](https://raw.githubusercontent.com/saul/demofile-net/main/assets/ide-4.png) |

## 기능

| 기능                                               | 지원 여부       |
|---------------------------------------------------|----------------|
| CSTV / GOTV 데모                                  | ✅ 완전 지원    |
| POV 데모                                          | ✅ 완전 지원    |
| HTTP 방송                                         | ✅ 완전 지원    |
| 게임 이벤트 (예: `player_death`)                   | ✅ 완전 지원    |
| 엔티티 업데이트 (플레이어 위치, 수류탄 등)          | ✅ 완전 지원    |
| 데모 내 앞으로/뒤로 탐색                            | ✅ 완전 지원    |

## 시작하기

### 설치

프로젝트에 적절한 NuGet 패키지를 추가하세요:


```bash
# For Counter-Strike 2
dotnet add package DemoFile.Game.Cs

# For Deadlock
dotnet add package DemoFile.Game.Deadlock
```
### 기본 사용법

다음은 CS2 데모에서 킬 피드 정보를 출력하는 간단한 예제입니다:


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
## 고급 예제

### 플레이어 위치 추적

데모 전반에 걸쳐 플레이어 위치 및 기타 엔티티 데이터를 추적할 수 있습니다:


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

### 게임 이벤트 작업하기

DemoFile.Net은 게임 이벤트에 대해 강력한 형식의 접근을 제공합니다:

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

### 최대 성능을 위한 병렬 처리

최대 성능을 위해 여러 CPU 코어를 사용하여 데모를 병렬로 파싱하세요:

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = DemoFileReader.Create(demo, File.OpenRead(demoPath));
await reader.ReadAllParallelAsync();  // Uses all available CPU cores
```

### HTTP 방송 지원

DemoFile.Net은 라이브 HTTP 방송을 파싱할 수 있습니다:

```c#
var demo = new CsDemoParser();
// Set up your event handlers...

var reader = HttpBroadcastReader.Create(demo, "http://localhost:8080/broadcast");
await reader.ReadAllAsync();
```
[examples/](https://github.com/saul/demofile-net/tree/main/examples) 폴더에서 더 완성도 높은 예제를 확인하세요:

- [Basic](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.Basic/Program.cs) - 간단한 데모 파싱
- [MultiThreaded](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.MultiThreaded/Program.cs) - 최대 성능을 위한 병렬 처리
- [PlayerPositions](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.PlayerPositions/Program.cs) - 플레이어 위치 및 이동 추적
- [HttpBroadcast](https://raw.githubusercontent.com/saul/demofile-net/main/./examples/DemoFile.Example.HttpBroadcast/Program.cs) - 실시간 HTTP 방송 파싱

## 벤치마크

M1 MacBook Pro에서 DemoFile.Net은 전체 경쟁 게임(약 1시간 게임 시간)을 1.3초 만에 읽을 수 있습니다.
`ReadAllParallelAsync` 메서드를 사용해 여러 스레드로 파싱할 경우 거의 500밀리초까지 단축됩니다.
여기에는 모든 엔티티 데이터(플레이어 위치, 속도, 무기 추적, 수류탄 등) 파싱이 포함됩니다.

| 메서드             |           평균 |    오류 |   표준편차 | 할당량     |
|-------------------|---------------:|---------:|---------:|----------:|
| ParseDemo         | **1,294.6 ms** |  3.68 ms |  2.88 ms | 491.48 MB |
| ParseDemoParallel |   **540.1 ms** | 23.99 ms | 22.44 ms | 600.67 MB |

## 저자 및 감사의 글

DemoFile.Net은 [Saul Rennison](https://saul.re)이 개발했습니다. 이 라이브러리 개발은
[demoparser by LaihoE](https://github.com/LaihoE/demoparser)
와 [Manta by Dotabuff](https://raw.githubusercontent.com/dotabuff/manta/master/README.md) 없이는 불가능했으며,
후자는 여러 사람들의 노력에 의존합니다:

- [Michael Fellinger](https://github.com/manveru)는 Dotabuff의 Source 1
  파서 [yasha](https://github.com/dotabuff/yasha)를 개발했습니다.
- [Robin Dietrich](https://github.com/invokr)는 C++ 파서 [Alice](https://github.com/AliceStats/Alice)를 개발했습니다.
- [Martin Schrodt](https://github.com/spheenik)는 Java 파서 [clarity](https://github.com/skadistats/clarity)를 개발했습니다.
- [Drew Schleck](https://github.com/dschleck)는 원본 C++ 파서 [edith](https://github.com/dschleck/edith)를 개발했습니다.

수정된 버전의 [Source2Gen by neverlosecc](https://github.com/neverlosecc/source2gen)가 게임 스키마 클래스 및 열거형을
정적으로 생성하는 데 사용됩니다.

라이선스 정보는 [ACKNOWLEDGEMENTS](./ACKNOWLEDGEMENTS)에서 확인하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---