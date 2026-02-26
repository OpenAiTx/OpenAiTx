# ポケットモンスター 赤 (RL エディション)

![テスト](https://github.com/thatguy11325/pokemonred_puffer/actions/workflows/workflow.yml/badge.svg)

このリポジトリは、ポケットモンスター赤のRL開発用のライブラリとして設計されています。ライブラリ環境で使用すべきでない便利関数が含まれており、フォークして使用することが推奨されます。将来的には、これらの便利関数は移行され、フォーク不要になる予定です。

## クイックスタート

### インストール

ライブラリをインストールするには、以下のいずれかの方法があります。

1. リポジトリをローカルマシンにクローンしてインストールする。
2. リポジトリをフォークし、フォークをローカルマシンにクローンする。

例えば、

```sh
pip3 install -e . 
```

### 実行

以下は、場合によってはデフォルト引数を使用するコマンドです。リポジトリに関連するコマンドライン操作の使い方がわからない場合は、`python3 -m pokemonred_puffer.train --help`を実行してください。いくつかのコマンドは最近テストされていない可能性があるため、問題があればぜひIssueを作成してください。

インストール後は、次のコマンドでトレーニングを開始できます：

```sh
# Run before training to test what num_envs value you should use
python3 -m pokemonred_puffer.train autotune
# Default
python3 -m pokemonred_puffer.train train
```

### マルチノードハイパーパラメータスイープ（進行中）

ハイパーパラメータスイープを実行したい場合は、関連パッケージをインストールし、2つのコマンドを起動してください：

```sh
pip3 install -e '.[sweep]'
python3 -m pokemonred_puffer.sweep launch-sweep
python3 -m pokemonred_puffer.sweep launch-agent <sweep-id>
```

スイープIDはスイープを開始するときに表示されます。スイープを再開するには、スイープを再度起動して次のようにします。

```sh
python3 -m pokemonred_puffer.sweep launch-sweep --sweep-id <sweep-id>
```
スイープはスイープ設定（デフォルトは `sweep-config.yaml`）とベース設定（デフォルトは `config.yaml`）で構成できます。ハイパーパラメータスイープはスイープ設定を使って範囲を設定し、ベース設定のパラメータを中心にハイパーパラメータを調整します。ハイパーパラメータアルゴリズムの詳細については、[ImbueのCARBSリポジトリ](https://github.com/imbue-ai/carbs/tree/main)をご覧ください。

注意：現在、シングルノードスイープはサポートされていません。もしこれが必要な機能であれば、Issueを作成してください。

### トレーニング用の修正

実行中のランがあるが、それをいじりたい場合はどうしますか？

いくつかの選択肢があります：

1. `config.yaml`のパラメータを変更し始める
2. コードを直接修正し始める（詳細は後述）
3. このリポジトリをライブラリとして使用し、自分のラッパーを作成する

### デバッグ
変更をテストしたい場合は、次のように実行できます


```sh
python3 -m pokemonred_puffer.train --config config.yaml --debug
```
緊急の場合は、`environment.py` の `send_input` 関数呼び出しを削除することをお勧めします。これにより、モデルのスケジュールではなく、自分のスケジュールで報酬をテストできます。

## ディレクトリ構成

このリポジトリは最終的にライブラリとして使用されることを想定しています。すべてのソースファイルは `pokemonred_puffer` ディレクトリの下に配置してください。`__main__` を持つモジュールを追加したい場合は自由にどうぞ。ただし、`pokemonred_puffer` ディレクトリの下に置いてください。その後、`python3 -m pokemonred_puffer.<your-module>` でメインを実行できるはずです。

`pokemonred_puffer` ディレクトリ内には以下のファイルとディレクトリがあります：

- `policies`：モデルを実行するための異なるポリシーのディレクトリ。
- `rewards`：`RedGymEnv`（ポケモン赤の gym 環境）オブジェクトの報酬を管理する `gym.Env` クラスのディレクトリ。
- `wrappers`：例えば [Pokemon Red Map Visualizer](https://pwhiddy.github.io/pokerl-map-viz/) へのログ出力などに使えるラッパーのディレクトリ。
- `cleanrl_puffer.py` - 実際のトレーニングロジックを実行する責任を持つ。
- `environment.py` - ポケモン赤 Gym 環境のコアロジック。
- `eval.py` - トレーニング中のログのための可視化生成。
- `kanto_map_dsv.png` - 関東地方の高解像度マップ。
- `train.py` - トレーニング開始用のスクリプト兼エントリポイント。

## 変更の加え方

簡単な変更の場合は、`config.yaml` を直接更新できます。`config.yaml` にはいくつか重要なルールがあります。`wrappers`、`rewards`、および `policies` は、それぞれのラッパー、報酬、ポリシーが必ず `module_name.class_name` をキーにしている必要があります。これらのセクションは複数のタイプの `wrappers`、`rewards`、`policies` を保持できます。一般的なレイアウトは `ラベル : クラスの引数` です。これは、より良い方法が見つかるまでの間の対応です。

### ラッパーの追加

ラッパーを追加するには、`gym.Wrapper` を継承した新しいクラスを `wrappers` ディレクトリに追加します。次に `config.yaml` の `wrappers` セクションを更新します。ラッパーは上から下へ順にベース環境をラップします。ラッパーリストはクラスパスでキー付けされているわけではありません。ラッパーの集合を区別するユニークな名前です。

### 報酬の追加

報酬を追加するには、新しいクラスを `rewards` ディレクトリに追加します。次に `config.yaml` の `rewards` セクションを更新します。報酬セクションはクラスパスでキー付けされています。

### ポリシーの追加

ポリシーを追加するには、新しいクラスを `policies` ディレクトリに追加します。次に `config.yaml` の `policies` セクションを更新します。ポリシーセクションはクラスパスでキー付けされています。再帰的なポリシーは、それがラップするポリシーと同じモジュールに存在すると想定されています。

## 開発

このリポジトリはフォーマットとリンティングを強制するために [pre-commit](https://pre-commit.com/) を使用しています。開発のために、このリポジトリを以下のようにインストールしてください：


```sh
pip3 install -e '.[dev]'
pre-commit install
```

変更がある場合は、プルリクエストを提出してください。

## 著者

[David Rubinstein](https://github.com/drubinstein), [Keelan Donovan](https://github.com/leanke), [Daniel Addis](https://github.com/xinpw8), Kyoung Whan Choe, [Joseph Suarez](https://puffer.ai/), [Peter Whidden](https://peterwhidden.webflow.io/)

<a href="https://star-history.com/#drubinstein/pokemonred_puffer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
 </picture>
</a>

[![](https://raw.githubusercontent.com/drubinstein/pokemonred_puffer/main/assets/puffer.png)](https://puffer.ai)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-26

---