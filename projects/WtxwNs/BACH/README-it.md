
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
  <i>Guarda come BACH trasforma i token grezzi in musica strutturata—passo dopo passo.</i>
</p>

# BACH: Bar-level AI Composing Helper  
<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="License"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo Size"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Stars"/>
</p>

&gt; *"Via Score to Performance: Efficient Human-Controllable Long Song Generation with Bar-Level Symbolic Notation"*  
&gt; ICASSP 2026 Submission – **Accettato**

---

## 🎼 Sintesi in una frase  
BACH è il primo generatore di canzoni simboliche a **misura d'uomo** e **a livello di battuta**:  
LLM scrive i testi → Transformer produce la partitura ABC → renderizzatori pronti all’uso generano musica **di minuti, livello Suno**.  
**1 B parametri**, inferenza **a livello di minuto**, **SOTA open-source**.

---

## 📦 Cosa contiene questo repository (anteprima)
| Path | Descrizione |
|------|-------------|
| `README.md` | Questo file |
| `code/` | codice di inferenza |
| `example.mp3` | una canzone di esempio |
| `fig/` | Figura dell’architettura |

---

## 🏗️ Architettura del modello (a colpo d’occhio)

Prompt utente
Qwen3 — tag per testo & stile
BACH-1B Decoder-Only Transformer
Partitura ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
Mix stereo


| Componente | Idea chiave |
|------------|-------------|
| **Dual-NTP** | Prevedere `{vocal_patch, accomp_patch}` congiuntamente ad ogni passo |
| **Chain-of-Score** | Tag di sezione `[START:Chorus] ... [END:Chorus]` per una lunga coerenza |
| **Bar-stream patch** | Patch di 16 caratteri non sovrapposte per ogni battuta |

---

## 🧪 Avvio rapido (compatibile con CPU)
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

##  🎧 Ascolta ora
example.mp3 è pronto per te, è una canzone intera. Puoi confrontarla con Suno🙂

## Rilascio completo dopo l'accettazione dell'articolo correlato
- Set di addestramento completo (ABC + testi + etichette di struttura)
- Pesi BACH-1B (formato Transformers)
- Script di addestramento (multifase + multitasking + ICL)
- Codice completo

## 📎 Citazione
L'articolo è pubblicato su Arxiv,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Dal punteggio alla performance: Generazione efficiente e controllabile da umani di brani lunghi con notazione simbolica a livello di battuta}, 
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