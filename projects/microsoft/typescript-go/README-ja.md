# TypeScript 7

[これが何か分からない場合は、アナウンス投稿をお読みください！](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## プレビュー

プレビュービルドは npm で `@typescript/native-preview` として利用可能です。

```sh
npm install @typescript/native-preview
npx tsgo # tsc と同様に使用します。
```

プレビュー版の VS Code 拡張機能は[VS Code マーケットプレイス](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview)で入手可能です。

これを使用するには、VS Code の設定に以下を追加してください：

```json
{
    "typescript.experimental.useTsgo": true
}
```

## ビルドと実行方法

このリポジトリは [Go 1.24 以上](https://go.dev/dl/)、[Rust 1.85 以上](https://www.rust-lang.org/tools/install)、[Node.js と npm](https://nodejs.org/)、および [`hereby`](https://www.npmjs.com/package/hereby) を使用します。

テストやコード生成のため、このリポジトリには移植対象のコミットを指し示す TypeScript 本体リポジトリへの git サブモジュールが含まれています。
クローン時にはサブモジュール付きでクローンしてください：

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

既にリポジトリをクローンしている場合は、サブモジュールを以下で初期化できます：

```sh
git submodule update --init --recursive
```

サブモジュールが揃い `npm ci` を実行した後、`hereby` でタスクを実行できます（TypeScript 本体リポジトリと同様です）：

```sh
hereby build          # プロジェクトのビルドを検証
hereby test           # すべてのテストを実行
hereby install-tools  # linter など追加ツールのインストール
hereby lint           # すべての linter を実行
hereby format         # すべてのコードのフォーマット
hereby generate       # すべての Go コードを生成（例：diagnostics、リポジトリにコミット）
```

追加タスクは作業中です。

`hereby` はリポジトリ作業に必須ではありません；通常の `go` ツール（例：`go build`, `go test ./...`）も期待通り動作します。
`hereby` タスクは TypeScript リポジトリに慣れている方への利便性として提供されています。

### `tsgo` の実行

`hereby build` 実行後、`built/local/tsgo` を実行できます。これは主に `tsc` と同じ動作をします。

### LSP プロトタイプの実行

VS Code 拡張機能をグローバルにインストールせずにデバッグ・実行するには：

* リポジトリのワークスペースで VS Code を起動（`code .`）
* `.vscode/launch.template.json` を `.vscode/launch.json` にコピー
* <kbd>F5</kbd>（またはコマンドパレットから `Debug: Start Debugging`）

これで Corsa LS をバックエンドに使用する新しい VS Code インスタンスが起動します。正しく設定されていれば、TypeScript または JavaScript ファイルを開くとステータスバーに「tsgo」と表示されます：

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)

## これまでに動作していること

これはまだ進行中の作業であり、TypeScript と完全な機能互換には達していません。バグが存在する可能性があります。新しい issue を登録する前や意図的な変更と判断する前に、このリストをよくご確認ください。

| 機能 | 状態 | 備考 |
|---------|--------|-------|
| プログラム作成 | 完了 | TS5.8 と同じファイル・モジュール解決。全解決モードは未対応。 |
| パース／スキャン | 完了 | TS5.8 と全く同じ構文エラー |
| コマンドラインと `tsconfig.json` パース | ほぼ完了 | 現状エントリーポイントがやや異なる |
| 型解決 | 完了 | TS5.8 と同じ型 |
| 型チェック | 完了 | TS5.8 と同じエラー・位置・メッセージ。エラー内型出力は表示が異なる場合あり（対応中） |
| JavaScript 固有推論・JS Doc | 未対応 | - |
| JSX | 完了 | - |
| 宣言出力 | 対応中 | 一般的な機能は対応済みだが一部エッジケースやフラグ未対応 |
| 出力（JS 出力） | 対応中 | `target: esnext` は十分対応。他ターゲットは未対応箇所あり |
| ウォッチモード | プロトタイプ | ファイル監視・再ビルドは可、増分再チェックなし |
| ビルドモード／プロジェクト参照 | 未対応 | - |
| 増分ビルド | 未対応 | - |
| 言語サービス（LSP） | プロトタイプ | 最小限（エラー・ホバー・定義ジャンプ）。機能拡張予定 |
| API | 未対応 | - |

定義：

 * **完了**（"believed done"）: 現時点で未対応や大きな作業残は認識していません。バグ報告OK
 * **対応中**: 作業中。一部動作しない機能あり。パニック報告OK、それ以外はご遠慮を
 * **プロトタイプ**: 検証用のみ。バグ報告しないでください
 * **未対応**: まだ着手していないか、対応が遠く手を出さないでください

## その他の注意

長期的には、このリポジトリおよび内容は `microsoft/TypeScript` に統合される予定です。
そのため、typescript-go のリポジトリおよび issue トラッカーは最終的にクローズされる見込みです。議論・issue の扱いにはご注意ください。

TypeScript 5.7 からの意図的な変更リストについては CHANGES.md を参照してください。

## コントリビュートについて

このプロジェクトは貢献や提案を歓迎します。ほとんどの貢献には、
Contributor License Agreement (CLA) への同意が必要です。これは、あなたがその貢献を行う権利を持ち、
実際に貢献する権利を当方に付与することを宣言するものです。詳細は [Contributor License Agreements](https://cla.opensource.microsoft.com) をご参照ください。

プルリクエストを提出すると、CLA ボットが自動的に CLA が必要かどうかを判定し、
PR にステータスチェックやコメントを付与します。指示に従ってください。
CLA の同意は、当社の CLA を利用しているすべてのリポジトリで一度だけ必要です。

このプロジェクトでは [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) を採用しています。
詳細は [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) をご覧いただくか、
追加のご質問・ご意見は [opencode@microsoft.com](mailto:opencode@microsoft.com) までご連絡ください。

## 商標について

このプロジェクトにはプロジェクト・製品・サービスの商標やロゴが含まれている場合があります。Microsoft の
商標やロゴの正規の使用は
[Microsoft の商標およびブランドガイドライン](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general)
に従う必要があります。改変版で Microsoft の商標やロゴを使用する場合、混乱や Microsoft の後援を示唆しないようにしてください。
第三者商標やロゴの使用は各第三者のポリシーに従ってください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---