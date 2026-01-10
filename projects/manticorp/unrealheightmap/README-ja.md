# 16/32 ビット グレースケール PNG/EXR ハイトマップジェネレーター

実世界の地形データから高品質な16ビットグレースケールPNGハイトマップまたは16/32ビットEXRハイトマップを生成するブラウザベースのツール。

Unreal Engine 5やTerrain3d、Godot4、Blenderなどのゲームエンジンや3Dソフトウェアでリアルな風景を作成するのに最適です。

🌐 **ライブサイト:** [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/L4L212G6M7)

## ⚠️ 重要なお知らせ

一部の地図サービスの無料利用枠の制限に達し始めているため、資金調達が行われるまでサイトが*動作しない可能性があります*。このツールが役立つ場合は、ぜひプロジェクトの支援をご検討ください！

## ✨ 特徴

- **高品質な16/32ビット出力** - 65,536/4,294,967,296段階の詳細レベルのハイトマップを生成（8ビットの256段階と比較）
- **実世界の地形データ** - [Mapzenのグローバル標高サービス](https://www.mapzen.com/blog/elevation/)からの高品質な標高データを使用
- **インタラクティブな地図インターフェース** - 直感的な地図インターフェースで地形エリアを視覚的に選択
- **複数の正規化モード** - ハイトマップデータを最適化するために、なし、通常、スマートの中から選択可能
- **柔軟な出力サイズ** - Unreal Engine用のプリセットサイズや最大8129×8129ピクセルのカスタム寸法
- **ブラウザベース** - インストール不要で、完全にウェブブラウザ上で動作
- **リアルタイムプレビュー** - 地図上のオーバーレイでエクスポート範囲を確認可能
- **座標のコピー＆ペースト** - DMSや10進度など複数の座標形式に対応

## 🎯 利用例

- Unreal Engine 5/Blender/Terrain3Dのリアルな地形作成
- 正確な実世界地形を用いたゲーム開発
- 3Dモデリングおよび可視化プロジェクト
- 地理情報システム（GIS）アプリケーション
- 教育および科学的可視化

## 🚀 クイックスタート

1. [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/) にアクセス
2. 地図で目的の場所へ移動するか、座標を手動で入力
3. 出力のズームとサイズを調整してエクスポート範囲を設定（オレンジの矩形で表示）
4. 用途に適した正規化モードを選択
5. 「Generate」をクリックしてハイトマップを作成しダウンロード
詳細な手順については、[ドキュメント](https://manticorp.github.io/unrealheightmap/instructions.html)ページをご覧ください。

## 📖 ドキュメント

- **[使い方](https://manticorp.github.io/unrealheightmap/instructions.html)** - ツールの使用方法に関する包括的なガイド
- **[例](https://manticorp.github.io/unrealheightmap/examples.html)** - ツールで作成されたハイトマップのギャラリー
- **[ライセンス情報](https://manticorp.github.io/unrealheightmap/rights.html)** - データソースおよびライセンスに関する情報

## 🛠️ 技術スタック

- **TypeScript** - 型安全なアプリケーションコード
- **Leaflet** - インタラクティブな地図インターフェース
- **jQuery** - DOM操作およびUIインタラクション
- **UPNG.js** - PNGのエンコード/デコード
- **Pako** - データ圧縮
- **Webpack** - モジュールバンドリング
- **Bulma** - CSSフレームワーク
- **SASS** - CSSプリプロセッシング

## 💻 開発環境のセットアップ

### 前提条件

- Node.js（v14以上推奨）
- npm（Node.jsに付属）

### インストール


```bash
# Clone the repository
git clone https://github.com/manticorp/unrealheightmap.git
cd unrealheightmap

# Install dependencies
npm install
```
### ビルドコマンド


```bash
# Development build
npm run build

# Production build
npm run author

# Watch mode (auto-rebuild on changes)
npm run watch

# Run unit tests
npm test
```

### プロジェクト構成

```
├── src/                   # Source TypeScript and SASS files
│   ├── app.ts             # Main application logic
│   ├── main.ts            # Entry point
│   ├── png.ts             # PNG processing
│   ├── processor.ts       # Web worker for image processing
│   ├── sass/              # Stylesheets
│   └── templates/         # HTML templates
├── public/                # Static assets and build output
│   ├── dist/              # Built JavaScript and CSS
│   ├── im/                # Images
│   └── examples/          # Example heightmaps
├── index.html             # Main application page
├── instructions.html      # Documentation page
├── examples.html          # Examples page
└── webpack.config.js      # Webpack configuration
```
## 🎨 例

### グランドキャニオン (64km)
[ツールで表示](https://manticorp.github.io/unrealheightmap/#latitude/36.18111652966563/longitude/-112.021/zoom/10/outputzoom/14/width/8129/height/8129)

![グランドキャニオン例](https://raw.githubusercontent.com/manticorp/unrealheightmap/main/public/im/grand_canyon_desserty.png)

他の例については、[例ページ](https://manticorp.github.io/unrealheightmap/examples.html)をご覧ください。

## 🔧 正規化モード

### なし
正規化は行われません。ピクセル値は直接メートル単位の高さを表し（負の値は0に設定されます）。

### 通常
高さ値を16ビット全範囲（0-65535）にスケーリングし、高度マップ全体で詳細を最大化します。

### スマート
データエラーや外れ値を処理する高度なモードです。99.9%のウィンドウを使用して極端な値をフィルタリングしながら、1標準偏差内の本物の最小/最大値を保持します。

## 📊 出力形式

- **形式:** 16ビットグレースケールPNG、16ビットEXRまたは32ビットEXR
- **ビット深度:** 65,536レベルの詳細 (2^16) または4,294,967,296 (2^32)
- **精度:** エベレスト山（8,849m）を約13cm間隔で表現可能（16ビット）
- **ソースデータ:** Mapzen標高データ（24ビット精度、約4mm忠実度）

## 🤝 貢献

貢献を歓迎します！問題を報告したり、リポジトリをフォークしてプルリクエストを作成してください。

## 📄 ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

標高データは[Mapzen](https://www.mapzen.com/blog/elevation/)から提供されており、独自のライセンス条件が適用される場合があります。

## 💖 サポート


このツールが役に立った場合は、プロジェクトのサポートをご検討ください：

- ☕ [Ko-fiでコーヒーを買う](https://ko-fi.com/harrymustoeplayfair)
- ⭐ このリポジトリにスターを付ける
- 🐦 役立ちそうな他の人と共有する

## 🙏 謝辞

- 高品質な世界標高データを提供している [Mapzen](https://www.mapzen.com/)
- インスピレーションとユースケースを提供する [Unreal Engine](https://www.unrealengine.com/) コミュニティ
- このツールのすべての貢献者とユーザー

## 📞 連絡先

- **著者:** Harry Mustoe-Playfair
- **メール:** harry.mustoeplayfair@gmail.com
- **GitHub:** [manticorp](https://github.com/manticorp)

---

Unreal Engine、3Dおよびゲーム開発コミュニティのために❤️を込めて作成しました


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---