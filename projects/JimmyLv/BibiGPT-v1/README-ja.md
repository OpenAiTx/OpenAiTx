> このリポジトリはv1専用で、BilibilとYouTubeをサポートしています！

# 🤖 BibiGPT: 音声・動画のワンクリックAI要約＆学習コンテンツとのチャット [https://bibigpt.co](https://bibigpt.co)

🎉 AI駆動のビデオサマライザーでYouTubeやBilibiliの動画を簡単に要約できます。ポッドキャスト、Twitter、会議、講義、Tiktok動画などにも対応。ChatGPTとともに、もっとスマートな学習法を発見しましょう。最高のAI学習パートナーです！（旧BiliGPT）「通信量節約の神器＆クラス代表」。

代替アドレス：https://b.jimmylv.cn
ブラウザ拡張機能：https://bibigpt.co/extension

---

## 🤖 BibiGPT · AI 音声・動画コンテンツのワンクリック要約＆対話 [https://bibigpt.co](https://bibigpt.co)

🎉 ChatGPT AIによる音声・動画のワンクリック要約で、Bilibili丨YouTube丨ローカル動画丨ローカル音声丨ポッドキャスト丨小紅書丨抖音丨会議丨講義丨ウェブなどあらゆるコンテンツを手軽に学習可能。BibiGPTは最良のAI学習アシスタントを目指し、無料トライアルを提供！(旧BiliGPT 通信節約神器＆AIクラス代表)（iOSショートカット＆微信サービス号対応）。

予備アドレス：https://b.jimmylv.cn
ブラウザプラグイン: https://bibigpt.co/extension

---

🎬 本プロジェクトは、YouTube/Bilibili/Twitter/TikTok/Podcast/講義/会議などの動画や音声をAIで要約します。

🤯 [Nutlope/news-summarizer](https://github.com/Nutlope/news-summarizer) & [zhengbangbo/chat-simplifier](https://github.com/zhengbangbo/chat-simplifier/) & [lxfater/BilibiliSummary](https://github.com/lxfater/BilibiliSummary) にインスパイアされています。

[![BibiGPT音声・動画要約神器](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/BibiGPT.gif)](https://twitter.com/Jimmy_JingLv/status/1630137750572728320?s=20)

🚀 初公開: [【BibiGPT】AIが自動でB站動画内容を要約、GPT-3で字幕をスマート抽出](https://www.bilibili.com/video/BV1fX4y1Q7Ux/?vd_source=dd5a650b0ad84edd0d54bb18196ecb86)

## 仕組み

本プロジェクトは[OpenAI ChatGPT API](https://openai.com/api/)（特にgpt-3.5-turbo）と[Vercel Edge functions](https://vercel.com/features/edge-functions)のストリーミング、[Upstash](https://console.upstash.com/)のRedisキャッシュとレート制限を利用しています。Bilibili動画のコンテンツを取得し、プロンプトとしてGPT-3 APIに送信、Vercel Edge関数で要約し、その応答をアプリにストリーム返却します。

## コスト節約

この種のプロジェクトはコストがかかるため、自分のバージョンを作成し公開したい場合は、以下の3点を推奨します：

- [x] 1. レート制限を実装し、サイトの悪用を防ぐ
- [x] 2. 高額なAI再生成を避けるためキャッシュを実装する
- [x] 3. `summarize`エッジ関数で`text-dacinci-003`の代わりに`text-curie-001`を使用する

## ローカルでの実行

リポジトリをクローンした後、[OpenAI](https://beta.openai.com/account/api-keys)でアカウントを作成し、APIキーを `.env` というファイルに記入してください。

その後、コマンドラインでアプリケーションを実行すると、`http://localhost:3000` で利用可能になります。

[具体的な実行手順はこのドキュメントに記載されています - 中国語版](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./deploy-ch.md)

```bash
npm run dev
```

## デプロイ

[Vercel](https://vercel.com?utm_source=github&utm_medium=readme&utm_campaign=vercel-examples) を使用して例をデプロイします

`./example.env` ファイルに従って環境変数を設定してください。

## Dockerサポート

https://github.com/JimmyLv/BibiGPT/pull/133

```shell
# make sure setup .env file firstly
docker compose up -d
```

## Support -> Contact Me

![](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/wechat.jpg)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=JimmyLv/BibiGPT&type=Date)](https://star-history.com/#JimmyLv/BibiGPT&Date)

## Contributors

This project exists thanks to all the people who contribute.

 <a href="https://github.com/JimmyLv/BibiGPT/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=JimmyLv/BibiGPT" />
 </a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---