## プロジェクトのドキュメントライブラリを簡単に作成する方法

デモ: [https://easydocs.codeandmedia.com/](https://easydocs.codeandmedia.com/)

このテーマは [Zola](https://getzola.org)（静的サイトエンジン）用で、プロジェクトのドキュメントを簡単かつ迅速に構築・公開するのに役立ちます。Zolaは単一のバイナリで、Markdownで書かれたドキュメントをビルドするとHTMLページと追加の静的アセットを出力します。つまり、このテーマ、mdファイル、Zolaを組み合わせることで、柔軟かつシンプルなドキュメント用ウェブサイトを作成できます。

### ステップバイステップ

ご存知かもしれませんが、Zolaは非常に柔軟です :) したがって、以下のシナリオは数百の可能な方法のうちの一例であり、ご自身に最適な方法を見つけてください。また、Zolaは独自のテーマインストールおよび使用機構を提供しています。詳細は[ドキュメント](https://www.getzola.org/documentation/themes/installing-and-using-themes/)をご覧ください。

1. リポジトリをフォークし、contentフォルダー内のデモコンテンツを自分のものに置き換えます。ただし、_index.mdファイルを確認してください。これには`title`が含まれており、見出しの右側にアンカーを表示したい場合は、各indexに`insert_anchor_links = "right"`を追加します。`theme.toml`、スクリーンショット、readmeも削除して構いません。
2. `config.toml`内のURLとタイトルを自分用に変更します。extraセクションでは、ナビゲーションのロゴ下に表示されるバージョン用のGitHub APIパス、favicon、ロゴそのものを指定できます。不要であれば行を削除してください。また、Zolaに関連する追加設定を構成または有効化できます。[仕様はこちら](https://www.getzola.org/documentation/getting-started/configuration/)。
3. sass/_variables.scssでフォント、色、背景を変更することも可能です。
4. ほぼ完了です。次に、どのようにビルドし、どこにウェブサイトをホストするかを決定してください。ローカルでビルドしてどこかにアップロードすることも、GitHub ActionsでビルドしてGitHub Pages / Netlify / CloudFlare Pages / AnyS3CloudStorageでホストすることもできます。[GitHub Pagesの方法](https://www.getzola.org/documentation/deployment/github-pages/)。[私の例](https://github.com/o365hq/o365hq.com/blob/main/.github/workflows/main.yml)は2段階ビルドのGitHubワークフローです（最初はリンクとスペルチェック、次にAzureへアップロード）。[Dockerfile](https://github.com/codeandmedia/zola_docsascode_theme/blob/master/Dockerfile)でDockerイメージを作成可能。

## 提供される設定オプション

これらのオプションは[config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml)の`extra`セクションで設定可能です。
存在しない場合は、スターターの[config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml)に示されるデフォルトの動作と同じになります。

- **easydocs_logo_always_clickable** はロゴが常にクリック可能かを制御します。デフォルトでは、ホームページ以外のときのみロゴはクリック可能です。これを有効にすると、ホームページでもロゴがクリック可能になり、ホームページ上では基本的にページをリロードする動作になります。
- **easydocs_uglyurls** はウェブサーバーを使わないオフラインサイトをサポートします。trueに設定するとナビのリンクは`index.html`を含む完全なパスで生成されます。この機能は[Abridgeテーマ](https://www.getzola.org/themes/abridge/)に触発されました。これを機能させるには、base URLをサイトを保存するローカルフォルダ（例：`base_url = file:///home/user/mysite/public/`）に設定する必要があります。したがって、これはポータブルではなく特定のローカルフォルダでのみ動作しますが、ウェブサーバーを必要としません。
- **easydocs_heading_threshold** はページに表示される見出しの最小数を制御し、その数未満の場合は左側のナビゲーションに見出しが表示されません。デフォルトは5です。例えば常に各ページで見出しを表示したい場合は1に設定します。

ドキュメントをお楽しみください！

* _アイコン: [Office UI Fabric Icons](https://uifabricicons.azurewebsites.net/)_
* _コピーコードボタン: [Aaron Luna](https://aaronluna.dev/blog/add-copy-button-to-code-blocks-hugo-chroma/)_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---