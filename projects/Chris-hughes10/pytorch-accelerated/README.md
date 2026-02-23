# pytorch-accelerated

`pytorch-accelerated` is a lightweight library designed to accelerate the process of training PyTorch models
 by providing a minimal, but extensible training loop - encapsulated in a single `Trainer` 
object - which is flexible enough to handle the majority of use cases, and capable of utilizing different hardware
 options with no code changes required.
 
`pytorch-accelerated` offers a streamlined feature set, and places a huge emphasis on **simplicity** and **transparency**,
to enable users to understand exactly what is going on under the hood, but without having to write and maintain the boilerplate themselves!
   
The key features are:
- A simple and contained, but easily customisable, training loop, which should work out of the box in straightforward cases;
 behaviour can be customised using inheritance and/or callbacks.
- Handles device placement, mixed-precision, DeepSpeed integration, multi-GPU and distributed training with no code changes.
- Uses pure PyTorch components, with no additional modifications or wrappers, and easily interoperates
 with other popular libraries such as [timm](https://github.com/rwightman/pytorch-image-models), 
 [transformers](https://huggingface.co/transformers/) and [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- A small, streamlined API ensures that there is a minimal learning curve for existing PyTorch users.

Significant effort has been taken to ensure that every part of the library - both internal and external components - is as clear and simple as possible, 
making it easy to customise, debug and understand exactly what is going on behind the scenes at each step; most of the 
behaviour of the trainer is contained in a single class! 
In the spirit of Python, nothing is hidden and everything is accessible.

`pytorch-accelerated` is proudly and transparently built on top of 
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), which is responsible for the 
movement of data between devices and launching of training configurations. When customizing the trainer, or launching
training, users are encouraged to consult the [Accelerate documentation](https://huggingface.co/docs/accelerate/) 
to understand all available options; Accelerate provides convenient functions for operations such gathering tensors 
and gradient clipping, usage of which can be seen in the `pytorch-accelerated` 
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) folder! 

To learn more about the motivations behind this library, along with a detailed getting started guide, check out [this blog post](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Installation

`pytorch-accelerated` can be installed from pip using the following command:
```
pip install pytorch-accelerated
```

To make the package as slim as possible, the packages required to run the examples are not included by default. To include these packages, you can use the following command:
```
pip install pytorch-accelerated[examples]
```

## Quickstart

To get started, simply import and use the pytorch-accelerated `Trainer` ,as demonstrated in the following snippet,
and then launch training using the 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
described below.

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

To launch training using the [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, on your machine(s), run:

` accelerate config --config_file accelerate_config.yaml`

and answer the questions asked. This will generate a config file that will be used to properly set the default options when doing

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Note*: Using the [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) is completely optional, training can also be launched in the usual way using:

`python train.py` / `python -m torch.distributed ...`

depending on your infrastructure configuration, for users who would like to maintain a more fine-grained control 
over the launch command.

More complex training examples can be seen in the examples folder 
[here](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples). 

Alternatively, if you would rather understand the core concepts first, this can be found in the [documentation](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Usage

### Who is pytorch-accelerated aimed at?

- Users that are familiar with PyTorch but would like to avoid having to write the common training loop boilerplate
to focus on the interesting parts of the training loop.
- Users who like, and are comfortable with, selecting and creating their own models, loss functions, optimizers and datasets.
- Users who value a simple and streamlined feature set, where the behaviour is easy to debug, understand, and reason about!

### When shouldn't I use pytorch-accelerated?

- If you are looking for an end-to-end solution, encompassing everything from loading data to inference,
  which helps you to select a model, optimizer or loss function, you would probably be better suited to
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` focuses only on the training process, with all other
  concerns being left to the responsibility of the user.
- If you would like to write the entire training loop yourself, just without all of the device management headaches, 
you would probably be best suited to using [Accelerate](https://github.com/huggingface/accelerate) directly! Whilst it
is possible to customize every part of the `Trainer`, the training loop is fundamentally broken up into a number of 
different methods that you would have to override. But, before you go, is writing those `for` loops really important 
enough to warrant starting from scratch *again* 😉.
- If you are working on a custom, highly complex, use case which does not fit the patterns of usual training loops
and want to squeeze out every last bit of performance on your chosen hardware, you are probably best off sticking
 with vanilla PyTorch; any high-level API becomes an overhead in highly specialized cases!


## Acknowledgements

Many aspects behind the design and features of `pytorch-accelerated` were greatly inspired by a number of excellent 
libraries and frameworks such as [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) and [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Each of these tools 
have made an enormous impact on both this library and the machine learning community, and their influence can not be 
stated enough!

`pytorch-accelerated` has taken only inspiration from these tools, and all of the functionality contained has been implemented
 from scratch in a way that benefits this library. The only exceptions to this are some of the scripts in the 
 [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
 folder in which existing resources were taken and modified in order to showcase the features of `pytorch-accelerated`;
 these cases are clearly marked, with acknowledgement being given to the original authors.
 
