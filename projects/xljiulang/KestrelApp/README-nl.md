# KestrelApp
Voorbeeld van netwerkprogrammering op basis van Kestrel

### 1 Projectdoel
1. Begrijpen dat netwerkprogrammering niet meer bij Socket hoeft te beginnen
2. Begrijpen dat netwerkprogrammering geen externe frameworks meer nodig heeft (inclusief Dotnetty)
3. Begrijpen van `telnet` over `websocket` over `tls` over `xxx private encryptie` over `tcp` als een "matroesjka" netwerkprogrammeringsstructuur
4. In staat zijn om netwerkapplicaties te ontwikkelen op basis van het KestrelFramework

### 2 Documentatie
**Interne documentatie**: [docs](docs)

**Externe documentatie**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Enkele noodzakelijke basisbibliotheken voor Kestrel-netwerkprogrammering
1. Kestrel middleware-interface en -registratie
2. System.Buffers: Klasse voor bufferbewerkingen
3. System.IO: Klasse voor streambewerkingen
4. System.IO.Pipelines: Klasse voor duplexpijplijnbewerkingen
5. Middleware: Enkele middleware van Kestrel

### 4 KestrelApp
Kestrel-applicatie, inhoud omvat:
1. Configuratie van te beluisteren EndPoints
2. Protocolconfiguratie voor EndPoints

### 5 KestrelApp.Middleware
Middleware-bibliotheek van KestrelApp
#### 5.1 Echo
Voorbeeld van een eenvoudig Echo applicatieprotocol

#### 5.2 FlowAnalyze
Voorbeeld van middleware voor verkeerstatistieken op transportlaag

#### 5.3 FlowXor
Voorbeeld van middleware voor XOR-verwerking van verkeer op transportlaag

#### 5.4 HttpProxy
Voorbeeld van http-proxyapplicatieprotocol

#### 5.5 Telnet
Voorbeeld van een eenvoudig Telnet applicatieprotocol

#### 5.6 TelnetProxy
Voorbeeld van verkeerdoorsturen naar een telnetserver

#### 5.6 Redis
Redis-protocolserver, voorbeeld van het gebruik van applicatiemiddleware

### Open source is mooier met jou
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---