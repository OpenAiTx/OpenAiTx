
# Unverceled Next.js

> OpenNextを使用してCloudflare Workersにデプロイされた、ツール重視のNext.js 15スターターキットテンプレート。

## 含まれているもの

このテンプレートは基本的な「Hello World」ページのみですが、必要なツールはすべて含まれています。例えば：

- Changesets
- Github Actions
- Commitlint & Commitizen
- Lefthookのpre-commit & commit-msgフック
- Playwright E2Eテスト
- Vitestのユニット＆ブラウザコンポーネントテスト
- Prettier、ESLint、Cspell & MarkdownLint
- Tailwind V4 & Shadcn UI
- 完全なTypeScript TSリセット
- 厳密なTypeScript設定
- Arktype & T3 Env

## はじめに

1. このテンプレートを使って新しいリポジトリを作成する
2. テンプレートをマシンにクローンする
3. `pnpm install` を実行する
4. `wrangler.toml` ファイルを編集し、自分のKVネームスペースIDとD1データベース名＆IDを入力する
5. Cloudflareにデプロイするには、まず `pnpm wrangler login` を実行し、その後 `pnpm run deploy` を実行するだけです

とても簡単です！

このテンプレートの基本設定を拡張するには、OpenNext Cloudflareのドキュメントを [https://opennext.js.org/cloudflare](https://opennext.js.org/cloudflare) で参照してください。

## 注意事項

- [Cloudflare Workers Builds](https://developers.cloudflare.com/workers/ci-cd/builds/) を使って、mainブランチに新しいコミットがあると自動でアプリケーションをデプロイできます。
- Cloudflare Imagesをカスタムローダーとして使用し、画像最適化が可能です [ドキュメント](https://opennext.js.org/cloudflare/howtos/image)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---