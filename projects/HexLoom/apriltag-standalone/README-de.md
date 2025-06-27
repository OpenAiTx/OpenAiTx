# AprilTag Standalone-Erkennungsbibliothek

Dies ist ein auf der pupil-apriltags-Bibliothek basierendes AprilTag-Erkennungs-Toolkit zur Detektion und Verfolgung von AprilTags in Kamerabildern.

<!-- Diese Links bitte beibehalten. Übersetzungen aktualisieren sich automatisch mit der README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Abhängigkeiten

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Installation

1. Stellen Sie sicher, dass Python installiert ist
2. Installieren Sie die notwendigen Abhängigkeiten:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Anwendung

### Grundlegende Verwendung

```python
import cv2
from apriltag import Detector, DetectorOptions

# Erstellen des Detektors
options = DetectorOptions(
    families="tag36h11",  # Tag-Familie
    border=1,             # Tag-Randgröße
    nthreads=4,           # Anzahl der Threads
    quad_decimate=1.0,    # Bild-Dezimierungsfaktor
    quad_blur=0.0,        # Gaußscher Unschärfefaktor
    refine_edges=True     # Kantenverfeinerung
)
detector = Detector(options)

# Bild einlesen
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# AprilTag erkennen
detections = detector.detect(gray)

# Ergebnisse anzeigen
for detection in detections:
    print(f"Tag-Familie: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Position: {detection.center}")
    print(f"Eckpunkte: {detection.corners}")
```

### Detektionsergebnisse zeichnen

```python
import numpy as np
from apriltag import draw_detection_results

# Kameramatrix und Verzerrungskoeffizienten
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Ergebnisse zeichnen
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Ergebnis anzeigen
cv2.imshow("AprilTag-Erkennung", result_img)
cv2.waitKey(0)
```

### Test-Skript ausführen

Ein einfaches Testskript steht zur Verfügung, um die AprilTag-Erkennung zu überprüfen:

```bash
python test_apriltag.py
```

Dies öffnet die Standardkamera des Computers und erkennt AprilTags in Echtzeit. Mit der Taste "q" beenden.

## Unterstützte Tag-Familien

Die pupil-apriltags-Bibliothek unterstützt folgende Tag-Familien:
- tag36h11 (Standard)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Hinweise

- Für bessere Performance können die Parameter in DetectorOptions angepasst werden
- Auf Geräten mit begrenzten Ressourcen kann quad_decimate erhöht werden, um die Komplexität zu verringern
- Stellen Sie sicher, dass die Größe des verwendeten AprilTags mit dem tag_size-Parameter im Code übereinstimmt
- Das Zeichnen der 3D-Achsen erfordert genaue Kameraparameter

## Funktionsmerkmale

- Echtzeit-AprilTag-Erkennung mit USB-Kameras
- Berechnung und Anzeige der 3D-Position und -Orientierung des Tags
- Speicherung von Original- und markierten Bildern möglich
- Anpassbare Konfiguration und Kameraparameter
- Vollständiges Kamerakalibrierungswerkzeug enthalten
- Kein ROS erforderlich, reine Python-Version des ursprünglichen ROS-Pakets

## Installationsschritte

### 1. Installation der AprilTag-C-Bibliothek

Die C-Bibliothek von AprilTag ist erforderlich. Bitte wie folgt installieren:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windows-Nutzer müssen selbst kompilieren oder vorgefertigte Binärdateien herunterladen und sicherstellen, dass sich `apriltag.dll` im System-PATH oder im aktuellen Verzeichnis befindet.

### 2. Installation der Python-Abhängigkeiten

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Gebrauchsanweisung

### Schnellstart (empfohlen)

Am einfachsten nutzen Sie das integrierte Tool mit interaktivem Menü, das Sie durch alle Schritte führt:

```bash
python apriltag_tool.py
```

Das Tool bietet folgende Menüoptionen:
1. Schachbrett-Kalibrierungsfeld generieren
2. Kamerakalibrierung
3. AprilTag-Erkennung
4. Hilfedokument anzeigen

Folgen Sie einfach den Menüanweisungen, um den gesamten Prozess abzuschließen.

### Kamerakalibrierung

Vor der AprilTag-Erkennung wird empfohlen, die Kamera zu kalibrieren, um genaue Parameter zu erhalten:

