# PacketSniffer - リアルタイムネットワークキャプチャとプロトコル解析ツール

C# をベースに開発されたリアルタイムネットワークキャプチャツールで、自動プロトコル識別、解析、業務ロジックの分配をサポートします。

## 機能特徴

- 🔍 **リアルタイムキャプチャ**：SharpPcap を使用したネットワークパケットのキャプチャ
- 🔄 **自動プロトコル識別**：JSON、HTTP、バイナリプロトコルの自動識別をサポート
- 📊 **スマート解析**：プロトコルフィールドと内容の自動抽出
- 🎯 **業務分配**：カスタム業務ロジック処理をサポート
- 🛡️ **高い拡張性**：新しいプロトコル解析器の追加が容易

## プロジェクト構成

```
PacketSniffer/
├── PacketSniffer.csproj      # 项目配置文件
├── Program.cs                 # 程序入口
├── Core/
│   ├── Sniffer.cs            # 抓包核心模块
│   └── PacketRouter.cs       # 数据包路由分发器
├── Parsers/
│   ├── IParser.cs            # 解析器接口
│   ├── JsonParser.cs         # JSON 协议解析器
│   ├── HttpParser.cs         # HTTP 协议解析器
│   └── BinaryParser.cs       # 二进制协议解析器（兜底）
└── Models/
    └── ParsedResult.cs       # 解析结果数据模型
```

## 環境要件

- .NET 6.0 以上
- Windows オペレーティングシステム（管理者権限での実行が必要）
- インストール済みのネットワークアダプター

## インストール手順

### 1. プロジェクトのクローンまたはダウンロード

```bash
cd "D:\C# Project\zhuabao"
```

### 2. NuGet 依存関係の復元

```bash
dotnet restore
```
### 3. プロジェクトの構築


```bash
dotnet build
```

## 使用方法

### 基本运行

**重要：必ず管理者権限で実行してください！**

```bash
# 默认模式：只打印 HTTP Request 的时间 + 方法 + 路径
dotnet run

# 完整模式：打印完整数据包信息（包含 IP/MAC/端口/Body 等）
dotnet run -- --full

# 先构建后运行
dotnet build
dotnet bin/Debug/net6.0/PacketSniffer.exe
```

### 配置文件 `config.json`

所有需要手动调整的内容都集中在根目录的 `config.json`，程序运行时会从 **exe 所在目录** 读取该文件。

示例：

```json
{
  "DeviceKeyword": "loopback",
  "Ports": [5005],
  "FilterSourcePort": true,
  "FilterDestinationPort": true,
  "HttpPathFilters": [
    "/api/"
  ]
}
```
- **DeviceKeyword**：ネットワークカードのフィルターキーワード（Name/Descriptionにマッチ）。  
  例えば `"Intel"`、`"Realtek"`、`"Npcap Loopback"`、`"loopback"`。空または省略時は物理ネットワークカードを優先的に選択し、次に Npcap Loopback を選択します。
- **Ports**：監視するポートのリスト（送信元ポートまたは宛先ポートのいずれかにマッチすればよい）。空または省略時は全ポートを監視します。
- **FilterSourcePort / FilterDestinationPort**：送信元ポート / 宛先ポートでフィルタリングするかどうか。
- **HttpPathFilters**：HTTPリクエストパスのフィルターキーワード。**HTTP Request** のみ有効。  
  例えば `["/api/"]` はパスに `/api/` を含むHTTPリクエストのみを表示します。

### 実行フロー

1. 起動時に `config.json` を読み込み、ネットワークカードキーワード、監視ポート、HTTPパスフィルターのルールを決定します。
2. `DeviceKeyword` に基づきネットワークカードリストから曖昧一致で選択し、設定がなければ物理ネットワークカードを優先し、次に Npcap Loopback を選択します。  
   この時点でコンソールに全てのネットワークカードが `[PHYSICAL]` / `[VIRTUAL]` / `[LOOPBACK]` のラベル付きで表示されます。
