# 🧠 Proxy Cursor DeepSeek V4

> **Correction en un clic de l'erreur `reasoning_content` lors de l'utilisation de DeepSeek V4 avec Cursor, fini le `Rate limit exceeded`, pour un fonctionnement stable du mode Agent IA.**

[![GitHub stars](https://img.shields.io/github/stars/你的用户名/cursor-deepseek-v4-proxy?style=social)](https://github.com/你的用户名/cursor-deepseek-v4-proxy)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📌 Quels problèmes ce projet peut-il résoudre ?

Si vous rencontrez fréquemment l’une des erreurs suivantes lors de l’appel de DeepSeek V4 (Pro / Flash) dans Cursor :

* `Provider returned error: The reasoning_content in the thinking mode must be passed back to the API.`
* `User API Key Rate limit exceeded` (alors que le quota est encore largement disponible)
* `AI Model Not Found: deepseek-v4-pro` (le nom du modèle est invalide dans les tâches en arrière-plan)
* Premier tour de chat normal, deuxième tour commence à générer des erreurs ou des interruptions

**Plus besoin de galérer, suivez ce guide 5 minutes et c’est réglé.**

> ⚠️  **Correction du 14-05-2026** : le modèle texte brut filtre désormais automatiquement les images, résolvant l’erreur 502. Voir [journal des modifications](#changelog)

---

## ✨ Fonctionnalités principales

* ✅ **Mise en cache automatique & renvoi de la chaîne de raisonnement** : plus d’erreur liée à l’absence de `reasoning_content`.
* ✅ **Limitation intelligente** : seau de jetons intégré, évitant les pics de requêtes qui saturent la limite gratuite.
* ✅ **Support de sortie en flux continu** : sans impacter l’effet machine à écrire de Cursor.
* ✅ **Script de démarrage en un clic** : compatible Windows / macOS / Linux, double-cliquez pour lancer.
* ✅ **Logs transparents** : affichage en temps réel des statuts de requête dans le terminal, pour faciliter le débogage.
* ✅ **Zéro intrusion** : aucune modification des fichiers du programme Cursor, seul l’URL de base est modifiée.

---

## 🖥️ Environnements compatibles

| Système d’exploitation | Support |
| :--- | :--- |
| **Windows 10 / 11** | ✅ Supporté |
| **macOS** | ✅ Pris en charge |
| **Linux** | ✅ Pris en charge |

> **Exigence unique** : Installez **Python 3.8** ou une version ultérieure (assurez-vous de cocher `Add Python to PATH` lors de l'installation).

---

## 🚀 Guide détaillé en trois étapes (pour débutants)

### Étape 1 : Télécharger le projet et installer les dépendances

1.  Téléchargez le fichier ZIP du dépôt du projet, décompressez-le localement (**le chemin ne doit pas contenir de caractères chinois**).
2.  Accédez au dossier décompressé, tapez `cmd` dans la barre d'adresse du dossier et appuyez sur Entrée pour ouvrir la fenêtre de commande.
3.  Exécutez la commande suivante pour installer les dépendances :
    ```bash
    pip install -r requirements.txt
    ```
    *Si le message `pip n'est pas une commande interne` apparaît, veuillez réinstaller Python en cochant `Add to PATH`.*

### Étape 2 : Démarrer le proxy local + le tunnel

Vous avez besoin d'un tunnel pour générer une adresse publique (Cursor limite l'accès à localhost).

#### 🪟 Utilisateurs Windows
1.  Assurez-vous que le dossier contient `cloudflared-windows-amd64.exe` (sinon, téléchargez-le sur le [site officiel de Cloudflare](https://github.com/cloudflare/cloudflared/releases)).
2.  Double-cliquez pour lancer **`start_proxy.bat`**.
3.  Deux fenêtres vont s’ouvrir. Dans la **fenêtre du tunnel**, trouvez une adresse `https://xxx.trycloudflare.com` et **copiez-la**.

#### 🍎 Utilisateurs macOS / Linux
1.  Ouvrez un terminal dans le répertoire du projet et exécutez :
    ```bash
    bash start_proxy.sh
    ```
2.  Attendez un instant, copiez l'adresse `https://xxx.trycloudflare.com` affichée dans le terminal.

> ⚠️ **Attention** : La fenêtre ne doit pas être fermée. L'adresse du tunnel change à chaque redémarrage, elle reste valide tant que la fenêtre reste ouverte.

### Troisième étape : configurer Cursor

1.  Ouvrez les paramètres de Cursor : appuyez sur `Ctrl+Shift+P` → tapez `Cursor Settings`.
2.  Allez dans l’onglet **Models**.
3.  Dans **"Override OpenAI Base URL"**, collez l’adresse copiée précédemment, **en ajoutant `/v1` à la fin** :
    * Par exemple : `https://xxxxxx.trycloudflare.com/v1`
4.  Saisissez votre **clé API DeepSeek** dans le champ API Key.
5.  **Fermez complètement et redémarrez Cursor**.

---

## 🛡️ Résoudre l’erreur "Model name not valid"

Si une erreur survient lors de l’exécution d’Apply ou d’une tâche en arrière-plan, procédez comme suit :

1.  Appuyez sur `Ctrl+Shift+P`, tapez `Preferences: Open User Settings (JSON)` puis validez.
2.  Ajoutez la configuration suivante entre les accolades `{}` du fichier JSON :
    ```json
    "cursor.models": {
        "deepseek-v4-pro": {
            "provider": "openai",
            "apiBase": "[https://你的隧道地址.trycloudflare.com/v1](https://你的隧道地址.trycloudflare.com/v1)",
            "apiKey": "你的DeepSeek API Key"
        }
    }
    ```
3.  Enregistrez et redémarrez Cursor.

---

## ❓ Questions fréquentes (FAQ)

<details>
<summary>🔁 Que faire si l'adresse du tunnel change ?</summary>
Chaque redémarrage du script génère une nouvelle adresse. Il vous suffit de récupérer la nouvelle adresse et de la mettre à jour dans l'URL de base de Cursor.
</details>

<details>
<summary>💸 Toujours le message "Rate limit exceeded" ?</summary>
Le niveau gratuit de DeepSeek a une fréquence très basse. Vous pouvez éditer `proxy.py` et réduire le `5` dans `TokenBucket(rate=5/60.0, capacity=5)` (par exemple à `3`) pour forcer une fréquence de requêtes plus basse.
</details>

<details>
<summary>🚫 Le tunnel est-il obligatoire ? Peut-on se connecter en localhost ?</summary>
Pour des raisons de sécurité, Cursor interdit la connexion directe à `localhost`. Cloudflare Tunnel est actuellement la solution la plus simple, gratuite et sans inscription pour le tunneling.
</details>

<details>
<summary>🧪 Le proxy affecte-t-il l’intelligence du modèle ?</summary>
Dans 99% des cas, cela passe inaperçu. Le proxy complète automatiquement la chaîne de pensée lorsque le modèle "oublie" de la renvoyer, garantissant une conversation fluide.
</details>

<details>
<summary>🧪 Pourquoi seulement 200k context et pas 1M ?</summary>
C’est la limite par défaut de Cursor, ce n’est pas un problème du proxy.

Cursor utilise par défaut une fenêtre de contexte de 200k.
Pour activer le support du contexte 1M du modèle, il faut activer le `Max Mode` dans Cursor Chat.
Chemin :
Chat -> Sélecteur de modèle -> Max Mode
</details>

---

## ⚙️ Personnalisation avancée

* **Changer l'upstream** : modifier `UPSTREAM_URL` dans `proxy.py`.
* **Nom de domaine fixe** : si vous avez votre propre domaine, vous pouvez configurer un tunnel nommé Cloudflare (Tunnel Persistant).

<a name="changelog"></a>
## 🆕 Journal des modifications

### 2026-05-14 : Correction de la compatibilité des images dans le modèle texte pur

**Contenu de la correction**
Lorsque des clients comme Cursor envoient des messages contenant des images à `deepseek-v4-pro` (modèle texte pur), la couche proxy filtre désormais automatiquement les blocs `image_url`, ne conservant que la partie texte. Si un message est entièrement composé d’images (sans texte), il est remplacé par un texte d’avertissement, évitant que le modèle reçoive un message vide.
Cette correction résout l’erreur 502 causée par l’API DeepSeek retournant `"unknown variant image_url, expected text"`.

**Améliorations supplémentaires**

- Uniformisation du format de retour des erreurs upstream, le client reçoit désormais une erreur JSON structurée (et non plus une erreur brute ou une page blanche).
- La logique de compatibilité des images n’affecte pas le cache d’inférence (`reasoning_content`), le traitement des messages historiques reste normal.

------

### Remerciements

Merci à [@BG-ah](https://github.com/BG-ah) pour avoir signalé le problème de limitation de débit dans l’issue [#4](https://github.com/wustghj/cursor-deepseek-v4-proxy/issues/4), ainsi qu’à [@CH-nolyn](https://github.com/CH-nolyn) pour sa participation aux discussions. Vos retours ont directement permis cette correction de compatibilité, rendant le proxy plus stable avec le modèle texte pur.

------

> 💡 **Conseil** : si vous souhaitez que le modèle comprenne réellement le contenu des images, modifiez le champ `model` dans la requête en `deepseek-chat` qui supporte le multimodal, et assurez-vous que votre compte DeepSeek a les permissions nécessaires.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---