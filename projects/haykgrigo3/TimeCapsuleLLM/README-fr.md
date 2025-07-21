<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (bientôt)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (bientôt)</a> |
        | <a href="#" title="Coming soon">ไทย (bientôt)</a> |
        | <a href="#" title="Coming soon">Français (bientôt)</a>
        | <a href="#" title="Coming soon">Deutsch (bientôt)</a>
        | <a href="#" title="Coming soon">Español (bientôt)</a>
        | <a href="#" title="Coming soon">Italiano (bientôt)</a>
        | <a href="#" title="Coming soon">Русский (bientôt)</a>
        | <a href="#" title="Coming soon">Português (bientôt)</a>
        | <a href="#" title="Coming soon">Nederlands (bientôt)</a>
        | <a href="#" title="Coming soon">Polski (bientôt)</a>
        | <a href="#" title="Coming soon">العربية (bientôt)</a>
        | <a href="#" title="Coming soon">فارسی (bientôt)</a>
        | <a href="#" title="Coming soon">Türkçe (bientôt)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (bientôt)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (bientôt)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Un LLM entraîné uniquement sur des données de certaines périodes pour réduire les biais modernes.

Imaginez si un modèle d’IA ne faisait pas que prétendre être historique, mais l’était réellement.

Basé sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT). Les scripts de base d’entraînement et l’architecture du modèle sont son travail.

# Objectifs du projet

TimeCapsule LLM est un projet expérimental qui ne sera entraîné que sur des textes écrits durant certaines périodes. L’objectif est de simuler la vision du monde et le langage d’époques historiques spécifiques.

# Pourquoi le fine tuning ne suffit pas

Si vous vous contentez d’affiner un modèle pré-entraîné, votre LLM connaîtra toujours des concepts modernes. Bien sûr, atteindre zéro biais moderne est difficile mais je veux m’en rapprocher autant que possible. Pour n’avoir aucun biais moderne, il faut entraîner un modèle depuis zéro.

# Résultats attendus

J’espère qu’une fois terminé, ce modèle ne connaîtra pas de concepts modernes et ne pourra pas raisonner au-delà de ce sur quoi il a été entraîné. Il ne devrait pas reconnaître les concepts/vocabulaire modernes et j’espère qu’il n’hallucinera pas de connaissances modernes.

# Mises à jour de progression

## 9 juillet 2025

J’ai défini ma période à 1800-1850 et la région : Londres

J’ai rassemblé une liste de textes, livres, documents

J’en ai récupéré 50 au format txt et je vais bientôt commencer l’entraînement de NanoGPT

Je mettrai à jour ceci tant que des progrès seront réalisés

## 13 juillet 2025

Entraîné nanoGPT avec 187 Mo de textes historiques.

## 15 juillet 2025

J’ai commencé à télécharger des textes pour la deuxième session d’entraînement. Je récupère tout depuis Internet Archive et j’ai élargi la période à 1800-1875. Pour obtenir une diversité de textes, vous pouvez utiliser les filtres de sujet et de recherche pour le lieu de publication, la période et les sujets sur Internet Archive.

