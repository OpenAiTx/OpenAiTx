# KVzip: Nén Bộ Nhớ Đệm KV Không Phụ Thuộc Truy Vấn với Tái Tạo Ngữ Cảnh

[[Bài báo](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Có Gì Mới?
- KVzip nén bộ nhớ đệm KV để hỗ trợ **đa dạng truy vấn tương lai**.
- [Phụ thuộc ngữ cảnh] Đạt được **giảm 3–4× kích thước bộ nhớ đệm KV** và **giảm 2× độ trễ giải mã**, với suy giảm hiệu năng tối thiểu.
- [Không phụ thuộc ngữ cảnh] Nâng cao nén KV cấp đầu theo phong cách [DuoAttention](https://github.com/mit-han-lab/duo-attention), chỉ sử dụng **vài lần truyền thẳng trong vòng một phút** để tối ưu điểm quan trọng cấp đầu (nhanh hơn 100 lần).
- Chạy demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Đánh giá trên thiết lập không phụ thuộc truy vấn
- Nhiệm vụ: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Mô hình: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Cài Đặt
Chúng tôi sử dụng CUDA 12.1 và Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Để sử dụng lượng tử hóa [QServe](https://github.com/mit-han-lab/omniserve), vui lòng theo dõi [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Bộ dữ liệu
- Vui lòng tải bộ dữ liệu SCBench đã được tiền xử lý từ [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Nếu bạn đã giải nén các tệp, chỉ cần di chuyển thư mục scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Bắt Đầu Nhanh
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # điền trước bộ nhớ đệm KV + tính điểm quan trọng
kv.prune(ratio=0.3)  # tỉ lệ nén, loại bỏ 70% KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # suy luận hiệu quả
    print(q, output)
```
- Các mô hình được hỗ trợ được liệt kê trong [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), bao gồm **LLaMA3, Qwen2.5/3, Gemma3**.
- Đặt `load_score=True` để loại bỏ chi phí nén. Điều này cho phép loại bỏ KV không phụ thuộc ngữ cảnh, với sự đánh đổi tỉ lệ nén là `ratio=0.6`.
- Sau khi sinh, các cặp KV tương ứng với truy vấn và token sinh ra được loại bỏ chọn lọc khỏi bộ nhớ đệm để xử lý tiếp. Đặt `update_cache=True` để kích hoạt suy luận đa lượt, giữ lại toàn bộ lịch sử tương tác trong suốt quá trình suy luận. 

## Đo Hiệu Năng Bộ Nhớ và Thời Gian Tính Toán
### Loại bỏ phụ thuộc ngữ cảnh
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Mã trên cũng so sánh kết quả sinh ra với bộ nhớ đệm KV đầy đủ và đã bị loại bỏ.
- Để thử nhanh, dùng `-d squad`. Để thử với ngữ cảnh dài, dùng `-d scbench_kv`.
  - Tên dữ liệu có sẵn: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Tên mô hình có sẵn: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), ví dụ llama3.1-8b, qwen2.5-7b (hoặc Qwen/Qwen2.5-7B-Instruct-1M).
- Chúng tôi điều chỉnh kernel CUDA từ [AdaKV](https://github.com/FFY0/AdaKV/tree/main), hỗ trợ phân bổ ngân sách đầu không đồng đều.
  - Hiện tại, mã của chúng tôi thiếu kernel tối ưu cho Gemma3 sử dụng bộ nhớ đệm KV tĩnh, nên mã không mang lại hiệu quả thực tế. Tuy nhiên, hiệu năng mô hình vẫn có thể đánh giá bằng chú ý giảm với chọn mẫu KV (`--kv_type retain`).


### Loại bỏ không phụ thuộc ngữ cảnh (không có chi phí nén thời gian chạy)
- Dùng cờ `--level head` với `--ratio 0.6` (khuyến nghị).
  - Loại bỏ toàn bộ cặp KV ngữ cảnh liên quan đến một đầu cụ thể trong khi giữ lại cặp KV lời nhắc hệ thống và truy vấn.
  - Điểm đầu đã tính trước có sẵn cho LLaMA3.1-8B và Qwen2.5-7/14B trong `./utils/head_score`.
- Để tính điểm đầu cho các mô hình khác:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - Kết quả sẽ được lưu ở `./utils/head_score`.
  - Nếu nhắm đến nhiệm vụ lập trình, chúng tôi khuyên bạn chạy thêm lệnh với `-d scbench_repoqa`. Điều này cho phép mô hình dùng điểm đầu tối đa từ cả ngôn ngữ tự nhiên và lập trình, cải thiện hiệu năng.
- Những điểm này có thể tích hợp liền mạch với bộ máy suy luận tối ưu của [DuoAttention](https://github.com/mit-han-lab/duo-attention) bằng cách thay thế dữ liệu điểm đầu của họ bằng của chúng tôi.


## Đánh Giá
- Để sinh câu trả lời mô hình với các tỉ lệ nén KV từ 0.1 đến 1.0:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - Kết quả sẽ được lưu tại `./results/[data_name]`.
  - Các bộ dữ liệu được hỗ trợ liệt kê trong `data/load.py`.
- Để tính toán các chỉ số đánh giá từ kết quả sinh:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Áp Dụng Cho Mô Hình Mới
Để tích hợp KVzip cho mô hình mới, bạn cần cập nhật các tệp sau:
- `attention/attn.py`  
  Sửa logic truyền thẳng attention theo nhu cầu. Trong một số trường hợp, cần cập nhật thêm kvcache.py và score.py.
- `model/monkeypatch.py`  
  Triển khai monkey patch đặc thù mô hình để tích hợp.
- `model/template.py`   
  Định nghĩa lời nhắc hệ thống và mẫu định dạng chat của mô hình.


## Trích Dẫn
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Giấy Phép
Giấy phép MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---