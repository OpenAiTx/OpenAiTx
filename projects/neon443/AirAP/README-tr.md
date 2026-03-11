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
        <img src="https://github.com/neon443/AirAP/blob/main/Icon/icon.png?raw=true" title="icon" alt="icon" width="100" />
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
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="Bu proje dünyanın ilk ada hackathonu olan Shipwrecked'in bir parçasıdır!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP, iOS için Swift ile yazılmış tamamen yerel bir AirPlay sunucusudur. Temelde, AirAP iPhone'unuzu iTunes veya Mac'inizde bir AirPlay alıcısı olarak kullanmanızı sağlar, yani iPhone'unuzu cihazınızın sesini çalmak için kullanabilirsiniz.

## AirAP nedir?

Mac'inizden, Apple TV'nizden veya başka bir iOS cihazdan iPhone'unuza ses akışı yapmak istediniz mi? AirAP, iOS üzerinde yerel olarak çalışan tam bir AirPlay sunucusu uygulayarak bunu mümkün kılıyor. Kurulduktan sonra, iPhone'unuz Sistem Tercihleri'nin Ses bölümünde, Music.app'ta veya başka bir AirPlay uyumlu uygulamada kullanılabilir bir AirPlay hedefi olarak görünür.

İlk başta fikir ters görünebilir - sonuçta, genellikle iPhone'larımızdan diğer cihazlara akış yapmaya alışkınız. Fakat tersini yapmak isteyebileceğiniz şaşırtıcı derecede çok senaryo var. Belki Mac'inizde gece geç saatlerde çalışıyorsunuz ve sesleri kulaklıkla iPhone'unuza yönlendirmek istiyorsunuz ki kimseyi rahatsız etmeyin (merhaba 👋). Belki bir geliştiricisiniz ve ses uygulamalarını test ediyorsunuz, farklı çıkış cihazları arasında hızlıca geçiş yapmanız gerekiyor. Ya da belki eski kablolu hoparlörünüzü yeniden değerlendirmek istiyorsunuz.

## AirAP Kurulumu

Denemek için [bu TestFlight bağlantısını açın](https://testflight.apple.com/join/8aeqD8Q2), AirAP'i kurun ve talimatları izleyin. Kurulumdan sonra, AirAP'i başlatın ve iPhone'unuzun, akış yapmak istediğiniz cihazla aynı Wi-Fi ağına bağlı olduğundan emin olun. iPhone'unuz otomatik olarak AirPlay cihaz listelerinde görünecek, ses almaya hazır olacak - eğer görünmüyorsa, uygulamayı yeniden başlatmayı deneyin.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---