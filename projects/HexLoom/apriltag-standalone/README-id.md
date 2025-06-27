# AprilTag Deteksi Mandiri

Ini adalah paket alat deteksi AprilTag berbasis pustaka pupil-apriltags, digunakan untuk deteksi dan pelacakan AprilTag pada kamera.

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

## Dependensi

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Instalasi

1. Pastikan lingkungan Python sudah terpasang
2. Instal dependensi yang diperlukan:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Cara Penggunaan

### Penggunaan Dasar

```python
import cv2
from apriltag import Detector, DetectorOptions

# Membuat detektor
options = DetectorOptions(
    families="tag36h11",  # Keluarga tag
    border=1,             # Ukuran border tag
    nthreads=4,           # Jumlah thread
    quad_decimate=1.0,    # Faktor downsampling gambar
    quad_blur=0.0,        # Koefisien blur Gaussian
    refine_edges=True     # Apakah edge refinement
)
detector = Detector(options)

# Membaca gambar
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Deteksi AprilTag
detections = detector.detect(gray)

# Tampilkan hasil deteksi
for detection in detections:
    print(f"Keluarga tag: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Posisi: {detection.center}")
    print(f"Titik sudut: {detection.corners}")
```

### Menggambar Hasil Deteksi

```python
import numpy as np
from apriltag import draw_detection_results

# Matriks parameter internal kamera dan koefisien distorsi
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Gambar hasil deteksi
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Tampilkan hasil
cv2.imshow("Deteksi AprilTag", result_img)
cv2.waitKey(0)
```

### Menjalankan Skrip Uji

Sebuah skrip pengujian sederhana disediakan untuk memverifikasi fungsi deteksi AprilTag:

```bash
python test_apriltag.py
```

Ini akan membuka kamera default komputer dan mendeteksi AprilTag secara real-time. Tekan tombol "q" untuk keluar.

## Keluarga Tag yang Didukung

Pustaka pupil-apriltags mendukung keluarga tag berikut:
- tag36h11 (default)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Catatan

- Untuk performa yang lebih baik, Anda dapat mengatur parameter di DetectorOptions
- Untuk perangkat dengan sumber daya komputasi terbatas, pertimbangkan untuk menaikkan parameter quad_decimate untuk mengurangi kompleksitas komputasi
- Pastikan ukuran AprilTag yang digunakan sesuai dengan parameter tag_size di kode
- Untuk menggambar sumbu 3D diperlukan parameter kamera yang akurat

## Fitur

- Mendukung deteksi AprilTag real-time dengan kamera USB
- Menghitung dan menampilkan pose 3D tag (posisi dan orientasi)
- Mendukung penyimpanan gambar asli dan gambar dengan tag
- Konfigurasi dan parameter kamera dapat dikustomisasi
- Termasuk alat kalibrasi kamera yang lengkap
- Tidak bergantung pada ROS, merupakan versi mandiri Python dari paket ROS

## Langkah Instalasi

### 1. Instalasi Library C AprilTag

Library C AprilTag diperlukan. Ikuti langkah berikut untuk instalasi:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Pengguna Windows harus mengompilasi sendiri atau mengunduh file biner yang telah dikompilasi, dan memastikan `apriltag.dll` ada di PATH sistem atau direktori saat ini.

### 2. Instalasi Dependensi Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Petunjuk Penggunaan

### Mulai Cepat (Direkomendasikan)

Cara termudah adalah menjalankan alat terintegrasi, yang menyediakan menu interaktif untuk memandu Anda melalui semua langkah:

```bash
python apriltag_tool.py
```

Alat ini akan menyediakan pilihan menu:
1. Membuat papan kalibrasi chessboard
2. Kalibrasi kamera
3. Deteksi AprilTag
4. Lihat dokumentasi bantuan

Cukup ikuti petunjuk menu untuk menyelesaikan seluruh proses.

### Kalibrasi Kamera

Sebelum menggunakan deteksi AprilTag, disarankan untuk melakukan kalibrasi kamera untuk memperoleh parameter kamera yang akurat:

