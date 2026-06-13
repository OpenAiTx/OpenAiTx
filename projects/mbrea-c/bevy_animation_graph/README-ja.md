_ライブラリクレート:_
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)

_エディタークレート:_
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)

[![CI](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml/badge.svg)](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml)

# Bevy Animation Graph

> **_注意:_** 現在バージョン `0.8.0` 以下を使用している場合、
> `0.9.0` では多くの破壊的変更が導入されています。
> アップグレードには
> [マイグレーションガイド](https://mbrea-c.github.io/bevy_animation_graph/migration_guides/0.8_to_0.9.html)
> をご覧ください。

## 動機

アニメーショングラフは、現代の3Dゲームのアニメーションパイプラインに存在する複雑さを管理するための重要なツールです。
ゲームに複雑なブレンドや遷移を持つ数十のアニメーションがある場合や、
ごく少数のキーフレームからアニメーションを手続き的に生成したい場合、単純なアニメーションクリップの再生だけでは不十分です。

このクレートは `bevy_animation` の多くの機能に代わるものとして機能し、
アニメーショングラフ、アニメーションステートマシン（すなわちアニメーションコントローラー）、
およびアニメーショングラフとステートマシンを作成するためのグラフィカルエディターを含む
完全なアニメーションシステムと開発ワークフローを提供することを目的としています。

_注: このプロジェクトは `bevy_animation` バージョン0.14で導入されたアニメーショングラフとは別物です。_

![利用例スクリーンショット](https://raw.githubusercontent.com/mbrea-c/bevy_animation_graph/master/locomotion_graph.png)

## 現在の機能

- アニメーショングラフはアセットです。アセットファイルからロードできるほか、
  エルゴノミックなAPIを使ってコード内で作成可能です。
- ビジュアルグラフエディター。


- アニメーションステートマシン:
  - アニメーションステートマシンはアニメーショングラフ内のノードとして埋め込まれています。
  - ステートマシン内の各ステートは要求に応じて自身のアニメーショングラフを再生します。
  - トランジションも独自のアニメーショングラフを持ち、ソースおよびターゲットステートのアニメーショングラフを参照できます。
- ラグドールサポート:
  - エディタ内での視覚的なラグドール編集が可能です。
  - 一部のボーンのみ物理シミュレーションされ、その他はターゲットのアニメーションポーズでキネマティックに駆動される
    _部分ラグドール_をサポートしています。
- Rustで書かれたカスタムノードのサポート。
  - ユーザーはエディタプラグインを追加し、Bevyのタイプレジストリに独自のカスタムノードを登録することで
    独自のエディタバイナリを作成できます。エディタは登録されたすべてのノードを自動的に認識します。
- 利用可能な組み込みノードには以下が含まれます:
  - アニメーションチェイニング（すなわち、あるノードの後に別のノードを再生）。
  - 2ボーン逆運動学。
  - ループ再生。
  - 線形ブレンディング（ボーン空間内）。
  - 2Dブレンドスペースノード。
  - YZ平面を中心にアニメーションをミラーリング。
  - アニメーションクリップ再生。
  - ボーンマスクを使用してポーズ内の特定のボーンに回転を適用。
  - アニメーション再生速度の加速・減速。
  - アニメーショングラフノード。
  - アニメーションステートマシンノード。
  - 算術ノード：f32、Vec3、Quatなどの一般的な演算を多様に提供。
- 他のグラフ内にアニメーショングラフをノードとして入れ子にできます。
- イベントトラックを使ったアニメーション同期。
- 不要な計算を避けるためにグラフノードの出力はキャッシュされます。

## 今後の計画機能

1. ラグドールの「ポーズ追従」モード。物理的な力を用いてシミュレーションされたラグドールボーンが
   ターゲットポーズに追従しようとします:
   - _絶対_追従モード：ターゲットボーンのワールド空間位置・回転を追跡し、
     ラグドールボーンに対するバネ力の基点として使用します。
   - _相対_追従モード：ラグドールボーンが親ボーンに対するターゲットの位置・回転に合わせて追従します。
     このモードを適切に実装するにはAvianでのジョイントモーターサポートが必要になるかもしれません。





## インストール

### ライブラリ

[bevy_animation_graph](https://crates.io/crates/bevy_animation_graph) は
このプロジェクトのライブラリ部分です。アニメーショングラフを使用するために、
あなたのプロジェクトの依存関係として追加する必要があります。crates.ioから
最新の公開バージョンをインストールするには、次のコマンドを実行してください。

```bash
cargo add bevy_animation_graph
```
または最新バージョンを手動で `Cargo.toml` に追加してください。

最新のgitマスターをインストールするには、次の内容を `Cargo.toml` に追加してください：


```toml
# ...
[dependencies]
# ...
bevy_animation_graph = { git = "https://github.com/mbrea-c/bevy_animation_graph.git" }
# ...
```

### エディター

[bevy_animation_graph_editor](https://crates.io/crates/bevy_animation_graph_editor)
はエディターです。通常のRustバイナリと同様にインストールできます：

```bash
# for the latest crates.io version
cargo install bevy_animation_graph_editor
# for the latest master
cargo install --git https://github.com/mbrea-c/bevy_animation_graph bevy_animation_graph_editor
# for the version from a local workspace
cargo install --path <PATH_TO_WORKSPACE> bevy_animation_graph_editor

# use the --force flag to force reinstall
```
あるいは、  
[プラグインとしてのエディターの例](https://github.com/mbrea-c/bevy_animation_graph/blob/master/examples/editor_as_a_plugin/examples/editor_as_a_plugin.rs)  
を参照して、クレート／ワークスペース内に独自のエディターバイナリを設定し、  
ゲームと同じライブラリバージョンを使用することをお勧めします。  
これにより、このクレートの強力な機能であるカスタムアニメーショングラフノードを登録できます。  

## はじめに  

[進行中の書籍](https://sarahihme.github.io/initial_book_bevy_animation_graph/)  
のチュートリアルをチェックしてください（@SarahIhme に感謝します！）。  

最新の追加例は、  
[examples](https://github.com/mbrea-c/bevy_animation_graph/tree/master/examples)  
ディレクトリに含まれています。  

以下のリソースも参考になりますが、やや古い情報です：  

- [docs.rs](https://docs.rs/bevy_animation_graph) のドキュメントには、  
  ライブラリとエディターの紹介や簡単なアニメーショングラフの例の説明があります。  
  エディターの使い方のデモについては下記の動画もご覧ください。  
- 古い  
  [使用方法の動画ウォークスルー](https://www.youtube.com/watch?v=q-JBSQJIcX0) があります。  

## 貢献やサポートについて  

バグに遭遇した場合や新機能について議論したい場合は、  
Issueを投稿したりPRを開いたり、Discordで私に連絡してください（Bevy Discord内の@mbreac、  
`bevy_animation_graph`用のcrate-helpチャンネルがあります：  
[リンク](https://discord.com/channels/691052431525675048/1202998277482479616)）。  

## FAQ  

### これは本番環境向けですか？  

状況によります。  

小規模なプロジェクトにはすでに有用ですが、APIの保証はできません。



異なる `0.x` バージョン間の安定性（これは大きなライブラリで、比較的新しく、アニメーションプログラミングの経験がないため、最適な方法を模索しているところです）を保つことは難しいです。  
つまり、より良いマイグレーション方法を見つけるまでは、アニメーショングラフのアセットを手動でバージョン間移行する必要がある可能性が高いということです。  

さらに、バグやその他の問題が発生することは ~~あるかもしれません~~ あります。  
発生した際にはできるだけ修正するよう努めています。  

### 機能 X は実装されますか？  

もし小さな機能（例えば追加のベクトルや浮動小数点演算ノードなど）であれば、単にまだ対応できていないだけの可能性が高いです。  
Issue を開いていただければ、迅速に実装することが多いです。PR も歓迎します。  

より大きな機能については、まず Issue を開いて議論を始めるか、Bevy の Discord で私に連絡するのが良いでしょう。  

## バージョン表  

| `bevy` | `bevy_animation_graph` |  
| ------ | ---------------------- |  
| 0.18 | master |  
| 0.18 | 0.10 |  
| 0.17 | 0.9 |  
| 0.17 | 0.8 |  
| 0.16 | 0.7 |  
| 0.15 | 0.6 |  
| 0.14 | 0.5 |  
| 0.13 | 0.4 |  
| 0.13 | 0.3 |  
| 0.12 | 0.2 |  

## 謝辞  

アニメーションプログラミングに関する講義を行っている [Bobby Anguelov](https://www.youtube.com/@BobbyAnguelov) に多大なる感謝を捧げます。









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---