
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

[Lien Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Comportement du Modèle & Limitations

### **v0**  

Les premiers prompts montrent que le modèle répond avec le langage et le comportement des années 1800.  
Exemple : Prompt : "Who art Henry?" et il a répondu "I know that man, I have did not a black, the storm." 

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Aucune mention de concepts modernes  
- Vocabulaire principalement fidèle à l'époque  
- Les phrases sont majoritairement incohérentes (attendu pour un jeu de données d'environ 187 Mo)

### **v0.5** 

Une amélioration significative par rapport à v0.  
- Style d'écriture victorien, ponctuation correcte, phrases généralement grammaticales  
- Taux élevé d'hallucinations factuelles persistant  
- Bruit OCR (« Digitized by Google ») toujours présent dans les sorties

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Premier modèle à rappeler et relier un événement historique réel à une figure réelle du jeu de données.

Exemple : Prompt : "It was the year of our Lord 1834" 

La sortie : "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Au début, j'ai supposé qu'une protestation avait pu avoir lieu par coïncidence la même année, mais regardez ceci : ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Pourquoi c'est important :

C'est le premier exemple d'un de mes modèles reliant une année à la fois à un événement historique réel et à une personne réelle liée à cet événement (Lord Palmerston). Les versions précédentes (v0 et v0.5) pouvaient imiter les styles d'écriture du XIXe siècle mais hallucinaient systématiquement les événements, personnes et faits. Cela montre que le modèle commence à se souvenir d'éléments du jeu de données.

## Plans à venir 

- Il y a près de 175 000 textes publiés à Londres entre 1800 et 1875 sur Internet Archive 
- Je prévois d’élargir le corpus et de le nettoyer davantage pour améliorer les capacités de raisonnement
- Extension vers différentes régions et périodes pour des modèles plus historiques


## Comment utiliser

Ce projet porte principalement sur la curation de données historiques, leur préparation pour l’entraînement et la construction d’un tokenizer. Je ne vais pas couvrir le processus complet d’entraînement d’un LLM, pour cela référez-vous à nanoGPT par Andrej Karpathy.

### Étape 1 : Rassembler et préparer les textes historiques 

- Collectez des fichiers .txt de livres, documents, etc du domaine public issus de votre période choisie (ex : Londres 1800-1850) 
- Gardez-les dans la fenêtre de temps/lieu choisie  
- Nettoyez les fichiers texte en utilisant un script ou retirez manuellement les en-têtes/pieds de page de Project Gutenberg, les annotations modernes ou des erreurs OCR.

### Étape 2 : Construire un tokenizer personnalisé

- Exécutez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
- Cela vous donnera vocab.json et merges.txt
- Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

### Étape 3 : Entraîner votre modèle 

- Référez-vous à [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d’entraînement ou la documentation de l’architecture de votre choix.

# FAQ

## Qu’est-ce que l’Entraînement Temporel Sélectif ?

L’Entraînement Temporel Sélectif (ETS) est une méthodologie d’apprentissage automatique où toutes les données d’entraînement sont soigneusement sélectionnées pour appartenir à une période historique spécifique. Cela permet de modéliser la langue et le savoir de cette époque sans influence des concepts modernes. Par exemple, le modèle actuel (v0.5) est entraîné exclusivement sur des données de 1800 à 1875 ; il n’est pas simplement affiné mais entraîné depuis zéro, ce qui donne une sortie reflétant le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas utiliser simplement le fine-tuning ou LoRA ?

Pour ce projet, j’essaie de créer un modèle de langue non biaisé par la modernité. Si je fais un fine-tuning sur quelque chose comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si je l’entraîne depuis zéro, le modèle de langue ne fera pas semblant d’être ancien, il le sera vraiment. L’objectif actuel est de créer quelque chose qui puisse raisonner exclusivement à partir des connaissances des livres londoniens publiés entre 1800 et 1875.

## Quel type de données avez-vous utilisé pour l’entraînement ?

J'utilise des livres, des documents juridiques, des journaux et d'autres écrits provenant de Londres entre 1800 et 1875. La liste que j'ai liée (pour v0) en contient environ 200, mais pour le premier entraînement, j'ai seulement utilisé 50 fichiers pour environ ~187 Mo. Vous pouvez consulter la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tailles des jeux de données :
v0 : ~187Mo
v0.5 : ~435Mo
v1 : ~6,25Go

## Quelle est la taille des modèles ?

V0 : 16M Paramètres

V0.5 123M Paramètres

V1 : 700M Paramètres

# Spécifications d'entraînement ?

# V0/V0.5
GPU : Geforce rtx 4060
CPU : i5-13400F
Ram : 16Go DDR5.

# V1
GPU : A100 louée















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---