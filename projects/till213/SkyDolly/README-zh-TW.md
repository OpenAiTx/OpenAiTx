
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![預發布](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![授權：MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![支援編譯器](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)
[![詢問 DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/till213/SkyDolly)
![單元測試](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - 您飛行記錄的異類黑羊。

## 關於
Sky Dolly 連接到正在運行的 Flight Simulator 2020 實例，並記錄各種模擬變數，以供重播。

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

連線是通過 SimConnect 建立的，這是自 Flight Simulator X 引入的標準 API，用於連接飛行模擬器。

另請參閱 [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md)。

## 功能特色
- 錄製 / 暫停 / 播放
- 編隊飛行（多架飛機，錄製期間重播，「與編隊飛行」，時間偏移）
- 可設定的錄製取樣率：固定或可變（「自動」）
- 可調整的重播速度（「慢動作」、「縮時」），重播循環
- 位置、速度及基本飛行控制模擬變數（副翼、方向舵、襟翼、起落架等）皆可錄製
- 插件架構，支援多種匯入/匯出插件（CSV、GPX、IGC、KML）
- 位置模組，內建超過 100 個預設位置並支援匯入/匯出功能
- 以資料庫（SQLite）為基礎的持久化（「飛行日誌」）

觀看（預覽）發行預告片於 [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I)：

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

欲觀看更多使用 Sky Dolly 製作的影片，請參閱 [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md)。新功能及即將推出的特色可參見 [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md)。

## 基本用法

- 開始一趟飛行
- 點擊「錄製」（鍵 R）
- 您可以暫停錄製（鍵 P）
- 停止錄製（鍵 R），然後點擊「播放」（空白鍵）
- 可調整重播速度並尋找播放位置，重播期間亦可操作
- 錄製的飛行會自動保存於「飛行日誌」
- 在飛行日誌中選擇一筆飛行並按「載入」（或雙擊該列）即可載入保存的飛行

### 編隊錄製與重播

#### 錄製

- 切換到「編隊」模組（F2 鍵）
- 點擊「錄製」（R 鍵）
- 每架錄製的飛機都會加入當前航班
- 當現有飛機以「自動」取樣率回放錄製時，你仍可更改錄製取樣率

#### 位置

- 最後錄製的飛機會成為「使用者飛機」（被飛行模擬器的攝影機跟隨）
- 錄製前可選擇相對於當前「使用者飛機」的位置

#### 回放

- 只需點擊「播放」、「暫停」並在時間軸上尋找，就像單架飛機的飛行一樣
- 更改「使用者飛機」（回放期間亦可）以「在座艙間切換」
- 通過選擇「取得控制權」或「編隊飛行」選項來控制「使用者飛機」

#### 編隊管理

- 你可以從航班（「編隊」）中刪除單架飛機
- 每個航班至少需有一架飛機，因此最後一架不能被刪除
- 為所選飛機添加時間偏移（「多人編隊飛行同步」）
- 若要開始新的單架飛機航班，請切回「飛行日誌」模組（F1 鍵）並點擊「錄製」（R 鍵）

何不試試其中一個導覽式的 ["Tell Tours"](https://github.com/till213/Tell-Tours)？:)

## 下載

前往 [Releases](https://github.com/till213/SkyDolly/releases) 下載最新發佈版本。

最新（預發佈）版本：**Sky Dolly 0.19.2**

請計算並比對你的雜湊值與[已發布的 SHA-256 雜湊值](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md)，以驗證下載副本的完整性。

## 建置

請參考 [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md) 文件。

## 相關專案
- https://github.com/nguyenquyhy/Flight-Recorder - 一款基於 .Net 的飛行記錄與重播應用程式
- https://github.com/saltysimulations/saltyreplay/ - 具備網頁使用者介面的記錄與重播工具
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - 記錄飛行並產生 Google Earth（KML 格式）「重播」
- https://github.com/Elephant42/FS_Tool - 一個簡單工具，可設定飛機位置與模擬速率
- https://github.com/pyviator/msfs-geoshot - 擷取螢幕截圖並自動「地理標記」
- https://github.com/ijl20/msfs_logger_replay - IGC 記錄器與重播（適用於 FSX）
- https://joinfs.net/ - 可跨多種飛行模擬器（MSFS、Prepar3D/FSX、XPlane）同步多人飛行。另提供編隊飛行記錄器（「疊加錄製」）。
- https://github.com/paulalexandrow/a32nx-webremote - FlyByWire A32NX 的 WebRemote：利用 FSUIPC7 控制 FBW A320 的座艙功能
- https://flightloganalyzer.com/ - FlightLog Analyzer 分析 MSFS 飛行日誌並提供可供 Sky Dolly 讀取的 CSV 匯出
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave 可自動（或手動）儲存飛行計劃
- https://github.com/mracko/MSFS-Landing-Inspector - 分析您的降落表現
- [景點（Google 地圖）](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Microsoft Flight Simulator 中的景點、機場與 3D 城市。

## 其他實用資源

- https://obsproject.com/ - 螢幕擷取／直播應用程式
- https://sqlitebrowser.org/ - 瀏覽 Sky Dolly 飛行日誌 (*.sdlog) 資料庫檔案，執行自訂 SQL 查詢



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---