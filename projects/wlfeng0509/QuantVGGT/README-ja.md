# Quantized Visual Geometry Grounded Transformer

[arXiv](https://arxiv.org/abs/2509.21302) | [BibTeX](#bibtex)

------

This project is the official implementation of our QuantVGGT: "Quantized Visual Geometry Grounded Transformer".

![teaser](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/teaser.png)

![overview](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/overview.png)

------

## Results

![result](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/result.png)

## Updates

- [October 10, 2025] Evaluation code for reproducing our camera pose estimation results on Co3D is now available.

## Quick Start

First, clone this repository to your local machine, and install the dependencies (torch, torchvision, numpy, Pillow, and huggingface_hub).

```
git clone git@github.com:wlfeng0509/QuantVGGT.git
cd QuantVGGT
pip install -r requirements.txt
```

次に、[VGGT](https://github.com/facebookresearch/vggt)で提供されている事前学習済みの重みをダウンロードし、[こちら](https://github.com/facebookresearch/vggt/tree/evaluation/evaluation)に従ってCo3Dデータセットを準備します。

次に、[huggingface](https://huggingface.co/wlfeng/QuantVGGT/tree/main)から事前学習済みのW4A4量子化パラメータをダウンロードし、ダウンロードしたフォルダを*evaluation\outputs\w4a4*ブランチの下に配置します。

提供されたスクリプトを推論に使用できます **（スクリプト内のデータパスを変更することを忘れないでください）** 。

```
cd evaluation
bash test.sh
```
また、量子化モデルを使用して、[こちら](https://github.com/facebookresearch/vggt/tree/evaluation#detailed-usage)のガイダンスに従って他の3D属性を予測することもできます。

## コメント

* 私たちのコードベースは主に[VGGT](https://github.com/facebookresearch/vggt)および[QuaRot](https://github.com/spcl/QuaRot)に基づいています。オープンソースに感謝します！

## BibTeX

*QuantVGGT*があなたの研究に役立った場合は、ぜひこの論文を引用してください。


```
@article{feng2025quantized,
  title={Quantized Visual Geometry Grounded Transformer},
  author={Feng, Weilun and Qin, Haotong and Wu, Mingqiang and Yang, Chuanguang and Li, Yuqi and Li, Xiangqi and An, Zhulin and Huang, Libo and Zhang, Yulun and Magno, Michele and others},
  journal={arXiv preprint arXiv:2509.21302},
  year={2025}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---