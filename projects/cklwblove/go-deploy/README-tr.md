# Go-Deploy Dağıtım Aracı

Go diliyle geliştirilmiş, otomatikleştirilmiş bir dağıtım aracıdır ve SFTP protokolü üzerinden yerel derleme çıktısını uzak sunucuya yüklemeyi destekler.

## Özellikler

- ✅ **Güvenli Aktarım**: SFTP protokolü ile, SSH tabanlı şifreli veri aktarımı
- ✅ **Dizin Senkronizasyonu**: Tüm dizin yapısını özyinelemeli olarak yükler, dosya hiyerarşisini korur
- ✅ **Akıllı Oluşturma**: Uzak dizin yapısını otomatik olarak oluşturur
- ✅ **Yol Uyarlanabilirliği**: Yürütülebilir dosya konumuna göre yerel yolu otomatik olarak hesaplar, çalışma dizini ile ilgilenmenize gerek yoktur
- ✅ **Yapılandırma Dosyası Desteği**: JSON yapılandırma dosyalarını destekler, farklı ortam konfigürasyonlarını yönetmeyi kolaylaştırır
- ✅ **Dosya Hariç Tutma**: Yüklenmesini istemediğiniz dosyaları joker karakterli desenlerle hariç tutma desteği
- ✅ **Otomatik Yedekleme**: Yüklemeden önce uzak dosyaların otomatik olarak yedeklenmesi
- ✅ **Yeniden Deneme Mekanizması**: Yükleme başarısız olduğunda otomatik tekrar deneme, başarı oranını artırır
- ✅ **Detaylı İstatistik**: Yüklenen dosya sayısı, aktarılan veri boyutu, geçen süre ve hız gösterimi
- ✅ **İlerleme Gösterimi**: Yükleme ilerlemesini ve dosya bilgisini anlık gösterir
- ✅ **Hata Yönetimi**: Gelişmiş hata yönetimi ve günlük (log) çıktısı

## Sistem Gereksinimleri

- Go 1.18 veya üstü sürüm
- Hedef sunucu SSH/SFTP protokolünü desteklemeli

## Kurulum Talimatları

### 1. Projeyi Klonlayın

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Go Modülünü Başlatın

```bash
go mod init go-deploy
go mod tidy
```

### 3. Bağımlılıkları Yükleyin

Program aşağıdaki bağımlılıkları otomatik olarak indirir:

- `github.com/pkg/sftp` - SFTP istemcisi
- `golang.org/x/crypto/ssh` - SSH istemcisi

## Yapılandırma Açıklaması

Program iki farklı yapılandırma yöntemi destekler:

### 1. Yapılandırma Dosyası ile Kullanım (Tavsiye Edilir)

`config.example.json` dosyasını `config.json` olarak kopyalayın ve düzenleyin:

```bash
cp config.example.json config.json
```

Ardından `config.json` dosyasını düzenleyin:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### Yapılandırma Alanları Açıklaması

**server yapılandırması**:

- `host`: SSH sunucu adresi
- `port`: SSH portu, genellikle 22
- `username`: SSH kullanıcı adı
- `password`: SSH şifresi (üretim ortamında anahtar ile kimlik doğrulama önerilir)
- `timeout`: Bağlantı zaman aşımı süresi (saniye)

**paths yapılandırması**:

- `local`: Yerel dizin yolu, göreli veya mutlak yol destekler
- `remote`: Uzak dizin yolu, mutlaka mutlak yol olmalıdır

**options yapılandırması**:

- `backup`: Yüklemeden önce uzakta zaten var olan dosyayı yedekleyip yedeklemeyeceği
- `backup_suffix`: Yedek dosya uzantısı, yedek dosya uzantısını özelleştirebilir, yedek dosya yoksa yedekleme atlanır
- `exclude_patterns`: Dosya hariç tutma desenleri, joker karakter desteği mevcut
- `max_retries`: Yükleme başarısız olduğunda maksimum tekrar deneme sayısı
- `chunk_size`: Dosya aktarım blok boyutu (bayt, henüz uygulanmadı)

### 2. Varsayılan Yapılandırma (Uyumluluk Modu)

Eğer `config.json` dosyası yoksa, program dahili varsayılan yapılandırmayı kullanır, geriye dönük uyumluluğu korur.

#### Yapılandırma Dosyası Önceliği

