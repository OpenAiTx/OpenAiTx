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

<h5 align="center"> 🎉 如果你喜欢我们的项目，请在 GitHub 上为我们加星 ⭐ 以获取最新更新。</h5>
**MemoryOS** 旨在为个性化 AI 助手提供内存操作系统，实现更连贯、更个性化、更具上下文感知的交互。受操作系统内存管理原理启发，MemoryOS 采用分层存储架构，包含存储、更新、检索与生成四大核心模块，实现全面高效的记忆管理。在 LoCoMo 基准测试上，本模型在 F1 和 BLEU-1 得分上分别取得了平均 **49.11%** 和 **46.18%** 的提升。







## 📣 最新动态
*   *<mark>[新]</mark>* 🔥  **[2025-06-15]**:🛠️ 开源 **MemoryOS-MCP**！现可在 Agent 客户端自定义配置，实现无缝集成与定制化。[👉 查看](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: **MemoryOS** 初版发布！支持短期、中期、长期人格记忆及自动化用户画像与知识更新。

## 演示
[![观看视频](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	系统架构
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## 项目结构

```
memoryos/
├── __init__.py            # 初始化 MemoryOS 包
├── __pycache__/           # Python 缓存目录（自动生成）
├── long_term.py           # 管理长期人格记忆（用户画像、知识）
├── memoryos.py            # MemoryOS 主类，协调所有组件
├── mid_term.py            # 管理中期记忆，整合短期交互
├── prompts.py             # 存放用于 LLM 交互的提示词（如摘要、分析）
├── retriever.py           # 从各层记忆中检索相关信息
├── short_term.py          # 管理最近交互的短期记忆
├── updater.py             # 处理记忆更新，包括层级信息迁移
└── utils.py               # 库内通用工具函数
```

## 工作原理

1.  **初始化：** 使用用户和助手 ID、API 密钥、数据存储路径及各类容量/阈值参数初始化 `Memoryos`，为每个用户和助手建立独立存储空间。
2.  **添加记忆：** 用户输入与助手回复作为 QA 对被添加，最初存储于短期记忆中。
3.  **短期到中期处理：** 当短期记忆存满后，`Updater` 模块将这些交互整合成有意义片段，转存至中期记忆。
4.  **中期分析与 LPM 更新：** 中期记忆片段根据访问频率、交互长度等积累“热度”，当热度超阈值时触发内容分析：
    *   提取用户画像洞见并用于更新长期用户画像。
    *   提炼特定用户事实，加入用户长期知识库。
    *   相关助手信息则加入助手长期知识库。
5.  **响应生成：** 用户提出问题时：
    *   `Retriever` 模块从短期历史、中期记忆片段、用户画像与知识、助手知识库中检索相关上下文。
    *   综合上下文与用户问题，使用 LLM 生成连贯且有信息量的回复。

## MemoryOS_PYPI 快速开始

### 先决条件

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### 安装

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### 基本用法

```python

import os
from memoryos import Memoryos

# --- 基础配置 ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # 替换为你的密钥
BASE_URL = ""  # 可选：如用自定义 OpenAI 地址
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS 简单演示")
    
    # 1. 初始化 MemoryOS
    print("正在初始化 MemoryOS...")
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
        print("MemoryOS 初始化成功！\n")
    except Exception as e:
        print(f"错误: {e}")
        return

    # 2. 添加一些基本记忆
    print("正在添加记忆...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"用户: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"助手: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP 快速开始
### 🔧 核心工具

#### 1. `add_memory`
将用户与 AI 助手的对话内容存入记忆系统，用于构建持久化对话历史与上下文记录。

#### 2. `retrieve_memory`
根据查询内容，从记忆系统中检索相关历史对话、用户偏好与知识信息，帮助 AI 助手理解用户需求和背景。

#### 3. `get_user_profile`
获取由历史对话分析生成的用户画像，包括性格特征、兴趣偏好及相关知识背景。


### 1. 安装依赖
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. 配置

编辑 `config.json`：
```json
{
  "user_id": "你的用户ID",
  "openai_api_key": "你的OpenAI API密钥",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. 启动服务
```bash
python server_new.py --config config.json
```
### 4. 测试
```bash
python test_comprehensive.py
```
### 5. 在Cline及其他客户端配置
复制 mcp.json 文件，并确保文件路径正确。
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#需替换为你的虚拟环境 Python 解释器路径
```
## 贡献

欢迎贡献！请随时提交 issue 或 pull request。

## 引用
如需了解更多详情，请点击：[阅读完整论文](https://arxiv.org/abs/2506.06326)

如果您觉得本项目有用，欢迎引用我们的论文：

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## 联系我们
百家AI是北京邮电大学白婷副教授指导的研究小组，致力于为硅基人类打造情感饱满、记忆超凡的大脑。<br>
合作与建议：baiting@bupt.edu.cn<br>
欢迎关注百家Agent公众号和微信群，共同交流！  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公众号" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="微信群二维码" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---