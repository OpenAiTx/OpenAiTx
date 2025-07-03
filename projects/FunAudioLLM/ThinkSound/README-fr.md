# 🎶 ThinkSound

<p align="center">
  Si vous trouvez ce projet utile, une étoile ⭐ sur GitHub serait grandement appréciée !
</p>

<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

---

**ThinkSound** est un cadre unifié de génération Any2Audio avec un guidage par appariement de flux basé sur le raisonnement Chain-of-Thought (CoT).

Implémentation PyTorch pour la génération et l'édition audio multimodales : générez ou éditez de l’audio à partir de vidéo, de texte et d’audio, alimenté par un raisonnement étape par étape provenant de Modèles de Langage Multimodaux de Grande Taille (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Actualités
- **2025.07** &nbsp; 🔥Démo en ligne sur [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) et [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) pour une expérience interactive !
- **2025.07** &nbsp; 🔥Scripts d’inférence et interface web publiés ; 
- **2025.06** &nbsp; 🔥[Article ThinkSound](https://arxiv.org/pdf/2506.21448) publié sur arXiv !
- **2025.06** &nbsp; 🔥[Démo en ligne](http://thinksound-project.github.io/) disponible - essayez-la dès maintenant !

---

## 🚀 Fonctionnalités

- **Any2Audio** : Génération audio à partir de modalités arbitraires — vidéo, texte, audio, ou leurs combinaisons.
- **Vidéo-vers-Audio SOTA** : Résultats à la pointe de la technologie sur plusieurs benchmarks V2A.
- **Raisonnement guidé par CoT** : Raisonnement Chain-of-Thought pour une génération audio compositionnelle et contrôlable via les MLLMs.
- **Édition interactive centrée objet** : Affinez ou éditez des événements sonores spécifiques en cliquant sur des objets visuels ou via des instructions textuelles.
- **Cadre unifié** : Un modèle fondamental unique prend en charge la génération, l’édition et le flux de travail interactif.

---

## ✨ Aperçu de la méthode

ThinkSound décompose la génération et l’édition audio en trois étapes interactives, toutes guidées par le raisonnement Chain-of-Thought (CoT) basé sur les MLLMs :

1. **Génération Foley :** Générer des paysages sonores fondamentaux, sémantiquement et temporellement alignés à partir de la vidéo.
2. **Affinement centré objet :** Affiner ou ajouter des sons pour des objets spécifiés par l’utilisateur via des clics ou des régions dans la vidéo.
3. **Édition audio ciblée :** Modifier l’audio généré à l’aide d’instructions en langage naturel de haut niveau.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Un jeu de données annoté CoT à grande échelle (**AudioCoT**) est utilisé pour entraîner à la fois le module de raisonnement et le modèle audio fondamental unifié.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Démarrage rapide

**Préparation de l’environnement :**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Télécharger les poids pré-entraînés https://huggingface.co/liuhuadai/ThinkSound dans le dossier ckpts/
# Les poids du modèle peuvent également être téléchargés depuis https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Rendez-le exécutable**
```bash
chmod +x scripts/demo.sh
```

**Lancer le script**
```bash
./scripts/demo.sh <chemin_vers_video> <légende> <description_CoT>
```


### Utilisation de l’interface web

Pour une expérience interactive, lancez l’interface web Gradio :

```bash
python app.py
```

---
## 📝 À FAIRE

- ☐ Publier les scripts d'entraînement pour les modèles ThinkSound
- ☐ Ouvrir le code source du jeu de données AudioCoT et du pipeline automatisé
- ☐ Fournir une documentation détaillée et une référence API
- ☐ Ajouter la prise en charge de modalités supplémentaires et de tâches en aval

---

## 📄 Licence

Ce projet est publié sous la [Licence Apache 2.0](LICENSE).

> **Remarque :**  
> Le code, les modèles et le jeu de données sont **uniquement destinés à la recherche et à l'éducation**.  
> **L'utilisation commerciale N'EST PAS autorisée.**
>
> Pour une licence commerciale, veuillez contacter les auteurs.

---

## 📖 Citation

Si ThinkSound vous est utile dans vos travaux ou recherches, veuillez citer notre article :

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Contact

✨ N'hésitez pas à [ouvrir une issue](https://github.com/liuhuadai/ThinkSound/issues) ou à nous contacter par e-mail ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) si vous avez des questions ou des suggestions !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---