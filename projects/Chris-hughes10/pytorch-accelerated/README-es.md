
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

`pytorch-accelerated` es una librería ligera diseñada para acelerar el proceso de entrenamiento de modelos en PyTorch
proporcionando un ciclo de entrenamiento mínimo, pero extensible, encapsulado en un único objeto `Trainer`
que es lo suficientemente flexible para manejar la mayoría de los casos de uso, y capaz de utilizar diferentes opciones de hardware
sin necesidad de realizar cambios en el código.
 
`pytorch-accelerated` ofrece un conjunto de características optimizado y pone un gran énfasis en la **simplicidad** y la **transparencia**,
para permitir a los usuarios entender exactamente lo que sucede bajo el capó, ¡pero sin tener que escribir y mantener el código repetitivo ellos mismos!
   
Las características clave son:
- Un bucle de entrenamiento simple y contenido, pero fácilmente personalizable, que debería funcionar directamente en casos sencillos;
  el comportamiento puede personalizarse usando herencia y/o callbacks.
- Maneja la asignación de dispositivos, precisión mixta, integración con DeepSpeed, entrenamiento multi-GPU y distribuido sin cambios en el código.
- Utiliza componentes puros de PyTorch, sin modificaciones o envoltorios adicionales, e interoperan fácilmente
  con otras bibliotecas populares como [timm](https://github.com/rwightman/pytorch-image-models),
  [transformers](https://huggingface.co/transformers/) y [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- Una API pequeña y simplificada asegura una curva de aprendizaje mínima para usuarios existentes de PyTorch.

Se ha hecho un esfuerzo significativo para garantizar que cada parte de la biblioteca, tanto los componentes internos como externos, sean lo más claros y simples posible,
lo que facilita la personalización, depuración y comprensión exacta de lo que sucede tras bambalinas en cada paso; ¡la mayor parte del
comportamiento del entrenador está contenido en una sola clase!
En el espíritu de Python, nada está oculto y todo es accesible.

`pytorch-accelerated` está orgullosa y transparentemente construida sobre
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), que se encarga del
movimiento de datos entre dispositivos y el lanzamiento de configuraciones de entrenamiento. Al personalizar el entrenador o lanzar
el entrenamiento, se recomienda a los usuarios consultar la [documentación de Accelerate](https://huggingface.co/docs/accelerate/)
para entender todas las opciones disponibles; Accelerate proporciona funciones convenientes para operaciones como recopilación de tensores
y recorte de gradientes, cuyo uso puede verse en la carpeta de
[ejemplos](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) de `pytorch-accelerated`!

Para saber más sobre las motivaciones detrás de esta biblioteca, junto con una guía detallada de inicio, consulta [esta entrada de blog](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Instalación

`pytorch-accelerated` puede instalarse desde pip usando el siguiente comando:
```
pip install pytorch-accelerated
```
Para hacer el paquete lo más ligero posible, los paquetes necesarios para ejecutar los ejemplos no se incluyen por defecto. Para incluir estos paquetes, puede usar el siguiente comando:

```
pip install pytorch-accelerated[examples]
```

## Inicio rápido

Para comenzar, simplemente importe y utilice el `Trainer` acelerado por pytorch, como se demuestra en el siguiente fragmento,
y luego inicie el entrenamiento utilizando el 
[CLI de accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
descrito a continuación.

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
Para iniciar el entrenamiento usando la [CLI de accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, en tu(s) máquina(s), ejecuta:

` accelerate config --config_file accelerate_config.yaml`

y responde las preguntas que se te hagan. Esto generará un archivo de configuración que se utilizará para establecer correctamente las opciones predeterminadas al hacer

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Nota*: Usar la [CLI de accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) es completamente opcional, el entrenamiento también puede iniciarse de la manera habitual usando:

`python train.py` / `python -m torch.distributed ...`

dependiendo de la configuración de tu infraestructura, para usuarios que prefieran mantener un control más detallado 
sobre el comando de lanzamiento.

Ejemplos de entrenamientos más complejos pueden verse en la carpeta de ejemplos 
[aquí](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples). 

Alternativamente, si prefieres entender primero los conceptos básicos, esto puede encontrarse en la [documentación](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Uso

### ¿A quién está dirigido pytorch-accelerated?

- Usuarios que están familiarizados con PyTorch pero desean evitar tener que escribir el código repetitivo común del ciclo de entrenamiento
para centrarse en las partes interesantes del ciclo de entrenamiento.
- Usuarios que les gusta y se sienten cómodos seleccionando y creando sus propios modelos, funciones de pérdida, optimizadores y conjuntos de datos.
- Usuarios que valoran un conjunto de características simple y optimizado, donde el comportamiento es fácil de depurar, entender y razonar.

### ¿Cuándo no debería usar pytorch-accelerated?

- Si buscas una solución completa, que abarque desde la carga de datos hasta la inferencia,
  que te ayude a seleccionar un modelo, optimizador o función de pérdida, probablemente te convenga más
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` se enfoca únicamente en el proceso de entrenamiento, dejando todas las demás
  responsabilidades al usuario.
- Si deseas escribir todo el ciclo de entrenamiento tú mismo, solo sin todos los problemas de gestión de dispositivos, 
probablemente te convenga usar directamente [Accelerate](https://github.com/huggingface/accelerate). Aunque es
posible personalizar cada parte del `Trainer`, el ciclo de entrenamiento se divide fundamentalmente en una serie de 

diferentes métodos que tendrías que sobrescribir. Pero, antes de que te vayas, ¿realmente es tan importante escribir esos bucles `for`  
como para justificar empezar desde cero *otra vez* 😉.  
- Si estás trabajando en un caso de uso personalizado, muy complejo, que no encaja con los patrones de los bucles de entrenamiento habituales  
y quieres exprimir hasta el último bit de rendimiento en tu hardware elegido, probablemente sea mejor que te quedes  
con PyTorch puro; cualquier API de alto nivel se convierte en una sobrecarga en casos altamente especializados!  


## Agradecimientos  

Muchos aspectos detrás del diseño y las características de `pytorch-accelerated` fueron grandemente inspirados por una serie de excelentes  
bibliotecas y frameworks como [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models),  
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) y [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Cada una de estas herramientas  
ha tenido un impacto enorme tanto en esta biblioteca como en la comunidad de aprendizaje automático, ¡y su influencia no puede ser  
subestimada!  

`pytorch-accelerated` solo ha tomado inspiración de estas herramientas, y toda la funcionalidad contenida ha sido implementada  
desde cero de una manera que beneficia a esta biblioteca. Las únicas excepciones a esto son algunos de los scripts en la  
carpeta [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)  
en los que se tomaron y modificaron recursos existentes para mostrar las características de `pytorch-accelerated`;  
estos casos están claramente marcados, dando reconocimiento a los autores originales.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---