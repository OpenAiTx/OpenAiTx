<!---
Bản quyền 2020 Nhóm HuggingFace. Đã đăng ký mọi quyền.

Được cấp phép theo Giấy phép Apache, Phiên bản 2.0 ("Giấy phép");
bạn không được sử dụng tệp này ngoại trừ tuân thủ Giấy phép.
Bạn có thể lấy một bản sao của Giấy phép tại

    http://www.apache.org/licenses/LICENSE-2.0

Trừ khi luật pháp yêu cầu hoặc được đồng ý bằng văn bản, phần mềm
phân phối theo Giấy phép này được phân phối "NGUYÊN TRẠNG",
KHÔNG CÓ BẤT KỲ BẢO ĐẢM NÀO, cả rõ ràng lẫn ngụ ý.
Xem Giấy phép để biết các quy định về quyền hạn và
giới hạn theo Giấy phép.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Thư viện Hugging Face Transformers" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints trên Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Tài liệu" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="Phát hành trên GitHub" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>Mô hình pretrained tiên tiến nhất cho suy luận và huấn luyện</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers là một thư viện các mô hình văn bản, thị giác máy tính, âm thanh, video và đa phương thức đã được huấn luyện sẵn cho mục đích suy luận và huấn luyện. Sử dụng Transformers để tinh chỉnh mô hình trên dữ liệu của bạn, xây dựng các ứng dụng suy luận và cho các trường hợp sử dụng AI tạo sinh trên nhiều phương thức khác nhau.

