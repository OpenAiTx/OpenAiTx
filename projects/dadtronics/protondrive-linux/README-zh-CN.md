# 使用 rclone 和 systemd 在 Linux 上挂载 Proton Drive

本指南自动化了在 Linux 系统上使用 [`rclone`](https://rclone.org/) 和 `systemd` 挂载 [Proton Drive](https://proton.me/drive) 的过程。

已在 **Arch Linux** 上测试，但在大多数 Linux 发行版上只需稍作调整即可使用。

---

## 🔧 功能

- 通过 `systemd --user` 登录时挂载 Proton Drive
- 使用带有 `--vfs-cache-mode writes` 的 `rclone` 以提高兼容性
- 启用带日志的后台服务
- 添加 FUSE 支持以允许 `--allow-other` 挂载

---

## 🚀 快速开始

### 1. ✅ 安装依赖

#### 安装 `fuse3`（挂载所需）：
```bash
sudo pacman -S fuse3
````

#### 安装 `rclone`（必须是 v1.64.0 或更新版本）

🔹 **选项 1：使用预编译二进制文件（推荐）**

```bash
curl -O https://downloads.rclone.org/rclone-current-linux-amd64.zip
unzip rclone-current-linux-amd64.zip
cd rclone-*-linux-amd64
sudo cp rclone /usr/local/bin/
sudo chmod +x /usr/local/bin/rclone
```
验证：


```bash
rclone version
# Must be v1.64.0 or higher
```

---

### 2. 🔐 Configure Proton Drive Remote

Run:

```bash
rclone config
```

Follow prompts:

* `n` → 新建远程
* Name: `proton`
* Type: `protondrive`
* Log in via browser when prompted
* 接受并保存

---

### 3. 📜 运行设置脚本

运行提供的脚本：

```bash
chmod +x setup-proton-mount.sh
./setup-proton-mount.sh
```

脚本将执行：

* 创建挂载点：`~/ProtonDrive`
* 编写 systemd 用户服务
* 向 `/etc/fuse.conf` 添加 `user_allow_other`（如果缺失）
* 将用户添加到 `fuse` 组（如果需要）
* 启用并启动挂载服务

---

### 4. 🔁 重启或注销/登录

如果脚本将您添加到了 `fuse` 组，您必须**注销并重新登录**以使更改生效。

---

## 🔍 验证挂载

检查 Proton Drive 是否已挂载：

```bash
ls ~/ProtonDrive
```
检查 systemd 服务：


```bash
systemctl --user status rclone-proton.mount.service
```

---

## 🔁 Remount

If unmounted the Proton Drive can be remounted by:

```bash
systemctl --user restart rclone-proton.mount.service
```

请注意，Proton Drive 会在每次登录时自动挂载。

## 🧼 卸载

要移除自动挂载设置：

```bash
systemctl --user disable --now rclone-proton.mount.service
rm ~/.config/systemd/user/rclone-proton.mount.service
```
(Optional) 如果不再需要挂载点，可以删除 `~/ProtonDrive`。

---

## 📁 文件

* `setup-proton-mount.sh` — 完整的安装脚本
* `~/.config/systemd/user/rclone-proton.mount.service` — systemd 单元
* `~/ProtonDrive` — 挂载位置
* `~/.cache/rclone/rclone-proton.log` — 日志输出（可选）

---

## 📎 需求

* 支持 Proton Drive 的 `rclone >= 1.64.0`
* `fuse3`
* 一个 Proton Drive 账户

---

## 🛟 故障排除

如果挂载无法正常工作：


```bash
journalctl --user -u rclone-proton.mount.service
```
要手动重启服务：


```bash
systemctl --user restart rclone-proton.mount.service
```

---

## 📚 参考资料

* [rclone Proton Drive 文档](https://rclone.org/protondrive/)
* [systemd 用户服务](https://wiki.archlinux.org/title/Systemd/User)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---