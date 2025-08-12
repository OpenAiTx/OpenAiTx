<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (bientôt disponible)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (bientôt disponible)</a> |
        | <a href="#" title="Coming soon">ไทย (bientôt disponible)</a> |
        | <a href="#" title="Coming soon">Français (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Deutsch (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Español (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Italiano (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Русский (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Português (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Nederlands (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Polski (bientôt disponible)</a>
        | <a href="#" title="Coming soon">العربية (bientôt disponible)</a>
        | <a href="#" title="Coming soon">فارسی (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Türkçe (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (bientôt disponible)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (bientôt disponible)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Un LLM entraîné uniquement sur des données de certaines périodes pour réduire le biais moderne.

Imaginez si un modèle d’IA ne se contentait pas de faire semblant d’être historique, mais l’était réellement.

Basé sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) Les scripts d’entraînement principaux et l’architecture du modèle sont son travail.

# Objectifs du projet

TimeCapsule LLM est un projet expérimental qui ne sera entraîné que sur des textes écrits durant certaines périodes historiques. L'objectif est de simuler la vision du monde et le langage d'époques spécifiques.

# Pourquoi l’affinage ne suffit pas

Si vous vous contentez d’affiner un modèle pré-entraîné, votre LLM connaîtra toujours des concepts modernes. Bien sûr, atteindre zéro biais moderne est difficile mais je veux m’en rapprocher autant que possible. Pour éliminer tout biais moderne, il faut entraîner un modèle depuis zéro.

# Résultats attendus

Une fois terminé, ce modèle ne devrait pas connaître de concepts modernes et ne pourra pas raisonner au-delà de ce sur quoi il a été entraîné. Il ne devrait pas reconnaître de vocabulaire/concepts modernes et ne devrait pas halluciner de connaissances contemporaines.

# Mises à jour de l’avancement

## 9 juillet 2025

J’ai défini ma période : 1800-1850 et la région : Londres

J’ai rassemblé une liste de textes, livres, documents

Pour l’instant j’en ai récupéré 50 au format txt et je vais bientôt commencer l’entraînement avec NanoGPT

Je mettrai à jour ce fil tant que des progrès seront faits

## 13 juillet 2025

Entraîné nanoGPT avec 187 Mo de données textuelles historiques.

## 15 juillet 2025

J’ai commencé à télécharger des textes pour le deuxième entraînement. Je récupère tout sur Internet Archive et j’ai étendu la période à 1800-1875. Pour obtenir une diversité de textes, vous pouvez utiliser les filtres par sujet et par lieu de publication, période et thèmes sur Internet Archive.

![Filtres de recherche](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juillet 2025

J’ai téléchargé environ 500 fichiers txt sur Internet Archive et après nettoyage (juste suppression des espaces, en-têtes Gutenberg, etc.) j’ai environ 500 Mo de données. C’est un minuscule jeu de données mais la dernière fois j’ai entraîné sur 187 Mo donc il devrait y avoir au moins une différence notable dans la sortie après l’entraînement du second modèle. J’espère que ce modèle pourra au moins produire des phrases plus cohérentes qui ont un certain sens. Ce n’est pas garanti bien sûr car c’est toujours un très petit jeu de données, mais c’est plus que ce que j’ai utilisé précédemment.

Cela devrait être faisable sur mon propre matériel, c’est bien car je pourrai peut-être constater quelques améliorations avant de passer à un jeu de données plus grand qui nécessiterait de louer un GPU. Mais ne vous inquiétez pas, je prévois toujours de louer un GPU bientôt, mais avant cela je veux m’assurer que mon jeu de données est aussi bien sélectionné et propre que possible. L’un des problèmes que j’ai est le nettoyage, beaucoup de ces fichiers txt contiennent des caractères absurdes mélangés. Les scripts que j’utilise pour le nettoyage fonctionnent mais ne sont pas 100 % efficaces.

Je vais entraîner ce jeu de données aujourd’hui et cela devrait prendre environ 4-5 heures. Une fois terminé et testé, je donnerai des nouvelles. Merci encore à tous ceux qui suivent mon projet, j’ai même eu des personnes qui m’ont donné des liens vers des ressources OCR alors merci ! J’espère que plus de gens essaieront et expérimenteront avec leurs propres jeux de données.


## 12 août 2025

La version 1 est terminée, cette version utilise Phi 1.5 (700M paramètres) et est entraînée sur un jeu de données contenant près de 7000 textes. La principale amélioration de ce modèle est sa capacité à parfois référencer des noms réels et des événements historiques. Les versions 0 et 0.5 n’y parvenaient pas, lorsque je les sollicitais avec une phrase du type « En l’an 1821 », la sortie n’était que des hallucinations, des choses qui ne se sont jamais produites. Un exemple avec la version 1 :

Mon prompt : C’était l’an de grâce 1834,

La sortie : « C’était l’an de grâce 1834 et les rues de Londres étaient pleines de protestations et de pétitions. La cause, comme beaucoup l’ont raconté, n’était pas privée, mais ayant pris le même jour sous le jour de Lord Palmerston, le public recevra un court exposé des difficultés auxquelles le jour de la loi nous a conduits. Il est profondément regrettable que les événements présents dans l’histoire du monde soient clairs et seront donc connus. Il n’est pas vrai que les tout premiers installés de l’Évangile à Jérusalem devraient avoir un registre aussi vaste et intéressant de prospérité et de prospérité »

Au début j’ai pensé que c’était une coïncidence mais regardez ceci : ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Mise à jour de l’entraînement

J’ai commencé l’entraînement sur un corpus de 435 Mo (108 M de tokens), ça se passe plutôt bien pour l’instant. La perte d’entraînement est passée de 10,9 à 4,9 lors des 2800 premières itérations. Je pense que cela prendra environ 8 ou 9 heures pour terminer. Je publierai une autre mise à jour une fois terminé.

## 17 juillet 2025

L’entraînement du second modèle est terminé, mon 4060 a mis environ 8 heures et 40 minutes (3 900 itérations/h) pour 33 000 itérations (5 époques). La perte d’entraînement finale était de 3,73. Les sorties étaient étonnamment bonnes, il génère désormais de vraies phrases cohérentes dans le style du XIXe siècle.

## 28 juillet 2025

J’ai mis en ligne v0.5 sur Hugging Face, [Jetez-y un œil](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si vous voulez. Vous pouvez maintenant télécharger mon dépôt et l’exécuter localement. Malheureusement, nanoGPT ne fonctionne pas nativement avec HuggingFace, donc il faudra télécharger et exécuter le modèle en local.

Je vais aussi commencer à sélectionner des données pour mon prochain entraînement, je pense qu’il me faudra 5 à 10 fois plus de données pour atteindre des capacités de raisonnement.

## 2 août 2025

Je vais bientôt commencer à travailler sur la version 1. Je devrai passer de l’architecture de nanoGPT à quelque chose de plus moderne. J’ai plusieurs architectures LLM open-source en tête, dont : OpenLLaMA v3, Phi-2 et Qwen 1.5B. Et pour supporter le saut vers V1, il faudra que je sélectionne soigneusement un jeu de données beaucoup plus grand et diversifié. J’aurai besoin d’au moins 5 Go de données d’entraînement propres.

# Comportement et limitations du modèle V0

Les premiers prompts montrent que le modèle répond avec le langage et le comportement des années 1800. Par exemple, je lui ai demandé « Who art Henry? » et il a répondu « I know that man, I have did not a black, the storm. » et oui cette phrase n’a pas de sens mais le LLM reconnaît que je parle d’une personne.

![TimeLockLLM Exemple de sortie](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Il n’y a aucune mention de concepts modernes, les sorties contiennent principalement des mots et expressions du XIXe siècle.

Il reste encore beaucoup de travail, s’entraîner sur 187 Mo ne donnera pas un modèle capable de produire des textes avec un raisonnement complexe.


Actuellement, il produit des phrases qui manquent de structure complète et n'ont globalement aucun sens, mais cela est normal pour la taille d'entraînement.

# Comportement et limitations du modèle V0.5

C'est une belle amélioration par rapport au dernier modèle. Le style d'écriture et le vocabulaire sont victoriens et presque chaque phrase est grammaticalement correcte avec une ponctuation appropriée. Et encore une fois, ce modèle est entraîné à partir de zéro, donc il reste sur des sujets des années 1800.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Il y a beaucoup d’hallucinations factuelles. Beaucoup (comme 100%) des détails (dates, événements, personnages historiques) sont inventés. De plus, les phrases n’ont pas vraiment de liens entre elles, parfois peut-être 2 phrases se rapportent entre elles mais au-delà de ça non. Un autre problème est qu'il arrive qu’un pied de page “Digitized by Google” apparaisse, donc la prochaine fois que j’entraîne, je devrai vraiment m'assurer que les textes soient bien nettoyés. Globalement, je suis très satisfait des résultats, ce n'est pas encore un LLM mais c'est assurément un générateur de phrases.

J’apprends beaucoup et je vais commencer à déterminer ce que je dois améliorer dans les prochaines semaines. Je vais bientôt mettre les fichiers en ligne !

# Comportement et limitations du modèle V1

Je vais bientôt mettre en ligne des exemples de sorties et aussi faire des comparaisons entre les 3 modèles avec le même prompt. Je vais aussi uploader V1 sur huggingface comme je l’ai fait avec ma dernière version, vous pouvez trouver mon compte huggingface ici : https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Projets à venir

(Terminé) Je vais commencer à travailler sur la version 0.5, au lieu d'utiliser 50 livres pour l'entraînement, je vais idéalement en utiliser 500-600. Actuellement, j’entraîne nanoGPT en utilisant des livres de 1800-1850 et spécifiquement de Londres. Il y a quelques défis comme s’assurer que les livres que je trouve n’ont pas été mis à jour ou n’ont pas d’interprétations modernes, mais des livres intacts publiés pendant la période choisie.

Je veux entraîner un nouveau modèle (v1) avec un corpus beaucoup plus large, peut-être 5 à 10 fois plus grand que celui utilisé pour v0.5. Mon objectif est de voir si je peux faire émerger des capacités de raisonnement uniquement grâce à l’entraînement temporel sélectif, ce sera une tâche plus difficile et je ne suis même pas sûr que ce soit possible à cause des limitations des données historiques. Dans les semaines à venir, je vais essayer de réunir assez de données pour un corpus de 5 à 10 Go. Je pense que si j’arrive à obtenir des données propres et de haute qualité et louer un GPU, il y aura des progrès.

# Comment utiliser ce projet

Ce projet se concentre principalement sur la collecte de données historiques, leur préparation pour l’entraînement et la création d’un tokenizer. Je ne vais pas couvrir tout le processus d’entraînement LLM, pour cela référez-vous à nanoGPT par Andrej Karpathy.

# Étape 1 : Collecter et préparer des textes historiques

Rassemblez des fichiers .txt de livres du domaine public, documents, etc. de la période choisie (par exemple, Londres 1800-1850)

Vous pouvez utiliser download_texts_improved.py pour télécharger des livres si besoin.

Nettoyez les fichiers textes à l’aide d’un script ou retirez manuellement les en-têtes/pieds de page de Project Gutenberg, les annotations modernes ou les erreurs OCR.

prepare_dataset.py devrait fonctionner correctement.

# Étape 2 : Construire un tokenizer personnalisé

Lancez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
Cela vous donnera vocab.json et merges.txt

Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

# Étape 3 : Entraînez votre modèle (nanoGPT)

Reportez-vous à [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d'entraînement.

Vous pouvez entraîner un autre LLM si vous le souhaitez, mais j'ai utilisé nanoGPT

# FAQ

## Qu'est-ce que l'entraînement temporel sélectif ?

L'entraînement temporel sélectif (STT) est une méthodologie d'apprentissage automatique où toutes les données d'entraînement sont spécialement sélectionnées pour appartenir à une période historique spécifique. Cela permet de modéliser la langue et les connaissances de cette époque sans influence de concepts modernes. Par exemple, le modèle actuel que j'ai (v0.5) est entraîné exclusivement sur des données de 1800 à 1875, il n'est pas affiné mais entraîné depuis zéro, ce qui donne une sortie qui reflète le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?

Pour ce projet, j'essaie de créer un modèle de langue qui n'est pas biaisé par la modernité. Si j'affine un modèle comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j'entraîne le modèle depuis zéro, il ne fera pas semblant d'être ancien, il le sera vraiment. L'objectif de ce projet est de créer quelque chose qui puisse raisonner exclusivement avec les connaissances provenant de livres londoniens publiés entre 1800 et 1850.

## Quel type de données avez-vous utilisé pour l'entraînement ?

J'utilise des livres, des documents juridiques, des journaux et autres écrits de Londres entre 1800 et 1850. La liste que j'ai partagée contient environ 200 documents, mais pour le premier entraînement j'ai seulement utilisé 50 fichiers pour environ ~187 Mo. Vous pouvez consulter la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quelle est la taille des modèles ?

V0 : 16M paramètres

V0.5 : 123M paramètres

V1 : 700M paramètres

# Spécifications d'entraînement ?

#V0/V0.5
GPU : Geforce RTX 4060
CPU : i5-13400F
RAM : 16 Go DDR5.

#V1
GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---