# AprilTag Niezależna Biblioteka Detekcji

Jest to zestaw narzędzi do rozpoznawania AprilTag oparty na bibliotece pupil-apriltags, służący do detekcji i śledzenia AprilTag w kamerze.

<!-- Zachowaj te linki. Tłumaczenia będą automatycznie aktualizowane z README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Wymagane biblioteki

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Instalacja

1. Upewnij się, że środowisko Python jest zainstalowane
2. Zainstaluj wymagane zależności:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Sposób użycia

### Podstawowe użycie

```python
import cv2
from apriltag import Detector, DetectorOptions

# Utwórz detektor
options = DetectorOptions(
    families="tag36h11",  # Rodzina tagów
    border=1,             # Rozmiar obramowania tagu
    nthreads=4,           # Liczba wątków
    quad_decimate=1.0,    # Współczynnik podpróbkowania obrazu
    quad_blur=0.0,        # Współczynnik rozmycia Gaussa
    refine_edges=True     # Czy doprecyzować krawędzie
)
detector = Detector(options)

# Wczytaj obraz
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Detekcja AprilTag
detections = detector.detect(gray)

# Wyświetl wyniki detekcji
for detection in detections:
    print(f"Rodzina tagów: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Pozycja: {detection.center}")
    print(f"Wierzchołki: {detection.corners}")
```

### Rysowanie wyników detekcji

```python
import numpy as np
from apriltag import draw_detection_results

# Macierz intrynsicznych kamery i współczynniki dystorsji
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Narysuj wyniki detekcji
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Wyświetl wynik
cv2.imshow("Detekcja AprilTag", result_img)
cv2.waitKey(0)
```

### Uruchomienie skryptu testowego

Dostępny jest prosty skrypt testowy umożliwiający weryfikację działania detekcji AprilTag:

```bash
python test_apriltag.py
```

Spowoduje to otwarcie domyślnej kamery komputera i wykrywanie AprilTag w czasie rzeczywistym. Naciśnij klawisz "q", aby wyjść.

## Obsługiwane rodziny tagów

Biblioteka pupil-apriltags obsługuje następujące rodziny tagów:
- tag36h11 (domyślna)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Uwagi

- W celu uzyskania lepszej wydajności można dostosować parametry w DetectorOptions
- Dla urządzeń o ograniczonych zasobach obliczeniowych można rozważyć zwiększenie parametru quad_decimate, aby zmniejszyć złożoność obliczeniową
- Upewnij się, że rozmiar znacznika AprilTag używany w rzeczywistości odpowiada parametrowi tag_size w kodzie
- Rysowanie osi 3D wymaga dokładnych parametrów kamery

## Cechy funkcjonalne

- Obsługa detekcji AprilTag na żywo z kamery USB
- Obliczanie i wyświetlanie pozycji 3D tagu (pozycja i orientacja)
- Obsługa zapisu obrazów surowych i z naniesionymi znacznikami
- Możliwość konfiguracji i ustawień parametrów kamery
- Pełne narzędzie do kalibracji kamery
- Nie wymaga ROS, jest niezależną wersją w czystym Pythonie wywodzącą się z oryginalnego pakietu ROS

## Kroki instalacji

### 1. Instalacja biblioteki C AprilTag

Biblioteka C AprilTag jest wymagana. Zainstaluj ją według poniższych kroków:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Użytkownicy Windows muszą samodzielnie skompilować lub pobrać gotowe pliki binarne i upewnić się, że `apriltag.dll` znajduje się w zmiennej PATH systemu lub w bieżącym katalogu.

### 2. Instalacja zależności Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Instrukcja użytkowania

### Szybki start (zalecane)

Najprostszym sposobem użycia jest uruchomienie zintegrowanego narzędzia, które oferuje interaktywne menu prowadzące przez wszystkie kroki:

```bash
python apriltag_tool.py
```

To narzędzie udostępnia następujące opcje w menu:
1. Generowanie planszy kalibracyjnej (szachownicy)
2. Kalibracja kamery
3. Detekcja AprilTag
4. Przeglądanie dokumentacji pomocy

Wystarczy postępować zgodnie z instrukcjami w menu, aby przejść przez cały proces.

### Kalibracja kamery

Przed użyciem detekcji AprilTag zaleca się najpierw wykonać kalibrację kamery w celu uzyskania dokładnych parametrów kamery:

