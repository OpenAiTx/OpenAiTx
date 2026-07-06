# SQLite Online

<div align="center">
  <a href="https://yzua.github.io/sqlite-online/">
    <img
      src="https://github.com/user-attachments/assets/aef749bf-df08-4a84-8148-d34b796449d8"
      alt="SQLite Online ロゴ"
      width="128"
    />
  </a>
</div>

React、TypeScript、Vite、`sql.js`で構築されたクライアントサイドのSQLiteエディタです。  
ブラウザ上で動作し、デフォルトでデモデータベースを初期化し、バックエンドなしで  
ローカルのSQLiteファイルを開くことができます。

## 概要

- **ローカルの `.db`、`.sqlite`、`.sqlite3` ファイルを開く**
- **SQLでテーブル、ビュー、インデックスを作成および修正**
- **行の閲覧、フィルター、ソート、ページング、追加、編集、削除**
- **カスタムSQLを実行し、結果をCSVとしてエクスポート**

ほとんどのデータベース処理はWebAssemblyとウェブワーカーを介してブラウザ内でローカルに実行されます。  
URL読み込み、CORSプロキシフォールバック、Google Fonts、Geminiによるクエリ生成などのオプション機能は  
ネットワークリクエストを使用します。

## 機能

- **ローカルファーストのデータベース編集：** ディスクからファイルを開き、データベースをページにドラッグ＆ドロップし、  
  現在のデータベースを `database.sqlite` としてダウンロード可能。
- **スキーマとデータのワークフロー：** スキーマの検査、テーブルデータの閲覧、行の編集、新規行の挿入、行の削除、  
  カスタムSQL文の実行。
- **CSVエクスポートパス：** テーブル全体、現在のテーブルページ、または現在のカスタムクエリ結果セットをCSVとしてエクスポート。
- **追加のUX機能：** ダークモード、高コントラストモード、キーボードショートカット、スキップリンク、アクセシビリティのためのライブリージョン。
- **オプションの統合機能：** `?url=` クエリパラメータからデータベースを読み込み、Gemini APIキーを設定後に `/ai ...` プロンプトからSQL生成。





## 開発

```bash
npm install
npm run dev
```
便利なプロジェクトコマンド:

- `npm run build`
- `npm run build:pages`
- `npm run typecheck`
- `npm run check`
- `npm run check:fix`
- `npm run doctor`
- `npm run preview`
- `npm run preview:pages`
- `npm run lint`
- `npm run lint:fix`
- `npm run format`
- `npm run format:check`
- `npm test`
- `npm run test:watch`
- `npm run knip`
- `npm run deploy`

## キーボードショートカット（ホットキー）

これらの組み込みホットキーでワークフローを効率化しましょう:

| ショートカット         | 操作                         |
| --------------------- | --------------------------- |
| **Ctrl + s**          | データベースをダウンロード   |
| **Ctrl + ArrowRight** | 次のページに移動             |
| **Ctrl + ArrowUp**    | 最初のページにジャンプ       |
| **Ctrl + ArrowDown**  | 最後のページにジャンプ       |
| **Ctrl + ArrowLeft**  | 前のページに移動             |
| **Ctrl + \`**         | 編集パネルを閉じる           |
| **Ctrl + i**          | 挿入モード / 挿入を送信      |
| **Ctrl + u**          | 更新編集を送信               |
| **Ctrl + d**          | 削除編集を送信               |
| **Ctrl + q**          | SQLクエリを実行              |

## ライセンス

SQLite Online は [GNU GPL v3.0](https://github.com/yzua/sqlite-online/blob/main/LICENSE) の下でリリースされています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---