# SwayAudioIdleInhibit

Empêche swayidle/hypridle de passer en veille tant qu'une application émet ou
reçoit de l'audio. Nécessite le support de l'inhibition systemd/elogind.

Cela fonctionne uniquement avec Pulseaudio / Pipewire Pulse

## Installation

Arch :  
Le paquet est disponible sur le [AUR](https://aur.archlinux.org/packages/sway-audio-idle-inhibit-git/)

Autres :

```zsh
# Can compile to use systemd or elogind
# systemd (default)
meson setup build -Dlogind-provider=systemd
# or elogind for systemd-less systems
meson setup build -Dlogind-provider=elogind

meson compile -C build
meson install -C build
```

## Utilisation de Sway

```ini
# Enables inhibit_idle when playing audio
exec sway-audio-idle-inhibit
```

## Autres utilisations sans inhiber l'inactivité

Celles-ci pourraient être utilisées pour surveiller si une application utilise votre micro ou joue
un audio.

Surveiller les sources et les puits : affichera `RUNNING` ou `NOT RUNNING`

```zsh
sway-audio-idle-inhibit --dry-print-both
```

Sources de surveillance : affichera `EN COURS` ou `NON EN COURS`

```zsh
sway-audio-idle-inhibit --dry-print-source
```

Surveiller les puits : affichera `RUNNING` ou `NOT RUNNING`

```zsh
sway-audio-idle-inhibit --dry-print-sink
```

## Intégration Waybar

Un module Waybar personnalisé peut être utilisé pour afficher une icône lorsqu'une application utilise votre micro ou diffuse un son.

Ajoutez la section suivante à votre fichier `~/.config/waybar/config` et ajoutez
`custom/audio_idle_inhibitor` à la liste `modules-left`, `modules-center`
ou `modules-right`.

*Remarque : la police FontAwesome est utilisée pour les icônes ci-dessous*


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