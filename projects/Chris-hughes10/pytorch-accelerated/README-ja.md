# pytorch-accelerated

`pytorch-accelerated` は、PyTorchモデルのトレーニングプロセスを加速するために設計された軽量ライブラリで、
最小限ながら拡張可能なトレーニングループを提供します - それは単一の `Trainer` 
オブジェクトにカプセル化されており、多くのユースケースに対応可能で、コード変更なしで異なるハードウェア
オプションを利用できる柔軟性を持っています。
 
`pytorch-accelerated` は洗練された機能セットを提供し、**シンプルさ**と**透明性**を強く重視しており、
ユーザーが内部で何が起きているかを正確に理解できるようにしつつ、自分でボイラープレートコードを書いて維持する必要をなくします！
   
主な特徴は以下の通りです：
- シンプルで完結した、しかし簡単にカスタマイズ可能なトレーニングループ。単純なケースではすぐに使える；
 振る舞いは継承やコールバックを用いてカスタマイズ可能です。
- デバイス配置、混合精度、DeepSpeed統合、マルチGPUおよび分散トレーニングをコード変更なしで処理します。
- 純粋なPyTorchコンポーネントを使用し、追加の修正やラッパーはなく、[timm](https://github.com/rwightman/pytorch-image-models)、 
 [transformers](https://huggingface.co/transformers/)、[torchmetrics](https://torchmetrics.readthedocs.io/en/latest/) などの他の人気ライブラリと簡単に連携可能です。
- 小規模で洗練されたAPIにより、既存のPyTorchユーザーにとって学習コストが最小限です。

ライブラリのあらゆる部分 - 内部および外部のコンポーネントの両方 - が可能な限り明確かつシンプルになるように多大な努力が払われており、 
カスタマイズやデバッグが容易で、各ステップの裏側で何が起きているかを正確に理解できます；トレーナーの
動作の大部分は単一のクラスに収められています！
Pythonの精神に則り、何も隠されておらず全てにアクセス可能です。

`pytorch-accelerated` は誇りを持って透明に 
[Hugging Face Accelerate](https://github.com/huggingface/accelerate) の上に構築されており、これは
デバイス間のデータ移動やトレーニング設定の起動を担当しています。トレーナーをカスタマイズしたり
トレーニングを開始する際は、利用可能なすべてのオプションを理解するために [Accelerateのドキュメント](https://huggingface.co/docs/accelerate/) を参照することが推奨されます；
Accelerate はテンソルの集約や勾配クリッピングなどの便利な関数を提供しており、その使用例は `pytorch-accelerated` の
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) フォルダで見ることができます！

このライブラリの動機や詳細な入門ガイドについては、[このブログ記事](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968) をご覧ください。

## インストール

`pytorch-accelerated` は以下のコマンドでpipからインストールできます：


```
pip install pytorch-accelerated
```
パッケージをできるだけスリムにするために、例を実行するために必要なパッケージはデフォルトで含まれていません。これらのパッケージを含めるには、次のコマンドを使用できます：

```
pip install pytorch-accelerated[examples]
```

## クイックスタート

始めるには、以下のスニペットで示されているように、pytorch-acceleratedの`Trainer`をインポートして使用し、
その後、以下に記載された
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
を使ってトレーニングを開始します。

```python
# examples/core/train_mnist.py
import os

from torch import nn, optim
from torch.utils.data import random_split
from torchvision import transforms
from torchvision.datasets import MNIST

from pytorch_accelerated import Trainer

class MNISTModel(nn.Module):
    def __init__(self):
        super().__init__()
        self.main = nn.Sequential(
            nn.Linear(in_features=784, out_features=128),
            nn.ReLU(),
            nn.Linear(in_features=128, out_features=64),
            nn.ReLU(),
            nn.Linear(in_features=64, out_features=10),
        )

    def forward(self, input):
        return self.main(input.view(input.shape[0], -1))

def main():
    dataset = MNIST(os.getcwd(), download=True, transform=transforms.ToTensor())
    train_dataset, validation_dataset, test_dataset = random_split(dataset, [50000, 5000, 5000])
    model = MNISTModel()
    optimizer = optim.SGD(model.parameters(), lr=0.001, momentum=0.9)
    loss_func = nn.CrossEntropyLoss()

    trainer = Trainer(
            model,
            loss_func=loss_func,
            optimizer=optimizer,
    )

    trainer.train(
        train_dataset=train_dataset,
        eval_dataset=validation_dataset,
        num_epochs=8,
        per_device_batch_size=32,
    )

    trainer.evaluate(
        dataset=test_dataset,
        per_device_batch_size=64,
    )
    
if __name__ == "__main__":
    main()
```
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) を使用してトレーニングを開始するには、
マシン上で次のコマンドを実行します:

` accelerate config --config_file accelerate_config.yaml`

表示される質問に答えてください。これにより、以下を実行する際に適切にデフォルトオプションを設定するための
設定ファイルが生成されます。

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*注*: [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) の使用は完全に任意です。トレーニングは以下のように
通常の方法でも開始できます:

`python train.py` / `python -m torch.distributed ...`

これはインフラ構成に応じて、起動コマンドをより細かく制御したいユーザー向けです。

より複雑なトレーニング例は、examples フォルダで確認できます
[こちら](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)。

あるいは、まずコアコンセプトを理解したい場合は、[ドキュメント](https://pytorch-accelerated.readthedocs.io/en/latest/)にあります。

## 使い方

### pytorch-accelerated は誰向け？

- PyTorch に慣れていて、トレーニングループの共通ボイラープレートを書くことを避けて、
  トレーニングループの面白い部分に集中したいユーザー。
- 自分でモデル、損失関数、オプティマイザ、データセットの選択や作成を好み、慣れているユーザー。
- シンプルで洗練された機能セットを重視し、動作がデバッグしやすく、理解しやすく、論理的に考えやすいことを望むユーザー。

### いつ pytorch-accelerated を使うべきでない？

- データの読み込みから推論までを含むエンドツーエンドのソリューションを探していて、
  モデル、オプティマイザ、損失関数の選択を助けてくれるものが必要なら、
  おそらく [fastai](https://github.com/fastai/fastai) の方が適しているでしょう。`pytorch-accelerated` はトレーニングプロセスのみに焦点を当てており、
  他の全てはユーザーの責任に任されています。
- トレーニングループ全体を自分で書きたいが、デバイス管理の煩わしさだけは避けたい場合は、
  おそらく [Accelerate](https://github.com/huggingface/accelerate) を直接使うのが最適でしょう。`Trainer` のあらゆる部分をカスタマイズ可能ですが、
  トレーニングループは基本的に複数の部分に分割されています。
異なるメソッドをオーバーライドする必要があります。しかし、その前に、本当にまた最初から`for`ループを書くことが重要でしょうか😉。
- 通常のトレーニングループのパターンに当てはまらないカスタムで非常に複雑なユースケースに取り組んでいて、
選択したハードウェアでのパフォーマンスを最大限に引き出したい場合は、おそらくバニラのPyTorchを使い続けるのが最善です；
高度なAPIは高度に専門化されたケースではオーバーヘッドになります！


## 謝辞

`pytorch-accelerated`の設計と機能の多くは、[fastai](https://github.com/fastai/fastai)、[timm](https://github.com/rwightman/pytorch-image-models)、
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning)、および[Hugging Face Accelerate](https://github.com/huggingface/accelerate)などの
優れたライブラリやフレームワークから大きな影響を受けています。これらのツールはこのライブラリと機械学習コミュニティの両方に
非常に大きな影響を与えており、その影響力は言い尽くせません！

`pytorch-accelerated`はこれらのツールからインスピレーションを得ていますが、含まれる全ての機能はこのライブラリに
利益をもたらすよう一から実装されています。唯一の例外は、
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
フォルダ内のいくつかのスクリプトで、既存のリソースを取り入れ`pytorch-accelerated`の機能を示すために修正したものです；
これらの場合は明確にマークされ、元の作者に謝辞が示されています。
 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---