1. **Komut satırı ile belirtilen yapılandırma dosyası**: `--config` parametresi ile belirtilen dosya
2. **Varsayılan yapılandırma dosyası**: Mevcut dizindeki `config.json`
3. **Dahili varsayılan yapılandırma**: Yukarıdakiler yoksa programın içindeki yapılandırma kullanılır

#### Yol İşleme Kuralları

- **Yapılandırma dosyası yolu**:

  - Göreli yol: Yürütülebilir dosyanın bulunduğu dizine göre hesaplanır
  - Mutlak yol: Belirtilen yol doğrudan kullanılır
- **Yerel dizin yolu**:

  - Göreli yol: Yürütülebilir dosyanın bulunduğu dizine göre hesaplanır
  - Mutlak yol: Belirtilen yol doğrudan kullanılır

## Çalıştırma Talimatları

### Komut Satırı Parametreleri

Program aşağıdaki komut satırı parametrelerini destekler:

```bash
# Yardım bilgisini göster
./deploy --help

# Sürüm bilgisini göster  
./deploy --version

# Varsayılan yapılandırma dosyası config.json ile çalıştır
./deploy

# Belirtilen yapılandırma dosyası ile çalıştır
./deploy --config prod.json

# Mutlak yol ile yapılandırma dosyası kullanarak çalıştır
./deploy --config /path/to/config.json
```

### Geliştirme Ortamında Çalıştırma

```bash
# Varsayılan yapılandırma ile çalıştır
go run main.go

# Belirtilen yapılandırma dosyası ile çalıştır
go run main.go --config test.json

# Yardım bilgisini göster
go run main.go --help
```

### Derlendikten Sonra Çalıştırma

```bash
# Derle
go build -o deploy main.go

# Varsayılan yapılandırma ile çalıştır
./deploy

# Belirtilen yapılandırma dosyası ile çalıştır
./deploy --config prod.json
```

## Paketleme Talimatları

### 1. Yerel Platform için Paketleme

```bash
# Mevcut platform için yürütülebilir dosya derle
go build -o deploy main.go
```

### 2. Çapraz Platform Paketleme

#### Linux 64-bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64-bit

```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64-bit

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Paketlemeyi Optimize Etme (Dosya Boyutunu Küçültme)

```bash
# Hata ayıklama bilgisi ve sembol tablosunu kaldır
go build -ldflags="-s -w" -o deploy main.go

# UPX ile sıkıştırma (Önce UPX'i yüklemeniz gerekir)
upx --best deploy
```

### 4. Toplu Paketleme Scripti

`build.sh` scriptini oluşturun:

```bash
#!/bin/bash

# Derleme dizini oluştur
mkdir -p builds

# Her platform için derleme
echo "Linux 64-bit sürümü derleniyor..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Windows 64-bit sürümü derleniyor..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "macOS 64-bit sürümü derleniyor..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "macOS ARM64 sürümü derleniyor..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Derleme tamamlandı!"
ls -la builds/
```

Scripti çalıştırın:

```bash
chmod +x build.sh
./build.sh
```

## Kullanım Örneği

### Yardım Bilgisini Göster

```bash
$ ./deploy --help
Go-Deploy Dağıtım Aracı

Kullanım: ./deploy [seçenekler]

Seçenekler:
  -config string
        Yapılandırma dosyası yolu (varsayılan "config.json")
  -help
        Yardım bilgisini göster
  -version
        Sürüm bilgisini göster

Örnekler:
  ./deploy                           # Varsayılan yapılandırma dosyası config.json ile kullan
  ./deploy --config prod.json        # Belirtilen yapılandırma dosyasını kullan
  ./deploy --config /path/to/config.json  # Mutlak yol ile yapılandırma dosyasını kullan
