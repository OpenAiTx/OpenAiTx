
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![文件說明](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![授權](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![下載量](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock for future test.yaml)
[//]: # ([![測試狀態]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

一個用於將容器映像檔（Docker 等）轉換為 Git 儲存庫的 Rust 應用程式。每個容器層都被表示為一個 Git 提交，保留原始映像的歷史和結構。

![OCI2Git 轉換 nginx 映像的演示](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## 功能特色

- 分析 Docker 映像並提取層資訊
- 建立一個 Git 儲存庫，每個映像層都被表示為一個提交
- 支援空層（如 ENV、WORKDIR 等）以空提交方式呈現
- 完整的中繼資料抽取並匯出為 Markdown 格式
- 可擴充架構，支援不同的容器引擎

## 使用情境

### 層差異比對
在排查容器問題時，可以利用 Git 強大的差異比較功能來精確辨識任兩層之間的變更。透過在提交間執行 `git diff`，工程師可以清楚看到哪些檔案被新增、修改或刪除，更容易理解每個 Dockerfile 指令的影響並定位問題變更。
![層差異範例](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### 來源追蹤
利用 `git blame`，開發者能快速判斷是哪一層引入了特定檔案或程式碼行。這在診斷設定檔或相依套件問題時特別有用。無需手動檢查每一層，您可立即追溯任何檔案的來源層及對應的 Dockerfile 指令。

### 檔案生命週期追蹤
OCI2Git 讓您能夠追蹤特定檔案在容器映像歷史中的演變過程。您可以觀察檔案首次建立的時間、在各層間的修改，以及最終被移除的時點。這種全方位檢視，協助了解檔案演化過程，而不必手動追蹤數十層的變更。

要追蹤容器映像中檔案的歷史—包括首次出現、被修改或刪除的時點—您可以在轉換後使用以下 Git 指令：

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
這些指令讓您可以輕鬆追蹤任何檔案在各容器層中的完整歷史，而無需手動提取和比較層級 tarball 的複雜步驟。

### 多層分析
有時最具洞察力的比較來自於檢查多個非連續層級的變化。使用 OCI2Git，您可以利用 Git 的比較工具分析組件在多個建置階段中的演進，識別僅查看相鄰層級時可能看不見的模式。

### 層級探索
透過使用 `git checkout` 切換到任何特定的提交，您可以檢視容器檔案系統在該層級存在時的完整狀態。這讓開發人員能夠檢查影像創建過程中任意時點的檔案和目錄的精確狀態，為除錯或分析容器行為提供極具價值的背景資訊。
![切換至先前提交](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### 多影像分析

當處理多個具有共同祖先的容器影像時，OCI2Git 僅在影像實際分歧時才會智能地建立分支。這讓您能夠在單一儲存庫中分析多個相關影像，同時保留它們的共同歷史。


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git 會自動偵測映像檔之間的共享層，並建立反映其共同基礎的分支結構。Git 歷史記錄將顯示：
- 包含所有共享層的共同主幹
- 只有在映像檔實際不同時才分岔的獨立分支
- 清楚可視化映像檔共用祖先及何處開始獨特化
- 智慧重複處理：若完全相同的映像檔被處理兩次，演算法會在最終中繼資料提交前偵測並跳過建立重複分支

此方法特別適用於：
- **映像家族分析**：了解映像檔的不同變體（不同版本、架構或設定）彼此之間的關係
- **基礎映像影響**：精確檢視基礎映像的變更如何影響多個衍生映像檔
- **最佳化機會**：識別可在各映像變體間更好利用的共享元件

![多映像庫結構顯示共享基礎與分岔分支](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### 其他使用情境

- **安全稽核**：精確找出易受攻擊套件或設定被引入的時點，並追溯至特定建置指令。
- **映像最佳化**：分析層結構以尋找多餘操作或大型檔案，進而合併以協助減少映像檔大小。
- **相依性管理**：監控相依性在映像檔歷史中的新增、升級或移除時點。
- **建置流程優化**：檢查層組成以最佳化 Dockerfile 指令，提升快取效率並減少映像檔大小。
- **跨映像比較**：將多個相關映像檔轉換為 Git 儲存庫，並利用 Git 的比較工具分析其差異與共通性。

## 安裝

### 原始碼安裝


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### 從 Crates.io

```bash
cargo install oci2git
```

## 使用方法

```bash
oci2git [OPTIONS] <IMAGE>
```

參數：
  `<IMAGE>`  要轉換的映像名稱（例如：'ubuntu:latest'）或使用 tar 引擎時的 tarball 路徑

選項：
  `-o, --output <o>`  Git 儲存庫的輸出目錄 [預設值：./container_repo]
  `-e, --engine <ENGINE>`  要使用的容器引擎（docker、nerdctl、tar）[預設值：docker]
  `-h, --help`            列印說明資訊
  `-V, --version`         列印版本資訊

環境變數：
  `TMPDIR`  設定此環境變數以變更用於中間資料處理的預設位置。此設定依平台而異（例如 Unix/macOS 為 `TMPDIR`，Windows 則為 `TEMP` 或 `TMP`）。

## 範例

使用 Docker 引擎（預設）：
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

使用已下載的映像檔 tarball：
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
tar 引擎需要有效的 OCI 格式壓縮檔，這通常是用 `docker save` 建立的：

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

這將在 `./ubuntu-repo` 中建立一個 Git 儲存庫，內容包括：
- `Image.md` - 以 Markdown 格式記錄的完整映像中繼資料
- `rootfs/` - 從容器取得的檔案系統內容

Git 歷史記錄反映了容器的層次歷史：
- 第一個提交僅包含帶有完整中繼資料的 `Image.md` 檔案
- 每個後續提交代表原始映像中的一個層
- 提交訊息包含 Dockerfile 指令

## 儲存庫結構

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## 系統需求

- Rust 2021 版本
- Docker CLI（用於支援 Docker 引擎）
- Git

## 授權條款

MIT

[文件]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---