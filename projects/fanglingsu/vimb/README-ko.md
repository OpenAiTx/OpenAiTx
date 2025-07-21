<translate-content># Vimb - Vim과 유사한 브라우저

[![Build Status](https://travis-ci.com/fanglingsu/vimb.svg?branch=master)](https://travis-ci.com/fanglingsu/vimb)
[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![Latest Release](https://img.shields.io/github/release/fanglingsu/vimb.svg?style=flat)](https://github.com/fanglingsu/vimb/releases/latest)

Vimb는 Pentadactyl과 Vimprobable에서 영감을 받은 Vim과 유사한 웹 브라우저입니다.
Vimb의 목표는 완전히 키보드 중심적이고 효율적이며
메모리와 CPU 사용량이 적은 쾌적한 브라우징 경험을 제공하는 것으로,
Vim 사용자에게 직관적으로 사용 가능하도록 하는 것입니다.

더 많은 정보와 Vimb 브라우저의 실행 화면은
[Vimb][] 프로젝트 페이지에서 확인할 수 있습니다.

## 기능

- Vim처럼 모달 방식
- 각 브라우저 모드별로 할당 가능한 Vim 스타일 키 바인딩
- 거의 모든 설정을 Vim의 set 문법으로 런타임에 변경 가능
- `ex` 명령, 검색 쿼리, URL의 히스토리
- 명령, URL, 북마크된 URL, 설정 변수명, 검색 쿼리에 대한 완성 기능
- 힌팅 - 링크, 폼 필드 및 다른 클릭 가능한 요소에 마크를 표시하여
  클릭, 열기 또는 검사 가능
- ca-인증서 파일을 통한 SSL 검증
- 자리 표시자가 포함된 사용자 정의 URL 단축키
- 나중에 읽기용 URI 수집 큐
- 다중 얀크/붙여넣기 레지스터
- Vim과 유사한 autocmd - 특정 URI에서 이벤트 후 자동으로 명령 실행

## 패키지

- Arch Linux: [extra/vimb][], [aur/vimb-git][], [aur/vimb-gtk2][]
- Fedora: [fedora/vimb][],
- Gentoo: [tharvik overlay][], [jjakob overlay][]
- openSUSE: [network/vimb][]
- pkgsrc: [pkgsrc/www/vimb][], [pkgsrc/wip/vimb-git][]
- Slackware: [slackbuild/vimb][]

## 의존성

- gtk+-3.0
- webkit2gtk-4.1
- gst-libav, gst-plugins-good (선택 사항, 미디어 디코딩 등용)

## 설치

`config.mk`를 로컬 설정에 맞게 수정하세요. 
tcc 같은 다른 컴파일러를 사용하는 경우 이 작업이 필요할 수 있습니다. 
하지만 대부분의 사용자는 Ubuntu나 Debian 같은 시스템에서는 거의 필요하지 않습니다.

`src/config.h`를 개인 취향에 맞게 수정하세요, 예를 들어
로딩 바에 사용되는 문자나 폰트를 변경하는 식으로요.

기본 `Makefile`은 최신 git pull로 업데이트되어도
사용자 맞춤 `config.h`를 `config.def.h` 내용으로 덮어쓰지 않습니다.
따라서, 항상 맞춤 `config.h`와 `config.def.h`를 비교하여
후자의 변경사항을 `config.h`에 반영해야 합니다.

다음 명령으로 Vimb를 컴파일하고 설치하세요 (필요 시 마지막 명령은 root 권한으로).
`PREFIX`를 변경하려면 빌드와 설치 두 단계 모두에서 지정해야 합니다.

    make PREFIX=/usr
    make PREFIX=/usr install

설치 없이 vimb를 실행하여 테스트하려면 'runsandbox' make 타겟을 사용하세요.

    make runsandbox

## 메일링 리스트

- 기능 요청, 이슈 및 패치는 [메일링 리스트][mail]에서 논의할 수 있습니다 ([리스트 아카이브][mail-archive])

## 유사 프로젝트

- [luakit](https://luakit.github.io/)
- [qutebrowser](https://www.qutebrowser.org/)
- [surf](https://surf.suckless.org/)
- [uzbl](https://www.uzbl.org/)
- [wyeb](https://github.com/jun7/wyeb)

## 라이선스

라이선스 정보는 LICENSE 파일에서 확인할 수 있습니다.

## 정보

- https://en.wikipedia.org/wiki/Vimb
- http://thedarnedestthing.com/vimb
- https://blog.jeaye.com/2015/08/23/vimb/

[aur/vimb-git]:        https://aur.archlinux.org/packages/vimb-git
[aur/vimb-gtk2]:       https://aur.archlinux.org/packages/vimb-gtk2/
[extra/vimb]:          https://www.archlinux.org/packages/extra/x86_64/vimb/
[fedora/vimb]:         https://src.fedoraproject.org/rpms/vimb
[tharvik overlay]:     https://github.com/tharvik/overlay/tree/master/www-client/vimb
[jjakob overlay]:      https://github.com/jjakob/gentoo-overlay/tree/master/www-client/vimb
[mail-archive]:        https://sourceforge.net/p/vimb/vimb/vimb-users/ "vimb - mailing list archive"
[mail]:                https://lists.sourceforge.net/lists/listinfo/vimb-users "vimb - mailing list"</translate-content>


[network/vimb]:        https://build.opensuse.org/package/show/network/vimb
[pkgsrc/wip/vimb-git]: http://pkgsrc.se/wip/vimb-git
[pkgsrc/www/vimb]:     http://pkgsrc.se/www/vimb
[slackbuild/vimb]:     https://slackbuilds.org/repository/14.2/network/vimb/
[vimb]:                https://fanglingsu.github.io/vimb/ "Vimb - Vim과 유사한 브라우저 프로젝트 페이지"


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---