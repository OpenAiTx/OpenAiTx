# LlamaIndex Workflows

[![Kiểm thử đơn vị](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Tình trạng bao phủ](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![Số lượng người đóng góp GitHub](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Lượt tải xuống](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows là một framework để điều phối và liên kết các hệ thống phức tạp gồm nhiều bước và sự kiện.

## Bạn có thể xây dựng gì với Workflows?

Workflows phát huy tối đa sức mạnh khi bạn cần điều phối các quy trình đa bước phức tạp liên quan đến mô hình AI, API và các quyết định. Dưới đây là một số ví dụ về những gì bạn có thể xây dựng:

- **AI Agents** - Tạo ra các hệ thống thông minh có khả năng suy luận, ra quyết định và thực hiện hành động qua nhiều bước
- **Chuỗi xử lý tài liệu** - Xây dựng hệ thống tiếp nhận, phân tích, tóm tắt và điều hướng tài liệu qua nhiều giai đoạn xử lý khác nhau
- **Ứng dụng AI đa mô hình** - Điều phối giữa các mô hình AI khác nhau (LLM, mô hình thị giác, v.v.) để giải quyết các nhiệm vụ phức tạp
- **Trợ lý nghiên cứu** - Phát triển các workflow có khả năng tìm kiếm, phân tích, tổng hợp thông tin và cung cấp câu trả lời toàn diện
- **Hệ thống tạo nội dung** - Tạo ra các chuỗi xử lý để tạo, kiểm tra, chỉnh sửa và xuất bản nội dung với quy trình phê duyệt có sự tham gia của con người
- **Tự động hóa hỗ trợ khách hàng** - Xây dựng hệ thống điều hướng thông minh có thể hiểu, phân loại và phản hồi các yêu cầu từ khách hàng

Kiến trúc ưu tiên bất đồng bộ, dựa trên sự kiện giúp bạn dễ dàng xây dựng các workflow có thể điều phối giữa các khả năng khác nhau, triển khai các mẫu xử lý song song, lặp qua các chuỗi phức tạp, và duy trì trạng thái qua nhiều bước - tất cả những tính năng bạn cần để đưa ứng dụng AI của mình vào vận hành thực tế.
## Tính Năng Chính

- **ưu tiên async** - các workflow được xây dựng dựa trên tính năng async của Python - các bước là các hàm async xử lý các sự kiện nhận vào từ một hàng đợi asyncio và phát ra các sự kiện mới tới các hàng đợi khác. Điều này cũng có nghĩa là workflow hoạt động tốt nhất trong các ứng dụng async của bạn như FastAPI, Jupyter Notebooks, v.v.
- **dẫn động bởi sự kiện** - workflow bao gồm các bước và các sự kiện. Việc tổ chức mã nguồn của bạn xung quanh các sự kiện và bước giúp dễ dàng suy luận và kiểm thử hơn.
- **quản lý trạng thái** - mỗi lần chạy một workflow là độc lập, nghĩa là bạn có thể khởi chạy một workflow, lưu thông tin trong đó, tuần tự hóa trạng thái của workflow và tiếp tục lại sau này.
- **khả năng quan sát** - các workflow được tự động gắn công cụ quan sát, nghĩa là bạn có thể sử dụng các công cụ như `Arize Phoenix` và `OpenTelemetry` ngay lập tức.

## Bắt Đầu Nhanh

Cài đặt gói:

```bash
pip install llama-index-workflows
```

Và tạo workflow đầu tiên của bạn:

```python
import asyncio
from pydantic import BaseModel, Field
from workflows import Context, Workflow, step
from workflows.events import Event, StartEvent, StopEvent

class MyEvent(Event):
    msg: list[str]

class RunState(BaseModel):
    num_runs: int = Field(default=0)

class MyWorkflow(Workflow):
    @step
    async def start(self, ctx: Context[RunState], ev: StartEvent) -> MyEvent:
        async with ctx.store.edit_state() as state:
            state.num_runs += 1

            return MyEvent(msg=[ev.input_msg] * state.num_runs)

    @step
    async def process(self, ctx: Context[RunState], ev: MyEvent) -> StopEvent:
        data_length = len("".join(ev.msg))
        new_msg = f"Processed {len(ev.msg)} times, data length: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```python
# [tùy chọn] cung cấp một đối tượng context cho workflow
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Kết quả Workflow:", result)

# chạy lại với cùng một context sẽ giữ nguyên trạng thái
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Kết quả Workflow:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

Trong ví dụ trên
- Các bước chấp nhận một `StartEvent` sẽ được chạy trước tiên.
- Các bước trả về một `StopEvent` sẽ kết thúc workflow.
- Các sự kiện trung gian do người dùng định nghĩa và có thể được sử dụng để truyền thông tin giữa các bước.
- Đối tượng `Context` cũng được sử dụng để chia sẻ thông tin giữa các bước.

Truy cập [tài liệu đầy đủ](https://docs.llamaindex.ai/en/stable/understanding/workflows/) để xem thêm các ví dụ sử dụng `llama-index`!

## Thêm ví dụ

- [Chạy thử các tính năng cơ bản](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Xây dựng một Agent gọi hàm với `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Trích xuất tài liệu lặp lại với sự tham gia của con người](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Khả năng quan sát
  - [Giới thiệu về OpenTelemetry + Instrumentation](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Các gói liên quan

- [Workflows Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---