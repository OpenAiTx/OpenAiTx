<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <p>以下翻譯是使用 AI 自動生成的。請注意，可能包含不準確或參考本說明文件舊版本的內容。</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

播放器集數預覽
====================
## 📄 關於
此外掛會在影片播放器中新增集數列表，讓您可以直接預覽影集的每一集，而無需離開播放器。

此修改支援以下客戶端：
* [Jellyfin 網頁端客戶端](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin 多媒體播放器](https://github.com/jellyfin/jellyfin-media-player) (JMP) 桌面客戶端

## ✨ 功能特色
* 列出一季的所有劇集
* 在季之間切換
* 顯示劇集標題、描述、縮圖及播放進度
* 顯示劇集詳細資訊如社群排名
* 標記劇集為已播放或收藏
* 開始新的劇集
* 支援自訂主題

## 📸 預覽
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

使用主題：(SkinManager) Kaleidochromic
<br>
此預覽缺少了標記劇集為已完成或收藏的新按鈕。

## 🔧 安裝方式

### Jellyfin 網頁客戶端（伺服器端）

> [!NOTE]
> 強烈建議安裝至少 v2.2.1.0 版本的 [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation)。此插件有助於避免在任何安裝類型下修改 index.html 時的權限問題！
<details open>
<summary> 查看安裝說明... </summary>

1. 將 manifest `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` 新增為 Jellyfin 插件倉庫至您的伺服器。
2. 從倉庫安裝插件 `InPlayerEpisodePreview`。
3. 重新啟動 Jellyfin 伺服器。
</details>

### Jellyfin Media Player (JMP) 桌面客戶端（已棄用）
<details>
<summary> 查看安裝說明... </summary>

**自 JMP 版本 [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0) 起已棄用**

由於新的 JMP 客戶端使用伺服器上的現行網頁播放器，不再需要直接對客戶端程式碼進行任何更改。

這是推薦的桌面客戶端安裝此腳本方式。
如果你不想自行編輯 nativeshell.js 檔案（步驟 3 到 6），你可以直接下載完整發佈版，其中已經包含將腳本加入至 nativeshell.js 檔案的內容。
目前尚不清楚直接用發佈版中的 nativeshell.js 檔案替換，是否可能產生潛在問題，因此建議仍依照下方所有步驟進行。

1. 下載最新版發佈檔 [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) 或 [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip)（已將腳本加入 nativeshell.js 檔案）
2. 將 zip 檔解壓縮至你的 Jellyfin 目錄（例如：C:\Program Files\Jellyfin\Jellyfin Media Player）
3. 在 Jellyfin 目錄中依路徑進入 "web-client\extension" 資料夾
4. 使用文字編輯器開啟 "nativeshell.js" 檔案。
5. 在檔案中找到 `const plugins = [];` 段落。於列表開頭新增一行，貼入 `'inPlayerEpisodePreviewPlugin',`。該段落現在應如下所示：
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. 儲存檔案並重新啟動 JMP 用戶端。
</details>

## 💡 疑難排解

### 1. 預覽按鈕無法顯示
這很可能與 `index.html` 檔案的權限錯誤有關。

<details>
<summary> 查看可能的解決方案列表... </summary>

#### 1.1 使用 [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) 外掛程式來避免此問題。

#### 1.2 在 docker 容器中更改所有權
如果你在 docker 容器中運行 jellyfin，可以使用以下命令更改所有權
（將 jellyfin 替換為你的容器名稱，user 和 group 替換為你的容器用戶及群組）：
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
你可以在系統啟動時將此設為 cron 工作來執行。
（感謝 [muisje](https://github.com/muisje) 協助解決 [這個](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) 問題）

#### 1.3 在 Windows 安裝環境下變更所有權
1. 前往：`C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. 右鍵點擊 `index.html` → 選擇「內容」→「安全性」頁籤 → 點擊「編輯」
3. 從列表中選擇你的使用者並勾選「寫入」權限方塊。
4. 重新啟動伺服器與客戶端。
   （感謝 [xeuc](https://github.com/xeuc) 提供 [這個](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) 解決方案）

如果上述解決方案皆無效，請參考舊的問題。例如 [此處](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) 或 [此處](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)。
</details>

<br/>
<br/>
如果你遇到無法自行解決的錯誤，歡迎提出問題。
<br/>請記得每個系統都不同，可能導致非預期行為，因此請盡可能提供詳細資訊。
<br/>Jellyfin 日誌以及瀏覽器主控台日誌（前綴為 [InPlayerEpisodePreview]）都非常有幫助。

## 鳴謝
此外掛結構受 [NickNSY](https://github.com/nicknsy) 的 [Jellyscrub](https://github.com/nicknsy/jellyscrub) 外掛啟發和借鑒。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---