# SwayAudioIdleInhibit

防止 swayidle/hypridle 在任何应用程序输出或接收音频时进入休眠。需要 systemd/elogind 抑制支持。

这仅适用于 Pulseaudio / Pipewire Pulse

## 安装

Arch：
该软件包可在 [AUR](https://aur.archlinux.org/packages/sway-audio-idle-inhibit-git/) 获取

其他：


```zsh
# Can compile to use systemd or elogind
# systemd (default)
meson setup build -Dlogind-provider=systemd
# or elogind for systemd-less systems
meson setup build -Dlogind-provider=elogind

meson compile -C build
meson install -C build
```

## Sway 使用指南

```ini
# Enables inhibit_idle when playing audio
exec sway-audio-idle-inhibit
```

## 其他不抑制空闲状态的用法

这些可用于监控是否有应用程序正在使用您的麦克风或播放
任何音频。

监控源和接收器：将打印 `RUNNING` 或 `NOT RUNNING`

```zsh
sway-audio-idle-inhibit --dry-print-both
```

监控源：将打印 `运行中` 或 `未运行`

```zsh
sway-audio-idle-inhibit --dry-print-source
```

监控接收器：将打印 `RUNNING` 或 `NOT RUNNING`

```zsh
sway-audio-idle-inhibit --dry-print-sink
```

## Waybar 集成

可以使用自定义的 waybar 模块来显示图标，当任何应用程序
正在使用你的麦克风或播放任何音频时。

将以下部分添加到你的 `~/.config/waybar/config` 文件中，并将
`custom/audio_idle_inhibitor` 添加到 `modules-left`、`modules-center`
或 `modules-right` 列表中。

*注意：下面使用的图标字体是 FontAwesome*

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