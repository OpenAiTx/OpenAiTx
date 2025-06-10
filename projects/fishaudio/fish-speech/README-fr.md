<div align="center">
<h1>Fish Speech</h1>

**English** | [简体中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **Avis de licence**  
> Cette base de code est publiée sous la **licence Apache** et tous les poids des modèles sont publiés sous la **licence CC-BY-NC-SA-4.0**. Veuillez consulter le fichier [LICENSE](LICENSE) pour plus de détails.

> [!WARNING]
> **Avertissement légal**  
> Nous déclinons toute responsabilité en cas d'utilisation illégale de cette base de code. Veuillez respecter les lois locales concernant le DMCA et toute législation associée.

---

## 🎉 Annonce

Nous sommes ravis d'annoncer notre changement de nom pour **OpenAudio** — une nouvelle série révolutionnaire de modèles avancés de synthèse vocale (Text-to-Speech) qui s'appuie sur les fondations de Fish-Speech.

Nous sommes fiers de présenter **OpenAudio-S1**, le premier modèle de cette série, qui apporte des améliorations significatives en termes de qualité, de performance et de fonctionnalités.

OpenAudio-S1 est disponible en deux versions : **OpenAudio-S1** et **OpenAudio-S1-mini**. Les deux modèles sont désormais accessibles sur [Fish Audio Playground](https://fish.audio) (pour **OpenAudio-S1**) et sur [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (pour **OpenAudio-S1-mini**).

Consultez le [site officiel OpenAudio](https://openaudio.com/blogs/s1) pour le blog et le rapport technique.

## Points forts ✨

### **Excellente qualité TTS**

Nous utilisons les métriques Seed TTS Eval pour évaluer la performance du modèle, et les résultats montrent qu'OpenAudio S1 atteint **0,008 WER** et **0,004 CER** sur du texte anglais, ce qui est nettement supérieur aux modèles précédents. (Anglais, évaluation automatique, basé sur OpenAI gpt-4o-transcribe, distance entre locuteurs utilisant Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Modèle | Taux d’erreur de mots (WER) | Taux d’erreur de caractères (CER) | Distance des locuteurs |
|--------|-----------------------------|-----------------------------------|-----------------------|
| **S1** | **0,008**  | **0,004**  | **0,332** |
| **S1-mini** | **0,011** | **0,005** | **0,380** |

### **Meilleur modèle sur TTS-Arena2** 🏆

OpenAudio S1 a obtenu le **rang #1** sur [TTS-Arena2](https://arena.speechcolab.org/), le benchmark d’évaluation de la synthèse vocale :

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Contrôle de la parole**

OpenAudio S1 **prend en charge une variété de marqueurs émotionnels, de tonalité et spéciaux** pour enrichir la synthèse vocale :

- **Émotions de base** :
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Émotions avancées** :
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Marqueurs de tonalité** :
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Effets audio spéciaux** :
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Vous pouvez aussi utiliser Ha,ha,ha pour contrôler, de nombreux autres cas restent à explorer par vous-même.

(Actuellement disponible pour l’anglais, le chinois et le japonais, d’autres langues arrivent bientôt !)

### **Deux types de modèles**

| Modèle | Taille | Disponibilité | Fonctionnalités |
|--------|--------|---------------|-----------------|
| **S1** | 4B paramètres | Disponible sur [fish.audio](fish.audio) | Modèle phare toutes options |
| **S1-mini** | 0,5B paramètres | Disponible sur huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Version distillée avec capacités principales |

S1 et S1-mini intègrent tous deux l’apprentissage par renforcement en ligne à partir du retour humain (RLHF).

## **Fonctionnalités**

1. **TTS Zero-shot & Few-shot :** Saisissez un échantillon vocal de 10 à 30 secondes pour générer une sortie TTS de haute qualité. **Pour un guide détaillé, voir [Meilleures pratiques pour le clonage de voix](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Support multilingue et interlingue :** Copiez/collez simplement du texte multilingue dans la boîte de saisie—aucune inquiétude à avoir sur la langue. Actuellement supporte l’anglais, le japonais, le coréen, le chinois, le français, l’allemand, l’arabe et l’espagnol.

3. **Aucune dépendance aux phonèmes :** Le modèle possède de solides capacités de généralisation et ne dépend pas des phonèmes pour la synthèse vocale. Il peut traiter du texte dans n’importe quel alphabet.

4. **Grande précision :** Atteint un faible taux d’erreur de caractères (CER) d’environ 0,4% et un taux d’erreur de mots (WER) d’environ 0,8% pour Seed-TTS Eval.

5. **Rapide :** Avec l’accélération fish-tech, le facteur temps réel est d’environ 1:5 sur un portable Nvidia RTX 4060 et 1:15 sur une Nvidia RTX 4090.

6. **WebUI pour l’inférence :** Propose une interface web conviviale basée sur Gradio, compatible avec Chrome, Firefox, Edge et d’autres navigateurs.

7. **Inférence GUI :** Offre une interface graphique PyQt6 qui fonctionne parfaitement avec le serveur d’API. Compatible Linux, Windows et macOS. [Voir GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Prêt pour le déploiement :** Déployez facilement un serveur d’inférence avec support natif pour Linux, Windows (MacOS bientôt disponible), avec une perte de vitesse minimale.

## **Médias & Démonstrations**

<div align="center">

### **Réseaux sociaux**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Démos interactives**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Vidéos de présentation**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Exemples audio**
<div style="margin: 20px 0;">
    <em> Des exemples audio de haute qualité seront bientôt disponibles, démontrant nos capacités TTS multilingues dans différentes langues et émotions.</em>
</div>

</div>

---

## Documents

- [Build Envrionment](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inference](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Remerciements

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Rapport technique (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
```
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---