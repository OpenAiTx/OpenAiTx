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

**ThinkSound** é uma estrutura unificada de geração Any2Audio com fluxo guiado por Chain-of-Thought (CoT) reasoning.

Implementação em PyTorch para geração e edição multimodal de áudio: gere ou edite áudio a partir de vídeo, texto e áudio, impulsionado por raciocínio passo a passo de Modelos de Linguagem Multimodal de Grande Porte (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novidades
- **2025.07.17** &nbsp; 🧠 Finetuning ativado: código de treinamento e ajuste fino agora disponível publicamente, junto com instruções claras para ajudar você a customizar e expandir o ThinkSound com seus próprios dados.
- **2025.07.15** &nbsp; 📦 Instalação e usabilidade simplificadas: dependências no PyPI para fácil configuração multiplataforma; scripts `.bat` para Windows automatizam a criação do ambiente e execução dos scripts.
- **2025.07.08** &nbsp;  🔧 Atualização principal: modelo mais leve e uso otimizado de memória e GPU, agora suporta geração de áudio em alta escala!
- **2025.07.01** &nbsp; 🔥Demo online no [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) para experiência interativa!
- **2025.07.01** &nbsp; 🔥Scripts de inferência e interface web lançados;
- **2025.06** &nbsp; 🔥[Artigo ThinkSound](https://arxiv.org/pdf/2506.21448) publicado no arXiv!
- **2025.06** &nbsp; 🔥[Demo Online](http://thinksound-project.github.io/) está no ar - experimente agora!

---


## 🚀 Funcionalidades

- **Any2Audio**: Gere áudio a partir de modalidades arbitrárias — vídeo, texto, áudio ou suas combinações.
- **Video-to-Audio SOTA**: Resultados de ponta em diversos benchmarks de V2A.
- **Raciocínio guiado por CoT**: Chain-of-Thought reasoning para geração de áudio composicional e controlável via MLLMs.
- **Edição Interativa Centrada em Objetos**: Refine ou edite eventos sonoros específicos clicando em objetos visuais ou usando instruções de texto.
- **Estrutura Unificada**: Um modelo base suporta geração, edição e fluxo de trabalho interativo.

---

## ✨ Visão Geral do Método

ThinkSound decompõe a geração e edição de áudio em três estágios interativos, todos guiados por raciocínio Chain-of-Thought (CoT) baseado em MLLM:

1. **Geração Foley:** Gere paisagens sonoras fundamentais, semanticamente e temporalmente alinhadas ao vídeo.
2. **Refinamento Centrado em Objetos:** Refine ou adicione sons para objetos especificados pelo usuário através de cliques ou regiões no vídeo.
3. **Edição de Áudio Direcionada:** Modifique o áudio gerado usando instruções em linguagem natural de alto nível.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Um conjunto de dados em larga escala anotado com CoT (**AudioCoT**) é usado para treinar tanto o módulo de raciocínio quanto o modelo unificado de áudio base.
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
## 🏋️ Treine o Modelo

Veja [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & Planos Futuros
* - [ ] Open-source do dataset AudioCoT e pipeline automatizado (Previsto antes de 23/07/2025)
* - [ ] Lançar um modelo base mais poderoso cobrindo múltiplos domínios para proporcionar criação de foley mais envolvente e imersiva (Previsto até o final de agosto de 2025)
* - [ ] Adicionar suporte para modalidades adicionais e tarefas downstream (Previsto antes do final de julho de 2025)
* - [ ] Lançar modelos em diferentes escalas (Previsto antes do final de julho de 2025)
* - [x] Disponibilizar scripts de treinamento para os modelos ThinkSound
* - [x] README de início rápido para Windows para iniciantes
---


## 📄 Licença

Este projeto é distribuído sob a Licença Apache 2.0.

> **Nota:**
> O código, modelos e dataset são **apenas para fins de pesquisa e educação**.
> **Uso comercial NÃO é permitido.**
> Para licenciamento comercial, por favor contate os autores.

**📦 Componentes de Terceiros**

* **Stable Audio Open VAE** (por Stability AI):
  Este repositório inclui um VAE fine-tuned do [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), licenciado sob a [Licença da Comunidade Stability AI](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Uso comercial e redistribuição requerem permissão prévia da Stability AI.**

* 📘 **Todo o restante do código e modelos** são lançados sob a Licença Apache 2.0.

---

## Agradecimentos

Muito obrigado a:

* **stable-audio-tools** (por Stability AI):
Por fornecer um framework fácil de usar para geração de áudio, bem como o módulo VAE e pesos.
* **MMAudio**:
  Pela implementação do backbone MM-DiT no domínio do áudio.

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

## 📬 Contato

✨ Sinta-se à vontade para [abrir uma issue](https://github.com/liuhuadai/ThinkSound/issues) ou entrar em contato conosco por e-mail ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) se tiver alguma dúvida ou sugestão!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---