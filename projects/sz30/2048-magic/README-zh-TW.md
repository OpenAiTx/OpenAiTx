<div align="right">
  <details>
    <summary >🌐 其他語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

經典 2048 遊戲的增強版，現在加入更多有趣的功能！這是我在閒暇時間做的小專案——希望能為你帶來歡樂！

## 🎯 遊戲簡介

2048 是一款簡單卻令人上癮的數字合併遊戲。在 4x4 的方格中，向上、下、左、右滑動來合併相同數字的方塊。目標？達到 2048（不過你可以繼續挑戰更高分數）！

**玩法說明：**
- 使用方向鍵或 WASD 鍵移動方塊。
- 當兩個相同數字的方塊碰撞時，會合併成一個。
- 每次移動後，隨機在空格出現一個 2 或 4。
- 當無法再移動時，遊戲結束。

## ✨ 特別功能

### 1. 回復（Undo）功能
- 走錯一步也不用擔心！
- 只要點選「回復」按鈕即可回到上一步。
- 你可以無限次回復，直到遊戲開始的那一刻。
- 再也不怕手滑毀了一局好局！

### 2. 秘密作弊模式
- 輸入神奇指令：←←→→ →→←←（左、左、右、右、右、右、左、左）
- 所有方塊將神奇地變成 128！
- 這是一個彩蛋，只是為了好玩。
- 小提示：作弊雖然有趣，但別太過火哦！😉

## 🎯 線上體驗

🎯 點此遊玩：[2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 專案結構
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**檔案說明：**
- `2048.py`：以 Flask 撰寫的後端伺服器，處理遊戲邏輯與 API 請求。
- `script.js`：前端遊戲邏輯，包括移動、動畫及特殊功能。
- `styles.css`：遊戲樣式，確保介面美觀且具回應式設計。
- `index.html`：將所有內容整合的主頁面。

## 🚀 開始使用

**方法一：下載發行版**
1. 下載最新發行版本。
2. 確認已安裝 Python 3.x。
3. 安裝相依套件：`pip install flask`
4. 執行：`python 2048.py`
5. 開啟瀏覽器並前往：[http://localhost:9969](http://localhost:9969)

**方法二：從 GitHub 複製**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 自訂化

想要打造屬於你自己的風格嗎？調整 `styles.css` 來換個新樣貌，或是深入 `script.js` 修改遊戲玩法。所有程式碼都有詳細註解，方便你盡情改造！

## 📝 授權

GPL-2.0 授權

## 🤝 貢獻

持續更新中！非常歡迎提交問題與 Pull Requests——讓我們一起讓這款遊戲變得更棒！


## 🙏 致謝

感謝以下贊助商對本專案的支持：
- [IDC.REST](https://idc.rest/) 提供伺服器
- [Serv00](https://www.serv00.com/) 提供伺服器

---
_最後更新：2025年6月_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---