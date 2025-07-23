
# FormFactory：多模态表单填写代理的交互式基准测试套件

![](https://raw.githubusercontent.com/formfactory-ai/formfactory/main/img/fig1v1_page_1.png)

<p align="center">
  <a href="https://arxiv.org/abs/2506.01520"><img src="https://img.shields.io/badge/arXiv-2506.01520-B31B1B.svg" alt="arXiv"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io/#demo-video" target="_blank"><img src="https://img.shields.io/badge/Demo-Video-orange.svg" alt="视频演示"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io" target="_blank"><img src="https://img.shields.io/badge/Project_Page-Website-blue.svg" alt="项目主页"></a>
</p>

## 📖 概述
在线表单填写是最常见且最费时的日常任务之一。传统的自动化工具通常是基于规则的脚本，难以应对复杂且不断变化的网页布局。随着多模态大型语言模型（**MLLMs**）的兴起，研究人员开始探索能够“一键”完成表单的视觉语言代理。然而，目前的模型在布局理解和字段-值对齐方面仍存在不足。

**FormFactory** 通过提供一个高保真的多模态表单填写代理基准和实验平台，弥补了这一差距。该项目包括：

1. 🌐 **网页前端** – 来自八个领域（学术、商业、金融、医疗等）的40多个真实场景的高保真HTML表单。
2. 🗄 **数据集** –
   • `data1/` 包含每个表单的JSON格式**标准答案**（字段真实值）。
   • `data2/` 存储可用作额外上下文或提示的**文本材料**。
   • `labeled-images/` 提供页面**截图**及对应的**边界框注释**（按文件夹A–H组织）。
3. ⚙️ **后端服务** – 轻量级Flask API，用于渲染页面、接收提交并自动保存结果。
4. 📊 **评估脚本** – 用于计算字段级和表单级准确率、布局推理指标等的工具。

---

## 🚀 快速开始

### 1 先决条件

- Python ≥ 3.8
- Flask == 2.3.*
- 使用以下命令安装其他依赖：

  ```bash
  pip install -r requirements.txt
  ```
### 2  克隆仓库

```bash
git clone https://github.com/formfactory-ai/formfactory.git
cd formfactory
```
### 3  运行演示服务器

```bash
python app.py        # default: http://127.0.0.1:5000/
```

在浏览器中打开该网址，从仪表板中选择任何表单，然后开始互动。

---

## 🗂 目录结构

```text
formfactory/
├─ app.py                # Flask back-end entry point
├─ templates/            # 40+ HTML form templates
├─ static/               # Stylesheets & front-end assets
├─ data/                 # Dataset root
│  ├─ data1/             # Gold answers in JSON format
│  ├─ data2/             # Supporting textual materials
│  └─ labeled-images/    # Screenshots + bbox annotations (A–H)
├─ submission/           # Auto-generated user/model submissions
└─ README.md             # This document
```
---

## ✨ 主要特性
- **多领域覆盖** – 学术、商业、艺术、技术、金融、医疗、法律及制造业。
- **高保真页面** – 真实布局，用于测试视觉理解和字段本地化。
- **动态字段** – 组、可重复部分、级联依赖等。
- **交互式评估** – 运行服务器实时观察模型行为；结果自动保存。
- **易于扩展** – 只需提供 HTML 模板和 JSON 答案文件即可添加新表单。

---

## 🧪 评估

![](https://raw.githubusercontent.com/formfactory-ai/formfactory/main/img/systemoverview_page_1.png)


```bash
# 📁 Navigate to evaluation directory
cd eval

# 🔄 Process data with model API
python batch_processor.py A11 json --filename Art_Exhibition_Submission_Form

# 📊 Evaluate model performance  
python evaluator.py --batch

# 📋 View detailed evaluation report
cat evaluation_results/batch_evaluation_*_report.txt
```
---

> [!NOTE]
>
> 在 `model_call.py` 中完成您的 API 调用，并在 `evaluator.py` 中自定义您的评估

## 📄 许可
本项目在 **MIT 许可证** 下发布 – 详见 [LICENSE](LICENSE) 文件。

---

## 🔗 引用
如果您在研究中使用 FormFactory，请引用：

```bibtex
@misc{li2025formfactoryinteractivebenchmarkingsuite,
  title        = {FormFactory: An Interactive Benchmarking Suite for Multimodal Form-Filling Agents},
  author       = {Bobo Li and Yuheng Wang and Hao Fei and Juncheng Li and Wei Ji and Mong-Li Lee and Wynne Hsu},
  year         = {2025},
  eprint       = {2506.01520},
  archivePrefix= {arXiv},
  primaryClass = {cs.CL},
  url          = {https://arxiv.org/abs/2506.01520}
}
```
快乐研究，让我们一起推动多模态表单填写代理的发展！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---