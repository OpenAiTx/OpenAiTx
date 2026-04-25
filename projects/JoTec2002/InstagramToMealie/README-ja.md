# InstagramToMealie

InstagramのURLをMealieにインポートするシンプルなコンバーター

<p align="center">
    <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="center" width="30%">
</p>
<p align="center"><h1 align="center">INSTAGRAM TO MEALIE</h1></p>

<p align="center">
	<img src="https://img.shields.io/github/license/JoTec2002/InstagramToMealie?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/JoTec2002/InstagramToMealie?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-language-count">
</p>
<br>

## 目次

- [概要](#overview)
- [はじめに](#getting-started)
    - [前提条件](#prerequisites)
    - [インストール](#installation)
    - [使い方](#usage)
    - [設定](#configuration)
- [貢献](#contributing)
- [ライセンス](#license)
- [謝辞](#acknowledgments)

---

## 概要

InstagramToMealieを使えば、Instagramの投稿URLを簡単に入力できます。  
このプロジェクトはMealieのAPIとシームレスに統合され、関連する画像または動画を含む新しいレシピを作成します。

---

## はじめに

### 必要条件

1. Mealieのインスタンスで`/admin/debug/openai`にアクセスし、OpenAI / Ollamaが設定されていることを確認してください。このプロジェクトはOpenAI / Ollamaと直接統合されていませんが、Mealieで設定されている必要があります。個人的にはOllamaモデルとして`qwen2.5:7b`が最良の結果を得られました。
2. MealieのAPIキーを生成します（`/user/profile/api-tokens`）。[Mealieドキュメント](https://docs.mealie.io/documentation/getting-started/api-usage/)
3. Instagramセッションファイルを生成します（これが最も難しいステップです）。このリポジトリには[ヘルパースクリプト](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)が提供されています！これは[Instaloaderドキュメント](https://instaloader.github.io/troubleshooting.html)からそのままコピーしたものです。
    1. スクリプトをダウンロードします：[https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)
    2. FirefoxでInstagramにログインします
    3. スニペットを実行します：`python ./instaloader_login_helper.py`
    4. スクリプトによって生成されたファイルを既知の場所にコピーします。このファイルは後でDockerコンテナにマウントされます。別のシステムで生成してからターゲットシステムにコピーしても構いません。

### インストール

以下の方法のいずれかでInstagramToMealieをインストールしてください：

**ソースからビルド：**
<details closed>

1. InstagramToMealieリポジトリをクローンします：


```sh
❯ git clone https://github.com/JoTec2002/InstagramToMealie
```

2. プロジェクトディレクトリに移動します:

```sh
❯ cd InstagramToMealie
```

3. プロジェクトの依存関係をインストールします：

```sh
❯ pip install -r requirements.txt
```

4. サーバーを起動します：

```sh
❯ python -u main.py
```

</details>

**[jotec2002/instagramtomealie](https://hub.docker.com/repository/docker/jotec2002/instagramtomealie/general) にある提供されたDockerイメージを使用してください**

Mealieのインストールと共にDocker Composeでデプロイします

セッションファイルを使用して認証する例の `compose.yaml` ファイル:

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
    volumes:
      - ./session-file:/app/session-file        # The Instagram session file you created in the Prerequisites
    depends_on:
      mealie:
        condition: service_healthy
```

ユーザー名とパスワードの環境変数を使用して認証する例の `compose.yaml` ファイル：

> [!IMPORTANT]
> **この方法を機能させるには、アカウントで二要素認証（TFA/TOTP）を無効にする必要があります。**
> この方法を成功させるには、複数回の試行が必要になる可能性があります。Instagramのボット検出に引っかからないように、他のシステムやIPで並行してログインしてください。
> これはInstagramToMealieを設定する推奨方法ではありません。

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      INSTA_PWD: "Cleartext Instagram password"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
      MEALIE_USE_INSTAGRAM_TAGS: true
```

**Dockerイメージを自分でビルドする**

提供されたDockerイメージを使用する場合と同様に設定しますが、`compose.yaml`内で以下のように置き換えてください:

```diff
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
+   build:
+     context: .
+     dockerfile: Dockerfile
+   image: instagramtomealie:latest
    ports:
      - 9001:9001
```

### 使用方法

1. Webブラウザで開く（例: `http://instagramtomealie.my-server.com`）そしてInstagramのURLをテキストフィールドにインポートするだけです
2. 自動化から呼び出す（例: IOSショートカット）URLは `http://instagramtomealie.my-server.com?url=<InstagramURL>`
3. インポート結果を返すAPIが必要な場合は、`POST http://instagramtomealie.my-server.com/api` に対してURLをJSON形式のリクエストボディ（推奨、`{"url": "<InstagramURL>"}`）かクエリパラメータとして送信してください（前の箇条書きを参照）。APIは以下の形式のJSONで応答します:
```json
{
  "recipe_slug": <imported recipe slug>,
  "error": <error message if any error>,
  "url": <Instagram URL which was imported>
}
```

### 設定

```env
MEALIE_URL:                          # Full URL of your Mealie instance (e.g http://mealie:9000, http://192.168.1.2:9000, http://my-mealie.com), required.
MEALIE_API_KEY:                      # API key used to authenticate with the Mealie REST API, required.
MEALIE_OPENAI_REQUEST_TIMEOUT: 60    # The timeout in seconds for OpenAI / Ollama requests, optional, default 60.
MEALIE_USE_INSTAGRAM_TAGS: true      # Embeds tags provided on the Instagram post as tags in Mealie, optional, default true.
INSTA_USER:                          # Instagram username (e.g mob_kitchen), required.
INSTA_PWD:                           # Instagram password in plaintext, optional (if using a session file).
INSTA_TOTP_SECRET:                   # Secret key used for 2FA authentication, optional, not recommended.
HTTP_PORT:                           # Port to use for the Flask HTTP server, optional, default 9001
```

---

## 貢献について

- **💬 [ディスカッションに参加する](https://github.com/JoTec2002/InstagramToMealie/discussions)**: ご意見を共有したり、  
  フィードバックを提供したり、質問をしてください。  
- **🐛 [問題を報告する](https://github.com/JoTec2002/InstagramToMealie/issues)**: バグの報告や機能要望を  
  `InstagramToMealie` プロジェクトに提出してください。  
- **💡 [プルリクエストを提出する](https://github.com/JoTec2002/InstagramToMealie/blob/main/CONTRIBUTING.md)**:  
  オープンなPRをレビューし、ご自身のPRを提出してください。  

<details closed>  
<summary>コントリビューターグラフ</summary>  
<br>  
<p align="left">  
   <a href="https://github.com{/JoTec2002/InstagramToMealie/}graphs/contributors">  
      <img src="https://contrib.rocks/image?repo=JoTec2002/InstagramToMealie">  
   </a>  
</p>  
</details>  

---

## ライセンス

このプロジェクトはMITライセンスの下で保護されています。詳細は、  
[LICENSE](https://choosealicense.com/licenses/) ファイルを参照してください。  

---

## 謝辞

- [Mealie](https://github.com/mealie-recipes/mealie/)  
- [Instadownloader](https://github.com/instaloader/instaloader)  

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-25

---