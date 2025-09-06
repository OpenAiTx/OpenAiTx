
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

L’accélération CDN et la protection de sécurité pour ce projet sont sponsorisées par Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

L’auteur de ce projet est colin1114.

# 🚀 Convertisseur d’abonnement Clash

Un outil en ligne élégant et puissant, conçu pour convertir divers liens d’abonnement proxy au format de configuration Clash. Prend en charge le déploiement automatique via Cloudflare Workers & Pages, offrant un service de conversion d’abonnement rapide et fiable.

## ✨ Fonctionnalités

- 🎨 **Interface moderne et esthétique** - Utilise un fond en dégradé et un design en cartes
- 🔄 **Support multi-protocole** - Prend en charge V2Ray, VLESS, Shadowsocks, Trojan et autres protocoles principaux
- ☁️ **Déploiement cloud** - Accélération CDN mondiale via Cloudflare Workers
- 📱 **Design responsive** - Adaptation parfaite pour ordinateurs et mobiles
- ⚡ **Conversion rapide** - Convertit les liens d’abonnement en configuration Clash en temps réel
- 📋 **Copie intelligente** - Permet de copier en un clic la configuration YAML générée, compatible avec tous les navigateurs
- 📡 **Génération de liens d’abonnement** - Génère automatiquement des liens d’abonnement importables dans Clash
- 🌐 **Accès YAML en ligne** - Offre plusieurs méthodes d’accès aux fichiers YAML :
  - 📡 Lien d’abonnement : Prise en charge de la mise à jour automatique par le client Clash
  - 🔗 Consultation en ligne : Visualisation directe de la configuration dans le navigateur
  - 💾 Téléchargement de fichier : Téléchargez le fichier .yaml sur votre appareil
  - ⚡ Accès rapide : Lien de téléchargement simplifié
- 🔧 **Prise en charge UTF-8** - Prise en charge parfaite des noms de nœuds et configurations en chinois
- 🆓 **Entièrement gratuit** - Basé sur le service gratuit Cloudflare, sans aucune restriction d’utilisation

## 📁 Structure du projet

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Démarrage rapide

### Méthode 1 : Exécution locale

1. **Cloner le projet**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Démarrer le serveur local**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Accéder à l'application**
   - Ouvrez le navigateur et accédez à `http://localhost:8000`
   - Un exemple de configuration sera affiché dans l'environnement local

### Méthode 2 : Déploiement avec Cloudflare Workers

#### Étape 1 : Créer un Worker

