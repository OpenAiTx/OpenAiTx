# Stable Diffusion 網頁介面
一個基於 Gradio 函式庫實作的 Stable Diffusion 網頁介面。

![](screenshot.png)

## 功能
[詳細功能展示與圖片](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features)：
- 原生 txt2img 與 img2img 模式
- 一鍵安裝與執行腳本（但仍需自行安裝 Python 與 git）
- 外延繪圖（Outpainting）
- 局部修復（Inpainting）
- 彩色草圖（Color Sketch）
- 提示詞矩陣（Prompt Matrix）
- Stable Diffusion 放大（Upscale）
- 注意力調整，可指定模型需特別注意的文字部分
    - a man in a `((tuxedo))` - 會更關注 tuxedo
    - a man in a `(tuxedo:1.21)` - 替代語法
    - 選取文字後按 `Ctrl+Up` 或 `Ctrl+Down`（MacOS 為 `Command+Up` 或 `Command+Down`）可自動調整選中文字的注意力（由匿名用戶貢獻）
- 迴圈處理（Loopback），可多次執行 img2img 處理
- X/Y/Z 繪圖，可繪製參數不同的三維圖像
- 文字反轉（Textual Inversion）
    - 可擁有任意數量的嵌入詞，並可自由命名
    - 支援多組不同向量數的嵌入詞
    - 支援半精度浮點數
    - 嵌入詞可在 8GB 顯存訓練（也有 6GB 可行的回報）
- 進階功能（Extras 標籤頁）：
    - GFPGAN，神經網絡臉部修復工具
    - CodeFormer，替代 GFPGAN 的臉部修復工具
    - RealESRGAN，神經網絡放大工具
    - ESRGAN，支援多款第三方模型的神經網絡放大工具
    - SwinIR 和 Swin2SR（[詳見此處](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)），神經網絡放大工具
    - LDSR，潛變分辨率超解析放大
- 調整尺寸比例選項
- 採樣方式選擇
    - 可調整採樣器 eta 值（噪聲倍增器）
    - 更多進階噪聲設定選項
- 可隨時中斷處理
- 支援 4GB 顯卡（也有 2GB 可行的回報）
- 批次正確種子控制
- 即時提示詞長度驗證
- 生成參數
     - 產生圖像時所用的參數會一併儲存
     - PNG 以 chunk 儲存，JPEG 以 EXIF 儲存
     - 可將圖片拖曳至 PNG info 標籤頁恢復生成參數並自動複製至 UI
     - 可於設定中停用
     - 支援將圖片/文字參數拖放至提示框
- 讀取生成參數按鈕，將提示框參數載入至 UI
- 設定頁面
- 可從 UI 執行任意 Python 代碼（需以 `--allow-code` 啟用）
- 大多數 UI 元素提供滑鼠提示
- 可透過文字設定檔變更 UI 元素的預設/最小/最大/步進值
- 支援平鋪（Tiling），勾選後可產生可作為材質的平鋪圖像
- 進度條與即時圖像生成預覽
    - 可額外啟用輕量神經網絡進行預覽，幾乎無需 VRAM 或算力
- 負面提示詞，額外輸入欄可列出你不希望出現在生成圖像中的內容
- 樣式（Styles），可儲存部分提示詞並於下拉選單中快速套用
- 變異（Variations），產生略有差異的相同圖像
- 種子縮放（Seed resizing），生成相同圖像但解析度略有不同
- CLIP 詢問器，一鍵從圖片預測提示詞
- 提示詞編輯，可於生成過程中變更提示詞，例如從西瓜中途切換為動漫少女
- 批次處理，可對多檔案以 img2img 處理
- Img2img 替代法，反向 Euler 交叉注意力控制
- 高解析修復，一鍵產生高解析圖像且減少常見失真
- 支援動態載入模型檢查點
- 檢查點合併器，可將最多三個檢查點合併為一
- [自訂腳本](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts)，社群多種擴充功能
- [可組合擴散](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/)，可同時使用多組提示詞
     - 以大寫 `AND` 分隔多組提示詞
     - 支援提示詞權重：`a cat :1.2 AND a dog AND a penguin :2.2`
