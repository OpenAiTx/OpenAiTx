# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Le plan est de migrer vers ente-io/ente, car j'ai besoin de s3 pour stocker les photos~~
> 
> ente a encore trop peu de fonctionnalités
> 
> Changement pour utiliser juicedata/juicefs pour monter s3

## Présentation du projet

Ce projet est une solution d'amélioration IA pour le système de gestion de photos [Immich](https://github.com/immich-app/immich). Il étend principalement les fonctionnalités natives d’Immich via les composants suivants :

- **inference-gateway** : passerelle écrite en Go, responsable de la répartition intelligente des requêtes de machine learning d’Immich
- **mt-photos-ai** : service IA basé sur Python et FastAPI, intégrant RapidOCR et le modèle cn-clip
- Extension des fonctions Immich, dont la recherche OCR et le retraitement AI d’un média, classement hybride OCR texte intégral et score de vecteur CLIP
- Ajout de zhparser à PostgreSQL pour la segmentation chinoise

## Fonctionnalités principales

### 1. Reconnaissance et recherche de texte OCR

- Utilise RapidOCR pour la reconnaissance de texte dans les images
- Prend en charge la reconnaissance de texte mixte chinois-anglais
- Permet la recherche basée sur le contenu textuel des images

### 2. Traitement des vecteurs d’image CLIP

- Améliore la correspondance image-texte en chinois grâce au modèle cn-clip
- Prend en charge la recherche sémantique, améliore la précision des résultats

### 3. Retraitement AI des données d’un média

- Permet de régénérer les données OCR d’une seule image/vidéo
- Permet de régénérer les vecteurs CLIP d’une seule image/vidéo
- Offre la possibilité de rafraîchir manuellement en cas de résultats inexacts

## Architecture système

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## Détails des composants

### inference-gateway

Service passerelle écrit en Go, principales responsabilités :
- Recevoir les requêtes de machine learning d’Immich
- Rediriger les requêtes OCR et CLIP vers le service mt-photos-ai selon le type de requête
- Rediriger les autres requêtes de machine learning (comme la reconnaissance faciale) vers le service de machine learning natif d’Immich
- Gérer l’authentification et la conversion des formats de données

### mt-photos-ai

Service IA écrit en Python et FastAPI, fournit :
- API de reconnaissance de texte OCR (basée sur RapidOCR)
- API de traitement de vecteurs CLIP (basée sur cn-clip)
- Prise en charge de l’accélération GPU

## Instructions de déploiement

### Prérequis

- Docker et Docker Compose
- GPU NVIDIA (optionnel, mais recommandé pour accélérer le traitement)
- Espace de stockage suffisant

### Explication de la configuration

1. **Configuration de inference-gateway**

Principales variables d’environnement :

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **Configuration de mt-photos-ai**

Principales variables d'environnement :

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Étapes de déploiement

1. Cloner le dépôt :

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Démarrer le service :

```bash
docker-compose up -d
```
## Instructions d'utilisation

1. **Configurer Immich pour utiliser un service ML personnalisé**

Dans le fichier de configuration d'Immich, pointez l'adresse du service de machine learning vers inference-gateway :

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Utilisation de la recherche OCR**

- Utilisez le préfixe `ocr:` dans la barre de recherche Immich pour effectuer une recherche OCR
- Par exemple : `ocr:facture` recherchera les photos contenant le texte "facture" dans l’image

3. **Re-traitement des données IA d’un média unique**

- Sur la page de détails de la photo, cliquez sur les options du menu
- Sélectionnez "Régénérer les données OCR" ou "Régénérer le vecteur CLIP"
- Le système va retraiter les données IA de cette photo

## Guide de développement

### inference-gateway (Go)

Compiler et exécuter :

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Configuration de l'environnement de développement :

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
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modèle pré-entraîné d’apprentissage contrastif multimodal en chinois



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---