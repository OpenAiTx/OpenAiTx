
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

`pytorch-accelerated` è una libreria leggera progettata per accelerare il processo di addestramento dei modelli PyTorch
 fornendo un ciclo di addestramento minimale ma estensibile - racchiuso in un unico oggetto `Trainer` -
che è sufficientemente flessibile per gestire la maggior parte dei casi d'uso, e in grado di sfruttare diverse opzioni hardware
 senza necessità di modifiche al codice.
 
`pytorch-accelerated` offre un set di funzionalità essenziale e pone grande enfasi su **semplicità** e **trasparenza**,
per consentire agli utenti di capire esattamente cosa sta succedendo sotto il cofano, ma senza dover scrivere e mantenere loro stessi il boilerplate!
   
Le caratteristiche principali sono:
- Un ciclo di addestramento semplice e contenuto, ma facilmente personalizzabile, che dovrebbe funzionare subito nei casi più semplici;
 il comportamento può essere personalizzato tramite ereditarietà e/o callback.
- Gestisce il posizionamento dei dispositivi, la mixed-precision, l'integrazione DeepSpeed, il training multi-GPU e distribuito senza modifiche al codice.
- Utilizza componenti PyTorch puri, senza modifiche o wrapper aggiuntivi, e si integra facilmente
 con altre librerie popolari come [timm](https://github.com/rwightman/pytorch-image-models),
 [transformers](https://huggingface.co/transformers/) e [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- Una piccola e snella API assicura una curva di apprendimento minima per gli utenti PyTorch già esistenti.

È stato fatto un grande sforzo per garantire che ogni parte della libreria - sia i componenti interni che quelli esterni - sia il più chiara e semplice possibile,
rendendo facile la personalizzazione, il debug e la comprensione di ciò che accade dietro le quinte ad ogni passo; la maggior parte del
comportamento del trainer è contenuto in una singola classe!
Nello spirito di Python, nulla è nascosto e tutto è accessibile.

`pytorch-accelerated` è orgogliosamente e trasparentemente costruito sopra
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), che si occupa
dello spostamento dei dati tra i dispositivi e dell'avvio delle configurazioni di addestramento. Quando si personalizza il trainer o si avvia
l'addestramento, si consiglia agli utenti di consultare la [documentazione di Accelerate](https://huggingface.co/docs/accelerate/)
per comprendere tutte le opzioni disponibili; Accelerate fornisce funzioni comode per operazioni come il raggruppamento dei tensori
e il clipping dei gradienti, il cui utilizzo può essere visto nella cartella `pytorch-accelerated`
[esempi](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)!

Per saperne di più sulle motivazioni che stanno dietro questa libreria, insieme a una guida dettagliata per iniziare, dai un'occhiata a [questo post sul blog](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Installazione

`pytorch-accelerated` può essere installato tramite pip usando il seguente comando:
```
pip install pytorch-accelerated
```

Per rendere il pacchetto il più snello possibile, i pacchetti necessari per eseguire gli esempi non sono inclusi di default. Per includere questi pacchetti, puoi usare il seguente comando:
```
pip install pytorch-accelerated[examples]
```

## Guida rapida

Per iniziare, importa e utilizza semplicemente il `Trainer` di pytorch-accelerated, come mostrato nel seguente esempio,
e poi avvia l’addestramento utilizzando la 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
descritta di seguito.

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
Per avviare l'addestramento utilizzando la [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, sulla/le tua/e macchina/e, esegui:

` accelerate config --config_file accelerate_config.yaml`

e rispondi alle domande poste. Questo genererà un file di configurazione che verrà utilizzato per impostare correttamente le opzioni predefinite durante

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Nota*: L'utilizzo della [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) è completamente opzionale, l'addestramento può anche essere avviato nel modo consueto usando:

`python train.py` / `python -m torch.distributed ...`

a seconda della configurazione della tua infrastruttura, per utenti che desiderano mantenere un controllo più dettagliato 
sul comando di avvio.

Esempi di addestramento più complessi possono essere visti nella cartella degli esempi 
[qui](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples). 

In alternativa, se preferisci prima comprendere i concetti fondamentali, questi si trovano nella [documentazione](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Utilizzo

### A chi è rivolto pytorch-accelerated?

- Utenti che hanno familiarità con PyTorch ma vorrebbero evitare di scrivere il boilerplate del ciclo di addestramento comune
per concentrarsi sulle parti interessanti del ciclo di training.
- Utenti che apprezzano, e sono a loro agio, nel selezionare e creare i propri modelli, funzioni di perdita, ottimizzatori e dataset.
- Utenti che valorizzano un set di funzionalità semplice e snello, dove il comportamento è facile da debug, comprendere e motivare!

### Quando non dovrei usare pytorch-accelerated?

- Se stai cercando una soluzione end-to-end, che comprenda tutto dal caricamento dati all'inferenza,
  che ti aiuti a selezionare un modello, ottimizzatore o funzione di perdita, probabilmente sarai più adatto a
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` si concentra solo sul processo di addestramento, con tutte le altre
  problematiche lasciate alla responsabilità dell'utente.
- Se vorresti scrivere l'intero ciclo di addestramento tu stesso, solo senza tutte le difficoltà di gestione dei dispositivi, 
probabilmente ti troverai meglio usando direttamente [Accelerate](https://github.com/huggingface/accelerate)! Anche se
è possibile personalizzare ogni parte del `Trainer`, il ciclo di addestramento è fondamentalmente suddiviso in numerose

diversi metodi che dovresti sovrascrivere. Ma, prima di andare, scrivere quei cicli `for` è davvero così importante 
da giustificare il ricominciare *da capo* un'altra volta 😉.
- Se stai lavorando su un caso d'uso personalizzato, altamente complesso, che non si adatta agli schemi dei soliti cicli di addestramento
e vuoi ottenere ogni minimo incremento di performance sull'hardware scelto, probabilmente la soluzione migliore è restare
 con il PyTorch “vanilla”; qualsiasi API ad alto livello diventa un sovraccarico in casi altamente specializzati!

## Ringraziamenti

Molti aspetti del design e delle funzionalità di `pytorch-accelerated` sono stati fortemente ispirati da numerose eccellenti 
librerie e framework come [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) e [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Ognuno di questi strumenti 
ha avuto un impatto enorme sia su questa libreria che sulla comunità del machine learning, e la loro influenza non può essere 
sottolineata abbastanza!

`pytorch-accelerated` ha preso solo ispirazione da questi strumenti, e tutte le funzionalità incluse sono state implementate
 da zero in modo da avvantaggiare questa libreria. Le uniche eccezioni sono alcuni degli script nella cartella 
 [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
 in cui sono state prese e modificate risorse esistenti per mostrare le funzionalità di `pytorch-accelerated`;
 questi casi sono chiaramente segnalati, con riconoscimento dato agli autori originali.
 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---