<div align="center">
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/./assets/ObjectClear_logo.png" alt="ObjectClear Logo" style="height: 52px;">
    <h2>透過物件效果注意力實現完整物件移除</h2>
</div>

<div>
    <a href="https://zjx0101.github.io/" target='_blank'>趙吉鑫</a>&emsp;
    <a href='https://shangchenzhou.com/' target='_blank'>周尚晨<sup>†</sup></a>&emsp;
    <a href='https://wzhouxiff.github.io' target='_blank'>王周霞</a>&emsp;
    <a href='https://pq-yang.github.io/' target='_blank'>楊培青</a>&emsp;
    <a href='https://www.mmlab-ntu.com/person/ccloy/' target='_blank'>羅展成</a>
</div>
<div>
    南洋理工大學 S-Lab<br>
   <p><sup>†</sup>通訊作者</p>
</div>


<div>
    <h4 align="center">
        <a href="https://zjx0101.github.io/projects/ObjectClear/" target='_blank'>
        <img src="https://img.shields.io/badge/🐳-專案頁面-blue">
        </a>
        <a href="https://arxiv.org/abs/2505.22636" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2505.22636-b31b1b.svg">
        </a>
        <a href="https://huggingface.co/spaces/jixin0101/ObjectClear" target='_blank'>
        <img src="https://img.shields.io/badge/示範-%F0%9F%A4%97%20Hugging%20Face-blue">
        </a>
        <img src="https://api.infinitescript.com/badgen/count?name=sczhou/ObjectClear&ltext=訪客&color=3977dd">
    </h4>
</div>

<strong>ObjectClear 是一個物件移除模型，能夠利用物件效果注意力同時消除目標物件及其相關效果，同時保持背景一致性。</strong>

<div style="width: 100%; text-align: center; margin:auto;">
    <img style="width:100%" src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/teaser.jpg">
</div>

欲查看更多視覺成果，請參考我們的 <a href="https://zjx0101.github.io/projects/ObjectClear/" target="_blank">專案頁面</a>

---
</div>


## ⭐ 更新
- [2025.07] 發布推理程式碼與 Gradio 示範。
- [2025.05] 本倉庫建立。


## 🎃 概述
![overall_structure](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/ObjectClear_pipeline.png)


## 📷 OBER 資料集
![OBER_dataset_pipeline](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/OBER_pipeline.png)

OBER（物件效果移除）是一個混合資料集，設計用於支持具效果物件移除的研究，結合了實拍與模擬資料。

![OBER_dataset_samples](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/dataset_samples.png)


## ⚙️ 安裝
1. 複製倉庫
    ```bash
    git clone https://github.com/zjx0101/ObjectClear.git
    cd ObjectClear
    ```
2. 建立 Conda 環境並安裝依賴項目

    ```bash
    # create new conda env
    conda create -n objectclear python=3.10 -y
    conda activate objectclear

    # install python dependencies
    pip3 install -r requirements.txt
    # [optional] install python dependencies for gradio demo
    pip3 install -r hugging_face/requirements.txt
    ```
## ⚡ 推論

### 快速測試
我們在 [`inputs`](./inputs) 資料夾中提供了一些範例。**每次執行時，我們都會以一張影像及其分割遮罩作為輸入。** <u>分割遮罩可以從互動式分割模型取得，例如 [SAM2 demo](https://huggingface.co/spaces/fffiloni/SAM2-Image-Predictor)</u>。例如，目錄結構可以安排如下：


```
inputs
   ├─ imgs
   │   ├─ test-sample1.jpg      # .jpg, .png, .jpeg supported
   │   ├─ test-sample2.jpg
   └─ masks
       ├─ test-sample1.png
       ├─ test-sample2.png
```
執行以下指令以嘗試：

```shell
## Single image inference
python inference_objectclear.py -i inputs/imgs/test-sample1.jpg -m inputs/masks/test-sample1.png --use_fp16

## Batch inference on image folder
python inference_objectclear.py -i inputs/imgs -m inputs/masks --use_fp16
```
## 🪄 互動示範
為了免去分割遮罩的準備工作，我們在 [hugging face](https://huggingface.co/spaces/jixin0101/ObjectClear) 上準備了一個 gradio 示範，也可以 [本地啟動](./hugging_face)。只需拖放圖片，點幾下指派目標遮罩，即可獲得物件移除結果！


```shell
cd hugging_face

# install python dependencies
pip3 install -r requirements.txt

# launch the demo
python app.py
```
## 📑 引用
如果您發現我們的資源庫對您的研究有幫助，請考慮引用我們的論文：



```bibtex
@InProceedings{zhao2025ObjectClear,
    title     = {{ObjectClear}: Complete Object Removal via Object-Effect Attention},
    author    = {Zhao, Jixin and Zhou, Shangchen and Wang, Zhouxia and Yang, Peiqing and Loy, Chen Change},
    booktitle = {arXiv preprint arXiv:2505.22636},
    year      = {2025}
    }
```
## 📧 聯絡方式
如果您有任何問題，歡迎隨時聯繫我們，郵箱地址為 `jixinzhao0101@gmail.com`。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---