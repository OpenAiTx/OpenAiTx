![GitHub Cards Preview](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike는 간단하고 사용하기 쉬운 음식 배달 앱입니다. Android-Jetpack Compose를 사용하여 구축되었으며, 최신 Android 아키텍처 컴포넌트를 활용한 MVVM 원칙에 따라 설계되었습니다.

## 데모 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## 스크린샷 📱 
온보딩 | 로그인 | 홈 | 상세 | 히스토리 | 장바구니 | 프로필
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## 사용 기술 🛠

- [Kotlin](https://kotlinlang.org/) - Android 개발을 위한 공식 1급 프로그래밍 언어입니다.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose는 Android의 최신 네이티브 UI 빌드 툴킷입니다.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - 코루틴은 비동기 실행 코드를 간소화하기 위해 Android에서 사용할 수 있는 동시성 설계 패턴입니다.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow는 지연 생성되는 값을 가진 컬렉션 타입인 Sequence의 비동기 버전입니다.
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) -
  견고하고 테스트 가능하며 유지보수가 쉬운 앱 설계를 돕는 라이브러리 모음입니다.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow는 현재 상태와 새 상태 업데이트를 수집자에게 방출하는 상태 보유 관찰 가능한 플로우입니다.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow는 지연 생성되는 값을 가진 컬렉션 타입인 Sequence의 비동기 버전입니다.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - UI 변경 시에도 파괴되지 않는 UI 관련 데이터를 저장합니다.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Navigation 컴포넌트는 Jetpack Compose 애플리케이션을 지원합니다.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore는 키-값 쌍 또는 프로토콜 버퍼를 이용한 타입 객체를 저장할 수 있는 데이터 저장 솔루션입니다. DataStore는 Kotlin 코루틴과 Flow를 사용하여 데이터를 비동기적이고 일관성 있게, 트랜잭션 방식으로 저장합니다.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt는 Android용 의존성 주입 라이브러리로, 프로젝트에서 수동 의존성 주입 시 발생하는 보일러플레이트 코드를 줄여줍니다. 수동 의존성 주입은 모든 클래스와 그 의존성을 직접 생성하고, 의존성 재사용 및 관리를 위해 컨테이너를 사용하는 작업을 요구합니다.












  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - Android 12부터 SplashScreen API를 사용하면 앱 시작 시 애니메이션을 포함하여, 시작 시 앱 내 모션, 앱 아이콘을 보여주는 스플래시 화면, 그리고 앱 자체로의 전환을 구현할 수 있습니다. SplashScreen은 Window이므로 Activity를 덮습니다.
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Android용 모듈화되고 커스터마이즈 가능한 Material Design UI 컴포넌트입니다.
- [Figma](https://figma.com/) - Figma는 주로 웹 기반인 벡터 그래픽 편집기이자 프로토타이핑 도구입니다.

## Architecture 🗼

이 앱은 [***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch) 아키텍처를 사용합니다.

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Build-tool 🧰
이 프로젝트를 빌드하려면 [Android Studio Beta 3 이상](https://developer.android.com/studio/preview)이 필요합니다.

## Contact 📩

저에게 연락하고 싶으신가요? 아래에서 DM 주세요 👇

메일 보내기:- gautamhazarika01@gmail.com

제 포트폴리오:- www.gautamhz.com

## Donation 💰

이 프로젝트가 개발 시간을 줄이는 데 도움이 되었다면, 커피 한 잔 사주세요 :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## License 🔖


```

MIT License

Copyright (c) 2026 Gautam Hazarika

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



```
## 백엔드:

저는 전체 코틀린을 사용하여 ktor로 백엔드를 구축하고 있습니다 [여기](https://github.com/gautam84/foodike-backend).


## 다음 단계:

- 백엔드를 안드로이드 앱에 통합합니다.
- 모든 코드를 최신 버전으로 업데이트합니다.
- 단위 테스트, 통합 테스트 및 UI/엔드 투 엔드 테스트를 작성합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---