1. Rendez-vous sur [Cloudflare Workers](https://workers.cloudflare.com/)
2. Inscrivez-vous ou connectez-vous à votre compte Cloudflare
3. Cliquez sur "Create a Worker"
4. Copiez intégralement le code du fichier `worker.js` dans l'éditeur
5. Cliquez sur "Save and Deploy"

#### Étape 2 : Déployer avec Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Étape 3 : Configurer le nom de domaine (optionnel)

1. Ajouter un nom de domaine personnalisé dans les paramètres du Worker
2. Ou utiliser le nom de domaine par défaut fourni par Cloudflare

### Méthode 3 : Déploiement avec Cloudflare Pages

#### Option A : Intégration GitHub (recommandée)

1. **Préparer le dépôt**
   - Pousser le code vers le dépôt GitHub
   - S'assurer que tous les fichiers nécessaires sont inclus

2. **Créer un projet Pages**
   - Accéder à [Cloudflare Pages](https://pages.cloudflare.com/)
   - Connecter votre dépôt GitHub
   - Sélectionner le dépôt du projet

3. **Paramètres de build**
   - Commande de build : laisser vide ou `echo "No build required"`
   - Répertoire de sortie de build : `/` (répertoire racine)
   - Variables d'environnement : aucune configuration requise

#### Option B : Téléchargement direct

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Architecture technique

### Pile technologique front-end
- **HTML5** - Langage de balisage moderne
- **CSS3** - Design responsive et effets d’animation
- **Vanilla JavaScript** - Interactivité front-end légère

### Pile technologique back-end
- **Cloudflare Workers** - Plateforme de calcul en périphérie
- **Web APIs** - API Fetch standard et gestion des réponses

### Formats de protocole pris en charge
- **VMess** - Protocole standard V2Ray
- **VLESS** - Protocole léger V2Ray (supporte Reality)
- **Shadowsocks** - Protocole proxy classique
- **Trojan** - Protocole proxy émergent

### Points de terminaison API
- `GET /` - Page principale
- `POST /convert` - API de conversion d’abonnement
- `GET /clash/{config-id}` - Obtenir le fichier de configuration YAML (lien d’abonnement)
- `GET /yaml/{config-id}` - Télécharger le fichier de configuration YAML
- `OPTIONS /*` - Requête de pré-vérification CORS

## 📖 Guide d’utilisation

### Utilisation de base

1. **Saisir le lien d’abonnement**
   - Collez votre lien d’abonnement proxy dans le champ de saisie
   - Prise en charge des liens d’abonnement encodés en Base64

2. **Définir le nom de la configuration**
   - Optionnellement, définissez un nom personnalisé pour le fichier de configuration
   - Par défaut : "My Clash Config"

3. **Convertir la configuration**
   - Cliquez sur le bouton "Convertir l’abonnement"
   - Attendez la fin de la conversion
4. **Utilisation de la configuration**
   - Copiez la configuration YAML générée
   - Importez-la dans le client Clash pour l'utiliser

5. **Utilisation du lien d'abonnement (recommandé)**
   - Copiez le lien d'abonnement généré
   - Ajoutez l'abonnement dans le client Clash
   - La configuration se synchronisera automatiquement, sans mise à jour manuelle

### Configuration avancée

La configuration Clash générée comprend les fonctionnalités suivantes :

- **Stratégie de groupe de proxy**
  - 🚀 Sélection de nœud - Sélection manuelle du proxy
  - ♻️ Sélection automatique - Test de latence et sélection automatique
  - 🎯 Connexion directe mondiale - Connexion directe

- **Configuration DNS**
  - Activation de la résolution DNS
  - Prise en charge du mode fake-ip
  - Split DNS domestique/international

- **Règles de routage**
  - Adresse locale en connexion directe
  - IP domestique en connexion directe
  - Autre trafic via proxy

## 🔧 Dépannage du déploiement

### Problèmes courants

#### 1. Wrangler ne trouve pas le point d'entrée
**Message d'erreur** : `Missing entry-point to Worker script`

**Solution** :
- Assurez-vous qu'il y a un fichier `wrangler.jsonc` à la racine du projet
- Vérifiez que le champ `main` dans `wrangler.jsonc` pointe vers `worker.js`


#### 2. Échec du déploiement GitHub Actions
**Solution** :
- Ajoutez les Secrets suivants dans les paramètres du dépôt GitHub :
  - `CLOUDFLARE_API_TOKEN` : Jeton API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID` : ID du compte Cloudflare

#### 3. Échec de la construction des Pages
**Solution** :
- Définissez la commande de construction sur vide ou `echo "No build required"`
- Assurez-vous que le répertoire de sortie de la construction est défini sur `/`

### Explication des fichiers de configuration du déploiement

- **`wrangler.jsonc`** : Configuration de Wrangler CLI pour le déploiement Worker
- **`_headers`** : Configuration des en-têtes HTTP pour Cloudflare Pages
- **`.github/workflows/deploy.yml`** : Configuration du déploiement automatique via GitHub Actions

## 🔧 Configuration personnalisée

### Modifier les groupes de proxy

Vous pouvez éditer la fonction `convertToClash` dans `worker.js` pour personnaliser les groupes de proxy :

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Règles de routage personnalisées

Modifiez le tableau `rules` pour ajouter des règles de routage personnalisées :

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Caractéristiques de performance

- **CDN mondial** - Cloudflare couvre des nœuds périphériques dans le monde entier
- **Réponse rapide** - Temps de réponse moyen < 100 ms
- **Haute disponibilité** - Disponibilité du service à 99,9 %
- **Quota gratuit** - 100 000 requêtes par jour

## 🔒 Informations de sécurité

- **Confidentialité des données** - Les données d'abonnement sont utilisées uniquement pendant la conversion, sans stockage
- **Chiffrement HTTPS** - Toutes les communications sont chiffrées via HTTPS
- **Transparence open source** - Code source complet disponible pour audit indépendant

## 🤝 Guide de contribution

Les Issues et Pull Requests sont les bienvenus !

1. Forkez ce dépôt
2. Créez une branche de fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commitez vos modifications (`git commit -m 'Add some AmazingFeature'`)
4. Poussez sur la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

## 📝 Journal des modifications

### v1.1.0
- ✅ Ajout du support du protocole VLESS (y compris Reality sécurisé)
- ✅ Compatibilité des protocoles améliorée

### v1.0.0
- ✅ Fonctionnalité de base de conversion d’abonnement
- ✅ Interface utilisateur esthétique
- ✅ Prise en charge de Cloudflare Workers
- ✅ Prise en charge de plusieurs protocoles (VMess, Shadowsocks, Trojan)
- ✅ Design responsive
- ✅ Fonction de copie en un clic

## 📞 Support et retours

Si vous rencontrez des problèmes ou avez des suggestions lors de l’utilisation, veuillez :

1. Consulter ce document README
2. Soumettre une [Issue](../../issues)
3. Lancer une [Discussion](../../discussions)

## 📄 Licence

Ce projet est sous licence MIT – voir le fichier [LICENSE](LICENSE) pour plus de détails

## 🙏 Remerciements

- [Cloudflare Workers](https://workers.cloudflare.com/) – Fournit une plateforme de calcul en périphérie
- [Clash](https://github.com/Dreamacro/clash) – Excellent client proxy
- Soutien de tous les contributeurs et utilisateurs

---

⭐ Si ce projet vous est utile, merci de lui attribuer une étoile ! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---