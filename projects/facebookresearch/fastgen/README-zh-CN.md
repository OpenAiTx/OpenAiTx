
# Fastgen

**高吞吐量的稠密变换器推理。**

Fastgen 是一个大型语言模型推理库，具备最先进的技术：
批量推理、CUDA 图、分页注意力、分块预填充、主机端 KV 缓存、
张量并行、CPU/GPU 性能分析。

你可以将其视为一个迷你版（约 3k 行代码）的 vLLM，
可以轻松导入到更大的系统中，如强化学习循环或合成数据生成
管道。

以下 HuggingFace 模型已知支持：
Llama 3.1 8B，Mistral 7B，Ministral 8B，R1-Llama 8B 和 70B，
R1-Qwen 14B，Qwen2.5 7B 和 14B；可能还有更多。

## 基准测试

|                       | Fastgen      | vLLM (0.8.4) |
| --------------------- | ------------ | -----------  |
| Mistral 7B / 1x H100  | 3430 toks/s  | 3390 toks/s  |
| Qwen2.5 14B / 1x H100 | 1700 toks/s  | 1700 toks/s  |
| Llama 70B / 8x H100   | 2260 toks/s  | 2230 toks/s  |

此表中展示的吞吐量数据是通过使用
`fgserve`（见下文）和 `vllm serve`，对 512 个提示中每个
1024 个标记进行 128 步解码负载时收集的。下图显示了
Mistral 7B 模型在不同生成负载下的更详细结果。

![Mistral 7B 基准测试](https://raw.githubusercontent.com/facebookresearch/fastgen/main/scripts/data/mistral7-perf.png)

> [!注意]
> 在对 `fgserve` 进行测试时，你可能会观察到短提示的
> 性能下降。这种性能降低是由于未优化的多线程 HTTP
> 服务代码导致 Fastgen 在小批量（效率低下）上运行。
> 使用 Fastgen 的生产环境应采用基于进程的并行。

## 演示工具

该库附带两个工具：`fgchat` 和 `fgserve`。
第一个工具是一个基本的命令行聊天演示；第二个则提供
一个简易的 OpenAI 聊天 API 服务。

### fgchat





```
$ # on an RTX A5000
$ # accelerate inference with '--tensor-parallel N' if you have N GPUs
$ fgchat mistralai/Mistral-7B-Instruct-v0.3  
loading: 100%|███████████████████████▉| 14.5G/14.5G [00:00<00:00, 75.9GB/s]
Ready to chat!
  Available commands:
    /r <N> -- reset conversation before round N
    /m     -- input a multiline message, end your input
              with a single line containing '.'
    /q     -- quit

---
1> hello
Hello! How can I help you today? [...]
--- [33 tokens, 26.554toks/s]
2> can you give me some makeup advice?
Of course! Here are some general makeup tips that might be helpful:

[...]
--- [489 tokens, 34.715toks/s]
3> /q
```
### fgserve


```
$ fgserve mistralai/Mistral-7B-Instruct-v0.3  
...
$ cat test.py
from openai import OpenAI
client = OpenAI(base_url="http://localhost:5678", api_key="foo")

completion = client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[
        {"role": "system", "content": "You are a helpful assistant."},
    ] + [
        {
            "role": "user",
            "content": "Write a haiku about recursion in programming."
        }
    ]
)
print(completion.choices[0].message.content)

$ python test.py
Code dives within,
Echoes of self repeat,
Solving the unseen.
```


## 致谢

感谢：
- [vLLM项目](https://github.com/vllm-project/vllm)的启发及其在Fastgen中采用的大部分创新（分页注意力、分块预填充等）。
- Daniel Haziza ([@danthe3rd](https://github.com/danthe3rd))，感谢其建设性的初始设计讨论及持续提供的高GPU利用率建议。

## 许可协议

Fastgen采用BSD三条款许可，详见LICENSE文件。







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---