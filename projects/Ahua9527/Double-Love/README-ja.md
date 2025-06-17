# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 フレーム間の愛で、効率2倍

[//]: # (コードに隠されたイースターエッグ)
<!Double Love：すべてのカットに言葉にできなかったフレームレートを隠して -->

[English](./README.en.md) · 简体中文 · [オンライン体験](https://double-love.ahua.space)

</div>

Double Loveは場記メタデータの自動標準化処理を提供します。オフライン利用対応。バッチ処理とローカル処理により、Adobe Premiere、Silverstack、DTG Slateとのシームレスな連携を実現し、メタデータの一貫性を確保。ポストプロダクションワークフローの効率を大幅に向上させます。

## ✨ 機能特性

- 🎬 映像制作ワークフロー対応
- 📝 インテリジェントなメタデータ標準化処理
- ⚡ ゼロレイテンシーのローカル処理
- 🧩 Adobe Premiereとシームレス連携

## 🚀 クイックスタート

### 基本ワークフロー

1. 場記記録：DTG Slateを使用してインタラクティブな場記表を生成
2. データ管理：Silverstack Labで場記データをインポート
3. ファイル書き出し：Adobe Premiere Pro XMLを生成
4. 標準化処理：Double Loveでインテリジェント最適化

例：
- 入力xml：`UnitA_304_20250127.xml`
- 出力xml：`UnitA_304_20250127_Double_LOVE.xml`

### 詳細例

#### ファイル名最適化
- シーン番号、カット番号、テイク番号のフォーマットを自動処理
- 数字にゼロパディングを自動追加
- 大文字・小文字の規則を自動修正
- 余分なアンダースコアを自動削除

#### クリップ命名規則

処理後のクリップ名は以下のフォーマットに従います：
```
{項目前置詞}{シーン}_{カット}_{テイク}{カメラ}{評価}
```

- `prefix`: カスタムプレフィックス（任意）
- `scene`: シーン番号（3桁数字、例：001）
- `shot`: カット番号（2桁数字、例：01）
- `take`: テイク番号（2桁数字、例：01）
- `camera`: カメラ識別子（小文字、例：a）
- `Rating`: 評価（ok/kp/ng）

#### 評価処理
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT情報
- DIT情報を自動追加：'DIT: 哆啦Ahua 🌱'
- 削除が必要な場合はご自身でデプロイしてください😁😁

#### カスタムプレフィックス例

1. プレフィックスを "PROJECT_A_" に設定：
   - 入力ファイル：`A304C007_250123G3`
   - 出力ファイル：`PROJECT_A_004_01_07a_kp`

2. プレフィックスを設定しない場合：
   - 入力ファイル：`A304C007_250123G3`
   - 出力ファイル：`004_01_07a_kp`

#### シーケンス解像度設定例

1. FHD解像度（デフォルト）：
   - 幅：1920
   - 高さ：1080   
2. DCI 2K解像度（カスタム）：
   - 幅：2048
   - 高さ：1080   

#### バッチ処理例

1. 複数ファイルの同時アップロード：
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. 処理完了後は以下のファイルが得られます：
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ 技術スタック

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA対応

## 📦 インストールと使用方法

1. プロジェクトをクローン

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. 依存関係のインストール

```bash
npm install
```

3. ローカル開発

```bash
npm run dev
```

4. プロジェクトビルド

```bash
npm run build
```

## 🔒 セキュリティについて

- すべてのファイル処理はブラウザローカルで実行され、サーバーへのアップロードはありません
- 最大50MBのファイルサイズ制限あり
- XML形式のファイルのみ対応

## 🌈 開発者向け情報

### プロジェクト構成

```
Double-Love/
├── src/
│   ├── components/     # Reactコンポーネント
│   ├── context/       # React Context
│   ├── utils/         # ユーティリティ関数
│   ├── styles/        # スタイルファイル
│   └── App.tsx        # メインアプリケーションコンポーネント
├── public/            # 静的アセット
└── ...設定ファイル
```

## 📃 ライセンス

[MIT License](LICENSE)

## 🤝 コントリビュートガイド

IssueやPull Requestのご提出を歓迎します！

## 👨‍💻 作者

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---