# TypeGen - インテリジェントテキストスタイル変換ツール

TypeGen は Next.js をベースにしたモダンな AI 駆動テキストスタイル変換アプリです。OpenAI API を統合し、多次元の執筆スタイル、構造テンプレート、戦略パラメータ間のインテリジェントな変換を提供し、直感的なドラッグ＆ドロップインターフェースを備えています。

## 🎯 コア機能

### インテリジェントテキスト変換
- **AI 駆動**: OpenAI GPT-4o-mini を統合し、リアルなテキストスタイル変換を実現
- **28 種類のスタイルフィルター**: 執筆文体、構造骨格、伝播戦略の三大次元をカバー
- **インテリジェント文字数制御**: 目標長さ設定に対応し、簡潔な要約から詳細な展開まで対応
- **リアルタイム変換**: 高速応答の API 処理でスムーズなユーザー体験を提供

### 直感的インタラクションデザイン
- **ドラッグ＆ドロップ操作**: スタイルフィルターをテキストボックスにドラッグするだけで変換開始
- **視覚フィードバック**: 豊富なアニメーション効果と状態表示
- **比較表示**: 変換前後の二段組比較レイアウト
- **ワンクリック操作**: 結果のコピー、他スタイルの試行、再スタート

## 🛠️ 技術アーキテクチャ

### フロントエンド技術スタック
- **フレームワーク**: [Next.js](https://nextjs.org/) 15.5.0 (Turbopack を使用した開発)
- **UI ライブラリ**: [React](https://reactjs.org/) 19.0.0
- **スタイルシステム**: [Tailwind CSS](https://tailwindcss.com/) 4.1.11
- **アニメーションライブラリ**: [Framer Motion](https://www.framer.com/motion/) 12.23.6
- **型安全**: [TypeScript](https://www.typescriptlang.org/) 5
- **パッケージマネージャー**: [pnpm](https://pnpm.io/)

### コアコンポーネント
- **ドラッグ＆ドロップシステム**: @dnd-kit/core ベースのプロフェッショナルなドラッグ操作
- **スタイル管理**: clsx と tailwind-merge による動的スタイル処理
- **UI コンポーネント**: Radix UI ベースのカスタムコンポーネントライブラリ

## 📂 プロジェクト構成

```
├── app/                           # Next.js App Router
│   ├── api/transform/route.ts     # 文本转换 API 端点
│   ├── page.tsx                   # 主应用界面
│   ├── layout.tsx                 # 根布局组件
│   └── globals.css                # 全局样式
├── components/                    # UI 组件库
│   ├── style-filter/              # 风格滤镜系统
│   │   ├── types.ts              # 类型定义
│   │   ├── filters-data.ts       # 风格数据配置
│   │   ├── filter-container.tsx  # 滤镜容器组件
│   │   └── ...                   # 动画和交互组件
│   ├── ui/                       # 基础 UI 组件
│   ├── length-control.tsx        # 字数控制滑动条
│   └── text-stats.tsx           # 文本统计显示
├── lib/                          # 业务逻辑层
│   ├── api-client.ts            # API 客户端封装
│   ├── transform-service.ts     # 转换服务核心
│   ├── openai-service.ts        # OpenAI API 集成
│   └── api-types.ts             # API 类型定义
├── public/icons/                # 风格图标资源
└── utils/                       # 工具函数
```
## 🎨 スタイルフィルター一覧

### 文体スタイル（Style）

**ニュース / 学術 / 教科書**
- APスタイル
- APAスタイル
- IEEEスタイル
- 教科書スタイル
- 調査報道

**コミュニティ / プラットフォーム文化**
- 4chanスタイル
- Redditスタイル
- BuzzFeed
- Twitterスタイル
- Instagramキャプション
- ミームスタイル

**小説 / 創作ライティング**
- ヘミングウェイスタイル

### 構造テンプレート（Structure）

**ニュース / 情報構造**
- 逆ピラミッド
- 見出し重視

**リスト / スレッド / チュートリアル**
- リスティクル
- スレッド形式
- ハウツー
- 箇条書き

**学術 / 叙述構造**
- IMRaD

### 戦略とパラメータ（Strategy & Controls）
- クリックベイト

- 行動を促す
- SEO最適化済み
- FOMO（取り残される恐怖）を駆動
- ハッシュタグ多用
- 絵文字多用
- フレッシュ-キンケイド（可読性指標）
- 引用多数
- 技術用語多用

## ⚙️ 配置ガイド

### 環境設定
1. **OpenAI APIキーの取得**
   ```bash
   # 访问 https://platform.openai.com/account/api-keys
   # 创建新的 API 密钥
   ```
2. **環境変数の設定**

   ```bash
   cp .env.example .env.local
   ```
   `.env.local` ファイルを編集します：

   ```bash
   OPENAI_API_KEY=sk-proj-your_api_key_here
   OPENAI_MODEL=gpt-4o-mini                    # 可选，默认值
   OPENAI_MAX_TOKENS=2000                      # 可选，默认值
   OPENAI_TEMPERATURE=0.7                      # 可选，默认值
   API_TIMEOUT=30000                           # 可选，30秒超时
   API_MAX_RETRIES=3                           # 可选，最大重试次数
   ```

### ローカル開発
```bash
# 安装依赖
pnpm install

# 启动开发服务器
pnpm dev

# 构建生产版本
pnpm build

# 代码检查
pnpm lint
```

## 🔧 核心実装

### 状態管理
アプリは完全なステートマシンパターンを使用して変換プロセスを管理しています：
- `idle`: 初期状態、テキスト入力を待機
- `readyToTransform`: テキストが準備完了し、変換可能
- `transforming`: 変換中、ロード状態を表示
- `transformed`: 変換完了、結果の比較を表示

### API 統合
- **型安全**: 完全な TypeScript 型定義
- **エラー処理**: 階層的なエラー処理とユーザーフレンドリーなエラーメッセージ
- **パフォーマンス最適化**: API応答のキャッシュとリクエストの重複排除
- **リトライ機構**: ネットワーク障害時の自動リトライ

### インタラクション体験（デスクトップ）
- **ドラッグ操作**: 滑らかなドラッグアニメーションと視覚フィードバック
- **文字数制御**: リアルタイム文字数カウントと目標長さ設定
- **結果操作**: ワンクリックコピー、リトライ、再スタート
- **プラットフォーム説明**: 現バージョンはデスクトップ向けのみで、モバイルではインタラクション非対応

## 🚀 拡張方向

- **多言語対応**: 国際化サポートの追加
- **一括処理**: 複数テキストの同時変換対応
- **カスタムスタイル**: ユーザーが個性的なスタイルを作成可能に
- **協働機能**: チーム共有とコメント機能
- **データ分析**: 利用統計と効果分析の活用


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---