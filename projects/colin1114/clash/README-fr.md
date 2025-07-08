L'accélération CDN et la protection de sécurité pour ce projet sont sponsorisées par Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

L'auteur de ce projet est colin1114.

# 🚀 Convertisseur d’abonnement Clash

Un outil en ligne esthétique et puissant, conçu pour convertir divers liens d’abonnement proxy au format de configuration Clash. Prend en charge le déploiement automatique via Cloudflare Workers & Pages, offrant un service de conversion d’abonnements rapide et fiable.

## ✨ Fonctionnalités

- 🎨 **Interface moderne et élégante** – Utilise un fond en dégradé et un design en cartes
- 🔄 **Support multi-protocoles** – Prend en charge V2Ray, VLESS, Shadowsocks, Trojan et autres protocoles courants
- ☁️ **Déploiement dans le cloud** – Accélération CDN mondiale grâce à Cloudflare Workers
- 📱 **Design responsive** – Parfaitement adapté aux ordinateurs de bureau et aux appareils mobiles
- ⚡ **Conversion rapide** – Conversion en temps réel des liens d’abonnement vers la configuration Clash
- 📋 **Copie intelligente** – Permet de copier en un clic la configuration YAML générée, compatible avec tous les navigateurs
- 📡 **Génération de liens d’abonnement** – Génère automatiquement des liens d’abonnement importables directement dans Clash
- 🌐 **Accès YAML en ligne** – Propose plusieurs modes d’accès aux fichiers YAML :
  - 📡 Lien d’abonnement : permet la mise à jour automatique via le client Clash
  - 🔗 Visualisation en ligne : consulter la configuration directement dans le navigateur
  - 💾 Téléchargement de fichier : télécharger le fichier .yaml localement
  - ⚡ Accès rapide : lien de téléchargement simplifié
- 🔧 **Support UTF-8** – Prise en charge parfaite des noms de nœuds et configurations en chinois
- 🆓 **Entièrement gratuit** – Basé sur les services gratuits de Cloudflare, sans aucune restriction d’utilisation

## 📁 Structure du projet

```
clash/
├── index.html              # Page front-end
├── worker.js               # Code back-end du Cloudflare Worker
├── wrangler.jsonc          # Fichier de configuration Wrangler
├── _headers                # Configuration des en-têtes HTTP pour Cloudflare Pages
├── .github/
│   └── workflows/
│       └── deploy.yml      # Configuration de déploiement GitHub Actions
├── README.md              # Documentation du projet
└── package.json           # Fichier de configuration du projet
```

## 🚀 Démarrage rapide

### Méthode 1 : Exécution locale

1. **Cloner le projet**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Démarrer un serveur local**
   ```bash
   # Avec Python
   python -m http.server 8000
   
   # Ou avec Node.js
   npx serve .
   ```

3. **Accéder à l’application**
   - Ouvrir le navigateur à l’adresse `http://localhost:8000`
   - Un exemple de configuration sera affiché en local

### Méthode 2 : Déploiement via Cloudflare Workers

#### Étape 1 : Créer un Worker

