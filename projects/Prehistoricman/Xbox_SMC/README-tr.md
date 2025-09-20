
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Orijinal Xbox'tan alınan PIC16/Xyclops dökümleri ve bazı tersine mühendislik çalışmalarıyla IDA veritabanları.

![Orijinal bir Xbox'tan alınan PIC16LC63A'nın görüntüsü](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops flaşlama (XycloMod)
[Bkz. Xyclops dizini ve README](/Xyclops)

# Dump'lar
Her PIC dökümü için .bin dosyasındaki baytlar, IDA'ya doğru şekilde yüklenmesi için takas edilmiştir. Yani PIC belleğinin ilk kelimesi byte_0 + byte_1 << 8'dir.

.idb IDA veritabanlarında değişkenler hakkında bilgi ve veritabanı not defterinde bazı gözlemler vardır.

SMC sürümlerinin ayrıntılı dökümü için bu wiki sayfasına bakınız: https://xboxdevwiki.net/Xboxen_Info

## B2A
DVT3 Xbox'tan döküldü. P01 ile aynı yapılandırma kelimesine sahip. Ayrıca üretim PIC'lerinin aksine yapılandırma alanında cihaz kimliği 0000 0000 000B 002A olarak yazılmıştır.

Boot challenge tamamen eksik.

## D01
XDK BETA 2 Xbox'tan döküldü. Boot challenge eksik olması dışında P01 ile özdeş. Beklenen boot challenge yanıtını hesaplayan fonksiyon hala mevcut, ancak hiçbir zaman çağrılmıyor.

## DXF
XDK D2 debug kitinden döküldü. D01'e çok benzer, ancak biraz farklı tepsi, aşırı ısınma ve boot mantığına sahip. Boot challenge D01'deki ile aynı şekilde eksik.

## D2E
Tuscany (v1.6) geliştirme kitinden döküldü. Xyclops çipi X01202-001 olarak işaretlenmiş, ve perakende ünitelerde bulunan A-A02 veya A-B01 hattı eksik.

FC00'deki debug seri kodu perakende P2L dökümü ile eşleşiyor. 0x4000 ila 0xFBFF arasında garip bir veri deseni var.

## P01
v1.0 Xbox'tan döküldü. Yapılandırma kelimesi 0x86:
- CP1:CP0 = 0 (Tüm bellek için Kod Koruma etkin)
- BODEN = 0 (Brown-out Reset devre dışı)
- ~PWRTE = 0 (Power-up Timer etkin)
- WDTE = 1 (Watchdog Timer etkin)
- FOSC1:FOSC0 = 2 (HS osilatör)

Kod koruma etkin olmadan SMC klonları için uygun bir yapılandırma değeri 0x3FB6'dır.

## P11
v1.3 Xbox'tan döküldü. P01 ile aynı yapılandırma kelimesine sahip.

P11'de P01'e göre birkaç küçük değişiklik var; ek SMBus komutu (0x22 yazma), farklı LED öncelikleri ve boot için daha gevşek zamanlamalar gibi.

v1.3'ün karıştırılmış dökümlerini v1.4 ile karşılaştırdım ve eşleştiler. Bu, çok büyük olasılıkla aynı programa sahip oldukları anlamına geliyor.

## P2L
v1.6 Xbox'tan çıkarıldı. Xyclops revizyonu A-A02. Intel 8051 kodu içeriyor fakat işlevi bilinmeyen birçok özel fonksiyon kaydı var.

Debug seri portu FC00 adresindeki kod tarafından çalıştırılıyor. Görünüşe göre, çalışmayı durdurabilen, veri dökebilen ve kayıtlar/RAM üzerinde yazma yapabilen ilkel bir hata ayıklayıcı.

# Xyclops dökümü

Xyclops çipinde 'debug' için 3 pin var: TXD (pin 64), RXD (pin 63) ve DEBUG (pin 29). Seri portu TX ve RX pinlerinde etkinleştirmek için DEBUG pinini yüksek seviyeye ayarlayın. Seri iletişim 9600 baud hızında çalışır.

Protokol genellikle `<komut>` `<adres MSByte>` `<adres LSByte>` `<önemsiz>` formatında olan 4 baytlık komutlara dayanır.

0x14 komutu her seferinde 64 bayt BIOS verisi, 0x15 ise her seferinde 64 bayt SMC program verisi döker. Xyclops'tan alınan bir döküm olan P2L.bin depoda dahil edilmiştir. Kendi makinenizi dökmek için [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) de dahildir.

# PIC döküm metodolojisi
Tam yazı için https://wiki.recessim.com/view/PIC_Burnout

PIC'de kod koruması etkin, bu yüzden tüm veriler 0000 olarak okunuyor. Bunun yerine karıştırılmış veri çıkışı almak için bir yöntem kullandım, feda edilen bir çip ile karıştırma algoritmasını keşfettim ve bir çeşit exploit kullanarak ROM verisini bazı bitleri bilinen değerlere değiştirmek için kullandım. Daha sonra, birden fazla karıştırılmış dökümlerden gerekli bilgileri çıkartıp orijinal veriyi yeniden oluşturabiliyorum.

# PICProgrammer
PICProgrammer, araştırmalarımda kullandığım RP2040 için birkaç Arduino projesinden biridir. PIC üzerinde ICSP (devre içi seri programlama) işlemlerini gerçekleştirmek için basit bir komut satırı arayüzü sunar. Esnekliği ve üreticinin öngörmediği işlemlerin yapılabilmesi nedeniyle, özel amaçlı bir programlayıcı (ör. PICkit) kullanmaktan daha avantajlıdır.

Bunu kullanmadan önce elektronik ve programlama konusunda iyi bir anlayışa sahip olmanız ve komutları çalıştırmadan önce ne yaptıklarını dikkatlice incelemeniz gerekir.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---