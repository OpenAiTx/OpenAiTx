# 🖼️ HEIC Görüntü İşleme Araçları

HEIC (High Efficiency Image Container) dosyalarını işlemek için Python araçlarından oluşan bir koleksiyon, özellikle HDR içerik çıkarımı ve EXR dönüşümüne odaklanır.

## 🛠️ Araçlara Genel Bakış

### 1. gain_map_extract.py
HEIC dosyalarındaki tüm bileşenleri çıkarır, bunlar:
- Temel görüntüler
- HDR kazanç haritaları
- Derinlik haritaları
- Tüm metadata (EXIF, XMP, ICC profilleri)

### 2. heic_to_exr.py
HEIC dosyalarını OpenEXR formatına dönüştürür:
- Temel görüntü ve kazanç haritasını birleştirerek HDR EXR oluşturur (Apple’ın yöntemiyle)
- Tam dinamik aralığı korur
- Mümkün olduğunca metadata’yı saklar
- Toplu işlemeyi destekler
### 3. merge_to_exr.sh
Toplu işleme için kabuk betiği:
- HEIC'ten EXR'ye dönüştürmeyi otomatikleştirir
- Birden fazla dosyayla ilgilenir
- İlerleme geri bildirimi sağlar
- Dizin yapısını korur

## 🔧 Kurulum

### Önkoşullar
- Python 3.8 veya üzeri
- pip (Python paket yöneticisi)
- Git (deponun klonlanması için)

### macOS
```bash
# Homebrew yüklü değilse yükleyin
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# Python ve OpenEXR bağımlılıklarını yükleyin
brew install python3 openexr

# Depoyu klonlayın
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Sanal ortam oluşturun ve etkinleştirin
python3 -m venv venv
source venv/bin/activate

# Python bağımlılıklarını yükleyin
pip install -r requirements.txt
```

### Linux (Ubuntu/Debian)
```bash
# Sistem bağımlılıklarını yükleyin
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# Depoyu klonlayın
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Sanal ortamı oluşturun ve etkinleştirin
python3 -m venv venv
source venv/bin/activate

# Python bağımlılıklarını yükleyin
pip install -r requirements.txt
```

### Windows
```powershell
# Python'u https://www.python.org/downloads/ adresinden indirin ve kurun
# Git'i https://git-scm.com/download/win adresinden indirin ve kurun

# Depoyu klonlayın
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Sanal ortam oluşturun ve etkinleştirin
python -m venv venv
.\venv\Scripts\activate

# Python bağımlılıklarını yükleyin
pip install -r requirements.txt
```

## 📋 Gereksinimler
Gerekli tüm Python paketleri requirements.txt dosyasında listelenmiştir:
- Pillow: Görüntü işleme kütüphanesi
- pillow-heif: HEIC dosya desteği
- numpy: Sayısal işlemler
- defusedxml: Güvenli XML ayrıştırma

Sistem bağımlılıkları (paket yöneticisi ile kurulur):
- EXR dosya işlemleri için OpenEXR ve OpenImageIO (oiiotool)

## 💻 Kullanım
### Kazanç Haritası Çıkarımı
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### HEIC'ten EXR'ye Dönüştürme
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### Toplu İşlem
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 Çıktı Dosyaları

### gain_map_extract.py çıktıları:
- Taban görüntü: `{filename}_base.tiff`
- Kazanç haritaları: `{filename}_gain_map_{id}.tiff`
- Derinlik haritaları: `{filename}_depth_{index}.tiff`
- Meta veri: `{filename}_metadata.json`

### heic_to_exr.py çıktıları:
- HDR EXR dosyası: `{filename}.exr`

## 🔍 Gelişmiş Kullanım

### Metadata Yönetimi
- İkili veriler base64 ile kodlanır
- ICC profilleri korunur
- EXIF verileri mümkün olduğunca korunur

### HDR İşleme
- Gain haritaları düzgün şekilde ölçeklendirilir
- Doğrusal renk uzayı korunur
- EXR çıktısında tam dinamik aralık korunur

## ⚠️ Bilinen Sınırlamalar
- Bazı HEIC varyantları tam olarak desteklenmeyebilir
- Derinlik haritası çıkarımı yalnızca desteklenen cihazlarla sınırlıdır
- Windows OpenEXR desteği ek yapılandırma gerektirebilir
## 🤝 Katkıda Bulunma
Katkılar memnuniyetle karşılanır! Lütfen bir Pull Request göndermekten çekinmeyin.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---