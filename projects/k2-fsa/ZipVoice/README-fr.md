<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Synthèse vocale rapide et de haute qualité zéro-shot avec Flow Matching
</div>

## Aperçu

ZipVoice est une série de modèles TTS zéro-shot rapides et de haute qualité basés sur le flow matching.

### 1. Principales fonctionnalités

- Petit et rapide : seulement 123M de paramètres.

- Clonage vocal de haute qualité : performances de pointe en similarité de locuteur, intelligibilité et naturel.

- Multilingue : prend en charge le chinois et l'anglais.

- Multi-mode : prend en charge la génération de parole à locuteur unique et de dialogues.

### 2. Variantes du modèle

<table>
  <thead>
    <tr>
      <th>Nom du modèle</th>
      <th>Description</th>
      <th>Article</th>
      <th>Démo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Le modèle de base prenant en charge le TTS zéro-shot à locuteur unique en chinois et en anglais.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>La version distillée de ZipVoice, avec une vitesse améliorée et une dégradation minimale des performances.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Un modèle de génération de dialogues basé sur ZipVoice, capable de générer des dialogues parlés à deux voix sur un seul canal.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>La variante stéréo de ZipVoice-Dialog, permettant la génération de dialogues à deux canaux avec chaque locuteur sur un canal distinct.</td>
    </tr>
  </tbody>
</table>

## Actualités

**2025/07/14** : **ZipVoice-Dialog** et **ZipVoice-Dialog-Stereo**, deux modèles de génération de dialogues parlés, sont publiés. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14** : Le jeu de données **OpenDialog**, un jeu de données de dialogues parlés de 6,8k heures, est disponible. Téléchargez-le sur [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Détails sur [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16** : **ZipVoice** et **ZipVoice-Distill** sont publiés. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installation

### 1. Clonez le dépôt ZipVoice


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Optionnel) Créez un environnement virtuel Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Installez les paquets requis


```bash
pip install -r requirements.txt
```
### 4. Installer k2 pour l'entraînement ou l'inférence efficace

**k2 est nécessaire pour l'entraînement** et peut accélérer l'inférence. Néanmoins, vous pouvez toujours utiliser le mode inférence de ZipVoice sans installer k2.

> **Remarque :** Assurez-vous d'installer la version de k2 qui correspond à votre version de PyTorch et CUDA. Par exemple, si vous utilisez pytorch 2.5.1 et CUDA 12.1, vous pouvez installer k2 comme suit :


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Veuillez consulter https://k2-fsa.org/get-started/k2/ pour plus de détails.
Les utilisateurs en Chine continentale peuvent consulter https://k2-fsa.org/zh-CN/get-started/k2/.

- Pour vérifier l'installation de k2 :


```
python3 -c "import k2; print(k2.__file__)"
```
## Utilisation

### 1. Génération de parole à un seul locuteur

Pour générer de la parole à un seul locuteur avec nos modèles ZipVoice ou ZipVoice-Distill pré-entraînés, utilisez les commandes suivantes (Les modèles requis seront téléchargés depuis HuggingFace) :

#### 1.1 Inférence d'une seule phrase


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` peut être `zipvoice` ou `zipvoice_distill`, qui sont respectivement les modèles avant et après distillation.
- Si `<>` ou `[]` apparaissent dans le texte, les chaînes qu'ils entourent seront traitées comme des jetons spéciaux. `<>` désigne le pinyin chinois et `[]` désigne d'autres balises spéciales.
- Il est possible d'exécuter les modèles ONNX plus rapidement sur le CPU avec `zipvoice.bin.infer_zipvoice_onnx`.

> **Remarque :** Si vous avez des difficultés à vous connecter à HuggingFace, essayez :
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Inférence d'une liste de phrases


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Chaque ligne de `test.tsv` est au format `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Génération de la parole en dialogue

#### 2.1 Commande d'inférence

Pour générer des dialogues parlés à deux voix avec nos modèles pré-entraînés ZipVoice-Dialogue ou ZipVoice-Dialogue-Stereo, utilisez les commandes suivantes (les modèles requis seront téléchargés depuis HuggingFace) :


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` peut être `zipvoice_dialog` ou `zipvoice_dialog_stereo`,
    qui génèrent respectivement des dialogues mono et stéréo.

#### 2.2 Formats d'entrée

Chaque ligne de `test.tsv` est dans l'un des formats suivants :

(1) **Format de prompt fusionné** où les audios et transcriptions des prompts des deux locuteurs sont fusionnés en un seul fichier wav de prompt :

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name` est le nom du fichier wav de sortie.
- `prompt_transcription` est la transcription du fichier wav du prompt conversationnel, par exemple, "[S1] Bonjour. [S2] Comment ça va ?"
- `prompt_wav` est le chemin vers le fichier wav du prompt.
- `text` est le texte à synthétiser, par exemple, "[S1] Je vais bien. [S2] Comment tu t'appelles ?"

(2) **Format de prompt séparé** où les audios et les transcriptions des deux intervenants existent dans des fichiers distincts :


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` est le nom du fichier wav de sortie.
- `spk1_prompt_transcription` est la transcription du prompt wav du premier locuteur, par exemple, "Bonjour"
- `spk2_prompt_transcription` est la transcription du prompt wav du deuxième locuteur, par exemple, "Comment ça va ?"
- `spk1_prompt_wav` est le chemin du fichier wav du prompt du premier locuteur.
- `spk2_prompt_wav` est le chemin du fichier wav du prompt du deuxième locuteur.
- `text` est le texte à synthétiser, par exemple, "[S1] Je vais bien. [S2] Comment tu t'appelles ?"

### 3. Autres fonctionnalités

#### 3.1 Correction des caractères chinois polyphoniques mal prononcés

Nous utilisons [pypinyin](https://github.com/mozillazg/python-pinyin) pour convertir les caractères chinois en pinyin. Cependant, il peut parfois mal prononcer les **caractères polyphoniques** (多音字).

Pour corriger manuellement ces erreurs de prononciation, entourez le **pinyin corrigé** avec des chevrons `< >` et incluez la **marque de ton**.

**Exemple :**

- Texte original : `这把剑长三十公分`
- Corrigez le pinyin de `长` :  `这把剑<chang2>三十公分`

> **Remarque :** Si vous souhaitez attribuer manuellement plusieurs pinyins, entourez chaque pinyin avec `<>`, par exemple, `这把<jian4><chang2><san1>十公分`

## Entraînez votre propre modèle

Consultez le répertoire [egs](egs) pour des exemples d'entraînement, de fine-tuning et d'évaluation.

## Discussion & Communication

Vous pouvez discuter directement sur [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Vous pouvez également scanner le code QR pour rejoindre notre groupe wechat ou suivre notre compte officiel wechat.

| Groupe Wechat | Compte officiel Wechat |
| ------------- | ---------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Citation


```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---