<div align="right">
  <details>
<summary>🌐 Langue</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Un modèle de langage entraîné **à partir de zéro** exclusivement sur des données provenant de certains lieux et périodes pour réduire le biais moderne et émuler la voix, le vocabulaire et la vision du monde de l'époque.*

Imaginez si un modèle d'IA ne faisait pas que prétendre être historique, mais l'était réellement.

v0 et v0.5 basés sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) Les scripts d'entraînement principaux et l'architecture du modèle sont son travail.

v1 basé sur [Phi 1.5 par Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 basé sur llamaforcausallm

[Lien Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## État de la recherche
Ce projet a été initié et développé indépendamment.

Il est actuellement mené sous supervision académique, avec une collaboration de recherche affiliée au Muhlenberg College.

## Citation

Si vous utilisez ce jeu de données ou ce modèle dans un travail académique, veuillez citer :


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  Comportement et limitations du modèle

### **v0**  

Les premiers prompts montrent que le modèle répond avec le langage et le comportement des années 1800.  
Exemple : Prompt : « Qui est Henry ? » et il a répondu « Je connais cet homme, je n’ai pas fait de noir, la tempête. » 

![Exemple de sortie TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Aucune mention de concepts modernes  
- Vocabulaire principalement fidèle à l’époque  
- Phrases majoritairement incohérentes (attendu pour un jeu d’entraînement de ~187Mo)

### **v0.5** 

Amélioration significative par rapport à v0.  
- Style d’écriture victorien, ponctuation correcte, phrases majoritairement grammaticales  
- Taux de fabrication factuelle encore élevé  
- Bruit d’OCR (« Digitized by Google ») encore présent dans les sorties

![Exemple de sortie TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Premier modèle à rappeler et relier un événement historique réel avec une figure réelle du jeu de données.

Exemple : Prompt : « C’était l’an de grâce 1834 » 

Sortie : « C’était l’an de grâce 1834 et les rues de Londres étaient remplies de protestations et de pétitions. La cause, comme beaucoup l’ont raconté, n’était pas liée à la voie privée, mais ayant été reprise le même jour en la journée de Lord Palmerston, le public recevra un court exposé des difficultés sous lesquelles la journée de la loi nous est parvenue. C’est un sujet de profond regret, que les événements actuels dans l’histoire du monde soient clairs et seront donc connus. Il n’est pas vrai que les tout premiers hommes qui se sont installés dans l’Évangile à Jérusalem devaient posséder un dossier aussi vaste et intéressant de la prospérité et de la prospérité » 

Au début, j’ai supposé qu’une manifestation avait pu avoir lieu par coïncidence cette année-là, mais regardez ceci : ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Entraîné à partir d’un échantillon de 15 Go issu du jeu de données de 90 Go de v2.  
Modèle entraîné sur seulement 10 000 étapes.

Un problème de tokenisation a causé ce type de sortie :

Qui est Charles Dickens ?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corrigé :

« Qui est Charles Dickens ? Est-ce que cela fonctionne davantage pour ses excellents élans, dans ses pièces, à la ferme de la Grande Compagnie ? Qu'ai-je encore à citer de Jack Pickett ? Ne savez-vous pas qu'ils étaient une sorte de galop, ou de sciage de leur poitrine, ou qu'il fallait faire quelque chose à l'époque où Jackson regardait par la fenêtre ? Quel est le succès d'un Anglais, et que son fils ne m'a pas encore révélé, afin d'accomplir un tel poids ? Avez-vous déjà fait un passage sur l'ancienne chaussée, ou vers une brise d'ancre au pied de notre bateau, que vous devez nous laisser ? Le fait est que, que le vent se lève de la plaine le samedi soir ou à midi, ou jusqu'au nord, ou autrement, nous serons obligés de décrire une barrière redoutable, avec les mêmes effets qu'à présent. Dans cette situation, du moins, il n'est pas exagéré de dire que nous avons quitté cette pièce. Je crois qu'il y a trois exemplaires dans le « Cinq Cents Fois », à consulter, comme le premier numéro de nos lecteurs qui souhaitent t[o]... »

### **v2mini-eval2**

Entraîné à l'aide du même échantillon de 15 Go utilisé pour l'entraînement d'eval1.
Le modèle est à nouveau entraîné à seulement 10 000 étapes.

PROMPT : Charles Darwin

Charles DarwinECCEMACY. Monsieur, — Le cas suivant m'intéresse : — J'étais à Londres depuis quinze jours, et j'ai été fortement affecté par une attaque de rhumatisme. La première attaque de rhumatisme a eu lieu une semaine avant de vous voir, la deuxième quand je vous ai vu, la troisième quand je vous ai vu, et la troisième en même temps. Cependant, la deuxième attaque de goutte n'était pas accompagnée de symptômes fébriles, mais d'une augmentation du débit urinaire et d'une évacuation urinaire plus abondante. La troisième attaque est survenue une heure après vous avoir vu, suivie d'un retour du paroxysme de goutte, et d'un retour plus rapide de la goutte. La quatrième attaque était aussi accompagnée de fièvre, mais pas toujours de symptômes fébriles. La troisième attaque de goutte a eu lieu quinze jours après votre maladie, et la quatrième a été suivie d'un paroxysme de goutte. La quatrième attaque a eu lieu quinze jours après votre attaque, et était accompagnée d'une sensation

### **v2**

Entraîné avec un jeu de données de 90 Go (112 Go tokenisés)
Entraîné jusqu'à 182 000 étapes

![Exemple de sortie TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![Exemple de sortie TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Jeux de données

### **v2**

- 90 Go (brut) de textes londoniens de 1800-1875
- 136 344 documents
- L'ensemble de données tokenisé complet est désormais disponible ici : https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Statistiques de biais 
  ![Biais des pronoms](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Biais géographique](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Biais temporel](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consultez le [rapport sur les biais v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) pour plus d'informations.



## Comment utiliser

Ce projet se concentre principalement sur la collecte de données historiques, leur préparation pour l'entraînement et la création d'un tokenizer. Je ne vais pas couvrir le processus complet d'entraînement d'un LLM, pour cela référez-vous à nanoGPT par Andrej Karpathy.

### Étape 1 : Collecter et préparer des textes historiques

- Rassemblez des fichiers .txt de livres, documents, etc. du domaine public de votre période choisie (par exemple, Londres 1800-1850)
- Gardez-les dans votre fenêtre temporelle/géographique choisie
- Nettoyez les fichiers texte à l'aide d'un script ou supprimez manuellement les en-têtes/pieds de page du Projet Gutenberg, les annotations modernes ou les erreurs OCR.

### Étape 2 : Construire un tokenizer personnalisé

- Exécutez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
- Cela vous donnera vocab.json et merges.txt
- Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

### Étape 3 : Entraînez votre modèle

- Référez-vous à [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d'entraînement ou la documentation de l'architecture choisie.

# FAQ

## Qu'est-ce que l'Entraînement Temporel Sélectif ?

L'Entraînement Temporel Sélectif (Selective Temporal Training, STT) est une méthodologie d'apprentissage automatique où toutes les données d'entraînement sont soigneusement sélectionnées pour appartenir à une période historique spécifique. Cela permet de modéliser la langue et les connaissances de cette époque sans influence des concepts modernes. Par exemple, le modèle actuel (v0.5) est entraîné uniquement sur des données de 1800 à 1875, il n'est pas affiné mais entraîné de zéro, produisant ainsi des sorties qui reflètent le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?

Pour ce projet, j'essaie de créer un modèle linguistique non biaisé par la modernité. Si j'affine un modèle comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j'entraîne un modèle à partir de zéro, il ne fera pas semblant d'être ancien, il le sera vraiment. L'objectif actuel de ce projet est de créer un modèle qui raisonne exclusivement à partir des connaissances de livres londoniens publiés entre 1800 et 1875.

## Quel type de données avez-vous utilisé pour l'entraînement ?

J'utilise des livres, documents juridiques, journaux et autres écrits de Londres entre 1800 et 1875. La liste que j'ai partagée (pour v0) contient environ 200 fichiers, mais pour le premier entraînement j'en ai utilisé seulement 50, soit environ 187 Mo. Vous pouvez consulter la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tailles des jeux de données :
- v0 : ~187 Mo
- v0.5 : ~435 Mo
- v1 : ~6,25 Go
- v2mini-eval1 : 15 Go (échantillon de 90 Go de v2)
- v2 : 90 Go

## Quelle est la taille des modèles ?

v0 : 16M de paramètres

v0.5 : 123M de paramètres

v1 : 700M de paramètres

v2mini-eval1 : 300M de paramètres

v2mini-eval2 : 200M de paramètres

v2 : 1,2B de paramètres

## Spécifications d’entraînement ?

### v0/v0.5
GPU : Geforce RTX 4060
CPU : i5-13400F
RAM : 16 Go DDR5.

### v1
GPU : A100 SXM louée

### v2mini-eval1/eval2
GPU : A100 SXM louée

### v2
GPU : H100 SXM louée

## Remerciements

Je souhaite remercier [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) pour la supervision académique, l’orientation sur la structuration de la recherche et l’évaluation, ainsi que pour l’aide apportée à l’entraînement du tokenizer et à la préparation du jeu de données pour la version v2. Ses retours et son expérience ont été déterminants dans l’amélioration de la présentation de ce travail.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---