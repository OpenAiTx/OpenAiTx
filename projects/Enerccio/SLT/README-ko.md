# SLT - Jetbrains IDE 라인업을 위한 Common Lisp 언어 플러그인

![GitHub release (latest by date)](https://img.shields.io/github/v/release/Enerccio/SLT)
[![Version](https://img.shields.io/jetbrains/plugin/v/21132-slt.svg)](https://plugins.jetbrains.com/plugin/21132-slt)
![JetBrains plugins](https://img.shields.io/jetbrains/plugin/d/21132)
![GitHub Release Date](https://img.shields.io/github/release-date/Enerccio/SLT)
![OSS Lifecycle](https://img.shields.io/osslifecycle/Enerccio/SLT)
![GitHub](https://img.shields.io/github/license/Enerccio/SLT)
![GitHub lisp counter](https://img.shields.io/github/search/Enerccio/SLT/lisp)
[![0.1.0](https://badgen.net/github/milestones/enerccio/SLT/1)](https://github.com/enerccio/SLT/milestone/1)
[![0.2.0](https://badgen.net/github/milestones/enerccio/SLT/2)](https://github.com/enerccio/SLT/milestone/2)
[![0.3.0](https://badgen.net/github/milestones/enerccio/SLT/4)](https://github.com/enerccio/SLT/milestone/4)
[![0.4.0](https://badgen.net/github/milestones/enerccio/SLT/5)](https://github.com/enerccio/SLT/milestone/5)
[![0.5.0](https://badgen.net/github/milestones/enerccio/SLT/6)](https://github.com/enerccio/SLT/milestone/6)
![GitHub all releases](https://img.shields.io/github/downloads/Enerccio/SLT/total)
![GitHub last commit](https://img.shields.io/github/last-commit/Enerccio/SLT)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/Enerccio/SLT)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/Enerccio/SLT)
![Lines of code](https://img.shields.io/tokei/lines/github/Enerccio/SLT)
![GitHub top language](https://img.shields.io/github/languages/top/Enerccio/SLT)
[![(want-to-support-me? T NIL)](https://img.shields.io/liberapay/receives/Enerccio.svg?logo=liberapay)](https://liberapay.com/Enerccio)
![Liberapay patrons](https://img.shields.io/liberapay/patrons/Enerccio)
[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpledges&style=flat)](https://patreon.com/enerccio)[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpatrons&style=flat)](https://patreon.com/enerccio)
![Maintenance](https://img.shields.io/maintenance/yes/2023)
![GitHub issues](https://img.shields.io/github/issues/Enerccio/SLT)
![GitHub branch checks state](https://img.shields.io/github/checks-status/Enerccio/SLT/master)

[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/SLT_IDE?style=social)](https://old.reddit.com/r/SLT_IDE/)
![GitHub forks](https://img.shields.io/github/forks/Enerccio/SLT?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/Enerccio/SLT?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/Enerccio/SLT?style=social)
[![Join the chat at https://gitter.im/SLT-Plugin/community](https://badges.gitter.im/SLT-Plugin/Lobby.svg)](https://gitter.im/SLT-Plugin/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
![GitHub Discussions](https://img.shields.io/github/discussions/Enerccio/SLT)

![Image](https://raw.githubusercontent.com/Enerccio/SLT/master/src/main/resources/logo/logo.svg)

**이 플러그인은 실험적이며 언제든지 충돌할 수 있습니다! 모든 버그를 신고해 주세요!**

이 플러그인은 JetBrains IDE용 Common Lisp 지원을 제공합니다.  
수정된 SLIME/Swank 프로토콜을 사용하여 Lisp 인터프리터와 통신하며  
Common Lisp용 IDE 기능을 제공합니다.

# (다소) 상세 설치 및 사용 가이드

이제 마켓플레이스에서 플러그인을 다운로드할 수 있습니다! https://plugins.jetbrains.com/plugin/21132-slt

https://github.com/Enerccio/SLT/wiki/User-Guide

## 요구 사항

1) Intellij 기반 IDE - `Intellij Idea Community/Ultimate`에서 테스트되었으며 주요 IDE에서 작동해야 합니다  
   1) 지원되는 버전은 2022.2 이상입니다

선택 사항 (자세한 내용은 가이드 참조):

1) 지원되는 LISP 인터프리터 중 하나 설치:  
   * [Steel Bank Common Lisp](https://www.sbcl.org/)  
   * [Armed Bear Common Lisp](https://armedbear.common-lisp.dev/)  
   * [Clozure Common Lisp](https://ccl.clozure.com/)  
   * [Allegro CL](https://franz.com/products/allegro-common-lisp/)  
   * [CMUCL](https://www.cons.org/cmucl/)  
2) [Quicklisp](https://www.quicklisp.org/beta/) 설치

(모든 기능이 모든 인터프리터에서 동작하는 것은 아니며, 자세한 내용은 [FEATURES.md](https://raw.githubusercontent.com/Enerccio/SLT/master/FEATURES.md)를 참고하세요!)

## 시작하기

https://github.com/Enerccio/SLT/wiki/User-Guide#plugin-installation 참고

## 플러그인 옵션

- SDK 관련 내용은 위 가이드 참고  
- 색상 변경: https://github.com/Enerccio/SLT/wiki/User-Guide#change-colors-of-elements  
- 들여쓰기 변경: https://github.com/Enerccio/SLT/wiki/User-Guide#change-indentation-settings

## 소스 컴파일

저장소를 클론하고 gradle.properties를 IDE에 맞게 변경하세요.  
그런 다음 gradle로 플러그인을 빌드할 수 있습니다.  
Intellij Idea에서 프로젝트로 열 수도 있습니다.

## 계획된 기능 / 목표

* [x] 기능이 충분해지면 마켓플레이스에 업로드  
* [x] 자동 들여쓰기  
* [x] REPL  
  * [x] REPL 반환 검사  
* [x] 대화형 디버깅  
* [x] 인수 도움말 (Ctrl+P)  
* [x] 검사  
  * [x] 기본 검사  
  * [x] 액션  
  * [x] 심볼 검사기  
  * [ ] 검사 평가  
* [x] 중단점  
* [x] 문서화  
  * [x] Hyperspec 통합  
* [x] 매크로 확장 (전체, 1개, 일반)  
* [x] 심볼 이름으로 함수 찾기  
* [x] 심볼 검색
* [x] 역참조  
* [x] 무지개 괄호  
* [ ] 리팩토링  
  * [x] 람다를 함수로 추출  
* [ ] quicklisp 설치된 패키지 목록 / ASDF 패키지 목록  
* [ ] 아직 평가되지 않은 수정된 최상위 폼 목록  
* [ ] 실제 IDE 만들기, 즉 플러그인과 의존성을 하나의 애플리케이션으로 통합, 단순 플러그인이 아님  
* [x] SDK 지원  
    * 진정한 SDK는 아니며, 이는 Intellij에서만 제공되고 (예: PyCharm에서는 제공되지 않으므로) 수동으로 구현됨  
    * [x] 사용자용 SBCL과 quicklisp 다운로드  
* [x] Lisp 인터프리터 및 quicklisp 자동 다운로드  
* [x] 다양한 Lisp 인터프리터 지원  

## 라이선스  

이 프로젝트는 [Apache License v2](https://raw.githubusercontent.com/Enerccio/SLT/master/LICENSE.txt) 하에 라이선스가 부여되었습니다.  

# 어떻게 도울 수 있나요?  

* 플러그인을 설치하고 사용해 보세요!  
* 모든 버그를 보고해 주세요. 모두 잡을 수 있도록 [여기](https://github.com/enerccio/SLT/issues/new)를 클릭해 보고하세요.  
* 프로젝트가 마음에 들면 별을 주거나 정보를 공유해 주세요  
* 이 프로젝트는 오픈 소스이므로, 지식이 있고 구현하고 싶은 것이 있다면 저장소를 포크하고 PR을 생성하세요!  

## 후원  

원하시면 [Liberapay](https://liberapay.com/Enerccio/donate) 또는  
[Patreon](https://www.patreon.com/enerccio)을 통해 제 작업을 지원할 수 있습니다.  

# SLT는 무슨 뜻인가요?  

SLT - Speech Language Therapy. LISP의 유일한 치료법!  

또한 Superior Lisp Tooling의 백로님입니다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---