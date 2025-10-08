
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp Batch Video Download Tool (Windows / Linux Supported)

> One-click video download script based on [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspired by [NodeSeek's sharing](https://www.nodeseek.com/post-334093-2#15).
> Supports single video and batch downloads, compatible with Windows and mainstream Linux distributions (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Features

* 📥 **One-click Run**: No manual configuration required, just follow the prompts to start downloading
* 🍪 **Custom Cookie Support**: Suitable for downloading videos that require login (⚠️ This feature is not yet verified and may have bugs)
* 📂 **Custom Output Directory Support**: Easily save to your specified folder
* 📃 **Batch Download Support**: Automatically reads links from the `urls.txt` file for downloading
* ⚙️ **Automatic Dependency Installation**: Automatically installs `yt-dlp` and `ffmpeg` on Linux environments

---

## 🖼️ Screenshot Preview

| Example 1                                                               | Example 2                                                               |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Example 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Example 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Example 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Example 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows Usage

1. Download the following files:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows version](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. After extraction, place the following files in the same directory (e.g. `yt-dlp` folder):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (script file)

3. Double-click `yt-dlp.bat` and follow the prompts to download videos.
4. Edit config/config.ini to modify default configurations

---

## 🐧 Linux Usage (The latest script from techlion also integrates the same functionality script)

**Supported Systems**: Debian / Ubuntu / Alpine / CentOS

One-click deployment or update and run:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

To uninstall:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Recommended Android Usage

1. Use the [Seal](https://github.com/JunkFood02/Seal) App to experience `yt-dlp` functionality on Android.
2. Installing Debian on termux can also download, but there's no need to use that; Seal is very user-friendly.

---

## ⚠️ Notes

1. **Batch Download Mode**: The script will automatically read `config\urls.txt` in the current directory, with one video link per line. If the file does not exist, it will be created automatically.
2. **Resource Usage Reminder**: Devices with limited memory should avoid downloading multiple large videos simultaneously or setting too high concurrency threads.
3. **CentOS Special Note**: Due to a special environment, it has not been fully tested yet; it is recommended to use in non-production environments. Other mainstream systems have been verified to work.
4. Linux version minor bug: The script checks dependencies once when running to the homepage; following the principle of code that runs is fine, so no fix has been made.
5. Windows version minor bug: When returning to the homepage from other pages and then making a selection, the default option may become invalid, causing a loop; limited capability, no proper fix yet.
Two solutions:
    1. Exit and restart
    2. Avoid default, just select by number

---

## 📄 License

This project follows the [MIT License](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---