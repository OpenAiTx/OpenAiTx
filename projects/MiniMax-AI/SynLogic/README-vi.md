<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

Kho lưu trữ này chứa mã nguồn và dữ liệu cho SynLogic, một khung tổng hợp dữ liệu suy luận logic toàn diện, có khả năng tạo ra dữ liệu suy luận đa dạng, có thể xác thực ở quy mô lớn. Công trình của chúng tôi giải quyết khoảng trống quan trọng về dữ liệu huấn luyện suy luận logic chất lượng cao để phát triển khả năng suy luận tổng quát cho các Mô hình Ngôn ngữ Lớn (LLMs).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Tin tức
- **[2025/07/07]** :fire: Chúng tôi cung cấp hướng dẫn sử dụng dữ liệu SynLogic để huấn luyện RL với framework Verl. Xem chi tiết tại [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md). 

- **[2025/06/03]** :fire: Đã phát hành các mô hình đã huấn luyện trên Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Chúng tôi vui mừng ra mắt các tài nguyên cho bài báo "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Tổng quan

**SynLogic** là một framework tổng hợp dữ liệu và bộ dữ liệu toàn diện mà:
- 📊 **Bao phủ 35 tác vụ suy luận logic đa dạng** bao gồm Sudoku, Game of 24, Mật mã, Mê cung Mũi tên và nhiều hơn nữa
- 🎯 **Cho phép tổng hợp dữ liệu với độ khó có kiểm soát** bằng các tham số điều chỉnh cho từng tác vụ
- ✅ **Cung cấp phần thưởng có thể xác thực** thông qua xác minh dựa trên quy tắc cho huấn luyện RL
- 🚀 **Đạt hiệu năng SOTA** trong số các bộ dữ liệu mã nguồn mở, vượt DeepSeek-R1-Distill-Qwen-32B 6 điểm trên BBEH

### Tính năng nổi bật
- **Tổng hợp dữ liệu quy mô lớn**: Tạo dữ liệu không giới hạn với các mức độ khó điều chỉnh được
- **Bao phủ tác vụ toàn diện**: 35 tác vụ suy luận logic riêng biệt với bộ sinh và kiểm tra tùy chỉnh
- **Sẵn sàng cho RL**: Tất cả ví dụ đều có thể xác minh bằng quy tắc đơn giản, lý tưởng cho học tăng cường
- **Chuyển giao đa lĩnh vực**: Khả năng tổng quát mạnh mẽ sang các miền toán học và lập trình

## 🚀 Bắt đầu nhanh

### Cài đặt
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Sinh dữ liệu mẫu (Ví dụ Mê cung Mũi tên)
```bash
# Ví dụ nhanh với Mê cung Mũi tên
bash games/tasks/arrow_maze/run.sh

# Hoặc với tham số tùy chỉnh
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Cho huấn luyện RL

Chúng tôi cung cấp hướng dẫn chi tiết về cách sử dụng dữ liệu SynLogic trong huấn luyện học tăng cường. Xem [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) để biết hướng dẫn chi tiết về tích hợp SynLogic với framework Verl.

## :rocket: Tài nguyên

### Bộ dữ liệu
| Tên bộ dữ liệu | Mô tả | Liên kết |
|:--------------:|:------|:--------:|
| **SynLogic** | Bộ dữ liệu | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Mô hình


| Tên mô hình | Mô tả | Liên kết |
|:------------|:------|:--------:|
| **SynLogic-7B** | Mô hình 7B huấn luyện trên SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Mô hình 32B huấn luyện trên SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Mô hình 32B huấn luyện trên SynLogic, dữ liệu Toán, Lập trình tổng hợp | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Các cập nhật trong tương lai
Chúng tôi đang tích cực mở rộng SynLogic với nhiều nhiệm vụ lý luận logic hơn.

Hãy theo dõi kho lưu trữ của chúng tôi để cập nhật những tin tức và bản phát hành mới nhất!

## Trích dẫn
Vui lòng trích dẫn bài báo của chúng tôi nếu bạn thấy công trình của chúng tôi hữu ích:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---