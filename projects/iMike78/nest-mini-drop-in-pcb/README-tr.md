
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
Her ikisi de tamamen açık kaynaklı donanım projeleridir ve bazı kavramsal ilhamlarını [Onju Voice](https://github.com/justLV/onju-voice) projesinden alırken, PCB tasarımları ve teknik özellikler için [Open Home Foundation'ın açık sesli asistanlar standardı ile Home Assistant Voice Preview Edition referans alınarak](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) ilerlemeyi amaçlamaktadır.

# Proje kapsamı

Bu projenin ve deposunun amacı ([Onju Voice](https://github.com/justLV/onju-voice) ile benzer ancak tamamen açık kaynaklı donanım lisansı altında), herkesin kendisinin yapabileceği/üretebileceği veya bir PCB üreticisinden sipariş edebileceği, Google Nest Mini (2. Nesil) için özel bir drop-in (yerine geçebilen) PCB (Baskılı Devre Kartı) ve donanım şematiklerini tasarlamaktır.

Bu proje öncelikle eski Google Nest Mini akıllı hoparlörlerini [Home Assistant için Sesli Kontrol](https://www.home-assistant.io/voice_control/) ve/veya [Music Assistant](https://www.music-assistant.io) ile medya oynatıcı hoparlör çıkışı olarak kullanmak ya da dönüştürmek isteyenleri hedeflemektedir, (donanım, popüler Espressif ESP32 platformuna dayandığı için muhtemelen başka uygulamalar ve farklı firmware ile de kullanılabilir).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Donanım tasarımı, (tıpkı [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) gibi), WiFi, BLE ve [yerleşik uyandırma kelimesi algılama](https://www.home-assistant.io/voice_control/about_wake_word/) (kod yazmadan [ESPHome firmware](https://esphome.io/) ile) için bir ESP32-S3 SoC + gelişmiş ses işleme için XMOS xCORE XU316 çipi (mikrofon temizleme işlemini özel firmware ile offload ederek daha iyi sesli komut tanıma için gürültü azaltma, akustik yankı iptali, girişim iptali ve otomatik kazanç kontrolü gibi yerel algoritmalar kullanarak) entegre edecektir.

Fonksiyonel olarak, donanım büyük ölçüde [Home Assistant Voice Preview Edition (Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) referans tasarımı ile donanımsal olarak uyumlu olacak şekilde tasarlanmıştır (bu tasarım Open Home Foundation tarafından Nabu Casa ile işbirliğinde açık kaynaklı donanım olarak yayımlandı). Ana fark, Google Nest Mini muhafazası ve bileşenlerinin belirlediği sınırlamalardan kaynaklanacaktır (yani, nest-mini-drop-in-pcb proje donanım tasarımı, Google'ın orijinal donanımı ile aynı tür fiziksel kapasite girişleri ile sınırlı olacaktır).

Bu nedenle, bu proje/deponun kapsamı ESPHome firmware için yeni özellikler/fonksiyonlar geliştirmek değildir; eğer bunu istiyorsanız, bunun yerine Home Assistant Voice Preview Edition firmware geliştirme ve upstream ESPHome ana koduna yönelmeniz gerekmektedir:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## İşbirliği talebi

PCB yerleşim tasarımı konusunda deneyiminiz varsa (özellikle PCB yönlendirme, topraklama, veya gürültüye duyarlı dijital+analog yerleşimler ile ilgili), **yardımınız çok takdir edilecektir**! Lütfen yeni bir issue açmaktan, öneri/talep sunmaktan, mevcut issue'lara katkı ve geri bildirim eklemekten veya bu depoyu forkladığınızda özgürce hareket edin.

Kavram/fikir hakkında daha fazla bilgi almak ve katkı sağlamak için ilgili tartışmaya Home Assistant topluluk forumunda da göz atabilirsiniz:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Mevcut durum

- ✅ Şematik tamamlandı
- ✅ Bileşen yerleşimi yapıldı
- ✅ Yönlendirme tamamlandı
- ✅ Toprak dökümü, koruma stratejisi ve EMI değerlendirmeleri tamamlandı
- ⚠️ 1. test partisi iki hata nedeniyle başarısız oldu - düzeltildi
- 🕓 2. test partisi bekleniyor

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## Kullanılan Araçlar

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC (ayak izi bulmak için)

## Bilinen donanım özellikleri

- 4 katmanlı PCB
- ESP32-S3R8 çıplak çip (WiFi, BLE ve dahili uyandırma kelimesi algılama için ESP32-S3)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP ses işleme)
- Çift SPI flash (çünkü ESP32 ve XMOS'un kendi SPI flash'ı var)
- Çift I²S veri yolu (aynı anda I2S arayüzlerine izin verir, yani eşzamanlı ses çıkışı ve ses girişi)
- MAX98357 hoparlör çıkışı için (I2S Sınıf-D Mono Ses Yükseltici)
- 2x MEMS mikrofon (çift MMICT390200012, mikrofonlar arası mesafe 68mm)
- 6x SK6812 RGB LED
- Özel USB-C ve 14V güç girişi (Not! USB-C ve varil konnektörü aynı anda bağlanamaz)

---

> ⚠️ USB-C üzerinden yazılım yüklemek için ana 14V güç girişinin bağlantısı kesilmelidir. Detaylar için PCB üzerindeki ipek baskı notuna bakınız.

## Referanslar

### Home Assistant Voice Preview Edition kaynakları, PCB tasarım dosyaları dahil
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE için ESPHome ürün yazılımı (aynı ESP32-S3 + XMOS XU316 kombinasyonunu kullanır):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC çipi

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Edition donanımı için ESPHome projesinden XMOS firmware'i:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Lisans

Bu proje [CERN Açık Donanım Lisansı Sürüm 2 - Güçlü Karşılıklı (CERN-OHL-S v2)] kapsamında lisanslanmıştır.
Bu donanımın değiştirilmiş herhangi bir sürümü de aynı lisans altında dağıtılmalıdır.

☕ Bu projeyi desteklemek isterseniz, [Ko-fi üzerinden bana bir kahve ısmarlayabilirsiniz](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---