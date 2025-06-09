# StyTr^2 : 基於 Transformer 的影像風格轉換（CVPR2022）
*作者: [Yingying Deng](https://diyiiyiii.github.io/)、Fan Tang、Xingjia Pan、Weiming Dong、Chongyang Ma、Changsheng Xu*

本論文旨在基於 transformer 模型實現無偏見的影像風格轉換。與現有最先進方法相比，我們能夠提升風格化效果。  
本程式庫為 [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576) 的官方實現。

## 結果展示
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
與部分最先進的演算法相比，我們的方法具有強大的避免內容洩漏能力，並且具有更好的特徵表達能力。  <br>

## 架構
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p>
StyTr^2 框架的整體流程。我們將內容與風格圖片切分為多個 patch，並使用線性投影獲取影像序列。然後，將加上 CAPE 的內容序列餵入內容 transformer 編碼器，而風格序列則餵入風格 transformer 編碼器。經過兩個 transformer 編碼器後，採用多層 transformer 解碼器根據風格序列對內容序列進行風格化。最後，使用漸進式上採樣解碼器獲得高解析度的風格化影像。

## 實驗
### 環境需求
* python 3.6
* pytorch 1.4.0
* PIL、numpy、scipy
* tqdm  <br>

### 測試
預訓練模型: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing)、 [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing)、[decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing)、[Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br>
請下載並將它們放置在資料夾 ./experiments/  <br>
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### 訓練
風格資料集為從 [WIKIART](https://www.wikiart.org/) 收集的 WikiArt  <br>
內容資料集為 COCO2014  <br>
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### 參考文獻
如果您認為本研究對您的研究有幫助，請使用以下 BibTeX 條目引用我們的論文~感謝 ^ . ^。論文連結 [pdf](https://arxiv.org/abs/2105.14576)<br>
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---