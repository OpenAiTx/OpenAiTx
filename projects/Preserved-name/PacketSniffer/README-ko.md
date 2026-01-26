# PacketSniffer - 실시간 네트워크 패킷 캡처 및 프로토콜 분석 도구

C# 기반으로 개발된 실시간 네트워크 패킷 캡처 도구로, 자동 프로토콜 인식, 분석 및 비즈니스 로직 분배를 지원합니다.

## 기능 특징

- 🔍 **실시간 패킷 캡처**：SharpPcap을 사용하여 네트워크 데이터 패킷을 캡처
- 🔄 **자동 프로토콜 인식**：JSON, HTTP, 이진 프로토콜 자동 인식 지원
- 📊 **스마트 분석**：프로토콜 필드 및 내용 자동 추출
- 🎯 **비즈니스 분배**：사용자 정의 비즈니스 로직 처리 지원
- 🛡️ **높은 확장성**：새로운 프로토콜 분석기 추가 용이

## 프로젝트 구조

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
## 환경 요구 사항

- .NET 6.0 이상 버전
- Windows 운영 체제(관리자 권한으로 실행 필요)
- 설치된 네트워크 어댑터

## 설치 단계

### 1. 프로젝트 클론 또는 다운로드


```bash
cd "D:\C# Project\zhuabao"
```

### 2. NuGet 종속성 복원

```bash
dotnet restore
```

### 3. 프로젝트 빌드

```bash
dotnet build
```
## 사용 방법

### 기본 실행

**중요: 반드시 관리자 권한으로 실행해야 합니다!**


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
- **DeviceKeyword**：네트워크 카드 필터 키워드(Name/Description 일치).  
  예: `"Intel"`, `"Realtek"`, `"Npcap Loopback"`, `"loopback"`. 비어 있거나 생략 시 물리 네트워크 카드를 우선 선택하며, 다음으로 Npcap Loopback을 선택합니다.
- **Ports**：감시할 포트 목록(출발지 포트 또는 목적지 포트 중 하나만 일치해도 됨). 비어 있거나 생략 시 모든 포트를 감시합니다.
- **FilterSourcePort / FilterDestinationPort**：출발지 포트 / 목적지 포트로 필터링 여부.
- **HttpPathFilters**：HTTP 요청 경로 필터 키워드, **HTTP Request**에만 적용.  
  예: `["/api/"]` 는 경로에 `/api/` 가 포함된 HTTP 요청만 출력합니다.

### 실행 흐름

1. 시작 시 `config.json`을 읽어 네트워크 카드 키워드, 감시 포트, HTTP 경로 필터 규칙을 결정합니다.
2. `DeviceKeyword`에 따라 네트워크 카드 목록에서 모호하게 매칭하여, 설정된 카드 우선 선택; 설정 없으면 물리 네트워크 카드 우선, 다음 Npcap Loopback 선택.  
   이때 콘솔에 모든 네트워크 카드를 표시하며 `[PHYSICAL]` / `[VIRTUAL]` / `[LOOPBACK]` 태그를 붙입니다.
3. 프로미스큐어스 모드(Promiscuous Mode)를 켜서 패킷을 캡처합니다.
4. 실시간으로 TCP/UDP 페이로드를 캡처하며 포트 설정(`Ports` + FilterSource/FilterDestination)에 따라 필터링합니다.
5. 프로토콜 유형 자동 인식(JsonParser → HttpParser → BinaryParser).
6. 기본 모드: HTTP Request만 처리하며 요청 라인을 분석해 `시간 + 메서드 + 경로 + 포트`를 출력, 경로 키워드 필터링 선택 가능.
7. 전체 모드(`--full`)에서는 각 패킷에 대해 `PacketInfo`를 구성, 패킷 전체 구조, 헤더 정보, 페이로드 요약을 출력.

### 프로그램 종료

`Ctrl+C`를 눌러 우아하게 종료, 프로그램은 자동으로 패킷 캡처를 중지하고 자원을 정리합니다.

## 프로토콜 분석 설명

### JSON 프로토콜 분석

- **인식 방법**：페이로드가 `{` 또는 `[` 로 시작하는지 검사
- **분석 내용**：모든 1차 필드의 키-값 쌍 추출
- **출력 형식**：`Protocol=json, Fields={key1=value1, key2=value2, ...}`

### HTTP 프로토콜 분석

- **인식 방법**：HTTP 메서드(GET/POST 등) 또는 `HTTP/1.x` 로 시작하는지 검사
- **분석 내용**：
  - HTTP 헤더(모든 헤더 필드) 분석
  - 요청 라인(Request Line) 또는 상태 라인(Status Line) 분석
  - 바디가 JSON 형식이면 JSON 필드 자동 분석
- **출력 형식**：`Protocol=http, Fields={request_line=..., header_Content-Type=..., ...}`


