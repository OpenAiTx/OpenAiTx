<img src="https://raw.githubusercontent.com/jerthz/scion/main/banner.png" alt="Scion" />

ScionはRustで作られた2Dゲームライブラリです。

> このプロジェクトはまだ初期段階にあり、利便性や大きな機能の追加に応じて変更される可能性があることをご承知おきください。
> 
> Scionは自由に使っていただいて構いませんが、私はコミュニティに役立てるためにオープンソース化しただけで、現在のRustゲームエンジンのエコシステムの競合を目指しているわけではありません。

## なぜこのプロジェクトか？ 
まず第一に、ゲーム開発の様々な側面を内部から学ぶ良い方法だからです。 
それから、控えめな目標を持ち、使いやすさと指針となる短い原則のリストに焦点を当てたものを作りたかったからです。

Scionは他のエンジンに「触発」されたわけではなく、実際のゲームプロジェクトのニーズに基づいています。つまり、他で見たからという理由だけで機能を実装するのではなく、Scionを使う次のプロジェクトに必要だから実装するのです。

### 目標
- **2D**のみに強くフォーカス。
- **簡単**で**楽しい**使い心地。
- クリーンで読みやすいソースコード（必要に応じて書き直す努力をします）
- エディタなし、ライブラリとして常にあるべきもの

### 非目標
- 超最適化されたコードやパフォーマンス。これについては他のエンジンを試すか自作してください！
- 3D

## ドキュメント、チュートリアルは？
はい、計画中で作業中です。Scionの動作を見たい方は、現時点ではサンプルをご覧ください。

## なぜECSなのか？
現在、ECSはゲーム、ゲームライブラリ、ゲームエンジンにおいて「魔法の」言葉のように扱われています。しかしECSは万能の答えではなく、そう考えるべきでもありません。
私はECSには強みと弱みがあると考えています。 
ここでの採用は、このライブラリの最初の主なターゲットゲームが以下のようなものだったためです： 
- 複雑な都市建設ゲーム。
- リアルタイムでトレーナーが成長し、野生のポケモンが登場するポケモンファンゲーム。
- 粒度の細かいネットワークパケット表現＆ドットシミュレーションゲーム。

## 主な依存関係
このプロジェクトが依存しているライブラリです。これら素晴らしいコミュニティのおかげで、このような小さなプロジェクトを構築できています。

- <a href="https://github.com/rust-windowing/winit" target="blank">winit</a> と <a href="https://github.com/gfx-rs/wgpu/tree/master/wgpu" target="blank">wgpu</a>（ウィンドウ管理とマルチバックエンドレンダリング）
- <a href="https://github.com/Ralith/hecs" target="blank">hecs</a>（エンティティコンポーネントシステム）
- <a href="https://github.com/termhn/ultraviolet" target="blank">ultraviolet</a>（数学）

## 前提条件
Scionをビルドするには、システムに必要なパッケージをインストールする必要があります：
### Debian、Ubuntu、PopOS...
```sh
sudo apt install gcc cmake build-essential libx11-dev libxi-dev libgl1-mesa-dev libasound2-dev
```
### Fedora

```sh
sudo dnf install gcc cmake make automake gcc gcc-c++ kernel-devel libX11-devel libXi-devel mesa-libGL-devel alsa-lib-devel
```
### Arch、Manjaro...

```sh
sudo pacman -S gcc cmake make automake linux-headers libx11 libxi mesa alsa-lib
```

### 例を実行する
次に、例を実行できます:
```sh
cargo run --example bomberman --release
```

## ショーケース

| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/taquin/taquin_2.gif" alt="Taquin" style="width:300px; border: 2px solid black;"/>  | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/tetris/tetris.gif" alt="Tetris" style="width:300px" />             | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/pixel-adventures/pixel-adventures.gif" alt="Pixel-adventures" style="width:300px" /> |
|---------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/bomberman/bomberman.gif" alt="Bomberman" style="width:300px" />                    | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/jezzball/jezzball.gif" alt="Jezzball" style="width:300px" />       | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/new-bark-town/new-bark-town.gif" alt="New bark town" style="width:300px" />          |
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/starlight-1961/starlight.gif" alt="Starlight" style="width:300px" />               | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/klondike.gif" alt="Starlight" style="width:300px" /> | |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---