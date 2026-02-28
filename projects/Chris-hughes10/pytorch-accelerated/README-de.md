
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# pytorch-accelerated

`pytorch-accelerated` ist eine schlanke Bibliothek, die entwickelt wurde, um den Trainingsprozess von PyTorch-Modellen zu beschleunigen,
 indem sie eine minimale, aber erweiterbare Trainingsschleife bereitstellt – gekapselt in einem einzelnen `Trainer`-
Objekt –, das flexibel genug ist, um die meisten Anwendungsfälle abzudecken und verschiedene Hardwareoptionen
 ohne Codeänderungen nutzen kann.
 
`pytorch-accelerated` bietet einen schlanken Funktionsumfang und legt großen Wert auf **Einfachheit** und **Transparenz**,
um den Nutzern zu ermöglichen, genau zu verstehen, was im Hintergrund passiert, ohne jedoch selbst das Boilerplate schreiben und pflegen zu müssen!
   
Die wichtigsten Merkmale sind:
- Eine einfache und abgeschlossene, aber leicht anpassbare Trainingsschleife, die in unkomplizierten Fällen direkt einsatzbereit ist;
 das Verhalten kann durch Vererbung und/oder Callbacks angepasst werden.
- Behandelt Geräteplatzierung, Mixed Precision, DeepSpeed-Integration, Multi-GPU und verteiltes Training ohne Codeänderungen.
- Verwendet reine PyTorch-Komponenten, ohne zusätzliche Modifikationen oder Wrapper, und ist leicht kompatibel
 mit anderen beliebten Bibliotheken wie [timm](https://github.com/rwightman/pytorch-image-models),
 [transformers](https://huggingface.co/transformers/) und [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- Eine kleine, schlanke API stellt sicher, dass die Lernkurve für bestehende PyTorch-Nutzer minimal bleibt.

Es wurde erheblicher Aufwand betrieben, um sicherzustellen, dass jeder Teil der Bibliothek – sowohl interne als auch externe Komponenten – so klar und einfach wie möglich ist,
was die Anpassung, das Debugging und das Verständnis der Abläufe hinter den Kulissen in jedem Schritt erleichtert; das meiste
Verhalten des Trainers ist in einer einzigen Klasse enthalten!
Im Sinne von Python wird nichts versteckt und alles ist zugänglich.

`pytorch-accelerated` baut stolz und transparent auf
[Hugging Face Accelerate](https://github.com/huggingface/accelerate) auf, das für die
Datenbewegung zwischen Geräten und das Starten von Trainingskonfigurationen verantwortlich ist. Beim Anpassen des Trainers oder Starten
des Trainings sollten Nutzer die [Accelerate-Dokumentation](https://huggingface.co/docs/accelerate/)
konsultieren, um alle verfügbaren Optionen zu verstehen; Accelerate bietet praktische Funktionen für Operationen wie das Sammeln von Tensoren
und Gradient Clipping, deren Verwendung im `pytorch-accelerated`
[Beispiele](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) Ordner zu sehen ist!

Um mehr über die Beweggründe hinter dieser Bibliothek zu erfahren und eine ausführliche Einstiegshilfe zu erhalten, lesen Sie [diesen Blogbeitrag](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Installation

`pytorch-accelerated` kann mit folgendem Befehl über pip installiert werden:
```
pip install pytorch-accelerated
```
Um das Paket so schlank wie möglich zu halten, sind die für die Ausführung der Beispiele benötigten Pakete standardmäßig nicht enthalten. Um diese Pakete einzubinden, können Sie den folgenden Befehl verwenden:

```
pip install pytorch-accelerated[examples]
```

## Schnellstart

Um zu beginnen, importieren und verwenden Sie einfach den pytorch-accelerated `Trainer`, wie im folgenden Beispiel gezeigt,
und starten Sie dann das Training mit dem 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script),
wie unten beschrieben.

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
Um das Training mit der [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
zu starten, führen Sie auf Ihrer(n) Maschine(n) Folgendes aus:

` accelerate config --config_file accelerate_config.yaml`

und beantworten Sie die gestellten Fragen. Dies erzeugt eine Konfigurationsdatei, die verwendet wird, um die Standardoptionen korrekt einzustellen, wenn Sie

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Hinweis*: Die Verwendung der [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) ist völlig optional, das Training kann auch auf herkömmliche Weise gestartet werden mit:

`python train.py` / `python -m torch.distributed ...`

abhängig von Ihrer Infrastruktur-Konfiguration, für Benutzer, die einen feineren Kontrollgrad über den Startbefehl
beibehalten möchten.

Komplexere Trainingsbeispiele finden Sie im Beispiel-Ordner
[hier](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples).

Alternativ, falls Sie die Kernkonzepte zuerst verstehen möchten, finden Sie diese in der [Dokumentation](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Verwendung

### Für wen ist pytorch-accelerated gedacht?

- Benutzer, die mit PyTorch vertraut sind, aber das Schreiben der üblichen Trainingsschleifen-Boilerplate vermeiden möchten,
um sich auf die interessanten Teile der Trainingsschleife zu konzentrieren.
- Benutzer, die gerne und sicher darin sind, eigene Modelle, Loss-Funktionen, Optimierer und Datensätze auszuwählen und zu erstellen.
- Benutzer, die ein einfaches und übersichtliches Funktionsangebot schätzen, bei dem das Verhalten leicht zu debuggen, zu verstehen und nachzuvollziehen ist!

### Wann sollte ich pytorch-accelerated nicht verwenden?

- Wenn Sie nach einer End-to-End-Lösung suchen, die alles vom Laden der Daten bis zur Inferenz umfasst,
  und Ihnen hilft, ein Modell, einen Optimierer oder eine Loss-Funktion auszuwählen, sind Sie vermutlich mit
  [fastai](https://github.com/fastai/fastai) besser beraten. `pytorch-accelerated` konzentriert sich ausschließlich auf den Trainingsprozess, alle anderen
  Aspekte liegen in der Verantwortung des Benutzers.
- Wenn Sie die gesamte Trainingsschleife selbst schreiben möchten, nur ohne all die Kopfschmerzen im Gerätemanagement,
sind Sie vermutlich am besten beraten, [Accelerate](https://github.com/huggingface/accelerate) direkt zu verwenden! Während es
möglich ist, jeden Teil des `Trainer` anzupassen, ist die Trainingsschleife grundsätzlich in mehrere

verschiedene Methoden, die Sie überschreiben müssten. Aber bevor Sie gehen, ist das Schreiben dieser `for`-Schleifen wirklich so wichtig, 
dass es einen Neustart *schon wieder* 😉 rechtfertigt?
- Wenn Sie an einem benutzerdefinierten, hochkomplexen Anwendungsfall arbeiten, der nicht den Mustern gewöhnlicher Trainingsschleifen entspricht
und jede letzte Leistungsreserve aus Ihrer gewählten Hardware herausholen möchten, sind Sie wahrscheinlich am besten beraten, 
bei Vanilla PyTorch zu bleiben; jede High-Level-API wird in hochspezialisierten Fällen zum Overhead!

## Danksagungen

Viele Aspekte des Designs und der Funktionen von `pytorch-accelerated` wurden stark durch eine Reihe ausgezeichneter 
Bibliotheken und Frameworks wie [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) und [Hugging Face Accelerate](https://github.com/huggingface/accelerate) inspiriert. Jedes dieser Tools 
hat sowohl auf diese Bibliothek als auch auf die Machine-Learning-Community einen enormen Einfluss gehabt und ihre Bedeutung 
kann gar nicht genug betont werden!

`pytorch-accelerated` hat sich nur von diesen Tools inspirieren lassen, und sämtliche enthaltene Funktionalität wurde 
von Grund auf so implementiert, dass sie dieser Bibliothek zugutekommt. Die einzigen Ausnahmen hiervon sind einige Skripte im 
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
Ordner, in denen bestehende Ressourcen übernommen und modifiziert wurden, um die Funktionen von `pytorch-accelerated` zu präsentieren;
diese Fälle sind klar gekennzeichnet, wobei den ursprünglichen Autoren Anerkennung gezollt wird.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---