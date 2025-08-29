# Flatito: YAMLおよびJSONファイル用のGrep

YAMLおよびJSONファイル用の一種のgrepです。キーを検索して、その値と位置する行番号を取得できます。

![Example](https://raw.githubusercontent.com/ceritium/flatito/master/docs/screenshot.png)

## 意味

[エスペラント語](https://en.wiktionary.org/wiki/flatito): flati（「お世辞を言う」の過去単数名詞受動分詞）。

## インストール

以下のコマンドを実行してgemをインストールし、アプリケーションのGemfileに追加します：

    $ bundle add flatito

Bundlerを使って依存関係を管理していない場合は、以下のコマンドでgemをインストールします：

    $ gem install flatito

### Nixpkgsパッケージ

[@Rucadi](https://github.com/Rucadi)のおかげで、[nixpkgs](https://search.nixos.org/packages?channel=unstable&show=flatito)としても利用可能です。

    $ nix run nixpkgs#flatito


## 使い方

```sh
Usage:    flatito PATH [options]
Example:  flatito . -k "search string" -e "json,yaml"
Example:  cat file.yaml | flatito -k "search string"

    -h, --help                       Prints this help
    -V, --version                    Show version
    -k, --search-key=SEARCH          Search string
        --no-color                   Disable color output
    -e, --extensions=EXTENSIONS      File extensions to search, separated by comma, default: (json,yaml,yaml)
        --no-skipping                Do not skip hidden files
```
## 開発

リポジトリをチェックアウトした後、依存関係をインストールするために `bin/setup` を実行してください。次に、テストを実行するには `rake test` を実行します。また、実験を行うための対話型プロンプトとして `bin/console` を実行することもできます。

このgemをローカルマシンにインストールするには、`bundle exec rake install` を実行します。新しいバージョンをリリースするには、`version.rb` のバージョン番号を更新し、その後 `bundle exec rake release` を実行します。これにより、バージョンのgitタグが作成され、gitのコミットと作成されたタグがプッシュされ、`.gem`ファイルが[rubygems.org](https://rubygems.org)にプッシュされます。

## コントリビューティング

バグ報告やプルリクエストは、GitHubの https://github.com/ceritium/flatito で歓迎されます。このプロジェクトは安全で歓迎的なコラボレーションの場であることを目的としており、貢献者は[行動規範](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md)を遵守することが期待されています。

## ライセンス

このgemは[MITライセンス](https://opensource.org/licenses/MIT)の条件の下でオープンソースとして利用可能です。

## 行動規範

Flatitoプロジェクトのコードベース、イシュートラッカー、チャットルーム、メーリングリストで交流するすべての人は、[行動規範](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md)に従うことが期待されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---