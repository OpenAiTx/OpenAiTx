<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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
        gunakan iphone Anda sebagai penerima airplay
        <br/>

        <a href="https://neon443.github.io">
            dibuat oleh neon443
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
         alt="Proyek ini adalah bagian dari Shipwrecked, hackathon pertama di dunia yang diadakan di pulau!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP adalah server AirPlay native sepenuhnya, ditulis dalam Swift, untuk iOS. Secara sederhana, AirAP memungkinkan Anda menggunakan iPhone sebagai penerima AirPlay di iTunes atau di Mac Anda, yang berarti Anda dapat menggunakan iPhone untuk memutar suara dari perangkat Anda.

## Apa itu AirAP?

Pernahkah Anda ingin melakukan streaming audio dari Mac, Apple TV, atau perangkat iOS lain ke iPhone Anda? AirAP memungkinkan hal ini dengan mengimplementasikan server AirPlay penuh yang berjalan secara native di iOS. Setelah terpasang, iPhone Anda akan muncul sebagai tujuan AirPlay yang tersedia di panel Audio Preferensi Sistem, Music.app, atau aplikasi lain yang kompatibel dengan AirPlay.

Konsep ini mungkin terasa terbalik pada awalnya - karena kita biasanya melakukan streaming dari iPhone ke perangkat lain. Namun ada banyak skenario di mana Anda ingin melakukan sebaliknya. Mungkin Anda sedang bekerja di Mac larut malam dan ingin mengalihkan audio ke iPhone dengan headphone agar tidak mengganggu siapa pun (hai 👋). Atau Anda adalah pengembang yang menguji aplikasi audio dan perlu dengan cepat berganti antara perangkat output yang berbeda. Atau mungkin Anda hanya ingin memanfaatkan speaker kabel lama Anda.

## Instalasi AirAP

Untuk mencobanya, [buka tautan TestFlight ini](https://testflight.apple.com/join/8aeqD8Q2), pasang AirAP, dan ikuti instruksinya. Setelah terpasang, cukup jalankan AirAP dan pastikan iPhone Anda terhubung ke jaringan Wi-Fi yang sama dengan perangkat yang ingin Anda streaming. iPhone Anda akan otomatis muncul di daftar perangkat AirPlay, siap menerima audio - jika tidak, coba mulai ulang aplikasinya.

## Kompilasi

Pastikan Anda memiliki [homebrew](https://brew.sh)
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