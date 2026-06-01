<br />
<br />
<p align="center">
  <a href="https://github.com/mixxorz/DSLR">
    <img width="281" height="84" src="https://user-images.githubusercontent.com/3102758/181914025-44bff27e-aac1-4d1b-a037-9fa98f9fed65.png" alt="The DSLR logo">
  </a>
</p>
<br />

<p align="center">
  <a href=""><img src="" alt=""></a>
  <a href="https://badge.fury.io/py/dslr"><img src="https://badge.fury.io/py/dslr.svg" alt="PyPI version"></a>
  <a href="https://pypi.python.org/pypi/dslr/"><img src="https://img.shields.io/pypi/pyversions/dslr.svg" alt="PyPI Supported Python Versions"></a>
  <a href="https://github.com/mixxorz/dslr"><img src="https://github.com/mixxorz/dslr/actions/workflows/tests.yml/badge.svg" alt="GitHub Actions (Code quality and tests)"></a>

</p>

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/190845105-dd2ec4e6-286b-431d-a33d-490805852b68.png" alt="A terminal showing DSLR's command line interface.">
</p>

---

データベースのスナップショット、一覧表示、および復元

ローカルのPostgresデータベースのスナップショットを超高速で取得します。

## これは何ですか？

DSLRは、データベースのマイグレーション作業中、ブランチを切り替えるとき、またはSQLを操作するときに、
素早くデータベースのスナップショットを取得および復元できるツールです。

