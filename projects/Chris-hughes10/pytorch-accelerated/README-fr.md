
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=en">Anglais</a>
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

`pytorch-accelerated` est une bibliothèque légère conçue pour accélérer le processus d'entraînement des modèles PyTorch
 en fournissant une boucle d'entraînement minimale mais extensible - encapsulée dans un objet unique `Trainer`
qui est suffisamment flexible pour gérer la majorité des cas d'utilisation, et capable d'utiliser différents matériels
 sans nécessiter de modification du code.
 
`pytorch-accelerated` offre un ensemble de fonctionnalités simplifiées, et accorde une grande importance à la **simplicité** et à la **transparence**,
pour permettre aux utilisateurs de comprendre exactement ce qui se passe sous le capot, mais sans avoir à écrire et maintenir eux-mêmes le code standard !
   
Les principales fonctionnalités sont :
- Une boucle d'entraînement simple et contenue, mais facilement personnalisable, qui devrait fonctionner dès la sortie de la boîte dans les cas simples ;
 le comportement peut être personnalisé via l'héritage et/ou des callbacks.
- Gère le placement des appareils, la précision mixte, l'intégration DeepSpeed, l'entraînement multi-GPU et distribué sans modification du code.
- Utilise des composants PyTorch purs, sans modifications ou wrappers supplémentaires, et s'interopère facilement
 avec d'autres bibliothèques populaires telles que [timm](https://github.com/rwightman/pytorch-image-models), 
 [transformers](https://huggingface.co/transformers/) et [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- Une API petite et épurée garantit une courbe d'apprentissage minimale pour les utilisateurs PyTorch existants.

Un effort important a été fait pour garantir que chaque partie de la bibliothèque - composants internes et externes - soit aussi claire et simple que possible,
rendant facile la personnalisation, le débogage et la compréhension exacte de ce qui se passe en coulisses à chaque étape ; la plupart du
comportement de l'entraîneur est contenu dans une seule classe !
Dans l'esprit de Python, rien n'est caché et tout est accessible.

`pytorch-accelerated` est fièrement et transparent construit sur 
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), qui est responsable du
transfert des données entre appareils et du lancement des configurations d'entraînement. Lors de la personnalisation de l'entraîneur, ou du lancement
de l'entraînement, il est conseillé aux utilisateurs de consulter la [documentation Accelerate](https://huggingface.co/docs/accelerate/)
pour comprendre toutes les options disponibles ; Accelerate fournit des fonctions pratiques pour des opérations telles que la collecte de tenseurs
et la coupure de gradient, dont l'utilisation peut être vue dans le dossier 
[exemples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) de `pytorch-accelerated` !

Pour en savoir plus sur les motivations derrière cette bibliothèque, ainsi qu'un guide détaillé pour bien démarrer, consultez [cet article de blog](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Installation

`pytorch-accelerated` peut être installé via pip en utilisant la commande suivante :
```
pip install pytorch-accelerated
```

Pour rendre le package aussi léger que possible, les packages nécessaires pour exécuter les exemples ne sont pas inclus par défaut. Pour inclure ces packages, vous pouvez utiliser la commande suivante :
```
pip install pytorch-accelerated[examples]
```

## Démarrage rapide

Pour commencer, importez simplement et utilisez le `Trainer` accéléré par pytorch, comme démontré dans l'extrait suivant,
puis lancez l'entraînement en utilisant la 
[CLI accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
décrite ci-dessous.

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
Pour lancer l'entraînement en utilisant le [CLI accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, sur votre(s) machine(s), exécutez :

` accelerate config --config_file accelerate_config.yaml`

et répondez aux questions posées. Cela générera un fichier de configuration qui sera utilisé pour définir correctement les options par défaut lors de l'exécution de

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Note* : L'utilisation du [CLI accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) est totalement optionnelle, l'entraînement peut également être lancé de la manière habituelle via :

`python train.py` / `python -m torch.distributed ...`

selon la configuration de votre infrastructure, pour les utilisateurs qui souhaitent garder un contrôle plus précis
sur la commande de lancement.

Des exemples d'entraînement plus complexes sont disponibles dans le dossier examples
[ici](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples).

Alternativement, si vous préférez comprendre d'abord les concepts de base, vous pouvez les trouver dans la [documentation](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Utilisation

### À qui s'adresse pytorch-accelerated ?

- Aux utilisateurs familiers avec PyTorch mais qui souhaitent éviter d'écrire la structure standard de la boucle d'entraînement
pour se concentrer sur les parties intéressantes de la boucle d'entraînement.
- Aux utilisateurs qui aiment, et sont à l'aise avec, la sélection et la création de leurs propres modèles, fonctions de perte, optimiseurs et ensembles de données.
- Aux utilisateurs qui apprécient un ensemble de fonctionnalités simple et épuré, où le comportement est facile à déboguer, comprendre et analyser !

### Quand ne devrais-je pas utiliser pytorch-accelerated ?

- Si vous cherchez une solution complète, couvrant tout depuis le chargement des données jusqu'à l'inférence,
  qui vous aide à sélectionner un modèle, un optimiseur ou une fonction de perte, vous seriez probablement mieux servi par
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` se concentre uniquement sur le processus d'entraînement, toutes les autres
  préoccupations restant de la responsabilité de l'utilisateur.
- Si vous souhaitez écrire vous-même toute la boucle d'entraînement, simplement sans toutes les complications liées à la gestion des appareils,
vous seriez probablement mieux servi en utilisant directement [Accelerate](https://github.com/huggingface/accelerate) ! Bien qu'il
soit possible de personnaliser chaque partie du `Trainer`, la boucle d'entraînement est fondamentalement découpée en un certain nombre de

différentes méthodes que vous devrez surcharger. Mais, avant de partir, est-ce que l'écriture de ces boucles `for` est vraiment assez importante  
pour justifier de repartir de zéro *encore* 😉.  
- Si vous travaillez sur un cas d'utilisation personnalisé, très complexe, qui ne correspond pas aux schémas habituels des boucles d'entraînement  
et que vous souhaitez exploiter chaque dernier bit de performance sur votre matériel choisi, il est probablement préférable de rester  
avec PyTorch vanilla ; toute API de haut niveau devient une surcharge dans les cas hautement spécialisés !  


## Remerciements  

De nombreux aspects derrière la conception et les fonctionnalités de `pytorch-accelerated` ont été grandement inspirés par un certain nombre d'excellentes  
bibliothèques et frameworks tels que [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models),  
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) et [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Chacun de ces outils  
a eu un impact énorme à la fois sur cette bibliothèque et sur la communauté de l'apprentissage automatique, et leur influence ne peut  
être assez soulignée !  

`pytorch-accelerated` s'est inspiré uniquement de ces outils, et toute la fonctionnalité contenue a été implémentée  
à partir de zéro de manière à bénéficier à cette bibliothèque. Les seules exceptions sont certains scripts dans le  
[dossier examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)  
dans lesquels des ressources existantes ont été prises et modifiées afin de présenter les fonctionnalités de `pytorch-accelerated` ;  
ces cas sont clairement indiqués, avec une reconnaissance donnée aux auteurs originaux.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---