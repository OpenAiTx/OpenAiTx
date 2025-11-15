
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Ön Sürüm](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Lisans: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Desteklenen Derleyiciler](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![Birim Testleri](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - Uçuş Kayıtlarınız için Kara Koyun.

## Hakkında
Sky Dolly, çalışan bir Flight Simulator 2020 oturumuna bağlanır ve çeşitli simülasyon değişkenlerini kaydeder, tekrar oynatmak için.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

Bağlantı, Flight Simulator X ile tanıtılan standart bir API olan SimConnect üzerinden yapılır ve uçuş simülatörü ile bağlantı sağlar.

Ayrıca [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md) dosyasına bakınız.

## Özellikler
- Kayıt / Duraklat / Oynat
- Formasyon uçuşları (birden fazla uçak, kayıt sırasında tekrar oynatma, "formasyonla uç", zaman farkı)
- Ayarlanabilir kayıt örnekleme hızı: sabit ya da değişken ("otomatik")
- Ayarlanabilir tekrar oynatma hızı ("yavaş hareket", "zaman atlamalı"), tekrar döngüsü
- Konum, hız ve temel uçuş kontrol simülasyon değişkenleri (ailerons, rudder, flaps, gears, ...) kaydedilir
- Çeşitli içe/dışa aktarma eklentileriyle eklenti mimarisi (CSV, GPX, IGC, KML)
- 100'den fazla varsayılan konum ve içe/dışa aktarma işlevine sahip konum modülü
- Veritabanı (SQLite) tabanlı kalıcılık ("uçuş günlüğü")

(Yayın önizlemesi) tanıtım videosunu [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I) üzerinden izleyin:

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Sky Dolly ile oluşturulmuş daha fazla video için [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md) sayfasına da bakabilirsiniz. Yeni ve gelecek özellikler için [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md) dosyasına göz atın.

## Temel Kullanım

- Bir uçuş başlatın
- "Kaydet"e tıklayın (R tuşu)
- Kaydı duraklatabilirsiniz (P tuşu)
- Kaydı durdurun (R tuşu) ve "Oynat"a tıklayın (boşluk tuşu)
- Tekrar oynatma hızını ayarlayın ve oynatma konumunu seçin, tekrar oynatma sırasında da
- Kaydedilen uçuşlar otomatik olarak "uçuş günlüğü"nde saklanır
- Günlükte bir uçuş seçin ve "Yükle"ye basın (veya satıra çift tıklayın) ve kaydedilen uçuşu yükleyin

### Formasyon Kaydı & Tekrar Oynatma

#### Kayıt

- "Formation" modülüne geçin (F2 tuşu)
- "Kayıt" düğmesine tıklayın (R tuşu)
- Her kaydedilen uçak mevcut uçuşa eklenir
- "Otomatik" örnekleme oranı ile kayıtta mevcut uçaklar tekrar oynatılırken, kayıt örnekleme oranını değiştirebilirsiniz

#### Pozisyon

- Son kaydedilen uçak "kullanıcı uçağı" olur (uçuş simülatöründe kamera tarafından takip edilir)
- Kayıttan önce mevcut "kullanıcı uçağına" göre bir pozisyon seçin

#### Tekrar Oynatma

- Tek bir uçak uçuşunda olduğu gibi, sadece "Oynat", "Duraklat" düğmesine tıklayın ve zaman çizelgesinde gezin
- "Kullanıcı uçağını" değiştirin (tekrar oynatma sırasında da) ve "kokpitten kokpite atlayın"
- "Kullanıcı uçağının" kontrolünü "Kontrolü al" veya "Formation ile uç" seçeneğini seçerek ele alın

#### Formasyonları Yönetme

- Bir uçuştan ("formasyon") tek bir uçağı silebilirsiniz
- Her uçuşta en az bir uçak olmalıdır, bu nedenle son uçak silinemez
- Seçilen uçağa zaman farkı ekleyin ("çok oyunculu formasyon uçuşu senkronizasyonu")
- Yeni, tek uçaklı bir uçuş başlatmak için tekrar "Logbook" modülüne geçin (F1 tuşu) ve "Kayıt" düğmesine tıklayın (R tuşu)

Neden bunu rehberli ["Tell Tours"](https://github.com/till213/Tell-Tours) ile denemiyorsunuz? :)

## İndirme

[Releases](https://github.com/till213/SkyDolly/releases) sayfasına gidin ve en son sürümü indirin.

En son (ön-)sürüm: **Sky Dolly 0.19.2**

İndirilen kopyanızın bütünlüğünü doğrulamak için SHA-256 kontrol toplamınızı [yayınlanan SHA-256 kontrol toplamları](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md) ile karşılaştırın.

## Derleme

[BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md) dokümantasyonuna bakınız.

## İlgili Projeler

- https://github.com/nguyenquyhy/Flight-Recorder - .Net tabanlı bir uçuş kaydı ve tekrar oynatma uygulaması
- https://github.com/saltysimulations/saltyreplay/ - Web kullanıcı arayüzüne sahip bir kayıt ve tekrar oynatma uygulaması
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Uçuşu kaydeder ve Google Earth (KML formatında) "tekrarlar" oluşturur
- https://github.com/Elephant42/FS_Tool - Uçak konumunu ve simülasyon hızını ayarlamaya olanak tanıyan basit bir araç
- https://github.com/pyviator/msfs-geoshot - Ekran görüntüleri alır ve bunları otomatik olarak "coğrafi etiketler"
- https://github.com/ijl20/msfs_logger_replay - IGC kaydedici ve tekrar oynatma (FSX için)
- https://joinfs.net/ - Farklı uçuş simülatörlerinde (MSFS, Prepar3D/FSX, XPlane) çok oyunculu uçuşları senkronize etmeyi sağlar. Ayrıca formasyon uçuşu kaydı ("overdub") ile bir uçuş kaydedici sunar.
- https://github.com/paulalexandrow/a32nx-webremote - FlyByWire'ın A32NX'i için WebRemote: FBW A320 kokpit işlevselliğini FSUIPC7 kullanarak kontrol edin
- https://flightloganalyzer.com/ - FlightLog Analyzer, MSFS günlüğünü analiz eder ve Sky Dolly tarafından okunabilir CSV dışa aktarma sunar
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave uçuş planlarını otomatik olarak (veya isteğe bağlı olarak) kaydeder
- https://github.com/mracko/MSFS-Landing-Inspector - İniş performansınızı analiz eder
- [İlgi Noktaları (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Microsoft Flight Simulator'daki İlgi Noktaları, Havaalanlar ve 3D şehirler.

## Diğer Faydalı Kaynaklar

- https://obsproject.com/ - Ekran kaydı / yayın uygulaması
- https://sqlitebrowser.org/ - Sky Dolly günlük defteri (*.sdlog) veritabanı dosyalarını inceleyin, kendi SQL sorgularınızı çalıştırın


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---