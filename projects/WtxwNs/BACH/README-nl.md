
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">Assamees</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>Kijk hoe BACH ruwe tokens omzet in gestructureerde muziek—stap voor stap.</i>
</p>

# BACH: Bar-level AI Composing Helper  
<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="Licentie"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo Grootte"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Sterren"/>
</p>

&gt; *"Via Score to Performance: Efficiënte, door mensen aanpasbare lange liedgeneratie met maatniveau symbolische notatie"*  
&gt; ICASSP 2026 Inzending – **Geaccepteerd**

---

## 🎼 Eén-zin Samenvatting  
BACH is de eerste **door mensen bewerkbare**, **maatniveau** symbolische liedgenerator:  
LLM schrijft songtekst → Transformer genereert ABC-score → standaard renderers leveren **minutenlange, Suno-waardige** muziek.  
**1 B parameters**, **minuutniveau** inferentie, **SOTA open-source**.

---

## 📦 Wat zit er in deze repo (vooruitgave)
| Pad | Beschrijving |
|------|-------------|
| `README.md` | Dit bestand |
| `code/` | inferentiecode |
| `example.mp3` | een voorbeeldlied |
| `fig/` | Architectuurfiguur |

---

## 🏗️ Modelarchitectuur (in één oogopslag)

Gebruikersprompt
Qwen3 — songteksten & stijltags
BACH-1B Decoder-Only Transformer
ABC-score (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
Stereomix


| Component | Sleutelidee |
|-----------|-------------|
| **Dual-NTP** | Voorspel `{vocal_patch, accomp_patch}` gezamenlijk elke stap |
| **Chain-of-Score** | Sectietags `[START:Chorus] ... [END:Chorus]` voor langdurige samenhang |
| **Bar-stream patch** | 16-tekens niet-overlappende patches per maat |

---

## 🧪 Snelstart (CPU-vriendelijk)
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

##  🎧 Luister nu
example.mp3 is klaar voor je, het is een volledig nummer. Je kunt het vergelijken met Suno🙂

## Volledige release na acceptatie van gerelateerd artikel
- Compleet trainingset (ABC + songteksten + structuur labels)
- BACH-1B gewichten (Transformers-formaat)
- Trainingsscripts (meervoudige fasen + multitask + ICL)
- Complete code

## 📎 Referentie
Artikel is uitgebracht op Arxiv, 
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Via Score to Performance: Efficiënte Mens-Gestuurde Lange Liedgeneratie met Symbolische Notatie op Maatniveau}, 
      author={Tongxi Wang en Yang Yu en Qing Wang en Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---