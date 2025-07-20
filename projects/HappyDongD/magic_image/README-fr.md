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

# Peinture Magique par IA

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![Licence](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Une application de dessin par IA basée sur Next.js, offrant les fonctionnalités principales suivantes :
- 🎨 Prise en charge de plusieurs modèles IA (Sora, DALL-E, GPT, etc.) et ajout de modèles personnalisés
- 🖼️ Fonctionnalité texte-vers-image et image-vers-image, supporte la référence multi-images et l’édition de zones
- 🔐 Toutes les données et clés API sont stockées localement pour garantir la confidentialité
- 💻 Prise en charge du web et du packaging en application de bureau, utilisation multiplateforme

## Démo en ligne

Adresse d’accès : [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Captures d’écran de l’application

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Capture 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Capture 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Capture 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Capture 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Capture 3" width="800" style="margin-bottom: 20px"/>
</div>

## Caractéristiques

- 🎨 Prise en charge de multiples modèles IA
  - Modèle GPT Sora_Image
  - Modèle GPT 4o_Image
  - Modèle GPT Image 1
  - Modèle DALL-E 3
  - 🆕 Modèle personnalisé (ajout de modèles privés possible)
- ✍️ Fonction texte-vers-image
  - Prise en charge de prompts personnalisés
  - Choix du format d’image
  - Prise en charge de diverses tailles d’image
- 🖼️ Fonction image-vers-image
  - Prise en charge de l’édition d’image
  - Prise en charge de l’édition par masque de zone
  - Ajustement de la qualité d’image
  - Prise en charge de la référence multi-images (téléchargement simultané de plusieurs images)
- 🔒 Sécurité des données
  - Toutes les images générées et historiques sont uniquement stockées dans le navigateur local
  - Prise en charge de l’adresse proxy API personnalisée
  - Prise en charge de la configuration de la clé API
- 📱 Design UI
  - Interface utilisateur moderne
  - Expérience utilisateur fluide
  - Affichage au format Markdown
  - Prise en charge de la coloration syntaxique
- 🖥️ Multiplateforme
  - Packaging en application de bureau (Windows, macOS, Linux)
  - Utilisation hors-ligne possible (configuration de l’API requise)

## Pile technologique

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (packaging application de bureau)

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
   - Image vers image : éditer une image en la téléchargeant

3. Définir les paramètres de génération
   - Choisir un modèle d’IA (modèle intégré ou modèle personnalisé)
   - Définir le ratio d’image
   - Ajuster la qualité d’image (mode image vers image)

4. Gestion des modèles personnalisés
   - Cliquez sur l’icône de réglage à côté du champ de sélection du modèle
   - Ajouter un nouveau modèle : saisir le nom du modèle, la valeur du modèle et choisir le type de modèle
   - Éditer un modèle : cliquer sur le bouton d’édition d’un modèle existant
   - Supprimer un modèle : cliquer sur le bouton de suppression d’un modèle existant
   - Sélectionner un modèle : cliquer sur le bouton plus du modèle pour l’utiliser immédiatement

5. Explication des types de modèles
   - Format DALL-E : utilise l’API de génération d’images (/v1/images/generations)
   - Format OpenAI : utilise l’API de chat (/v1/chat/completions)

6. Générer une image
   - Saisir le prompt
   - Cliquer sur le bouton « Générer l’image »
   - Attendre la fin de la génération

7. Gestion des images
   - Consulter l’historique
   - Télécharger les images générées
   - Éditer une image existante

## Remarques

- Toutes les images générées et l’historique ne sont stockés que dans le navigateur local
- L’utilisation du mode navigation privée ou le changement d’appareil entraînera une perte des données
- Veuillez télécharger et sauvegarder à temps les images importantes
- La configuration de l’API sera stockée en toute sécurité dans votre navigateur et ne sera pas envoyée au serveur
- Le chargement de ressources HTTP sur un site HTTPS sera bloqué par le navigateur, l’application convertira automatiquement les interfaces HTTP en HTTPS

## Guide de contribution

Les Issues et Pull Requests pour améliorer le projet sont les bienvenus.

## Licence

Ce projet est sous licence [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Selon la licence, vous pouvez :
- ✅ Usage commercial : vous pouvez utiliser le logiciel à des fins commerciales
- ✅ Modification : vous pouvez modifier le code source du logiciel
- ✅ Distribution : vous pouvez distribuer le logiciel
- ✅ Usage privé : vous pouvez utiliser le logiciel à titre privé
- ✅ Concession de brevet : cette licence offre aussi une concession de brevet

Mais vous devez respecter les conditions suivantes :
- 📝 Licence et mention de copyright : vous devez inclure la licence d’origine et la mention de copyright
- 📝 Déclaration de modification : vous devez déclarer les modifications majeures du code d’origine
- 📝 Déclaration de marque : vous ne pouvez pas utiliser les marques des contributeurs

---

## Offrez-moi un café

Si ce projet vous a été utile, vous pouvez m’offrir un café ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Code de paiement WeChat" width="300" />
  <p>Offrez-moi un café</p>
</div>

## Contact

Si vous avez des questions ou des suggestions, vous pouvez me contacter via WeChat :

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Contact WeChat" width="300" />
  <p>Scannez le code QR pour ajouter sur WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---