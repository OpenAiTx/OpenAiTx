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

# Alternatif Trello open-source yang ringan, dirancang untuk pembuat dan indie hacker.

Fokus pada kesederhanaan, kecepatan, dan skalabilitas.
Dibangun dengan stack modern: Tailwind CSS, shadcn/ui, Supabase, integrasi Stripe.
Mendukung proyek tanpa batas, kolaborasi tim, mode gelap/terang, dan pengalaman pengguna yang mulus.
Sempurna untuk developer solo dan tim kecil yang ingin kontrol penuh tanpa kompleksitas yang tidak perlu.

## 🌟 Jika Anda merasa proyek ini bermanfaat, pertimbangkan untuk memberinya bintang! Ini membantu orang lain menemukannya juga.

# Panduan Deployment

## Ikhtisar
Aplikasi ini sekarang menggunakan route API Next.js lokal, bukan Supabase Edge Functions untuk integrasi Stripe. Ini membuat proses deployment lebih sederhana dan memungkinkan Anda menggunakan file .env standar untuk konfigurasi.

## Pengaturan Variabel Lingkungan

### 1. Buat file .env.local
Salin `.env.example` ke `.env.local` dan isi dengan nilai asli Anda:


```bash
cp .env.example .env.local
```
### 2. Variabel Lingkungan yang Diperlukan

#### Konfigurasi Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL proyek Supabase Anda
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Kunci anonim Supabase Anda
- `SUPABASE_SERVICE_ROLE_KEY` - Kunci peran layanan Supabase Anda (hanya sisi server)

#### Konfigurasi Stripe (opsional)
- `STRIPE_SECRET_KEY` - Kunci rahasia Stripe Anda (hanya sisi server)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Kunci publishable Stripe Anda
- `STRIPE_WEBHOOK_SECRET` - Rahasia webhook Stripe Anda

#### Konfigurasi Situs
- `NEXT_PUBLIC_SITE_URL` - URL situs Anda (untuk produksi)
- `NEXTAUTH_URL` - URL situs Anda (sama seperti di atas)
- `NEXTAUTH_SECRET` - Rahasia acak untuk NextAuth

## Pengembangan Lokal

1. Instal dependensi:

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
## Deployment Produksi


### Deployment Vercel

1. **Deploy ke Vercel:**

```bash
npx vercel
```
2. **Variabel Lingkungan:**
   Tambahkan semua variabel lingkungan melalui dashboard Vercel atau CLI

3. **Pengaturan Webhook Stripe:**
   - Arahkan webhook ke: `https://your-domain.vercel.app/api/stripe/webhook`

## Endpoint API

Aplikasi sekarang menggunakan rute API lokal berikut:

- `POST /api/stripe/checkout` - Membuat sesi checkout Stripe
- `POST /api/stripe/webhook` - Menangani event webhook Stripe

## Manfaat Rute API Lokal

1. **Deploy Lebih Sederhana** - Tidak perlu deploy fungsi edge terpisah
2. **Variabel Lingkungan** - Dukungan file .env standar
3. **Debugging Lebih Baik** - Lebih mudah untuk debug secara lokal
4. **Integrasi Framework** - Integrasi lebih baik dengan Next.js
5. **Tidak Terkunci Vendor** - Dapat deploy ke platform mana pun yang mendukung Next.js

## Pemecahan Masalah

1. **Masalah Webhook:**
   - Pastikan `STRIPE_WEBHOOK_SECRET` sesuai dengan endpoint webhook Stripe Anda
   - Periksa log webhook di dashboard Stripe
   - Verifikasi URL webhook sudah benar

2. **Variabel Lingkungan:**
   - Pastikan semua variabel yang dibutuhkan sudah diatur
   - Periksa kesalahan penulisan pada nama variabel
   - Verifikasi kunci peran layanan Supabase memiliki izin yang sesuai

3. **Masalah CORS:**
   - Rute API sudah menyertakan header CORS yang tepat
   - Pastikan domain Anda sudah di-whitelist jika diperlukan

## Catatan Keamanan

- Jangan pernah mengekspos `STRIPE_SECRET_KEY` atau `SUPABASE_SERVICE_ROLE_KEY` ke klien
- Gunakan awalan `NEXT_PUBLIC_` hanya untuk variabel sisi klien
- Rutin rotasi rahasia webhook Anda
- Pantau pengiriman webhook di dashboard Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---