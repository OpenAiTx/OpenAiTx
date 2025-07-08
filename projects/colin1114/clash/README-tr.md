CDN hızlandırma ve güvenlik koruması bu proje için Tencent EdgeOne tarafından sağlanmaktadır.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Bu projenin yazarı colin1114'tür.

# 🚀 Clash Abonelik Dönüştürücü

Çeşitli proxy abonelik linklerini Clash yapılandırma formatına dönüştürmek için kullanılan, şık ve güçlü bir çevrimiçi araç. Cloudflare Workers & Pages ile otomatik dağıtımı destekler, hızlı ve güvenilir abonelik dönüştürme hizmeti sunar.

## ✨ Özellikler

- 🎨 **Şık modern arayüz** - Gradyan arka plan ve kart tasarımı kullanır
- 🔄 **Çoklu protokol desteği** - V2Ray, VLESS, Shadowsocks, Trojan gibi popüler protokolleri destekler
- ☁️ **Bulut tabanlı dağıtım** - Cloudflare Workers ile küresel CDN hızlandırma sağlar
- 📱 **Duyarlı tasarım** - Masaüstü ve mobilde mükemmel uyum
- ⚡ **Hızlı dönüşüm** - Abonelik linklerini anında Clash yapılandırmasına dönüştürür
- 📋 **Akıllı kopyalama** - Oluşturulan YAML yapılandırmasını tek tıkla kopyalama, tüm tarayıcılarla uyumlu
- 📡 **Abonelik linki oluşturma** - Clash’e doğrudan aktarılabilen abonelik linkini otomatik üretir
- 🌐 **Çevrimiçi YAML erişimi** - Çeşitli YAML dosyası erişim yöntemleri sunar:
  - 📡 Abonelik linki: Clash istemcisi ile otomatik güncelleme desteği
  - 🔗 Çevrimiçi görüntüleme: Yapılandırma içeriğini tarayıcıda direkt görüntüleme
  - 💾 Dosya indirme: .yaml dosyasını yerel olarak indir
  - ⚡ Hızlı erişim: Kısaltılmış indirme linki
- 🔧 **UTF-8 desteği** - Çince düğüm adları ve yapılandırmaları tam destekler
- 🆓 **Tamamen ücretsiz** - Cloudflare’ın ücretsiz hizmetiyle, kullanım kısıtlaması olmadan

## 📁 Proje Yapısı

```
clash/
├── index.html              # Ön uç sayfası
├── worker.js               # Cloudflare Worker arka uç kodu
├── wrangler.jsonc          # Wrangler yapılandırma dosyası
├── _headers                # Cloudflare Pages HTTP başlık yapılandırması
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions dağıtım yapılandırması
├── README.md              # Proje açıklama dokümanı
└── package.json           # Proje yapılandırma dosyası
```

## 🚀 Hızlı Başlangıç

### Yöntem 1: Yerel Çalıştırma

1. **Projeyi klonlayın**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Yerel sunucuyu başlatın**
   ```bash
   # Python ile
   python -m http.server 8000
   
   # veya Node.js ile
   npx serve .
   ```

3. **Uygulamayı açın**
   - Tarayıcıda `http://localhost:8000` adresine gidin
   - Yerel ortamda örnek yapılandırma görüntülenecektir

### Yöntem 2: Cloudflare Workers ile Dağıtım

#### Adım 1: Worker Oluşturun

