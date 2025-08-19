
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (à venir)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (à venir)</a> |
        | <a href="#" title="Coming soon">ไทย (à venir)</a> |
        | <a href="#" title="Coming soon">Français (à venir)</a>
        | <a href="#" title="Coming soon">Deutsch (à venir)</a>
        | <a href="#" title="Coming soon">Español (à venir)</a>
        | <a href="#" title="Coming soon">Italiano (à venir)</a>
        | <a href="#" title="Coming soon">Русский (à venir)</a>
        | <a href="#" title="Coming soon">Português (à venir)</a>
        | <a href="#" title="Coming soon">Nederlands (à venir)</a>
        | <a href="#" title="Coming soon">Polski (à venir)</a>
        | <a href="#" title="Coming soon">العربية (à venir)</a>
        | <a href="#" title="Coming soon">فارسی (à venir)</a>
        | <a href="#" title="Coming soon">Türkçe (à venir)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (à venir)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (à venir)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*Un modèle linguistique entraîné **depuis zéro** exclusivement sur des données provenant de certains lieux et périodes afin de réduire les biais modernes et d’émuler la voix, le vocabulaire et la vision du monde de l’époque.*

Imaginez si un modèle d’IA n’essayait pas seulement d’être historique, mais l’était réellement.

v0 et v0.5 construits sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) Les scripts d'entraînement principaux et l'architecture du modèle sont son œuvre. 

v1 construit sur [Phi 1.5 par Microsoft](https://huggingface.co/microsoft/phi-1_5)

##  Comportement du modèle & Limitations

### **v0**  

Les premiers prompts montrent le modèle répondant avec un langage et un comportement du XIXe siècle.  
Exemple : Prompt : "Who art Henry ?" et il a répondu "Je connais cet homme, je n'ai pas fait de noir, la tempête."

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Aucune mention de concepts modernes  
- Vocabulaire majoritairement fidèle à l'époque  
- Phrases généralement incohérentes (attendu pour ~187 Mo de données d'entraînement)

### **v0.5** 

Amélioration significative par rapport à v0.  
- Style d'écriture victorien, ponctuation correcte, phrases majoritairement grammaticales  
- Taux élevé de hallucinations factuelles  
- Bruit OCR ("Digitized by Google") encore présent dans les sorties

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Premier modèle à rappeler et relier un événement historique réel à une figure réelle du jeu de données.

Exemple : Prompt : "It was the year of our Lord 1834"

La sortie : "C'était l'année de notre Seigneur 1834 et les rues de Londres étaient remplies de protestations et de pétitions. La cause, comme beaucoup l'ont raconté, n'était pas liée au privé, mais ayant pris le même jour dans le jour de Lord Palmerston, le public recevra une brève déclaration des difficultés auxquelles le jour de la loi nous a conduits. Il est profondément regrettable que les événements actuels de l'histoire du monde soient clairs, et par conséquent seront connus. Il n'est pas vrai que les tout premiers hommes qui se sont installés dans l'Évangile à Jérusalem devraient avoir un dossier aussi vaste et aussi intéressant de la prospérité et de la prospérité."

Au début, j'ai supposé qu'une protestation avait pu avoir lieu la même année par hasard, mais regardez ceci : ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Pourquoi c'est important :

C'est le premier exemple d'un de mes modèles reliant une année à la fois à un événement historique réel et à une personne réelle associée à cet événement (Lord Palmerston). Les modèles précédents (v0 et v0.5) savaient imiter les styles d'écriture du XIXe siècle mais hallucinaient toujours les événements, les personnes et les faits. Cela montre que le modèle commence à se souvenir des éléments du jeu de données.

## Plans à venir

- Il y a près de 175 000 textes publiés à Londres de 1800 à 1875 sur Internet Archive 
- Je prévois d’étendre le corpus et de le nettoyer davantage pour améliorer les capacités de raisonnement
- Extension à différentes régions et périodes pour des modèles historiques plus variés


## Comment utiliser

Ce projet se concentre principalement sur la curation de données historiques, leur préparation pour l’entraînement et la création d’un tokenizer. Je ne vais pas couvrir tout le processus d’entraînement d’un LLM ; pour cela, référez-vous à nanoGPT d’Andrej Karpathy.

### Étape 1 : Collecter et préparer des textes historiques 

- Rassemblez des fichiers .txt de livres, documents, etc. du domaine public de la période choisie (ex. : Londres 1800-1850) 
- Gardez-les dans votre fenêtre de temps/lieu choisie  
- Nettoyez les fichiers texte à l’aide d’un script ou retirez manuellement les en-têtes/pieds de page de Project Gutenberg, les annotations modernes ou les erreurs OCR.

### Étape 2 : Construire un tokenizer personnalisé

- Exécutez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
- Cela vous donnera vocab.json et merges.txt
- Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

### Étape 3 : Entraîner votre modèle 

- Référez-vous à [nanoGPT d’Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d’entraînement ou aux documents de l’architecture que vous avez choisie.

# FAQ

## Qu’est-ce que l’entraînement temporel sélectif ?

L’entraînement temporel sélectif (STT) est une méthodologie d’apprentissage automatique où toutes les données d’entraînement sont spécifiquement sélectionnées pour appartenir à une période historique définie. Cela permet de modéliser la langue et les connaissances de cette époque sans influence de concepts modernes. Par exemple, le modèle actuel (v0.5) est entraîné uniquement sur des données de 1800 à 1875 ; il n’est pas affiné mais entraîné depuis zéro, ce qui donne un résultat qui reflète le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?

Pour ce projet, je cherche à créer un modèle linguistique non biaisé par la modernité. Si je fais du fine-tuning sur un modèle comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j’entraîne un modèle depuis zéro, il ne fera pas semblant d’être ancien, il le sera véritablement. L’objectif ici est de créer un modèle capable de raisonner exclusivement à partir des connaissances des livres londoniens publiés entre 1800 et 1875.

## Quel type de données avez-vous utilisé pour l’entraînement ?

J’utilise des livres, des documents juridiques, des journaux et autres écrits de Londres entre 1800 et 1875. La liste que j’ai partagée (pour v0) en compte environ 200, mais pour le premier entraînement j’ai juste utilisé 50 fichiers pour environ 187 Mo. Vous pouvez consulter la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt


Tailles des ensembles de données :
v0 : ~187 Mo
v0.5 : ~435 Mo 
v1 : ~6,25 Go 

## Quelle est la taille des modèles ?

V0 : 16M paramètres

V0.5 : 123M paramètres

V1 : 700M paramètres

# Spécifications d'entraînement ?

# V0/V0.5
GPU : Geforce RTX 4060
CPU : i5-13400F 
RAM : 16 Go DDR5.

# V1
GPU : A100 louée














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---