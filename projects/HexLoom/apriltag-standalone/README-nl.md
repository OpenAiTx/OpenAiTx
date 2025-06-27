# AprilTag-zelfstandige detectiebibliotheek

Dit is een AprilTag-herkenningspakket gebaseerd op de pupil-apriltags-bibliotheek, bedoeld voor detectie en tracking van AprilTags in camerabeelden.

<!-- Keep these links. Translations will automatically update with the README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Vereiste bibliotheken

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Installatie

1. Zorg dat je een Python-omgeving hebt geïnstalleerd
2. Installeer de benodigde afhankelijkheden:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Gebruik

### Basisgebruik

```python
import cv2
from apriltag import Detector, DetectorOptions

# Maak een detector aan
options = DetectorOptions(
    families="tag36h11",  # Tag-familie
    border=1,             # Randgrootte van de tag
    nthreads=4,           # Aantal threads
    quad_decimate=1.0,    # Factor voor beeldresolutieverlaging
    quad_blur=0.0,        # Gaussiaanse blur-factor
    refine_edges=True     # Randen verfijnen
)
detector = Detector(options)

# Lees afbeelding in
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Detecteer AprilTag
detections = detector.detect(gray)

# Toon detectieresultaat
for detection in detections:
    print(f"Tag-familie: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Locatie: {detection.center}")
    print(f"Hoekpunten: {detection.corners}")
```

### Detectieresultaten tekenen

```python
import numpy as np
from apriltag import draw_detection_results

# Cameramatrix en vervormingscoëfficiënten
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Teken detectieresultaten
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Toon resultaat
cv2.imshow("AprilTag-detectie", result_img)
cv2.waitKey(0)
```

### Testscript uitvoeren

Er is een eenvoudig testscript beschikbaar om de AprilTag-detectie te verifiëren:

```bash
python test_apriltag.py
```

Hiermee wordt de standaard webcam geopend en worden AprilTags realtime gedetecteerd. Druk op "q" om af te sluiten.

## Ondersteunde tag-families

De pupil-apriltags-bibliotheek ondersteunt de volgende tag-families:
- tag36h11 (standaard)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Opmerkingen

- Voor betere prestaties kun je de parameters in DetectorOptions aanpassen
- Op apparaten met beperkte rekenkracht kun je de quad_decimate-parameter verhogen om de rekensnelheid te verbeteren
- Zorg dat de maat van de gebruikte AprilTag-markering overeenkomt met de tag_size-parameter in de code
- Voor het tekenen van 3D-coördinaten is een nauwkeurige cameracalibratie vereist

## Functiekenmerken

- Ondersteunt realtime AprilTag-detectie met USB-camera
- Berekent en toont de 3D-positie (positie en oriëntatie) van de tag
- Ondersteunt het opslaan van originele en gemarkeerde afbeeldingen
- Volledig configureerbaar, inclusief camerainstellingen
- Inclusief volledige cameracalibratietool
- Geen ROS vereist, pure Python-implementatie van de originele ROS-package

## Installatiestappen

### 1. Installeer de AprilTag C-bibliotheek

De C-bibliotheek van AprilTag is vereist. Installeer deze als volgt:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windows-gebruikers moeten zelf compileren of een voorgecompileerd binair bestand downloaden en zorgen dat `apriltag.dll` zich in het systeem-PATH of de huidige map bevindt.

### 2. Installeer Python-afhankelijkheden

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Gebruiksaanwijzing

### Snel starten (aanbevolen)

De eenvoudigste manier is het uitvoeren van de geïntegreerde tool, die een interactief menu biedt om je door alle stappen te leiden:

```bash
python apriltag_tool.py
```

Deze tool biedt de volgende menu-opties:
1. Genereer een schaakbord-calibratiepatroon
2. Cameracalibratie
3. AprilTag-detectie
4. Bekijk de handleiding

Volg gewoon de aanwijzingen in het menu om het hele proces af te ronden.

### Cameracalibratie

Voer eerst een cameracalibratie uit om nauwkeurige cameragegevens te verkrijgen voordat je AprilTag-detectie gebruikt:

