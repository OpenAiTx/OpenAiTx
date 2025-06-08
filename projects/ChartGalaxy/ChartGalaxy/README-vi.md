![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## Bộ Dữ Liệu
> 📦 **[👉 Truy cập bộ dữ liệu đầy đủ ChartGalaxy trên Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Do hạn chế về lưu trữ, chúng tôi chỉ bao gồm một tập hợp các ví dụ đại diện.  
Repo này chứa mã nguồn liên quan cho bài báo "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Tin Tức
**2025.5**:  🎉🎉 Chúng tôi đã phát hành phiên bản đầu tiên của bộ dữ liệu, bao gồm 1.151.087 biểu đồ infographic tổng hợp và 104.519 biểu đồ infographic thật, bao phủ 75 loại biểu đồ và 330 biến thể.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## Giới Thiệu

### Về ChartGalaxy

ChartGalaxy là bộ dữ liệu quy mô triệu biểu đồ infographic tổng hợp và thật cùng với bảng dữ liệu, hỗ trợ các ứng dụng về hiểu biểu đồ infographic, sinh mã và sinh biểu đồ. Bộ dữ liệu này giải quyết thách thức khi các bộ dữ liệu hiện tại chủ yếu chỉ giới hạn ở các biểu đồ đơn giản, chưa thể phản ánh được sự đa dạng về phong cách thiết kế và bố cục - những đặc điểm then chốt của biểu đồ infographic.

### Thống Kê

- **Quy mô**: 1.255.606 biểu đồ infographic (1.151.087 tổng hợp + 104.519 thật)
- **Nội dung**: Mỗi biểu đồ infographic đều đi kèm bảng dữ liệu đã sử dụng để tạo ra nó
- **Loại biểu đồ**: 75 loại biểu đồ với 330 biến thể
- **Mẫu bố cục**: 68 mẫu bố cục

### Thu Thập và Tạo Dữ Liệu

ChartGalaxy được xây dựng thông qua:

1. **Thu Thập Biểu Đồ Infographic Thật**: Các biểu đồ được thu thập từ 19 trang web uy tín nhiều biểu đồ như Pinterest, Visual Capitalist, Statista và Information is Beautiful.

2. **Tạo Biểu Đồ Infographic Tổng Hợp**: Theo quy trình cấu trúc quy nạp gồm:
   - Xác định 75 loại biểu đồ (ví dụ: biểu đồ cột) và 330 biến thể biểu đồ phản ánh các phong cách phần tử trực quan khác nhau
   - Trích xuất 68 mẫu bố cục xác định quan hệ không gian giữa các phần tử
   - Sinh tự động các biểu đồ tổng hợp dựa trên các mẫu này

## 🎯 Ứng Dụng

Tính hữu ích của ChartGalaxy được minh chứng qua ba ứng dụng tiêu biểu:

### 1. 🧠 Hiểu Biểu Đồ Infographic

Fine-tuning trên ChartGalaxy giúp cải thiện hiệu quả của các mô hình nền tảng trong việc hiểu biểu đồ infographic.

### 2. 💻 Sinh Mã Biểu Đồ Infographic

Một bộ chuẩn đánh giá việc sinh mã D3.js cho biểu đồ infographic từ các LVLMs. Bộ chuẩn này đánh giá độ tương đồng giữa các biểu đồ được dựng bởi mã D3.js sinh ra và biểu đồ gốc ở hai cấp độ chi tiết: cấp cao (tổng thể trực quan) và cấp thấp (trung bình các phần tử SVG chi tiết).

#### Tổng Quan

Bộ chuẩn đánh giá sinh mã biểu đồ ở hai cấp độ:
- **Cấp thấp**: Độ tương đồng từng phần tử giữa SVG sinh ra và tham chiếu
- **Cấp cao**: Đánh giá tổng thể về độ trung thực và chức năng trực quan

#### Cài Đặt

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Sử Dụng

1. Cấu hình trong `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Bỏ comment các mô hình bạn muốn đánh giá
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Chạy đánh giá:
   ```bash
   python main.py
   ```

#### Cấu Trúc Dữ Liệu

Mỗi thư mục biểu đồ trong `data_root_dir` cần chứa:
- `chart.svg`: Biểu đồ gốc định dạng SVG

Hệ thống sẽ sinh ra:
- `convert_chart.html`: HTML hiển thị biểu đồ tham chiếu
- `convert_chart.png`: Ảnh PNG chụp màn hình biểu đồ tham chiếu
- `convert_chart.json`: Cấu trúc phần tử của biểu đồ tham chiếu
- Kết quả của từng mô hình trong các thư mục con riêng

#### Kết Quả

Kết quả được lưu trong các thư mục con theo từng mô hình với:
- Kết xuất HTML/PNG đã sinh
- Các chỉ số đánh giá dưới dạng JSON
- Log chi tiết trong `log_dir`
  

### 3. 🖼️ Sinh Biểu Đồ Infographic Dựa Trên Ví Dụ

Một phương pháp dựa trên ví dụ giúp chuyển đổi bảng dữ liệu do người dùng cung cấp thành biểu đồ infographic, phù hợp bố cục và phong cách trực quan của biểu đồ ví dụ cho trước. Nghiên cứu người dùng cho thấy phương pháp này vượt trội GPT-Image-1 về độ trung thực, thẩm mỹ và sáng tạo.


## Liên Hệ
- chartgalaxy@163.com

## Liên Kết Bài Báo

### 📌 Bài Báo Chính (Repo Này)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Các Bài Báo Liên Quan

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Trích Dẫn
Nếu bạn sử dụng ChartGalaxy trong nghiên cứu, vui lòng trích dẫn:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---