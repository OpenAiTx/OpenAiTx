# SwayAudioIdleInhibit

Evita que swayidle/hypridle entre en suspensión mientras cualquier aplicación esté reproduciendo o
recibiendo audio. Requiere soporte de inhibición de systemd/elogind.

Esto solo funciona para Pulseaudio / Pipewire Pulse

## Instalación

Arch:
El paquete está disponible en el [AUR](https://aur.archlinux.org/packages/sway-audio-idle-inhibit-git/)

Otros:

```zsh
# Can compile to use systemd or elogind
# systemd (default)
meson setup build -Dlogind-provider=systemd
# or elogind for systemd-less systems
meson setup build -Dlogind-provider=elogind

meson compile -C build
meson install -C build
```

## Uso de Sway

```ini
# Enables inhibit_idle when playing audio
exec sway-audio-idle-inhibit
```

## Otros usos sin inhibir el modo inactivo

Estos podrían usarse para monitorear si alguna aplicación está usando tu micrófono o reproduciendo
algún audio.

Monitorear fuentes y sumideros: imprimirá `RUNNING` o `NOT RUNNING`

```zsh
sway-audio-idle-inhibit --dry-print-both
```

Fuentes de monitor: mostrará `RUNNING` o `NOT RUNNING`

```zsh
sway-audio-idle-inhibit --dry-print-source
```

Monitor de sinks: imprimirá `RUNNING` o `NOT RUNNING`

```zsh
sway-audio-idle-inhibit --dry-print-sink
```

## Integración de Waybar

Se puede usar un módulo personalizado de waybar para mostrar un icono cuando alguna aplicación está
usando tu micrófono o reproduciendo algún audio.

Agrega la siguiente sección a tu archivo `~/.config/waybar/config` y añade
`custom/audio_idle_inhibitor` a la lista de `modules-left`, `modules-center`
o `modules-right`.

*Nota: La fuente FontAwesome se utiliza para los íconos a continuación*

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