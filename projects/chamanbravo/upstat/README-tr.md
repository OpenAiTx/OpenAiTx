
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> basit ve kullanımı kolay, kendin barındırabileceğin durum izleme aracı

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Canlı Demo

Deneyin.

Demo Sunucusu (Konum: Singapur): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Kullanıcı Adı: `demo`
Şifre: `demodemo`

## ⭐ Özellikler

Daha fazla özelliğe ihtiyacı var ama şimdilik...

- HTTP(s) için çalışma süresi izleme
- Durum ve Gecikme Grafiği
- Discord üzerinden bildirimler
- 60 saniyelik aralıklar
- Şık, Tepkisel, Hızlı UI/UX
- Birden fazla durum sayfası
- Durum sayfalarını belirli alan adlarına eşleştirin
- Ping grafiği
- Sertifika bilgisi
- PWA
- Sqlite & Postgres veritabanı desteği

Ve eklenecek onlarca küçük özellik.

## 🔧 Nasıl Kurulur

### 🐳 Docker

Sqlite için

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Postgres için

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat artık http://localhost:3000 adresinde çalışıyor

> [!ÖNEMLİ]
> Dağıtımdan önce ortam değerlerini değiştirdiğinizden emin olun.

### 💪🏻 Docker Olmadan

Gereksinimler:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (İsteğe bağlı)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Teknoloji yığını

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Katkıda Bulunanlar

Katkılarınızı memnuniyetle karşılıyorum! Katkılar, açık kaynak topluluğunu öğrenmek, ilham almak ve yaratmak için harika bir yer yapan şeydir. Yaptığınız herhangi bir katkı **çok takdir edilecektir**.

Daha iyi olmasını sağlayacak bir öneriniz varsa, lütfen repoyu çatallayın, değişiklikleri yapın ve bir pull request oluşturun. Ayrıca "enhancement" etiketiyle bir issue açabilirsiniz.
Projeye yıldız vermeyi unutmayın! Tekrar teşekkürler!

1. Projeyi Çatalla (Fork)
2. Özellik Dalını Oluştur (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerini Commit Et (`git commit -m 'Add some AmazingFeature'`)
4. Dalına Gönder (`git push origin feature/AmazingFeature`)
5. Bir Pull Request Aç

## Katkıda Bulunanlar

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Lisans

Bu proje [MIT Lisansı](https://opensource.org/license/mit/) altında lisanslanmıştır.

## 🖼 Daha Fazla Ekran Görüntüsü

Bir İzleyici Oluştur

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

İzleyici Sayfası

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---