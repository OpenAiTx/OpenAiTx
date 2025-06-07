<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">문서</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">채팅</a>
</h1>

[![Coverity Scan 분석](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![패키지](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![다운로드](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim은 [Vim](https://www.vim.org/)을 적극적으로 리팩토링하여 다음을 목표로 하는 프로젝트입니다:

- 유지보수를 단순화하고 [기여](CONTRIBUTING.md)를 장려
- 여러 개발자 간에 작업 분산
- 코어 수정 없이 [고급 UI] 지원
- [확장성](https://neovim.io/doc/user/ui.html) 극대화

더 많은 정보는 [소개](https://github.com/neovim/neovim/wiki/Introduction) 위키 페이지와 [로드맵]을 참고하세요.

기능
--------

- 현대적인 [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin, JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust 등 어떤 언어로든 [API 접근](https://github.com/neovim/neovim/wiki/Related-projects#api-clients) 가능
- 내장형, 스크립트화 가능한 [터미널 에뮬레이터](https://neovim.io/doc/user/terminal.html)
- 비동기 [작업 제어](https://github.com/neovim/neovim/pull/2247)
- 여러 에디터 인스턴스 간의 [공유 데이터 (shada)](https://github.com/neovim/neovim/pull/2506)
- [XDG 기본 디렉터리](https://github.com/neovim/neovim/pull/3470) 지원
- Ruby 및 Python 플러그인을 포함한 대부분의 Vim 플러그인과 호환

전체 목록은 [`:help nvim-features`][nvim-features]를 참고하고, 최신 버전의 주요 변경 사항은 [`:help news`][nvim-news]를 참고하세요!

패키지로 설치
--------------------

Windows, macOS, Linux용 빌드된 패키지는
[릴리즈 페이지](https://github.com/neovim/neovim/releases/)에서 확인할 수 있습니다.

[관리형 패키지]는 [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] 등에서 제공됩니다!

소스에서 설치
-------------------

자세한 내용은 [BUILD.md](./BUILD.md)와 [지원 플랫폼](https://neovim.io/doc/user/support.html#supported-platforms)을 참고하세요.

빌드는 CMake 기반이지만, 편의를 위해 Makefile도 제공됩니다.
의존성을 설치한 후, 아래 명령어를 실행하세요.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

기본이 아닌 경로에 설치하려면:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

빌드 점검을 위한 CMake 팁:

- `cmake --build build --target help` 는 모든 빌드 타겟을 나열합니다.
- `build/CMakeCache.txt` (또는 `cmake -LAH build/`)에는 모든 CMake 변수의 해석된 값이 포함되어 있습니다.
- `build/compile_commands.json`은 각 번역 단위별 전체 컴파일러 호출 정보를 보여줍니다.

Vim에서 전환
--------------------

설명은 [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim)을 참고하세요.

프로젝트 구조
--------------

    ├─ cmake/           CMake 유틸리티
    ├─ cmake.config/    CMake 정의
    ├─ cmake.deps/      서브프로젝트(의존성 다운로드 및 빌드, 선택적)
    ├─ runtime/         플러그인 및 문서
    ├─ src/nvim/        애플리케이션 소스 코드 (src/nvim/README.md 참고)
    │  ├─ api/          API 서브시스템
    │  ├─ eval/         Vimscript 서브시스템
    │  ├─ event/        이벤트 루프 서브시스템
    │  ├─ generators/   코드 생성(사전 컴파일)
    │  ├─ lib/          일반 데이터 구조
    │  ├─ lua/          Lua 서브시스템
    │  ├─ msgpack_rpc/  RPC 서브시스템
    │  ├─ os/           저수준 플랫폼 코드
    │  └─ tui/          내장 UI
    └─ test/            테스트 (test/README.md 참고)

라이선스
-------

[b17d96][license-commit] 이후 Neovim 기여분은
Apache 2.0 라이선스 하에 배포됩니다. Vim에서 복사된 기여분(`vim-patch` 토큰으로 표시됨)은 예외입니다. 자세한 내용은 LICENSE를 참고하세요.

    Vim은 Charityware입니다.  자유롭게 사용 및 복사할 수 있지만,
    우간다의 도움이 필요한 아이들을 위해 기부를 권장합니다. 자세한 내용은
    Vim 문서의 kcc 섹션이나 아래 웹사이트를 참고하세요:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    또한 Vim 개발을 후원할 수 있습니다. Vim 후원자는 기능에 투표할 수 있으며,
    모금된 금액은 모두 우간다로 전달됩니다.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Managed packages]: ./INSTALL.md#install-from-package
[Debian]: https://packages.debian.org/testing/neovim
[Ubuntu]: https://packages.ubuntu.com/search?keywords=neovim
[Fedora]: https://packages.fedoraproject.org/pkgs/neovim/neovim/
[Arch Linux]: https://www.archlinux.org/packages/?q=neovim
[Void Linux]: https://voidlinux.org/packages/?arch=x86_64&q=neovim
[Gentoo]: https://packages.gentoo.org/packages/app-editors/neovim
[Homebrew]: https://formulae.brew.sh/formula/neovim

<!-- vim: set tw=80: -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---