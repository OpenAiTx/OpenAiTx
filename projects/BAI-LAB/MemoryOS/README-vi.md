# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Nếu bạn thích dự án của chúng tôi, hãy tặng chúng tôi một sao ⭐ trên GitHub để nhận các cập nhật mới nhất.</h5>
**MemoryOS** được thiết kế để cung cấp một hệ điều hành bộ nhớ cho các tác nhân AI cá nhân hóa, cho phép các tương tác mạch lạc, cá nhân hóa và nhận biết ngữ cảnh hơn. Lấy cảm hứng từ các nguyên lý quản lý bộ nhớ trong hệ điều hành, nó áp dụng kiến trúc lưu trữ phân cấp với bốn mô-đun cốt lõi: Lưu trữ, Cập nhật, Truy xuất và Sinh, nhằm đạt được quản lý bộ nhớ toàn diện và hiệu quả. Trên bộ tiêu chuẩn LoCoMo, mô hình đạt được mức cải thiện trung bình **49,11%** và **46,18%** về điểm F1 và BLEU-1.







## 📣 Tin Tức Mới Nhất
*   *<mark>[mới]</mark>* 🔥  **[2025-06-15]**:🛠️ Đã phát hành mã nguồn mở **MemoryOS-MCP**! Giờ đây có thể cấu hình trên các client agent để tích hợp và tùy chỉnh linh hoạt. [👉 Xem chi tiết](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Phiên bản đầu tiên của **MemoryOS** ra mắt! Hỗ trợ bộ nhớ nhân vật ngắn hạn, trung hạn và dài hạn cùng với cập nhật hồ sơ người dùng và tri thức tự động.

## Demo
[![Xem video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Kiến Trúc Hệ Thống
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Cấu Trúc Dự Án

```
memoryos/
├── __init__.py            # Khởi tạo gói MemoryOS
├── __pycache__/           # Thư mục cache Python (tạo tự động)
├── long_term.py           # Quản lý bộ nhớ dài hạn của nhân vật (hồ sơ người dùng, tri thức)
├── memoryos.py            # Lớp chính cho MemoryOS, điều phối tất cả thành phần
├── mid_term.py            # Quản lý bộ nhớ trung hạn, tổng hợp các tương tác ngắn hạn
├── prompts.py             # Chứa các prompt dùng cho tương tác với LLM (ví dụ: tóm tắt, phân tích)
├── retriever.py           # Truy xuất thông tin liên quan từ tất cả các tầng bộ nhớ
├── short_term.py          # Quản lý bộ nhớ ngắn hạn cho các tương tác gần nhất
├── updater.py             # Xử lý cập nhật bộ nhớ, bao gồm thăng cấp thông tin giữa các tầng
└── utils.py               # Các hàm tiện ích dùng chung trong thư viện
```

## Cách Hoạt Động

1.  **Khởi tạo:** `Memoryos` được khởi tạo với ID người dùng và trợ lý, khóa API, đường dẫn lưu trữ dữ liệu, và các thiết lập về dung lượng/ngưỡng khác nhau. Nó tạo vùng lưu trữ riêng cho từng người dùng và trợ lý.
2.  **Thêm bộ nhớ:** Đầu vào của người dùng và phản hồi của agent được thêm dưới dạng cặp Hỏi-Đáp (QA). Các cặp này ban đầu được lưu ở bộ nhớ ngắn hạn.
3.  **Xử lý từ Ngắn hạn sang Trung hạn:** Khi bộ nhớ ngắn hạn đầy, mô-đun `Updater` xử lý các tương tác này, tổng hợp thành các đoạn ý nghĩa và lưu vào bộ nhớ trung hạn.
4.  **Phân tích Trung hạn & Cập nhật LPM:** Các đoạn bộ nhớ trung hạn tích lũy "nhiệt" dựa trên các yếu tố như tần suất truy cập và độ dài tương tác. Khi "nhiệt" của đoạn vượt ngưỡng, nội dung sẽ được phân tích:
    *   Thông tin hồ sơ người dùng được trích xuất và cập nhật hồ sơ dài hạn.
    *   Các sự thật cụ thể về người dùng được thêm vào tri thức dài hạn của người dùng.
    *   Thông tin liên quan cho trợ lý sẽ được thêm vào cơ sở tri thức dài hạn của trợ lý.
5.  **Sinh phản hồi:** Khi nhận truy vấn từ người dùng:
    *   Mô-đun `Retriever` lấy bối cảnh liên quan từ lịch sử ngắn hạn, các đoạn bộ nhớ trung hạn, hồ sơ & tri thức người dùng, và cơ sở tri thức của trợ lý.
    *   Bối cảnh toàn diện này được sử dụng cùng truy vấn của người dùng để sinh ra phản hồi mạch lạc, đầy đủ thông tin qua LLM.

## MemoryOS_PYPI Hướng Dẫn Bắt Đầu

### Yêu Cầu

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Cài Đặt

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Sử Dụng Cơ Bản

```python

import os
from memoryos import Memoryos

# --- Cấu hình cơ bản ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Thay bằng khóa của bạn
BASE_URL = ""  # Tùy chọn: sử dụng nếu có endpoint OpenAI tùy chỉnh
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Simple Demo")
    
    # 1. Khởi tạo MemoryOS
    print("Initializing MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS initialized successfully!\n")
    except Exception as e:
        print(f"Error: {e}")
        return

    # 2. Thêm một số bộ nhớ cơ bản
    print("Adding some memories...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"User: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistant: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP Hướng Dẫn Bắt Đầu
### 🔧 Công Cụ Cốt Lõi

#### 1. `add_memory`
Lưu nội dung cuộc trò chuyện giữa người dùng và trợ lý AI vào hệ thống bộ nhớ, nhằm xây dựng lịch sử đối thoại và ngữ cảnh liên tục.

#### 2. `retrieve_memory`
Truy xuất các đối thoại lịch sử liên quan, sở thích người dùng và thông tin tri thức từ hệ thống bộ nhớ dựa trên truy vấn, giúp trợ lý AI hiểu nhu cầu và bối cảnh người dùng.

#### 3. `get_user_profile`
Lấy hồ sơ người dùng được sinh ra từ việc phân tích các đối thoại lịch sử, bao gồm đặc điểm tính cách, sở thích, và nền tảng tri thức liên quan.


### 1. Cài đặt phụ thuộc
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. cấu hình

Chỉnh sửa `config.json`：
```json
{
  "user_id": "your_user_ID",
  "openai_api_key": "your_OpenAI_API_key",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Khởi động server
```bash
python server_new.py --config config.json
```
### 4. Kiểm tra
```bash
python test_comprehensive.py
```
### 5. Cấu hình trên Cline và các client khác
Sao chép file mcp.json và đảm bảo đường dẫn file chính xác.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Nên được thay bằng trình thông dịch Python của môi trường ảo của bạn
```
## Đóng góp

Chào mừng mọi đóng góp! Vui lòng gửi issue hoặc pull request.

## Trích dẫn
Nếu bạn muốn đọc chi tiết hơn, vui lòng nhấn vào đây: [Đọc toàn văn bài báo](https://arxiv.org/abs/2506.06326)

Nếu bạn thấy dự án này hữu ích, hãy trích dẫn bài báo của chúng tôi:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
## Liên hệ chúng tôi
百家AI là nhóm nghiên cứu do Phó Giáo sư Bạch Đình của Đại học Bưu điện Bắc Kinh hướng dẫn, cam kết xây dựng một bộ não giàu cảm xúc, trí nhớ siêu phàm cho nhân loại nền tảng silicon.<br>
Hợp tác và góp ý: baiting@bupt.edu.cn<br>
Hoan nghênh theo dõi công khai 百家Agent trên WeChat và tham gia nhóm WeChat để cùng trao đổi!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公众号" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="微信群二维码" width="300"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---