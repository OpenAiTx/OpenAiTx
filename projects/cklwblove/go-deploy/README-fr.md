# Go-Deploy Outil de Déploiement

Un outil de déploiement automatisé développé en Go, prenant en charge le transfert des artefacts de construction locaux vers un serveur distant via le protocole SFTP.

## Fonctionnalités

- ✅ **Transfert sécurisé** : Utilise le protocole SFTP, transfert chiffré basé sur SSH
- ✅ **Synchronisation de répertoire** : Téléversement récursif de toute la structure du répertoire, maintien de la hiérarchie des fichiers
- ✅ **Création intelligente** : Création automatique de la structure de répertoire distante
- ✅ **Adaptation de chemin** : Calcul automatique du chemin local basé sur l’emplacement de l’exécutable, pas besoin de se soucier du répertoire d’exécution
- ✅ **Prise en charge des fichiers de configuration** : Prend en charge les fichiers de configuration JSON, facilitant la gestion des configurations pour différents environnements
- ✅ **Exclusion de fichiers** : Prise en charge des motifs génériques pour exclure les fichiers à ne pas téléverser
- ✅ **Sauvegarde automatique** : Possibilité de sauvegarder automatiquement les fichiers distants avant le téléversement
- ✅ **Mécanisme de reprise** : Reprise automatique en cas d’échec de téléversement, améliore le taux de succès
- ✅ **Statistiques détaillées** : Affichage du nombre de fichiers téléversés, taille transférée, temps écoulé et vitesse
- ✅ **Affichage de la progression** : Affichage en temps réel de la progression du téléversement et des informations de fichier
- ✅ **Gestion des erreurs** : Gestion complète des erreurs et journalisation

## Prérequis système

- Go 1.18 ou version ultérieure
- Le serveur cible doit prendre en charge les protocoles SSH/SFTP

## Instructions d’installation

### 1. Cloner le projet

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Initialiser le module Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. Installer les dépendances

Le programme téléchargera automatiquement les dépendances suivantes :

- `github.com/pkg/sftp` - Client SFTP
- `golang.org/x/crypto/ssh` - Client SSH

## Guide de configuration

Le programme prend en charge deux modes de configuration :

### 1. Utilisation d’un fichier de configuration (recommandé)

Copiez `config.example.json` en `config.json` puis modifiez la configuration :

```bash
cp config.example.json config.json
```

Ensuite, éditez `config.json` :

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### Explications des paramètres de configuration

**Configuration server** :

- `host` : Adresse du serveur SSH
- `port` : Port SSH, généralement 22
- `username` : Nom d’utilisateur SSH
- `password` : Mot de passe SSH (il est recommandé d’utiliser une authentification par clé en production)
- `timeout` : Délai de connexion (secondes)

**Configuration paths** :

- `local` : Chemin du répertoire local, prend en charge les chemins relatifs et absolus
- `remote` : Chemin du répertoire distant, doit être un chemin absolu

**Configuration options** :

- `backup` : Sauvegarder ou non les fichiers distants existants avant le téléversement
- `backup_suffix` : Suffixe du fichier de sauvegarde, personnalisable, la sauvegarde sera ignorée si le fichier n’existe pas
- `exclude_patterns` : Motifs d’exclusion de fichiers, prend en charge les caractères génériques
- `max_retries` : Nombre maximal de tentatives en cas d’échec du téléversement
- `chunk_size` : Taille des blocs de transfert de fichiers (octets, non implémenté pour le moment)

### 2. Configuration par défaut (mode compatible)

Si aucun fichier `config.json` n’est présent, le programme utilisera une configuration par défaut intégrée, assurant la rétrocompatibilité.

#### Priorité des fichiers de configuration

1. **Fichier de configuration spécifié en ligne de commande** : Fichier indiqué par le paramètre `--config`
2. **Fichier de configuration par défaut** : `config.json` dans le répertoire courant
3. **Configuration par défaut intégrée** : Si rien de tout cela n’existe, utilise la configuration interne du programme

