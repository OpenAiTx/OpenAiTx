<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Bir Astro Blog Teması</p>
<p>Sora, “gökyüzü kubbesi” anlamına gelir; sınırsız olasılıkları ve geniş yaratıcılığı simgeler</p>
<p>Bu temayı beğendiyseniz, bir 🌟Star bırakmayı unutmayın!</p>
<p><strong>简体中文</strong> | <a href="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/README.en.md">English</a></p>
</div>

# Önizleme

[My Blog](https://blog.liks.space)

## Kimler Kullanıyor

Kendi sitenizi göstermek için bir [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) gönderebilirsiniz.

# Başlangıç

1. Temayı Yükleyin

   - [pnpm](https://pnpm.io/installation) kurun
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Proje dizinine girin, projeyi başlatmak için `pnpm dev` komutunu çalıştırın

2. Temayı Yapılandırın

   Temayı özelleştirmek için `theme.config.ts` yapılandırma dosyasını düzenleyin. Detaylar için [Yapılandırma](#配置) bölümüne bakınız.

3. Makale Düzenleme

   `src/content/` dizininde düzenleyin, Markdown formatı desteklenir.

4. Web Sitesini Yayınlama

   Web sitesini derlemek için `pnpm build` komutunu çalıştırın, çıktılar `dist/` dizininde bulunur. Yerel önizleme için `pnpm preview` çalıştırabilirsiniz.

   Web sitenizi kendi sunucunuza dağıtın veya [Astro Belgeleri](https://docs.astro.build/en/guides/deploy/) ile Vercel, Netlify, GitHub Pages gibi platformlara dağıtın.

<!-- # 文档 -->

# Yapılandırma

Yapılandırma dosyası `theme.config.ts` olarak bulunur.

## Site Bilgileri

```typescript
site: {
  // Web sitesi adresi
  url: "https://blog.liks.space",
  // Web sitesi başlığı
  title: "Sora",
  // Site sahibi adı
  author: "Liks",
  // Web sitesi açıklaması
  description: "A blog theme built with Astro",
  // Web sitesi simgesi
  // SVG, PNG, ICO formatları desteklenir
  // public/ dizininde bulunan yerel dosya yolu
  favicon: "/images/favicon.ico",
}
```

## Genel Ayarlar

```typescript
global: {
  // Avatar
  // src/images/ dizininde bulunan yerel dosya yolu
  avatar: "avatar.jpg",
  // RSS etkinleştir
  rss: true,
  // Çoklu dil desteği (geliştiriliyor)
  i18n: true,
}
```

## Navigasyon Çubuğu

```typescript
nav: [
  {
    // Sayfa adı
    name: "Arşiv",
    // Sayfa adresi
    url: "/archives",
  },
  {
    name: "Kategoriler",
    url: "/categories",
  },
  {
    name: "Etiketler",
    url: "/tags",
  },
  {
    name: "Hakkında",
    url: "/about",
  },
  ...
];
```

## Altbilgi

```typescript
footer: {
  // Telif hakkı
  copyright: {
    // Kuruluş yılı
    time: "2024 - 2025",
    // Telif hakkı sahibi
    owner: "Liks",
  },
  // Kayıt (Çin'e özel)
  beian: {
    // ICP kaydı
    icp: {
      // Etkinleştir
      enabled: false,
      // Kayıt numarası
      number: "京 ICP 备 12345678 号",
    },
    // Polis kaydı
    police: {
      // Etkinleştir
      enabled: false,
      // Kayıt numarası
      number: "京公网安备 12345678901234 号",
      // Kayıt web adresi
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Ana Sayfa

```typescript
index: {
  // Sosyal Medya
  social: [
    {
      // Ad
      name: "GitHub",
      // Etkinleştir
      enabled: true,
      // Web adresi
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu desteklenmektedir.

## Makale Sayfası

```typescript
post: {
  // Telif hakkı lisansı
  copyright: {
    // CC Lisansı
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Lisans web adresi
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Bağış

```typescript
sponsor: {
  // Etkinleştir
  enabled: true,
  // Alipay QR kodu
  alipay: {
    // Etkinleştir
    enabled: true,
    // src/images/ dizininde bulunan yerel dosya yolu
    image: "alipay.png",
  },
  // WeChat QR kodu
  wechat: {
    enabled: false,
  },
  // Bağışçı listesini göster
  list: true,
}
```

## Yorum

```typescript
comment: {
  // Etkinleştir
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Sunucu adresi
    server: "https://artalk.example.com",
    // Site adı
    site: "Sora",
  },
}
```

## Araçlar

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Etkinleştir
    enabled: false,
    // Sunucu adresi
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Lisans

[GNU Genel Kamu Lisansı v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Teşekkürler

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