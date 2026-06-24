
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Google Nest Mini için MiciMike drop-in PCB değiştirme kartı

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb), ["Google Nest Mini" (Google’ın ikinci nesil, varil tip şarj bağlantı portuna sahip akıllı hoparlörü)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) için ESP32 ve XMOS mikrodenetleyicileri tabanlı, açık kaynaklı yazılım çalıştırabilen drop-in PCB değiştirme kartıdır.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

İpucu! Eğer "Google Home Mini" (Google’ın ilk nesil, Micro-USB şarj portuna sahip akıllı hoparlör donanımı) için benzer bir drop-in PCB değiştirme kartı arıyorsanız, kardeş projeye https://github.com/iMike78/home-mini-v1-drop-in-pcb adresinden göz atabilirsiniz.

**Dikkat!** Şu anda "MiciMike Home Mini Drop-In PCB" (1. nesil Google Home Mini) için bir kitlesel fonlama kampanyası Crowd Supply'da ön satış aşamasında (proje ön-izleme yalnızca) canlı olarak devam ediyor, ve eğer bu başarılı olursa, daha yeni Nest Mini (2. nesil) için de benzer bir kampanya planlanacak, bu yüzden buradan göz atın ve mümkünse destekleyerek bu projeye dolaylı olarak katkıda bulunun:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Her iki proje de tamamen açık kaynak donanım projeleri olup, bazı kavramsal ilhamı [Onju Voice](https://github.com/justLV/onju-voice) projesinden alıyor ancak [Open Home Foundation'ın açık sesli asistanlar standardını Home Assistant Voice Preview Edition referans alınarak](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) PCB tasarımları ve spesifikasyonları için takip etmeyi hedefliyor.

# Proje kapsamı

