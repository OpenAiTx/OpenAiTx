
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
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

**將你的 GitHub Actions 執行器轉變為 [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ 的強大平台，徹底清除預裝的冗餘軟體。**

GitHub Actions 執行器對 Nix 可用的磁碟空間非常有限——僅有約 20GB。
*Nothing but Nix* **強力清除**不必要的軟體，讓你獲得 **65GB 到 130GB** 的 Nix store 空間！💪

## 使用方式 🔧

在您的工作流程中安裝 Nix **之前**，請新增此操作：

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

### 需求 ️✔️

- 僅支援官方 **Ubuntu** GitHub Actions 運行器
- 必須在 Nix 安裝**之前**執行
- **macOS/Darwin 運行器**：此動作若在 macOS 上執行將會優雅地跳過並發出警告。macOS 運行器本身已提供足夠空間給 Nix，無需執行此動作
- **Windows 運行器**：此動作若在 Windows 上執行將會優雅地跳過並發出警告。Windows 運行器的檔案系統結構及限制不同

## 問題：為 Nix 創造成長空間 🌱

標準的 GitHub Actions 運行器裡塞滿了你在 Nix 工作流程中永遠用不到的 *"臃腫軟體"*：

- 🌍 網頁瀏覽器。很多，必須全部擁有！
- 🐳 Docker 映像檔佔據寶貴磁碟空間數 GB
- 💻 不必要的語言執行環境（.NET、Ruby、PHP、Java...）
- 📦 套件管理器閒置生灰塵
- 📚 沒人會讀的文件

這些臃腫只剩下約 ~20GB 給你的 Nix 儲存空間——對嚴肅的 Nix 建置來說根本不夠！😞

## 解決方案：只剩 Nix ️❄️

**只剩 Nix** 對 GitHub Actions 運行器採取焦土策略，無情地回收磁碟空間，分兩階段攻擊：

1. **初步大砍：** 立即從 `/mnt` 奪取空間，建立大型 `/nix` 卷（約 65GB）
2. **背景掃蕩：** 在你的工作流程繼續進行時，我們徹底移除不必要軟體，將 `/nix` 卷擴展至約 130GB
   - 網頁瀏覽器？不行 ⛔
   - Docker 映像檔？消失 🗑️
   - 語言執行環境？徹底消滅 💥
   - 套件管理器？殲滅 💣
   - 文件？蒸發 ️👻

檔案系統清除由 `rmz`（來自 [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) 專案）驅動——是 `rm` 的高效替代方案，讓空間回收速度飛快！⚡
   - 比標準 `rm` 快一個數量級
   - 平行處理刪除，效能極致
   - **磁碟空間幾秒回收完成！** ️⏱️

最終成果？GitHub Actions 運行器擁有 **65GB 到 130GB** 的 Nix 專用空間！😁

### 動態卷增長
與其他解決方案不同，**Nothing but Nix** 會動態擴展你的 `/nix` 磁區：

1. **初始磁區建立（1-10 秒）：**（*取決於 Hatchet Protocol*）
   - 從 `/mnt` 的可用空間建立循環裝置
   - 設定 BTRFS 檔案系統為 RAID0 配置
   - 以壓縮及效能優化方式掛載
   - 即使清理尚未開始，也能立即提供 65GB 的 `/nix`

2. **背景擴展（30-180 秒）：**（*取決於 Hatchet Protocol*）
   - 執行清理作業
   - 監控在去除膨脹後釋放出的新空間
   - 動態新增擴展磁碟至 `/nix` 磁區
   - 重新平衡檔案系統以納入新空間

`/nix` 磁區會在工作流程執行期間自動**成長** 🎩🪄

### 選擇你的武器：Hatchet Protocol 🪓

透過 `hatchet-protocol` 參數控制殲滅等級 💥：


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

當 `nix-permission-edict` 設為 `true` 時，該動作會在掛載 `/nix` 後執行 `sudo chown -R "$(id --user)":"$(id --group)" /nix`。

### 設定 Nix 使用 /nix/build

此動作會建立 `/nix/build`，讓 Nix 衍生構建使用回收的空間。請在 Nix 設定中新增 `build-dir`：

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

或者使用 DeterminateSystems：

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
這會指示 Nix 在大型 BTRFS 卷上執行建置，而不是系統預設的暫存目錄。

## 疑難排解 🔍

### 在大型建置期間出現「No space left on device」

如果你的建置在只使用 Nix 的情況下仍然空間不足，這很可能是因為背景清除尚未完成，而你的建置已經消耗了可用空間。這通常會影響：

- 組裝大型磁碟映像的 NixOS VM 測試
- 有許多未快取相依性的建置
- Rust 工具鏈及其他大型編譯

**解決方法：** 使用 `witness-carnage: true` 以強制同步清除。這可確保在建置開始*之前*回收所有空間：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
這會為你的工作流程設置增加30-180秒，但能保證在建置開始時有最大的可用空間。

現在就利用這些寶貴的 Nix 儲存空間，去創造令人驚豔的作品吧！❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---