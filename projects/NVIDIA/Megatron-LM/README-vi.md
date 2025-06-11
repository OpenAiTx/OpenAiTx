<div align="center">

Megatron-LM & Megatron-Core
===========================
<h4>Các kỹ thuật tối ưu hóa GPU để huấn luyện mô hình transformer quy mô lớn</h4>

[![Documentation](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)
[![version](https://img.shields.io/badge/release-0.5.0-green)](./setup.py)
[![license](https://img.shields.io/badge/license-OpenBSD-blue)](./LICENSE)

<div align="left">

# Tin tức mới nhất

- **[2024/7]** Megatron-Core v0.7 cải thiện khả năng mở rộng và độ bền khi huấn luyện, đồng thời bổ sung hỗ trợ huấn luyện đa phương thức ([blog](https://developer.nvidia.com/blog/train-generative-ai-models-more-efficiently-with-new-nvidia-megatron-core-functionalities/)). 
- **[2024/6]** Megatron-Core bổ sung hỗ trợ cho các mô hình dựa trên Mamba. Xem bài báo [An Empirical Study of Mamba-based Language Models](https://arxiv.org/pdf/2406.07887) và [mã ví dụ](https://github.com/NVIDIA/Megatron-LM/tree/ssm/examples/mamba).
- **[2024/1 Announcement]** NVIDIA đã phát hành các khả năng cốt lõi của **Megatron-LM** vào [**Megatron-Core**](https://github.com/NVIDIA/Megatron-LM/tree/main/megatron/core) trong kho lưu trữ này. Megatron-Core mở rộng các kỹ thuật tối ưu hóa GPU của Megatron-LM với nhiều đổi mới tiên tiến về tối ưu hóa ở cấp hệ thống, nổi bật với API dạng module, có thể kết hợp. Khám phá [giới thiệu về Megatron-Core](#megatron-core) để biết thêm chi tiết.

# Mục lục

- [Megatron-LM \& Megatron-Core](#megatron-lm--megatron-core)
- [Tin tức mới nhất](#tin-tuc-moi-nhat)
- [Mục lục](#muc-luc)
- [Tổng quan về Megatron](#tong-quan-ve-megatron)
  - [Megatron-LM](#megatron-lm)
  - [Megatron-Core](#megatron-core)
- [Tốc độ huấn luyện và khả năng mở rộng](#toc-do-huan-luyen-va-kha-nang-mo-rong)
- [Cài đặt](#cai-dat)
  - [Docker (Khuyến nghị)](#docker-khuyen-nghi)
  - [Các lựa chọn cài đặt](#cac-lua-chon-cai-dat)
    - [Cài đặt từ PyPI](#cai-dat-tu-pypi)
    - [Cài đặt từ mã nguồn](#cai-dat-tu-ma-nguon)
  - [Điều kiện tiên quyết](#dieu-kien-tien-quyet)
  - [Tải checkpoint](#tai-checkpoint)
- [Cách sử dụng](#cach-su-dung)
- [Huấn luyện](#huan-luyen)
  - [Tiền xử lý dữ liệu](#tien-xu-ly-du-lieu)
  - [Tiền huấn luyện BERT](#tien-huan-luyen-bert)
  - [Tiền huấn luyện GPT](#tien-huan-luyen-gpt)
  - [Tiền huấn luyện T5](#tien-huan-luyen-t5)
  - [Tiền huấn luyện phân tán](#tien-huan-luyen-phan-tan)
  - [Checkpoint hóa kích hoạt và tái tính toán](#checkpoint-hoa-kich-hoat-va-tai-tinh-toan)
  - [Tối ưu hóa phân tán](#toi-uu-hoa-phan-tan)
  - [FlashAttention](#flashattention)
  - [Ví dụ GPT-3](#vi-du-gpt-3)
  - [Retro và InstructRetro](#retro-va-instructretro)
  - [Mô hình ngôn ngữ dựa trên Mamba](#mo-hinh-ngon-ngu-dua-tren-mamba)
  - [Mixture of Experts](#mixture-of-experts)
- [Đánh giá và các tác vụ](#danh-gia-va-cac-tac-vu)
  - [Sinh văn bản GPT](#sinh-van-ban-gpt)
    - [Giảm độc GPT qua tự sinh](#giam-doc-gpt-qua-tu-sinh)
  - [Đánh giá GPT](#danh-gia-gpt)
    - [Đánh giá perplexity WikiText](#danh-gia-perplexity-wikitext)
    - [Độ chính xác LAMBADA Cloze](#do-chinh-xac-lambada-cloze)
  - [Đánh giá tác vụ BERT](#danh-gia-tac-vu-bert)
    - [Đánh giá RACE](#danh-gia-race)
    - [Đánh giá MNLI](#danh-gia-mnli)
  - [Suy luận và tinh chỉnh Llama-2](#suy-luan-va-tinh-chinh-llama-2)
- [Tối ưu hóa và triển khai mô hình](#toi-uu-hoa-va-trien-khai-mo-hinh)
  - [Lượng tử hóa và triển khai TensorRT-LLM](#luong-tu-hoa-va-trien-khai-tensorrt-llm)
- [Bộ dữ liệu](#bo-du-lieu)
  - [Thu thập dữ liệu huấn luyện Wikipedia](#thu-thap-du-lieu-huan-luyen-wikipedia)
  - [Thu thập dữ liệu Webtext cho GPT](#thu-thap-du-lieu-webtext-cho-gpt)
- [Tái lập kết quả](#tai-lap-ket-qua)
- [Chuyển đổi checkpoint](#chuyen-doi-checkpoint)
  - [Chuyển đổi lớp mô hình](#chuyen-doi-lop-mo-hinh)
  - [Chuyển đổi định dạng checkpoint](#chuyen-doi-dinh-dang-checkpoint)
- [Các dự án sử dụng Megatron](#cac-du-an-su-dung-megatron)

# Tổng quan về Megatron
Kho lưu trữ này bao gồm hai thành phần chính: **Megatron-LM** và **Megatron-Core**. Megatron-LM đóng vai trò là framework nghiên cứu sử dụng Megatron-Core để huấn luyện các mô hình ngôn ngữ lớn (LLM). Ngược lại, Megatron-Core là một thư viện các kỹ thuật huấn luyện tối ưu hóa GPU, đi kèm với hỗ trợ sản phẩm chính thức, bao gồm các API phiên bản hóa và phát hành định kỳ. Bạn có thể sử dụng Megatron-Core cùng với Megatron-LM hoặc [Nvidia NeMo Framework](https://docs.nvidia.com/deeplearning/nemo/user-guide/docs/en/main/nlp/nemo_megatron/mcore_customization.html) cho giải pháp trọn gói, cloud-native. Ngoài ra, bạn có thể tích hợp các khối xây dựng của Megatron-Core vào framework huấn luyện yêu thích của mình.

## Megatron-LM
Được giới thiệu lần đầu vào năm 2019, Megatron ([1](https://arxiv.org/pdf/1909.08053.pdf), [2](https://arxiv.org/pdf/2104.04473.pdf), và [3](https://arxiv.org/pdf/2205.05198)) đã khơi dậy làn sóng đổi mới trong cộng đồng AI, cho phép các nhà nghiên cứu và phát triển tận dụng nền tảng của thư viện này để thúc đẩy tiến bộ LLM. Hiện nay, nhiều framework phát triển LLM phổ biến nhất đã được lấy cảm hứng và xây dựng trực tiếp dựa trên thư viện mã nguồn mở Megatron-LM, thúc đẩy làn sóng mô hình nền tảng và các startup AI. Một số framework LLM nổi bật được xây dựng dựa trên Megatron-LM bao gồm [Colossal-AI](https://github.com/hpcaitech/ColossalAI), [HuggingFace Accelerate](https://github.com/huggingface/accelerate), và [NVIDIA NeMo Framework](https://www.nvidia.com/en-us/ai-data-science/generative-ai/nemo-framework/). Danh sách các dự án sử dụng trực tiếp Megatron có thể xem [tại đây](#cac-du-an-su-dung-megatron).

## Megatron-Core
Megatron-Core là thư viện mã nguồn mở dựa trên PyTorch, chứa các kỹ thuật tối ưu hóa GPU và các tối ưu hóa hệ thống tiên tiến. Nó trừu tượng hóa các kỹ thuật này thành các API dạng module, có thể kết hợp, cho phép các nhà phát triển và nghiên cứu mô hình linh hoạt huấn luyện các transformer tùy chỉnh ở quy mô lớn trên hạ tầng tính toán tăng tốc NVIDIA. Thư viện này tương thích với tất cả GPU NVIDIA Tensor Core, bao gồm hỗ trợ tăng tốc FP8 cho [kiến trúc NVIDIA Hopper](https://www.nvidia.com/en-us/data-center/technologies/hopper-architecture/). 

Megatron-Core cung cấp các khối xây dựng cốt lõi như cơ chế attention, khối và lớp transformer, các lớp chuẩn hóa và kỹ thuật embedding. Các tính năng bổ sung như tái tính toán kích hoạt, checkpoint phân tán cũng được tích hợp sẵn trong thư viện. Các khối xây dựng và chức năng đều được tối ưu hóa GPU, có thể xây dựng với các chiến lược song song hóa tiên tiến để đạt tốc độ huấn luyện và độ ổn định tối ưu trên hạ tầng tăng tốc NVIDIA. Một thành phần quan trọng khác của Megatron-Core là các kỹ thuật song song hóa mô hình tiên tiến (song song tensor, chuỗi, pipeline, ngữ cảnh và song song chuyên gia MoE).

Megatron-Core có thể sử dụng cùng với [NVIDIA NeMo](https://www.nvidia.com/en-us/ai-data-science/products/nemo/), nền tảng AI cấp doanh nghiệp. Ngoài ra, bạn có thể khám phá Megatron-Core với vòng lặp huấn luyện PyTorch gốc [tại đây](https://github.com/NVIDIA/Megatron-LM/tree/main/examples). Xem thêm tại [tài liệu Megatron-Core](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html).


# Tốc độ huấn luyện và khả năng mở rộng
Bộ mã nguồn của chúng tôi có thể huấn luyện hiệu quả các mô hình ngôn ngữ lớn (tức là các mô hình với hàng trăm tỷ tham số) với cả song song hóa mô hình và dữ liệu. Để minh họa khả năng mở rộng với nhiều GPU và kích thước mô hình, chúng tôi xét các mô hình GPT từ 2 tỷ tham số đến 462 tỷ tham số. Tất cả các mô hình sử dụng kích thước từ vựng 131.072 và độ dài chuỗi 4096. Chúng tôi thay đổi kích thước ẩn, số lượng đầu attention và số tầng để có được kích thước mô hình cụ thể. Khi kích thước mô hình tăng, chúng tôi cũng tăng nhẹ batch size. Các thí nghiệm sử dụng tối đa 6144 GPU [H100](https://www.nvidia.com/en-us/data-center/h100/). Chúng tôi thực hiện chồng chéo mịn giữa giao tiếp song song dữ liệu (`--overlap-grad-reduce --overlap-param-gather`), song song tensor (`--tp-comm-overlap`) và song song pipeline (bật mặc định) với tính toán để cải thiện khả năng mở rộng. Thông lượng báo cáo là đo cho toàn bộ quá trình huấn luyện và bao gồm tất cả các thao tác như tải dữ liệu, bước tối ưu hóa, giao tiếp và cả ghi log. Lưu ý rằng các mô hình này chưa được huấn luyện đến hội tụ.

![Bảng mô hình](images/model_table.png)

Kết quả weak scaling của chúng tôi cho thấy khả năng mở rộng siêu tuyến tính (MFU tăng từ 41% với mô hình nhỏ nhất lên 47-48% với các mô hình lớn nhất); điều này là do GEMM lớn hơn có cường độ số học cao hơn và do đó thực thi hiệu quả hơn.

![Weak scaling](images/weak_scaling.png)

Chúng tôi cũng strong scale mô hình GPT-3 chuẩn (phiên bản của chúng tôi có hơn 175 tỷ tham số một chút do kích thước từ vựng lớn hơn) từ 96 GPU H100 lên 4608 GPU, giữ nguyên batch size là 1152 chuỗi trong suốt quá trình. Giao tiếp trở nên rõ rệt hơn ở quy mô lớn, dẫn tới giảm MFU từ 47% xuống 42%.

![Strong scaling](images/strong_scaling.png)


# Cài đặt

## Docker (Khuyến nghị)

Chúng tôi khuyến nghị mạnh mẽ sử dụng bản phát hành trước của [PyTorch NGC Container](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/pytorch) thay vì bản mới nhất. Các bản phát hành của chúng tôi luôn dựa trên container NGC của tháng trước, do đó đảm bảo tương thích và ổn định. Container này đã cài đặt sẵn tất cả phụ thuộc với phiên bản phù hợp và cấu hình tối ưu cho GPU NVIDIA. 

```bash
# Kéo container NGC bản trước (thay 25.04 bằng phiên bản tháng trước)
docker pull nvcr.io/nvidia/pytorch:25.04-py3
```

```bash
# Chạy container với các thư mục được mount
docker run --gpus all -it --rm \
  -v /path/to/megatron:/workspace/megatron \
  -v /path/to/dataset:/workspace/dataset \
  -v /path/to/checkpoints:/workspace/checkpoints \
  nvcr.io/nvidia/pytorch:25.04-py3
```

## Các lựa chọn cài đặt

### Điều kiện tiên quyết

- PyTorch (phiên bản ổn định mới nhất)
- CUDA, cuDNN, NCCL (phiên bản ổn định mới nhất)
- Hỗ trợ FP8 trên GPU NVIDIA Hopper, Ada, và Blackwell
- Để có hiệu suất tốt nhất, sử dụng GPU NVIDIA từ thế hệ Turing trở lên

### Cài đặt từ PyPI

Để cài đặt phiên bản ổn định mới nhất với pip:

```bash
# Cài đặt bản phát hành mới nhất
pip install megatron-core
```

### Cài đặt từ mã nguồn

```bash
# Clone kho lưu trữ
git clone https://github.com/NVIDIA/Megatron-LM.git
cd Megatron-LM

# Tùy chọn checkout một bản phát hành cụ thể
git checkout v0.11.0

# Cài đặt ở chế độ phát triển
pip install -e .
```

## Tải checkpoint
Chúng tôi đã cung cấp checkpoint pretrained cho [BERT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_bert_345m) và [GPT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_lm_345m) để đánh giá hoặc tinh chỉnh cho các tác vụ hạ nguồn. Để truy cập các checkpoint này, trước tiên hãy [đăng ký](https://ngc.nvidia.com/signup) và [cài đặt](https://ngc.nvidia.com/setup/installers/cli) NVIDIA GPU Cloud (NGC) Registry CLI. Tham khảo tài liệu hướng dẫn tải mô hình tại [tài liệu NGC](https://docs.nvidia.com/dgx/ngc-registry-cli-user-guide/index.html#topic_6_4_1).

Ngoài ra, bạn có thể tải trực tiếp các checkpoint bằng:

<pre>
BERT-345M-uncased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_uncased/zip -O megatron_bert_345m_v0.1_uncased.zip
BERT-345M-cased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_cased/zip -O megatron_bert_345m_v0.1_cased.zip
GPT-345M: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_lm_345m/versions/v0.0/zip -O megatron_lm_345m_v0.0.zip
</pre>

Các mô hình yêu cầu file từ vựng để chạy. File vocab WordPiece của BERT có thể trích xuất từ các mô hình BERT pretrained của Google: [uncased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-uncased-vocab.txt), [cased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-cased-vocab.txt). File [vocab GPT](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-vocab.json) và [merge table](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-merges.txt) có thể tải trực tiếp.

# Cách sử dụng

Sau khi cài đặt, có một số quy trình làm việc khả thi. Quy trình đầy đủ nhất là:
1. Tiền xử lý dữ liệu
2. Tiền huấn luyện
3. Tinh chỉnh (Tùy chọn cho các tác vụ zero-shot)
4. Đánh giá tác vụ hạ nguồn hoặc sinh văn bản

Tuy nhiên, bước 1 và 2 có thể được thay thế bằng cách sử dụng một trong các mô hình pretrained đã đề cập ở trên.

Chúng tôi đã cung cấp một số script để tiền huấn luyện cả BERT và GPT trong thư mục [`examples`](./examples), cũng như các script cho các tác vụ hạ nguồn zero-shot và fine-tuned bao gồm MNLI, RACE, WikiText103 và đánh giá LAMBADA. Ngoài ra còn có script sinh văn bản tương tác cho GPT.

# Huấn luyện
## Tiền xử lý dữ liệu
Dữ liệu huấn luyện cần được tiền xử lý. Đầu tiên, đặt dữ liệu huấn luyện của bạn ở định dạng json rời, với một json chứa một mẫu văn bản mỗi dòng. Ví dụ:
<pre>
{"src": "www.nvidia.com", "text": "The quick brown fox", "type": "Eng", "id": "0", "title": "First Part"}
{"src": "The Internet", "text": "jumps over the lazy dog", "type": "Eng", "id": "42", "title": "Second Part"}
</pre>

Tên trường `text` trong json có thể thay đổi bằng cờ `--json-key` trong [`preprocess_data.py`](./tools/preprocess_data.py). Các trường metadata khác là tùy chọn và không dùng trong huấn luyện.

Json rời sau đó được xử lý sang định dạng nhị phân để huấn luyện. Để chuyển json sang định dạng mmap, dùng `preprocess_data.py`. Một script ví dụ chuẩn bị dữ liệu cho huấn luyện BERT:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-bert \
       --vocab-file bert-vocab.txt \
       --tokenizer-type BertWordPieceLowerCase \
       --split-sentences
</pre>

Kết quả sẽ là hai file, trong trường hợp này, tên là `my-bert_text_sentence.bin` và `my-bert_text_sentence.idx`. Tham số `--data-path` được chỉ định trong huấn luyện BERT sau này là đường dẫn đầy đủ và tên file mới, nhưng không có phần mở rộng.

Với T5, sử dụng tiền xử lý tương tự như BERT, có thể đổi tên thành:
<pre>
       --output-prefix my-t5 \
</pre>
Một số chỉnh sửa nhỏ cần thiết cho tiền xử lý dữ liệu GPT, cụ thể là bổ sung bảng merge, thêm token kết thúc tài liệu (end-of-document), loại bỏ việc tách câu, và thay đổi loại tokenizer:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-gpt2 \
       --vocab-file gpt2-vocab.json \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file gpt2-merges.txt \
       --append-eod
</pre>

Ở đây, các file đầu ra sẽ được đặt tên là `my-gpt2_text_document.bin` và `my-gpt2_text_document.idx`. Như trước đây, trong quá trình huấn luyện GPT, sử dụng tên dài hơn mà không có phần mở rộng làm `--data-path`.

Các tham số dòng lệnh bổ sung được mô tả trong file nguồn [`preprocess_data.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/preprocess_data.py).

## Huấn luyện trước BERT


Script [`examples/bert/train_bert_340m_distributed.sh`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/bert/train_bert_340m_distributed.sh) chạy huấn luyện trước BERT 345M tham số trên một GPU đơn. Việc debug là mục đích chính cho huấn luyện trên một GPU, vì code và tham số dòng lệnh đã được tối ưu cho huấn luyện phân tán quy mô lớn. Hầu hết các tham số đều khá dễ hiểu. Mặc định, learning rate sẽ giảm tuyến tính qua các vòng lặp huấn luyện bắt đầu từ `--lr` đến giá trị tối thiểu do `--min-lr` thiết lập qua số vòng lặp `--lr-decay-iters`. Tỷ lệ số vòng lặp huấn luyện dùng để warmup được thiết lập bởi `--lr-warmup-fraction`. Dù đây là huấn luyện một GPU, batch size được chỉ định bởi `--micro-batch-size` là batch size cho một lượt forward-backward, và code sẽ tích lũy gradient cho đến khi đạt `global-batch-size`, chính là batch size trên mỗi vòng lặp. Dữ liệu được chia theo tỷ lệ 949:50:1 cho train/validation/test (mặc định là 969:30:1). Việc chia này diễn ra động, nhưng nhất quán qua các lần chạy với cùng random seed (mặc định là 1234, hoặc chỉ định thủ công bằng `--seed`). Chúng tôi dùng `train-iters` làm số vòng lặp huấn luyện yêu cầu. Ngoài ra, có thể cung cấp `--train-samples` là tổng số mẫu sẽ huấn luyện. Nếu sử dụng tùy chọn này, thay vì chỉ định `--lr-decay-iters`, bạn cần chỉ định `--lr-decay-samples`.

Các tùy chọn log, lưu checkpoint và khoảng đánh giá được chỉ định rõ. Lưu ý rằng `--data-path` hiện bao gồm hậu tố `_text_sentence` thêm vào trong bước tiền xử lý, nhưng không có phần mở rộng file.

Các tham số dòng lệnh bổ sung được mô tả trong file nguồn [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

Để chạy `train_bert_340m_distributed.sh`, hãy chỉnh sửa tùy ý, bao gồm thiết lập biến môi trường cho `CHECKPOINT_PATH`, `VOCAB_FILE`, và `DATA_PATH`. Đảm bảo đặt các biến này đúng đường dẫn trong container. Sau đó, khởi động container với Megatron và các đường dẫn cần thiết đã mount (như giải thích trong [Setup](#setup)) và chạy script ví dụ.

## Huấn luyện trước GPT

Script `examples/gpt3/train_gpt3_175b_distributed.sh` chạy huấn luyện trước GPT 345M tham số trên một GPU đơn. Như đã đề cập ở trên, huấn luyện một GPU chủ yếu dành cho mục đích debug, vì code được tối ưu cho huấn luyện phân tán.

Nó có định dạng phần lớn giống script BERT trước đó với một số khác biệt đáng chú ý: hệ thống tokenization sử dụng là BPE (yêu cầu bảng merge và file vocab dạng `json`) thay vì WordPiece, kiến trúc mô hình cho phép chuỗi dài hơn (lưu ý rằng embedding vị trí tối đa phải lớn hơn hoặc bằng chiều dài chuỗi tối đa), và `--lr-decay-style` đã được đặt thành cosine decay. Lưu ý rằng `--data-path` hiện bao gồm hậu tố `_text_document` thêm vào trong tiền xử lý, nhưng không có phần mở rộng file.

Các tham số dòng lệnh bổ sung được mô tả trong file nguồn [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

`train_gpt3_175b_distributed.sh` có thể chạy tương tự như hướng dẫn cho BERT. Thiết lập biến môi trường và các chỉnh sửa khác, khởi động container với các mount phù hợp, và chạy script.
Xem chi tiết hơn tại [`examples/gpt3/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/gpt3/README.md)

## Huấn luyện trước T5

Rất giống với BERT và GPT, script `examples/t5/train_t5_220m_distributed.sh` chạy huấn luyện trước T5 "base" (~220M tham số) trên một GPU đơn. Khác biệt chính với BERT và GPT là bổ sung các tham số sau để đáp ứng kiến trúc T5:

* `--kv-channels` thiết lập kích thước trong của ma trận "key" và "value" cho tất cả các cơ chế attention trong mô hình. Với BERT và GPT, mặc định là kích thước ẩn chia cho số đầu attention, nhưng có thể cấu hình cho T5.

* `--ffn-hidden-size` thiết lập kích thước ẩn trong mạng feed-forward bên trong lớp transformer. Với BERT và GPT, mặc định là 4 lần kích thước ẩn transformer, nhưng có thể cấu hình cho T5.

* `--encoder-seq-length` và `--decoder-seq-length` thiết lập chiều dài chuỗi cho encoder và decoder riêng biệt.

Các tham số khác vẫn giữ nguyên như BERT và GPT. Chạy ví dụ này với các bước giống như đã mô tả cho các script khác.

Xem chi tiết hơn tại [`examples/t5/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/t5/README.md)

## Huấn luyện phân tán

Các script `pretrain_{bert,gpt,t5}_distributed.sh` sử dụng PyTorch distributed launcher cho huấn luyện phân tán. Do đó, huấn luyện nhiều node có thể đạt được bằng cách thiết lập đúng các biến môi trường. Xem tài liệu chính thức của PyTorch [tại đây](https://pytorch.org/docs/stable/elastic/run.html#launcher-api) cho mô tả chi tiết về các [biến môi trường](https://pytorch.org/docs/stable/distributed.html#environment-variable-initialization). Mặc định, huấn luyện nhiều node sử dụng backend phân tán [nccl](https://developer.nvidia.com/nccl). Chỉ cần một số tham số bổ sung và sử dụng module phân tán của PyTorch với elastic launcher `torchrun` (tương đương với `python -m torch.distributed.run`) là đủ để sử dụng huấn luyện phân tán. Xem bất kỳ script nào trong `pretrain_{bert,gpt,t5}_distributed.sh` để biết thêm chi tiết.

Chúng tôi sử dụng hai loại song song: song song dữ liệu và song song mô hình. Việc triển khai song song dữ liệu nằm trong `megatron/core/distributed`, và hỗ trợ chồng lắp quá trình giảm gradient với backward pass khi sử dụng tùy chọn dòng lệnh `--overlap-grad-reduce`.

Thứ hai, chúng tôi phát triển một phương pháp song song mô hình hai chiều đơn giản và hiệu quả. Để sử dụng chiều thứ nhất, song song tensor model (chia thực thi một module transformer qua nhiều GPU, xem Phần 3 của [bài báo của chúng tôi](https://arxiv.org/pdf/1909.08053.pdf)), thêm cờ `--tensor-model-parallel-size` để xác định số GPU sẽ chia nhỏ mô hình, cùng với các tham số truyền cho distributed launcher như trên. Để sử dụng chiều thứ hai, song song chuỗi, chỉ định `--sequence-parallel`, cũng yêu cầu bật song song mô hình tensor vì nó chia qua cùng các GPU (xem chi tiết tại Phần 4.2.2 của [bài báo](https://arxiv.org/pdf/2205.05198.pdf)).

Để sử dụng song song pipeline model (chia các module transformer thành các stage với số module transformer bằng nhau trên mỗi stage, sau đó thực thi pipeline bằng cách chia batch thành các microbatch nhỏ hơn, xem Phần 2.2 của [bài báo](https://arxiv.org/pdf/2104.04473.pdf)), sử dụng cờ `--pipeline-model-parallel-size` để xác định số stage chia mô hình (ví dụ, chia mô hình 24 lớp transformer qua 4 stage, mỗi stage có 6 lớp transformer).

Chúng tôi có các ví dụ sử dụng hai dạng song song mô hình này trong các script ví dụ kết thúc bằng `distributed_with_mp.sh`.

Ngoài các thay đổi nhỏ này, huấn luyện phân tán giống hệt như huấn luyện trên một GPU đơn.

Lịch trình pipeline interleaved (xem chi tiết tại Phần 2.2.2 của [bài báo](https://arxiv.org/pdf/2104.04473.pdf)) có thể kích hoạt bằng tham số `--num-layers-per-virtual-pipeline-stage`, kiểm soát số lớp transformer trong một virtual stage (mặc định không interleaved, mỗi GPU sẽ chạy một virtual stage duy nhất với `NUM_LAYERS / PIPELINE_MP_SIZE` lớp transformer). Tổng số lớp trong mô hình transformer phải chia hết cho giá trị tham số này. Ngoài ra, số microbatch trong pipeline (tính bằng `GLOBAL_BATCH_SIZE / (DATA_PARALLEL_SIZE * MICRO_BATCH_SIZE)`) phải chia hết cho `PIPELINE_MP_SIZE` khi dùng lịch trình này (điều kiện này được kiểm tra trong code). Lịch trình interleaved không hỗ trợ pipeline với 2 stage (`PIPELINE_MP_SIZE=2`).

## Checkpoint hóa kích hoạt và tính toán lại (Activation Checkpointing and Recomputation)

Để giảm sử dụng bộ nhớ GPU khi huấn luyện mô hình lớn, chúng tôi hỗ trợ nhiều dạng checkpoint hóa kích hoạt và tính toán lại. Thay vì lưu tất cả các activation trong bộ nhớ để dùng khi backprop, như truyền thống trong các mô hình deep learning, chỉ các activation tại một số "checkpoint" nhất định trong mô hình mới được giữ lại (hoặc lưu trữ) trong bộ nhớ, còn các activation khác sẽ được tính toán lại khi cần trong backprop. Lưu ý loại checkpoint này, *activation* checkpointing, khác hoàn toàn với checkpoint tham số mô hình và trạng thái optimizer được đề cập ở nơi khác.

Chúng tôi hỗ trợ hai mức độ hạt mịn của tính toán lại: `selective` và `full`. Tính toán lại chọn lọc (selective) là mặc định và được khuyến nghị trong hầu hết trường hợp. Chế độ này giữ trong bộ nhớ các activation chiếm ít bộ nhớ và tốn nhiều chi phí tính toán lại, còn các activation chiếm nhiều bộ nhớ nhưng rẻ để tính toán lại thì sẽ được tính lại. Xem [bài báo của chúng tôi](https://arxiv.org/pdf/2205.05198) để biết chi tiết. Bạn sẽ thấy chế độ này tối ưu hiệu suất đồng thời giảm thiểu bộ nhớ cần thiết để lưu activation. Để bật recompute activation chọn lọc, chỉ cần dùng `--recompute-activations`.

Trong trường hợp bộ nhớ rất hạn chế, tính toán lại toàn phần (`full`) chỉ lưu đầu vào của một lớp transformer, hoặc một nhóm, hoặc một block các lớp transformer, và tính toán lại phần còn lại. Để bật recompute activation toàn phần, dùng `--recompute-granularity full`. Khi dùng recompute toàn phần, có hai phương pháp: `uniform` và `block`, chọn bằng tham số `--recompute-method`.

* Phương pháp `uniform` chia đều các lớp transformer thành các nhóm (mỗi nhóm có kích thước `--recompute-num-layers`) và lưu activation đầu vào của mỗi nhóm trong bộ nhớ. Kích thước nhóm mặc định là 1, khi đó activation đầu vào của từng lớp transformer sẽ được lưu. Khi bộ nhớ GPU không đủ, tăng số lớp mỗi nhóm sẽ giảm sử dụng bộ nhớ, cho phép huấn luyện mô hình lớn hơn. Ví dụ, khi `--recompute-num-layers` là 4, chỉ lưu activation đầu vào của mỗi nhóm 4 lớp transformer.

* Phương pháp `block` tính toán lại activation đầu vào của số lớp transformer nhất định (do `--recompute-num-layers` chỉ định) cho mỗi pipeline stage và lưu activation đầu vào của các lớp còn lại trong stage. Giảm `--recompute-num-layers` đồng nghĩa lưu activation đầu vào của nhiều lớp hơn, giảm tính toán lại activation khi backprop, cải thiện hiệu suất huấn luyện nhưng tăng dùng bộ nhớ. Ví dụ, khi chỉ định tính toán lại 5 lớp trên tổng 8 lớp mỗi pipeline stage, chỉ activation đầu vào của 5 lớp đầu được tính toán lại, còn 3 lớp cuối sẽ được lưu. `--recompute-num-layers` có thể tăng dần cho đến khi lượng bộ nhớ vừa đủ để mô hình chạy, nhờ đó tận dụng tối đa bộ nhớ và tối ưu hiệu suất.


## Distributed Optimizer

Sử dụng: `--use-distributed-optimizer`. Tương thích với mọi loại mô hình và dữ liệu.

Distributed optimizer là một kỹ thuật tiết kiệm bộ nhớ, trong đó trạng thái optimizer được phân phối đều qua các rank song song dữ liệu (so với cách truyền thống là nhân bản trạng thái optimizer trên mọi rank song song dữ liệu). Như mô tả trong [ZeRO: Memory Optimizations Toward Training Trillion Parameter Models](https://arxiv.org/abs/1910.02054), triển khai của chúng tôi phân phối tất cả trạng thái optimizer không trùng với trạng thái mô hình. Ví dụ, khi dùng tham số mô hình fp16, distributed optimizer duy trì bản sao riêng biệt của tham số & gradient fp32, được phân phối qua các rank DP. Khi dùng tham số mô hình bf16, gradient fp32 chính của distributed optimizer giống với gradient fp32 của mô hình, nên gradient này không được phân phối (dù tham số fp32 chính vẫn được phân phối vì tách biệt với tham số mô hình bf16).

Lý thuyết tiết kiệm bộ nhớ thay đổi tùy thuộc vào kiểu dữ liệu tham số và gradient của mô hình. Trong triển khai của chúng tôi, số byte lý thuyết trên mỗi tham số là (với 'd' là kích thước song song dữ liệu):

| | Non-distributed optim | Distributed optim |
|-|-|-|
| fp16 param, fp16 grads | 20 | 4 + 16/d |
| bf16 param, fp32 grads | 18 | 6 + 12/d |
| fp32 param, fp32 grads | 16 | 8 + 8/d |

Như với song song dữ liệu thông thường, overlapping giảm gradient (trong trường hợp này là reduce-scatter) với backward pass có thể thực hiện bằng flag `--overlap-grad-reduce`. Ngoài ra, overlapping all-gather tham số có thể thực hiện đồng thời với forward pass bằng `--overlap-param-gather`.

## FlashAttention

Sử dụng: `--use-flash-attn`. Hỗ trợ kích thước attention head tối đa 128.

[FlashAttention](https://github.com/HazyResearch/flash-attention) là một thuật toán nhanh và tiết kiệm bộ nhớ để tính attention chính xác. Nó tăng tốc huấn luyện mô hình và giảm yêu cầu bộ nhớ.

Để cài đặt FlashAttention:
```sh
pip install flash-attn
```

## Ví dụ GPT-3

Trong `examples/gpt3/train_gpt3_175b_distributed.sh` chúng tôi cung cấp ví dụ cấu hình Megatron để huấn luyện [GPT-3](https://arxiv.org/abs/2005.14165) với 175 tỷ tham số trên 1024 GPU. Script này thiết kế cho [slurm](https://slurm.schedmd.com/documentation.html) với plugin [pyxis](https://github.com/NVIDIA/pyxis) nhưng dễ dàng chuyển đổi sang các trình quản lý khác. Nó sử dụng song song tensor 8 chiều và song song pipeline 16 chiều. Với các tùy chọn `global-batch-size 1536` và `rampup-batch-size 16 16 5859375`, huấn luyện sẽ bắt đầu với global batch size 16 và tăng tuyến tính đến 1536 qua 5.859.375 mẫu với bước tăng là 16. Bộ dữ liệu huấn luyện có thể là một tập đơn hoặc nhiều tập kết hợp với trọng số.

Với batch size tối đa 1536 trên 1024 GPU A100, mỗi vòng lặp mất khoảng 32 giây, đạt 138 teraFLOPs mỗi GPU, tương đương 44% FLOPs cực đại lý thuyết.

## Retro và InstructRetro


Retro [(Borgeaud et al., 2022)](https://arxiv.org/abs/2112.04426) là mô hình ngôn ngữ tự hồi tiếp chỉ decoder được huấn luyện trước với retrieval-augmentation.
Retro có khả năng mở rộng thực tế để hỗ trợ huấn luyện lớn từ đầu bằng cách truy xuất từ hàng nghìn tỷ token.
Huấn luyện trước có retrieval cung cấp cơ chế lưu trữ thông tin hiệu quả hơn, so với việc lưu trữ thông tin trong tham số mạng, giúp giảm đáng kể số lượng tham số mô hình trong khi đạt perplexity thấp hơn GPT truyền thống.
Retro cũng linh hoạt trong việc cập nhật
kiến thức lưu trữ trong LM [(Wang et al., 2023a)](https://arxiv.org/abs/2304.06762)
bằng cách cập nhật cơ sở dữ liệu retrieval mà không cần huấn luyện lại LM.

InstructRetro [(Wang et al., 2023b)](https://arxiv.org/abs/2310.07713) còn mở rộng kích thước Retro lên 48B, là LLM lớn nhất được huấn luyện trước với retrieval (tính đến tháng 12/2023).
Mô hình nền tảng thu được, Retro 48B, vượt trội đáng kể so với GPT cùng quy mô về perplexity.
Với fine-tuning theo chỉ dẫn trên Retro, InstructRetro cho thấy cải thiện đáng kể so với GPT đã fine-tune chỉ dẫn trên các tác vụ downstream ở chế độ zero-shot. Cụ thể, mức cải thiện trung bình của InstructRetro là 7% so với GPT trên 8 tác vụ QA ngắn, và 10% so với GPT trên 4 tác vụ QA dài khó. Chúng tôi cũng nhận thấy có thể loại bỏ encoder khỏi kiến trúc InstructRetro và sử dụng trực tiếp backbone decoder InstructRetro như GPT mà vẫn đạt kết quả tương đương.

Trong repo này, chúng tôi cung cấp hướng dẫn tái hiện toàn diện để triển khai Retro và InstructRetro, bao gồm
- **Xây dựng cơ sở dữ liệu retrieval**, hỗ trợ hàng tỷ hoặc hàng nghìn tỷ token cho retrieval database quy mô lớn.
- **Huấn luyện trước với retrieval**, hỗ trợ huấn luyện từ đầu và huấn luyện tiếp từ mô hình GPT đã huấn luyện (Retro-fitting).
- **Instruction tuning**, chúng tôi cung cấp bộ dữ liệu instruction tuning mã nguồn mở và công thức huấn luyện cho instruction tuning trên Retro.
- **Đánh giá tác vụ downstream**, chúng tôi cung cấp script tạo văn bản và đánh giá cho các tác vụ zero-shot question answering.

Xem [tools/retro/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/retro/README.md) để biết tổng quan chi tiết.

## Mô hình ngôn ngữ dựa trên Mamba

Xem [examples/mamba](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/mamba) để biết chi tiết.

<!--
## REALM Pipeline
Chúng tôi đang phát triển hệ thống [REALM](https://arxiv.org/pdf/2002.08909.pdf). Các phần sau sẽ phản ánh ba giai đoạn huấn luyện của nó. Hiện tại mới chỉ có code ICT.
Nói ngắn gọn, các giai đoạn là huấn luyện trước các module truy xuất, sau đó huấn luyện kết hợp mô hình ngôn ngữ và module truy xuất, rồi fine-tune đầu ra trả lời câu hỏi trên mô hình ngôn ngữ với module truy xuất cố định.

### Huấn luyện trước Inverse Cloze Task (ICT)
1. Chuẩn bị tập dữ liệu dạng JSON thô với mục đích tạo bộ sưu tập các block văn bản có kích thước cố định làm đơn vị dữ liệu cơ bản. Với tập như Wikipedia, điều này nghĩa là mỗi block có nhiều câu, nhưng mỗi tài liệu có nhiều block.
Chạy `tools/preprocess_data.py` để tạo một hoặc nhiều tập dữ liệu được đánh chỉ mục với tham số `--split-sentences` để câu là đơn vị cơ bản. Với hệ thống REALM gốc, chúng tôi tạo hai tập, một với tiêu đề của mỗi tài liệu, một với phần thân.
Tham khảo script sau
<pre>
python preprocess_data.py \
    --input /path/to/corpus.json \
    --json-keys text title \
    --split-sentences \
    --tokenizer-type BertWordPieceLowerCase \
    --vocab-file /path/to/vocab.txt \
    --output-prefix corpus_indexed \
    --workers 5  # phù hợp với 10 nhân CPU. Tăng phù hợp nếu có nhiều hơn.
</pre>

2. Sử dụng hàm ánh xạ mẫu tùy chỉnh thay cho `megatron/legacy/data/realm_dataset_utils.get_block_samples_mapping` nếu cần. Để làm điều này, bạn cần cài đặt hàm mới bằng C++ bên trong `megatron/core/datasets/helpers.cpp`. Cấu trúc dữ liệu ánh xạ mẫu được dùng để chọn dữ liệu tạo thành từng mẫu huấn luyện trước khi vào vòng lặp huấn luyện.
Ánh xạ mẫu chịu trách nhiệm lưu trữ tất cả metadata cần thiết để tạo mẫu từ một hoặc nhiều tập dữ liệu đã đánh chỉ mục. Trong REALM, ánh xạ mẫu gồm chỉ mục bắt đầu và kết thúc câu, chỉ mục tài liệu (để lấy đúng tiêu đề cho phần thân) và một ID duy nhất cho mỗi block.
3. Huấn luyện một mô hình ngôn ngữ BERT bằng `pretrain_bert.py`, với chiều dài chuỗi bằng kích thước block tính theo token id. Mô hình này nên được huấn luyện trên tập dữ liệu đã đánh chỉ mục dùng để cung cấp block cho tác vụ retrieval.
Trong REALM, đây là mô hình bert base uncased huấn luyện với hyperparameter chuẩn.
4. Sử dụng `pretrain_ict.py` để huấn luyện `ICTBertModel` dùng hai encoder dựa trên BERT để mã hóa truy vấn và block nhằm thực hiện retrieval.
Script dưới đây huấn luyện mô hình ICT từ REALM. Nó tham chiếu mô hình BERT đã huấn luyện (bước 3) trong tham số `--bert-load`. Batch size dùng trong bài báo là 4096, do đó cần chạy với data parallel world size 32.
<pre>
python pretrain_ict.py \
    --num-layers 12 \
    --num-attention-heads 12 \
    --hidden-size 768 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-head-size 128 \
    --train-iters 100000 \
    --bert-load /path/to/pretrained_bert \
    --load checkpoints \
    --save checkpoints \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --vocab-file /path/to/vocab.txt \
    --lr 0.0001 \
    --num-workers 2 \
    --lr-decay-style linear \
    --weight-decay 1e-2 \
    --clip-grad 1.0 \
    --lr-warmup-fraction .01 \
    --save-interval 3000 \
    --query-in-block-prob 0.1 \
    --fp16

</pre>

### Xây dựng chỉ mục embedding của block
Sau khi đã huấn luyện mô hình ICT, bạn có thể embedding toàn bộ tập block bằng cách tạo cấu trúc `BlockData`. Sau khi đã lưu lại, bạn có thể load nó và gói với `FaissMIPSIndex` để thực hiện tìm kiếm tương đồng nhanh, là thành phần chủ chốt trong pipeline retrieval học được. Chỉ mục ban đầu có thể xây dựng bằng script dưới đây, dùng cho phiên interactive. Nó có thể tận dụng nhiều GPU trên nhiều node để index tập dữ liệu lớn nhanh hơn nhiều.
<pre>
python tools/create_doc_index.py \
    --num-layers 12 \
    --hidden-size 768 \
    --ict-head-size 128 \
    --num-attention-heads 12 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-load /path/to/pretrained_ict \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --block-data-path embedded_blocks.pkl \
    --indexer-log-interval 1000 \
    --indexer-batch-size 128 \
    --vocab-file /path/to/vocab.txt \
    --num-workers 2 \
    --fp16
</pre>

-->

## Mixture of Experts
MoE (Mixture of Experts) là một kiến trúc LLM mạnh mẽ được triển khai trong framework Megatron-Core, được thiết kế để nâng cao hiệu suất và khả năng mở rộng của các mô hình ngôn ngữ lớn. MoE tận dụng **Song song Chuyên gia (Expert Parallelism)**, cho phép nhiều chuyên gia được phân phối trên các worker khác nhau, trong đó mỗi worker xử lý các batch mẫu huấn luyện riêng biệt. Phương pháp này giúp tăng đáng kể thông lượng tính toán, cho phép các mô hình đạt được các chỉ số hiệu năng cao, ví dụ như 47% MFU khi huấn luyện BF16 cho 8x7B trên H100.

Các tính năng chính của MoE:
- **Kỹ thuật Song song**: MoE kết hợp nhiều chiến lược song song như Song song Chuyên gia, Song song Dữ liệu, Song song Tensor, Song song Chuỗi, Song song Pipeline và Song song Ngữ cảnh. Sự kết hợp này cho phép xử lý hiệu quả các biến thể mô hình lớn hơn.
- **Router và Cân bằng tải**: Hệ thống sử dụng các cơ chế định tuyến tiên tiến như Top-K router và áp dụng các thuật toán cân bằng tải để tối ưu việc phân phối token giữa các chuyên gia.
- **Tối ưu hóa Hiệu năng**: Các kỹ thuật như GroupedGEMM và huấn luyện FP8 giúp tăng hiệu quả của các mô hình MoE, đặc biệt khi có nhiều chuyên gia tham gia.
- **Cơ chế Phân phối Token**: MoE hỗ trợ cả chiến lược không bỏ token (dropless) và bỏ token (token drop) nhằm quản lý hiệu quả việc phân phối token giữa các chuyên gia.

Để có cái nhìn tổng quan về cấu hình huấn luyện và tối ưu hóa MoE, vui lòng tham khảo README chi tiết tại [megatron/core/transformer/moe/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/core/transformer/moe/README.md).

# Đánh giá và Nhiệm vụ

Chúng tôi cung cấp một số tham số dòng lệnh, được trình bày chi tiết trong các script bên dưới, để xử lý các nhiệm vụ downstream zero-shot và fine-tuned khác nhau. Tuy nhiên, bạn cũng có thể fine-tune mô hình của mình từ một checkpoint đã pretrain trên các tập dữ liệu khác theo ý muốn. Để làm điều này, chỉ cần thêm cờ `--finetune` và điều chỉnh các file đầu vào cũng như tham số huấn luyện trong script huấn luyện gốc. Số vòng lặp (iteration) sẽ được đặt lại về 0 và optimizer cùng trạng thái nội bộ sẽ được khởi tạo lại. Nếu việc fine-tune bị gián đoạn vì bất kỳ lý do gì, hãy chắc chắn loại bỏ cờ `--finetune` trước khi tiếp tục, nếu không quá trình huấn luyện sẽ bắt đầu lại từ đầu.

Vì quá trình đánh giá tốn ít bộ nhớ hơn nhiều so với huấn luyện, nên có thể sẽ hiệu quả hơn nếu gộp (merge) mô hình đã huấn luyện song song để sử dụng trên ít GPU hơn cho các nhiệm vụ downstream. Script dưới đây thực hiện việc này. Ví dụ này đọc một mô hình GPT với song song tensor 4 chiều và song song pipeline 4 chiều, sau đó ghi ra một mô hình với song song tensor 2 chiều và song song pipeline 2 chiều.

<pre>
python tools/checkpoint/convert.py \
        --model-type GPT \
        --load-dir checkpoints/gpt3_tp4_pp4 \
        --save-dir checkpoints/gpt3_tp2_pp2 \
        --target-tensor-parallel-size 2 \
        --target-pipeline-parallel-size 2

</pre>

Một số nhiệm vụ downstream được mô tả cho cả mô hình GPT và BERT bên dưới. Chúng có thể chạy ở chế độ phân tán và song song mô hình với các thay đổi tương tự như trong các script huấn luyện.

## Sinh văn bản với GPT

Chúng tôi đã bao gồm một REST server đơn giản để sử dụng cho sinh văn bản tại `tools/run_text_generation_server.py`. Bạn chạy nó tương tự như khi khởi động một job pretrain, chỉ cần chỉ định checkpoint đã pretrain phù hợp. Ngoài ra còn có một số tham số tuỳ chọn: `temperature`, `top-k` và `top-p`. Xem `--help` hoặc file nguồn để biết thêm thông tin. Xem [examples/inference/run_text_generation_server_345M.sh](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/run_text_generation_server_345M.sh) để biết ví dụ về cách chạy server.

Khi server đã chạy, bạn có thể sử dụng `tools/text_generation_cli.py` để truy vấn, nó chỉ nhận một tham số là host mà server đang chạy.

<pre>
tools/text_generation_cli.py localhost:5000
</pre>

Bạn cũng có thể sử dụng CURL hoặc bất kỳ công cụ nào khác để truy vấn trực tiếp server:

<pre>
curl 'http://localhost:5000/api' -X 'PUT' -H 'Content-Type: application/json; charset=UTF-8'  -d '{"prompts":["Hello world"], "tokens_to_generate":1}'
</pre>

Xem [megatron/inference/text_generation_server.py](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/inference/text_generation_server.py) để biết thêm tùy chọn API.

### Detoxify GPT bằng Tự sinh
Chúng tôi cung cấp ví dụ tại `examples/academic_paper_scripts/detxoify_lm/` để làm sạch mô hình ngôn ngữ (detoxify) bằng cách tận dụng sức mạnh sinh văn bản của mô hình ngôn ngữ.

Xem [examples/academic_paper_scripts/detxoify_lm/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/academic_paper_scripts/detxoify_lm/README.md) để xem hướng dẫn từng bước cách huấn luyện thích ứng theo miền và làm sạch LM bằng tập dữ liệu tự sinh.

## Đánh giá GPT
Chúng tôi cung cấp các script ví dụ để đánh giá GPT trên đánh giá độ rối (perplexity) với WikiText và độ chính xác Cloze với LAMBADA.

### Đánh giá Perplexity với WikiText
Để so sánh công bằng với các nghiên cứu trước, chúng tôi đánh giá perplexity trên [bộ dữ liệu kiểm tra WikiText-103](https://s3.amazonaws.com/research.metamind.io/wikitext/wikitext-103-v1.zip) ở cấp độ từ, và tính toán perplexity phù hợp khi sử dụng tokenizer subword của chúng tôi.

Chúng tôi sử dụng lệnh sau để đánh giá WikiText-103 trên mô hình 345M tham số.
<pre>
TASK="WIKITEXT103"

VALID_DATA=&#60;wikitext path&#62;.txt
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m

COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 1024 \
                  --max-position-embeddings 1024 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

### Độ chính xác Cloze với LAMBADA
Để tính độ chính xác Cloze với LAMBADA (độ chính xác khi dự đoán token cuối cùng dựa trên các token trước đó), chúng tôi sử dụng phiên bản đã detokenize và xử lý của [bộ dữ liệu LAMBADA](https://github.com/cybertronai/bflm/blob/master/lambada_test.jsonl).

Chúng tôi sử dụng lệnh sau để đánh giá LAMBADA trên mô hình 345M tham số. Lưu ý rằng cờ `--strict-lambada` nên được sử dụng để yêu cầu khớp toàn bộ từ. Đảm bảo rằng `lambada` là một phần của đường dẫn file.

<pre>
TASK="LAMBADA"

VALID_DATA=&#60;lambada path&#62;.json
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m
COMMON_TASK_ARGS=&#60;giống như trong <a href="#wikitext-perplexity-evaluation">Đánh giá Perplexity với WikiText</a> ở trên&#62;

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --strict-lambada \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

Các tham số dòng lệnh bổ sung được mô tả trong file nguồn [`main.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tasks/main.py)

## Đánh giá Nhiệm vụ với BERT
### Đánh giá RACE
Script dưới đây fine-tune mô hình BERT để đánh giá trên [bộ dữ liệu RACE](http://www.cs.cmu.edu/~glai1/data/race/). Thư mục `TRAIN_DATA` và `VALID_DATA` chứa bộ dữ liệu RACE dưới dạng các file `.txt` riêng biệt. Lưu ý rằng với RACE, batch size là số truy vấn RACE cần đánh giá. Vì mỗi truy vấn RACE có bốn mẫu, batch size thực tế đưa vào mô hình sẽ gấp bốn lần batch size chỉ định ở dòng lệnh.

<pre>
TRAIN_DATA="data/RACE/train/middle"
VALID_DATA="data/RACE/dev/middle \
            data/RACE/dev/high"
VOCAB_FILE=bert-vocab.txt
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
CHECKPOINT_PATH=checkpoints/bert_345m_race
COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 512 \
                  --max-position-embeddings 512 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

COMMON_TASK_ARGS_EXT="--train-data $TRAIN_DATA \
                      --valid-data $VALID_DATA \
                      --pretrained-checkpoint $PRETRAINED_CHECKPOINT \
                      --save-interval 10000 \
                      --save $CHECKPOINT_PATH \
                      --log-interval 100 \
                      --eval-interval 1000 \
                      --eval-iters 10 \
                      --weight-decay 1.0e-1"

python tasks/main.py \
       --task RACE \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 3 \
       --micro-batch-size 4 \
       --lr 1.0e-5 \
       --lr-warmup-fraction 0.06
</pre>

### Đánh giá MNLI
Script dưới đây fine-tune mô hình BERT để đánh giá với [tập dữ liệu MultiNLI sentence pair](https://www.nyu.edu/projects/bowman/multinli/). Vì các nhiệm vụ so khớp khá giống nhau, script này cũng có thể được chỉnh sửa nhanh để làm việc với [Quora Question Pairs](https://www.kaggle.com/quora/question-pairs-dataset) (QQP).

<pre>

TRAIN_DATA="data/glue_data/MNLI/train.tsv"
VALID_DATA="data/glue_data/MNLI/dev_matched.tsv \
            data/glue_data/MNLI/dev_mismatched.tsv"
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
VOCAB_FILE=bert-vocab.txt
CHECKPOINT_PATH=checkpoints/bert_345m_mnli
COMMON_TASK_ARGS=&#60;giống như trong <a href="#race-evaluation">Đánh giá RACE</a> ở trên&#62;
COMMON_TASK_ARGS_EXT=&#60;giống như trong <a href="#race-evaluation">Đánh giá RACE</a> ở trên&#62;

python tasks/main.py \
       --task MNLI \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
```
   --tokenizer-type BertWordPieceLowerCase \
   --epochs 5 \
   --micro-batch-size 8 \
   --lr 5.0e-5 \
   --lr-warmup-fraction 0.065
</pre>

## Suy luận và Tinh chỉnh Llama-2

Dòng [mô hình Llama-2](https://ai.meta.com/llama/) là tập hợp các mô hình mã nguồn mở đã được huấn luyện trước & tinh chỉnh (cho chat) đạt được kết quả mạnh trên nhiều bộ đánh giá khác nhau. Tại thời điểm phát hành, các mô hình Llama-2 đạt kết quả trong nhóm tốt nhất đối với các mô hình mã nguồn mở, và có khả năng cạnh tranh với mô hình đóng GPT-3.5 (xem https://arxiv.org/pdf/2307.09288.pdf).

Các checkpoint Llama-2 có thể được nạp vào Megatron để suy luận và tinh chỉnh. Xem tài liệu [tại đây](docs/llama_mistral.md).

# Tối ưu hóa Mô hình và Triển khai
Dòng `GPTModel` của Megatron-Core (MCore) hỗ trợ các thuật toán lượng tử hóa tiên tiến và suy luận hiệu năng cao thông qua TensorRT-LLM.

## Lượng tử hóa và Triển khai TensorRT-LLM
Xem [Tối ưu hóa và Triển khai Mô hình Megatron](examples/inference/quantization/README.md) cho các ví dụ về `llama2` và `nemotron3`.

# Bộ Dữ liệu
Chúng tôi không lưu trữ bất kỳ bộ dữ liệu nào cho huấn luyện GPT hoặc BERT, tuy nhiên, chúng tôi mô tả chi tiết quá trình thu thập để các kết quả của chúng tôi có thể được tái tạo.

## Thu thập Dữ liệu Huấn luyện Wikipedia
Chúng tôi khuyến nghị làm theo quy trình trích xuất dữ liệu Wikipedia do Google research chỉ định: "quy trình tiền xử lý được khuyến nghị là tải về [bản dump mới nhất](https://dumps.wikimedia.org/enwiki/latest/enwiki-latest-pages-articles.xml.bz2), trích xuất văn bản với [WikiExtractor.py](https://github.com/attardi/wikiextractor), và sau đó thực hiện các thao tác dọn dẹp cần thiết để chuyển thành văn bản thuần túy."

Chúng tôi khuyến nghị sử dụng tham số `--json` khi dùng WikiExtractor, sẽ xuất dữ liệu Wikipedia thành định dạng json rời rạc (mỗi dòng là một đối tượng json), giúp quản lý dễ dàng hơn trên hệ thống tệp và cũng sẵn sàng cho codebase của chúng tôi. Chúng tôi khuyến nghị tiền xử lý thêm tập dữ liệu json này với chuẩn hóa dấu câu bằng nltk. Đối với huấn luyện BERT, dùng cờ `--split-sentences` cho `preprocess_data.py` như mô tả [ở trên](#data-preprocessing) để chèn ngắt câu vào chỉ mục tạo ra. Nếu bạn muốn sử dụng dữ liệu Wikipedia cho huấn luyện GPT thì vẫn nên làm sạch bằng nltk/spacy/ftfy, nhưng không dùng cờ `--split-sentences`.

## Thu thập Dữ liệu GPT Webtext
Chúng tôi sử dụng thư viện [OpenWebText](https://github.com/eukaryote31/openwebtext) công khai từ [jcpeterson](https://github.com/jcpeterson/openwebtext) và [eukaryote31's](https://github.com/eukaryote31/openwebtext) để tải các url. Sau đó chúng tôi lọc, làm sạch và loại trùng lặp toàn bộ nội dung đã tải theo quy trình mô tả trong thư mục [openwebtext](./tools/openwebtext) của chúng tôi. Đối với các URL reddit tương ứng với nội dung đến tháng 10 năm 2018, chúng tôi thu được khoảng 37GB nội dung.

# Tái tạo Kết quả (Reproducibility)
Huấn luyện Megatron có thể tái tạo bitwise; để kích hoạt chế độ này sử dụng `--deterministic-mode`. Điều này có nghĩa là cùng cấu hình huấn luyện chạy hai lần trên cùng môi trường HW và SW sẽ tạo ra checkpoint mô hình, giá trị loss và accuracy hoàn toàn giống nhau (thời gian lặp có thể thay đổi).

Hiện có ba tối ưu hóa Megatron đã biết phá vỡ tính tái tạo nhưng vẫn cho kết quả huấn luyện gần như giống hệt:
1. Thuật toán NCCL cụ thể sử dụng khi all-reduce (được chỉ định bởi biến môi trường `NCCL_ALGO`) là quan trọng. Chúng tôi đã thử nghiệm các thuật toán sau: `^NVLS`, `Tree`, `Ring`, `CollnetDirect`, `CollnetChain`. Code chấp nhận dùng `^NVLS`, cho phép NCCL chọn thuật toán không phải NVLS; lựa chọn này dường như ổn định.
2. Flash attention là không xác định; không dùng `--use-flash-attn`.
3. Nếu dùng Transformer Engine, bạn cũng phải đặt biến môi trường `NVTE_ALLOW_NONDETERMINISTIC_ALGO=0`.

Ngoài ra, tính xác định chỉ được xác minh trong các container PyTorch NGC đến bản 23.12 trở đi. Nếu bạn quan sát thấy Megatron huấn luyện không xác định trong các trường hợp khác, vui lòng mở một issue.

# Chuyển đổi checkpoint

Chúng tôi hỗ trợ hai dạng chuyển đổi mô hình:

1. Chuyển đổi lớp mô hình (ví dụ, `GPTModel` trong `model.legacy` so với `model.core`)
2. Chuyển đổi định dạng checkpoint (ví dụ, checkpoint phân tán so với không phân tán)

## Chuyển đổi lớp mô hình

Megatron hỗ trợ chuyển đổi giữa các lớp mô hình khác nhau, bao gồm lớp mô hình nội bộ (hiện chúng tôi có các mô hình `legacy` cũ hơn, và mô hình `core` mới hơn) và lớp mô hình bên ngoài (như các mô hình của Meta, Huggingface, Mistral, và Mixtral). Ngoài ra, trong quá trình chuyển đổi này, bạn có thể cập nhật trạng thái song song của mô hình (tức là thay đổi song song tensor và pipeline).

Chúng tôi cung cấp công cụ `tools/checkpoint/convert.py` để chuyển đổi giữa các lớp mô hình. Một số đối số quan trọng gồm:

- `--model-type`: `GPT` hoặc `BERT`
- `--loader`: định dạng của checkpoint hiện có. Hỗ trợ các định dạng:
  - `legacy`: các lớp mô hình cũ (trong `megatron.legacy.model`)
  - `core`: các lớp mô hình mới hơn (trong `megatron.core.models`)
  - `llama_mistral`: để nạp các mô hình Llama và Mistral (hỗ trợ định dạng Meta và Huggingface)
  - `mixtral_hf`: để nạp các mô hình Mixtral (chỉ Huggingface)
- `--load-dir`: thư mục để nạp checkpoint hiện có
- `--saver`: `legacy` hoặc `core` (xem mô tả ở `--loader`)
- `--save-dir`: thư mục để lưu checkpoint mới
- `--target-tensor-parallel-size`: kích thước song song tensor mới
- `--target-pipeline-parallel-size`: kích thước song song pipeline mới

Để biết chi tiết về các đối số, vui lòng xem script chính (`convert.py`), các script loader (`loader_core.py`, `loader_legacy.py`, `loader_llama_mistral.py`, `loader_mixtral_hf.py`), hoặc các script saver (`saver_core.py`, `saver_legacy.py`).

Ví dụ lệnh chuyển đổi mô hình GPT từ định dạng cũ (`legacy`) sang định dạng mới (`core`) như sau:

```
python tools/checkpoint/convert.py \
>   --model-type GPT \
>   --loader legacy \
>   --load-dir ${LEGACY_FORMAT_DIR} \
>   --saver core \
>   --save-dir ${CORE_FORMAT_DIR} \
>   --target-tensor-parallel-size ${TP} \
>   --target-pipeline-parallel-size ${PP} \
```

Để tham khảo các ví dụ chuyển đổi mô hình Llama/Mistral vào Megatron, vui lòng xem [tại đây](docs/llama_mistral.md).

## Chuyển đổi định dạng checkpoint

Megatron cung cấp nhiều định dạng checkpoint, bao gồm:

- `torch`: Định dạng checkpoint cơ bản với thao tác đọc & ghi tuần tự, gắn liền với trạng thái song song tensor/pipeline cụ thể (trạng thái TP/PP). (Một checkpoint cụ thể gắn với TP/PP cụ thể, nhưng vẫn có thể chuyển đổi thủ công qua trình chuyển đổi lớp mô hình như trên).
- `torch_dist`: Định dạng checkpoint phân tán, hỗ trợ đọc & ghi song song nhanh, và không phụ thuộc trạng thái song song (tức là có thể nạp cùng checkpoint vào các thiết lập TP/PP khác nhau).

Nhìn chung, `torch_dist` là định dạng checkpoint hiện đại và được khuyến nghị do tốc độ. Tuy nhiên, tùy trường hợp sử dụng, có thể cần chuyển đổi giữa hai định dạng này. Để thực hiện, hãy khởi chạy script *huấn luyện* của bạn (ví dụ, qua `pretrain_gpt.py`) như bình thường, nhưng thêm hai đối số:

- `--ckpt-convert-format ${FORMAT}`: `${FORMAT}` có thể là `torch` hoặc `torch_dist`, như mô tả ở trên.
- `--ckpt-convert-save ${PATH_TO_SAVE_NEW_FORMAT}`: đường dẫn này nên khác với các đường dẫn `--load`/`--save` hiện tại, để tránh ghi đè checkpoint hiện có. Sau khi chuyển đổi, dùng đường dẫn mới này cho các tham số `--load`/`--save`.

Ý tưởng chính của trình chuyển đổi định dạng checkpoint là khởi chạy mô hình như bình thường để huấn luyện, nhưng trước khi chạy bất kỳ vòng lặp huấn luyện nào, sẽ lưu sang định dạng checkpoint mới và sau đó thoát. Lưu ý rằng các tham số khởi chạy khác nên giữ nguyên, để hệ thống hiểu đúng định dạng checkpoint trước đó.

# Các Dự án Sử dụng Megatron
Dưới đây là một số dự án mà chúng tôi đã sử dụng trực tiếp Megatron:
* [BERT and GPT Studies Using Megatron](https://arxiv.org/pdf/1909.08053.pdf)
* [BioMegatron: Larger Biomedical Domain Language Model](https://www.aclweb.org/anthology/2020.emnlp-main.379.pdf)
* [End-to-End Training of Neural Retrievers for Open-Domain Question Answering](https://arxiv.org/abs/2101.00408)
* [Large Scale Multi-Actor Generative Dialog Modeling](https://www.aclweb.org/anthology/2020.acl-main.8.pdf)
* [Local Knowledge Powered Conversational Agents](https://arxiv.org/abs/2010.10150)
* [MEGATRON-CNTRL: Controllable Story Generation with External Knowledge Using Large-Scale Language Models](https://www.aclweb.org/anthology/2020.emnlp-main.226.pdf)
* [RACE Reading Comprehension Dataset Leaderboard](http://www.qizhexie.com/data/RACE_leaderboard.html)
* [Training Question Answering Models From Synthetic Data](https://www.aclweb.org/anthology/2020.emnlp-main.468.pdf)
* [Few-shot Instruction Prompts for Pretrained Language Models to Detect Social Biases](https://arxiv.org/abs/2112.07868)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Using DeepSpeed and Megatron to Train Megatron-Turing NLG 530B, A Large-Scale Generative Language Model](https://arxiv.org/abs/2201.11990)
* [Multi-Stage Prompting for Knowledgeable Dialogue Generation](https://arxiv.org/abs/2203.08745)
* [Evaluating Parameter Efficient Learning for Generation](https://aclanthology.org/2022.emnlp-main.319.pdf)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Shall We Pretrain Autoregressive Language Models with Retrieval? A Comprehensive Study](https://arxiv.org/abs/2304.06762)
* [InstructRetro: Instruction Tuning post Retrieval-Augmented Pretraining](https://arxiv.org/abs/2310.07713)
* [An Empirical Study of Mamba-based Language Models](https://arxiv.org/abs/2406.07887)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---