# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Installation

```
yarn install
```

### Exécution

```
yarn run serve
```

### Description

```
Diagramme de Gantt développé sur la base de Vue, pouvant être utilisé pour la collaboration d’équipe, la répartition des tâches et d’autres scénarios agiles

Prise en charge des groupes
Prise en charge du glisser-déposer
Prise en charge du redimensionnement
Prise en charge du pourcentage
Prise en charge de la plage de temps : jour, semaine, mois
Actuellement, seule la première couche de groupes est écrite. Afin d’anticiper des besoins futurs en groupes à deux niveaux ou multiples, une partie du code a été refactorée lors de la dernière soumission pour supporter les groupes hiérarchiques, mais cette version ne les implémente pas encore

Avantages : lors des opérations de glisser-déposer, de redimensionnement, de modification de l’avancement, les données ne sont pas mises à jour en temps réel, mais après l’opération, ce qui réduit la perte de performance
      Lors de l’édition, la suppression ou l’ajout, l’ensemble des instances n’est pas modifié de manière récursive, seules les parties concernées sont ajoutées, supprimées ou modifiées

Réorganisation en cours pour préparer la componentisation. Actuellement, pour l’utiliser dans un projet, il suffit d’importer le fichier `gant.vue` du projet
Les méthodes d’import/export de données en masse sont déjà écrites, il suffit de copier !~

```

### Notes de mise à jour

- Prise en charge de l’édition
- Prise en charge de la suppression
- Correction du bug empêchant le défilement vertical (ajout du défilement bidirectionnel simultané) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Correction d’un bug causé par elementUI
- Concernant la plage de temps [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Il n’est actuellement pas possible de configurer d’autres plages de temps, comme l’ajout d’heures, en modifiant la configuration. Certaines options sont fixées à l’initialisation ; cela sera modifié à l’avenir et exposé via l’API.


### Voir l’exemple

Voir [démo](https://ggbeng1.github.io/Gantt/#/)

### Capture d’écran

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---