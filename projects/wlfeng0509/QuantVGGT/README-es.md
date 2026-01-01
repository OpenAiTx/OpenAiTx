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

Luego descargue los pesos preentrenados proporcionados por [VGGT](https://github.com/facebookresearch/vggt) y prepare el conjunto de datos Co3D siguiendo [esto](https://github.com/facebookresearch/vggt/tree/evaluation/evaluation).

Luego descargue los parámetros de cuantización W4A4 preentrenados de [huggingface](https://huggingface.co/wlfeng/QuantVGGT/tree/main) y coloque la carpeta descargada bajo la rama *evaluation\outputs\w4a4*.

Ahora podemos usar el script proporcionado para la inferencia **(recuerde cambiar la ruta de datos dentro del script)**.

```
cd evaluation
bash test.sh
```

También, puedes usar el modelo cuantificado para predecir otros atributos 3D siguiendo la guía [aquí](https://github.com/facebookresearch/vggt/tree/evaluation#detailed-usage).

## Comentarios

* Nuestra base de código se construye en gran medida sobre [VGGT](https://github.com/facebookresearch/vggt) y [QuaRot](https://github.com/spcl/QuaRot). ¡Gracias por hacerlos de código abierto!

## BibTeX

Si encuentras que *QuantVGGT* es útil y beneficioso para tu trabajo, por favor cita amablemente este artículo:

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