# KestrelApp
Kestrelベースのネットワークプログラミング応用例

### 1 プロジェクトの目的
1. ネットワークプログラミングがもはやSocketから始める必要がないことを理解する
2. ネットワークプログラミングがもはやサードパーティフレームワーク（Dotnettyを含む）を必要としないことを理解する
3. `telnet` over `websocket` over `tls` over `xxx私有加密` over `tcp`のマトリョーシカ型ネットワークプログラミングを理解する
4. KestrelFrameworkに基づいてネットワークアプリケーションを開発できるようにする

### 2 ドキュメント資料
**内部ドキュメント**：[docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**外部ドキュメント**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
kestrelネットワークプログラミングのためのいくつかの必須基礎ライブラリ
1. Kestrelミドルウェアインターフェイスとミドルウェア登録
2. System.Buffers: バッファ操作クラス
3. System.IO: ストリーム操作クラス
4. System.IO.Pipelines: デュプレックスパイプライン操作クラス
5. Middleware: kestrelのいくつかのミドルウェア

### 4 KestrelApp
Kestrelアプリケーション、内容は以下を含む
1. 監視するEndPointの設定
2. EndPointで使用するプロトコルの設定

### 5 KestrelApp.Middleware
KestrelAppのミドルウェアライブラリ
#### 5.1 Echo
シンプルなEchoアプリケーションプロトコルの例

#### 5.2 FlowAnalyze
トランスポート層トラフィック統計ミドルウェアの例

#### 5.3 FlowXor
トランスポート層トラフィックXOR処理ミドルウェアの例

#### 5.4 HttpProxy
httpプロキシアプリケーションプロトコルの例

#### 5.5 Telnet
シンプルなTelnetアプリケーションプロトコルの例

#### 5.6 TelnetProxy
トラフィックをtelnetサーバーに転送する例

#### 5.6 Redis
redisプロトコルサーバー、アプリケーションミドルウェアの使い方を示す例

### オープンソースはあなたと共により素晴らしく
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---