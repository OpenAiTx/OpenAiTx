# ExpeRepair

**ExpeRepair** 是一个新颖的基于大型语言模型（LLM）的程序修复框架，通过双重记忆系统持续积累和重用历史修复经验。它包含两个核心组件：
- **程序修复模块**：由测试代理和补丁代理组成，协同处理三个关键任务——测试生成、补丁生成和补丁验证。
- **记忆模块**：从程序修复模块中捕获修复轨迹，提取具体示范并总结高级修复策略，分别存储在**情景记忆**和**语义记忆**中。在未来的修复过程中，ExpeRepair 会检索相关示范和见解，以增强其针对新问题的修复策略。

## 🚀 快速开始

### 安装
```bash
git clone <repository-url>
cd ExpeRepair-v1.0
pip install -r requirements.txt
```

### 环境设置

将您的 API 密钥设置为环境变量：
```bash
export PYTHONPATH=$PYTHONPATH:$(pwd)
# OpenAI key
export OPENAI_KEY="your-openai-key"
# Anthropic Key
export CLAUDE_KEY="your-anthropic-key"
```
继承自 [Agentless](https://arxiv.org/abs/2407.01489)，ExpeRepair 使用 **仓库结构格式** 来定位可疑文件。  
您可以自行预处理仓库，或下载准备好的数据：[swebench_lite_repo_structure.zip](https://github.com/OpenAutoCoder/Agentless/releases/tag/v1.5.0)。  

下载后，解压并导出其位置：

```bash
export PROJECT_FILE_LOC={folder which you saved}
```
最后，按照[auto-code-rover项目](https://github.com/AutoCodeRoverSG/auto-code-rover#setting-up-testbed)中的说明设置测试平台。

### 在完整基准上运行ExpeRepair
1. 使用**所有实例ID**运行`run_reproduce_initial.sh`。
2. 使用**所有实例ID**运行`run_localization.sh`。
3. 对于复现成功的实例（即生成了有效的`reproducer_X.py`脚本），运行`generate_initial.py`。
4. 对于剩余的实例，运行`generate_w_memory.py`，该脚本利用累积的记忆并持续更新它。
5. 最后，使用所有实例ID运行`validation.py`和`obtain_predictions.py`。

### 使用方法


```bash
# reproduce the issue
bash inference/run_reproduce_initial.sh

# localize potential bug locations
bash inference/run_localization.sh

# generate candidate patches
bash inference/run_generate.sh

# validate candidate patches and select the best one
python inference/validation.py

# obtain the prediction results
python inference/obtain_predictions.py
```

## 🙏 致谢

* [SWE-bench](https://www.swebench.com/)
* [auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover)
* [Agentless](https://github.com/OpenAutoCoder/Agentless/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---