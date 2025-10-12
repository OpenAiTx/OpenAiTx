<center>
  <h1>ChinaTravel：中文旅游规划语言代理的真实世界基准
</h1>
</center>

论文《ChinaTravel：中文旅游规划语言代理的真实世界基准》的官方代码库。

<!-- | [网页](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [论文](https://arxiv.org/abs/2412.13682) | [数据集(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![网页](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![论文](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![数据集(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![竞赛(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![竞赛(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![概览](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 旅游规划挑战赛 (TPC@IJCAI)

我们自豪地宣布，ChinaTravel 被选为 **IJCAI 2025 旅游规划挑战赛（TPC）的官方基准**！

**官方竞赛网站**：
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

欢迎参赛者开发能够应对复杂约束下真实旅游规划场景的新型代理。本次竞赛将展示语言代理研究的最前沿方法。

## 📝 更新日志

### 2025.09
1. 上传了 TPC@IJCAI2025 DSL 赛道冠军方案。感谢 [@evergreenee](https://github.com/evergreenee) 的贡献。  


### 2025.06

1. 修复了常识评测代码中的错误收集问题。 
2. 修复了纯神经代理的流水线
3. 修复了从 Huggingface 加载数据集的问题
4. 更新了语法验证中的异常处理


### 2025.05

1. 更新最新版本的日志。
2. 提供TPC的评估代码。

### 2025.04

1. 新增本地数据加载器。用户现在可以本地加载自定义查询。当为“run_exp.py”指定非默认的splits_name值（例如“abc”）时，系统将自动从evaluation/default_splits/abc.txt中加载对应文件，TXT文件包含目标查询文件名。
2. 详细的约束分类。详见文档：[Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. 引入LLM-modulo基线
   实现带有真实符号验证器的LLM-modulo流程。
   基于以下方法：
   论文：Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   代码库：https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. 支持使用Qwen3-8B/4B进行本地LLM推理。

## 🚀 快速开始

### ⚙️ 环境配置

1. 创建conda环境并安装依赖：

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. 下载数据库并将其解压到 "chinatravel/environment/" 目录下

下载链接：[Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU)，[南京大学网盘](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. 下载开源大型语言模型（可选）。

```bash
bash download_llm.sh
```
4. 下载分词器。


```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ 运行

我们支持 deepseek（deepseek 官方 API）、gpt-4o（chatgpt-4o-latest）、glm4-plus 以及使用 Qwen（Qwen3-8B）、llama、mistral（Mistral-7B-Instruct-v0.3）等进行本地推理。

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**注意**：

- `--oracle_translation` 标志启用对带注释的真实数据的访问，包括：

  - `hard_logic_py`：可执行的验证DSL代码
  - `hard_logic_nl`：相应的约束描述
  - 示例注释结构：

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- LLM-modulo 方法**需要** oracle_translation 模式来进行其符号细化过程

### 📊 评估

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```
在 TPC@IJCAI2025 中，评估代码包含在 `eval_tpc.py` 文件中。你可以按如下方式运行评估代码：


```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 文档

[环境](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[约束](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ 高级开发

### 1. 开发您自己的代理算法

要开发您自己的代理算法，您需要继承 `chinatravel/agent/base.py` 中的 `BaseAgent` 类，并在 `chinatravel/agent/load_model.py` 的 `init_agent` 函数中添加您的算法逻辑。我们提供了一个名为 `TPCAgent` 的空代理示例。

步骤：

- **继承 `BaseAgent` 类**：在 `chinatravel/agent` 目录下创建一个新的 Python 文件，定义您自己的代理类，继承自 `BaseAgent`。

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **向 init_agent 函数添加代码**：打开 chinatravel/agent/load_model.py 文件，在 init_agent 函数中添加对新代理的支持。

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. 开发您自己的本地大型语言模型

要开发您自己的本地大型语言模型（LLM），您需要继承 chinatravel/agent/llms.py 中的 AbstractLLM 类，并在 llms.py 中添加相应的本地 LLM 推理代码。我们提供了一个名为 TPCLLM 的空白 LLM 示例。
步骤：

- **继承 AbstractLLM 类**：在 chinatravel/agent/llms.py 文件中定义您自己的 LLM 类，继承自 AbstractLLM。

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **在 init_agent 函数中添加代码**：打开 chinatravel/agent/load_model.py 文件，并在 init_llm 函数中添加对您的新 llm 的支持。

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. 使用实验脚本运行代码

完成上述开发后，您可以使用实验脚本运行代码。

运行示例：

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
结果将保存在 `results/YourMethodName_YourLLMName_xxx` 目录中，例如，`results/TPCAgent_TPCLLM`。

## ✉️ 联系方式

如果您有任何问题，请联系 [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn)。

## 📌 引用

如果我们的论文或相关资源对您的研究有价值，敬请引用。


```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-12

---