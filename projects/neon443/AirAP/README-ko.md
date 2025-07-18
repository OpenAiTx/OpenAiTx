<div align="center"> 
    <br/>
    <p>
        <img src="https://github.com/neon443/AirAP/blob/main/AirAP/Assets.xcassets/AppIcon.appiconset/Icon.png?raw=true" title="cobalt" alt="cobalt logo" width="100" />
    </p>
    <p>
        아이폰을 에어플레이 수신기로 사용하세요
        <br/>
        <a href="https://neon443.github.io">
            neon443 제작
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
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="이 프로젝트는 세계 최초 섬에서 열리는 해커톤 Shipwrecked의 일부입니다!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP는 iOS용으로 Swift로 작성된 완전한 네이티브 AirPlay 서버입니다. 본질적으로 AirAP를 사용하면 iTunes나 Mac에서 iPhone을 AirPlay 수신기로 사용할 수 있어, iPhone을 통해 기기에서 나오는 소리를 재생할 수 있습니다.

## AirAP란?

Mac, Apple TV 또는 다른 iOS 기기에서 iPhone으로 오디오를 스트리밍하고 싶었던 적이 있나요? AirAP는 iOS에서 네이티브로 실행되는 완전한 AirPlay 서버를 구현하여 이를 가능하게 합니다. 설치 후, iPhone은 시스템 환경설정의 오디오 창, Music.app 또는 다른 AirPlay 호환 앱에서 사용 가능한 AirPlay 대상 장치로 나타납니다.

처음에는 이 개념이 다소 역방향처럼 보일 수 있습니다 - 결국 우리는 iPhone에서 다른 기기로 스트리밍하는 데 익숙하니까요. 하지만 실제로는 반대 방향으로 하고 싶은 경우가 꽤 많습니다. 예를 들어, 밤늦게 Mac에서 작업하면서 오디오를 헤드폰을 쓴 iPhone으로 보내 주변 사람들을 방해하지 않으려 할 때(안녕하세요 👋). 개발자로서 오디오 앱을 테스트하며 여러 출력 기기 사이를 빠르게 전환해야 할 때. 또는 오래된 유선 스피커를 재활용하고 싶을 때 등입니다.

## AirAP 설치하기

시험해보려면 [이 테스트플라이트 링크](https://testflight.apple.com/join/8aeqD8Q2)를 열고 AirAP를 설치한 후 안내에 따라 진행하세요. 설치 후에는 AirAP를 실행하고 iPhone이 스트리밍할 기기와 동일한 Wi-Fi 네트워크에 연결되어 있는지 확인하세요. iPhone은 자동으로 AirPlay 기기 목록에 나타나 오디오를 받을 준비를 합니다 - 만약 나타나지 않는다면 앱을 재시작해 보세요.

## 컴파일하기

[homebrew](https://brew.sh)를 설치했는지 확인하세요
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