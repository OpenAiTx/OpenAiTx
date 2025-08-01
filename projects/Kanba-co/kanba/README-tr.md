<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Programı" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# Üreticiler ve bağımsız geliştiriciler için tasarlanmış açık kaynak, hafif Trello alternatifi.

Basitlik, hız ve ölçeklenebilirliğe odaklanır.
Modern teknolojiyle inşa edildi: Tailwind CSS, shadcn/ui, Supabase, Stripe entegrasyonu.
Sınırsız proje, ekip iş birliği, karanlık/açık mod ve sorunsuz kullanıcı deneyimi sunar.
Gereksiz karmaşıklık olmadan tam kontrol isteyen bireysel geliştiriciler ve küçük ekipler için idealdir.

## 🌟 Bu projeyi faydalı buluyorsanız, bir yıldız vermeyi düşünün! Başkalarının da keşfetmesine yardımcı olur.

# Dağıtım Rehberi

## Genel Bakış
Bu uygulama artık Stripe entegrasyonu için Supabase Edge Functions yerine yerel Next.js API rotalarını kullanıyor. Bu, dağıtımı basitleştirir ve yapılandırma için standart .env dosyalarını kullanmanıza olanak tanır.

## Ortam Değişkenleri Kurulumu

### 1. .env.local dosyası oluşturun
`.env.example` dosyasını `.env.local` olarak kopyalayın ve gerçek değerlerle doldurun:


```bash
cp .env.example .env.local
```

### 2. Gerekli Ortam Değişkenleri

#### Supabase Yapılandırması
- `NEXT_PUBLIC_SUPABASE_URL` - Supabase proje URL'niz
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Supabase anonim anahtarınız
- `SUPABASE_SERVICE_ROLE_KEY` - Supabase servis rol anahtarınız (sadece sunucu tarafı)

#### Stripe Yapılandırması (isteğe bağlı)
- `STRIPE_SECRET_KEY` - Stripe gizli anahtarınız (sadece sunucu tarafı)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Stripe yayınlanabilir anahtarınız
- `STRIPE_WEBHOOK_SECRET` - Stripe webhook gizli anahtarınız

#### Site Yapılandırması
- `NEXT_PUBLIC_SITE_URL` - Sitenizin URL'si (canlı ortam için)
- `NEXTAUTH_URL` - Sitenizin URL'si (yukarıdakiyle aynı)
- `NEXTAUTH_SECRET` - NextAuth için rastgele bir gizli anahtar

## Yerel Geliştirme

1. Bağımlılıkları yükleyin:
```bash
npm install
```

2. Ortam değişkenlerinizi `.env.local` dosyasında ayarlayın

3. Geliştirme sunucusunu çalıştırın:
```bash
npm run dev
```

4. Stripe CLI kullanarak Stripe webhook'larını yerel olarak test edin:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Üretim Dağıtımı


### Vercel Dağıtımı

1. **Vercel'e Dağıt:**
```bash
npx vercel
```
2. **Ortam Değişkenleri:**
   Tüm ortam değişkenlerini Vercel kontrol paneli veya CLI üzerinden ekleyin

3. **Stripe Webhook Kurulumu:**
   - Webhook'u şu adrese yönlendirin: `https://your-domain.vercel.app/api/stripe/webhook`

## API Uç Noktaları

Uygulama artık bu yerel API rotalarını kullanıyor:

- `POST /api/stripe/checkout` - Stripe ödeme oturumları oluşturur
- `POST /api/stripe/webhook` - Stripe webhook olaylarını işler

## Yerel API Rotalarının Faydaları

1. **Daha Basit Dağıtım** - Ayrı edge fonksiyonları dağıtmaya gerek yok
2. **Ortam Değişkenleri** - Standart .env dosyası desteği
3. **Daha İyi Hata Ayıklama** - Yerelde hata ayıklamak daha kolay
4. **Çerçeve Entegrasyonu** - Next.js ile daha iyi entegrasyon
5. **Tedarikçiye Bağımlılık Yok** - Next.js'i destekleyen herhangi bir platforma dağıtılabilir

## Sorun Giderme

1. **Webhook Sorunları:**
   - `STRIPE_WEBHOOK_SECRET` değerinin Stripe webhook uç noktanızla eşleştiğinden emin olun
   - Stripe panelinde webhook günlüklerini kontrol edin
   - Webhook URL’sinin doğru olduğuna emin olun

2. **Ortam Değişkenleri:**
   - Gerekli tüm değişkenlerin ayarlandığından emin olun
   - Değişken adlarında yazım hatası olup olmadığını kontrol edin
   - Supabase servis rol anahtarının uygun izinlere sahip olduğuna emin olun

3. **CORS Sorunları:**
   - API rotalarında uygun CORS başlıkları bulunur
   - Gerekirse alan adınızın beyaz listeye alındığından emin olun

## Güvenlik Notları

- `STRIPE_SECRET_KEY` veya `SUPABASE_SERVICE_ROLE_KEY` anahtarlarını asla istemciye göstermeyin
- Yalnızca istemci tarafı değişkenleri için `NEXT_PUBLIC_` önekini kullanın
- Webhook sırlarınızı düzenli olarak değiştirin
- Stripe panelinde webhook teslimatını izleyin



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---