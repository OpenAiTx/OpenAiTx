<div align="center">

<!-- TITLE -->
# **Diffusion Language Models are Super Data Learners**

[![Static Badge](https://img.shields.io/badge/Blog-2025--08--09-darkcyan)](https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/cloudposse.svg?style=social&label=tweet)](https://x.com/NiJinjie/status/1954177095435014533)
</div>

# Highlights
- We pre-trained DLMs and AR models from scratch for up to **8B parameters** and **480B tokens**. DLMs demonstrate > **3x** greater data potential compared to autoregressive (AR) models. Notably, a 1B-parameter masked diffusion model achieves > **56%** accuracy on HellaSwag and > **33%** on MMLU using only **1B** tokens, without any special tricks, just by repeating standard pre-training data. Note that more repetitions could further improve its performance, as **no signs of diminishing returns** were observed.
- DLMs are super-dense models that consume more FLOPs than dense AR models. Training DLMs to fully leverage the data typically demands at least **two orders of magnitude** more FLOPs. During inference, generating sequences ranging from 16 to 4096 tokens incurs a **16× to 4700×** increase in FLOPs compared to AR baselines. In addition, the more expressive bidirectional attention enabled by the diffusion objective allows **bidirectional modeling of the language data**, which is not fully causal, to fully squeeze its value.
- Our concurrent work, “Diffusion Beats Autoregressive in Data-Constrained Settings”, contains critical methodological issues potentially leading to problematic conclusions, including **problematic diffusion loss formulation, invalid metrics for comparison, unfair settings for AR models, and problematic scaling law formulation.** All of which might lead to questionable results and conclusions.

<br>

# The Crossover
<p align="center" width="100%">
<img src="https://raw.githubusercontent.com/JinjieNi/dlms-are-super-data-learners/main/resources/imgs/1.jpg"  width="80%" height="100%">
</p>

*Figure A of the blog: The performance comparison of autoregressive (AR) and masked diffusion models (Diffusion) when repeating on a limited portion of data. All models are trained on 96B total tokens (including repetition), varying the unique tokens from 0.5B to 96B. Diffusion models exploit the data better through more repetition on limited unique data. More unique tokens requires more repetition to see the crossover, where the high unique token runs postpone the crossover beyond our 96B token observation scope.*

<br>

# Citation
```
@misc{ni2025difflm,
title={Diffusion Language Models are Super Data Learners},
author={Jinjie Ni and the team},
year={2025},
howpublished={\url{https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac}},
note={Notion Blog},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---