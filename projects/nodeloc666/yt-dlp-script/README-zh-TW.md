<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp 視頻批量下載工具（支援 Windows / Linux）

> 基於 [yt-dlp](https://github.com/yt-dlp/yt-dlp) 的一鍵式視頻下載腳本，靈感來源於 [NodeSeek 大佬的分享](https://www.nodeseek.com/post-334093-2#15)。
> 支援單視頻與批量下載，兼容 Windows 及主流 Linux 發行版（Debian / Ubuntu / Alpine / CentOS）。

---


## ✨ 功能特色

* 📥 **一鍵運行**：無需手動配置，按照提示輸入即可開始下載
* 🍪 **支援自訂 Cookie**：適用於需要登入才能下載的影片（⚠️ 此功能尚未驗證，可能存在 Bug）
* 📂 **支援自訂輸出目錄**：輕鬆保存到指定資料夾
* 📃 **支援批次下載**：自動讀取 `urls.txt` 檔案中的連結進行下載
* ⚙️ **自動安裝依賴**：Linux 環境下自動安裝 `yt-dlp` 和 `ffmpeg`

---

## 🖼️ 截圖預覽

| 範例 1                                                                   | 範例 2                                                                   |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![範例 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![範例 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![範例 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![範例 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows 使用方法

1. 下載以下檔案：

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows 版本](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. 解壓後，將下列檔案放入同一目錄（如 `yt-dlp` 資料夾）：

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat`（腳本檔案）

3. 雙擊執行 `yt-dlp.bat`，依提示操作即可下載影片。
4. 編輯 config/config.ini 進行預設配置修改

---

## 🐧 Linux 使用方法（科技lion大佬最新腳本內也集成了相同功能腳本）

**支援系統**：Debian / Ubuntu / Alpine / CentOS

一鍵部署或更新並運行：

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

如需解除安裝：

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Android 使用推薦

1. 使用 [Seal](https://github.com/JunkFood02/Seal) App，在 Android 上體驗 `yt-dlp` 功能。
2. termux安裝Debian也能下載，不過咱沒必要用這個，Seal非常好用

---

## ⚠️ 注意事項

1. **批量下載模式**：腳本將自動讀取當前目錄下的 `config\urls.txt`，每行一個影片連結。若檔案不存在，將自動建立。
2. **資源佔用提示**：記憶體較小的設備請避免同時下載多個大型影片，或設定過高的並發執行緒。
3. **CentOS 特別說明**：由於環境較為特殊，尚未全面測試，建議在非生產環境中使用。其餘主流系統均已驗證可用。
4. Linux版小bug：腳本運行到首頁時，會檢查一次依賴，遵從程式能跑就好的原則，懶得改了
5. Windows版小bug：當其他頁面回到首頁，再進行選擇時，預設選項可能會失效，然後卡在循環，能力有限，沒修好
兩種解決方案：
    1. 退出重新執行
    2. 不要預設，按照數字選就行

---

## 📄 License

本專案遵循 [MIT License](https://opensource.org/licenses/MIT)。

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---