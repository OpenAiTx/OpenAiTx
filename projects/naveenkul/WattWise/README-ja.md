# WattWise

スマートプラグからの電力使用量をリアルタイムで監視するための軽量CLIツールで、直接またはHome Assistantを通じて使用可能。

## デモ

![WattWise Demo](/media/WattWise_demo.gif)

## 特長

- ワット数と電流（アンペア）によるリアルタイムの電力使用量監視
- 複数の接続オプション：
  - TP-Link Kasaスマートプラグへの直接接続
  - Home Assistant経由での接続
- 動的な色分けされた電力表示（緑 < 300W、黄 300-1200W、赤 > 1200W）
- チャートと履歴データによる継続的な監視
- シンプルなコマンドラインインターフェース

## インストール

### pip経由

```bash
pip install .

```

### Dockerの使用方法

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

## アンインストール

### 完全なアンインストール

Dockerコンテナ、イメージ、およびすべての設定を含むWattWiseの迅速かつ完全な削除には：

```bash
# Make the script executable (first time only)
chmod +x clean_uninstall.sh

# Run the uninstallation script
./clean_uninstall.sh
```
このスクリプトはすべてのWattWise Dockerコンテナ、Dockerイメージ、設定ファイル、およびデータを削除します。また、WattWiseのpipインストールを検出し、アンインストールを提案します。

### 手動アンインストール

#### pip経由で


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

## 基本的な使い方

### 初回設定

```bash
# Configure Home Assistant connection
wattwise config ha

# OR Configure Kasa smart plug
wattwise config kasa
```

### 監視

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
## 要件

- Python 3.11 以降
- 機器に接続された TP-Link Kasa スマートプラグ
- 任意：Kasa統合を使用したHome Assistantのセットアップ

## 設定

設定は `~/.config/wattwise/config.yaml` に保存され、以下を含みます：
- Home Assistantの接続情報（URL、トークン、エンティティID）
- Kasaデバイスの詳細（IPアドレス）
- 認証トークンは安全に保存されます

## Docker使用のヒント

### 簡単に使うためのエイリアス作成

より簡単に使えるようにbashエイリアスを作成できます：


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