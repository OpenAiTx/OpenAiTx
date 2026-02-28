<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

`pytorch-accelerated`, PyTorch modellerinin eğitim sürecini hızlandırmak için tasarlanmış hafif bir kütüphanedir
 ve minimal, ancak genişletilebilir bir eğitim döngüsü sağlayarak - tek bir `Trainer` 
nesnesinde kapsüllenmiş - çoğu kullanım senaryosunu karşılayacak kadar esnek ve farklı donanım
 seçeneklerini herhangi bir kod değişikliği gerektirmeden kullanabilecek yetenektedir.
 
`pytorch-accelerated`, sadeleştirilmiş bir özellik seti sunar ve **basitlik** ile **şeffaflık** üzerine büyük vurgu yapar,

kullanıcıların kaputun altında neler olup bittiğini tam olarak anlamalarını sağlamak için, ancak kendilerinin şablon kodu yazıp bakımını yapmak zorunda kalmadan!
   
Anahtar özellikler şunlardır:
- Basit ve kendi içinde, ancak kolayca özelleştirilebilen bir eğitim döngüsü; doğrudan kullanıma hazırdır, basit durumlarda kutudan çıkar çıkmaz çalışır;
 davranış kalıtım ve/veya geri çağırmalar kullanılarak özelleştirilebilir.
