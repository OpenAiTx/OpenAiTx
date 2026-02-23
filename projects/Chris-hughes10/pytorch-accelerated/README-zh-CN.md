# pytorch-accelerated

`pytorch-accelerated` 是一个轻量级库，旨在通过提供一个简洁但可扩展的训练循环来加速 PyTorch 模型的训练过程——封装在单个 `Trainer` 对象中——该对象足够灵活，可处理大多数用例，并且能够利用不同的硬件选项，无需更改代码。

`pytorch-accelerated` 提供了精简的功能集，并非常强调 **简单性** 和 **透明性**，使用户能够准确了解底层发生的情况，而无需自己编写和维护样板代码！

主要特性包括：
- 一个简单且封闭，但易于定制的训练循环，在简单场景下开箱即用；行为可以通过继承和/或回调进行定制。
- 处理设备放置、混合精度、DeepSpeed 集成、多 GPU 及分布式训练，无需更改代码。
- 使用纯 PyTorch 组件，无需额外修改或包装，并且能轻松与其他流行库如 [timm](https://github.com/rwightman/pytorch-image-models)、[transformers](https://huggingface.co/transformers/) 和 [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/) 互操作。
- 小巧精简的 API 确保现有 PyTorch 用户的学习曲线极低。

投入了大量精力确保库的每个部分——包括内部和外部组件——都尽可能清晰简单，便于定制、调试，并准确理解每一步背后的实际操作；训练器的大部分行为都包含在一个类中！
秉承 Python 精神，所有内容都不隐藏，全部可访问。

`pytorch-accelerated` 自豪且透明地构建在 [Hugging Face Accelerate](https://github.com/huggingface/accelerate) 之上，后者负责设备间数据移动和训练配置的启动。在定制训练器或启动训练时，建议用户查阅 [Accelerate 文档](https://huggingface.co/docs/accelerate/) 以了解所有可用选项；Accelerate 提供了便捷的函数用于如张量收集和梯度裁剪等操作，其使用示例可见于 `pytorch-accelerated` 的 [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) 文件夹！

想了解更多关于该库的动机及详细入门指南，请查看[这篇博客文章](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968)。

## 安装

`pytorch-accelerated` 可通过 pip 使用以下命令安装：















```
pip install pytorch-accelerated
```
为了使软件包尽可能精简，运行示例所需的软件包默认不包括在内。要包含这些软件包，您可以使用以下命令：

```
pip install pytorch-accelerated[examples]
```

## 快速开始

要开始，只需导入并使用pytorch加速的`Trainer`，如下面的代码片段所示，
然后使用下面描述的
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
启动训练。

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
要使用[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)启动训练，
在你的机器上运行：

` accelerate config --config_file accelerate_config.yaml`

并回答所提出的问题。这将生成一个配置文件，用于在执行

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

时正确设置默认选项。

*注意*：使用[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)是完全可选的，训练也可以通过以下常规方式启动：

`python train.py` / `python -m torch.distributed ...`

这取决于你的基础设施配置，适合希望对启动命令进行更细粒度控制的用户。

更复杂的训练示例可以在示例文件夹中查看
[这里](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)。

或者，如果你更愿意先了解核心概念，可以在[文档](https://pytorch-accelerated.readthedocs.io/en/latest/)中找到。

## 使用说明

### pytorch-accelerated的目标用户是谁？

- 熟悉PyTorch但希望避免编写常见训练循环样板代码，以便专注于训练循环有趣部分的用户。
- 喜欢并且擅长选择和创建自己的模型、损失函数、优化器和数据集的用户。
- 重视简单且精简的功能集，行为易于调试、理解和推理的用户！

### 什么时候不应该使用pytorch-accelerated？

- 如果你正在寻找一套端到端的解决方案，涵盖从数据加载到推理的所有环节，
  并帮助你选择模型、优化器或损失函数，你可能更适合使用
  [fastai](https://github.com/fastai/fastai)。`pytorch-accelerated`仅专注于训练过程，其他所有
  方面由用户自行负责。
- 如果你想自己编写整个训练循环，只是不想处理所有设备管理的头疼问题，
你可能更适合直接使用[Accelerate](https://github.com/huggingface/accelerate)！虽然可以自定义`Trainer`的每个部分，训练循环本质上被拆分为多个


不同的方法你可能需要重写。但是，在你开始之前，编写那些 `for` 循环真的重要到值得*再次*从头开始写吗😉。
- 如果你正在处理一个自定义的、高度复杂的用例，不符合通常训练循环的模式，
并且想要在你选择的硬件上榨取每一丝性能，那么你最好坚持使用原生 PyTorch；任何高级 API 在高度专业化的情况下都会成为负担！


## 致谢

`pytorch-accelerated` 的设计和功能的许多方面都深受一些优秀库和框架的启发，比如 [fastai](https://github.com/fastai/fastai)、[timm](https://github.com/rwightman/pytorch-image-models)、
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) 和 [Hugging Face Accelerate](https://github.com/huggingface/accelerate)。这些工具
对本库和机器学习社区都产生了巨大影响，其影响力不可言喻！

`pytorch-accelerated` 只是从这些工具中汲取灵感，所有包含的功能都是从零开始实现的，以适应本库的需求。唯一的例外是
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
文件夹中的一些脚本，这些脚本采用并修改了现有资源以展示 `pytorch-accelerated` 的功能；
这些情况都有明确标记，并对原作者给予了致谢。








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---