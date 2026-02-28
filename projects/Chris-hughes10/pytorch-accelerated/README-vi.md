
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

`pytorch-accelerated` là một thư viện nhẹ được thiết kế để tăng tốc quá trình huấn luyện các mô hình PyTorch
 bằng cách cung cấp một vòng lặp huấn luyện tối giản nhưng có khả năng mở rộng - được đóng gói trong một đối tượng `Trainer` duy nhất -
 đủ linh hoạt để xử lý phần lớn các trường hợp sử dụng, và có khả năng tận dụng các tùy chọn phần cứng khác nhau
 mà không cần thay đổi mã nguồn.
 
`pytorch-accelerated` cung cấp một tập hợp tính năng gọn nhẹ, và đặt trọng tâm lớn vào **sự đơn giản** và **tính minh bạch**,
để cho phép người dùng hiểu chính xác những gì đang diễn ra bên trong, nhưng không cần phải tự viết và duy trì các đoạn mã mẫu lặp đi lặp lại!
   
Các tính năng chính bao gồm:
- Vòng lặp huấn luyện đơn giản, gói gọn nhưng dễ dàng tùy biến, có thể sử dụng ngay trong các trường hợp đơn giản; hành vi có thể được tùy chỉnh bằng cách kế thừa và/hoặc sử dụng callback.
- Xử lý việc đặt thiết bị, tính toán hỗn hợp độ chính xác, tích hợp DeepSpeed, huấn luyện đa-GPU và phân tán mà không cần thay đổi mã nguồn.
- Sử dụng các thành phần thuần PyTorch, không có sửa đổi hay bọc thêm nào, và dễ dàng tương thích với các thư viện phổ biến khác như [timm](https://github.com/rwightman/pytorch-image-models), 
 [transformers](https://huggingface.co/transformers/) và [torchmetrics](https://torchmetrics.readthedocs.io/en/latest/).
- API nhỏ gọn, tinh giản đảm bảo đường cong học tập tối thiểu cho người dùng PyTorch hiện tại.

Đã có nỗ lực đáng kể để đảm bảo rằng mọi phần của thư viện - cả thành phần bên trong và bên ngoài - đều rõ ràng và đơn giản nhất có thể,
giúp dễ dàng tùy biến, debug và hiểu rõ chính xác những gì đang xảy ra phía sau hậu trường ở mỗi bước; hầu hết
hành vi của trainer đều nằm trong một lớp duy nhất!
Theo tinh thần của Python, không có gì bị ẩn giấu và mọi thứ đều có thể truy cập được.

`pytorch-accelerated` được xây dựng một cách minh bạch và tự hào dựa trên
[Hugging Face Accelerate](https://github.com/huggingface/accelerate), chịu trách nhiệm cho việc
di chuyển dữ liệu giữa các thiết bị và khởi chạy các cấu hình huấn luyện. Khi tùy chỉnh trainer hoặc khởi chạy
quá trình huấn luyện, người dùng nên tham khảo [tài liệu Accelerate](https://huggingface.co/docs/accelerate/)
để hiểu tất cả các tùy chọn hiện có; Accelerate cung cấp các hàm tiện lợi cho các thao tác như gom các tensor
và cắt gradient, cách sử dụng các hàm này có thể xem trong thư mục
[ví dụ](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples) của `pytorch-accelerated`!

Để tìm hiểu thêm về động lực xây dựng thư viện này, cùng với hướng dẫn bắt đầu chi tiết, hãy xem [bài viết blog này](https://medium.com/@chris.p.hughes10/introducing-pytorch-accelerated-6ba99530608c?source=friends_link&sk=868c2d2ec5229fdea42877c0bf82b968).

## Cài đặt

`pytorch-accelerated` có thể được cài đặt từ pip bằng lệnh sau:


```
pip install pytorch-accelerated
```
Để làm cho gói càng nhỏ gọn càng tốt, các gói cần thiết để chạy ví dụ không được bao gồm mặc định. Để thêm các gói này, bạn có thể sử dụng lệnh sau:

```
pip install pytorch-accelerated[examples]
```

## Bắt đầu nhanh

Để bắt đầu, chỉ cần import và sử dụng `Trainer` của pytorch-accelerated, như minh họa trong đoạn mã dưới đây,
sau đó khởi động quá trình huấn luyện bằng 
[accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
được mô tả bên dưới.

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
Để khởi động quá trình huấn luyện bằng [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script)
, trên máy của bạn, hãy chạy:

` accelerate config --config_file accelerate_config.yaml`

và trả lời các câu hỏi được đưa ra. Điều này sẽ tạo ra một tệp cấu hình sẽ được dùng để thiết lập đúng các tùy chọn mặc định khi chạy

`accelerate launch --config_file accelerate_config.yaml train.py [--training-args]`

*Lưu ý*: Việc sử dụng [accelerate CLI](https://huggingface.co/docs/accelerate/quicktour.html#launching-your-distributed-script) là hoàn toàn tùy chọn, bạn cũng có thể khởi động quá trình huấn luyện theo cách thông thường bằng:

`python train.py` / `python -m torch.distributed ...`

tùy thuộc vào cấu hình hạ tầng của bạn, dành cho người dùng muốn kiểm soát chi tiết hơn
lệnh khởi động.

Các ví dụ huấn luyện phức tạp hơn có thể được xem trong thư mục examples
[tại đây](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples).

Ngoài ra, nếu bạn muốn hiểu các khái niệm cốt lõi trước, bạn có thể tìm thấy chúng trong [tài liệu](https://pytorch-accelerated.readthedocs.io/en/latest/).

## Sử dụng

### Đối tượng mà pytorch-accelerated hướng tới là ai?

- Người dùng đã quen với PyTorch nhưng muốn tránh phải viết các đoạn mã lặp trong vòng lặp huấn luyện
để tập trung vào các phần thú vị của quy trình huấn luyện.
- Người dùng thích và tự tin trong việc lựa chọn, tạo mô hình, hàm mất mát, bộ tối ưu hóa và tập dữ liệu riêng của mình.
- Người dùng đánh giá cao một bộ tính năng đơn giản, tinh gọn, dễ dàng gỡ lỗi, hiểu và giải thích hành vi!

### Khi nào bạn không nên dùng pytorch-accelerated?

- Nếu bạn đang tìm kiếm một giải pháp trọn gói, bao gồm tất cả từ việc tải dữ liệu đến suy luận,
  hỗ trợ bạn chọn mô hình, bộ tối ưu hóa hoặc hàm mất mát, có lẽ bạn sẽ phù hợp hơn với
  [fastai](https://github.com/fastai/fastai). `pytorch-accelerated` chỉ tập trung vào quá trình huấn luyện, các vấn đề khác
  sẽ do người dùng tự đảm nhận.
- Nếu bạn muốn tự viết toàn bộ vòng lặp huấn luyện, chỉ không muốn phải quản lý thiết bị phức tạp,
bạn sẽ phù hợp nhất với việc sử dụng trực tiếp [Accelerate](https://github.com/huggingface/accelerate)! Mặc dù có thể
tùy chỉnh mọi phần của `Trainer`, nhưng vòng lặp huấn luyện về cơ bản được chia thành một số 

các phương pháp khác nhau mà bạn sẽ phải ghi đè. Nhưng, trước khi bạn đi, liệu việc viết những vòng lặp `for` đó có thực sự quan trọng 
đến mức đáng để bắt đầu lại từ đầu *một lần nữa* 😉.
- Nếu bạn đang làm việc trên một trường hợp sử dụng tuỳ chỉnh, cực kỳ phức tạp mà không phù hợp với các mẫu của các vòng lặp huấn luyện thông thường
và muốn tận dụng tối đa hiệu năng trên phần cứng được chọn, thì tốt nhất bạn nên sử dụng PyTorch gốc; bất kỳ API cấp cao nào cũng trở thành gánh nặng trong các trường hợp đặc biệt!


## Lời cảm ơn

Nhiều khía cạnh trong thiết kế và các tính năng của `pytorch-accelerated` đã được lấy cảm hứng rất lớn từ một số thư viện 
và framework xuất sắc như [fastai](https://github.com/fastai/fastai), [timm](https://github.com/rwightman/pytorch-image-models), 
[PyTorch-lightning](https://github.com/PyTorchLightning/pytorch-lightning) và [Hugging Face Accelerate](https://github.com/huggingface/accelerate). Mỗi công cụ này 
đều có ảnh hưởng to lớn đến cả thư viện này và cộng đồng học máy, và tầm ảnh hưởng của chúng không thể 
nói hết bằng lời!

`pytorch-accelerated` chỉ lấy cảm hứng từ các công cụ này, và toàn bộ các chức năng đều được triển khai
từ đầu theo cách có lợi cho thư viện này. Ngoại lệ duy nhất là một số script trong thư mục 
[examples](https://github.com/Chris-hughes10/pytorch-accelerated/tree/main/examples)
trong đó các tài nguyên hiện có được lấy và chỉnh sửa nhằm trình diễn các tính năng của `pytorch-accelerated`;
các trường hợp này đều được đánh dấu rõ ràng, với sự ghi nhận dành cho tác giả gốc.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---