# Serveur PubChem MCP Amélioré pour Assistants IA

🧪 Un serveur MCP avancé, robuste et axé sur la confidentialité qui permet aux assistants IA de rechercher et d’accéder intelligemment aux informations sur les composés chimiques depuis PubChem.

Ce serveur PubChem MCP agit comme un puissant pont entre les assistants IA (comme ceux d’AnythingLLM) et l’immense base de données chimiques de PubChem. Il exploite le Model Context Protocol (MCP) pour permettre aux modèles IA d’effectuer des recherches intelligentes et résilientes de composés chimiques et de récupérer leurs propriétés détaillées de manière programmatique.

---

## ✨ Fonctionnalités Clés

Ce n’est pas un simple wrapper PubChem. Ce serveur a été reconstruit de zéro pour être très robuste et intelligent :

-   **🧠 Recherche de Secours Intelligente** : Si une recherche par nom commun (comme « Vitamine D ») échoue, le serveur effectue automatiquement une recherche approfondie dans la base de données Substance de PubChem pour trouver le composé correct. Cela améliore considérablement les taux de réussite pour les requêtes ambiguës.
-   **🛡️ Gestion Robuste des Erreurs & Reprises Automatiques** : Le serveur est conçu pour gérer élégamment les erreurs API. S’il rencontre une erreur « Serveur Occupé » de PubChem, il attendra automatiquement puis réessaiera la requête, garantissant le succès de vos requêtes même sous forte charge.
-   **🔒 Support Optionnel de Proxy Tor** : Vous avez un contrôle total sur votre confidentialité. Un simple fichier `config.ini` vous permet de router toutes les requêtes via le réseau Tor (via proxy SOCKS5 ou HTTP), empêchant l’exposition de votre adresse IP. Le serveur est sécurisé par défaut et ne **fuitera jamais** votre IP si la connexion proxy échoue.
-   **🔎 Recherche de Composé Unique & Multiple** : Gère sans difficulté les requêtes pour un ou plusieurs composés dans un seul prompt.
-   **🧪 Récupération Détailée des Propriétés** : Accès aux propriétés chimiques clés comme le nom IUPAC, la formule moléculaire, le poids moléculaire, et surtout, la **masse monoisotopique**.

---

---

### 🚀 Aucune Installation Requise : Essayez-le en Direct sur Smithery.ai

Pour ceux qui découvrent les serveurs MCP ou qui souhaitent simplement tester les capacités de cet outil sans installation locale, une version hébergée en direct est disponible sur Smithery.ai. Cela vous permet de discuter avec l’agent directement depuis votre navigateur.

