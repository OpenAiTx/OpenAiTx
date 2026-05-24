
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  一個簡單的檔案總管，誕生於我想學習 Rust 語言的動機。
  <br>
  它是作業系統無關，並針對最佳化進行過精簡。
</p>

<br/><br/>

此效能來自於 ["jwalk"](https://crates.io/crates/jwalk/versions) 和 ["Tauri"](https://tauri.app/)。
<br/><br/>
CoDriver 並未使用路徑快取來存取檔案與資料夾，因此效能取決於 Rust、磁碟速度以及 CPU 的運算能力。

⁉️ 請注意此軟體仍在開發中，可能會有錯誤發生！
<br/><br/>

# 連結
- <a href="#basic-features">基本功能</a>
- <a href="#advanced-features">進階功能</a>
- <a href="#dependencies-if-not-working-instantly">相依性</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP 實作（SSHFS）</a>
- <a href="#%EF%B8%8F-known-issues">已知問題</a>
- <a href="#-todos">待辦事項</a>
- <a href="#user-interface">使用者介面</a>

## 基本功能
- 以熟悉的方式瀏覽目錄
- 複製與貼上、刪除、新建與重新命名檔案和資料夾
- 在網格、清單和米勒欄模式間切換
- 按下 esc 關閉彈出視窗
- 透過 Ctrl / Cmd + G 輸入路徑直接跳轉至目錄
- 在清單模式下依大小、名稱或最後修改時間排序項目

## 進階功能
- 壓縮檔案與資料夾
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- 解壓縮檔案
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- 使用快捷鍵 LAlt + 1 / 2 / 3 (macOS 為 option + 1 / 2 / 3) 導航至目錄
  - 可在設定中自訂路徑
- 按 F6 新建檔案
- 按 F7 新建資料夾
- 雙窗格視圖
  - 按 F8 搜尋檔案
  - 按 F5 將當前選取項目複製到另一窗格
  - 按 LShift + F5 將當前選取項目移動到另一窗格
- 拖曳檔案到檔案總管以複製到當前目錄
- 使用 Ctrl / Cmd + LShift + M 批次重新命名所選項目
  - 使用 Ctrl / Cmd + Enter 執行批次重新命名
- 檔案快速預覽 -> 選取目錄項並按空白鍵
  - 支援檔案類型：所有圖片檔案（.jpg、.png 等）、.pdf、.mp4、.json、.txt、.html
  - 其他項目將顯示包含其資訊（路徑、大小、最後修改時間）的小方塊
- 即時導覽 -> 開始輸入即可自動篩選目錄項目，有時 <br/>
  能更快速地導覽到想要的位置

## 依賴項（如果無法立即運作）

<details>
<summary>展開以顯示</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### 架構
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ FTP 整合（sshfs）
<details>
  <summary>展開以顯示</summary>
  <br/>
  依賴項（需要另外安裝）：
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | 尚未支援 **_yet_** |

  ### 安裝方式：
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ 語言支援
- 英文
  - 選擇語言的選項即將推出……
</details>

## ⚠️ 已知問題：
- 在 Linux 上，拖放到視窗外目前不一定能正常運作
- 在 Windows 上，你可能需要安裝 [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- 在 ms-windows 上的權限有點奇怪
  - 如果遇到無法複製元件等問題，可能需要以系統管理員身份執行程式
- 如果程式無法啟動，在 Linux 系統上可能需要安裝 openssl1.1

## 📝 待辦事項：
- 多語言支援
- 我的最愛
- 存取線上儲存服務（Google Drive 等）

## 使用者介面

### 清單樣式
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### 網格樣式
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### 米勒欄檢視
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### 雙分割視窗
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## 如何參與貢獻
為 tauri v1 應用程式開發設定你的機器：[Tauri 先決條件](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
完成後，只需在你的機器上執行 ```git clone https://github.com/RickyDane/CoDriver``` 或 ```gh repo clone RickyDane/CoDriver```。
</br></br>
你應該可以在此專案根目錄下執行 ```cargo tauri dev``` 來開始建構與運行 CoDriver。
</br>
請確保已安裝 tauri-cli：```cargo install tauri-cli```
</br>

## 發佈簽章

macOS 發佈產物必須經過簽章及公證，否則 Gatekeeper 會報告安裝的應用程式已損壞。請參閱 [macOS 簽章與公證](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) 以取得所需的 GitHub Actions 機密和驗證指令。

## Star 歷史

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### 其他第三方軟體
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---