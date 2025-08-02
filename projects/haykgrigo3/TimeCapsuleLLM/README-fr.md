
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

Imaginez si un modèle d'IA ne se contentait pas de faire semblant d'être historique, mais l'était réellement.

Basé sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) Les scripts d'entraînement principaux et l'architecture du modèle sont de lui.

# Objectifs du projet

TimeCapsule LLM est un projet expérimental qui ne sera entraîné que sur des textes écrits durant certaines périodes. L'objectif est de simuler la vision du monde et la langue d'époques historiques spécifiques.

# Pourquoi l'affinage n'est pas suffisant

Si vous vous contentez d'affiner un modèle pré-entraîné, votre LLM connaîtra encore des concepts modernes. Bien sûr, atteindre un biais moderne nul est difficile, mais je veux m'en approcher le plus possible. Obtenir un modèle sans biais moderne nécessite un entraînement depuis zéro.

# Résultats attendus

J'espère que, une fois terminé, ce modèle n'aura pas connaissance des concepts modernes et ne sera pas capable de raisonner au-delà de ce sur quoi il a été entraîné. Il ne devrait pas reconnaître les concepts/vocabulaire modernes et j'espère qu'il n'hallucinera pas de connaissances modernes.

# Mises à jour de l'avancement

## 9 juillet 2025

J'ai défini ma période à 1800-1850 et la région : Londres

J'ai rassemblé une liste de textes, livres, documents

Jusqu'à présent, j'en ai obtenu 50 sous forme de fichiers txt et je vais bientôt commencer l'entraînement de NanoGPT

Je mettrai à jour ceci tant que des progrès seront réalisés

## 13 juillet 2025

NanoGPT entraîné avec 187 Mo de données textuelles historiques.

## 15 juillet 2025

J'ai commencé à télécharger des textes pour la seconde session d'entraînement. Je prends tout sur Internet Archive et j'ai élargi la période à 1800-1875. Pour obtenir une gamme diversifiée de textes, vous pouvez utiliser les filtres de sujet et de recherche sur Internet Archive selon le lieu de publication, la période et les sujets.

