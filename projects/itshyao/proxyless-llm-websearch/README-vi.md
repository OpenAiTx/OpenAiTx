
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🧠 Công cụ tìm kiếm LLM không cần proxy

Một công cụ truy xuất thông tin mạng LLM đa công cụ tìm kiếm không cần proxy, hỗ trợ phân tích nội dung URL và thu thập dữ liệu web, kết hợp với LangGraph để xây dựng chuỗi agent mô-đun. Thiết kế đặc biệt cho kịch bản LLM gọi kiến thức ngoài, hỗ trợ **Playwright + Crawl4AI** để lấy và phân tích trang web, hỗ trợ xử lý đồng thời bất đồng bộ, cắt nhỏ và lọc sắp xếp lại nội dung.

## ✨ Tính năng nổi bật

- 🌐 **Không cần proxy**: Thông qua cấu hình Playwright hỗ trợ trình duyệt nội địa, không cần proxy vẫn có thể tìm kiếm trên mạng.
- 🔍 **Hỗ trợ nhiều công cụ tìm kiếm**: Hỗ trợ Bing, Quark, Baidu, Sogou và các công cụ tìm kiếm phổ biến khác, tăng tính đa dạng nguồn thông tin.
- 🤖 **Nhận diện ý định**: Hệ thống có thể tự động xác định dựa trên nội dung đầu vào của người dùng là thực hiện tìm kiếm hay phân tích URL.
- 🔄 **Phân tách truy vấn**: Theo ý định tìm kiếm của người dùng, tự động tách truy vấn thành nhiều tác vụ nhỏ và thực hiện tuần tự, nâng cao độ liên quan và hiệu quả tìm kiếm.
- ⚙️ **Kiến trúc agent**: Đóng gói dựa trên **LangGraph** với **「web_search」** và **「link_parser」**.
- 🏃‍♂️ **Xử lý tác vụ đồng thời bất đồng bộ**: Hỗ trợ xử lý tác vụ đồng thời bất đồng bộ, xử lý hiệu quả nhiều nhiệm vụ tìm kiếm.
- 📝 **Tối ưu xử lý nội dung**:

  - ✂️ **Cắt nhỏ nội dung**: Cắt nội dung trang web dài thành từng đoạn.

  - 🔄 **Sắp xếp lại nội dung**: Sắp xếp thông minh để tăng độ liên quan thông tin.

  - 🚫 **Lọc nội dung**: Tự động loại bỏ nội dung không liên quan hoặc trùng lặp.
- 🌐 **Hỗ trợ đa nền tảng**:

  - 🖥️ Cung cấp API backend FastAPI, có thể tích hợp vào bất kỳ hệ thống nào.

  - 🌍 Có giao diện web Gradio, dễ dàng triển khai thành ứng dụng trực quan.
  
  - 🧩[ **Hỗ trợ tiện ích trình duyệt**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Hỗ trợ Edge, cung cấp plugin phân tích URL thông minh, gửi yêu cầu phân tích và trích xuất nội dung trực tiếp trên trình duyệt.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Bắt đầu nhanh

### 1. Sao chép kho mã

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Cài đặt các phụ thuộc

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Bắt đầu nhanh

#### Cấu hình biến môi trường

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### trình diễn

```python
'''
python demo.py
'''

from pools import BrowserPool, CrawlerPool
from agent import ToolsGraph
import asyncio

async def main():
    browser_pool = BrowserPool(pool_size=1)
    crawler_pool = CrawlerPool(pool_size=1)
    
    graph = ToolsGraph(browser_pool, crawler_pool, engine="bing")

    await browser_pool._create_browser_instance(headless=True)
    await crawler_pool._get_instance()

    result = await graph.run("广州今日天气")

    await browser_pool.cleanup()
    await crawler_pool.cleanup()

    print(result)

if __name__ == "__main__":
    asyncio.run(main())
```

#### API phía sau

```python
'''
python api_serve.py
'''
import requests

url = "http://localhost:8000/search"

data = {
    "question": "广州今日天气"
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### gradio_demo

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 So sánh với kiểm tra tìm kiếm trên Internet trực tuyến

Chúng tôi đã so sánh dự án với một số API trực tuyến phổ biến, đánh giá hiệu suất của chúng trong các câu hỏi phức tạp.

### 🔥 Bộ dữ liệu

- Bộ dữ liệu lấy từ [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) do Alibaba phát hành, bao gồm 680 câu hỏi khó, bao phủ nhiều lĩnh vực như giáo dục, hội nghị học thuật, trò chơi,...
- Bộ dữ liệu bao gồm câu hỏi bằng tiếng Trung và tiếng Anh.

### 🧑‍🏫 Kết quả so sánh

| Công cụ tìm kiếm/hệ thống | ✅ Đúng | ❌ Sai | ⚠️ Đúng một phần |
| ---------------------- | ------- | ------ | --------------- |
| **火山方舟**           | 5.00%   | 72.21% | 22.79%          |
| **百炼**               | 9.85%   | 62.79% | 27.35%          |
| **Our**                | 19.85%  | 47.94% | 32.06%          |

## 🙏 Lời cảm ơn

Một số chức năng của dự án này được hỗ trợ và truyền cảm hứng bởi các dự án mã nguồn mở sau, xin trân trọng cảm ơn:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph)：dùng để xây dựng khung chuỗi tác tử mô-đun.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai)：công cụ phân tích nội dung web mạnh mẽ.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---