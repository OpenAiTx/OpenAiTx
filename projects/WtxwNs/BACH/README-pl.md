
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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
  <i>Obejrzyj, jak BACH zamienia surowe tokeny w uporządkowaną muzykę — krok po kroku.</i>
</p>

# BACH: Asystent AI do komponowania na poziomie taktów
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
&gt; Zgłoszenie na ICASSP 2026 – **Zaakceptowano**

---

## 🎼 Jednozdaniowe podsumowanie  
BACH to pierwszy **edytowalny przez człowieka**, **na poziomie taktów** generator utworów symbolicznych:  
LLM pisze teksty → Transformer generuje zapis ABC → gotowe renderery tworzą **wielominutową muzykę na poziomie Suno**.  
**1 mld parametrów**, wnioskowanie **na poziomie minut**, **najlepszy open-source**.

---

## 📦 Co zawiera to repozytorium (wersja podglądowa)
| Ścieżka | Opis |
|------|-------------|
| `README.md` | Ten plik |
| `code/` | kod do wnioskowania |
| `example.mp3` | przykładowy utwór |
| `fig/` | Rysunek architektury |

---

## 🏗️ Architektura modelu (na pierwszy rzut oka)

Podpowiedź użytkownika
Qwen3 — teksty i tagi stylu
BACH-1B Transformer dekoder-only
Zapis ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
Miks stereo


| Komponent | Kluczowa idea |
|-----------|--------------|
| **Dual-NTP** | Przewiduje `{vocal_patch, accomp_patch}` wspólnie na każdym kroku |
| **Chain-of-Score** | Tagi sekcji `[START:Chorus] ... [END:Chorus]` dla długiej spójności |
| **Bar-stream patch** | 16-znakowe, niepokrywające się patche na takt |

---

## 🧪 Szybki start (przyjazny dla CPU)
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

##  🎧 Posłuchaj teraz
example.mp3 jest gotowy dla Ciebie, to cały utwór. Możesz go porównać z Suno🙂

## Pełna publikacja po akceptacji powiązanego artykułu
- Pełny zestaw treningowy (ABC + teksty + etykiety struktury)
- Wagi BACH-1B (format Transformers)
- Skrypty treningowe (wielofazowe + wielozadaniowe + ICL)
- Pełny kod

## 📎 Cytowanie
Artykuł został opublikowany na Arxiv,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Od partytury do wykonania: Efektywne, kontrolowane przez człowieka generowanie długich utworów z wykorzystaniem symbolicznej notacji taktowej}, 
      author={Tongxi Wang i Yang Yu i Qing Wang i Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---