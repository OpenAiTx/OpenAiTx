## 🛡️ LoLTrackGuard : Détection des comportements scriptés dans LoL

**LoLTrackGuard** est un système léger de détection des comportements suspects de la souris dans les vidéos de jeu *League of Legends*. Il combine la détection du curseur basée sur YOLOv8 avec un autoencodeur LSTM pour identifier les anomalies dans les mouvements du curseur — aucun journal de jeu ni outil invasif requis.

- 🎯 Entrée : vidéo de jeu 1080p 30FPS
- 🖱️ Étape 1 : Détecter les positions du curseur avec un modèle YOLO entraîné
- 📐 Étape 2 : Extraire et normaliser les caractéristiques de mouvement (vitesse, accélération, etc.)
- 🧠 Étape 3 : Alimenter l’autoencodeur LSTM pour attribuer un score d’anomalie
- 📊 Sortie : CSV avec scores d’anomalie par seconde

Entraîné sur des données de joueurs pros réels, LoLTrackGuard offre une méthode non intrusive pour signaler un comportement potentiellement automatisé dans les séquences de jeu.

---

## 📁 Structure du projet

```bash
LoLTrackGuard-MAIN/
├── cursor_templates/                # Cursor icon PNGs with transparency (for FakeDataGenerator)
├── extension/                       # C++/CUDA Acceleration Module
│   ├── setup.py                     # Build script
│   └── src/                         # C++ and CUDA source files
├── model/                           # Trained LSTM models for anomaly detection
│   ├── detection_model.keras        # Default trained LSTM model
│   ├── detection_model2.keras       # Alternate model versions
│   └── detection_model3.keras
├── mouse_positions/                # Output CSVs from cursorDetector with raw mouse position data
├── pipeline/                       # Core logic scripts
│   ├── analyzer.py                 # Runs analysis using a trained model
│   ├── cursorDetector.py          # Detects cursor in videos using YOLO and outputs CSV
│   ├── cursorDetector_accelerated.py # High-Performance version (C++/Numba)
│   ├── dataModifier.py            # Extracts motion features and normalizes them
│   └── modelTrainer.py            # Trains LSTM anomaly detection model
├── utils/                          # Resource files and utility scripts
│   ├── cursorDetector_x.pt        # Primary YOLOv8 model for cursor detection
│   ├── FakeDataGenerator.py       # Script to generate synthetic training data for YOLO
│   └── universal_scaler.joblib    # Saved standardizer for feature normalization
├── train_pipeline.py               # Full training pipeline: from video to trained model
├── analyze_pipeline.py             # Full analysis pipeline: from video to anomaly scores
├── requirements.txt                # Python dependencies
└── README.md                       # Project documentation
```

---

## ⚙️ Project Setup

### 1. Install Git LFS (for large model files)

```bash
# Install Git LFS from: https://git-lfs.github.com/
git lfs install
```

### 2. Installer les dépendances

```bash
pip install -r requirements.txt
```

---

## 🔍 Comment utiliser : Pipeline d'analyse (`analyze_pipeline.py`)

### 🎯 Objectif

Détecter les anomalies dans les mouvements de la souris à partir d'enregistrements de gameplay en utilisant un modèle pré-entraîné.

> ⚠️ **Important :** Votre vidéo d'entrée **doit être en 1080p 30 FPS** pour garantir une détection correcte du curseur et un alignement des caractéristiques.

### 🚀 Exécution

```bash
python analyze_pipeline.py
```

### 📊 Flux

```
1. Select a video file (e.g. MP4 screen recording with visible cursor)
2. Run YOLOv8 to detect and record mouse positions (X, Y, time)
3. Automatically extract movement features (velocity, acceleration, etc.)
4. Apply the pre-trained scaler to normalize features
5. Feed sequences into LSTM autoencoder
6. Calculate reconstruction error for each 1-second action
7. Save anomaly scores to CSV
```

### 📂 Sortie

- `analysis_results/` : Contient des fichiers CSV listant l'erreur de reconstruction par action  
- Chaque ligne correspond à une séquence d'une seconde (30 images), indiquant le niveau d'anomalie


## 🧠 Entraînez Votre Propre Modèle

Si vous souhaitez entraîner votre propre modèle autoencodeur LSTM :

1. Utilisez `pipeline/dataModifier.py` pour extraire les caractéristiques de vos fichiers CSV bruts de positions de souris.
2. Utilisez `utils/universal_scaler.joblib` pour normaliser les vecteurs de caractéristiques.
3. Utilisez `pipleline/modelTrainer.py` pour entraîner un nouveau modèle sur les séquences traitées.

> 💡 **Astuce** : Assurez-vous que vos vidéos d'entrée sont systématiquement en **1080p 30 FPS**.

---

## 🧪 Comment Cela Fonctionne

