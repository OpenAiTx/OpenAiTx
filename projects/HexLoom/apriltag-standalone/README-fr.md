# Bibliothèque de détection AprilTag autonome

Il s'agit d'un outil de reconnaissance AprilTag basé sur la bibliothèque pupil-apriltags, destiné à la détection et au suivi d'AprilTag dans les images de caméra.

<!-- Gardez ces liens. Les traductions se mettront automatiquement à jour avec le README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Dépendances

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Installation

1. Assurez-vous que l'environnement Python est installé
2. Installez les dépendances nécessaires :

```bash
pip install opencv-python numpy pupil-apriltags
```

## Utilisation

### Utilisation de base

```python
import cv2
from apriltag import Detector, DetectorOptions

# Créer un détecteur
options = DetectorOptions(
    families="tag36h11",  # Famille de tags
    border=1,             # Taille de la bordure du tag
    nthreads=4,           # Nombre de threads
    quad_decimate=1.0,    # Facteur de sous-échantillonnage de l'image
    quad_blur=0.0,        # Coefficient de flou gaussien
    refine_edges=True     # Raffiner les bords ou non
)
detector = Detector(options)

# Lire une image
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Détecter les AprilTag
detections = detector.detect(gray)

# Afficher les résultats de la détection
for detection in detections:
    print(f"Famille du tag : {detection.tag_family}, ID : {detection.tag_id}")
    print(f"Position : {detection.center}")
    print(f"Coins : {detection.corners}")
```

### Dessiner les résultats de la détection

```python
import numpy as np
from apriltag import draw_detection_results

# Matrice intrinsèque de la caméra et coefficients de distorsion
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Dessiner les résultats de la détection
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Afficher le résultat
cv2.imshow("Détection AprilTag", result_img)
cv2.waitKey(0)
```

### Exécuter le script de test

Un script de test simple est fourni pour vérifier la fonctionnalité de détection AprilTag :

```bash
python test_apriltag.py
```

Cela ouvrira la caméra par défaut de l'ordinateur et détectera les AprilTag en temps réel. Appuyez sur la touche "q" pour quitter.

## Familles de tags prises en charge

La bibliothèque pupil-apriltags prend en charge les familles de tags suivantes :
- tag36h11 (par défaut)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Remarques

- Pour de meilleures performances, ajustez les paramètres dans DetectorOptions
- Pour les appareils à ressources limitées, envisagez d'augmenter le paramètre quad_decimate pour réduire la complexité de calcul
- Assurez-vous que la taille physique du marqueur AprilTag correspond au paramètre tag_size dans le code
- Le dessin des axes 3D nécessite des paramètres de caméra précis

## Fonctionnalités

- Prise en charge de la détection AprilTag en temps réel avec une caméra USB
- Calcul et affichage de la pose 3D du tag (position et orientation)
- Prise en charge de la sauvegarde des images brutes et annotées
- Configuration et paramètres de caméra personnalisables
- Outil complet d'étalonnage de caméra inclus
- Indépendant de ROS, version Python autonome du package ROS d'origine

## Étapes d'installation

### 1. Installer la bibliothèque C AprilTag

La bibliothèque C AprilTag est requise. Veuillez suivre les étapes ci-dessous pour l'installer :

#### Ubuntu/Debian :
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows :
Les utilisateurs Windows doivent compiler eux-mêmes ou télécharger un binaire précompilé et s'assurer que `apriltag.dll` est dans le PATH système ou le répertoire courant.

### 2. Installer les dépendances Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Guide d'utilisation

### Démarrage rapide (recommandé)

La façon la plus simple de commencer est d'exécuter l'outil intégré, qui fournit un menu interactif pour vous guider à travers toutes les étapes :

```bash
python apriltag_tool.py
```

Cet outil propose les options de menu suivantes :
1. Générer une planche d'étalonnage à damier
2. Étalonnage de la caméra
3. Détection AprilTag
4. Voir la documentation d'aide

Il suffit de suivre les instructions du menu pour compléter le processus.

### Étalonnage de la caméra

Avant d'utiliser la détection AprilTag, il est recommandé de calibrer la caméra pour obtenir des paramètres précis :