1. [Cloudflare Workers](https://workers.cloudflare.com/) adresine gidin
2. Cloudflare hesabı oluşturun/giriş yapın
3. "Create a Worker" butonuna tıklayın
4. `worker.js` dosyasındaki kodun tamamını editöre yapıştırın
5. "Save and Deploy" butonuna tıklayın

#### Adım 2: Wrangler CLI ile Dağıtım

```bash
# Wrangler CLI’yı yükleyin
npm install -g wrangler

# Cloudflare’a giriş yapın
wrangler login

# Worker’ı dağıtın
npm run deploy:worker
```

#### Adım 3: Alan Adı Yapılandırması (Opsiyonel)

1. Worker ayarlarından özel alan adı ekleyin
2. Veya Cloudflare’ın varsayılan alan adını kullanın

### Yöntem 3: Cloudflare Pages ile Dağıtım

#### Seçenek A: GitHub Entegrasyonu (Tavsiye Edilir)

1. **Depoyu hazırlayın**
   - Kodu GitHub deposuna gönderin
   - Gerekli tüm dosyaların dahil olduğundan emin olun
2. **Pages Projesi Oluşturma**
   - [Cloudflare Pages](https://pages.cloudflare.com/) adresini ziyaret edin
   - GitHub deposunu bağlayın
   - Proje deposunu seçin

3. **Yapılandırma Ayarları**
   - Yapı komutu: Boş bırakın veya `echo "No build required"`
   - Yapı çıktı dizini: `/` (kök dizin)
   - Ortam değişkenleri: Ayarlamaya gerek yok

#### Seçenek B: Doğrudan Yükleme

```bash
# Wrangler Pages ile dağıtım
npm run deploy:pages
```

## 🛠️ Teknik Mimari

### Ön Uç Teknoloji Yığını
- **HTML5** - Modern işaretleme dili
- **CSS3** - Duyarlı tasarım ve animasyon efektleri
- **Vanilla JavaScript** - Hafif ön uç etkileşimi

### Arka Uç Teknoloji Yığını
- **Cloudflare Workers** - Uç bilişim platformu
- **Web API'leri** - Standart Fetch API ve yanıt işlemesi

### Desteklenen Protokol Formatları
- **VMess** - V2Ray standart protokolü
- **VLESS** - V2Ray hafif protokolü (Reality destekli)
- **Shadowsocks** - Klasik proxy protokolü
- **Trojan** - Yeni nesil proxy protokolü

### API Uç Noktaları
- `GET /` - Ana sayfa
- `POST /convert` - Abonelik dönüştürme API'si
- `GET /clash/{config-id}` - YAML yapılandırma dosyası alma (abonelik bağlantısı)
- `GET /yaml/{config-id}` - YAML yapılandırma dosyası indirme
- `OPTIONS /*` - CORS ön kontrol isteği

## 📖 Kullanım Kılavuzu

### Temel Kullanım

1. **Abonelik Bağlantısı Girin**
   - Proxy abonelik bağlantınızı giriş kutusuna yapıştırın
   - Base64 kodlu abonelik bağlantıları desteklenir

2. **Yapılandırma Adı Ayarlama**
   - Yapılandırma dosyasına isteğe bağlı olarak özel bir ad verebilirsiniz
   - Varsayılan: "My Clash Config"

3. **Yapılandırmayı Dönüştür**
   - "Aboneliği Dönüştür" butonuna tıklayın
   - Dönüştürme işleminin tamamlanmasını bekleyin

4. **Yapılandırmayı Kullan**
   - Oluşturulan YAML yapılandırmasını kopyalayın
   - Clash istemcisine aktararak kullanın

5. **Abonelik Bağlantısını Kullan (Tavsiye Edilir)**
   - Oluşturulan abonelik bağlantısını kopyalayın
   - Clash istemcisine abonelik ekleyin
   - Yapılandırma otomatik olarak senkronize edilir, manuel güncellemeye gerek yoktur

### Gelişmiş Yapılandırma

Oluşturulan Clash yapılandırması aşağıdaki özellikleri içerir:

- **Proxy Grup Politikası**
  - 🚀 Düğüm Seçimi - Proxy'yi manuel seçme
  - ♻️ Otomatik Seçim - Gecikme testiyle otomatik seçim
  - 🎯 Global Doğrudan Bağlantı - Direkt bağlantı

- **DNS Yapılandırması**
  - DNS çözümleme etkin
  - fake-ip modu desteklenir
  - Yurtiçi ve yurtdışı DNS ayırma

- **Yönlendirme Kuralları**
  - Yerel adresler doğrudan bağlanır
  - Yurtiçi IP’ler doğrudan bağlanır
  - Diğer trafiğin proxy üzerinden geçişi

## 🔧 Dağıtım Sorun Giderme

### Sıkça Sorulan Sorunlar

#### 1. Wrangler giriş noktası bulunamıyor
**Hata mesajı**: `Missing entry-point to Worker script`

**Çözüm**: 
- Proje kök dizininde `wrangler.jsonc` dosyasının olduğundan emin olun
- `wrangler.jsonc` içindeki `main` alanının `worker.js` dosyasını gösterdiğini kontrol edin

#### 2. GitHub Actions dağıtımı başarısız
**Çözüm**:
- GitHub depo ayarlarında aşağıdaki Secrets değerlerini ekleyin:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API belirteci
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare hesap ID’si

#### 3. Pages Derleme Başarısız
**Çözüm**:
- Derleme komutunu boş veya `echo "No build required"` olarak ayarlayın
- Derleme çıktı dizininin `/` olarak ayarlandığından emin olun

### Dağıtım Yapılandırma Dosyası Açıklaması

- **`wrangler.jsonc`**: Worker dağıtımı için Wrangler CLI yapılandırması
- **`_headers`**: Cloudflare Pages HTTP başlık yapılandırması
- **`.github/workflows/deploy.yml`**: GitHub Actions otomatik dağıtım yapılandırması

## 🔧 Özelleştirilmiş Yapılandırma

### Proxy Grubunu Değiştirme

`worker.js` içindeki `convertToClash` fonksiyonunu düzenleyerek proxy grubunu özelleştirebilirsiniz:

```javascript
'proxy-groups': [
  {
    name: '🚀 Node Seçimi',
    type: 'select',
    proxies: ['♻️ Otomatik Seçim', '🎯 Global Direkt', ...proxyNames]
  },
  // Daha fazla proxy grubu ekleyin...
]
```

### Özelleştirilmiş Yönlendirme Kuralları

`rules` dizisini düzenleyerek özelleştirilmiş yönlendirme kuralları ekleyebilirsiniz:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Node Seçimi',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Daha fazla kural ekleyin...
]
```

## 📊 Performans Özellikleri

- **Küresel CDN** - Cloudflare’ın dünya çapındaki edge node’ları
- **Hızlı Yanıt** - Ortalama yanıt süresi < 100ms
- **Yüksek Erişilebilirlik** - %99.9 servis kullanılabilirliği
- **Ücretsiz Kota** - Günde 100.000 isteğe kadar ücretsiz

## 🔒 Güvenlik Açıklamaları

- **Veri Gizliliği** - Abonelik verisi yalnızca dönüşüm sırasında kullanılır, depolanmaz
- **HTTPS Şifreleme** - Tüm iletişim HTTPS ile şifrelenir
- **Açık Kaynak Şeffaflığı** - Tüm kaynak kodu açık, dilediğiniz gibi inceleyebilirsiniz

## 🤝 Katkı Rehberi

Issue ve Pull Request göndermekten memnuniyet duyarız!

1. Depoyu fork’layın
2. Özellik dalı oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişiklikleri ekleyin (`git commit -m 'Add some AmazingFeature'`)
4. Dalı gönderin (`git push origin feature/AmazingFeature`)
5. Pull Request başlatın

## 📝 Değişiklik Günlüğü

### v1.1.0
- ✅ VLESS protokol desteği eklendi (Reality güvenli aktarım dahil)
- ✅ Protokol uyumluluğu geliştirildi

### v1.0.0
- ✅ Temel abonelik dönüştürme işlevi
- ✅ Şık kullanıcı arayüzü
- ✅ Cloudflare Workers desteği
- ✅ Çoklu protokol desteği (VMess, Shadowsocks, Trojan)
- ✅ Duyarlı tasarım
- ✅ Tek tıkla kopyalama özelliği

## 📞 Destek ve Geri Bildirim

Kullanım sırasında bir sorunla karşılaşırsanız veya öneriniz varsa lütfen:

1. Bu README belgesine bakın
2. [Issue](../../issues) gönderin
3. [Discussion](../../discussions) başlatın

## 📄 Lisans

Bu proje MIT lisansı ile lisanslanmıştır - Detaylar için [LICENSE](LICENSE) dosyasına bakın

## 🙏 Teşekkürler

- [Cloudflare Workers](https://workers.cloudflare.com/) - Edge computing platformu sağlayıcısı
- [Clash](https://github.com/Dreamacro/clash) - Mükemmel proxy istemcisi
- Tüm katkıda bulunanlar ve kullanıcıların desteği

---
⭐ Eğer bu proje sana yardımcı olduysa, lütfen ona bir Yıldız ver!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---