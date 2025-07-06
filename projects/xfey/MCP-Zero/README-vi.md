## MCP-Zero: Khám phá Công cụ Chủ động cho Tác nhân LLM Tự động

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Cảm ơn bạn đã quan tâm tới MCP-Zero! 🤗

Chúng tôi hiện đã mã nguồn mở bộ mã liên quan đến bài báo. Chúng tôi sẽ tiếp tục cập nhật công trình này, khám phá ứng dụng trong ngành công nghiệp và tiếp tục mở rộng dự án này.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Sử dụng MCP-Zero để chủ động xây dựng chuỗi công cụ cho "Làm một bữa ăn tuyệt vời"</p>
</div>


### Phương pháp: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # thực nghiệm: APIBank
├── experiment_mcptools.py      # thực nghiệm: mcp_tools (needle test)
├── matcher.py                  # mã cho so khớp tương đồng
├── prompt_guide/               # prompt cho phương pháp của chúng tôi
├── reformatter.py              # bộ định dạng json cho mô tả công cụ
├── sampler.py                  # bộ chọn mẫu cho chọn công cụ mục tiêu
├── test_cases.jsonl            # trường hợp kiểm thử cho matcher
├── test_matcher.py             # unit test cho matcher
└── utils.py                    # tiện ích: grid_search
```

Chúng tôi hiện đã phát hành mã nguồn cho bài báo. Mã trong bài báo hiện thực hóa khả năng truy xuất và đạt được các kết quả cụ thể trong thực nghiệm.

Trong công việc tương lai, chúng tôi cam kết ứng dụng MCP-zero vào ngành công nghiệp, vì vậy các mô-đun khác vẫn cần được tích hợp, như triển khai động máy chủ MCP, triển khai môi trường cho thử nghiệm GAIA, v.v. Chúng tôi sẽ tiếp tục hoàn thiện công việc này, và cảm ơn sự quan tâm của mọi người. Hãy để lại một ngôi sao🌟 để tôi biết bạn đang theo dõi nhé :D



### Dataset: MCP-tools

- **Google Drive**: [Đường dẫn tải về](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: Sắp ra mắt
- **Đặt file tại**: `./MCP-tools/mcp_tools_with_embedding.json`


**Giới thiệu**: Một bộ dữ liệu chứa tất cả các công cụ đã lọc (308 máy chủ và tổng cộng 2.797 công cụ) từ kho MCP chính thức.

**Cấu trúc dữ liệu**:
```
{
  "server_name": string, // Tên của máy chủ MCP, lấy ra hoặc suy luận từ README
  "server_summary": string, // Tóm tắt về mục đích và khả năng của máy chủ, dựa trên tất cả các phần liên quan trong README.
  "server_description": string, // Mô tả từ metadata. 
  "description_embedding": float[3072], // Vector embedding của mô tả máy chủ từ text-embedding-3-large
  "summary_embedding": float[3072], // Vector embedding của tóm tắt máy chủ từ text-embedding-3-large
  "tools": [
    {
      "name": string, // Tên chức năng/công cụ
      "description": string, // Mô tả ngắn gọn về chức năng của công cụ
      "description_embedding": float[3072], // Vector embedding của mô tả công cụ từ text-embedding-3-large
      "parameter": { // Dictionary các tham số đầu vào, được đưa vào nếu được định nghĩa rõ ràng
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**Tự xây dựng bộ dữ liệu**: Nếu bạn muốn xây dựng bộ dữ liệu tuỳ chỉnh cho các máy chủ MCP, bạn có thể làm theo mã dưới thư mục `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # mã trích xuất dữ liệu cấu trúc từ file ReadMe của máy chủ MCP
│   ├── run_vllm.sh                 # triển khai mô hình Qwen2.5-72B-Instruct với VLLM
│   └── server_summary.prompt       # prompt để trích xuất dữ liệu
└── download_data.md
```


### Trích dẫn

> Trích dẫn làm tôi hạnh phúc.
> 
>   --Shakespeare
>   ~~(chỉ để vui :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---