# PacketSniffer - Outil de capture de paquets réseau en temps réel et d'analyse de protocoles

Un outil de capture de paquets réseau en temps réel développé en C#, prenant en charge la reconnaissance automatique des protocoles, l'analyse et la distribution de la logique métier.

## Fonctionnalités

- 🔍 **Capture en temps réel** : Utilisation de SharpPcap pour la capture des paquets réseau  
- 🔄 **Reconnaissance automatique des protocoles** : Prise en charge de JSON, HTTP, et protocoles binaires  
- 📊 **Analyse intelligente** : Extraction automatique des champs et contenus des protocoles  
- 🎯 **Distribution métier** : Prise en charge du traitement personnalisé de la logique métier  
- 🛡️ **Grande extensibilité** : Facilité d’ajout de nouveaux analyseurs de protocoles  

## Structure du projet

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

## Exigences environnementales

- .NET 6.0 ou version supérieure
- Système d'exploitation Windows (exécution avec privilèges administratifs requise)
- Adaptateur réseau installé

## Étapes d'installation

### 1. Cloner ou télécharger le projet

```bash
cd "D:\C# Project\zhuabao"
```

### 2. Restauration des dépendances NuGet

```bash
dotnet restore
```

### 3. Construction du projet

```bash
dotnet build
```

## Mode d'emploi

### Exécution de base

**Important : Doit être exécuté avec les droits administrateur !**

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
- **DeviceKeyword**：Mot-clé de filtrage de la carte réseau (correspond au Nom/Description).  
  Par exemple `"Intel"`, `"Realtek"`, `"Npcap Loopback"`, `"loopback"`. S'il est vide ou omis, la carte physique est sélectionnée en priorité, suivie de Npcap Loopback.
