# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Kareler arasında sevgi, verimlilik ikiye katlanır

[//]: # (Koddaki gizli yumurta)
<!Double Love：Her karede söyleyemediğim kare hızı saklı olsun -->

[English](./README.en.md) · 简体中文 · [Çevrimiçi Deneyim](https://double-love.ahua.space)

</div>

Double Love, set metaverilerini otomatik olarak standartlaştırmak için bir çözüm sunar. Çevrimdışı kullanılabilir. Toplu işleme ve yerel işlem yoluyla Adobe Premiere, Silverstack, DTG Slate ile sorunsuz entegre olur ve metaveri tutarlılığını sağlar. Post prodüksiyon iş akışı verimliliğini etkin şekilde artırır.

## ✨ Özellikler

- 🎬 Sinema endüstriyel iş akışı desteği
- 📝 Akıllı metaveri standartlaştırma işlemi
- ⚡ Sıfır gecikmeli yerel işleme
- 🧩 Adobe Premiere ile sorunsuz entegrasyon

## 🚀 Hızlı Başlangıç

### Temel İş Akışı

1. Set kayıt: DTG Slate ile interaktif set formu oluşturun
2. Veri yönetimi: Silverstack Lab ile set verilerini içe aktarın
3. Dosya dışa aktarımı: Adobe Premiere Pro XML oluşturun
4. Standartlaştırma: Double Love ile akıllı optimizasyon yapın

Örnek:
- Girdi xml: `UnitA_304_20250127.xml`
- Çıktı xml: `UnitA_304_20250127_Double_LOVE.xml`

### Detaylı Örnekler

#### Dosya Adı Optimizasyonu
- Yazılım, sahne numarası, çekim numarası ve tekrar numarası formatını otomatik işler
- Sayılara otomatik ön sıfır ekler
- Büyük-küçük harf uyumunu otomatik ayarlar
- Fazladan alt çizgileri otomatik temizler

#### Parça İsimlendirme Kuralları

İşlenmiş parça adı aşağıdaki formata uyar:
```
{proje öneki}{sahne}_{çekim}_{tekrar}{kamera}{derecelendirme}
```

- `prefix`: Özelleştirilebilir ön ek (isteğe bağlı)
- `scene`: Sahne numarası (3 haneli rakam, örn. 001)
- `shot`: Çekim numarası (2 haneli rakam, örn. 01)
- `take`: Tekrar numarası (2 haneli rakam, örn. 01)
- `camera`: Kamera işareti (küçük harf, örn. a)
- `Rating`: Derecelendirme (ok/kp/ng)

#### Derecelendirme İşlemi
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT Bilgisi
- DIT bilgisi otomatik eklenir: 'DIT: 哆啦Ahua 🌱'
- Kaldırmak isterseniz, kendi dağıtımınızı yapınız😁😁

#### Özelleştirilmiş Ön Ek Örneği

1. Ön ek olarak "PROJECT_A_" ayarlayın:
   - Girdi dosyası: `A304C007_250123G3`
   - Çıktı dosyası: `PROJECT_A_004_01_07a_kp`

2. Ön ek olmadan:
   - Girdi dosyası: `A304C007_250123G3`
   - Çıktı dosyası: `004_01_07a_kp`

#### Dizi Çözünürlüğü Ayarı Örneği

1. FHD çözünürlük (varsayılan):
   - Genişlik: 1920
   - Yükseklik: 1080   
2. DCI 2K çözünürlük (özelleştirilmiş):
   - Genişlik: 2048
   - Yükseklik: 1080   

#### Toplu İşleme Örneği

1. Birden fazla dosyayı aynı anda yükleyin:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. İşlem tamamlandıktan sonra elde edilecekler:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Teknoloji Yığını

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA Desteği

## 📦 Kurulum ve Kullanım

1. Projeyi klonlayın

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Bağımlılıkları yükleyin

```bash
npm install
```

3. Yerel geliştirme

```bash
npm run dev
```

4. Projeyi derleyin

```bash
npm run build
```

## 🔒 Güvenlik Notları

- Tüm dosya işlemleri tarayıcıda yerel olarak gerçekleşir, sunucuya yüklenmez
- Maksimum 50MB dosya boyutu desteği
- Sadece XML dosya formatı desteklenir

## 🌈 Geliştirici Notları

### Proje Yapısı

```
Double-Love/
├── src/
│   ├── components/     # React bileşenleri
│   ├── context/        # React Context
│   ├── utils/          # Yardımcı fonksiyonlar
│   ├── styles/         # Stil dosyaları
│   └── App.tsx         # Ana uygulama bileşeni
├── public/             # Statik kaynaklar
└── ...konfigürasyon dosyaları
```

## 📃 Lisans

[MIT License](LICENSE)

## 🤝 Katkı Rehberi

Issue ve Pull Request göndermeye hoş geldiniz!

## 👨‍💻 Yazar

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---