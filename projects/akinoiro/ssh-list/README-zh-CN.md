# SSH-List
带有TUI界面的SSH连接管理器。

![demo gif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo.gif)

主要功能：
- 添加和编辑连接
- 重新排列和排序连接
- 从 ~/.ssh/config 导入主机
- 搜索和过滤连接
- 在远程主机上执行命令

此应用不会修改您现有的SSH配置文件。主机设置可能分散在多个由Include指令引用的文件中（以及系统和用户配置之间），因此自动编辑不可靠。

此应用不存储密码。为实现安全认证，请使用SSH密钥。

## 前提条件
您必须在系统中安装OpenSSH客户端。
## 从GitHub Release安装
从[发行页面](https://github.com/akinoiro/ssh-list/releases)下载最新的二进制文件。

#### 在终端运行 `ssh-list` 命令：
```
# Make the binary executable
chmod +x ssh-list
# Move it to a directory in your PATH
sudo mv ssh-list /usr/local/bin/
```
## 从 crates.io 安装

```
cargo install ssh-list
```
## 从 AUR 安装（Arch Linux）
```
paru -S ssh-list
```
## 从PPA安装（Ubuntu，Linux Mint）
```
sudo add-apt-repository ppa:akinoiro/ssh-list
sudo apt update
sudo apt install ssh-list
```
## 通过 Homebrew 安装（macOS，Linux）
```
brew tap akinoiro/tap
brew install ssh-list
```
## 从源码构建
您需要安装 Rust 和 Cargo。
```
git clone https://github.com/akinoiro/ssh-list
cd ssh-list
cargo build --release
```
二进制文件将位于 target/release/  
## 配置文件  
ssh-list 会自动创建文件来存储您的连接：
```
~/.ssh/ssh-list.json
```
以及应用程序设置：
```
~/.ssh/ssh-list_config.toml
```
## Appearance customization

![demo settingsgif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo_settings.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---