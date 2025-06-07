![Banner image](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - 技術チームのためのセキュアなワークフロー自動化

n8nは、技術チームにコードの柔軟性とノーコードのスピードを提供するワークフロー自動化プラットフォームです。400以上の統合、ネイティブなAI機能、公正なコードライセンスにより、データやデプロイメントを完全にコントロールしながら強力な自動化を構築できます。

![n8n.io - Screenshot](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## 主な機能

- **必要なときにコードを書ける**: JavaScript/Pythonの記述、npmパッケージの追加、またはビジュアルインターフェースの利用が可能
- **AIネイティブプラットフォーム**: 独自データやモデルを用いたLangChainベースのAIエージェントワークフローの構築
- **完全なコントロール**: 公正なコードライセンスでセルフホスト、または[クラウドサービス](https://app.n8n.cloud/login)の利用
- **エンタープライズ対応**: 高度な権限管理、SSO、エアギャップ環境での導入
- **活発なコミュニティ**: 400以上の統合と900以上の即利用可能な[テンプレート](https://n8n.io/workflows)

## クイックスタート

[npx](https://docs.n8n.io/hosting/installation/npm/)（[Node.js](https://nodejs.org/en/)が必要）ですぐにn8nをお試しください:

```
npx n8n
```

または、[Docker](https://docs.n8n.io/hosting/installation/docker/)でデプロイ:

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

エディタへは http://localhost:5678 からアクセスできます。

## リソース

- 📚 [ドキュメント](https://docs.n8n.io)
- 🔧 [400以上の統合](https://n8n.io/integrations)
- 💡 [ワークフロー例](https://n8n.io/workflows)
- 🤖 [AI & LangChainガイド](https://docs.n8n.io/langchain/)
- 👥 [コミュニティフォーラム](https://community.n8n.io)
- 📖 [コミュニティチュートリアル](https://community.n8n.io/c/tutorials/28)

## サポート

お困りですか？サポートや他のユーザーとの交流はコミュニティフォーラムをご利用ください:
[community.n8n.io](https://community.n8n.io)

## ライセンス

n8nは[公正なコード（fair-code）](https://faircode.io)のもと、[Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md)および[n8n Enterprise License](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md)で配布されています。

- **ソースコード常時公開**: いつでもソースコードを閲覧可能
- **セルフホスト可能**: どこにでもデプロイ可能
- **拡張性**: 独自ノードや機能を追加可能

追加機能やサポートが必要な場合は[エンタープライズライセンス](mailto:license@n8n.io)をご利用いただけます。

ライセンスモデルの詳細は[ドキュメント](https://docs.n8n.io/reference/license/)をご覧ください。

## コントリビューション

バグ🐛の発見や新機能✨のアイデアはありませんか？[コントリビューションガイド](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md)をチェックしてご参加ください。

## チームに参加しませんか

自動化の未来を共に作りませんか？[求人情報](https://n8n.io/careers)をご覧の上、ぜひご応募ください！

## n8nとはどういう意味ですか？

**短い答え:** 「nodemation」の意味で、「エヌ・エイト・エヌ」と発音します。

**長い答え:** 「この質問はかなり頻繁に（予想以上に）いただくので、ここで答えておくことにしました。プロジェクトに良い名前とフリードメインを探していたとき、思いつく良い名前はすでに取得されていることにすぐ気づきました。結局、nodemationに決めました。『node-』はNode-Viewを使い、Node.jsを利用しているという意味で、『-mation』は『automation』、つまりこのプロジェクトが支援する自動化を表しています。ただ、名前が長すぎるのが気になり、CLIで毎回これだけ長い名前を入力するのは現実的ではありませんでした。そこで最終的に『n8n』に落ち着きました。」 - **Jan Oberhauser, Founder and CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---