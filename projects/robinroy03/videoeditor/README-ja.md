<samp>
  
<h1>オープンソース動画編集ソフト</h1>
<p>React、Remotion、TypeScriptを使用した、普通とは違う動画編集アプリケーション。</p>
<br />

> [!NOTE]  
> このアプリケーションは現在積極的に開発中です。これは初期MVPです。実行する場合は[Discordサーバー](https://discord.gg/GSknuxubZK)にご参加ください。

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React Video Editor Screenshot">
</p>
<p align="center">Capcut、Canva、RVEのオープンソース代替。</p>
</samp>

## ✨特徴

- 🎬ノンリニア動画編集
- 🔀マルチトラック対応
- 👀ライブプレビュー
- 📤動画エクスポート
- 📜MITライセンス

## 🐋デプロイ

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻開発

```
pnpm i
pnpm run dev (フロントエンド)
pnpm dlx tsx app/videorender/videorender.ts (バックエンド)
uv run backend/main.py
`/app/utils/api.ts` 内の `isProduction` を `false` に切り替えてください

AIを利用する場合はGEMINI_API_KEYも必要です。
```

## 📃TODO

やるべきことがたくさんあります！まずはRemotionのすべてのAPIを統合する予定です。近いうちに正式なロードマップも追加します。アップデートやサポートのために[Discordサーバー](https://discord.com/invite/GSknuxubZK)にご参加ください。

## ❤️貢献

皆さんのご貢献をお待ちしています！❤️ [貢献ガイド](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md)をご覧ください。

## 📜ライセンス

このプロジェクトはMITライセンスの下で提供されています。[Remotionライセンス](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md)も関連部分に適用されます。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---