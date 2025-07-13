# 🖼️ Outils de traitement d’images HEIC

Une collection d’outils Python pour le traitement des fichiers HEIC (High Efficiency Image Container), avec un accent sur l’extraction de contenu HDR et la conversion en EXR.

## 🛠️ Aperçu des outils

### 1. gain_map_extract.py
Extrait tous les composants des fichiers HEIC, y compris :
- Images de base
- Cartes de gain HDR
- Cartes de profondeur
- Métadonnées complètes (EXIF, XMP, profils ICC)

### 2. heic_to_exr.py
Convertit les fichiers HEIC au format OpenEXR :
- Combine l’image de base et la carte de gain en un EXR HDR selon la méthode Apple
- Préserve toute la plage dynamique
- Conserve les métadonnées lorsque c’est possible
- Prend en charge le traitement par lot
### 3. merge_to_exr.sh
Script Shell pour le traitement par lots :
- Automatise la conversion de HEIC en EXR
- Gère plusieurs fichiers
- Fournit un retour d’information sur la progression
- Conserve la structure des dossiers

## 🔧 Installation

### Prérequis
- Python 3.8 ou version supérieure
- pip (gestionnaire de paquets Python)
- Git (pour cloner le dépôt)

### macOS
```bash
# Installer Homebrew si ce n’est pas déjà fait
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# Installer Python et les dépendances OpenEXR
brew install python3 openexr

# Cloner le dépôt
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Créer et activer l'environnement virtuel
python3 -m venv venv
source venv/bin/activate

# Installer les dépendances Python
pip install -r requirements.txt
```

### Linux (Ubuntu/Debian)
```bash
# Installer les dépendances système
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# Cloner le dépôt
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Créer et activer un environnement virtuel
python3 -m venv venv
source venv/bin/activate

# Installer les dépendances Python
pip install -r requirements.txt
```

### Windows
```powershell
# Installer Python depuis https://www.python.org/downloads/
# Installer Git depuis https://git-scm.com/download/win

# Cloner le dépôt
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Créer et activer un environnement virtuel
python -m venv venv
.\venv\Scripts\activate

# Installer les dépendances Python
pip install -r requirements.txt
```

## 📋 Prérequis
Tous les paquets Python requis sont listés dans requirements.txt :
- Pillow : Bibliothèque de traitement d’images
- pillow-heif : Prise en charge des fichiers HEIC
- numpy : Opérations numériques
- defusedxml : Analyse XML sécurisée

Dépendances système (installées via le gestionnaire de paquets) :
- OpenEXR et OpenImageIO (oiiotool) pour la gestion des fichiers EXR

## 💻 Utilisation
### Extraction de la carte de gain
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### Conversion HEIC vers EXR
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### Traitement par lot
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 Fichiers de sortie

### Sorties de gain_map_extract.py :
- Image de base : `{filename}_base.tiff`
- Cartes de gain : `{filename}_gain_map_{id}.tiff`
- Cartes de profondeur : `{filename}_depth_{index}.tiff`
- Métadonnées : `{filename}_metadata.json`

### Sorties de heic_to_exr.py :
- Fichier EXR HDR : `{filename}.exr`

## 🔍 Utilisation avancée

### Gestion des métadonnées
- Les données binaires sont encodées en base64
- Les profils ICC sont conservés
- Les données EXIF sont préservées lorsque cela est possible

### Traitement HDR
- Les gain maps sont correctement mis à l’échelle
- L’espace colorimétrique linéaire est maintenu
- Toute la plage dynamique est préservée dans la sortie EXR

## ⚠️ Limitations connues
- Certaines variantes HEIC peuvent ne pas être entièrement prises en charge
- L’extraction de la carte de profondeur est limitée aux appareils compatibles
- La prise en charge d’OpenEXR sur Windows peut nécessiter une configuration supplémentaire
## 🤝 Contribuer
Les contributions sont les bienvenues ! N'hésitez pas à soumettre une Pull Request.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---