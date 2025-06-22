<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>すべてのAIボットと同時にチャットし、最適なものを見つけよう</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## スクリーンショット

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## 特徴

大規模言語モデル（LLM）ベースのAIボットは素晴らしいですが、その挙動はランダムで、ボットごとに得意分野が異なります。最高の体験を得たいなら、一つずつ試す必要はありません。ChatALL（中国名：齐叨）は複数のAIボットに同時にプロンプトを送信し、最適な結果を見つける手助けをします。[ダウンロードしてインストール](https://github.com/ai-shifu/ChatALL/releases)し、質問するだけです。

### こんな方におすすめ

ChatALLの主なユーザーは以下の通りです：

- 🤠**LLMの達人**：LLMから最適な回答や創作を探したい方
- 🤓**LLMの研究者**：様々な分野で異なるLLMの強みと弱みを直感的に比較したい方
- 😎**LLMアプリ開発者**：プロンプトを迅速にデバッグし、最もパフォーマンスの高い基礎モデルを見つけたい方

### 対応ボット

| AI ボット                                                                         | Webアクセス | API         | 備考                                         |
| -------------------------------------------------------------------------------- | ----------- | ----------- | ------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                               | あり         | APIなし      |                                             |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                          | なし         | あり         |                                             |
| [Character.AI](https://character.ai/)                                            | あり         | APIなし      |                                             |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                        | あり         | APIなし      | ログイン不要                                 |
| [ChatGPT](https://chatgpt.com)                                               | あり         | あり         | Web閲覧、Azure OpenAIサービス対応            |
| [Claude](https://www.anthropic.com/claude)                                       | あり         | あり         |                                             |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/)   | あり         | APIなし      |                                             |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                   | なし         | あり         |                                             |
| [Cohere Command R Models](https://cohere.com/command)                            | なし         | あり         |                                             |
| [Copilot](https://copilot.microsoft.com/)                                        | あり         | APIなし      |                                             |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                                 | 近日対応     | APIなし      |                                             |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                    | あり         | APIなし      |                                             |
| [Gemini](https://gemini.google.com/)                                             | あり         | あり         |                                             |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)    | あり         | APIなし      |                                             |
| [Gradio](https://gradio.app/)                                                    | あり         | APIなし      | Hugging Faceスペース/自己ホストモデル用      |
| [Groq Cloud](https://console.groq.com/docs/models)                               | なし         | あり         |                                             |
| [HuggingChat](https://huggingface.co/chat/)                                      | あり         | APIなし      |                                             |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                        | あり         | 近日対応     |                                             |
| [Kimi](https://kimi.moonshot.cn/               )                                 | あり         | APIなし      |                                             |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                  | あり         | APIなし      |                                             |
| [MOSS](https://moss.fastnlp.top/)                                                | あり         | APIなし      |                                             |
| [Perplexity](https://www.perplexity.ai/)                                         | あり         | APIなし      |                                             |
| [Phind](https://www.phind.com/)                                                  | あり         | APIなし      |                                             |
| [Pi](https://pi.ai)                                                              | あり         | APIなし      |                                             |
| [Poe](https://poe.com/)                                                          | あり         | 近日対応     |                                             |
| [SkyWork](https://neice.tiangong.cn/)                                            | あり         | 近日対応     |                                             |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                      | あり         | 近日対応     |                                             |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                    | あり         | APIなし      | ログイン不要                                 |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                             | あり         | APIなし      |                                             |
| [xAI Grok](https://x.ai)                                                         | なし         | あり         |                                             |
| [YouChat](https://you.com/)                                                      | あり         | APIなし      |                                             |
| [You](https://you.com/)                                                          | あり         | APIなし      |                                             |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)                | あり         | APIなし      |                                             |

さらに追加予定です。[こちらのIssue](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs)でお気に入りのボットに投票できます。

### Web接続型ボットの信頼性について

「Webアクセス」欄が「あり」のAIボットは、サービスプロバイダーがWebインターフェースやセキュリティを頻繁に更新するため、本質的に信頼性が低く、安定性に欠けます。これらのWeb型接続はリバースエンジニアリングに依存しており、予期せず動作しなくなることが多いです。信頼できる体験を求める場合は、APIアクセスが提供されているボットの利用を強く推奨します。

### その他の機能

- クイックプロンプトモード：前回のリクエスト完了を待たずに次のプロンプトを送信可能
- チャット履歴をローカルに保存、プライバシー保護
- 気に入った回答のハイライト、不適切な回答の削除
- いつでも任意のボットを有効/無効化可能
- 1カラム・2カラム・3カラム表示の切り替え
- 最新バージョンへの自動アップデート
- ダークモード（@tanchekwei氏による貢献）
- ショートカットキー。<kbd>Ctrl</kbd> + <kbd>/</kbd>で一覧表示（@tanchekwei氏による貢献）
- 複数チャット対応（@tanchekwei氏による貢献）
- プロキシ設定（@msaong氏による貢献）
- プロンプト管理（@tanchekwei氏による貢献）
- 多言語対応（中国語・英語・ドイツ語・フランス語・ロシア語・ベトナム語・韓国語・日本語・スペイン語・イタリア語）
- Windows, macOS, Linux対応

今後の予定機能：

これらの機能への貢献も歓迎しています。

- [ ] フロントエンドをGitHub Pagesへデプロイ

## プライバシー

全てのチャット履歴、設定、ログインデータはお使いのPC上にローカル保存されます。

ChatALLは製品改善のため、匿名の利用データを収集します。収集内容は以下の通りです：

- どのAIボットにプロンプトを送ったか、およびプロンプトの長さ（プロンプト内容は含まれません）
- 回答の長さ、どの回答が削除/ハイライトされたか（回答内容は含まれません）

## 必要条件

ChatALLはクライアントであり、プロキシではありません。そのため、以下が必要です：

1. 各ボットの有効なアカウントまたはAPIトークンを保有していること
2. 各ボットへの安定したネットワーク接続があること

## ダウンロード / インストール

https://github.com/ai-shifu/ChatALL/releases からダウンロードしてください

### Windowsの場合

\*-win.exeファイルをダウンロードし、セットアップを進めてください。

### macOSの場合

Apple Silicon Mac（M1, M2 CPU）は\*-mac-arm64.dmgファイルをダウンロードしてください。

その他のMacは\*-mac-x64.dmgファイルをダウンロードしてください。

[Homebrew](https://brew.sh/)をご利用の場合、以下でインストールできます：

```bash
brew install --cask chatall
```

### Linuxの場合

Debian系ディストリビューション：.debファイルをダウンロードし、ダブルクリックでインストールしてください。
Arch系ディストリビューション：AURから[こちら](https://aur.archlinux.org/packages/chatall-bin)をクローンできます。手動またはyayやparu等のAURヘルパーでインストール可能です。
その他のディストリビューション：.AppImageファイルをダウンロードして実行権限を与えると、クリックで実行できます。[AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher)も利用可能です。

## トラブルシューティング

ChatALL使用中に問題が発生した場合、以下の方法で解決をお試しください：

1. **リフレッシュ** - <kbd>Ctrl</kbd> + <kbd>R</kbd> または <kbd>⌘</kbd> + <kbd>R</kbd>を押します。
2. **再起動** - ChatALLを終了し、再度起動してください。
3. **再ログイン** - 右上の設定ボタンをクリックし、各Webサイトのログイン/ログアウトリンクから再ログインしてください。
4. **新規チャット作成** - `New Chat`ボタンをクリックし、再度プロンプトを送信してください。

上記でも解決しない場合は**ChatALLのリセット**をお試しください。これにより全ての設定とメッセージ履歴が削除されます。

ChatALLは以下のディレクトリを削除することでリセットできます：

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

問題が解決しない場合は、[Issueを提出](https://github.com/ai-shifu/ChatALL/issues)してください。

## 開発者向け情報

### ボットの追加

[ガイド](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA)をご参照ください。

### 実行

```bash
npm install
npm run electron:serve
```

### ビルド

現在のプラットフォーム用ビルド：

```bash
npm run electron:build
```

全てのプラットフォーム用ビルド：

```bash
npm run electron:build -- -wml --x64 --arm64
```

## クレジット

### コントリビューター

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### その他

- GPT-4が多くのコードに貢献
- ChatGPT, Copilot, Googleが多くのソリューションを提供（順不同）
- [ChatHub](https://github.com/chathub-dev/chathub)から着想を得ました。リスペクト！

## スポンサー

このプロジェクトが気に入ったら、ぜひご検討ください：

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---