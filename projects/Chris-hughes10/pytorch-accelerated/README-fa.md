<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Chris-hughes10&project=pytorch-accelerated&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# pytorch-accelerated

کتابخانه `pytorch-accelerated` یک ابزار سبک است که برای تسریع فرآیند آموزش مدل‌های PyTorch
 با ارائه یک حلقه آموزشی حداقلی اما قابل توسعه - که در یک شیء واحد به نام `Trainer` 
جای گرفته است - طراحی شده است. این حلقه به اندازه کافی انعطاف‌پذیر است تا اکثر موارد استفاده را پوشش دهد و می‌تواند بدون نیاز به تغییر کد،
 از سخت‌افزارهای مختلف استفاده کند.
 
کتابخانه `pytorch-accelerated` مجموعه‌ای ساده از قابلیت‌ها را ارائه می‌دهد و تاکید زیادی بر **سادگی** و **شفافیت** دارد،

برای اینکه کاربران بتوانند دقیقاً متوجه شوند که در پشت صحنه چه اتفاقی می‌افتد، اما بدون اینکه مجبور باشند خودشان کدهای تکراری را بنویسند و نگهداری کنند!
   
ویژگی‌های کلیدی عبارتند از:
- یک حلقه آموزش ساده و محدود، اما به راحتی قابل سفارشی‌سازی، که باید در موارد ساده به طور پیش‌فرض کار کند؛
رفتار آن را می‌توان با استفاده از ارث‌بری و/یا callbackها سفارشی کرد.
- مدیریت جای‌گذاری روی دستگاه، دقت ترکیبی، یکپارچگی با DeepSpeed، آموزش چند GPU و توزیع‌شده بدون نیاز به تغییر کد.
- استفاده از اجزای خالص PyTorch، بدون تغییرات یا بسته‌بندی اضافه، و تعامل آسان با
کتابخانه‌های محبوب دیگر مانند [timm](https://github.com/rwightman/pytorch-image-models)، 
[transformers](https://huggingface.co/transformers/) و [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- یک API کوچک و ساده که باعث می‌شود منحنی یادگیری برای کاربران فعلی PyTorch حداقل باشد.

تلاش زیادی شده تا اطمینان حاصل شود هر بخش از کتابخانه - چه اجزای داخلی و چه خارجی - تا حد ممکن واضح و ساده باشد،
تا سفارشی‌سازی، دیباگ و درک دقیق آنچه در پشت صحنه در هر مرحله اتفاق می‌افتد آسان شود؛ بیشتر
رفتار مربی (trainer) در یک کلاس واحد قرار دارد!
در روحیه پایتون، هیچ چیز پنهان نیست و همه چیز قابل دسترسی است.

کتابخانه `pytorch-accelerated` با افتخار و شفافیت روی
[Hugging Face Accelerate](https://github.com/huggingface/accelerate) ساخته شده است، که مسئول
انتقال داده‌ها بین دستگاه‌ها و راه‌اندازی پیکربندی‌های آموزش است. هنگام سفارشی‌سازی trainer یا راه‌اندازی
آموزش، توصیه می‌شود کاربران به [مستندات Accelerate](https://huggingface.co/docs/accelerate/)
مراجعه کنند تا از همه گزینه‌های موجود مطلع شوند؛ Accelerate توابع راحتی برای عملیات‌هایی مثل جمع‌آوری تنسورها
و برش گرادیان ارائه می‌دهد که استفاده آن‌ها را می‌توانید در پوشه
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) کتابخانه `pytorch-accelerated` ببینید!

برای آشنایی بیشتر با انگیزه‌های پشت این کتابخانه و همچنین راهنمای آغاز به کار کامل، به [این پست وبلاگ](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968) مراجعه کنید.

## نصب

کتابخانه `pytorch-accelerated` را می‌توانید با دستور زیر از pip نصب کنید:
```
pip install pytorch-accelerated
```
برای اینکه بسته تا حد امکان سبک باشد، بسته‌هایی که برای اجرای مثال‌ها لازم هستند به طور پیش‌فرض گنجانده نشده‌اند. برای افزودن این بسته‌ها، می‌توانید از دستور زیر استفاده کنید:

```
pip install pytorch-accelerated[examples]
```

## شروع سریع

برای شروع، کافی است `Trainer` از پکیج pytorch-accelerated را همانطور که در قطعه کد زیر نشان داده شده است، ایمپورت و استفاده کنید،
و سپس آموزش را با استفاده از 
[رابط خط فرمان accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
که در زیر توضیح داده شده است، راه‌اندازی کنید.

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
برای اجرای آموزش با استفاده از [رابط خط فرمان accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
، بر روی دستگاه(های) خود اجرا کنید:

` accelerate config --config_file accelerate_config.yaml`

و به سوالات پرسیده شده پاسخ دهید. این کار یک فایل پیکربندی تولید می‌کند که برای تنظیم صحیح گزینه‌های پیش‌فرض هنگام اجرای

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*نکته*: استفاده از [رابط خط فرمان accelerate](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) کاملاً اختیاری است، آموزش همچنین می‌تواند به روش معمول اجرا شود:

`python train.py` / `python -m torch.distributed ...`

بسته به پیکربندی زیرساخت شما، برای کاربرانی که می‌خواهند کنترل دقیق‌تری 
بر دستور اجرای آموزش داشته باشند.

نمونه‌های پیچیده‌تر آموزش را می‌توانید در پوشه examples 
[اینجا](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) مشاهده کنید.

در عوض، اگر ترجیح می‌دهید ابتدا مفاهیم اصلی را درک کنید، می‌توانید آن را در [مستندات](https://pytorch-accelerated.readthedocs.io/en/latest/) پیدا کنید.

## نحوه استفاده

### مخاطب pytorch-accelerated چه کسانی هستند؟

- کاربرانی که با PyTorch آشنا هستند اما ترجیح می‌دهند نوشتن کد تکراری حلقه آموزش را کنار بگذارند
تا بتوانند روی بخش‌های جالب حلقه آموزش تمرکز کنند.
- کاربرانی که دوست دارند و راحت هستند با انتخاب و ساخت مدل، تابع خطا، بهینه‌ساز و داده‌ست‌های خود.
- کاربرانی که یک مجموعه ویژگی ساده و سرراست را ارزشمند می‌دانند، جایی که رفتار به سادگی قابل دیباگ، درک و تحلیل باشد!

### چه زمانی نباید از pytorch-accelerated استفاده کنم؟

- اگر به دنبال یک راه حل انتها به انتها هستید که همه چیز را از بارگذاری داده تا استنتاج
  پوشش دهد و به شما در انتخاب مدل، بهینه‌ساز یا تابع خطا کمک کند، احتمالاً [fastai](https://github.com/fastai/fastai) گزینه بهتری برای شماست. `pytorch-accelerated` فقط بر فرایند آموزش تمرکز دارد و سایر
  موارد را به عهده کاربر می‌گذارد.
- اگر می‌خواهید حلقه آموزش را کاملاً خودتان بنویسید فقط بدون دردسر مدیریت دستگاه،
احتمالاً استفاده مستقیم از [Accelerate](https://github.com/huggingface/accelerate) برای شما مناسب‌تر است! اگرچه
امکان سفارشی‌سازی هر بخش از `Trainer` وجود دارد، اما حلقه آموزش اساساً به چند بخش تقسیم شده است


روش‌های مختلفی وجود دارند که باید آن‌ها را بازنویسی کنید. اما قبل از رفتن، آیا نوشتن آن حلقه‌های `for` واقعاً آنقدر مهم است که ارزش شروع دوباره *از صفر* را داشته باشد 😉.
- اگر روی یک مورد استفاده سفارشی و بسیار پیچیده کار می‌کنید که با الگوهای معمول حلقه‌های آموزش سازگار نیست و می‌خواهید حداکثر عملکرد را از سخت‌افزار انتخابی خود استخراج کنید، احتمالاً بهتر است با PyTorch معمولی کار کنید؛ هر API سطح بالا در موارد بسیار تخصصی تبدیل به سربار می‌شود!

## قدردانی

بسیاری از جنبه‌های طراحی و ویژگی‌های `pytorch-accelerated` به شدت تحت تأثیر تعدادی از کتابخانه‌ها و چارچوب‌های عالی مانند [fastai](https://github.com/fastai/fastai)، [timm](https://github.com/rwightman/pytorch-image-models)،
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) و [Hugging Face Accelerate](https://github.com/huggingface/accelerate) قرار گرفته است. هر یک از این ابزارها تأثیر عظیمی هم بر این کتابخانه و هم بر جامعه یادگیری ماشین داشته‌اند و نمی‌توان تأثیر آن‌ها را کافی بیان کرد!

`pytorch-accelerated` تنها از این ابزارها الهام گرفته است و تمامی قابلیت‌های موجود از ابتدا به گونه‌ای پیاده‌سازی شده‌اند که برای این کتابخانه سودمند باشند. تنها استثنا، برخی از اسکریپت‌های موجود در
پوشه [examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
است که منابع موجود گرفته شده و برای نمایش ویژگی‌های `pytorch-accelerated` تغییر یافته‌اند؛
این موارد به وضوح مشخص شده‌اند و به نویسندگان اصلی تقدیر داده شده است.











---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---