```bash
# Générer d'abord la planche d'étalonnage à damier
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Imprimez la grille et mesurez la taille réelle des carrés, puis effectuez l'étalonnage
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Explication des paramètres :

**Outil de génération de damier (create_chessboard.py) :**
- `--size` : Nombre de points d'intersection internes du damier, largeur x hauteur (défaut : 9x6)
- `--square` : Taille des cases, en pixels (défaut : 100)
- `--output` : Chemin du fichier de sortie (défaut : chessboard.png)
- `--dpi` : DPI de l'image de sortie (défaut : 300), influence la taille à l'impression

**Programme d'étalonnage de caméra (camera_calibration.py) :**
- `--size` : Nombre de points d'intersection internes du damier, largeur x hauteur (défaut : 9x6)
- `--square` : Taille des cases du damier, en mètres (défaut : 0.025)
- `--output` : Chemin du fichier de sortie (défaut : config/camera/HSK_200W53_1080P.yaml)
- `--camera` : ID du périphérique caméra (défaut : 0)
- `--width` : Largeur de capture de la caméra (défaut : 1280)
- `--height` : Hauteur de capture de la caméra (défaut : 720)
- `--samples` : Nombre d'échantillons requis pour l'étalonnage (défaut : 20)
- `--preview` : Aperçu du résultat de la calibration après l'étalonnage

Processus d'étalonnage :
1. Générer et imprimer la planche d'étalonnage à damier
2. Mesurer la taille réelle des cases (en mètres)
3. Exécuter le programme d'étalonnage, placer le damier devant la caméra et collecter des images sous différents angles
4. Le programme détectera automatiquement le damier et collectera des échantillons, vous pouvez aussi appuyer sur 's' pour sauvegarder manuellement la frame courante
5. Après avoir collecté suffisamment d'échantillons, le programme calculera automatiquement les paramètres de la caméra et les enregistrera dans le fichier spécifié

### Détection AprilTag

Après l'étalonnage, vous pouvez exécuter le programme de détection AprilTag :
```bash
python apriltag_detector.py
```

### Utilisation avancée

```bash
python apriltag_detector.py [chemin_du_fichier_de_configuration] --camera ID_de_la_caméra --width largeur --height hauteur --camera_info fichier_paramètres_camera
```

Explication des paramètres :
- `chemin_du_fichier_de_configuration` : chemin du fichier de configuration AprilTag (par défaut : `config/vision/tags_36h11_all.json`)
- `--camera` : ID de l'appareil photo (par défaut : 0)
- `--camera_info` : chemin du fichier des paramètres internes de la caméra (par défaut : `config/camera/HSK_200W53_1080P.yaml`)
- `--width` : largeur de capture de la caméra (par défaut : 1280)
- `--height` : hauteur de capture de la caméra (par défaut : 720)

### Contrôle par clavier

- `q` : quitter le programme

## Explication du fichier de configuration

Toutes les configurations du système peuvent être paramétrées dans le fichier `config/vision/table_setup.json` :

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Famille de tags
        "size": 0.05,              // Taille physique du tag (en mètres)
        "threads": 2,              // Nombre de threads de traitement
        "max_hamming": 0,          // Distance de Hamming maximale
        "z_up": true,              // Axe Z vers le haut
        "decimate": 1.0,           // Facteur de sous-échantillonnage de l'image
        "blur": 0.8,               // Facteur de flou
        "refine_edges": 1,         // Affiner les contours
        "debug": 0                 // Activer le mode debug
    },

    "Camera": {
        "device_id": 0,            // ID de l'appareil photo
        "width": 1280,             // Résolution largeur de la caméra
        "height": 720,             // Résolution hauteur de la caméra
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Fichier de paramètres de calibration de la caméra
    },

    "Archive": {
        "enable": true,            // Activer l'archivage des données
        "preview": true,           // Afficher la fenêtre de prévisualisation
        "save_raw": false,         // Sauvegarder les images brutes
        "save_pred": false,        // Sauvegarder les images prédites
        "path": "./data/table_tracking"  // Chemin de sauvegarde des données
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Liste des IDs des tags de référence
        "moving_tags": [4, 5, 6],            // Liste des IDs des tags mobiles
        "require_initialization": true,       // Nécessite une initialisation
        "tag_positions": {                    // Positions prédéfinies des tags (si existantes)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

En modifiant le fichier de configuration, vous pouvez :
1. Configurer les paramètres du détecteur AprilTag
2. Définir les paramètres de la caméra (ID de l'appareil, résolution, fichier de calibration)
3. Configurer les options d'archivage des données
4. Personnaliser les IDs des tags de référence et des tags mobiles
5. Contrôler la nécessité de l'initialisation (mettre `require_initialization` à `false` pour sauter l'étape d'initialisation)
6. Prédéfinir les positions des tags

### Utilisation

C'est très simple, un seul commande suffit pour démarrer le système :

```
python table_tracking.py
```

Si vous souhaitez utiliser un fichier de configuration personnalisé :

```
python table_tracking.py --config chemin_du_fichier_de_configuration_personnalisé
```

Après le lancement du système, vous pouvez appuyer à tout moment sur la touche 'i' pour déclencher manuellement le processus d'initialisation.

## FAQ

1. **Bibliothèque apriltag introuvable**
   
   Assurez-vous que la bibliothèque apriltag est correctement installée et que les fichiers sont accessibles sur votre système.

2. **Impossible d’ouvrir la caméra**
   
   Vérifiez que l’ID de l’appareil photo est correct et que la caméra n’est pas utilisée par un autre programme.

3. **Résultats de détection inexacts**
   
   Assurez-vous que votre caméra est bien calibrée et que la taille du tag dans le fichier de configuration est correcte.


## Structure des fichiers

```
apriltag_standalone/
├── apriltag.py              # Code principal de la bibliothèque de détection AprilTag
├── apriltag_detector.py     # Programme principal de détection AprilTag
├── apriltag_tool.py         # Menu de lancement des outils intégrés
├── camera_calibration.py    # Programme de calibration de la caméra
├── create_chessboard.py     # Outil de génération d'échiquier
├── configs.py               # Gestion des fichiers de configuration
├── config/                  # Répertoire de configuration
│   ├── camera/              # Configurations caméra
│   │   └── HSK_200W53_1080P.yaml  # Paramètres de la caméra
│   └── vision/              # Configurations vision
│       └── tags_36h11_all.json # Configuration AprilTag
├── README.md                # Documentation
└── requirements.txt         # Dépendances Python
```

## Explication technique

Ce projet est une version indépendante portée du paquet de détection ROS AprilTag, sans dépendance ROS, ne conservant que les fonctionnalités principales.
Il utilise principalement les technologies suivantes :

- OpenCV : traitement d’image, calibration de caméra et estimation de pose
- Bibliothèque C AprilTag : détection des tags
- SciPy : conversion matrice de rotation/quaternions

## Licence

Ce projet est sous licence MIT.

## Nouveautés

### Suivi multi-tags et gestion des occultations

Le système prend désormais en charge les fonctionnalités suivantes :

1. **Initialisation par prise de vue** : Après le démarrage, le système effectue automatiquement une initialisation par prise de vue pour enregistrer la relation spatiale entre les tags, incluant :
   - La position des tags de référence fixes (ID 0-3)
   - Les relations relatives entre plusieurs tags mobiles (par défaut ID 4,5,6)

2. **Gestion des occultations** : Après l’initialisation, même si certains tags sont masqués :
   - Si un tag de référence est occulté, le système peut estimer sa position à l’aide des autres tags de référence visibles
   - Si un tag mobile est occulté, le système peut estimer sa position à l’aide d’autres tags mobiles visibles

3. **Suivi multi-tags** : Prise en charge du suivi simultané de plusieurs tags mobiles, par défaut ID 4,5,6
   - Si la position relative entre les tags mobiles est fixe, il suffit qu’un seul soit visible pour estimer la position des autres
   - Les IDs des tags mobiles peuvent être personnalisés dans le fichier de configuration

### Explication du fichier de configuration

Toutes les configurations du système peuvent être paramétrées dans le fichier `config/vision/table_setup.json` :

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Liste des IDs des tags de référence
        "moving_tags": [4, 5, 6],            // Liste des IDs des tags mobiles
        "require_initialization": true,       // Nécessite une initialisation
        "tag_positions": {                    // Positions prédéfinies des tags (si existantes)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

En modifiant le fichier de configuration, vous pouvez :
1. Personnaliser les IDs des tags de référence et des tags mobiles
2. Contrôler la nécessité de l'initialisation (mettre `require_initialization` à `false` pour sauter l’étape d’initialisation)
3. Prédéfinir les positions des tags

### Utilisation

1. Démarrer le système avec la configuration par défaut :
   ```
   python table_tracking.py
   ```

2. Démarrer le système avec un fichier de configuration personnalisé :
   ```
   python table_tracking.py --config chemin_du_fichier_de_configuration_personnalisé
   ```

3. Initialisation manuelle : Appuyez sur la touche 'i' pendant l'exécution du système

### Exigences d'exécution

Assurez-vous que tous les tags sont visibles lors de l'initialisation, le système enregistrera la relation spatiale entre les tags. Après l'initialisation, même si certains tags sont masqués, le système pourra estimer correctement la position de tous les tags.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---