# AprilTag Bağımsız Tespit Kütüphanesi

Bu, kameradaki AprilTag’lerin tespiti ve takibi için pupil-apriltags kütüphanesine dayalı bir AprilTag tanıma araç setidir.

<!-- Bu bağlantıları koruyun. Çeviriler README ile otomatik olarak güncellenecek. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Bağımlılıklar

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Kurulum

1. Python ortamının kurulu olduğundan emin olun
2. Gerekli bağımlılıkları yükleyin:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Kullanım Yöntemi

### Temel Kullanım

```python
import cv2
from apriltag import Detector, DetectorOptions

# Dedektörü oluştur
options = DetectorOptions(
    families="tag36h11",  # Etiket ailesi
    border=1,             # Etiket kenarlık boyutu
    nthreads=4,           # İş parçacığı sayısı
    quad_decimate=1.0,    # Görüntü alt örnekleme katsayısı
    quad_blur=0.0,        # Gauss bulanıklık katsayısı
    refine_edges=True     # Kenarları ince ayarla
)
detector = Detector(options)

# Görüntüyü oku
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# AprilTag tespiti
detections = detector.detect(gray)

# Tespit sonuçlarını göster
for detection in detections:
    print(f"Etiket Ailesi: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Konum: {detection.center}")
    print(f"Köşe Noktaları: {detection.corners}")
```

### Tespit Sonuçlarını Çizdirme

```python
import numpy as np
from apriltag import draw_detection_results

# Kamera iç parametre matrisi ve distorsiyon katsayıları
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Tespit sonuçlarını çizdir
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Sonucu göster
cv2.imshow("AprilTag Tespiti", result_img)
cv2.waitKey(0)
```

### Test Scriptini Çalıştırma

AprilTag tespit fonksiyonunu doğrulamak için basit bir test scripti sunulmuştur:

```bash
python test_apriltag.py
```

Bu, bilgisayarın varsayılan kamerasını açacak ve gerçek zamanlı olarak AprilTag tespiti yapacaktır. Çıkmak için "q" tuşuna basın.

## Desteklenen Etiket Aileleri

pupil-apriltags kütüphanesi aşağıdaki etiket ailelerini destekler:
- tag36h11 (varsayılan)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Dikkat Edilecekler

- Daha iyi performans için DetectorOptions içindeki parametreler ayarlanabilir
- Hesaplama kaynakları kısıtlı cihazlarda, quad_decimate parametresini artırarak hesaplama karmaşıklığını azaltabilirsiniz
- Kullanılan AprilTag işaretlerinin boyutunun, kodda belirtilen tag_size parametresiyle uyumlu olduğundan emin olun
- 3B koordinat eksenlerinin çizimi için doğru kamera parametreleri gereklidir

## Özellikler

- USB kamera ile gerçek zamanlı AprilTag tespiti desteği
- Etiketin 3B pozunun (konum ve yönelim) hesaplanması ve gösterimi
- Orijinal ve işaretlenmiş görüntüyü kaydetme desteği
- Özelleştirilebilir yapılandırma ve kamera parametreleri
- Tam kamera kalibrasyon aracı içerir
- ROS’a bağımlı değildir, orijinal ROS paketinin saf Python bağımsız sürümüdür

## Kurulum Adımları

### 1. AprilTag C Kütüphanesinin Kurulumu

AprilTag’in C kütüphanesi gereklidir. Kurulum için aşağıdaki adımları izleyin:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windows kullanıcılarının, derlemeyi kendilerinin yapması ya da önceden derlenmiş ikili dosyaları indirmesi gerekir ve `apriltag.dll` dosyasının sistem PATH’inde veya mevcut dizinde olduğundan emin olunmalıdır.

### 2. Python Bağımlılıklarını Kurma

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Kullanım Talimatları

### Hızlı Başlangıç (Tavsiye Edilen)

En basit kullanım şekli, sizi tüm adımlar boyunca yönlendiren entegre aracı çalıştırmaktır:

```bash
python apriltag_tool.py
```

Bu araç aşağıdaki menü seçeneklerini sunar:
1. Satranç Tahtası Kalibrasyon Tablası Oluşturma
2. Kamera Kalibrasyonu
3. AprilTag Tespiti
4. Yardım Dokümanını Görüntüle

Tüm süreci tamamlamak için sadece menü yönergelerini takip edin.

### Kamera Kalibrasyonu

AprilTag tespitinden önce, doğru kamera parametrelerini almak için kamera kalibrasyonu önerilir:

