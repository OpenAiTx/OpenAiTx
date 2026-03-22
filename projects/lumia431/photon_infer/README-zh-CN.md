# PhotonInfer

<div align="center">

**一个具有 vLLM 风格连续批处理的高性能大型语言模型推理引擎**

[English](https://raw.githubusercontent.com/lumia431/photon_infer/master/README.md) | [中文](https://raw.githubusercontent.com/lumia431/photon_infer/master/README_ZH.md) | [在线演示](https://photoninfer.xyz/)

[![许可证: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![CUDA](https://img.shields.io/badge/CUDA-12.0+-green.svg)](https://developer.nvidia.com/cuda-toolkit)
[![C++20](https://img.shields.io/badge/C++-20-orange.svg)](https://en.cppreference.com/w/cpp/20)

</div>

---

## 🚀 性能亮点

PhotonInfer 为大型语言模型提供**生产级推理性能**，具备先进的批处理能力。**支持 Llama-3.2 和 Qwen3 模型**。

### 单次请求推理

| 模型 | PhotonInfer | llama.cpp | 加速比 |
|-------|-------------|-----------|---------|
| Llama 3.2 1B | 185 词元/秒 | 252 词元/秒 | 0.73×（llama.cpp 更快） |

**TTFT（首个词元时间）**：387 毫秒 @ 100 词元提示（INT8 量化）

### 批量推理吞吐量

| 批量大小 | PhotonInfer | llama.cpp | 加速比 |
|------------|-------------|-----------|---------|
| 4          | 410 词元/秒   | 252 词元/秒 | **1.63×** |
| 8          | 720 词元/秒   | 255 词元/秒 | **2.82×** |
| 16         | 787 词元/秒   | 253 词元/秒 | **3.07×** |

**测试环境**：NVIDIA A100，Llama 3.2 1B，Q8/INT8 量化

## ✨ 主要特性

### 🎯 **vLLM风格的连续批处理**
- **令牌级动态调度**：在生成过程中添加新请求，无需等待批处理完成
- **两阶段调度器**：无缝继续运行请求，同时接收新请求
- **请求状态跟踪**：精确管理 `num_computed_tokens`，高效恢复
- **生产环境完美适用**：高并发推理服务，实时响应

### ⚡ **GPU优化内核**
- **批量分页注意力**：块级KV缓存管理，高效利用内存
- **矢量化内存访问**：`float4`加载，实现2-4倍带宽效率
- **融合操作**：零拷贝GPU采样，批量RoPE，融合归一化
- **INT8量化**：支持cuBLASLt INT8 GEMM的分组量化
- **优化Softmax**：基于CUB BlockReduce的数值稳定注意力计算

### 🏗️ **现代C++20架构**
- **类型安全错误处理**：借鉴Rust的 `Result<T, E>` 类型显式传播错误
- **零拷贝设计**：广泛使用 `std::span` 和移动语义
- **设备无关**：CPU和CUDA后端统一接口
- **概念与范围**：编译时约束与表达性类型安全

## 🚀 快速开始

### 先决条件

- **编译器**：GCC 12+（需支持C++20）
- **CMake**：3.20+
- **CUDA工具包**：12.0+（已在12.5测试）
- **GPU**：支持计算能力7.0+的NVIDIA GPU

### 下载模型

下载预量化模型快速开始：

https://huggingface.co/Lummy666/llama-3.2-1B-Instruct

### 构建

#### 选项1：从源码构建

```bash
# Clone repository
cd photon_infer

# Configure with CUDA
mkdir build && cd build
cmake -DCMAKE_BUILD_TYPE=Release -DPHOTON_BUILD_CUDA=ON ..

# Build
cmake --build . -j$(nproc)

# Install (optional)
sudo cmake --install .
```
安装完成后，您可以直接从任何位置运行网络服务器：


```bash
photon_web_server \
    --port 5728 \
    --model /path/to/llama-3.2-1B-Instruct \
    --tokenizer /path/to/llama-3.2-1B-Instruct/tokenizer.json
```
安装将会放置：
- `photon_web_server` → `/usr/local/bin/`
- 静态网页文件 → `/photon_infer/web/static/`
- 核心库 → `/usr/local/lib/`

卸载方法：

```bash
cd build
sudo cmake --build . --target uninstall
```

#### 选项 2：使用 Docker（推荐）

```bash
# Pull the pre-built Docker image
docker pull lumia431/photon_infer:latest

# Run the container with GPU support
docker run --rm --gpus all -p 5728:5728 -e PORT=5728 lumia431/photon_infer:latest
```

Web界面将可通过 `http://localhost:5728` 访问

## 🔬 技术细节

### INT8 量化
- **分组量化**：可配置分组大小（32、64、128）
- **cuBLASLt 集成**：硬件加速的 INT8 GEMM
- **极小的精度损失**：Llama模型上困惑度下降 < 1%

### 分页注意力
- **块级 KV 缓存**：高效内存分配，无碎片
- **动态序列管理**：每序列缓存偏移，实现灵活调度
- **批处理缓存操作**：单核函数支持多序列 K/V 写入

### 连续批处理调度器
- **两阶段调度**：
  1. **阶段1**：继续所有运行中的请求（不打断）
  2. **阶段2**：接纳等待中的请求填充剩余容量
- **请求状态**：等待 → 运行 → 完成（支持抢占）
- **令牌级粒度**：通过 `num_computed_tokens` 精确追踪恢复点

## 🛣️ 路线图

- [x] **核心架构**：张量、算子、内存管理
- [x] **LLaMA模型**：完整Transformer实现，支持CPU/GPU核
- [x] **INT8量化**：基于cuBLASLt的分组量化
- [x] **分页注意力**：块级KV缓存管理
- [x] **连续批处理**：vLLM风格动态请求调度
- [ ] **Flash Attention 2**：面向长序列的IO感知注意力
- [ ] **多GPU支持**：大模型的张量并行
- [ ] **FP16/BF16混合精度**：提升现代GPU吞吐率
- [ ] **推测解码**：使用草稿模型进行多令牌生成

## 📖 文档

- [连续批处理设计](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/continuous_batching.md)
- [性能优化指南](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/performance.md)
- [API参考](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/api.md)

## 🤝 贡献

欢迎贡献！请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/contributing.md) 获取指南。

## 📝 许可

MIT 许可证 - 详情见 [LICENSE](LICENSE)。

## 🙏 致谢

- 架构灵感来源于 [vLLM](https://github.com/vllm-project/vllm)
- 内核优化参考 [llama.cpp](https://github.com/ggerganov/llama.cpp)
- 错误处理设计借鉴 Rust 的 `Result<T, E>`

---

**为高性能大型语言模型推理而用 ❤️ 构建**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-22

---