```bash
# Zuerst das Schachbrett erzeugen
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Schachbrett ausdrucken und tatsächliche Feldgröße messen, dann Kalibrierung durchführen
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Parametererklärung:

**Schachbrett-Generator (create_chessboard.py):**
- `--size`: Anzahl der inneren Eckpunkte des Schachbretts, Breite x Höhe (Standard: 9x6)
- `--square`: Kantenlänge der Felder in Pixel (Standard: 100)
- `--output`: Ausgabepfad der Datei (Standard: chessboard.png)
- `--dpi`: DPI des Ausgabebildes (Standard: 300), beeinflusst die Druckgröße

**Kamerakalibrierung (camera_calibration.py):**
- `--size`: Anzahl der inneren Eckpunkte des Schachbretts, Breite x Höhe (Standard: 9x6)
- `--square`: Kantenlänge der Schachbrettfelder in Metern (Standard: 0.025)
- `--output`: Ausgabepfad der Datei (Standard: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: Kamera-Geräte-ID (Standard: 0)
- `--width`: Aufnahmebreite der Kamera (Standard: 1280)
- `--height`: Aufnahmehöhe der Kamera (Standard: 720)
- `--samples`: Anzahl der für die Kalibrierung benötigten Bilder (Standard: 20)
- `--preview`: Vorschau des Kalibrierungsergebnisses nach Abschluss

Ablauf der Kalibrierung:
1. Schachbrett erzeugen und ausdrucken
2. Tatsächliche Feldgröße messen (in Metern)
3. Kalibrierungsprogramm starten, Schachbrett vor die Kamera halten und aus verschiedenen Winkeln Bilder aufnehmen
4. Das Programm erkennt das Schachbrett automatisch und sammelt Muster, alternativ kann mit 's' das aktuelle Bild manuell gespeichert werden
5. Nach ausreichend Mustern werden die Kameraparameter berechnet und in der angegebenen Datei gespeichert

### AprilTag-Erkennung

Nach Abschluss der Kalibrierung kann das AprilTag-Erkennungsprogramm gestartet werden:
```bash
python apriltag_detector.py
```

### Erweiterte Nutzung

```bash
python apriltag_detector.py [Pfad zur Konfigurationsdatei] --camera KameraID --width Breite --height Höhe --camera_info Kameraparameterdatei
```

Parameterbeschreibung:
- `Pfad zur Konfigurationsdatei`: Pfad zur AprilTag-Konfigurationsdatei (Standard: `config/vision/tags_36h11_all.json`)
- `--camera`: Kamera-Geräte-ID (Standard: 0)
- `--camera_info`: Pfad zur Kameraintrinsik-Datei (Standard: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Aufnahmebreite der Kamera (Standard: 1280)
- `--height`: Aufnahmehöhe der Kamera (Standard: 720)

### Tastatursteuerung

- `q`: Programm beenden

## Konfigurationsdatei-Erklärung

Alle Systemeinstellungen können in der Datei `config/vision/table_setup.json` vorgenommen werden:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Tag-Familie
        "size": 0.05,              // Physikalische Größe des Tags (Einheit: Meter)
        "threads": 2,              // Anzahl Verarbeitungsthreads
        "max_hamming": 0,          // Maximale Hamming-Distanz
        "z_up": true,              // Z-Achse nach oben
        "decimate": 1.0,           // Bild-Dezimation
        "blur": 0.8,               // Unschärfefaktor
        "refine_edges": 1,         // Kantennachbearbeitung
        "debug": 0                 // Debugmodus aktivieren
    },

    "Camera": {
        "device_id": 0,            // Kamera-Geräte-ID
        "width": 1280,             // Kamera-Bildbreite
        "height": 720,             // Kamera-Bildhöhe
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Pfad zur Kamerakalibrierungsdatei
    },

    "Archive": {
        "enable": true,            // Datenarchivierung aktivieren
        "preview": true,           // Vorschaufenster anzeigen
        "save_raw": false,         // Rohbild speichern
        "save_pred": false,        // Vorhersagebild speichern
        "path": "./data/table_tracking"  // Speicherpfad für Daten
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Liste der Referenz-Tag-IDs
        "moving_tags": [4, 5, 6],            // Liste der beweglichen Tag-IDs
        "require_initialization": true,       // Initialisierung erforderlich
        "tag_positions": {                    // Voreingestellte Tag-Positionen (falls vorhanden)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Durch Anpassen der Konfigurationsdatei können Sie:
1. Parameter des AprilTag-Detektors konfigurieren
2. Kameraparameter festlegen (Geräte-ID, Auflösung, Parameterdatei)
3. Optionen zur Datenarchivierung konfigurieren
4. Referenz- und bewegliche Tag-IDs individuell festlegen
5. Steuern, ob eine Initialisierung erforderlich ist (setze `require_initialization` auf `false`, um die Initialisierung zu überspringen)
6. Voreingestellte Tag-Positionsdaten definieren

### Anwendung

Sehr einfach, das System wird mit nur einem Befehl gestartet:

```
python table_tracking.py
```

Falls eine benutzerdefinierte Konfigurationsdatei verwendet werden soll:

```
python table_tracking.py --config Pfad_zur_eigenen_Konfigurationsdatei
```

Nach dem Systemstart kann der Initialisierungsprozess jederzeit manuell mit der Taste 'i' ausgelöst werden.

## FAQ (Häufige Fragen)

1. **AprilTag-Bibliothek nicht gefunden**
   
   Stellen Sie sicher, dass die AprilTag-Bibliothek korrekt installiert ist und die Bibliotheksdatei im System gefunden werden kann.

2. **Kamera kann nicht geöffnet werden**
   
   Prüfen Sie, ob die Kamera-Geräte-ID korrekt ist und ob die Kamera nicht von einem anderen Programm verwendet wird.

3. **Unpräzise Detektionsergebnisse**
   
   Stellen Sie sicher, dass Ihre Kamera korrekt kalibriert ist und die Tag-Größe in der Konfiguration stimmt.


## Verzeichnisstruktur

```
apriltag_standalone/
├── apriltag.py              # Kerncode der AprilTag-Detektion
├── apriltag_detector.py     # Hauptprogramm für AprilTag-Detektion
├── apriltag_tool.py         # Startmenü für integrierte Werkzeuge
├── camera_calibration.py    # Kamerakalibrierung
├── create_chessboard.py     # Schachbrett-Generator
├── configs.py               # Konfigurationsdatei-Verarbeitung
├── config/                  # Konfigurationsverzeichnis
│   ├── camera/              # Kamera-Konfiguration
│   │   └── HSK_200W53_1080P.yaml  # Kameraparameter
│   └── vision/              # Visuelle Konfiguration
│       └── tags_36h11_all.json # AprilTag-Konfiguration
├── README.md                # Dokumentation
└── requirements.txt         # Python-Abhängigkeiten
```

## Technische Hinweise

Dieses Projekt ist eine eigenständige Portierung des ROS AprilTag-Detection-Pakets und entfernt die ROS-Abhängigkeit bei Beibehaltung der Kernfunktionen.
Hauptsächlich werden folgende Technologien verwendet:

- OpenCV: Bildverarbeitung, Kamerakalibrierung und Pose-Schätzung
- AprilTag C-Bibliothek: Tag-Erkennung
- SciPy: Umwandlung von Rotationsmatrizen und Quaternionen

## Lizenz

Dieses Projekt steht unter der MIT-Lizenz.

## Neue Funktionen

### Mehrfach-Tag-Tracking und Okklusionsbehandlung

Das System unterstützt jetzt folgende neue Funktionen:

1. **Initialisierung per Foto**: Nach dem Systemstart erfolgt automatisch eine Initialisierung per Bildaufnahme, um die Lagebeziehungen der Tags zu erfassen, darunter:
   - Positionen der festen Referenz-Tags (ID 0-3)
   - Relative Lage mehrerer beweglicher Tags (Standard: ID 4,5,6)

2. **Okklusionsbehandlung**: Nach der Initialisierung, auch wenn manche Tags verdeckt sind:
   - Wenn Referenz-Tags verdeckt sind, kann das System die Position der verdeckten Tags anhand der sichtbaren Referenz-Tags schätzen
   - Wenn bewegliche Tags verdeckt sind, kann das System die Position der verdeckten beweglichen Tags anhand anderer sichtbarer beweglicher Tags schätzen

3. **Mehrfach-Tag-Tracking**: Gleichzeitiges Tracking mehrerer beweglicher Tags wird unterstützt, standardmäßig ID 4,5,6
   - Wenn die Relativpositionen der beweglichen Tags zueinander fest sind, genügt es, dass einer sichtbar ist, um die Position der anderen zu schätzen
   - Bewegliche Tag-IDs sind in der Konfigurationsdatei anpassbar

### Konfigurationsdatei-Erklärung

Alle Systemeinstellungen können in der Datei `config/vision/table_setup.json` vorgenommen werden:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Liste der Referenz-Tag-IDs
        "moving_tags": [4, 5, 6],            // Liste der beweglichen Tag-IDs
        "require_initialization": true,       // Initialisierung erforderlich
        "tag_positions": {                    // Voreingestellte Tag-Positionen (falls vorhanden)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Durch Anpassen der Konfigurationsdatei können Sie:
1. Referenz- und bewegliche Tag-IDs individuell festlegen
2. Steuern, ob eine Initialisierung erforderlich ist (setze `require_initialization` auf `false`, um die Initialisierung zu überspringen)
3. Voreingestellte Tag-Positionsdaten definieren

### Anwendung

1. System mit Standardkonfiguration starten:
   ```
   python table_tracking.py
   ```

2. System mit benutzerdefinierter Konfigurationsdatei starten:
   ```
   python table_tracking.py --config Pfad_zur_eigenen_Konfigurationsdatei
   ```

3. Manuelle Initialisierung: Während des Betriebs Taste 'i' drücken

### Betriebsbedingungen

Stellen Sie sicher, dass beim Initialisieren alle Tags sichtbar sind – das System speichert die relativen Positionen der Tags. Nach der Initialisierung kann das System auch bei teilweiser Tag-Okklusion alle Positionen zuverlässig schätzen.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---