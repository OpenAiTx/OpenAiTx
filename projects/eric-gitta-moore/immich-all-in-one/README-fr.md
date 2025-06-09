# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Plan de migrer ultérieurement vers ente-io/ente car j'ai besoin de S3 pour stocker les photos~~
> 
> ente a finalement trop peu de fonctionnalités
> 
> Passage à l’utilisation de juicedata/juicefs pour monter S3

## Présentation du projet

Ce projet est une solution d'amélioration des capacités IA du système de gestion de photos [Immich](https://github.com/immich-app/immich). Les fonctionnalités natives d'Immich sont principalement étendues via les composants suivants :

- **inference-gateway** : service passerelle écrit en Go, responsable de la répartition intelligente des requêtes de machine learning d’Immich
- **mt-photos-ai** : service IA basé sur Python et FastAPI, intégrant les modèles RapidOCR et cn-clip
- Extension des fonctions d’Immich, dont la recherche OCR, le retraitement AI unitaire des médias, le tri hybride avec les vecteurs texte OCR et CLIP
- Ajout de la segmentation chinoise zhparser à PostgreSQL

## Fonctionnalités principales

### 1. Reconnaissance de texte OCR et recherche

- Utilisation de RapidOCR pour reconnaître le texte dans les images
- Prise en charge de la reconnaissance de texte mixte chinois-anglais
- Fonction de recherche basée sur le contenu textuel des images

### 2. Traitement de vecteurs d’image CLIP

- Correspondance image-texte chinois plus précise basée sur le modèle cn-clip
- Prise en charge de la recherche sémantique pour une précision accrue

### 3. Retraitement AI unitaire des médias

- Re-génération des données OCR pour une seule image/vidéo
- Re-génération des vecteurs CLIP pour une seule image/vidéo
- Possibilité de rafraîchir manuellement en cas de résultats non précis

## Architecture du système

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ requêtes OCR/CLIP
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (service Python)│
                     │                  │
                     └──────────────────┘
```

## Détail des composants

### inference-gateway

Service passerelle écrit en Go, responsabilités principales :
- Reçoit les requêtes ML d’Immich
- Transfère les requêtes OCR et CLIP vers le service mt-photos-ai selon le type
- Transfère les autres requêtes ML (ex : reconnaissance faciale) vers le service ML natif d’Immich
- Gère l’authentification et la conversion de formats de données

### mt-photos-ai

Service IA écrit en Python et FastAPI, fournit :
- API de reconnaissance de texte OCR (basé sur RapidOCR)
- API de traitement de vecteurs CLIP (basé sur cn-clip)
- Prise en charge de l’accélération GPU

## Guide de déploiement

### Prérequis

- Docker et Docker Compose
- GPU NVIDIA (optionnel, mais recommandé pour accélérer le traitement)
- Espace de stockage suffisant

### Guide de configuration

1. **Configuration de inference-gateway**

Principales variables d’environnement :
```
IMMICH_API=http://localhost:3003  # Adresse de l’API Immich
MT_PHOTOS_API=http://localhost:8060  # Adresse du service mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # Clé API
PORT=8080  # Port d’écoute de la passerelle
```

2. **Configuration de mt-photos-ai**

Principales variables d’environnement :
```
CLIP_MODEL=ViT-B-16  # Nom du modèle CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # Chemin de téléchargement du modèle
DEVICE=cuda  # ou cpu, appareil d’inférence
HTTP_PORT=8060  # Port d’écoute du service
```

### Étapes de déploiement

1. Cloner le dépôt :
```bash
git clone https://github.com/votre-utilisateur/immich-all-in-one.git
cd immich-all-in-one
```

2. Démarrer les services :
```bash
docker-compose up -d
```

## Mode d’emploi

1. **Configurer Immich pour utiliser le service ML personnalisé**

Dans le fichier de configuration d’Immich, pointer l’adresse du service ML vers inference-gateway :
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Utilisation de la recherche OCR**

- Dans la barre de recherche Immich, utiliser le préfixe `ocr:` pour effectuer une recherche OCR
- Par exemple : `ocr:facture` recherchera les photos contenant le mot "facture" dans l’image

3. **Retraitement AI unitaire des médias**

- Sur la page de détails d’une photo, cliquer sur le menu
- Choisir "Re-générer les données OCR" ou "Re-générer les vecteurs CLIP"
- Le système retraitera les données AI de la photo

## Guide de développement

### inference-gateway (Go)

Compiler et exécuter :
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Mise en place de l’environnement de développement :
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Licence

Ce projet est open source sous licence MIT.

## Remerciements

- [Immich](https://github.com/immich-app/immich) - Solution open source d’auto-hébergement pour la sauvegarde de photos et vidéos
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Bibliothèque OCR multiplateforme basée sur PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modèle de pré-entraînement de comparaison multimodale pour le chinois

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---