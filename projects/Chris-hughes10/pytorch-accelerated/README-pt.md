
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

`pytorch-accelerated` é uma biblioteca leve projetada para acelerar o processo de treinamento de modelos PyTorch
 fornecendo um loop de treinamento minimalista, mas extensível - encapsulado em um único objeto `Trainer`
- que é flexível o suficiente para lidar com a maioria dos casos de uso e capaz de utilizar diferentes opções de hardware
 sem necessidade de alterações no código.
 
`pytorch-accelerated` oferece um conjunto de recursos simplificado e dá grande ênfase à **simplicidade** e **transparência**,
para permitir que os usuários compreendam exatamente o que está acontecendo nos bastidores, mas sem precisar escrever e manter o código repetitivo eles mesmos!

Os principais recursos são:
- Um loop de treinamento simples e contido, mas facilmente personalizável, que deve funcionar imediatamente em casos simples;
 o comportamento pode ser personalizado usando herança e/ou callbacks.
- Gerencia alocação de dispositivo, precisão mista, integração com DeepSpeed, treinamento multi-GPU e distribuído sem necessidade de alterações no código.
- Usa componentes puros do PyTorch, sem modificações ou wrappers adicionais, e interopera facilmente
 com outras bibliotecas populares como [timm](https://github.com/rwightman/pytorch-image-models),
 [transformers](https://huggingface.co/transformers/) e [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- Uma API pequena e enxuta garante uma curva de aprendizado mínima para usuários já familiarizados com PyTorch.

Um esforço significativo foi feito para garantir que cada parte da biblioteca – tanto componentes internos quanto externos – seja o mais clara e simples possível,
tornando fácil personalizar, depurar e entender exatamente o que está acontecendo nos bastidores em cada etapa; a maior parte do
comportamento do treinador está contido em uma única classe!
No espírito do Python, nada é escondido e tudo é acessível.

O `pytorch-accelerated` é construído de forma orgulhosa e transparente sobre
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), que é responsável pelo
movimento dos dados entre dispositivos e inicialização das configurações de treinamento. Ao customizar o treinador ou iniciar
o treinamento, os usuários são incentivados a consultar a [documentação do Accelerate](https://huggingface.co/docs/accelerate/)
para entender todas as opções disponíveis; o Accelerate fornece funções convenientes para operações como agregação de tensores
e clipping de gradiente, cujo uso pode ser visto na pasta de
[exemplos](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) do `pytorch-accelerated`!

Para saber mais sobre as motivações por trás desta biblioteca, junto com um guia detalhado de introdução, confira [este post no blog](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Instalação

`pytorch-accelerated` pode ser instalado via pip usando o seguinte comando:
```
pip install pytorch-accelerated
```

Para tornar o pacote o mais enxuto possível, os pacotes necessários para executar os exemplos não são incluídos por padrão. Para incluir esses pacotes, você pode usar o seguinte comando:
```
pip install pytorch-accelerated[examples]
```

## Início Rápido

Para começar, basta importar e usar o `Trainer` do pytorch-accelerated, como demonstrado no trecho a seguir,
e então iniciar o treinamento usando o 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
descrito abaixo.

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
Para iniciar o treinamento usando o [CLI do accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, na(s) sua(s) máquina(s), execute:

` accelerate config --config_file accelerate_config.yaml`

e responda às perguntas feitas. Isso irá gerar um arquivo de configuração que será usado para definir corretamente as opções padrão ao executar

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Nota*: Utilizar o [CLI do accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) é completamente opcional, o treinamento também pode ser iniciado da maneira usual utilizando:

`python train.py` / `python -m torch.distributed ...`

dependendo da configuração da sua infraestrutura, para usuários que desejam manter um controle mais detalhado
sobre o comando de inicialização.

Exemplos de treinamento mais complexos podem ser vistos na pasta de exemplos
[aqui](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples).

Alternativamente, se preferir entender os conceitos principais primeiro, isso pode ser encontrado na [documentação](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Uso

### Para quem o pytorch-accelerated é indicado?

- Usuários que estão familiarizados com PyTorch, mas gostariam de evitar ter que escrever o código repetitivo comum do loop de treinamento
para se concentrar nas partes interessantes do loop de treinamento.
- Usuários que gostam, e se sentem confortáveis, em selecionar e criar seus próprios modelos, funções de perda, otimizadores e conjuntos de dados.
- Usuários que valorizam um conjunto de funcionalidades simples e direto, onde o comportamento é fácil de depurar, entender e raciocinar!

### Quando não devo usar o pytorch-accelerated?

- Se você está procurando uma solução completa de ponta a ponta, abrangendo tudo desde o carregamento dos dados até a inferência,
  que te ajude a selecionar um modelo, otimizador ou função de perda, provavelmente você se adaptaria melhor ao
  [fastai](https://github.com/fastai/fastai). O `pytorch-accelerated` foca apenas no processo de treinamento, deixando todas as outras
  responsabilidades ao usuário.
- Se você gostaria de escrever todo o loop de treinamento você mesmo, mas sem todas as dores de cabeça de gerenciamento de dispositivos,
provavelmente o melhor seria usar diretamente o [Accelerate](https://github.com/huggingface/accelerate)! Embora seja
possível customizar cada parte do `Trainer`, o loop de treinamento é fundamentalmente dividido em vários

diferentes métodos que você teria que sobrescrever. Mas, antes de ir, será que escrever aqueles loops `for` é realmente importante 
o suficiente para justificar começar tudo do zero *de novo* 😉.
- Se você está trabalhando em um caso de uso personalizado, altamente complexo, que não se encaixa nos padrões dos loops de treinamento usuais
e quer extrair cada gota de desempenho do seu hardware escolhido, provavelmente o melhor é continuar
com o PyTorch puro; qualquer API de alto nível se torna um overhead em casos altamente especializados!


## Agradecimentos

Muitos aspectos por trás do design e das funcionalidades do `pytorch-accelerated` foram grandemente inspirados por uma série de excelentes 
bibliotecas e frameworks como [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) e [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Cada uma dessas ferramentas 
teve um enorme impacto tanto nesta biblioteca quanto na comunidade de aprendizado de máquina, e sua influência não pode ser 
enfatizada o suficiente!

O `pytorch-accelerated` apenas tomou inspiração dessas ferramentas, e toda a funcionalidade contida foi implementada
do zero de uma forma que beneficie esta biblioteca. As únicas exceções a isso são alguns dos scripts na 
[pasta de exemplos](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
onde recursos existentes foram usados e modificados para mostrar as funcionalidades do `pytorch-accelerated`;
esses casos estão claramente marcados, com o devido reconhecimento aos autores originais.
 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---