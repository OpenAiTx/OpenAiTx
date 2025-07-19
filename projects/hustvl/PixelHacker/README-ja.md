<div align="center">
    <img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/LOGO.png" width="280px"></img>
</div>
<div align="center">
    <img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Typing_re.gif" width="320px"></img>
</div>

<div align="center">
<h2>PixelHacker: 構造的および意味的整合性を備えた画像修復</h2>

**_Places2、CelebA-HQ、およびFFHQでのSOTA性能＆優れた構造的および意味的整合性_**

[Ziyang Xu](https://ziyangxu.top)<sup>1</sup>, [Kangsheng Duan](https://github.com/AnduinD)<sup>1</sup>, Xiaolei Shen<sup>2</sup>, Zhifeng Ding<sup>2</sup>, [Wenyu Liu](http://eic.hust.edu.cn/professor/liuwenyu)<sup>1</sup>, Xiaohu Ruan<sup>2</sup>,  
[Xiaoxin Chen](https://scholar.google.com/citations?hl=zh-CN&user=SI_oBwsAAAAJ)<sup>2</sup>, [Xinggang Wang](https://xwcv.github.io)<sup>1 :email:</sup>

(<sup>:email:</sup>) 対応著者.

<sup>1</sup> 华中科技大学. <sup>2</sup> VIVO AIラボ.  

[![arxiv](https://img.shields.io/badge/Paper-arXiv-orange)](https://arxiv.org/abs/2504.20438) [![license](https://img.shields.io/badge/License-Apache_2.0-blue)](LICENSE) [![Project](https://img.shields.io/badge/Project-https://hustvl.github.io/PixelHacker-purple)](https://hustvl.github.io/PixelHacker) [![Demo](https://img.shields.io/badge/Demo-Comming_Soon-b687f8)]()
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Pipeline.png"></img>

## 🌟ハイライト
* **潜在カテゴリガイダンス（LCG）**：シンプルでありながら効果的な修復パラダイムで、優れた構造的および意味的整合性を実現。より複雑なシナリオに挑戦するために修復研究を前進させましょう！
* **PixelHacker**：LCGで訓練された拡散ベースの修復モデルで、複数の自然シーン（Places2）および人間の顔（CelebA-HQ、FFHQ）ベンチマークでSOTA性能を凌駕！
* **包括的なSOTA性能**：
    * **Places2**（自然シーン）
        * 40-50％のマスク領域を含む1万枚のテストセット画像を512解像度で評価し、PixelHackerは**FID 8.59**および**LPIPS 0.2026**で最高性能を達成。
        * 大小のマスク設定で3.65万枚の検証セット画像を512解像度で評価し、PixelHackerは**FID（大: 2.05、小: 0.82）**と**U-IDS（大:36.07、小:42.21）**で最高性能を、**LPIPS（大:0.169、小:0.088）**で第2位の性能を達成。
        * 高度にランダム化されたマスク戦略を用いた検証セット画像を256および512解像度で評価し、PixelHackerは512解像度で**FID 5.75 と LPIPS 0.305**で最高性能を、256解像度で**FID 9.25 と LPIPS 0.367**で第2位の性能を達成。
    * **CelebA-HQ**（人間の顔シーン）
        * 512解像度で評価し、PixelHackerは**FID 4.75 と LPIPS 0.115**で最高性能を達成。
    * **FFHQ**（人間の顔シーン）
        * 256解像度で評価し、PixelHackerは**FID 6.35 と LPIPS 0.229**で最高性能を達成。

## 🔥アップデート

* **`2025年5月20日`**: 🔥 [コード](https://github.com/hustvl/PixelHacker)と[重み](https://huggingface.co/hustvl/PixelHacker/tree/main)を公開しました。重みには事前学習済みおよびすべてのファインチューニング済みバージョンが含まれ、それぞれパラメータは0.8Bのみです。ぜひ試してみてください！
* **`2025年5月1日`**: 🔥 自然シーンと人間の顔シーンに関する63以上のデモを含む[プロジェクトページ](https://hustvl.github.io/PixelHacker)を公開しました。お楽しみください！🤗
* **`2025年4月30日`**: 🔥 PixelHackerの[arXiv論文](https://arxiv.org/abs/2504.20438)を公開しました。コードとプロジェクトページは近日公開予定です。

## 🏕️自然シーンでの性能

<div align="center">
<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Demo1.gif" width="360px"></img>
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Cover.png"></img>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Natural-Scene.png"></img>

## 🤗人間の顔シーンでの性能
<div align="center">
<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Demo2.gif" width="360px"></img>
</div>

<img src="https://raw.githubusercontent.com/hustvl/PixelHacker/main/./assets/Human-Face.png"></img>

## 📦環境セットアップ
* torch 2.3.0
* transformers 4.40.0
* diffusers 0.30.2
* 詳細なPythonライブラリは'requirements.txt'を参照してください

```shell
conda create -n pixelhacker python=3.10
conda activate pixelhacker
# cd /xx/xx/PixelHacker
pip install -r requirements.txt
```
## 🗃️モデルチェックポイント
* [VAE](https://huggingface.co/hustvl/PixelHacker/tree/main/vae) のチェックポイントをダウンロードし、../PixelHacker/vae に入れてください。

* [事前学習版](https://huggingface.co/hustvl/PixelHacker/tree/main/pretrained)、[ファインチューニング版 (places2)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_places2)、[ファインチューニング版 (celeba-hq)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_celebahq)、[ファインチューニング版 (ffhq)](https://huggingface.co/hustvl/PixelHacker/tree/main/ft_ffhq) のチェックポイントをダウンロードし、../PixelHacker/weight に入れてください。

* 最後に、詳細なフォルダ構成は以下の通りです：

```shell
├── PixelHacker
│    ├── weight
│        ├── pretrained
│            ├── diffusion_pytorch_model.bin
│        ├── ft_places2
│            ├── diffusion_pytorch_model.bin
│        ├── ft_celebahq
│            ├── diffusion_pytorch_model.bin
│        ├── ft_ffhq
│            ├── diffusion_pytorch_model.bin
│    ├── vae
│        ├── config.json
│        ├── diffusion_pytorch_model.bin
│    ├── ...
```
## 🔮推論  
以下のコードを直接実行すると、例の画像とマスクのペアのインペインティング結果が得られ、結果は ../PixelHacker/outputs に生成されます。  
カスタムデータで推論したい場合は、画像とマスクを同じ名前でそれぞれ ../PixelHacker/imgs と ../PixelHacker/masks に配置し、同様に以下のコードを実行してください。
```shell
python infer_pixelhacker.py \
--config config/PixelHacker_sdvae_f8d4.yaml \
--weight weight/ft_places/diffusion_pytorch_model.bin
```


## 🎓Citation

```shell
@misc{xu2025pixelhacker,
      title={PixelHacker: Image Inpainting with Structural and Semantic Consistency}, 
      author={Ziyang Xu and Kangsheng Duan and Xiaolei Shen and Zhifeng Ding and Wenyu Liu and Xiaohu Ruan and Xiaoxin Chen and Xinggang Wang},
      year={2025},
      eprint={2504.20438},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.20438}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---