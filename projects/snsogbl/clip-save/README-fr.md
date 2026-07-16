# 剪存 - Outil de gestion de l'historique du presse-papiers

Un outil de gestion de l'historique du presse-papiers multiplateforme basé sur Wails + Vue 3 + TypeScript.

## Disponible sur l'App Store
https://apps.apple.com/us/app/剪存/id6754015301

## Fonctionnalités
- [Nouveau script personnalisé - cliquez pour voir](https://raw.githubusercontent.com/snsogbl/clip-save/main/scriptingExample/README.md)
- Sauvegarde automatique de l'historique du presse-papiers
- Prise en charge de plusieurs types : texte, image, fichier, etc.
- Recherche et filtrage en temps réel (prise en charge de la recherche de texte OCR dans les images)
- Stockage local dans une base de données SQLite (toutes les données sont stockées localement, confidentialité garantie)
- Paramètres personnalisés : protection par mot de passe, nettoyage automatique, configuration des raccourcis clavier

## Captures d'écran du projet

<img src="https://raw.githubusercontent.com/snsogbl/clip-save/master/screenshots/clipboard-1.png" alt="Capture" width="960">


## Stack technique

- **Backend** : Go + Wails v2
- **Frontend** : Vue 3 + TypeScript + Vite
- **Base de données** : SQLite3
- **Presse-papiers** : golang.design/x/clipboard

## Installation des dépendances

### 1. Installer Wails CLI

```bash
go install github.com/wailsapp/wails/v2/cmd/wails@latest
```

### 2. Installer les dépendances du projet

```bash
# Go 依赖
go mod tidy

# 前端依赖
cd frontend
npm install
```

## 开发

### 启动开发服务器

```bash
wails dev
```

Cela lancera le serveur de développement avec rechargement à chaud :
- Les modifications du code Go backend seront automatiquement recompilées
- Les modifications du code Vue frontend seront automatiquement rechargées à chaud

### Débogage en mode développement

En mode développement, l'application ouvrira automatiquement les outils de développement, où vous pourrez consulter :
- Les journaux Console
- Les requêtes Network
- L'état des composants frontend

## Compilation

### Compilation de la version de production

```bash
wails build
```

Après la construction, les fichiers exécutables se trouveront dans le répertoire `build/bin/`.

### Déploiement de scripts personnalisés sur Cloudflare Pages

Le projet utilise Cloudflare Pages pour héberger la liste des scripts en ligne, permettant aux utilisateurs d'installer et de mettre à jour les scripts directement depuis le "Marché des scripts".

#### 1. Installer Wrangler CLI

```bash
npm install -g wrangler
```

#### 2. Se connecter à Cloudflare

```bash
wrangler login
```

Cela ouvrira un navigateur et vous connectera à votre compte Cloudflare.

#### 3. Déploiement du script

```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```

Après le déploiement, le script sera accessible via les URL suivantes :
- Liste des plugins : `https://clip-save-plugins.pages.dev/plugins.json`
- Fichier script : `https://clip-save-plugins.pages.dev/{nom_du_fichier_script}.js`

#### 4. Mise à jour du script

Après chaque modification des fichiers dans le répertoire `scriptingExample`, relancez la commande de déploiement :

```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```

#### 5. Remarques

- Assurez-vous que `scriptUrl` dans `plugins.json` utilise l'URL de Cloudflare Pages
- L'effet est généralement visible en quelques secondes après le déploiement (le temps de cache de Cloudflare Pages est très court)
- Vous pouvez consulter l'historique de déploiement et les journaux via le tableau de bord Cloudflare

### Options de construction macOS

```bash
# 构建 Intel 版本
wails build -platform darwin/amd64

# 构建 Apple Silicon 版本
wails build -platform darwin/arm64

# 构建通用二进制（推荐）
wails build -platform darwin/universal
```

### Construction Windows

```bash
wails build -platform windows/amd64
```
### Construction Linux


```bash
wails build -platform linux/amd64
```

## Structure du projet

```
.
├── main.go                      # 主程序入口
├── app.go                       # Wails 应用结构和 API
├── wails.json                   # Wails 配置文件
├── go.mod                       # Go 依赖管理
├── common/                      # 共享代码
│   ├── clipboard.go             # 剪贴板逻辑
│   ├── clipboard_darwin.go      # macOS 特定代码
│   └── db.go                    # 数据库操作
├── frontend/                    # 前端代码
│   ├── src/
│   │   ├── App.vue              # 主应用组件
│   │   ├── components/
│   │   │   └── ClipboardHistory.vue  # 剪贴板历史组件
│   │   ├── main.ts              # 前端入口
│   │   └── style.css            # 全局样式
│   ├── index.html               # HTML 模板
│   ├── package.json             # 前端依赖
│   ├── vite.config.ts           # Vite 配置
│   └── tsconfig.json            # TypeScript 配置
└── build/                       # 构建资源和输出
    ├── bin/                     # 编译后的可执行文件
    ├── appicon.png              # 应用图标
    └── darwin/                  # macOS 特定配置
```

## Description de l'API

### API Backend (Go)

Les méthodes définies dans `app.go` sont automatiquement exposées au frontend :

- `SearchClipboardItems(keyword, filterType, limit)` - Recherche des éléments du presse-papiers
- `GetClipboardItems(limit)` - Obtient la liste du presse-papiers
- `GetClipboardItemByID(id)` - Obtient un élément par ID
- `CopyToClipboard(id)` - Copie un élément dans le presse-papiers
- `DeleteClipboardItem(id)` - Supprime un élément
- `GetStatistics()` - Obtient des statistiques

### Exemple d'appel frontend

```typescript
import { SearchClipboardItems } from '../wailsjs/go/main/App'

// 搜索剪贴板项目
const items = await SearchClipboardItems('关键词', '所有类型', 100)
```
## Instructions d'utilisation

1. Après avoir lancé l'application, elle sauvegarde automatiquement le presse-papiers système en arrière-plan  
2. Chaque fois que vous copiez du contenu, il est automatiquement enregistré dans l'historique  
3. Utilisez la barre de recherche en haut pour retrouver rapidement l'historique (prise en charge de la recherche dans le texte OCR des images)  
4. Utilisez les filtres pour trier le contenu par type (texte/image/URL, etc.)  
5. Cliquez sur n'importe quelle entrée de l'historique pour voir les détails  
6. Pour les images, cliquez sur le bouton "Extraire le texte" pour voir les résultats de la reconnaissance OCR  
7. Cliquez sur le bouton "Copier" pour recopier le contenu dans le presse-papiers  
8. Cliquez sur le bouton "Supprimer" pour effacer une entrée de l'historique  

### Fonctionnalité de reconnaissance de texte OCR

- **Reconnaissance automatique** : après avoir copié une image, l'application reconnaît automatiquement le texte de l'image en arrière-plan (macOS 10.15+)  
- **Recherche intelligente** : le texte reconnu est automatiquement ajouté à l'index de recherche, saisissez un mot-clé pour trouver les images contenant ce texte  
- **Extraction manuelle** : dans la page de détails de l'image, cliquez sur "Extraire le texte" pour voir le résultat complet de la reconnaissance OCR  
- **Langues supportées** : prise en charge du chinois (simplifié/traditionnel) et de l'anglais  
- **Optimisation des performances** : chaque image est reconnue une seule fois, les résultats sont réutilisés automatiquement pour améliorer les performances  

## Stockage des données

L'historique du presse-papiers est enregistré dans : `~/.clipsave/clipboard.db`  

La base de données est créée automatiquement et contient les champs suivants :  
- ID - identifiant unique  
- Content - texte du contenu  
- ContentType - type de contenu  
- ImageData - données de l'image (format PNG)  
- Timestamp - horodatage  
- Source - source  
- CharCount - nombre de caractères  
- WordCount - nombre de mots  
- OCRText - texte reconnu par OCR (spécifique aux images, utilisé pour la recherche)  

## Exigences système

- **macOS** : 10.15 Catalina ou version ultérieure (fonctionnalité OCR requise)  
- **Windows** : Windows 10/11 (1809 ou version ultérieure) + WebView2  
- **Linux** : distributions supportant WebKit2GTK

- **Go** : version 1.21 ou supérieure  
- **Node.js** : version 16 ou supérieure  

## Considérations de développement

### Après la mise à jour de l'API Go

Chaque fois que vous modifiez une méthode dans `app.go`, il est nécessaire de régénérer les bindings frontend :

```bash
wails generate module
```

Ou utilisez le mode développeur, il générera automatiquement :

```bash
wails dev
```
### Développement Frontend

Le frontend utilise Vite + Vue 3 + TypeScript :
- Prise en charge de la vérification des types TypeScript
- Utilisation de l'API Composition
- Importation automatique des bindings Wails
- Remplacement à chaud des modules (HMR)

### Dépendances CGO

Le projet utilise CGO (pour SQLite et les opérations presse-papiers), la construction nécessite :
- macOS : nécessite Xcode Command Line Tools
- Windows : nécessite MinGW-w64
- Linux : nécessite gcc

## FAQ

### 1. Échec de la construction

Assurez-vous que toutes les dépendances sont installées :

```bash
# macOS
xcode-select --install

# Windows
# 安装 MSYS2 和 MinGW-w64

# Linux
sudo apt-get install build-essential libgtk-3-dev libwebkit2gtk-4.0-dev
```

### 2. Le front-end ne peut pas appeler l’API back-end

Assurez-vous d’avoir exécuté `wails generate module` pour générer les bindings front-end.

## Licence

Licence MIT

## Soutien par des dons

💗 **Offrez un café à l’auteur**

Si ce logiciel vous a fait gagner du temps (ou au moins ne vous a pas rendu fou), n’hésitez pas à offrir un café ☕ ou une bière 🍺 à l’auteur !

Chaque café se transforme miraculeusement en : nouvelles fonctionnalités, moins de bugs (je fais de mon mieux), et un soutien moral pour les nuits blanches de l’auteur à coder.

Vos étoiles ⭐ et vos dons sont ma motivation pour corriger les bugs et ajouter de nouvelles fonctionnalités (et aussi mon budget café) !

### Scannez avec WeChat

![Code de don](https://raw.githubusercontent.com/snsogbl/clip-save/main/frontend/src/assets/static/zs.png)

**"Offrez-moi un café ☕"**

### Donnez une étoile ⭐ au projet

Si ce projet vous aide, merci de lui donner une étoile ⭐, c’est le plus grand soutien que vous puissiez m’apporter !

## Remerciements

- [Wails](https://wails.io) - Framework de création d’applications de bureau
- [Vue 3](https://vuejs.org) - Framework JavaScript progressif
- [golang.design/x/clipboard](https://github.com/golang-design/clipboard) - Bibliothèque de presse-papiers multiplateforme
- [json-editor-vue](https://github.com/cloydlau/json-editor-vue)
- [highlight.js](https://github.com/highlightjs/highlight.js)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---