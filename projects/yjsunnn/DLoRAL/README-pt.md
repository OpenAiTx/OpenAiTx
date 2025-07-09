<div align="center">
<h2>Difusão de Um Passo para Super-Resolução de Vídeo Rica em Detalhes e Temporalmente Consistente</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>The Hong Kong Polytechnic University, <sup>2</sup>OPPO Research Institute
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Página%20do%20Projeto-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Vídeo%20Demo-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/Explicação%202%20Min-brightgreen?logo=YouTube&logoColor=white">
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Resultados Visuais">

</p>
## ⏰ Atualização

- **2025.07.08**: O código de inferência e os pesos pré-treinados estão disponíveis.
- **2025.06.24**: A página do projeto está disponível, incluindo um breve vídeo explicativo de 2 minutos, mais resultados visuais e pesquisas relevantes.
- **2025.06.17**: O repositório foi lançado.

:star: Se o DLoRAL for útil para seus vídeos ou projetos, por favor, ajude dando uma estrela neste repositório. Obrigado! :hugs:

😊 Você também pode querer conferir nossos trabalhos relacionados:

1. **OSEDiff (NIPS2024)** [Artigo](https://arxiv.org/abs/2406.08177) | [Código](https://github.com/cswry/OSEDiff/)  

   Algoritmo de SR de Imagem em tempo real que foi aplicado à série OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Artigo](https://arxiv.org/pdf/2412.03017) | [Código](https://github.com/csslc/PiSA-SR) 

   Exploração pioneira do paradigma Dual-LoRA em SR de Imagem.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repositório](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Uma lista curada de recursos para Super-Resolução de Vídeo (VSR) usando Modelos de Difusão.
## 👀 TODO
- [x] Liberar o código de inferência.
- [ ] Colab e interface Huggingface para teste conveniente (Em breve!).
- [ ] Liberar o código de treinamento.
- [ ] Liberar os dados de treinamento.


## 🌟 Visão Geral da Estrutura

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Treinamento**: Um esquema dinâmico de treinamento em duas etapas alterna entre a otimização da coerência temporal (estágio de consistência) e o refinamento de detalhes espaciais de alta frequência (estágio de aprimoramento), com interpolação suave da perda para garantir estabilidade.

**Inferência**: Durante a inferência, tanto o C-LoRA quanto o D-LoRA são mesclados no UNet de difusão congelado, permitindo o aprimoramento em um único passo de entradas de baixa qualidade para saídas de alta qualidade.
## 🔧 Dependências e Instalação

1. Clone o repositório
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Instale os pacotes dependentes
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Baixe os Modelos 
#### Modelos Dependentes
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> coloque em **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> coloque em **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> coloque em **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> coloque em **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pesos Pré-treinados](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> coloque em **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Cada caminho pode ser modificado de acordo com os próprios requisitos, e as alterações correspondentes também devem ser aplicadas na linha de comando e no código.
## 🖼️ Inferência Rápida
Para Super-Resolução de Vídeo do Mundo Real:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /caminho/para/stable-diffusion-2-1-base     \
--ram_ft_path /caminho/para/DAPE.pth     \
--ram_path '/caminho/para/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/caminho/para/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /caminho/para/model_checkpoint.pkl     \
--stages 1     \
-i /caminho/para/input_videos/     \
-o /caminho/para/results
```

### Citações
Se o nosso código ajudar na sua pesquisa ou trabalho, por favor, considere citar o nosso artigo.
A seguir estão as referências BibTeX:

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