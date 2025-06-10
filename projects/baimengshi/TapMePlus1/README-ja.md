# TapMePlus1 自動クリアスクリプト

TapMePlus1 ゲームのクリア作業を自動化する強力な Greasemonkey ユーザースクリプトです。

## 特徴

- 🎮 **完全自動ゲーム**：最適なクリック戦略を自動的に判断
- ⚡ **インテリジェント判定**：価値関数に基づき各クリックの潜在的な利益を評価
- 🔁 **連鎖反応処理**：連鎖消去効果を完全にシミュレート
- 🚀 **高効率アルゴリズム**：複数回連続クリック戦略をサポート
- 🛠 **ブレイクスルーモード**：不利な状況で最良の突破口を発見
- 📊 **リアルタイム監視**：バックグラウンドでゲーム状態を監視し自動で再起動
- 🖥 **コントロールパネル**：直感的なGUIでスクリプト操作を制御

## インストール手順

1. [violentmonkey](https://violentmonkey.github.io/) ブラウザ拡張機能をインストール
2. [TapmePlus1 スクリプト](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js) をクリックしてインストール
3. [TapMePlus1](https://tapmeplus1.com/) にアクセスし、ゲームを開始

## 設定オプション

スクリプトには以下の調整可能なパラメータが含まれています（コード内で修正）：

```javascript
// ====== 基本パラメータ ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== 動的重み付け関数 ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== フェーズ戦略 ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基礎', strategy: 'default' };
    };
```

## ライセンス

GPL-3.0 ライセンス。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---