# Chrome Debloat

Un outil pour générer des politiques pour les navigateurs basés sur Chromium (Chrome, Brave et Edge) qui désactivent les fonctionnalités inutiles, la télémétrie et les logiciels superflus tout en activant certaines améliorations de qualité de vie.

## Fonctionnalités

- Tente de désactiver la télémétrie et le rapport d’utilisation
- Supprime les fonctionnalités inutiles et les logiciels superflus préinstallés
- Bloque le contenu promotionnel et les éléments d’interface utilisateur inutiles
- Maintient la fonctionnalité du navigateur tout en réduisant l’utilisation des ressources
- Préconfigure les extensions essentielles :
  - uBlock Origin
  - Cookie AutoDelete
  - Don't f*** with paste
  - I still don't care about cookies
  - SponsorBlock
  - BlockTube
  - BlankTab
  - Decentraleyes

### Navigateurs pris en charge

| Navigateur | Windows | macOS | Linux |
|------------|---------|-------|-------|
| Google Chrome | ✅ | ✅ | ✅ |
| Microsoft Edge | ✅ | ✅ | ✅ |
| Brave | ✅ | ✅ | ✅ |

## Démarrage rapide

### Windows
1.  Téléchargez le fichier `.reg` pour votre navigateur depuis [`generated/windows/`](./generated/windows/).
2.  Ouvrez le fichier `.reg` téléchargé pour ajouter les paramètres au Registre Windows.
3.  Redémarrez votre navigateur ou allez sur `chrome://policy` (ou `edge://policy`, `brave://policy`) et cliquez sur « Recharger les politiques ».

### macOS
1.  Téléchargez le fichier `.mobileconfig` pour votre navigateur depuis [`generated/macos/`](./generated/macos/).
2.  Ouvrez le fichier `.mobileconfig` téléchargé pour lancer l’installation du profil.
3.  Allez dans `Réglages Système` > `Confidentialité et sécurité` > `Profils` et approuvez le nouveau profil.
4.  Redémarrez votre navigateur ou allez sur `chrome://policy` (ou `edge://policy`, `brave://policy`) et cliquez sur « Recharger les politiques ».

### Linux
1.  Téléchargez le fichier `.json` pour votre navigateur depuis [`generated/linux/`](./generated/linux/).
2.  Déplacez le fichier téléchargé dans le répertoire de politique approprié (créez-le si nécessaire) :
    *   **Chrome :** `/etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge :** `/etc/opt/edge/policies/managed/edge.json`
    *   **Brave :** `/etc/brave/policies/managed/brave.json`
    *   *Remarque : Vous pourriez avoir besoin des droits `sudo` pour cela.*
3.  Redémarrez votre navigateur ou allez sur `chrome://policy` (ou `edge://policy`, `brave://policy`) et cliquez sur "Recharger les politiques".

## Configuration personnalisée

Si vous souhaitez personnaliser les politiques :

1. Clonez ce dépôt
2. Installez les dépendances :
   ```bash
   uv sync
   ```
3. Modifiez `policies.yaml` selon vos besoins  
4. Générez de nouveaux fichiers de configuration :
   ```bash
   uv run main.py
   ```
5. Trouvez les fichiers générés dans le répertoire `generated/`


### Désinstallation des politiques

**Windows :**
1.  Naviguez vers le répertoire [`uninstall/windows/`](./uninstall/) dans ce dépôt.
2.  Exécutez le fichier `.reg` correspondant à votre navigateur (par exemple, `uninstall_chrome.reg`). Cela supprimera les clés de registre ajoutées lors de l'installation.
3.  Redémarrez votre navigateur ou allez sur `chrome://policy` (ou `edge://policy`, `brave://policy`) et cliquez sur "Reload policies".

**macOS :**
1.  Allez dans `Réglages Système` > `Confidentialité et sécurité` > `Profils`.
2.  Sélectionnez le profil associé à votre navigateur (par exemple, "Chrome Debloat Policies").
3.  Cliquez sur le bouton '-' (moins) pour supprimer le profil.
4.  Redémarrez votre navigateur ou allez sur `chrome://policy` (ou `edge://policy`, `brave://policy`) et cliquez sur "Reload policies".

**Linux :**
1.  Supprimez le fichier JSON de politique dans le répertoire spécifique au navigateur (vous pourriez avoir besoin des droits `sudo`) :
    *   **Chrome :** `sudo rm /etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge :** `sudo rm /etc/opt/edge/policies/managed/edge.json`
    *   **Brave :** `sudo rm /etc/brave/policies/managed/brave.json`
2.  Redémarrez votre navigateur ou allez sur `chrome://policy` (ou `edge://policy`, `brave://policy`) et cliquez sur "Reload policies".

## Documentation des politiques

- [Politiques Chrome Enterprise](https://chromeenterprise.google/policies/)
- [Politiques Brave](https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy)
- [Politiques Microsoft Edge](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies)

## Licence

[Apache 2.0](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---