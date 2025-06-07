# Discord GNOME 主題

一個適用於 Discord 的 GNOME 主題，遵循 Adwaita 風格與 GNOME 人機介面指導原則（在 Discord CSS 所允許的範圍內實現）。

## 需求

1. Vesktop

   用於啟用 Windows 標題列。

2. 設定 > 語言 > 選擇「English (US)」

   這能讓自訂圖示正常顯示，因為 Discord 是依此辨識圖示。你可以[本地化](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss)這個主題，但請閱讀本地化說明。

3. 設定 > 插件 > 啟用「ThemeAttributes」

   這能讓設定對話框出現圖示。

4. 設定 > Vesktop 設定 > 啟用「Discord Titlebar」

   選用，但若你有標題列，建議啟用。

### 選用附加功能

1. 移除 Nitro 相關內容：https://github.com/CroissantDuNord/discord-adblock

## 主題設計理念

### 人機介面指導原則

由於 Discord 的 CSS 或設計限制，或是我的個人選擇，主題可能無法完全符合 HIG。

### 支援說明

以下內容不支援：

- Discord 實驗功能

  我不是 Discord 員工，無法得知這些實驗功能是否會被修改、棄用等，也就是維護負擔——我同時維護其他專案

- Nitro

  例外——任何能用 FakeNitro 插件存取的內容。

你**可以**針對上述內容提出 issue，但只有在很容易修復（如缺少圖示）時才會處理。

## 安裝方式

### 無需設定

將以下內容複製到 設定 > 主題 > 在線主題 的輸入框中：

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### 包含設定

將 [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) 放到 ~/.config/vesktop/themes。此檔案仍會自動更新。

## 預覽

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---