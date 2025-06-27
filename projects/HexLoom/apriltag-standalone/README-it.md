# Libreria di rilevamento AprilTag indipendente

Questo è un toolkit di riconoscimento AprilTag basato sulla libreria pupil-apriltags, utilizzato per il rilevamento e il tracciamento degli AprilTag nella videocamera.

<!-- Mantieni questi link. Le traduzioni si aggiorneranno automaticamente con il README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Librerie dipendenti

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Installazione

1. Assicurarsi che l'ambiente Python sia installato
2. Installare le dipendenze necessarie:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Modalità d'uso

### Utilizzo di base

```python
import cv2
from apriltag import Detector, DetectorOptions

# Crea il rilevatore
options = DetectorOptions(
    families="tag36h11",  # Famiglia del tag
    border=1,             # Dimensione del bordo del tag
    nthreads=4,           # Numero di thread
    quad_decimate=1.0,    # Fattore di sottocampionamento dell'immagine
    quad_blur=0.0,        # Fattore di sfocatura gaussiana
    refine_edges=True     # Raffinamento dei bordi
)
detector = Detector(options)

# Leggi l'immagine
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Rileva l'AprilTag
detections = detector.detect(gray)

# Mostra i risultati del rilevamento
for detection in detections:
    print(f"Famiglia del tag: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Posizione: {detection.center}")
    print(f"Vertici: {detection.corners}")
```

### Disegnare i risultati del rilevamento

```python
import numpy as np
from apriltag import draw_detection_results

# Matrice dei parametri interni della camera e coefficienti di distorsione
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Disegna i risultati del rilevamento
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Mostra il risultato
cv2.imshow("Rilevamento AprilTag", result_img)
cv2.waitKey(0)
```

### Eseguire lo script di test

È fornito uno script di test semplice, che può essere utilizzato per verificare la funzionalità di rilevamento degli AprilTag:

```bash
python test_apriltag.py
```

Questo aprirà la videocamera predefinita del computer e rileverà gli AprilTag in tempo reale. Premi il tasto "q" per uscire.

## Famiglie di tag supportate

La libreria pupil-apriltags supporta le seguenti famiglie di tag:
- tag36h11 (predefinito)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Note

- Per migliori prestazioni, è possibile regolare i parametri in DetectorOptions
- Nei dispositivi con risorse computazionali limitate, è possibile aumentare il parametro quad_decimate per ridurre la complessità computazionale
- Assicurarsi che la dimensione dell'AprilTag utilizzato corrisponda al parametro tag_size nel codice
- Per disegnare gli assi 3D sono necessari parametri della camera accurati

## Caratteristiche

- Supporto per il rilevamento in tempo reale di AprilTag tramite webcam USB
- Calcolo e visualizzazione della posa 3D (posizione e orientamento) del tag
- Supporto per il salvataggio dell'immagine originale e di quella con marcatura
- Configurazione e parametri della camera completamente personalizzabili
- Include strumenti completi per la calibrazione della camera
- Non dipende da ROS, versione standalone in puro Python del pacchetto ROS originale

## Passaggi di installazione

### 1. Installare la libreria C di AprilTag

La libreria C di AprilTag è necessaria. Seguire i passaggi seguenti per l'installazione:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Gli utenti Windows devono compilare autonomamente o scaricare i file binari precompilati e assicurarsi che `apriltag.dll` sia incluso nel PATH di sistema o nella directory corrente.

### 2. Installare le dipendenze Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Istruzioni per l'uso

### Avvio rapido (consigliato)

Il modo più semplice per iniziare è eseguire lo strumento integrato, che fornisce un menu interattivo per guidarti attraverso tutti i passaggi:

```bash
python apriltag_tool.py
```

Questo strumento fornirà le seguenti opzioni di menu:
1. Genera la scacchiera di calibrazione
2. Calibrazione della camera
3. Rilevamento AprilTag
4. Visualizza la documentazione di aiuto

Segui semplicemente le istruzioni del menu per completare l'intero processo.

### Calibrazione della camera

Prima di utilizzare il rilevamento AprilTag, si consiglia di calibrare la camera per ottenere parametri di calibrazione accurati:

