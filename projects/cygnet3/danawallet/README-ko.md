# Dana wallet

Dana는 비트코인 기부를 받기 위해 사용되는 Flutter 앱입니다. 온체인 프라이버시를 유지하면서 기부를 받을 수 있는 새로운 정적 결제 프로토콜인 Silent Payments를 사용합니다.

## Dana wallet 사용해보기

**Dana wallet은 현재 실험 단계에 있습니다. 테스트넷/사인넷 사용을 권장합니다. 메인넷에서 실제로 테스트하려면, 잃어도 괜찮은 자금만 사용하세요. 손실에 대해서는 책임지지 않습니다.**

앱이 좀 더 안정화되면 인기 앱 스토어에 Dana wallet을 출시할 예정입니다.

그동안 Dana wallet을 사용해볼 수 있는 두 가지 방법이 있습니다:

- [릴리즈 페이지](https://github.com/cygnet3/danawallet/releases)에서 최신 Dana wallet APK 다운로드
- [셀프 호스팅 F-Droid 저장소](https://fdroid.silentpayments.dev/fdroid/repo)를 통해 Dana wallet 다운로드

### F-Droid를 통한 다운로드

자동 업데이트 지원과 한 번의 설정만 필요하므로 F-Droid 옵션을 권장합니다.

- 안드로이드 폰에서 F-Droid 앱 실행
- ‘설정’으로 이동
- ‘내 앱’ 섹션에서 ‘저장소’ 클릭
- ‘+’ 아이콘 클릭하여 새 저장소 추가
- 이 페이지에 있는 QR 코드를 스캔: https://fdroid.silentpayments.dev/fdroid/repo

셀프 호스팅 저장소가 추가되었습니다. 앱을 다운로드하려면 F-Droid 앱 스토어에서 ‘Dana Wallet’을 검색하세요 (먼저 F-Droid 스토어 화면에서 아래로 스와이프하여 앱 목록을 새로고침해야 할 수 있습니다).

## 소스에서 Dana wallet 빌드하기

아래는 Dana wallet을 소스에서 빌드하는 방법입니다. Dana wallet 개발에 기여하고 싶은 경우에만 권장합니다.

### 리눅스(데스크톱)용 빌드

리눅스용 빌드는 추가 작업 없이 아래 명령어만 실행하면 됩니다.

```
flutter run
```

다른 플랫폼(macOS, Windows)에서도 작동할 수 있으나 테스트하지는 않았습니다.

### 안드로이드용 빌드

안드로이드 기기용 빌드는 해당 아키텍처용 바이너리를 생성하기 위한 준비 작업이 필요합니다.

먼저 `cargo-ndk`가 필요합니다. 원하는 툴체인을 추가해야 할 수도 있습니다:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

설치 후 rust 디렉터리로 이동해 `just build-android`를 실행합니다.

```
cd rust
just build-android
```

`just`가 설치되어 있지 않으면 `justfile`에 있는 명령어를 복사해 실행해도 됩니다.
이 과정에서 바이너리가 생성됩니다.

다음으로, 폰을 연결하고 디버깅 모드를 활성화하세요.
폰이 연결되었는지 확인하려면 다음 명령어를 실행합니다:

```
flutter devices
```

마지막으로 안드로이드 기기에 앱을 빌드하고 설치하려면:

```
flutter run
```

## Dana에 기부하기

다음 주소를 통해 Dana wallet에 기부할 수 있습니다:

> ₿donate@danawallet.app

또는 다음 Silent Payments 주소를 사용할 수 있습니다:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---