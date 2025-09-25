# Terminara

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)

ターミナルベースのAIシミュレーションゲーム。

## 使い方

[最新リリース](https://github.com/luyiourwong/Terminara/releases/latest)から実行可能ファイルをダウンロードできます。

完全な圧縮ファイルには実行可能ファイルとデフォルトのワールド設定ファイルが含まれています。ゲームを最新バージョンに更新する場合は、実行可能ファイルのみをダウンロードできます。

| OS      | バージョン                                         |
|---------|--------------------------------------------------|
| Windows | Windows 10、Windows 11                            |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS、Ubuntu 24.04 LTS |
| MacOS   | macOS 13、macOS 14、macOS 15、macOS 26             |

<details>
<summary><strong>手動実行</strong></summary>

### インストール

1.  **リポジトリをクローンする：**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **仮想環境を作成する：**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Windowsでは、`.venv\Scripts\activate`を使用します

3.  **依存関係をインストールします：**
    ```bash
    pip install -e .
    ```

### 方法1の開始：インストール済みコマンドを使用（推奨）
インストール後、以下のコマンドでゲームを起動します：
```bash
terminara
```

### 方法2の開始：直接実行
クロスプラットフォームの方法
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Windowsでは、`terminara\main.py` を使用してください。

詳細については、[Contribute & Develop Guide](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md) を参照してください。
</details>

## AI セットアップ

アプリケーションを起動した後、メインメニューからAI設定を行う必要があります。

![AI 設定](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

以下の項目を入力してください：（OpenAI互換API）
- **Host**：APIエンドポイント。空欄にするとデフォルトのOpenAIエンドポイントが使用されます。
- **API Key**：AIサービス用のAPIキー。
- **Model**：使用したいモデル。

「Apply」をクリックして設定を保存します。

### 例

#### 1. [OpenAI](https://platform.openai.com/)（デフォルト）
- **Host**：（空欄のまま）
- **API Key**：`YOUR_OPENAI_API_KEY`
- **Model**：`gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**：`https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**：`YOUR_GEMINI_API_KEY`
- **Model**：`gemini-2.0-flash`

## ワールドセットアップ

### 設定保存場所
ワールド設定は `terminara/data/worlds` ディレクトリに保存されます。（正式リリース版にて）
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### 新しいワールドの作成
例として[aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json)というワールドがあります。[スキーマ](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json)に従って新しいワールドを作成できます。

## リンク

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub リポジトリ](https://github.com/luyiourwong/Terminara)
- [貢献と開発ガイド](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## ライセンス

本プロジェクトは[MIT ライセンス](LICENSE)の下でライセンスされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---