- **Ports**：Liste des ports écoutés (correspond à n'importe quel port source ou destination). S'il est vide ou omis, tous les ports sont écoutés.
- **FilterSourcePort / FilterDestinationPort**：Filtrer selon le port source / port destination.
- **HttpPathFilters**：Mots-clés de filtrage du chemin de requête HTTP, uniquement pour les **requêtes HTTP**.  
  Par exemple `["/api/"]` signifie que seules les requêtes HTTP contenant `/api/` dans le chemin seront affichées.

### Processus d'exécution

1. Au démarrage, lire `config.json` pour déterminer : mot-clé de la carte réseau, ports d'écoute, règles de filtrage du chemin HTTP.
2. Faire un filtrage flou dans la liste des cartes réseau selon `DeviceKeyword`, en sélectionnant prioritairement la carte configurée ; sinon choisir automatiquement en priorité la carte physique, puis Npcap Loopback.  
   La console affichera alors toutes les cartes réseau avec les étiquettes `[PHYSICAL]` / `[VIRTUAL]` / `[LOOPBACK]`.
3. Activer le mode promiscuité (Promiscuous Mode) pour la capture.
4. Capturer en temps réel les payloads des paquets TCP/UDP et filtrer selon la configuration de ports (`Ports` + FilterSource/FilterDestination).
5. Reconnaissance automatique du type de protocole (JsonParser → HttpParser → BinaryParser).
6. En mode par défaut : traiter uniquement les requêtes HTTP, analyser la ligne de requête et afficher `heure + méthode + chemin + port`, avec option de filtrage par mot-clé de chemin.
7. En mode complet (`--full`) : construire pour chaque paquet un `PacketInfo` et afficher la structure complète du paquet, les informations d'en-tête et un résumé du payload.

### Arrêt du programme

Appuyer sur `Ctrl+C` pour quitter proprement, le programme arrêtera automatiquement la capture et nettoiera les ressources.

## Explication de l'analyse des protocoles

### Analyse du protocole JSON

- **Méthode de reconnaissance** : vérifier si le payload commence par `{` ou `[`
- **Contenu analysé** : extraire toutes les paires clé-valeur du premier niveau
- **Format de sortie** : `Protocol=json, Fields={key1=value1, key2=value2, ...}`

### Analyse du protocole HTTP

- **Méthode de reconnaissance** : vérifier si cela commence par une méthode HTTP (GET/POST etc.) ou `HTTP/1.x`
- **Contenu analysé** :
  - Analyse des en-têtes HTTP (tous les champs d'en-tête)
  - Analyse de la ligne de requête ou de la ligne d'état
  - Si le corps est au format JSON, analyse automatique des champs JSON
- **Format de sortie** : `Protocol=http, Fields={request_line=..., header_Content-Type=..., ...}`


### Analyse du protocole binaire

- **Mode de reconnaissance** : En tant qu'analyseur de secours, tous les protocoles non reconnus utiliseront cet analyseur  
- **Contenu de l'analyse** : Convertir la charge utile en chaîne hexadécimale  
- **Format de sortie** : `Protocol=binary, Fields={hex=AA BB CC DD ...}`  
- **Conseil d'extension** : Vous pouvez ajouter une logique d'analyse de protocole personnalisée dans `BinaryParser.cs`  

## Traitement de la logique métier

La version actuelle effectue par défaut uniquement la « capture + analyse + affichage », pour faciliter l'observation du trafic réel :  

- En mode par défaut : seuls l'heure, la méthode, le chemin et le port de la requête HTTP sont affichés.  
- En mode complet : affiche le `PacketInfo` complet, incluant les informations des couches liaison/IP/transport ainsi qu’un résumé de la charge utile.  
- Le point d'entrée du traitement métier `HandleBusinessLogic(ParsedResult result)` est toujours conservé, facilitant un traitement personnalisé basé sur les résultats d’analyse.  

## Extension personnalisée

### Ajouter un nouvel analyseur de protocole

1. Implémentez l’interface `IParser` :

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
2. Enregistrer dans `Program.cs` :


```csharp
router.RegisterParser(new CustomParser());
```

### Logique métier étendue

Ajoutez une logique personnalisée dans la méthode `HandleBusinessLogic()` de `PacketRouter.cs` :

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

## Exemple de sortie

### Mode par défaut : n’imprimer que le chemin des requêtes HTTP

Utilisez la configuration suivante (exemple `config.json`) :

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

Exemple de sortie d'exécution :

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
### Mode complet : imprimer les informations complètes du paquet


```bash
dotnet run -- --full
```
Exemple de sortie (troncature) :


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
## Remarques importantes

1. **Droits administrateur** : La fonction de capture nécessite des droits administrateur, sinon il est impossible d'ouvrir l'adaptateur réseau  
2. **Pare-feu** : Certains pare-feu peuvent bloquer les opérations de capture  
3. **Impact sur les performances** : Un volume important de trafic réseau peut affecter les performances du programme, il est conseillé d'utiliser un filtrage par port pour réduire la charge  
4. **Confidentialité et sécurité** : Veuillez vous assurer d'utiliser dans un environnement légal et conforme, ne pas capturer de données privées d'autrui  
5. **Filtrage par port** : L'utilisation d'un filtrage par port peut réduire significativement le nombre de paquets à traiter, améliorant ainsi les performances  

## Dépannage

### Problème 1 : Aucun périphérique réseau trouvé

**Message d'erreur** : `No network devices found`

**Solution** :  
- Assurez-vous que les pilotes de l'adaptateur réseau sont installés  
- Vérifiez la présence d'une connexion réseau disponible  
- Essayez d'exécuter avec les droits administrateur  

### Problème 2 : Impossible d'ouvrir le périphérique

**Message d'erreur** : `Failed to open device`

**Solution** :  
- Assurez-vous d'exécuter en mode administrateur  
- Vérifiez qu'aucun autre programme n'occupe l'adaptateur réseau  
- Essayez de redémarrer le programme  

### Problème 3 : Échec de l'analyse

**Symptôme** : Certains paquets ne peuvent pas être analysés  

**Explication** : C'est normal, les protocoles non reconnus sont affichés en format hexadécimal via BinaryParser  

## Stack technique

- **.NET 6.0** - Framework de développement  
- **SharpPcap 6.2.5** - Bibliothèque de capture réseau  
- **PacketDotNet 1.4.7** - Bibliothèque d'analyse de paquets  

- **Newtonsoft.Json 13.0.3** - Bibliothèque d'analyse JSON

## Licence

Ce projet est uniquement destiné à l'apprentissage et à la recherche.

## Journal des modifications

### v1.0.0 (2024)
- ✅ Mise en œuvre de la capture réseau en temps réel
- ✅ Prise en charge de la détection automatique des protocoles JSON/HTTP/binaire
- ✅ Mise en place d'un mécanisme de distribution de la logique métier
- ✅ Support de la sortie élégante (Ctrl+C)

## Contact

Pour toute question ou suggestion, veuillez soumettre un Issue ou une Pull Request.

---

**⚠️ Avertissement** : Cet outil est destiné uniquement à des fins d'apprentissage et d'utilisation légale, l'utilisateur assume l'entière responsabilité légale de son utilisation.


## Étoiles au fil du temps
[![Étoiles au fil du temps](https://starchart.cc/Preserved-name/PacketSniffer.svg?variant=adaptive)](https://starchart.cc/Preserved-name/PacketSniffer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-28

---