Có hơn 500.000+ [checkpoint mô hình](https://huggingface.co/models?library=transformers&sort=trending) Transformers trên [Hugging Face Hub](https://huggingface.com/models) mà bạn có thể sử dụng.

Khám phá [Hub](https://huggingface.com/) ngay hôm nay để tìm một mô hình và sử dụng Transformers để bắt đầu ngay lập tức.

## Cài đặt

Transformers làm việc với Python 3.9+ [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+, và [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Tạo và kích hoạt một môi trường ảo với [venv](https://docs.python.org/3/library/venv.html) hoặc [uv](https://docs.astral.sh/uv/), một trình quản lý gói và dự án Python nhanh dựa trên Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Cài đặt Transformers trong môi trường ảo của bạn.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Cài đặt Transformers từ mã nguồn nếu bạn muốn cập nhật những thay đổi mới nhất của thư viện hoặc có ý định đóng góp phát triển. Tuy nhiên, phiên bản *mới nhất* có thể không ổn định. Hãy mở [issue](https://github.com/huggingface/transformers/issues) nếu bạn gặp lỗi.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Khởi động nhanh

Bắt đầu với Transformers ngay lập tức với API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). `Pipeline` là một lớp suy luận cấp cao hỗ trợ các tác vụ văn bản, âm thanh, thị giác và đa phương thức. Nó xử lý tiền xử lý đầu vào và trả về đầu ra phù hợp.

Khởi tạo một pipeline và chỉ định mô hình sử dụng cho sinh văn bản. Mô hình sẽ được tải về và lưu vào bộ nhớ đệm để có thể sử dụng lại dễ dàng. Cuối cùng, truyền vào một đoạn văn bản để mô hình sinh kết quả.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Để trò chuyện với một mô hình, cách sử dụng cũng tương tự. Sự khác biệt duy nhất là bạn cần xây dựng lịch sử hội thoại (đầu vào cho `Pipeline`) giữa bạn và hệ thống.

> [!TIP]
> Bạn cũng có thể trò chuyện với mô hình trực tiếp từ dòng lệnh.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Bạn là một robot hài hước, trả treo như tưởng tượng của Hollywood năm 1986."},
    {"role": "user", "content": "Này, bạn có thể gợi ý vài điều thú vị để làm ở New York không?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Mở rộng các ví dụ bên dưới để xem `Pipeline` hoạt động với các phương thức và tác vụ khác nhau như thế nào.

<details>
<summary>Nhận diện giọng nói tự động</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Phân loại hình ảnh</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>Hỏi đáp hình ảnh</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## Tại sao nên sử dụng Transformers?

1. Mô hình tiên tiến dễ sử dụng:
    - Hiệu năng cao đối với các tác vụ hiểu & sinh ngôn ngữ tự nhiên, thị giác máy tính, âm thanh, video và đa phương thức.
    - Giảm rào cản cho các nhà nghiên cứu, kỹ sư và lập trình viên.
    - Chỉ cần học ba lớp trừu tượng hướng người dùng.
    - API thống nhất cho tất cả các mô hình đã huấn luyện sẵn.

1. Giảm chi phí tính toán, giảm dấu chân carbon:
    - Chia sẻ mô hình đã huấn luyện thay vì huấn luyện lại từ đầu.
    - Giảm thời gian tính toán và chi phí sản xuất.
    - Hàng chục kiến trúc mô hình với hơn 1 triệu checkpoint pretrained trên mọi phương thức.

1. Tự do chọn framework phù hợp cho mọi giai đoạn vòng đời mô hình:
    - Huấn luyện mô hình tiên tiến chỉ với 3 dòng lệnh.
    - Dễ dàng chuyển mô hình giữa PyTorch/JAX/TF2.0.
    - Chọn framework phù hợp cho huấn luyện, đánh giá và sản xuất.

1. Dễ dàng tùy chỉnh mô hình hoặc ví dụ cho nhu cầu của bạn:
    - Cung cấp ví dụ cho từng kiến trúc để tái tạo kết quả đã công bố.
    - Lõi mô hình được lộ ra một cách nhất quán.
    - File mô hình có thể dùng độc lập với thư viện để thử nghiệm nhanh.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Khi nào KHÔNG nên sử dụng Transformers?

- Thư viện này không phải là một bộ công cụ mô-đun các khối xây dựng mạng nơ-ron. Mã nguồn trong file mô hình không được tái cấu trúc với các trừu tượng bổ sung, nhằm giúp các nhà nghiên cứu có thể thử nghiệm nhanh trên từng mô hình mà không cần đi sâu vào nhiều lớp trừu tượng/file khác.
- API huấn luyện được tối ưu để làm việc với mô hình PyTorch mà Transformers cung cấp. Nếu cần vòng lặp máy học tổng quát, bạn nên dùng thư viện khác như [Accelerate](https://huggingface.co/docs/accelerate).
- [Các script ví dụ](https://github.com/huggingface/transformers/tree/main/examples) chỉ là *ví dụ*. Chúng có thể không hoạt động ngay với trường hợp sử dụng của bạn và bạn cần điều chỉnh lại mã nguồn.

## 100 dự án sử dụng Transformers

Transformers không chỉ là một bộ công cụ sử dụng mô hình pretrained, mà còn là một cộng đồng các dự án xây dựng xung quanh nó và
Hugging Face Hub. Chúng tôi muốn Transformers giúp các lập trình viên, nhà nghiên cứu, sinh viên, giảng viên, kỹ sư, và bất kỳ ai khác xây dựng dự án mơ ước của họ.

Để kỷ niệm Transformers đạt 100.000 stars, chúng tôi muốn tôn vinh cộng đồng với trang [awesome-transformers](./awesome-transformers.md) liệt kê 100 dự án tuyệt vời xây dựng bằng Transformers.

Nếu bạn sở hữu hoặc sử dụng một dự án xứng đáng nằm trong danh sách này, hãy mở PR để bổ sung nhé!

## Một số mô hình ví dụ

Bạn có thể thử hầu hết các mô hình trực tiếp trên [trang mô hình trên Hub](https://huggingface.co/models).

Mở rộng từng phương thức bên dưới để xem một số mô hình ví dụ cho các trường hợp sử dụng khác nhau.

<details>
<summary>Âm thanh</summary>

- Phân loại âm thanh với [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Nhận diện giọng nói tự động với [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Phát hiện từ khóa với [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Chuyển đổi lời nói sang lời nói với [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Văn bản sang âm thanh với [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Văn bản sang giọng nói với [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Thị giác máy tính</summary>

- Sinh mặt nạ tự động với [SAM](https://huggingface.co/facebook/sam-vit-base)
- Ước lượng độ sâu với [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Phân loại hình ảnh với [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Phát hiện keypoint với [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Ghép keypoint với [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Phát hiện vật thể với [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Ước lượng tư thế với [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Phân đoạn đa năng với [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Phân loại video với [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Đa phương thức</summary>

- Âm thanh hoặc văn bản sang văn bản với [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Hỏi đáp tài liệu với [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Hình ảnh hoặc văn bản sang văn bản với [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Sinh chú thích hình ảnh với [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Hiểu tài liệu dựa trên OCR với [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Hỏi đáp bảng với [TAPAS](https://huggingface.co/google/tapas-base)
- Hiểu và sinh đa phương thức thống nhất với [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Thị giác sang văn bản với [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Hỏi đáp hình ảnh với [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Phân đoạn biểu thức tham chiếu hình ảnh với [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>Xử lý ngôn ngữ tự nhiên (NLP)</summary>

- Điền từ thiếu với [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Nhận diện thực thể có tên với [Gemma](https://huggingface.co/google/gemma-2-2b)
- Hỏi đáp với [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Tóm tắt với [BART](https://huggingface.co/facebook/bart-large-cnn)
- Dịch với [T5](https://huggingface.co/google-t5/t5-base)
- Sinh văn bản với [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Phân loại văn bản với [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Trích dẫn

Chúng tôi hiện đã có [bài báo](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) bạn có thể trích dẫn cho thư viện 🤗 Transformers:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---