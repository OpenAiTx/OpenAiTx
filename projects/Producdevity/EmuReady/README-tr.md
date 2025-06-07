# EmuReady

Farklı cihazlar ve emülatörler arasında emülasyon uyumluluğunu takip etmeye yönelik, topluluk odaklı bir platform.

Web sitemizi ziyaret edin: [https://emuready.com](https://emuready.com)

---

**Ana Sayfa Ekran Görüntüsü**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Uyumluluk Listeleri Sayfası Ekran Görüntüsü**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Oyunlar Sayfası Ekran Görüntüsü**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Genel Bakış

EmuReady, kullanıcıların farklı donanım ve yazılım yapılandırmalarında emülasyon uyumluluk bilgilerini paylaşmalarına ve keşfetmelerine yardımcı olur. Kullanıcılar uyumluluk raporları ekleyebilir, listelemelere oy verebilir ve belirli oyun/cihaz/emülatör kombinasyonlarını tartışabilirler.

![Lisans](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Yıldız](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Çatallar](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Sorunlar](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Özellikler

- **Kapsamlı Uyumluluk Veritabanı**: Oyunların farklı emülatör ve cihazlarda nasıl çalıştığını takip edin
- **Kullanıcı Katkıları**: Topluluk odaklı raporlar ve oylama sistemi
- **Tartışma Sistemi**: Oy verilebilen/oy azaltılabilen yorum başlıkları
- **Yönetici Paneli**: Kullanıcıları, listelemeleri ve içerik moderasyonunu yönetin
- **Duyarlı Tasarım**: Mobil, tablet ve masaüstünde çalışır

## Son İyileştirmeler

Kod tabanı aşağıdaki geliştirmeler ile önemli ölçüde iyileştirildi:

### UI Bileşenleri

- Daha iyi hata yönetimi ve kurtarma için **ErrorBoundary** bileşeni oluşturuldu
- Daha iyi performans için Next.js Image bileşenini kullanan **OptimizedImage** bileşeni eklendi
- **Sayfalama** geliştirildi: Erişilebilirlik özellikleri, klavye ile gezinme ve daha iyi kullanıcı deneyimi
- Daha fazla varyant, boyut ve hap seçeneğiyle **Badge** bileşeni geliştirildi
- Açık, koyu ve sistem temaları arasında geçiş için **ThemeToggle** bileşeni eklendi
- Görsel göstergelerle tablo sıralama için **SortableHeader** uygulandı

### Önbellekleme & Performans

- Daha iyi varsayılanlarla React Query yapılandırması geliştirildi (önbellekleme, bayatlama süreleri, yeniden deneme mantığı)
- Cihaz görselleri için resim optimizasyonu eklendi
- Uygulama genelinde uygun hata yönetimi uygulandı

### Erişilebilirlik

- Etkileşimli öğeler için klavye ile gezinme geliştirildi
- Uygun ARIA etiketleri ve rolleri eklendi
- Odak yönetimi geliştirildi
- UI bileşenlerinde daha iyi renk kontrastı

### Güvenlik

- Birden fazla seviyede (istemci, sunucu, veritabanı) veri doğrulama ve temizleme
- İçerik Güvenlik Politikası uygulanması
- XSS ve CSRF saldırılarına karşı koruma
- NextAuth.js ile güvenli kimlik doğrulama
- Dosya yükleme doğrulaması ve güvenlik önlemleri
- Girdi uzunluğu kısıtlamaları ve uygun temizleme
- Parametre manipülasyonunu önlemek için UUID doğrulama

### Geliştirici Deneyimi

- Geliştirme iş akışı için ek npm komutları eklendi
- Tutarlı dışa aktarımlar ile daha iyi proje yapısı
- Özel ErrorBoundary ile geliştirilmiş hata geri bildirimi
- Kullanışlı gezinme seçenekleriyle geliştirilmiş 404 sayfası

### Tema Desteği

- Sistem tema tercihi algılama eklendi
- Birden fazla UI seçeneğiyle tema geçişi oluşturuldu
- Bileşenler genelinde koyu mod uygulaması geliştirildi

## Başlarken

### Gereksinimler

- Node.js 20+
- `npm`
- PostgreSQL (veya geliştirme için SQLite)

### Kurulum

1. Depoyu klonlayın

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Bağımlılıkları yükleyin

```bash
npm install
```

3. Ortam değişkenlerini ayarlayın

```bash
cp .env.example .env
```

Ardından `.env` dosyasını veritabanı bilgileriniz ve diğer yapılandırmalarınız ile düzenleyin.

4. Veritabanını kurun

```bash
npx prisma generate
npx prisma db push
```

5. Geliştirme sunucusunu başlatın

```bash
npm run dev
```

6. Tarayıcınızda [http://localhost:3000](http://localhost:3000) adresini açın

## Kullanılabilir Komutlar

- `npm run dev` - Geliştirme sunucusunu başlatır
- `npm run dev:strict` - React strict modu ile başlatır
- `npm run build` - Prodüksiyon için derler
- `npm run start` - Prodüksiyon sunucusunu başlatır
- `npm run test` - Testleri çalıştırır
- `npm run lint` - ESLint çalıştırır
- `npm run lint:fix` - Hataları otomatik düzeltir
- `npm run format` - Prettier ile kodu biçimlendirir
- `npm run typecheck` - TypeScript tiplerini kontrol eder
- `npm run analyze` - Paket boyutunu analiz eder
- `npm run clean` - Derleme önbelleğini temizler
- `npm run prepare-deploy` - Dağıtım için hazırlar (lint, typecheck, test, build)

### Prisma Komutları

- `npx prisma db seed` - Veritabanını tohumlar
- `npx prisma studio` - Prisma Studio'yu açar
- `npx prisma db pull` - Veritabanı şemasını çeker
- `npx prisma db push` - Veritabanı şemasını iter

Daha fazla bilgi için [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) adresine bakın.

## Teknoloji Yığını

- **Çatı**: Next.js 15
- **Veritabanı ORM**: Prisma
- **API**: tRPC
- **Kimlik Doğrulama**: NextAuth.js
- **Stil**: Tailwind CSS
- **Durum Yönetimi**: React Query
- **Tip Kontrolü**: TypeScript
- **Animasyon**: Framer Motion
- **Doğrulama**: Zod, İçerik Güvenlik Politikası, Girdi Doğrulama

## Katkıda Bulunma

Katkılarınızı bekliyoruz! Daha fazla detay için [Katkı Rehberi](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) dosyamıza bakabilirsiniz.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır - detaylar için [LİSANS](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) dosyasına bakın.

## Davranış Kuralları (YAPILACAK)

Lütfen bu projenin bir [Davranış Kuralları](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md) belgesine bağlı olduğunu unutmayın. Bu projeye katılarak, şartlarını kabul etmiş olursunuz.

## Güvenlik (YAPILACAK)

Bir güvenlik açığı keşfederseniz, lütfen [Güvenlik Politikamızı](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) takip ederek bildirin.

## Teşekkürler

- Tüm [Katkıda Bulunanlar](https://github.com/Producdevity/emuready/graphs/contributors)
- İlham ve destek için emülasyon topluluğu

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---