- Aygıt yerleşimi, karışık hassasiyet, DeepSpeed entegrasyonu, çoklu-GPU ve dağıtılmış eğitim işlemlerini kodda değişiklik yapmadan yönetir.
- Ek bir değişiklik veya sarmalayıcı olmadan tamamen saf PyTorch bileşenleri kullanır ve kolayca diğer popüler kütüphanelerle
 [timm](https://github.com/rwightman/pytorch-image-models), 
 [transformers](https://huggingface.co/transformers/) ve [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/) gibi kütüphanelerle birlikte çalışabilir.
- Küçük ve sade bir API, mevcut PyTorch kullanıcıları için öğrenme eğrisinin minimumda olmasını garanti eder.

Kütüphanenin her bir parçasının - hem dahili hem harici bileşenlerin - olabildiğince açık ve basit olması için büyük çaba harcanmıştır, 
bu sayede özelleştirme, hata ayıklama ve her adımda perde arkasında tam olarak neler olup bittiğini anlamak kolaydır; eğiticinin
davranışlarının çoğu tek bir sınıfta toplanmıştır!
Python'un ruhuna uygun olarak, hiçbir şey gizlenmez ve her şeye erişilebilir.

`pytorch-accelerated`, gururla ve şeffaf bir şekilde 
[Hugging Face Accelerate](https://github.com/huggingface/accelerate) üzerine inşa edilmiştir; bu kütüphane,
veri hareketini aygıtlar arasında yönetir ve eğitim yapılandırmalarını başlatır. Eğiticiyi özelleştirirken veya eğitimi başlatırken,
kullanıcıların tüm mevcut seçenekleri anlamak için [Accelerate dokümantasyonuna](https://huggingface.co/docs/accelerate/) 
bakmaları önerilir; Accelerate, tensörlerin toplanması ve gradyan kırpma gibi işlemler için uygun işlevler sunar; bu işlevlerin kullanımı `pytorch-accelerated` 
[örnekler](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) klasöründe görülebilir! 

Bu kütüphanenin arkasındaki motivasyonlar ve ayrıntılı bir başlangıç rehberi için, [bu blog yazısına](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968) göz atın.

## Kurulum

`pytorch-accelerated` aşağıdaki komut ile pip üzerinden kurulabilir:

```
pip install pytorch-accelerated
```

Paketi olabildiğince ince yapmak için, örnekleri çalıştırmak için gerekli paketler varsayılan olarak dahil edilmemiştir. Bu paketleri dahil etmek için aşağıdaki komutu kullanabilirsiniz:
```
pip install pytorch-accelerated[examples]
```

## Hızlı Başlangıç

Başlamak için, aşağıdaki kod parçasında gösterildiği gibi pytorch-accelerated `Trainer`'ı içe aktarın ve kullanın,
ardından eğitimi başlatmak için aşağıda açıklanan 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
komutunu kullanın.

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
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) kullanarak eğitimi başlatmak için, makinenizde (veya makinelerinizde) şu komutu çalıştırın:

` accelerate config --config_file accelerate_config.yaml`

ve sorulan soruları yanıtlayın. Bu, eğitim sırasında varsayılan seçeneklerin doğru şekilde ayarlanmasını sağlayacak bir yapılandırma dosyası oluşturacaktır.

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Not*: [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) kullanımı tamamen isteğe bağlıdır, eğitim her zamanki gibi aşağıdaki şekilde de başlatılabilir:

`python train.py` / `python -m torch.distributed ...`

altyapı yapılandırmanıza bağlı olarak, başlatma komutu üzerinde daha ayrıntılı kontrol sahibi olmak isteyen kullanıcılar için.

Daha karmaşık eğitim örnekleri, örnekler klasöründe 
[burada](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) görülebilir.

Alternatif olarak, önce temel kavramları anlamak isterseniz, bu [dokümantasyonda](https://pytorch-accelerated.readthedocs.io/en/latest/) bulunabilir.

## Kullanım

### pytorch-accelerated kimler için uygundur?

- PyTorch'a aşina olan ama eğitim döngüsündeki sıkıcı kod şablonlarını yazmaktan kaçınarak
eğitim döngüsünün ilgi çekici kısımlarına odaklanmak isteyen kullanıcılar.
- Kendi modellerini, kayıp fonksiyonlarını, optimize edicilerini ve veri setlerini seçmekten ve oluşturmaktan hoşlanan ve bu konuda rahat olan kullanıcılar.
- Davranışların kolayca hata ayıklanabilir, anlaşılır ve mantıklı olduğu basit ve yalın bir özellik setini değerli bulan kullanıcılar!

### Hangi durumlarda pytorch-accelerated kullanmamalıyım?

- Eğer veri yüklemeden çıkarıma kadar her şeyi kapsayan uçtan uca bir çözüm arıyorsanız,
  model, optimizer veya kayıp fonksiyonu seçmenize yardımcı olan, muhtemelen
  [fastai](https://github.com/fastai/fastai) sizin için daha uygun olacaktır. `pytorch-accelerated` yalnızca eğitim sürecine odaklanır, diğer tüm
  konular kullanıcıya bırakılmıştır.
- Eğer tüm eğitim döngüsünü kendiniz yazmak istiyorsanız, sadece cihaz yönetimiyle ilgili sıkıntılar olmadan,
muhtemelen doğrudan [Accelerate](https://github.com/huggingface/accelerate) kullanmanız daha iyi olur! Her ne kadar
`Trainer`'ın her bölümünü özelleştirmek mümkün olsa da, eğitim döngüsü temelde birkaç parçaya ayrılmıştır.



üzerine geçmeniz gereken farklı yöntemler olurdu. Ancak, başlamadan önce, bu `for` döngülerini yazmak gerçekten *yeterince* önemli mi ki, *tekrar* sıfırdan başlamayı gerektiriyor 😉.
- Eğer alışılmış eğitim döngüsü kalıplarına uymayan, özel ve son derece karmaşık bir kullanım durumu üzerinde çalışıyor ve seçtiğiniz donanımda en yüksek performansı elde etmek istiyorsanız, muhtemelen sade PyTorch kullanmak sizin için en iyisi olacaktır; yüksek seviyeli herhangi bir API, son derece özelleşmiş durumlarda ek bir yük haline gelir!

## Teşekkürler

`pytorch-accelerated` kütüphanesinin tasarımı ve özelliklerinin birçok yönü, [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) ve [Hugging Face Accelerate](https://github.com/huggingface/accelerate) gibi bir dizi mükemmel kütüphane ve çerçeveden büyük ölçüde esinlenmiştir. Bu araçların her biri, hem bu kütüphane hem de makine öğrenimi topluluğu üzerinde muazzam bir etki yaratmıştır ve etkileri yeterince vurgulanamaz!

`pytorch-accelerated`, bu araçlardan yalnızca ilham almış olup, içerdiği tüm işlevsellik, bu kütüphaneye fayda sağlayacak şekilde sıfırdan uygulanmıştır. 
Bunun tek istisnası, [örnekler](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) 
klasöründeki bazı betiklerdir; burada mevcut kaynaklar alınmış ve `pytorch-accelerated`'ın özelliklerini sergilemek için değiştirilmiştir; 
bu durumlar açıkça belirtilmiş ve orijinal yazarlara teşekkür edilmiştir.











---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---