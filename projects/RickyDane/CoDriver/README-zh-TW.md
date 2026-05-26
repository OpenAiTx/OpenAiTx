
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
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='在 ko-fi.com 上請我喝咖啡' />
  </a>
</p>

<br/>

<p align="center">
  一個簡單的檔案總管，誕生的原因是我想學習 Rust 語言。
  <br>
  它是跨作業系統且針對最佳化而精簡設計。
</p>

<br/><br/>

此效能來自於 ["jwalk"](https://crates.io/crates/jwalk/versions) 與 ["Tauri"](https://tauri.app/)。
<br/><br/>
CoDriver 沒有使用路徑快取來存取檔案與資料夾，因此效能仰賴 Rust、硬碟速度與 CPU 效能。

⁉️ 請注意，此軟體仍在開發中，可能會有錯誤！
<br/><br/>

# 連結
- <a href="#basic-features">基本功能</a>
- <a href="#advanced-features">進階功能</a>
- <a href="#dependencies-if-not-working-instantly">相依套件</a>
- <a href="#%EF%B8%8F-ftp-sftp-integration">FTP / SFTP 整合</a>
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

## 🖥️ FTP / SFTP 整合

CoDriver 提供完全原生且開箱即用的 FTP 和 SFTP 遠端連線支援。不需要外部依賴、FUSE 層或 `sshfs` 掛載！只需在側邊欄面板直接連接您的遠端伺服器。

## 🏴‍☠️ 語言支援
- 英文
  - 即將推出語言選擇功能 ...

## ⚠️ 已知問題：
- 在 Linux 上，拖放出視窗目前並不總是有效
- 在 Windows 上，您可能需要安裝 [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- ms-windows 上的權限有點奇怪
  - 如果遇到複製元素等問題，可能需要以管理員身分執行程式
- 在 Linux 系統上，如果程式無法啟動，可能需要安裝 openssl1.1

## 📝 待辦事項：
- 多語言支援
- 收藏夾
- 存取線上儲存服務（Google 雲端硬碟等）

## 使用者介面
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## 如何貢獻
請依照 Tauri v1 應用程式開發環境設定： [Tauri 先決條件](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
完成後，只需在您的機器上執行 ```git clone https://github.com/RickyDane/CoDriver``` 或 ```gh repo clone RickyDane/CoDriver```。
</br></br>
您應該可以在本專案根目錄執行 ```cargo tauri dev``` 來開始建置並運行 CoDriver。
</br>
請確保已安裝 tauri-cli：```cargo install tauri-cli```
</br>

## 發行簽名

macOS 發行成品必須簽名並經過公證，才能避免 Gatekeeper 報告已安裝的應用程式損壞。請參閱 [macOS 簽名與公證](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) 以取得所需的 GitHub Actions 機密及驗證指令。

## 星星歷史

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="星星歷史圖表" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### 其他第三方軟體
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---