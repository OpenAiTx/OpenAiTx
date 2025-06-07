Bitcoin Core 整合／暫存樹
==========================

https://bitcoincore.org

如需立即可用的 Bitcoin Core 軟體二進位版本，請參閱
https://bitcoincore.org/en/download/。

什麼是 Bitcoin Core？
---------------------

Bitcoin Core 連接到比特幣點對點網路，以下載並完全驗證區塊和交易。它還包含一個錢包和圖形使用者介面，可選擇性地編譯建置。

關於 Bitcoin Core 的更多資訊，請參閱 [doc 資料夾](/doc)。

授權
----

Bitcoin Core 依 MIT 授權條款發佈。詳情請參閱 [COPYING](COPYING) 或 https://opensource.org/license/MIT。

開發流程
--------

`master` 分支會定期建置（請參閱 `doc/build-*.md` 以獲得說明）並進行測試，但不保證完全穩定。[標籤](https://github.com/bitcoin/bitcoin/tags) 會定期從發佈分支建立，用以標示 Bitcoin Core 的新官方、穩定發佈版本。

https://github.com/bitcoin-core/gui 儲存庫專供 GUI 的開發使用。其 master 分支在所有 monotree 儲存庫中皆相同。發佈分支和標籤不存在，因此請勿分支該儲存庫，除非是基於開發理由。

貢獻流程說明見 [CONTRIBUTING.md](CONTRIBUTING.md)，開發人員可在 [doc/developer-notes.md](doc/developer-notes.md) 找到實用提示。

測試
----

測試與程式碼審查是開發的瓶頸；我們收到的拉取請求多於能在短時間內審查和測試的數量。請耐心等待並協助測試其他人的拉取請求，並記得這是一個安全性極高的專案，任何錯誤都可能讓用戶損失大量資金。

### 自動化測試

強烈建議開發人員為新代碼撰寫[單元測試](src/test/README.md)，並為舊代碼提交新的單元測試。單元測試可編譯並執行（假設在產生建置系統時未被停用），方法為：`ctest`。有關執行和擴展單元測試的更多細節，請參閱 [/src/test/README.md](/src/test/README.md)。

也有用 Python 撰寫的[回歸與整合測試](/test)。
這些測試可在安裝好[測試相依套件](/test)後，透過以下方式執行：`build/test/functional/test_runner.py`
（假設 `build` 是您的建置目錄）。

CI（持續整合）系統確保每個拉取請求都能在 Windows、Linux 和 macOS 上建置，並自動執行單元／完整性測試。

### 手動品質保證（QA）測試

變更應由非原開發者進行測試。對於大型或高風險的變更尤為重要。如果測試變更並不簡單，請在拉取請求描述中附上測試計劃。

翻譯
----

對現有翻譯的更改以及新翻譯，可提交至
[Bitcoin Core 的 Transifex 頁面](https://www.transifex.com/bitcoin/bitcoin/)。

翻譯會定期從 Transifex 拉取並合併進 git 儲存庫。關於其運作方式，請參閱
[翻譯流程](doc/translation_process.md)。

**重要**：我們不接受以 GitHub 拉取請求方式提交的翻譯更動，因為下一次從 Transifex 拉取時將會自動覆蓋這些更動。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---