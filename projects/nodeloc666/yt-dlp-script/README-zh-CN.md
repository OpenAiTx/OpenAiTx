
# 🎬 yt-dlp 视频批量下载工具（Windows / Linux 支持）

> 基于 [yt-dlp](https://github.com/yt-dlp/yt-dlp) 的一键式视频下载脚本，灵感来源于 [NodeSeek 大佬的分享](https://www.nodeseek.com/post-334093-2#15)。
> 支持单视频与批量下载，兼容 Windows 与主流 Linux 发行版（Debian / Ubuntu / Alpine / CentOS）。

---

## ✨ 功能特色

* 📥 **一键运行**：无需手动配置，按提示输入即可开始下载
* 🍪 **支持自定义 Cookie**：适用于需要登录才能下载的视频（⚠️ 该功能尚未验证，可能存在 Bug）
* 📂 **支持自定义输出目录**：轻松保存到指定文件夹
* 📃 **支持批量下载**：自动读取 `urls.txt` 文件中的链接进行下载
* ⚙️ **自动安装依赖**：Linux 环境下自动安装 `yt-dlp` 和 `ffmpeg`

---

## 🖼️ 截图预览

| 示例 1                                                                   | 示例 2                                                                   |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![示例 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![示例 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![示例 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![示例 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows 使用方法

1. 下载以下文件：

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows 版本](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. 解压后，将下列文件放入同一目录（如 `yt-dlp` 文件夹）：

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat`（脚本文件）

3. 双击运行 `yt-dlp.bat`，根据提示操作即可下载视频。
4. 编辑config/config.ini进行默认配置修改

---

## 🐧 Linux 使用方法(科技lion大佬最新脚本内也集成了相同功能脚本)

**支持系统**：Debian / Ubuntu / Alpine / CentOS

一键部署或更新并运行：

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```
如需卸载：


```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Android 使用推荐

1. 使用 [Seal](https://github.com/JunkFood02/Seal) App，在 Android 上体验 `yt-dlp` 功能。
2. termux安装Debian也能下载，不过咱没必要用这个，Seal非常好用

---

## ⚠️ 注意事项

1. **批量下载模式**：脚本将自动读取当前目录下的 `config\urls.txt`，每行一个视频链接。若文件不存在，将自动创建。
2. **资源占用提示**：内存较小的设备请避免同时下载多个大视频，或设置过高的并发线程。
3. **CentOS 特别说明**：由于环境较为特殊，尚未全面测试，建议在非生产环境中使用。其余主流系统均已验证可用。
4. Linux版小bug：脚本运行到首页，就会检测一次依赖，遵从代码能跑就行的原则，懒得改了
5. Windows版小bug：当其他页面回到首页，再进行选择时，默认选项可能会失效，然后卡循环，能力有限，没修复好
两种解决方案：
    1. 退出重新运行
    2. 不要默认，按照数字选就行

---

## 📄 License

本项目遵循 [MIT 许可证](https://opensource.org/licenses/MIT)。

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---