    Copyright (C) 2013-2018 Christian Thomas Jacobs.

    Ce fichier fait partie de PyQSO.

    PyQSO est un logiciel libre : vous pouvez le redistribuer et/ou le modifier
    selon les termes de la Licence Publique Générale GNU telle que publiée par
    la Free Software Foundation, soit la version 3 de la licence, soit
    (à votre choix) toute version ultérieure.

    PyQSO est distribué dans l'espoir qu'il sera utile,
    mais SANS AUCUNE GARANTIE ; sans même la garantie implicite de
    QUALITÉ MARCHANDE ou D'ADAPTATION À UN USAGE PARTICULIER. Consultez la
    Licence Publique Générale GNU pour plus de détails.

    Vous devriez avoir reçu une copie de la Licence Publique Générale GNU
    avec PyQSO. Sinon, consultez <http://www.gnu.org/licenses/>.

# PyQSO

PyQSO est un outil de journal de contacts pour les opérateurs radioamateurs.

[![Statut de la documentation](https://readthedocs.org/projects/pyqso/badge/?version=latest)](https://readthedocs.org/projects/pyqso/?badge=latest)

## Dépendances

Comme son nom l'indique, PyQSO est principalement écrit en langage de programmation [Python](https://www.python.org/) (version 3.x). L'interface graphique utilisateur a été développée en utilisant la [bibliothèque GTK+](https://www.gtk.org/) via les liaisons [PyGObject](https://pygobject.readthedocs.io). Par conséquent, pour exécuter PyQSO, l'interpréteur Python doit être présent sur votre système ainsi que le support de GTK+. Sur de nombreux systèmes basés sur Linux, cela peut être réalisé en installant les paquets Debian suivants :

* python3
* gir1.2-gtk-3.0
* python3-gi-cairo

Plusieurs paquets supplémentaires sont nécessaires pour activer toutes les fonctionnalités de PyQSO. Beaucoup d'entre eux (spécifiés dans le fichier `requirements.txt`) peuvent être facilement installés globalement en utilisant le gestionnaire de paquets Python en exécutant la commande suivante dans le terminal :

    sudo pip3 install -U -r requirements.txt

mais la liste complète est donnée ci-dessous :

* python3-matplotlib (version 1.3.0 ou ultérieure)
* python3-numpy
* libxcb-render0-dev
* [cartopy](http://scitools.org.uk/cartopy/), pour dessiner la carte du monde. Ce paquet dépend à son tour de python3-scipy, python3-cairocffi, cython, libproj-dev (version 4.9.0 ou ultérieure), et libgeos-dev (version 3.3.3 ou ultérieure).
* [geocoder](https://pypi.python.org/pypi/geocoder), pour les recherches QTH.
* python3-sphinx, pour construire la documentation.
* python3-hamlib, pour le support Hamlib.

### Support Hamlib

Il n’existe actuellement pas de paquet Debian compatible Python 3 pour [Hamlib](http://www.hamlib.org). Cette bibliothèque doit être compilée manuellement pour activer le support Hamlib. Selon les instructions sur la [liste de diffusion Hamlib](https://sourceforge.net/p/hamlib/mailman/message/35692744/), exécutez les commandes suivantes dans le répertoire racine de Hamlib (vous devrez peut-être exécuter `sudo apt-get install build-essential autoconf automake libtool` auparavant) :

    export PYTHON=/usr/bin/python3
    autoreconf --install
    ./configure --with-python-binding
    make
    sudo make install

Vous devrez également ajouter les répertoires `bindings` et `bindings/.libs` de Hamlib à la variable `PYTHONPATH` :

    export PYTHONPATH=$PYTHONPATH:/path/to/hamlib/bindings:/path/to/hamlib/bindings/.libs

## Installation et exécution

En supposant que le répertoire de travail actuel soit le répertoire de base de PyQSO (le répertoire contenant le `Makefile`), PyQSO peut être exécuté sans installation en lançant la commande suivante dans le terminal :

    python3 bin/pyqso

Si le gestionnaire de paquets Python `pip3` est disponible sur votre système, PyQSO peut être installé globalement en utilisant :

    sudo make install

Une fois installé, la commande suivante lancera PyQSO :

    pyqso

## Documentation

Des instructions sur l’utilisation de PyQSO sont disponibles sur [Read the Docs](http://pyqso.readthedocs.io/) et dans la vidéo ci-dessous.

[![PyQSO : un outil de journalisation pour opérateurs radioamateurs](https://img.youtube.com/vi/sVdZl9KnDsk/0.jpg)](https://www.youtube.com/watch?v=sVdZl9KnDsk)

La documentation peut également être construite localement avec la commande suivante :

    make docs

qui produira une version HTML de la documentation dans `docs/build/html` pouvant être ouverte dans un navigateur web.

## Contact

Veuillez signaler tout problème technique ou suggestion de fonctionnalité concernant PyQSO sur le suivi des issues GitHub.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---