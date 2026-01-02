
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=v3kt0r-87&project=Mesa-Turnip-Builder&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Freedreno Turnip Builder 

## 穩定版 / RC Mesa  + Android NDK <br> 建議為穩定性使用本構建 ✅ 

簡易 Bash 腳本，旨在為 **MAGISK/KERNELSU 或模擬器** 編譯 turnip 驅動

# 新增內容 : 🔥

**[點擊此處](//github.com/v3kt0r-87/Mesa-Turnip-Builder/blob/main/UPDATES.md)**
 
## 如何在本地建置 🤔

只需複製此儲存庫並使用 **BASH** 進行建置 

``` 
bash build-turnip.sh
``` 

請參閱下方 [Notes](//github.com/v3kt0r-87/Mesa-Turnip-Builder?tab=readme-ov-file#notes-) 區段以獲取更多資訊

# 應用程式相容性

| 名稱                                            | 狀態   | 備註                                                                                                                     |
|-------------------------------------------------|--------|--------------------------------------------------------------------------------------------------------------------------|
| 3D Mark                                         | ✅     |                                                                                                                          |
| GRID™ Autosport                                 | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 測試<br>運作正常。(60fps)                                                          |
| 海綿寶寶比奇堡大冒險                            | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 測試<br>運作正常,(30 - 45 fps)                                                    |
| Carx Street                                     | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 測試<br>運作正常,(30 - 45 fps)                                                    |
| Dolphin 模擬器                                  | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 測試<br>運作正常。                                                                |
| PPSSPP                                          | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 測試<br>運作正常。                                                                |
| EggNS                                           | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 測試<br>運作正常。                                                                |
| ANGLE (com.android.angle)                       | ✅     |                                                                                                                          |
| GTA 三部曲 - 終極版                             | ✅     | 由 [@Ryder_7777](//t.me/Ryder_7777) 測試<br>可運作，效能不佳。                                                           |
| 決勝時刻：戰區行動版                            | ✅     | 由 [@SeniorFurry](//t.me/SeniorFurry) 測試<br>可運作，紋理錯誤，效能不佳。                                               |
| 絕命殺手：血錢復仇                              | ✅     | 由 [@V3KT0R-87](//github.com/V3KT0R-87) 測試<br>可運作，60 fps 中等畫質。                                                |


### 備註：

### 重要：需要 Android 15（SDK 35）以獲得完整的 Vulkan 1.4 支援

## 請使用 Ubuntu 24.04 或任何基於其的發行版

**在繼續之前請確保你的網路連線穩定**

**如果你的 ISP 限速，請使用 VPN**

請確保你的 Android 版本為 ``14`` 或以上，否則將無法安裝

安裝前請確保你已安裝最新的 **MAGISK / KERNELSU**

# 鳴謝 🙏

### 沒有下列這些優秀人士的幫助，本專案無法實現：
 
 **[@MrMiy4mo](//github.com/ilhan-athn7)** 創建了 turnip 建構腳本並允許我修改與學習。

 
 **[@Mesa3D 團隊](//gitlab.freedesktop.org/mesa/mesa)**，感謝他們提供如此優秀的驅動程式，使我們能進一步提升裝置效能。

 **[Adreno Driver Support Group](//t.me/adreno_driver)**，感謝他們進行測試並分享效能基準。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-02

---