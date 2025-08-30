![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/v/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/users/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/rating/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/stars/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/chrome-web-store/rating-count/gnhhdgbaldcilmgcpfddgdbkhjohddkj.svg)<br>
![https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj](https://img.shields.io/badge/dynamic/json?label=microsoft%20edge%20add-on&query=%24.version&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)
[![https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme](https://img.shields.io/badge/dynamic/json?label=users&query=%24.activeInstallCount&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme)
[![https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme](https://img.shields.io/badge/dynamic/json?label=rating&query=%24.averageRating&suffix=%2F5&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme)
[![https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme](https://img.shields.io/badge/dynamic/json?label=ratings&query=%24.ratingCount&url=https%3A%2F%2Fmicrosoftedge.microsoft.com%2Faddons%2Fgetproductdetailsbycrxid%2Finjfmegnapmoakbmnmnecjabigpdjeme)](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme)

<!--The ratings badges are currently broken due to [this](https://github.com/badges/shields/issues/5475) and [this](https://github.com/pandawing/node-chrome-web-store-item-property/issues/275#issuecomment-687801815).-->

#### Googleの変更によりプロジェクトがManifest Version 3にアップグレードされたため、アップデートについては https://github.com/june07/nimv3 を参照してください。

[![https://nim.june07.com](https://june07.github.io/image/smallPromoTile.png)](https://nim.june07.com) [![https://nim.june07.com](https://github.com/june07/nimv3/assets/11353590/e6f30f3f-4ae5-4831-bafa-392eaeff66fd)](https://nim.june07.com)

# NiM (Node.js --inspector マネージャー)
###### あなたの開発プロセスを効率化します

* [Google Chrome ウェブストア]([http://bit.ly/2W8hQG9](https://chromewebstore.google.com/detail/nodejs-v8-inspector-manag/gnhhdgbaldcilmgcpfddgdbkhjohddkj?utm_source=github&utm_medium=readme&utm_campaign=nim&utm_content=1))（GoogleのChrome、MicrosoftのEdge、Opera、Vivaldi、Brave、Epicなど、あらゆるChromiumベースのブラウザに対応）
* [Microsoft Edge アドオン](https://microsoftedge.microsoft.com/addons/detail/injfmegnapmoakbmnmnecjabigpdjeme)（MicrosoftのEdgeブラウザ https://www.microsoftedgeinsider.com/en-us/ に対応） 

    ***ご注意ください***: インストールにはあなたのメールアドレスの共有（私にのみ）が必要です。これは他の通知でも説明されていますが、問題が非常に大きいため、過剰なほど明確にしておきたいと思います。メールアドレスの共有に問題がある場合（ちなみに私のメールは667@june07.comです）、ぜひご自身でクローンまたはフォークしてコードの不満な部分を変更するか、別のソリューションを使ってください（NiMほど良いものはありませんが、偏っていますのでご了承ください）。また、直接ご連絡いただければお話も可能です。FacebookやGoogle、Amazonのような大企業とは異なり、私が書いたコードを使ってくださる実際のユーザーの懸念（約99％）を本当に大切にしています。NiMのプライバシーポリシーはこちら https://june07.com/privacypolicy です。ありがとうございます。

## ブログ投稿/アップデート:
* NiMを書いた理由 https://blog.june07.com/inspect-broke-my-workflow/
* カスタムDevTools機能: https://blog.june07.com/nim-custom-devtools-url/
## `about::inspect (chrome://inspect/#devices)` より簡単に

NiMはChrome DevToolsのウィンドウ/タブのライフサイクルを管理し、あなたが重要なこと、つまりコードのデバッグに集中できるようにします。DevToolsのURLをコピー＆ペーストしたり、タブやウィンドウを開閉し続ける必要はもうありません。

NiMは--inspectオプション付きでnodeを実行したときに生成されるURLを自動検出します（ローカルまたはリモート）。NiMはChrome DevToolsをタブまたはウィンドウで自動的に開閉するオプションを提供します。Manual/Auto設定を切り替え、デバッグセッションを開始してください。DevToolsは「Open DevTools」ボタンをクリックするか、指定したタイムアウト後に開きます。自動閉じ設定の場合は、デバッグセッション終了後にDevToolsタブ/ウィンドウが自動で閉じます。

 * ローカルおよびリモートのデバッグセッションを管理・監視
 * DevToolsインターフェースの手動または自動制御
 * DevToolsを新しいタブまたはウィンドウで開く
 * DevToolsを開始時にフォーカスあり/なしに設定
 * v8 Inspectorプローブ間の期間をカスタマイズ
 * 設定の自動保存
 * [VSCode](https://imgur.com/download/PRMn9md)で起動したnodeプロセスをデバッグ
## セットアップ / 使い方 / 方法

シンプルで基本的な手順です... 以下のいずれかの方法でChrome拡張機能をインストールしてください：

1. Chromeウェブストアからインストール：
    https://bit.ly/2W8hQG9 (https://chrome.google.com/webstore/detail/gnhhdgbaldcilmgcpfddgdbkhjohddkj)
2. または、リリースから直接 .crx ファイルをダウンロードしてください：

![https://media.giphy.com/media/xT0xenBpYPF2F0j2fe/giphy.gif](https://media.giphy.com/media/xT0xenBpYPF2F0j2fe/giphy.gif)



# 追加情報が必要ですか？
* NiMのインストール後ページでいくつかのヘルプを提供しています [https://blog.june07.com/nim-install](https://blog.june07.com/nim-install/)
* NiM自体のデバッグ方法 [https://blog.june07.com/debugging-nim/](https://blog.june07.com/debugging-nim/)

*注：執筆時点では、v8の--inspectオプションは比較的新しいものです。オプションの詳細は https://nodejs.org/api/debugger.html#debugger_v8_inspector_integration_for_node_js を参照してください。*
#### NIMの使用を楽しんでいただけましたら、ぜひ[5つ星評価および/またはG+1をお願いいたします。](https://chrome.google.com/webstore/detail/nim-node-inspector-manage/gnhhdgbaldcilmgcpfddgdbkhjohddkj/reviewshttps://chrome.google.com/webstore/detail/nim-node-inspector-manage/gnhhdgbaldcilmgcpfddgdbkhjohddkj/reviews)

あらゆるフィードバックを歓迎します。  [メールをお送りください！](https://raw.githubusercontent.com/june07/NiM/master/mailto:667@june07.com)

<!--
[![IPv4 Lease](https://june07.github.io/image/EVERYTHING.jpg)](https://june07.com/blog/ipv4/?utm_source=NiM&utm_medium=options%20page&utm_campaign=ipv4&utm_content=2)
-->

<div style="display:flex; justify-content:center;">
  <a href="https://m.do.co/c/fe4184318b19" target="_blank" rel="noopener"><IMG border="0" alt="Digitalocean $100 Credit" src="https://june07.github.io/image/digitalocean-credit.png"></a>
</div>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---