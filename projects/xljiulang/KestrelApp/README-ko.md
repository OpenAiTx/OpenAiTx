# KestrelApp
Kestrel 기반 네트워크 프로그래밍 애플리케이션 예제

### 1 프로젝트 의도
1. 네트워크 프로그래밍이 더 이상 소켓(Socket)부터 시작할 필요가 없음을 이해
2. 네트워크 프로그래밍이 더 이상 서드파티 프레임워크(예: Dotnetty)를 필요로 하지 않음을 이해
3. `telnet` over `websocket` over `tls` over `xxx사설 암호화` over `tcp`의 계층적 네트워크 프로그래밍을 이해
4. KestrelFramework를 기반으로 네트워크 애플리케이션을 개발할 수 있음

### 2 문서 자료
**내부 문서**：[docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**외부 문서**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
kestrel 네트워크 프로그래밍에 필요한 몇 가지 기본 라이브러리
1. Kestrel 미들웨어 인터페이스 및 미들웨어 등록
2. System.Buffers: 버퍼 조작 클래스
3. System.IO: 스트림 조작 클래스
4. System.IO.Pipelines: 듀플렉스 파이프라인 조작 클래스
5. Middleware: kestrel의 몇 가지 미들웨어

### 4 KestrelApp
Kestrel 애플리케이션, 내용 포함
1. 리스닝 EndPoint의 구성
2. EndPoint에서 사용하는 프로토콜 구성

### 5 KestrelApp.Middleware
KestrelApp의 미들웨어 클래스 라이브러리
#### 5.1 Echo
간단한 Echo 애플리케이션 프로토콜 예제

#### 5.2 FlowAnalyze
전송 계층 트래픽 통계 미들웨어 예제

#### 5.3 FlowXor
전송 계층 트래픽 XOR 처리 미들웨어 예제

#### 5.4 HttpProxy
http 프록시 애플리케이션 프로토콜 예제

#### 5.5 Telnet
간단한 Telnet 애플리케이션 프로토콜 예제

#### 5.6 TelnetProxy
트래픽을 telnet 서버로 포워딩하는 예제

#### 5.6 Redis
redis 프로토콜 서버, 애플리케이션 미들웨어를 사용하는 방법 시연 예제

### 오픈 소스로 더 멋진 세상
![후원](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---