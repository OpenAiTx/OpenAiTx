<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim コミュニティリポジトリ</h1>

AstroNvim のコミュニティリポジトリにはプラグイン設定仕様が含まれており、AstroNvim（NeoVim の設定）のためにコミュニティが提供するプラグインのコレクションです。これらの仕様は、AstroNvim で使用されるさまざまなプラグインの管理を支援します。

## 📦 セットアップ

コミュニティプラグインを統合するには、提供された設定を `plugins` セットアップに追加してください。可能であれば、自分のプラグインをインポートする前に追加し、すべての AstroCommunity の変更が自分の上書きより先に読み込まれるようにします。[AstroNvim テンプレート](https://github.com/AstroNvim/template) を使用している場合は、`lua/community.lua` ファイルでこれを行うことができます。プラグイン設定に不慣れな場合は、[AstroNvim ドキュメント](https://docs.astronvim.com/configuration/customizing_plugins/)を参照することをおすすめします。

### AstroCommunity プラグインのインポート

`lua/community.lua` ファイルに以下の内容を統合してください:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "astrocommunity.colorscheme.catppuccin" },
  -- ... ここにコミュニティ提供プラグインをインポート
}
```

### AstroCommunity インストールのカスタマイズ

`lua/community.lua` に AstroCommunity のインポートを定義したら、独自のプラグイン定義（通常は `lua/plugins/` ディレクトリ）でインストールをさらにカスタマイズできます。以下は、上記のように Catppuccin をインストールしている例です。

```lua
return {
  { -- コミュニティによる設定をさらにカスタマイズ
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**注意事項:**

- インポートを無効化するには、`enabled` オプションを `false` に設定してください。既存のプラグインを修正するには、リポジトリのフルネーム（例: "m4xshen/smartcolumn.nvim"）かモジュール名（例: "catppuccin"）のどちらかを使用できます。モジュール名はフォルダ名と異なる場合がありますのでご注意ください。
- プラグインをカスタマイズする際は、リポジトリ名だけの省略形ではなく、完全なインポートパスの使用を推奨します。
- コミュニティプラグインの設定、依存関係、バージョンなど多くの側面を上書き可能です。利用可能なオプションの詳細は、[lazy.nvim ドキュメント](https://lazy.folke.io/)を参照してください。

## コントリビュート

プラグイン設定を作成し、AstroCommunity リポジトリに追加したい場合は、[Contribution Guidelines](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) に従いプルリクエストを提出してください。変更は十分にテストしてからの提出をお願いいたします。このリポジトリは公式のものではなく、その安定性はコミュニティの貢献に依存しています。プロジェクトがどのように成長し進化していくか楽しみにしています！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---