```

### Belirtilen Yapılandırma Dosyasını Kullanma

```bash
$ ./deploy --config prod.json
Dağıtım programı çalıştırılıyor...
Yapılandırma dosyası okunmaya çalışılıyor: /path/to/go-deploy/prod.json
Yapılandırma dosyası kullanılıyor...
Yerel dizin /path/to/project/dist mevcut
SSH sunucusuna bağlanılıyor...
SSH sunucu bağlantısı başarılı
...
```

### Yapılandırma Dosyası ile Kullanma

```bash
$ ./deploy
Dağıtım programı çalıştırılıyor...
Yapılandırma dosyası okunmaya çalışılıyor: /path/to/go-deploy/config.json
Yapılandırma dosyası kullanılıyor...
Yerel dizin /path/to/project/unpackage/dist/build/web mevcut
SSH sunucusuna bağlanılıyor...
SSH sunucu bağlantısı başarılı
SFTP istemcisi oluşturuluyor...
SFTP istemcisi başarıyla oluşturuldu
Uzak dizine yüklemeye hazırlanılıyor: /opt/xsoft/nginx/html/app/dist
Dizin yüklenmeye başlıyor...
Yerel dizin taranıyor: /path/to/project/unpackage/dist/build/web
Dizin oluşturuluyor: /opt/xsoft/nginx/html/app/dist
Dosya static/js/app.js.map hariç tutuldu, yükleme atlandı
Yedek oluşturuluyor: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Dosya yükleniyor: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Dosya .DS_Store hariç tutuldu, yükleme atlandı
Dosya yükleniyor: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Yükleme başarısız (deneme 1/3): Ağ hatası
Dosya yeniden yükleniyor (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Dosya yükleniyor: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Dizin yükleme başarılı!
İstatistikler:
  - Yüklenen dosya sayısı: 485
  - Oluşturulan dizin sayısı: 18
  - Aktarılan boyut: 25.8 MB
  - Yükleme süresi: 38.5s
  - Toplam süre: 39.2s
  - Aktarım hızı: 0.67 MB/s
```

## Dikkat Edilmesi Gerekenler

1. **Güvenlik**:

   - Üretim ortamında şifre yerine SSH anahtar doğrulaması kullanılması önerilir
   - Şu anda `ssh.InsecureIgnoreHostKey()` kullanılıyor, üretim ortamında anahtar doğrulaması yapılmalıdır
2. **Ağ**:

   - Yerel makinenin hedef sunucunun 22. portuna erişebildiğinden emin olun
   - Aktarım hızı ağ bant genişliğine ve sunucu performansına bağlıdır
3. **İzinler**:

   - SSH kullanıcısının hedef dizinde yazma izni olduğundan emin olun
   - Gerekirse sudo yetkisi kullanılması gerekebilir
4. **Yollar**:

   - Yerel yol otomatik olarak çalıştırılabilir dosyanın konumuna göre hesaplanır, çalışma dizini önemli değildir
   - Uzak yol mutlak yoldur

## Sorun Giderme

### Yaygın Sorunlar

1. **Bağlantı Zaman Aşımı**

   ```
   SSH sunucusuna bağlanılamadı: dial tcp: i/o timeout
   ```

   - Sunucu adresi ve portunu kontrol edin
   - Ağ bağlantısını doğrulayın
   - Güvenlik duvarı ayarlarını kontrol edin
2. **Kimlik Doğrulama Başarısız**

   ```
   Giriş başarısız: ssh: handshake failed
   ```

   - Kullanıcı adı ve şifreyi kontrol edin
   - SSH servisinin çalıştığından emin olun
   - SSH yapılandırmasını kontrol edin
3. **Yetki Hatası**

   ```
   Dizin oluşturma başarısız: permission denied
   ```

   - Kullanıcının hedef dizinde yazma izni olduğundan emin olun
   - Gerekirse sudo kullanın veya dizin sahibini değiştirin
4. **Yerel Dizin Bulunamadı**

   ```
   Hata: Yerel dizin /path/to/unpackage/dist/build/web bulunamadı
   ```

   - Yerel derlemenin tamamlandığından emin olun
   - Proje dizin yapısını kontrol edin
   - Program yolu otomatik hesaplar, çalışma dizinini elle değiştirmenize gerek yoktur

## Geliştirme Notları

### Proje Yapısı

```
go-deploy/
├── main.go                 # Ana program dosyası
├── go.mod                  # Go modül dosyası  
├── go.sum                  # Bağımlılık doğrulama dosyası
```
├── README.md               # Detaylı açıklama dokümanı
├── Makefile                # Derleme aracı
├── build.sh                # Toplu paketleme betiği
├── install.sh              # Tek tıkla kurulum betiği
└── config.example.json     # Konfigürasyon dosyası örneği
```

### Ana Fonksiyonlar

- `main()` - Ana fonksiyon, bağlantıyı işler ve yükleme çağrısını yapar
- `uploadDirectory()` - Dizinleri özyinelemeli olarak yükler
- `uploadFile()` - Tek bir dosya yükler
- `mkdirAll()` - Uzaktaki dizini özyinelemeli olarak oluşturur

## Lisans

MIT Lisansı

## Katkı

Issue ve Pull Request göndermeye hoş geldiniz!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---