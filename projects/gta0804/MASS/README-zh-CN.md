
# MASS：用于投资组合构建的多代理仿真扩展

📜 [论文链接](https://arxiv.org/abs/2505.10278)

## ✨ 概览

![MASS 概览](https://raw.githubusercontent.com/gta0804/MASS/main/img/MASS.pdf)

## 📝 你需要知道的

1. 目前，我们只提供了用于运行 MASS 的完整数据集中的一个非常[小子集](https://github.com/gta0804/MASS/tree/main/stock_disagreement/example_dataset)。完整数据集将在审稿完成后发布。

## 🧑‍💻 使用方法
1. **依赖安装**

```
conda create -n your_env_name python==3.10 -y
conda activate your_env_name
pip install pdm
pdm install
```
2. **数据集获取**  
获取数据集后，将所有 `ROOT_PATH` 变量更改为您的数据集目录。  
现在我们发布了一个基于 SSE 50 指数的示例数据集。  

3. **在您自己的数据集上扩展 MASS**  
由于时间限制，我们的数据源有限。我们鼓励您将更多数据源整合到 MASS 中，以获得更显著的性能提升，同时也鼓励您将 MASS 扩展到投资组合构建之外！  
您可以按以下步骤使用您的数据源：  
  - **定义您自己的数据模态。**  
  在 MASS 中，我们在 [这里](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L42) 预定义了多种数据模态。您可以将其更改为您自己的数据源。更改数据源后，记得修改数据加载代码，见 [这里](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L165)。
  ```
  class Modality(IntFlag):  
      FUDAMENTAL_VALUTION = 0b00000001  
      FUDAMENTAL_DIVIDEND = 0b00000010 
      FUDAMENTAL_GROWTH = 0b000000100
      FUDAMENTAL_QUALITY = 0b000001000
      NEWS = 0b000010000      
      BASE_DATA = 0b000100000  
      CROSS_INDUSTRY_LABEL = 0b001000000
      RISK_FACTOR = 0b010000000
      PRICE_FEATURE = 0b100000000 
  ```
- **使用您自己的聚合函数。**  
  在MASS中，我们通过市场分歧假说聚合个体投资者的决策。实际上，您可以使用自己的聚合方法。请在[investor_analyzer.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/investment_analyzer.py)中修改代码以实现您自己的聚合函数！  
  - **使用不同的优化器**  
     在MASS中，我们在代理分布优化中使用模拟退火。我们在[agent_distribution.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/agent_distribution.py)中实现了一个优化器框架。您可以定义您自己的优化器。  
  

4. **计算资源配置。**  
我们使用[Qwen2.5-72B-Instruct](https://huggingface.co/Qwen/Qwen2.5-72B-Instruct)作为基础模型。您可以在[这里](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L57)更改您的基础模型URL。  
对于SSE 50和默认配置，需80GiB内存。您可以通过调整[这里](https://github.com/gta0804/MASS/blob/main/stock_disagreement/exp/trainer.py#L148)的代理并行度来节省内存开销。  

5. **运行MASS**
```
python stock_disagreement/main.py
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---