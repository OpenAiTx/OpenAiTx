# こんにちは、私はWxBotClientです <img width="30px" src="https://media.tenor.com/images/3b388fe03da271d2674faf85eb7c3fcd/tenor.gif" />
私はオープンソースのWeChat管理ソフトウェアで、electron、wechaty、vueをベースに開発されており、現在ChatGPTが統合されています。ビルドされたインストーラーはすぐに使え、複雑な環境に依存せず、管理プログラムは安定しており、勝手に切断されることはありません。

<img align="right" height="200" src="https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./src/assets/icons/icon.png" />

---
## セットアップ方法
### ダウンロード＆インストール
[リリースパッケージダウンロード先](https://github.com/WhiteWatson/wx-bot-client/releases) から、すでにビルド済みの **.exeインストーラー（Windows）** をダウンロードできます。ダウンロード中にソフトがファイルの安全性を警告することがありますが、この警告は無視して問題ありません。ダウンロード完了後、ローカルでインストールしてください。

### あなたのWeChatを管理する
ソフトを開き、**さあ始めましょう** ボタンをクリックし、表示されるウィンドウにあなたのopenAI APIKeyを入力してください。

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/one.png)

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/apikeyinput.png)

入力後、**今すぐロボットを起動**をクリックし、QRコードが表示されるのを待ちます。QRコードが表示されたら、WeChatでスキャンしてログインし、管理を開始します。

ヒント：国内で利用する場合はVPNを使用してください。さもないとAPIが通らず、AIがずっと思考状態のままになります。

### ロボット基本設定
ログイン成功後、ロボット管理ダッシュボードに入り、左側の**GPT設定**メニューをクリックすると、基本的なロボット設定が表示されます。

**AIトリガーワード**でロボットの起動ワードを変更できます。

**AIグループチャット、AIプライベートチャット**では、ロボットがサービスを提供するグループチャットやWeChatユーザーを指定できます。

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/gptsetting.png)

---
## 機能概要
### AIテキストチャット機能

```
提问格式： @AI + 问题内容

例：@AI 你是谁？
```
### AI生成画像能力

```
提问格式： /image + 图片提示词

例：/image 一个骑马的人
```
tips: AIは違法画像を生成しやすいため、ロボットは直接画像リンクを送信し、リンクには有効期限があります

---

## カスタムデプロイ
本プロジェクトのローカル実行にはnode環境が必要です

### 依存関係のインストール

ここでは必ずyarnまたはpnpmで依存関係をインストールしてください
```
yarn install
```

### ChatGPTに接続し、ローカルでプロジェクトを実行する：

```
npm run electron:serve
```

### クライアントインストーラーのパッケージ化:
```
npm run electron:build
```
### プロジェクトでのopenAI APIKeyの設定
`/src/bot/config.ts`ディレクトリに入り、[openAi公式API申請ページ](https://platform.openai.com/account/api-keys)から取得した`Organization`と`APIKey`を`setApiKey`関数に入力します

### 問題が発生した場合は[こちらのドキュメントを先に参照してください](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/problem.md)

---
## 私はコンピューターサイエンスと工学の学生です  

- 👨‍💻 現在、JavaScriptやVueなどのウェブ開発技術に取り組んでいます。
- 💪🏼 将来の目標：より多くの技術を学び、新しいアイデアを創造し続けること。
- ⚡ 面白い事実：原神をプレイするのが大好きです。

### 特別な感謝：leeguiyu@qq.comによるアイコン制作

### 使用言語とツール 🛠 

![JavaScript](https://img.shields.io/badge/-JavaScript-%23F7DF1C?style=flat-square&logo=javascript&logoColor=000000&labelColor=%23F7DF1C&color=%23FFCE5A)
![HTML5](https://img.shields.io/badge/-HTML5-%23E44D27?style=flat-square&logo=html5&logoColor=ffffff)
![CSS3](https://img.shields.io/badge/-CSS3-%231572B6?style=flat-square&logo=css3)
![Sass](https://img.shields.io/badge/-Sass-%23CC6699?style=flat-square&logo=sass&logoColor=ffffff)
![Bootstrap](https://img.shields.io/badge/-Bootstrap-563D7C?style=flat-square&logo=Bootstrap)
![Markdown](https://img.shields.io/badge/-Markdown-000000?style=flat-square&logo=markdown)
![Nodejs](https://img.shields.io/badge/-Nodejs-339933?style=flat-square&logo=Node.js&logoColor=ffffff)
![Npm](https://img.shields.io/badge/-npm-CB3837?style=flat-square&logo=npm)
![Git](https://img.shields.io/badge/-Git-%23F05032?style=flat-square&logo=git&logoColor=%23ffffff)
![GitHub](https://img.shields.io/badge/-GitHub-181717?style=flat-square&logo=github)
![VS Code](http://img.shields.io/badge/-VS%20Code-007ACC?style=flat-square&logo=visual-studio-code&logoColor=ffffff)
![Powershell](http://img.shields.io/badge/-Powershell-5391FE?style=flat-square&logo=powershell&logoColor=ffffff)
![Windows](http://img.shields.io/badge/-Windows-0078D6?style=flat-square&logo=windows&logoColor=ffffff)

<br/>

<br/>

  <h2 align="center"> Github統計 📈 </h2>
  
  <div align="center"> 
     <a href="">
      <img align="center" src="https://github-readme-stats-sigma-five.vercel.app/api?username=WhiteWatson&show_icons=true&include_all_commits=true&count_private=true&theme=react&line_height=40" />
    </a>
    <a href="">
      <img align="center" src="https://github-readme-stats.vercel.app/api/top-langs/?username=WhiteWatson&theme=react&line_height=40&hide=css"/>
    </a>
</div
  
<br/>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-18

---