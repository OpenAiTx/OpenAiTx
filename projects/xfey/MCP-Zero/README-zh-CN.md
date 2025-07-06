## MCP-Zero：面向自主LLM智能体的主动工具发现

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


感谢您关注 MCP-Zero！🤗

我们现已开源论文中涉及的代码。我们将持续更新我们的工作，探索其在工业界的应用，并不断扩展该项目。


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> 使用 MCP-Zero 主动构建“做一顿美餐”的工具链</p>
</div>


### 方法：MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # 实验：APIBank
├── experiment_mcptools.py      # 实验：mcp_tools（needle test）
├── matcher.py                  # 相似度匹配代码
├── prompt_guide/               # 方法相关提示词
├── reformatter.py              # 工具描述的json格式化器
├── sampler.py                  # 选择目标工具的采样器
├── test_cases.jsonl            # 匹配器的测试用例
├── test_matcher.py             # 匹配器的单元测试
└── utils.py                    # 工具函数：grid_search
```

我们现已发布论文所用的代码。论文中的代码实现了检索能力，并在实验中取得了具体成果。

在后续工作中，我们致力于将 MCP-zero 应用于工业界，因此还需要涉及其他模块，比如 MCP 服务器的动态部署、GAIA 测试的环境部署等。我们会持续完善本工作，感谢大家的关注。欢迎点亮 star🌟，让我知道你在关注 :D



### 数据集：MCP-tools

- **Google Drive**: [下载链接](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface 链接**: 敬请期待
- **请将文件放置于**: `./MCP-tools/mcp_tools_with_embedding.json`


**简介**：本数据集包含 MCP 官方仓库中所有筛选过的工具（共 308 个服务器和 2,797 个工具）。

**数据结构**：
```
{
  "server_name": string, // MCP服务器名称，从README中提取或推断
  "server_summary": string, // 服务器用途和能力的摘要，基于README的相关部分
  "server_description": string, // 元数据中的描述 
  "description_embedding": float[3072], // 服务器描述的embedding，来自text-embedding-3-large
  "summary_embedding": float[3072], // 服务器摘要的embedding，来自text-embedding-3-large
  "tools": [
    {
      "name": string, // 函数/工具名
      "description": string, // 工具功能的简要描述
      "description_embedding": float[3072], // 工具描述的embedding，来自text-embedding-3-large
      "parameter": { // 输入参数字典，如有明确定义则包含
        "param1": "(类型) 描述1",
        "param2": "(可选, 类型) 描述2"
      }
    }
  ]
}
```

**自定义构建数据集**：如需为 MCP 服务器构建自定义数据集，可参考 `MCP-tools/build_data` 文件夹下的代码。

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # 提取 MCP 服务器 ReadMe 结构化数据的代码
│   ├── run_vllm.sh                 # 使用 VLLM 部署 Qwen2.5-72B-Instruct 模型
│   └── server_summary.prompt       # 数据集抽取用 prompt
└── download_data.md
```


### 引用

> 被引用会让我很开心。
> 
>   ——莎士比亚
>   ~~（纯属娱乐 :D）~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
```
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---