これは[Stellar](https://github.com/fastmonkeys/stellar)の精神的な後継ツールを目指しています。

**重要：** DSLRは開発用途専用です。 本番環境のデータベースでの使用は推奨されません。

## パフォーマンス




DSLRは、標準の`pg_dump`/`pg_restore`を使ったスナップショット方式よりもはるかに高速です。

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/182014327-1b13da6e-63ad-4bbe-817e-7d6c66befc98.png" alt="DSLRとpg_dump/pg_restoreの実行時間比較チャート。スナップショットとリストアで、DSLRはそれぞれ4.125秒と4.431秒、pg_dump/pg_restoreはそれぞれ36.602秒と13.257秒かかっています。">
</p>

DSLRは、スナップショット作成時に8倍、スナップショット復元時に3倍速く、`pg_dump`/`pg_restore`方式より優れています。

<details>
  <summary>テスト手法</summary>
  
  Dockerを使ってPostgres 12.3を起動し、テスト用データベースを作成、以下のスクリプトで1GBのランダムデータを投入しました：
  
  ```SQL
  CREATE TABLE large_test (num1 bigint, num2 double precision, num3 double precision);

INSERT INTO large*test (num1, num2, num3)
SELECT round(random() * 10), random(), random() \_ 142
FROM generate_series(1, 20000000) s(i);

```
以下のコマンドを使用して実行時間を測定しました：


```

time dslr snapshot my-snapshot
time dslr restore my-snapshot
time pg_dump -Fc -f export.dump
time pg_restore --no-acl --no-owner export.dump

```
各コマンドを3回実行し、平均値をグラフにプロットしました。

以下は生データです：

| コマンド       | 実行回数 | 実行時間（秒）           |
| ------------- | ------- | ------------------------ |
| dslr snapshot | 1       | 4.797                    |
|               | 2       | 4.650                    |
|               | 3       | 2.927                    |
| dslr restore  | 1       | 5.840                    |
|               | 2       | 4.122                    |
|               | 3       | 3.331                    |
| pg_dump       | 1       | 37.345                   |
|               | 2       | 36.227                   |
|               | 3       | 36.233                   |
| pg_restore    | 1       | 13.304                   |
|               | 2       | 13.148                   |
|               | 3       | 13.320                   |
</details>

## インストール


```

pip install DSLR psycopg2 # or psycopg2-binary, or psycopg

```

**pipxを使用してインストール**

```

pipx install DSLR[psycopg2] # or psycopg2-binary, or psycopg

````

**uvを使用してインストール**

```

uv tool install 'DSLR[psycopg2]' # or psycopg2-binary, or psycopg

```

注意: DSLRの`export`および`import`スナップショットコマンドは`pg_dump`と
`pg_restore`が`PATH`に存在する必要があるため、これらのコマンドを使用するには
PostgresのCLIユーティリティが必要です。

<details>
  <summary><strong>シェル補完</strong></summary>

**Bash**

これを`~/.bashrc`に追加してください:

```
eval "$(_DSLR_COMPLETE=bash_source dslr)"
```

**Zsh**

Add this to `~/.zshrc`:

```
eval "$(_DSLR_COMPLETE=zsh_source dslr)"
```

**Fish**

これを `~/.config/fish/completions/dslr.fish` に追加してください:

```
eval (env _DSLR_COMPLETE=fish_source dslr)
```

これは下記のアクティベーションスクリプト方式で使用されるのと同じファイルです。Fishでは、おそらく常にその方法を使う方が簡単です。

evalを使用すると、シェルが起動するたびにコマンドが呼び出され評価されるため、シェルの応答速度が遅くなることがあります。速度を上げるには、生成されたスクリプトをファイルに書き込み、それをソースしてください。

**Bash**

スクリプトをどこかに保存します。

```
_DSLR_COMPLETE=bash_source dslr > ~/.dslr-complete.bash
```

~/.bashrc ファイルをソースしてください。

```
. ~/.dslr-complete.bash
```

**Zsh**

Save the script somewhere.

```
_DSLR_COMPLETE=zsh_source dslr > ~/.dslr-complete.zsh
```

~/.zshrc ファイルをソースします。

```
. ~/.dslr-complete.zsh
```

**Fish**

スクリプトを ~/.config/fish/completions/foo-bar.fish に保存してください：

```
_DSLR_COMPLETE=fish_source dslr > ~/.config/fish/completions/dslr.fish
```

</details>



## 設定

DSLRにどのデータベースのスナップショットを取得するかを指定する方法はいくつかあります：

**DATABASE_URL**

`DATABASE_URL` 環境変数が設定されている場合、DSLRはこれを使って
対象のデータベースに接続します。

```bash
export DATABASE_URL=postgres://username:password@host:port/database_name
````

**dslr.toml**

現在のディレクトリに `dslr.toml` ファイルが存在する場合、DSLR はその設定をそこから読み込みます。DSLR は環境変数よりもこちらを優先します。


```toml
url = 'postgres://username:password@host:port/database_name'
```

**`--url` オプション**

最後に、`--url` オプションを使って接続文字列を明示的に渡すことができます。
これにより、上記の設定はすべて上書きされます。

## 使用法

```
$ dslr snapshot my-first-snapshot
Created new snapshot my-first-snapshot

$ dslr restore my-first-snapshot
Restored database from snapshot my-first-snapshot

$ dslr list

  Name                Created            Size
 ─────────────────────────────────────────────
  my-first-snapshot   2 minutes ago   3253 kB

$ dslr rename my-first-snapshot fresh-db
Renamed snapshot my-first-snapshot to fresh-db

$ dslr delete some-old-snapshot
Deleted some-old-snapshot

$ dslr export my-feature-test
Exported snapshot my-feature-test to my-feature-test_20220730-075650.dump

$ dslr import snapshot-from-a-friend_20220730-080632.dump friend-snapshot
Imported snapshot friend-snapshot from snapshot-from-a-friend_20220730-080632.dump
```

非対話型シェルで既存のスナップショットを強制的に上書きするには、フラグ `-y` を使用します:

```
$ dslr snapshot my-first-snapshot -y
Updated snapshot my-first-snapshot
```
## 仕組みは？

DSLRはPostgresの[テンプレートデータベース](https://www.postgresql.org/docs/current/manage-ag-templatedbs.html)機能を使ってデータベースをクローンすることでスナップショットを取得します。これがDSLRの高速性の主な要因です。

つまり、スナップショットの取得はメインデータベースをテンプレートとして新しいデータベースを作成するだけです。スナップショットの復元はメインデータベースを削除し、スナップショットデータベースをテンプレートとして新しいデータベースを作成するだけです。これを繰り返します。

## コントリビューター

[![Contributors](https://contrib.rocks/image?repo=mixxorz/DSLR)](https://github.com/mixxorz/DSLR/graphs/contributors)

## ライセンス

MIT








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---