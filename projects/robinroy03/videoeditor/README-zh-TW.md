<samp>
  
<h1>開源影片編輯器</h1>
<p>不是你一般的影片編輯應用程式，採用 React、Remotion 和 TypeScript 開發。</p>
<br />

> [!NOTE]  
> 此應用程式正積極開發中。目前為早期 MVP。如果你準備執行，請加入 [Discord 伺服器](https://discord.gg/GSknuxubZK)。

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React 影片編輯器螢幕截圖">
</p>
<p align="center">一個開源的 Capcut、Canva 和 RVE 替代方案。</p>
</samp>

## ✨功能

- 🎬非線性影片編輯
- 🔀多軌支援
- 👀即時預覽
- 📤影片匯出
- 📜採用 MIT 授權

## 🐋部署

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻開發

```
pnpm i
pnpm run dev (前端)
pnpm dlx tsx app/videorender/videorender.ts (後端)
uv run backend/main.py
將 `/app/utils/api.ts` 的 `isProduction` 設為 `false`

如果要使用 AI，還需要 GEMINI_API_KEY。
```

## 📃待辦事項

我們還有很多工作要做！首先，我們計畫整合所有 Remotion API。我會很快新增一份正式的開發路線圖。請加入 [Discord 伺服器](https://discord.com/invite/GSknuxubZK) 以獲得最新消息與支援。

## ❤️貢獻

我們非常歡迎你的貢獻！❤️ 請參考[貢獻指南](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md)。

## 📜授權

本專案採用 MIT 授權。專案相關部分亦適用於 [Remotion 授權條款](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---