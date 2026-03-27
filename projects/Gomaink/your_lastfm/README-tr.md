
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Durum](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Lisans](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

**Last.fm**'den scrobbleri senkronize eden, yerel bir **SQLite** veritabanında depolayan ve bir web panosu sunan kapsüllenmiş bir Node.js uygulaması.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Proje

**Your LastFM**, Last.fm'den **müzik scrobble'larını otomatik olarak senkronize eden** bir Node.js uygulamasıdır. Dinleme geçmişinizi yerel bir SQLite veritabanında saklar ve veri görselleştirmesi için bir web arayüzü sunar.

Proje tamamen **Docker** ile konteynerleştirilmiştir, veritabanı başlatma ve ardışık çalıştırma işlemlerini (Önce Senkronizasyon, ardından Web API'nin başlatılması) yöneten otomatik bir giriş noktası kullanır. Ayrıca, web servisinin aktif ve dayanıklı kalmasını sağlamak için konteyner içinde işlem yöneticisi olarak **PM2** kullanır.

## Özellikler
### Etkileşimli Web Paneli

- Müzik aktivitenizi görselleştirmek için temiz, modern bir web arayüzü.

### Otomatik Last.fm Scrobble Senkronizasyonu

- Last.fm'den dinleme geçmişinizi (scrobbles) periyodik olarak alır ve saklar.
- Verilerinizin her zaman güncel kalmasını sağlar, manuel müdahale gerektirmez.

### Yerel Müzik Geçmişi Veritabanı

- Tüm scrobble'ları yerel bir SQLite veritabanında saklar.
- Hızlı sorgular ve geçmiş dinleme verilerine çevrimdışı erişim sağlar.

### Son Scrobble'lar Görünümü

- En son dinlediğiniz parçaları gösterir.
- Parçalar, albümler ve sanatçılar için akıllı görsel yedekleme mantığı.

### Arkadaş Karşılaştırması (Uyumluluk Görünümü)

- Müzik zevkinizi Last.fm arkadaşlarınızla karşılaştırın.
- Uyumluluk seviyesini gösterir (Çok Düşük → Süper).
- Ortak en iyi sanatçıları, albümleri ve parçaları gösterir.
- Gerçek dinleme verilerine dayalı olarak uyumluluğu hesaplar ve normalize eder.

### Paylaşılabilir Müzik Kartları

- Dinleme verilerinize dayalı dinamik görseller oluşturur.
- Akış gönderileri ve instagram hikayeleri (9:16) için optimize edilmiş düzenler.

- Sunucu tarafı görsel işleme için node-canvas kullanılarak oluşturulmuştur.

## Ön Gereksinimler

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Kurulum

### Bir `.env` dosyası oluşturun

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: API Anahtarınızı almak için bir API hesabı oluşturun [burada](https://www.last.fm/api/account/create).

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

Terminalde:
`docker compose up -d`

Sonra erişin:
```
http://localhost:1533
```

(veya `localhost` yerine sunucu IP'nizi kullanın)

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---