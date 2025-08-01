<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# Alternatif Trello open-source, ringan, dirancang untuk pembuat dan indie hacker.

Fokus pada kesederhanaan, kecepatan, dan skalabilitas.
Dibangun dengan stack modern: Tailwind CSS, shadcn/ui, Supabase, integrasi Stripe.
Mendukung proyek tanpa batas, kolaborasi tim, mode gelap/terang, dan pengalaman pengguna yang mulus.
Sangat cocok untuk pengembang solo dan tim kecil yang ingin kendali penuh tanpa kompleksitas yang tidak perlu.

## 🌟 Jika Anda merasa proyek ini bermanfaat, pertimbangkan untuk memberi bintang! Ini membantu orang lain menemukannya juga.

# Panduan Deployment

## Ikhtisar
Aplikasi ini sekarang menggunakan rute API Next.js lokal, bukan Supabase Edge Functions untuk integrasi Stripe. Ini membuat proses deployment lebih sederhana dan memungkinkan Anda menggunakan file .env standar untuk konfigurasi.

## Pengaturan Variabel Lingkungan

### 1. Buat file .env.local
Salin `.env.example` ke `.env.local` dan isi dengan nilai sebenarnya Anda:


```bash
cp .env.example .env.local
```

### 2. Variabel Lingkungan yang Dibutuhkan

#### Konfigurasi Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL proyek Supabase Anda
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Kunci anonim Supabase Anda
- `SUPABASE_SERVICE_ROLE_KEY` - Kunci role layanan Supabase Anda (hanya sisi server)

#### Konfigurasi Stripe (opsional)
- `STRIPE_SECRET_KEY` - Kunci rahasia Stripe Anda (hanya sisi server)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Kunci publishable Stripe Anda
- `STRIPE_WEBHOOK_SECRET` - Rahasia webhook Stripe Anda

#### Konfigurasi Situs
- `NEXT_PUBLIC_SITE_URL` - URL situs Anda (untuk produksi)
- `NEXTAUTH_URL` - URL situs Anda (sama seperti di atas)
- `NEXTAUTH_SECRET` - Rahasia acak untuk NextAuth

## Pengembangan Lokal

1. Install dependensi:
```bash
npm install
```

2. Atur variabel lingkungan Anda di `.env.local`

3. Jalankan server pengembangan:
```bash
npm run dev
```

4. Uji webhook Stripe secara lokal menggunakan Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Deploy Produksi


### Deploy Vercel

1. **Deploy ke Vercel:**
```bash
npx vercel
```
2. **Variabel Lingkungan:**
   Tambahkan semua variabel lingkungan melalui dashboard Vercel atau CLI

3. **Pengaturan Stripe Webhook:**
   - Arahkan webhook ke: `https://your-domain.vercel.app/api/stripe/webhook`

## Endpoint API

Aplikasi sekarang menggunakan route API lokal berikut:

- `POST /api/stripe/checkout` - Membuat sesi checkout Stripe
- `POST /api/stripe/webhook` - Menangani event webhook Stripe

## Manfaat Route API Lokal

1. **Deploy Lebih Sederhana** - Tidak perlu deploy edge function terpisah
2. **Variabel Lingkungan** - Dukungan file .env standar
3. **Debugging Lebih Baik** - Lebih mudah debug secara lokal
4. **Integrasi Framework** - Integrasi lebih baik dengan Next.js
5. **Tidak Terkunci Vendor** - Dapat dideploy ke platform mana pun yang mendukung Next.js

## Pemecahan Masalah

1. **Masalah Webhook:**
   - Pastikan `STRIPE_WEBHOOK_SECRET` sesuai dengan endpoint webhook Stripe Anda
   - Periksa log webhook di dashboard Stripe
   - Pastikan URL webhook sudah benar

2. **Variabel Lingkungan:**
   - Pastikan semua variabel yang diperlukan sudah diatur
   - Cek typo pada nama variabel
   - Pastikan Supabase service role key memiliki izin yang benar

3. **Masalah CORS:**
   - Route API sudah menyertakan header CORS yang sesuai
   - Pastikan domain Anda sudah di-whitelist jika diperlukan

## Catatan Keamanan

- Jangan pernah mengekspos `STRIPE_SECRET_KEY` atau `SUPABASE_SERVICE_ROLE_KEY` ke client
- Gunakan prefix `NEXT_PUBLIC_` hanya untuk variabel sisi client
- Rutin lakukan rotasi webhook secrets Anda
- Pantau pengiriman webhook di dashboard Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---