<center>
  <h1>ChinaTravel: Bộ tiêu chuẩn thực tế cho Tác nhân Ngôn ngữ trong Lập kế hoạch Du lịch Trung Quốc
</h1>
</center>

Mã nguồn chính thức cho bài báo "ChinaTravel: Bộ tiêu chuẩn thực tế cho Tác nhân Ngôn ngữ trong Lập kế hoạch Du lịch Trung Quốc".

<!-- | [Trang web](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Bài báo](https://arxiv.org/abs/2412.13682) | [Bộ dữ liệu (Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Trang web](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Bài báo](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Bộ dữ liệu (Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Cuộc thi (TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Cuộc thi (TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Tổng quan](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 Thử thách Lập kế hoạch Du lịch IJCAI 2025 (TPC@IJCAI)

Chúng tôi tự hào thông báo rằng ChinaTravel đã được chọn là bộ tiêu chuẩn chính thức cho **Thử thách Lập kế hoạch Du lịch (TPC) @ IJCAI 2025**!

**Trang web Cuộc thi Chính thức**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Chúng tôi mời các thí sinh phát triển các tác nhân mới có thể giải quyết các tình huống lập kế hoạch du lịch thực tế với các ràng buộc phức tạp. Cuộc thi này sẽ trình diễn các phương pháp nghiên cứu tác nhân ngôn ngữ tiên tiến nhất.

## 📝 Nhật ký thay đổi

### 2025.09
1. Đăng tải giải pháp vô địch của TPC@IJCAI2025 ở nhánh DSL. Cảm ơn [@evergreenee](https://github.com/evergreenee) vì những đóng góp của họ.  


### 2025.06

1. Sửa lỗi thu thập trong mã đánh giá kiến thức thường thức.
2. Sửa quy trình của tác nhân thuần thần kinh.
3. Sửa lỗi load_datasets từ huggingface.
4. Cập nhật xử lý ngoại lệ khi xác minh cú pháp.


### 2025.05

1. Cập nhật nhật ký cho phiên bản mới nhất.
2. Cung cấp mã đánh giá cho TPC.

### 2025.04

1. Thêm bộ tải dữ liệu cục bộ. Người dùng hiện có thể tải các truy vấn tùy chỉnh tại chỗ. Khi chỉ định giá trị splits_name không mặc định (ví dụ: "abc") cho "run_exp.py", hệ thống sẽ tự động tải các tệp tương ứng từ evaluation/default_splits/abc.txt, trong đó tệp TXT chứa tên tệp truy vấn mục tiêu.
2. Phân loại ràng buộc chi tiết. Xem tài liệu chi tiết tại [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Giới thiệu phương pháp LLM-modulo cơ bản
   Triển khai quy trình LLM-modulo với bộ xác minh biểu tượng chuẩn.
   Dựa trên phương pháp từ:
   Bài báo: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Mã nguồn: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Hỗ trợ suy luận LLM cục bộ với Qwen3-8B/4B.

## 🚀 Bắt đầu nhanh

### ⚙️ Cài đặt

1. Tạo môi trường conda và cài đặt các phụ thuộc:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Tải xuống cơ sở dữ liệu và giải nén vào thư mục "chinatravel/environment/"

Liên kết tải xuống: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Tải xuống các mô hình LLM mã nguồn mở (tùy chọn).

```bash
bash download_llm.sh
```

4. Tải xuống các bộ tách từ.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Chạy

Chúng tôi hỗ trợ deepseek (API chính thức từ deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus, và suy luận cục bộ với Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3), v.v.

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**Lưu ý**:

- Cờ `--oracle_translation` cho phép truy cập vào dữ liệu thực tế đã được chú thích bao gồm:

  - `hard_logic_py`: Mã DSL xác minh có thể thực thi
  - `hard_logic_nl`: Mô tả các ràng buộc tương ứng
  - Cấu trúc chú thích ví dụ:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- Phương pháp LLM-modulo **yêu cầu** chế độ oracle_translation cho quá trình tinh chỉnh biểu tượng của nó

### 📊 Đánh giá

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

Trong TPC@IJCAI2025, mã đánh giá được cung cấp trong tệp `eval_tpc.py`. Bạn có thể chạy mã đánh giá như sau:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Tài liệu

[Môi trường](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Ràng buộc](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Phát triển nâng cao

### 1. Phát triển thuật toán Agent riêng của bạn

Để phát triển thuật toán agent của riêng bạn, bạn cần kế thừa lớp `BaseAgent` từ `chinatravel/agent/base.py` và thêm logic cho thuật toán của mình vào hàm `init_agent` trong `chinatravel/agent/load_model.py`. Chúng tôi cung cấp một ví dụ agent trống có tên là `TPCAgent`.

Các bước:

- **Kế thừa lớp `BaseAgent`**: Tạo một file Python mới trong thư mục `chinatravel/agent` và định nghĩa lớp agent của riêng bạn, kế thừa từ `BaseAgent`.

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **Thêm mã vào hàm init_agent**: Mở tệp chinatravel/agent/load_model.py và thêm hỗ trợ cho tác nhân mới của bạn trong hàm init_agent.

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. Phát triển LLM cục bộ của riêng bạn

Để phát triển mô hình ngôn ngữ lớn (LLM) cục bộ của riêng bạn, bạn cần kế thừa lớp AbstractLLM từ chinatravel/agent/llms.py và thêm mã suy luận LLM cục bộ tương ứng vào llms.py. Chúng tôi cung cấp một ví dụ LLM trống có tên TPCLLM.
Các bước thực hiện:

- **Kế thừa lớp AbstractLLM**: Định nghĩa lớp LLM của riêng bạn trong tệp chinatravel/agent/llms.py, kế thừa từ AbstractLLM.

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **Thêm mã vào hàm init_agent**: Mở tệp chinatravel/agent/load_model.py và thêm hỗ trợ cho llm mới của bạn trong hàm init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Chạy Mã của Bạn Bằng Các Script Thí Nghiệm

Sau khi hoàn thành phát triển ở trên, bạn có thể sử dụng các script thí nghiệm để chạy mã của mình.

Ví dụ về cách chạy:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

Kết quả sẽ được lưu trong thư mục `results/YourMethodName_YourLLMName_xxx`, ví dụ: `results/TPCAgent_TPCLLM`.

## ✉️ Liên hệ

Nếu bạn gặp bất kỳ vấn đề nào, vui lòng liên hệ [Thiệu Giới Kình](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Trương Bá Văn](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Dương Tiêu Văn](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Trích dẫn

Nếu bài báo hoặc các tài nguyên liên quan của chúng tôi có giá trị đối với nghiên cứu của bạn, xin vui lòng trích dẫn.

```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---