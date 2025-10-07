
# 🎬 yt-dlp Video Batch Download Tool (Windows / Linux Supported)

> A one-click video download script based on [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspired by [NodeSeek's sharing](https://www.nodeseek.com/post-334093-2#15).  
> Supports single video and batch downloads, compatible with Windows and mainstream Linux distributions (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Features

* 📥 **One-click run**: No manual configuration needed, just input as prompted to start downloading  
* 🍪 **Supports custom Cookie**: Suitable for videos that require login to download (⚠️ This feature is unverified and may contain bugs)  
* 📂 **Supports custom output directory**: Easily save to a specified folder  
* 📃 **Supports batch downloading**: Automatically reads links from the `urls.txt` file for downloading  
* ⚙️ **Automatic dependency installation**: Automatically installs `yt-dlp` and `ffmpeg` in Linux environments

---

## 🖼️ Screenshot Preview

| Example 1                                                                | Example 2                                                                |
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
3. Double-click to run `yt-dlp.bat` and follow the prompts to download the video.  
4. Edit config/config.ini to modify the default configuration.  

---

## 🐧 Linux Usage (The latest script by tech lion also integrates the same functional script)  

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---