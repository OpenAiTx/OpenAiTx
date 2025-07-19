<translate-content># FormFactory: An Interactive Benchmarking Suite for Multimodal Form-Filling Agents

![](https://raw.githubusercontent.com/formfactory-ai/formfactory/main/img/fig1v1_page_1.png)

<p align="center">
  <a href="https://arxiv.org/abs/2506.01520"><img src="https://img.shields.io/badge/arXiv-2506.01520-B31B1B.svg" alt="arXiv"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io/#demo-video" target="_blank"><img src="https://img.shields.io/badge/Demo-Video-orange.svg" alt="Video Demo"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io" target="_blank"><img src="https://img.shields.io/badge/Project_Page-Website-blue.svg" alt="Project Page"></a>
</p>

## 📖 Overview
Online form filling is one of the most common—yet most labor-intensive—daily tasks. Traditional automation tools are usually rule-based scripts that struggle with complex and ever-changing web layouts. With the recent rise of Multimodal Large Language Models (**MLLMs**), researchers have begun to explore vision-language agents capable of "one-click" form completion. However, current models still fall short in layout understanding and field–value alignment.

**FormFactory** bridges this gap by providing a high-fidelity benchmark and experimentation platform for multimodal form-filling agents. The project consists of:

1. 🌐 **Web Front-End** – 40+ high-fidelity HTML forms from real-world scenarios spanning eight domains (academia, business, finance, healthcare, etc.).
2. 🗄 **Dataset** –
   • `data1/` contains JSON **gold answers** (ground-truth field values) for each form.
   • `data2/` stores supporting **textual materials** that can be used as additional context or prompts.
   • `labeled-images/` provides page **screenshots** and corresponding **bbox annotations** (organized by folders A–H).
3. ⚙️ **Back-End Service** – A lightweight Flask API that renders pages, receives submissions, and saves results automatically.
4. 📊 **Evaluation Scripts** – Utilities for computing field-level and form-level accuracy, layout reasoning metrics, and more.

---

## 🚀 Quick Start

### 1  Prerequisites

- Python ≥ 3.8
- Flask == 2.3.*
- Install additional dependencies with:</translate-content>
  ```bash
  pip install -r requirements.txt
  ```
### 2  Clone Repository

```bash
git clone https://github.com/formfactory-ai/formfactory.git
cd formfactory
```
### 3  Run Demo Server

```bash
python app.py        # default: http://127.0.0.1:5000/
```
Open the URL in your browser, pick any form from the dashboard, and start interacting.

---

## 🗂 Directory Layout
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

## ✨ Key Features
- **Multi-Domain Coverage** – Academia, business, arts, technology, finance, healthcare, law, and manufacturing.
- **High-Fidelity Pages** – Realistic layouts to test visual understanding and field localization.
- **Dynamic Fields** – Groups, repeatable sections, cascading dependencies, and more.
- **Interactive Evaluation** – Run the server to observe model behavior in real time; results are saved automatically.
- **Easy to Extend** – Add a new form by simply providing an HTML template and a JSON answer file.

---

## 🧪 Evaluation

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
> Complete your API call in `model_call.py`, and customize your evaluation in `evaluator.py`

## 📄 License
This project is released under the **MIT License** – see the [LICENSE](LICENSE) file for details.

---

## 🔗 Citation
If you use FormFactory in your research, please cite:

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
Happy researching, and let's advance multimodal form-filling agents together!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---