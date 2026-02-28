<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=en">الإنجليزية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-CN">الصينية المبسطة</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-TW">الصينية التقليدية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ja">اليابانية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ko">الكورية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=hi">الهندية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=th">التايلاندية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fr">الفرنسية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=de">الألمانية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=es">الإسبانية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=it">الإيطالية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ru">الروسية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pt">البرتغالية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=nl">الهولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pl">البولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fa">الفارسية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=tr">التركية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=vi">الفيتنامية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=id">الإندونيسية</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=as">الآسامية</
      </div>
    </div>
  </details>
</div>

# pytorch-accelerated

`pytorch-accelerated` هي مكتبة خفيفة الوزن مصممة لتسريع عملية تدريب نماذج بايتورتش
 من خلال توفير حلقة تدريبية بسيطة ولكن قابلة للتوسعة - مضمنة في كائن واحد يسمى `Trainer` 
وهو مرن بما يكفي للتعامل مع معظم حالات الاستخدام، وقادر على استخدام خيارات أجهزة مختلفة
 دون الحاجة لتغيير الكود.
 
تقدم `pytorch-accelerated` مجموعة ميزات مبسطة، وتضع تركيزًا كبيرًا على **البساطة** و**الشفافية**،

لتمكين المستخدمين من فهم ما يحدث بالضبط خلف الكواليس، ولكن دون الحاجة إلى كتابة وصيانة الأكواد المتكررة بأنفسهم!
   
الميزات الرئيسية هي:
- حلقة تدريب بسيطة ومحتواة، ولكن قابلة للتخصيص بسهولة، والتي يجب أن تعمل مباشرة في الحالات المباشرة؛
 يمكن تخصيص السلوك باستخدام الوراثة و/أو الاستدعاءات.
