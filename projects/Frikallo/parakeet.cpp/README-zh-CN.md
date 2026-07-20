# parakeet.cpp

使用NVIDIA的[Parakeet](https://huggingface.co/collections/nvidia/parakeet)模型实现纯C++的快速语音识别。

基于[axiom](https://github.com/frikallo/axiom)构建 —— 一个轻量级张量库，支持自动Metal GPU加速。无ONNX运行时，无Python运行时，无重量级依赖。仅使用C++和一个比PyTorch MPS更快的张量库。

**Apple Silicon GPU上10秒音频的编码器推理约27毫秒**（110M模型）——比CPU快96倍。支持FP16，内存减少约2倍。

## 支持的模型

| 模型 | 类别 | 规模 | 类型 | 说明 |
|-------|-------|------|------|-------------|
| `tdt-ctc-110m` | `ParakeetTDTCTC` | 110M | 离线 | 英语，双CTC/TDT解码头 |
| `tdt-600m` | `ParakeetTDT` | 600M | 离线 | 多语言，TDT解码器 |
| `eou-120m` | `ParakeetEOU` | 120M | 流式 | 英语，带结束语检测的RNNT |
| `nemotron-600m` | `ParakeetNemotron` | 600M | 流式 | 多语言，可配置延迟（80ms–1120ms） |
| `sortformer` | `Sortformer` | 117M | 流式 | 说话人分离（最多4个说话人） |
| `diarized` | `DiarizedTranscriber` | 110M+117M | 离线 | 语音识别 + 说话人分离 → 说话人标注词汇 |

所有ASR模型共享相同的音频流水线：16kHz单声道WAV → 80箱Mel频谱图 → FastConformer编码器。

## 快速开始

```cpp
#include <parakeet/parakeet.hpp>

parakeet::Transcriber t("model.safetensors", "vocab.txt");
t.to_gpu();   // optional — Metal acceleration
t.to_half();  // optional — FP16 inference (~2x memory reduction)

auto result = t.transcribe("audio.wav");
std::cout << result.text << std::endl;
```

## 功能特性

- **多解码器** — CTC 贪心，TDT 贪心，CTC 波束搜索，TDT 波束搜索（调用时切换）
- **词级时间戳** — 所有解码器均提供每词的起止时间及置信度分数
- **波束搜索 + 语言模型** — CTC 和 TDT 波束搜索支持可选 ARPA n-gram 语言模型融合
- **短语增强** — 通过基于词元的字典树实现领域专用词汇的上下文偏置
- **批量转录** — 多文件可在一次编码器前向传递中批量处理
- **VAD 预处理** — Silero VAD 在 ASR 前剥离静音；时间戳自动重映射
- **GPU 加速** — 通过 axiom 的 MPSGraph 编译器使用 Metal（Apple Silicon 上加速 96 倍）
- **FP16 推理** — 半精度权重和计算（内存约减少一半）
- **流式处理** — 支持 EOU 和 Nemotron 模型的分块音频输入
- **说话人分离** — Sortformer（最多支持 4 位说话人），可与 ASR 结合实现说话人归属词
- **C API** — 提供平坦的 `extern "C"` FFI，支持 Python、Swift、Go、Rust 等语言
- **多格式音频** — 支持 WAV、FLAC、MP3、OGG，自动重采样

请参见 [examples/](examples/) 目录获取演示各项功能的代码示例。

## 安装

预编译二进制文件附带于每个 [GitHub 发布](https://github.com/Frikallo/parakeet.cpp/releases)，支持 macOS arm64、macOS x86_64 和 Linux x86_64。下载对应平台的压缩包并解压：

```bash
tar -xzf parakeet-v0.1.0-macos-arm64.tar.gz
cd parakeet-v0.1.0-macos-arm64
# On macOS, clear the Gatekeeper quarantine attribute first:
xattr -dr com.apple.quarantine .
./bin/parakeet --help
```

该归档包含一个自包含的 `bin/parakeet`（和 `bin/example-server`）以及带有设置了 `@rpath`/`$ORIGIN` 的 `lib/libaxiom`，使二进制文件能够相对于安装目录解析其依赖关系——可以将目录放置在任何地方。`include/parakeet/` 下的 C-API 头文件供嵌入使用。

## 从源码构建

```bash
git clone --recursive https://github.com/frikallo/parakeet.cpp
cd parakeet.cpp
make build
make test
```

要求：C++20（Clang 14+ 或 GCC 12+），CMake 3.20+，macOS 13+ 以支持 Metal GPU。

> **macOS：** 构建需要 **完整的 Xcode** 安装（不仅仅是命令行工具），因为 axiom 使用 `xcrun metal` 和 `xcrun metallib` 编译其 Metal 着色器 — 这些仅随 Xcode 一起提供。如果您只想运行 parakeet，请使用上面预构建的 tar 包；`.metallib` 已嵌入到随附的 `libaxiom.dylib` 中，用户端无需安装任何 Xcode/命令行工具即可运行。

## 转换权重

```bash
# Download from HuggingFace
huggingface-cli download nvidia/parakeet-tdt_ctc-110m --include "*.nemo" --local-dir .

# Convert to safetensors
pip install safetensors torch
python scripts/convert_nemo.py parakeet-tdt_ctc-110m.nemo -o model.safetensors
```
转换器支持所有模型类型：`110m-tdt-ctc`（默认）、`600m-tdt`、`eou-120m`、`nemotron-600m`、`sortformer`。


```bash
python scripts/convert_nemo.py checkpoint.nemo -o model.safetensors --model 600m-tdt
```
Silero VAD 权重：

```bash
python scripts/convert_silero_vad.py -o silero_vad_v5.safetensors
```

## 示例

| 示例 | 描述 |
|---------|-------------|
| [basic](examples/basic/) | 最简单的转录（约20行） |
| [timestamps](examples/timestamps/) | 带置信度的单词/标记时间戳 |
| [beam-search](examples/beam-search/) | 具有可选ARPA语言模型的CTC/TDT束搜索 |
| [phrase-boost](examples/phrase-boost/) | 针对领域词汇的上下文偏置 |
| [batch](examples/batch/) | 多文件批量转录 |
| [vad](examples/vad/) | 独立VAD和ASR+VAD预处理 |
| [gpu](examples/gpu/) | Metal GPU + FP16及时间比较 |
| [stream](examples/stream/) | EOU流式转录 |
| [nemotron](examples/nemotron/) | 带有延迟模式的Nemotron流式 |
| [diarize](examples/diarize/) | Sortformer说话人分离 |
| [diarized-transcription](examples/diarized-transcription/) | ASR + 分离结合 |
| [c-api](examples/c-api/) | 纯C99 FFI用法 |
| [cli](examples/cli/) | 带所有选项的完整CLI |

## 作为库使用

### CMake `find_package`

安装后（`make install` 或 `cmake --install build`）：

```cmake
find_package(Parakeet REQUIRED)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### CMake `add_subdirectory`

```cmake
add_subdirectory(third_party/parakeet.cpp)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### pkg-config

```bash
g++ -std=c++20 myapp.cpp $(pkg-config --cflags --libs parakeet) -o myapp
```
## 架构

### 离线模型

基于共享的 FastConformer 编码器（Conv2d 8倍下采样 → N 个带相对位置注意力的 Conformer 块）构建：

| 模型 | 类别 | 解码器 | 使用场景 |
|-------|-------|---------|----------|
| CTC | `ParakeetCTC` | 贪婪最大值或束搜索（+语言模型） | 快速，仅限英语 |
| RNNT | `ParakeetRNNT` | 自回归 LSTM | 支持流式 |
| TDT | `ParakeetTDT` | LSTM + 时长预测，贪婪或束搜索（+语言模型） | 准确率优于 RNNT |
| TDT-CTC | `ParakeetTDTCTC` | 同时具备 TDT 和 CTC 头 | 推理时切换解码器 |

### 流式模型

基于支持缓存的流式 FastConformer 编码器，带因果卷积和有界上下文注意力：

| 模型 | 类别 | 解码器 | 使用场景 |
|-------|-------|---------|----------|
| EOU | `ParakeetEOU` | 流式 RNNT | 语句结束检测 |
| Nemotron | `ParakeetNemotron` | 流式 TDT | 可配置延迟流式 |

### 说话人分离

| 模型 | 类别 | 架构 | 使用场景 |
|-------|-------|-------------|----------|
| Sortformer | `Sortformer` | NEST 编码器 → Transformer → sigmoid | 说话人分离（最多4人） |

## 基准测试

在 Apple M3 16GB 上使用模拟音频输入（`Tensor::randn`）测量。时间为每次编码器前向传递（Sortformer：完整前向传递）。

**编码器吞吐量 — 10秒音频：**

| 模型 | 参数量 | CPU（毫秒） | GPU（毫秒） | GPU 加速比 |
|-------|--------|----------|----------|-------------|
| 110m (TDT-CTC) | 110M | 2,581 | 27 | **96倍** |
| tdt-600m | 600M | 10,779 | 520 | **21倍** |
| rnnt-600m | 600M | 10,648 | 1,468 | **7倍** |

| sortformer | 117M | 3,195 | 479 | **7倍** |

**110m GPU在不同音频长度下的扩展性能：**

| 音频长度 | CPU (毫秒) | GPU (毫秒) | 实时因子 | 吞吐量 |
|-------|----------|----------|-----|------------|
| 1秒 | 262 | 24 | 0.024 | 41倍 |
| 5秒 | 1,222 | 26 | 0.005 | 190倍 |
| 10秒 | 2,581 | 27 | 0.003 | 370倍 |
| 30秒 | 10,061 | 32 | 0.001 | 935倍 |
| 60秒 | 26,559 | 72 | 0.001 | 833倍 |

GPU加速由axiom的Metal图编译器驱动，将完整编码器融合为优化的MPSGraph操作。

```bash
make bench ARGS="--110m=models/model.safetensors --tdt-600m=models/tdt.safetensors"
```

## 路线图

### 第一阶段 — 高影响力

- [x] **置信度分数** — 通过令牌对数概率计算每个令牌和每个词的置信度
- [x] **短语提升** — 解码时的令牌级前缀树上下文偏置
- [x] **束搜索** — CTC前缀束搜索和TDT时间同步束搜索
- [x] **N-gram语言模型融合** — 在词边界计算的ARPA语言模型评分

### 音频与输入输出

- [x] **多格式音频** — 通过dr_libs + stb_vorbis支持WAV、FLAC、MP3、OGG
- [x] **自动重采样** — 窗口化sinc插值（Kaiser，16抽头）
- [x] **从内存加载** — `read_audio(bytes, len)`，支持float/int16缓冲区
- [ ] **音频时长查询** — 仅头信息时长查询，无需完整解码
- [ ] **进度回调** — 长文件的阶段报告
- [ ] **从原始PCM流式传输** — 直接麦克风缓冲区输入

### 第二阶段 — 生产准备

- [x] **说话人分离转录** — ASR + Sortformer → 带说话人标注的词
- [x] **语音活动检测（VAD）** — Silero VAD v5，独立及ASR预处理
- [x] **批量推理** — 填充多文件编码器前向传递
- [ ] **长音频分块** — 对超过30秒的音频使用重叠窗口
- [ ] **神经语言模型重评分** — 使用Transformer LM进行N-best重排序

### 第三阶段 — 生态系统

- [x] **C接口** — 适用于任何语言的扁平C语言FFI接口
- [x] **FP16推理** — 半精度权重和计算
- [ ] **模型量化** — 用于移动端部署的INT8/INT4
- [ ] **热词检测** — 触发词检测
- [ ] **说话人嵌入** — 来自Sortformer/TitaNet的说话人验证

## 说明

- 音频：16kHz单声道（WAV、FLAC、MP3、OGG — 自动检测并重采样）
- 离线模型支持约4-5分钟音频长度；更长音频请使用流式模型
- GPU加速需要支持Metal的Apple Silicon

## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---