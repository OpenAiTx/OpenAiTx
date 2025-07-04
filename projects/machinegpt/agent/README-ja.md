![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

高速かつ自律的なPython AIエージェントフレームワークであり、OpenAI Python SDKを活用して自然言語コマンドを解釈し、動的にコードを生成・実行し、実行環境をシームレスに管理します。自動依存関係インストール、安全な環境構成、構造化ログ記録、強力なPythonツールを埋め込むためのミニマルなプラグインインターフェースを備えており、すべてパーミッシブなApache 2.0ライセンスのもとで提供されます。

## ⭐ Star History

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 環境セットアップ

### Python仮想環境
プロジェクトをセットアップする前に、仮想環境を作成することを推奨します。以下の手順に従ってください。

仮想環境について学ぶ: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

仮想環境を作成して有効化します:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### プロジェクトセットアップ
本プロジェクトを動作させるにはOpenAI APIキーが必要です。ルートディレクトリに以下の内容で.envファイルを作成してください。
```
OPENAI_API_KEY=
```
または、用意されている.env.exampleファイルをコピーしてキーを更新することもできます。
```
cp .env.example .env
```

## 🧠 起動
エージェントを起動するには、以下を実行してください。
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ コントリビューション

貢献、提案、バグ報告、修正を歓迎します！

新しい機能、コンポーネント、拡張の追加を検討している場合は、PRを送る前にIssueを立ててご相談ください。

## 💖 このプロジェクトは貢献してくださる皆さまのおかげで成り立っています
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---