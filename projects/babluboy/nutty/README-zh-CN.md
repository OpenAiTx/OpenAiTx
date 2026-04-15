# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
一个网络工具

作者：Siddhartha Das

一个为 elementary OS 制作的简单应用程序，提供网络相关方面的基本信息。信息以以下标签页形式展示。<br>
1. 我的信息：提供设备网卡的基本和详细信息<br>
2. 使用情况：以两种视图提供网络数据使用情况——历史使用和当前使用<br>
3. 速度：检查上传和下载速度，并获取到主机的路由时间<br>
4. 端口：提供本地设备上活动端口及使用它们的应用程序信息<br>
5. 设备：监控、提醒并提供网络上其他连接设备的信息<br>

请访问 Nutty 网站了解功能详情、快捷键、Ubuntu 及其他支持发行版的安装指南等：<br>
https://babluboy.github.io/nutty/

## 从源码构建、测试和安装

构建时需要以下依赖：
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

执行时需要以下依赖：
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

有时安装后 vnstat 不会自动启动，请使用相应的初始化系统命令启动 vnstat 守护进程，如 `sudo systemctl enable vnstat`
运行 `meson build` 来配置构建环境，运行 `ninja test` 来构建


```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

安装时，使用 `sudo ninja install`，然后执行 `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
要卸载，请进入构建目录并运行

```
sudo ninja uninstall
```

### 从 Deb 包安装

要从 `.deb` 包安装 Nutty，请确保已安装上述所有 Nutty 的运行时依赖（无需构建依赖）。然后运行以下命令
```bash
sudo dpkg -i <deb-package-name>.deb
```

要卸载通过 `.deb` 包安装的 Nutty，请运行
```bash
sudo apt autoremove com.github.babluboy.nutty
```
如果您想直接构建 Nutty 的 `.deb` 软件包，请先安装上述构建依赖项，然后运行

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---