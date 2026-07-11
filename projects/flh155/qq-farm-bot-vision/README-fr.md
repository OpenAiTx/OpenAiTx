# qq-farm-bot-vision
# Robot classique QQ Farm (version vision IA)
## La première version basée sur la correspondance visuelle CV est terminée, la version Alpha est publiée, attention : c'est une version de test précoce, les fonctionnalités sont incomplètes et en cours de développement et d'optimisation, principalement pour permettre à certains utilisateurs de tester et d'aider à signaler les bugs et donner leur avis.
## Pour les dernières mises à jour des fonctionnalités, veuillez consulter : [update_cv.txt](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./update_cv.txt)
## En cas de problème lors de l'essai, vous pouvez ouvrir un issue : [zone de problèmes issue](https://github.com/flh155/qq-farm-bot-vision/issues)
## Pour les échanges techniques, rejoignez Discord : [canal d’échange des fermiers](https://discord.gg/xbpVKG9wKw)

## Voici la méthode de déploiement et d’essai de la version CV
### Remarque : comme c'est une version de test, il existe de nombreux problèmes et fonctionnalités manquantes, donc pour l’instant, il n’y a pas de méthode d’installation en un clic via docker, exe, etc., seulement le démarrage via le code source est fourni, destiné aux utilisateurs ayant une certaine base technique et souhaitant tester en avant-première ; une fois la version mise à jour et optimisée pour être plus stable, une solution de déploiement en un clic sera proposée, merci de votre compréhension

## ❗ À lire avant utilisation :
- La fenêtre du jeu doit rester en permanence au premier plan, mais peut être masquée
- La version actuelle dispose déjà d’une interface GUI basique, lancez `python main_gui.py` si vous souhaitez l’utiliser
- La version actuelle implémente les fonctions `récolte automatique`, `désherbage/désinsectisation/arrosage automatiques`, `plantation automatique (en test)`, `vol automatique de cultures`, `aide automatique au désherbage/désinsectisation/arrosage`, `réception automatique de l’engrais gratuit quotidien`, ces fonctions sont en test et optimisation continue
- La correspondance de modèles d’image peut échouer ou produire des erreurs à cause de divers facteurs, il faut ajuster les paramètres de seuil en fonction de l’utilisation, consultez la méthode d’ajustement des seuils ici : [threshold_adjust.txt](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./threshold_adjust.txt)
- Un écouteur de touches est configuré pour un contrôle rapide du robot, raccourcis : `Ctrl+c` pour arrêter et quitter immédiatement, `p` pour mettre en pause/reprendre temporairement l’inspection du robot

---
## Explications des branches
- ### ~~[branche silence-click](https://github.com/flh155/qq-farm-bot-vision/tree/silence-click) : mode clic silencieux, la fenêtre du jeu reste au premier plan mais le robot ne prend pas la souris à l’utilisateur, attention : ce mode peut comporter un risque de bannissement, à utiliser à votre propre discrétion, surveillez bien les retours si vous l’utilisez~~ (cette branche a été fusionnée dans la branche main)
- ### [branche gui-pr](https://github.com/flh155/qq-farm-bot-vision/tree/gui-pr) : cette branche est dédiée aux PR pour l’interface GUI, le projet par défaut a une interface simple, si vous avez un bon design GUI, vous pouvez soumettre une PR sur cette branche (pour l’instant aucune soumission)

---
## Aperçu de l’interface GUI
![GUI](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./assert/gui.jpg)

## Configuration système requise
- Windows 10 ou supérieur (Linux et autres systèmes non supportés pour l’instant)
- Python installé localement (environnement conda recommandé), version Python ≥ 3.9
- QQ version bureau NT installée et capable d’ouvrir la page de la ferme
## Méthode de déploiement et d’essai
- 1. `git clone` du projet localement, ouvrez QQ PC et connectez-vous
- 2. Ouvrez un terminal dans le répertoire racine du projet (optionnel : activez l’environnement conda), installez les dépendances avec `pip install -r requirement.txt`
- 3. Vérifiez le fichier de configuration `config.ini` à la racine, modifiez les paramètres selon vos besoins
- 4. Lancez le robot avec la commande `python main.py`, vérifiez que le terminal indique un démarrage réussi (pour l’interface GUI, utilisez `python main_gui.py`)
- 5. Ouvrez la fenêtre du jeu ferme (attention, la fenêtre doit être complètement visible dans cette version)
- 6. Le programme contrôlera automatiquement la souris pour cliquer sur les boutons et automatiser les fonctions
---
# Plan de développement futur
- ~~Première version implémentant la correspondance d’image basée sur cv pour la récolte, la désinsectisation et le désherbage (version simplifiée pour transition rapide)~~ (réalisé)
- ~~Ajout d'une interface GUI pour faciliter l'utilisation~~ (réalisé)  
- Optimisation et enrichissement des fonctionnalités de la version de correspondance CV, correction des problèmes existants (en cours)  
- Collecte de jeux de données d'images : nettoyage, annotation, augmentation  
- Entraînement d'un modèle de détection d'objets basé sur le réseau neuronal yolo  
- Utilisation de réseaux neuronaux pour une reconnaissance plus précise et riche des différents icônes, enrichissement des fonctionnalités (planter, récolter, voler, cultiver, etc.)  
# Votre étoile⭐ est ma motivation pour mettre à jour  
---  
## Tout d'abord, merci beaucoup pour l'attention portée au projet et pour vos étoiles⭐, mais comme je travaille habituellement, je n'ai du temps pour mettre à jour et maintenir le projet que pendant mes pauses et après le travail, et ce projet a été démarré de zéro, donc la progression est un peu lente, la qualité du code peut être un peu moindre, j'espère que vous comprendrez, et tous les experts sont invités à faire des PR pour devenir contributeurs du projet, enfin je mettrai à jour le progrès de développement en temps voulu, merci de votre patience  

# Avertissement ❗  
## Ce projet est uniquement destiné à la recherche, à l'apprentissage et à l'échange autour de l'IA et des applications de la vision par ordinateur, il est garanti open source et gratuit à vie, il est strictement interdit à quiconque de faire un développement secondaire, un emballage ou une revente, une promotion illégale du projet, et l'utilisation de ce projet peut enfreindre les conditions de service des jeux et entraîner des sanctions telles que la suspension de compte, l'utilisation du code de ce projet signifie que vous avez pris connaissance et accepté les informations ci-dessus, toutes les conséquences en découlant sont à la charge de l'utilisateur et n'engagent pas l'auteur.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---