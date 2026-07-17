<div align="center">

# VIGIL

**Moniteur de puissance en temps réel pour terminal — CPU · GPU · RAM · Réseau · Processus**

[![CI](https://github.com/GIN-SYSTEMS/vigil-tui/actions/workflows/ci.yml/badge.svg)](https://github.com/GIN-SYSTEMS/vigil-tui/actions)
[![Python](https://img.shields.io/badge/python-3.11%2B-blue?logo=python&logoColor=white)](https://www.python.org/)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20Windows-lightgrey)](https://github.com/GIN-SYSTEMS/vigil-tui)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

</div>

---

![vigil-tui dashboard](https://raw.githubusercontent.com/GIN-SYSTEMS/vigil-tui/main/assets/screenshot.png)

---

## Vue d’ensemble

vigil est un tableau de bord terminal haute résolution qui affiche **la puissance en watts en direct, les températures, les fréquences d’horloge, les scores d’efficacité et le coût de l’électricité** pour chaque composant majeur — le tout dans le terminal sans navigateur, sans service en arrière-plan, sans télémétrie.

Il lit directement depuis les capteurs matériels (hwmon, RAPL, LibreHardwareMonitor, NVML) et bascule élégamment lorsqu’un capteur est indisponible. Chaque panneau se met à jour en temps réel, le tout fonctionne avec une seule commande `vigil`.

---

## Fonctionnalités

### Puissance & Températures
- **Puissance du package CPU** — hwmon (k10temp / zenpower / amd_energy) → RAPL → LibreHardwareMonitor WMI → CPU% × estimation TDP
- **Puissance GPU** — NVIDIA NVML : watts, température, utilisation, fréquences core/mémoire, VRAM, vitesse du ventilateur
- **Consommation RAM** — modèle de puissance DDR4 (nombre de slots × utilisation)
- **Détection de throttling** — badge clignotant `THROTTLE` sur CPU ou GPU en cas de throttling thermique

### Graphiques & Visualisation
- **Historique de puissance** — graphique de surface en Braille haute résolution, superposition CPU + GPU
- **Historique des fréquences** — fréquence moyenne CPU + fréquence core GPU avec marqueur de plafond de boost
- **Barres par cœur** — % d’utilisation + fréquence en direct pour chaque cœur

### Intelligence des processus
- **Tableau des processus** — classé par contribution estimée en watts
- **Tendances Sparkline** — mini graphique historique de watts par processus
- **Colonne EST.W** — watts par processus dérivés de la part CPU% de la puissance du package

### Efficacité & Coût
- **Score d'efficacité** — `OPTIMAL` · `NORMAL` · `FAIBLE EFF` · `RÉDUCTION`
- **Coût électricité** — /h, /jour, total session (prix kWh + devise configurable)
- **Mode de référence** — instantané état inactif, comparer delta en temps réel

### Alertes & Journalisation
- **Alertes Webhook** — POST HTTP quand seuil de température CPU ou puissance dépassé
- **Journalisation session** — log JSONL tick optionnel (`--log` flag)
- **Capture SVG** — export complet du tableau de bord avec `s`

### Thèmes & UX
- **TacticalCyberpunk** (sombre) — vert / ambre / cyan sur quasi-noir
- **GhostWhite** (clair) — monochrome à fort contraste
- **Assistant d'installation** — configuration guidée TDP + kWh au premier lancement
- **Recoloration d’accent en direct** — ajustements couleur barre latérale sans redémarrage

---

## Support des plateformes

| Plateforme | Puissance CPU | Temp CPU | Puissance GPU | Temp GPU |
|---|---|---|---|---|
| **Linux** | hwmon · RAPL · estimation | hwmon | NVML | NVML |
| **Windows 11 / 10** | LibreHardwareMonitor · estimation | LHM | NVML | NVML |
| **macOS** | estimation uniquement | — | NVML (si présent) | NVML |

### Windows — lectures CPU précises

vigil lit la puissance réelle CPU via **[LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) (MPL-2.0)** par son interface WMI. Sans cela, vigil utilise automatiquement une estimation CPU% × TDP.

1. Télécharger [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor/releases)
2. Lancer **en tant qu’administrateur**
3. Démarrer vigil — LHM est détecté automatiquement

> vigil ne bundle ni ne modifie LibreHardwareMonitor. Il se connecte à son interface WMI au moment de l’exécution. LHM doit être lancé séparément.

---

## Installation

**Requirements:** Python 3.11+

```bash
# Clone
git clone https://github.com/GIN-SYSTEMS/vigil-tui
cd vigil-tui

# Linux / macOS
pip install .

# Windows (includes WMI + pywin32 for LHM support)
pip install ".[windows]"
```

**Run:**
```bash
vigil           # launch dashboard
vigil --log     # launch + write JSONL tick log
vigil --help    # all options
```

---

## Raccourcis clavier

| Touche | Action |
|-----|--------|
| `*` / `?` | Basculer l’aide superposée |
| `q` / Ctrl+C | Quitter |
| `p` | Mettre en pause / reprendre l’échantillonnage |
| `r` | Réinitialiser l’historique du graphique |
| `+` / `-` | Zoomer / dézoomer l’axe Y |
| `b` | Capturer la ligne de base — appuyer de nouveau pour effacer |
| `s` | Enregistrer une capture d’écran SVG |
| `t` | Basculer le thème (sombre ↔ clair) |
| `c` | Ouvrir la configuration / l’assistant de configuration |

---

## Configuration

Le premier lancement crée `~/.config/vigil/config.toml` :

```toml
[hardware]
cpu_tdp_watts       = 65.0     # CPU TDP ceiling for estimation
gpu_tdp_watts       = 165.0    # GPU TDP ceiling
update_interval     = 1.0      # seconds between ticks
history_len         = 120      # chart ring-buffer depth

[cost]
kwh_price           = 2.0      # electricity price per kWh
currency_symbol     = "₺"

[alerts]
webhook_url         = ""       # HTTP POST endpoint — empty = disabled
cpu_temp_thresh     = 90       # °C
cpu_watt_thresh_pct = 90       # % of TDP

[ui]
theme               = "tactical"   # "tactical" or "ghost"
```

---

## How the power waterfall works

```
vigil starts
│
├─ Linux?
│   ├─ hwmon sysfs (k10temp / zenpower / amd_energy)   ← real sensor
│   ├─ RAPL powercap energy_uj delta                   ← kernel counter
│   └─ CPU% × TDP estimate                             ← always available
│
└─ Windows?
    ├─ LibreHardwareMonitor WMI (requires Admin + LHM) ← real sensor
    └─ CPU% × TDP estimate                             ← always available

GPU → NVML (pynvml) on all platforms
     if no NVIDIA GPU: panel shows "unavailable", no crash
```

---

## Project Structure

```
vigil-tui/
├── src/vigil/
│   ├── app.py                   # Textual app, layout, tick loop
│   ├── config.py                # Static constants
│   ├── config_manager.py        # TOML config loader/writer
│   ├── session.py               # Cost tracking, webhooks, JSONL logging
│   ├── collectors/
│   │   ├── base.py              # Collector ABC + SensorReading
│   │   ├── cpu.py               # hwmon → RAPL → LHM → estimate
│   │   ├── gpu.py               # NVIDIA NVML
│   │   ├── ram.py               # RAM wattage model
│   │   ├── netdisk.py           # Network + disk I/O rates
│   │   └── system.py            # Orchestrator → SystemSnapshot
│   └── widgets/
│       ├── power_header.py      # Top bar: wordmark + gauge
│       ├── cpu_panel.py         # Left: CPU + per-core bars
│       ├── braille_chart.py     # Center: power history
│       ├── clock_chart.py       # Center: clock history
│       ├── process_table.py     # Center: process ranking
│       ├── gpu_panel.py         # Right: GPU metrics
│       ├── financial_widget.py  # Cost display
│       ├── netdisk_widget.py    # Network + disk rates
│       ├── status_bar.py        # Footer
│       ├── boot_screen.py       # Splash screen
│       ├── help_overlay.py      # Key bindings overlay
│       └── setup_wizard.py      # First-run wizard
├── .github/workflows/ci.yml
├── pyproject.toml
├── requirements.txt
└── LICENSE
```

---

## Dépendances

| Paquet | Utilité |
|---------|---------|
| `textual >= 0.80` | Framework TUI |
| `psutil >= 5.9.8` | CPU%, liste des processus, E/S réseau/disque |
| `pynvml >= 11.5.0` | Métriques GPU NVIDIA |
| `wmi >= 1.5.1` *(Windows)* | Pont WMI LHM |
| `pywin32 >= 306` *(Windows)* | Support Windows COM/WMI |

---

## Licence

[MIT](LICENSE) — libre à utiliser, modifier et distribuer.

---

<div align="center">
construit par <a href="https://github.com/GIN-SYSTEMS">GIN-SYSTEMS</a>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---