### 이진 프로토콜 분석

- **인식 방식**：대체 분석기로서, 인식할 수 없는 모든 프로토콜에 대해 이 분석기를 사용
- **분석 내용**：payload를 16진수 문자열로 변환
- **출력 형식**：`Protocol=binary, Fields={hex=AA BB CC DD ...}`
- **확장 팁**：`BinaryParser.cs`에 사용자 정의 프로토콜 분석 로직 추가 가능

## 비즈니스 로직 처리

현재 버전은 기본적으로 "캡처 + 분석 + 출력"만 수행하여 실제 트래픽 관찰에 용이:

- 기본 모드：HTTP 요청의 시간, 메서드, 경로 및 포트 정보만 출력.
- 전체 모드：체인 계층/IP 계층/전송 계층 정보 및 Payload 개요를 포함한 전체 `PacketInfo` 출력.
- 비즈니스 처리 진입점 `HandleBusinessLogic(ParsedResult result)`는 여전히 남아 있어, 분석 결과에 따른 사용자 정의 처리를 편리하게 수행 가능.

## 사용자 정의 확장

### 새로운 프로토콜 분석기 추가

1. `IParser` 인터페이스 구현：

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

2. `Program.cs`에서 등록:

```csharp
router.RegisterParser(new CustomParser());
```

### 확장 비즈니스 로직

`PacketRouter.cs`의 `HandleBusinessLogic()` 메서드에 사용자 정의 로직 추가:

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

## 출력 예제

### 기본 모드: HTTP 요청 경로만 출력

다음 구성(`config.json`) 예시를 사용합니다:

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

실행 출력 예시:

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

### 전체 모드: 전체 패키지 정보 출력

```bash
dotnet run -- --full
```
출력 예시(절단):


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
## 주의사항

1. **관리자 권한**: 패킷 캡처 기능은 관리자 권한이 필요하며, 그렇지 않으면 네트워크 어댑터를 열 수 없습니다.
2. **방화벽**: 일부 방화벽은 패킷 캡처 작업을 차단할 수 있습니다.
3. **성능 영향**: 대량의 네트워크 트래픽은 프로그램 성능에 영향을 줄 수 있으므로, 처리량을 줄이기 위해 포트 필터링 사용을 권장합니다.
4. **개인정보 보호**: 합법적이고 규정을 준수하는 환경에서 사용하며 타인의 개인정보를 캡처하지 마십시오.
5. **포트 필터링**: 포트 필터링을 사용하면 처리해야 할 패킷 수를 크게 줄여 성능을 향상시킬 수 있습니다.

## 문제 해결

### 문제1: 네트워크 장치를 찾을 수 없음

**오류 메시지**: `No network devices found`

**해결 방법**:
- 네트워크 어댑터 드라이버가 설치되어 있는지 확인
- 사용 가능한 네트워크 연결이 있는지 확인
- 관리자 권한으로 실행 시도

### 문제2: 장치를 열 수 없음

**오류 메시지**: `Failed to open device`

**해결 방법**:
- 관리자 권한으로 실행하는지 확인
- 다른 프로그램이 네트워크 어댑터를 사용 중인지 확인
- 프로그램 재시작 시도

### 문제3: 파싱 실패

**현상**: 일부 패킷이 파싱되지 않음

**설명**: 이는 정상적인 현상이며, 인식할 수 없는 프로토콜은 BinaryParser를 사용해 16진수 형식으로 출력됩니다.

## 기술 스택

- **.NET 6.0** - 개발 프레임워크
- **SharpPcap 6.2.5** - 네트워크 패킷 캡처 라이브러리
- **PacketDotNet 1.4.7** - 패킷 파싱 라이브러리

- **Newtonsoft.Json 13.0.3** - JSON 파싱 라이브러리

## 라이선스

본 프로젝트는 학습 및 연구용으로만 사용 가능합니다.

## 변경 로그

### v1.0.0 (2024)
- ✅ 실시간 네트워크 패킷 캡처 기능 구현
- ✅ JSON/HTTP/바이너리 프로토콜 자동 인식 지원
- ✅ 비즈니스 로직 분배 메커니즘 구현
- ✅ 우아한 종료 지원 (Ctrl+C)

## 연락처

문의 사항이나 제안이 있으면 Issue 또는 Pull Request를 제출해 주세요.

---

**⚠️ 면책 조항**: 본 도구는 학습 및 합법적인 용도로만 사용해야 하며, 사용자는 본 도구 사용으로 인한 법적 책임을 스스로 감수해야 합니다.


## 시간에 따른 스타 수
[![시간에 따른 스타 수](https://starchart.cc/Preserved-name/PacketSniffer.svg?variant=adaptive)](https://starchart.cc/Preserved-name/PacketSniffer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---