# RefineAnything

**Affinement multimodal spécifique à une région pour des détails locaux parfaits**

<a href="https://limuloo.github.io/RefineAnything/"><img src="https://img.shields.io/badge/Project-Page-blue" /></a>
<a href="https://arxiv.org/abs/2604.06870"><img src="https://img.shields.io/badge/arXiv-2604.06870-b31b1b" /></a>
<a href="https://github.com/limuloo/RefineAnything"><img src="https://img.shields.io/badge/GitHub-Code-black?logo=github" /></a>
<a href="https://huggingface.co/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Checkpoint-yellow?logo=huggingface" /></a>
<a href="https://huggingface.co/spaces/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Space-orange?logo=huggingface" /></a>
<a href="https://github.com/smthemex/ComfyUI_RefineAnything"><img src="https://img.shields.io/badge/ComfyUI-Plugin-green?logo=github" /></a>

RefineAnything cible **l’affinement d’image spécifique à une région** : à partir d’une image d’entrée et d’une région spécifiée par l’utilisateur (par exemple un masque griffonné ou une boîte englobante), il restaure les détails fins — textes, logos, structures fines — tout en gardant **tous les pixels non modifiés inchangés**. Il supporte à la fois l’affinement **avec référence** et **sans référence**.

![Teaser](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/teaser.png)
---

