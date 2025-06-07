<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />

  <p>
    <strong>專為各種用途而設計的快速且模組化閃電網路實作，採用 Rust 編寫。</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">專案首頁</a>
  </h4>
</div>

## Crates

以下是目前支援的完整 crates 清單：

| Crate       | 說明                                   | 版本     |
|:------------|:--------------------------------------:|---------:|
| lampod-cli  | Lampo Daemon 指令列介面，用於啟動守護程式 | _未相關_ |
| lampo-cli   | 簡易 Lampo 指令列介面，用於與守護程式互動 | _未相關_ |

## 安裝方式

要安裝所有需求套件及 Lampo 執行檔，您需要先安裝 rust，然後執行下列指令：

```
make install
```

當您有了 `lampod-cli` 和 `lampo-cli` 之後，可以執行以下指令以 signet 模式啟動 Lampo：

```
➜  ~ lampod-cli --network signet
✓ 已產生錢包，請妥善保存這些助記詞
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
請保存您的錢包助記詞，並可用 `--restore-wallet` 來恢復錢包。如果您沒有妥善保存這些助記詞，當 Lampo 下次啟動時，您的資金將會遺失！

請注意，您需要在 `~/.lampo/signet` 路徑下擁有一個 `lampo.conf`。請執行下列指令以使用範例設定檔：

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

然後您可以用以下指令查詢節點資訊：

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### 與 core lightning 執行整合測試：

請確保您已以開發者模式編譯 core-lightning。安裝指南請見[這裡](https://docs.corelightning.org/docs/installation)。

可以用以下指令執行整合測試：

```
make integration
```

## 貢獻指南

請閱讀我們的[貢獻指南](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md)。

## 社群

為了保持溝通清晰，我們選擇了特定的聯絡管道：
- 開發者請加入我們的 [Zulip](https://lampo-dev.zulipchat.com/)。
- 社群成員歡迎參與我們的 [Twitter 社群](https://twitter.com/i/communities/1736414802849706087)。
- 技術問題與功能需求，請至 GitHub 討論區。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---