```bash
# Najpierw wygeneruj planszę kalibracyjną (szachownicę)
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Wydrukuj planszę i zmierz rzeczywisty rozmiar pola, następnie wykonaj kalibrację
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Opis parametrów:

**Narzędzie do generowania szachownicy (create_chessboard.py):**
- `--size`: Liczba punktów wewnętrznych szachownicy, szerokość x wysokość (domyślnie: 9x6)
- `--square`: Rozmiar pola, piksele (domyślnie: 100)
- `--output`: Ścieżka pliku wyjściowego (domyślnie: chessboard.png)
- `--dpi`: DPI obrazu wyjściowego (domyślnie: 300), wpływa na rozmiar wydruku

**Program do kalibracji kamery (camera_calibration.py):**
- `--size`: Liczba punktów wewnętrznych szachownicy, szerokość x wysokość (domyślnie: 9x6)
- `--square`: Rozmiar pola szachownicy w metrach (domyślnie: 0.025)
- `--output`: Ścieżka pliku wyjściowego (domyślnie: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: ID urządzenia kamery (domyślnie: 0)
- `--width`: Szerokość przechwytywania kamery (domyślnie: 1280)
- `--height`: Wysokość przechwytywania kamery (domyślnie: 720)
- `--samples`: Liczba próbek potrzebnych do kalibracji (domyślnie: 20)
- `--preview`: Podgląd efektu korekcji po zakończeniu kalibracji

Proces kalibracji:
1. Wygeneruj i wydrukuj planszę kalibracyjną (szachownicę)
2. Zmierz rzeczywisty rozmiar pola (w metrach)
3. Uruchom program kalibracji, umieść szachownicę przed kamerą i zbieraj próbki z różnych kątów
4. Program automatycznie wykrywa szachownicę i zbiera próbki, można też ręcznie zapisać klatkę klawiszem 's'
5. Po zebraniu wystarczającej liczby próbek program automatycznie obliczy parametry kamery i zapisze do wskazanego pliku

### Detekcja AprilTag

Po zakończeniu kalibracji można uruchomić program detekcji AprilTag:
```bash
python apriltag_detector.py
```

### Zaawansowane użycie

```bash
python apriltag_detector.py [ścieżka do pliku konfiguracyjnego] --camera ID_kamery --width szerokość --height wysokość --camera_info plik_parametrów_kamery
```

Opis parametrów:
- `ścieżka do pliku konfiguracyjnego`: Ścieżka do pliku konfiguracyjnego AprilTag (domyślnie: `config/vision/tags_36h11_all.json`)
- `--camera`: ID urządzenia kamery (domyślnie: 0)
- `--camera_info`: Ścieżka do pliku parametrów kamery (domyślnie: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Szerokość przechwytywanego obrazu kamery (domyślnie: 1280)
- `--height`: Wysokość przechwytywanego obrazu kamery (domyślnie: 720)

### Sterowanie klawiaturą

- `q`: Wyjście z programu

## Opis pliku konfiguracyjnego

Wszystkie ustawienia systemu można skonfigurować w pliku `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Rodzina znaczników
        "size": 0.05,              // Fizyczny rozmiar znacznika (metry)
        "threads": 2,              // Liczba wątków przetwarzania
        "max_hamming": 0,          // Maksymalna odległość Hamminga
        "z_up": true,              // Oś Z skierowana w górę
        "decimate": 1.0,           // Współczynnik próbkowania obrazu w dół
        "blur": 0.8,               // Współczynnik rozmycia
        "refine_edges": 1,         // Czy wyostrzać krawędzie
        "debug": 0                 // Czy włączyć tryb debugowania
    },

    "Camera": {
        "device_id": 0,            // ID urządzenia kamery
        "width": 1280,             // Rozdzielczość szerokości kamery
        "height": 720,             // Rozdzielczość wysokości kamery
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Plik kalibracji kamery
    },

    "Archive": {
        "enable": true,            // Czy włączyć archiwizację danych
        "preview": true,           // Czy wyświetlać okno podglądu
        "save_raw": false,         // Czy zapisywać surowe obrazy
        "save_pred": false,        // Czy zapisywać obrazy z predykcją
        "path": "./data/table_tracking"  // Ścieżka zapisu danych
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista ID znaczników referencyjnych
        "moving_tags": [4, 5, 6],            // Lista ID znaczników ruchomych
        "require_initialization": true,       // Czy wymagana jest inicjalizacja
        "tag_positions": {                    // Wstępnie ustawione pozycje znaczników (jeśli istnieją)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Poprzez modyfikację pliku konfiguracyjnego można:
1. Skonfigurować parametry detektora AprilTag
2. Ustawić parametry kamery (ID urządzenia, rozdzielczość, plik parametrów)
3. Skonfigurować opcje archiwizacji danych
4. Zdefiniować ID znaczników referencyjnych i ruchomych
5. Sterować koniecznością inicjalizacji (ustaw `require_initialization` na `false`, aby pominąć ten krok)
6. Ustawić pozycje znaczników

### Sposób użycia

Bardzo proste, wystarczy jedno polecenie, aby uruchomić system:

```
python table_tracking.py
```

Aby użyć własnego pliku konfiguracyjnego:

```
python table_tracking.py --config ścieżka_do_pliku_konfiguracyjnego
```

Po uruchomieniu systemu można nacisnąć klawisz 'i', aby ręcznie wywołać proces inicjalizacji.

## Najczęstsze pytania

1. **Nie znaleziono biblioteki apriltag**
   
   Upewnij się, że biblioteka apriltag została poprawnie zainstalowana i pliki biblioteki są dostępne w systemie.

2. **Nie można otworzyć kamery**
   
   Sprawdź, czy ID kamery jest prawidłowe oraz czy kamera nie jest używana przez inny program.

3. **Niedokładne wyniki detekcji**
   
   Upewnij się, że kamera została prawidłowo skalibrowana, a rozmiar znaczników w pliku konfiguracyjnym jest poprawny.


## Struktura plików

```
apriltag_standalone/
├── apriltag.py              # Główny kod biblioteki detekcji AprilTag
├── apriltag_detector.py     # Główny program detekcji AprilTag
├── apriltag_tool.py         # Menu narzędzi zintegrowanych
├── camera_calibration.py    # Program kalibracji kamery
├── create_chessboard.py     # Narzędzie do generowania planszy szachownicy
├── configs.py               # Obsługa plików konfiguracyjnych
├── config/                  # Katalog konfiguracyjny
│   ├── camera/              # Konfiguracja kamery
│   │   └── HSK_200W53_1080P.yaml  # Parametry kamery
│   └── vision/              # Konfiguracja wizyjna
│       └── tags_36h11_all.json # Konfiguracja AprilTag
├── README.md                # Dokumentacja
└── requirements.txt         # Wymagania Python
```

## Wyjaśnienie techniczne

Ten projekt to samodzielna wersja przeniesiona z pakietu ROS AprilTag, bez zależności od ROS, z zachowaniem kluczowych funkcji.
Wykorzystuje głównie następujące technologie:

- OpenCV: przetwarzanie obrazu, kalibracja kamery i estymacja pozycji
- Biblioteka AprilTag C: detekcja znaczników
- SciPy: konwersja macierzy obrotu i kwaternionów

## Licencja

Projekt oparty na licencji MIT

## Nowe funkcje

### Śledzenie wielu znaczników i obsługa zasłonięcia

System obsługuje obecnie następujące funkcje:

1. **Inicjalizacja poprzez zdjęcie**: Po uruchomieniu systemu automatycznie wykonywana jest inicjalizacja przez zdjęcie, rejestrująca położenia znaczników, w tym:
   - Pozycje stałych znaczników referencyjnych (ID 0-3)
   - Wzajemne pozycje wielu znaczników ruchomych (domyślnie ID 4,5,6)

2. **Obsługa zasłonięcia**: Po inicjalizacji, nawet jeśli niektóre znaczniki są zasłonięte:
   - Jeśli zasłonięty jest znacznik referencyjny, system może oszacować jego położenie na podstawie innych widocznych znaczników referencyjnych
   - Jeśli zasłonięty jest znacznik ruchomy, system może oszacować jego położenie na podstawie innych widocznych znaczników ruchomych

3. **Śledzenie wielu znaczników**: Obsługa jednoczesnego śledzenia wielu znaczników ruchomych, domyślnie ID 4,5,6
   - Jeśli pozycje względne znaczników ruchomych są stałe, wystarczy widoczność jednego z nich, aby oszacować położenie pozostałych
   - Możliwość zdefiniowania ID znaczników ruchomych w pliku konfiguracyjnym

### Opis pliku konfiguracyjnego

Wszystkie ustawienia systemu można skonfigurować w pliku `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista ID znaczników referencyjnych
        "moving_tags": [4, 5, 6],            // Lista ID znaczników ruchomych
        "require_initialization": true,       // Czy wymagana jest inicjalizacja
        "tag_positions": {                    // Wstępnie ustawione pozycje znaczników (jeśli istnieją)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Poprzez modyfikację pliku konfiguracyjnego można:
1. Zdefiniować ID znaczników referencyjnych i ruchomych
2. Sterować koniecznością inicjalizacji (ustaw `require_initialization` na `false`, aby pominąć ten krok)
3. Ustawić pozycje znaczników

### Sposób użycia

1. Uruchom system z domyślną konfiguracją:
   ```
   python table_tracking.py
   ```

2. Uruchom system z własnym plikiem konfiguracyjnym:
   ```
   python table_tracking.py --config ścieżka_do_pliku_konfiguracyjnego
   ```

3. Ręczna inicjalizacja: podczas pracy systemu naciśnij klawisz 'i'

### Wymagania dotyczące działania

Upewnij się, że wszystkie znaczniki są widoczne podczas inicjalizacji; system zarejestruje wzajemne położenia znaczników. Po inicjalizacji, nawet jeśli niektóre znaczniki będą zasłonięte, system poprawnie oszacuje położenia wszystkich znaczników.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---