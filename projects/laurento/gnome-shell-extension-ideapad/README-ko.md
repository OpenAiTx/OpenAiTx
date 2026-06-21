# gnome-shell-extension-ideapad
Lenovo IdeaPad를 위한 GNOME Shell 기능

*현재 이 확장 기능은 Lenovo IdeaPad 노트북에서 제공되는 배터리 절약 모드를 쉽게 전환할 수 있는 사용자 친화적인 방법과 현재 상태를 시각적으로 표시하는 기능만 제공합니다.*

# 설치
[공식 GNOME 확장 웹사이트](https://extensions.gnome.org/extension/2992/ideapad/)에서 확장 기능을 간단히 설치하세요(권장). 또는 저장소를 수동으로 다운로드하거나 클론하여 `~/.local/share/gnome-shell/extensions/ideapad@laurento.frittella` 아래에 위치시킬 수 있습니다.

두 경우 모두 몇 가지 추가 단계가 필요합니다. 전용 섹션을 확인해 주세요.

코드를 직접 보고 싶다면, `master` 브랜치는 최신 안정 버전의 GNOME Shell을 대상으로 합니다. 이전 버전은 전용 브랜치(e.g. `pre-43`)에서 여전히 지원됩니다.

# 사용법
확장 기능은 패널에 *절약 모드 전환(Toggle Conservation Mode)* 새 항목을 추가하고, 배터리 절약 모드가 활성화되었을 때 상태 메뉴에 아이콘을 표시합니다.

특정 노트북 모델이 지원하는 경우, 절약 모드는 배터리 충전을 용량의 55-60%로 제한하여 배터리 수명을 향상시킵니다. 노트북이 대부분 외부 전원으로 작동할 때 특히 유용합니다.

| GNOME Shell < 43    | GNOME Shell >= 43      |
|---------------------|------------------------|
| ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot.png) | ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot-43.png) |

# 추가 필수 설정
데스크탑 사용자는 일반적으로 루트 사용자 소유인 특정 sysfs 파일에 읽기-쓰기 권한이 필요합니다. 가장 쉬운 방법은 `sudo`를 사용하는 것입니다. 다음 단계는 Debian에서 테스트되었지만, 현대 GNU/Linux 시스템에서는 모두 작동해야 합니다. 의심스러운 경우 배포판 문서를 참조하세요.

* 배포판에 따라 `sudo` 그룹(e.g. Debian 및 Ubuntu) 또는 `wheel` 그룹(e.g. Arch 및 Fedora)을 사용해야 합니다. 의심될 경우 터미널에서 `groups` 명령을 실행하여 두 그룹 중 어떤 것이 나오는지 확인하세요.

  시스템 sudoers 구성(e.g. `/etc/sudoers.d/ideapad`)에 다음 항목을 추가하세요. **필요 시 `%sudo`를 `%wheel`로 바꾸는 것을 잊지 마세요.**
  ~~~
  %sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode
  ~~~

* `ideapad_laptop` 커널 모듈이 부팅 시 자동으로 로드되도록 하려면, `/etc/modules` 파일에 해당 모듈을 추가하세요.

요약 및 참고용으로...
~~~
# 필요 시 %sudo를 %wheel로 바꾸는 것을 잊지 마세요!
#
$ echo "%sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode" | sudo tee /etc/sudoers.d/ideapad
$ echo "ideapad_laptop" | sudo tee -a /etc/modules
~~~
# 잘못된 배터리 추정 표시
사용 중인 커널 버전에 따라 사소한 미관상의 문제가 여전히 존재할 수 있습니다. 그러나 GNOME에서 영구적으로 "추정 중..." 배터리 상태가 표시되어 불편하다면 해결책도 있습니다.

사실 이 문제는 커널 5.19 이상에서 수정되어야 합니다. 구버전 커널을 사용 중이라면 [여기 패치](https://git.kernel.org/pub/scm/linux/kernel/git/torvalds/linux.git/commit/?id=185d20694a8aceb4eda9fc1314cbaad0df0aab07)를 적용해 볼 수 있습니다. 이 점을 알려준 Martino Fontana에게 감사드립니다.

또는 제가 처음 제안한 [이 uPower 병합 요청](https://gitlab.freedesktop.org/upower/upower/-/merge_requests/46)에 있는 패치를 사용할 수도 있습니다. 하지만 개인적으로는 커널 패치를 권장합니다. 훨씬 깔끔한 해결책이기 때문입니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---