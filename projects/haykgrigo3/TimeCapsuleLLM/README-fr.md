
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
Un LLM entraîné uniquement sur des données provenant de certaines périodes pour réduire le biais moderne.

Imaginez si un modèle d’IA ne faisait pas que prétendre être historique mais l’était réellement.

Basé sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) Les scripts principaux d’entraînement et l’architecture du modèle sont son œuvre. 

# Objectifs du projet

TimeCapsule LLM est un projet expérimental qui ne sera entraîné que sur des textes écrits pendant certaines périodes historiques. L’objectif est de simuler la vision du monde et la langue d’époques spécifiques.

# Pourquoi l’affinage ne suffit pas

Si vous ne faites qu’affiner un modèle pré-entraîné, votre LLM connaîtra tout de même des concepts modernes. Bien sûr, atteindre zéro biais moderne est difficile mais je veux m’en approcher le plus possible. Éliminer tout biais moderne nécessite d’entraîner un modèle à partir de zéro.

# Résultats attendus

J’espère qu’une fois terminé, ce modèle ne connaîtra pas les concepts modernes et ne pourra pas raisonner au-delà de ce sur quoi il a été entraîné. Il ne devrait pas reconnaître les concepts/vocabulaire modernes et j’espère qu’il n’hallucinera pas de connaissances modernes.

# Mises à jour de progression

## 9 juillet 2025

J’ai choisi ma période : 1800-1850 et la région : Londres

J’ai rassemblé une liste de textes, livres, documents

Pour l’instant j’en ai obtenu 50 en fichiers txt et je vais bientôt commencer l’entraînement sur NanoGPT

Je mettrai à jour ceci tant que des progrès seront réalisés

## 13 juillet 2025

Entraînement de nanoGPT avec 187 Mo de textes historiques.

## 15 juillet 2025

J’ai commencé à télécharger des textes pour la seconde session d’entraînement. Je prends tout depuis Internet Archive et j’ai élargi la période à 1800-1875. Pour obtenir une gamme diversifiée de textes, on peut utiliser les filtres de sujet et de recherche pour le lieu de publication, la période et les sujets sur Internet Archive.