```bash
# Önce satranç tahtası kalibrasyon tablosunu oluşturun
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Satranç tahtasını yazdırın ve gerçek kare boyutunu ölçün, ardından kalibrasyonu yapın
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Parametre Açıklamaları:

**Satranç Tahtası Oluşturma Aracı (create_chessboard.py):**
- `--size`: Satranç tahtasının iç köşe sayısı, genişlik x yükseklik (varsayılan: 9x6)
- `--square`: Kare boyutu, piksel (varsayılan: 100)
- `--output`: Çıktı dosya yolu (varsayılan: chessboard.png)
- `--dpi`: Çıktı görüntüsünün DPI’ı (varsayılan: 300), baskı boyutunu etkiler

**Kamera Kalibrasyon Programı (camera_calibration.py):**
- `--size`: Satranç tahtasının iç köşe sayısı, genişlik x yükseklik (varsayılan: 9x6)
- `--square`: Satranç tahtası kare boyutu, metre cinsinden (varsayılan: 0.025)
- `--output`: Çıktı dosya yolu (varsayılan: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: Kamera cihazı ID’si (varsayılan: 0)
- `--width`: Kameranın yakalama genişliği (varsayılan: 1280)
- `--height`: Kameranın yakalama yüksekliği (varsayılan: 720)
- `--samples`: Kalibrasyon için gereken örnek sayısı (varsayılan: 20)
- `--preview`: Kalibrasyon tamamlandıktan sonra düzeltme önizlemesi

Kalibrasyon süreci:
1. Satranç tahtası kalibrasyon tablosunu oluşturun ve yazdırın
2. Gerçek kare boyutunu (metre cinsinden) ölçün
3. Kalibrasyon programını çalıştırın, satranç tahtasını kameranın önüne farklı açılardan tutarak örnekler toplayın
4. Program otomatik olarak satranç tahtasını algılar ve örnek toplar, isterseniz 's' tuşuna basarak mevcut kareyi manuel kaydedebilirsiniz
5. Yeterli örnek toplandıktan sonra, program kamera parametrelerini otomatik olarak hesaplar ve belirtilen dosyaya kaydeder

### AprilTag Tespiti

Kalibrasyon tamamlandıktan sonra, AprilTag tespit programını çalıştırabilirsiniz:
```bash
python apriltag_detector.py
```

### Gelişmiş Kullanım

```bash
python apriltag_detector.py [konfigürasyon dosyası yolu] --camera KameraID --width Genişlik --height Yükseklik --camera_info KameraParametreDosyası
```

Parametre açıklamaları:
- `konfigürasyon dosyası yolu`: AprilTag konfigürasyon dosyası yolu (Varsayılan: `config/vision/tags_36h11_all.json`)
- `--camera`: Kamera cihazı ID'si (Varsayılan: 0)
- `--camera_info`: Kamera iç parametre dosyası yolu (Varsayılan: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Kameranın yakalama genişliği (Varsayılan: 1280)
- `--height`: Kameranın yakalama yüksekliği (Varsayılan: 720)

### Tuş Kontrolleri

- `q`: Programdan çıkış

## Konfigürasyon Dosyası Açıklaması

Sistemin tüm ayarları `config/vision/table_setup.json` dosyasında yapılabilir:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Etiket ailesi
        "size": 0.05,              // Etiket fiziksel boyutu (birim: metre)
        "threads": 2,              // İş parçacığı sayısı
        "max_hamming": 0,          // Maksimum Hamming mesafesi
        "z_up": true,              // Z ekseni yukarı
        "decimate": 1.0,           // Görüntü downsample katsayısı
        "blur": 0.8,               // Bulanıklık katsayısı
        "refine_edges": 1,         // Kenar iyileştirme
        "debug": 0                 // Hata ayıklama açma
    },

    "Camera": {
        "device_id": 0,            // Kamera cihazı ID'si
        "width": 1280,             // Kamera çözünürlüğü (genişlik)
        "height": 720,             // Kamera çözünürlüğü (yükseklik)
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Kamera kalibrasyon dosyası
    },

    "Archive": {
        "enable": true,            // Veri arşivleme etkin mi
        "preview": true,           // Önizleme penceresi gösterilsin mi
        "save_raw": false,         // Ham görüntü kaydedilsin mi
        "save_pred": false,        // Tahmin görüntüsü kaydedilsin mi
        "path": "./data/table_tracking"  // Veri kayıt yolu
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Referans etiket ID listesi
        "moving_tags": [4, 5, 6],            // Hareketli etiket ID listesi
        "require_initialization": true,       // Başlangıçta başlatma gerekli mi
        "tag_positions": {                    // Önceden ayarlanmış etiket pozisyonları (varsa)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Konfigürasyon dosyasını değiştirerek şunları yapabilirsiniz:
1. AprilTag dedektör parametrelerini yapılandırma
2. Kamera parametrelerini ayarlama (cihaz ID, çözünürlük, parametre dosyası)
3. Veri arşivleme seçeneklerini yapılandırma
4. Referans ve hareketli etiketlerin ID’lerini özelleştirme
5. Başlatma gerekip gerekmediğini kontrol etme (`require_initialization`'ı `false` yaparak başlatma adımını atlayabilirsiniz)
6. Etiketlerin ön ayarlı pozisyon bilgilerini belirleme

### Kullanım

Oldukça basittir, sistemi başlatmak için tek bir komut yeterlidir:

```
python table_tracking.py
```

Özel bir konfigürasyon dosyası kullanmak isterseniz:

```
python table_tracking.py --config ÖzelleştirilmişKonfigDosyaYolu
```

Sistem çalışırken herhangi bir anda 'i' tuşuna basarak manuel başlatma işlemini tetikleyebilirsiniz.

## Sıkça Sorulan Sorular

1. **apriltag kütüphanesi bulunamıyor**
   
   Apriltag kütüphanesinin doğru şekilde kurulu olduğundan ve sistemde bulunabildiğinden emin olun.

2. **Kamera açılamıyor**
   
   Kamera cihazı ID'sinin doğru olup olmadığını ve kameranın başka bir program tarafından kullanılmadığını kontrol edin.

3. **Tespit sonuçları doğru değil**
   
   Kameranızın doğru şekilde kalibre edildiğinden ve konfigürasyon dosyasındaki etiket boyutunun doğru olduğundan emin olun.


## Dosya Yapısı Açıklaması

```
apriltag_standalone/
├── apriltag.py              # AprilTag dedektör çekirdek kodu
├── apriltag_detector.py     # AprilTag dedektör ana programı
├── apriltag_tool.py         # Entegre araç başlatma menüsü
├── camera_calibration.py    # Kamera kalibrasyon programı
├── create_chessboard.py     # Satranç tahtası oluşturma aracı
├── configs.py               # Konfigürasyon dosyası işlemleri
├── config/                  # Konfigürasyon dizini
│   ├── camera/              # Kamera konfigürasyonu
│   │   └── HSK_200W53_1080P.yaml  # Kamera parametreleri
│   └── vision/              # Görüntü konfigürasyonu
│       └── tags_36h11_all.json # AprilTag konfigürasyonu
├── README.md                # Açıklama dokümanı
└── requirements.txt         # Python bağımlılıkları
```

## Teknik Açıklama

Bu proje, ROS AprilTag tespit paketinden taşınmış bağımsız bir sürümdür; ROS bağımlılığı kaldırılmış ve çekirdek fonksiyonlar korunmuştur.
Başlıca kullanılan teknolojiler:

- OpenCV: Görüntü işleme, kamera kalibrasyonu ve poz tahmini
- AprilTag C Kütüphanesi: Etiket tespiti
- SciPy: Rotasyon matrisi ve kuaterniyon dönüşümleri

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.

## Yeni Özellikler Açıklaması

### Çoklu Etiket Takibi ve Engel (Görünmezlik) İşleme

Bu sistemde artık aşağıdaki yeni özellikler desteklenmektedir:

1. **Fotoğraf ile Başlatma**: Sistem başlatıldığında, otomatik olarak bir fotoğraf ile başlatma işlemi yapılır ve etiketlerin konum ilişkileri kaydedilir, bunlar:
   - Sabit referans etiketleri (ID 0-3) konumları
   - Birden fazla hareketli etiketin (varsayılan ID 4,5,6) kendi aralarındaki göreli konum ilişkileri

2. **Engel (Görünmezlik) İşleme**: Başlatma sonrası, bazı etiketler engellenmiş (görünmez) olsa bile:
   - Referans etiketler engellenirse, sistem diğer görünen referans etiketlerini kullanarak engellenmiş etiketin konumunu tahmin edebilir
   - Hareketli etiketler engellenirse, sistem diğer görünen hareketli etiketleri kullanarak engellenmiş hareketli etiketin konumunu tahmin edebilir

3. **Çoklu Etiket Takibi**: Birden fazla hareketli etiketi aynı anda takip edebilirsiniz, varsayılan olarak ID 4,5,6 desteklenir
   - Hareketli etiketlerin kendi aralarındaki göreli konumları sabitse, sadece biri görünse bile diğerlerinin konumu tahmin edilebilir
   - Konfigürasyon dosyasında hareketli etiket ID'lerini özelleştirebilirsiniz

### Konfigürasyon Dosyası Açıklaması

Sistemin tüm ayarları `config/vision/table_setup.json` dosyasında yapılabilir:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Referans etiket ID listesi
        "moving_tags": [4, 5, 6],            // Hareketli etiket ID listesi
        "require_initialization": true,       // Başlatma gerekli mi
        "tag_positions": {                    // Önceden ayarlanmış etiket pozisyonları (varsa)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Konfigürasyon dosyasını değiştirerek şunları yapabilirsiniz:
1. Referans ve hareketli etiketlerin ID’lerini özelleştirme
2. Başlatma gerekip gerekmediğini kontrol etme (`require_initialization`'ı `false` yaparak başlatma adımını atlayabilirsiniz)
3. Etiketlerin ön ayarlı pozisyon bilgilerini belirleme

### Kullanım

1. Varsayılan konfigürasyon ile sistemi başlatın:
   ```
   python table_tracking.py
   ```

2. Özel konfigürasyon dosyası ile sistemi başlatın:
   ```
   python table_tracking.py --config ÖzelleştirilmişKonfigDosyaYolu
   ```

3. Manuel başlatma: Sistem çalışırken 'i' tuşuna basın

### Çalıştırma Gereksinimleri

Başlatma sırasında tüm etiketlerin görünür olduğundan emin olun, sistem etiketler arasındaki göreli konum ilişkilerini kaydedecektir. Başlatma sonrasında, bazı etiketler engellense (görünmez olsa) bile sistem tüm etiketlerin konumunu doğru şekilde tahmin edebilir.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---