#### Règles de gestion des chemins

- **Chemin du fichier de configuration** :

  - Chemin relatif : basé sur le répertoire de l’exécutable
  - Chemin absolu : utilise directement le chemin spécifié
- **Chemin du répertoire local** :

  - Chemin relatif : basé sur le répertoire de l’exécutable
  - Chemin absolu : utilise directement le chemin spécifié

## Instructions d’utilisation

### Paramètres en ligne de commande

Le programme prend en charge les paramètres suivants en ligne de commande :

```bash
# Afficher l’aide
./deploy --help

# Afficher les informations de version  
./deploy --version

# Utiliser le fichier de configuration par défaut config.json
./deploy

# Utiliser un fichier de configuration spécifique
./deploy --config prod.json

# Utiliser un fichier de configuration avec chemin absolu
./deploy --config /path/to/config.json
```

### Exécution en environnement de développement

```bash
# Utiliser la configuration par défaut
go run main.go

# Utiliser un fichier de configuration spécifique
go run main.go --config test.json

# Afficher l’aide
go run main.go --help
```

### Exécution après compilation

```bash
# Compiler
go build -o deploy main.go

# Exécuter avec la configuration par défaut
./deploy

# Exécuter avec un fichier de configuration spécifique
./deploy --config prod.json
```

## Instructions de packaging

### 1. Packaging pour la plateforme locale

```bash
# Compiler l’exécutable pour la plateforme courante
go build -o deploy main.go
```

### 2. Packaging multiplateforme

#### Linux 64 bits

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64 bits
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64 bits

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Optimisation du packaging (réduction de la taille du fichier)

```bash
# Suppression des informations de débogage et de la table des symboles
go build -ldflags="-s -w" -o deploy main.go

# Compression avec UPX (UPX doit être installé au préalable)
upx --best deploy
```

### 4. Script de packaging en lot

Créer le script `build.sh` :

```bash
#!/bin/bash

# Création du répertoire de build
mkdir -p builds

# Build pour chaque plateforme
echo "Construction de la version Linux 64 bits..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Construction de la version Windows 64 bits..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Construction de la version macOS 64 bits..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Construction de la version macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Build terminé !"
ls -la builds/
```

Exécuter le script :

```bash
chmod +x build.sh
./build.sh
```

## Exemple d’utilisation

### Afficher l’aide

```bash
$ ./deploy --help
Outil de déploiement Go-Deploy

Utilisation : ./deploy [options]

Options :
  -config string
        Chemin du fichier de configuration (par défaut "config.json")
  -help
        Afficher l’aide
  -version
        Afficher la version

Exemples :
  ./deploy                           # Utilise le fichier de configuration par défaut config.json
  ./deploy --config prod.json        # Utilise le fichier de configuration spécifié
  ./deploy --config /path/to/config.json  # Utilise un chemin absolu pour le fichier de configuration
```

### Utiliser un fichier de configuration spécifié

```bash
$ ./deploy --config prod.json
Démarrage du programme de déploiement...
Tentative de lecture du fichier de configuration : /path/to/go-deploy/prod.json
Utilisation du fichier de configuration...
Le répertoire local /path/to/project/dist existe
Connexion au serveur SSH en cours...
Connexion au serveur SSH réussie
...
```

### Utiliser le fichier de configuration