- 提示詞無 token 數限制（原生 Stable Diffusion 僅支援最多 75 個 token）
- DeepDanbooru 整合，為動漫提示詞產生 danbooru 標籤
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers)，特定顯卡大幅提升速度（啟用時於命令列參數加上 `--xformers`）
- 透過擴充：[歷史紀錄頁籤](https://github.com/yfszzx/stable-diffusion-webui-images-browser)：於 UI 內方便瀏覽、刪除、管理圖像
- 永久生成選項
- 訓練標籤頁
     - 超網路（hypernetworks）與嵌入詞選項
     - 預處理圖片：裁切、鏡像、BLIP 或 deepdanbooru（動漫）自動標註
- Clip skip
- 超網路（Hypernetworks）
- Lora（與超網路相似但更便於使用）
- 可於獨立 UI 預覽選擇要加入提示詞的嵌入詞、超網路或 Lora
- 可於設定頁選擇載入不同 VAE
- 進度條顯示預估完成時間
- API
- 支援專用 [inpainting 模型](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion)（RunwayML 提供）
- 透過擴充：[Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients)，以指定美學生成圖像（[原始實作](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients)）
- 支援 [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - 詳細說明見 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)
- 支援 [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - 詳細說明見 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)
- 現已不含任何不良字元！
- 支援 safetensors 格式載入檢查點
- 放寬解析度限制：生成圖像維度僅需為 8 的倍數（原為 64）
- 現已附帶授權條款！
- 支援從設定頁調整 UI 元素順序
- 支援 [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## 安裝與執行
請確保已符合所需[相依套件](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies)，並依照下列說明安裝：
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)（建議）
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) 顯示卡
- [Intel CPU、Intel GPU（內建與獨立）](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon)（外部 wiki 頁面）
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs)（外部 wiki 頁面）

或可使用線上服務（如 Google Colab）：

- [線上服務列表](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### 於 Windows 10/11 使用 NVidia 顯卡安裝（發行包方式）
1. 從 [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) 下載 `sd.webui.zip` 並解壓縮。
2. 執行 `update.bat`。
3. 執行 `run.bat`。
> 詳細說明見 [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Windows 自動安裝方式
1. 安裝 [Python 3.10.6](https://www.python.org/downloads/release/python-3106/)（新版 Python 不支援 torch），並勾選「Add Python to PATH」。
2. 安裝 [git](https://git-scm.com/download/win)。
3. 下載 stable-diffusion-webui 原始碼，例如執行 `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`。
4. 以一般使用者（非管理員）權限從檔案總管執行 `webui-user.bat`。

### Linux 自動安裝方式
1. 安裝相依套件：
```bash
# Debian 系：
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat 系：
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE 系：
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch 系：
sudo pacman -S wget git python3
```
若您的系統較新，需安裝 python3.11 或 python3.10：
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # 請勿與 python3.11 套件混淆

# 僅適用於 3.11
# 於啟動腳本中設定環境變數
export python_cmd="python3.11"
# 或於 webui-user.sh
python_cmd="python3.11"
```
2. 進入您想安裝 webui 的目錄並執行下列指令：
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
或直接將原始碼 clone 到任意目錄：
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. 執行 `webui.sh`。
4. 於 `webui-user.sh` 查看可用選項。
### Apple Silicon 安裝說明

請參考[此處說明](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)。

## 貢獻
如欲貢獻代碼，請參見：[如何貢獻](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## 文件

文件已自本 README 移至專案 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki)。

為方便 Google 及其他搜尋引擎爬蟲收錄 wiki，請見（非為人類閱讀）[可爬取 wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki)。

## 致謝
所有引用代碼的授權條款均可於 `設定 -> 授權` 頁面與 `html/licenses.html` 檔案中找到。

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel 實作
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- 優化想法 - https://github.com/basujindal/stable-diffusion
- Cross Attention 層優化 - Doggettx - https://github.com/Doggettx/stable-diffusion，提供 prompt editing 原始想法
- Cross Attention 層優化 - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI（原始於 http://github.com/lstein/stable-diffusion）
- 次二次 Cross Attention 層優化 - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion（我們未使用其代碼，但採用了其想法）
- SD upscale 構想 - https://github.com/jquesnelle/txt2imghd
- Outpainting mk2 噪聲產生 - https://github.com/parlance-zz/g-diffuser-bot
- CLIP 詢問器構想與部分代碼 - https://github.com/pharmapsychotic/clip-interrogator
- Composable Diffusion 構想 - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - 動漫 diffusers 詢問器 https://github.com/KichangKim/DeepDanbooru
- 以 float32 精度從 float16 UNet 採樣 - marunine 提供想法，Birch-san 實作 Diffusers 範例（https://github.com/Birch-san/diffusers-play/tree/92feee6）
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- 安全性建議 - RyotaK
- UniPC 採樣器 - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- 重啟採樣 - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- 初始 Gradio 腳本 - 由匿名用戶於 4chan 發布，感謝該匿名用戶。
- （你）

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---