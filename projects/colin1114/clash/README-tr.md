
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

Bu projenin CDN hızlandırması ve güvenlik koruması Tencent EdgeOne tarafından sağlanmaktadır.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Bu projenin yazarı colin1114'dür.

# 🚀 Clash Abonelik Dönüştürücü

Çeşitli proxy abonelik bağlantılarını Clash yapılandırma formatına dönüştürmek için estetik ve güçlü bir çevrimiçi araç. Cloudflare Workers & Pages ile otomatik dağıtımı destekler, hızlı ve güvenilir abonelik dönüştürme hizmeti sunar.

## ✨ Özellikler

- 🎨 **Şık ve modern arayüz** - Gradyan arka plan ve kart tarzı tasarım kullanır
- 🔄 **Çoklu protokol desteği** - V2Ray, VLESS, Shadowsocks, Trojan gibi popüler protokolleri destekler
- ☁️ **Bulut tabanlı dağıtım** - Cloudflare Workers ile küresel CDN hızlandırması sağlar
- 📱 **Duyarlı tasarım** - Masaüstü ve mobil cihazlarla tam uyumludur
- ⚡ **Hızlı dönüşüm** - Abonelik bağlantılarını anında Clash konfigürasyonuna dönüştürür
- 📋 **Akıllı kopyalama** - Oluşturulan YAML yapılandırmasını tek tıkla kopyalama, çeşitli tarayıcılarla uyumlu
- 📡 **Abonelik bağlantısı oluşturma** - Clash’e doğrudan aktarılabilir abonelik bağlantısını otomatik üretir
- 🌐 **Çevrimiçi YAML erişimi** - Birden fazla YAML dosya erişim yöntemi sunar:
  - 📡 Abonelik bağlantısı: Clash istemcisiyle otomatik güncelleme desteği
  - 🔗 Çevrimiçi görüntüleme: Tarayıcıda yapılandırma içeriğini doğrudan görüntüleme
  - 💾 Dosya indirme: .yaml dosyasını yerel olarak indir
  - ⚡ Hızlı erişim: Basitleştirilmiş indirme bağlantısı
- 🔧 **UTF-8 desteği** - Çince düğüm adları ve yapılandırmalarını mükemmel şekilde destekler
- 🆓 **Tamamen ücretsiz** - Cloudflare’ın ücretsiz hizmetiyle, kullanım sınırlaması yoktur

## 📁 Proje Yapısı

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Hızlı Başlangıç

### Yöntem 1: Yerel Olarak Çalıştırma

1. **Projeyi klonlayın**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Yerel sunucuyu başlatın**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Uygulamaya Erişim**
   - Tarayıcıda `http://localhost:8000` adresini açın
   - Yerel ortamda örnek yapılandırma görüntülenecektir

### Yöntem 2: Cloudflare Workers ile Dağıtım

#### Adım 1: Worker Oluşturma

