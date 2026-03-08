
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>Veja como o BACH transforma tokens brutos em música estruturada — passo a passo.</i>
</p>

# BACH: Assistente de Composição com IA em Nível de Compasso
<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="Licença"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Tamanho do Repositório"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Estrelas"/>
</p>

&gt; *"Via Score to Performance: Efficient Human-Controllable Long Song Generation with Bar-Level Symbolic Notation"*  
&gt; Submissão ICASSP 2026 – **Aceito**

---

## 🎼 Resumo em uma frase  
BACH é o primeiro gerador de músicas simbólicas **editável por humanos**, **nível de compasso**:  
LLM escreve a letra → Transformer gera a partitura ABC → renderizadores prontos produzem música de **minutos, nível Suno**.  
**1 B parâmetros**, inferência em **nível de minutos**, **SOTA código aberto**.

---

## 📦 O que contém este repositório (lançamento prévio)
| Caminho | Descrição |
|------|-------------|
| `README.md` | Este arquivo |
| `code/` | código de inferência |
| `example.mp3` | uma música de exemplo |
| `fig/` | Figura da arquitetura |

---

## 🏗️ Arquitetura do Modelo (visão rápida)

Prompt do usuário
Qwen3 — letras & tags de estilo
BACH-1B Transformer Decoder-Only
Partitura ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
Mixagem estéreo


| Componente | Ideia principal |
|------------|----------------|
| **Dual-NTP** | Prediz `{vocal_patch, accomp_patch}` conjuntamente a cada passo |
| **Chain-of-Score** | Tags de seção `[START:Chorus] ... [END:Chorus]` para longa coerência |
| **Bar-stream patch** | Patches de 16 caracteres não sobrepostos por compasso |

---

## 🧪 Início rápido (compatível com CPU)
```bash
# 1. Clone
git clone https://github.com/your-github/BACH.git
cd BACH

# 2. Install
pip install -r requirements.txt        # transformers>=4.41 mido abcpy fluidsynth

# 3. Generate ABC
python bach/generate.py \
    --prompt "A rainy-day lo-fi hip-hop song about missing the last train" \
    --out_abc demo/rainy_lofi.abc

# 4. Render audio
```

##  🎧 Ouça agora
example.mp3 está pronto para você, é uma música completa. Você pode comparar com Suno🙂

## Lançamento completo após aceitação do artigo relacionado
- Conjunto de treinamento completo (ABC + letras + rótulos de estrutura)
- Pesos BACH-1B (formato Transformers)
- Scripts de treinamento (multifásico + multitarefa + ICL)
- Código completo

## 📎 Citação
O artigo foi publicado no Arxiv,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Do Score à Performance: Geração Eficiente e Controlável por Humanos de Músicas Longas com Notação Simbólica em Nível de Compasso}, 
      author={Tongxi Wang e Yang Yu e Qing Wang e Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---