3. プロミスキャスモード（Promiscuous Mode）を有効にしてパケットキャプチャを開始します。
4. TCP/UDPパケットのペイロードをリアルタイムにキャプチャし、ポート設定（`Ports` + FilterSource/FilterDestination）に基づいてフィルタリングします。
5. プロトコルタイプを自動識別します（JsonParser → HttpParser → BinaryParser）。
6. デフォルトモードでは：HTTPリクエストのみ処理し、リクエストラインを解析して `時間 + メソッド + パス + ポート` を表示し、パスキーワードによるフィルタも可能です。
7. フルモード（`--full`）では：各パケットに対して `PacketInfo` を構築し、完全なパケット構造、ヘッダー情報、ペイロードの概要を表示します。

### プログラム停止

`Ctrl+C` を押すと正常終了し、プログラムは自動的にキャプチャを停止しリソースを解放します。

## プロトコル解析説明

### JSON プロトコル解析

- **識別方法**：ペイロードが `{` または `[` で始まるかをチェック
- **解析内容**：トップレベルの全フィールドのキーと値を抽出
- **出力フォーマット**：`Protocol=json, Fields={key1=value1, key2=value2, ...}`

### HTTP プロトコル解析

- **識別方法**：HTTPメソッド（GET/POSTなど）や `HTTP/1.x` で始まるかをチェック
- **解析内容**：
  - HTTPヘッダー（全ヘッダー項目）を解析
  - リクエストラインまたはステータスラインを解析
  - ボディがJSON形式の場合は自動的にJSONフィールドを解析
- **出力フォーマット**：`Protocol=http, Fields={request_line=..., header_Content-Type=..., ...}`


### バイナリプロトコル解析

- **識別方法**：フォールバック解析器として、認識できないすべてのプロトコルはこの解析器を使用します
- **解析内容**：ペイロードを16進数の文字列に変換します
- **出力形式**：`Protocol=binary, Fields={hex=AA BB CC DD ...}`
- **拡張ヒント**：`BinaryParser.cs` にカスタムプロトコル解析ロジックを追加可能です

## ビジネスロジック処理

現バージョンでは「キャプチャ＋解析＋表示」のみをデフォルトで行い、実際のトラフィックを観察しやすくしています：

- デフォルトモード：HTTPリクエストの時間、メソッド、パス、ポート情報のみを表示します。
- フルモード：リンク層/IP層/トランスポート層情報およびペイロード概要を含む完全な `PacketInfo` を表示します。
- ビジネス処理のエントリポイント `HandleBusinessLogic(ParsedResult result)` は残してあり、解析結果に応じたカスタム処理を後で追加しやすくしています。

## カスタム拡張

### 新しいプロトコル解析器の追加

1. `IParser` インターフェースを実装する：

```csharp
public class CustomParser : IParser
{
    public bool CanParse(byte[] payload)
    {
        // 判断逻辑
        return false;
    }

    public ParsedResult Parse(byte[] payload)
    {
        // 解析逻辑
        return new ParsedResult { ... };
    }
}
```

2. `Program.cs` に登録します：

```csharp
router.RegisterParser(new CustomParser());
```

### 拡張ビジネスロジック

`PacketRouter.cs` の `HandleBusinessLogic()` メソッドにカスタムロジックを追加します：

```csharp
private void HandleBusinessLogic(ParsedResult result)
{
    // 添加你的业务逻辑
    if (result.Fields.ContainsKey("yourKey"))
    {
        // 处理逻辑
    }
}
```

## 出力例

### デフォルトモード：HTTPリクエストパスのみを表示

以下の設定（`config.json`）の例を使用します：

```json
{
  "DeviceKeyword": "loopback",
  "Ports": [5005],
  "FilterSourcePort": true,
  "FilterDestinationPort": true,
  "HttpPathFilters": [
    "/api/"
  ]
}
```

実行出力例：

