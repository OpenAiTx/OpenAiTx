# SwayAudioIdleInhibit

어떤 애플리케이션이 오디오를 출력하거나 수신하는 동안 swayidle/hypridle이 절전 모드로 전환되는 것을 방지합니다. systemd/elogind의 inhibit 지원이 필요합니다.

이 기능은 Pulseaudio / Pipewire Pulse에만 적용됩니다.

## 설치

Arch:
패키지는 [AUR](https://aur.archlinux.org/packages/sway-audio-idle-inhibit-git/)에서 사용할 수 있습니다.

기타:


```zsh
# Can compile to use systemd or elogind
# systemd (default)
meson setup build -Dlogind-provider=systemd
# or elogind for systemd-less systems
meson setup build -Dlogind-provider=elogind

meson compile -C build
meson install -C build
```

## Sway 사용법

```ini
# Enables inhibit_idle when playing audio
exec sway-audio-idle-inhibit
```
## 유휴 상태를 방해하지 않는 기타 용도

이들은 어떤 애플리케이션이 마이크를 사용하거나 오디오를 재생하는지 모니터링하는 데 사용할 수 있습니다.

소스 및 싱크 모니터링: `RUNNING` 또는 `NOT RUNNING`을 출력합니다.



```zsh
sway-audio-idle-inhibit --dry-print-both
```
모니터 소스: `RUNNING` 또는 `NOT RUNNING`을 출력합니다


```zsh
sway-audio-idle-inhibit --dry-print-source
```

모니터 싱크: `RUNNING` 또는 `NOT RUNNING`을 출력합니다.

```zsh
sway-audio-idle-inhibit --dry-print-sink
```
## Waybar 통합

사용자가 마이크를 사용하거나 오디오를 재생 중일 때 아이콘을 표시하기 위해 맞춤 waybar 모듈을 사용할 수 있습니다.

다음 섹션을 `~/.config/waybar/config` 파일에 추가하고
`custom/audio_idle_inhibitor`를 `modules-left`, `modules-center`
또는 `modules-right` 목록에 추가하세요.

*참고: 아래 아이콘에는 FontAwesome 폰트가 사용됩니다*



```json
	"custom/audio_idle_inhibitor": {
		"format": "{icon}",
		"exec": "sway-audio-idle-inhibit --dry-print-both-waybar",
		"exec-if": "which sway-audio-idle-inhibit",
		"return-type": "json",
		"format-icons": {
			"output": "",
			"input": "",
			"output-input": "  ",
			"none": ""
		}
	},
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-28

---