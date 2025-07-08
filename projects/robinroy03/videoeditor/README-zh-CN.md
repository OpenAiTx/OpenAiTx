<samp>
  
<h1>开源视频编辑器</h1>
<p>这不是普通的视频编辑应用，使用 React、Remotion 和 TypeScript 开发。</p>
<br />

> [!NOTE]  
> 该应用正在积极开发中。这是一个早期 MVP。如果你准备运行它，请加入 [Discord 服务器](https://discord.gg/GSknuxubZK)。

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React 视频编辑器截图">
</p>
<p align="center">一个开源的 Capcut、Canva 和 RVE 替代品。</p>
</samp>

## ✨功能

- 🎬非线性视频编辑
- 🔀多轨道支持
- 👀实时预览
- 📤视频导出
- 📜MIT 许可协议

## 🐋部署

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻开发

```
pnpm i
pnpm run dev (前端)
pnpm dlx tsx app/videorender/videorender.ts (后端)
uv run backend/main.py
将 `/app/utils/api.ts` 中的 `isProduction` 切换为 `false`

如果你想使用 AI，还需要 GEMINI_API_KEY。
```

## 📃TODO

我们有很多工作要做！首先，我们计划集成所有 Remotion API。我很快会添加一个正式的路线图。欢迎加入 [Discord 服务器](https://discord.com/invite/GSknuxubZK) 获取更新和支持。

## ❤️贡献

我们非常欢迎你的贡献！❤️ 请查看[贡献指南](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md)。

## 📜许可证

本项目采用 MIT 许可证。项目相关部分同样适用 [Remotion 许可证](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---