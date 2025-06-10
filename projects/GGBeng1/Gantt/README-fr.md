# Gantt

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
Gantt développé sur la base de Vue, peut être utilisé pour la collaboration en équipe, la répartition des tâches et d'autres scénarios agiles.

Supporte les groupes
Supporte le glisser-déposer
Supporte l’étirement
Supporte le pourcentage
Supporte les plages de temps : jour, semaine, mois
Actuellement, seule la première couche de groupe est implémentée. Afin de répondre à d’éventuels besoins futurs en groupes à plusieurs niveaux, une partie du code a été refactorisée lors de la dernière soumission pour supporter les groupes à plusieurs niveaux, mais cette version ne les développe pas encore.

Avantages : lors des opérations de glisser-déposer, étirement, modification de l’avancement, les données ne sont pas mises à jour en temps réel, mais après l’opération, ce qui réduit la perte de performance.
      Lors de l’édition, suppression ou ajout, l’instance entière n’est pas modifiée de façon récursive, seules les parties concernées sont modifiées, ajoutées ou supprimées.

Préparation en cours d'une réorganisation pour la modularisation. Actuellement, pour utiliser dans un projet, il suffit d’importer `gant.vue` de ce projet.
Les méthodes d’import/export de données en lot sont déjà écrites, il suffit de copier !~

```

### Notes de mise à jour

- Supporte l’édition
- Supporte la suppression
- Correction du bug empêchant le défilement vertical (ajout du défilement bidirectionnel simultané) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Correction du bug causé par elementUI
- Problème concernant la plage de temps [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Il n’est actuellement pas possible de configurer d'autres plages (par exemple, ajouter les heures) en changeant les paramètres de plage, car certaines configurations sont fixes à l’initialisation. Cela sera modifié plus tard et exposé via une API.


### Voir l’exemple

Voir [démo](https://ggbeng1.github.io/Gantt/#/)

### Aperçu

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---