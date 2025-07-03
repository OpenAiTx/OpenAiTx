# Proje Tanıtımı
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Oyun sunucularının dağıtımını, yönetimini ve bakımını basit ve verimli hale getirin**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Doküman Sitesi](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Resmi Web Sitesi](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQ Grubu](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Proje Özeti

GameServerManager (kısa adıyla GSManager), **Docker** teknolojisi tabanlı, oyun sunucularının dağıtımını, yönetimini ve bakımını basitleştirmek için tasarlanmış modern bir oyun sunucusu yönetim platformudur.

### ✨ Temel Özellikler

- 🐳 **Docker Konteynerleştirme** - Tamamen Docker tabanlı çalışır, ortam izolasyonu ve mükemmel uyumluluk
- 🎯 **Tek Tıkla Dağıtım** - Popüler birçok oyunun hızlı dağıtımını destekler
- 🌐 **Web Yönetim Arayüzü** - Modern React tabanlı ön yüz, sezgisel ve kullanımı kolay
- 🔧 **Gerçek Zamanlı Terminal** - Dahili web terminali, anlık komut yürütme desteği
- 📊 **Kaynak İzleme** - Sunucu kaynak kullanımını gerçek zamanlı izleme
- 🔐 **Yetki Yönetimi** - Gelişmiş kullanıcı kimlik doğrulama ve yetki kontrol sistemi
- 🎮 **Çoklu Oyun Desteği** - Steam platformundaki birçok popüler oyun sunucusu desteği
- 💾 **Veri Kalıcılığı** - Oyun verileri ve yapılandırma dosyalarının harici eşlemesi, güvenli ve sağlam

![Konteyner Bilgi Paneli](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Hızlı Başlangıç

### Tek Tıkla Kurulum Scripti

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> debian (docker manuel kurulum) ve centos için lütfen manuel kurulumu kullanın, detaylar için doküman sitesine bakınız

---

## 🎮 Desteklenen Oyunlar

| Oyun Adı | Çince Adı | Steam ID | Anonim İndirme | Durum |
|---------|--------|----------|----------|------|
| **Popüler Oyunlar** | | | | |
| Palworld | Fantastik Canavarlar | 2394010 | ✅ | 🟢 Tam Destek |
| Rust | Pas | 258550 | ✅ | 🟢 Tam Destek |
| Satisfactory | Memnuniyet Fabrikası | 1690800 | ✅ | 🟢 Tam Destek |
| Valheim | Valheim | 896660 | ✅ | 🟢 Tam Destek |
| 7 Days to Die | 7 Gün Hayatta Kal | 294420 | ✅ | 🟢 Tam Destek |
| Project Zomboid | Zombi Yok Etme Projesi | 380870 | ✅ | 🟢 Tam Destek |
| ARK: Survival Evolved | ARK: Hayatta Kalma Evrimi | 376030 | ✅ | 🟢 Tam Destek |
| **Nişancı Oyunları** | | | | |
| Left 4 Dead 2 | Left 4 Dead 2 | 222860 | ❌ | 🟡 Orijinal Gerekli |
| Team Fortress 2 | Takım Kalesi 2 | 232250 | ✅ | 🟢 Tam Destek |
| Squad | Taktik Takım | 403240 | ✅ | 🟢 Tam Destek |
| Insurgency: Sandstorm | İsyan: Çöl Fırtınası | 581330 | ✅ | 🟢 Tam Destek |
| Killing Floor 2 | Katliam Alanı 2 | 232130 | ✅ | 🟢 Tam Destek |
| Insurgency (2014) | İsyan 2 | 237410 | ✅ | 🟢 Tam Destek |
| MORDHAU | MORDHAU | 629800 | ✅ | 🟢 Tam Destek |
| No More Room in Hell | Cehennemde Yer Yok | 317670 | ✅ | 🟢 Tam Destek |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Tam Destek |
| Half-Life | Half-Life | 90 | ✅ | 🟢 Tam Destek |
| Half-Life 2: Deathmatch | Half-Life 2: Deathmatch | 232370 | ✅ | 🟢 Tam Destek |
| Operation: Harsh Doorstop | Operasyon: Sert Kapı | 950900 | ✅ | 🟢 Tam Destek |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Yapılandırma Gerekli |
| **Bağımsız Oyunlar** | | | | |
| Unturned | Dönüşmeyenler | 1110390 | ✅ | 🟢 Tam Destek |
| Don't Starve Together | Açlıktan Ölme Birlikte | 343050 | ✅ | 🟡 Yapılandırma Gerekli |
| Last Oasis | Son Vaha | 920720 | ✅ | 🟢 Tam Destek |
| Hurtworld | Hurtworld | 405100 | ✅ | 🟢 Tam Destek |
| Soulmask | Ruh Maskesi | 3017300 | ✅ | 🟢 Tam Destek |
| **Simülasyon Oyunları** | | | | |
| Euro Truck Simulator 2 | Euro Truck Simulator 2 | 1948160 | ✅ | 🟡 Yapılandırma Gerekli |
| American Truck Simulator | American Truck Simulator | 2239530 | ✅ | 🟡 Yapılandırma Gerekli |
| ECO | Ekolojik Hayatta Kalma | 739590 | ✅ | 🟡 Yapılandırma Gerekli |

> Daha fazla oyun desteği eklenmeye devam ediyor...

---

## 🏗️ Teknik Mimari

### Ön Yüz Teknoloji Yığını
- **React 18** - Modern ön yüz framework'ü
- **Ant Design** - Kurumsal seviye UI bileşen kütüphanesi
- **Monaco Editor** - Kod editörü
- **Xterm.js** - Web terminal simülatörü
- **Vite** - Hızlı derleme aracı

### Arka Uç Teknoloji Yığını
- **Python 3.13** - Ana geliştirme dili
- **Flask** - Web çerçevesi
- **Gunicorn** - WSGI sunucusu
- **Docker** - Konteyner teknolojisi
- **SteamCMD** - Steam komut satırı aracı
- **Aria2** - Çok protokollü indirme yöneticisi

---

## 📁 Proje Yapısı

```
GameServerManager/
├── app/                    # Ön uç uygulaması
│   ├── src/               # React kaynak kodu
│   ├── public/            # Statik kaynaklar
│   └── package.json       # Ön uç bağımlılıkları
├── server/                # Arka uç servisi
│   ├── api_server.py      # Ana API sunucusu
│   ├── game_installer.py  # Oyun yükleyici
│   ├── pty_manager.py     # Terminal yöneticisi
│   ├── auth_middleware.py # Kimlik doğrulama ara katmanı
│   └── installgame.json   # Oyun yapılandırma dosyası
├── docker-compose.yml     # Docker orkestrasyon dosyası
├── Dockerfile            # Docker imajı oluşturma dosyası
└── README.md             # Proje açıklama belgesi
```

---

## 🔧 Yapılandırma Açıklaması

### Port Yapılandırması
- **5000** - Web yönetim arayüzü
- **27015-27020** - Steam oyun sunucusu port aralığı

### Veri Dizini Eşlemesi
- `./game_data` → `/home/steam/games` - Oyun veri dizini
- `./game_file` → `/home/steam/.config` - Oyun yapılandırma dizini
- `./game_file` → `/home/steam/.local` - Oyun kayıt dizini

### Ortam Değişkenleri
- `TZ=Asia/Shanghai` - Zaman dilimi ayarı
- `USE_GUNICORN=true` - Gunicorn'u etkinleştir
- `GUNICORN_TIMEOUT=120` - İstek zaman aşımı süresi
- `GUNICORN_PORT=5000` - Sunucu portu

---

## 🤝 Katkı Rehberi

Her türlü katkıyı memnuniyetle karşılıyoruz!

1. Bu projeyi **fork**'layın
2. Özellik dalınızı oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi gönderin (`git commit -m 'Add some AmazingFeature'`)
4. Dalınıza gönderin (`git push origin feature/AmazingFeature`)
5. Bir **Pull Request** açın

---

## 📞 Destek ve Geri Bildirim

- 🐛 **Sorun Bildirimi**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQ Grup Sohbeti**：1040201322
- 📖 **Detaylı Dokümantasyon**：[Dokümantasyonu Görüntüle](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Açık Kaynak Lisansı

Bu proje [AGPL-3.0 license](LICENSE) açık kaynak lisansı ile lisanslanmıştır.

---

## 👨‍💻 Yazar Hakkında

Bu proje **又菜又爱玩的小朱** tarafından bağımsız olarak geliştirilip sürdürülmektedir.

Eğer bu proje size yardımcı olduysa, lütfen bir ⭐ Star vererek destek olun!

---

## 📈 Proje İstatistikleri

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Oyun sunucusu yönetimini kolay ve eğlenceli hale getiriyoruz!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---