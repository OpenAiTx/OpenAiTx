<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**將你的 GitHub Actions 執行器轉變為 [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ 強力平台，徹底清除預裝的累贅軟體。**

GitHub Actions 執行器為 Nix 提供的磁碟空間非常有限，僅有約 ~20GB。
*Nothing but Nix* **強力清除**不必要的軟體，讓你的 Nix store 可用空間提升至 **65GB 到 130GB**！💪

## 用法 🔧

在你的工作流程安裝 Nix **之前** 加入此 action：


```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### 系統需求 ️✔️

- 只支援官方 **Ubuntu** GitHub Actions 執行器
- 必須在安裝 Nix 之前執行

## 問題：為 Nix 創造茁壯空間 🌱

標準的 GitHub Actions 執行器塞滿了你在 Nix 工作流程中永遠用不到的 *"冗餘軟體"*：

- 🌍 網頁瀏覽器。超多款。全都得裝！
- 🐳 Docker 映像檔佔據數 GB 寶貴硬碟空間
- 💻 不必要的語言執行環境（.NET、Ruby、PHP、Java……）
- 📦 塵封無用的套件管理器
- 📚 永遠沒人會看的文件

這些冗餘只留給你的 Nix 儲存區約 ~20GB——對於認真進行 Nix 建構來說根本不夠！😞

## 解決方案：只留 Nix ️❄️

**Nothing but Nix** 對 GitHub Actions 執行器採用焦土策略，毫不留情地用雙重攻擊收回硬碟空間：

1. **初步劈砍：** 立即從 `/mnt` 取得可用空間，創建大型 `/nix` 卷（約 65GB）
2. **背景橫掃：** 工作流程繼續時，無情清除不必要軟體，將 `/nix` 卷擴充至約 130GB
   - 網頁瀏覽器？不要 ⛔
   - Docker 映像檔？清除 🗑️
   - 語言執行環境？徹底摧毀 💥
   - 套件管理器？徹底消滅 💣
   - 文件？蒸發 ️👻

檔案系統清理由 `rmz`（來自 [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) 專案）驅動——這是高效能版 `rm`，讓空間釋放超級迅速！⚡
   - 性能比標準 `rm` 高一個數量級
   - 支援平行刪除以達最高效率
   - **幾秒而非幾分鐘內釋放硬碟空間！** ️⏱️

最終成果？一台有 **65GB 至 130GB** Nix 就緒空間的 GitHub Actions 執行器！😁

### 動態卷擴展

與其他解決方案不同，**Nothing but Nix** 會動態擴展你的 `/nix` 卷：

1. **初始卷建立（1-10 秒）：**（取決於 Hatchet Protocol）
   - 從 `/mnt` 的可用空間建立 loop 裝置
   - 建立 BTRFS RAID0 檔案系統
   - 使用壓縮及效能調校掛載
   - 在清理開始前，立即提供 65GB `/nix`

2. **背景擴展（30-180 秒）：**（取決於 Hatchet Protocol）
   - 執行清理作業
   - 持續監控新釋放空間
   - 動態將擴展磁碟加入 `/nix` 卷
   - 平衡檔案系統以納入新空間

`/nix` 卷會在工作流程執行時 **自動擴展** 🎩🪄

### 選擇你的武器：Hatchet Protocol 🪓

用 `hatchet-protocol` 參數控制清理強度 💥：

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### 協議比較 ⚖️

| 協議      | `/nix` | 說明                                               | 清除 apt  | 清除 docker | 清除 snap | 被清除的檔案系統         |
|-----------|--------|----------------------------------------------------|-----------|--------------|------------|--------------------------|
| Holster   | ~65GB  | 保持刀斧未出鞘，從 `/mnt` 釋放空間                  | 否        | 否           | 否         | 無                       |
| Carve     | ~85GB  | 合成並結合 `/` 與 `/mnt` 的可用空間                 | 否        | 否           | 否         | 無                       |
| Cleave    | ~115GB | 果斷切除大型套件                                    | 最小化    | 是           | 是         | `/opt` 和 `/usr/local`   |
| Rampage   | ~130GB | 無情徹底消滅一切膨脹                                | 積極      | 是           | 是         | 哈哈哈哈！🔥🌎            |

請謹慎選擇：
- **Holster**：當你需要 runner 的工具保持完全可用
- **Carve**：保留 runner 工具功能，同時為 Nix 釋放所有空間
- **Cleave**（*預設*）：在空間與功能間取得良好平衡
- **Rampage**：當你只在乎 Nix 空間極大化，不在意什麼會壞掉 `#nix-is-life`

### 見證大屠殺 🩸

預設情況下，清除程序會在背景靜默執行，讓你的工作流程不中斷。但如果你想即時目睹清除過程：

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### 自訂安全區 🛡️

透過自訂安全區大小，控制從 Nix store 佔用空間中保留多少空間：

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```
這些安全保護區定義了在空間回收期間將仁慈地保留多少空間（以 MB 為單位）：
- 預設的 `root-safe-haven` 為 2048MB（2GB）
- 預設的 `mnt-safe-haven` 為 1024MB（1GB）

如果你需要在檔案系統上有更多的緩衝空間，可以增加這些值，或是減少它們來毫不留情地釋放空間！😈

### 賦予使用者對 /nix 的擁有權（Nix 權限法令）🧑‍⚖️

有些 Nix 安裝程式或設定會預期 `/nix` 目錄可由目前使用者寫入。預設情況下，`/nix` 的擁有者是 root。如果你需要將擁有權給予使用者（例如某些 Nix 安裝腳本並未對 `/nix` 內的所有操作都使用 `sudo`），你可以啟用 `nix-permission-edict`：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

當 `nix-permission-edict` 設為 `true` 時，該操作會在掛載 `/nix` 之後執行 `sudo chown -R "$(id --user)":"$(id --group)" /nix`。

現在就去利用這片壯觀的 Nix 儲存空間創造一些令人驚艷的東西吧！❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---