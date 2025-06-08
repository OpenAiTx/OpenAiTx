<h1 align="center">TexGaussian: Octreeベースの3Dガウシアンスプラッティングによる高品質PBRマテリアル生成</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

物理ベースレンダリング（PBR）マテリアルは、現代のグラフィックスにおいて重要な役割を果たしており、多様な環境マップにわたるフォトリアリスティックなレンダリングを可能にします。RGBテクスチャではなく3Dメッシュ用の高品質PBRマテリアルを自動生成できる効果的かつ効率的なアルゴリズムを開発することは、3Dコンテンツ制作を大幅に効率化します。既存のほとんどの手法は事前学習済み2D拡散モデルを用いてマルチビュー画像合成を行いますが、これにより生成されたテクスチャと入力3Dメッシュとの間に深刻な不整合が生じることが多いです。本論文では、八分木（Octree）に整列した3Dガウシアンスプラッティングを用いて高速なPBRマテリアル生成を実現する新しい手法「TexGaussian」を提案します。具体的には、入力3Dメッシュから構築されたOctreeの最も細かいリーフノードごとに3Dガウシアンを配置し、アルベドマップだけでなく、ラフネスやメタリックのマルチビュー画像もレンダリングします。さらに、本モデルは拡散ノイズ除去ではなく回帰的に学習されており、単一のフィードフォワード処理で3DメッシュのPBRマテリアルを生成できます。公開ベンチマークでの広範な実験により、本手法は視覚的により優れたPBRマテリアルを合成し、従来手法よりも高速に動作することが示されました。これにより、与えられたジオメトリとの整合性も向上しています。

## 📦 インストール

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# 修正版ガウシアンスプラッティング（+ depth, alpha rendering対応）
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# その他依存パッケージ
pip3 install -r requirements.txt
```

## 🤖 学習済みモデル

以下の学習済みモデルを提供しています：

| モデル | 説明 | パラメータ数 | ダウンロード |
| --- | --- | --- | --- |
| TexGaussian-bench | ShapeNetのbenchで学習された無条件RGBテクスチャモデル | 70M | [ダウンロード](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | ShapeNetのcarで学習された無条件RGBテクスチャモデル | 70M | [ダウンロード](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | ShapeNetのchairで学習された無条件RGBテクスチャモデル | 70M | [ダウンロード](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | ShapeNetのtableで学習された無条件RGBテクスチャモデル | 70M | [ダウンロード](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Objaverseで学習されたテキスト条件付きPBRマテリアルモデル | 295M | [ダウンロード](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 推論

### PBRマテリアル
テキスト条件付きPBRマテリアル生成には、以下を実行してください。
```bash
bash inference_for_PBR_material.sh
```
テクスチャとマテリアルのベイク後、2つのマップ（アルベドマップとPBRマテリアルマップ）が得られます。特に、PBRマテリアルマップは3チャンネルで構成され、緑チャンネルがラフネス値、青チャンネルがメタリック値を示します。生成されたテクスチャおよびマテリアルマップのPBRレンダリングには、bpyで記述された[このレンダリングスクリプト](https://github.com/ymxbj/BlenderToolboxPBR)の使用を推奨します。

さらに、Cap3Dデータセットのテキストスタイルを模倣し、自分自身のプロンプトを作成することで、より良い生成結果が得られます。Cap3Dデータセットは[こちら](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true)からダウンロード可能です。

### RGBテクスチャ
無条件RGBテクスチャ生成（bench, car, chair, tableの4カテゴリのみ対応）の場合は、以下を実行してください。
```bash
bash inference_for_RGB_texture.sh
```
テクスチャのベイク後、1つのアルベドマップが得られます。

## 🏋️‍♂️ 学習
Objaverse用：
```bash
bash train_for_objaverse.sh
```

ShapeNet用：
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] 学習・推論コードの公開
- [x] ShapeNetデータセット上の無条件アルベドのみ事前学習済みモデルの公開
- [x] Objaverseデータセット上のテキスト条件付きPBR事前学習済みモデルの公開
- [ ] データセットおよびデータセットツールキットの公開

## 📚 謝辞

本研究は多くの素晴らしい研究およびオープンソースプロジェクトに基づいて構築されています。著者の皆様のご貢献に感謝いたします。

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) および [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 引用

本研究が役立った場合は、ぜひ論文を引用してください：

1. arXivバージョン
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPRバージョン
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