```bash
# Pertama buat papan kalibrasi chessboard
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Cetak chessboard dan ukur ukuran kotak nyata, lalu lakukan kalibrasi
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Penjelasan parameter:

**Alat pembuat chessboard (create_chessboard.py):**
- `--size`: Jumlah titik sudut dalam chessboard, lebar x tinggi (default: 9x6)
- `--square`: Ukuran kotak, piksel (default: 100)
- `--output`: Path file output (default: chessboard.png)
- `--dpi`: DPI gambar output (default: 300), mempengaruhi ukuran cetak

**Program kalibrasi kamera (camera_calibration.py):**
- `--size`: Jumlah titik sudut dalam chessboard, lebar x tinggi (default: 9x6)
- `--square`: Ukuran kotak pada chessboard, satuan meter (default: 0.025)
- `--output`: Path file output (default: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: ID perangkat kamera (default: 0)
- `--width`: Lebar tangkapan kamera (default: 1280)
- `--height`: Tinggi tangkapan kamera (default: 720)
- `--samples`: Jumlah sampel yang diperlukan untuk kalibrasi (default: 20)
- `--preview`: Pratinjau hasil kalibrasi setelah selesai

Proses kalibrasi:
1. Buat dan cetak papan kalibrasi chessboard
2. Ukur ukuran kotak sesungguhnya (dalam meter)
3. Jalankan program kalibrasi, letakkan chessboard di depan kamera, dan ambil sampel dari sudut berbeda
4. Program akan otomatis mendeteksi chessboard dan mengumpulkan sampel, juga dapat menekan tombol 's' untuk menyimpan frame saat ini secara manual
5. Setelah cukup sampel, program secara otomatis menghitung parameter kamera dan menyimpannya ke file yang ditentukan

### Deteksi AprilTag

Setelah kalibrasi selesai, Anda dapat menjalankan program deteksi AprilTag:
```bash
python apriltag_detector.py
```

### Penggunaan Tingkat Lanjut

```bash
python apriltag_detector.py [path_konfigurasi] --camera ID_kamera --width lebar --height tinggi --camera_info file_parameter_kamera
```

Penjelasan parameter:
- `path_konfigurasi`: Path file konfigurasi AprilTag (default: `config/vision/tags_36h11_all.json`)
- `--camera`: ID perangkat kamera (default: 0)
- `--camera_info`: Path file parameter internal kamera (default: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Lebar tangkapan kamera (default: 1280)
- `--height`: Tinggi tangkapan kamera (default: 720)

### Kontrol Tombol

- `q`: Keluar dari program

## Penjelasan File Konfigurasi

Semua konfigurasi sistem dapat diatur di file `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Keluarga tag
        "size": 0.05,              // Ukuran fisik tag (satuan: meter)
        "threads": 2,              // Jumlah thread pemrosesan
        "max_hamming": 0,          // Jarak hamming maksimum
        "z_up": true,              // Sumbu Z menghadap atas
        "decimate": 1.0,           // Koefisien downsampling gambar
        "blur": 0.8,               // Koefisien blur
        "refine_edges": 1,         // Apakah memperhalus tepi
        "debug": 0                 // Aktifkan mode debug
    },

    "Camera": {
        "device_id": 0,            // ID perangkat kamera
        "width": 1280,             // Resolusi lebar kamera
        "height": 720,             // Resolusi tinggi kamera
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // File parameter kalibrasi kamera
    },

    "Archive": {
        "enable": true,            // Aktifkan penyimpanan data
        "preview": true,           // Tampilkan jendela pratinjau
        "save_raw": false,         // Simpan gambar mentah
        "save_pred": false,        // Simpan gambar hasil prediksi
        "path": "./data/table_tracking"  // Path penyimpanan data
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Daftar ID tag referensi
        "moving_tags": [4, 5, 6],            // Daftar ID tag bergerak
        "require_initialization": true,       // Apakah perlu inisialisasi
        "tag_positions": {                    // Posisi tag preset (jika ada)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Dengan mengubah file konfigurasi, Anda dapat:
1. Mengatur parameter detektor AprilTag
2. Mengatur parameter kamera (ID perangkat, resolusi, file parameter)
3. Mengonfigurasi opsi penyimpanan data
4. Menyesuaikan ID tag referensi dan tag bergerak
5. Mengontrol kebutuhan inisialisasi (atur `require_initialization` ke `false` untuk melewati inisialisasi)
6. Menentukan informasi posisi tag preset

### Cara Penggunaan

Sangat mudah, hanya dengan satu perintah untuk menjalankan sistem:

```
python table_tracking.py
```

Jika ingin menggunakan file konfigurasi khusus:

```
python table_tracking.py --config path_konfigurasi_khusus
```

Setelah sistem berjalan, Anda dapat menekan tombol 'i' kapan saja untuk memicu proses inisialisasi secara manual.

## FAQ (Pertanyaan yang Sering Diajukan)

1. **Tidak dapat menemukan pustaka apriltag**
   
   Pastikan pustaka apriltag telah terinstal dengan benar, dan file pustaka dapat ditemukan oleh sistem.

2. **Kamera tidak dapat dibuka**
   
   Periksa apakah ID perangkat kamera sudah benar, dan pastikan kamera tidak sedang digunakan oleh program lain.

3. **Hasil deteksi tidak akurat**
   
   Pastikan kamera Anda telah dikalibrasi dengan benar, dan ukuran tag pada file konfigurasi sudah sesuai.

## Penjelasan Struktur File

```
apriltag_standalone/
├── apriltag.py              # Kode inti pustaka deteksi AprilTag
├── apriltag_detector.py     # Program utama deteksi AprilTag
├── apriltag_tool.py         # Menu utama alat terintegrasi
├── camera_calibration.py    # Program kalibrasi kamera
├── create_chessboard.py     # Alat pembuat papan catur
├── configs.py               # Pengelolaan file konfigurasi
├── config/                  # Direktori konfigurasi
│   ├── camera/              # Konfigurasi kamera
│   │   └── HSK_200W53_1080P.yaml  # Parameter kamera
│   └── vision/              # Konfigurasi visi
│       └── tags_36h11_all.json # Konfigurasi AprilTag
├── README.md                # Dokumentasi
└── requirements.txt         # Dependensi Python
```

## Penjelasan Teknis

Proyek ini adalah versi mandiri hasil porting dari paket deteksi AprilTag ROS, menghapus ketergantungan ROS namun tetap mempertahankan fungsi inti.
Teknologi utama yang digunakan:

- OpenCV: Pengolahan gambar, kalibrasi kamera, dan estimasi pose
- Pustaka AprilTag C: Deteksi tag
- SciPy: Konversi matriks rotasi dan quaternion

## Lisensi

Proyek ini menggunakan lisensi MIT

## Penjelasan Fitur Baru

### Pelacakan Multi-Tag dan Penanganan Occlusion

Sistem ini sekarang mendukung fitur-fitur baru berikut:

1. **Inisialisasi dengan Foto**: Setelah sistem dijalankan, secara otomatis melakukan inisialisasi dengan mengambil foto untuk merekam hubungan posisi tag, termasuk:
   - Posisi tag referensi tetap (ID 0-3)
   - Hubungan posisi relatif beberapa tag bergerak (default ID 4,5,6)

2. **Penanganan Occlusion**: Setelah inisialisasi, meskipun beberapa tag terhalang:
   - Jika tag referensi terhalang, sistem dapat memperkirakan posisi tag yang terhalang menggunakan tag referensi lain yang terlihat
   - Jika tag bergerak terhalang, sistem dapat memperkirakan posisi tag bergerak yang terhalang menggunakan tag bergerak lain yang terlihat

3. **Pelacakan Multi-Tag**: Mendukung pelacakan beberapa tag bergerak secara bersamaan, default untuk ID 4,5,6
   - Jika posisi relatif antar tag bergerak tetap, maka selama satu tag terlihat, posisi tag lain dapat diperkirakan
   - ID tag bergerak dapat dikustomisasi pada file konfigurasi

### Penjelasan File Konfigurasi

Semua konfigurasi sistem dapat diatur di file `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Daftar ID tag referensi
        "moving_tags": [4, 5, 6],            // Daftar ID tag bergerak
        "require_initialization": true,       // Apakah perlu inisialisasi
        "tag_positions": {                    // Posisi tag preset (jika ada)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Dengan mengubah file konfigurasi, Anda dapat:
1. Menyesuaikan ID tag referensi dan tag bergerak
2. Mengontrol kebutuhan inisialisasi (atur `require_initialization` ke `false` untuk melewati inisialisasi)
3. Menentukan informasi posisi tag preset

### Cara Penggunaan

1. Jalankan sistem dengan konfigurasi default:
   ```
   python table_tracking.py
   ```

2. Jalankan sistem dengan file konfigurasi khusus:
   ```
   python table_tracking.py --config path_konfigurasi_khusus
   ```

3. Inisialisasi manual: tekan tombol 'i' selama sistem berjalan

### Persyaratan Operasi

Pastikan semua tag terlihat pada saat inisialisasi, sistem akan merekam hubungan posisi antar tag. Setelah inisialisasi, meskipun sebagian tag terhalang, sistem tetap dapat memperkirakan posisi semua tag dengan benar.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---