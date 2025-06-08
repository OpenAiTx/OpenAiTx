# Memvid - 基于视频的 AI 记忆 🧠📹

**适用于大规模 AI 记忆的轻量级革命性解决方案**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid 通过将文本数据编码为视频，彻底革新了 AI 记忆管理，使得**百万级文本块的语义搜索**变得**极其迅速**，检索时间可达**亚秒级**。与传统的消耗大量内存和存储的向量数据库不同，Memvid 将你的知识库压缩为紧凑的视频文件，同时保持对任意信息的即时访问。

## 🎥 演示

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ 主要特性

- 🎥 **视频即数据库**：在单个 MP4 文件中存储百万级文本块
- 🔍 **语义搜索**：通过自然语言查询查找相关内容
- 💬 **内置聊天**：具备上下文感知回复的对话界面
- 📚 **PDF 支持**：可直接导入并索引 PDF 文档
- 🚀 **极速检索**：对大规模数据集进行亚秒级搜索
- 💾 **高效存储**：相比传统数据库压缩率可达 10 倍
- 🔌 **可插拔 LLM**：支持 OpenAI、Anthropic 或本地模型
- 🌐 **离线优先**：视频生成后无需联网即可使用
- 🔧 **简单 API**：3 行代码即可快速上手

## 🎯 应用场景

- **📖 数字图书馆**：在单个视频文件中索引成千上万本书籍
- **🎓 教育内容**：为课程资料创建可搜索的视频记忆库
- **📰 新闻档案**：将多年文章压缩为易管理的视频数据库
- **💼 企业知识库**：构建公司级可搜索知识库
- **🔬 科研论文**：对科学文献实现快速语义检索
- **📝 个人笔记**：将笔记转化为可搜索的 AI 助手

## 🚀 为什么选择 Memvid？

### 颠覆性创新
- **视频即数据库**：百万级文本块存储于单个 MP4 文件
- **即时检索**：大数据集内实现亚秒级语义搜索
- **10 倍存储效率**：视频压缩极大降低内存占用
- **零基础设施**：无需数据库服务器，仅需可随意复制的文件
- **离线优先**：视频生成后完全可离线运行

### 轻量级架构
- **依赖极少**：核心功能仅约 1000 行 Python 代码
- **CPU 友好**：无需 GPU 也能高效运行
- **便携式**：单个视频文件即包含全部知识库
- **可流式传输**：视频可从云存储直接流式播放

## 📦 安装

### 快速安装
```bash
pip install memvid
```

### 启用 PDF 支持
```bash
pip install memvid PyPDF2
```

### 推荐设置（虚拟环境）
```bash
# 创建新项目目录
mkdir my-memvid-project
cd my-memvid-project

# 创建虚拟环境
python -m venv venv

# 激活虚拟环境
# 在 macOS/Linux 上：
source venv/bin/activate
# 在 Windows 上：
venv\Scripts\activate

# 安装 memvid
pip install memvid

# 支持 PDF：
pip install PyPDF2
```

## 🎯 快速开始

### 基本用法
```python
from memvid import MemvidEncoder, MemvidChat

# 通过文本块创建视频记忆
chunks = ["重要事实1", "重要事实2", "历史事件详情"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# 与您的记忆聊天
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("你知道哪些历史事件？")
print(response)
```

### 从文档构建记忆库
```python
from memvid import MemvidEncoder
import os

# 加载文档
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# 添加文本文件
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# 构建优化视频
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # 更高的 FPS = 每秒更多文本块
    frame_size=512  # 更大帧尺寸 = 每帧容纳更多数据
)
```

### 高级搜索与检索
```python
from memvid import MemvidRetriever

# 初始化检索器
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# 语义搜索
results = retriever.search("机器学习算法", top_k=5)
for chunk, score in results:
    print(f"分数: {score:.3f} | {chunk[:100]}...")

# 获取上下文窗口
context = retriever.get_context("解释神经网络", max_tokens=2000)
print(context)
```

### 交互式聊天界面
```python
from memvid import MemvidInteractive

# 启动交互式聊天 UI
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # 在 http://localhost:7860 打开 Web 界面
```

### 使用 file_chat.py 进行测试
`examples/file_chat.py` 脚本可全面测试 Memvid 处理您的文档：

