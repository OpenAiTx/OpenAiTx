# KestrelApp
Exemples d'applications de programmation réseau basées sur Kestrel

### 1 Objectif du projet
1. Comprendre que la programmation réseau n'a plus besoin de commencer par Socket
2. Comprendre que la programmation réseau n'a plus besoin de frameworks tiers (y compris Dotnetty)
3. Comprendre la programmation réseau en "poupées russes" : `telnet` sur `websocket` sur `tls` sur `xxx chiffrement privé` sur `tcp`
4. Être capable de développer des applications réseau basées sur KestrelFramework

### 2 Documentation
**Documentation interne** : [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Documentation externe**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Quelques bibliothèques de base nécessaires à la programmation réseau avec kestrel
1. Interface de middleware Kestrel et enregistrement intermédiaire
2. System.Buffers : classes d'opérations sur les buffers
3. System.IO : classes d'opérations sur les flux
4. System.IO.Pipelines : classes d'opérations sur les pipelines duplex
5. Middleware : quelques middlewares de kestrel

### 4 KestrelApp
Application Kestrel, contenu comprenant :
1. Configuration des EndPoints à écouter
2. Configuration des protocoles utilisés par les EndPoints

### 5 KestrelApp.Middleware
Bibliothèque de classes middleware de KestrelApp
#### 5.1 Echo
Exemple de protocole d'application Echo simple

#### 5.2 FlowAnalyze
Exemple de middleware de statistiques de flux au niveau transport

#### 5.3 FlowXor
Exemple de middleware de traitement xor du flux au niveau transport

#### 5.4 HttpProxy
Exemple de protocole d'application proxy http

#### 5.5 Telnet
Exemple de protocole d'application Telnet simple

#### 5.6 TelnetProxy
Exemple de redirection de flux vers un serveur telnet

#### 5.6 Redis
Serveur de protocole redis, démonstration de l'utilisation de middleware applicatif

### L'open source est plus passionnant avec vous
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---