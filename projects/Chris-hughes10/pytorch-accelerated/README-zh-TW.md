<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# pytorch-accelerated

`pytorch-accelerated` 是一個輕量級的函式庫，旨在加速 PyTorch 模型訓練流程，
透過提供一個極簡但可擴展的訓練迴圈 —— 封裝於單一 `Trainer`
物件中 —— 這個物件足夠靈活，能應對大多數使用情境，並且能在不同硬體
選項下運行，無需修改任何程式碼。
 
`pytorch-accelerated` 提供精簡的功能集，並極度強調 **簡潔** 與 **透明度**，

讓使用者能夠完全理解底層發生了什麼事，同時不需要自己撰寫和維護樣板程式碼！
   
主要功能包括：
- 一個簡單且封閉，但易於自訂的訓練迴圈，在一般情況下可直接使用；
  行為可透過繼承和/或回呼函式進行自訂。
- 處理裝置部署、混合精度、DeepSpeed整合、多GPU及分布式訓練，無需更動任何程式碼。
- 採用純 PyTorch 組件，無需額外修改或包裝，並可輕鬆與其他熱門函式庫如 [timm](https://github.com/rwightman/pytorch-image-models)、 
  [transformers](https://huggingface.co/transformers/) 及 [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/) 互操作。
- 精簡的 API 確保現有 PyTorch 使用者幾乎無需學習門檻。

我們投入大量心力確保函式庫的每個部分——包括內部與外部組件——都盡可能清楚且簡單，
使其易於自訂、除錯並能完全理解每一步背後的運作；訓練器的主要行為都封裝在單一類別內！
秉持 Python 精神，沒有任何東西被隱藏，一切皆可存取。

`pytorch-accelerated` 堂堂正正且透明地建構於
[Hugging Face Accelerate](https://github.com/huggingface/accelerate) 之上，負責
裝置間資料移動及訓練配置啟動。當自訂訓練器或啟動訓練時，
建議使用者參考 [Accelerate 文件](https://huggingface.co/docs/accelerate/)
以了解所有可用選項；Accelerate 提供方便的函式，如張量收集及梯度截斷，
其使用方式可於 `pytorch-accelerated`
[範例](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) 資料夾中看到！

若想了解這個函式庫背後的動機，以及詳細的入門指南，請參閱 [這篇部落格文章](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968)。

## 安裝

可透過 pip 使用以下指令安裝 `pytorch-accelerated`：


```
pip install pytorch-accelerated
```
為了使套件盡可能精簡，預設情況下不會包含執行範例所需的套件。若要包含這些套件，您可以使用以下指令：

```
pip install pytorch-accelerated[examples]
```

## 快速入門

要開始使用，只需按照以下範例匯入並使用 pytorch-accelerated 的 `Trainer`，
然後使用下方說明的 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
啟動訓練即可。

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
要使用 [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) 啟動訓練，
請在您的機器上執行：

` accelerate config --config_file accelerate_config.yaml`

並回答所提出的問題。這將生成一個配置檔案，會在執行以下操作時用於正確設置預設選項：

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*注意*：使用 [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) 完全是可選的，訓練也可以用常規方式啟動：

`python train.py` / `python -m torch.distributed ...`

根據您的基礎設施配置，適用於希望更細緻控制啟動命令的使用者。

更複雜的訓練範例可在範例資料夾
[這裡](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) 找到。

另外，如果您希望先了解核心概念，可參閱 [文件](https://pytorch-accelerated.readthedocs.io/en/latest/)。

## 使用方法

### pytorch-accelerated 適合哪些人？

- 熟悉 PyTorch 的使用者，但希望避免撰寫常見的訓練迴圈樣板，專注於訓練迴圈的有趣部分。
- 喜歡並習慣自己選擇及創建模型、損失函數、優化器和資料集的使用者。
- 重視簡單且精簡功能集，行為容易除錯、理解和推理的使用者！

### 什麼情況下不適合使用 pytorch-accelerated？

- 如果您尋找的是端到端解決方案，涵蓋從資料載入到推論，
  並協助您選擇模型、優化器或損失函數，您可能會更適合
  [fastai](https://github.com/fastai/fastai)。`pytorch-accelerated` 只專注於訓練過程，其他
  部分則由使用者自行負責。
- 如果您想自己撰寫完整的訓練迴圈，只是不想處理設備管理的麻煩，
您可能會更適合直接使用 [Accelerate](https://github.com/huggingface/accelerate)！儘管
可以自訂 `Trainer` 的每個部分，訓練迴圈基本上被拆分為數個



你需要覆寫不同的方法。但，在你開始之前，寫那些 `for` 迴圈真的重要到值得你*再次*從頭開始嗎 😉。
- 如果你正在處理一個自訂且高度複雜的用例，無法套用一般訓練迴圈的模式，並且希望在所選硬體上榨取每一分效能，那麼你很可能最好還是堅持使用原生 PyTorch；任何高階 API 在高度專業化的情境下都會變成額外負擔！


## 致謝

`pytorch-accelerated` 在設計與功能上，深受許多優秀函式庫與框架的啟發，例如 [fastai](https://github.com/fastai/fastai)、[timm](https://github.com/rwightman/pytorch-image-models)、[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) 以及 [Hugging Face Accelerate](https://github.com/huggingface/accelerate)。這些工具對本函式庫及整個機器學習社群帶來了巨大影響，他們的貢獻不可言喻！

`pytorch-accelerated` 僅從這些工具中獲取靈感，所有功能皆從零開始實作，以最大化本函式庫的效益。唯一的例外是部份位於 [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) 資料夾中的腳本，這些腳本取自現有資源並經過修改，用以展示 `pytorch-accelerated` 的特色；
這類情況皆有明確標註，並向原作者致上謝意。













---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---