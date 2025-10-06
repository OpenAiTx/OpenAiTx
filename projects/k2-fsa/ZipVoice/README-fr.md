
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

## Synthèse vocale rapide et de haute qualité en zéro-shot grâce au Flow Matching
</div>

## Vue d'ensemble

ZipVoice est une série de modèles TTS zero-shot rapides et de haute qualité, basés sur le flow matching.

### 1. Caractéristiques principales

- Petit et rapide : seulement 123M de paramètres.

- Clonage vocal de haute qualité : performance à l’état de l’art en similarité de locuteur, intelligibilité et naturel.

- Multilingue : support du chinois et de l’anglais.

- Multi-mode : support de la génération vocale mono-locuteur et du dialogue.

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
      <td>Le modèle de base supportant le TTS zero-shot mono-locuteur en chinois et anglais.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>La version distillée de ZipVoice, offrant une vitesse améliorée avec une dégradation minimale des performances.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Un modèle de génération de dialogue basé sur ZipVoice, capable de générer des dialogues parlés à deux voix sur un seul canal.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>La variante stéréo de ZipVoice-Dialog, permettant la génération de dialogues à deux canaux avec chaque interlocuteur assigné à un canal distinct.</td>
    </tr>
  </tbody>
</table>

## Actualités

**2025/07/14** : **ZipVoice-Dialog** et **ZipVoice-Dialog-Stereo**, deux modèles de génération de dialogues parlés, sont publiés. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14** : Le jeu de données **OpenDialog**, un corpus de dialogues parlés de 6,8k heures, est publié. Téléchargez-le sur [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Consultez les détails sur [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16** : **ZipVoice** et **ZipVoice-Distill** sont publiés. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installation

### 1. Cloner le dépôt ZipVoice

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


```bash
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
- Si `<>` ou `[]` apparaissent dans le texte, les chaînes entourées par celles-ci seront traitées comme des jetons spéciaux. `<>` indique le pinyin chinois et `[]` indique d'autres balises spéciales.

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
- `text` est le texte à synthétiser, par exemple "[S1] Je vais bien. [S2] Comment tu t'appelles ? [S1] Je m'appelle Eric. [S2] Salut Eric."

(2) **Format de prompt séparé** où les audios et les transcriptions des deux interlocuteurs existent dans des fichiers distincts :

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```

- `wav_name` est le nom du fichier wav de sortie.
- `spk1_prompt_transcription` est la transcription du fichier wav de prompt du premier locuteur, par exemple "Bonjour"
- `spk2_prompt_transcription` est la transcription du fichier wav de prompt du second locuteur, par exemple "Comment ça va ?"
- `spk1_prompt_wav` est le chemin du fichier wav de prompt du premier locuteur.
- `spk2_prompt_wav` est le chemin du fichier wav de prompt du second locuteur.
- `text` est le texte à synthétiser, par exemple "[S1] Je vais bien. [S2] Comment tu t'appelles ? [S1] Je m'appelle Eric. [S2] Salut Eric."

### 3 Conseils pour une meilleure utilisation :

#### 3.1 Longueur du prompt

Nous recommandons un fichier wav de prompt court (par exemple, moins de 3 secondes pour la génération de parole à un seul locuteur, moins de 10 secondes pour la génération de dialogue) pour une vitesse d'inférence plus rapide. Un prompt très long ralentira l'inférence et dégradera la qualité de la parole.

#### 3.2 Optimisation de la vitesse

Si la vitesse d'inférence n'est pas satisfaisante, vous pouvez l'accélérer comme suit :

- **Modèle distillé et moins d'étapes** : Pour le modèle de génération de parole à un seul locuteur, nous utilisons le modèle `zipvoice` par défaut pour une meilleure qualité de parole. Si la rapidité est prioritaire, vous pouvez passer à `zipvoice_distill` et réduire le paramètre `--num-steps` jusqu'à `4` (8 par défaut).

- **Accélération CPU avec multi-threading** : Lors de l'exécution sur CPU, vous pouvez utiliser le paramètre `--num-thread` (par exemple, `--num-thread 4`) pour augmenter le nombre de threads et accélérer la vitesse. Nous utilisons 1 thread par défaut.

- **Accélération CPU avec ONNX** : Lors de l'exécution sur CPU, vous pouvez utiliser les modèles ONNX avec `zipvoice.bin.infer_zipvoice_onnx` pour une vitesse supérieure (ONNX n'est pas encore supporté pour les modèles de génération de dialogue). Pour encore plus de rapidité, vous pouvez définir `--onnx-int8 True` pour utiliser un modèle ONNX quantifié INT8. Notez que le modèle quantifié dégradera la qualité de la parole dans une certaine mesure. **N'utilisez pas ONNX sur GPU**, car il est plus lent que PyTorch sur GPU.

#### 3.3 Contrôle de la mémoire

Le texte fourni sera découpé en morceaux selon la ponctuation (pour la génération de parole à un seul locuteur) ou le symbole de changement de locuteur (pour la génération de dialogue). Ensuite, les morceaux seront traités en lots. Ainsi, le modèle peut traiter des textes arbitrairement longs avec une utilisation mémoire quasiment constante. Vous pouvez contrôler l'utilisation mémoire en ajustant le paramètre `--max-duration`.

#### 3.4 Évaluation "brute"

Par défaut, nous prétraitons les entrées (prompt wav, transcription du prompt et texte) pour une inférence efficace et de meilleures performances. Si vous souhaitez évaluer la performance "brute" du modèle avec les entrées exactes fournies (par exemple, pour reproduire les résultats de notre article), vous pouvez utiliser `--raw-evaluation True`.

#### 3.5 Texte court

Lors de la génération de parole pour des textes très courts (par exemple, un ou deux mots), la parole générée peut parfois omettre certaines prononciations. Pour résoudre ce problème, vous pouvez utiliser `--speed 0.3` (où 0.3 est une valeur ajustable) pour prolonger la durée de la parole générée.

#### 3.6 Correction de la prononciation incorrecte des caractères chinois polyphoniques

Nous utilisons [pypinyin](https://github.com/mozillazg/python-pinyin) pour convertir les caractères chinois en pinyin. Cependant, il peut parfois mal prononcer les **caractères polyphoniques** (多音字).

Pour corriger manuellement ces erreurs de prononciation, encadrez le **pinyin corrigé** entre chevrons `< >` et incluez l’**accent tonique**.

**Exemple :**

- Texte original : `这把剑长三十公分`
- Corrigez le pinyin de `长` :  `这把剑<chang2>三十公分`

> **Remarque :** Si vous souhaitez attribuer plusieurs pinyins manuellement, encadrez chaque pinyin avec `<>`, par exemple : `这把<jian4><chang2><san1>十公分`

#### 3.7 Suppression des silences longs dans la parole générée

Le modèle détermine automatiquement les positions et la durée des silences dans la parole générée. Il arrive qu’il y ait de longs silences au milieu de la parole. Si vous ne souhaitez pas cela, vous pouvez passer l’option `--remove-long-sil` pour supprimer les longs silences au milieu de la parole générée (les silences en début et fin seront supprimés par défaut).

#### 3.8 Téléchargement du modèle

Si vous rencontrez des difficultés pour vous connecter à HuggingFace lors du téléchargement des modèles pré-entraînés, essayez de changer l’endpoint vers le site miroir : `export HF_ENDPOINT=https://hf-mirror.com`.

## Entraînez votre propre modèle

Consultez le répertoire [egs](egs) pour des exemples d’entraînement, de fine-tuning et d’évaluation.

## Déploiement C++

Consultez [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) pour la solution de déploiement C++ sur CPU.

## Discussion & Communication

Vous pouvez discuter directement sur [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Vous pouvez également scanner le code QR pour rejoindre notre groupe WeChat ou suivre notre compte officiel WeChat.

| Groupe WeChat | Compte Officiel WeChat |
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---