![Filtres de recherche](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juillet 2025

J’ai téléchargé environ 500 fichiers txt depuis Internet Archive et après les avoir nettoyés (simplement en supprimant les espaces, en-têtes Gutenberg, etc), j’ai environ 500 Mo de données. C’est un tout petit jeu de données mais la dernière fois j’ai entraîné sur 187 Mo donc il devrait au moins y avoir une différence notable dans la sortie après avoir entraîné le second modèle. J’espère que ce modèle pourra au moins produire des phrases plus cohérentes qui ont un certain sens. Ce n’est bien sûr pas garanti puisque le jeu de données reste minuscule, mais c’est plus que la dernière fois.

C’est faisable sur mon propre matériel, c’est bien aussi car je pourrai, espérons-le, voir quelques améliorations avant de passer à un jeu de données plus gros qui m’obligerait à louer un GPU. Mais ne vous inquiétez pas, je compte toujours louer un GPU bientôt, mais avant cela je veux m’assurer que mon jeu de données est aussi sélectionné et propre que possible. L’un des problèmes que j’ai est le nettoyage, beaucoup de ces fichiers txt contiennent des caractères sans sens. Les scripts que j’ai utilisés pour nettoyer fonctionnent mais ne sont pas efficaces à 100%.

Je vais entraîner ce jeu de données aujourd’hui et cela devrait prendre environ 4-5 heures. Une fois terminé et testé, je donnerai des nouvelles. Merci encore à tous ceux qui consultent mon projet, j’ai même eu des gens qui m’ont envoyé des liens vers des ressources OCR donc merci ! J’espère que plus de gens essaieront et expérimenteront avec leurs propres jeux de données.

### Mise à jour entraînement

J’ai commencé l’entraînement sur un corpus de 435 Mo (108 M tokens), ça se passe plutôt bien pour l’instant. La perte d’entraînement est passée de 10.9 à 4.9 lors des 2800 premières itérations. Je pense que cela prendra environ 8 ou 9 heures pour compléter. Je posterai une autre mise à jour une fois terminé.

## 17 juillet 2025 2:13AM

L’entraînement est terminé pour le second modèle, mon 4060 a mis environ 8 heures et 40 minutes (3 900 itérations/h) pour 33 000 itérations (5 époques). La perte d’entraînement finale était de 3,73. Les résultats étaient étonnamment bons, il génère désormais réellement des phrases cohérentes dans le style du XIXe siècle.

# Comportement & Limites du modèle V0

Les premiers prompts montrent que le modèle répond avec le langage et le comportement des années 1800. Par exemple, je lui ai demandé "Who art Henry?" et il a répondu "I know that man, I have did not a black, the storm." et oui cette phrase n’a pas de sens mais le LLM reconnaît que je demande à propos d’une personne.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Il n’y a aucune mention de concepts modernes, les sorties contiennent principalement des mots et tournures des années 1800.

Il reste encore beaucoup à faire, s’entraîner sur 187 Mo ne donnera pas un modèle qui produit des textes avec un raisonnement complexe.

Pour l’instant il produit des phrases qui manquent de structure complète et globalement n’ont pas de sens, mais c’est normal pour cette taille d’entraînement.

# Comportement et limitations du modèle V0.5

Ceci représente une belle amélioration par rapport au modèle précédent. Le style d'écriture et le vocabulaire sont victoriens et presque chaque phrase est grammaticalement correcte avec la ponctuation appropriée. Encore une fois, il s'agit d'un entraînement depuis zéro donc il reste centré sur les sujets des années 1800.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Il y a beaucoup d'hallucinations factuelles. Beaucoup (comme 100%) des détails (dates, événements, personnages historiques) sont inventés. De plus, les phrases ne sont pas vraiment liées entre elles, parfois peut-être 2 phrases se rapportent l'une à l'autre mais pas plus. Un autre problème est qu'il arrive parfois qu'un pied de page “Digitized by Google” apparaisse, donc la prochaine fois que j'entraînerai, je devrai vraiment m'assurer que les textes soient bien nettoyés. Globalement, je suis très satisfait des résultats, ce n'est pas encore un LLM mais c'est clairement un générateur de phrases.

J'apprends beaucoup et je vais commencer à déterminer ce que je dois améliorer dans les semaines à venir. Je vais bientôt télécharger les fichiers !

# Plans à venir

(Terminé) Je vais commencer à travailler sur la version 0.5, au lieu d'utiliser 50 livres pour l'entraînement, j'utiliserai idéalement 500-600. Pour l'instant, j'entraîne nanoGPT avec des livres de 1800-1850 et spécifiquement de Londres. Il y a des défis comme s'assurer que les livres trouvés ne soient pas des versions mises à jour ou avec des interprétations modernes mais des livres non modifiés publiés dans la période choisie.

Je veux entraîner un nouveau modèle (v1) avec un corpus beaucoup plus grand, peut-être 5 à 10 fois plus grand que celui utilisé pour v0.5. Mon objectif est de voir si je peux obtenir l'émergence de capacités de raisonnement à partir du seul entraînement temporel sélectif, ce sera une tâche plus difficile et je ne suis même pas sûr que cela soit possible à cause des limitations des données historiques. Dans les prochaines semaines, j'essaierai de rassembler suffisamment de données pour un corpus de 5 à 10 Go. Je pense que si j'obtiens des données propres et de haute qualité et que je loue un GPU, il y aura des progrès.

# Comment utiliser ce projet

Ce projet se concentre principalement sur la curation de données historiques, leur préparation pour l'entraînement et la construction d'un tokenizer. Je ne couvre pas ici l'intégralité du processus d'entraînement d'un LLM, pour cela référez-vous à nanoGPT par Andrej Karpathy.

# Étape 1 : Collecter et préparer des textes historiques

Rassemblez des fichiers .txt de livres du domaine public, documents, etc. de la période choisie (par exemple, Londres 1800-1850)

Vous pouvez utiliser download_texts_improved.py pour télécharger des livres si besoin.

Nettoyez les fichiers texte à l'aide d'un script ou retirez manuellement les en-têtes/pieds de page de Project Gutenberg, les annotations modernes ou des erreurs d'OCR.

prepare_dataset.py devrait fonctionner correctement.

# Étape 2 : Construire un tokenizer personnalisé

Lancez train_tokenizer.py ou train_tokenizer_hf.py sur les données nettoyées.
Cela vous donnera vocab.json et merges.txt

Ces fichiers définissent le vocabulaire et les règles de fusion pour votre modèle

# Étape 3 : Entraîner votre modèle (nanoGPT)

Référez-vous à [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT) pour le processus d'entraînement.

Vous pouvez entraîner un autre LLM si vous le souhaitez, mais j'ai utilisé nanoGPT

# FAQ

## Qu'est-ce que l'entraînement temporel sélectif ?

L'entraînement temporel sélectif (STT) est une méthodologie d'apprentissage automatique où toutes les données d'entraînement sont soigneusement sélectionnées pour appartenir à une période historique spécifique. C'est fait afin de modéliser le langage et les connaissances de cette époque sans influence des concepts modernes. Par exemple, le modèle actuel (v0.5) est entraîné uniquement avec des données de 1800-1875, il n'est pas affiné mais entraîné depuis zéro, produisant ainsi des sorties reflétant le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser le fine-tuning ou LoRA ?

Pour ce projet, j'essaie de créer un modèle de langage non biaisé par la modernité. Si je fais un fine-tuning sur GPT-2, il est déjà pré-entraîné et ces informations ne disparaîtront pas. Si j'entraîne depuis zéro, le modèle de langage ne fera pas semblant d'être ancien, il le sera simplement. L'objectif actuel de ce projet est de créer quelque chose capable de raisonner uniquement avec les connaissances provenant de livres londoniens publiés entre 1800 et 1850.

## Quel type de données avez-vous utilisé pour l'entraînement ?

J'utilise des livres, documents juridiques, journaux et autres écrits de Londres 1800–1850. La liste que j'ai partagée en contient environ 200 mais pour le premier entraînement j'ai utilisé seulement 50 fichiers d'environ 187 Mo. Vous pouvez voir la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quelle est la taille du modèle Version 0 ?

Ce modèle est très petit pour l'instant, je fais ça pour le plaisir et je suis une règle stricte de ne pas utiliser de sources modernes. Il a presque 16 millions de paramètres mais je vais commencer à rassembler plus de textes anciens pour commencer un nouvel entraînement. Je donnerai des nouvelles au fur et à mesure.

## Spécifications d'entraînement ?

GPU : Geforce rtx 4060
CPU : i5-13400F
Ram : 16 Go DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---