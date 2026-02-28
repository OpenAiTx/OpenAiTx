
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

`pytorch-accelerated` to lekka biblioteka zaprojektowana, aby przyspieszyć proces trenowania modeli PyTorch
 poprzez udostępnienie minimalnej, ale rozszerzalnej pętli treningowej – zamkniętej w jednym obiekcie `Trainer` – 
która jest na tyle elastyczna, by obsłużyć większość przypadków użycia oraz pozwala na wykorzystanie różnych opcji sprzętowych
 bez konieczności zmiany kodu.
 
`pytorch-accelerated` oferuje uproszczony zestaw funkcji i kładzie ogromny nacisk na **prostotę** i **przejrzystość**,
aby umożliwić użytkownikom dokładne zrozumienie, co dzieje się "pod maską", ale bez konieczności pisania i utrzymywania kodu szablonowego samodzielnie!
   
Główne cechy to:
- Prosta i zamknięta, ale łatwo konfigurowalna pętla treningowa, która powinna działać od razu w prostych przypadkach;
 zachowanie można dostosować przy użyciu dziedziczenia i/lub callbacków.
- Obsługuje przypisywanie urządzeń, precyzję mieszaną, integrację z DeepSpeed, trening na wielu GPU i w trybie rozproszonym bez zmian w kodzie.
- Wykorzystuje czyste komponenty PyTorch, bez dodatkowych modyfikacji ani wrapperów, i łatwo współpracuje
 z innymi popularnymi bibliotekami, takimi jak [timm](https://github.com/rwightman/pytorch-image-models), 
 [transformers](https://huggingface.co/transformers/) oraz [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- Małe, uproszczone API zapewnia minimalną krzywą uczenia dla obecnych użytkowników PyTorch.

Włożono znaczący wysiłek, by każda część biblioteki – zarówno komponenty wewnętrzne, jak i zewnętrzne – była jak najprostsza i najbardziej przejrzysta,
co ułatwia dostosowanie, debugowanie i zrozumienie dokładnie tego, co dzieje się w tle na każdym etapie; większość
zachowań trenera jest zawarta w jednej klasie!
W duchu Pythona nic nie jest ukryte, wszystko jest dostępne.

`pytorch-accelerated` jest dumnie i transparentnie zbudowany na
bazie [Hugging Face Accelerate](https://github.com/huggingface/accelerate), który odpowiada za
przemieszczanie danych między urządzeniami i uruchamianie konfiguracji treningowych. Podczas dostosowywania trenera lub uruchamiania
treningu użytkownicy są zachęcani do zapoznania się z [dokumentacją Accelerate](https://huggingface.co/docs/accelerate/)
aby poznać wszystkie dostępne opcje; Accelerate zapewnia wygodne funkcje do operacji takich jak zbieranie tensorów
i obcinanie gradientów, których użycie można zobaczyć w folderze
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) `pytorch-accelerated`!

Aby dowiedzieć się więcej o motywacjach stojących za tą biblioteką oraz przeczytać szczegółowy przewodnik na start, sprawdź [ten wpis na blogu](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Instalacja

`pytorch-accelerated` można zainstalować z pip, korzystając z poniższego polecenia:
```
pip install pytorch-accelerated
```
Aby uczynić pakiet możliwie jak najbardziej smukłym, domyślnie nie są dołączone pakiety wymagane do uruchomienia przykładów. Aby dołączyć te pakiety, możesz użyć następującego polecenia:

```
pip install pytorch-accelerated[examples]
```

## Szybki start

Aby rozpocząć, po prostu zaimportuj i użyj `Trainer` z pytorch-accelerated, jak pokazano w poniższym fragmencie,
a następnie uruchom trening, korzystając z 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
opisanego poniżej.

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
Aby uruchomić trening za pomocą [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, na swoim komputerze/komputerach uruchom:

` accelerate config --config_file accelerate_config.yaml`

i odpowiedz na zadane pytania. To wygeneruje plik konfiguracyjny, który zostanie użyty do poprawnego ustawienia domyślnych opcji podczas uruchamiania

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Uwaga*: Użycie [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) jest całkowicie opcjonalne, trening można również uruchomić w tradycyjny sposób używając:

`python train.py` / `python -m torch.distributed ...`

w zależności od konfiguracji infrastruktury, dla użytkowników, którzy chcą mieć większą kontrolę 
nad poleceniem uruchamiającym.

Bardziej złożone przykłady treningu można zobaczyć w folderze examples 
[tu](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples). 

Alternatywnie, jeśli wolisz najpierw poznać podstawowe pojęcia, znajdziesz je w [dokumentacji](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Użycie

### Do kogo skierowany jest pytorch-accelerated?

- Do użytkowników zaznajomionych z PyTorch, którzy chcą uniknąć pisania typowej powtarzalnej pętli treningowej
aby skupić się na ciekawszych aspektach treningu.
- Do użytkowników, którzy lubią i potrafią samodzielnie wybierać oraz tworzyć własne modele, funkcje straty, optymalizatory i zbiory danych.
- Do użytkowników ceniących sobie prostotę i przejrzysty zestaw funkcji, gdzie zachowanie jest łatwe do debugowania, zrozumienia i przewidzenia!

### Kiedy nie powinieneś używać pytorch-accelerated?

- Jeśli szukasz kompletnego rozwiązania od końca do końca, obejmującego wszystko od ładowania danych po inferencję,
  pomagającego w wyborze modelu, optymalizatora lub funkcji straty, prawdopodobnie lepszym wyborem będzie
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` skupia się wyłącznie na procesie treningowym, pozostawiając całą resztę
  po stronie użytkownika.
- Jeśli chciałbyś samodzielnie napisać całą pętlę treningową, ale bez wszystkich problemów z zarządzaniem urządzeniami,
najlepiej będzie bezpośrednio użyć [Accelerate](https://github.com/huggingface/accelerate)! Chociaż możliwa jest pełna personalizacja `Trainer`, pętla treningowa jest zasadniczo podzielona na kilka 


różne metody, które musiałbyś nadpisać. Ale zanim pójdziesz, czy naprawdę pisanie tych pętli `for` jest aż tak ważne, żeby *znowu* zaczynać od zera 😉.
- Jeśli pracujesz nad niestandardowym, bardzo złożonym przypadkiem użycia, który nie pasuje do wzorców typowych pętli treningowych
i chcesz wycisnąć maksimum wydajności z wybranego sprzętu, prawdopodobnie najlepiej będzie pozostać przy czystym PyTorch; każda wysokopoziomowa API staje się narzutem w wysoce wyspecjalizowanych przypadkach!


## Podziękowania

Wiele aspektów projektowych i funkcjonalnych `pytorch-accelerated` zostało silnie zainspirowanych przez znakomite 
biblioteki i frameworki takie jak [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) oraz [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Każde z tych narzędzi 
wywarło ogromny wpływ zarówno na tę bibliotekę, jak i na społeczność uczenia maszynowego, i ich wpływ nie może być 
wystarczająco doceniony!

`pytorch-accelerated` czerpał jedynie inspirację z tych narzędzi, a cała zawarta funkcjonalność została zaimplementowana
od zera w sposób korzystny dla tej biblioteki. Jedynymi wyjątkami są niektóre skrypty w folderze 
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples),
w których wykorzystano i zmodyfikowano istniejące zasoby, aby zaprezentować możliwości `pytorch-accelerated`;
te przypadki są wyraźnie oznaczone, z podaniem uznania dla oryginalnych autorów.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---