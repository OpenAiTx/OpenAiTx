
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

Imaginez si un modèle d’IA ne faisait pas que prétendre être historique mais l’était réellement.

Construit sur [nanoGPT par Andrej Karpathy](https://github.com/karpathy/nanoGPT). Les scripts de formation principaux et l’architecture du modèle sont son œuvre.

# Objectifs du projet

TimeCapsule LLM est un projet expérimental qui ne sera entraîné que sur des textes écrits pendant certaines périodes. L’objectif est de simuler la vision du monde et le langage d’époques historiques spécifiques.

# Pourquoi l’ajustement fin ne suffit pas

Si vous ne faites qu’ajuster un modèle pré-entraîné, votre LLM connaîtra toujours des concepts modernes. Bien sûr, obtenir zéro biais moderne est difficile mais je veux m’en approcher le plus possible. Pour éliminer le biais moderne, il faut entraîner un modèle à partir de zéro.

# Résultats attendus

J’espère qu’une fois terminé, ce modèle ne connaîtra pas les concepts modernes et ne pourra pas raisonner au-delà de ce sur quoi il a été entraîné. Il ne devrait pas reconnaître les concepts/vocabulaire modernes et j’espère qu’il ne génèrera pas de connaissances modernes par hallucination.

# Suivi de l’avancement

## 9 juillet 2025

J’ai fixé ma période à 1800-1850 et la région : Londres

J’ai rassemblé une liste de textes, livres, documents

J’en ai obtenu 50 sous forme de fichiers txt jusqu’ici et je vais bientôt commencer l’entraînement de NanoGPT

Je mettrai à jour ceci tant que des progrès seront réalisés

## 13 juillet 2025

Entraîné nanoGPT avec 187 Mo de données textuelles historiques.

## 15 juillet 2025

J’ai commencé à télécharger des textes pour la deuxième session d’entraînement. Je récupère tout sur Internet Archive et j’ai élargi la période à 1800-1875. Pour obtenir une gamme variée de textes, vous pouvez utiliser les filtres de sujet et de recherche pour le lieu de publication, la période et les sujets sur Internet Archive.

![Filtres de recherche](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 juillet 2025

J’ai téléchargé environ 500 fichiers txt depuis Internet Archive et après les avoir nettoyés (juste suppression des espaces, en-têtes Gutenberg, etc.) j’ai environ 500 Mo de données. C’est un petit jeu de données mais la dernière fois j’ai entraîné sur 187 Mo donc il devrait y avoir au moins une différence notable dans les résultats après l’entraînement du deuxième modèle. J’espère que ce modèle pourra au moins produire des phrases plus cohérentes qui ont un certain sens. Ce n’est bien sûr pas garanti car le jeu de données reste minuscule, mais c’est mieux que la dernière fois.

Ceci devrait être faisable avec mon propre matériel, c’est une bonne chose car j’espère voir quelques améliorations avant de passer à un jeu de données plus important qui m’obligerait à louer un GPU. Mais ne vous inquiétez pas, je prévois toujours d’en louer un bientôt, mais avant cela je veux m’assurer que mon jeu de données est aussi bien sélectionné et propre que possible. Un des problèmes que j’ai est le nettoyage, beaucoup de ces fichiers txt contiennent du charabia. Les scripts que j’utilise pour nettoyer fonctionnent, mais ils ne sont pas efficaces à 100 %.

Je vais entraîner ce jeu de données aujourd’hui et cela devrait prendre environ 4 à 5 heures. Une fois terminé et testé, je donnerai des nouvelles. Merci encore à tous ceux qui consultent mon projet, j’ai même eu des personnes qui m’ont envoyé des liens vers des ressources OCR alors merci ! J’espère que d’autres essaieront aussi et expérimenteront avec leurs propres jeux de données.


### Mise à jour de l’entraînement

J’ai commencé l’entraînement sur un corpus de 435 Mo (108 M tokens), tout se passe bien pour l’instant. La perte d’entraînement est passée de 10,9 à 4,9 lors des 2800 premières itérations. Je pense que cela prendra environ 8 ou 9 heures pour terminer. Je posterai une autre mise à jour une fois terminé.

## 17 juillet 2025

L’entraînement est terminé pour le deuxième modèle, mon 4060 a mis environ 8h40 (3 900 iters/h) pour 33 000 itérations (5 époques). La perte d’entraînement finale était de 3,73. Les résultats étaient étonnamment bons, il génère désormais vraiment des phrases cohérentes dans le style du XIXe siècle.

## 28 juillet 2025

J’ai mis en ligne la version 0.5 sur Hugging Face, [jetez-y un coup d’œil](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si vous le souhaitez. Vous pouvez maintenant télécharger mon dépôt et l’exécuter localement. Malheureusement, nanoGPT ne fonctionne pas nativement avec HuggingFace, il faudra donc télécharger et exécuter le modèle en local.

Je vais aussi commencer à sélectionner des données pour mon prochain entraînement, je pense qu’il me faudra peut-être 5 à 10 fois plus de données pour atteindre des capacités de raisonnement.

## 2 août 2025

Je vais bientôt commencer à travailler sur la Version 1. Je vais devoir passer de l’architecture de nanoGPT à quelque chose de plus moderne. J’ai plusieurs architectures LLM open source en tête, dont : OpenLLaMA v3, Phi-2 et Qwen 1.5B. Et pour passer à la V1, il me faudra soigneusement sélectionner un jeu de données bien plus grand et diversifié. J’aurai besoin d’au moins 5 Go de données d’entraînement propres.

# Comportement et limitations du modèle V0

Les premiers prompts montrent que le modèle répond avec le langage et le comportement des années 1800. Par exemple, je lui ai demandé "Who art Henry ?" et il a répondu "Je connais cet homme, je n'ai point fait un noir, la tempête." et oui, cette phrase n'a aucun sens mais le LLM reconnaît que je demande à propos d'une personne.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Il n'y a aucune mention de concepts modernes, les résultats contiennent principalement des mots et des tournures de phrases des années 1800.

Il reste encore beaucoup de travail à faire, s'entraîner sur 187 Mo ne donnera pas un modèle capable de produire du texte avec un raisonnement complexe.

Actuellement, il produit des phrases qui manquent de structure complète et, globalement, n'ont aucun sens, mais c'est normal avec cette taille d'entraînement.

# Comportement et limitations du modèle V0.5

C'est une nette amélioration par rapport au précédent modèle. Le style d'écriture et le vocabulaire sont victoriens et presque chaque phrase est grammaticalement correcte avec une bonne ponctuation. Et encore une fois, ce modèle est entraîné depuis zéro donc il reste centré sur les sujets des années 1800.

![Exemple de sortie TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Il y a beaucoup d'hallucinations factuelles. Beaucoup (environ 100%) des détails (dates, événements, personnages historiques) sont inventés. De plus, les phrases n'ont pas vraiment de liens entre elles, parfois deux phrases peuvent se rapporter l'une à l'autre mais pas au-delà. Un autre problème est qu'il arrive parfois qu'un pied de page “Digitized by Google” apparaisse, donc la prochaine fois que j'entraînerai, il faudra vraiment que je nettoie mieux les textes. Globalement, je suis très satisfait des résultats, ce n'est pas encore un LLM mais définitivement un générateur de phrases.

J'apprends beaucoup et je vais commencer à déterminer ce que je dois améliorer dans les prochaines semaines. Je mettrai bientôt les fichiers en ligne !

# Plans à venir

(Terminé) Je vais commencer à travailler sur la version 0.5, au lieu de m'entraîner avec 50 livres, je vais utiliser idéalement 500-600. Actuellement, j'entraîne nanoGPT avec des livres de 1800-1850 et spécifiquement de Londres. Il y a quelques défis comme s'assurer que les livres trouvés ne sont pas mis à jour ou possèdent des interprétations modernes mais qu'ils sont bien des livres intacts publiés durant la période choisie.

Je souhaite entraîner un nouveau modèle (v1) avec un corpus bien plus grand, peut-être 5 à 10 fois plus grand que celui utilisé pour v0.5. Mon objectif est de voir si des capacités de raisonnement peuvent émerger du seul entraînement temporel sélectif, ce sera une tâche plus difficile et je ne suis même pas certain que ce soit possible en raison des limites des données historiques. Dans les prochaines semaines, j'essaierai de rassembler assez de données pour un corpus de 5 à 10 Go. Je pense que si j'arrive à obtenir des données propres et de haute qualité et à louer un GPU, il y aura des progrès.

# Comment utiliser ce projet

Ce projet se concentre surtout sur la curation de données historiques, leur préparation pour l'entraînement et la création d'un tokenizer. Je ne vais pas couvrir tout le processus d'entraînement d'un LLM, pour cela, référez-vous à nanoGPT par Andrej Karpathy.

# Étape 1 : Rassembler et préparer les textes historiques

Collectez des fichiers .txt de livres, documents, etc. du domaine public issus de la période de votre choix (par ex. Londres 1800-1850)

Vous pouvez utiliser download_texts_improved.py pour télécharger des livres si besoin.

Nettoyez les fichiers textes à l'aide d'un script ou manuellement pour supprimer les en-têtes/pieds de page de Project Gutenberg, annotations modernes ou erreurs d'OCR.

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

L'entraînement temporel sélectif (Selective Temporal Training, STT) est une méthodologie d'apprentissage automatique où toutes les données d'entraînement sont spécifiquement sélectionnées pour appartenir à une période historique précise. Cela permet de modéliser la langue et les connaissances de cette époque sans influence de concepts modernes. Par exemple, le modèle actuel (v0.5) est entraîné uniquement sur des données de 1800 à 1875, il n'est pas affiné mais entraîné depuis zéro, ce qui donne un résultat reflétant le style linguistique et le contexte historique de cette période.

## Pourquoi ne pas simplement utiliser du fine-tuning ou LoRA ?

Pour ce projet, j'essaie de créer un modèle de langage non biaisé par la modernité. Si je fais du fine-tuning sur un modèle comme GPT-2, il est déjà pré-entraîné et cette information ne disparaîtra pas. Si j'entraîne depuis zéro, le modèle de langage ne fera pas semblant d'être ancien, il le sera. L'objectif de ce projet est actuellement de créer un modèle capable de raisonner uniquement avec les connaissances des livres londoniens publiés entre 1800 et 1850.

## Quel type de données avez-vous utilisé pour l'entraînement ?

J'utilise des livres, des documents juridiques, des journaux et d'autres écrits de Londres entre 1800 et 1850. La liste que j'ai partagée en contient environ 200 mais pour le premier entraînement, je n'ai utilisé que 50 fichiers soit environ 187 Mo. Vous pouvez consulter la liste des documents :
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Quelle est la taille du modèle Version 0 ?

Ce modèle est encore très petit, je fais ça pour m'amuser et je suis une règle stricte d'entraînement sans sources modernes. Il compte presque 16 millions de paramètres mais je vais commencer à rassembler plus de textes anciens pour débuter une nouvelle phase d'entraînement. Je donnerai des nouvelles au fur et à mesure.

## Spécifications d'entraînement ?

GPU : Geforce rtx 4060
CPU : i5-13400F
Ram : 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---