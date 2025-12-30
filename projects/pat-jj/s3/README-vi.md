
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# s3 - Đào Tạo Tác Nhân Tìm Kiếm Hiệu Quả Bằng RL
***Bạn Không Cần Quá Nhiều Dữ Liệu Để Đào Tạo Một Tác Nhân Tìm Kiếm***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**Tổng quan Hiệu suất:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## S3 là gì?

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**Khung s3**
</div>

`s3` là một khung đơn giản nhưng mạnh mẽ để huấn luyện các tác nhân tìm kiếm trong hệ thống tạo nội dung có hỗ trợ truy xuất thông tin (RAG). Nó dạy các mô hình ngôn ngữ cách tìm kiếm hiệu quả hơn—mà không cần thay đổi bộ tạo nội dung. Bằng cách chỉ tập trung vào thành phần tìm kiếm, `s3` đạt hiệu suất cao trong các tác vụ hỏi đáp với chỉ một phần nhỏ dữ liệu so với các phương pháp trước đó. Khung này có tính mô-đun, hiệu quả, và được thiết kế để tích hợp mượt mà với bất kỳ LLM hộp đen nào.



## Mục lục

- [📦 Cài đặt](#-installation)
- [💡 Chuẩn bị](#-preparation)
- [🏋️ Chạy Huấn luyện](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 Chạy Tìm kiếm/Truy xuất](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 Chạy Đánh giá](#-run-evaluation)

## 📦 Cài đặt

**Môi trường Searcher & Generator**
```bash
conda create -n s3 python=3.9
# install torch [or you can skip this step and let vllm to install the correct version for you]
pip install torch==2.4.0 --index-url https://download.pytorch.org/whl/cu121
# install vllm
pip3 install vllm==0.6.3 # or you can install 0.5.4, 0.4.2 and 0.3.1
pip3 install ray

# verl
# cd code
pip install -e .

# flash attention 2
pip3 install flash-attn --no-build-isolation

# we use pyserini for efficient retrieval and evaluation
pip install pyserini    # the version we used is 0.22.1

# quality of life
pip install wandb IPython matplotlib huggingface_hub
```
**Môi trường Retriever**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
## 💡 Chuẩn bị
***Tải xuống Chỉ mục & Tập dữ liệu***



```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```

***Tiền xử lý Khởi tạo RAG Đơn giản*** (hoặc bạn có thể tải xuống dữ liệu đã xử lý của chúng tôi tại đây: [huggingface](https://huggingface.co/datasets/pat-jj/s3_processed_data))

```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ Chạy Huấn Luyện
***Bước này dành cho việc huấn luyện S3***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 Chạy Tìm kiếm/Truy xuất
***Bước này dùng để thu thập ngữ cảnh của s3 / các đường cơ sở***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>Các đường cơ sở</summary>

**RAG**

```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
**DeepRetrieval**
**DeepRetrieval**
```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
**Tìm kiếm-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**IRCoT**
**IRCoT**
```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**Tìm kiếm-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 Chạy Đánh Giá
***Bước này dành cho việc đánh giá s3 / các đường cơ sở***



```bash
bash scripts/evaluation/run.sh
```

## Hỏi & Đáp
### Dữ liệu Tùy chỉnh?
Nếu bạn muốn thử nghiệm s3 trên tập dữ liệu/corpus của riêng mình, bạn có thể tham khảo commit này để xem bạn cần làm gì để xây dựng pipeline riêng: [commit 8420538](https://github.com/pat-jj/s3/commit/8420538836febbe59d5bcbe41187f16908c9c36c)

### Tái tạo Kết quả?
Một số nhà phát triển đã tái tạo thành công kết quả của chúng tôi. Nếu bạn có câu hỏi hoặc gặp sự cố, cứ thoải mái [mở một issue](https://github.com/pat-jj/s3/issues) — chúng tôi sẵn sàng hướng dẫn thực tế (xem [ví dụ này](https://github.com/pat-jj/s3/issues/20)).

Mặc dù việc tự mình tái tạo mô hình khá đơn giản — và thực ra chúng tôi **khuyên bạn nên huấn luyện từ đầu**, vì đánh giá thường tốn nhiều thời gian hơn huấn luyện — chúng tôi cũng cung cấp một checkpoint tham khảo: [s3-8-3-3-20steps](https://huggingface.co/pat-jj/s3-8-3-3-20steps), được huấn luyện trong khoảng một giờ.



## Trích dẫn
```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
Cảm ơn bạn đã quan tâm đến công việc của chúng tôi!






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---