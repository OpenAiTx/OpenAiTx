<div align="center">
<h2>一步擴散：細節豐富且時間一致的影片超解析度</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>香港理工大學，<sup>2</sup>OPPO 研究院
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Visual Results">

</p>
## ⏰ 更新

- **2025.07.08**：推理程式碼與預訓練權重已釋出。
- **2025.06.24**：專案頁面已上線，包括簡短的 2 分鐘解說影片、更多視覺化結果及相關研究。
- **2025.06.17**：程式庫已釋出。

:star: 如果 DLoRAL 對您的影片或專案有所幫助，請幫忙給本程式庫一顆星。感謝！ :hugs:

😊 您也可以參考我們的相關研究：

1. **OSEDiff (NIPS2024)** [論文](https://arxiv.org/abs/2406.08177) | [程式碼](https://github.com/cswry/OSEDiff/)  

   實時影像超解析（SR）演算法，已應用於 OPPO Find X8 系列。

2. **PiSA-SR (CVPR2025)** [論文](https://arxiv.org/pdf/2412.03017) | [程式碼](https://github.com/csslc/PiSA-SR) 

   首創於影像超解析中探索雙重 LoRA（Dual-LoRA）範式。

3. **Awesome Diffusion Models for Video Super-Resolution** [程式庫](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   一份針對使用擴散模型進行影像超解析（VSR）的資源精選列表。
## 👀 TODO
- [x] 發布推理程式碼。
- [ ] 提供 Colab 和 Huggingface UI 以方便測試（即將推出！）。
- [ ] 發布訓練程式碼。
- [ ] 發布訓練資料。


## 🌟 概覽框架

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**訓練**：動態雙階段訓練方案在優化時間一致性（穩定階段）與細緻高頻空間細節（增強階段）之間交替，並通過平滑損失插值以確保穩定性。

**推理**：在推理過程中，C-LoRA 與 D-LoRA 共同合併進凍結的 diffusion UNet，實現對低品質輸入的一步增強轉換為高品質輸出。
## 🔧 依賴項與安裝

1. 複製倉庫
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. 安裝依賴套件
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. 下載模型  
#### 依賴模型
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> 放入 **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> 放入 **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> 放入 **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> 放入 **/path/to/DLoRAL/preset/models/DAPE.pth**
* [預訓練權重](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> 放入 **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

每個路徑可依自身需求進行修改，並應於命令列及程式碼中做相應變更。
## 🖼️ 快速推論
用於真實世界影片超解析度：

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```
### 引用
如果我們的程式碼對您的研究或工作有所幫助，請考慮引用我們的論文。
以下是 BibTeX 參考文獻：

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---