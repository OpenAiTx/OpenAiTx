# PacketSniffer - Real-time Network Packet Capture and Protocol Analysis Tool

A real-time network packet capture tool developed in C#, supporting automatic protocol recognition, parsing, and business logic dispatch.

## Features

- 🔍 **Real-time Capture**: Uses SharpPcap for network packet capture
- 🔄 **Automatic Protocol Recognition**: Supports automatic recognition of JSON, HTTP, and binary protocols
- 📊 **Intelligent Parsing**: Automatically extracts protocol fields and content
- 🎯 **Business Dispatch**: Supports custom business logic processing
- 🛡️ **Highly Extensible**: Easy to add new protocol parsers

## Project Structure

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

## Environment Requirements

- .NET 6.0 or higher
- Windows operating system (requires administrator privileges)
- Installed network adapter

## Installation Steps

### 1. Clone or download the project

```bash
cd "D:\C# Project\zhuabao"
```

### 2. Restore NuGet Dependencies

```bash
dotnet restore
```

### 3. Building the Project

```bash
dotnet build
```

## Usage

### Basic Operation

**Important: Must be run with administrator privileges!**

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
- **DeviceKeyword**: Network card filter keyword (matches Name/Description).  
  For example, `"Intel"`, `"Realtek"`, `"Npcap Loopback"`, `"loopback"`. If empty or omitted, physical network cards are prioritized, followed by Npcap Loopback.
- **Ports**: List of listening ports (matches source or destination port). If empty or omitted, all ports are listened to.
- **FilterSourcePort / FilterDestinationPort**: Whether to filter by source port / destination port.
- **HttpPathFilters**: HTTP request path filtering keywords, effective only for **HTTP Request**.  
  For example, `["/api/"]` means only printing HTTP requests whose paths contain `/api/`.

### Running Process

1. On startup, read `config.json` to determine: network card keyword, listening ports, HTTP path filtering rules.
2. Fuzzy match the network card list based on `DeviceKeyword`, prioritizing the configured network card; if not configured, automatically prioritize physical network cards, then Npcap Loopback.  
   The console will list all network cards and mark them `[PHYSICAL]` / `[VIRTUAL]` / `[LOOPBACK]`.
3. Enable promiscuous mode for packet capture.
4. Capture TCP/UDP packet payloads in real time and filter according to port configuration (`Ports` + FilterSource/FilterDestination).
5. Automatically recognize protocol type (JsonParser → HttpParser → BinaryParser).
6. In default mode: only process HTTP Requests, parse the request line and print `time + method + path + port`, optionally filter by path keywords.
7. In full mode (`--full`): build `PacketInfo` for each packet, print full packet structure, header info, and payload summary.

### Stopping the Program

Press `Ctrl+C` to exit gracefully; the program will automatically stop capturing and clean up resources.

## Protocol Parsing Description

### JSON Protocol Parsing

- **Recognition method**: Check if payload starts with `{` or `[`
- **Parsing content**: Extract all first-level field key-value pairs
- **Output format**: `Protocol=json, Fields={key1=value1, key2=value2, ...}`

### HTTP Protocol Parsing

- **Recognition method**: Check if it starts with HTTP methods (GET/POST, etc.) or `HTTP/1.x`
- **Parsing content**:
  - Parse HTTP Headers (all header fields)
  - Parse Request Line or Status Line
  - If Body is JSON format, automatically parse JSON fields
- **Output format**: `Protocol=http, Fields={request_line=..., header_Content-Type=..., ...}`


### Binary Protocol Parsing

- **Identification method**: Used as the fallback parser; all unrecognized protocols will use this parser  
- **Parsing content**: Converts the payload into a hexadecimal string  
- **Output format**: `Protocol=binary, Fields={hex=AA BB CC DD ...}`  
- **Extension tip**: Custom protocol parsing logic can be added in `BinaryParser.cs`  

## Business Logic Processing

The current version by default only performs "capture + parse + print" to help you observe actual traffic:  

- In default mode: only prints the HTTP Request time, method, path, and port information.  
- In full mode: prints the complete `PacketInfo`, including link layer/IP layer/transport layer information and payload summary.  
- The business processing entry `HandleBusinessLogic(ParsedResult result)` is still reserved for you to perform custom processing based on parsing results later.  

## Custom Extensions

### Adding a New Protocol Parser

1. Implement the `IParser` interface:

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

2. Register in `Program.cs`:

```csharp
router.RegisterParser(new CustomParser());
```

### Extended Business Logic

Add custom logic in the `HandleBusinessLogic()` method of `PacketRouter.cs`:

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

## Output Example

### Default Mode: Print Only HTTP Request Paths

Use the following configuration example (`config.json`):

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

Example of running output:

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

### Full Mode: Print Complete Package Information

```bash
dotnet run -- --full
```

Output Example (Truncated):

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
## Notes

1. **Administrator Privileges**: Packet capture requires administrator privileges; otherwise, network adapters cannot be opened.  
2. **Firewall**: Some firewalls may block packet capture operations.  
3. **Performance Impact**: Large amounts of network traffic may affect program performance; it is recommended to use port filtering to reduce processing load.  
4. **Privacy and Security**: Please ensure use in a legal and compliant environment; do not capture others' private data.  
5. **Port Filtering**: Using port filtering can significantly reduce the number of packets processed and improve performance.  

## Troubleshooting

### Issue 1: Network Device Not Found

**Error Message**: `No network devices found`  

**Solution**:  
- Ensure network adapter drivers are installed.  
- Check if there is an available network connection.  
- Try running with administrator privileges.  

### Issue 2: Cannot Open Device

**Error Message**: `Failed to open device`  

**Solution**:  
- Ensure running with administrator privileges.  
- Check if other programs are occupying the network adapter.  
- Try restarting the program.  

### Issue 3: Parsing Failure

**Symptom**: Some packets cannot be parsed.  

**Explanation**: This is normal; unrecognized protocols will be output in hexadecimal format using BinaryParser.  

## Technology Stack

- **.NET 6.0** - Development framework  
- **SharpPcap 6.2.5** - Network packet capture library  
- **PacketDotNet 1.4.7** - Packet parsing library

- **Newtonsoft.Json 13.0.3** - JSON parsing library

## License

This project is for learning and research purposes only.

## Changelog

### v1.0.0 (2024)
- ✅ Implemented real-time network packet capture functionality
- ✅ Supports automatic recognition of JSON/HTTP/binary protocols
- ✅ Implemented business logic dispatch mechanism
- ✅ Supports graceful exit (Ctrl+C)

## Contact

If you have any questions or suggestions, please submit an Issue or Pull Request.

---

**⚠️ Disclaimer**: This tool is for learning and legal use only. Users are responsible for any legal consequences arising from the use of this tool.


## Stargazers over time
[![Stargazers over time](https://starchart.cc/Preserved-name/PacketSniffer.svg?variant=adaptive)](https://starchart.cc/Preserved-name/PacketSniffer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-28

---