# Memvid - Mémoire IA Basée sur la Vidéo 🧠📹

**La solution légère et révolutionnaire pour la mémoire IA à grande échelle**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid révolutionne la gestion de la mémoire pour l’IA en encodant les données textuelles en vidéos, permettant une **recherche sémantique ultra-rapide** sur des millions de fragments de texte avec des **temps de récupération inférieurs à la seconde**. Contrairement aux bases de données vectorielles traditionnelles qui consomment énormément de RAM et de stockage, Memvid compresse votre base de connaissance en fichiers vidéo compacts tout en maintenant un accès instantané à toute information.

## 🎥 Démonstration

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Principales fonctionnalités

- 🎥 **Vidéo comme Base de Données** : Stockez des millions de fragments de texte dans un seul fichier MP4
- 🔍 **Recherche Sémantique** : Trouvez le contenu pertinent avec des requêtes en langage naturel
- 💬 **Chat Intégré** : Interface conversationnelle avec des réponses contextuelles
- 📚 **Support PDF** : Import et indexation directe de documents PDF
- 🚀 **Récupération Rapide** : Recherche en moins d’une seconde sur des ensembles de données massifs
- 💾 **Stockage Efficace** : Compression 10x par rapport aux bases de données classiques
- 🔌 **LLMs Modulaire** : Fonctionne avec OpenAI, Anthropic ou des modèles locaux
- 🌐 **Offline-First** : Aucune connexion Internet nécessaire après la génération des vidéos
- 🔧 **API Simple** : Commencez en seulement 3 lignes de code

## 🎯 Cas d’utilisation

- **📖 Bibliothèques Numériques** : Indexez des milliers de livres dans un seul fichier vidéo
- **🎓 Contenus Éducatifs** : Créez des mémoires vidéo consultables pour les supports de cours
- **📰 Archives de Presse** : Compressez des années d’articles dans des bases de données vidéo faciles à gérer
- **💼 Connaissance d’Entreprise** : Construisez des bases de connaissances consultables à l’échelle de l’entreprise
- **🔬 Publications Scientifiques** : Recherche sémantique rapide dans la littérature scientifique
- **📝 Notes Personnelles** : Transformez vos notes en assistant IA consultable

## 🚀 Pourquoi Memvid ?

### Innovation Révolutionnaire
- **Vidéo comme Base de Données** : Stockez des millions de fragments de texte dans un seul fichier MP4
- **Récupération Instantanée** : Recherche sémantique en moins d’une seconde sur de grands ensembles de données
- **Efficacité de Stockage 10x** : La compression vidéo réduit considérablement l’empreinte mémoire
- **Zéro Infrastructure** : Pas de serveur de base de données, juste des fichiers que vous pouvez copier n’importe où
- **Offline-First** : Fonctionne entièrement hors-ligne une fois les vidéos générées

### Architecture Légère
- **Dépendances Minimales** : Fonctionnalité principale en ~1000 lignes de Python
- **Optimisé CPU** : Fonctionne efficacement sans nécessiter de GPU
- **Portable** : Un seul fichier vidéo contient toute votre base de connaissance
- **Diffusable** : Les vidéos peuvent être diffusées depuis un stockage cloud

## 📦 Installation

### Installation Rapide
```bash
pip install memvid
```

### Pour le support PDF
```bash
pip install memvid PyPDF2
```

### Configuration recommandée (Environnement Virtuel)
```bash
# Créer un nouveau dossier de projet
mkdir my-memvid-project
cd my-memvid-project

# Créer un environnement virtuel
python -m venv venv

# L’activer
# Sur macOS/Linux :
source venv/bin/activate
# Sur Windows :
venv\Scripts\activate

# Installer memvid
pip install memvid

# Pour le support PDF :
pip install PyPDF2
```

## 🎯 Démarrage Rapide

### Utilisation de Base
```python
from memvid import MemvidEncoder, MemvidChat

# Créer une mémoire vidéo à partir de fragments de texte
chunks = ["Fait important 1", "Fait important 2", "Détails d’un événement historique"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Discuter avec votre mémoire
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Que sais-tu des événements historiques ?")
print(response)
```

### Créer une mémoire à partir de documents
```python
from memvid import MemvidEncoder
import os

# Charger des documents
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Ajouter des fichiers texte
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Générer une vidéo optimisée
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Plus de FPS = plus de fragments par seconde
    frame_size=512  # Plus grande taille de frame = plus de données par frame
)
```

### Recherche & Récupération Avancées
```python
from memvid import MemvidRetriever

# Initialiser le récupérateur
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Recherche sémantique
results = retriever.search("algorithmes d’apprentissage automatique", top_k=5)
for chunk, score in results:
    print(f"Score : {score:.3f} | {chunk[:100]}...")

# Obtenir une fenêtre de contexte
context = retriever.get_context("expliquer les réseaux de neurones", max_tokens=2000)
print(context)
```

