# go-torch 

go-torch は純粋な Go 言語でゼロから構築されたオープンソースのディープラーニングフレームワークです。安定した自動微分エンジンを備え、PyTorch のようなモジュラーAPIでニューラルネットワークの構築とトレーニングを提供します。

mail - abineshmathivanan31@gmail.com 

blog - https://abinesh-mathivanan.vercel.app/en/posts/post-5/


## features 
- **動的計算グラフ**: テンソルは履歴を追跡し、バックワードパスで自動勾配計算を可能にします。
- 拡張可能なモジュールシステム (nn.Layer, nn.Sequential): 柔軟で Keras のようなシーケンシャルAPIで複雑なモデルアーキテクチャを構築。
- レイヤーおよび関数ライブラリ: Conv2D、Linear、MaxPooling2D、Flatten、ReLU、CrossEntropyLoss、SGD を含みます。
- **リアルタイム TUI ダッシュボード**: バッチ単位の損失とエポック単位の検証精度のライブグラフ、メモリ使用量（Heap/Total Alloc）、GCサイクル、アクティブなゴルーチンの監視、keras風のサマリー付き。
- 最適化されたパフォーマンス: BLAS、ゴルーチン、トポロジカルオートグラッド＋勾配蓄積を利用。

<br/>

**TUI Dashboard**

![alt text](https://raw.githubusercontent.com/Abinesh-Mathivanan/go-torch/main/dashboard.png)


<br>

## TODO
- [ ] RNN、LSTM、Transformer のサポート追加
- [ ] Ga-lore と LORA 技術を用いた Adam、RMSProp 等の実装
- [ ] gob を使わない model.load() と model.save()
- [ ] Transformer の構築サポート

<br/>

## pre-requisites 
- Go 1.18 以降。
- 最大パフォーマンスのためにシステムにインストールされた BLAS ライブラリ推奨だが必須ではない。
- 一部のTODOはファイル内に記述。最良の体験には 'better comments' 拡張機能を使用してください。

<br/>

## 使用方法

### リポジトリをクローンする
```bash
git clone https://github.com/abinesh-mathivanan/go-torch.git
cd go-torch
``` 
### 依存関係のインストール 
``` bash
go mod tidy
```

### 実行 
mnistのトレーニングファイルを実行して機能をテストします。 
```bash
go run ./cnn_benchmark/go_bench.go
```
<br>

## ベンチマーク

| ベンチマーク詳細                          | 128x128      | 512x512     | 1024x1024    |
|:------------------------------------------|:-------------|:------------|:-------------|
| **行列乗算**                             | 510.33 µs    | 13.54 ms    | 130.50 ms    |
| 要素ごとの加算                           | 71.72 µs     | 1.29 ms     | 4.13 ms      |
| 要素ごとの乗算                           | 47.83 µs     | 1.63 ms     | 3.91 ms      |
| ReLU 活性化関数                         | 121.18 µs    | 1.75 ms     | 6.45 ms      |
| **線形層の順伝播 (B32,I128,O10)**         | 71.93 µs     |             |              |
| **クロスエントロピー損失 (B32,C10)**      | 11.16 µs     |             |              |
| **完全順伝播-逆伝播 (ネット:128-256-10, B32)** | 4.02 ms      |             |              |


<br>
<br>

[![Star History Chart](https://api.star-history.com/svg?repos=Abinesh-Mathivanan/go-torch&type=Date)](https://www.star-history.com/#Abinesh-Mathivanan/go-torch&Date)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-26

---