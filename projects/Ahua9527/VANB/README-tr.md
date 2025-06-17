# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (Vay!! NB)

VANB, GStreamer tabanlı bir video/ses akış dönüştürme aracıdır ve NDI ile RTMP protokolleri arasında çift yönlü dönüşümü destekler. NDI kaynağını RTMP sunucusuna gönderebilir veya RTMP akışını NDI çıkışına dönüştürebilirsiniz.

Bu proje [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) lisansı ile açık kaynak olarak sunulmaktadır.

## Desteklenen Platformlar

Şu anda esas olarak aşağıdaki platformları desteklemektedir:
- macOS (Apple Silicon)

## Sistem Gereksinimleri

### Sistem Bağımlılıkları
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Kurulum Adımları
1. [NewTek NDI SDK](https://www.ndi.tv/sdk/) kurun

2. Homebrew ile GStreamer kurun
```bash
brew install --cask --zap gstreamer-development
```

3. Proje deposunu klonlayın
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Python bağımlılıklarını kurun
```bash
pip install -r requirements.txt
```

5. Ortam değişkenlerini yapılandırın (.env dosyasına bakınız)
```bash
# NDI SDK yolunu yapılandır
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# GStreamer eklenti yolunu yapılandır
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Kullanım Yöntemi

### NDI'dan RTMP'ye (Gönderici)
```bash
python vanb_tx.py
```
Program mevcut NDI kaynaklarını otomatik olarak tarar ve RTMP yayın adresini girmenizi ister.

### RTMP'den NDI'ya (Alıcı)
```bash
python vanb_rx.py
```
RTMP akış adresini girdikten sonra program otomatik olarak yeni bir NDI çıkışı oluşturacaktır.

## Geliştirme Durumu

### Gerçekleştirilen Özellikler
- ✓ NDI'dan RTMP'ye dönüşüm
- ✓ RTMP'den NDI'ya dönüşüm
- ✓ Otomatik kare hızı ve çözünürlük uyarlama
- ✓ Ses ve video senkronizasyonu
- ✓ NDI kaynaklarını otomatik tarama
- ✓ NDI çıkışı için otomatik adlandırma
- ✓ VideoToolbox donanım kodlama/çözme

### Gerçekleştirilecek Özellikler
- ⨯ Yapılandırma dosyası desteği (Profile/config.json)
  - Girdi ve çıktı parametrelerini yapılandırma dosyasıyla kontrol etme
  - Birden fazla transkodlama ön ayarını destekleme
  - Tampon boyutu ve gecikme parametrelerinin yapılandırılabilir olması
  - Transkodlama kalitesi ve performans dengesi ayarları desteği
- ⨯ Çoklu akış eşzamanlı işleme

## Lisans Bildirimi

⚠️ **Önemli Uyarı: Lisans ve Uyum**

### Yazılım Lisansı

Bu proje [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html) ile lisanslanmıştır.

GPL-3.0 lisansının seçilme nedenleri:
1. Bu projede birden çok GPL lisanslı GStreamer eklentisi kullanılmıştır:
   - `x264`: H.264 video kodlayıcı (GPL)
   - `x265`: HEVC/H.265 video kodlayıcı (GPL)
   - `faad`: AAC ses çözücü (GPL)
2. GPL’in bulaşıcı lisans hükümlerine göre, GPL bileşenleri kullanan yazılım da GPL lisansı ile sunulmalıdır
3. GPL-3.0 seçimi, tüm bağımlı bileşenlerin lisanslarıyla uyumu garanti eder

### Lisans Koşulları

Bu projeyi kullanırken aşağıdaki koşullara uymalısınız:
1. **Kod Açıklığı**: Bu projenin kodunu değiştirir veya kendi projenize dahil ederseniz, tüm kaynak kodunuzu açık kaynak yapmalısınız
2. **Lisansı Korumak**: Projeniz GPL-3.0 lisansı ile devam etmelidir
3. **Telif Hakkı Bildirimi**: Orijinal telif hakkı ve lisans bildirimini korumalısınız
4. **Belirgin Not**: Kodda değişiklik yaptıysanız, yaptığınız değişiklikleri açıkça belirtmelisiniz
5. **Patent İzni**: GPL-3.0 açık patent lisans koşulları içerir

### GStreamer Bileşen Lisansı
1. Bu proje yalnızca geliştirme ve test amaçlıdır
2. NDI® , NewTek, Inc.'in tescilli markasıdır
3. Bu projeyi kullanırken NewTek NDI® SDK lisans sözleşmesine uymalısınız
4. Üretim ortamında kullanmadan önce gerekli tüm lisans ve izinleri aldığınızdan emin olun

## Sorun Bildirimi

Sorunla karşılaşırsanız lütfen:
1. Ortam değişkenlerini doğru yapılandırıp yapılandırmadığınızı kontrol edin
2. GStreamer eklentilerinin düzgün kurulu olup olmadığını doğrulayın
3. Günlük dosyasında ayrıntılı hata bilgilerini inceleyin
4. Issues üzerinden sorun bildirin ve günlük ile ortam bilgilerini ekleyin

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---