<h1 align="center">
  <br>
  OpenSuperClone
  <br>
</h1>

<div align="center">

  [![Commits](https://badgen.net/github/commits/ispillmydrink/opensuperclone/main)](https://github.com/ISpillMyDrink/OpenSuperClone/commits/main)
  [![Last Commit](https://badgen.net/github/last-commit/ispillmydrink/opensuperclone/main)](https://github.com/ISpillMyDrink/OpenSuperClone/commits/main)
  [![Release](https://badgen.net/github/release/ispillmydrink/opensuperclone)](https://github.com/ISpillMyDrink/OpenSuperClone/releases)
  [![License](https://badgen.net/github/license/ispillmydrink/opensuperclone)](https://github.com/ISpillMyDrink/OpenSuperClone/blob/main/LICENSE)
  
</div>

<h4 align="center">
  <a href="https://www.hddsuperclone.com/">Scott Dwyer의 HDDSuperClone</a>를 기반으로 한 많은 고급 기능을 갖춘 리눅스용 강력한 데이터 복구 유틸리티입니다.
</h4>

<p align="center">
  <a href="#-features">✨ 기능</a> •
  <a href="#-installation">💾 설치</a> •
  <a href="#-documentation">📖 문서</a> •
  <a href="#%EF%B8%8F-changelog">✏️ 변경 로그</a> •
  <a href="#-credits">💵 크레딧</a> •
  <a href="#-license">📄 라이선스</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/ISpillMyDrink/OpenSuperClone/main/./doc/opensuperclone.gif" alt="Size Limit CLI" width="738">
</p>

## ✨ 기능

* ddrescue와 유사한 고급 드라이브 <a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Clone-Mode">복제</a> 기능
* 대상 데이터 추출을 위한 <a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Virtual-Disk-Mode">가상 디스크 모드</a>
* OS 드라이버를 우회하는 <a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Direct-Modes">직접 AHCI/IDE</a> 기능
* 드라이브 자동 전원 사이클링을 위한 <a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Relay-Operation">USB 릴레이 제어</a>

#### 📋 계획된 변경사항

계획된 변경사항 목록은 <a href="https://github.com/users/ISpillMyDrink/projects/2">로드맵</a>을 참조하세요.

## 💾 설치

OpenSuperClone의 사전 빌드된 DEB 및 RPM 패키지는 <a href=https://github.com/ISpillMyDrink/OpenSuperClone/releases>릴리스</a> 페이지에서 찾을 수 있습니다.

소스에서 OpenSuperClone을 설치하는 방법은 <a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Compiling-from-Source">위키</a>에서 확인할 수 있습니다.

OpenSuperClone 설치 대신에, <a href="https://sourceforge.net/projects/opensuperclone-live/">Linux 라이브 ISO</a>가 이제 <a href="https://sourceforge.net/u/xak77/profile/">xak77</a>에 의해 제공됩니다.

## 📖 문서

OpenSuperClone 문서는 <a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki">위키</a>에서 찾을 수 있습니다.
현재 위키는 작업 중이며 완성되지 않았음을 참고하세요.

## ✏️ 변경 로그

#### OpenSuperClone 2.5.1 (작업 진행 중)

* OSCDriver 2.6.7: 커널 6.14.0까지 지원 추가 (기여: <a href="https://github.com/ISpillMyDrink/OpenSuperClone/pull/25">piernov</a>)

#### OpenSuperClone 2.5

* 드라이버 설치용 DKMS 구현
* OSCDriver 2.6.6: 커널 6.11.0까지 지원 추가 (기여: <a href="https://github.com/ISpillMyDrink/OpenSuperClone/pull/19">piernov</a>)
* USB 대용량 저장 장치 드라이버 비활성화 시 USB 연결 SCSI 드라이버도 비활성화됨
* 대부분의 컨트롤에 툴팁 추가 및 SMART, 분석, 식별 보기 개선 등 다양한 UI 향상
* 더 많은 알려진 SMART 속성과 식별 플래그 추가
* 재시도 횟수를 최대 8회에서 1000회로 증가 (솔리드 스테이트 복구에 유용)

#### OpenSuperClone 2.4.1

* UI 레이블에 잘못된 문자열이 표시되는 버그 수정

#### OpenSuperClone 2.4

* 라이선스 관련 코드 제거
* 빌드 시스템으로 CMake 도입
* GTK2에서 GTK3로 전환
* 지역화 시스템을 gettext로 교체
* OSCDriver 2.6.1: 커널 5.19.11까지 지원 추가 (기여: <a href="https://github.com/piernov/">piernov</a>)
* OSCViewer의 사소한 개선 (색상 선택기, 그래픽 변경)

## 💵 크레딧

이 프로젝트는 <a href="https://www.hddsuperclone.com/">HDDSuperClone</a>의 훌륭한 작업을 한 Scott Dwyer에게,
그리고 커널 모듈 업데이트 작업을 한 <a href="https://github.com/piernov/">piernov</a>에게 크레딧을 돌립니다.

이 프로젝트는 다음 라이브러리/프로그램을 사용합니다:
* GLADE (https://glade.gnome.org/)
* GTK (https://www.gtk.org/)
* libconfig (https://hyperrealm.github.io/libconfig/)
* libintl (https://www.gnu.org/software/gettext/)
* libusb (https://libusb.info/)
* Font Awesome (https://fontawesome.com/)

## 📄 라이선스

이 소프트웨어는 [GPLv2](LICENSE) 라이선스 하에 배포됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---