Ceci est Python version 3.15.0 alpha 0
=======================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: Statut de la build CPython sur GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Statut de la build CPython sur Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Chat Discourse Python
   :target: https://discuss.python.org/


Copyright © 2001 Python Software Foundation.  Tous droits réservés.

Voir la fin de ce fichier pour plus d’informations sur les droits d’auteur et la licence.

.. contents::

Informations générales
----------------------

- Site web : https://www.python.org
- Code source : https://github.com/python/cpython
- Suivi des problèmes : https://github.com/python/cpython/issues
- Documentation : https://docs.python.org
- Guide du développeur : https://devguide.python.org/

Contribuer à CPython
--------------------

Pour des instructions plus complètes sur la contribution au développement de CPython,
voir le `Guide du Développeur`_.

.. _Guide du Développeur: https://devguide.python.org/

Utiliser Python
---------------

Des kits Python installables et des informations sur l’utilisation de Python sont disponibles sur
`python.org`_.

.. _python.org: https://www.python.org/

Instructions de compilation
---------------------------

Sur Unix, Linux, BSD, macOS et Cygwin ::

    ./configure
    make
    make test
    sudo make install

Ceci installera Python sous le nom de ``python3``.

Vous pouvez passer de nombreuses options au script configure ; exécutez ``./configure --help``
pour en savoir plus.  Sur les systèmes de fichiers insensibles à la casse de macOS et sur Cygwin,
l’exécutable s’appelle ``python.exe`` ; ailleurs, c’est simplement ``python``.

La construction d’une installation complète de Python nécessite l’utilisation de diverses
bibliothèques tierces supplémentaires, en fonction de votre plateforme de compilation et des
options de configuration.  Tous les modules de la bibliothèque standard ne sont pas compilables ou
utilisables sur toutes les plateformes.  Reportez-vous à la section
`Installer les dépendances <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
du `Guide du Développeur`_ pour des informations détaillées à jour sur
les dépendances pour diverses distributions Linux et macOS.

Sur macOS, il existe des options supplémentaires de configuration et de compilation liées
au framework macOS et aux builds universelles.  Voir `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

Sous Windows, voir `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Pour construire l’installateur Windows, voir `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Si vous le souhaitez, vous pouvez créer un sous-répertoire et invoquer configure à partir de là.
Par exemple ::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Cela échouera si vous avez *aussi* compilé dans le répertoire de niveau supérieur.  Vous devez d’abord faire
un ``make clean`` dans le répertoire principal.)

Pour obtenir une compilation optimisée de Python, lancez ``configure --enable-optimizations``
avant d’exécuter ``make``.  Cela configure les cibles make par défaut pour activer
l’Optimisation Guidée par le Profil (PGO) et peut être utilisé pour activer automatiquement l’Optimisation
au Moment de l’Édition des Liens (LTO) sur certaines plateformes.  Pour plus de détails, voir les sections
ci-dessous.

Optimisation guidée par le profil
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO exploite les versions récentes des compilateurs GCC ou Clang.  Si utilisé,
soit via ``configure --enable-optimizations``, soit en exécutant manuellement
``make profile-opt`` indépendamment des options de configure, le processus de compilation optimisée
effectuera les étapes suivantes :

Le répertoire Python entier est nettoyé des fichiers temporaires qui pourraient
résulter d’une compilation précédente.

Une version instrumentée de l’interpréteur est construite, en utilisant les options de compilation appropriées
pour chaque type. Notez qu’il ne s’agit que d’une étape intermédiaire.  Le
binaire résultant de cette étape n’est pas adapté à un usage réel car il contient
des instructions de profilage intégrées.

Après la construction de l’interpréteur instrumenté, le Makefile exécute une charge de travail d’entraînement.
Ceci est nécessaire pour profiler l’exécution de l’interpréteur.
Notez également que toute sortie, stdout et stderr, pouvant apparaître à cette étape
est supprimée.

L’étape finale consiste à construire l’interpréteur réel, en utilisant les informations
collectées à partir de la version instrumentée.  Le résultat final sera un binaire Python
optimisé, adapté à la distribution ou à l’installation en production.


Optimisation au moment de l’édition des liens
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Activée via l’option ``--with-lto`` de configure.  LTO exploite la
capacité des chaînes d’outils des compilateurs récents à optimiser au-delà de la limite
arbitraire des fichiers ``.o`` lors de la création des exécutables finaux ou des bibliothèques partagées,
pour des gains de performance supplémentaires.


