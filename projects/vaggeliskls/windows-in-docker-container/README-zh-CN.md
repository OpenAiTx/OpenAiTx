# 💻 在 Docker 容器中运行 Windows
探索一种创新且高效的方法，利用 Vagrant 虚拟机、libvirt 和 docker-compose 的力量，在您的 Linux 系统上部署 Windows 操作系统（x64）。这些技术共同帮助您将 Windows 操作系统容器化，使您能够像管理任何 Docker 容器一样管理 Windows 实例。这种无缝集成到现有工作流程中，大大提升了便利性并优化了资源分配。

⭐ **如果本项目对您有帮助，别忘了给项目点星！**

## 📋 先决条件

确保您的系统满足以下要求：

- **Docker：** 版本 20 或更高 [(安装 Docker)](https://www.docker.com/)

- **主机操作系统：** Linux

- **虚拟化已启用：**
  - 通过以下命令检查：
    - `lscpu | grep -i Virtualization`
  - 输出表示：
    - `VT-x` → 支持且启用了 Intel 虚拟化。
    - `AMD-V` → 支持且启用了 AMD 虚拟化。
  - 如果未启用虚拟化，请在 BIOS/UEFI 设置中启用。

- Compose 文件中需使用 **`cgroup: host`**：libvirt 及其启动的守护进程需要完全的 cgroup 访问权限，否则容器在 cgroup v2 主机上无法启动。

## 🚀 部署指南

1. 创建/更新环境变量文件 `.env`
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---