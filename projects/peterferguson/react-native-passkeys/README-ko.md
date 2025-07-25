# React Native 패스키

이것은 iOS, Android 및 웹에서 동일한 API로 패스키를 생성하고 인증하는 데 도움을 주는 Expo 모듈입니다. 이 라이브러리는 표준 [`navigator.credentials`](https://w3c.github.io/webappsec-credential-management/#framework-credential-management)에 가깝게 유지하는 것을 목표로 합니다. 더 구체적으로, 우리는 `get` 및 `create` 함수에 대한 API를 제공합니다(이 함수들은 크로스 플랫폼에서 사용 가능합니다).

우리가 적용하는 적응은 base64-url 인코딩 문자열을 버퍼로 자동 변환하는 것과 같은 간단한 편의 기능입니다. 이는 네이티브 측에 값을 전달하기 쉽게 하기 위해서도 수행됩니다.

추가 편의 기능으로는 특정 기능 지원을 나타내는 플래그 함수들이 포함됩니다.

## 설치 방법

```sh
npx expo install react-native-passkeys
```
## iOS 설정

#### 1. Apple App Site Association (AASA) 파일 호스팅

iOS에서 Passkeys를 사용하려면 도메인에 AASA 파일을 호스팅해야 합니다. 이 파일은 앱이 인증하려는 도메인을 처리할 수 있음을 확인하는 데 사용됩니다. 이 파일은 유효한 SSL 인증서가 있는 사이트에 호스팅되어야 합니다.

파일은 다음 위치에 호스팅되어야 합니다:


```
https://<your_domain>/.well-known/apple-app-site-association
```

이 파일에는 `.json` 확장자가 없지만 형식은 json임을 유의하십시오. 파일의 내용은 다음과 비슷해야 합니다:

```json
{
  "webcredentials": {
    "apps": ["<teamID>.<bundleID>"]
  }
}
```

`<teamID>`를 Apple 팀 ID로, `<bundleID>`를 앱의 번들 식별자로 교체하세요.

#### 2. 관련 도메인 추가

다음 내용을 `app.json`에 추가하세요:

```json
{
  "expo": {
    "ios": {
      "associatedDomains": ["webcredentials:<your_domain>"]
    }
  }
}
```
`<your_domain>`을 AASA 파일을 호스팅하는 도메인으로 바꾸십시오. 예를 들어, AASA 파일을 `https://example.com/.well-known/apple-app-site-association`에서 호스팅하는 경우, `associatedDomains` 배열에 `example.com`을 추가합니다.

#### 3. 최소 배포 대상 추가

다음 내용을 `app.json`에 추가하십시오:


```json
{
  "expo": {
    "plugins": [
      [
        "expo-build-properties",
        {
          "ios": {
            "deploymentTarget": "15.0"
          }
        }
      ]
    ]
  }
}
```

#### 4. 앱 사전 빌드 및 실행하기

```sh
npx expo prebuild -p ios
npx expo run:ios # or build in the cloud with EAS
```

## Android 설정

#### 1. `assetlinks.json` 파일 호스팅

안드로이드에서 패스키를 사용하려면 도메인에 `assetlinks.json` 파일을 호스팅해야 합니다. 이 파일은 앱이 인증하려는 도메인을 처리할 수 있음을 확인하는 데 사용됩니다. 이 파일은 유효한 SSL 인증서가 있는 사이트에 호스팅되어야 합니다.

파일은 다음 위치에 호스팅되어야 합니다:

```
https://<your_domain>/.well-known/assetlinks.json
```

그리고 다음과 같은 형태여야 합니다 (이 파일은 [Android Asset Links Assistant](https://developers.google.com/digital-asset-links/tools/generator)를 사용하여 생성할 수 있습니다):

```json
[
  {
    "relation": ["delegate_permission/common.handle_all_urls"],
    "target": {
      "namespace": "android_app",
      "package_name": "<package_name>",
      "sha256_cert_fingerprints": ["<sha256_cert_fingerprint>"]
    }
  }
]
```

`<package_name>`을 앱의 패키지 이름으로, `<sha256_cert_fingerprint>`을 앱의 SHA256 인증서 지문으로 교체하세요.

#### 2. Expo 빌드 속성 수정

다음으로, `app.json`에서 `compileSdkVersion`을 최소 34 이상으로 수정해야 합니다.

```json
{
  "expo": {
    "plugins": [
      [
        "expo-build-properties",
        {
          "android": {
            "compileSdkVersion": 34
          }
        }
      ]
    ]
  }
}
```

#### 3. 앱 사전 빌드 및 실행하기

```sh
npx expo prebuild -p android
npx expo run:android # or build in the cloud with EAS
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---