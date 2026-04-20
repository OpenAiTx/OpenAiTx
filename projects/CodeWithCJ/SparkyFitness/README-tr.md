<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Kendi sunucunuzda barındırabileceğiniz, gizliliğe öncelik veren MyFitnessPal alternatifidir. Beslenme, egzersiz, vücut ölçüleri ve sağlık verilerini takip edin ve verilerinizin kontrolü tamamen sizde olsun.

![Ekran Görüntüsü](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness aşağıdakilerden oluşan kendi sunucunuzda barındırılan bir fitness takip platformudur:

- Bir arka uç sunucusu (API + veri depolama)
- Web tabanlı bir ön yüz
- iOS ve Android için yerel mobil uygulamalar

Sağlık verilerini, üçüncü parti hizmetlere bağlı kalmadan, kontrolünüzdeki altyapıda saklar ve yönetir.

## Temel Özellikler

- Beslenme, egzersiz, su tüketimi, uyku, oruç, ruh hali ve vücut ölçümleri takibi
- Hedef belirleme ve günlük kontrol
- Etkileşimli grafikler ve uzun vadeli raporlar
- Çoklu kullanıcı profilleri ve aile erişimi
- Açık ve koyu temalar
- OIDC, TOTP, Passkey, MFA vb.

## Sağlık & Cihaz Entegrasyonları

SparkyFitness, birden fazla sağlık ve fitness platformundan veri senkronize edebilir:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (kısmen test edildi)
- **Hevy** (test edilmedi)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (kısmen test edildi)

Entegrasyonlar, adım, antrenman, uyku gibi aktivite verilerini ve kilo, vücut ölçümleri gibi sağlık metriklerini otomatik olarak SparkyFitness sunucunuza senkronize eder.

## Opsiyonel Yapay Zeka Özellikleri (Beta)

SparkyAI, veri kaydı ve ilerleme incelemesi için sohbet tabanlı bir arayüz sunar.

- Sohbet üzerinden yemek, egzersiz, vücut istatistikleri ve adım kaydı yapın
- Otomatik öğün kaydı için yemek görsellerini yükleyin
- Takipler için konuşma geçmişini saklar

Not: Yapay zeka özellikleri şu anda beta aşamasındadır.

## Hızlı Başlangıç (Sunucu)

Docker Compose kullanarak dakikalar içinde bir SparkyFitness sunucusu çalıştırın.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 Video Eğitim

[![Videoyu izle](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

SparkyFitness’in (kendi barındırılan fitness takipçisi) nasıl kurulacağını gösteren hızlı 2 dakikalık eğitim.


## Dokümantasyon

Tam kurulum kılavuzları, yapılandırma seçenekleri ve geliştirme belgeleri için lütfen [Dokümantasyon Sitemizi](https://codewithcj.github.io/SparkyFitness/) ziyaret edin.

### Hızlı Bağlantılar

- **[Kurulum Kılavuzu](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Dağıtım ve yapılandırmalar
- **[Özellikler Genel Bakış](https://codewithcj.github.io/SparkyFitness/features)** - Tüm özelliklerin belgeleri
- **[Geliştirici İş Akışı](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Geliştirici rehberi ve katkı süreci
- **[iOS Uygulama Bilgisi](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** ve **[Android Uygulama Bilgisi](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Yardıma mı ihtiyacınız var?

- Github issues/discussion bölümünde paylaşın.
- Daha hızlı yanıt almak ve diğer topluluk üyelerinden yardım almak için **[Discord’a Katılın](https://discord.gg/vcnMT5cPEA)**

## Yıldız Geçmişi

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Yıldız Geçmişi Grafiği" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Çeviriler

**[Weblate Çevirileri](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Çeviri durumu" />
</a>

## Depo etkinliği

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats analiz görüntüsü")

## Katkıda Bulunanlar

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Bilinen Sorunlar / Beta Özellikler ⚠️

SparkyFitness aktif olarak geliştirilmektedir.
Sürüm değişiklikleri arasında uyumsuzluklar olabilir.

- Otomatik güncellenen konteynerler önerilmez
- Yükseltmeden önce her zaman sürüm notlarını inceleyin

Aşağıdaki özellikler şu anda beta aşamasındadır ve kapsamlı bir şekilde test edilmemiş olabilir. Potansiyel hatalar veya eksik işlevler bekleyin:

- AI Sohbet Botu
- Aile & Arkadaş erişimi
- API dokümantasyonu


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---