![Filtres de recherche](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juillet 2025

J’ai téléchargé environ 500 fichiers txt depuis Internet Archive et après nettoyage (suppression des espaces, en-têtes Gutenberg, etc.) j’ai environ 500 Mo de données. C’est un petit jeu de données mais la dernière fois j’ai entraîné sur 187 Mo donc il devrait y avoir une différence au moins perceptible dans la sortie après l’entraînement du second modèle. J’espère que ce modèle pourra au moins produire des phrases plus cohérentes qui ont du sens. Ce n’est pas garanti bien sûr puisque le jeu de données reste très petit, mais c’est plus que la fois précédente.

Cela devrait être faisable sur mon propre matériel, c’est bien aussi car j’espère voir une amélioration avant de passer à un jeu de données plus grand qui nécessiterait de louer un GPU. Mais ne vous inquiétez pas je prévois toujours d’en louer un bientôt, mais avant ça je veux m’assurer que mon jeu de données est le plus soigné et propre possible. Un des problèmes que j’ai c’est le nettoyage, beaucoup de ces fichiers txt contiennent du charabia. Les scripts que j’ai utilisés pour nettoyer fonctionnent mais ne sont pas efficaces à 100 %.

Je vais entraîner ce jeu de données aujourd’hui et cela devrait prendre environ 4 à 5 heures. Une fois terminé et testé, je donnerai des nouvelles. Merci encore à tous ceux qui suivent mon projet, j’ai même eu des gens qui m’ont envoyé des liens vers des ressources OCR alors merci ! J’espère que davantage de personnes essaieront et expérimenteront avec leurs propres jeux de données.

## 28 juillet 2025

J’ai mis en ligne la version v0.5 sur Hugging Face, [jetez-y un œil](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si vous le souhaitez. Vous pouvez maintenant télécharger mon dépôt et l’exécuter localement. Malheureusement, nanoGPT ne fonctionne pas nativement avec HuggingFace, donc il faudra télécharger et exécuter le modèle localement.

Je vais aussi commencer à sélectionner des données pour la prochaine session d’entraînement, je pense qu’il me faudra peut-être 5 à 10 fois plus de données pour atteindre des capacités de raisonnement.

### Mise à jour sur l’entraînement

J’ai commencé l’entraînement sur un corpus de 435 Mo (108 M de tokens), tout se passe bien pour l’instant. La perte d’entraînement est passée de 10,9 à 4,9 lors des 2800 premières itérations. Je pense qu’il faudra environ 8 ou 9 heures pour terminer. Je posterai une autre mise à jour une fois fini.

## 17 juillet 2025 2:13AM

L’entraînement du second modèle est terminé, mon 4060 a mis environ 8 heures et 40 minutes (3 900 itérations/heure) pour 33 000 itérations (5 époques). La perte finale d’entraînement était de 3,73. Les résultats étaient étonnamment bons, il génère vraiment maintenant des phrases cohérentes au style du XIXe siècle.

# Comportement & limitations du modèle V0

Les premiers prompts montrent que le modèle répond avec le langage et le comportement des années 1800. Par exemple, je lui ai demandé « Who art Henry? » et il a répondu « I know that man, I have did not a black, the storm. » et oui cette phrase n’a pas de sens mais le LLM reconnaît que je demande à propos d’une personne.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Il n'y a aucune mention de concepts modernes, les sorties contiennent principalement des mots et des formulations du XIXe siècle.

Il reste encore beaucoup de travail à faire, s'entraîner sur 187 Mo ne vous donnera pas un modèle produisant un texte avec un raisonnement complexe.

Actuellement, il produit des phrases qui manquent de structure complète et, dans l'ensemble, n'ont aucun sens, mais c'est normal pour cette taille de données d'entraînement.

# Comportement et limitations du modèle V0.5

C'est une belle amélioration par rapport au dernier modèle. Le style d'écriture et le vocabulaire sont victoriens et presque chaque phrase est grammaticalement correcte avec une ponctuation appropriée. Et encore une fois, ce modèle est entraîné à partir de zéro, donc il s'en tient aux sujets des années 1800.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Il y a beaucoup d'hallucinations factuelles. Beaucoup (comme 100%) des détails (dates, événements, personnages historiques) sont inventés. De plus, les phrases n'ont pas vraiment de liens entre elles, parfois peut-être que 2 phrases se rapportent entre elles, mais pas au-delà. Un autre problème est qu'il arrive parfois qu'un pied de page “Digitized by Google” apparaisse, donc la prochaine fois que j'entraînerai, je devrai vraiment m'assurer que les textes sont bien nettoyés. Globalement, je suis très satisfait des résultats, ce n'est pas encore un LLM mais clairement un générateur de phrases.

J'apprends beaucoup et je vais commencer à déterminer ce que je dois améliorer dans les semaines à venir. Je vais bientôt téléverser les fichiers !

# Projets à venir

(Terminé) Je vais commencer à travailler sur la version 0.5, au lieu d'entraîner avec 50 livres, je vais entraîner idéalement avec 500-600. En ce moment, j'entraîne nanoGPT avec des livres de 1800-1850, spécifiquement de Londres. Il y a quelques défis comme s'assurer que les livres trouvés ne sont pas mis à jour ou avec des interprétations modernes, mais des livres intacts publiés dans ma période choisie.

Je veux entraîner un nouveau modèle (v1) avec un corpus beaucoup plus grand, peut-être 5 à 10 fois plus grand que celui utilisé pour v0.5. Mon objectif est de voir si je peux faire émerger des capacités de raisonnement grâce au Selective Temporal Training seul, ce sera une tâche plus difficile et je ne suis même pas sûr que ce soit possible à cause des limitations des données historiques. Dans les semaines à venir, j'essaierai de rassembler suffisamment de données pour un corpus de 5-10 Go. Je crois que si j'obtiens des données propres et de haute qualité et que je loue un GPU, il y aura des progrès.

# Comment utiliser ce projet

Ce projet se concentre principalement sur la curation de données historiques, leur préparation pour l'entraînement et la création d'un tokenizer. Je ne vais pas couvrir le processus complet d'entraînement LLM, pour cela référez-vous à nanoGPT par Andrej Karpathy.

# Étape 1 : Rassembler et préparer des textes historiques

Rassemblez des fichiers .txt de livres du domaine public, documents, etc. de votre période choisie (par ex. Londres 1800-1850)

Vous pouvez utiliser download_texts_improved.py pour télécharger des livres si besoin.

Nettoyez les fichiers texte à l'aide d'un script ou retirez manuellement les en-têtes/pieds de page de Project Gutenberg, les annotations modernes ou les erreurs OCR.

prepare_dataset.py devrait fonctionner correctement.

# Étape 2 : Construire un tokenizer personnalisé

Lancez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
Cela vous donnera vocab.json et merges.txt

Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

# Étape 3 : Entraînez votre modèle (nanoGPT)

Référez-vous à [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d'entraînement.

Vous pouvez entraîner un autre LLM si vous le souhaitez, mais j'ai utilisé nanoGPT

# FAQ

## Qu'est-ce que le Selective Temporal Training ?

Le Selective Temporal Training (STT) est une méthodologie d'apprentissage automatique où toutes les données d'entraînement sont précisément sélectionnées pour appartenir à une période historique spécifique. Cela permet de modéliser la langue et les connaissances de cette époque sans influence de concepts modernes. Par exemple, le modèle que j'ai actuellement (v0.5) est entraîné sur des données exclusivement de 1800-1875, il n'est pas affiné mais entraîné à partir de zéro, ce qui donne une sortie reflétant le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?

Pour ce projet, j'essaie de créer un modèle de langage sans biais moderne. Si j'affine quelque chose comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j'entraîne à partir de zéro, le modèle de langage ne fera pas semblant d'être ancien, il le sera simplement. Le but de ce projet, pour l'instant, est de créer quelque chose qui puisse raisonner uniquement à partir des connaissances issues de livres londoniens publiés entre 1800 et 1850.

## Quelles données avez-vous utilisées pour l'entraînement ?

J'utilise des livres, documents juridiques, journaux et autres écrits de Londres, 1800–1850. La liste que j'ai partagée en compte environ 200, mais pour le premier entraînement j'ai utilisé seulement 50 fichiers pour ~187 Mo. Vous pouvez voir une liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quelle est la taille du modèle Version 0 ?

Ce modèle est très petit pour l'instant, je fais cela pour le plaisir en suivant la règle stricte de n'utiliser aucune source moderne. Il a presque 16 millions de paramètres mais je vais commencer à rassembler plus de vieux textes pour commencer un autre entraînement. Je donnerai des nouvelles au fur et à mesure.

## Spécifications d'entraînement ?

GPU : Geforce rtx 4060
CPU : i5-13400F
Ram : 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---