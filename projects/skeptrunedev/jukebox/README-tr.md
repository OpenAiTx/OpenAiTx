<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logosu">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker Çekme" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub yıldızları" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="X (Twitter) üzerinde takip et" />
  </a>
</p>

---
# Herhangi Bir Cihazı Ortak Bir Jukebox’a Dönüştürün

**Jukebox**, arkadaşlarınızla anında paylaşımlı bir müzik çalma listesi oluşturmanızı sağlar—uygulama yok, giriş yok, reklam yok. Sadece bir kutu oluşturun, bağlantı paylaşın ve birlikte şarkı eklemeye başlayın. Partiler, yolculuklar veya herhangi bir grup buluşması için mükemmel!

- 🌐 **Spotify Ortak Çalma Listelerine Açık Kaynak Alternatif**
- 🕵️ **Hesap Gerekmez**: Anonim olarak kullanın—üye olma veya e-posta gerekmez
- ✨ **Bağlantı Paylaşın, Birlikte Şarkı Ekleyin**: Herkes gerçek zamanlı katkıda bulunabilir
- 🚀 **Uygulama İndirmeye Gerek Yok**: Herhangi bir cihazda, doğrudan tarayıcınızda çalışır
- 🎵 **YouTube Entegrasyonu**: Neredeyse her şarkıyı anında arayın ve çalın
- 📱 **Mobil Uyumlu**: Telefon, tablet ve masaüstü için tasarlandı
- ⚖️ **Adil Kuyruk**: Şarkılar otomatik olarak sıralanır, böylece herkes sırası geldiğinde çalar
- 🆓 **%100 Ücretsiz, Reklamsız**

---

## Hemen Deneyin

1. **Bir Jukebox Oluşturun**: Ana sayfayı ziyaret edin ve yeni bir kutu oluşturun
2. **Bağlantıyı Paylaşın**: Davet bağlantısını arkadaşlarınıza gönderin
3. **Şarkı Ekleyin**: YouTube’da arama yapın veya şarkıları manuel olarak ekleyin
4. **Müzik Çalın**: Yerleşik oynatıcıyı kullanarak birlikte dinleyin

---
## Özellikler

- Ortak çalma listeleri: Birlikte şarkı ekleyin, sıraya alın ve çalın
- Anonim kullanım: Giriş veya hesap gerektirmez
- YouTube arama & oynatma: Geniş bir müzik kitaplığına erişim
- Mobil öncelikli, duyarlı arayüz
- Açık kaynak (MIT Lisansı)
- Docker ile kolay kurulum

### Docker Compose Dağıtımları

Tüm servisleri başlatın:

```bash
docker-compose up -d
```

Güncellenen imajlardan sonra servisleri sıfır kesinti ile yeniden dağıtın:

```bash
bash ./redeploy.sh
```
---

## Başlarken

### Gereksinimler

- Node.js 16+
- npm veya yarn
- YouTube Data API v3 anahtarı (Google'dan ücretsiz)

### YouTube API Kurulumu

1. [Google Cloud Console](https://console.cloud.google.com/) adresine gidin
2. Yeni bir proje oluşturun veya mevcut bir projeyi seçin
3. **YouTube Data API v3**'ü etkinleştirin
4. Kimlik bilgileri oluşturun (API Anahtarı)
5. API anahtarınızı kopyalayın

### Kurulum
```bash
# Depoyu klonlayın
git clone <your-repo-url>
cd jukebox

# Sunucu bağımlılıklarını yükleyin
cd server
yarn install

# Ön yüz bağımlılıklarını yükleyin
cd ../frontend
yarn install

# Ortam değişkenlerini yapılandırın
cd ../server
cp .env.example .env
# .env dosyasını düzenleyin ve YouTube API anahtarınızı ekleyin

# Veritabanı migrasyonlarını çalıştırın
```
yarn migrate

# Geliştirme sunucularını başlatın
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (yeni bir terminalde):
cd frontend
yarn dev
```

---

## Lisans

MIT

---
## Katkıda Bulunma & Geri Bildirim

- [GitHub](https://github.com/skeptrunedev/jukebox) üzerinde bir issue ya da pull request açın
- Özellik talepleriniz mi var? [@skeptrune X (Twitter)](https://twitter.com/skeptrune) üzerinden DM atın

---

## Değişiklik Günlüğü

En son güncellemeler ve özellikler için [Değişiklik Günlüğü](https://jukebox.skeptrune.com#changelog) sayfasına bakın.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---