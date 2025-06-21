# KestrelApp
Exemplo de aplicação de programação de rede baseada em Kestrel

### 1 Objetivo do Projeto
1. Entender que a programação de rede não precisa mais começar pelo Socket
2. Entender que a programação de rede não precisa mais de frameworks de terceiros (incluindo Dotnetty)
3. Compreender a programação de rede “matrioska”: `telnet` sobre `websocket` sobre `tls` sobre `xxx criptografia privada` sobre `tcp`
4. Ser capaz de desenvolver aplicações de rede baseadas no KestrelFramework

### 2 Documentação
**Documentação interna**: [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Documentação externa**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Algumas bibliotecas básicas necessárias para programação de rede com kestrel
1. Interface de middleware do Kestrel e registro intermediário
2. System.Buffers: Classe de operações de buffer
3. System.IO: Classe de operações de fluxo
4. System.IO.Pipelines: Classe de operações de canal duplex
5. Middleware: Alguns middlewares do kestrel

### 4 KestrelApp
Aplicação Kestrel, inclui
1. Configuração do EndPoint de escuta
2. Configuração do protocolo usado pelo EndPoint

### 5 KestrelApp.Middleware
Biblioteca de classes de middleware do KestrelApp
#### 5.1 Echo
Exemplo de protocolo de aplicação Echo simples

#### 5.2 FlowAnalyze
Exemplo de middleware para estatísticas de tráfego na camada de transporte

#### 5.3 FlowXor
Exemplo de middleware para processamento de tráfego XOR na camada de transporte

#### 5.4 HttpProxy
Exemplo de protocolo de aplicação proxy http

#### 5.5 Telnet
Exemplo de protocolo de aplicação Telnet simples

#### 5.6 TelnetProxy
Exemplo de encaminhamento de tráfego para servidor telnet

#### 5.6 Redis
Servidor de protocolo redis, demonstra como usar middlewares de aplicação

### O open source é mais brilhante com você
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---