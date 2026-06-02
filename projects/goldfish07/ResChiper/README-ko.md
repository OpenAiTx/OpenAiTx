# ResChiper

<h1 align="center">
  <img src="https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/reschiper-banner.png" alt="failed to load artifacts/logo.png"/>
  <p align="center" style="font-size: 0.3em">AAB 리소스 난독화 도구</p>
</h1>

[![License](https://img.shields.io/badge/license-Apache_2.0-maroon)](LICENSE)
![Android Gradle Plugin](https://img.shields.io/badge/Dependency-AGP/8.8.0-4CAF50)
[![BundleTool](https://img.shields.io/badge/Dependency-Bundletool/1.17.2-red)](https://github.com/google/bundletool)
![JDK Version](https://img.shields.io/badge/JDK-17-blue)
![Gradle Version](https://img.shields.io/badge/Gradle_Wrapper-8.8-darkgreen)
[![ResChiper Version](https://img.shields.io/badge/release-0.1.0--rc6-%23C6782A.svg?style=flat)](https://github.com/goldfish07/ResChiper/releases/tag/0.1.0-rc6)

## 목차

- [소개](#introduction)
- [시작하기](#getting-started)
    - [요구사항](#requirements)
    - [설치](#installation)
    - [사용법](#usage)
- [설정 옵션](#configuration-options)
- [예제](#example)
- [화이트리스트](#whitelist)
- [출력](#output)
- [감사의 글](#acknowledgments)
- [라이선스](#license)

## 소개

ResChiper는 Android AAB 리소스 난독화를 위해 설계된 도구입니다.
무단 접근으로부터 리소스를 보호하고 앱의 AAB 크기를 줄일 수 있습니다.

## 시작하기

다음 단계를 따라 AAB 리소스 난독화 도구를 Android 프로젝트에 통합하세요:

## 요구사항

ResChiper를 사용하기 전에 앱이 다음 요구사항을 충족하는지 확인하세요:
- **Java Development Kit (JDK)**: ResChiper는 JDK 17을 필요로 합니다. 앱이 JDK 17로 설정되어 있는지 확인하세요.
- **Android Gradle Plugin (AGP)**: 버전 8.0 이상이어야 합니다.

## 설치

#### 1. ResChiper Gradle 플러그인 추가

프로젝트의 루트 레벨 `build.gradle` 파일의 `buildscript` 섹션에 ResChiper Gradle 플러그인을 추가하세요:


```gradle
buildscript {
  dependencies {
    classpath "io.github.goldfish07.reschiper:plugin:<latest_version>"
  }
  
  repositories {
    mavenCentral()
    google()
   }
}
```
#### 2. 플러그인 적용

앱 수준의 `build.gradle` 파일에서 ResChiper 플러그인을 적용하세요:


```gradle
apply plugin: "io.github.goldfish07.reschiper"
```

#### 3. 플러그인 구성

`app/build.gradle` 파일에서 원하는 설정을 지정하여 ResChiper 플러그인을 구성합니다. 다음은 예시
구성입니다:

```gradle
resChiper {
    enableObfuscation = true //by default res obfuscate is enabled
    obfuscationMode = "default" //["dir", "file", "default"]
    obfuscatedBundleName = "reschiper-app.aab" // Obfuscated file name, must end with '.aab'
    //mappingFile = file("path/to/your/mapping.txt").toPath() // Mapping file used for incremental obfuscation
    whiteList = [
                  //Whitelist rule (directory name to exclude)
                  "res/raw", // raw dir will not be obfuscated
                  "res/xml", // xml dir will not be obfuscated

                  //Whitelist rule (file name to exclude)
                  "res/raw/*", // all files inside raw directory will not be obfuscated
                  "res/raw/success_tick.json", // success_tick.json file will not be obfuscated
                  "res/xml/*", // all files inside xml directory will not be obfuscated

                  // White list rules (resource name to exclude)
                  "*.R.raw.*",
                  "*.R.xml.*",

                  // for google-services
                  "*.R.string.google_api_key",
                  "*.R.string.google_app_id",
                  "*.R.string.default_web_client_id",
                  "*.R.string.gcm_defaultSenderId",
                  "*.R.string.ga_trackingId",
                  "*.R.string.firebase_database_url",
                  "*.R.string.google_crash_reporting_api_key",
                  "*.R.string.google_storage_bucket",
                  "*.R.integer.google_play_services_version",
                  
                  //firebase
                  "*.R.string.project_id",
                  //firebase crashlytics
                  "*.R.string.com.google.firebase.crashlytics.mapping_file_id",
                  "*.R.bool.com.crashlytics.useFirebaseAppId",
                  "*.R.string.com.crashlytics.useFirebaseAppId",
                  "*.R.string.google_app_id",
                  "*.R.bool.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.string.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.bool.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.ApiEndpoint",
                  "*.R.string.com.crashlytics.android.build_id",
                  "*.R.bool.com.crashlytics.RequireBuildId",
                  "*.R.string.com.crashlytics.RequireBuildId",
                  "*.R.bool.com.crashlytics.CollectCustomLogs",
                  "*.R.string.com.crashlytics.CollectCustomLogs",
                  "*.R.bool.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.CollectCustomKeys"
    ]
    mergeDuplicateResources = true // allow the merge of duplicate resources
    enableFileFiltering = true
    enableFilterStrings = true
    fileFilterList = [ // file filter rules
                         "META-INF/*",
//                       "*/armeabi-v7a/*",
//                       "*/arm64-v8a/*",
//                       "*/x86/*",
//                       "*/x86_64/*"
    ]
    unusedStringFile = "path/to/your/unused_strings.txt" // strings will be filtered in this file
    localeWhiteList = ["en", "in", "fr"] //keep en,en-xx,in,in-xx,fr,fr-xx and remove others locale.
}
```
## 사용법

리소스를 난독화하고 난독화된 AAB를 생성하려면, 프로젝트 루트 디렉터리에서 다음 Gradle 명령어를 실행하세요.:



```cmd
./gradle clean :app:resChiperDebug --stacktrace
```
이 명령어는 프로젝트 루트에서 난독화 과정을 실행하며, 난독화된 AAB 파일은  
`app/build/outputs/bundle/debug` 디렉토리에 생성됩니다.

## 구성 옵션

ResChiper 확장 기능은 리소스 난독화를 위한 다양한 구성 옵션을 제공하며, 난독화 활성화/비활성화,  
매핑 파일 지정, 화이트리스트 리소스 설정 등 여러 기능을 포함합니다.

- `enableObfuscation`: 리소스 난독화 활성화 또는 비활성화.<br>
- `obfuscationMode`: 디렉토리만 난독화하려면 `obfuscationMode = "dir"`, 파일만 난독화하려면  
  `obfuscationMode = "file"`, 디렉토리와 파일 모두 난독화하려면 `obfuscationMode = "default"`로 설정.<br>
- `enableFilterStrings`: 사용하지 않는 파일 분할을 라인 단위로 입력하여 문자열 제거 지원.<br>
- `enableFileFiltering`: 번들 패키지 내 파일 필터링 지원. 현재는 `META-INFO/`와 `lib/` 경로에서만 필터링 지원.<br>
- `obfuscatedBundleName`: 난독화된 AAB 파일 이름.<br>
- `mergeDuplicateResources`: 중복 리소스 파일 제거 및 패키지 크기 축소.<br>
- `mappingFile`: ProGuard 매핑 파일 경로 (mapping.txt를 난독화에 사용할 때만 설정).<br>
- `whiteList`: 난독화에서 제외할 리소스 이름 집합.<br>
- `fileFilterList`: 필터링할 파일 패턴 목록.<br>
- `unusedStringFile`: 사용하지 않는 문자열이 포함된 파일 경로.<br>
- `localeWhiteList`: AAB에 포함할 로케일 집합.

## 예시

일부 구성 예시는 [여기](https://github.com/goldfish07/ResChiper/wiki/Example-Configuration-Options)에서 확인할 수 있습니다.

## 화이트리스트

빌드 과정에서 난독화되지 않는 리소스입니다.<br>
화이트리스트 설정은 [여기](https://github.com/goldfish07/ResChiper/wiki/WhiteList)에서 확인할 수 있습니다.

## 출력

난독화 과정을 실행한 후 다음과 같은 출력 파일을 기대할 수 있습니다:

- **aab:** 난독화된 번들 패키지로, 난독화된 리소스를 포함하는 Android App Bundle (AAB)입니다.
- **resources-mapping.txt:** 리소스 난독화 매핑 파일로, 향후 난독화 과정의 입력으로 사용하여 증분 난독화를 수행할 수 있습니다.  
  이는 특히 유지 관리 시 유용합니다.



  일관성을 유지합니다.
- **-duplicated.txt:** 이 로그 파일은 병합된 리소스에 대한 정보를 제공합니다. 난독화 과정 중 병합된 중복 리소스를 식별하고 추적하는 데 도움이 됩니다.

이 출력 파일들은 ResChiper 도구를 실행한 결과로 생성되며, 프로젝트의 빌드 출력 내 관련 디렉토리에서 찾을 수 있습니다.

## 감사의 글

ResChiper는 다음 프로젝트 및 도구에서 영감을 받았습니다:

* [AabResGuard](https://github.com/bytedance/AabResGuard/)
* [AndResGuard](https://github.com/shwenzhang/AndResGuard/)
* [BundleTool](https://github.com/google/bundletool)

## 라이선스

[![Apache License v2.0 logo](https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/apache-licence-logo.png)](https://www.apache.org/licenses/LICENSE-2.0.txt)

    Copyright (C) 2023 goldfish07 (Ayush Bisht) <ayushbisht5663@gmail.com>
    이 파일은 ResChiper의 일부입니다.

    ResChiper는 자유 소프트웨어입니다: Apache 소프트웨어 재단에서 발표한
    Apache License, 버전 2.0의 조건에 따라 재배포 및/또는 수정할 수 있습니다.
    라이선스 버전 2.0 또는 그 이후 버전을 선택할 수 있습니다.

    Apache License, 버전 2.0("라이선스")에 따라 라이선스가 부여됩니다.
    이 파일을 라이선스에 따라 사용해야 합니다.
    라이선스 사본은 다음에서 얻을 수 있습니다.

        http://www.apache.org/licenses/LICENSE-2.0

    해당 법률에 의해 요구되거나 서면으로 동의하지 않는 한,
    라이선스 하에 배포되는 소프트웨어는 "있는 그대로" 제공되며,
    명시적이거나 묵시적인 보증이나 조건 없이 배포됩니다.
    라이선스에 따른 권리 및 제한 사항을 확인하십시오.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---