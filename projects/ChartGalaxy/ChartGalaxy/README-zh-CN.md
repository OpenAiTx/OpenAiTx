![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## 数据集
> 📦 **[👉 在 Hugging Face 获取完整的 ChartGalaxy 数据集！👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

由于存储限制，我们仅包含了一组具有代表性的示例。
本仓库包含了论文《ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation》相关的代码。

## 🔥 新闻
**2025.5**：🎉🎉 我们发布了首个版本的数据集，包含 1,151,087 个合成信息图表和 104,519 个真实信息图表，涵盖 75 种图表类型和 330 种变体。

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![示例图片](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 新闻 -->

## 简介

### 关于

ChartGalaxy 是一个包含百万级合成与真实信息图表的数据集，并配有数据表，支持信息图表理解、代码生成及图表生成等应用。该数据集解决了现有数据集大多仅限于基础图表，无法覆盖信息图表多样的设计风格和布局这一挑战。

### 统计信息

- **规模**：1,255,606 个信息图表（1,151,087 个合成图表 + 104,519 个真实图表）
- **内容**：每个信息图表都配有用于生成该图表的表格数据
- **图表类型**：75 种图表类型，330 种图表变体
- **布局模板**：68 种布局模板

### 数据收集与生成

ChartGalaxy 的构建方式如下：

1. **真实信息图表收集**：从 19 个知名的富含图表的网站（如 Pinterest、Visual Capitalist、Statista、Information is Beautiful）收集图表。

2. **合成信息图表生成**：遵循归纳结构化流程，包括：
   - 识别 75 种图表类型（如柱状图）及 330 种反映不同视觉元素风格的图表变体
   - 提取 68 种布局模板，定义元素间的空间关系
   - 基于这些模式程序化生成合成图表

## 🎯 应用场景

ChartGalaxy 的实用性通过三个代表性应用进行了展示：

### 1. 🧠 信息图表理解

在 ChartGalaxy 上微调可提升基础模型在信息图表理解任务上的表现。

### 2. 💻 信息图表代码生成

用于评估 LVLMs 在信息图表代码生成能力的基准。该基准评估生成的 D3.js 代码渲染出的图表与真实图表在两个粒度层面的相似性：高层次（整体视觉相似性）和低层次（细粒度 SVG 元素的平均相似性）。

#### 概览

该基准从两个层面对图表代码生成进行评估：
- **低层次**：生成 SVG 与参考 SVG 的元素级相似性
- **高层次**：整体视觉保真度与功能性评估

#### 安装

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### 使用方法

1. 配置 `code_generation_benchmark/configs/default_config.yaml`：
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # 取消注释你要评估的模型
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. 运行基准评测：
   ```bash
   python main.py
   ```

#### 数据结构

`data_root_dir` 下每个图表文件夹应包含：
- `chart.svg`：原始 SVG 格式的图表

系统将生成：
- `convert_chart.html`：参考图表的 HTML 渲染
- `convert_chart.png`：参考图表的 PNG 截图
- `convert_chart.json`：参考图表的元素结构
- 各模型输出的子文件夹

#### 结果

结果将保存在各模型子文件夹中，包括：
- 生成的 HTML/PNG 渲染结果
- JSON 格式的评测指标
- `log_dir` 下的详细日志
  

### 3. 🖼️ 基于示例的信息图表生成

一种基于示例的方法，将用户提供的表格数据转化为信息图表，并与给定示例图表的布局和视觉风格保持一致。用户研究显示，该方法在保真度、美观性和创造力方面优于 GPT-Image-1。


## 联系方式
- chartgalaxy@163.com

## 论文链接

### 📌 主论文（本仓库）

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### 相关论文

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 引用
如果您在研究中使用了 ChartGalaxy，请引用：
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---