[**<-- Explorez l’Agent PubChem en Direct sur Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Comment démarrer :**

1.  Cliquez sur le lien ci-dessus pour accéder à la page du serveur.
2.  Connectez-vous avec votre compte **GitHub** ou **Google**.
3.  Cliquez sur le bouton **« Explorer les capacités »** pour ouvrir une interface de chat et commencer les tests !

> **✅ Modèles Recommandés pour de Meilleurs Résultats**
>
> Pour obtenir la plus grande précision, notamment avec les nombres décimaux longs, nous recommandons fortement d’utiliser des modèles puissants. Les suivants ont été testés et fonctionnent parfaitement avec cet outil :
>
> *   **Claude 3 Sonnet d’Anthropic**
> *   **GPT-4 Turbo d’OpenAI** (ou versions plus récentes comme GPT-4o)
>
> Nous avons confirmé que les deux modèles ont correctement traité la pleine précision des nombres décimaux renvoyés par l'outil sans aucun arrondi.

---

## 🚀 Démarrage rapide & Installation

Ce serveur est conçu pour être exécuté localement, soit sur votre bureau soit dans l'environnement Docker AnythingLLM.

### 1. Dépendances

Ce projet repose sur quelques bibliothèques Python. Assurez-vous qu'elles sont installées dans votre environnement.

Créez un fichier `requirements.txt` avec le contenu suivant :
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Installez-les en utilisant `uv` ou `pip` :
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Remarque : `PySocks` est uniquement requis si vous prévoyez d'utiliser la fonctionnalité de proxy SOCKS5 de Tor.)*

### 2. Configuration

Le serveur est configuré via un fichier `config.ini` qui est **créé automatiquement** lors de la première exécution. Ce fichier apparaîtra dans le même répertoire que le script `pubchem_server.py`.

**`config.ini` par défaut :**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Intégration avec AnythingLLM

Suivez la documentation officielle pour ajouter ceci en tant que serveur MCP personnalisé. L'important est de pointer la `command` vers votre exécutable Python et le script `pubchem_server.py`.

**Exemple pour AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`) :**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Exemples d'implémentation avec AnythingLLM

Voici quelques exemples de la façon d'interagir avec l'agent. Ces tests ont été réalisés en utilisant AnythingLLM Desktop, en se connectant à divers grands modèles de langage via OpenRouter.

Une constatation cruciale de nos tests est l'importance du modèle que vous choisissez. Nous **déconseillons fortement l'utilisation de modèles petits ou locaux** pour cette tâche. Les modèles plus petits ont souvent du mal à analyser correctement les données renvoyées par l'outil, entraînant des erreurs telles que des valeurs hallucinées, un formatage incorrect ou, plus critique encore, **l'arrondi des nombres décimaux**, ce qui va à l'encontre de l'objectif de cet outil à haute précision.

Pour garantir l'intégrité de vos résultats, il est toujours conseillé de vérifier les données brutes renvoyées par le MCP. Vous pouvez apprendre comment faire cela dans la section suivante : [3.2 Comment vérifier les sorties MCP dans les logs](#32-comment-vérifier-les-sorties-mcp-dans-les-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

D'autre part, plusieurs modèles ont montré d'excellentes performances. Nous avons obtenu des résultats remarquables avec **le `Gemini 2.5 Flash lite` de Google**, qui a démontré une précision remarquable dans la gestion des nombres décimaux longs et un formatage correct du tableau Markdown final.

Google Gemini 2.5 Flash lite sans prompt et avec prompt conserve parfaitement les décimales (dans l'exemple, utiliser une température de 0,6)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Pour cette tâche spécifique, mon favori personnel est **`Gemini 2.5 Flash lite`** en raison de sa précision et fiabilité constantes.

### 3.2 Comment vérifier les sorties MCP dans les logs

La meilleure façon de confirmer que l'agent reçoit les bonnes données et que le LLM ne fait pas d'erreurs est de vérifier le fichier de log de débogage généré par le serveur MCP.

Ce serveur est configuré pour créer automatiquement un fichier de log dans un sous-dossier de votre répertoire de projet. L'emplacement sera :

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

À l'intérieur de `mcp_debug.log`, vous trouverez les données JSON exactes que l'outil renvoie au LLM *avant* que le modèle ne les traite. Vous pouvez inspecter manuellement ce JSON pour vérifier toutes les valeurs, en particulier les nombres décimaux longs issus de propriétés telles que `monoisotopic_mass`, afin de vous assurer que le LLM n'a introduit aucune erreur d'arrondi ou hallucination dans sa réponse finale.

---

## 📊 Utilisation

Une fois intégré, votre assistant IA utilisera automatiquement cet outil lorsqu'on lui demandera des informations chimiques. L'outil principal exposé est `search_compounds_by_name`.

### Exemple de prompt

Ce prompt démontre la capacité de l'outil à gérer une liste de composés avec différents types de noms et à récupérer plusieurs propriétés.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

L'agent appellera l'outil `search_compounds_by_name`, qui trouvera intelligemment chaque composé, récupérera ses données et les renverra au LLM pour mise en forme.

---

## 🛠 Outil MCP Exposé

### `search_compounds_by_name`

Recherche plusieurs composés par nom, un par un, en utilisant une stratégie de repli intelligente avec pauses et tentatives pour une fiabilité maximale.

**Paramètres :**
-   `names` (List[str]) : Une liste de noms de composés. Exemple : `["Aspirine", "Ibuprofène"]`

**Retourne :** Une liste de dictionnaires, où chaque dictionnaire contient soit les informations du composé trouvé, soit un message d'erreur expliquant pourquoi la recherche a échoué pour ce composé spécifique.

---

## 🙏 Remerciements

Ce projet a été fortement inspiré par et construit sur la base de l'original [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) créé par **JackKuo666**.

Bien que ce dépôt ne soit pas un fork direct, le projet original a été le point de départ crucial. Cette version améliore le concept original en mettant l'accent sur une robustesse extrême, des stratégies de recherche intelligentes et la confidentialité des utilisateurs via une intégration optionnelle de Tor 🧅.

Un grand merci à l'auteur original pour son travail fantastique et pour le partage avec la communauté.

---

## ⚠️ Avertissement

Cet outil est destiné à des fins de recherche et d'éducation. Veuillez respecter les conditions d'utilisation de PubChem et utiliser cet outil de manière responsable.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---