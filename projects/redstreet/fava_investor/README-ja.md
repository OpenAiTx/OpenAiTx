# Fava Investor

Fava Investorは、[Beancount](https://beancount.github.io/)および
[Fava](https://github.com/beancount/fava)（[プレーンテキストによる複式簿記](https://plaintextaccounting.org/)向けソフトウェア）用の
投資に関する包括的なレポート、分析、ツールのセットを目指しています。これはモジュールの集合として開発されており、
各モジュールは*Favaプラグイン、Beancountライブラリ、シェルコマンド*を提供します。

### 現在のモジュール:
- [クラス別の視覚的なツリー構造資産配分](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/assetalloc_class#readme)
- 口座別資産配分
- [税損収穫ツール](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/tlh#readme)
- [キャッシュドラック分析](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/cashdrag#readme)
- [サマライザー](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/summarizer#readme)
- [利益最小化ツール](https://github.com/redstreet/fava_investor/blob/main/fava_investor/modules/minimizegains#readme)

### デモ
***[pythonanywhere](http://favainvestor.pythonanywhere.com/example-beancount-file/extension/Investor/)で
ライブデモをお試しください。***


#### スクリーンショット（日付付き）:
![Screenshot: TLH](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot.png)
![Screenshot: Asset Allocation](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot-assetalloc.png)

### ユーティリティ

Fava Investorには`ticker-util`が付属しており、これは以下のユーティリティの集合です：
- Yahooからコモディティ（ティッカー）の情報をダウンロードし、
  コモディティ宣言にメタデータを注釈付けする
- Beancountファイル内のティッカー間の関係を発見する、例えば同等または実質的に同一のティッカー、
  そして税損収穫のパートナーグループを、最小かつ不完全な仕様から抽出する
- インポーターにISINなどのティッカー識別情報を提供する

詳細については、pipでfava_investorをインストールし、以下を参照してください：



```
ticker-util --help
ticker-util relate --help
```

## インストール

```bash
pip3 install fava-investor
```

または、gitから最新の開発版をインストールするには：
```bash
pip3 install git+https://github.com/redstreet/fava_investor
```
MacOSのインストールについては[#55](https://github.com/redstreet/fava_investor/issues/55)を参照してください。

最新バージョンのFava InvestorはBeancount v2およびv3の両方に対応していることに注意してください。

## Fava Investorの実行
### Fava内での実行：
これをbeancountのソースに追加し、通常通りfavaを起動してください：
```
2000-01-01 custom "fava-extension" "fava_investor" "{}"
```

favaのサイドバーに「Investor」リンクが表示されているはずです。拡張機能の設定方法の詳細は、同梱の `huge-example.beancount` を参照してください。

### コマンドラインでの実行：
コマンドラインインターフェース（CLI）は `investor` コマンドでアクセスでき、各モジュールごとのサブコマンドがあります。例：



```
investor assetalloc-class
investor tlh
investor --help
```

CLIとユーティリティ（`ticker-util`）はどちらも[click](https://click.palletsprojects.com/en/8.1.x/)を使用しています。
[zsh、bash、fishでのシェル補完の有効化についてはこちら](https://click.palletsprojects.com/en/8.1.x/shell-completion/#enabling-completion)を参照してください。強く推奨されます。

## 問題がありますか？
- favaを実行している端末を監視し、fava_investorからのエラー出力を確認してください
- バグ報告やヘルプを求める際には、上記のエラーメッセージを含めてください

## 貢献について

機能追加、修正、改善を歓迎します。以下を覚えておいてください：
- プルリクエストを自由に送ってください。ユニットテストを必ず含めてください
- 大きな変更や議論が必要な変更の場合は、時間節約のために先に連絡して議論してください（issueを開く）
- コミットは（適切に）スカッシュしてください
- コミットメッセージには[conventional commits](https://www.conventionalcommits.org/en/v1.0.0/)を使用してください

ご協力ありがとうございます！

## 関連プロジェクト
- [Fava Dashboards](https://github.com/andreasgerstmayr/fava-dashboards)
- [Fava Portfolio Returns](https://github.com/andreasgerstmayr/fava-portfolio-returns)
- [Beangrow](https://github.com/beancount/beangrow)





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---