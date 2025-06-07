# EmuReady

さまざまなデバイスとエミュレーターにおけるエミュレーション互換性を追跡する、コミュニティ主導のプラットフォームです。

ウェブサイトはこちら: [https://emuready.com](https://emuready.com)

---

**ホームページのスクリーンショット**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**互換性リストページのスクリーンショット**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**ゲームページのスクリーンショット**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## 概要

EmuReadyは、異なるハードウェアおよびソフトウェア構成でのエミュレーション互換性情報をユーザーが共有・発見できるよう支援します。ユーザーは互換性レポートの投稿、リストへの投票、特定のゲーム／デバイス／エミュレーターの組み合わせについて議論できます。

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## 主な特徴

- **包括的な互換性データベース**: ゲームが異なるエミュレーターやデバイスでどのように動作するかを追跡
- **ユーザー投稿機能**: コミュニティ主導のレポートと投票システム
- **ディスカッションシステム**: アップボート／ダウンボート機能付きのコメントスレッド
- **管理ダッシュボード**: ユーザー、リスト、コンテンツ管理
- **レスポンシブデザイン**: モバイル、タブレット、デスクトップに対応

## 最近の改善点

コードベースは以下の強化により大幅に改善されました。

### UIコンポーネント

- エラー時のハンドリングとリカバリー向上のため**ErrorBoundary**コンポーネントを作成
- Next.jsのImageコンポーネントを用いた**OptimizedImage**コンポーネントでパフォーマンス向上
- アクセシビリティ機能・キーボードナビゲーション・UXを改善した**Pagination**
- バリアント、サイズ、ピルオプションを追加した**Badge**コンポーネントを強化
- ライト／ダーク／システムテーマ切り替え用の**ThemeToggle**を追加
- 視覚的インジケーター付きのテーブルソート用**SortableHeader**を実装

### キャッシュ＆パフォーマンス

- キャッシュ、stale time、リトライロジックの初期値改善によるReact Query設定の向上
- デバイス画像の最適化追加
- アプリ全体での適切なエラーハンドリングの実装

### アクセシビリティ

- インタラクティブ要素のキーボードナビゲーション強化
- 適切なARIAラベルとロールを追加
- フォーカスマネジメントの向上
- UIコンポーネントの色コントラスト改善

### セキュリティ

- 多層（クライアント・サーバー・DB）でのデータ検証・サニタイズ
- コンテンツセキュリティポリシー（CSP）実装
- XSSおよびCSRF攻撃への対策
- NextAuth.jsによる安全な認証
- ファイルアップロードの検証とセキュリティ対策
- 入力長の制限と適切なサニタイズ
- パラメータ改ざん防止のためのUUID検証

### 開発体験

- 開発ワークフロー用の追加npmスクリプト
- 一貫したエクスポートによるプロジェクト構成の改善
- カスタムErrorBoundaryによるエラーフィードバックの強化
- ナビゲーションオプション付きの404ページ改善

### テーマ機能

- システムテーマ優先設定の検出
- 複数UIオプションのテーマトグル作成
- 各コンポーネントでのダークモード実装を改善

## はじめに

### 必要条件

- Node.js 20以上
- `npm`
- PostgreSQL（開発時はSQLiteも可）

### インストール

1. リポジトリをクローン

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. 依存パッケージのインストール

```bash
npm install
```

3. 環境変数のセットアップ

```bash
cp .env.example .env
```

その後、`.env`ファイルを編集し、データベース情報やその他設定を入力してください。

4. データベースのセットアップ

```bash
npx prisma generate
npx prisma db push
```

5. 開発サーバーの起動

```bash
npm run dev
```

6. ブラウザで [http://localhost:3000](http://localhost:3000) を開く

## 利用可能なスクリプト

- `npm run dev` - 開発サーバーを起動
- `npm run dev:strict` - React Strict Modeで起動
- `npm run build` - 本番用ビルド
- `npm run start` - 本番サーバーを起動
- `npm run test` - テストを実行
- `npm run lint` - ESLint実行
- `npm run lint:fix` - Lint問題を自動修正
- `npm run format` - Prettierでコード整形
- `npm run typecheck` - TypeScript型チェック
- `npm run analyze` - バンドルサイズ解析
- `npm run clean` - ビルドキャッシュ削除
- `npm run prepare-deploy` - デプロイ準備（lint, typecheck, test, build）

### Prismaコマンド

- `npx prisma db seed` - データベースにシードデータを投入
- `npx prisma studio` - Prisma Studioを開く
- `npx prisma db pull` - データベーススキーマの取得
- `npx prisma db push` - データベーススキーマの反映

詳細は[Prisma CLIリファレンス](https://www.prisma.io/docs/orm/reference/prisma-cli-reference)を参照してください。

## 技術スタック

- **フレームワーク**: Next.js 15
- **データベースORM**: Prisma
- **API**: tRPC
- **認証**: NextAuth.js
- **スタイリング**: Tailwind CSS
- **状態管理**: React Query
- **型チェック**: TypeScript
- **アニメーション**: Framer Motion
- **バリデーション**: Zod、CSP、入力バリデーション

## コントリビューション

貢献を歓迎します！詳細は[コントリビューションガイドライン](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md)をご覧ください。

## ライセンス

このプロジェクトはMITライセンスの下で公開されています。詳細は[LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE)ファイルを参照してください。

## 行動規範（TODO）

本プロジェクトは[行動規範](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md)を遵守しています。ご参加の際は、その内容に同意いただいたものとみなします。

## セキュリティ（TODO）

セキュリティ上の脆弱性を発見した場合は、[セキュリティポリシー](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md)に従ってご報告ください。

## 謝辞

- すべての[コントリビューター](https://github.com/Producdevity/emuready/graphs/contributors)
- インスピレーションと支援をしてくれたエミュレーションコミュニティ

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---