
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 💻 Docker 容器中的 Windows
探索一種創新且高效的方法，利用 Vagrant VM、libvirt 及 docker-compose 的強大功能，在您的 Linux 系統上部署 Windows 作業系統（x64）。這些技術結合起來，能將 Windows 作業系統容器化，使您能像管理任何 Docker 容器一樣，管理一個 Windows 實例。這種無縫整合進現有工作流程，大幅提升便利性並優化資源分配。

⭐ **如果本專案對您有幫助，別忘了給顆星！**

## 📋 先決條件

請確保您的系統符合以下要求：
- **Docker:** 版本 20 或更高 [(安裝 Docker)](https://www.docker.com/)

- **主機作業系統 (Host OS):** Linux

- **已啟用虛擬化:**
  - 檢查方式：
    - `lscpu | grep -i Virtualization`
  - 輸出說明：
    - `VT-x` → 支援並已啟用 Intel 虛擬化。
    - `AMD-V` → 支援並已啟用 AMD 虛擬化。
  - 若未啟用虛擬化，請於 BIOS/UEFI 設定中啟用。

- **compose 檔案中的 `cgroup: host` 必須設定：** libvirt 及其產生的守護行程需完整的 cgroup 存取權限，否則在 cgroup v2 主機上容器將無法啟動。

## 🚀 部署指南

1. 建立或更新環境設定檔 `.env`

```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. 建立 `docker-compose.yml`
```yaml
services:
  win10:
    image: docker.io/vaggeliskls/windows-in-docker-container:latest
    platform: linux/amd64
    env_file: .env
    stdin_open: true
    tty: true
    privileged: true
    cgroup: host
    restart: always
    ports:
      - 3389:3389
      - 2222:2222
```
3. 當你希望你的虛擬機持久化時，請建立 `docker-compose.override.yml`
```yaml
services:
  win10:
    volumes:
      - libvirt_data:/var/lib/libvirt
      - vagrant_data:/root/.vagrant.d
      - vagrant_project:/app/.vagrant
      - libvirt_config:/etc/libvirt

volumes:
  libvirt_data:
    name: libvirt_data
  vagrant_data:
    name: vagrant_data
  vagrant_project:
    name: vagrant_project
  libvirt_config:
    name: libvirt_config
```
4. 執行：`docker compose up -d`

> **首次啟動需要幾分鐘** — Vagrant box 已經包含在映像檔中，但虛擬機仍需啟動並執行配置腳本（安裝 Chocolatey、磁碟擴展、註冊表調整）。可以用 `docker compose logs -f` 來追蹤進度。

> 當你想要銷毀所有東西時，執行 `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 存取  

### 遠端桌面（RDP）  
為了除錯或測試，你可以使用 **遠端桌面** 連接到虛擬機，埠號為 `3389`。  

#### 遠端桌面存取軟體  
| 作業系統 | 軟體 |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` 或 [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | 內建 **遠端桌面連線** |

---

### SSH   
你可以使用 **administrator** 或 **Vagrant** 使用者憑證透過 SSH 連接。

```bash
ssh <user>@<host> -p 2222
```

## 🔑 使用者登入
根據 Vagrant 映像檔的預設使用者如下：

1. 管理員
    - 使用者名稱：Administrator
    - 密碼：vagrant
2. 一般使用者
    - 使用者名稱：vagrant
    - 密碼：vagrant

## ⚠️ 限制事項

- **僅限 Linux 主機** — 依賴 `/dev/kvm` 和 libvirt；不支援 macOS 與 Windows 主機。
- **評估授權** — 內建 box 為 Windows Server 2022 評估版本。啟用期限依微軟評估條款到期。
- **無同步資料夾** — `rsync`、`smb` 與 `nfs` 於 [Vagrantfile](Vagrantfile) 中皆未啟用（rsync 需於 Windows 端安裝後才可配置；Linux 主機不支援 SMB 同步資料夾；容器內 NFS 會遇到 `no support in current kernel`）。
- **效能** — 若 Docker 未啟用巢狀 KVM（如雲端 VM 未開放 KVM），來賓系統將退回純 QEMU，速度會慢數倍。

## 🔧 疑難排解

- 日誌顯示 **`KVM acceleration is not available`** → 主機未開放 `/dev/kvm`。請確認 BIOS 已啟用虛擬化、`kvm` 模組已載入（`lsmod | grep kvm`），且主機存在 `/dev/kvm`。啟動腳本會自動退回 QEMU，速度將大幅下降。
- **3389 / 2222 埠已被佔用** → 另一個 RDP/SSH 服務已於主機綁定。請關閉該服務，或在 `docker-compose.yml` 內更改主機端埠對應。
- **容器立即結束** → 幾乎都是 cgroup 或權限問題。請確認已設為 `privileged: true` 及 `cgroup: host`，然後檢查 `docker compose logs win10`。
- **`vagrant up` 停在 "Waiting for domain to get an IP address"`** → libvirt 預設 NAT 網路未啟動。請重啟容器，或在容器內執行 `virsh net-start default`。

## 📚 延伸閱讀與資源

- [Windows Vagrant 教學](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant 映像檔：peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [HashiCorp Vagrant 官方網站](https://www.vagrantup.com/)
- [於 Linux Docker 容器中安裝 Windows 虛擬機](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [容器中使用 GPU](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---