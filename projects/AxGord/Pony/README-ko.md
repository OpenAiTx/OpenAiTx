
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Lang](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.12-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony는 프로젝트 개발, 준비, 빌드, 테스트 및 배포를 위한 도구 세트입니다.
Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash, Cocos Creator 애플리케이션 생성에 사용할 수 있습니다.

서버 또는 클라이언트 측에서 작동합니다.

라이브러리는 XML 기반 UI 빌딩 시스템과 컴포넌트, 강력한 이벤트 시스템, 다양한 유틸리티 함수를 제공합니다.

설치
============
안정 버전

    haxelib install pony

불안정 버전

    haxelib git pony https://github.com/AxGord/Pony

Pony Tools 설치

    haxelib run pony

조용한 설치 예시

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - 옵션 활성화

`-` - 옵션 비활성화

`code` - Visual Studio Code 추천 플러그인 설치

`code-insiders` - Visual Studio Code Insiders 추천 플러그인 설치

`npm` - NPM (Node 패키지 관리자) 모듈 설치

`userpath` - 사용자 경로 설정

`nodepath` - node_modules 경로를 사용자 경로로 설정, Windows에서만 사용

`ponypath` - Windows에서만 pony.exe의 사용자 경로를 설정합니다.

CI 설치 예시

    haxelib run pony install -code -code-insiders +npm +userpath

[설치 비디오 가이드](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - 크로스플랫폼 애플리케이션 제작 비디오](https://youtu.be/gAY77ESYOUY)

매뉴얼
------
* [홈](//github.com/AxGord/Pony/wiki)

* [Pony 도구](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [명령어](//github.com/AxGord/Pony/wiki/Commands)
    * [서버 섹션](//github.com/AxGord/Pony/wiki/Server-section)
    * [설정 섹션](//github.com/AxGord/Pony/wiki/Config-section)
    * [준비 섹션](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [빌드 섹션](//github.com/AxGord/Pony/wiki/Build-sections)
    * [포스트 빌드 섹션](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [네트워크](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* 플랫폼
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [참고서](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---