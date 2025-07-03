# 🎶 ThinkSound

<p align="center">
  Se você achar este projeto útil, uma estrela ⭐ no GitHub será muito apreciada!
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

---

**ThinkSound** é uma estrutura unificada de geração Any2Audio com correspondência de fluxo guiada por raciocínio Chain-of-Thought (CoT).

Implementação em PyTorch para geração e edição de áudio multimodal: gere ou edite áudio a partir de vídeo, texto e áudio, impulsionado por raciocínio passo a passo de Grandes Modelos de Linguagem Multimodal (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Novidades
- **2025.07** &nbsp; 🔥Demo online em [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) e [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) para experiência interativa!
- **2025.07** &nbsp; 🔥Scripts de inferência e interface web lançados;
- **2025.06** &nbsp; 🔥[Artigo ThinkSound](https://arxiv.org/pdf/2506.21448) publicado no arXiv!
- **2025.06** &nbsp; 🔥[Demo Online](http://thinksound-project.github.io/) disponível - experimente agora!

---

## 🚀 Funcionalidades

- **Any2Audio**: Gere áudio a partir de modalidades arbitrárias — vídeo, texto, áudio ou suas combinações.
- **Video-to-Audio SOTA**: Alcança resultados de ponta em múltiplos benchmarks V2A.
- **Raciocínio CoT-Driven**: Raciocínio Chain-of-Thought para geração de áudio composicional e controlável via MLLMs.
- **Edição Interativa Centrada em Objetos**: Refine ou edite eventos sonoros específicos clicando em objetos visuais ou usando instruções de texto.
- **Estrutura Unificada**: Um modelo de base suporta geração, edição e fluxo de trabalho interativo.

---

## ✨ Visão Geral do Método

ThinkSound decompõe a geração e edição de áudio em três etapas interativas, todas guiadas por raciocínio Chain-of-Thought (CoT) baseado em MLLM:

1. **Geração Foley:** Geração de paisagens sonoras fundamentais, semanticamente e temporalmente alinhadas a partir do vídeo.
2. **Refinamento Centrado em Objetos:** Refine ou adicione sons para objetos especificados pelo usuário via cliques ou regiões no vídeo.
3. **Edição de Áudio Direcionada:** Modifique o áudio gerado usando instruções em linguagem natural de alto nível.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Um conjunto de dados em larga escala anotado com CoT (**AudioCoT**) é usado para treinar tanto o módulo de raciocínio quanto o modelo de base de áudio unificado.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Início Rápido

**Preparação do Ambiente:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Baixe os pesos pré-treinados em https://huggingface.co/liuhuadai/ThinkSound para o diretório ckpts/
# Os pesos do modelo também podem ser baixados de https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Torne executável**
```bash
chmod +x scripts/demo.sh
```

**Execute o script**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Uso da Interface Web

Para uma experiência interativa, inicie a interface web Gradio:

```bash
python app.py
```

---
## 📝 TODO

- ☐ Liberar scripts de treinamento para os modelos ThinkSound
- ☐ Tornar open-source o conjunto de dados AudioCoT e o pipeline automatizado
- ☐ Fornecer documentação detalhada e referência da API
- ☐ Adicionar suporte para modalidades adicionais e tarefas downstream

---

## 📄 Licença

Este projeto é disponibilizado sob a [Licença Apache 2.0](LICENSE).

> **Nota:**  
> O código, os modelos e o conjunto de dados são **apenas para fins de pesquisa e educação**.  
> **O uso comercial NÃO é permitido.**
>
> Para licenciamento comercial, por favor, entre em contato com os autores.

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

✨ Sinta-se à vontade para [abrir uma issue](https://github.com/liuhuadai/ThinkSound/issues) ou entrar em contato conosco por e-mail ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) se tiver qualquer dúvida ou sugestão!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---