```bash
$ ./deploy
Démarrage du programme de déploiement...
Tentative de lecture du fichier de configuration : /path/to/go-deploy/config.json
Utilisation du fichier de configuration...
Le répertoire local /path/to/project/unpackage/dist/build/web existe
Connexion au serveur SSH en cours...
Connexion au serveur SSH réussie
Création du client SFTP en cours...
Client SFTP créé avec succès
Préparation de l’upload vers le répertoire distant : /opt/xsoft/nginx/html/app/dist
Début de l’upload du répertoire...
Parcours du répertoire local : /path/to/project/unpackage/dist/build/web
Création du répertoire : /opt/xsoft/nginx/html/app/dist
Fichier static/js/app.js.map exclu, upload ignoré
Création d’une sauvegarde : /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Upload du fichier : /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Fichier .DS_Store exclu, upload ignoré
Upload du fichier : /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Échec de l’upload (essai 1/3) : erreur réseau
Nouvel essai d’upload du fichier (2/3) : /path/to/project/unpackage/dist/build/web/static/js/app.js
Upload du fichier : /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Upload du répertoire terminé avec succès !
Statistiques :
  - Nombre de fichiers uploadés : 485
  - Nombre de répertoires créés : 18
  - Taille transférée : 25.8 MB
  - Durée de l’upload : 38.5s
  - Durée totale : 39.2s
  - Vitesse de transfert : 0,67 MB/s
```

## Remarques

1. **Sécurité** :

   - Pour la production, il est conseillé d’utiliser l’authentification par clé SSH plutôt que par mot de passe
   - L’utilisation actuelle de `ssh.InsecureIgnoreHostKey()` n’est pas recommandée pour la production, il faut valider la clé du serveur
2. **Réseau** :

   - Assurez-vous que le port 22 du serveur cible est accessible depuis la machine locale
   - La vitesse de transfert dépend de la bande passante et des performances du serveur
3. **Droits** :

   - L’utilisateur SSH doit avoir les droits d’écriture sur le répertoire cible
   - Si nécessaire, il peut être utile d’utiliser sudo
4. **Chemins** :

   - Le chemin local est automatiquement calculé à partir de l’emplacement de l’exécutable, pas besoin de se soucier du répertoire d’exécution
   - Le chemin distant doit être un chemin absolu

## Dépannage

### Problèmes courants

1. **Délai d’attente de connexion**

   ```
   Connexion au serveur SSH échouée : dial tcp: i/o timeout
   ```

   - Vérifiez l’adresse et le port du serveur
   - Vérifiez la connectivité réseau
   - Vérifiez la configuration du pare-feu
2. **Échec d’authentification**

   ```
   Échec de connexion : ssh: handshake failed
   ```

   - Vérifiez le nom d’utilisateur et le mot de passe
   - Vérifiez que le service SSH est démarré
   - Vérifiez la configuration SSH
3. **Erreur de droits**

   ```
   Échec de création du répertoire : permission denied
   ```

   - Vérifiez que l’utilisateur a les droits d’écriture sur le répertoire cible
   - Il peut être nécessaire d’utiliser sudo ou de changer le propriétaire du répertoire
4. **Le répertoire local n’existe pas**

   ```
   Erreur : le répertoire local /path/to/unpackage/dist/build/web n’existe pas
   ```

   - Vérifiez que la compilation locale est terminée
   - Vérifiez la structure du projet
   - Le programme calcule le chemin automatiquement, il n’est pas nécessaire de modifier le répertoire de travail

## Notes de développement

### Structure du projet

```
go-deploy/
├── main.go                 # Fichier principal du programme
├── go.mod                  # Fichier de module Go
├── go.sum                  # Fichier de vérification des dépendances
```
├── README.md               # Documentation détaillée  
├── Makefile                # Outil de construction  
├── build.sh                # Script de packaging en lot  
├── install.sh              # Script d'installation en un clic  
└── config.example.json     # Exemple de fichier de configuration  
```

### Fonctions principales

- `main()` - Fonction principale, gère la connexion et appelle l’upload
- `uploadDirectory()` - Téléversement récursif du répertoire
- `uploadFile()` - Téléversement d’un seul fichier
- `mkdirAll()` - Création récursive de répertoires distants

## Licence

Licence MIT

## Contribution

Les Issues et Pull Requests sont les bienvenus !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---