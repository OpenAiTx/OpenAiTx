![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Transformez n’importe quel dépôt GitHub en un conteneur Docker prêt pour la production grâce à la génération de Dockerfile assistée par l’IA.**

[![Licence MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer est une application web alimentée par l’IA qui génère automatiquement des Dockerfiles prêts pour la production en analysant les dépôts GitHub. Il suffit de coller une URL GitHub pour obtenir un Dockerfile personnalisé avec une sélection intelligente de l’image de base, la gestion des dépendances et les meilleures pratiques Docker.

## 🌟 Accès rapide

Remplacez simplement `github.com` par `gitcontainer.com` dans n’importe quelle URL de dépôt GitHub pour accéder instantanément à la page de génération du Dockerfile pour ce dépôt.

Par exemple :
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Fonctionnalités

- **🔄 Accès instantané par URL** : Remplacez simplement 'github.com' par 'gitcontainer.com' dans n’importe quelle URL GitHub
- **🤖 Analyse par IA** : Utilise OpenAI GPT-4 pour analyser la structure du dépôt et générer des Dockerfiles intelligents
- **⚡ Streaming en temps réel** : Regardez l’IA générer votre Dockerfile en temps réel grâce au streaming WebSocket
- **🎯 Détection intelligente** : Détecte automatiquement les stacks technologiques (Python, Node.js, Java, Go, etc.)
- **🔧 Prêt pour la production** : Génère des Dockerfiles respectant les meilleures pratiques avec sécurité, constructions multi-étapes et optimisation
- **📋 Instructions supplémentaires** : Ajoutez des exigences personnalisées pour des environnements spécialisés
- **📄 Docker Compose** : Propose automatiquement un docker-compose.yml pour les applications complexes
- **🎨 Interface moderne** : Interface propre et réactive avec l’éditeur Monaco pour la coloration syntaxique
- **📱 Compatible mobile** : Fonctionne parfaitement sur ordinateurs et appareils mobiles

## 🚀 Démarrage rapide

### Prérequis

- Python 3.9 ou supérieur
- Git
- Clé API OpenAI

### Installation

1. **Clonez le dépôt :**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Installez les dépendances :**
   ```bash
   pip install -r requirements.txt
   ```

3. **Configurez les variables d’environnement :**
   ```bash
   # Créez le fichier .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Lancez l’application :**
   ```bash
   python app.py
   ```

5. **Ouvrez votre navigateur :**
   Rendez-vous sur `http://localhost:8000`

## 🛠️ Fonctionnement

1. **Traitement de l’URL** : Accédez à n’importe quel dépôt en remplaçant 'github.com' par 'gitcontainer.com' dans l’URL
2. **Clonage du dépôt** : Gitcontainer clone localement le dépôt GitHub via Git
3. **Analyse du code** : Utilise [gitingest](https://github.com/cyclotruc/gitingest) pour analyser la structure du dépôt et extraire les informations pertinentes
4. **Génération IA** : Envoie l’analyse à OpenAI GPT-4 avec des prompts spécialisés pour la génération du Dockerfile
5. **Optimisation intelligente** : L’IA prend en compte :
   - Détection du stack technologique
   - Gestion des dépendances
   - Bonnes pratiques de sécurité
   - Constructions multi-étapes si bénéfique
   - Configuration des ports
   - Variables d’environnement
   - Health checks

## 📁 Structure du projet

```
cyclotruc-gitcontainer/
├── app.py                 # Application principale FastAPI
├── requirements.txt       # Dépendances Python
├── .env                  # Variables d’environnement (à créer)
├── static/               # Fichiers statiques (icônes, CSS)
├── templates/
│   └── index.jinja       # Modèle HTML principal
└── tools/                # Modules de fonctionnalité principale
    ├── __init__.py
    ├── create_container.py  # Génération du Dockerfile par IA
    ├── git_operations.py    # Clonage du dépôt GitHub
    └── gitingest.py        # Analyse du dépôt
```

## 🔧 Configuration

### Variables d'environnement

| Variable | Description | Obligatoire |
|----------|-------------|-------------|
| `OPENAI_API_KEY` | Votre clé API OpenAI | Oui |
| `PORT` | Port du serveur (défaut : 8000) | Non |
| `HOST` | Hôte du serveur (défaut : 0.0.0.0) | Non |

### Utilisation avancée

Vous pouvez utiliser les outils de manière programmatique :

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Cloner le dépôt
    clone_result = await clone_repo_tool(github_url)
    
    # Analyser avec gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Générer le Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Utilisation
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Personnalisation

### Ajouter des instructions personnalisées

Utilisez la fonctionnalité "Instructions supplémentaires" pour personnaliser la génération :

- `"Utiliser Alpine Linux pour une taille d’image réduite"`
- `"Inclure Redis et PostgreSQL"`
- `"Optimiser pour un déploiement en production"`
- `"Ajouter des outils de développement pour le débogage"`

## 📝 Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.

## 🙏 Remerciements

- **[OpenAI](https://openai.com/)** pour la mise à disposition de l’API GPT-4
- **[gitingest](https://github.com/cyclotruc/gitingest)** pour les capacités d’analyse de dépôts
- **[FastAPI](https://fastapi.tiangolo.com/)** pour l’excellent framework web
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** pour la coloration syntaxique du code

## 🔗 Liens

- **Dépôt GitHub** : [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Démo** : Essayez-le en direct avec des dépôts d’exemple
- **Issues** : [Signaler des bugs ou demander des fonctionnalités](https://github.com/cyclotruc/gitcontainer/issues)

---

**Réalisé avec ❤️ par [Romain Courtois](https://github.com/cyclotruc)**

*Transformez n’importe quel dépôt en conteneur en quelques secondes !*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---