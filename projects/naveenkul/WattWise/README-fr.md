# WattWise

Un outil CLI léger pour surveiller la consommation d'énergie des prises intelligentes en temps réel, soit directement, soit via Home Assistant.

## Démo

![Démo WattWise](/media/WattWise_demo.gif)

## Fonctionnalités

- Surveille la consommation d'énergie en temps réel avec la puissance en watts et le courant (ampères)
- Plusieurs options de connexion :
  - Connexion directe aux prises intelligentes TP-Link Kasa
  - Connexion via Home Assistant
- Affichage dynamique de la puissance avec code couleur (vert < 300W, jaune 300-1200W, rouge > 1200W)
- Surveillance continue avec graphiques et données historiques
- Interface en ligne de commande simple

## Installation

### Via pip

```bash
pip install .

```

### Utilisation de Docker

```bash
# 1. Build the Docker image (from project directory)
docker build -t wattwise .

# 2. Create directories for persistence (first time only)
mkdir -p ~/.config/wattwise
mkdir -p ~/.local/share/wattwise

# 3. First time setup: Configure a data source
# Configure Home Assistant
docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise config ha

# OR Configure Kasa smart plug
docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise config kasa

# Optional: Add additional devices (multi-device config)
docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise devices add --name "PC" --type kasa --ip 192.168.1.50

docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise devices add --name "Server" --type homeassistant \
    --host http://homeassistant.local:8123 \
    --token $HA_TOKEN \
    --entity-id sensor.server_power \
    --current-entity-id sensor.server_current

# 4. Run a single check with Docker
docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise

# 5. Run with continuous monitoring
docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise --watch

# 6. If you have permission issues, you can fix them with:
sudo chown -R $USER:$USER ~/.config/wattwise ~/.local/share/wattwise
chmod -R u+rw ~/.config/wattwise ~/.local/share/wattwise

# Or using the built-in command:
docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise config fix-permissions
```

## Désinstallation

### Désinstallation complète

Pour une suppression rapide et complète de WattWise incluant les conteneurs Docker, les images et toute la configuration :

```bash
# Make the script executable (first time only)
chmod +x clean_uninstall.sh

# Run the uninstallation script
./clean_uninstall.sh
```

Ce script supprimera tous les conteneurs Docker WattWise, l’image Docker, les fichiers de configuration et les données. Il détectera également toute installation de WattWise via pip et proposera de la désinstaller.

### Désinstallation manuelle

#### Via pip

```bash
# Uninstall the package
pip uninstall wattwise

# Remove configuration files if desired
rm -rf ~/.config/wattwise
rm -rf ~/.local/share/wattwise
```

#### Docker

```bash
# Remove the Docker image
docker rmi wattwise

# Remove local configuration if desired
rm -rf ~/.config/wattwise
rm -rf ~/.local/share/wattwise
```

## Utilisation de base

### Première configuration

```bash
# Configure Home Assistant connection
wattwise config ha

# OR Configure Kasa smart plug
wattwise config kasa
```

### Surveillance

```bash
# Quick power view (single reading)
wattwise

# To discover the kasa devices on your local network
wattwise --discover

# Continuous monitoring with charts
wattwise --watch

# Monitor current (amperes) as well
wattwise --current --watch

# Set refresh interval (seconds)
wattwise --watch --interval 5

# Output only raw watt value (for scripting use)
wattwise --raw

# Continuous raw monitoring (output a new value every second)
wattwise --raw --watch

# Specify data source manually
wattwise --source homeassistant
wattwise --source kasa

# Manage multiple devices
wattwise devices list
wattwise devices add --name "PC" --type kasa --ip 192.168.1.50
wattwise devices add --name "Server" --type homeassistant \
  --host http://homeassistant.local:8123 \
  --token $HA_TOKEN \
  --entity-id sensor.server_power \
  --current-entity-id sensor.server_current
wattwise --device "PC"
```

## Exigences

- Python 3.11 ou version ultérieure
- Une prise intelligente TP-Link Kasa connectée à votre équipement
- Optionnel : Configuration de Home Assistant avec l'intégration Kasa

## Configuration

La configuration est stockée dans `~/.config/wattwise/config.yaml` et comprend :
- Les détails de connexion à Home Assistant (URL, token, identifiants des entités)
- Les détails de l'appareil Kasa (adresse IP)
- Les tokens d'authentification sont stockés de manière sécurisée

## Conseils d'utilisation de Docker

### Créer un alias pour une utilisation facile

Vous pouvez créer un alias bash pour une utilisation plus simple :

```bash
# Add to your .bashrc or .zshrc file
alias wattwise='docker run -it --rm --network host \
  -v ~/.config/wattwise:/root/.config/wattwise \
  -v ~/.local/share/wattwise:/root/.local/share/wattwise \
  wattwise'

# After creating the alias, you can use it just like the normal command:
wattwise  # Single reading
wattwise --watch  # Continuous monitoring
wattwise config fix-permissions  # Fix directory permissions
wattwise --device "PC"  # Target a specific configured device
```

## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-01

---