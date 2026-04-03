
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">Japonca</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">Korece</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">Hintçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">Tayca</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Fransızca</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Almanca</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">İspanyolca</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">İtalyanca</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Rusça</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Portekizce</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Flemenkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Lehçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">Arapça</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">Farsça</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Vietnamca</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Endonezce</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">Assamca</a>
      </div>
    </div>
  </details>
</div>

# Jimmy'nin Blogu

Next.js 15+ tabanlı, çevrimiçi içerik oluşturmayı ve statik dağıtımı destekleyen sade bir kişisel blog sistemi.

## Teknoloji Yığını

- **Çerçeve**: Next.js 15+ (App Router)
- **Dil**: TypeScript
- **Stil**: Tailwind CSS
- **İkon**: Lucide Icons
- **İçerik**: Markdown + Gray Matter + Remark
- **Kimlik Doğrulama**: GitHub OAuth
- **Dağıtım**: Vercel

## Özellikler

### Okuyucu tarafı

- 📝 Markdown + GFM makale renderı (matematik formülü gösterimi dahil)
- 🏷️ Etiket filtreleme, sayfalama, arşivleme (yıl/etiket bazında)
- 📚 Makale içindekiler navigasyonu (TOC) ve kod bloğu tek tıkla kopyalama
- 📱 Duyarlı tasarım ve koyu/açık tema geçişi
- 🔥 Hover ile yazı takvimi ısı haritası (makale + deneme)
- 📡 RSS abonelik çıkışı (`/rss.xml`)

### Yazarlık tarafı (yönetim paneli)

- 🔐 GitHub OAuth ile giriş (sahip/işbirlikçi yetki doğrulaması)
- ✍️ Makale/deneme çevrimiçi oluşturma, düzenleme, silme
- 🆔 Özelleştirilebilir dosya ID + otomatik çakışma önleme
- 👀 Düzenleme / Önizleme / Bölünmüş ekran üç yazım modu
- 📊 Yazarlık istatistik paneli (toplam, haftalık/aylık üretim, popüler etiketler)

### Teknik taraf

- ⚡ Çoklu sayfa statik çıktı (`force-static`) ile performans ve stabilite artışı
- 🧭 Dahili sitemap ve robots
- 🧩 İçerik okuma önbelleği ve modüler API yapısı

## Proje Yapısı

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
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

### Yöntem 1: Çevrimiçi Yönetim Paneli (Önerilir)

1. `/admin` sayfasını ziyaret edin
2. GitHub OAuth ile giriş yapın
3. Makale bilgilerini doldurun ve gönderin
4. Makale, GitHub API ile otomatik olarak oluşturulur, Vercel otomatik olarak yeniden dağıtır

### Yöntem 2: Dosya Manuel Ekleme

1. `content/posts` dizininde yeni bir Markdown dosyası oluşturun
2. Dosya adlandırma formatı: `xxx.md`
3. Dosyanın başına meta verisi ekleyin:

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
- Yerel geliştirme sırasında, OAuth App'in callback URL'sinin `http://localhost:3000/api/auth/github/callback` olarak ayarlandığından emin olun
- **Üretim ortamında `NEXT_PUBLIC_BASE_URL` mutlaka `https://www.jimmy-blog.top` olarak ayarlanmalı**
- Üretim ortamındaki OAuth App callback URL'i şu şekilde ayarlanmalı: `https://www.jimmy-blog.top/api/auth/github/callback`

## Dağıtım

Proje Vercel dağıtımı ile yapılandırılmıştır, otomatik dağıtımı destekler. Sadece kodu GitHub deposuna gönderin, Vercel otomatik olarak derleyip dağıtacaktır.

### Yönetim paneli kullanmanın avantajları

- ✅ Yerel geliştirme ortamına gerek yok
- ✅ Her yerden ve her zaman makale ekleyebilirsiniz
- ✅ Vercel'in yeniden dağıtımı otomatik tetiklenir
- ✅ Tamamen ücretsiz (GitHub OAuth ve Vercel ücretsiz kotada)
- ✅ Güvenli (GitHub OAuth doğrulaması, yalnızca depo sahibi/işbirlikçiler erişebilir)
- ✅ Şifre yönetimine gerek yok, GitHub hesabınızla giriş yapabilirsiniz
- ✅ Mevcut içerikleri çevrimiçi düzenleme desteği (sadece yeni oluşturma değil)
- ✅ Dosya ID çakışmalarını otomatik işler, üzerine yazma ve manuel yeniden adlandırma gerektirmez
- ✅ Panelde yerleşik üretim istatistikleri, sürekli içerik yönetimi için kolaylık sağlar

## Proje Analizi ve Gelecek Planı

- Proje analiz dokümanı: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Gelecek planı dokümanı: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Katkı

Issue ve Pull Request göndermeye hoş geldiniz!

## Lisans

MIT Lisansı


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---