![Filtres de recherche](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juillet 2025

J'ai téléchargé environ 500 fichiers txt depuis Internet Archive et après les avoir nettoyés (juste suppression des espaces, en-têtes Gutenberg, etc.) j'ai environ 500 Mo de données. C'est un petit jeu de données mais la dernière fois j'ai entraîné sur 187 Mo donc il devrait y avoir au moins une différence notable dans la sortie après l'entraînement du second modèle. J'espère que ce modèle pourra au moins produire des phrases plus cohérentes qui ont un certain sens. Ce n'est bien sûr pas garanti puisque c'est encore un tout petit jeu de données, mais c'est plus que ce que j'avais utilisé la dernière fois.

Cela devrait être faisable sur mon propre matériel, c'est aussi bien car je pourrai voir, je l'espère, des améliorations avant de passer à un plus grand jeu de données qui nécessiterait de louer un GPU. Mais ne vous inquiétez pas, je prévois toujours de louer un GPU bientôt, mais avant cela, je veux m'assurer que mon jeu de données est aussi bien sélectionné et propre que possible. L'un des problèmes que j'ai est le nettoyage, beaucoup de ces fichiers txt contiennent du charabia mélangé. Les scripts que j'ai utilisés pour le nettoyage fonctionnent mais ne sont pas efficaces à 100 %.

Je vais entraîner ce jeu de données aujourd'hui et cela devrait prendre environ 4 à 5 heures. Une fois terminé et testé, je donnerai des nouvelles. Merci encore à tous ceux qui consultent mon projet, certains m'ont même envoyé des liens vers des ressources OCR alors merci ! J'espère que plus de gens essaieront cela et expérimenteront avec leurs propres jeux de données.


### Mise à jour de l'entraînement

J'ai commencé l'entraînement sur un corpus de 435 Mo (108 M de tokens), ça se passe plutôt bien pour l'instant. La perte d'entraînement est passée de 10,9 à 4,9 lors des 2800 premières itérations. Je pense que cela prendra environ 8 ou 9 heures pour se terminer. Je posterai une autre mise à jour une fois que ce sera fait.

## 17 juillet 2025 2:13AM

L'entraînement du second modèle est terminé, cela a pris environ 8 heures et 40 minutes à mon 4060 (3 900 iters/h) pour 33 000 itérations (5 époques). La perte d'entraînement finale était de 3,73. Les sorties étaient étonnamment bonnes, il génère maintenant vraiment des phrases de style XIXe siècle cohérentes.

## 28 juillet 2025

J'ai uploadé la v0.5 sur Hugging Face, [Regardez ici](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si vous voulez. Vous pouvez maintenant télécharger mon repo et l'exécuter localement. Malheureusement nanoGPT ne fonctionne pas nativement avec HuggingFace, donc vous devrez télécharger et exécuter le modèle localement.

Je vais également commencer à sélectionner les données pour mon prochain entraînement, je pense qu'il me faudra peut-être 5 à 10 fois plus de données pour atteindre des capacités de raisonnement.


# Comportement et limitations du modèle V0

Les premiers prompts montrent le modèle répondant avec la langue et le comportement des années 1800. Par exemple, je lui ai demandé "Who art Henry?" et il a répondu "I know that man, I have did not a black, the storm." et oui, cette phrase n'a aucun sens mais le LLM reconnaît que je demande à propos d'une personne.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Aucune mention de concepts modernes, les sorties contiennent principalement des mots et des formulations du XIXe siècle.

Il reste encore beaucoup de travail, s’entraîner sur 187 Mo ne permet pas d’obtenir un modèle capable de produire un texte avec un raisonnement complexe.

Actuellement, il produit des phrases qui manquent de structure complète et globalement n’ont aucun sens, mais c’est normal compte tenu de la taille de l’entraînement.

# Comportement et limitations du modèle V0.5

C’est une belle amélioration par rapport au dernier modèle. Le style d’écriture et le vocabulaire sont victoriens et presque chaque phrase est grammaticalement correcte avec une ponctuation appropriée. Et encore une fois, ce modèle est entraîné à partir de zéro donc il reste sur des sujets du XIXe siècle.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Il y a beaucoup d’hallucinations factuelles. Beaucoup (pratiquement 100 %) des détails (dates, événements, personnages historiques) sont inventés. De plus, les phrases n’ont pas vraiment de liens entre elles, parfois 2 phrases peuvent être liées mais pas au-delà. Un autre problème est qu’il arrive qu’un pied de page « Digitized by Google » apparaisse, donc la prochaine fois que j’entraîne, je dois vraiment m’assurer que les textes sont bien nettoyés. Globalement, je suis très content des résultats, on est loin d’un LLM mais c’est définitivement un générateur de phrases.

J’apprends beaucoup et je vais commencer à identifier ce que je dois améliorer dans les semaines à venir. Je mettrai bientôt les fichiers en ligne !

# Projets à venir

(Terminé) Je vais commencer à travailler sur la version 0.5, au lieu d’entraîner sur 50 livres, j’entraînerai idéalement sur 500-600. Actuellement, j’entraîne nanoGPT en utilisant des livres de 1800-1850, spécifiquement de Londres. Il y a quelques défis comme s’assurer que les livres trouvés ne sont pas modernisés ou interprétés, mais bien des livres intacts publiés dans la période choisie.

Je veux entraîner un nouveau modèle (v1) avec un corpus beaucoup plus large, peut-être 5 à 10 fois plus grand que celui utilisé pour v0.5. Mon objectif est de voir si des capacités de raisonnement peuvent émerger grâce au Selective Temporal Training seul, ce qui sera plus difficile et je ne suis même pas sûr que ce soit possible à cause des limitations de données historiques. Dans les semaines à venir, je vais essayer de réunir assez de données pour un corpus de 5 à 10 Go. Je crois qu’avec des données propres et de haute qualité et en louant un GPU, il y aura des progrès.

# Comment utiliser ce projet

Ce projet se concentre surtout sur la curation de données historiques, leur préparation pour l’entraînement et la création d’un tokenizer. Je ne couvrirai pas tout le processus d’entraînement d’un LLM, pour cela référez-vous à nanoGPT d’Andrej Karpathy.

# Étape 1 : Rassembler et préparer les textes historiques

Collectez des fichiers .txt de livres, documents, etc. du domaine public de la période choisie (par ex. Londres 1800-1850)

Vous pouvez utiliser download_texts_improved.py pour télécharger des livres si besoin.

Nettoyez les fichiers texte à l’aide d’un script ou manuellement pour retirer les en-têtes/pieds de page de Project Gutenberg, annotations modernes ou erreurs d’OCR.

prepare_dataset.py devrait fonctionner correctement.

# Étape 2 : Construire un tokenizer personnalisé

Lancez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
Cela vous donnera vocab.json et merges.txt

Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

# Étape 3 : Entraînez votre modèle (nanoGPT)

Référez-vous à [nanoGPT d’Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d’entraînement.

Vous pouvez entraîner un autre LLM si vous le souhaitez, mais j’ai utilisé nanoGPT

# FAQ

## Qu’est-ce que le Selective Temporal Training ?

Le Selective Temporal Training (STT) est une méthodologie d’apprentissage automatique où toutes les données d’entraînement sont spécifiquement sélectionnées pour appartenir à une période historique précise. Cela permet de modéliser la langue et les connaissances de cette époque sans influence de concepts modernes. Par exemple, le modèle actuel (v0.5) est entraîné uniquement sur des données de 1800-1875, il n’est pas affiné mais entraîné à partir de zéro, ce qui donne une sortie reflétant le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?

Pour ce projet, j’essaie de créer un modèle de langue non biaisé par la modernité. Si je fais du fine-tuning sur quelque chose comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j’entraîne à partir de zéro, le modèle ne fera pas semblant d’être ancien, il le sera vraiment. L’objectif de ce projet actuellement est de créer quelque chose qui puisse raisonner exclusivement avec les connaissances issues de livres londoniens publiés entre 1800 et 1850.

## Quel type de données as-tu utilisé pour l’entraînement ?

J’utilise des livres, documents juridiques, journaux et autres écrits de Londres 1800–1850. La liste que j’ai partagée contient environ 200 documents, mais pour le premier entraînement je n’ai utilisé que 50 fichiers d’environ ~187 Mo. Vous pouvez consulter la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quelle est la taille du modèle Version 0 ?

Ce modèle est très petit pour l’instant, je fais ça pour le plaisir et je respecte la règle stricte de n’utiliser aucune source moderne. Il a près de 16 millions de paramètres mais je vais commencer à rassembler plus de vieux textes pour débuter un nouvel entraînement. Je donnerai des nouvelles au fur et à mesure.

## Spécifications d’entraînement ?

GPU : Geforce RTX 4060
CPU : i5-13400F
Ram : 16 Go DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---