1. Aller sur [Cloudflare Workers](https://workers.cloudflare.com/)
2. S’inscrire/se connecter à un compte Cloudflare
3. Cliquer sur "Create a Worker"
4. Copier l’intégralité du code de `worker.js` dans l’éditeur
5. Cliquer sur "Save and Deploy"

#### Étape 2 : Déployer avec le CLI Wrangler

```bash
# Installer le CLI Wrangler
npm install -g wrangler

# Se connecter à Cloudflare
wrangler login

# Déployer le Worker
npm run deploy:worker
```

#### Étape 3 : Configurer le nom de domaine (optionnel)

1. Ajouter un domaine personnalisé dans les paramètres du Worker
2. Ou utiliser le domaine par défaut fourni par Cloudflare

### Méthode 3 : Déploiement via Cloudflare Pages

#### Option A : Intégration GitHub (recommandé)

1. **Préparer le dépôt**
   - Pousser le code sur un dépôt GitHub
   - S’assurer que tous les fichiers nécessaires sont inclus
2. **Créer un projet Pages**
   - Accédez à [Cloudflare Pages](https://pages.cloudflare.com/)
   - Connectez votre dépôt GitHub
   - Sélectionnez le dépôt du projet

3. **Paramètres de build**
   - Commande de build : laisser vide ou `echo "No build required"`
   - Répertoire de sortie de build : `/` (répertoire racine)
   - Variables d’environnement : aucune configuration requise

#### Option B : Téléversement direct

```bash
# Déployer avec Wrangler Pages
npm run deploy:pages
```

## 🛠️ Architecture technique

### Stack technologique front-end
- **HTML5** - Langage de balisage moderne
- **CSS3** - Design réactif et effets d’animation
- **Vanilla JavaScript** - Interactions front-end légères

### Stack technologique back-end
- **Cloudflare Workers** - Plateforme de calcul en périphérie
- **Web APIs** - API Fetch standard et gestion des réponses

### Protocoles supportés
- **VMess** - Protocole standard V2Ray
- **VLESS** - Protocole léger V2Ray (supporte Reality)
- **Shadowsocks** - Protocole proxy classique
- **Trojan** - Nouveau protocole proxy

### Points de terminaison de l’API
- `GET /` - Page principale
- `POST /convert` - API de conversion d’abonnement
- `GET /clash/{config-id}` - Obtenir le fichier de configuration YAML (lien d’abonnement)
- `GET /yaml/{config-id}` - Télécharger le fichier de configuration YAML
- `OPTIONS /*` - Requête préliminaire CORS

## 📖 Guide d’utilisation

### Utilisation de base

1. **Entrer le lien d’abonnement**
   - Collez votre lien d’abonnement proxy dans le champ de saisie
   - Prend en charge les liens d’abonnement codés en Base64

2. **Définir le nom de la configuration**
   - Optionnellement, définissez un nom personnalisé pour le fichier de configuration
   - Par défaut : "My Clash Config"

3. **Convertir la configuration**
   - Cliquez sur le bouton "Convertir l’abonnement"
   - Attendez la fin de la conversion

4. **Utiliser la configuration**
   - Copiez la configuration YAML générée
   - Importez-la dans le client Clash

5. **Utiliser le lien d’abonnement (recommandé)**
   - Copiez le lien d’abonnement généré
   - Ajoutez-le dans le client Clash
   - La configuration se synchronise automatiquement, pas besoin de mise à jour manuelle

### Configuration avancée

La configuration Clash générée inclut les fonctionnalités suivantes :

- **Stratégies de groupe proxy**
  - 🚀 Sélection de nœud - Choix manuel du proxy
  - ♻️ Sélection automatique - Sélection automatique basée sur le test de latence
  - 🎯 Connexion directe globale - Connexion directe

- **Configuration DNS**
  - Activation de la résolution DNS
  - Prise en charge du mode fake-ip
  - Routage DNS domestique et international

- **Règles de routage**
  - Adresses locales en connexion directe
  - IP nationales en connexion directe
  - Autre trafic via proxy

## 🔧 Dépannage du déploiement

### Problèmes courants

#### 1. Wrangler ne trouve pas le point d’entrée
**Message d’erreur** : `Missing entry-point to Worker script`

**Solution** : 
- Vérifiez que le fichier `wrangler.jsonc` se trouve à la racine du projet
- Vérifiez que le champ `main` dans `wrangler.jsonc` pointe vers `worker.js`

#### 2. Échec du déploiement GitHub Actions
**Solution** :
- Ajoutez les Secrets suivants dans les paramètres du dépôt GitHub :
  - `CLOUDFLARE_API_TOKEN` : Jeton API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID` : ID du compte Cloudflare

#### 3. Échec de la construction des Pages
**Solution** :
- Définir la commande de construction comme vide ou `echo "No build required"`
- S'assurer que le répertoire de sortie de la construction est `/`

### Description des fichiers de configuration de déploiement

- **`wrangler.jsonc`** : Configuration du CLI Wrangler, utilisée pour le déploiement Worker
- **`_headers`** : Configuration des en-têtes HTTP de Cloudflare Pages
- **`.github/workflows/deploy.yml`** : Configuration de déploiement automatique GitHub Actions

## 🔧 Configuration personnalisée

### Modifier les groupes de proxy

Vous pouvez éditer la fonction `convertToClash` dans `worker.js` pour personnaliser les groupes de proxy :

```javascript
'proxy-groups': [
  {
    name: '🚀 Sélection de nœud',
    type: 'select',
    proxies: ['♻️ Sélection automatique', '🎯 Connexion globale directe', ...proxyNames]
  },
  // Ajouter plus de groupes de proxy...
]
```

### Règles de routage personnalisées

Modifiez le tableau `rules` pour ajouter des règles de routage personnalisées :

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Sélection de nœud',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Ajouter plus de règles...
]
```

## 📊 Caractéristiques de performance

- **CDN mondial** - Nœuds Edge Cloudflare couvrant le monde entier
- **Réponse rapide** - Temps de réponse moyen < 100 ms
- **Haute disponibilité** - Disponibilité du service à 99,9 %
- **Quota gratuit** - 100 000 requêtes par jour

## 🔒 Informations de sécurité

- **Confidentialité des données** - Les données d'abonnement sont uniquement utilisées pendant la conversion et ne sont pas stockées
- **Chiffrement HTTPS** - Toutes les communications sont chiffrées via HTTPS
- **Transparence open source** - Code source complet disponible pour audit

## 🤝 Guide de contribution

Les Issues et Pull Requests sont les bienvenus !

1. Forkez ce dépôt
2. Créez une branche de fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commitez vos modifications (`git commit -m 'Add some AmazingFeature'`)
4. Poussez la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

## 📝 Journal des modifications

### v1.1.0
- ✅ Ajout du support du protocole VLESS (y compris transport sécurisé Reality)
- ✅ Amélioration de la compatibilité des protocoles

### v1.0.0
- ✅ Fonction de conversion d’abonnement de base
- ✅ Interface utilisateur esthétique
- ✅ Support Cloudflare Workers
- ✅ Prise en charge multi-protocoles (VMess, Shadowsocks, Trojan)
- ✅ Design responsive
- ✅ Fonction de copie en un clic

## 📞 Support et retours

Si vous rencontrez des problèmes ou avez des suggestions lors de l'utilisation :

1. Consultez ce document README
2. Soumettez une [Issue](../../issues)
3. Lancez une [Discussion](../../discussions)

## 📄 Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails

## 🙏 Remerciements

- [Cloudflare Workers](https://workers.cloudflare.com/) - Plateforme de calcul en périphérie
- [Clash](https://github.com/Dreamacro/clash) - Excellent client proxy
- Merci à tous les contributeurs et utilisateurs pour leur soutien

---
⭐ Si ce projet vous a été utile, merci de lui attribuer une étoile !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---