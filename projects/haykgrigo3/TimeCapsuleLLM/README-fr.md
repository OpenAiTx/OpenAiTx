<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (bientôt disponible)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (bientôt disponible)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Un modèle de langage entraîné **à partir de zéro** exclusivement sur des données de certains lieux et périodes afin de réduire le biais moderne et d’émuler la voix, le vocabulaire et la vision du monde de l’époque.*

Imaginez qu’un modèle IA ne fasse pas seulement semblant d’être historique, mais le soit réellement.

v0 et v0.5 construits sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) Les scripts d’entraînement principaux et l’architecture du modèle sont son œuvre. 

v1 construit sur [Phi 1.5 par Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Lien Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Comportement du modèle & Limitations

### **v0**  

Les premiers prompts montrent que le modèle répond avec le langage et le comportement des années 1800.  
Exemple : Prompt : « Qui est Henry ? » et il a répondu « Je connais cet homme, je n’ai pas fait de noir, la tempête. »  

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Aucune mention de concepts modernes  
- Vocabulaire principalement fidèle à l’époque  
- Les phrases sont majoritairement incohérentes (attendu pour ~187MB de données d’entraînement)

### **v0.5** 

Amélioration significative par rapport à v0.  
- Style d’écriture victorien, ponctuation correcte, phrases majoritairement grammaticales  
- Taux élevé d’hallucination factuelle persistant  
- Bruit OCR (« Digitized by Google ») encore présent dans les sorties

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Premier modèle à rappeler et relier un événement historique réel à une figure authentique du jeu de données.

Exemple : Prompt : « C’était l’an de grâce 1834 » 

La sortie : « C’était l’an de grâce 1834 et les rues de Londres étaient remplies de protestation et de pétition. La cause, comme beaucoup l’ont raconté, n’était pas liée à la voie privée, mais ayant pris le même jour lors du jour de Lord Palmerston, le public recevra une brève déclaration des difficultés sous lesquelles la loi du jour nous a atteints. C’est un profond regret que les événements actuels dans l’histoire du monde soient clairs, et seront donc connus. Il n’est pas vrai que les tout premiers hommes installés dans l’Évangile à Jérusalem devraient avoir un compte rendu aussi vaste et aussi intéressant de la prospérité et de la prospérité » 

Au début, je pensais qu’une protestation avait pu avoir lieu la même année par coïncidence mais regardez ceci : ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Entraîné à l’aide d’un échantillon de 15 Go provenant du jeu de données de 90 Go de v2.

Modèle entraîné uniquement jusqu'à 10 000 étapes.

Il y a eu un problème de tokenisation qui fait que la sortie ressemble à ceci :

INVITE :
Qui est Charles Dickens ?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Corrigé :

« Qui est Charles Dickens ? Est-ce que cela fonctionne davantage de son excellente agitation, dans ses pièces, à la ferme de la Great Company ? Que dois-je encore citer de Jack Pickett ? Ne savez-vous pas qu'ils étaient une sorte de galop, ou de sciage de leur poitrine, ou que fallait-il faire à l'époque où Jackson regardait par la fenêtre ? Quel est le succès d'un Anglais, et que son fils ne m'a pas encore révélé, afin d'accomplir un tel poids ? Avez-vous déjà fait un passage sur l'ancienne chaussée, ou vers une brise d'ancre au pied de notre bateau, que vous devez nous quitter ? Le fait est que, que le vent se lève de la plaine le samedi soir ou à midi, ou vers le nord, ou autrement, nous serons obligés de décrire une barrière redoutable, avec les mêmes effets que ceux du présent. Dans cette situation, du moins, il n'est pas exagéré de dire que nous avons quitté cette pièce. Je crois qu'il y a trois exemplaires dans le « Cinq-Cents fois », à consulter, en tant que premier nombre de nos lecteurs qui souhaitent t[...]... »

### **v2mini-eval2**

Entraîné avec le même échantillon de 15 Go utilisé pour l’entraînement de eval1.
Le modèle est de nouveau entraîné sur seulement 10 000 étapes.

PROMPT : Charles Darwin

Charles DarwinECCEMACY. Monsieur, — Le cas suivant m’intéresse : — J’étais à Londres pendant quinze jours, et j’ai été fortement affecté par une attaque de rhumatisme. La première attaque de rhumatisme a eu lieu une semaine avant que je vous voie, la deuxième quand je vous ai vu, la troisième quand je vous ai vu, et la troisième en même temps. La deuxième attaque de goutte, cependant, n’était pas accompagnée de symptômes fébriles, mais d’une augmentation du flux urinaire, et d’une évacuation urinaire plus abondante. La troisième attaque a eu lieu une heure après que je vous ai vu, et a été suivie d’un retour du paroxysme de goutte, et d’un retour plus rapide de la goutte. La quatrième attaque était également accompagnée de fièvre, mais n’était pas toujours accompagnée de symptômes fébriles. La troisième attaque de goutte a eu lieu quinze jours après que vous avez été malade, et la quatrième a été suivie d’un paroxysme de goutte. La quatrième attaque est survenue quinze jours après que vous avez été attaqué, et était accompagnée d’une sensation


##  Jeux de données

### **v2**

- 90 Go de textes londoniens de 1800 à 1875
- 136 344 documents
- Les 90 Go complets ne sont pas encore disponibles car ils n’ont pas encore été tokenisés, mais vous pouvez trouver un échantillon de 15 Go ici : https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Statistiques sur les biais
  ![Biais de pronom](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Biais géographique](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Biais temporel](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Référez-vous au [rapport sur les biais v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) pour plus d’informations.


## Comment utiliser

Ce projet se concentre principalement sur la collecte de données historiques, leur préparation pour l’entraînement et la construction d’un tokenizer. Je ne vais pas couvrir tout le processus d’entraînement LLM, pour cela, référez-vous à nanoGPT par Andrej Karpathy.

### Étape 1 : Rassembler et préparer des textes historiques

- Collectez des fichiers .txt de livres du domaine public, de documents, etc. de votre période choisie (par exemple, Londres 1800-1850)
- Gardez-les dans la fenêtre temporelle/lieu que vous avez choisie  
- Nettoyez les fichiers texte à l’aide d’un script ou retirez manuellement les en-têtes/pieds de page de Project Gutenberg, les annotations modernes ou les erreurs OCR.

### Étape 2 : Construire un tokenizer personnalisé

- Exécutez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
- Cela vous donnera vocab.json et merges.txt
- Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

### Étape 3 : Entraînez votre modèle 

- Reportez-vous à [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d’entraînement ou la documentation de l’architecture choisie.

# FAQ

## Qu’est-ce que l’entraînement temporel sélectif ?

L’entraînement temporel sélectif (Selective Temporal Training, STT) est une méthodologie d’apprentissage automatique où toutes les données d’entraînement sont soigneusement sélectionnées pour appartenir à une période historique spécifique. Cela permet de modéliser la langue et les connaissances de cette époque sans influence des concepts modernes. Par exemple, le modèle actuel que je possède (v0.5) est entraîné exclusivement sur des données de 1800 à 1875, il n’est pas ajusté mais entraîné depuis zéro, ce qui donne une sortie reflétant le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?

Pour ce projet, j’essaie de créer un modèle de langage non biaisé par la modernité. Si je fais du fine-tuning sur GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j’entraîne à partir de zéro, le modèle de langage ne fera pas semblant d’être ancien, il le sera réellement. L’objectif pour ce projet est de créer quelque chose qui puisse raisonner exclusivement à partir de connaissances tirées de livres londoniens publiés entre 1800 et 1875.

## Quel type de données avez-vous utilisé pour l’entraînement ?

J’utilise des livres, documents juridiques, journaux et autres écrits de Londres entre 1800 et 1875. La liste que j’ai partagée (pour v0) en contient environ 200, mais pour le premier entraînement, j’ai utilisé seulement 50 fichiers pour environ ~187 Mo. Vous pouvez consulter la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Taille des ensembles de données :
- v0 : ~187 Mo
- v0.5 : ~435 Mo 
- v1 : ~6,25 Go 
- v2mini-eval1 : 15 Go

## Quelle est la taille des modèles ?

v0 : 16M de paramètres

v0.5 123M de paramètres

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---