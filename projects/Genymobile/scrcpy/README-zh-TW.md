**這個 GitHub 儲存庫 (<https://github.com/Genymobile/scrcpy>) 是本專案的唯一官方來源。請勿從隨機網站下載發佈版本，即使其名稱中包含 `scrcpy`。**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_發音為 "**scr**een **c**o**py**"_

本應用程式可鏡像透過 USB 或 [TCP/IP](doc/connection.md#tcpip-wireless) 連接的 Android 裝置（影像與音訊），並允許使用電腦的鍵盤與滑鼠進行控制。它不需要 _root_ 權限或在裝置上安裝應用程式。支援 _Linux_、_Windows_ 與 _macOS_。

![screenshot](assets/screenshot-debian-600.jpg)

主要特點：

 - **輕量化**：原生，僅顯示裝置螢幕
 - **高效能**：30~120fps，視裝置而定
 - **高畫質**：1920×1080 或更高
 - **低延遲**：[35~70ms][lowlatency]
 - **啟動快**：~1 秒顯示第一張畫面
 - **非侵入性**：Android 裝置上不會留下任何安裝檔
 - **用戶友好**：無需帳號、無廣告、不需網路
 - **自由**：自由且開源的軟體

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

其功能包含：
 - [音訊轉發](doc/audio.md)（Android 11+）
 - [螢幕錄影](doc/recording.md)
 - [虛擬顯示器](doc/virtual_display.md)
 - [裝置螢幕關閉下的鏡像](doc/device.md#turn-screen-off)
 - 雙向 [複製貼上](doc/control.md#copy-paste)
 - [可調整畫質](doc/video.md)
 - [鏡像相機](doc/camera.md)（Android 12+）
 - [作為網路攝影機鏡像（V4L2）](doc/v4l2.md)（僅限 Linux）
 - 實體 [鍵盤][hid-keyboard] 與 [滑鼠][hid-mouse] 模擬（HID）
 - [遊戲手把](doc/gamepad.md) 支援
 - [OTG 模式](doc/otg.md)
 - 以及更多……

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## 先決條件

Android 裝置至少需為 API 21（Android 5.0）。

[音訊轉發](doc/audio.md) 僅支援 API >= 30（Android 11+）。

請確保你已在裝置上[啟用 USB 除錯][enable-adb]。

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

在某些裝置（特別是小米）上，你可能會遇到以下錯誤：

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

此時，你需要啟用[額外選項][control] `USB 除錯（安全設置）`（這與 `USB 除錯` 是不同項目），以便使用鍵盤和滑鼠控制。設定後需重啟裝置。

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

請注意，若使用 [OTG 模式](doc/otg.md) 運行 scrcpy，則不需 USB 除錯功能。

## 取得應用程式

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md)（請閱讀[如何執行](doc/windows.md#run)）
 - [macOS](doc/macos.md)

## 必知技巧

 - [降低解析度](doc/video.md#size) 可大幅提升效能（`scrcpy -m1024`）
 - [_右鍵點擊_](doc/mouse.md#mouse-bindings) 觸發 `BACK`
 - [_中鍵點擊_](doc/mouse.md#mouse-bindings) 觸發 `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> 切換 [全螢幕](doc/window.md#fullscreen)
 - 還有許多其他 [快捷鍵](doc/shortcuts.md)

## 使用範例

有許多選項，[詳細說明](#user-documentation)於不同頁面。這裡僅列出常見範例。

 - 以 H.265（較佳畫質）擷取畫面，限制最大尺寸為 1920，最大幀率為 60fps，關閉音訊，並以實體鍵盤模擬控制裝置：

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # 簡寫版
    ```

 - 在新的虛擬顯示器（與裝置螢幕分離）中啟動 VLC：

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - 以 H.265 及 1920x1080（含麥克風）錄製裝置相機，並儲存為 MP4 檔：

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - 擷取裝置前鏡頭並將其作為電腦網路攝影機（僅限 Linux）：

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - 僅以實體鍵盤與滑鼠模擬控制裝置，不進行螢幕鏡像（不需 USB 除錯）：

    ```bash
    scrcpy --otg
    ```

 - 使用插入電腦的遊戲手把控制裝置：

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # 簡寫版
    ```

## 使用者文件

本應用程式提供大量功能與設定選項，詳細說明如下頁面：

 - [連線](doc/connection.md)
 - [影像](doc/video.md)
 - [音訊](doc/audio.md)
 - [控制](doc/control.md)
 - [鍵盤](doc/keyboard.md)
 - [滑鼠](doc/mouse.md)
 - [遊戲手把](doc/gamepad.md)
 - [裝置](doc/device.md)
 - [視窗](doc/window.md)
 - [錄影](doc/recording.md)
 - [虛擬顯示器](doc/virtual_display.md)
 - [通道](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [相機](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [快捷鍵](doc/shortcuts.md)

## 資源

 - [常見問題](FAQ.md)
 - [翻譯][wiki]（可能不是最新）
 - [編譯指引](doc/build.md)
 - [開發者資訊](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## 相關文章

- [Introducing scrcpy][article-intro]
- [Scrcpy 現已支援無線連線][article-tcpip]
- [Scrcpy 2.0，支援音訊][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## 聯絡方式

你可以提交 [issue] 以回報錯誤、提出新功能需求或一般性問題。

回報錯誤前，請先閱讀 [常見問題](FAQ.md)，你可能能立即找到解決方法。

[issue]: https://github.com/Genymobile/scrcpy/issues

你也可以使用：

 - Reddit：[`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky：[`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter：[`@scrcpy_app`](https://twitter.com/scrcpy_app)

## 捐款支持

我是 [@rom1v](https://github.com/rom1v)，_scrcpy_ 的作者與維護者。

如果你喜歡這個應用程式，歡迎 [支持我的開源工作][donate]：
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## 授權條款

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    本程式依 Apache License, Version 2.0（以下簡稱「授權條款」）授權；
    除非符合授權條款，否則不得使用本檔案。
    你可以在下列網址取得授權條款副本：

        http://www.apache.org/licenses/LICENSE-2.0

    除非適用法律要求或書面同意，否則根據本授權條款散布的軟體，
    均以「現狀」(AS IS) 提供，不附任何明示或暗示之擔保條款。
    詳情請參閱授權條款內容。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---