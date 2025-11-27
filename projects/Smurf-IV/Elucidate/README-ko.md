# Elucidate

- [프로젝트 설명](#project-description)
- [시스템 요구사항:](#os-requirements)
- [자주 묻는 질문](#faqs)
- [로드맵](#roadmap)
- [스크린샷](#screenshots)

## Project Description

Elucidate는 명령줄 SnapRAID 애플리케이션을 위한 Windows GUI 프론트엔드입니다.

*이 프로젝트는 저와 다른 기여자들이 수행한 훌륭한 작업의 융합을 계속 이어가고 있습니다.

## System Requirements

- Windows 운영 체제
- .Net 런타임 4.8.0
- SnapRaid 버전 11.5 이하
- 대상 드라이브에 10MB 이상의 여유 공간

## FAQs

**Q**: SnapRAID란 무엇인가요?<br/>
**A**: SnapRAID는 Windows 및 Linux 운영 체제를 위한 소프트웨어 정의 스냅샷-패리티 엔진입니다. 가장 기본적인 수준에서, 파일 시스템 내 구성 파일들의 해시를 계산하고 패리티 파일에 결과를 저장하여 해당 파일 시스템의 내용을 보호합니다. 하드 드라이브가 완전히 고장난 경우, 이 패리티 파일을 사용해 손실된 데이터를 복구할 수 있습니다. 자세한 내용은 SnapRAID의 [공식 파일 보호 엔진 비교 페이지](http://snapraid.sourceforge.net/compare.html)를 참조하세요.

**Q**: 명령줄도 잘 작동하는데 왜 GUI가 필요한가요?<br/>
**A**: 더 큰 목표는 사용자가 작동하는 SnapRAID 환경을 유지하는 데 도움이 되는 추가 관리 기능을 갖춘 기능 완비 GUI를 만드는 것입니다. 때로는 ‘포인트 앤 클릭’ 방식이 초보자가 시작하기에 더 쉽습니다. SnapRAID의 기술 문서와 깊은 구성 가능성은 사용자가 시도하는 데 부담을 줄 수 있습니다!

**Q**: 아직 확신이 서지 않는데, 더 있나요?<br/>
**A**: 네, [문서](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md)를 참고하여 사진 등을 확인해 보세요.

**Q**: 그렇다면 "더 큰 목표"는 무엇인가요?<br/>
**A**: 완전한 내용을 위해 아래 __로드맵__을 참조하세요.

## Roadmap

- [x] 1단계
  - [x] 최신 SnapRAID의 최소 지원을 따라가도록 시도 - __진행 중.__
  - [x] 사용 편의성
  - [x] SnapRAID에는 세 가지 명령이 있으므로 초보자가 쉽게 접근할 수 있도록 단순화합니다.
  - [x] 진행 상태 표시기
  - [x] "인터랙티브" 및 로그로 직접 기록
  - [x] 사용자 로그인 시 자동 시작
  - [x] 안내용 툴팁 •

- [x] 2단계 2단계 기능 요청
  - [x] 일시 중지, 우선순위 변경, 중단.
  - [x] 명령 확장 - "기본값에 추가 매개변수 허용."
  - [x] 예약
    - 제거됨, 명령줄 사용
  - [x] 보호된 데이터의 그래픽 뷰.

- [ ] 3단계 (2017-03 이후 재시작)
  - [x] 새 컴파일러 및 .Net 4.7.x
  - [x] 명령줄 인터페이스
  - [ ] Krypton 툴킷 / 내비게이터 등을 통한 새 레이아웃
    - 진행 중
  - [ ] 번역
  - [x] 새 명령어
  - [ ] 상태 보고서가 포함된 메일러
  - [ ] 테스트 단계 문서화
    - 진행 중
  - [ ] 문서에 추가 / 이미지 업데이트
    - 진행 중
  - [ ] 오류에 대한 _Windows 이벤트 로그_ 보고 추가
  - [x] 예외 온라인 보고를 위한 _ExceptionLess_ 추가
  - [x] 복구 가능한 항목 표시

- [ ] 4단계 (새 SnapRAID 명령어 ?)
  - [ ] 디스크 복구가 포함된 확장 도움말 - 인터랙티브 가이드 등
  - [ ] SnapRAID 버전이 오래된 경우 사용자에게 알림
  - [ ] SnapRAID 로그 해석 (아래 변경 사항에서 사용)
  - [ ] 명령 실행 후 배열 상태 제공
  - [ ] 초기 차이 비교를 포함하도록 sync 명령 수정
  - [ ] 차이 비교 결과가 임계값을 초과하는 문제를 보고하면 경고를 표시하도록 sync 명령 수정
  - [ ] sync 임계값 요구 사항에 대한 사용자 설정 추가


## 스크린샷

![시작 화면](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![설정 폼](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## 도와주실 수 있나요? 
- 테스터 모집 (.Net 모든 플랫폼) 
- 번역 도움 
- 도움말 / 사용자 인터페이스 가이드 
- 기타 아이디어 :-) 
- 아이디어 개발자 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-27

---