```bash
# Genereer eerst het schaakbordpatroon
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Print het schaakbord uit, meet de werkelijke vierkantsgrootte, en voer calibratie uit
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Uitleg van de parameters:

**Schaakbordgenerator (create_chessboard.py):**
- `--size`: Aantal binnenhoekpunten, breedte x hoogte (standaard: 9x6)
- `--square`: Grootte van de vierkanten, in pixels (standaard: 100)
- `--output`: Uitvoerpadafbeelding (standaard: chessboard.png)
- `--dpi`: DPI van uitvoerafbeelding (standaard: 300), beïnvloedt de printgrootte

**Cameracalibratieprogramma (camera_calibration.py):**
- `--size`: Aantal binnenhoekpunten van het schaakbord, breedte x hoogte (standaard: 9x6)
- `--square`: Grootte van het schaakbordvierkant, in meters (standaard: 0.025)
- `--output`: Uitvoerbestandspad (standaard: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: Cameradevice ID (standaard: 0)
- `--width`: Opnamebreedte van de camera (standaard: 1280)
- `--height`: Opnamehoogte van de camera (standaard: 720)
- `--samples`: Aantal benodigde samples voor calibratie (standaard: 20)
- `--preview`: Voorbeeld van correctie tonen na calibratie

Calibratieproces:
1. Genereer en print het schaakbordpatroon
2. Meet de werkelijke vierkantsgrootte (in meters)
3. Start het calibratieprogramma, plaats het schaakbord voor de camera en verzamel samples vanuit verschillende hoeken
4. Het programma detecteert automatisch het schaakbord en verzamelt samples, of druk op 's' om het huidige frame handmatig op te slaan
5. Na het verzamelen van voldoende samples worden de cameragegevens automatisch berekend en opgeslagen in het opgegeven bestand

### AprilTag-detectie

Na calibratie kun je het AprilTag-detectieprogramma uitvoeren:
```bash
python apriltag_detector.py
```

### Geavanceerd gebruik

```bash
python apriltag_detector.py [pad naar configuratiebestand] --camera cameraID --width breedte --height hoogte --camera_info camerakalibratiebestand
```

Parameteruitleg:
- `pad naar configuratiebestand`: Pad naar het AprilTag-configuratiebestand (standaard: `config/vision/tags_36h11_all.json`)
- `--camera`: Camera apparaat ID (standaard: 0)
- `--camera_info`: Pad naar het camerakalibratiebestand (standaard: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Breedte van de cameracaptatie (standaard: 1280)
- `--height`: Hoogte van de cameracaptatie (standaard: 720)

### Toetsenbediening

- `q`: Programma afsluiten

## Uitleg configuratiebestand

Alle systeeminstellingen kunnen worden aangepast in het bestand `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Tag familie
        "size": 0.05,              // Fysieke grootte van de tag (eenheid: meter)
        "threads": 2,              // Aantal verwerkingsthreads
        "max_hamming": 0,          // Maximale Hamming-afstand
        "z_up": true,              // Z-as omhoog
        "decimate": 1.0,           // Downsampling factor afbeelding
        "blur": 0.8,               // Vervagingsfactor
        "refine_edges": 1,         // Randen verfijnen
        "debug": 0                 // Debugmodus aan/uit
    },

    "Camera": {
        "device_id": 0,            // Camera apparaat ID
        "width": 1280,             // Camerabreedte (resolutie)
        "height": 720,             // Camerahoogte (resolutie)
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Camerakalibratiebestand
    },

    "Archive": {
        "enable": true,            // Data-archivering inschakelen
        "preview": true,           // Voorbeeldvenster tonen
        "save_raw": false,         // Ruwe beelden opslaan
        "save_pred": false,        // Voorspelde beelden opslaan
        "path": "./data/table_tracking"  // Pad voor het opslaan van data
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lijst van referentietag-ID's
        "moving_tags": [4, 5, 6],            // Lijst van bewegende tag-ID's
        "require_initialization": true,       // Initialisatie vereist
        "tag_positions": {                    // Vooraf ingestelde tagposities (indien aanwezig)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Door het configuratiebestand aan te passen kun je:
1. AprilTag-detectorparameters configureren
2. Cameraparameters instellen (apparaat-ID, resolutie, kalibratiebestand)
3. Opties voor data-archivering instellen
4. Referentie- en bewegende tag-ID's zelf bepalen
5. Controleren of initialisatie nodig is (stel `require_initialization` in op `false` om de initialisatiestap over te slaan)
6. Positie-informatie van tags vooraf instellen

### Gebruik

Heel eenvoudig: start het systeem met één commando:

```
python table_tracking.py
```

Gebruik een eigen configuratiebestand:

```
python table_tracking.py --config pad/naar/eigen_config.json
```

Na het starten kun je op de 'i'-toets drukken om handmatig het initialisatieproces te starten.

## Veelgestelde vragen

1. **Kan de apriltag-bibliotheek niet vinden**
   
   Zorg ervoor dat de apriltag-bibliotheek correct is geïnstalleerd en dat het bibliotheekbestand vindbaar is in het systeem.

2. **Camera kan niet worden geopend**
   
   Controleer of het camera-apparaat ID klopt en of de camera niet door een ander programma wordt gebruikt.

3. **Detectieresultaat is onnauwkeurig**
   
   Zorg ervoor dat de camera goed is gekalibreerd en dat de taggrootte in het configuratiebestand correct is.

## Uitleg bestandsstructuur

```
apriltag_standalone/
├── apriltag.py              # Kerncode van de AprilTag-bibliotheek
├── apriltag_detector.py     # Hoofdprogramma AprilTag-detectie
├── apriltag_tool.py         # Tool voor startmenu
├── camera_calibration.py    # Camerakalibratieprogramma
├── create_chessboard.py     # Hulpmiddel voor schaakbordgeneratie
├── configs.py               # Configuratiebestandbeheer
├── config/                  # Configuratiemap
│   ├── camera/              # Cameraconfiguratie
│   │   └── HSK_200W53_1080P.yaml  # Camerakalibratiebestand
│   └── vision/              # Visieconfiguratie
│       └── tags_36h11_all.json # AprilTag-configuratiebestand
├── README.md                # Documentatie
└── requirements.txt         # Python-afhankelijkheden
```

## Technische toelichting

Dit project is een zelfstandige versie van het ROS AprilTag-detectiepakket, zonder ROS-afhankelijkheden, maar met behoud van de kernfunctionaliteit.
Belangrijkste gebruikte technieken:

- OpenCV: beeldverwerking, camerakalibratie en posebepaling
- AprilTag C-bibliotheek: tagdetectie
- SciPy: rotatiematrix- en quaternionconversie

## Licentie

Dit project is gelicenseerd onder de MIT-licentie

## Uitleg nieuwe functies

### Multi-tag tracking en occlusieafhandeling

Het systeem ondersteunt nu de volgende nieuwe functies:

1. **Foto-initialisatie**: Na het starten van het systeem wordt automatisch éénmalig geïnitialiseerd met een foto, waarbij de relatieve posities van tags worden vastgelegd, inclusief:
   - Posities van vaste referentietags (ID 0-3)
   - Relatie tussen meerdere bewegende tags (standaard ID 4,5,6)

2. **Occlusieafhandeling**: Na initialisatie, zelfs als sommige tags niet zichtbaar zijn:
   - Als referentietags zijn afgedekt, kan het systeem de positie van de afgedekte tag schatten op basis van andere zichtbare referentietags
   - Als bewegende tags zijn afgedekt, kan het systeem de positie van de afgedekte bewegende tag schatten op basis van andere zichtbare bewegende tags

3. **Multi-tag tracking**: Ondersteuning voor het gelijktijdig volgen van meerdere bewegende tags, standaard ID 4,5,6
   - Indien de onderlinge positie van bewegende tags vast is, kan de positie van de overige tags worden geschat als er minimaal één zichtbaar is
   - ID's van bewegende tags kunnen naar wens worden ingesteld in het configuratiebestand

### Uitleg configuratiebestand

Alle systeeminstellingen kunnen worden aangepast in het bestand `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lijst van referentietag-ID's
        "moving_tags": [4, 5, 6],            // Lijst van bewegende tag-ID's
        "require_initialization": true,       // Initialisatie vereist
        "tag_positions": {                    // Vooraf ingestelde tagposities (indien aanwezig)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Door het configuratiebestand aan te passen kun je:
1. Zelf de ID's van referentie- en bewegende tags bepalen
2. Controleren of initialisatie nodig is (stel `require_initialization` in op `false` om de initialisatiestap over te slaan)
3. Positie-informatie van tags vooraf instellen

### Gebruik

1. Start het systeem met de standaardconfiguratie:
   ```
   python table_tracking.py
   ```

2. Start het systeem met een eigen configuratiebestand:
   ```
   python table_tracking.py --config pad/naar/eigen_config.json
   ```

3. Handmatige initialisatie: druk tijdens het draaien van het systeem op de 'i'-toets

### Eisen voor gebruik

Zorg ervoor dat alle tags zichtbaar zijn tijdens de initialisatie; het systeem legt dan de onderlinge positie van de tags vast. Na initialisatie kan het systeem de positie van alle tags correct schatten, zelfs als sommige tags worden afgedekt.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---