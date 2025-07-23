<h1 align="center">
  <br>
  OpenSuperClone
  <br>
</h1>

<div align="center">

  [![提交](https://badgen.net/github/commits/ispillmydrink/opensuperclone/main)](https://github.com/ISpillMyDrink/OpenSuperClone/commits/main)
  [![最新提交](https://badgen.net/github/last-commit/ispillmydrink/opensuperclone/main)](https://github.com/ISpillMyDrink/OpenSuperClone/commits/main)
  [![发布](https://badgen.net/github/release/ispillmydrink/opensuperclone)](https://github.com/ISpillMyDrink/OpenSuperClone/releases)
  [![许可证](https://badgen.net/github/license/ispillmydrink/opensuperclone)](https://github.com/ISpillMyDrink/OpenSuperClone/blob/main/LICENSE)
  
</div>

<h4 align="center">
  基于<a href="https://www.hddsuperclone.com/">Scott Dwyer 的 HDDSuperClone</a>，功能强大的 Linux 数据恢复工具，具有多种高级功能。
</h4>

<p align="center">
  <a href="#-features">✨ 功能</a> •
  <a href="#-installation">💾 安装</a> •
  <a href="#-documentation">📖 文档</a> •
  <a href="#%EF%B8%8F-changelog">✏️ 更新日志</a> •
  <a href="#-credits">💵 鸣谢</a> •
  <a href="#-license">📄 许可证</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/ISpillMyDrink/OpenSuperClone/main/./doc/opensuperclone.gif" alt="Size Limit CLI" width="738">
</p>

## ✨ 功能

* 类似于 ddrescue 的先进驱动器<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Clone-Mode">克隆</a>能力
* 用于定向数据提取的<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Virtual-Disk-Mode">虚拟磁盘模式</a>
* 规避操作系统驱动的<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Direct-Modes">直接 AHCI/IDE</a>功能
* 用于驱动器自动电源循环的<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Relay-Operation">USB 继电器控制</a>

#### 📋 计划变更

有关计划变更列表，请参阅<a href="https://github.com/users/ISpillMyDrink/projects/2">路线图</a>。

## 💾 安装

OpenSuperClone 的预编译 DEB 和 RPM 软件包可在<a href=https://github.com/ISpillMyDrink/OpenSuperClone/releases>发布</a>页面找到。

有关从源码安装 OpenSuperClone 的说明，请参阅<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Compiling-from-Source">Wiki</a>。

此外，项目现由<a href="https://sourceforge.net/u/xak77/profile/">xak77</a>提供包含该项目的<a href="https://sourceforge.net/projects/opensuperclone-live/">Linux Live ISO</a>。

## 📖 文档

OpenSuperClone 的文档可在<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki">Wiki</a>中找到。
请注意，Wiki 目前仍在建设中，尚不完整。

## ✏️ 更新日志

#### OpenSuperClone 2.5.1（开发中）

* OSCDriver 2.6.7：添加对内核 6.14.0 的支持（感谢<a href="https://github.com/ISpillMyDrink/OpenSuperClone/pull/25">piernov</a>）

#### OpenSuperClone 2.5

* 实现了驱动程序安装的 DKMS
* OSCDriver 2.6.6：添加对内核 6.11.0 的支持（感谢<a href="https://github.com/ISpillMyDrink/OpenSuperClone/pull/19">piernov</a>）
* 禁用 USB 大容量存储驱动程序时也会禁用 USB 附加 SCSI 驱动程序
* 各种界面改进，包括大多数控件的工具提示以及改进的 SMART、分析和识别视图
* 添加了一些已知的 SMART 属性和识别标志
* 将最大重试次数从 8 次增加到 1000 次（对固态恢复有用）

#### OpenSuperClone 2.4.1

* 修复了界面标签显示错误字符串的错误

#### OpenSuperClone 2.4

* 移除了许可相关代码
* 实现了 CMake 构建系统
* 从 GTK2 切换到 GTK3
* 用 gettext 替换了本地化系统
* OSCDriver 2.6.1：添加对内核 5.19.11 的支持（感谢<a href="https://github.com/piernov/">piernov</a>）
* 对 OSCViewer 进行了小幅改进（颜色选择器，细微图形更改）

## 💵 鸣谢

感谢 Scott Dwyer 在<a href="https://www.hddsuperclone.com/">HDDSuperClone</a>上的卓越工作，
以及<a href="https://github.com/piernov/">piernov</a>对内核模块更新所做的贡献。

本项目使用了以下库/程序：
* GLADE (https://glade.gnome.org/)
* GTK (https://www.gtk.org/)
* libconfig (https://hyperrealm.github.io/libconfig/)
* libintl (https://www.gnu.org/software/gettext/)
* libusb (https://libusb.info/)
* Font Awesome (https://fontawesome.com/)

## 📄 许可证

本软件根据[GPLv2](LICENSE)授权。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---