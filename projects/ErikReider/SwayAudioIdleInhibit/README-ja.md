# SwayAudioIdleInhibit

任意のアプリケーションが音声を出力または受信している間、swayidle/hypridleがスリープするのを防ぎます。systemd/elogindのinhibitサポートが必要です。

これはPulseaudio / Pipewire Pulseのみで動作します。

## インストール

Arch:
パッケージは[AUR](https://aur.archlinux.org/packages/sway-audio-idle-inhibit-git/)で入手可能です。

その他:


```zsh
# Can compile to use systemd or elogind
# systemd (default)
meson setup build -Dlogind-provider=systemd
# or elogind for systemd-less systems
meson setup build -Dlogind-provider=elogind

meson compile -C build
meson install -C build
```

## Swayの使用法

```ini
# Enables inhibit_idle when playing audio
exec sway-audio-idle-inhibit
```

## アイドルを妨げずに他の用途で使用する

これらは、アプリケーションがマイクを使用しているか、または音声を再生しているかを監視するために使用できます。

ソースとシンクを監視する：`RUNNING` または `NOT RUNNING` と表示します


```zsh
sway-audio-idle-inhibit --dry-print-both
```

監視ソース：`RUNNING` または `NOT RUNNING` を表示します。

```zsh
sway-audio-idle-inhibit --dry-print-source
```

モニターシンク：`RUNNING` または `NOT RUNNING` を表示します。

```zsh
sway-audio-idle-inhibit --dry-print-sink
```

## Waybar 統合

カスタム Waybar モジュールを使用して、任意のアプリケーションが
マイクを使用しているか、音声を再生している場合にアイコンを表示できます。

次のセクションを `~/.config/waybar/config` ファイルに追加し、
`custom/audio_idle_inhibitor` を `modules-left`、`modules-center`、
または `modules-right` のいずれかのリストに追加してください。

*注: 以下のアイコンには FontAwesome フォントが使用されています*

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