## Actualités
- **2026-04-21** — **Mise à jour de l’environnement verrouillé.** Pour de meilleurs résultats (et éviter les décalages de couleurs), veuillez utiliser **exactement** les versions verrouillées dans `requirement.txt` : `diffusers==0.36.0`, `transformers==4.55.0`, `safetensors==0.5.3`, `peft==0.17.0`. Voir [Avis sur l’environnement](#environment-notice) ci-dessous pour une comparaison visuelle.
- **2026-04-21** — **Environnement Hugging Face Space corrigé.** La démo en ligne fonctionne désormais avec les bonnes versions des dépendances, les résultats d’affinement sont donc nettement meilleurs : <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-14** — Intégration communautaire ComfyUI par [@smthemex](https://github.com/smthemex) : [ComfyUI_RefineAnything](https://github.com/smthemex/ComfyUI_RefineAnything). Merci pour ce super travail !
- **2026-04-14** — Démo locale Gradio (`app.py`) disponible pour des tests interactifs.
- **2026-04-12** — Démo Hugging Face Space en ligne : <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-09** — Checkpoint publié sur Hugging Face : <https://huggingface.co/limuloo1999/RefineAnything>.
- **2026-04-09** — Publication des scripts d’inférence.
- **2026-04-08** — Squelette de documentation ajouté ; **publication du code prévue ce mois-ci** (scripts d’inférence, environnement et checkpoints seront liés ici).
- **À venir** — Les checkpoints et ressources d’entraînement/évaluation seront annoncés une fois finalisés.

---

## Points forts

- **Affinement précis sur la région** — Des indications explicites (griffonnages ou boîtes) dirigent les modifications vers la zone ciblée.
- **Avec et sans référence** — Image de référence optionnelle pour une récupération guidée des détails locaux.
- **Préservation stricte de l’arrière-plan** — Les modifications restent à l’intérieur de la région cible ; l’entraînement insiste sur des transitions sans couture.

---

## Comparaisons

![Comparaisons qualitatives sans référence](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_free.png)

![Reference-based qualitative comparisons](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_reference.png)

---

## Installation

```bash
pip install -r requirement.txt
```

> **Important — épinglez ces versions exactement.** RefineAnything est sensible aux petites différences numériques dans les bibliothèques sous-jacentes. Veuillez installer **exactement** les versions ci-dessous ; utiliser des versions plus récentes ou plus anciennes peut provoquer des artefacts visibles tels que des décalages de couleur dans la zone raffinée.
>
> ```
> diffusers==0.36.0
> transformers==4.55.0
> safetensors==0.5.3
> peft==0.17.0
> ```

---

## Avis sur l’environnement

Nous avons observé que des versions non assorties de `diffusers` / `transformers` / `safetensors` / `peft` peuvent introduire des **décalages de couleur** dans la zone raffinée, même lorsque tout le reste est identique. L’exemple ci-dessous utilise l’invite *« retirer la main »* :

<table>
<tr>
<td align="center"><b>Entrée (zone masquée = main)</b></td>
<td align="center"><b>Environnement correct</b></td>
<td align="center"><b>Mauvais environnement (décalage de couleur)</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/env_check_input.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/correct_env_result.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/wrong_env_result.png" width="100%"></td>
</tr>
</table>

Si votre sortie affiche un léger décalage de couleur/ton à l’intérieur du masque alors que le reste de l’image semble correct, la première chose à vérifier est la version de vos paquets.

---

## Démarrage rapide

Seules **trois** choses sont nécessaires pour exécuter RefineAnything :

| Argument | Description |
|----------|-------------|
| `--input` | Image source |
| `--mask` | Masque binaire (blanc = région à affiner) |
| `--prompt` | Ce qu'il faut affiner |
| `--ref` | *(optionnel)* Image de référence pour un affinage guidé |

---

### Démo 1 — Affinage de logo basé sur une référence

Affinez un logo flou sur un coussin en utilisant une image de référence.

```bash
python scripts/fast_inference.py \
    --input  src/input1.png \
    --mask   src/mask1.png \
    --prompt "Refine the LOGO." \
    --ref    src/ref1.png \
    --output output/demo1.png
```
<table>
<tr>
<td align="center"><b>Entrée</b></td>
<td align="center"><b>Référence</b></td>
<td align="center"><b>Invite</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_input_zoom.jpg" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/src/ref1.png" width="100%"></td>
<td><i>« Affiner le LOGO. »</i></td>
</tr>
<tr>
<td align="center" colspan="3"><b>Sortie</b></td>
</tr>
<tr>
<td colspan="3"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

### Démo 2 — Affinement de texte sans référence

Affiner un texte chinois flou sur un panneau de bâtiment — aucune image de référence nécessaire.


```bash
python scripts/fast_inference.py \
    --input  src/input2.png \
    --mask   src/mask2.png \
    --prompt "refine the text '鼎好商城'" \
    --output output/demo2.png
```

<table>
<tr>
<td align="center"><b>Entrée</b></td>
<td align="center"><b>Invite</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_input_zoom.jpg" width="100%"></td>
<td><i>« affiner le texte '鼎好商城' »</i></td>
</tr>
<tr>
<td align="center" colspan="2"><b>Sortie</b></td>
</tr>
<tr>
<td colspan="2"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

## Démonstration locale Gradio

Nous proposons également une interface web basée sur Gradio pour des tests interactifs. Vous pouvez brosser des régions, télécharger des images de référence et ajuster tous les paramètres d'inférence dans le navigateur.

```bash
python app.py
```

Ouvrez ensuite `http://localhost:7860` dans votre navigateur. L'application téléchargera automatiquement le modèle de base (`Qwen/Qwen-Image-Edit-2511`) et le LoRA RefineAnything depuis Hugging Face lors du premier lancement.

Vous pouvez spécifier un chemin personnalisé pour le modèle de base via la variable d'environnement `MODEL_DIR` :

```bash
MODEL_DIR=/path/to/local/Qwen-Image-Edit-2511 python app.py
```

**Fonctionnalités de la démo Gradio :**
- **Sélection au pinceau** : peignez directement sur l'image source pour définir la zone de raffinement.
- **Image de référence optionnelle** : téléchargez une seconde image et utilisez éventuellement un pinceau pour découper une zone de référence spécifique.
- **Recadrage de mise au point** : recadre et zoome automatiquement sur la zone d'édition pour une fidélité de détail accrue, puis recombine sans couture.
- **Lightning LoRA** : bascule en un clic pour une inférence plus rapide avec moins d'étapes.
- **Curseur Avant / Après** : comparez instantanément l'entrée et la sortie.

---

## Citation

Si vous utilisez ce dépôt, veuillez citer :

```bibtex
@article{zhou2026refineanything,
  title={RefineAnything: Multimodal Region-Specific Refinement for Perfect Local Details},
  author={Zhou, Dewei and Li, You and Yang, Zongxin and Yang, Yi},
  journal={arXiv preprint arXiv:2604.06870},
  year={2026}
}
```

---

## Remerciements et Licence

RefineAnything s’appuie sur des idées et composants issus de l’écosystème plus large de diffusion et multimodal (y compris **Qwen2.5-VL**, **Qwen-Image**, et la diffusion latente avec **VAE** + **MMDiT**). Les poids des modèles de base et les conditions d’API sont soumis à leurs licences respectives—**vérifiez la conformité avant de redistribuer les points de contrôle ou les poids dérivés**.

Licence **du code du dépôt** : *À DÉFINIR* (par exemple, Apache-2.0 ou MIT)—définissez `LICENSE` lorsque vous publiez le code source de l’implémentation.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---