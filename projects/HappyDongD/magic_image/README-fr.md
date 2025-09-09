
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Dessin Magique par IA

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Une application de dessin basée sur Next.js avec IA, offrant les fonctionnalités principales suivantes :
- 🎨 Prise en charge de plusieurs modèles IA (Sora, DALL-E, GPT, GEMINI, etc.) et ajout de modèles personnalisés
- 🖼️ Fonctionnalités de génération d’images à partir de texte et de transformation d’images, avec prise en charge de références multiples et d’édition par zone
- 🔐 Stockage local de toutes les données et clés API pour garantir la sécurité et la confidentialité
- 💻 Compatible avec le Web et le packaging en application de bureau, utilisation multiplateforme

## Expérience en ligne

Adresse d’accès : [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Captures d’écran de l’application

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Capture d’écran 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Capture d’écran 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Capture d’écran 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Capture d’écran 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Capture d’écran 3" width="800" style="margin-bottom: 20px"/>
</div>

## Caractéristiques et fonctionnalités

- 🎨 Prise en charge de plusieurs modèles IA
  - Modèle GPT Sora_Image
  - Modèle GPT 4o_Image
  - Modèle GPT Image 1
  - Modèle DALL-E 3
  - Modèle GEMINI
  - 🆕 Modèles personnalisés (prise en charge de l’ajout de modèles privés)
- 🔄 Changement rapide de modèles
  - Permet de basculer rapidement entre différents modèles
  - Chaque modèle dispose de ses propres options de configuration
- ✍️ Fonction de génération d’image à partir de texte
  - Prise en charge de mots-clés personnalisés
  - Possibilité de choisir le ratio de l’image
  - Prise en charge de multiples tailles d’image
- 🖼️ Fonction de transformation d’image
  - Prise en charge de l’édition d’image
  - Prise en charge de l’édition de zones masquées
  - Prise en charge de l’ajustement de la qualité d’image
  - Prise en charge de la référence multi-images (téléversement simultané de plusieurs images)
- 🔒 Sécurité des données
  - Toutes les images générées et l'historique sont uniquement enregistrés dans le navigateur local
  - Prise en charge de l'adresse proxy API personnalisée
  - Prise en charge de la configuration de la clé API
- 📱 Conception UI
  - Interface utilisateur moderne
  - Expérience d'interaction fluide
  - Affichage au format Markdown
  - Prise en charge de la coloration syntaxique
- 🖥️ Compatibilité multiplateforme
  - Prise en charge de l'empaquetage en application de bureau (Windows, macOS, Linux)
  - Prise en charge de l'utilisation hors ligne (configuration de l'API requise)

## Stack technique

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (empaquetage application de bureau)

## Développement local

1. Cloner le projet
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Installation des dépendances

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Démarrer le serveur de développement

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Accédez à [http://localhost:3000](http://localhost:3000)

## Packaging de l’application de bureau

Ce projet utilise Tauri pour le packaging des applications de bureau, prenant en charge Windows, macOS et Linux.

### Préparation de l’environnement

Avant de packager l’application de bureau, il est nécessaire d’installer les dépendances suivantes :

1. **Installer Rust** :
   - Rendez-vous sur [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Suivez les instructions pour installer Rust et Cargo

2. **Dépendances système** :
   - **Windows** : Installez [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS** : Installez les outils de ligne de commande Xcode (`xcode-select --install`)
   - **Linux** : Installez les dépendances requises, voir la [documentation Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### Mode développement


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Créer des applications de bureau


```bash
# 构建桌面应用安装包
npm run desktop
```
Une fois la construction terminée, vous pouvez trouver le paquet d'installation correspondant à votre système dans le répertoire `src-tauri/target/release/bundle`.

## Déploiement sur Vercel

1. Forkez ce projet sur votre compte GitHub

2. Créez un nouveau projet sur [Vercel](https://vercel.com)

3. Importez votre dépôt GitHub

4. Cliquez sur Déployer

## Instructions d'utilisation

1. La première utilisation nécessite la configuration d'une clé API
   - Cliquez sur "Paramètres de clé" en haut à droite
   - Saisissez la clé API et l'adresse de base
   - Cliquez sur Enregistrer
   - Vous pouvez également configurer rapidement via les paramètres d'URL :

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Remarque : les caractères spéciaux dans l’URL doivent être encodés en URL

2. Choisir le mode de génération
   - Texte vers image : générer une image à partir d’une description textuelle
   - Image vers image : éditer une image en téléchargeant un fichier

3. Définir les paramètres de génération
   - Choisir le modèle IA (modèle intégré ou personnalisé)
   - Définir le ratio d’image
   - Ajuster la qualité de l’image (mode image vers image)

4. Gestion des modèles personnalisés
   - Cliquez sur l’icône de réglages à côté du sélecteur de modèle
   - Ajouter un nouveau modèle : saisissez le nom, la valeur et choisissez le type de modèle
   - Modifier un modèle : cliquez sur le bouton d’édition du modèle existant
   - Supprimer un modèle : cliquez sur le bouton de suppression du modèle existant
   - Sélectionner un modèle : cliquez sur le bouton plus du modèle pour l’utiliser immédiatement

5. Explication des types de modèle
   - Format DALL-E : utiliser l’API de génération d’images (/v1/images/generations)
   - Format OpenAI : utiliser l’API de chat (/v1/chat/completions)

6. Générer une image
   - Saisir le prompt
   - Cliquez sur le bouton "Générer une image"
   - Attendre la fin du processus de génération

7. Gestion des images
   - Consulter l’historique
   - Télécharger les images générées
   - Éditer les images existantes

## Remarques

- Toutes les images générées et l’historique ne sont enregistrés que dans le navigateur local
- L’utilisation du mode privé ou le changement d’appareil entraînera une perte de données
- Veuillez télécharger et sauvegarder rapidement les images importantes
- La configuration de l’API est stockée en toute sécurité dans votre navigateur et n’est pas envoyée au serveur
- Le chargement de ressources HTTP sur des sites HTTPS est bloqué par le navigateur ; l’application convertira automatiquement les API HTTP en HTTPS

## Guide de contribution

Bienvenue à la soumission d'Issues et de Pull Requests pour aider à améliorer le projet.

## Licence

Ce projet est sous licence [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Selon la licence, vous pouvez :
- ✅ Usage commercial : vous pouvez utiliser le logiciel à des fins commerciales
- ✅ Modification : vous pouvez modifier le code source du logiciel
- ✅ Distribution : vous pouvez distribuer le logiciel
- ✅ Usage privé : vous pouvez utiliser le logiciel à titre privé
- ✅ Autorisation de brevet : cette licence fournit également une autorisation de brevet

Mais vous devez respecter les conditions suivantes :
- 📝 Licence et déclaration de droits d’auteur : vous devez inclure la licence originale et la déclaration de droits d’auteur
- 📝 Déclaration de modifications : vous devez indiquer les modifications majeures apportées au code original
- 📝 Déclaration de marque : vous ne pouvez pas utiliser les marques déposées des contributeurs

---

## Offrez-moi un café

Si ce projet vous a aidé, n’hésitez pas à m’offrir un café ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Code de paiement WeChat" width="300" />
  <p>Offrez-moi un café</p>
</div>

## Coordonnées

Si vous avez des questions ou des suggestions, vous pouvez me contacter via WeChat :

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Contact WeChat" width="300" />
  <p>Scannez le QR code pour ajouter WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---