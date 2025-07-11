# 手勢琶音器

以手部控制的琶音器、鼓機和音訊互動視覺化工具。舉起你的雙手，一起嗨翻全場！

這是一個以 threejs、mediapipe 電腦視覺、rosebud AI 和 tone.js 打造的互動式網頁應用程式。

- 手 #1 控制琶音（舉高手提高音高，捏合手指改變音量）
- 手 #2 控制鼓組（舉起不同手指切換節奏模式）

[影片](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [線上展示](https://collidingscopes.github.io/arpeggiator/) | [更多原始碼與教學](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## 系統需求

- 支援 WebGL 的現代網頁瀏覽器
- 啟用攝影機權限以進行手部追蹤

## 技術

- **MediaPipe**：用於手部追蹤與手勢辨識
- **Three.js**：用於音訊互動視覺渲染
- **Tone.js**：用於合成器音效
- **HTML5 Canvas**：用於視覺回饋
- **JavaScript**：用於即時互動
## 開發環境設置

```bash
# 複製此儲存庫
git clone https://github.com/collidingScopes/arpeggiator

# 進入專案目錄
cd arpeggiator

# 使用你偏好的方式啟動伺服器（以下為 Python 範例）
python -m http.server
```

然後在瀏覽器中前往 `http://localhost:8000`。

## 授權條款

MIT 授權條款

## 鳴謝
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## 相關專案

我已在這裡發布了數個電腦視覺專案（包含程式碼與教學）：
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

你可以購買終身存取權，獲得完整專案檔案與教學。我會定期新增更多內容 🪬

你可能也會喜歡我的其他開源專案：

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) - 用語音和手勢控制 3D 模型
- [Threejs hand tracking tutorial](https://collidingScopes.github.io/threejs-handtracking-101) - 使用 threejs 和 MediaPipe 電腦視覺的基本手部追蹤設定
- [Particular Drift](https://collidingScopes.github.io/particular-drift) - 將照片變成流動的粒子動畫
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) - 將影片轉換為 ASCII 像素藝術
## 聯絡方式

- Instagram: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X: [@measure_plan](https://x.com/measure_plan)
- 電子郵件: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## 捐款支持

如果你覺得這個工具對你有幫助，歡迎請我喝杯咖啡。

我的名字是 Alan，我熱衷於開發用於電腦視覺、遊戲等領域的開源軟體。在深夜編碼時收到你的支持，我會非常感激！

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---