
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [프로젝트 설명](#project-description)
- [시스템 요구사항:](#os-requirements)
- [자주 묻는 질문](#faqs)
- [로드맵](#roadmap)
- [스크린샷](#screenshots)

## 프로젝트 설명

Elucidate는 명령줄 SnapRAID 애플리케이션을 위한 Windows GUI 프론트엔드입니다.

*이 프로젝트는 저와 다른 기여자들이 수행한 훌륭한 작업을 계속 통합합니다.

## 시스템 요구 사항

- Windows 운영 체제
- .Net 런타임 4.8.0
- SnapRaid 버전 11.5 이하
- 대상 드라이브에 10MB의 여유 공간

## 자주 묻는 질문

**Q**: SnapRAID란 무엇인가요?<br/>
**A**: SnapRAID는 Windows 및 Linux 운영 체제를 위한 소프트웨어 정의 스냅샷-패리티 엔진입니다. 가장 기본적으로, 이는 파일 시스템 내 파일들의 해시를 계산하고 결과를 패리티 파일에 저장함으로써 해당 파일 시스템의 내용을 보호합니다. 하드 드라이브가 완전히 손상될 경우, 이 패리티 파일을 사용해 손실된 데이터를 복구할 수 있습니다. 자세한 내용은 SnapRAID의 [공식 파일 보호 엔진 비교](http://snapraid.sourceforge.net/compare.html)를 참고하세요.

**Q**: GUI가 왜 필요한가요? 명령줄도 잘 작동하는데!<br/>
**A**: 더 큰 목표는 사용자가 작동하는 SnapRAID 환경을 유지 관리하는 데 도움을 주기 위해 설계된 추가 관리 기능이 포함된 기능 완비 GUI를 만드는 것입니다. 때로는 초보자가 시작하기에 ‘포인트 앤 클릭’ 방식이 더 쉽습니다. SnapRAID의 기술 문서와 깊은 설정 가능성은 처음 사용하려는 이들에게 진입 장벽이 될 수 있습니다!

**Q**: 그래도 잘 모르겠어요, 더 볼 수 있나요?<br/>
**A**: 네, [문서](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md)를 참고해 사진 등도 확인해보세요.

**Q**: 그렇다면 "더 큰 목표"는 무엇인가요?<br/>
**A**: 아래 __로드맵__ 에서 전체 내용을 확인하세요.

## 로드맵

- [x] 1단계
  - [x] 최신 SnapRAID의 최소 지원을 유지하려고 시도합니다. - __진행 중.__
  - [x] 사용의 용이성
  - [x] SnapRAID에는 세 가지 명령이 있으니 초보자도 쉽게 접근할 수 있게 합시다
  - [x] 진행 상황 표시기
  - [x] "인터랙티브" 및 로그로 직접 기록하는 로깅
  - [x] 사용자 로그인 시 자동 시작
  - [x] 툴팁으로 안내 •	

- [x] 2단계 2단계 기능 요청
  - [x] 일시 정지, 우선순위 변경, 중단.
  - [x] 명령 확장 - "기본값에 추가 매개변수 허용."
  - [x] 스케줄링 
    - 제거됨, CommandLine을 사용하세요
  - [x] 보호된 데이터의 그래픽 보기.

- [ ] 3단계 (2017-03 이후 재시작)
  - [x] 새로운 컴파일러 및 .Net 4.7.x	
  - [x] 명령줄 인터페이스
  - [ ] Krypton Toolkit / Navigator / 등으로 새로운 레이아웃 
    - 진행 중
  - [ ] 번역 
  - [x] 새로운 명령어
  - [ ] 상태 리포트가 포함된 메일러
  - [ ] 문서 테스트 단계
    - 진행 중
  - [ ] 문서 추가 / 이미지 업데이트
    - 진행 중
  - [ ] _Windows EventLog_ 오류 보고 추가
  - [x] _ExceptionLess_를 통한 온라인 예외 보고 추가
  - [x] 복구 가능한 항목 표시 

- [ ] 4단계 (새로운 SnapRAID 명령어 ?)
  - [ ] 디스크 복구를 위한 확장 도움말 - 인터랙티브 가이드 등
  - [ ] SnapRAID 버전이 오래된 경우 사용자에게 알림
  - [ ] SnapRAID 로그 해석(아래 변경사항에 사용됨)
  - [ ] 명령 실행 후 어레이 상태 제공
  - [ ] 동기화 명령에 초기 diff 포함하도록 수정
  - [ ] diff에서 임계값 초과 문제 보고시 동기화 명령 경고 추가
  - [ ] 동기화 임계값 요구사항을 위한 사용자 설정 추가

## 스크린샷

![시작 화면](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![설정 폼](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## 도와주실 수 있나요?
- 테스터 모집 중 (모든 .Net 플랫폼)

- 번역을 도와줄 수 있음
- 도움말 / 사용자 인터페이스 안내서
- 기타 아이디어 :-)
- 아이디어를 위한 개발자


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---