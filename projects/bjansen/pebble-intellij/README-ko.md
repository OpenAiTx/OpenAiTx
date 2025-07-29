# Pebble용 IntelliJ 플러그인 [![Gitter](https://badges.gitter.im/bjansen/pebble-intellij.svg)](https://gitter.im/bjansen/pebble-intellij) [![GitHub Actions](https://github.com/bjansen/pebble-intellij/workflows/Java%20CI/badge.svg?branch=master)](https://github.com/bjansen/pebble-intellij/actions) [![GitHub release](https://img.shields.io/github/release/bjansen/pebble-intellij.svg)](https://plugins.jetbrains.com/plugin/9407-pebble) [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=pebble-intellij&metric=coverage)](https://sonarcloud.io/dashboard?id=pebble-intellij)

이 플러그인은 IntelliJ IDEA 2017.3 이상에서 [Pebble 템플릿 엔진](https://github.com/PebbleTemplates/pebble)을 지원합니다.

<p align="center">
  <img src="https://github.com/bjansen/pebble-intellij/raw/master/images/plugin.png" 
       width="594" alt="Pebble용 IntelliJ 플러그인"/>
<p>

## 기능

* 파서/렉서<sup>1</sup> 및 구문 하이라이팅 (사용자 정의 구분자 지원)
* 내장 태그용 라이브 템플릿
* 중괄호 매칭, 코드 접기 및 주석 처리
* 따옴표 처리기
* 탐색 (메서드 및 필드, 포함된 파일)
* 코드 완성
* 알 수 없는 참조 하이라이트
* [pebble-spring](https://github.com/PebbleTemplates/pebble/wiki/spring-integration)에서 도입된 변수 및 함수 지원
* [추가 기능 예정](https://github.com/bjansen/pebble-intellij/issues?utf8=%E2%9C%93&q=is%3Aissue%20is%3Aopen%20label%3At-feature)

<sup>1</sup>: *사용자 정의 연산자는 현재 지원되지 않습니다*.

## 설치

이 플러그인은 JetBrains의 [플러그인 저장소](https://plugins.jetbrains.com/idea/plugin/9407-pebble)에서 제공됩니다. IDE에서 `Preferences > Plugins`로 이동한 후 검색창에 `pebble`을 입력하세요.

## Pebble과 다른 언어 혼합 사용

한 파일 내에서 두 가지 언어를 인식하도록 하려면, 예를 들어 HTML과 Pebble을 함께 사용할 경우, `Preferences > Languages & Frameworks > Template Data Languages`로 이동하여 Pebble 템플릿이 있는 디렉터리에 대해 `HTML` 데이터 언어를 선택하세요:

![템플릿 데이터 언어 설정](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/settings.png)

이렇게 하면 구문 하이라이팅, 코드 완성, 탐색, Emmet 확장 등 기능이 활성화됩니다.

## 코드 완성 사용법

코드 완성을 사용하려면 `foo`의 타입을 플러그인에 알려야 합니다. 이는 JSP, FreeMarker, Velocity 플러그인과 마찬가지로 `@pebvariable` 힌트를 사용하여 가능합니다:

![코드 완성](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/completion.png)

`@pebvariable` 힌트는 `var` 라이브 템플릿을 통해 템플릿에 쉽게 추가할 수 있습니다. 문법은 다음과 같습니다:

    {# @pebvariable name="<name>" type="<type>" #}

코드 완성이 제대로 작동하려면 `type` 속성에 명시된 클래스들이 포함된 `.peb` 파일이 [콘텐츠 루트](https://www.jetbrains.com/help/idea/content-roots.html) (예: `src/main/resources`) 아래에 위치해야 합니다. 그렇지 않으면 자신의 소스 파일에 정의된 클래스가 제안되지 않습니다.

## 야간 빌드

스냅샷 빌드는 Actions CI에서 제공됩니다:
 * https://github.com/bjansen/pebble-intellij/actions 로 이동
 * 최신 빌드를 클릭
 * 페이지 하단의 `Artifacts` 섹션에서 `pebble-intellij-development` 클릭
 * 다운로드된 zip 파일은 [디스크에서 플러그인 설치](https://www.jetbrains.com/help/idea/managing-plugins.html#install_plugin_from_disk)를 통해 IDE에 설치할 수 있습니다













---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---