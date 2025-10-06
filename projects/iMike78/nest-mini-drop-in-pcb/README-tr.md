
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

# Google Nest Mini için MiciMike drop-in PCB değişimi

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb), ["Google Nest Mini" (Google'ın ikinci nesil, varil konnektörlü şarj portuna sahip akıllı hoparlörü)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) için bir drop-in PCB değişimidir, ancak açık kaynaklı yazılım çalıştırmak için ESP32 ve XMOS mikrodenetleyicilere dayanmaktadır.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

İpucu! Eğer "Google Home Mini" (Google'ın birinci nesil, Micro-USB şarj portuna sahip akıllı hoparlör donanımı) için benzer bir drop-in PCB değişimi arıyorsanız, https://github.com/iMike78/home-mini-v1-drop-in-pcb adresindeki kardeş projeye göz atın.

Her ikisi de tamamen açık kaynaklı donanım projeleridir ve [Onju Voice](https://github.com/justLV/onju-voice)'dan bazı konsept ilhamları almıştır; ancak PCB tasarımları ve özellikleri için [Open Home Foundation'ın açık sesli asistanlar standardını, Home Assistant Voice Preview Edition’ı referans alarak](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) izlemeyi hedeflemektedirler.

# Proje kapsamı

Bu projenin ve deposunun amacı (ki bu [Onju Voice](https://github.com/justLV/onju-voice)'a benzer ama tamamen açık kaynak donanım lisansı altındadır), herkesin üretebileceği veya tek bir PCB üreticisinden sipariş edebileceği, Google Nest Mini (2. Nesil) için özel bir drop-in yedek PCB (Baskılı Devre Kartı) ve donanım şematiklerini tasarlamaktır.

Bu öncelikle eski Google Nest Mini akıllı hoparlörlerini [Home Assistant'ın Sesli Kontrolü](https://www.home-assistant.io/voice_control/) için açık kaynaklı donanıma dönüştürmek veya [Music Assistant](https://www.music-assistant.io) için medya oynatıcı hoparlör çıkışı elde etmek isteyen kişileri hedeflemektedir, (donanım muhtemelen diğer uygulamalar ve farklı firmware ile de kullanılabilir, çünkü popüler Espressif ESP32 platformu üzerine kuruludur).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Donanım tasarımı (tıpkı [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) gibi), WiFi, BLE ve [yerleşik uyandırma kelimesi algılama](https://www.home-assistant.io/voice_control/about_wake_word/) (kod gerektirmeyen [ESPHome firmware’i](https://esphome.io/)) için bir ESP32-S3 SoC’yi + gelişmiş ses işleme için bir XMOS xCORE XU316 çipini entegre edecektir (mikrofon temizleme işini üstlenmek için özel firmware ile, daha iyi ses tanıma yetenekleri için yerel olarak çalışan algoritmalar kullanılarak Gürültü Bastırma, Akustik Yankı İptali, Parazit İptali ve Otomatik Kazanç Kontrolü sağlanır).

Fonksiyonellik açısından, donanım [Home Assistant Voice Preview Edition (diğer adıyla Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) referans tasarımı ile büyük ölçüde donanım uyumlu olacak şekilde hazırlanmıştır (ki bu, Open Home Foundation tarafından Nabu Casa ile işbirliği içinde açık kaynak donanım tasarımı olarak yayınlanmıştır). Ana fark, Google Nest Mini muhafazası ve bileşenleriyle belirlenen sınırlamalar nedeniyle olacaktır, (yani nest-mini-drop-in-pcb proje donanım tasarımı, Google’ın orijinal donanımındakiyle aynı türde fiziksel kapasite girişleriyle sınırlı olacaktır).

Bu nedenle, bu proje/deponun kapsamı ESPHome firmware’i için yeni özellikler/fonksiyonlar geliştirmek değildir, eğer bu tarz bir şey istiyorsanız, bunun yerine Home Assistant Voice Preview Edition firmware geliştirme ve upstream ESPHome ana koduna yönelmeniz gerekir:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## İşbirliği talebi

PCB yerleşim tasarımı konusunda deneyiminiz varsa (ve özellikle PCB yönlendirme, toprak dökümü veya gürültüye duyarlı dijital+analog yerleşimler ile ilgiliyseniz), **yardımınız çok değerlidir**! Lütfen yeni bir issue açmaktan, öneri/istek göndermekten, mevcut issue’lara katkı/geri bildirim eklemekten veya bu depoyu çatallamaktan çekinmeyin.

Kavram/fikir hakkında daha fazla bilgi için, ilgili tartışmaya katkı sağlamak ve bilgi edinmek üzere aşağıdaki Home Assistant topluluk forumu başlığını da inceleyin:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Mevcut durum

- ✅ Şematik tamamlandı
- ✅ Bileşen yerleşimi yapıldı
- ✅ Yönlendirme yapıldı
- ✅ Toprak dökümü, koruma stratejisi ve EMI değerlendirmeleri yapıldı
- ⚠️ 1. test partisi iki hatada başarısız oldu - düzeltildi
- 🕓 2. test partisi bekleniyor

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Kullanılan araçlar

- 🛠️ KiCad 9
- 🧰 Ayak izi bulmak için SnapEDA / LCSC

## Bilinen donanım özellikleri

- 4 katmanlı PCB
- ESP32-S3R8 çıplak çip (WiFi, BLE ve dahili uyandırma kelimesi algılama için ESP32-S3)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP ses işleme)
- Çift SPI flaş
- Çift I²S veri yolu (aynı anda I2S arayüzlerinin kullanılabilmesi için, yani eşzamanlı ses çıkışı ve ses girişi)
- Hoparlör çıkışı için MAX98357 (I2S Sınıf-D Mono Ses Amplifikatörü)
- 2x MEMS mikrofon (MSM261DHP)
- SK6812 LED'ler
- Özel USB-C ve 14V güç girişi

---

> ⚠️ USB-C üzerinden flaşlama, ana 14V güç girişinin bağlantısının kesilmesini gerektirir. Ayrıntılar için PCB üzerindeki serigrafi notuna bakın.

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

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC çipi

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Önizleme Sürümü donanımı için ESPHome projesinden XMOS firmware'i:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Lisans

Bu proje [CERN Açık Donanım Lisansı Sürüm 2 - Güçlü Karşılıklılık (CERN-OHL-S v2)] altında lisanslanmıştır.
Bu donanımın değiştirilmiş herhangi bir sürümü de aynı lisans altında dağıtılmalıdır.

☕ Bu projeyi desteklemek isterseniz, [Ko-fi üzerinden bana bir kahve ısmarlayabilirsiniz](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---