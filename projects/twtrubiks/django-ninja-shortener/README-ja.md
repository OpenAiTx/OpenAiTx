# Django Ninja Shortener - Bitly風 短縮URLサービス

Django、Django Ninja、Tailwind CSSで構築されたモダンな短縮URLサービス。設計インスピレーションはBitlyから。

ユーザーは登録・ログイン後にURLを短縮でき、各短縮URLのクリック数を追跡可能。

本プロジェクトは [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) を活用して構築されました。詳細は [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md) を参照してください。

## 画面スクリーンショット

短縮URLページ（未登録でも利用可能）

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

登録済みの場合はクリック追跡が可能

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ 主な機能

* **ユーザー認証**：ユーザーの新規登録、ログイン、ログアウトに対応。
* **短縮URLの作成**：ログインユーザーはロングURLからユニークな短縮URLを生成可能。
* **短縮URLリダイレクト**：短縮URLクリック時、元のロングURLへリダイレクト。
* **クリック数追跡**：各短縮URLのクリック数を自動カウント。
* **個人ダッシュボード**：ユーザーは自分が作成した全短縮URLとその統計情報を確認可能。
* **RESTful API**：短縮URLをプログラム的に作成できるAPIエンドポイントを提供。
* **Docker対応**：DockerfileとDocker Compose設定を同梱し、開発・デプロイを簡素化。

## 🛠️ 技術スタック

* **バックエンドフレームワーク**：[Django](https://github.com/twtrubiks/django-tutorial)
* **APIフレームワーク**：[Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **フロントエンドスタイル**：[Tailwind CSS](https://tailwindcss.com/)（`django-tailwind`経由で統合）
* **データベース**：
  * 開発環境：SQLite（デフォルト）
  * 本番環境：PostgreSQLへの切替も容易（`settings.py`で設定済み）
* **短縮URLコード**：`shortuuid`で生成
* **テスト**：[Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **コンテナ化**：[Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 クイックスタート（Docker利用、推奨）

この方法が最もおすすめです。開発環境の一貫性を確保できます。

**手順：**

1. **サービスの起動：**

    Docker Composeで全サービスを一括起動。

    ```bash
    docker compose up --build
    ```

    このコマンドでDockerイメージ作成、依存関係インストール、DBマイグレーション、開発サーバ起動まで全て自動化されます。

2. **スーパーユーザー作成（任意）：**

    Django Adminにアクセスしたい場合は、別ターミナルで以下を実行：

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **アプリケーションへのアクセス：**

    * **Webサイトトップ**：[http://localhost:8000](http://localhost:8000)

    * **APIドキュメント（Swagger UI）**：[http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 ローカル開発（Docker未使用）

ローカル環境で直接セットアップしたい場合はこちら。

**前提条件：**

* Python 3.12
* Node.jsとnpm（Tailwind CSS用）

**セットアップ手順：**

1. **仮想環境の作成・有効化：**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Windowsの場合は `venv\Scripts\activate`
    ```

2. **Python依存パッケージのインストール：**

    ```bash
    pip install -r requirements.txt
    ```

3. **Tailwind CSSのインストール・設定：**

    `django-tailwind`がセットアップの大半を自動化します。

    ```bash
    python manage.py tailwind install
    ```

    参考：[https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **データベースマイグレーション：**

    ```bash
    python manage.py migrate
    ```

5. **スーパーユーザー作成（任意）：**

    ```bash
    python manage.py createsuperuser
    ```

6. **開発サーバの起動：**

    DjangoサーバーとTailwind CSSのビルドプロセスを両方起動する必要があります。

    ```bash
    python manage.py runserver
    ```

    別ターミナルで：

    ```bash
    python manage.py tailwind start
    ```

7. **アプリケーションへのアクセス：**

    * **Webサイトトップ**：[http://localhost:8000](http://localhost:8000)

    * **APIドキュメント（Swagger UI）**：[http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 テストの実行

本プロジェクトは `pytest` を使用し、カバレッジ計測も行います。

テスト計画については [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md) を参照してください。

* **Dockerでテスト実行：**

    ```bash
    docker compose --profile test up
    ```

    テストレポートは `htmlcov/index.html` に生成されます。

* **ローカルでテスト実行：**

    ```bash
    # 開発用依存パッケージがインストールされていることを確認
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 APIエンドポイント

APIは短縮URLサービスとプログラム的に連携する手段を提供します。全APIエンドポイントは `/api/` 配下です。

**APIドキュメント（Swagger UI）** での操作推奨：[http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

[Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt) を利用し、まず `/api/token/pair` にユーザー名とパスワードを送信してトークンを取得します。

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

取得したトークンを右上に貼り付けて、APIを呼び出します。

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 プロジェクト構成

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Djangoプロジェクト設定
│   ├── settings.py
│   └── urls.py
├── shortener/            # コア短縮URLアプリ
│   ├── models.py         # データベースモデル（Link）
│   ├── api.py            # Django Ninja APIエンドポイント
│   ├── views.py          # ページビューとリダイレクトロジック
│   └── utils.py          # 短縮コード生成ユーティリティ
└── theme/                # Djangoテーマとテンプレート
    ├── templates/        # HTMLテンプレート
    └── static_src/       # Tailwind CSSソース
```

## 💡 今後の展望

* **PostgreSQLへの切替**：本番環境向けにより堅牢なデータベースを導入済み。
* **詳細な分析ダッシュボード**：クリック日時・リファラ・地理情報などのデータ分析を提供予定。
* **カスタム短縮URL**：ユーザーが短縮URLのコードをカスタマイズできるようにします。
* **QRコード生成**：各短縮URLに対応するQRコードを生成します。
* **非同期タスク**：Celeryを使用してデータ分析などの時間のかかるタスクを処理します。

## 寄付

この記事はすべて自分で研究し、消化した上で執筆したオリジナル内容です。もしお役に立てた場合や応援していただける場合は、コーヒー1杯ご馳走していただけると嬉しいです :laughing:

ECPAY（会員登録不要）

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[寄付者お支払い](http://bit.ly/2F7Jrha)

O’Pay（会員登録必要）

![alt tag](https://i.imgur.com/LRct9xa.png)

[寄付者お支払い](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## 寄付者リスト

[寄付者リスト](https://github.com/twtrubiks/Thank-you-for-donate)

## ライセンス

MITライセンス

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---