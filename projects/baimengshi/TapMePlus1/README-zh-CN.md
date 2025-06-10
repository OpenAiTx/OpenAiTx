# TapMePlus1 自动清除脚本

一个强大的 Greasemonkey 用户脚本，用于自动化清除 TapMePlus1 游戏的过程。

## 功能特点

- 🎮 **全自动游戏**：自动判断最优点击策略
- ⚡ **智能决策**：基于价值函数评估每次点击的潜在收益
- 🔁 **连锁反应处理**：完全模拟连锁消除效果
- 🚀 **高效算法**：支持多次点击连续操作策略
- 🛠 **突破模式**：在不利局面下寻找最佳突破点
- 📊 **实时监控**：后台监控游戏状态并自动重启游戏
- 🖥 **控制面板**：直观的 GUI 界面控制脚本运行

## 安装说明

1. 安装 [violentmonkey](https://violentmonkey.github.io/) 浏览器扩展
2. 点击安装 [TapmePlus1 脚本](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. 访问 [TapMePlus1](https://tapmeplus1.com/) 开始游戏

## 配置选项

脚本包含以下可调参数（在代码中修改）：

```javascript
// ====== 基本参数 ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== 动态权重函数 ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== 阶段策略 ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基础', strategy: 'default' };
    };
```

## 许可证

GPL-3.0 许可证。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---