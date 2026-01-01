<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>Regardez comment BACH transforme des tokens bruts en musique structurée—étape par étape.</i>
</p>

# BACH : Assistant de Composition IA au Niveau des Mesures  

<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="Licence"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Taille du dépôt"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Étoiles"/>
</p>

&gt; *"Via Score to Performance : génération efficace de longues chansons contrôlables par l’humain avec notation symbolique au niveau des mesures"*  
&gt; Soumission ICASSP 2026 – **En attente de revue**

---

## 🎼 Résumé en une phrase  
BACH est le premier générateur de chansons symboliques **modifiable par l’humain**, au niveau des **mesures** :  
LLM écrit les paroles → Transformer produit la partition ABC → des moteurs prêts à l’emploi fournissent de la musique **de plusieurs minutes, de niveau Suno**.  
**1 milliard de paramètres**, inférence à l’échelle de la minute, **SOTA open-source**.

---

## 📦 Contenu de ce dépôt (version preview)
| Chemin | Description |
|------|-------------|
| `README.md` | Ce fichier |
| `code/` | code d’inférence |
| `example.mp3` | un exemple de chanson |
| `fig/` | Figure de l’architecture |

---

## 🏗️ Architecture du modèle (d’un coup d’œil)

Invite utilisateur
Qwen3 — paroles & tags de style
BACH-1B Transformeur décodeur seul
Score ABC (Dual-NTP + Chaîne-de-Score)
ABC → MIDI → FluidSynth + VOCALOID
Mix stéréo


| Composant | Idée clé |
|-----------|----------|
| **Dual-NTP** | Prédire `{vocal_patch, accomp_patch}` conjointement à chaque étape |
| **Chaîne-de-Score** | Tags de section `[START:Chorus] ... [END:Chorus]` pour une longue cohérence |
| **Patch flux-mesure** | Patches non chevauchants de 16 caractères par mesure |

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---