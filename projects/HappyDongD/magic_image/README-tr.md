<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Sihirli AI Resim

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![Lisans](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Next.js tabanlı geliştirilen bir AI resim uygulaması, aşağıdaki ana özelliklere sahiptir:
- 🎨 Birden fazla AI modelini destekler (Sora, DALL-E, GPT vb.) ve özel model ekleme imkanı sunar
- 🖼️ Metinden resim ve resimden resim oluşturma, çoklu görsel referans ve bölgesel düzenleme desteği
- 🔐 Tüm veriler ve API anahtarları yerel olarak saklanır, gizlilik ve güvenlik sağlanır
- 💻 Web sürümü ve masaüstü uygulama paketleme desteği, çapraz platform kullanım

## Çevrimiçi Deneyim

Ziyaret adresi: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Uygulama Ekran Görüntüleri

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Uygulama Ekran Görüntüsü 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Uygulama Ekran Görüntüsü 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Uygulama Ekran Görüntüsü 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Uygulama Ekran Görüntüsü 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Uygulama Ekran Görüntüsü 3" width="800" style="margin-bottom: 20px"/>
</div>

## Özellikler

- 🎨 Birden fazla AI modeli desteği
  - GPT Sora_Image modeli
  - GPT 4o_Image modeli
  - GPT Image 1 modeli
  - DALL-E 3 modeli
  - 🆕 Özel model (kendi özel modelinizi ekleyebilirsiniz)
- ✍️ Metinden resim oluşturma özelliği
  - Özelleştirilebilir komut desteği
  - Görsel oranı seçimi
  - Farklı görsel boyutlarını destekler
- 🖼️ Resimden resim oluşturma özelliği
  - Görsel düzenleme desteği
  - Bölgesel maske düzenleme desteği
  - Görsel kalite ayarlama desteği
  - Çoklu görsel referans (aynı anda birden fazla görsel yükleme)
- 🔒 Veri güvenliği
  - Oluşturulan tüm görseller ve geçmiş yalnızca yerel tarayıcıda saklanır
  - Özelleştirilebilir API proxy adresi desteği
  - API Anahtarı yapılandırması desteği
- 📱 UI tasarımı
  - Modern kullanıcı arayüzü
  - Akıcı etkileşim deneyimi
  - Markdown biçiminde gösterim
  - Kod vurgulama desteği
- 🖥️ Çapraz platform desteği
  - Masaüstü uygulaması olarak paketlenebilir (Windows, macOS, Linux)
  - Çevrimdışı kullanım desteği (API yapılandırması gerektirir)

## Teknoloji Yığını

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (masaüstü uygulama paketleme)

## Yerel Geliştirme

1. Projeyi klonlayın

```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Bağımlılıkların kurulumu

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Geliştirme sunucusunu başlatın

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. 访问 [http://localhost:3000](http://localhost:3000)

## Masaüstü Uygulama Paketleme

Bu proje, masaüstü uygulama paketleme için Tauri kullanır ve Windows, macOS ile Linux sistemlerini destekler.

### Ortam Hazırlığı

Masaüstü uygulamayı paketlemeden önce, aşağıdaki bağımlılıkların kurulması gerekir:

1. **Rust Kurulumu**:
   - [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install) adresini ziyaret edin
   - Yönergeleri izleyerek Rust ve Cargo'yu kurun

2. **Sistem Bağımlılıkları**:
   - **Windows**: [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/) kurun
   - **macOS**: Xcode komut satırı araçlarını kurun (`xcode-select --install`)
   - **Linux**: İlgili bağımlılıkları kurun, detaylar için [Tauri Belgeleri](https://tauri.app/v1/guides/getting-started/prerequisites) sayfasına bakın

### Geliştirme Modu


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Masaüstü Uygulaması Oluşturma


```bash
# 构建桌面应用安装包
npm run desktop
```
Derleme tamamlandığında, ilgili sistemin kurulum paketini `src-tauri/target/release/bundle` dizininde bulabilirsiniz.

## Vercel Dağıtımı

1. Bu projeyi GitHub hesabınıza Fork edin

2. [Vercel](https://vercel.com) üzerinde yeni bir proje oluşturun

3. GitHub depo adresinizi içe aktarın

4. Dağıtıma tıklayın

## Kullanım Talimatları

1. İlk kullanımda API anahtarı yapılandırılması gerekir
   - Sağ üst köşedeki "Anahtar Ayarları"na tıklayın
   - API anahtarını ve temel adresi girin
   - Kaydet'e tıklayın
   - Ayrıca URL parametreleriyle hızlıca yapılandırabilirsiniz:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
    Not: URL içindeki özel karakterler URL kodlamasına tabi tutulmalıdır

2. Üretim modunu seçin
   - Metinden Görsele: Metin açıklamasıyla görsel oluşturma
   - Görselden Görsele: Görsel yükleyerek düzenleme

3. Üretim parametrelerini ayarlayın
   - AI modeli seçin (dahili model veya özel model)
   - Görsel oranını ayarlayın
   - Görsel kalitesini ayarlayın (Görselden Görsele modunda)

4. Özel model yönetimi
   - Model seçim kutusunun yanındaki ayar simgesine tıklayın
   - Yeni model ekleyin: Model adı, model değeri girin ve model tipini seçin
   - Modeli düzenleyin: Mevcut modelin düzenle butonuna tıklayın
   - Modeli silin: Mevcut modelin silme butonuna tıklayın
   - Model seçin: Modelin artı butonuna tıklayarak hemen kullanın

5. Model tipi açıklamaları
   - DALL-E formatı: Görsel üretim arayüzü kullanılır (/v1/images/generations)
   - OpenAI formatı: Sohbet arayüzü kullanılır (/v1/chat/completions)

6. Görsel üretimi
   - Anahtar kelimeleri girin
   - "Görsel Üret" butonuna tıklayın
   - Oluşturma tamamlanana kadar bekleyin

7. Görsel yönetimi
   - Geçmiş kayıtları görüntüleyin
   - Oluşturulan görselleri indirin
   - Mevcut görselleri düzenleyin

## Dikkat Edilmesi Gerekenler

- Tüm oluşturulan görseller ve geçmiş kayıtları yalnızca yerel tarayıcıda saklanır
- Gizli mod kullanımı veya cihaz değişikliği veri kaybına yol açar
- Önemli görselleri zamanında indirip yedekleyin
- API yapılandırması güvenli şekilde tarayıcınızda saklanır, sunucuya yüklenmez
- HTTPS siteleri, HTTP kaynaklarının yüklenmesini tarayıcı engelleyebilir; uygulama HTTP arayüzlerini otomatik olarak HTTPS'ye dönüştürür

## Katkı Rehberi

Projeyi geliştirmek için Issue ve Pull Request göndermeye davetlisiniz.

## Lisans

Bu proje [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0) lisansı ile sunulmaktadır.

Lisans kapsamında şunlara izin verilir:
- ✅ Ticari kullanım: Yazılımı ticari amaçla kullanabilirsiniz
- ✅ Değişiklik: Yazılımın kaynak kodunu değiştirebilirsiniz
- ✅ Dağıtım: Yazılımı dağıtabilirsiniz
- ✅ Kişisel kullanım: Yazılımı kişisel olarak kullanabilirsiniz
- ✅ Patent izni: Bu lisans ayrıca patent izni de sağlar

Ancak şu koşullara uymanız gerekir:
- 📝 Lisans ve telif hakkı bildirimi: Orijinal lisans ve telif hakkı bildirimini eklemelisiniz
- 📝 Değişiklik bildirimi: Orijinal koddaki büyük değişiklikleri belirtmelisiniz
- 📝 Marka bildirimi: Katkıda bulunanların markasını kullanamazsınız

---

## Bana bir kahve ısmarlayın

Bu proje size yardımcı olduysa, bana bir kahve ısmarlayabilirsiniz ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="WeChat ödeme kodu" width="300" />
  <p>Bana bir kahve ısmarlayın</p>
</div>

## İletişim

Herhangi bir sorunuz veya öneriniz varsa, WeChat üzerinden bana ulaşabilirsiniz:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="WeChat iletişim bilgisi" width="300" />
  <p>Karekodu tarayarak WeChat ekleyin</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---