Bu projenin ve deposunun amacı (ki [Onju Voice](https://github.com/justLV/onju-voice) ile benzer fakat tamamen açık kaynak donanım lisansı altında) herkesin yapabileceği/üretebileceği veya özel bir drop-in yedek PCB olarak tek bir PCB üreticisinden sipariş edebileceği bir drop-in yedek PCB (Baskılı Devre Kartı) ve donanım şemaları tasarlamaktır; bu Google Nest Mini (2. Nesil) için özelleştirilecektir.

Bu, öncelikle eski Google Nest Mini akıllı hoparlörlerini [Home Assistant için Sesli Kontrol](https://www.home-assistant.io/voice_control/) ve/veya [Music Assistant](https://www.music-assistant.io) için medya oynatıcı hoparlör çıkışı olarak açık kaynak donanıma dönüştürmek/yeniden amaçlandırmak isteyenlere yöneliktir, (donanım muhtemelen başka uygulamalar ve farklı firmware ile de kullanılabilir çünkü popüler Espressif ESP32 platformu üzerine kuruludur).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="İlk test PCB">

Donanım tasarımı ( [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) gibi) WiFi, BLE ve [yerleşik uyandırma kelimesi algılama](https://www.home-assistant.io/voice_control/about_wake_word/) için bir ESP32-S3 SoC entegre edecek (kod gerektirmeyen [ESPHome firmware](https://esphome.io/)) + gelişmiş ses işleme için bir XMOS xCORE XU316 çip (mikrofon temizleme için özel firmware ile daha iyi ses tanıma yetenekleri için lokal olarak çalışan algoritmalar ile Gürültü Bastırma, Akustik Yankı İptali, Parazit İptali ve Otomatik Kazanç Kontrolü).

Fonksiyonellik açısından, donanım çoğunlukla [Home Assistant Voice Preview Edition (yani Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) referans tasarımı ile donanım uyumlu olarak yapılmıştır (bu tasarım Open Home Foundation tarafından Nabu Casa ile işbirliği içinde açık kaynak donanım olarak yayınlanmıştır). Ana fark, Google Nest Mini muhafazası ve bileşenlerinin tanımladığı kısıtlamalardan dolayı olacaktır, (yani nest-mini-drop-in-pcb projesi donanım tasarımı, Google'ın orijinal donanımıyla aynı tür fiziksel kapasite girişleri ile sınırlı olacaktır).

Bu nedenle, bu proje/deponun kapsamı ESPHome firmware için yeni özellikler/fonksiyonlar geliştirmek değildir, eğer bunu istiyorsanız, Home Assistant Voice Preview Edition firmware geliştirmesine ve üst akış ESPHome ana koduna yönelmeniz gerekir:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## İşbirliği çağrısı

PCB yerleşim tasarımı konusunda biraz deneyiminiz varsa, (özellikle PCB yönlendirme, toprak dökme veya gürültüye duyarlı dijital+analog yerleşimler konusunda), **yardımınız çok değerli**! Lütfen yeni bir konu açmaktan, öneri/istek göndermekten, mevcut konulara katkı/geri bildirim eklemekten veya bu depoyu çatallamaktan çekinmeyin.

Konsept/fikir hakkında daha fazla bilgi için ilgili tartışmaya katkıda bulunmak ve görmek için Home Assistant topluluk forumu başlığını inceleyin:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Güncel durum

- ✅ Şema tamamlandı
- ✅ Bileşen yerleşimi yapıldı
- ✅ Yönlendirme tamamlandı
- ✅ Toprak dökümü, koruma stratejisi ve EMI değerlendirmeleri tamamlandı
- ⛔ 1. test partisi iki hata nedeniyle başarısız oldu - düzeltildi
- ⚠️ 2. test partisi kısmen çalışıyor
- ✅ XTAG4 hata ayıklama seçeneği bir sonraki partiye eklendi

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Kullanılan Araçlar

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC ayak izi temini için

## Bilinen donanım özellikleri

- 4 katmanlı PCB
- ESP32-S3R8 çıplak çip (WiFi, BLE ve dahili uyandırma-kelime algılama için ESP32-S3)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP ses işleme)
- 16 MB SPI flaş (ESP32-S3)
- 4 MB SPI flaş (XMOS XU316)
- Çift I²S veri yolu (eşzamanlı ses girişi ve çıkışı)
- TAS5805M (TAS5805MPWPR) entegre DSP’li stereo Class-D amplifikatör (I2S ses, I2C kontrol), mono BTL hoparlör çıkışı için yapılandırılmıştır
- 3x MEMS mikrofon (MMICT390200012) 34 mm yarıçaplı bir yay üzerinde dizilmiş - mevcut firmware 2 mikrofon kullanıyor, donanımda 3 mikrofonlu dizi desteği mevcut
- 6x SK6812 RGB LED
- Özel USB-C ve 14V güç girişi (Not! USB-C ve yuvarlak konnektör aynı anda bağlanamaz)
- MPR121 kapasitif dokunmatik kontrolcü (ESP32-S3'ün yerel dokunmatik algılaması yerine kullanılır)

---

> ⚠️ USB-C üzerinden flaşlama, ana 14V güç girişinin bağlantısının kesilmesini gerektirir. Ayrıntılar için PCB üzerindeki serigrafi notunu inceleyin.

## Referanslar

### Home Assistant Voice Preview Edition kaynakları, PCB tasarım dosyaları dahil
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE için ESPHome firmware (aynı ESP32-S3 + XMOS XU316 kombinasyonunu kullanır):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU IC çip

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai

#### Home Assistant Voice Preview Edition donanımı için ESPHome projesinden XMOS firmware:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Lisans

Bu proje [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] lisansı altında lisanslanmıştır.
Bu donanımın herhangi bir değiştirilmiş versiyonu da aynı lisans altında dağıtılmalıdır.

☕ Bu projeyi desteklemek isterseniz, [Ko-fi'de bana bir kahve ısmarlayabilirsiniz](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---