1. [Cloudflare Workers](https://workers.cloudflare.com/) adresini ziyaret edin
2. Cloudflare hesabına kaydolun/giriş yapın
3. "Create a Worker" butonuna tıklayın
4. `worker.js` dosyasındaki kodun tamamını editöre kopyalayın
5. "Save and Deploy" butonuna tıklayın

#### Adım 2: Wrangler CLI ile Dağıtım

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Adım 3: Alan Adı Yapılandırması (İsteğe Bağlı)

1. Worker ayarlarında özel alan adı ekleyin
2. Veya Cloudflare'ın sağladığı varsayılan alan adını kullanın

### Yöntem 3: Cloudflare Pages ile Dağıtım

#### Seçenek A: GitHub Entegrasyonu (Tavsiye Edilir)

1. **Depoyu Hazırlayın**
   - Kodu GitHub deposuna gönderin
   - Tüm gerekli dosyaların dahil edildiğinden emin olun

2. **Pages Projesi Oluşturun**
   - [Cloudflare Pages](https://pages.cloudflare.com/) adresine gidin
   - GitHub deponuzu bağlayın
   - Proje deposunu seçin

3. **Derleme Ayarları**
   - Derleme komutu: Boş bırakın veya `echo "No build required"`
   - Derleme çıktı dizini: `/` (kök dizin)
   - Ortam değişkenleri: Ayarlamaya gerek yok

#### Seçenek B: Doğrudan Yükleme

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Teknik Mimari

### Ön Uç Teknoloji Yığını
- **HTML5** - Modern işaretleme dili
- **CSS3** - Duyarlı tasarım ve animasyon efektleri
- **Vanilla JavaScript** - Hafif ön uç etkileşimleri

### Arka Uç Teknoloji Yığını
- **Cloudflare Workers** - Uç nokta hesaplama platformu
- **Web API'leri** - Standart Fetch API ve yanıt işleme

### Desteklenen Protokol Formatları
- **VMess** - V2Ray standart protokolü
- **VLESS** - V2Ray hafif protokolü (Reality desteği ile)
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

1. **Abonelik bağlantısı girin**
   - Proxy abonelik bağlantınızı giriş kutusuna yapıştırın
   - Base64 kodlu abonelik bağlantılarını destekler

2. **Yapılandırma adını ayarlayın**
   - Yapılandırma dosyası için isteğe bağlı olarak özel bir ad belirleyebilirsiniz
   - Varsayılan olarak "My Clash Config"

3. **Yapılandırmayı dönüştürün**
   - "Aboneliği Dönüştür" düğmesine tıklayın
   - Dönüştürmenin tamamlanmasını bekleyin

4. **Yapılandırmanın Kullanımı**
   - Oluşturulan YAML yapılandırmasını kopyalayın
   - Clash istemcisine aktararak kullanın

5. **Abonelik Bağlantısı Kullanımı (Önerilir)**
   - Oluşturulan abonelik bağlantısını kopyalayın
   - Clash istemcisinde abonelik ekleyin
   - Yapılandırma otomatik olarak senkronize edilir, elle güncellemeye gerek yoktur

### Gelişmiş Yapılandırma

Oluşturulan Clash yapılandırması aşağıdaki özellikleri içerir:

- **Proxy Grup Stratejisi**
  - 🚀 Düğüm Seçimi - Proxy’yi manuel seçin
  - ♻️ Otomatik Seçim - Gecikme testiyle otomatik seçim
  - 🎯 Küresel Doğrudan Bağlantı - Doğrudan bağlantı

- **DNS Yapılandırması**
  - DNS çözümlemesi etkinleştirilir
  - Fake-ip modu desteklenir
  - Yurtiçi ve yurtdışı DNS ayrımı

- **Yönlendirme Kuralları**
  - Yerel adreslere doğrudan bağlantı
  - Yurtiçi IP’lere doğrudan bağlantı
  - Diğer trafiğin proxy üzerinden yönlendirilmesi

## 🔧 Dağıtım Sorun Giderme

### Yaygın Sorunlar

#### 1. Wrangler giriş noktası bulunamıyor
**Hata mesajı**: `Missing entry-point to Worker script`

**Çözüm**: 
- Proje kök dizininde `wrangler.jsonc` dosyasının olduğundan emin olun
- `wrangler.jsonc` içindeki `main` alanının `worker.js`’i işaret ettiğini kontrol edin

#### 2. GitHub Actions dağıtımı başarısız
**Çözüm**:
- GitHub deposu ayarlarında aşağıdaki Secrets'leri ekleyin:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API belirteci
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare hesap ID'si

#### 3. Pages derlemesi başarısız
**Çözüm**:
- Derleme komutunu boş veya `echo "No build required"` olarak ayarlayın
- Derleme çıktı dizininin `/` olarak ayarlandığından emin olun

### Dağıtım yapılandırma dosyası açıklamaları

- **`wrangler.jsonc`**: Worker dağıtımı için Wrangler CLI yapılandırması
- **`_headers`**: Cloudflare Pages HTTP başlık yapılandırması
- **`.github/workflows/deploy.yml`**: GitHub Actions otomatik dağıtım yapılandırması

## 🔧 Özelleştirilmiş yapılandırma

### Proxy grubunu değiştirme

`worker.js` dosyasındaki `convertToClash` fonksiyonunu düzenleyerek proxy grubunu özelleştirebilirsiniz:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Özel Yönlendirme Kuralları

Özel yönlendirme kuralları eklemek için `rules` dizisini değiştirin:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Performans Özellikleri

- **Küresel CDN** - Cloudflare’ın dünya çapındaki uç noktaları
- **Hızlı Yanıt** - Ortalama yanıt süresi < 100ms
- **Yüksek Kullanılabilirlik** - %99,9 hizmet kullanılabilirliği
- **Ücretsiz Kota** - Günde 100.000 istek

## 🔒 Güvenlik Açıklamaları

- **Veri Gizliliği** - Abonelik verileri sadece dönüşüm sırasında kullanılır, saklanmaz
- **HTTPS Şifreleme** - Tüm iletişim HTTPS ile şifrelenir
- **Açık Kaynak Şeffaflığı** - Tüm kaynak kodu yayınlanmıştır, inceleyebilirsiniz

## 🤝 Katkı Kılavuzu

Issue ve Pull Request göndermeye hoş geldiniz!

1. Depoyu Fork'layın
2. Özellik dalı oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişiklikleri kaydedin (`git commit -m 'Add some AmazingFeature'`)
4. Dalı gönderin (`git push origin feature/AmazingFeature`)
5. Pull Request açın

## 📝 Güncelleme Günlüğü

### v1.1.0
- ✅ VLESS protokol desteği eklendi (Reality güvenli aktarım dahil)
- ✅ Protokol uyumluluğu iyileştirildi

### v1.0.0
- ✅ Temel abonelik dönüştürme işlevi
- ✅ Şık kullanıcı arayüzü
- ✅ Cloudflare Workers desteği
- ✅ Çoklu protokol desteği (VMess, Shadowsocks, Trojan)
- ✅ Duyarlı tasarım
- ✅ Tek tıkla kopyalama özelliği

## 📞 Destek ve Geri Bildirim

Eğer kullanım sırasında bir sorunla karşılaşırsanız veya öneriniz varsa lütfen:

1. Bu README belgesine göz atın
2. [Issue](../../issues) gönderin
3. [Discussion](../../discussions) başlatın

## 📄 Lisans

Bu proje MIT Lisansı ile sunulmaktadır - Ayrıntılar için [LICENSE](LICENSE) dosyasına bakınız

## 🙏 Teşekkürler

- [Cloudflare Workers](https://workers.cloudflare.com/) - Kenar hesaplama platformu sağladı
- [Clash](https://github.com/Dreamacro/clash) - Mükemmel proxy istemcisi
- Tüm katkıda bulunanlara ve kullanıcılara desteklerinden ötürü

---

⭐ Eğer bu proje size yardımcı olduysa lütfen bir Star verin! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---