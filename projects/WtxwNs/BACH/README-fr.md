
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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
  <i>Regardez comment BACH transforme les jetons bruts en musique structurée—étape par étape.</i>
</p>

# BACH : Assistant de Composition IA au Niveau de la Mesure  

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
&gt; Soumission ICASSP 2026 – **Acceptée**

---

## 🎼 Résumé en une phrase  
BACH est le premier générateur de chansons symboliques **éditable par l’humain** et **au niveau de la mesure** :  
LLM écrit les paroles → Transformer génère une partition ABC → des synthétiseurs standards produisent une musique **de plusieurs minutes, au niveau de Suno**.  
**1 B de paramètres**, inférence **à l’échelle de la minute**, **meilleur open-source**.

---

## 📦 Contenu du dépôt (version préliminaire)
| Chemin | Description |
|--------|-------------|
| `README.md` | Ce fichier |
| `code/` | code d’inférence |
| `example.mp3` | une chanson exemple |
| `fig/` | Schéma d’architecture |

---

## 🏗️ Architecture du modèle (d’un seul coup d’œil)

Prompt utilisateur
Qwen3 — paroles & étiquettes de style
BACH-1B Transformer Décodage-Seul
Partition ABC (Dual-NTP + Chain-of-Score)
ABC → MIDI → FluidSynth + VOCALOID
Mixage stéréo


| Composant | Idée clé |
|-----------|----------|
| **Dual-NTP** | Prédire `{vocal_patch, accomp_patch}` conjointement à chaque étape |
| **Chain-of-Score** | Balises de section `[START:Chorus] ... [END:Chorus]` pour une longue cohérence |
| **Bar-stream patch** | Patches de 16 caractères non chevauchants par mesure |

---

## 🧪 Démarrage rapide (compatible CPU)
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

##  🎧 Écoutez maintenant
example.mp3 est prêt pour vous, c'est une chanson entière. Vous pouvez la comparer avec Suno🙂

## Sortie complète après acceptation de l'article associé
- Ensemble d'entraînement complet (ABC + paroles + étiquettes de structure)
- Poids BACH-1B (format Transformers)
- Scripts d'entraînement (multiphase + multitâche + ICL)
- Code complet

## 📎 Citation
L'article est publié sur Arxiv, 
```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={Via Score to Performance : Génération efficace de longues chansons contrôlables par l'humain avec une notation symbolique au niveau des mesures}, 
      author={Tongxi Wang et Yang Yu et Qing Wang et Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---