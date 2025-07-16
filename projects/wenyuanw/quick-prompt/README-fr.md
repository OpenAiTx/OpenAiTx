# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Logo Quick Prompt" width="128" style="background: transparent;">
</p>

Une puissante extension de navigateur, axée sur la gestion des prompts et la saisie rapide. Elle aide les utilisateurs à créer, gérer et organiser une bibliothèque de prompts, et à insérer rapidement du contenu prédéfini dans n'importe quel champ de saisie sur le web, améliorant ainsi l'efficacité du travail.

> Comme les extensions de navigateur ne fonctionnent que sur le web, un [plugin Raycast](https://github.com/wenyuanw/quick-prompt-raycast) open source, aux fonctionnalités identiques et compatible avec le format de données de l’extension, est également proposé. La migration sans couture via le même fichier JSON est prise en charge.

## ✨ Fonctionnalités

- 📚 **Gestion des prompts** : créez, éditez et gérez facilement votre bibliothèque de prompts
- 🚀 **Saisie rapide** : déclenchez rapidement le sélecteur de prompts dans n'importe quel champ de saisie web via `/p`
- ⌨️ Prise en charge des raccourcis clavier pour ouvrir le sélecteur de prompts & sauvegarder du texte sélectionné comme prompt
- 📑 Prise en charge de la sauvegarde directe du texte sélectionné comme prompt via le menu contextuel
- 🎯 Prise en charge des prompts personnalisés, incluant catégories, titres, contenu, étiquettes et variables
- 🧑‍💻 **Variables** : utilisez des variables au format `{{nom_variable}}` dans vos prompts, à renseigner lors de l’utilisation
- 💾 **Sauvegarde des données** : exportez et importez votre bibliothèque de prompts, pour une migration et une sauvegarde faciles entre appareils
- 🔗 **Synchronisation Notion** : synchronisez votre bibliothèque de prompts avec une base de données Notion
- 🔍 Prise en charge de la recherche et du filtrage des prompts
- 🌙 S’adapte automatiquement au thème clair ou sombre du système

## ⚠️ Problèmes connus

- Sur le site Doubao (doubao.com), après avoir déclenché le sélecteur de prompts avec `/p`, certains champs de saisie ne suppriment pas correctement le `/p`. Mais ne vous inquiétez pas, mon fidèle acolyte Cursor et moi travaillons jour et nuit pour trouver une solution et corriger ce souci au plus vite !

## 🚀 Mode d’emploi

1. **Déclenchement rapide** : dans tout champ de saisie web, tapez `/p` pour ouvrir le sélecteur de prompts
2. **Ouvrir le sélecteur via raccourci** : utilisez `Ctrl+Shift+P` (Windows/Linux) ou `Command+Shift+P` (macOS) pour ouvrir le sélecteur
3. **Choisir un prompt** : cliquez sur le prompt souhaité dans la fenêtre, il sera inséré automatiquement dans le champ de saisie actif
4. **Sauvegarde rapide d’un prompt** : sélectionnez du texte puis utilisez `Ctrl+Shift+S` (Windows/Linux) ou `Command+Shift+S` (macOS) pour l’enregistrer rapidement comme prompt
5. **Sauvegarde via menu contextuel** : après avoir sélectionné du texte, faites un clic droit et choisissez "Enregistrer ce prompt" pour l’ajouter à votre bibliothèque
6. **Exporter la bibliothèque** : sur la page de gestion, cliquez sur "Exporter" pour sauvegarder tous vos prompts dans un fichier JSON local
7. **Importer une bibliothèque** : sur la page de gestion, cliquez sur "Importer" pour ajouter des prompts depuis un fichier JSON local (fusion ou remplacement des prompts existants possible)

## 📸 Aperçu de l’interface

Quick Prompt propose une interface utilisateur intuitive, facilitant la gestion et l’utilisation de vos prompts.

### Sélecteur de prompts

![Sélecteur de prompts](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Sélecteur de prompts](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Utilisez la commande `/p` ou le raccourci clavier pour faire apparaître rapidement le sélecteur de prompts dans n’importe quel champ de saisie et insérer le prompt de votre choix.

### Page de gestion des prompts

![Gestion des prompts](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Dans la page de gestion, vous pouvez créer de nouveaux prompts, éditer les existants, ajouter des étiquettes et organiser vos catégories. L’interface est claire et l’utilisation aisée.

### Sauvegarde via menu contextuel

![Sauvegarde menu contextuel](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Sélectionnez simplement n’importe quel texte sur une page web, faites un clic droit et sauvegardez-le instantanément comme prompt pour améliorer votre productivité.

### Saisie des variables du prompt

![Fenêtre variable du prompt](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Les prompts prennent en charge la configuration de variables, une fenêtre s’affichera pour saisir leur valeur après sélection.

## ⚙️ Configuration personnalisée

1. Cliquez sur l’icône de l’extension puis sur le bouton "Gérer les prompts"
2. Sur la page de gestion, vous pouvez :
   - Ajouter de nouveaux prompts
   - Modifier les prompts existants
   - Supprimer les prompts inutiles
   - Ajouter des étiquettes aux prompts pour les classer
   - Exporter la bibliothèque de prompts pour sauvegarde
   - Importer une bibliothèque de prompts sauvegardée précédemment

## 📦 Guide d'installation

### Installation depuis le Chrome Web Store

Déjà disponible sur le Chrome Web Store ! [Cliquez ici pour télécharger et installer](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Téléchargement depuis GitHub Releases

1. Rendez-vous sur la [page GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Téléchargez le dernier paquet compilé du plugin
3. Décompressez le fichier téléchargé
4. Suivez les instructions ci-dessous pour installer l'extension compilée

### Compilation depuis le code source

1. Clonez le dépôt
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Installation des dépendances
   ```bash
   pnpm install
   ```
3. Développement et construction

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Installer l’extension construite

#### Chrome / Edge
1. Ouvrir la page de gestion des extensions (`chrome://extensions` ou `edge://extensions`)
2. Activer le "mode développeur"
3. Cliquer sur "Charger l’extension non empaquetée"
4. Sélectionner le dossier `.output/chrome-mv3/` du projet

#### Firefox
1. Ouvrir `about:debugging`
2. Cliquer sur "Ce Firefox"
3. Cliquer sur "Charger un module complémentaire temporaire"
4. Sélectionner le fichier `manifest.json` dans le dossier `.output/firefox-mv2/` du projet

## 📄 Licence

MIT

## 🤝 Guide de contribution

Les Pull Requests et Issues sont les bienvenus !

1. Forkez ce dépôt
2. Créez votre branche de fonctionnalité (`git checkout -b feature/amazing-feature`)
3. Commitez vos modifications (`git commit -m 'Add some amazing feature'`)
4. Poussez sur la branche (`git push origin feature/amazing-feature`)
5. Ouvrez une Pull Request

## 👏 Liste des contributeurs

Merci à tous les développeurs ayant contribué au projet !

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Historique des étoiles

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---