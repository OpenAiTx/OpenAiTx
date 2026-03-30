
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">Anglais</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Description du projet](#project-description)
- [Configuration requise du système :](#os-requirements)
- [FAQ](#faqs)
- [feuille de route](#roadmap)
- [Captures d'écran](#screenshots)

## Description du projet

Elucidate est une interface graphique Windows pour l’application en ligne de commande SnapRAID.

*Ce projet poursuit l’amalgame de l’excellent travail réalisé par moi-même et d’autres contributeurs.

## Configuration requise

- Système d’exploitation Windows
- .Net Runtime 4.8.0
- SnapRAID version 11.5 ou inférieure
- 10 Mo d’espace libre sur le disque cible

## FAQ

**Q** : Qu’est-ce que SnapRAID ?<br/>
**R** : SnapRAID est un moteur de parité instantanée défini par logiciel pour les systèmes d’exploitation Windows et Linux. Au niveau le plus basique, il offre une protection au contenu d’un système de fichiers sous sa gestion en calculant les hachages de ses fichiers composants et en stockant les résultats dans un fichier de parité. En cas de défaillance totale d’un disque dur, ce fichier de parité peut être utilisé pour reconstruire les données perdues. Pour plus de détails, consultez la [comparaison officielle des moteurs de protection de fichiers de SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**Q** : Pourquoi une interface graphique, la ligne de commande fonctionne !<br/>
**R** : L’objectif global est de créer une interface graphique complète avec des fonctionnalités de gestion supplémentaires conçues pour aider l’utilisateur à maintenir un environnement SnapRAID fonctionnel. Parfois, le “pointer-cliquer” est plus accessible pour un novice. La documentation technique de SnapRAID et ses nombreuses options de configuration peuvent rebuter ceux qui souhaitent l’essayer !

**Q** : Je ne suis pas encore convaincu, y a-t-il plus ?<br/>
**R** : Oui, consultez la [documentation](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) pour des images, etc.

**Q** : Quels sont donc les "objectifs plus larges" ?<br/>
**R** : Voir le __Roadmap__ ci-dessous pour une ventilation complète.

## Feuille de route

- [x] Phase I
  - [x] Tenter de maintenir le support minimum de la dernière version de SnapRAID. - __En cours.__
  - [x] Facilité d’utilisation
  - [x] SnapRAID a trois commandes, rendons-les simples d’accès pour un novice 
  - [x] Indicateur(s) de progression 
  - [x] Journalisation "Interactive" et directe vers le log. 
  - [x] Démarrage automatique à la connexion de l’utilisateur 
  - [x] Infobulles d’aide •	

- [x] Phase II Fonctionnalités demandées de la phase II
  - [x] Pause, changement de priorité, arrêt.
  - [x] Extension de commande - "Autoriser des paramètres supplémentaires aux valeurs par défaut utilisées."
  - [x] Planification 
    - Supprimé, utilisez la ligne de commande
  - [x] Vue(s) graphique(s) des données protégées.

- [ ] Phase III (Reprise à partir de 2017-03)
  - [x] Nouveau compilateur et .Net 4.7.x	
  - [x] Interface en ligne de commande
  - [ ] Nouvelle mise en page via Krypton Toolkit / Navigator / etc. 
    - En cours
  - [ ] Traductions 
  - [x] Nouvelles commandes
  - [ ] Module d'envoi de mails avec rapports de statut
  - [ ] Documenter les étapes de test
    - En cours
  - [ ] Ajouter à la documentation / Mettre à jour les images
    - En cours
  - [ ] Ajouter un rapport _Windows EventLog_ des erreurs
  - [x] Ajouter _ExceptionLess_ pour le rapport en ligne des exceptions
  - [x] Afficher ce qui pourrait être récupéré. 

- [ ] Phase IV (nouvelles commandes SnapRAID ?) 
  - [ ] Aide étendue avec récupération de disque - guides interactifs, etc.
  - [ ] Notifier l'utilisateur si sa version de SnapRAID est obsolète
  - [ ] Interpréter les journaux SnapRAID (utilisé par les changements ci-dessous)
  - [ ] Fournir l’état de l’ensemble après l’exécution d’une commande
  - [ ] Modifier la commande de synchronisation pour inclure un diff initial
  - [ ] Modifier la commande de synchronisation pour afficher un avertissement si le diff signale des problèmes au-dessus d’un seuil
  - [ ] Ajouter des paramètres configurables par l'utilisateur pour les exigences de seuil de synchronisation


## Captures d'écran

![Vue de départ](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Formulaire des paramètres](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Pouvez-vous aider ? 
- Recherche de testeurs (toutes plateformes .Net)
- Peut aider à traduire 
- Guides d'aide / interface utilisateur 
- Toutes autres idées :-) 
- Développeurs pour les idées 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---