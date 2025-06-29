# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Web Sitesi：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Diller: [简体中文](./README.zh.md) | English

## Özeti

----

bu eklentinin fikri [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart)'dan geldi, tüm kodlar yeniden yazıldı. tüm ses paketleriyle uyumludur ve bazı yeni özellikler eklendi.

## Özel Teşekkürler

---

1. eklenti [@justkowalski](https://github.com/JustKowalski) tarafından hazırlanan çinli ses paketini içerir. [daha fazla ses paketini github'dan edinebilirsiniz](https://github.com/topics/rainbow-fart)
2. eklenti, [@James K. Lawless](http://jiml.us) tarafından sağlanan cmdmp3win.exe'yi içerir.
3. varsayılan waifu modeli [@二夏](https://erxia207.lofter.com) tarafından hazırlanmıştır, yalnızca size ait orijinal bir waifu tasarlamak isterseniz, kendisiyle iletişime geçebilirsiniz.
4. eklenti, ayrıca [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632) tarafından açık kaynak yapılan keysoban adlı başka bir waifu modeli içerir.

[Daha Fazla Waifu Modeli Edinin](https://github.com/ezshine/live2d-model-collections)

## Desteklenen Platformlar

---

~~~~
Yalnızca MacOS ve Windows10 desteklenmektedir
~~~~

## SSS

---

#### _Waifu görüntülenmiyor mu?_
> C: [buradan](https://github.com/ezshine/live2d-model-collections) waifu container'ı indirmeniz gerekiyor. Zip dosyasının içindekileri çıkardıktan sonra liv2dplayer.exe'yi çalıştırın, vscode'da komutlar listesini açın, waifu modelini değiştirmeyi deneyin.

## Kullanım Kılavuzu, Komutlar

---

🌈 Rainbow Fart Waifu Komutlarını Göster

- "Ses Paketlerini Değiştir"
- "Waifu Modellerini Değiştir"
- "Kaynak Dizini Aç"

> Eğer bir ses paketi veya model paketi indirdiyseniz, kaynak dizinini açmak ve bu paketleri ilgili dizine taşımak için bu komutu kullanmanız gerekir.

- "Waifu Container ve Daha Fazla Kaynağı İndir"

## Özellikler

---

1. WebUI kaldırıldı, MacOS'ta 'afplay', Windows10'da 'cmdmp3win' ile ses dosyası oynatılıyor.
2. WaifuContainer ile etkileşim, masaüstünüzde sanal bir eşiniz size programlamada eşlik ediyor.

## Ses Paketi Uyarısı

---

~~~~
özelleştirilmiş bir ses paketi oluşturmak ya da internetten indirilen bir ses paketini kullanmak için bazı uyarılar
~~~~

1. 'manifest.json' yerine 'contributes.json' kullanın.
2. 'contributes.json' dosyasına ses içeriğiyle eşleşen metinler ekleyin.

~~~~javascript
"contributes": [
    {
        "keywords": ["function", "=>", "func ", "def "],
        "voices":[
            "function_01.mp3",
            "function_02.mp3",
            "function_03.mp3"
        ],
        "texts":[
            "Vay canına, callback fonksiyonunu harika yazmışsın!",
            "Bu fonksiyonun ismini benim adımla koymaya ne dersin?",
            "En havalı fonksiyon bile sana olan sevgimi ifade edemez!"
        ]
    }
]
~~~~

## Bana Destek Olun

---

Bu eklenti programlamanızı daha keyifli hale getirdiyse, bir kola ısmarlayabilir misiniz?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)

**Keyfini çıkarın!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---