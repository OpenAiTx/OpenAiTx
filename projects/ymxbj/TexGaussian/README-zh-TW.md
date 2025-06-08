<h1 align="center">TexGaussian: 基於八叉樹的3D高斯分佈生成高品質PBR材質</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

基於物理的渲染（PBR）材質在現代圖形學中扮演著至關重要的角色，使得在各種環境貼圖下能夠實現照片級真實感渲染。開發一套能自動為3D網格生成高品質PBR材質（而非RGB紋理）的高效且有效的演算法，可大幅簡化3D內容創作流程。現有多數方法利用預訓練的2D擴散模型進行多視角影像合成，這經常導致生成紋理與輸入3D網格之間出現嚴重的不一致。本文提出TexGaussian，一種新穎的基於八分體對齊3D高斯分佈的快速PBR材質生成方法。具體來說，我們將每個3D高斯分佈放置於由輸入3D網格構建的八叉樹最細分葉節點上，渲染多視角影像，不僅包括反照率貼圖，也包含粗糙度與金屬度。此外，我們模型採用回歸方式訓練，而非擴散去噪，可在單次前向傳播過程中為3D網格生成PBR材質。我們在公開基準上的大量實驗顯示，該方法在無條件與文本條件兩種情境下，均能合成更具視覺吸引力的PBR材質，且生成速度快於以往方法，並展現出更佳的幾何一致性。

## 📦 安裝

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# 經過修改的高斯分佈渲染（+ 深度、alpha渲染）
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# 其他依賴
pip3 install -r requirements.txt
```

## 🤖 預訓練模型

我們提供以下預訓練模型：

| 模型 | 說明 | 參數量 | 下載連結 |
| --- | --- | --- | --- |
| TexGaussian-bench | 在ShapeNet bench上訓練的無條件RGB紋理模型 | 70M | [下載](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | 在ShapeNet car上訓練的無條件RGB紋理模型 | 70M | [下載](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | 在ShapeNet chair上訓練的無條件RGB紋理模型 | 70M | [下載](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | 在ShapeNet table上訓練的無條件RGB紋理模型 | 70M | [下載](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | 在Objaverse上訓練的文本條件PBR材質模型 | 295M | [下載](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 推論

### PBR 材質
如需文本條件PBR材質生成，請執行
```bash
bash inference_for_PBR_material.sh
```
完成紋理與材質烘焙後，您將獲得兩張貼圖，一張為反照率貼圖，另一張為PBR材質貼圖。具體來說，PBR材質貼圖包含三個通道，其中綠色通道表示粗糙度值，藍色通道表示金屬度值。建議使用[bpy編寫的這個渲染腳本](https://github.com/ymxbj/BlenderToolboxPBR)進行生成紋理與材質貼圖的PBR渲染。

此外，我們建議大家仿照Cap3D資料集的文本風格自行創建提示詞，以獲得更佳的生成效果。Cap3D資料集可於[此處下載](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true)。

### RGB 紋理
如需無條件RGB紋理生成（僅支援四類：bench、car、chair、table），請執行
```bash
bash inference_for_RGB_texture.sh
```
紋理烘焙後，您將獲得一張反照率貼圖。

## 🏋️‍♂️ 訓練
針對Objaverse：
```bash
bash train_for_objaverse.sh
```

針對ShapeNet：
```bash
bash train_for_shapenet.sh
```

## 🚧 待辦事項
- [x] 發布訓練與推論程式碼
- [x] 發布ShapeNet數據集上的無條件僅反照率預訓練模型
- [x] 發布Objaverse數據集上的文本條件PBR預訓練模型
- [ ] 發布數據集與數據集工具包

## 📚致謝

本項目基於諸多傑出的研究工作與開源專案，感謝所有作者的無私分享！

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) 與 [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 引用

如果您覺得本工作對您有所幫助，請考慮引用我們的論文：

1. arXiv 版本
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR 版本
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---