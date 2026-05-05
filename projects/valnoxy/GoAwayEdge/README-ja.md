<div align="center">

  <!-- PROJECT LOGO -->
  <br />
    <a href="https://goawayedge.com">
      <img src="https://dl.exploitox.de/goawayedge/gh-banner-goawayedge.png" alt="GoAwayEdge バナー">
    </a>
  <br />

  [![Version][version-shield]][version-url]
  [![Download Counter][downloads-shield]][downloads-url]
  [![License][license-shield]][license-url]
  [![Weblate][weblate-shield]][weblate-url]
</div>

[version-shield]: https://img.shields.io/github/v/release/valnoxy/GoAwayEdge?color=9565F6
[version-url]: https://github.com/valnoxy/GoAwayEdge/releases

[weblate-shield]: http://translate.valnoxy.dev/widget/goawayedge/svg-badge.svg
[weblate-url]: https://translate.valnoxy.dev/engage/goawayedge/

[downloads-shield]: https://img.shields.io/github/downloads/valnoxy/GoAwayEdge/total.svg?color=431D93
[downloads-url]: https://github.com/valnoxy/GoAwayEdge/releases

[license-shield]: https://img.shields.io/github/license/valnoxy/GoAwayEdge?color=9565F6
[license-url]: https://img.shields.io/github/license/valnoxy/GoAwayEdge

<div align="center">
  <h3 align="center">GoAwayEdge</h3>
  <p align="center">
    <p>Microsoft Edgeが嫌いですか？私もです。すべてのEdge呼び出しをお気に入りのブラウザにリダイレクトしましょう！</p>
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">今すぐダウンロード</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/issues">バグ報告</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/discussions/">ディスカッション</a>
    ·
    <a href="https://translate.valnoxy.dev/engage/goawayedge/">翻訳を手伝う</a>
    <br />
    <br />
    🎉 バージョン2.0.1がリリースされました。リリースノートは
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">こちら</a>をご覧ください。
    <br />
    <br />
  </p>
</div>

---

> [!NOTE]
> このアプリケーションはシステムを変更します。使用中に発生したいかなる損害についても責任を負いかねますのでご了承ください。

# 🚀紹介
GoAwayEdgeは、私のようにMicrosoft EdgeやWindows Copilotが好きではない人のために設計されています。Edgeが突然起動してイライラすることが多いなら、ご安心ください！この賢いユーティリティは、Edgeに関連するすべての呼び出しをお好みのブラウザにリダイレクトし、シームレスなブラウジング体験を提供します。

GoAwayEdgeの主なポイントは以下の通りです：

- 目的：GoAwayEdgeの主な目的は、通常Microsoft Edgeを起動させるリクエストやアクションを傍受し、それらを代わりにお好みのブラウザにリダイレクトすることです。
- 動作方法：GoAwayEdgeはImage File Execution Optionsを通じてフックを行い、Edgeプロセスの起動を阻止します。その後、引数を読み取り解析し、デフォルトのブラウザにリダイレクトします。
- 互換性：Windows 10 / 11システムで動作し、Edgeを完全に回避したい方にシンプルな解決策を提供します。

コードの確認や貢献、あるいは予期せぬEdgeの起動なしにブラウザ体験をお楽しみください！🚀

# 🤸 インストール方法
## 💿 1. デフォルトインストール
1. [GitHub](https://github.com/valnoxy/GoAwayEdge/releases)から最新バージョンをダウンロードします。
2. アプリケーションを起動します。
3. ライセンスに同意します。
4. GoAwayEdgeをお好みにカスタマイズします。
5. 完了です！

## 📦 2. パッケージマネージャー
| パッケージマネージャー        | コマンド                                                             |
| ------------------------ | ------------------------------------- |
| winget                   | `winget install Exploitox.GoAwayEdge`<br>事前設定したい場合は`--custom`を使用可能：`winget install goawayedge --custom "-e:DuckDuckGo"` |                        

## 🤫 3. サイレントインストール
以下の引数を解析することでGoAwayEdgeをサイレントインストールできます：

| スイッチ                  | 説明                                                                                                                    |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `-s`                     | サイレントインストール                                                                                                          |
| `-e:<Engine>`            | 検索エンジンを指定: `Google`（デフォルト）、`Bing`、`DuckDuckGo`、`Yahoo`、`Yandex`、`Ecosia`、`Ask`、`Qwant`、`Perplexity`     |
| `-a:<AI Service>`        | AIサービスを指定: `Default`、`Copilot`、`ChatGPT`、`Gemini`、`GitHub_Copilot`、`Grok`                                            |
| `-w:<Weather Service>`   | 天気サービスを指定: `Default`、`WeatherCom`、`AccuWeather`                                                                       |
| `--search-url:<Url>`     | カスタム検索クエリURL（例: `https://google.com/search?q=`）                                                                     |
| `--ai-url:<Url>`         | カスタムAIウェブサイト（例: `https://chatgpt.com`）                                                                             |
| `--weather-url:<Url>`    | カスタム天気クエリURL（例: `https://my-weather.com/{country-code}/{latitude},{longitude}`）                                      |

<b>例</b>:

```bat
GoAwayEdge.exe -s -e:DuckDuckGo
```

# 🗑️ GoAwayEdgeの削除
GoAwayEdgeは他のアプリケーションと同様にアンインストールできます。あるいは、以下の方法でも可能です：
1. [GitHub](https://github.com/valnoxy/GoAwayEdge/releases)から最新バージョンをダウンロードします。
2. アプリケーションを起動します。
3. ```アンインストール```をクリックします。
4. 完了！

以下の引数を解析することで、GoAwayEdgeをサイレントにアンインストールすることもできます：
```bat
GoAwayEdge.exe -u
```

# 🖼️ スクリーンショット
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot2.png" alt="GoAwayEdge セットアップ" width=650>
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot3_Bar.png" alt="Copilot 置換" width=300>

# 🙏 ライブラリ
このプロジェクトでは以下のライブラリを使用しています:
- [ManagedShell](https://github.com/cairoshell/ManagedShell)
- [Microsoft.Toolkit.Uwp.Notification](https://github.com/CommunityToolkit/WindowsCommunityToolkit)
- [TaskScheduler](https://github.com/dahall/taskscheduler)
- [WPF-UI](https://github.com/lepoco/wpfui)


# 🧾 ライセンス
GoAwayEdgeは[MIT](https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE)ライセンスの下で提供されています。したがって、自由に使用および改変することが許可されています。いかなる結果についても私は責任を負いません。すべての行動は自己責任で行ってください。

<hr>
<h6 align="center">© 2018 - 2026 valnoxy. 全著作権所有。 
<br>
By Jonas Günner &lt;jonas@exploitox.de&gt;</h6>
<p align="center">
	<a href="https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE"><img src="https://img.shields.io/static/v1.svg?style=for-the-badge&label=License&message=MIT&logoColor=d9e0ee&colorA=363a4f&colorB=b7bdf8"/></a>
</p


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---