```text
=== Packet Sniffer - Protocol Parse Mode ===
已加载配置文件: C:\...\bin\Debug\net6.0\config.json
端口过滤: 已启用，监听端口: 5005
过滤模式: 源端口=True, 目标端口=True
网卡关键字: "loopback"（将优先匹配 Name/Description）
HTTP 路径过滤已启用，关键字列表：
  - /api/

Using device (from config/auto): Npcap Loopback Adapter
Packet capture started. Press Ctrl+C to stop.

======================================================================================================================
[2025-12-01 16:30:12.345] GET /api/user/123  (src:52345 -> dst:5005)
======================================================================================================================
[2025-12-01 16:30:13.001] POST /api/order/create  (src:52346 -> dst:5005)
```

### フルモード：完全なパケット情報を表示

```bash
dotnet run -- --full
```
出力例（切り捨て）：


```text
================================================================================
数据包捕获时间: 2025-12-01 16:31:00.123
--------------------------------------------------------------------------------
数据包长度: 1500 字节
链路层类型: Ethernet
源 MAC 地址: AA:BB:CC:DD:EE:FF
目标 MAC 地址: 11:22:33:44:55:66

网络层协议: IPv4Packet
IP 版本: IPv4
源 IP 地址: 192.168.1.100
目标 IP 地址: 192.168.1.1
TTL: 64

传输层协议: TCP
源端口: 52345
目标端口: 5005
TCP 标志: Syn, Ack

Payload 长度: 256 字节
Payload (十六进制):
0000: 47 45 54 20 2F 61 70 69 2F 75 73 65 72 2F 31 32 | GET /api/user/12
...
================================================================================
```
## 注意事項

1. **管理者権限**：パケットキャプチャ機能は管理者権限が必要で、そうでなければネットワークアダプターを開けません
2. **ファイアウォール**：一部のファイアウォールはパケットキャプチャ操作を阻止する可能性があります
3. **パフォーマンス影響**：大量のネットワークトラフィックはプログラムのパフォーマンスに影響を与えるため、ポートフィルタリングの使用を推奨します
4. **プライバシーと安全性**：合法かつ適切な環境で使用し、他人のプライバシーデータをキャプチャしないでください
5. **ポートフィルタリング**：ポートフィルタリングを使用すると処理するパケット数を大幅に減らし、パフォーマンスを向上させます

## トラブルシューティング

### 問題1：ネットワークデバイスが見つからない

**エラーメッセージ**：`No network devices found`

**解決策**：
- ネットワークアダプターのドライバーがインストールされていることを確認する
- 利用可能なネットワーク接続があるか確認する
- 管理者権限で実行してみる

### 問題2：デバイスを開けない

**エラーメッセージ**：`Failed to open device`

**解決策**：
- 管理者権限で実行していることを確認する
- 他のプログラムがネットワークアダプターを使用していないか確認する
- プログラムを再起動してみる

### 問題3：解析失敗

**現象**：一部のパケットが解析できない

**説明**：これは正常な現象で、認識できないプロトコルは BinaryParser により16進数形式で出力されます

## 技術スタック

- **.NET 6.0** - 開発フレームワーク
- **SharpPcap 6.2.5** - ネットワークキャプチャライブラリ
- **PacketDotNet 1.4.7** - パケット解析ライブラリ

- **Newtonsoft.Json 13.0.3** - JSON解析ライブラリ

## ライセンス

本プロジェクトは学習および研究目的のみに使用してください。

## 更新履歴

### v1.0.0 (2024)
- ✅ リアルタイムネットワークパケットキャプチャ機能を実装
- ✅ JSON/HTTP/バイナリプロトコルの自動識別に対応
- ✅ ビジネスロジックのディスパッチ機構を実装
- ✅ 優雅な終了（Ctrl+C）に対応

## 連絡先

ご質問やご提案がありましたら、IssueまたはPull Requestを提出してください。

---

**⚠️ 免責事項**：本ツールは学習および合法的な用途のみに使用してください。使用に伴う法的責任は利用者自身が負うものとします。


## Stargazers over time
[![Stargazers over time](https://starchart.cc/Preserved-name/PacketSniffer.svg?variant=adaptive)](https://starchart.cc/Preserved-name/PacketSniffer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---