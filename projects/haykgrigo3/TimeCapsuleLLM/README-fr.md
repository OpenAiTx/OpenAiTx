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

## Rejoignez le Discord Vintage LLM

Si vous vous intéressez aux **modèles de langage historiques**, aux **ensembles de données spécifiques à une époque**, ou à l’avenir de projets comme **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, venez rejoindre la communauté.

Nous utilisons le serveur pour discuter des idées, partager nos avancées et échanger avec d’autres personnes travaillant dans ce domaine.

[Rejoindre le Discord](https://discord.gg/JeWkk4z5)

##  Comportement du Modèle & Limitations

### **v0**  

Les premières requêtes montrent que le modèle répond avec un langage et un comportement des années 1800.  
Exemple : Invite : « Who art Henry? » et il a répondu « I know that man, I have did not a black, the storm. » 

![Sortie d’exemple TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Aucune mention de concepts modernes  
- Vocabulaire majoritairement fidèle à l’époque  
- Les phrases sont majoritairement incohérentes (attendu pour ~187Mo de données d’entraînement)

### **v0.5-london** 

Une amélioration significative par rapport à v0.  
- Style d’écriture victorien, ponctuation correcte, phrases majoritairement grammaticales  
- Taux d’hallucination factuelle toujours élevé  
- Bruit OCR (« Digitized by Google ») encore présent dans les sorties

![Sortie d’exemple TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Premier modèle à rappeler et relier un véritable événement historique avec une figure réelle du jeu de données.

Exemple : Invite : « It was the year of our Lord 1834 » 

La sortie : « It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity » 

Au début, j’ai pensé qu’une manifestation avait pu avoir lieu la même année par coïncidence, mais regardez ceci : ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Entraîné avec un échantillon de 15 Go issu du jeu de données de 90 Go de la v2.
Modèle entraîné uniquement jusqu'à 10 000 itérations.

Un problème de tokenisation a causé une sortie ressemblant à ceci :

INVITE :
Qui est Charles Dickens ?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corrigé :

« Qui est Charles Dickens ? Est-ce que cela fait davantage partie de ses excellents élans, dans ses pièces, à la ferme de la Grande Compagnie ? Qu'ai-je encore à citer de Jack Pickett ? Ne savez-vous pas qu'ils étaient une sorte de galop, ou de sciage de leur poitrine, ou que devait-on faire à l'époque où Jackson regardait à la fenêtre ? Quel est le succès d'un Anglais, et que son fils ne m'a pas encore révélé, ce qui permettrait d’accomplir un tel poids ? Avez-vous déjà fait un passage sur l’ancienne route, ou à une brise d’ancre au pied de notre bateau, que vous devez nous laisser ? Le fait est que, que le vent se lève de la plaine le samedi soir ou à midi, ou jusqu’au nord, ou autrement, nous serons obligés de décrire une barrière redoutable, avec les mêmes effets qu’actuellement. Dans cette situation, du moins, il n’est pas exagéré de dire que nous avons quitté cette pièce. Je crois qu’il y a trois exemplaires dans le "Cinq Cents Fois", à consulter, comme premier nombre pour nos lecteurs qui souhaitent t[…]... »

### **v2mini-eval2-london**

Entraîné avec le même échantillon de 15 Go que celui utilisé pour l’évaluation 1.
Le modèle est de nouveau entraîné jusqu’à 10 000 étapes seulement.

PROMPT : Charles Darwin

Charles Darwin ECCEMACY. Monsieur, — Le cas suivant m'intéresse : — J'étais à Londres depuis quinze jours, et j'ai été fortement atteint par une crise de rhumatisme. La première attaque de rhumatisme a eu lieu une semaine avant de vous voir, la deuxième lorsque je vous ai vu, et la troisième lorsque je vous ai vu, et la troisième au même moment. La deuxième attaque de goutte, cependant, n’était pas accompagnée de symptômes fébriles, mais d’une augmentation du débit urinaire, et d’une émission d’urine plus abondante. La troisième crise est survenue une heure après vous avoir vu, suivie d’un retour de paroxysme de goutte, puis d’un retour plus rapide de la goutte. La quatrième crise a également été accompagnée de fièvre, mais pas toujours de symptômes fébriles. La troisième attaque de goutte a eu lieu quinze jours après que vous ayez été malade, et la quatrième a été suivie d’un paroxysme de goutte. La quatrième crise a eu lieu quinze jours après votre attaque, accompagnée d’une sensation

### **v2-london**

Entraîné sur un jeu de données de 90 Go (112 Go tokenisé)
Entraîné jusqu’à 182 000 étapes

![Exemple de sortie TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![Exemple de sortie TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Quelle est la suite ?**

- Début du développement de TimeCapsuleLLM v3
- Augmentation de la taille et de la couverture géographique du jeu de données
- Extension au-delà de Londres vers d’autres villes

Le travail est mené en collaboration avec des chercheurs de l’University College London (UCL) et une implication institutionnelle supplémentaire est en discussion.


##  Jeux de données

### **v2**

- 90 Go (brut) de textes londoniens de 1800 à 1875
- 136 344 documents
- L’ensemble complet de données tokenisées est désormais disponible ici : https://huggingface.co/datasets/postgrammar/london-llm-1800


 ### Statistiques de biais 
  ![Biais de pronoms](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Biais géographique](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Biais temporel](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consultez le [rapport de biais v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) pour plus d'informations.


- 


## Comment utiliser

Ce projet se concentre principalement sur la collecte de données historiques, leur préparation pour l’entraînement et la création d’un tokenizer. Je ne vais pas aborder l'ensemble du processus d’entraînement LLM, pour cela référez-vous à nanoGPT d’Andrej Karpathy.

### Étape 1 : Rassembler et préparer les textes historiques 

- Collectez des fichiers .txt de livres, documents, etc. du domaine public de votre période choisie (par exemple, Londres 1800-1875) 
- Gardez-les dans votre fenêtre temporelle/géographique choisie  
- Nettoyez les fichiers texte à l’aide d’un script ou manuellement pour supprimer les en-têtes/pieds de page du Projet Gutenberg, annotations modernes ou erreurs OCR.

### Étape 2 : Créer un tokenizer personnalisé

- Exécutez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
- Cela vous donnera vocab.json et merges.txt
- Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

### Étape 3 : Entraînez votre modèle 

- Référez-vous à [nanoGPT d’Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d’entraînement ou aux documents de votre architecture choisie.

# FAQ

## Qu’est-ce que l’entraînement temporel sélectif ?

L’entraînement temporel sélectif (STT) est une méthodologie d’apprentissage automatique où toutes les données d’entraînement sont spécialement sélectionnées pour appartenir à une période historique précise. Cela permet de modéliser le langage et les connaissances de cette époque sans influence de concepts modernes. Par exemple, le modèle actuel (v0.5) est entraîné exclusivement sur des données de 1800 à 1875, il n’est pas affiné mais entraîné à partir de zéro, ce qui donne un résultat reflétant le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?
Pour ce projet, j'essaie de créer un modèle de langage qui ne soit pas influencé par les biais modernes. Si j'affine un modèle comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j'entraîne un modèle à partir de zéro, il ne fera pas semblant d'être ancien, il le sera réellement. L'objectif de ce projet pour l'instant est de créer quelque chose qui puisse raisonner exclusivement en utilisant les connaissances provenant de livres londoniens publiés entre 1800 et 1875.

## Quel type de données avez-vous utilisé pour l'entraînement ?

J'utilise des livres, des documents juridiques, des journaux et d'autres écrits de Londres de 1800 à 1875. La liste que j'ai partagée (pour v0) en contient environ 200, mais pour le premier entraînement je n'ai utilisé que 50 fichiers, soit environ ~187 Mo. Vous pouvez consulter une liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Taille des jeux de données :
- v0 : ~187Mo
- v0.5 : ~435Mo 
- v1 : ~6,25Go 
- v2mini-eval1 : 15Go (échantillon des 90Go de v2)
- v2 : 90Go

## Quelle est la taille des modèles ?

v0 : 16M paramètres

v0.5 : 123M paramètres

v1 : 700M paramètres

v2mini-eval1 : 300M paramètres

v2mini-eval2 : 200M paramètres

v2 : 1,2B paramètres

## Spécifications d'entraînement ?

### v0/v0.5
GPU : Geforce rtx 4060
CPU : i5-13400F 
Ram : 16Go DDR5.

### v1
GPU : A100 SXM louée

### v2mini-eval1/eval2

GPU : A100 SXM louée

### v2
GPU : H100 SXM louée

## Travaux connexes

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  LLM de 13 milliards de paramètres entraîné sur 260 milliards de tokens de textes antérieurs à 1930 avec Q&R. Il existe aussi une version [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  LLM de 1,4 milliard de paramètres entraîné sur des textes de 1800-1899 avec Q&R. Il existe aussi une version [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  LLM de 340 millions de paramètres entraîné sur plus de 28 000 textes entre 1837-1899 avec Q&R.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - une famille de LLMs de 4 milliards de paramètres basée sur l’architecture Qwen3, entraînée de zéro sur 80 milliards de tokens de données historiques jusqu’aux dates de connaissance 1913,1929,1933,1939,1946.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT est un affinement de Mistral-Hermes 2 sur 11 000 textes modernes précoces en anglais, français et latin, provenant principalement de EEBO et Gallica.

## Remerciements

Je tiens à remercier [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) pour sa supervision académique, son encadrement dans la structuration de la recherche et son évaluation, ainsi que pour son aide dans l’entraînement du tokenizer et la préparation du jeu de données pour la version v2. Ses retours et son expérience ont été essentiels pour affiner la présentation de ce travail.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---