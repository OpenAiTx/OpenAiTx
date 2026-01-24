# PacketSniffer - 实时网络抓包与协议解析工具

一个基于 C# 开发的实时网络抓包工具，支持自动协议识别、解析和业务逻辑分发。

## 功能特性

- 🔍 **实时抓包**：使用 SharpPcap 进行网络数据包捕获
- 🔄 **自动协议识别**：支持 JSON、HTTP、二进制协议自动识别
- 📊 **智能解析**：自动提取协议字段和内容
- 🎯 **业务分发**：支持自定义业务逻辑处理
- 🛡️ **扩展性强**：易于添加新的协议解析器

## 项目结构

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

## 环境要求

- .NET 6.0 或更高版本
- Windows 操作系统（需要管理员权限运行）
- 已安装的网络适配器

## 安装步骤

### 1. 克隆或下载项目

```bash
cd "D:\C# Project\zhuabao"
```

### 2. 恢复 NuGet 依赖

```bash
dotnet restore
```

### 3. 构建项目

```bash
dotnet build
```

## 使用方法

### 基本运行

**重要：必须以管理员权限运行！**

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
- **DeviceKeyword**：网卡筛选关键字（匹配 Name/Description）。  
  例如 `"Intel"`、`"Realtek"`、`"Npcap Loopback"`、`"loopback"`。为空或省略时，将自动选择物理网卡优先，其次 Npcap Loopback。
- **Ports**：监听的端口列表（源端口或目标端口任一匹配即可）。为空或省略时，监听所有端口。
- **FilterSourcePort / FilterDestinationPort**：是否按源端口 / 目标端口进行过滤。
- **HttpPathFilters**：HTTP 请求路径过滤关键字，仅对 **HTTP Request** 生效。  
  例如 `["/api/"]` 表示只打印路径中包含 `/api/` 的 HTTP 请求。

### 运行流程

1. 启动时读取 `config.json`，确定：网卡关键字、监听端口、HTTP 路径过滤规则。
2. 根据 `DeviceKeyword` 从网卡列表中模糊匹配，优先选择配置指定的网卡；若未配置则自动选择物理网卡优先，其次 Npcap Loopback。  
   此时控制台会列出所有网卡并标注 `[PHYSICAL]` / `[VIRTUAL]` / `[LOOPBACK]`。
3. 开启混杂模式（Promiscuous Mode）进行抓包。
4. 实时捕获 TCP/UDP 包的 payload，并根据端口配置 (`Ports` + FilterSource/FilterDestination) 做过滤。
5. 自动识别协议类型（JsonParser → HttpParser → BinaryParser）。
6. 默认模式下：只处理 HTTP Request，解析请求行并打印 `时间 + 方法 + 路径 + 端口`，可选按路径关键字过滤。
7. 完整模式（`--full`）下：对每个包构建 `PacketInfo`，打印完整的包结构、头部信息和 Payload 摘要。

### 停止程序

按 `Ctrl+C` 优雅退出，程序会自动停止抓包并清理资源。

## 协议解析说明

### JSON 协议解析

- **识别方式**：检查 payload 是否以 `{` 或 `[` 开头
- **解析内容**：提取所有一级字段的键值对
- **输出格式**：`Protocol=json, Fields={key1=value1, key2=value2, ...}`

### HTTP 协议解析

- **识别方式**：检查是否以 HTTP 方法（GET/POST等）或 `HTTP/1.x` 开头
- **解析内容**：
  - 解析 HTTP Headers（所有 header 字段）
  - 解析 Request Line 或 Status Line
  - 如果 Body 是 JSON 格式，自动解析 JSON 字段
- **输出格式**：`Protocol=http, Fields={request_line=..., header_Content-Type=..., ...}`


### 二进制协议解析

- **识别方式**：作为兜底解析器，所有无法识别的协议都会使用此解析器
- **解析内容**：将 payload 转换为十六进制字符串
- **输出格式**：`Protocol=binary, Fields={hex=AA BB CC DD ...}`
- **扩展提示**：可在 `BinaryParser.cs` 中添加自定义协议解析逻辑

## 业务逻辑处理

当前版本默认只做“捕获 + 解析 + 打印”，便于你观察实际流量：

- 默认模式下：只打印 HTTP Request 的时间、方法、路径和端口信息。
- 完整模式下：打印完整 `PacketInfo`，包括链路层/IP 层/传输层信息及 Payload 概要。
- 业务处理入口 `HandleBusinessLogic(ParsedResult result)` 仍然保留，方便你后续按解析结果做自定义处理。

## 自定义扩展

### 添加新的协议解析器

1. 实现 `IParser` 接口：

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
2. 在 `Program.cs` 中注册：


```csharp
router.RegisterParser(new CustomParser());
```

### 扩展业务逻辑

在 `PacketRouter.cs` 的 `HandleBusinessLogic()` 方法中添加自定义逻辑：

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

## 输出示例

### 默认模式：只打印 HTTP 请求路径

使用如下配置（`config.json`）示例：

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

运行输出示例：

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

### 完整模式：打印完整包信息

```bash
dotnet run -- --full
```

Output example (truncated):

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
## 注意事项

1. **管理员权限**：抓包功能需要管理员权限，否则无法打开网络适配器
2. **防火墙**：某些防火墙可能会阻止抓包操作
3. **性能影响**：大量网络流量可能会影响程序性能，建议使用端口过滤减少处理量
4. **隐私安全**：请确保在合法合规的环境中使用，不要抓取他人隐私数据
5. **端口过滤**：使用端口过滤可以显著减少处理的数据包数量，提高性能

## 故障排除

### 问题1：找不到网络设备

**错误信息**：`No network devices found`

**解决方案**：
- 确保已安装网络适配器驱动
- 检查是否有可用的网络连接
- 尝试以管理员权限运行

### 问题2：无法打开设备

**错误信息**：`Failed to open device`

**解决方案**：
- 确保以管理员权限运行
- 检查是否有其他程序占用网络适配器
- 尝试重启程序

### 问题3：解析失败

**现象**：某些数据包无法解析

**说明**：这是正常现象，无法识别的协议会使用 BinaryParser 输出十六进制格式

## 技术栈

- **.NET 6.0** - 开发框架
- **SharpPcap 6.2.5** - 网络抓包库
- **PacketDotNet 1.4.7** - 数据包解析库

- **Newtonsoft.Json 13.0.3** - JSON 解析库

## 许可证

本项目仅供学习和研究使用。

## 更新日志

### v1.0.0 (2024)
- ✅ 实现实时网络抓包功能
- ✅ 支持 JSON/HTTP/二进制协议自动识别
- ✅ 实现业务逻辑分发机制
- ✅ 支持优雅退出（Ctrl+C）

## 联系方式

如有问题或建议，请提交 Issue 或 Pull Request。

---

**⚠️ 免责声明**：本工具仅供学习和合法用途使用，使用者需自行承担使用本工具所产生的法律责任。


## Stargazers over time
[![Stargazers over time](https://starchart.cc/Preserved-name/PacketSniffer.svg?variant=adaptive)](https://starchart.cc/Preserved-name/PacketSniffer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---