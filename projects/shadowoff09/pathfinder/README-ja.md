# 🗺️ Pathfinder

<div align="center">
  <img src="https://raw.githubusercontent.com/shadowoff09/pathfinder/master/public/banner-readme.png" alt="Pathfinder バナー" width="1280"/>
  
  Next.js 15、MapboxGL、TypeScriptで構築されたモダンでインタラクティブなマッピングアプリケーションです。Pathfinderはリアルタイムの天気データ、位置検索、カスタマイズ可能な地図スタイルなどの機能を備え、シームレスなマッピング体験を提供します。

  [デモ](https://link.shadowdev.xyz/r/m3tydbf12hb) · [バグ報告](https://github.com/shadowoff09/pathfinder/issues) · [機能リクエスト](https://github.com/shadowoff09/pathfinder/issues)
</div>

## ✨ 特徴

- 🌓 ダーク/ライトモード対応
- 🏢 3D建物の可視化
- 🔍 オートコンプリート付き位置検索
- 🌤️ リアルタイム天気情報
- 📍 現在位置検出
- 🛰️ ストリート/衛星ビュー切替
- 📱 完全レスポンシブデザイン
- ⌨️ キーボードショートカット対応
- 🎨 Tailwind CSS と shadcn/ui を使用したモダンなUI

## 🚀 はじめに

### 前提条件

- Node.js 22+
- Mapbox APIキー（[Mapbox](https://www.mapbox.com/)から取得）
- OpenWeather APIキー（[OpenWeather](https://openweathermap.org/api)から取得）
- npm または yarn

### インストール

1. リポジトリをクローン:
```bash
git clone https://github.com/shadowoff09/pathfinder.git
cd pathfinder
```
2. 依存関係をインストールします:

```bash
npm install
# or
yarn install
```
3. 環境変数を設定します:
   - `.env.example` ファイルを `.env.local` にコピーします:

     ```bash
     cp .env.example .env.local
     ```
   - `.env.local`を開き、MapboxのAPIキーを追加します:
     ```env
     NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token_here
     NEXT_PUBLIC_WEATHER_API_KEY=your_weather_api_key_here
     ```
   - APIキーを取得してください：
     - [Mapbox](https://www.mapbox.com/) - 地図機能用
     - [OpenWeather](https://openweathermap.org/api) - 天気データ用

4. 開発サーバーを起動します：
```bash
npm run dev
# or
yarn dev
```

5. ブラウザで [http://localhost:3000](http://localhost:3000) を開きます。

## 🎮 使い方

### マップナビゲーション
- パン：クリックしてドラッグ
- ズーム：スクロールまたはズームコントロールを使用
- 回転：右クリックしてドラッグ
- ビューリセット：Ctrl+Qを押す

### 機能
- 検索バーで場所を検索
- ストリートビューと衛星ビューの切り替え
- ストリートビュー（ズームレベル15以上）で3D建物を表示
- 天気情報の確認（ズームレベル14以上）
- ワンクリックで現在地取得
- 座標をクリップボードにコピー

## 🛠️ 使用技術

- [Next.js 15](https://nextjs.org/) - Reactフレームワーク
- [TypeScript](https://www.typescriptlang.org/) - 型安全
- [Mapbox GL JS](https://www.mapbox.com/mapbox-gl-js) - マップAPI
- [Tailwind CSS](https://tailwindcss.com/) - スタイリング
- [shadcn/ui](https://ui.shadcn.com/) - UIコンポーネント
- [React Map GL](https://visgl.github.io/react-map-gl/) - Mapbox GLのReactラッパー

## 🤝 コントリビュート

コントリビューション歓迎します！プルリクエストをお気軽に送ってください。大きな変更は、まずIssueを開いて変更内容を相談してください。

1. プロジェクトをフォーク
2. 機能ブランチを作成（`git checkout -b feature/AmazingFeature`）
3. 変更をコミット（`git commit -m 'Add some AmazingFeature'`）
4. ブランチにプッシュ（`git push origin feature/AmazingFeature`）
5. プルリクエストを作成

## 📝 ライセンス

このプロジェクトはMITライセンスの下でライセンスされています - 詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## 🙏 謝辞

- 優れたマッピングプラットフォームを提供する[Mapbox](https://www.mapbox.com/)
- 美しいUIコンポーネントを提供する[shadcn/ui](https://ui.shadcn.com/)
- ホスティングとデプロイを提供する[Vercel](https://vercel.com)

## 📫 連絡先

X - [@shadowdev09](https://twitter.com/shadowdev09)

ポートフォリオ - [https://shadowdev.xyz](https://shadowdev.xyz)

## 💖 プロジェクト支援

Pathfinderの利用を楽しんでいただけたら、その開発支援として寄付をご検討ください：

- [PayPal経由で寄付](https://paypal.me/diogogaspar123)
- [Ko-Fi経由で寄付](ko-fi.com/shadowoff09)
- [GitHub Sponsors](https://github.com/sponsors/shadowoff09)


皆様のご支援がプロジェクトの継続と機能向上に役立っています！ご支援ありがとうございます！

---
<a href="https://www.producthunt.com/posts/pathfinder-11?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-pathfinder&#0045;11" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=915601&theme=dark&t=1740532963013" alt="Pathfinder - Navigate&#0032;Your&#0032;World&#0044;&#0032;Beautifully | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

⭐️ このプロジェクトが気に入ったら、ぜひスターを付けてください！

[![Stargazers over time](https://starchart.cc/shadowoff09/pathfinder.svg?variant=adaptive)](https://starchart.cc/shadowoff09/pathfinder)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---