```bash
# 处理一个文档目录
python examples/file_chat.py --input-dir /path/to/documents --provider google

# 处理指定文件
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# 使用 H.265 压缩（需要 Docker）
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# 大文档自定义分块
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# 加载已有记忆
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### 完整示例：与 PDF 书籍对话
```bash
# 1. 新建目录并设置环境
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Windows 下用 venv\Scripts\activate

# 2. 安装依赖
pip install memvid PyPDF2

# 3. 创建 book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# 你的 PDF 文件
book_pdf = "book.pdf"  # 替换为你的 PDF 路径

# 构建视频记忆库
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# 与书本对话
api_key = os.getenv("OPENAI_API_KEY")  # 可选：用于 AI 回复
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. 运行
export OPENAI_API_KEY="your-api-key"  # 可选
python book_chat.py
```

## 🛠️ 高级配置

### 自定义嵌入模型
```python
from sentence_transformers import SentenceTransformer

# 使用自定义嵌入模型
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### 视频优化
```python
# 最大压缩
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # 更高的帧率
    frame_size=256,  # 更小的帧尺寸
    video_codec='h265',  # 更好的压缩率
    crf=28  # 压缩质量（数值越低，质量越好）
)
```

### 分布式处理
```python
# 并行处理大型数据集
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 故障排除

### 常见问题

**ModuleNotFoundError: No module named 'memvid'**
```bash
# 确保你使用的是正确的 Python
which python  # 应显示你的虚拟环境路径
# 如果不是，请激活你的虚拟环境：
source venv/bin/activate  # Windows 下为：venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**LLM API 密钥问题**
```bash
# 设置你的 API 密钥（可在 https://platform.openai.com 获取）
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# 或在 Windows 下：
set GOOGLE_API_KEY=AIzaSyB1-...
```

**大型 PDF 处理**
```python
# 对于超大 PDF，使用更小的分块尺寸
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 参与贡献

欢迎贡献！详情请参阅我们的[贡献指南](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md)。

```bash
# 运行测试
pytest tests/

# 以覆盖率模式运行
pytest --cov=memvid tests/

# 格式化代码
black memvid/
```

## 🆚 与传统方案的对比

| 功能         | Memvid | 向量数据库 | 传统数据库 |
|--------------|--------|------------|------------|
| 存储效率     | ⭐⭐⭐⭐⭐ | ⭐⭐         | ⭐⭐⭐       |
| 部署复杂度   | 简单   | 复杂        | 复杂       |
| 语义检索     | ✅     | ✅          | ❌         |
| 离线使用     | ✅     | ❌          | ✅         |
| 便携性       | 文件型 | 服务器型    | 服务器型   |
| 可扩展性     | 百万级 | 百万级      | 十亿级     |
| 成本         | 免费   | $$$$        | $$$        |


## 📚 示例

请查看 [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) 目录，包含：
- 从维基百科数据构建记忆
- 创建个人知识库
- 多语言支持
- 实时记忆更新
- 与主流 LLM 集成

## 🆘 获取帮助

- 📖 [文档](https://github.com/olow304/memvid/wiki) - 全面指南
- 💬 [讨论区](https://github.com/olow304/memvid/discussions) - 提问交流
- 🐛 [问题追踪](https://github.com/olow304/memvid/issues) - 报告 Bug
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - 分享你的项目

## 🔗 链接

- [GitHub 仓库](https://github.com/olow304/memvid)
- [PyPI 包](https://pypi.org/project/memvid)
- [更新日志](https://github.com/olow304/memvid/releases)


## 📄 许可证

MIT 许可证 - 详见 [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) 文件。

## 🙏 鸣谢

由 [Olow304](https://github.com/olow304) 及 Memvid 社区创建。

基于以下技术开发 ❤️：
- [sentence-transformers](https://www.sbert.net/) - 语义检索的先进嵌入技术
- [OpenCV](https://opencv.org/) - 计算机视觉与视频处理
- [qrcode](https://github.com/lincolnloop/python-qrcode) - 二维码生成
- [FAISS](https://github.com/facebookresearch/faiss) - 高效相似度搜索
- [PyPDF2](https://github.com/py-pdf/pypdf) - PDF 文本提取

特别感谢所有为 Memvid 做出贡献的朋友！

---

**准备好颠覆你的 AI 记忆管理方式了吗？立即安装 Memvid，开始构建吧！** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---