Nouveautés
----------

Nous proposons un aperçu complet des changements dans le document `Quoi de neuf dans Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_.  Pour un journal des modifications plus
détaillé, lisez `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, mais une liste exhaustive
des changements ne peut être obtenue qu’à partir de l’`historique des commits
<https://github.com/python/cpython/commits/main>`_.

Si vous souhaitez installer plusieurs versions de Python, consultez la section ci-dessous
intitulée « Installer plusieurs versions ».


Documentation
-------------

La `documentation pour Python 3.15 <https://docs.python.org/3.15/>`_ est en ligne,
mise à jour quotidiennement.

Elle peut également être téléchargée dans de nombreux formats pour un accès plus rapide.  La documentation
est téléchargeable en formats HTML, PDF et reStructuredText ; cette dernière version
est principalement destinée aux auteurs de documentation, traducteurs et personnes ayant des
exigences de formatage particulières.

Pour des informations sur la construction de la documentation de Python, reportez-vous à `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Tests
-----

Pour tester l’interpréteur, tapez ``make test`` dans le répertoire principal.  Le
jeu de tests produit une certaine sortie.  Vous pouvez généralement ignorer les messages concernant
les tests ignorés dus à des fonctionnalités optionnelles qui ne peuvent pas être importées.  Si un message
est affiché concernant un test échoué ou si une trace ou un core dump est produit,
il y a un problème.

Par défaut, les tests sont empêchés de surconsommer des ressources comme l’espace disque et
la mémoire.  Pour activer ces tests, exécutez ``make buildbottest``.

Si des tests échouent, vous pouvez relancer le(s) test(s) échoué(s) en mode verbeux.  Par
exemple, si ``test_os`` et ``test_gdb`` échouent, vous pouvez lancer ::

    make test TESTOPTS="-v test_os test_gdb"

Si l’échec persiste et semble être un problème avec Python plutôt qu’avec
votre environnement, vous pouvez `soumettre un rapport de bug
<https://github.com/python/cpython/issues>`_ et inclure la sortie pertinente de
cette commande pour montrer le problème.

Voir `Exécuter & écrire des tests <https://devguide.python.org/testing/run-write-tests.html>`_
pour plus d’informations sur l’exécution des tests.

Installer plusieurs versions
----------------------------

Sur les systèmes Unix et Mac, si vous prévoyez d’installer plusieurs versions de Python
en utilisant le même préfixe d’installation (argument ``--prefix`` au script configure),
vous devez vous assurer que votre exécutable python principal ne soit pas
écrasé par l’installation d’une version différente.  Tous les fichiers et
répertoires installés via ``make altinstall`` contiennent le numéro de version majeur et mineur et peuvent donc coexister.  ``make install`` crée également
``${prefix}/bin/python3`` qui fait référence à ``${prefix}/bin/python3.X``.  Si vous
souhaitez installer plusieurs versions avec le même préfixe, vous devez décider laquelle
(éventuellement) sera votre version « principale ».  Installez cette version en utilisant
``make install``.  Installez toutes les autres versions en utilisant ``make altinstall``.

Par exemple, si vous souhaitez installer Python 2.7, 3.6 et 3.15 avec 3.15 comme
version principale, vous devez exécuter ``make install`` dans votre répertoire de compilation de 3.15
et ``make altinstall`` dans les autres.


Calendrier de publication
-------------------------

Voir `PEP 790 <https://peps.python.org/pep-0790/>`__ pour les détails de la publication de Python 3.15.


Informations sur le copyright et la licence
-------------------------------------------


Copyright © 2001 Python Software Foundation.  Tous droits réservés.

Copyright © 2000 BeOpen.com.  Tous droits réservés.

Copyright © 1995-2001 Corporation for National Research Initiatives.  Tous droits réservés.

Copyright © 1991-1995 Stichting Mathematisch Centrum.  Tous droits réservés.

Voir le fichier `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ pour
des informations sur l’historique de ce logiciel, les conditions d’utilisation, et une
DÉCLARATION DE NON-GARANTIE.

Cette distribution Python ne contient *aucun* code relevant de la licence GNU General Public License (GPL),
elle peut donc être utilisée dans des projets propriétaires. Il existe des interfaces vers certains
codes GNU mais celles-ci sont entièrement optionnelles.

Toutes les marques citées ici sont la propriété de leurs détenteurs respectifs.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---