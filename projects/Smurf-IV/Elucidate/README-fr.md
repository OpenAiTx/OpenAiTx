# Elucidate

- [Description du projet](#project-description)
- [Exigences système :](#os-requirements)
- [FAQ](#faqs)
- [Feuille de route](#roadmap)
- [Captures d'écran](#screenshots)

## Description du projet

Elucidate est une interface graphique Windows pour l'application SnapRAID en ligne de commande.

*Ce projet poursuit la fusion du travail remarquable réalisé par moi-même et d'autres contributeurs.

## Exigences système

- Système d'exploitation Windows
- .Net Runtime 4.8.0
- SnapRaid Version 11.5 ou inférieure
- 10 Mo d'espace libre sur le disque cible

## FAQ

**Q** : Qu'est-ce que SnapRAID ?<br/>
**R** : SnapRAID est un moteur de parité instantanée défini par logiciel pour les systèmes d'exploitation Windows et Linux. Au niveau le plus basique, il offre une protection au contenu d'un système de fichiers sous sa supervision en calculant les hachages de ses fichiers composants et en stockant les résultats dans un fichier de parité. En cas de défaillance complète d'un disque dur, ce fichier de parité peut être utilisé pour reconstruire les données perdues. Pour plus de détails, consultez la [comparaison officielle des moteurs de protection de fichiers](http://snapraid.sourceforge.net/compare.html) de SnapRAID.

**Q** : Pourquoi une interface graphique, la ligne de commande fonctionne !<br/>
**R** : L'objectif plus large est de créer une interface graphique complète avec des fonctionnalités de gestion supplémentaires conçues pour aider un utilisateur à maintenir un environnement SnapRAID fonctionnel. Parfois, les « pointer-cliquer » sont plus simples pour un novice. La documentation technique de SnapRAID et sa grande configurabilité peuvent rendre son adoption rebutante pour ceux qui veulent l’essayer !

**Q** : Je suis encore incertain, y a-t-il plus ?<br/>
**R** : Oui, jetez un œil à la [documentation](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) pour des images, etc.

**Q** : Alors quels sont les « Objectifs plus larges » ?<br/>
**R** : Voir la __Feuille de route__ ci-dessous pour une description complète.

## Feuille de route

- [x] Phase I
  - [x] Tentative de suivre le support minimum de la dernière version de SnapRAID. - __En cours.__
  - [x] Facilité d’utilisation
  - [x] SnapRAID a trois commandes, donc rendons-les simples d'accès pour un novice 
  - [x] Indicateur(s) de progression 
  - [x] Journalisation "Interactive" et directement dans le journal. 
  - [x] Démarrage automatique à la connexion de l'utilisateur 
  - [x] Info-bulles pour guider •

- [x] Phase II Phase II Demandes de fonctionnalités
  - [x] Pause, Changer la priorité, Annuler.
  - [x] Extension de commande - "Permettre des paramètres supplémentaires aux valeurs par défaut utilisées."
  - [x] Planification 
    - Supprimé, utiliser la ligne de commande
  - [x] Vue(s) graphique(s) des données protégées.

- [ ] Phase III (Redémarrage pour 2017-03 et au-delà)
  - [x] Nouveau compilateur et .Net 4.7.x	
  - [x] Interface en ligne de commande
  - [ ] Nouvelle disposition via Krypton Toolkit / Navigator / etc. 
    - En cours
  - [ ] Traductions 
  - [x] Nouvelles commandes
  - [ ] Envoi de mails avec rapports d’état
  - [ ] Documenter les étapes de test
    - En cours
  - [ ] Ajouter à la documentation / Mettre à jour les images
    - En cours
  - [ ] Ajouter un rapport _Windows EventLog_ des erreurs
  - [x] Ajouter _ExceptionLess_ pour le rapport en ligne des exceptions
  - [x] Montrer ce qui pourrait être récupéré. 

- [ ] Phase IV (nouvelles commandes SnapRAID ?) 
  - [ ] Aide étendue avec récupération de disque - guides interactifs, etc. 
  - [ ] Notifier l'utilisateur si sa version de SnapRAID est obsolète
  - [ ] Interpréter les journaux SnapRAID (utilisés par les modifications ci-dessous)
  - [ ] Fournir le statut du tableau après l'exécution d'une commande
  - [ ] Modifier la commande sync pour inclure un diff initial
  - [ ] Modifier la commande sync pour générer un avertissement si le diff a signalé des problèmes au-delà d’un seuil
  - [ ] Ajouter des paramètres configurables par l’utilisateur pour les exigences de seuil de synchronisation


## Captures d’écran

![Vue de départ](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Formulaire des paramètres](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Pouvez-vous aider ? 
- Recherche de testeurs (toutes plateformes .Net) 
- Peut aider à la traduction 
- Guides d’aide / interface utilisateur 
- Toute autre idée :-) 
- Développeurs pour les idées 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-27

---