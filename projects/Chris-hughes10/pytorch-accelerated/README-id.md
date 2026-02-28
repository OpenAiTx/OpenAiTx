
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

`pytorch-accelerated` adalah sebuah pustaka ringan yang dirancang untuk mempercepat proses pelatihan model PyTorch
dengan menyediakan loop pelatihan minimal, namun dapat dikembangkan - yang dikemas dalam satu objek `Trainer`
yang cukup fleksibel untuk menangani sebagian besar kasus penggunaan, serta mampu memanfaatkan berbagai opsi perangkat keras
tanpa memerlukan perubahan kode.
 
`pytorch-accelerated` menawarkan kumpulan fitur yang efisien, dan sangat menekankan pada **kesederhanaan** serta **transparansi**,
untuk memungkinkan pengguna memahami dengan tepat apa yang terjadi di balik layar, tetapi tanpa harus menulis dan memelihara boilerplate sendiri!

Fitur utama adalah:
- Sebuah loop pelatihan yang sederhana dan terkontrol, namun mudah dikustomisasi, yang seharusnya dapat langsung digunakan pada kasus-kasus yang sederhana;
  perilaku dapat dikustomisasi menggunakan pewarisan dan/atau callback.
- Menangani penempatan perangkat, presisi campuran, integrasi DeepSpeed, pelatihan multi-GPU dan terdistribusi tanpa perubahan kode.
- Menggunakan komponen PyTorch murni, tanpa modifikasi tambahan atau pembungkus, dan mudah diintegrasikan
  dengan pustaka populer lain seperti [timm](https://github.com/rwightman/pytorch-image-models),
  [transformers](https://huggingface.co/transformers/) dan [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- API yang kecil dan sederhana memastikan bahwa kurva pembelajaran minimal bagi pengguna PyTorch yang sudah ada.

Upaya besar telah dilakukan untuk memastikan bahwa setiap bagian dari pustaka ini - baik komponen internal maupun eksternal - sejelas dan sesederhana mungkin,
sehingga mudah untuk dikustomisasi, debug, dan dipahami dengan tepat apa yang terjadi di balik layar di setiap langkah; sebagian besar
perilaku trainer terkandung dalam satu kelas!
Dalam semangat Python, tidak ada yang disembunyikan dan semuanya dapat diakses.

`pytorch-accelerated` dengan bangga dan transparan dibangun di atas
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), yang bertanggung jawab untuk
pergerakan data antar perangkat dan peluncuran konfigurasi pelatihan. Saat mengkustomisasi trainer, atau menjalankan
pelatihan, pengguna dianjurkan untuk membaca [dokumentasi Accelerate](https://huggingface.co/docs/accelerate/)
untuk memahami semua opsi yang tersedia; Accelerate menyediakan fungsi-fungsi yang memudahkan untuk operasi seperti pengumpulan tensor
dan pemotongan gradien, penggunaannya dapat dilihat di folder
[contoh](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) `pytorch-accelerated`!

Untuk mempelajari lebih lanjut tentang motivasi di balik pustaka ini, beserta panduan lengkap memulai, silakan cek [blog post ini](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Instalasi

`pytorch-accelerated` dapat diinstal dari pip menggunakan perintah berikut:
```
pip install pytorch-accelerated
```

Untuk membuat paket menjadi se-ramping mungkin, paket-paket yang diperlukan untuk menjalankan contoh tidak disertakan secara default. Untuk menyertakan paket-paket ini, Anda dapat menggunakan perintah berikut:
```
pip install pytorch-accelerated[examples]
```

## Mulai Cepat

Untuk memulai, cukup impor dan gunakan `Trainer` dari pytorch-accelerated, seperti yang ditunjukkan pada cuplikan berikut,
dan kemudian jalankan pelatihan menggunakan 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
yang dijelaskan di bawah ini.

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
Untuk memulai pelatihan menggunakan [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, pada mesin Anda, jalankan:

`accelerate config --config_file accelerate_config.yaml`

dan jawab pertanyaan yang diajukan. Ini akan menghasilkan file konfigurasi yang akan digunakan untuk mengatur opsi default dengan benar saat menjalankan

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Catatan*: Penggunaan [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) sepenuhnya opsional, pelatihan juga dapat dijalankan dengan cara biasa menggunakan:

`python train.py` / `python -m torch.distributed ...`

tergantung pada konfigurasi infrastruktur Anda, untuk pengguna yang ingin mengontrol perintah peluncuran secara lebih detail.

Contoh pelatihan yang lebih kompleks dapat dilihat di folder contoh
[di sini](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples).

Sebagai alternatif, jika Anda lebih suka memahami konsep inti terlebih dahulu, hal tersebut dapat ditemukan dalam [dokumentasi](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Penggunaan

### Siapa target pengguna pytorch-accelerated?

- Pengguna yang sudah familiar dengan PyTorch tetapi ingin menghindari penulisan kode pelatihan yang berulang
agar dapat fokus pada bagian menarik dari loop pelatihan.
- Pengguna yang suka, dan nyaman, memilih serta membuat model, fungsi loss, optimizer, dan dataset sendiri.
- Pengguna yang menghargai fitur yang sederhana dan efisien, di mana perilakunya mudah untuk di-debug, dipahami, dan dianalisis!

### Kapan sebaiknya tidak menggunakan pytorch-accelerated?

- Jika Anda mencari solusi end-to-end, mulai dari pemuatan data hingga inferensi,
  yang membantu Anda memilih model, optimizer, atau fungsi loss, Anda mungkin lebih cocok menggunakan
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` hanya berfokus pada proses pelatihan, dengan semua hal lainnya
  menjadi tanggung jawab pengguna.
- Jika Anda ingin menulis seluruh loop pelatihan sendiri, hanya tanpa kerepotan manajemen perangkat,
Anda mungkin paling cocok menggunakan [Accelerate](https://github.com/huggingface/accelerate) secara langsung! Meskipun
dimungkinkan untuk mengkustomisasi setiap bagian dari `Trainer`, loop pelatihan secara mendasar dipecah menjadi beberapa


berbagai metode yang harus Anda override. Namun, sebelum Anda melanjutkan, apakah menulis `for` loop tersebut benar-benar
cukup penting hingga harus mulai dari awal *lagi* 😉.
- Jika Anda sedang mengerjakan kasus penggunaan khusus yang sangat kompleks dan tidak sesuai dengan pola loop pelatihan biasa
dan ingin memaksimalkan setiap performa pada perangkat keras pilihan Anda, Anda mungkin lebih baik tetap menggunakan
PyTorch murni; API tingkat tinggi manapun akan menjadi overhead pada kasus yang sangat spesifik!


## Ucapan Terima Kasih

Banyak aspek dari desain dan fitur `pytorch-accelerated` sangat terinspirasi oleh sejumlah pustaka dan framework luar biasa
seperti [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models),
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning), dan [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Masing-masing alat ini
telah memberikan dampak besar baik pada pustaka ini maupun komunitas machine learning, dan pengaruh mereka tidak bisa
dinyatakan secara berlebihan!

`pytorch-accelerated` hanya mengambil inspirasi dari alat-alat ini, dan semua fungsionalitas yang ada telah diimplementasikan
dari awal dengan cara yang menguntungkan pustaka ini. Satu-satunya pengecualian adalah beberapa skrip di
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
folder di mana sumber daya yang ada diambil dan dimodifikasi untuk menampilkan fitur `pytorch-accelerated`;
kasus-kasus ini ditandai dengan jelas, dengan penghargaan diberikan kepada penulis aslinya.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---