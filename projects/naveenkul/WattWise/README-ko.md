# WattWise

스마트 플러그의 전력 사용량을 실시간으로 직접 또는 Home Assistant를 통해 모니터링하는 경량 CLI 도구입니다.

## 데모

![WattWise 데모](/media/WattWise_demo.gif)

## 기능

- 와트수 및 전류(암페어)로 실시간 전력 사용량 모니터링
- 다양한 연결 옵션:
  - TP-Link Kasa 스마트 플러그에 직접 연결
  - Home Assistant를 통해 연결
- 동적 색상 코드 전력 표시 (녹색 < 300W, 노란색 300-1200W, 빨간색 > 1200W)
- 차트 및 과거 데이터와 함께 지속적인 모니터링
- 간단한 명령줄 인터페이스

## 설치

### pip를 통한 설치

```bash
pip install .

```

### Docker 사용하기

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
## 제거

### 완전한 제거

Docker 컨테이너, 이미지 및 모든 구성을 포함하여 WattWise를 빠르고 완전하게 제거하려면:


```bash
# Make the script executable (first time only)
chmod +x clean_uninstall.sh

# Run the uninstallation script
./clean_uninstall.sh
```
이 스크립트는 모든 WattWise Docker 컨테이너, Docker 이미지, 구성 파일 및 데이터를 제거합니다. 또한 pip로 설치된 WattWise를 감지하여 제거를 제안합니다.

### 수동 제거

#### pip를 통한 제거


```bash
# Uninstall the package
pip uninstall wattwise

# Remove configuration files if desired
rm -rf ~/.config/wattwise
rm -rf ~/.local/share/wattwise
```

#### 도커

```bash
# Remove the Docker image
docker rmi wattwise

# Remove local configuration if desired
rm -rf ~/.config/wattwise
rm -rf ~/.local/share/wattwise
```
## 기본 사용법

### 처음 설정하기


```bash
# Configure Home Assistant connection
wattwise config ha

# OR Configure Kasa smart plug
wattwise config kasa
```

### 모니터링

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
## 요구사항

- Python 3.11 이상
- 장비에 연결된 TP-Link Kasa 스마트 플러그
- 선택 사항: Kasa 통합이 포함된 Home Assistant 설정

## 구성

구성은 `~/.config/wattwise/config.yaml`에 저장되며 다음을 포함합니다:
- Home Assistant 연결 세부 정보(URL, 토큰, 엔티티 ID)
- Kasa 장치 세부 정보(IP 주소)
- 인증 토큰은 안전하게 저장됨

## 도커 사용 팁

### 간편한 사용을 위한 별칭 생성

더 쉽게 사용하려면 bash 별칭을 만들 수 있습니다:


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