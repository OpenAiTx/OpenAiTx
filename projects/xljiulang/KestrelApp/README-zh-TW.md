# KestrelApp
基於 Kestrel 的網路程式設計應用範例

### 1 專案意圖
1. 了解網路程式設計不再需要從 Socket 開始
2. 了解網路程式設計不再需要第三方框架（包括 Dotnetty）
3. 了解 `telnet` over `websocket` over `tls` over `xxx 私有加密` over `tcp` 的套娃網路程式設計
4. 能基於 KestrelFramework 開發網路應用

### 2 文件資料
**內部文件**：[docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**外部文件**
* [Pipelines](https://learn.microsoft.com/zh-tw/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-tw/dotnet/standard/io/buffers)

### 3 KestrelFramework
Kestrel 網路程式設計一些必要的基礎庫
1. Kestrel 中介軟體介面與中介註冊
2. System.Buffers: 緩衝區操作類
3. System.IO: 流的操作類
4. System.IO.Pipelines: 雙工管道操作類
5. Middleware: Kestrel 的一些中介軟體

### 4 KestrelApp
Kestrel 應用程式，內容包括
1. 監聽的 EndPoint 的配置
2. EndPoint 使用的協議配置

### 5 KestrelApp.Middleware
KestrelApp 的中介軟體類庫
#### 5.1 Echo
簡單 Echo 應用協議的範例

#### 5.2 FlowAnalyze
傳輸層流量統計中介軟體範例

#### 5.3 FlowXor
傳輸層流量異或處理的中介軟體範例

#### 5.4 HttpProxy
http 代理應用協議的範例

#### 5.5 Telnet
簡單 Telnet 應用協議的範例

#### 5.6 TelnetProxy
流量轉發到 telnet 伺服器的範例

#### 5.6 Redis
redis 協議伺服器，展示如何使用應用中介軟體的範例

### 開源有你更精彩
![打賞](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---