# チートシート

[![GitHub](https://img.shields.io/badge/github-michaelmagan/cheatsheet-blue?logo=github)](https://github.com/michaelmagan/cheatsheet)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](./LICENSE)
[![Next.js](https://img.shields.io/badge/Next.js-15-black?logo=next.js)](https://nextjs.org/)
[![Tambo AI](https://img.shields.io/badge/Tambo-AI-purple)](https://tambo.co)

[Tambo AI](https://tambo.co) を使って構築された、AI搭載のオープンソースGoogle Sheets競合製品です。

自然言語でインタラクティブなスプレッドシートを構築・操作し、グラフやビジュアライゼーションと共に扱えます。

## デモ
ぜひお試しください：**[CheatSheet](https://cheatsheet.tambo.co)**

### プレビュー
https://github.com/user-attachments/assets/da72aa8b-6bc5-468e-8f42-0da685105d22

## 特徴

- **AIによる編集**：自然言語でスプレッドシートと対話。
- **セル選択**：AIと対話するセルを選択可能。
- **マルチモーダル**：メッセージと共に画像を添付。
- **チャートとグラフ**：スプレッドシートのデータからビジュアライゼーションを作成。
- **モデルコンテキストプロトコル（MCP）**：外部データソースやツールと接続。

## ロードマップ

- **音声入力**：タイピングに加えて音声入力を利用可能に。
- **数式サポート**：スプレッドシートの数式（SUM、AVERAGE、IF、VLOOKUPなど）。
- **より良い書式設定**：テーブルのビジュアルオプション拡充（色、枠線、フォント、配置）。
- **インポート/エクスポート**：CSV、XLSX、JSON対応。

## はじめに

1. このリポジトリをクローン

2. プロジェクトディレクトリに移動：

   ```bash
   cd spreadsheet-template
   ```
3. 依存関係のインストール:

   ```bash
   npm install
   ```

4. 環境変数を設定します：

   **オプションA：Tambo CLIを使用する（推奨）**
   ```bash
   npx tambo init
   ```
   これにより、対話形式でTambo APIキーの入力を求められ、`.env.local`が自動的に作成されます。

   **オプションB：手動セットアップ**
   ```bash
   cp example.env.local .env.local
   ```
   次に `.env.local` を編集し、[tambo.co/dashboard](https://tambo.co/dashboard) から取得したAPIキーを追加します。

5. 開発サーバーを起動します：
   ```bash
   npm run dev
   ```
6. ブラウザで [http://localhost:3000](http://localhost:3000) を開いてアプリを使用してください！

## アーキテクチャ概要

このテンプレートは、AIがスプレッドシートを読み取り、更新する3つの方法を示しています：

### AIがスプレッドシートの状態にアクセスする方法

**コンテキストヘルパー**（読み取り専用データ）
- `spreadsheetContextHelper` - 現在のタブのデータをマークダウンテーブルとしてAIに提供します
- `spreadsheetSelectionContextHelper` - AIに現在選択されている内容を伝えます
- `tabContextHelper` - すべてのタブをリストアップし、アクティブなタブを強調表示します
- メッセージを送信するたびに自動で実行されます
- 参照：`src/lib/spreadsheet-context-helper.ts`、`src/lib/spreadsheet-selection-context.ts`、`src/lib/tab-context-helper.ts`

**ツール**（変更を加える）
- AIが状態を変更したりメタデータを調査したりするためのスプレッドシートおよびタブツール
- コンテキストヘルパーは読み取り専用；ツールは変更を行います
- 参照：`src/tools/spreadsheet-tools.ts`、`src/tools/tab-tools.ts`

### スプレッドシートツールリファレンス

| ツール | 目的 |
|------|---------|
| `updateCell` | 単一セルの値を更新 |
| `updateRange` | 複数セルを一度に更新 |
| `addColumn` | 新しい列を追加 |
| `removeColumn` | 列を削除 |
| `addRow` | 新しい行を追加 |
| `removeRow` | 行を削除 |
| `readCell` | 単一セルの値を読み取る |
| `readRange` | 複数セルを読み取る |
| `clearRange` | 範囲内のセルの値をクリア |
| `sortByColumn` | 列の値で行を並べ替え |

### 主要ファイル

**設定**
- `src/lib/tambo.ts` - コンポーネントおよびツールの登録

- `src/app/chat/page.tsx` - TamboProviderを使用したメインチャットインターフェース

**スプレッドシートシステム**
- `src/components/ui/spreadsheet-tabs.tsx` - FortuneSheetワークブックラッパー＋タブUI
- `src/lib/fortune-sheet-store.tsx` - ワークブック状態を結線するインメモリグローバルストア
- `src/lib/fortune-sheet-utils.ts` - FortuneSheet中心のヘルパー（範囲、ルックアップ）

**状態管理**
- `src/lib/canvas-storage.ts` - キャンバス／タブ状態管理
- スプレッドシートの状態はFortuneSheetプロバイダーとワークブックAPIを通じて流れます。

**依存関係についての注意：** FortuneSheet（`@fortune-sheet/{core,react}`）がすべてのスプレッドシート操作を支えています。

## カスタマイズ

### カスタムコンポーネントの追加

AIがチャット内でインラインレンダリングできるコンポーネントを`src/lib/tambo.ts`に登録します。例の構造：

```tsx
import type { TamboComponent } from "@tambo-ai/react";

const components: TamboComponent[] = [
  {
    name: "MyComponent",
    description: "When to use this component",
    component: MyComponent,
    propsSchema: myComponentSchema, // Zod schema
  },
];
```

コンポーネントの例は `src/components/tambo/` を参照し、詳細なガイダンスは [Tambo Components docs](https://docs.tambo.co/concepts/components) をご覧ください。

### カスタムツールの作成

`src/tools/` に以下のパターンでツールを追加してください：

```tsx
export const myTool = {
  name: "toolName",
  description: "What this tool does",
  tool: async (param: string) => {
    // Implementation
    return { success: true, message: "Result" };
  },
  toolSchema: z.function().args(
    z.string().describe("Parameter description")
  ).returns(z.object({
    success: z.boolean(),
    message: z.string().optional(),
  })),
};
```

`src/lib/tambo.ts` の tools 配列に登録します。詳細は [Tambo Tools ドキュメント](https://docs.tambo.co/concepts/tools) を参照してください。

### モデルコンテキストプロトコル（MCP）

設定モーダルから MCP サーバーを構成し、外部データソースに接続します。サーバーはブラウザの localStorage に保存され、チャットインターフェースでは `TamboMcpProvider` でラップされます。

## ドキュメント

Tambo について詳しくはこちら：
- [コンポーネント](https://docs.tambo.co/concepts/components)
- [インタラクタブルコンポーネント](https://docs.tambo.co/concepts/components/interactable-components)
- [ツール](https://docs.tambo.co/concepts/tools)
- [追加コンテキスト](https://docs.tambo.co/concepts/additional-context)

[Tambo AI](https://tambo.co) で構築 - AI搭載UIを作成するためのフレームワーク。Tambo はオープンソースです：[tambo-ai/tambo](https://github.com/tambo-ai/tambo)。

![Tambo テンプレートデモ](https://raw.githubusercontent.com/tambo-ai/tambo/main/assets/template.gif)

## コントリビューション

コントリビューション歓迎！ガイドラインは [CONTRIBUTING.md](https://raw.githubusercontent.com/michaelmagan/cheatsheet/main/./CONTRIBUTING.md) を参照してください。

## ライセンス

MIT ライセンス


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---