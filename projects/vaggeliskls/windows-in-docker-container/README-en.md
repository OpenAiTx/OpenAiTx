
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

# 💻 Windows in Docker Container
Discover an innovative and efficient method of deploying Windows OS (x64) on your linux system using the power of Vagrant VM, libvirt, and docker-compose. Together, these technologies help you containerize Windows OS, enabling you to manage a Windows instance just as you would any Docker container. This seamless integration into existing workflows significantly enhances convenience and optimizes resource allocation.

⭐ **Don't forget to star the project if it helped you!**

## 📋 Prerequisites

Ensure your system meets the following requirements:

- **Docker:** Version 20 or higher [(Install Docker)](https://www.docker.com/)

- **Host OS:** Linux

- **Virtualization Enabled:**
  - Check with:
    - `lscpu | grep -i Virtualization`
  - Output indicates:
    - `VT-x` → Intel virtualization is supported & enabled.
    - `AMD-V` → AMD virtualization is supported & enabled.
  - If virtualization is not enabled, enable it in the BIOS/UEFI settings.

- **`cgroup: host`** in the compose file is required: libvirt and the daemons it spawns need full cgroup access, otherwise the container fails to start on cgroup v2 hosts.

## 🚀 Deployment Guide

1. Create/Update the environmental file `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Create `docker-compose.yml`
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
3. Create `docker-compose.override.yml` when you want your VM to be persistent
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
4. Run: `docker compose up -d`

> **First boot takes several minutes** — the Vagrant box is already baked into the image, but the VM still has to boot and run the provisioning script (Chocolatey install, disk resize, registry tweaks). Follow progress with `docker compose logs -f`.

> When you want to destroy everything `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Access  

### Remote Desktop (RDP)  
For debugging or testing, you can connect to the VM using **Remote Desktop** on port `3389`.  

#### Software for Remote Desktop Access  
| OS       | Software |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` or [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | Built-in **Remote Desktop Connection** |

---

### SSH   
You can connect via SSH using either the **administrator** or **Vagrant** user credentials.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 User Login
Default users based on the Vagrant image are:

1. Administrator
    - Username: Administrator
    - Password: vagrant
2. User
    - Username: vagrant
    - Password: vagrant

## ⚠️ Limitations

- **Linux host only** — depends on `/dev/kvm` and libvirt; macOS and Windows hosts are not supported.
- **Eval license** — the underlying box ships an evaluation copy of Windows Server 2022. Activation expires per Microsoft's eval terms.
- **No synced folders** — `rsync`, `smb`, and `nfs` are all unwired in the [Vagrantfile](Vagrantfile) (rsync needs a Windows-side install before provisioning runs; SMB synced folders aren't supported with a Linux host; in-container NFS hits `no support in current kernel`).
- **Performance** — without nested KVM available to Docker (e.g. on a cloud VM that doesn't expose KVM), the guest falls back to plain QEMU and is several times slower.

## 🔧 Troubleshooting

- **`KVM acceleration is not available`** in logs → the host isn't exposing `/dev/kvm`. Check virtualization is enabled in BIOS, the `kvm` module is loaded (`lsmod | grep kvm`), and `/dev/kvm` exists on the host. The startup script falls back to QEMU automatically; expect a large slowdown.
- **Port 3389 / 2222 already in use** → another RDP/SSH service is bound on the host. Stop it, or change the host-side port mapping in `docker-compose.yml`.
- **Container exits immediately** → almost always a cgroup or privilege problem. Confirm `privileged: true` and `cgroup: host` are set, then check `docker compose logs win10`.
- **`vagrant up` hangs at "Waiting for domain to get an IP address"** → libvirt's default NAT network isn't running. Restart the container, or run `virsh net-start default` from inside it.

## 📚 Further Reading and Resources

- [Windows Vagrant Tutorial](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant image: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant by HashiCorp](https://www.vagrantup.com/)
- [Windows Virtual Machine in a Linux Docker Container](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU inside a container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---