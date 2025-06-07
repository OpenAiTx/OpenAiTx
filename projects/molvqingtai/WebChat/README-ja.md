<p align="center">
  <img src="https://github.com/molvqingtai/WebChat/blob/master/public/logo.png" width="200px"/>
</p>

# WebChat

[![GitHub License](https://img.shields.io/github/license/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/blob/master/LICENSE) [![Chrome Web Store Version](https://img.shields.io/chrome-web-store/v/cpaedhbidlpnbdfegakhiamfpndhjpgf)](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf) [![GitHub Release](https://img.shields.io/github/v/release/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/releases)

> どのウェブサイトでも誰とでもチャット

これは、分散型かつサーバーレスで、WebRTCによるエンドツーエンド暗号化通信を利用した匿名チャットのブラウザ拡張機能です。プライバシーを重視しており、すべてのデータはローカルに保存されます。

目的は、あらゆるウェブサイトにチャットルーム機能を追加することです。もう二度と孤独を感じることはありません。

### インストール

**ストアからインストール**

- [Chrome ウェブストア](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf)
- [Edge ウェブストア](https://microsoftedge.microsoft.com/addons/detail/mmfdplbomjjlgdffecapcpgjmhfhmiob)
- [Firefox アドオン](https://addons.mozilla.org/firefox/addon/webchat/)

**手動インストール**

1. GitHubリポジトリ（[リリース](https://github.com/molvqingtai/WebChat/releases)）へアクセス
2. 「Assets」ボタンをクリックし、「web-chat-*.zip」を選択
3. ZIPファイルをPC上の任意のフォルダに解凍
4. ブラウザの拡張機能管理ページを開く（通常は chrome://extensions/）
   - 「デベロッパーモード」を有効にする
   - 「パッケージ化されていない拡張機能を読み込む」をクリックし、先ほど解凍したフォルダを選択

### 使い方

拡張機能をインストールすると、任意のウェブサイトの右下にゴーストアイコンが表示されます。それをクリックすると、同じサイト上の他の人と楽しくチャットできます！

### 動画

https://github.com/user-attachments/assets/e7ac9b8e-1b6c-43fb-8469-7a0a2c09d450

### 巨人の肩の上に立つ

分散型チャットという優れたアイデアに加え、いくつかの素晴らしい技術も活用しています。

- **[remesh](https://github.com/remesh-js/remesh)**: JavaScriptでDDD原則を実装したフレームワーク。UIとロジックの真の分離を実現し、UI部分の実装（たとえばVueでの書き換え）が容易です。UIに依存しない設計となっています。

- **[shadcn/ui](https://ui.shadcn.com/)**: 美しいUIライブラリであり、ノーインストールコンセプトの先駆者。スタイルのカスタマイズが非常に便利です。

- **[wxt](https://wxt.dev/)**: これまで使った中で最高のブラウザ拡張機能開発フレームワークです。

- ~~**[trystero](https://github.com/dmotz/trystero)**: 分散型通信を実現するための中核的依存ライブラリ。IPFS、トレント、Nostrなどの分散型ネットワークへの接続を可能にします。~~
- **[Artico](https://github.com/matallui/artico)**: 独自のWebRTCベースソリューション作成を支援する柔軟なライブラリ群

- **[ugly-avatar](https://github.com/txstc55/ugly-avatar)**: ランダムで魅力的なアバターを作成できます。

### スポンサー

WebChatはオープンソースプロジェクトであり、その継続的な開発はこれら素晴らしい支援者のサポートによって完全に成り立っています。

[![Powered by DartNode](https://dartnode.com/branding/DN-Open-Source-sm.png)](https://dartnode.com "Powered by DartNode - Free VPS for Open Source")

### ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](https://github.com/molvqingtai/WebChat/blob/master/LICENSE)ファイルをご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---