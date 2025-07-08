# MoneyPrinter 💸

> ♥︎ 贊助商：最佳 AI 聊天應用程式：[shiori.ai](https://www.shiori.ai)
---

> 𝕏 同時，歡迎在 X 上關注我：[ @DevBySami ](https://x.com/DevBySami)。

只需提供一個你想討論的影片主題，即可自動化製作 YouTube Shorts。

<a href="https://trendshift.io/repositories/7545" target="_blank"><img src="https://trendshift.io/api/badge/repositories/7545" alt="FujiwaraChoki%2FMoneyPrinter | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

> **重要** 請務必先瀏覽現有/已關閉的問題，再建立新的問題。如果只是有問題想詢問，請加入我們的 [discord](https://dsc.gg/fuji-community) 並在那裡提問。

> **🎥** 在 [YouTube](https://youtu.be/mkZsaDA2JnA?si=pNne3MnluRVkWQbE) 上觀看教學影片。

本地端版本的說明請參閱[這裡](https://raw.githubusercontent.com/FujiwaraChoki/MoneyPrinter/main/Local.md)。

## FAQ 🤔

### 如何取得 TikTok session ID？

你可以在瀏覽器登入 TikTok，然後複製 `sessionid` cookie 的值來取得你的 TikTok session ID。

### 我的 ImageMagick 執行檔無法被偵測到

請確保你在 `.env` 檔案中正確設定了 ImageMagick 執行檔的路徑，應如下所示：

```env
IMAGEMAGICK_BINARY="C:\\Program Files\\ImageMagick-7.1.0-Q16\\magick.exe"
```

請記得在路徑中要使用雙反斜線（`\\`），不要只用一個。

### 我無法安裝 `playsound`：Wheel 編譯失敗

如果你在安裝 `playsound` 時遇到問題，可以嘗試使用以下指令安裝：

```bash
pip install -U wheel
pip install -U playsound
```

如果你還是無法找到解決方法，請在 discord 詢問或建立新問題，以便社群協助你。

## 贊助 🎁

如果你喜歡並享受使用 `MoneyPrinter`，並且想要贊助，可以點擊儲存庫右側的按鈕進行贊助。❤️
作為感謝，你的名字（和/或 logo）將被加入此儲存庫，作為支持者留名。

## 貢獻 🤝

目前暫不接受 Pull Requests。

## Star 歷史 🌟

[![Star History Chart](https://api.star-history.com/svg?repos=FujiwaraChoki/MoneyPrinter&type=Date)](https://star-history.com/#FujiwaraChoki/MoneyPrinter&Date)

## 授權 📝

更多資訊請參閱 [`LICENSE`](LICENSE) 檔案。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---