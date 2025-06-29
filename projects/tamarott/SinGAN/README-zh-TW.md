# SinGAN

[專案](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [補充資料](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [演講 (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### 論文官方 pytorch 實現："SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 最佳論文獎 (Marr prize)

## 從*單一*影像隨機取樣
使用 SinGAN，您可以從單一自然影像訓練出生成模型，然後從該影像產生隨機樣本，例如：

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)

## SinGAN 的應用
SinGAN 也可用於多種影像操作任務，例如：
![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
這是透過將影像注入已訓練好的模型來實現。詳情請參考我們[論文](https://arxiv.org/pdf/1905.01164.pdf)第 4 節。

### 引用
如果您在研究中使用本程式碼，請引用我們的論文：

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## 程式碼

### 安裝相依套件

```
python -m pip install -r requirements.txt
```

本程式碼經 Python 3.6、torch 1.4 測試。

請注意：目前僅支援 torch 1.4 或更早版本，這是由於優化方案所致。

如需支援新版 torch，可嘗試此倉庫：https://github.com/kligvasser/SinGAN（結果不一定與官方實現完全一致）。

### 訓練
若要在自有影像上訓練 SinGAN 模型，請將欲訓練影像置於 Input/Images 資料夾下，並執行

```
python main_train.py --input_name <input_file_name>
```

這也會使用訓練完成的模型自最粗尺度 (n=0) 開始產生隨機樣本。

若欲於 CPU 設備執行，請在呼叫 `main_train.py` 時指定 `--not_cuda`

### 隨機取樣
若要從任意起始生成尺度產生隨機樣本，請先依上述步驟於欲用影像上訓練 SinGAN 模型，然後執行

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

注意：若要使用完整模型，請將 generation start scale 設為 0；若要自第二尺度起始，請設為 1，依此類推。

### 任意尺寸的隨機取樣
若要產生任意尺寸的隨機樣本，請先依上述步驟於欲用影像上訓練 SinGAN 模型，然後執行

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

### 從單一影像生成動畫

若要從單一影像產生短動畫，請執行

```
python animation.py --input_name <input_file_name> 
```

這將自動以噪聲填補模式啟動新訓練階段。

### 融合

若要將貼上的物件與影像融合（請參見[論文](https://arxiv.org/pdf/1905.01164.pdf)圖 13 範例），請先在欲用背景影像上訓練 SinGAN 模型（如前述），然後將經簡單貼上的參考影像及其二值遮罩存至 "Input/Harmonization" 目錄下（可參考範例影像）。執行指令

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

請注意，注入的尺度不同將產生不同的融合效果。最粗的注入尺度為 1。

### 編輯

若要編輯影像（請參見[論文](https://arxiv.org/pdf/1905.01164.pdf)圖 12 範例），請先於欲用非編輯影像上訓練 SinGAN 模型（如前述），然後將簡單編輯結果存為參考影像於 "Input/Editing" 目錄下，並附上對應二值圖（可參考範例影像）。執行指令

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
```
遮罩與未遮罩的輸出都會被儲存。
同樣地，不同的注入層級會產生不同的編輯效果。最粗的注入層級為 1。

### 由繪畫轉換為影像

要將繪畫轉換為寫實影像（參見[我們的論文](https://arxiv.org/pdf/1905.01164.pdf)中的圖 11），請先在目標影像上訓練 SinGAN 模型（如上所述），然後將你的繪畫儲存在 "Input/Paint" 資料夾下，並執行以下指令：

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>
```

同樣地，不同的注入層級會產生不同的編輯效果。最粗的注入層級為 1。

進階選項：將 quantization_flag 設為 True，只對模型的注入層級進行再訓練，以獲得前一層上採樣生成影像的色彩量化版本。對某些影像而言，這可能會導致更寫實的結果。

### 超解析度
若要對影像進行超解析度，請執行：
```
python SR.py --input_name <LR_image_file_name>
```
這將自動訓練一個對應 4 倍上採樣倍率的 SinGAN 模型（若尚未存在）。
如需不同的超解析度倍率，請在呼叫函式時使用參數 `--sr_factor` 指定。
SinGAN 在 BSD100 資料集上的結果可於 'Downloads' 資料夾下載。

## 其他資料與功能

### 單張影像 Fréchet Inception Distance（SIFID 分數）
要計算真實影像與其對應生成樣本之間的 SIFID，請執行：
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
請確保每個生成影像的檔名與其對應的真實影像檔名完全相同。影像應以 `.jpg` 格式儲存。

### 超解析度結果
SinGAN 在 BSD100 資料集上的超解析度結果可於 'Downloads' 資料夾下載。

### 使用者研究
用於使用者研究的資料可於 Downloads 資料夾找到。

real 資料夾：50 張真實影像，隨機選自 [places database](http://places.csail.mit.edu/)

fake_high_variance 資料夾：對每張真實影像自 n=N 起的隨機樣本

fake_mid_variance 資料夾：對每張真實影像自 n=N-1 起的隨機樣本

更多細節請參見我們[論文](https://arxiv.org/pdf/1905.01164.pdf)的第 3.1 節。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---