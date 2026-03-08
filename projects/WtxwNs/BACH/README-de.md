
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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
  <i>Beobachten Sie, wie BACH rohe Tokens Schritt für Schritt in strukturierte Musik verwandelt.</i>
</p>

# BACH: Bar-level AI Composing Helper

<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="Lizenz"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo-Größe"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Sterne"/>
</p>

&gt; *"Via Score to Performance: Effiziente, menschlich steuerbare Langlied-Generierung mit Takt-basierter symbolischer Notation"*  
&gt; ICASSP 2026 Einreichung – **Akzeptiert**

---

## 🎼 Zusammenfassung in einem Satz  
BACH ist der erste **menschlich editierbare**, **taktbasierte** symbolische Songgenerator:  
LLM schreibt Liedtext → Transformer erzeugt ABC-Score → Standard-Renderer liefern **minutenlange, Suno-Niveau** Musik.  
**1 B Parameter**, **minutenlanges** Inferenz, **SOTA Open-Source**.

---

## 📦 Was ist in diesem Repo enthalten (Vorschauversion)
| Pfad | Beschreibung |
|------|--------------|
| `README.md` | Diese Datei |
| `code/` | Inferenz-Code |
| `example.mp3` | Ein Beispiel-Song |
| `fig/` | Architektur-Abbildung |

---

## 🏗️ Modellarchitektur (auf einen Blick)

Benutzereingabe
Qwen3 — Liedtext & Stil-Tags
BACH-1B Decoder-Only Transformer
ABC-Score (Dual-NTP + Chain-of-Score)
ABC → MIDI → FluidSynth + VOCALOID
Stereomix


| Komponente | Schlüsselidee |
|------------|--------------|
| **Dual-NTP** | `{vocal_patch, accomp_patch}` gemeinsam bei jedem Schritt vorhersagen |
| **Chain-of-Score** | Abschnittstags `[START:Chorus] ... [END:Chorus]` für lange Kohärenz |
| **Bar-stream patch** | 16-Zeichen nicht überlappende Patches pro Takt |

---

## 🧪 Schnellstart (CPU-freundlich)
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

##  🎧 Jetzt anhören
example.mp3 ist für dich bereit, es ist ein vollständiges Lied. Du kannst es mit Suno🙂 vergleichen.

## Vollständige Veröffentlichung nach Annahme des zugehörigen Papers
- Vollständiger Trainingssatz (ABC + Liedtexte + Struktur-Labels)
- BACH-1B-Gewichte (Transformers-Format)
- Trainingsskripte (mehrphasig + multitasking + ICL)
- Vollständiger Code

## 📎 Zitation
Das Paper ist auf Arxiv veröffentlicht,
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Von Score zu Performance: Effiziente, vom Menschen kontrollierbare Langlied-Generierung mit taktbasiertem symbolischem Notationssystem}, 
      author={Tongxi Wang und Yang Yu und Qing Wang und Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---