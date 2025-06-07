<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station 是 [Space Station 14](https://github.com/space-wizards/space-station-14) 的一個分支，運行於以 C# 撰寫的 [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) 引擎上。

這是 Frontier Station 的主要存儲庫。

如果你想要架設伺服器或為 Frontier Station 創建內容，這就是你需要的存儲庫。它同時包含 RobustToolbox 和用於開發新內容包的內容包。

## 連結

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## 文件／維基

我們的 [wiki](https://frontierstation.wiki.gg/) 有關於 Frontier Station 內容的文件說明。

## 貢獻

我們非常歡迎任何人的貢獻。如果你想幫忙，請加入 Discord。如果你需要靈感，我們有一份[可實現的想法清單](https://discord.com/channels/1123826877245694004/1127017858833068114)，任何人都可以認領。也不要害怕尋求幫助！

我們目前不接受在主存儲庫中的遊戲翻譯。如果你想要將遊戲翻譯成其他語言，請考慮創建一個分支或為現有分支做出貢獻。

如果你有任何貢獻，請務必閱讀 [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md) 中的標記說明。  
對上游文件的任何更改都必須根據文件中的規定進行正確標記。

## 編譯

1. 複製本存儲庫：
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. 進入專案資料夾並執行 `RUN_THIS.py` 來初始化子模組並載入引擎：
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. 編譯方案：

使用 `dotnet build` 來建構伺服器。

[更詳細的專案建構說明。](https://docs.spacestation14.com/en/general-development/setup.html)

## 授權

自 commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 之後貢獻到本存儲庫的內容，除非另有說明（見下方歸屬），皆採用 GNU Affero General Public License 3.0 授權。請參閱 `LICENSE-AGPLv3.txt`。  
在 commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 之前貢獻的內容，除非另有說明，皆採用 MIT 授權。請參閱 `LICENSE-MIT.txt`。

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) 推送於 2024 年 7 月 1 日 16:04 UTC

大多數資產除非另有說明，皆採用 [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) 授權。資產的授權及版權資訊會標註於中繼資料檔案中。例如，請參閱 [撬棍的中繼資料](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json)。

請注意，部分資產採用非商業授權 [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) 或其他類似非商業授權。如果你想要將本專案用於商業用途，這些資產需要移除。

## 歸屬

當我們從其他分支拉取內容時，會將其內容整理到存儲庫專屬的子資料夾，以方便歸屬追蹤並減少合併衝突。

這些子資料夾下的內容來源於其各自的分支，並可能包含修改。這些修改會以註釋標註於被修改的程式碼行周圍。

| 子資料夾 | 分支名稱 | 分支存儲庫 | 授權 |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

我們也有從未設置子資料夾的其他存儲庫移植功能，清單如下：

| 分支名稱 | 分支存儲庫 | 授權 |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---