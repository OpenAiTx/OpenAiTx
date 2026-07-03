dwm.tmux
===
[dwm](http://dwm.suckless.org/)에서 영감을 받은 Tmux용 타일형 창 및 창 관리자.

![](https://raw.githubusercontent.com/saysjonathan/dwm.tmux/master/screenshot.png)

## 의존성
dwm.tmux는 tmux >= 3.2를 필요로 합니다.

## 설치
### TPM을 통한 설치 (권장)
`~/.tmux.conf`에 다음을 추가하세요:

```sh
set -g @plugin 'saysjonathan/dwm.tmux'
```

다시 로드하고 `prefix-I`를 실행하여 가져옵니다.

### 수동 설치 (레거시)
설치하려면 제공된 `Makefile`을 사용하세요:

```sh
git clone https://github.com/saysjonathan/dwm.tmux.git
cd dwm.tmux
make
```
기본적으로 `dwm.tmux`는 `/usr/local`을 접두사로 사용합니다. 접두사를 변경하려면:


```sh
make PREFIX=$HOME
```

`$PREFIX/bin`이(가) `PATH`에 포함되어 있는지 확인하세요.

사용하려면, `dwm.tmux` tmux 설정 파일을 소스하세요:

```sh
echo 'source-file /usr/local/lib/dwm.tmux' >> $HOME/.tmux.conf
```
## 사용법
`dwm.tmux`는 각각 기본 키 바인딩이 있는 다음 명령 별칭들을 정의합니다:

- `newpane` `Meta-n` 새 창을 만들고 메인 창에 배치
- `newpanecurdir` `Meta-w` 현재 디렉토리에서 새 창을 만들고 메인 창에 배치
- `killpane` `Meta-c` 현재 창을 닫음. 창이 메인 창에 있으면 창을 닫고 스택의 첫 번째 창을 메인 창으로 승격
- `movepane[0-9]` `Meta-Shift-[0-9]` 현재 창을 지정된 창으로 이동
- `nextpane` `Meta-j` 다음 창 선택(시계 방향); 모노클 모드에서 전체 화면 창 교체
- `prevpane` `Meta-k` 이전 창 선택(반시계 방향); 모노클 모드에서 전체 화면 창 교체
- `stackup` `Meta-J` 포커스된 창을 스택 위로 이동
- `stackdown` `Meta-K` 포커스된 창을 스택 아래로 이동
- `rotateccw` `Meta-<` 창을 반시계 방향으로 회전
- `rotatecw` `Meta->` 창을 시계 방향으로 회전
- `tile` `Meta-t` 타일 레이아웃으로 복귀, 모노클 모드 종료
- `monocle` `Meta-Space` 모노클 모드 토글(현재 창 전체 화면)
- `zoom` `Meta-Enter` 선택한 창을 메인 창에 배치
- `decmfact` `Meta-h` 메인 창 공간 계수 감소
- `incmfact` `Meta-l` 메인 창 공간 계수 증가
- `window[0-9]` `Meta-[0-9]` ID로 대상 창 선택
- `newwindow` `Meta-N` 현재 창과 동일한 디렉토리에서 새 창 생성
- `killwindow` `Meta-X` 현재 활성 창 삭제
- `popup` `Meta-p` 현재 창 디렉토리에서 플로팅 창 팝업 표시
- `incpfact` `Meta-.` 스택 내 포커스된 창 크기 증가 (다른 창 대비)
- `decpfact` `Meta-,` 스택 내 포커스된 창 크기 감소 (다른 창 대비)
- `resetpfact` `Meta-=` 포커스된 창의 pfact 초기화

창 순환을 위한 추가 키 바인딩도 포함되어 있습니다:
- `Meta-[` 이전 창
- `Meta-]` 다음 창

동작을 조절하기 위한 전역 옵션도 정의되어 있습니다:

- `mfact` 메인 창 공간 계수, 전체 창 크기에 대한 메인 창 크기 비율(%)
- `killlast` 값이 `0`보다 크면, 창이 마지막 창이어도 종료
- `monocle` 활성 레이아웃 모드 추적; 0은 타일, 1은 모노클. 자동 설정되며 현재 상태 확인용으로 읽기 가능
- `pfact` 창별 스택 크기 계수, 1-9 범위, 기본 5. 값이 높을수록 스택 내 창의 상대적 높이 증가

### 커스터마이징
키 바인딩과 기본값은 구성 파일에서 설정할 수 있습니다. TPM 사용 시, 이들은 `~/.tmux.conf`의 `run '~/.tmux/plugins/tpm/tpm'` 라인 뒤에 설정해야 합니다.


예시:

```
setenv -g killlast 1 # kill pane even if it's the last
set-option -wg @mfact 60
set-option -wg @pfact 4
bind -n M-q killpane
bind -n M-w newpanecurdir
```

## 세부 사항

dwm과 유사하게, 창은 항상 다음과 같이 정리됩니다:

```
 ====================================
|                 |        S1        |
|                 |==================
|      M(0)       |        S2        |
|                 |==================
|                 |        S3        |
 ====================================
```
큰 메인 창은 화면 왼쪽에 배치되고, 작은 창들이 쌓여 있는 스택은 오른쪽에 배치됩니다. 메인 창은 항상 창 0이며, 스택에 쌓인 창들은 오름차순으로 순차적으로 번호가 매겨집니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---