```bash
# Per prima cosa genera la scacchiera di calibrazione
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Stampa la scacchiera e misura la dimensione reale delle celle, poi esegui la calibrazione
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Descrizione dei parametri:

**Strumento di generazione scacchiera (create_chessboard.py):**
- `--size`: numero di punti interni della scacchiera, larghezza x altezza (predefinito: 9x6)
- `--square`: dimensione della cella, pixel (predefinito: 100)
- `--output`: percorso file di output (predefinito: chessboard.png)
- `--dpi`: DPI dell'immagine di output (predefinito: 300), influisce sulla dimensione di stampa

**Programma di calibrazione della camera (camera_calibration.py):**
- `--size`: numero di punti interni della scacchiera, larghezza x altezza (predefinito: 9x6)
- `--square`: dimensione della cella della scacchiera, in metri (predefinito: 0.025)
- `--output`: percorso file di output (predefinito: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: ID del dispositivo della camera (predefinito: 0)
- `--width`: larghezza di acquisizione della camera (predefinito: 1280)
- `--height`: altezza di acquisizione della camera (predefinito: 720)
- `--samples`: numero di campioni richiesti per la calibrazione (predefinito: 20)
- `--preview`: anteprima della correzione dopo la calibrazione

Procedura di calibrazione:
1. Genera e stampa la scacchiera di calibrazione
2. Misura la dimensione reale delle celle (in metri)
3. Esegui il programma di calibrazione e posiziona la scacchiera davanti alla camera, acquisendo campioni da diverse angolazioni
4. Il programma rileverà automaticamente la scacchiera e raccoglierà i campioni; puoi anche premere il tasto 's' per salvare manualmente il fotogramma corrente
5. Dopo aver raccolto un numero sufficiente di campioni, il programma calcolerà automaticamente i parametri della camera e li salverà nel file specificato

### Rilevamento AprilTag

Dopo la calibrazione, è possibile eseguire il programma di rilevamento AprilTag:
```bash
python apriltag_detector.py
```

### Utilizzo Avanzato

```bash
python apriltag_detector.py [percorso file di configurazione] --camera ID_camera --width larghezza --height altezza --camera_info file_parametri_camera
```

Spiegazione dei parametri:
- `percorso file di configurazione`: Percorso del file di configurazione AprilTag (predefinito: `config/vision/tags_36h11_all.json`)
- `--camera`: ID del dispositivo della fotocamera (predefinito: 0)
- `--camera_info`: Percorso del file dei parametri intrinseci della fotocamera (predefinito: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Larghezza di acquisizione della fotocamera (predefinito: 1280)
- `--height`: Altezza di acquisizione della fotocamera (predefinito: 720)

### Controllo tramite tasti

- `q`: Esci dal programma

## Spiegazione del file di configurazione

Tutte le impostazioni del sistema possono essere configurate nel file `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Famiglia del tag
        "size": 0.05,              // Dimensione fisica del tag (unità: metri)
        "threads": 2,              // Numero di thread di elaborazione
        "max_hamming": 0,          // Distanza massima di Hamming
        "z_up": true,              // Asse Z rivolto verso l'alto
        "decimate": 1.0,           // Fattore di sottocampionamento dell'immagine
        "blur": 0.8,               // Fattore di sfocatura
        "refine_edges": 1,         // Raffinamento dei bordi
        "debug": 0                 // Modalità debug
    },

    "Camera": {
        "device_id": 0,            // ID del dispositivo della fotocamera
        "width": 1280,             // Risoluzione in larghezza della fotocamera
        "height": 720,             // Risoluzione in altezza della fotocamera
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // File dei parametri di calibrazione della fotocamera
    },

    "Archive": {
        "enable": true,            // Abilitare l'archiviazione dei dati
        "preview": true,           // Mostrare la finestra di anteprima
        "save_raw": false,         // Salvare l'immagine grezza
        "save_pred": false,        // Salvare l'immagine predetta
        "path": "./data/table_tracking"  // Percorso di salvataggio dei dati
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista degli ID dei tag di riferimento
        "moving_tags": [4, 5, 6],            // Lista degli ID dei tag mobili
        "require_initialization": true,       // Necessità di inizializzazione
        "tag_positions": {                    // Posizioni preimpostate dei tag (se presenti)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Modificando il file di configurazione, puoi:
1. Configurare i parametri del rilevatore AprilTag
2. Impostare i parametri della fotocamera (ID dispositivo, risoluzione, file parametri)
3. Configurare le opzioni di archiviazione dati
4. Personalizzare gli ID dei tag di riferimento e dei tag mobili
5. Controllare la necessità di inizializzazione (imposta `require_initialization` su `false` per saltare l'inizializzazione)
6. Preimpostare la posizione dei tag

### Modalità d'uso

Molto semplice, basta un solo comando per avviare il sistema:

```
python table_tracking.py
```

Se vuoi utilizzare un file di configurazione personalizzato:

```
python table_tracking.py --config percorso_file_configurazione_personalizzato
```

Dopo l'avvio del sistema, puoi premere il tasto 'i' in qualsiasi momento per avviare manualmente il processo di inizializzazione.

## Domande frequenti

1. **Impossibile trovare la libreria apriltag**
   
   Assicurati che la libreria apriltag sia installata correttamente e che i file della libreria siano accessibili dal sistema.

2. **Impossibile aprire la fotocamera**
   
   Controlla che l'ID del dispositivo della fotocamera sia corretto e che la fotocamera non sia occupata da altri programmi.

3. **Risultati di rilevamento imprecisi**
   
   Assicurati che la fotocamera sia stata calibrata correttamente e che la dimensione dei tag nel file di configurazione sia corretta.

## Struttura dei file

```
apriltag_standalone/
├── apriltag.py              # Codice principale della libreria di rilevamento AprilTag
├── apriltag_detector.py     # Programma principale di rilevamento AprilTag
├── apriltag_tool.py         # Menu strumenti integrato
├── camera_calibration.py    # Programma di calibrazione della fotocamera
├── create_chessboard.py     # Strumento di generazione della scacchiera
├── configs.py               # Gestione file di configurazione
├── config/                  # Directory di configurazione
│   ├── camera/              # Configurazione fotocamera
│   │   └── HSK_200W53_1080P.yaml  # Parametri della fotocamera
│   └── vision/              # Configurazione visione
│       └── tags_36h11_all.json # Configurazione AprilTag
├── README.md                # Documentazione
└── requirements.txt         # Dipendenze Python
```

## Spiegazione tecnica

Questo progetto è una versione indipendente portata dal pacchetto di rilevamento AprilTag per ROS, senza dipendenze ROS, mantenendo le funzionalità principali.
Le tecnologie principali utilizzate sono:

- OpenCV: elaborazione delle immagini, calibrazione della fotocamera e stima della posa
- Libreria C AprilTag: rilevamento dei tag
- SciPy: conversione tra matrici di rotazione e quaternioni

## Licenza

Questo progetto è rilasciato sotto licenza MIT 

## Novità

### Tracciamento multi-tag e gestione delle occlusioni

Il sistema ora supporta le seguenti nuove funzionalità:

1. **Inizializzazione tramite foto**: Dopo l'avvio, il sistema esegue automaticamente un'inizializzazione tramite foto, registrando la relazione di posizione tra i tag, inclusi:
   - La posizione dei tag di riferimento fissi (ID 0-3)
   - La relazione di posizione relativa tra più tag mobili (predefiniti ID 4,5,6)

2. **Gestione delle occlusioni**: Dopo l'inizializzazione, anche se alcuni tag sono occlusi:
   - Se un tag di riferimento è occluso, il sistema può stimarne la posizione usando altri tag di riferimento visibili
   - Se un tag mobile è occluso, il sistema può stimarne la posizione tramite altri tag mobili visibili

3. **Tracciamento multi-tag**: Supporta il tracciamento simultaneo di più tag mobili, con supporto predefinito per ID 4,5,6
   - Se la posizione relativa tra i tag mobili è fissa, basta che uno solo sia visibile per stimare la posizione degli altri
   - È possibile personalizzare gli ID dei tag mobili nel file di configurazione

### Spiegazione file di configurazione

Tutte le impostazioni del sistema possono essere configurate nel file `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista degli ID dei tag di riferimento
        "moving_tags": [4, 5, 6],            // Lista degli ID dei tag mobili
        "require_initialization": true,       // Necessità di inizializzazione
        "tag_positions": {                    // Posizioni preimpostate dei tag (se presenti)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Modificando il file di configurazione, puoi:
1. Personalizzare gli ID dei tag di riferimento e dei tag mobili
2. Controllare la necessità di inizializzazione (imposta `require_initialization` su `false` per saltare l'inizializzazione)
3. Preimpostare la posizione dei tag

### Modalità d'uso

1. Avvia il sistema con la configurazione predefinita:
   ```
   python table_tracking.py
   ```

2. Avvia il sistema con un file di configurazione personalizzato:
   ```
   python table_tracking.py --config percorso_file_configurazione_personalizzato
   ```

3. Inizializzazione manuale: durante il funzionamento del sistema, premi il tasto 'i'

### Requisiti di esecuzione

Assicurati che tutti i tag siano visibili durante l'inizializzazione; il sistema registrerà la relazione di posizione tra i tag. Dopo l'inizializzazione, anche se alcuni tag sono occlusi, il sistema può stimare correttamente la posizione di tutti i tag.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---