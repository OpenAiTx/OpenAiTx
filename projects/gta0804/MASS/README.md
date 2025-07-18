# MASS: Multi-Agent Simulation Scaling  for Portfolio Construction

📜 [Paper Link](https://arxiv.org/abs/2505.10278)

## ✨ Overview

![Overview of MASS](https://raw.githubusercontent.com/gta0804/MASS/main/img/MASS.pdf)

## 📝 What You Need to Know

1. Currently, we only provide a very [small subset](https://github.com/gta0804/MASS/tree/main/stock_disagreement/example_dataset) of the complete dataset for running MASS. The full dataset will be released after the review is completed.

## 🧑‍💻Usage
1. **dependency installation**
```
conda create -n your_env_name python==3.10 -y
conda activate your_env_name
pip install pdm
pdm install
```
2. **dataset fetching**
After fetching dataset, change all `ROOT_PATH` variables to your dataset directory.
Now we release an example dataset on SSE 50 index.

3. **Extend MASS on your own dataset**
Due to time limit, our data source is limited. We encourage you to incorporate more data sources into MASS to get more significant performances, and we also encourage you to extend MASS beyond investment portfolio construction!
You can use your data sources step by step below:
  - **Define your own data modality.**
  In MASS, we pre-define multiple data modalities in [here](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L42). You can change them into your own data sources. After changing your data sources, remember to change data loading  code [here](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L165).
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
  - **Use your own aggregation function.**
  In MASS, we aggregate individual investor's decision by market disagreement hypothesis. In fact, you can use your own aggregation method. Change the code in [investor_analyzer.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/investment_analyzer.py) for your own aggregation function!
  - **Use different optimizers**
     In MASS, we use simulated annealing on agent distaribution optimization. We imeplement an optimzer framework in [agent_distribution.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/agent_distribution.py). You can define your own optimizer.
  

4. **Compute resources configuration.**
We use [Qwen2.5-72B-Instruct](https://huggingface.co/Qwen/Qwen2.5-72B-Instruct) as our foundation model. You can change your foundation model url [here](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L57).
For SSE 50 and the default configuration, 80GiB RAM is needed. You can save memory overhead by adjusting the agent parallelism [here](https://github.com/gta0804/MASS/blob/main/stock_disagreement/exp/trainer.py#L148).

5. **Running MASS**
```
python stock_disagreement/main.py
```
