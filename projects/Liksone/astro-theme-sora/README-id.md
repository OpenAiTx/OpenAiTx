<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Sebuah tema blog Astro</p>
<p>Sora berarti "langit", melambangkan kemungkinan tak terbatas dan kreativitas yang luas</p>
<p>Jika Anda menyukai tema ini, silakan berikan 🌟Star!</p>
<p><strong>Simplified Chinese</strong> | <a href="/README.en.md">English</a></p>
</div>

# Pratinjau

[Blog Saya](https://blog.liks.space)

## Siapa yang Menggunakan

Silakan ajukan sebuah [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) untuk memamerkan situs Anda.

# Mulai

1. Instal Tema

   - Instal [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Masuk ke direktori proyek, jalankan `pnpm dev` untuk memulai proyek

2. Konfigurasi Tema

   Ubah file konfigurasi `theme.config.ts` untuk menyesuaikan tema. Lihat [Konfigurasi](#配置) untuk detail.

3. Edit Artikel

   Edit di direktori `src/content/`, mendukung format Markdown.

4. Deploy Website

   Jalankan `pnpm build` untuk membangun situs, hasil build ada di direktori `dist/`. Anda dapat menjalankan `pnpm preview` untuk melihat pratinjau situs secara lokal.

   Deploy situs Anda sendiri ke server, atau lihat [Dokumentasi Astro](https://docs.astro.build/en/guides/deploy/) untuk deploy ke Vercel, Netlify, GitHub Pages, dan platform hosting lainnya.

<!-- # 文档 -->

# Konfigurasi

File konfigurasi adalah `theme.config.ts`.

## Informasi Situs

```typescript
site: {
  // Alamat website
  url: "https://blog.liks.space",
  // Judul website
  title: "Sora",
  // Nama pemilik
  author: "Liks",
  // Deskripsi website
  description: "A blog theme built with Astro",
  // Ikon website
  // Mendukung format SVG, PNG, ICO
  // Path file lokal di dalam direktori public/
  favicon: "/images/favicon.ico",
}
```

## Pengaturan Global

```typescript
global: {
  // Avatar
  // Path file lokal di dalam direktori src/images/
  avatar: "avatar.jpg",
  // Aktifkan RSS
  rss: true,
  // Aktifkan dukungan multi-bahasa (dalam pengembangan)
  i18n: true,
}
```

## Navigasi

```typescript
nav: [
  {
    // Nama halaman
    name: "Arsip",
    // Alamat halaman
    url: "/archives",
  },
  {
    name: "Kategori",
    url: "/categories",
  },
  {
    name: "Tag",
    url: "/tags",
  },
  {
    name: "Tentang",
    url: "/about",
  },
  ...
];
```

## Footer

```typescript
footer: {
  // Hak cipta
  copyright: {
    // Tahun pembuatan
    time: "2024 - 2025",
    // Pemilik hak cipta
    owner: "Liks",
  },
  // Registrasi (Khusus Tiongkok)
  beian: {
    // Registrasi ICP
    icp: {
      // Aktifkan
      enabled: false,
      // Nomor registrasi
      number: "京 ICP 备 12345678 号",
    },
    // Registrasi Polisi
    police: {
      // Aktifkan
      enabled: false,
      // Nomor registrasi
      number: "京公网安备 12345678901234 号",
      // Alamat situs registrasi
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Beranda

```typescript
index: {
  // Media sosial
  social: [
    {
      // Nama
      name: "GitHub",
      // Aktifkan
      enabled: true,
      // Alamat
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Mendukung BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, XiaoHongShu, Zhihu.

## Halaman Artikel

```typescript
post: {
  // Lisensi Hak Cipta
  copyright: {
    // Lisensi CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Alamat lisensi
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Donasi

```typescript
sponsor: {
  // Aktifkan
  enabled: true,
  // QR Code Alipay
  alipay: {
    // Aktifkan
    enabled: true,
    // Path file lokal di dalam direktori src/images/
    image: "alipay.png",
  },
  // QR Code WeChat
  wechat: {
    enabled: false,
  },
  // Tampilkan daftar donatur
  list: true,
}
```

## Komentar

```typescript
comment: {
  // Aktifkan
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Alamat server backend
    server: "https://artalk.example.com",
    // Nama situs
    site: "Sora",
  },
}
```

## Alat

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Aktifkan
    enabled: false,
    // Alamat server
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Lisensi

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Ucapan Terima Kasih

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---