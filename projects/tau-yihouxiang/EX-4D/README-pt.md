# EX-4D: Síntese de Vídeo 4D com Pontos de Vista Extremos via Malha à Prova d’Água de Profundidade

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Artigo](https://arxiv.org/abs/2506.05554)  |  [🎥 Página Principal](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Código](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Destaques

- **🎯 Síntese de Pontos de Vista Extremos**: Gere vídeos 4D de alta qualidade com movimentos de câmera de -90° a 90°
- **🔧 Malha à Prova d’Água de Profundidade**: Nova representação geométrica que modela regiões visíveis e ocultas
- **⚡ Arquitetura Leve**: Apenas 1% dos parâmetros treináveis (140M) do backbone de difusão de vídeo de 14B
- **🎭 Sem Treinamento Multi-view**: Estratégia inovadora de mascaramento elimina a necessidade de datasets multi-view caros
- **🏆 Desempenho de Estado da Arte**: Supera métodos existentes, especialmente em ângulos de câmera extremos

## 🎬 Resultados de Demonstração

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D transforma vídeos monoculares em experiências 4D controláveis pela câmera, com resultados fisicamente consistentes sob pontos de vista extremos.*

## 🏗️ Visão Geral do Framework

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Nosso framework consiste em três componentes principais:

1. **🔺 Construção de Malha à Prova d’Água de Profundidade**: Cria um prior geométrico robusto que modela explicitamente regiões visíveis e ocultas
2. **🎭 Estratégia de Mascaramento Simulado**: Gera dados de treinamento eficazes a partir de vídeos monoculares sem datasets multi-view
3. **⚙️ Adaptador LoRA Leve**: Integra eficientemente informações geométricas com modelos de difusão de vídeo pré-treinados

## 🚀 Início Rápido

### Instalação

```bash
# Clone o repositório
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Crie o ambiente conda
conda create -n ex4d python=3.10
conda activate ex4d
# Instale o PyTorch (recomendado 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Instale o Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Instale dependências e diffsynth
pip install -e .
# Instale depthcrafter para estimativa de profundidade. (Siga as instruções de instalação do DepthCrafter para preparação dos checkpoints.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Baixar Modelo Pré-treinado
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Exemplo de Uso
#### 1. Reconstrução DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Geração EX-4D (Requer 48GB VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Vídeo de Entrada</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Vídeo de Saída</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Método | FID (Extremo) ↓ | FVD (Extremo) ↓ | Pontuação VBench ↑ |
|--------|-----------------|-----------------|--------------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Nosso)** | **55.42** | **823.61** | **0.450** | -->

### Resultados do Estudo com Usuários

- **70,7%** dos participantes preferiram o EX-4D em relação aos métodos de referência
- Desempenho superior em consistência física e qualidade de pontos de vista extremos
- Melhora significativa à medida que os ângulos de câmera se tornam mais extremos


## 🎯 Aplicações

- **🎮 Games**: Criação de cenas cinematográficas 3D imersivas a partir de vídeos 2D
- **🎬 Produção de Filmes**: Geração de novos ângulos de câmera para pós-produção
- **🥽 VR/AR**: Criação de experiências de vídeo com ponto de vista livre
- **📱 Mídias Sociais**: Geração de movimentos dinâmicos de câmera para criação de conteúdo
- **🏢 Arquitetura**: Visualização de espaços a partir de múltiplos pontos de vista

<!-- ## 📈 Benchmarks -->

<!-- ### Avaliação do Alcance do Ponto de Vista

| Alcance | Pequeno (0°→30°) | Grande (0°→60°) | Extremo (0°→90°) | Completo (-90°→90°) |
|---------|------------------|------------------|------------------|---------------------|
| Pontuação FID | 44.19 | 50.30 | 55.42 | - |
| Diferença de desempenho | +9,1% melhor | +8,9% melhor | +11,3% melhor | +15,5% melhor | -->

<!-- *Diferença de desempenho em comparação ao segundo melhor método em cada categoria.* -->

## ⚠️ Limitações

- **Dependência de Profundidade**: O desempenho depende da qualidade da estimativa de profundidade monocular
- **Custo Computacional**: Exige computação significativa para vídeos em alta resolução
- **Superfícies Reflexivas**: Desafios com materiais reflexivos ou transparentes

## 🔮 Trabalhos Futuros
- [ ] Otimização para inferência em tempo real (3DGS / 4DGS)
- [ ] Suporte para resoluções mais altas (1K, 2K)
- [ ] Técnicas de refinamento de malha neural

## 🙏 Agradecimentos

Gostaríamos de agradecer ao projeto [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) por fornecer a base do framework de difusão.

## 📚 Citação

Se você achar nosso trabalho útil, por favor, considere citar:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---