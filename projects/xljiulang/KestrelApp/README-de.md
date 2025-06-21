# KestrelApp
Beispielanwendungen für Netzwerkprogrammierung basierend auf Kestrel

### 1 Projektziele
1. Verstehen, dass Netzwerkprogrammierung nicht mehr bei Sockets beginnen muss
2. Verstehen, dass für Netzwerkprogrammierung keine Drittanbieter-Frameworks (einschließlich Dotnetty) mehr benötigt werden
3. Verstehen von `telnet` über `websocket` über `tls` über `xxx Private Encryption` über `tcp` als verschachtelte Netzwerkprogrammierung
4. In der Lage sein, Netzwerkapplikationen basierend auf dem KestrelFramework zu entwickeln

### 2 Dokumentation
**Interne Dokumentation**: [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Externe Dokumentation**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Einige notwendige Basisbibliotheken für die Kestrel-Netzwerkprogrammierung
1. Kestrel-Middleware-Schnittstelle und Middleware-Registrierung
2. System.Buffers: Klassen zur Pufferverwaltung
3. System.IO: Klassen zur Stream-Verarbeitung
4. System.IO.Pipelines: Klassen zur Duplex-Pipeline-Verarbeitung
5. Middleware: Verschiedene Kestrel-Middleware-Komponenten

### 4 KestrelApp
Kestrel-Anwendungen, einschließlich:
1. Konfiguration der zu überwachenden Endpunkte (EndPoints)
2. Protokollkonfiguration für die jeweiligen Endpunkte

### 5 KestrelApp.Middleware
Middleware-Bibliothek für KestrelApp

#### 5.1 Echo
Beispiel für ein einfaches Echo-Anwendungsprotokoll

#### 5.2 FlowAnalyze
Beispiel für Middleware zur Statistik des Transportdatenverkehrs

#### 5.3 FlowXor
Beispiel für Middleware zur XOR-Verarbeitung des Transportdatenverkehrs

#### 5.4 HttpProxy
Beispiel für ein HTTP-Proxy-Anwendungsprotokoll

#### 5.5 Telnet
Beispiel für ein einfaches Telnet-Anwendungsprotokoll

#### 5.6 TelnetProxy
Beispiel für Weiterleitung des Datenverkehrs zu einem Telnet-Server

#### 5.6 Redis
Redis-Protokollserver, Beispiel zur Demonstration der Verwendung von Anwendungsmiddleware

### Open Source ist mit dir noch besser
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---