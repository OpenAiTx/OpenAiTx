# CreamLinux

CreamLinux est une application GUI pour Linux qui simplifie la gestion des IDs DLC dans les jeux Steam. Elle offre une interface conviviale pour installer et configurer CreamAPI (pour les jeux Linux natifs) et SmokeAPI (pour les jeux Windows exécutés via Proton).

## Regardez la démo ici :

[![Regardez la démo](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/./src/assets/screenshot1.png)](https://www.youtube.com/watch?v=neUDotrqnDM)

## Statut Beta

⚠️ **IMPORTANT** : CreamLinux est actuellement en BÊTA. Cela signifie :

- Certaines fonctionnalités peuvent être incomplètes ou susceptibles d’être modifiées
- Vous pourriez rencontrer des bugs ou des comportements inattendus
- L’application est en développement actif
- Vos retours et rapports de bugs sont précieux

Bien que la fonctionnalité principale fonctionne, veuillez noter qu’il s’agit d’une version précoce. Je travaille continuellement à améliorer la stabilité, ajouter des fonctionnalités et améliorer l’expérience utilisateur. Merci de signaler tout problème rencontré sur la [page GitHub Issues](https://github.com/Novattz/creamlinux-installer/issues).

## Fonctionnalités

- **Découverte automatique** : Trouve automatiquement les jeux Steam installés sur votre système
- **Support natif** : Installe CreamLinux pour les jeux Linux natifs
- **Support Proton** : Installe SmokeAPI pour les jeux Windows exécutés via Proton
- **Gestion des DLC** : Sélection facile des DLC à activer
- **Interface moderne** : Interface propre, réactive et facile à utiliser

## Installation

### AppImage (Recommandé)

1. Téléchargez la dernière version de `creamlinux.AppImage` depuis la page [Releases](https://github.com/Novattz/creamlinux-installer/releases)
2. Rendez-le exécutable :
   ```bash
   chmod +x creamlinux.AppImage
   ```
3. Exécutez-le :

   ```bash
   ./creamlinux.AppImage
   ```
   Pour les utilisateurs Nvidia, utilisez cette commande :


   ```
   WEBKIT_DISABLE_DMABUF_RENDERER=1 ./creamlinux.AppImage
   ```

### Compilation à partir des sources

#### Prérequis

- Rust 1.77.2 ou version ultérieure
- Node.js 18 ou version ultérieure
- webkit2gtk-4.1 (libwebkit2gtk-4.1 pour debian)
- npm ou yarn

#### Étapes

1. Clonez le dépôt :

   ```bash
   git clone https://github.com/Novattz/creamlinux-installer.git
   cd creamlinux-installer
   ```

2. Installer les dépendances :

   ```bash
   npm install # or yarn
   ```

3. Construisez l'application :

   ```bash
   NO_STRIP=true npm run tauri build
   ```

4. Le binaire compilé sera disponible dans `src-tauri/target/release/creamlinux`

### Intégration au bureau

Si vous utilisez la version AppImage, vous pouvez l'intégrer à votre environnement de bureau :

1. Créez un fichier d'entrée pour le bureau :

   ```bash
   mkdir -p ~/.local/share/applications
   ```
2. Créez `~/.local/share/applications/creamlinux.desktop` avec le contenu suivant (ajustez le chemin vers votre AppImage) :


   ```
   [Desktop Entry]
   Name=Creamlinux
   Exec=/absolute/path/to/CreamLinux.AppImage
   Icon=/absolute/path/to/creamlinux-icon.png
   Type=Application
   Categories=Game;Utility;
   Comment=DLC Manager for Steam games on Linux
   ```

3. Mettez à jour votre base de données de bureau afin que creamlinux apparaisse dans votre lanceur d'applications :

```bash
update-desktop-database ~/.local/share/applications
```

## Dépannage

### Problèmes courants

- **Le jeu ne se lance pas** : Assurez-vous que les options de lancement sont correctement définies dans Steam
- **Les DLC ne s'affichent pas** : Essayez de rafraîchir la liste des jeux et de réinstaller
- **Steam introuvable** : Vérifiez que Steam est installé et que vous l'avez lancé au moins une fois

### Journaux de débogage

Les journaux sont stockés dans : `~/.cache/creamlinux/creamlinux.log`

## Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/LICENSE.md) pour plus de détails.

## Crédits

- [Creamlinux](https://github.com/anticitizn/creamlinux) - Support natif
- [SmokeAPI](https://github.com/acidicoala/SmokeAPI) - Support Proton
- [Tauri](https://tauri.app/) - Cadre pour la création de l'application de bureau
- [React](https://reactjs.org/) - Bibliothèque d'interface utilisateur


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---