# WattWise

一个轻量级的命令行工具，用于实时监控智能插座的电力使用情况，可以直接连接或通过 Home Assistant。

## 演示

![WattWise Demo](/media/WattWise_demo.gif)

## 功能

- 实时监控功率和电流（安培）
- 多种连接选项：
  - 直接连接 TP-Link Kasa 智能插座
  - 通过 Home Assistant 连接
- 动态颜色编码功率显示（绿色 < 300W，黄色 300-1200W，红色 > 1200W）
- 持续监控，带图表和历史数据
- 简单的命令行界面

## 安装

### 通过 pip

```bash
pip install .

```

### 使用 Docker

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

## 卸载

### 完全卸载

快速且彻底地移除 WattWise，包括 Docker 容器、镜像及所有配置：

```bash
# Make the script executable (first time only)
chmod +x clean_uninstall.sh

# Run the uninstallation script
./clean_uninstall.sh
```
此脚本将删除所有 WattWise Docker 容器、Docker 镜像、配置文件和数据。它还会检测并提供卸载任何通过 pip 安装的 WattWise 的选项。

### 手动卸载

#### 通过 pip


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

## 基本用法

### 初次设置

```bash
# Configure Home Assistant connection
wattwise config ha

# OR Configure Kasa smart plug
wattwise config kasa
```

### 监控

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

## 要求

- Python 3.11 或更高版本
- 一个连接到您的设备的 TP-Link Kasa 智能插座
- 可选：已配置 Kasa 集成的 Home Assistant

## 配置

配置存储在 `~/.config/wattwise/config.yaml` 中，包括：
- Home Assistant 连接详情（URL，令牌，实体 ID）
- Kasa 设备详情（IP 地址）
- 认证令牌安全存储

## Docker 使用技巧

### 创建别名以便使用

您可以创建一个 bash 别名以便更方便使用：

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