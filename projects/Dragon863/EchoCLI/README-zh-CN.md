> [!重要]
> 如果您想要获取 echo 的 root 权限，本项目现已废弃；请改用此处文档中介绍的方案 [here](https://xdaforums.com/t/unlock-root-twrp-unbrick-amazon-echo-dot-2nd-gen-2016-biscuit.4761416/)。非常感谢所有使此项目成为可能的人，开发这个项目非常有趣！ :)

# EchoCLI
针对您的 echo dot 第二代的有线 root 解决方案。
开始时，运行 `main.py`
<br>

[<kbd> <br> 这如何工作？ <br> </kbd>](https://dragon863.github.io/blog/echoroot.html)

## 注意
- 由于软件更新持续推送，我无法保证此方法对您的 echo 有效。如果遇到任何问题，欢迎联系我，发现漏洞也欢迎提交 pull request。
- 强烈建议您在 Linux 机器上运行此程序，因为我无法在 Windows 上测试，且不保证不存在 Windows 特定的错误。

> **警告**
> 
> **这是一个有线（TETHERED）root 方案** 建议阻止亚马逊的 OTA 服务器（https://d1s31zyz7dcc2d.cloudfront.net 和 https://d1s31zyz7dcc2d.cloudfront.prod.ota-cloudfront.net）以防止更新损坏或移除设备上的 root 权限。对于设备的任何损坏，我概不负责。

## 功能
- 通过 USB 或 Wi-Fi 获得 root 权限的 ADB shell
- 录制设备音频
- 在无互联网的情况下，将您的 Echo 用作 Home Assistant 的指示器
- 将设备恢复至出厂配置

## 安装
- 本项目需要 python 3。
- 推荐使用 Linux 运行此程序。请确保如果安装了 ModemManager，已将其禁用。
使用 `pip` 安装依赖：
```sh
pip install -r requirements.txt
```
- 您还需要 fastboot 和 ADB，关于如何安装它们，有一个很好的指南[这里](https://wiki.lineageos.org/adb_fastboot_guide)。下载后，您可以在 config.json 文件中设置可执行文件路径。
- 请确保用于连接 echo dot 的 micro USB 数据线是数据线，而非仅供电线缆。

## 文档
您可以在[我的网站](https://dragon863.github.io/blog/echoroot.html)上了解该工具的工作原理。

设备完成 root 后，将生成一个名为 `preloader_no_hdr.bin` 的文件。要启动设备，您需要安装 [mtkclient](https://github.com/bkerler/mtkclient)，将该文件复制到其目录下，并运行 `python mtk plstage --ptype=kamakiri2 --preloader=preloader_no_hdr.bin`。根据您安装的 Python 版本，将 `python` 替换为 `python3`。

## Home assistant 指示器
使用 Home assistant 指示器功能时，建议使用 Raspberry Pi Zero W 或其他小型 SBC 来运行 Python Flask 服务器并启动设备。您可以使用 crontab 设置开机自动通过 mtkclient 启动。

## Echo 变砖了？
请按照[这里](https://github.com/Dragon863/EchoCLI/blob/main/debrick.md)的指南使用 mtkclient 解砖已 root 或部分 root 的 echo。

## 致谢

本项目离不开以下支持：
- [j10hx40r](https://forum.xda-developers.com/m/j10hx40r.11878441/) - 帮助我最初 root 设备，重新设计补丁系统，演示如何结合使用 fos_flags，并在寻找资源时指引我方向
- [xyzz 的 Amonet](https://github.com/xyzz/amonet) - 这是我为本设备改编的漏洞利用代码，包括 bootrom 漏洞
- [chaosmaster](https://github.com/chaosmaster) - 编写了大量有用的 amonet 代码，我使用了其中多个片段，包括用于修复我的 GPT

## 联系我
- 您可以发送邮件至 dragon863.dev@gmail.com
- 您也可以在 [XDA](https://forum.xda-developers.com/m/lemon86.12487447/) 发起对话


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---