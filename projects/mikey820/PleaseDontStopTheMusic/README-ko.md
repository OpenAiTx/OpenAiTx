# PleaseDontStopTheMusic

iOS에서 오디오 세션 중단을 방지하여 여러 오디오 소스를 동시에 재생할 수 있게 하는 트윅입니다.

## ❤️ 프로젝트 지원하기

이 프로젝트가 유용하다고 생각되면 개발 지원을 위해 기부를 환영합니다.

### 라이트코인
**네트워크:** 라이트코인 (LTC)  
**주소:** `ltc1qaz2zqcc5usl4ueg7w5m8kqcmvrfqurpn6wqyfa`

반드시 **라이트코인** 네트워크로 보내는지 재확인해 주세요.

지원해 주셔서 감사합니다!

---

## 개요

**PleaseDontStopTheMusic**는 iOS의 `AVAudioSession`에 후킹하여 오디오 믹싱을 가능하게 하는 트윅입니다. 이를 통해 현재 재생 중인 오디오(음악, 팟캐스트 등)가 다른 앱이 오디오 재생을 요청할 때도 중단되지 않고 계속 재생됩니다. 일반적으로는 시스템이 현재 오디오를 일시정지하고 새 오디오만 재생하는 동작과 다릅니다.

## 기능

- **연속 재생** - 다른 앱에서 소리를 재생하려 해도 현재 오디오가 계속 재생됩니다.
- **오디오 믹싱** - `MixWithOthers` 옵션을 사용하여 여러 오디오 소스가 함께 믹싱됩니다.
- **범용 지원** - 루트풀, 루트리스, 탈옥 환경 모두에서 작동합니다.
- **경량화** - 오버헤드 최소, 후크 기반 구현만으로 작동합니다.

## 작동 원리

이 트윅은 `AVAudioSession` 구성 호출을 가로채며, **다른 앱이 이미 오디오를 재생 중인 경우**(`isOtherAudioPlaying`), 새 앱의 세션에 `AVAudioSessionCategoryOptionMixWithOthers` 옵션을 적용합니다. 이를 통해 iOS는 새 오디오를 기존 재생과 혼합하여 중단하지 않습니다.

중요하게도, 주 오디오 소스 앱에는 믹싱을 강제하지 않습니다. `MixWithOthers`를 선택한 앱은 iOS에서 *보조* 소스로 간주되어 잠금 화면/제어 센터의 "지금 재생 중" 전송 컨트롤을 잃게 됩니다. 첫 번째/주 앱은 그대로 두어 잠금 화면의 건너뛰기 및 일시정지 컨트롤을 유지하며, 이후 앱들(TikTok, 게임 등)은 방해하지 않고 조용히 믹싱됩니다.

### 후킹된 메서드

- `setCategory:error:`
- `setCategory:mode:options:error:`
- `setCategory:mode:routeSharingPolicy:options:error:` *(TikTok 및 최신 앱들이 사용하는 현대식 API)*
- `setCategory:withOptions:error:`
- `setActive:error:`
- `setActive:withOptions:error:`

`SoloAmbient` 세션(혼합 불가)은 다른 앱이 재생 중일 때 투명하게 `Ambient`로 전환되어 더 이상 음악을 중단시키지 않습니다.

---

## 설치 가이드

기기 구성에 맞는 방법을 아래에서 선택하세요.

### 방법 1: 탈옥되지 않은 기기 (사이드로딩)
기기가 탈옥되지 않은 경우 이 방법을 사용하세요. 릴리스에서 제공하는 `.dylib` 트윅을 대상 앱의 IPA 파일에 주입해야 합니다.

1. **준비:** `PleaseDontStopTheMusic.dylib` 파일을 준비합니다.
2. **도구 선택:** **Esign**, **Feather**, 또는 **Sideloadly** 같은 사이드로딩 도구를 사용하세요.
3. **주입:** 대상 앱(예: 로블록스 재생 중에 스포티파이를 듣고 싶으면 로블록스 앱에 주입)의 IPA를 도구에 불러오고, `.dylib`를 선택해 앱에 주입 후 서명합니다.
4. **설치:** 수정된 IPA를 기기에 설치하세요.

### 방법 2: 탈옥된 기기
기기가 탈옥된 경우 이 방법을 사용하세요.

1. **저장소 추가:** https://repo.chariz.com/ 에 접속하여 선호하는 패키지 관리자에 추가 버튼을 누릅니다 (기본 저장소이지만 없으면 추가하세요).
2. **설치:** 저장소 목록에서 찾아 설치하거나 "PleaseDontStopTheMusic"을 검색하세요.
3. **마무리:** 기기를 **리스프링**하여 훅을 적용합니다.

---

문제나 질문이 있으면 언제든지 디스코드로 DM 주세요! dc: fuseegelee

```bash
make all
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---