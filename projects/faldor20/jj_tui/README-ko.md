# Jujutsu TUI
[![nix](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml/badge.svg)](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml)

Jujutsu 버전 관리 시스템을 위한 TUI  
우리의 초점은 다음과 같습니다:  
- **성능**: jj_tui는 빠르게 시작하고 절대 느려지지 않아야 하며, 커밋과 파일을 탐색할 때 매우 빠르게 느껴져야 합니다  
- **직관성**: 키 바인딩은 쉽게 암기할 수 있어야 하며 불필요한 팝업 없이 빠르게 근육 기억으로 자리잡아야 합니다  
- **상호작용성**: jj_tui는 jj의 렌더러를 완전히 재구현하여 리베이스가 어떻게 보여야 할지 파악하는 동안 그래프의 실시간 미리보기를 표시할 수 있습니다 (시도하려면 `r`ebase `p`review 사용!)

![jj_tui-ezgif com-optimize](https://github.com/faldor20/jj_tui/assets/26968035/fb053320-484a-4d6f-9b66-e5b9d0d49e5d)


도움말 표시: `?` (그래프와 파일 뷰에서 명령어가 다릅니다).  
창/항목 탐색: `화살표` 또는 `hjkl`  
수정 선택/해제: `Space` (그래프 뷰에서 다중 선택 가능)  
diff 확대 및 스크롤: `Enter`  

## 주요 기능

### 일반 jj 작업  
- `c`커밋  
- `r`리베이스  
- `g`git 푸시 및 풀  
- `b`북마크 추가, 이동 및 삭제  
- 커밋 `s`스쿼시 및 `s`분할  
- `space`는 복사, 리베이스 등 여러 커밋 선택, 위에 새 커밋 시작 등에 사용 가능  

### 파일 뷰에서 커밋 생성:  
- 파일을 별도로 `c`커밋하거나 다른 커밋으로 `m`이동할 때 `space` 선택 가능  
- 파일은 다음(`N`) 또는 이전(`P`) 커밋으로 전송 가능  

### revsets 필터링  
- 원하는 모든 revset으로 `f`필터링 가능  

그래프 명령어 목록:

![jj_tui commands](https://github.com/user-attachments/assets/1e446a3d-1736-4207-b311-29d8e4bdc333)

## 설치  
`linux`: 최신 릴리스를 받아 사용하세요. 정적으로 링크되어 있어 모든 리눅스 머신에서 작동합니다.
`mac`: 미리 빌드된 버전을 받으세요. 제가 mac에서 테스트할 수 없기 때문에 문제가 있으면 알려주세요.

nix에서 jj_tui로 셸을 열려면: `nix shell github:faldor20/jj_tui`

## Dependencies
jujutsu CLI (최소 버전 0.30.0)
윈도우나 Mac에서는 테스트하지 않았습니다.
유닉스 외부에서는 작동하지 않을 것으로 생각되므로 윈도우 사용자는 현재 wsl을 사용해야 합니다.


# Config file:
키 입력을 사용자 지정하려면 다음 디렉터리에 `config.yaml` 설정 파일을 만들 수 있습니다.
`linux`: $XDG_CONFIG_HOME/jj_tui/
`macos`: ~/Library/preferences/jj_tui/
키맵 사양은 `./jj_tui/lib/key_map.ml`을, 설정은 `./jj_tui/lib/config.ml`을 참고하세요.
키맵 설정을 통해 모든 명령과 하위 메뉴를 완전히 사용자 지정하고 방향키도 재매핑할 수 있습니다.

예:
``` yaml
key_map:
  remap:
   h: "left"
   j: "down"
   k: "up"
   l: "right"
  graph:
    #Simple mapping from key to command_id
    p: prev
    #Command sub menu
    s:
      title: "Squash"
      sub:
        # sub menu command
        s: "squash_into_parent"
# If the terminal is smaller than this width, the UI will change to a single pane view
single_pane_width_threshold: 110
# Sets the limit to how many commits are ever rendered in jj_tui. Usefull for not slowing down too much when viewing 'all()' revest.
max_commits: 100
```
전체 명령 ID 목록은 [`jj_tui/bin/graph_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/graph_commands.ml) 및 [`jj_tui/bin/file_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/file_commands.ml)에서 확인하세요.

# 로그:
`linux`: $XDG_STATE_HOME/jj_tui/
`macos`: ~/Library/logs/jj_tui/

# 개발
`nix build`로 빌드하거나 `nix develop`로 nix 셸을 열 수 있습니다.
참고: nix 개발 셸을 사용 중이고 dune로 빌드하려면 nix가 제공하는 종속성을 사용하여 빌드하려면 `dune build --pkg disabled`를 사용하세요.
`dune build`를 통해 Dune 패키지 관리로 직접 빌드할 수도 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---