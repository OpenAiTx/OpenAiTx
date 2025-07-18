<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center"> 
    <br/>
    <p>
        <img src="https://github.com/neon443/AirAP/blob/main/AirAP/Assets.xcassets/AppIcon.appiconset/Icon.png?raw=true" title="cobalt" alt="cobalt logo" width="100" />
    </p>
    <p>
        iphone'unuzu bir airplay alıcısı olarak kullanın
        <br/>
        <a href="https://neon443.github.io">
            neon443 tarafından yapıldı
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            testflight
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="Bu proje, dünyanın bir adadaki ilk hackathonu olan Shipwrecked'in bir parçasıdır!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP, iOS için Swift ile yazılmış tamamen yerel bir AirPlay sunucusudur. Temelde, AirAP, iPhone'unuzu iTunes veya Mac'inizde bir AirPlay alıcısı olarak kullanmanıza olanak tanır; yani iPhone'unuzu cihazınızın sesini çalmak için kullanabilirsiniz.

## AirAP nedir?

Mac'inizden, Apple TV'nizden veya başka bir iOS cihazından iPhone'unuza ses akışı yapmak istediniz mi? AirAP, iOS'ta yerel olarak çalışan tam bir AirPlay sunucusu uygulayarak bunu mümkün kılar. Kurulduktan sonra, iPhone'unuz Sistem Tercihleri'ndeki Ses sekmesinde, Music.app'te veya başka herhangi bir AirPlay uyumlu uygulamada mevcut bir AirPlay hedefi olarak görünecektir.

Kavram ilk başta ters gelebilir - sonuçta, genellikle iPhone'larımızdan diğer cihazlara yayın yapmaya alışığız. Ancak tersi yönde yapmak isteyebileceğiniz şaşırtıcı derecede çok senaryo var. Belki gece geç saatlerde Mac'inizde çalışıyorsunuz ve sesi kimseyi rahatsız etmemek için kulaklıkla iPhone'unuza yönlendirmek istiyorsunuz (selam 👋). Belki bir geliştiricisiniz ve ses uygulamalarını test ederken farklı çıkış cihazları arasında hızlıca geçiş yapmanız gerekiyor. Ya da belki eski kablolu hoparlörünüzü yeniden değerlendirmek istiyorsunuz.

## AirAP'in Kurulumu

Denemek için, [bu TestFlight bağlantısını açın](https://testflight.apple.com/join/8aeqD8Q2), AirAP'i yükleyin ve talimatları izleyin. Kurulumdan sonra, sadece AirAP'i başlatın ve iPhone'unuzun yayın yapmak istediğiniz cihazla aynı Wi-Fi ağına bağlı olduğundan emin olun. iPhone'unuz otomatik olarak AirPlay cihaz listelerinde ses almaya hazır olarak görünecektir – eğer görünmüyorsa, uygulamayı yeniden başlatmayı deneyin.

## Derleme

[homebrew](https://brew.sh) yüklü olduğundan emin olun

```
brew install carthage
git clone https://github.com/neon443/AirAP
cd AirAP
carthage checkout
open AirAP.xcodeproj
```
After adding your Team ID in Project > AirAP > Signing and Capabilities, hit `Command + R` to build and run! 

### thanks to

[qasim/Airstream](https://github.com/qasim/Airstream)
[shairplay](https://github.com/juhovh/shairplay)
would not have been possible without these

---

<sup>
&copy; 2025 Nihaal Sharma. AirPlay, iPhone, iTunes, Mac, and Apple TV are trademarks of Apple Inc.
</sup>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---