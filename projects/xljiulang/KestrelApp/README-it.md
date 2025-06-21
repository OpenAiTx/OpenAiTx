# KestrelApp
Esempi di applicazioni di programmazione di rete basate su Kestrel

### 1 Scopo del Progetto
1. Comprendere che la programmazione di rete non richiede più di partire dai Socket
2. Comprendere che la programmazione di rete non richiede più framework di terze parti (incluso Dotnetty)
3. Comprendere la programmazione di rete a "matrioska": `telnet` su `websocket` su `tls` su `xxx crittografia proprietaria` su `tcp`
4. Essere in grado di sviluppare applicazioni di rete basate su KestrelFramework

### 2 Documentazione
**Documentazione interna**: [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Documentazione esterna**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Alcune librerie di base necessarie per la programmazione di rete con kestrel
1. Interfacce dei middleware in Kestrel e registrazione dei middleware
2. System.Buffers: Classe per operazioni sui buffer
3. System.IO: Classe per operazioni sui flussi
4. System.IO.Pipelines: Classe per operazioni sui canali duplex
5. Middleware: Alcuni middleware di kestrel

### 4 KestrelApp
Applicazione Kestrel, il contenuto include
1. Configurazione dell'EndPoint in ascolto
2. Configurazione del protocollo utilizzato dall'EndPoint

### 5 KestrelApp.Middleware
Libreria di classi middleware di KestrelApp
#### 5.1 Echo
Esempio di protocollo applicativo Echo semplice

#### 5.2 FlowAnalyze
Esempio di middleware per la statistica del traffico a livello di trasporto

#### 5.3 FlowXor
Esempio di middleware per l'elaborazione XOR del traffico a livello di trasporto

#### 5.4 HttpProxy
Esempio di protocollo applicativo proxy http

#### 5.5 Telnet
Esempio di protocollo applicativo Telnet semplice

#### 5.6 TelnetProxy
Esempio di inoltro del traffico verso un server telnet

#### 5.6 Redis
Server di protocollo redis, esempio che mostra come utilizzare i middleware applicativi

### L'open source è più emozionante con il tuo contributo
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---