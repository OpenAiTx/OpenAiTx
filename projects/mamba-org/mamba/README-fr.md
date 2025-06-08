# Mamba : Le gestionnaire de paquets rapide et multiplateforme

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">fait partie de mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Gestionnaire de paquets <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Serveur de paquets <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` est une réimplémentation du gestionnaire de paquets conda en C++.

- téléchargement parallèle des données de dépôt et des fichiers de paquets grâce au multi-threading
- libsolv pour une résolution des dépendances beaucoup plus rapide, une bibliothèque de pointe utilisée dans le gestionnaire de paquets RPM de Red Hat, Fedora et OpenSUSE
- les parties principales de `mamba` sont implémentées en C++ pour une efficacité maximale

En même temps, `mamba` utilise le même analyseur de ligne de commande, le même code d'installation et de désinstallation des paquets, et les mêmes routines de vérification des transactions que `conda` afin de rester aussi compatible que possible.

`mamba` fait partie de l'écosystème [conda-forge](https://conda-forge.org/), qui comprend également `quetz`, un serveur de paquets `conda` open source.

Vous pouvez lire notre [article d’annonce](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## micromamba

`micromamba` est la version statiquement liée de `mamba`.

Elle peut être installée comme un exécutable autonome sans aucune dépendance, ce qui en fait un choix idéal pour les pipelines CI/CD et les environnements conteneurisés.

Voir la [documentation sur `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) pour plus de détails.

## `mamba` vs `micromamba`

`mamba` doit être préféré lorsque :

- `libmambapy` ou `libmamba` est utilisé par d'autres logiciels dans le même environnement.
- Les scénarios nécessitent des mises à jour régulières des bibliothèques (notamment pour la sécurité).
- Les environnements sont axés sur la réduction de l'espace disque utilisé pour les dépendances.

`micromamba` doit être préféré lorsque :

- Il est nécessaire de s'appuyer sur un exécutable unique et autonome.
- Une distribution miniforge n'est pas présente.
- L'utilisation nécessite un temps d'exécution minimal.

## Installation

Veuillez vous référer au guide d'installation de [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
et de [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) dans la documentation.

## Fonctionnalités supplémentaires dans Mamba et Micromamba

`mamba` et `micromamba` offrent des fonctionnalités supplémentaires par rapport à `conda` standard.

### `repoquery`

Pour interroger efficacement les dépôts et les dépendances des paquets, vous pouvez utiliser `mamba repoquery` ou `micromamba repoquery`.

Voir la [documentation repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) pour plus de détails.

### Installation de fichiers de verrouillage

`micromamba` peut être utilisé pour installer des fichiers de verrouillage générés par [conda-lock](https://conda.github.io/conda-lock/) sans avoir à installer `conda-lock`.

Il suffit d'invoquer `micromamba create` avec l'option `-f`, en fournissant un fichier de verrouillage d'environnement dont le nom se termine par
`-lock.yml` ou `-lock.yaml` ; par exemple :

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (remplaçant de setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) est un remplaçant de [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) qui utilise `micromamba`.

Il peut réduire considérablement le temps d'installation de votre CI en :

- Utilisant `micromamba`, qui prend environ 1 s à installer.
- Mémorisant en cache les téléchargements de paquets.
- Mémorisant en cache des environnements `conda` entiers.

## Différences avec `conda`

Bien que `mamba` et `micromamba` soient généralement des remplaçants directs de `conda`, il existe quelques différences :

- `mamba` et `micromamba` ne prennent pas en charge les révisions (pour les discussions, voir <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` et `micromamba` normalisent les chaînes `MatchSpec` sous leur forme la plus simple, alors que `conda` utilise une forme plus verbeuse.
  Cela peut entraîner de légères différences dans la sortie de `conda env export` et `mamba env export`.

## Installation pour le développement

Veuillez vous référer aux instructions données par la [documentation officielle](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## Stabilité de l’API et de l’ABI

Le projet Mamba utilise le [versionnage sémantique](https://semver.org/) sous la forme `MAJEUR.MINEUR.CORRECTIF`.
Bien que nous essayions de maintenir la stabilité pour les utilisateurs, nous devons parfois apporter des changements incompatibles pour améliorer
Mamba et réduire la dette technique.
Les versions futures de Mamba pourraient offrir des garanties plus fortes.

### `libmamba` (C++)

Nous ne connaissons pas de consommateurs de l’API C++, donc nous nous laissons la possibilité d’apporter des améliorations.
Pour `libmamba`, le terme _compatible en rétrocompatibilité_ est compris comme suit :

- _ABI compatible en rétrocompatibilité_ signifie que vous pouvez remplacer les fichiers binaires de la bibliothèque sans recompiler
  votre code avec les nouveaux en-têtes.
  Le comportement observé sera le même, excepté pour les bogues (qui devraient disparaître) et les performances.
- _API compatible en rétrocompatibilité_ signifie que vous devez recompiler votre code avec la nouvelle version de la bibliothèque,
  mais sans avoir besoin de modifier votre code, seulement de le reconstruire.
  Cela s’applique tant que vous n’utilisez aucune déclaration considérée comme privée, par exemple
  dans les sous-espaces de noms `detail`.
  Le comportement observé sera le même, excepté pour les bogues (qui devraient disparaître) et les performances.
  Lorsque des déclarations sont obsolètes mais non supprimées et toujours fonctionnelles, nous considérons également
  cela comme rétrocompatible, car seul le comportement observé lors de la compilation change.

Avec cela en tête, `libmamba` offre les garanties suivantes :

- Les versions `CORRECTIF` sont rétrocompatibles au niveau de l’API et de l’ABI ;
- Les versions `MINEUR` sont rétrocompatibles au niveau de l’API pour les déclarations dans `mamba/api`,
  Elles peuvent casser l’API ailleurs et l’ABI partout ;
- Les versions `MAJEUR` n’offrent aucune garantie.

### `libmambapy` (Python)

Pour `libmambapy`, le terme _API compatible en rétrocompatibilité_ implique que votre code Python fonctionnera de la même façon
avec une version plus récente de `libmambapy` tant que vous n’utilisez aucune déclaration considérée comme privée,
par exemple celles dont le nom commence par un `_`.
Le comportement observé sera le même, excepté pour les bogues (qui devraient disparaître) et les performances.
Lorsque des déclarations sont obsolètes mais non supprimées et toujours fonctionnelles, nous considérons également
cela comme rétrocompatible, car le comportement n’est observable qu’en activant l’avertissement Python
`DeprecationWarning`, qui n’est généralement activé qu’en développement.

Avec cela en tête, `libmambapy` offre les garanties suivantes :

- Les versions `CORRECTIF` sont rétrocompatibles au niveau de l’API ;
- Les versions `MINEUR` sont rétrocompatibles au niveau de l’API ;
- Les versions `MAJEUR` n’offrent aucune garantie.

### `mamba` et `micromamba` (exécutables)

Pour les exécutables, le terme _rétrocompatible_ s’applique aux entrées et sorties programmables et signifie
que votre code (y compris les scripts shell) fonctionnera avec les nouvelles versions de l’exécutable sans
modification.
Les entrées/sorties programmables incluent le nom de l’exécutable, les arguments de ligne de commande, les fichiers de configuration,
les variables d’environnement, les sorties JSON en ligne de commande et les fichiers créés.
Cela _exclut_ la sortie lisible par l’homme et les messages d’erreur, ainsi que les avertissements de dépréciation écrits
dans la sortie lisible par l’homme.

Avec cela en tête, `mamba` et `micromamba` offrent les garanties suivantes :

- Les versions `CORRECTIF` sont rétrocompatibles ;
- Les versions `MINEUR` sont rétrocompatibles ;
- Les versions `MAJEUR` n’offrent aucune garantie.

## Soutenez-nous

Seules les versions `mamba` et `micromamba` 2.0 et supérieures sont prises en charge et activement développées.

La branche `1.x` n’est maintenue que pour traiter les problèmes de sécurité tels que les CVE.

Pour toute question, vous pouvez également nous rejoindre sur le [Chat QuantStack](https://gitter.im/QuantStack/Lobby)
ou sur le [canal Conda](https://gitter.im/conda/conda) (notez que ce projet n’est pas officiellement affilié à `conda` ou Anaconda Inc.).

## Licence

Nous utilisons un modèle de droit d’auteur partagé qui permet à tous les contributeurs de conserver les droits d’auteur sur leurs contributions.

Ce logiciel est sous licence BSD-3-Clause. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

---

### Réunion de développement bimensuelle

Nous organisons des visioconférences toutes les deux semaines où nous discutons de nos avancées et recueillons des retours les uns des autres.

Tout le monde est le bienvenu, que ce soit pour discuter d’un sujet ou simplement pour écouter.

- Quand : mardi [16h00 CET (Europe)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Où : [Mamba jitsi](https://meet.jit.si/mamba-org)
- Quoi : [Notes de réunion](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---