- تتعامل مع وضع الجهاز، الدقة المختلطة، التكامل مع DeepSpeed، التدريب متعدد وحدات معالجة الرسومات والتدريب الموزع دون الحاجة إلى تغيير الكود.
- تستخدم مكونات PyTorch الأصلية فقط، دون أي تعديلات أو مغلفات إضافية، وتتوافق بسهولة
 مع المكتبات الشهيرة الأخرى مثل [timm](https://github.com/rwightman/pytorch-image-models)،
 [transformers](https://huggingface.co/transformers/) و [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- واجهة برمجة تطبيقات صغيرة ومبسطة تضمن وجود منحنى تعلم بسيط لمستخدمي PyTorch الحاليين.

تم بذل جهد كبير لضمان أن كل جزء من المكتبة - سواء المكونات الداخلية أو الخارجية - واضح وبسيط قدر الإمكان،
مما يجعل من السهل تخصيصها، وتصحيحها وفهم ما يحدث بالضبط خلف الكواليس في كل خطوة؛ معظم
سلوك المدرب موجود في فئة واحدة فقط!
وبروح بايثون، لا شيء مخفي وكل شيء متاح.

تم بناء `pytorch-accelerated` بفخر وشفافية على
[Hugging Face Accelerate](https://github.com/huggingface/accelerate)، والتي تتولى
نقل البيانات بين الأجهزة وإطلاق تكوينات التدريب. عند تخصيص المدرب أو بدء التدريب،
ننصح المستخدمين بالرجوع إلى [وثائق Accelerate](https://huggingface.co/docs/accelerate/)
لفهم جميع الخيارات المتاحة؛ يوفر Accelerate وظائف مناسبة لعمليات مثل جمع التنسورات
وقص التدرجات، ويمكن رؤية استخدام ذلك في مجلد
[الأمثلة](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) الخاص بـ `pytorch-accelerated`!

للتعرف أكثر على دوافع إنشاء هذه المكتبة، بالإضافة إلى دليل مفصل للبدء، راجع [هذه التدوينة](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## التثبيت

يمكن تثبيت `pytorch-accelerated` باستخدام pip عبر الأمر التالي:
```
pip install pytorch-accelerated
```
لجعل الحزمة أنحف قدر الإمكان، لم يتم تضمين الحزم المطلوبة لتشغيل الأمثلة بشكل افتراضي. لإضافة هذه الحزم، يمكنك استخدام الأمر التالي:

```
pip install pytorch-accelerated[examples]
```

## البدء السريع

لبدء الاستخدام، قم ببساطة باستيراد واستخدام `Trainer` من pytorch-accelerated، كما هو موضح في المقتطف التالي،
ثم ابدأ عملية التدريب باستخدام 
[أداة accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
الموضحة أدناه.

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

لإطلاق التدريب باستخدام [واجهة الأوامر accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
، على جهازك (أجهزتك)، قم بتشغيل:

` accelerate config --config_file accelerate_config.yaml`

وأجب عن الأسئلة المطروحة. سيؤدي ذلك إلى إنشاء ملف إعدادات سيتم استخدامه لضبط الخيارات الافتراضية بشكل صحيح عند تنفيذ

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*ملاحظة*: استخدام [واجهة الأوامر accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) هو أمر اختياري تمامًا، حيث يمكن بدء التدريب بالطريقة المعتادة باستخدام:

`python train.py` / `python -m torch.distributed ...`

اعتمادًا على تكوين البنية التحتية الخاصة بك، وذلك للمستخدمين الذين يفضلون التحكم الدقيق 
في أمر الإطلاق.

يمكن مشاهدة أمثلة تدريب أكثر تعقيدًا في مجلد الأمثلة 
[هنا](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples).

بدلاً من ذلك، إذا كنت تفضل فهم المفاهيم الأساسية أولاً، يمكن العثور عليها في [التوثيق](https://pytorch-accelerated.readthedocs.io/en/latest/).

## الاستخدام

### من هو الجمهور المستهدف لـ pytorch-accelerated؟

- المستخدمون الملمون بـ PyTorch ولكنهم يفضلون تجنب كتابة القوالب المتكررة لحلقة التدريب
ليركزوا على الأجزاء المثيرة للاهتمام من حلقة التدريب.
- المستخدمون الذين يفضلون، ويشعرون بالراحة في، اختيار وإنشاء نماذجهم، ودوال الخسارة، والمُحسِنات، ومجموعات البيانات الخاصة بهم.
- المستخدمون الذين يقدرون مجموعة ميزات بسيطة وسلسة، حيث يكون السلوك سهل التصحيح والفهم والتعامل معه!

### متى لا يجب أن تستخدم pytorch-accelerated؟

- إذا كنت تبحث عن حل شامل من طرف إلى طرف، يشمل كل شيء من تحميل البيانات وحتى الاستدلال،
  ويساعدك في اختيار نموذج أو مُحسِّن أو دالة خسارة، فمن الأفضل لك استخدام
  [fastai](https://github.com/fastai/fastai). يركز `pytorch-accelerated` فقط على عملية التدريب، وجميع الأمور الأخرى
  تُترك لمسؤولية المستخدم.
- إذا كنت تفضل كتابة حلقة التدريب كاملة بنفسك، ولكن دون كل متاعب إدارة الأجهزة،
فربما من الأفضل لك استخدام [Accelerate](https://github.com/huggingface/accelerate) مباشرة! بينما
من الممكن تخصيص كل جزء من `Trainer`، إلا أن حلقة التدريب مقسمة أساسًا إلى عدة
طرق مختلفة ستحتاج إلى تجاوزها. ولكن، قبل أن تبدأ، هل كتابة تلك الحلقات `for` مهمة حقًا
لدرجة تستحق أن تبدأ من الصفر *مجدداً* 😉.
- إذا كنت تعمل على حالة استخدام مخصصة ومعقدة للغاية لا تتناسب مع أنماط حلقات التدريب المعتادة
وترغب في استخراج كل جزء من الأداء على عتادك المختار، فمن الأفضل غالباً الالتزام بـ PyTorch الأصلي؛ أي واجهة برمجة تطبيقات عالية المستوى تصبح عبئاً في الحالات المتخصصة للغاية!

## الشكر والتقدير

لقد استُلهمت العديد من جوانب تصميم وميزات مكتبة `pytorch-accelerated` بشكل كبير من عدد من المكتبات
والأطر الممتازة مثل [fastai](https://github.com/fastai/fastai)، [timm](https://github.com/rwightman/pytorch-image-models)،
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) و [Hugging Face Accelerate](https://github.com/huggingface/accelerate). كل من هذه الأدوات
أثرت بشكل كبير على كل من هذه المكتبة ومجتمع تعلم الآلة، ولا يمكن التأكيد بما فيه الكفاية على مدى تأثيرهم!

لقد استلهمت مكتبة `pytorch-accelerated` فقط من هذه الأدوات، وتم تنفيذ جميع الوظائف التي تحتويها من الصفر
بطريقة تفيد هذه المكتبة. والاستثناءات الوحيدة لذلك هي بعض السكريبتات في
مجلد [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
حيث تم أخذ الموارد الموجودة وتعديلها بهدف عرض ميزات `pytorch-accelerated`;
هذه الحالات تم تمييزها بوضوح، مع تقديم الشكر للمؤلفين الأصليين.






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---