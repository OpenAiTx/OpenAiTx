
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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
探索一种创新高效的方法，通过 Vagrant VM、libvirt 和 docker-compose 的强大组合，在您的 Linux 系统上部署 Windows 操作系统（x64）。这些技术协同工作，使您能够将 Windows 操作系统容器化，让您像管理其他 Docker 容器一样管理 Windows 实例。这种无缝集成极大地提升了便利性，并优化了资源分配。

⭐ **如果本项目对您有帮助，请记得给个星标！**

## 📋 前置条件

请确保您的系统满足以下要求：

- **Docker：** 版本 20 或更高 [（安装 Docker）](https://www.docker.com/)

- **主机操作系统：** Linux

- **已启用虚拟化：**
  - 检查方法：
    - `lscpu | grep -i Virtualization`
  - 输出结果说明：
    - `VT-x` → 支持并已启用 Intel 虚拟化。
    - `AMD-V` → 支持并已启用 AMD 虚拟化。
  - 如果未启用虚拟化，请在 BIOS/UEFI 设置中启用。

- 在 compose 文件中必须使用 **`cgroup: host`** ：libvirt 及其生成的守护进程需要完整的 cgroup 访问权限，否则在 cgroup v2 主机上容器将无法启动。

## 🚀 部署指南

1. 创建或更新环境文件 `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. 创建 `docker-compose.yml`
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
3. 当您希望虚拟机持久化时，创建 `docker-compose.override.yml`
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
4. 运行：`docker compose up -d`

> **首次启动需要几分钟时间** — Vagrant盒子已内置于镜像中，但虚拟机仍需启动并运行配置脚本（Chocolatey安装、磁盘扩展、注册表调整）。可通过 `docker compose logs -f` 查看进度。

> 如果想销毁所有内容，执行 `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 访问  

### 远程桌面 (RDP)  
用于调试或测试，可通过端口 `3389` 使用 **远程桌面** 连接虚拟机。  

#### 远程桌面访问软件  
| 操作系统    | 软件       |
|------------|------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` 或 [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | 内置 **远程桌面连接** |

---

### SSH   
您可以使用 **administrator** 或 **Vagrant** 用户凭据通过 SSH 连接。  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 用户登录
基于 Vagrant 镜像的默认用户为：

1. 管理员
    - 用户名：Administrator
    - 密码：vagrant
2. 用户
    - 用户名：vagrant
    - 密码：vagrant

## ⚠️ 限制

- **仅限 Linux 主机** — 依赖 `/dev/kvm` 和 libvirt；不支持 macOS 和 Windows 主机。
- **评估许可** — 底层镜像附带 Windows Server 2022 评估版。激活根据微软评估条款到期。
- **无同步文件夹** — `rsync`、`smb` 和 `nfs` 在 [Vagrantfile](Vagrantfile) 中均未启用（rsync 需要 Windows 端安装后才能在预配置时运行；Linux 主机不支持 SMB 同步文件夹；容器内 NFS 报错“当前内核不支持”）。
- **性能** — 在 Docker 中无法使用嵌套 KVM（例如云 VM 不支持 KVM），客机将回退至普通 QEMU，速度慢数倍。

## 🔧 故障排除

- **日志中出现 `KVM acceleration is not available`** → 主机未暴露 `/dev/kvm`。检查 BIOS 中虚拟化是否开启，`kvm` 模块是否加载（`lsmod | grep kvm`），以及主机上是否存在 `/dev/kvm`。启动脚本会自动回退到 QEMU，性能明显下降。
- **端口 3389 / 2222 已被占用** → 主机上已有其他 RDP/SSH 服务占用。停止该服务，或修改 `docker-compose.yml` 中主机端口映射。
- **容器立即退出** → 几乎总是 cgroup 或权限问题。确认设置了 `privileged: true` 和 `cgroup: host`，然后检查 `docker compose logs win10`。
- **`vagrant up` 卡在“Waiting for domain to get an IP address”** → libvirt 默认 NAT 网络未运行。重启容器，或在容器内运行 `virsh net-start default`。

## 📚 进一步阅读与资源

- [Windows Vagrant 教程](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant 镜像：peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [HashiCorp 的 Vagrant](https://www.vagrantup.com/)
- [在 Linux Docker 容器中运行 Windows 虚拟机](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [容器内的 GPU](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---