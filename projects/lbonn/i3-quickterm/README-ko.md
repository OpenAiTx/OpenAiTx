# i3-quickterm

[![Packaging status](https://repology.org/badge/vertical-allrepos/python:i3-quickterm.svg)](https://repology.org/project/python:i3-quickterm/versions)

[i3wm](https://i3wm.org/) 및 [sway](https://swaywm.org/)용 작은 드롭다운 터미널

## 기능

* 좋아하는 터미널 에뮬레이터 사용 가능
* [dmenu](http://tools.suckless.org/dmenu/) / [rofi](https://github.com/DaveDavenport/rofi)로 셸 선택 가능
* 화면 너비에 맞게 조정
* 다중 모니터 지원

## 설치

pip을 통해:

```
pip install i3-quickterm
```
또는 위의 repology 배지를 확인하여 해당 배포판에서 패키지화되었는지 확인하세요.

## 사용법

실행하면 현재 화면에 quickterm이 있으면 최소화됩니다. 그렇지 않으면 열 셸을 사용자에게 묻거나 인수로 전달된 셸을 사용합니다.

요청한 셸이 이미 다른 화면에 열려 있으면 현재 화면으로 이동됩니다.

i3 바인딩에 매핑하는 것이 권장됩니다:


```
# with prompt
bindsym $mod+p exec i3-quickterm
# always bring up standard shell, without the menu
bindsym $mod+b exec i3-quickterm shell
```
## 구성

구성은 `~/.config/i3-quickterm/config.json` 또는 `~/.config/i3/i3-quickterm.json`에서 읽습니다.

* `menu`: 셸 선택에 사용되는 dmenu 호환 애플리케이션
* `term`: 선택한 터미널 에뮬레이터
* `history`: 마지막으로 사용된 셸 순서를 저장하는 파일, null로 설정하면 마지막 사용 순서 저장이 비활성화됩니다
* `width`: 화면 너비의 사용 비율
* `height`: 화면 높이의 사용 비율
* `pos`: 터미널을 표시할 위치 (`top` 또는 `bottom`)
* `shells`: 등록된 셸 (`{ name: command }`)

`term`은 다음 중 하나일 수 있습니다:
- [지원되는 목록](#supported-terminals)의 터미널 이름.
- 위 목록에서 첫 번째로 존재하는 터미널을 자동 선택하는 `auto` (친근한 기본값 제공용이며, 그 외에는 권장하지 않음)
- 형식 문자열, 예를 들어: `urxvt -t {title} -e {expanded}`와 같이 터미널에 맞는 올바른 인수 형식. xfce4-terminal과 같은 일부 터미널은 명령 인수를 문자열로 전달해야 합니다. 이 경우 `{expanded}`를 `{string}`으로 대체하세요.

`menu`, `term`, `history` 및 `shell`에는 환경 변수용 자리 표시자 `{$var}`를 포함할 수 있습니다.

명시되지 않은 키는 기본값에서 상속됩니다:


```
{
    "menu": "rofi -dmenu -p 'quickterm: ' -no-custom -auto-select",
    "term": "auto",
    "history": "{$HOME}/.cache/i3-quickterm/shells.order",
    "width": 1.0,
    "height": 0.25,
    "pos": "top",
    "shells": {
        "js": "node",
        "python": "ipython3 --no-banner",
        "shell": "{$SHELL}"
    }
}
```
## 지원 터미널

* alacritty
* foot
* gnome-terminal
* kitty
* roxterm
* st
* terminator
* termite
* urxvt
* urxvtc
* xfce4-terminal
* xterm

다른 터미널을 추가하거나 오류를 수정하고 싶다면, 풀 리퀘스트를 열어주세요.

## 요구 사항

* python >= 3.8
* i3 >= v3.11 또는 sway >= 1.2
* [i3ipc-python](https://i3ipc-python.readthedocs.io/en/latest/) >= v2.0.1
* dmenu 또는 rofi (선택 사항)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---