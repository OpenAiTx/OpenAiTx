# CunZhi 🛑

> **Le "terminateur d’éjaculation précoce" des dialogues IA, pour des échanges qui durent jusqu’au bout**

Vous en avez assez que votre assistant IA mette fin à la conversation trop tôt ? Alors qu’il reste tant à discuter, il vous demande déjà : "Avez-vous besoin d’autre chose ?" **CunZhi** règle ce problème une bonne fois pour toutes !

Quand l’IA veut "expédier la discussion", CunZhi affiche une fenêtre de dialogue au bon moment, vous permettant de poursuivre l’échange en profondeur, jusqu’à la résolution complète de vos problèmes.

## 🌟 Fonctionnalités principales

- 🛑 **Interception intelligente** : Affichage automatique d’options de poursuite lorsque l’IA veut conclure
- 🧠 **Gestion de la mémoire** : Stockage des normes de développement et préférences par projet
- 🎨 **Interaction élégante** : Prise en charge Markdown, multiples modes de saisie
- ⚡ **Prêt à l’emploi** : Installation en 3 secondes, support multiplateforme

## 📸 Aperçu du résultat

### 🛑 Fenêtre d’interception intelligente
![Démonstration de la fenêtre pop-up CunZhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Lorsque l’IA souhaite mettre fin à la conversation, la fenêtre intelligente de CunZhi s’affiche instantanément, proposant des options prédéfinies pour poursuivre l’échange en profondeur*
### ⚙️ Interface de gestion des paramètres
![Interface des paramètres de Cunzhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Interface de paramètres élégante, prenant en charge la gestion de la mémoire, les commutateurs de fonctionnalités, le changement de thème et la génération intelligente de prompts*

## 🚀 Commencer à utiliser

### Méthode 1 : Installation rapide (recommandée)

**Utilisateurs macOS :**
```bash
# Installation en 3 secondes, pas besoin d'attendre la compilation
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Dépannage** : Si vous rencontrez une erreur de téléchargement 404, veuillez effectuer les étapes suivantes :
>
> ```bash
> # Effacer l'ancien cache du tap
> brew untap imhuso/cunzhi
> # Réinstaller
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Exemple d’erreur courante :**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Ceci est généralement dû à un problème de cache de version précédente entraînant une incompatibilité de numéro de version. Effacez le tap puis réinstallez pour résoudre le problème.

**Utilisateurs Windows/Linux :**
Il est recommandé d’utiliser la méthode 2 pour un téléchargement manuel, simple et rapide !
### Méthode 2 : Téléchargement manuel

1. Rendez-vous sur la [page des Releases](https://github.com/imhuso/cunzhi/releases)
2. Téléchargez la version correspondant à votre système :
   - 🐧 **Linux** : `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)** : `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)** : `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows** : `cunzhi-cli-v*-windows-x86_64.zip`

3. Après extraction, ajoutez `寸止` et `等一下` au PATH du système

## ⚡ Démarrage rapide

### Première étape : Configurer le client MCP

Ajoutez ceci au fichier de configuration de votre client MCP (par exemple Claude Desktop) :

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Deuxième étape : Ouvrir l’interface des paramètres

```bash
# Exécuter la commande de configuration
Attendez un instant
```

### Troisième étape : Configurer les prompts

Dans l’onglet "Prompts de référence" de l’interface des paramètres :
1. Consultez les prompts générés automatiquement
2. Cliquez sur le bouton de copie
3. Ajoutez les prompts à votre assistant IA

### Quatrième étape : Commencer à utiliser

Votre assistant IA dispose maintenant de fonctions d’interception intelligente, de gestion de la mémoire et d’interaction par fenêtres contextuelles !

> 💡 **Astuce** : Vous pouvez personnaliser les prompts générés pour créer une expérience d’interaction IA sur mesure.
## 🤝 Participer et contribuer

Cunzhi est un projet open source, nous accueillons toutes les formes de contribution !

### 🐛 Vous avez trouvé un problème ?
- [Soumettre un Issue](https://github.com/imhuso/cunzhi/issues) pour décrire le problème
- Fournir les étapes de reproduction et les informations sur l'environnement

### 💡 Vous avez une bonne idée ?
- [Lancer une discussion](https://github.com/imhuso/cunzhi/discussions) pour partager votre idée
- Soumettre une Pull Request pour implémenter une nouvelle fonctionnalité

### 🛠️ Développement local
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Contactez-nous

- 🐛 **Signaler un problème** : [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Discussion sur les fonctionnalités** : [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Vous aimez le projet** : Donnez-nous une étoile pour nous soutenir !

## 📄 Licence Open Source

Licence MIT - Utilisation libre, contributions bienvenues !

---

<div align="center">

**Dites adieu à "l'éjaculation précoce" des dialogues IA | Que chaque échange aille jusqu'au bout**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Signaler un bug](https://github.com/imhuso/cunzhi/issues) · [💡 Demander une fonctionnalité](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---