
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [簡介](#introduction)
- [安裝](#install)
  - [Chrome](#chrome-based-browsers)
    - [圖像指南](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [如何使用](#how-to-use)
  - [新增時間](#adding-time)
    - [基礎課程](#adding-time-in-foundations)
    - [流暢度培養](#adding-time-in-fluency-builder)
  - [驗證課程](#validating-lesson)
    - [基礎課程](#validating-lesson-in-foundations)
    - [流暢度培養](#validating-lesson-in-fluency-builder)

## 介紹

RosettaStonks 是一款瀏覽器擴充功能，讓使用者能在 Rosetta Stone 語言學習平台上新增時間並驗證課程。

> RosettaStonks，讓你的 Rosetta Stone 變得 stonks。

## 安裝

### 基於 Chrome 的瀏覽器

➡️ **第一次手動安裝 Chrome 擴充功能嗎？** 請參考 [逐步視覺化教學](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — 內含實用截圖！🖼️

#### 1. 使用 GitHub 發佈版本

要在基於 Chrome 的瀏覽器中使用此擴充功能，請：

- 從最新發佈版本下載檔案 `rosettastonks-chrome.tar.gz`
  到您的電腦。
- 在您的電腦上建立一個名為 `rosettastonks` 的資料夾來儲存
  擴充功能。
- 在 `rosettastonks` 資料夾中執行以下指令。


```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. 使用 nix 套件管理器

如果你是在支援 **flakes** 的 nix 系統上，可以改用以下指令，
這些指令會在路徑 `/tmp/rosettastonks` 下安裝一個資料夾，
並包含所有檔案。

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

資料夾現已安裝於 `/tmp/rosettastonks/`

**本部分適用於所有使用者，無論您是使用 github 方法或 nix 方法。**

在您的瀏覽器中：

- 前往 `chrome://extensions`
- 開啟 `開發者模式` 切換
- 點擊 `載入未封裝項目`
- 選取您的 `rosettastonks` 資料夾

### 基於 Firefox 的瀏覽器

- 從最新發行版本下載 `rosettastonks.xpi` 檔案。
- 或者，如果您使用具備 flake 支援的 nix 套件管理器，您可以執行下列指令。



```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- 在瀏覽器中前往 `about:addons`
- 點擊設定按鈕並前往 `Debug addons`。
- 點擊 `Load Temporary Add-On`
- 在檔案選擇器中選擇 `/tmp/rosettastonks.xpi` 檔案。

_警告：此方法只會暫時安裝擴充功能，這代表如果你關閉瀏覽器，該附加元件將會被解除安裝。這是因為 Firefox 的政策不允許使用未驗證的擴充功能。_

## 如何使用

### 新增時間

#### 在 Foundations 中新增時間

若要在 `foundations` 產品中新增時間，你需要進入你的練習題，並至少點擊忽略或解決其中一題。完成後，擴充功能頁面應會出現一個可新增時間的欄位。

#### 在 Fluency builder 中新增時間

若要在 `fluency builder` 產品中新增時間，你需要進入你的練習題，並至少回答一題。如果未出現新增時間欄位，代表未偵測到時間請求，你需要重新整理題目並再次回答。要讓時間新增，必須完成你用來新增時間的課程。

_注意：如果看不到新增時間欄位，代表你在 Rosetta Stone 網站上的操作未能新增合法時間，因此你需要回答其他題目。_

### 驗證課程

#### 在 Foundations 中驗證課程

要驗證課程，需要開始一個課程，並通過底部右側的 `ignore` 按鈕瀏覽所有題目。當所有題目都看過後，點擊 `validate lesson` 按鈕即可驗證課程。如果未成功，請返回首頁，點擊相同課程，














應該會問你「你想繼續還是重設？」你可以選擇任一選項，
並再次驗證課程直到成功。最多應該3至4次就會成功。

#### 在 Fluency builder 中驗證課程

目前，rosetta stonks 上尚未提供驗證課程功能。

## 建置應用程式

### 建置 worker

可以使用以下指令將 worker 打包

```
$ deno task build:worker
```

這會產生封裝後的檔案 `/dist/worker.esm.js`，這是 worker 的封裝檔案。

### 前端建置

可以使用以下指令來封裝 worker


```
$ deno task build:frontend
```

這會建立封裝檔案 `/dist/frontend.esm.js`，這是前端的封裝檔案。

## 打包擴充功能

### Chrome

要將擴充功能打包給 Chrome，可以執行以下指令：


```
$ make chrome
```

### Firefox

要為 Firefox 打包擴充套件，可以執行以下指令：

```
$ make firefox
```

這將產生 `rosettastonks.xpi`，即可在 Firefox 中加載的擴充功能檔案。

📸 喜歡圖像說明？請參考[含圖片的 Chrome 安裝指南](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---