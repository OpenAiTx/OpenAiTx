
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# pytorch-accelerated

`pytorch-accelerated` is een lichte bibliotheek ontworpen om het trainen van PyTorch-modellen te versnellen
 door een minimale, maar uitbreidbare trainingslus te bieden - verpakt in één `Trainer`
object - die flexibel genoeg is om de meeste gebruikssituaties aan te kunnen, en in staat is om verschillende hardware
opties te gebruiken zonder dat er codewijzigingen nodig zijn.
 
`pytorch-accelerated` biedt een gestroomlijnd functieset en legt een grote nadruk op **eenvoud** en **transparantie**,
om gebruikers in staat te stellen precies te begrijpen wat er onder de motorkap gebeurt, maar zonder dat ze zelf de boilerplate hoeven te schrijven en onderhouden!
   
De belangrijkste kenmerken zijn:
- Een eenvoudige en overzichtelijke, maar gemakkelijk aanpasbare trainingslus, die direct uit de doos zou moeten werken in eenvoudige gevallen;
 het gedrag kan worden aangepast met behulp van overerving en/of callbacks.
- Regelt apparaatplaatsing, mixed-precision, DeepSpeed-integratie, multi-GPU en gedistribueerde training zonder codewijzigingen.
- Gebruikt pure PyTorch-componenten, zonder extra aanpassingen of wrappers, en werkt eenvoudig samen
 met andere populaire libraries zoals [timm](https://github.com/rwightman/pytorch-image-models), 
 [transformers](https://huggingface.co/transformers/) en [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- Een kleine, gestroomlijnde API zorgt ervoor dat er een minimale leercurve is voor bestaande PyTorch-gebruikers.

Er is veel moeite gedaan om ervoor te zorgen dat elk deel van de library - zowel interne als externe componenten - zo duidelijk en eenvoudig mogelijk is, 
waardoor het gemakkelijk is om aan te passen, te debuggen en precies te begrijpen wat er achter de schermen gebeurt bij elke stap; het grootste deel van het 
gedrag van de trainer zit in een enkele klasse!
In de geest van Python wordt niets verborgen en is alles toegankelijk.

`pytorch-accelerated` is trots en transparant gebouwd bovenop 
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), dat verantwoordelijk is voor de 
verplaatsing van data tussen apparaten en het starten van trainingsconfiguraties. Bij het aanpassen van de trainer, of het starten van
training, worden gebruikers aangemoedigd om de [Accelerate documentatie](https://huggingface.co/docs/accelerate/) 
te raadplegen om alle beschikbare opties te begrijpen; Accelerate biedt handige functies voor operaties zoals het verzamelen van tensors 
en gradient clipping, waarvan het gebruik te zien is in de `pytorch-accelerated` 
[voorbeelden](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) map!

Om meer te weten te komen over de motivaties achter deze library, samen met een gedetailleerde introductiegids, bekijk [deze blogpost](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Installatie

`pytorch-accelerated` kan worden geïnstalleerd via pip met het volgende commando:
```
pip install pytorch-accelerated
```
Om het pakket zo slank mogelijk te houden, zijn de pakketten die nodig zijn om de voorbeelden uit te voeren niet standaard inbegrepen. Om deze pakketten toe te voegen, kunt u de volgende opdracht gebruiken:

```
pip install pytorch-accelerated[examples]
```

## Snelstart

Om aan de slag te gaan, importeer en gebruik je eenvoudig de pytorch-accelerated `Trainer`, zoals getoond in het volgende fragment,
en start vervolgens de training met de 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
zoals hieronder beschreven.

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

Om training te starten met behulp van de [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, voer op je machine(s) het volgende uit:

` accelerate config --config_file accelerate_config.yaml`

en beantwoord de gestelde vragen. Dit genereert een configuratiebestand dat gebruikt zal worden om de standaardopties correct in te stellen bij

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Opmerking*: Het gebruik van de [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) is volledig optioneel, training kan ook op de gebruikelijke manier worden gestart met:

`python train.py` / `python -m torch.distributed ...`

afhankelijk van je infrastructuurconfiguratie, voor gebruikers die graag meer gedetailleerde controle willen 
over het startcommando.

Meer complexe trainingsvoorbeelden zijn te vinden in de examples-map 
[hier](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples). 

Als je liever eerst de kernconcepten wilt begrijpen, kun je deze vinden in de [documentatie](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Gebruik

### Voor wie is pytorch-accelerated bedoeld?

- Gebruikers die bekend zijn met PyTorch maar het schrijven van de standaard trainingsloop-boilerplate willen vermijden
om zich te kunnen richten op de interessante delen van de trainingsloop.
- Gebruikers die graag hun eigen modellen, verliesfuncties, optimalisatoren en datasets kiezen en samenstellen.
- Gebruikers die waarde hechten aan een eenvoudige en gestroomlijnde feature set, waarbij het gedrag makkelijk te debuggen, te begrijpen en te doorgronden is!

### Wanneer kun je pytorch-accelerated beter niet gebruiken?

- Als je op zoek bent naar een end-to-end oplossing, van het laden van data tot inferentie,
  die je helpt bij het kiezen van een model, optimizer of verliesfunctie, ben je waarschijnlijk beter af met
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` richt zich alleen op het trainingsproces, waarbij alle andere
  aspecten aan de gebruiker worden overgelaten.
- Als je graag zelf de volledige trainingsloop wilt schrijven, maar zonder al het device-management gedoe, 
ben je waarschijnlijk het beste af met [Accelerate](https://github.com/huggingface/accelerate) direct! Hoewel het
mogelijk is om elk onderdeel van de `Trainer` aan te passen, wordt de trainingsloop in de basis opgedeeld in een aantal 
verschillende methoden die je zou moeten overschrijven. Maar voordat je vertrekt, is het schrijven van die `for`-lussen echt belangrijk genoeg om *weer* helemaal opnieuw te beginnen 😉.
- Als je werkt aan een aangepaste, zeer complexe use-case die niet past binnen de patronen van de gebruikelijke trainingslussen en je wilt elk beetje prestatie uit je gekozen hardware halen, kun je waarschijnlijk het beste bij vanilla PyTorch blijven; elke high-level API wordt een overhead in sterk gespecialiseerde gevallen!


## Dankbetuigingen

Veel aspecten achter het ontwerp en de functies van `pytorch-accelerated` zijn sterk geïnspireerd door een aantal uitstekende bibliotheken en frameworks zoals [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), [PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) en [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Elk van deze tools heeft een enorme impact gehad op zowel deze bibliotheek als de machine learning community, en hun invloed kan niet genoeg worden benadrukt!

`pytorch-accelerated` heeft alleen inspiratie uit deze tools gehaald, en alle functionaliteit is volledig opnieuw geïmplementeerd op een manier die voordelig is voor deze bibliotheek. De enige uitzonderingen hierop zijn sommige scripts in de map [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) waarin bestaande resources zijn gebruikt en aangepast om de mogelijkheden van `pytorch-accelerated` te demonstreren; deze gevallen zijn duidelijk gemarkeerd, met erkenning aan de oorspronkelijke auteurs.














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---