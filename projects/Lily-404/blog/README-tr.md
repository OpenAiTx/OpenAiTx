
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Jimmy'nin Blogu

Next.js 15+ tabanlı, sade bir kişisel blog sistemi.

## Teknoloji Yığını

- **Çerçeve**: Next.js 13+ (App Router)
- **Stil**: Tailwind CSS
- **İkonlar**: Lucide Icons
- **Tema**: Koyu/Açık mod desteği
- **Dağıtım**: Vercel

## Özellikler

- 📝 Markdown makale desteği
- 🌓 Koyu/Açık tema geçişi
- 📱 Duyarlı tasarım
- ⚡ Hızlı yükleme
- 📅 Makale zaman çizelgesi gösterimi
- 🔐 Çevrimiçi yönetim paneli (GitHub API ile doğrudan makale oluşturma)

## Proje Yapısı

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Kurulum ve Çalıştırma

1. Projeyi klonlayın

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Bağımlılıkları yükleyin

```bash
npm install
```

3. Geliştirme sunucusunu çalıştırın

```bash
npm run dev
```

4. Üretim sürümünü derleyin

```bash
npm run build
```

## Yeni Makale Ekleme

### Yöntem 1: Çevrimiçi Yönetim Paneli (Tavsiye Edilir)

1. `/admin` sayfasını ziyaret edin
2. Yönetici şifresiyle giriş yapın
3. Makale bilgilerini doldurun ve gönderin
4. Makale GitHub API aracılığıyla otomatik olarak oluşturulur, Vercel otomatik olarak yeniden dağıtım yapar

### Yöntem 2: Dosya Manuel Ekleme

1. `content/posts` dizininde yeni bir Markdown dosyası oluşturun
2. Dosya adlandırma formatı: xxx.md`
3. Dosyanın başına meta veri ekleyin:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Günlük Ekleme

1. `content/notes` dizininde yeni bir Markdown dosyası oluşturun
2. Dosya adlandırma formatı: `YYYY-MM-DD-title.md`
3. Dosyanın başına meta verileri ekleyin:

```markdown
---
date: YYYY-MM-DD
---
```

## Yönetim Paneli Yapılandırması

Yönetim paneli kimlik doğrulama için GitHub OAuth kullanır, sadece depo sahibi veya işbirlikçileri erişebilir.

### 1. GitHub OAuth Uygulaması Oluşturma

1. [GitHub Ayarları > Geliştirici ayarları > OAuth Uygulamaları](https://github.com/settings/developers) adresini ziyaret edin
2. "New OAuth App" butonuna tıklayın
3. Bilgileri doldurun:
   - **Uygulama adı**: `Jimmy Blog Admin` (veya herhangi bir isim)
   - **Ana sayfa URL'si**: `https://alanadiniz.com` (canlı ortam) veya `http://localhost:3000` (yerel geliştirme)
   - **Yetkilendirme geri dönüş URL'si**: 
     - Canlı ortam: `https://alanadiniz.com/api/auth/github/callback`
     - Yerel geliştirme: `http://localhost:3000/api/auth/github/callback`
4. "Register application" butonuna tıklayın
5. **Client ID** değerini kaydedin
6. "Generate a new client secret" butonuna tıklayın ve **Client secret** değerini kaydedin

### 2. Ortam Değişkenlerini Yapılandırma

Vercel proje ayarlarında aşağıdaki ortam değişkenlerini ekleyin:

- `GITHUB_CLIENT_ID`: GitHub OAuth App Client ID'niz
- `GITHUB_CLIENT_SECRET`: GitHub OAuth App Client Secret'ınız
- `GITHUB_OWNER`: GitHub kullanıcı adınız (varsayılan: `Lily-404`, kullanıcı yetkisi doğrulama için kullanılır)
- `GITHUB_REPO`: Depo adı (varsayılan: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth geri dönüş URL'si (isteğe bağlı, varsayılan olarak otomatik oluşturulur)
- `NEXT_PUBLIC_BASE_URL`: Sitenizin URL'si (geri dönüş URL'si oluşturmak için kullanılır, canlı ortamda mutlaka ayarlanmalı)
  - Canlı ortam: `https://www.jimmy-blog.top`
  - Yerel geliştirme: `http://localhost:3000`

### 3. Yerel Geliştirme Yapılandırması

Proje kök dizininde `.env.local` dosyası oluşturun:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Üretim Ortamı Yapılandırması (Vercel)

Vercel proje ayarlarında, aşağıdakilerin yapılandırıldığından emin olun:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Dikkat**: 
- `.env.local` dosyası `.gitignore`'a eklendi, Git'e gönderilmeyecek
- Yerel geliştirme sırasında, OAuth Uygulamasının callback URL'sinin `http://localhost:3000/api/auth/github/callback` olarak ayarlandığından emin olun
- **Üretim ortamında `NEXT_PUBLIC_BASE_URL` mutlaka `https://www.jimmy-blog.top` olarak ayarlanmalıdır**
- Üretim ortamında OAuth Uygulamasının callback URL'si şöyle ayarlanmalıdır: `https://www.jimmy-blog.top/api/auth/github/callback`

## Dağıtım

Proje Vercel dağıtımı için yapılandırılmıştır ve otomatik dağıtımı destekler. Kodu GitHub deposuna göndermeniz yeterli, Vercel otomatik olarak oluşturup dağıtacaktır.

### Yönetim paneli kullanmanın avantajları

- ✅ Yerel geliştirme ortamına gerek yok
- ✅ Her zaman, her yerde makale ekleyebilirsiniz
- ✅ Vercel yeniden dağıtımı otomatik olarak tetiklenir
- ✅ Tamamen ücretsiz (GitHub OAuth ve Vercel ücretsiz kontenjan dahilinde)
- ✅ Güvenli (GitHub OAuth doğrulaması, yalnızca depo sahibi/işbirlikçi erişebilir)
- ✅ Şifre yönetimine gerek yok, GitHub hesabıyla giriş yapılabilir

## Katkı

Issue ve Pull Request göndermekten memnuniyet duyarız!

## Lisans

MIT Lisansı


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---