<div align="right">
  <details>
    <summary >🌐 언어</summary>
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
        아이폰을 AirPlay 수신기로 사용하세요
        <br/>

        <a href="https://neon443.github.io">
            만든이: neon443
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            테스트플라이트
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="이 프로젝트는 세계 최초의 섬 해커톤 Shipwrecked의 일부입니다!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP는 iOS용으로 Swift로 작성된 완전한 네이티브 AirPlay 서버입니다. 본질적으로 AirAP를 사용하면 iTunes나 Mac에서 iPhone을 AirPlay 수신기로 사용할 수 있어, iPhone으로 기기의 소리를 재생할 수 있습니다.

## AirAP란?

Mac, Apple TV 또는 다른 iOS 기기에서 iPhone으로 오디오를 스트리밍하고 싶었던 적이 있나요? AirAP는 iOS에서 네이티브로 동작하는 완전한 AirPlay 서버를 구현하여 이를 가능하게 합니다. 설치 후, iPhone은 시스템 환경설정의 오디오 패널, 음악 앱 또는 다른 AirPlay 호환 앱에서 AirPlay 대상으로 표시됩니다.

처음에는 컨셉이 역설적으로 느껴질 수 있습니다. 보통 우리는 iPhone에서 다른 기기로 스트리밍하는 것에 익숙하니까요. 하지만 반대로 하고 싶은 상황이 의외로 많습니다. 예를 들어, 밤늦게 Mac으로 작업하면서 오디오를 iPhone과 헤드폰으로 듣고 싶을 수 있습니다(안녕하세요 👋). 또는 오디오 앱을 테스트하는 개발자라서 여러 출력 기기를 빠르게 전환해야 할 수도 있습니다. 아니면 오래된 유선 스피커를 재활용하고 싶을 수도 있고요.

## AirAP 설치하기

[이 TestFlight 링크를 열어서](https://testflight.apple.com/join/8aeqD8Q2) AirAP를 설치하고 안내에 따라 진행하세요. 설치 후 AirAP를 실행하고, iPhone이 스트리밍하려는 기기와 같은 Wi-Fi 네트워크에 연결되어 있는지 확인하세요. iPhone은 자동으로 AirPlay 기기 목록에 나타나며 오디오 수신 준비가 완료됩니다. 만약 보이지 않는다면 앱을 재시작해보세요.

## 컴파일하기

[homebrew](https://brew.sh)가 설치되어 있는지 확인하세요
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