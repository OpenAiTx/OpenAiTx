[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: 一個基於深度學習的化合物合成可及性預測工具

隨著人工智慧技術的不斷發展，越來越多的深度生成模型被應用於分子的生成。然而，大多數由生成模型產生的新分子在合成可及性方面經常面臨巨大挑戰。

DeepSA 旨在預測化合物的合成可及性，並在區分難以合成的分子方面具有更高的早期富集率。這幫助使用者選擇合成成本較低的分子，從而縮短藥物發現和開發的時間。你可以在 https://bailab.siais.shanghaitech.edu.cn/deepsa 上使用 DeepSA 網頁伺服器。<br/>

## 需求
可使用以下指令安裝相依套件：
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# GPU 版本
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### 新聞 🔔 

* 2024-12，因為 [AutoGluon 自 2024 年 10 月起停止支援 Python 3.8 版本](https://github.com/autogluon/autogluon/pull/4512)。因此，我們已將 DeepSA 升級至 Python 3.12，並更新了訓練及推論腳本以適配最新版 AutoGluon，感謝您對 DeepSA 的關注！

* 2023-7，DeepSA_v1.0 已經發佈，歡迎在 issue 反饋您的意見！

## 數據集
擴展訓練與測試數據集可於 https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing 下載。

## 研究人員使用說明
如果你想訓練自己的模型，可於命令列運行：

執行：
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
如果你想使用我們提出的模型，

執行：
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## 在線伺服器

我們已在專用伺服器部署了一個預訓練模型，公開於 https://bailab.siais.shanghaitech.edu.cn/deepsa，方便生物醫學研究人員在其研究工作中利用 DeepSA。

使用者可將 SMILES 或 csv 檔上傳至伺服器，然後即可快速獲得預測結果。

## <span id="citelink">引用</span>
如果你在研究中覺得此資源有幫助，請考慮引用我們的論文： 

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## 聯絡方式
如有任何問題，歡迎聯絡 Shihang Wang（信箱：wangshh12022@shanghaitech.edu.cn）或 Lin Wang（信箱：wanglin3@shanghaitech.edu.cn）。

歡迎提出 Pull requests！

## 致謝
感謝上海科技大學 HPC 平台的支持。<br/>
感謝大家對此工作的關注。

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---