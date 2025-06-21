# KestrelApp
Network Programming Application Examples Based on Kestrel

### 1 Project Intent
1. Understand that network programming no longer needs to start from Socket
2. Understand that network programming no longer requires third-party frameworks (including Dotnetty)
3. Understand the "nesting doll" network programming of `telnet` over `websocket` over `tls` over `xxx private encryption` over `tcp`
4. Be able to develop network applications based on KestrelFramework

### 2 Documentation
**Internal Documentation**: [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**External Documentation**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Some essential basic libraries for kestrel network programming
1. Kestrel middleware interface and middleware registration
2. System.Buffers: Buffer operation classes
3. System.IO: Stream operation classes
4. System.IO.Pipelines: Duplex pipeline operation classes
5. Middleware: Some middleware for kestrel

### 4 KestrelApp
Kestrel application program, including
1. Configuration of listening EndPoint
2. Protocol configuration used by EndPoint

### 5 KestrelApp.Middleware
Middleware class library of KestrelApp
#### 5.1 Echo
Example of a simple Echo application protocol

#### 5.2 FlowAnalyze
Example of transport layer traffic statistics middleware

#### 5.3 FlowXor
Example of transport layer traffic XOR processing middleware

#### 5.4 HttpProxy
Example of HTTP proxy application protocol

#### 5.5 Telnet
Example of a simple Telnet application protocol

#### 5.6 TelnetProxy
Example of traffic forwarding to a telnet server

#### 5.6 Redis
Redis protocol server, demonstrating how to use application middleware

### Open Source is More Wonderful With You
![Reward](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---