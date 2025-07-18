<a href="https://www.usebillsplit.com/">
<img alt="Self" src="https://raw.githubusercontent.com/Nutlope/billsplit/main/./public/og.png">
</a>

<div align="center">
    <h1 >BillSplit</h1>
    <p>
        モダンな割り勘アプリ。Together.aiによって提供されています。
    </p>
</div>

## 技術スタック

- 最新のウェブ開発のためのNext.js 15とApp Router
- 高度なLLM機能のためのTogether.ai
- LLMの可視化と監視のためのHelicone
- 安全な画像保存のためのAmazon S3
- シームレスなデプロイとホスティングのためのVercel

## 仕組み

1. ユーザーが請求書の写真をアップロードします
2. アプリがVisionモデルとJsonモードを使用してTogether.aiでPDFを処理します
3. ユーザーがアイテムの分割方法を選び、名前を追加できます
4. アプリが割り勘の最終集計を表示します

## クローン＆実行

1. リポジトリをフォークまたはクローンします
2. LLM用に https://togetherai.link でアカウントを作成します
3. S3バケット用に https://aws.amazon.com/ でアカウントを作成します
4. `.env`ファイルを作成し（参考に`.example.env`を使用）、APIキーを置き換えます
5. `pnpm install` と `pnpm run dev` を実行して依存関係をインストールし、ローカルで起動します


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---