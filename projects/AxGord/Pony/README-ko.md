[![Lang](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.11-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony는 프로젝트 개발, 준비, 빌드, 테스트 및 배포를 위한 도구 모음입니다.
Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash 및 Cocos Creator 애플리케이션을 만드는 데 사용할 수 있습니다.

서버 또는 클라이언트 측에서 작동합니다.

이 라이브러리는 XML 기반 UI 빌딩 시스템과 컴포넌트, 강력한 이벤트 시스템, 그리고 다양한 유틸리티 기능을 제공합니다.

설치
============
안정 버전

    haxelib install pony

불안정 버전

    haxelib git pony https://github.com/AxGord/Pony

Pony 도구 설치

    haxelib run pony

무음 설치 예제

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - 옵션 활성화

`-` - 옵션 비활성화

`code` - Visual Studio Code 권장 플러그인 설치
`code-insiders` - Visual Studio Code Insiders 권장 플러그인 설치

`npm` - NPM (Node Package Manager) 모듈 설치

`userpath` - 사용자 경로 설정

`nodepath` - node_modules 사용자 경로 설정, Windows 전용

`ponypath` - pony.exe 사용자 경로 설정, Windows 전용

CI 설치 예시

    haxelib run pony install -code -code-insiders +npm +userpath

[설치 비디오 가이드](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - 크로스 플랫폼 애플리케이션 제작 비디오](https://youtu.be/gAY77ESYOUY)

매뉴얼
------
* [홈](//github.com/AxGord/Pony/wiki)

* [Pony 도구](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [명령어](//github.com/AxGord/Pony/wiki/Commands)
    * [서버 섹션](//github.com/AxGord/Pony/wiki/Server-section)
    * [설정 섹션](//github.com/AxGord/Pony/wiki/Config-section)
    * [준비 섹션](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [빌드 섹션](//github.com/AxGord/Pony/wiki/Build-sections)
    * [빌드 후 섹션](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [네트워크](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* 플랫폼
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [참고서](http://axgord.github.io/Pony/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---