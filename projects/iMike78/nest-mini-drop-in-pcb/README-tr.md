
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

**Dikkat!** "MiciMike Home Mini Drop-In PCB" (1. nesil Google Home Mini) için yakında başlayacak kitlesel fonlama kampanyası şu anda Crowd Supply ön lansman aşamasında (proje önizlemesi yalnızca), ve bu başarılı olursa Nest Mini için eşleşen bir kampanya planlanacak, bu yüzden buradan göz atabilirsiniz:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Her ikisi de tamamen açık kaynak donanım projeleridir ve bazı fikirlerini [Onju Voice](https://github.com/justLV/onju-voice) projesinden alırken [Open Home Foundation'ın açık sesli asistanlar standardı ve Home Assistant Voice Preview Edition referans alınarak](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) PCB tasarımları ve özelliklerini takip etmeyi amaçlamaktadır.

# Proje kapsamı

Bu projenin ve depounun amacı ([Onju Voice](https://github.com/justLV/onju-voice) ile benzer fakat tamamen açık kaynak donanım lisansı altında) herkesin yapabileceği/üretebileceği veya tek bir PCB üreticisinden özel drop-in PCB olarak sipariş edebileceği bir drop-in yedek PCB (Baskılı Devre Kartı) ve donanım şemalarını tasarlamaktır; hedef donanım Google Nest Mini (2. Nesil)’dir.

Bu öncelikle eski Google Nest Mini akıllı hoparlörlerini [Home Assistant ile Sesli Kontrol](https://www.home-assistant.io/voice_control/) ve/veya [Music Assistant](https://www.music-assistant.io) için medya oynatıcı hoparlör çıkışı olarak açık kaynak donanım haline getirmek isteyenleri hedeflemektedir, (donanım ayrıca popüler Espressif ESP32 platformuna dayandığı için farklı uygulamalar ve yazılımlarla da kullanılabilir).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Donanım tasarımı ([Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) ile benzer şekilde) WiFi, BLE ve [yerleşik uyandırma kelimesi algılama](https://www.home-assistant.io/voice_control/about_wake_word/) (kod gerektirmeyen [ESPHome firmware](https://esphome.io/) ile) için ESP32-S3 SoC ile, ileri seviye ses işleme için XMOS xCORE XU316 çipi ile entegre olacak (mikrofon temizliği için özel yazılım ile daha iyi ses tanıma yeteneği sağlamak amacıyla yerel çalışan Gürültü Bastırma, Akustik Yankı İptali, Parazit İptali ve Otomatik Kazanç Kontrolü algoritmaları ile).

Fonksiyonellik açısından, donanım [Home Assistant Voice Preview Edition (diğer adıyla Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) referans tasarımına (Open Home Foundation tarafından Nabu Casa ile iş birliğiyle açık kaynak donanım olarak yayımlandı) büyük ölçüde donanım uyumlu olacak. Ana fark, Google Nest Mini kutusu ve bileşenlerinin belirlediği kısıtlamalardan kaynaklanacak, (yani nest-mini-drop-in-pcb proje donanım tasarımı, Google’ın orijinal donanımındakiyle aynı tür fiziksel kapasite girişleriyle sınırlı olacak).

Bu nedenle bu proje/depo kapsamı ESPHome firmware için yeni özellik/fonksiyonlar geliştirmek değildir, eğer bunu istiyorsanız Home Assistant Voice Preview Edition firmware geliştirmesine ve ana ESPHome koduna yönelmeniz gerekir:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## İşbirliği talebi

PCB yerleşim tasarımı konusunda deneyiminiz varsa (ve özellikle PCB yönlendirme, ground pour, veya gürültüye duyarlı dijital+analog yerleşimler konusunda), **yardımınız çok değerli**! Lütfen yeni bir konu açın, öneri/istek gönderin, mevcut konulara katkı/geri bildirim ekleyin veya bu depoyu çatallayın.

Kavram/fikir ile ilgili daha fazla bilgi için ve katkıda bulunmak için ilgili tartışmaya göz atmak için Home Assistant topluluk forumu başlığına da bakabilirsiniz:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Mevcut durum

- ✅ Şema tamamlandı
- ✅ Bileşen yerleşimi yapıldı
- ✅ Yönlendirme tamamlandı
- ✅ Ground pour, koruma stratejisi ve EMI değerlendirmeleri yapıldı
- ⚠️ İlk test partisi iki hata nedeniyle başarısız oldu - düzeltildi
- 🕓 2. test partisi bekleniyor

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Kullanılan Araçlar

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC ayak izi bulma için

## Bilinen donanım özellikleri

- 4 katmanlı PCB
- ESP32-S3R8 çıplak çip (ESP32-S3 WiFi, BLE ve gömülü uyanma kelimesi algılama için)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP ses işleme)
- Çift SPI flash (çünkü ESP32 ve XMOS'un kendi SPI flash'ı var)
- Çift I²S veri yolu (aynı anda I2S arayüzleri için, yani eşzamanlı ses çıkışı ve girişi)
- TAS5805M (TAS5805MPWPR) hoparlör çıkışı için (I2S Class-D Mono Ses Yükselteci, I2C üzerinden DSP ayarı)
- 2x MEMS mikrofon (çift MMICT390200012, mikrofonlar arası 68mm mesafe)
- 6x SK6812 RGB LED
- Özel USB-C ve 14V güç girişi (Not! USB-C ve varil konnektörü aynı anda bağlanamaz)

---

> ⚠️ USB-C ile yazılım yükleme için ana 14V güç girişinin bağlantısı kesilmelidir. Detaylar için PCB üzerindeki serigrafi notuna bakınız.

## Referanslar

### Home Assistant Voice Preview Edition kaynakları, PCB tasarım dosyaları dahil
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE için ESPHome üretici yazılımı (aynı ESP32-S3 + XMOS XU316 kombinasyonunu kullanır):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC yongası

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Edition donanımı için ESPHome projesinden XMOS üretici yazılımı:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Lisans

Bu proje [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] kapsamında lisanslanmıştır.
Bu donanımın değiştirilmiş herhangi bir versiyonu da aynı lisans altında dağıtılmalıdır.

☕ Bu projeyi desteklemek isterseniz, [Ko-fi üzerinden bana bir kahve ısmarlayabilirsiniz](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---