# Benchmark Vector RISC-V

Une collection de benchmarks Vector RISC-V (RVV) pour aider les développeurs à écrire du code RVV performant et portable.

Les résultats des benchmarks sont disponibles sur : https://camel-cdr.github.io/rvv-bench-results

## Benchmarks ([./bench/](./bench/))

Contient plusieurs benchmarks de différentes implémentations de certains algorithmes.

## Comptage des cycles d’instruction ([./instructions/](./instructions/))

Mesure le nombre de cycles des instructions RVV en déroulant et en répétant l’instruction donnée.

## Pour commencer

Commencez par configurer [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk), de sorte que `make` fonctionne et éventuellement [./run.sh](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./run.sh), qui permet de compiler et d’exécuter avec `make run`.

La configuration par défaut devrait fonctionner avec toutes les versions récentes de clang et ne nécessite pas de chaîne de compilation croisée complète, car elle compile en mode freestanding.
Cela signifie qu’elle ne fonctionnera que sous Linux, ou un système compatible syscall Linux.

Sur les versions récentes de Linux, les compteurs de performance ne sont pas exposés par défaut, vous devrez peut-être exécuter `echo 2 >/proc/sys/kernel/perf_user_access` et ajouter `-DUSE_PERF_EVENT` à la ligne `CFLAGS=...` dans [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) (si cela ne fonctionne pas, essayez plutôt `-DUSE_PERF_EVENT_SLOW`).

Vous pouvez configurer [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) pour effectuer une compilation hébergée ou la configurer avec votre chaîne d’outils personnalisée, ajoutez la définition `-DCUSTOM_HOST` et implémentez les fonctions non implémentées sous `#ifdef CUSTOM_HOST` dans [./nolibc.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./nolibc.h).

XTheadVector n’est plus supporté.

### Exécution des benchmarks ([./bench/](./bench/))

Pour lancer les benchmarks, commencez par consulter ([./bench/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./bench/config.h)) et ajustez-le à votre processeur (par exemple, définissez `HAS_E64`). Si l’exécution est trop longue, essayez de réduire `MAX_MEM`, qui est utilisé pour dimensionner le benchmark, et modifiez les autres constantes jusqu’à obtenir un temps d’exécution raisonnable et un graphique relativement fluide.

Vous pouvez maintenant simplement exécuter les benchmarks avec `make run` dans le répertoire ([./bench/](./bench/)), ou `make` pour simplement construire les exécutables.

### Mesure du nombre de cycles ([./instructions/](./instructions/))

Pour effectuer la mesure du nombre de cycles, commencez par configurer [instructions/rvv/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/instructions/rvv/config.h) pour votre processeur.

Vous pouvez ensuite lancer la mesure avec `make run` dans le répertoire ([./instructions/rvv/](./instructions/rvv/)), ou `make` pour construire uniquement les exécutables.

Pour XTheadVector, utilisez plutôt le répertoire ([./instructions/xtheadvector/](./instructions/xtheadvector/)). (ceci n’est plus maintenu)
## Contribution

Voici quelques suggestions de tâches encore à réaliser.

* contribuer à la mesure d’un nouveau CPU sur : https://github.com/camel-cdr/rvv-bench-results \
  Vous pouvez simplement créer une issue avec un fichier json unique, qui contient tous les résultats concaténés de [./bench/](./bench/). (après configuration adéquate, `make run > out.json` devrait faire l’affaire). \
* implémenter des benchmarks non limités par la mémoire
* implémenter davantage de benchmarks
* meilleures mesures de cycles : débit vs latence (également : pouvons-nous déterminer la configuration des ports d’exécution ?)
* nombre de cycles pour les chargements/stocks
* nombre de cycles pour vsetvl

## Licence

Ce dépôt est sous licence MIT [LICENSE](LICENSE).




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---