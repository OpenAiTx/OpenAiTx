# KestrelApp
Przykład aplikacji programowania sieciowego oparty na Kestrel

### 1 Cel projektu
1. Zrozumienie, że programowanie sieciowe nie musi już zaczynać się od Socket
2. Zrozumienie, że programowanie sieciowe nie wymaga już zewnętrznych frameworków (w tym Dotnetty)
3. Zrozumienie programowania sieciowego typu `telnet` over `websocket` over `tls` over `xxx prywatne szyfrowanie` over `tcp`
4. Możliwość tworzenia aplikacji sieciowych na bazie KestrelFramework

### 2 Dokumentacja
**Dokumentacja wewnętrzna**: [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Dokumentacja zewnętrzna**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Podstawowe biblioteki niezbędne do programowania sieciowego w kestrel
1. Interfejsy middleware Kestrel oraz rejestracja środków pośrednich
2. System.Buffers: Klasy operujące na buforach
3. System.IO: Klasy do operacji na strumieniach
4. System.IO.Pipelines: Klasy do obsługi dwukierunkowych potoków
5. Middleware: Wybrane middleware Kestrel

### 4 KestrelApp
Aplikacja Kestrel, zawiera m.in.:
1. Konfiguracja nasłuchującego EndPoint
2. Konfiguracja protokołu używanego przez EndPoint

### 5 KestrelApp.Middleware
Biblioteka klas middleware KestrelApp
#### 5.1 Echo
Przykład prostego protokołu aplikacyjnego Echo

#### 5.2 FlowAnalyze
Przykład middleware do analizy ruchu na warstwie transportowej

#### 5.3 FlowXor
Przykład middleware do przetwarzania ruchu na warstwie transportowej za pomocą XOR

#### 5.4 HttpProxy
Przykład aplikacyjnego protokołu proxy http

#### 5.5 Telnet
Przykład prostego protokołu aplikacyjnego Telnet

#### 5.6 TelnetProxy
Przykład przekazywania ruchu do serwera telnet

#### 5.6 Redis
Serwer protokołu redis, pokazujący jak korzystać z middleware aplikacyjnego

### Open source jest lepszy dzięki Tobie
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---