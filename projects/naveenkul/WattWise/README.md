# WattWise

A lightweight CLI tool for monitoring power usage from smart plugs in real-time, either directly or through Home Assistant.

## Demo

![WattWise Demo](/media/WattWise_demo.gif)

## Features

- Monitor real-time power usage with wattage and current (amperes)
- Multiple connection options:
  - Connect directly to TP-Link Kasa smart plugs
  - Connect through Home Assistant
- Dynamic color-coded power display (green < 300W, yellow 300-1200W, red > 1200W)
- Continuous monitoring with charts and historical data
- Simple command-line interface

## Installation

### Via pip

```bash
pip install .

```

### Using Docker

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

## Uninstallation

### Complete Uninstallation

For a quick and complete removal of WattWise including Docker containers, images, and all configuration:

```bash
# Make the script executable (first time only)
chmod +x clean_uninstall.sh

# Run the uninstallation script
./clean_uninstall.sh
```

This script will remove all WattWise Docker containers, the Docker image, configuration files, and data. It will also detect and offer to uninstall any pip installation of WattWise.

### Manual Uninstallation

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

## Basic Usage

### First Time Setup

```bash
# Configure Home Assistant connection
wattwise config ha

# OR Configure Kasa smart plug
wattwise config kasa
```

### Monitoring

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

## Requirements

- Python 3.11 or later
- A TP-Link Kasa smart plug connected to your equipment
- Optional: Home Assistant setup with the Kasa integration

## Configuration

Configuration is stored in `~/.config/wattwise/config.yaml` and includes:
- Home Assistant connection details (URL, token, entity IDs)
- Kasa device details (IP address)
- Authentication tokens are stored securely

## Docker Usage Tips

### Create an Alias for Easy Use

You can create a bash alias for easier usage:

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