### Interface Chat Interactive
```python
from memvid import MemvidInteractive

# Lancer l’interface chat interactive
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Ouvre l’interface web sur http://localhost:7860
```

### Tester avec file_chat.py
Le script `examples/file_chat.py` fournit un moyen complet de tester Memvid avec vos propres documents :

```bash
# Traiter un dossier de documents
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Traiter des fichiers spécifiques
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Utiliser la compression H.265 (nécessite Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Fragmentation personnalisée pour les gros documents
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Charger une mémoire existante
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Exemple Complet : Discuter avec un livre PDF
```bash
# 1. Créer un nouveau dossier et configurer l’environnement
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Sur Windows : venv\Scripts\activate

# 2. Installer les dépendances
pip install memvid PyPDF2

# 3. Créer book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Votre fichier PDF
book_pdf = "book.pdf"  # Remplacez par le chemin de votre PDF

# Construire la mémoire vidéo
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Discuter avec le livre
api_key = os.getenv("OPENAI_API_KEY")  # Optionnel : pour les réponses IA
```python
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Exécutez-le
export OPENAI_API_KEY="votre-clé-api"  # Optionnel
python book_chat.py
```

## 🛠️ Configuration avancée

### Embeddings personnalisés
```python
from sentence_transformers import SentenceTransformer

# Utiliser un modèle d'embedding personnalisé
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Optimisation vidéo
```python
# Pour une compression maximale
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Plus d'images par seconde
    frame_size=256,  # Images plus petites
    video_codec='h265',  # Meilleure compression
    crf=28  # Qualité de compression (plus bas = meilleure qualité)
)
```

### Traitement distribué
```python
# Traiter de grands ensembles de données en parallèle
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Dépannage

### Problèmes courants

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Assurez-vous d'utiliser le bon Python
which python  # Doit afficher le chemin de votre environnement virtuel
# Sinon, activez votre environnement virtuel :
source venv/bin/activate  # Sous Windows : venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**Problèmes de clé API LLM**
```bash
# Définir votre clé API (à obtenir sur https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Ou sous Windows :
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Traitement de PDF volumineux**
```python
# Pour les très gros PDF, utilisez des tailles de fragments plus petites
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Contribuer

Nous accueillons les contributions ! Veuillez consulter notre [Guide de contribution](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) pour plus de détails.

```bash
# Exécuter les tests
pytest tests/

# Exécuter avec la couverture
pytest --cov=memvid tests/

# Formater le code
black memvid/
```

## 🆚 Comparaison avec les solutions traditionnelles

| Fonctionnalité        | Memvid    | Bases de données vectorielles | Bases de données traditionnelles |
|----------------------|-----------|------------------------------|----------------------------------|
| Efficacité de stockage | ⭐⭐⭐⭐⭐    | ⭐⭐                          | ⭐⭐⭐                             |
| Complexité de mise en place | Simple | Complexe                     | Complexe                        |
| Recherche sémantique  | ✅        | ✅                           | ❌                              |
| Utilisation hors ligne| ✅        | ❌                           | ✅                              |
| Portabilité           | Basé sur fichier | Basé sur serveur             | Basé sur serveur                |
| Scalabilité           | Millions  | Millions                    | Milliards                       |
| Coût                  | Gratuit   | $$$$                        | $$$                             |


## 📚 Exemples

Consultez le répertoire [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) pour :
- Construire une mémoire à partir de dumps Wikipedia
- Créer une base de connaissances personnelle
- Prise en charge multilingue
- Mises à jour mémoire en temps réel
- Intégration avec les LLMs populaires

## 🆘 Obtenir de l'aide

- 📖 [Documentation](https://github.com/olow304/memvid/wiki) - Guides complets
- 💬 [Discussions](https://github.com/olow304/memvid/discussions) - Posez vos questions
- 🐛 [Suivi des problèmes](https://github.com/olow304/memvid/issues) - Signalez des bugs
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Partagez vos projets

## 🔗 Liens

- [Dépôt GitHub](https://github.com/olow304/memvid)
- [Paquet PyPI](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 Licence

Licence MIT - voir le fichier [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) pour plus de détails.

## 🙏 Remerciements

Créé par [Olow304](https://github.com/olow304) et la communauté Memvid.

Développé avec ❤️ grâce à :
- [sentence-transformers](https://www.sbert.net/) - Embeddings de pointe pour la recherche sémantique
- [OpenCV](https://opencv.org/) - Vision par ordinateur et traitement vidéo
- [qrcode](https://github.com/lincolnloop/python-qrcode) - Génération de QR codes
- [FAISS](https://github.com/facebookresearch/faiss) - Recherche de similarité efficace
- [PyPDF2](https://github.com/py-pdf/pypdf) - Extraction de texte PDF

Un grand merci à tous les contributeurs qui améliorent Memvid !

---

**Prêt à révolutionner la gestion de la mémoire de votre IA ? Installez Memvid et commencez à bâtir !** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---