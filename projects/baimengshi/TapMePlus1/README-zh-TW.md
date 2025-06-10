# TapMePlus1 自動清除腳本

一款強大的 Greasemonkey 使用者腳本，用於自動化清除 TapMePlus1 遊戲的過程。

## 功能特色

- 🎮 **全自動遊戲**：自動判斷最佳點擊策略
- ⚡ **智慧決策**：根據價值函數評估每次點擊的潛在收益
- 🔁 **連鎖反應處理**：完全模擬連鎖消除效果
- 🚀 **高效演算法**：支援多次點擊連續操作策略
- 🛠 **突破模式**：在不利情況下尋找最佳突破點
- 📊 **即時監控**：在背景中監控遊戲狀態並自動重啟遊戲
- 🖥 **控制面板**：直觀的 GUI 介面控制腳本運作

## 安裝說明

1. 安裝 [violentmonkey](https://violentmonkey.github.io/) 瀏覽器擴充套件
2. 點擊安裝 [TapmePlus1 腳本](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. 訪問 [TapMePlus1](https://tapmeplus1.com/) 開始遊戲

## 配置選項

腳本包含以下可調參數（請於程式碼內修改）：

```javascript
// ====== 基本參數 ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== 動態權重函數 ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== 階段策略 ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基礎', strategy: 'default' };
    };
```

## 授權條款

GPL-3.0 授權條款。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---