# RISC-V ベクターベンチマーク

ポータブルで高性能なRVVコードを書くための開発者支援用RISC-Vベクター（RVV）ベンチマークのコレクションです。

ベンチマーク結果は以下で確認できます：https://camel-cdr.github.io/rvv-bench-results

## ベンチマーク ([./bench/](./bench/))

特定のアルゴリズムのさまざまな実装のベンチマークを多数収録しています。

## 命令サイクルカウント ([./instructions/](./instructions/))

指定したRVV命令を繰り返し展開しループさせることで、命令のサイクル数を測定します。

## はじめに

まず[./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk)を設定して`make`が動作するようにし、オプションで`make run`を使ってコンパイルと実行を可能にする[./run.sh](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./run.sh)も設定します。

デフォルト設定は最近のclangビルドで動作し、フルクロスコンパイルツールチェーンは不要です。なぜならfreestandingモードでビルドするためです。
つまりLinuxかLinuxのシステムコール互換OSでのみ動作します。

最近のLinuxではパフォーマンスカウンターはデフォルトで公開されていないため、`echo 2 >/proc/sys/kernel/perf_user_access`を実行し、[./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk)の`CFLAGS=...`行に`-DUSE_PERF_EVENT`を追加する必要があります（動作しない場合は代わりに`-DUSE_PERF_EVENT_SLOW`を試してください）。

[./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk)をホステッドビルド用に設定するか、カスタムツールチェーンで設定し、`-DCUSTOM_HOST`を定義に追加し、[./nolibc.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./nolibc.h)の`#ifdef CUSTOM_HOST`以下の未実装関数を実装してください。

XTheadVectorはサポートを終了しました。

### ベンチマークの実行 ([./bench/](./bench/))

ベンチマークを実行するには、まず([./bench/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./bench/config.h))を確認し、プロセッサに合わせて調整します（例：`HAS_E64`を設定）。実行に時間がかかる場合は、ベンチマークのスケールに使われる`MAX_MEM`を減らし、他の定数も調整して、実行時間が適切で比較的滑らかなグラフになるようにします。

その後、([./bench/](./bench/))ディレクトリで`make run`を実行するか、実行ファイルだけをビルドする場合は`make`を実行してください。

### サイクルカウントの測定 ([./instructions/](./instructions/))

サイクルカウント測定を実行するには、まず[instructions/rvv/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/instructions/rvv/config.h)をプロセッサに合わせて設定します。

その後、([./instructions/rvv/](./instructions/rvv/))ディレクトリで`make run`を実行するか、実行ファイルだけをビルドする場合は`make`を実行してください。

XTheadVectorの場合は([./instructions/xtheadvector/](./instructions/xtheadvector/))ディレクトリを使用してください。（こちらはもはやメンテナンスされていません）

## 貢献について

以下はまだ行う必要がある作業の提案です。

* 新しいCPUの測定結果を https://github.com/camel-cdr/rvv-bench-results に貢献してください。\
  単一のjsonファイルを含むissueを作成するだけで構いません。このファイルにはすべての結合された[./bench/](./bench/)の結果が含まれます。（適切なセットアップ後、`make run > out.json` で実行可能です）。\
* メモリ非依存ベンチマークの実装
* さらに多くのベンチマークの実装
* より良いサイクルカウント測定：スループット対レイテンシ（また：実行ポート構成を特定できますか？）
* ロード／ストアのサイクルカウント
* vsetvlのサイクルカウント

## ライセンス

このリポジトリはMITライセンス[LICENSE](LICENSE)の下でライセンスされています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---