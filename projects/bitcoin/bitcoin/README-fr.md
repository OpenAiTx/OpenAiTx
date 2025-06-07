Arborescence d'intégration/staging de Bitcoin Core
==================================================

https://bitcoincore.org

Pour une version binaire immédiatement utilisable du logiciel Bitcoin Core, consultez
https://bitcoincore.org/en/download/.

Qu'est-ce que Bitcoin Core ?
----------------------------

Bitcoin Core se connecte au réseau pair-à-pair Bitcoin pour télécharger et valider entièrement
les blocs et les transactions. Il inclut également un portefeuille et une interface graphique,
qui peuvent être construits en option.

Des informations supplémentaires sur Bitcoin Core sont disponibles dans le [dossier doc](/doc).

Licence
-------

Bitcoin Core est publié sous les termes de la licence MIT. Voir [COPYING](COPYING) pour plus
d'informations ou consultez https://opensource.org/license/MIT.

Processus de développement
--------------------------

La branche `master` est régulièrement compilée (voir `doc/build-*.md` pour les instructions) et testée, mais sa stabilité
complète n’est pas garantie. Des [tags](https://github.com/bitcoin/bitcoin/tags) sont créés
régulièrement à partir des branches de publication pour indiquer les nouvelles versions officielles et stables de Bitcoin Core.

Le dépôt https://github.com/bitcoin-core/gui est utilisé exclusivement pour le
développement de l’interface graphique (GUI). Sa branche master est identique dans tous les dépôts monotree.
Il n’existe pas de branches ou de tags de publication, donc merci de ne pas forker
ce dépôt sauf pour des raisons de développement.

Le flux de contribution est décrit dans [CONTRIBUTING.md](CONTRIBUTING.md)
et des conseils utiles pour les développeurs sont disponibles dans [doc/developer-notes.md](doc/developer-notes.md).

Tests
-----

Les tests et la revue de code constituent le principal goulot d'étranglement du développement ; nous recevons plus de pull
requests que nous ne pouvons en réviser et tester à court terme. Merci d’être patient et d’aider en testant
les pull requests d’autres personnes, et souvenez-vous qu’il s’agit d’un projet critique pour la sécurité où toute erreur peut coûter
beaucoup d’argent aux utilisateurs.

### Tests automatisés

Les développeurs sont fortement encouragés à écrire des [tests unitaires](src/test/README.md) pour tout nouveau code, et à
soumettre de nouveaux tests unitaires pour l’ancien code. Les tests unitaires peuvent être compilés et lancés
(sauf s’ils ont été désactivés lors de la génération du système de build) avec : `ctest`. Pour plus de détails sur l’exécution
et l’extension des tests unitaires, consultez [/src/test/README.md](/src/test/README.md).

Il existe également des [tests de régression et d’intégration](/test), écrits
en Python.
Ces tests peuvent être lancés (si les [dépendances de test](/test) sont installées) avec : `build/test/functional/test_runner.py`
(en supposant que `build` est votre répertoire de compilation).

Les systèmes CI (Intégration Continue) s’assurent que chaque pull request est compilée pour Windows, Linux et macOS,
et que les tests unitaires/de santé sont exécutés automatiquement.

### Assurance Qualité (QA) Manuelle

Les modifications doivent être testées par une personne autre que le développeur qui a écrit le
code. Cela est particulièrement important pour les changements importants ou à haut risque. Il est utile
d’ajouter un plan de test à la description de la pull request si le test des modifications
n’est pas simple.

Traductions
-----------

Les modifications de traductions ainsi que les nouvelles traductions peuvent être soumises sur
[la page Transifex de Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/).

Les traductions sont périodiquement récupérées depuis Transifex et fusionnées dans le dépôt git. Voir le
[processus de traduction](doc/translation_process.md) pour plus de détails sur ce fonctionnement.

**Important** : Nous n’acceptons pas les modifications de traduction sous forme de pull requests GitHub car la prochaine
synchronisation depuis Transifex les écraserait automatiquement.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---