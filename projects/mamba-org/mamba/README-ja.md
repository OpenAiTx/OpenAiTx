# Mamba: 高速クロスプラットフォームパッケージマネージャ

![mamba ヘッダー画像](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">mamba-org の一部</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">パッケージマネージャ <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">パッケージサーバ <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` は、conda パッケージマネージャの C++ による再実装です。

- マルチスレッドによるリポジトリデータおよびパッケージファイルの並列ダウンロード
- Red Hat、Fedora、OpenSUSE の RPM パッケージマネージャで使用されている最先端のライブラリ libsolv による、はるかに高速な依存関係の解決
- `mamba` のコア部分は最大限の効率を実現するため C++ で実装

同時に、`mamba` は可能な限り互換性を保つために、`conda` と同じコマンドラインパーサー、パッケージのインストール・アンインストールコード、トランザクション検証ルーチンを利用しています。

`mamba` は [conda-forge](https://conda-forge.org/) エコシステムの一部であり、これはオープンソースの `conda` パッケージサーバ `quetz` も含まれます。

[アナウンスメントブログ記事](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23)もご覧いただけます。

## micromamba

`micromamba` は、`mamba` のスタティックリンク版です。

スタンドアロンの実行ファイルとして依存関係なしでインストール可能なため、CI/CD パイプラインやコンテナ化環境に最適です。

詳細は [micromamba のドキュメント](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) を参照してください。

## `mamba` と `micromamba` の比較

`mamba` が推奨されるケース：

- 同一環境内で他のソフトウェアが `libmambapy` や `libmamba` を使用する場合
- ライブラリの定期的な更新が必要なシナリオ（特にセキュリティ面）
- 依存関係のディスク容量削減に重点を置く環境

`micromamba` が推奨されるケース：

- 単一の自己完結型実行ファイルへの依存が必要な場合
- miniforge ディストリビューションが存在しない場合
- 実行時の最小化が要求される場合

## インストール

インストール方法については、ドキュメントの [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
および [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) のインストールガイドを参照してください。

## Mamba および Micromamba の追加機能

`mamba` および `micromamba` には、標準の `conda` にはない追加機能があります。

### `repoquery`

リポジトリやパッケージ依存関係を効率的に照会するには、`mamba repoquery` または `micromamba repoquery` を使用できます。

詳細は [repoquery ドキュメント](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) を参照してください。

### ロックファイルのインストール

`micromamba` は、[conda-lock](https://conda.github.io/conda-lock/) で生成されたロックファイルを、`conda-lock` をインストールせずに使用してインストールできます。

エンバイロメントロックファイル（ファイル名が `-lock.yml` または `-lock.yaml` で終わるもの）を `-f` オプションで指定して、`micromamba create` を実行するだけです。例：

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba（setup-miniconda の代替）

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) は、`micromamba` を使用した [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) の代替です。

CI セットアップ時間を大幅に短縮できます：

- `micromamba` の使用により、インストールに約1秒しかかかりません。
- パッケージダウンロードのキャッシュ
- `conda` 環境全体のキャッシュ

## `conda` との違い

`mamba` および `micromamba` は一般的に `conda` のドロップインリプレースメントですが、いくつか違いがあります：

- `mamba` および `micromamba` はリビジョンをサポートしていません（議論は <https://github.com/mamba-org/mamba/issues/803> を参照）
- `mamba` および `micromamba` は `MatchSpec` 文字列を最も単純な形に正規化しますが、`conda` はより冗長な形式を使用します。
  これにより、`conda env export` と `mamba env export` の出力にわずかな違いが生じることがあります。

## 開発用インストール

[公式ドキュメント](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html) の指示に従ってください。

## API および ABI の安定性

Mamba プロジェクトは [セマンティックバージョニング](https://semver.org/)（`MAJOR.MINOR.PATCH` 形式）を採用しています。
ユーザーのために安定性を維持しようと努力していますが、Mamba の改良や技術的負債の削減のために破壊的変更が必要になる場合もあります。
将来のバージョンでは、より強力な保証が提供される可能性があります。

### `libmamba`（C++）

C++ API の利用者は現時点で把握していないため、改善の余地を残しています。
`libmamba` における _後方互換性_ の意味は以下のとおりです：

- _ABI後方互換性_ とは、ライブラリのバイナリファイルをヘッダの更新なしで置き換えてもコードの再コンパイルが不要であり、（バグが消えることを除いて）動作が同じであることを意味します。
- _API後方互換性_ とは、コードの再ビルドは必要ですが、コード自体の修正は不要であることを意味します（ただし `detail` サブネームスペースなどプライベートとされる宣言は除く）。
  （バグが消えることを除いて）動作は同じです。
  宣言が非推奨となっても削除されておらず機能している場合も、コンパイル時の挙動が変化するだけなので後方互換とみなします。

これを踏まえて、`libmamba` では次の保証を提供します：

- `PATCH` リリースは API および ABI の後方互換性を保持
- `MINOR` リリースは `mamba/api` 内の宣言について API 後方互換性を保持。他は API や ABI が破壊される場合あり
- `MAJOR` リリースは保証なし

### `libmambapy`（Python）

`libmambapy` について、_API後方互換性_ とは、プライベートとされる宣言（例：`_` で始まる名前）を使わない限り、新しいバージョンでも Python コードが同じように動作することを意味します。
（バグが消えることを除いて）動作は同じです。
宣言が非推奨となっても削除されておらず機能している場合も、Python の `DeprecationWarning` を有効にしない限り挙動は変わりませんので、これも後方互換とみなします。

これを踏まえて、`libmambapy` では次の保証を提供します：

- `PATCH` リリースは API 後方互換性を保持
- `MINOR` リリースは API 後方互換性を保持
- `MAJOR` リリースは保証なし

### `mamba` および `micromamba`（実行ファイル）

実行ファイルについて、_後方互換性_ とはプログラムからの入力・出力に関して、シェルスクリプト等のコードが新しいバージョンの実行ファイルでも修正不要で動作することを意味します。
プログラムによる入出力には、実行ファイル名、コマンドライン引数、設定ファイル、環境変数、JSON コマンドライン出力、作成されるファイルなどが含まれます。
人間向け出力・エラーメッセージ（および人間向けの非推奨警告）は含みません。

これを踏まえて、`mamba` および `micromamba` では次の保証を提供します：

- `PATCH` リリースは後方互換性を保持
- `MINOR` リリースは後方互換性を保持
- `MAJOR` リリースは保証なし

## サポートについて

`mamba` および `micromamba` の 2.0 以降のみがサポート対象および積極的に開発されています。

`1.x` ブランチは、CVE などのセキュリティ問題対応のためのみ保守されています。

質問は [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
または [Conda チャンネル](https://gitter.im/conda/conda) でも受け付けています（本プロジェクトは `conda` や Anaconda Inc. とは公式な関係はありません）。

## ライセンス

本ソフトウェアは、全てのコントリビュータが自身の貢献分の著作権を維持できる共有著作権モデルを採用しています。

本ソフトウェアは BSD-3-Clause ライセンスの下でライセンスされています。詳細は [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) ファイルを参照してください。

---

### 隔週開発ミーティング

私たちは2週間ごとにビデオ会議ミーティングを開催し、進捗やフィードバックを共有しています。

議題のある方も、聞くだけの方も、どなたでも参加歓迎です。

- 日時: 火曜日 [午後4時（中央ヨーロッパ時間）](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- 場所: [Mamba jitsi](https://meet.jit.si/mamba-org)
- 内容: [ミーティングノート](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---