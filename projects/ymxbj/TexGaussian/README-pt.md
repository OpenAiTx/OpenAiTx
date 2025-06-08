<h1 align="center">TexGaussian: Gerando Materiais PBR de Alta Qualidade via Gaussian Splatting 3D Baseado em Octree</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Materiais de Renderização Baseada em Física (PBR) desempenham um papel crucial na computação gráfica moderna, possibilitando renderização fotorrealista em diversos mapas de ambiente. Desenvolver um algoritmo eficiente e eficaz capaz de gerar automaticamente materiais PBR de alta qualidade, ao invés de apenas textura RGB para malhas 3D, pode agilizar significativamente a criação de conteúdo 3D. A maioria dos métodos existentes utiliza modelos de difusão 2D pré-treinados para síntese de imagens multi-visuais, o que frequentemente resulta em grande inconsistência entre as texturas geradas e as malhas 3D de entrada. Este artigo apresenta o TexGaussian, um método inovador que utiliza Gaussian Splatting 3D alinhado por octantes para geração rápida de materiais PBR. Especificamente, posicionamos cada Gaussiana 3D no nó folha mais fino da octree construída a partir da malha 3D de entrada para renderizar as imagens multi-visuais não só para o mapa de albedo, mas também para rugosidade e metalicidade. Além disso, nosso modelo é treinado de forma regressiva ao invés de difusão por denoising, sendo capaz de gerar o material PBR para uma malha 3D em um único processo feed-forward. Experimentos extensivos em benchmarks públicos demonstram que nosso método sintetiza materiais PBR visualmente mais agradáveis e executa mais rápido do que métodos anteriores, tanto em cenários incondicionais quanto condicionais por texto, exibindo melhor consistência com a geometria fornecida.

## 📦 Instalação

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# gaussian splatting modificado (+ profundidade, renderização alpha)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# outras dependências
pip3 install -r requirements.txt
```

## 🤖 Modelos Pré-Treinados

Fornecemos os seguintes modelos pré-treinados:

| Modelo | Descrição | Parâmetros | Download |
| --- | --- | --- | --- |
| TexGaussian-bench | Modelo incondicional de textura RGB treinado no ShapeNet bench | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Modelo incondicional de textura RGB treinado no ShapeNet car | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Modelo incondicional de textura RGB treinado no ShapeNet chair | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Modelo incondicional de textura RGB treinado no ShapeNet table | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Modelo de material PBR condicional por texto treinado no Objaverse | 295M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inferência

### Material PBR
Para geração de material PBR condicional por texto, execute
```bash
bash inference_for_PBR_material.sh
```
Após o baking da textura e do material, você obterá dois mapas, um é o mapa de albedo e o outro é o mapa de material PBR. Especificamente, o mapa de material PBR contém três canais, onde o canal verde representa o valor de rugosidade e o canal azul representa o valor de metalicidade. Para realizar a renderização PBR das texturas e mapas de materiais gerados, recomendamos o uso [deste script de renderização](https://github.com/ymxbj/BlenderToolboxPBR) escrito em bpy.

Além disso, recomendamos a todos imitar o estilo dos textos do dataset Cap3D e criar seus próprios prompts para melhores resultados de geração. O dataset Cap3D pode ser baixado [aqui](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### Textura RGB
Para geração incondicional de textura RGB, que funciona apenas para 4 categorias específicas: bench, car, chair, table, execute
```bash
bash inference_for_RGB_texture.sh
```
Após o baking da textura, você obterá um mapa de albedo.

## 🏋️‍♂️ Treinamento
Para Objaverse:
```bash
bash train_for_objaverse.sh
```

Para ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Liberar código de treinamento e inferência
- [x] Liberar modelo pré-treinado incondicional apenas de albedo no ShapeNet Dataset
- [x] Liberar modelo pré-treinado PBR condicional por texto no Objaverse Dataset
- [ ] Liberar dataset e ferramentas para dataset

## 📚Agradecimentos

Este trabalho é baseado em várias pesquisas e projetos open-source incríveis, muito obrigado a todos os autores por compartilharem!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) e [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citação -->
## 📜 Citação

Se você achar este trabalho útil, por favor, cite nosso artigo:

1. Versão arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Versão CVPR
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