### 1. Détection du Curseur via YOLOv8 et Données Synthétiques

**Pourquoi le Curseur ?**  
Le but de ce projet est d’analyser des séquences de jeu à la première personne provenant de streamers ou créateurs de contenu. Comparé au comportement des personnages, les trajectoires du curseur de souris fournissent un signal plus direct et fiable pour détecter un éventuel scripting.

Fichiers de **curseur de souris** collectés et **replays de jeux** utilisés comme arrière-plans

Utilisation de `FakeDataGenerator.py` pour générer plus de **70 000 images synthétiques étiquetées** :  
- Chaque image est surimposée avec un modèle de curseur sélectionné aléatoirement  
- La taille, la luminosité, la saturation et le flou global du curseur sont aléatoires

Ces images bruitées mais étiquetées ont ensuite servi à entraîner un **modèle de détection d’objets basé sur YOLOv8** capable de détecter les positions de souris dans des vidéos de jeu réelles.

### 🖼️ Figure 1 : Exemple de Détection de Curseur  
![exemple de détection de curseur](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/1.png)  
---

### 2. Modélisation Comportementale via Autoencodeur LSTM

Pour éviter tout jugement subjectif dans l’identification des tricheurs, utilisez un **autoencodeur LSTM** entraîné uniquement sur des **données humaines vérifiées** (parties sans triche).

Le modèle apprend à reconstruire les **patrons normaux de mouvement de la souris humaine**. Lors de l’inférence, il signale toute séquence avec une **erreur de reconstruction** élevée comme une anomalie potentielle, sans nécessiter de définition manuelle de règles.

### 🧠 Figure 2 : Diagramme de l’Autoencodeur LSTM
![LSTM](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/2.png)

---

### 3. Ingénierie des caractéristiques avec des données de joueurs professionnels réels

Collecte de **50 replays à la première personne de joueurs professionnels de LoL**, extrayant plus de **1,5 million de mouvements de souris**.

Les coordonnées brutes du curseur sont traitées à l’aide de `dataModifier.py`, qui :
- Extrait des caractéristiques conçues à partir des données brutes (X, Y)
- Remplace les timestamps absolus par des deltas temporels
- Calcule la vélocité, l’accélération (X/Y), la vitesse angulaire et la distance de déplacement par frame
- Applique `universal_scaler.joblib` pour la normalisation

Les mouvements sont segmentés en **séquences de 30 étapes chacune** (1 seconde de mouvement à 30 FPS), représentant des actions utilisateur atomiques.

Ces plus de 500 000 séquences d’action sont utilisées pour entraîner le LSTM.

---

### 4. Évaluation des résultats via l’erreur de reconstruction

Après exécution complète du pipeline d’analyse, le script `analyzer.py` traite les séquences de caractéristiques extraites à l’aide de l’autoencodeur LSTM entraîné.

Pour chaque action (une séquence d’une seconde de mouvement de souris), le modèle calcule une **erreur de reconstruction** :

- **Erreur faible** → comportement similaire aux patrons humains appris
- **Erreur élevée** → comportement anormal et potentiellement scripté ou assisté

Cela permet une évaluation quantitative et objective des comportements suspects en jeu.

Les résultats sont sauvegardés dans `analysis_results/` sous forme de fichiers CSV, où chaque ligne correspond à une action détectée avec son score d’anomalie associé.

### 🎮 Figure 3 : Mouvement de souris d’un joueur pro (non vu pendant l’entraînement)
![Pro Player Data (Unseen During Training](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/3.png)

### 👤 Figure 4 : Mouvement de la souris d’un joueur régulier
![Données du joueur régulier](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/4.png)

### ⚠️ Figure 5 : Mouvement suspect de la souris en jeu
![Données de jeu suspect](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/5.png)

---

## 🚀 Mode haute performance (C++/CUDA)

LoLTrackGuard inclut désormais une chaîne de traitement accélérée.

### Fonctionnalités
- **Accélération hybride** : Utilise automatiquement `Numba` (JIT CUDA) et `Threading` si l’extension C++ n’est pas compilée.
- **Décodage vidéo asynchrone** : Sépare la lecture de l’inférence.
- **Kernels CUDA personnalisés** : Filtres de pré-traitement pour mettre en évidence les candidats curseurs.

### Installation (Extension C++ optionnelle)
Pour des performances maximales, vous pouvez compiler l’extension native C++ :

1. Assurez-vous que le `CUDA Toolkit` et `Visual Studio` (MSVC) sont installés.
2. Configurez les chemins OpenCV dans `extension/setup.py`.
3. Exécutez :
   ```bash
   cd extension
   python setup.py install
   cd ..
   ```

### Utilisation
Exécutez le détecteur accéléré :
```bash
python pipeline/cursorDetector_accelerated.py
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-15

---