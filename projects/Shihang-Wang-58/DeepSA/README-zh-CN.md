[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA：基于深度学习的化合物合成可及性预测工具

随着人工智能技术的不断发展，越来越多的深度生成模型被应用于分子的生成。然而，大多数由生成模型产生的新分子在合成可及性方面通常面临巨大挑战。

DeepSA旨在预测化合物的合成可及性，并在区分难以合成的分子方面具有更高的早期富集率。这有助于用户选择合成成本较低的分子，从而缩短药物发现和开发的时间。您可以在 https://bailab.siais.shanghaitech.edu.cn/deepsa 上使用 DeepSA<br/>

## 环境要求
依赖包可通过以下命令安装：
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# GPU 版本
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### 新闻 🔔 

* 2024-12，[AutoGluon 自 2024 年 10 月起停止支持 Python 3.8 版本](https://github.com/autogluon/autogluon/pull/4512)。因此，我们已将 DeepSA 升级至 Python 3.12，并更新了训练和推理脚本以适配最新版本的 AutoGluon，感谢大家对 DeepSA 的关注！

* 2023-7，DeepSA_v1.0 已发布，欢迎在 issue 区反馈意见！

## 数据集
扩展训练集和测试集可通过以下链接便捷下载：https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing

## 研究者使用指南
如果您希望训练自己的模型，可在命令行中运行：

运行：
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
如果您想使用我们提供的模型，

运行：
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## 在线服务器

我们在专用服务器上部署了一个预训练模型，所有人均可通过 https://bailab.siais.shanghaitech.edu.cn/deepsa 免费访问，便于生物医药领域的研究者在科研中使用 DeepSA。

用户可上传自己的 SMILES 或 csv 文件至服务器，随后即可快速获得预测结果。

## <span id="citelink">引用</span>
如果您在研究中觉得本仓库有帮助，请引用我们的论文：

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## 联系方式
如果您有任何问题，请随时联系王士航（邮箱：wangshh12022@shanghaitech.edu.cn）或王琳（邮箱：wanglin3@shanghaitech.edu.cn）。

欢迎提交 Pull Request！

## 致谢
感谢上海科技大学高性能计算平台的支持。<br/>
感谢大家对本项目的关注。

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---