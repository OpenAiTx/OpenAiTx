# pytorch-accelerated

`pytorch-accelerated`는 PyTorch 모델 학습 과정을 가속화하기 위해 설계된 경량 라이브러리로,  
최소한이지만 확장 가능한 학습 루프를 단일 `Trainer` 객체에 캡슐화하여 제공하며,  
대부분의 사용 사례를 처리할 수 있을 만큼 유연하고 하드웨어 옵션을 변경해도 코드 수정이 필요 없습니다.  

`pytorch-accelerated`는 간소화된 기능 세트를 제공하며, **단순성**과 **투명성**에 큰 중점을 두어,  
사용자가 내부 동작을 정확히 이해할 수 있도록 하면서도 반복적인 보일러플레이트 코드를 작성하고 유지할 필요가 없도록 합니다!  

주요 기능은 다음과 같습니다:  
- 간단하고 독립적이며 쉽게 커스터마이즈 가능한 학습 루프를 제공하며, 간단한 경우 즉시 사용 가능합니다;  
  동작은 상속 및/또는 콜백을 통해 커스터마이즈할 수 있습니다.  
- 장치 배치, 혼합 정밀도, DeepSpeed 통합, 다중 GPU 및 분산 학습을 코드 변경 없이 처리합니다.  
- 순수 PyTorch 구성 요소만 사용하며, 추가 수정이나 래퍼가 없고, [timm](https://github.com/rwightman/pytorch-image-models),  
  [transformers](https://huggingface.co/transformers/) 및 [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/) 같은  
  인기 라이브러리와 쉽게 연동됩니다.  
- 작고 간결한 API로 기존 PyTorch 사용자에게 최소한의 학습 곡선을 보장합니다.  

내부 및 외부 구성 요소를 포함한 라이브러리의 모든 부분이 최대한 명확하고 단순하도록 많은 노력을 기울였으며,  
커스터마이즈, 디버그 및 각 단계에서 무슨 일이 일어나는지 정확히 이해하기 쉽도록 설계되었습니다;  
트레이너의 대부분 동작은 단일 클래스에 포함되어 있습니다!  
Python의 정신에 따라 아무 것도 숨기지 않고 모든 것이 접근 가능합니다.  

`pytorch-accelerated`는 데이터 장치 간 이동 및 학습 구성 실행을 담당하는  
[Hugging Face Accelerate](https://github.com/huggingface/accelerate) 위에 투명하고 자랑스럽게 구축되었습니다.  
트레이너를 커스터마이즈하거나 학습을 시작할 때, 사용자는 [Accelerate 문서](https://huggingface.co/docs/accelerate/)를 참고하여  
모든 사용 가능한 옵션을 이해하는 것을 권장합니다; Accelerate는 텐서 수집과 그래디언트 클리핑과 같은 작업을 위한 편리한 함수들을 제공하며,  
이 함수들의 사용 예시는 `pytorch-accelerated` [예제](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) 폴더에서 확인할 수 있습니다!  

이 라이브러리의 동기와 자세한 시작 가이드를 알고 싶다면, [이 블로그 포스트](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968)를 참고하세요.  

## 설치

`pytorch-accelerated`는 다음 명령어로 pip에서 설치할 수 있습니다:



```
pip install pytorch-accelerated
```
패키지를 가능한 한 슬림하게 만들기 위해, 예제를 실행하는 데 필요한 패키지는 기본적으로 포함되어 있지 않습니다. 이러한 패키지를 포함하려면 다음 명령어를 사용할 수 있습니다:

```
pip install pytorch-accelerated[examples]
```

## 빠른 시작

시작하려면 아래 코드 조각에서 보여주는 것처럼 pytorch-accelerated `Trainer`를 가져와 사용하고,
그런 다음 아래에 설명된
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)를 사용하여 훈련을 시작하세요.


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
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)를 사용하여 
머신에서 훈련을 시작하려면 다음을 실행하세요:

` accelerate config --config_file accelerate_config.yaml`

그리고 질문에 답하세요. 이렇게 하면 기본 옵션을 적절히 설정하는 데 사용될 구성 파일이 생성됩니다.

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*참고*: [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)는 완전히 선택 사항이며,
훈련은 다음과 같이 일반적인 방법으로도 시작할 수 있습니다:

`python train.py` / `python -m torch.distributed ...`

이는 인프라 구성에 따라 다르며, 실행 명령을 더 세밀하게 제어하려는 사용자에게 적합합니다.

더 복잡한 훈련 예제는 examples 폴더에서 볼 수 있습니다
[여기](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples).

또는 핵심 개념을 먼저 이해하고 싶다면, [문서](https://pytorch-accelerated.readthedocs.io/en/latest/)에서 확인할 수 있습니다.

## 사용법

### pytorch-accelerated는 누구를 위한 것인가요?

- PyTorch에 익숙하지만 일반적인 훈련 루프의 보일러플레이트 코드를 작성하지 않고 훈련 루프의 흥미로운 부분에 집중하고 싶은 사용자.
- 자신만의 모델, 손실 함수, 옵티마이저 및 데이터셋을 선택하고 만드는 데 익숙하고 편한 사용자.
- 동작이 디버그, 이해 및 추론하기 쉽고 단순하고 간소화된 기능 세트를 중요하게 여기는 사용자.

### 언제 pytorch-accelerated를 사용하지 말아야 하나요?

- 데이터 로딩부터 추론까지 모든 것을 포함하는 엔드투엔드 솔루션을 찾고 있고, 모델, 옵티마이저 또는 손실 함수를 선택하는 데 도움을 받고 싶다면,
  아마도 [fastai](https://github.com/fastai/fastai)가 더 적합할 것입니다. `pytorch-accelerated`는 훈련 과정에만 집중하며,
  다른 모든 사항은 사용자의 책임으로 남겨둡니다.
- 전체 훈련 루프를 직접 작성하되, 장치 관리 문제만 없애고 싶다면,
  [Accelerate](https://github.com/huggingface/accelerate)를 직접 사용하는 것이 가장 좋습니다! `Trainer`의 모든 부분을 커스터마이징할 수는 있지만,
  훈련 루프는 근본적으로 여러 부분으로 나뉘어져 있습니다.



재정의해야 하는 다양한 메서드가 있을 것입니다. 하지만, 떠나기 전에, 그런 `for` 루프를 작성하는 것이 정말로 다시 *처음부터* 시작할 만큼 중요한가요 😉.
- 만약 일반적인 학습 루프 패턴에 맞지 않는 맞춤형, 매우 복잡한 사용 사례에 대해 작업 중이며 선택한 하드웨어에서 마지막 성능까지 최대한 끌어내고 싶다면, 아마도 일반 PyTorch를 사용하는 것이 가장 좋습니다; 고수준 API는 매우 특수화된 경우에 오버헤드가 될 수 있습니다!


## 감사의 글

`pytorch-accelerated`의 설계와 기능 뒤에는 [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) 및 [Hugging Face Accelerate](https://github.com/huggingface/accelerate)와 같은 여러 우수한 
라이브러리와 프레임워크에서 크게 영감을 받았습니다. 이 도구들은 이 라이브러리와 머신러닝 커뮤니티 모두에 엄청난 영향을 미쳤으며, 그 영향력은 아무리 강조해도 지나치지 않습니다!

`pytorch-accelerated`는 이러한 도구들로부터 영감을 받았으며, 포함된 모든 기능은 이 라이브러리에 이익이 되도록 처음부터 직접 구현되었습니다. 예외는 
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
폴더 내 일부 스크립트로, 기존 리소스를 가져와 수정하여 `pytorch-accelerated`의 기능을 보여주기 위한 경우입니다; 이러한 경우는 명확히 표시되어 있으며 원 저자에게 감사를 표하고 있습니다.










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---