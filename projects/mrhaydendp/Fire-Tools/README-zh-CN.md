# <p align="center">Fire 工具</p>

[![GitHub 下载统计)](https://img.shields.io/github/downloads/mrhaydendp/Fire-Tools/total?style=for-the-badge)](https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip) [![最新版本](https://img.shields.io/github/v/release/mrhaydendp/Fire-Tools?style=for-the-badge
)](https://github.com/mrhaydendp/fire-tools/releases/latest)

Fire 工具是一款强大的工具合集，帮助您在 Fire 平板上去除冗余应用并安装 Google 服务，使设备运行更流畅，提升可用性。此外，它支持自定义启动器，如 Nova、Lawnchair 或任何 `.apk(m)` 文件。如果您需要快速安装多个应用，还有批量安装器。只需将所有 `.apk(m)` 文件放入 Batch 文件夹，然后点击批量安装按钮即可！无需 root 权限！

![Fire 工具截图](https://raw.githubusercontent.com/mrhaydendp/Fire-Tools/main/Screenshot.png)

**功能特点：**
* 跨平台支持（Linux、macOS 和 Windows）
* 强力去除冗余工具
* 限制亚马逊追踪与广告
* Google Play 安装器（Android 8+/Fire OS 7+）
* 支持自定义启动器（新版 Fire OS 使用 LauncherHijack）
* 禁用 OTA 更新
* Apk 提取器
* 批量安装器（支持 .apk 和 .apkm 文件）
* 自定义 DNS 选择（AdGuard、Cloudflare 等）

**安装说明（Python）：**

请先按照 [Setup-Instructions.md](/Setup-Instructions.md) 中的步骤操作，然后进行安装。安装后运行更新工具以获取最新脚本版本！

**Linux/macOS：**

``` shell
# Download Latest Release & Extract, Then Run
curl -LO https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip
unzip Fire-Tools.zip && rm Fire-Tools.zip
cd Fire-Tools
chmod +x Scripts/Posix/*.sh
pip3 install -r requirements.txt
python3 main.py
```

**Windows Powershell：**

``` powershell
# Download Latest Release & Extract, Then Run
Start-BitsTransfer "https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip"
Expand-Archive .\Fire-Tools.zip .\; Remove-Item .\Fire-Tools.zip
Set-Location Fire-Tools
pip install -r requirements.txt
python main.py
```

**重要说明：**

* 虽然本项目目标类似，但与Datastream33的Amazon Fire Toolbox无关联
* 由于Fire OS更新，Fire Tools的某些功能可能会失效，但我会尽力保持其正常运行。
* 在进行精简前请先设置时区！ （重新启用 `com.amazon.kindle.otter.oobe` 以更改日期和时间设置）
* Google应用从[ApkMirror](https://www.apkmirror.com/)下载，并包含在发布版本中以方便使用，详情见[条款](https://github.com/mrhaydendp/Fire-Tools/blob/main/Fire-Tools/Gapps/README.md)。APK名称及对应URL可见Fire-Tools/Gapps/README.md
* 精简将禁用大多数亚马逊应用，例外包括：`Calculator`、`Camera`、`Clock`、`Files`、`Fire Launcher`、`Silk Browser` 和 `Settings`
* 保修与重置：使用Fire Tools不会使您的保修失效，且所有更改都可通过恢复出厂设置撤销。
* 免责声明：虽然此工具由我开发，但对其使用过程中产生的任何问题不承担责任。

**鸣谢：** Fire Tools感谢并致敬以下项目。它们已包含以方便您使用：

* [Google](https://www.android.com/)（谷歌应用）
* [TeslaCoil Software](https://novalauncher.com/)（Nova Launcher）
* [Lawnchair](https://github.com/LawnchairLauncher/Lawnchair)（Lawnchair）
* [BaronKiko](https://github.com/BaronKiko/LauncherHijack)（LauncherHijack）
* [D0k3](https://github.com/d0k3/OneClick-for-Amazon-Fire)（灵感来源于他们的OneClick-for-Amazon-Fire工具）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---