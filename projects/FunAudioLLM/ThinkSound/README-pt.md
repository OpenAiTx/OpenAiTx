<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Se você achar este projeto útil,<br>
  um star ⭐ no GitHub seria muito apreciado!
</p>

---

**ThinkSound** é uma estrutura unificada de geração Any2Audio com fluxo guiado por raciocínio Chain-of-Thought (CoT).

Implementação em PyTorch para geração e edição multimodal de áudio: gere ou edite áudio a partir de vídeo, texto e áudio, impulsionado por raciocínio passo a passo de Modelos de Linguagem Multimodal de Grande Escala (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novidades
- **2025.09.19** &nbsp; 🎉 ThinkSound foi aceito na **Conferência Principal NeurIPS 2025**!
- **2025.09.01** &nbsp; 🔥 Nosso conjunto de dados AudioCoT agora é open-source e está disponível no [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Finetuning habilitado: código para treinamento e ajuste fino agora disponível publicamente, juntamente com instruções claras para ajudar você a customizar e ampliar o ThinkSound com seus próprios dados.
- **2025.07.15** &nbsp; 📦 Instalação e usabilidade simplificadas: dependências no PyPI para configuração fácil em múltiplas plataformas; scripts `.bat` para Windows automatizam a criação do ambiente e execução dos scripts.
- **2025.07.08** &nbsp;  🔧 Grande atualização: modelo otimizado e leve, com uso aprimorado de memória e GPU, agora suporta geração de áudio em larga escala!
- **2025.07.01** &nbsp; 🔥Demo online no [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) para experiência interativa!
- **2025.07.01** &nbsp; 🔥Scripts de inferência e interface web lançados;
- **2025.06** &nbsp; 🔥[Artigo ThinkSound](https://arxiv.org/pdf/2506.21448) publicado no arXiv!
- **2025.06** &nbsp; 🔥[Demo Online](http://thinksound-project.github.io/) disponível - experimente agora!

---

## 🚀 Funcionalidades

- **Any2Audio**: Gere áudio a partir de qualquer modalidade — vídeo, texto, áudio ou suas combinações.
- **Video-to-Audio SOTA**: Alcança resultados de última geração em múltiplos benchmarks V2A.
- **Raciocínio CoT-Driven**: Raciocínio em cadeia para geração de áudio composicional e controlável via MLLMs.
- **Edição Interativa Centrada em Objetos**: Refine ou edite eventos sonoros específicos clicando em objetos visuais ou usando instruções de texto.
- **Framework Unificado**: Um modelo base suporta geração, edição e fluxo de trabalho interativo.

---

## ✨ Visão Geral do Método

ThinkSound decompõe a geração e edição de áudio em três etapas interativas, todas guiadas pelo raciocínio Chain-of-Thought (CoT) baseado em MLLM:

1. **Geração Foley:** Gere paisagens sonoras fundamentais, semanticamente e temporalmente alinhadas a partir de vídeo.
2. **Refinamento Centrado em Objetos:** Refine ou adicione sons para objetos especificados pelo usuário via cliques ou regiões no vídeo.
3. **Edição de Áudio Direcionada:** Modifique o áudio gerado usando instruções em linguagem natural de alto nível.

![Visão Geral ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Um grande conjunto de dados anotado com CoT (**AudioCoT**) é utilizado para treinar tanto o módulo de raciocínio quanto o modelo base de áudio unificado.

![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Início Rápido

**Preparação do Ambiente:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Dica para Windows:**  
> Usuários do Windows podem simplesmente executar `setup_windows.bat` (ou dar um duplo clique) para criar automaticamente o ambiente conda, instalar todas as dependências (incluindo o FFmpeg) e baixar o modelo pré-treinado — não é necessário configuração manual.  
> Certifique-se de que `conda` e `git` estejam instalados e disponíveis no PATH do sistema antes de executar o script.


### ▶️ Execute a Demonstração

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Você pode usar o script `.bat` fornecido em vez disso:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Nota:**

* `<caminho-para-seu-vídeo-demo>`: O caminho para um único vídeo
* `[use-half]` (opcional): Adicione use-half ao final para ativar a extração de recursos em precisão reduzida.

---

### 📦 Inferência em Lote

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Use o script `.bat` equivalente:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Nota:**

* `<video_path>`: Caminho para o diretório raiz contendo todos os vídeos .mp4 a serem processados (todos os vídeos devem ter a mesma duração).
* `<csv_path>`: Um arquivo CSV com prompts de texto para cada vídeo (veja `demo_test.csv` para o formato).
* `<save_path>` (opcional): Onde salvar o áudio gerado. O padrão é `results/features`.
* `[use-half]` (opcional): Adicione use-half ao final para habilitar a extração de recursos em meia precisão.

---


### Uso da Interface Web

Para uma experiência interativa, inicie a interface web do Gradio:


```bash
python app.py
```


## 🏋️ Treinar o Modelo

Veja [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & Planos Futuros
* - [ ] Lançar um modelo de fundação mais poderoso cobrindo múltiplos domínios para oferecer criação de foley mais envolvente e imersiva
* - [ ] Adicionar suporte para modalidades adicionais e tarefas downstream
* - [ ] Lançar modelos em diferentes escalas
* - [x] Open-source do conjunto de dados AudioCoT e pipeline automatizado
* - [x] Lançar scripts de treinamento para os modelos ThinkSound
* - [x] Um README de início rápido para Windows, amigável para iniciantes
---


## 📄 Licença

Este projeto é lançado sob a Licença Apache 2.0.

> **Nota:**
> O código, modelos e conjunto de dados são **apenas para fins de pesquisa e educação**.
> **Uso comercial NÃO é permitido.**
> Para licenciamento comercial, entre em contato com os autores.

**📦 Componentes de Terceiros**

* **Stable Audio Open VAE** (por Stability AI):
  Este repositório inclui um VAE ajustado do [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), licenciado sob a [Licença de Comunidade Stability AI](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Uso comercial e redistribuição requerem permissão prévia da Stability AI.**

* 📘 **Todo o restante do código e modelos** são lançados sob a Licença Apache 2.0.

---

## Agradecimentos

Muito obrigado a:

* **stable-audio-tools** (por Stability AI):
Por fornecer uma estrutura de fácil utilização para geração de áudio, bem como o módulo VAE e os pesos.
* **MMAudio**:
  Pela implementação do backbone MM-DiT no domínio de áudio.

---

## 📖 Citação

Se você achar o ThinkSound útil em sua pesquisa ou trabalho, por favor cite nosso artigo:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---