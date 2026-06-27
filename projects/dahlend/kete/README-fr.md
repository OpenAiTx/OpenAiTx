<p align="center">
<img src="https://github.com/dahlend/kete/blob/main/docs/_static/kete.svg" style="width:20%">
</p> 

# *Kete*

Prédire les orbites des astéroïdes et des comètes à grande échelle.

Voir l’[article arXiv](http://arxiv.org/abs/2509.04666).

![Github Actions](https://github.com/dahlend/kete/actions/workflows/test-lint.yml/badge.svg?branch=main)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.15259732.svg)](https://doi.org/10.5281/zenodo.15259732)
[![arXiv](https://img.shields.io/badge/arXiv-2509.04666-00ff00.svg)](http://arxiv.org/abs/2509.04666)

Les outils kete sont conçus pour permettre la simulation d’enquêtes tout-sky de petits
planètes. Cela inclut la dynamique orbitale multi-corps en physique, la détermination et
l’ajustement des orbites, la modélisation thermique et optique des objets, ainsi que les
corrections de champ de vision et de délai lumineux. Ces outils, en conjonction avec
les bases de données du Minor Planet Center (MPC) et du JPL sur les astéroïdes connus,
peuvent être utilisés non seulement pour planifier des enquêtes, mais aussi pour prédire
les objets visibles lors d’enquêtes existantes ou passées.

L’objectif principal de kete est de fournir un ensemble d’outils capable d’opérer sur le
catalogue complet du MPC en une seule fois, sans avoir à faire de requêtes sur des
objets spécifiques. Il a été utilisé pour simuler plus de 10 ans de temps d’enquête pour
la mission NEO Surveyor en utilisant 10 millions d’astéroïdes de la ceinture principale
et proches de la Terre.

[Documentation](https://dahlend.github.io/kete/)  
   - [Exemples](https://dahlend.github.io/kete/auto_examples/index.html)
   - [Tutoriels](https://dahlend.github.io/kete/tutorials/index.html)


https://github.com/user-attachments/assets/a48491d8-9c15-4659-9022-1767a3aa1e94

Voici une simulation de ce que l’enquête ZTF observerait durant toute l’année 2023.
Il s’agit de chaque position de chaque astéroïde numéroté, ainsi que d’un calcul des
magnitudes attendues en bande V. Si la magnitude attendue est inférieure à la limite
de magnitude rapportée par ZTF pour la trame spécifique, alors l’objet clignotera en
gris clair.

Cela a pris environ 50 minutes sur un ordinateur de bureau pour le calcul, et environ
40 minutes pour générer la vidéo.

Kete peut être utilisé pour répondre à de nombreuses questions, par exemple, identifier tous les astéroïdes connus  
dans une [image donnée](https://dahlend.github.io/kete/tutorials/kona.html).

Kete peut également être utilisé comme backend pour des visualisations plus ludiques, telles que :  

[Ketev](https://dahlend.github.io/ketev/) - Visualiseur du système solaire dans votre navigateur


## Installation

Kete peut être installé en utilisant pip :

``` bash
pip install kete
```

## Exemple de code

Voici un petit exemple montrant à quoi ressemble la programmation avec kete.
Cela calcule la distance la plus proche à laquelle l’astéroïde Apophis passera
lors de son approche *très* rapprochée de la Terre en avril 2029.

Un examen plus approfondi de cet exemple peut être trouvé
[ici](https://dahlend.github.io/kete/auto_examples/plot_close_approach.html).

```python

      import kete
      import numpy as np

      # Date of impact +- 1 day in Julian Date
      jd_center = kete.Time.from_ymd(2029, 4, 13.9066).jd

      # Step the orbit every 1 minute for +- 1 day.
      step_size = 1 / 24 / 60
      jd_range = np.arange(-1, 1, step_size) + jd_center

      # load Apophis from JPL Horizons
      obj = kete.HorizonsProperties.fetch("Apophis")
      cur_state = obj.state

      # keep track the the closest approach
      closest_approach = [np.inf, 0]
      for jd in jd_range:
            # propagate the object, and include the massive main belt asteroids
            cur_state = kete.propagate_n_body(cur_state, jd, include_asteroids=True)

            # calculate position relative to earth
            earth_vec = cur_state.pos - kete.spice.get_state("Earth", cur_state.jd).pos
            earth_dist = earth_vec.r * kete.constants.AU_KM
            if earth_dist < closest_approach[0]:
                  closest_approach = [earth_dist, cur_state.jd]

      print("Closest approach is on:")
      print(kete.Time(closest_approach[1]).iso)
      print(f"At a distance of about {closest_approach[0]:0.0f} km")
      #  Closest approach is on:
      #  2029-04-13T21:45:30.239+00:00
      #  At a distance of about 38015 km

```
## Nom

'Kete' vient de la mythologie grecque ancienne, signifiant monstres marins, et est la racine du mot
pour les Cétacés (Baleines).

## Licence :

La version originale de ce code a été développée pendant que l'auteur original (Dar Dahlen)
travaillait au Caltech IPAC. Ceci est un fork de ce dépôt où le travail continuera en tant que
projet personnel. La différence entre ce fork et le code précédent est sous licence
BSD 3-Clause mais le copyright appartient à Dar Dahlen & aux futurs collaborateurs.

### Unités et cadre de référence

Kete utilise le cadre de référence ICRF comme cadre de coordonnées de base, avec des unités en UA,
avec le temps en JD avec une échelle de Temps Dynamique Barycentrique (TDB). En interne, ce cadre est
converti en un système de coordonnées Écliptique défini par l'angle d'obliquité
utilisé par JPL Horizons, qui est le modèle IAU76/80 défini dans le cadre J2000.

      - https://fr.wikipedia.org/wiki/Inclinaison_axiale#Court_terme
      - https://ssd.jpl.nasa.gov/horizons/manual.html#defs

JPL Horizons et le Centre des Planètes Mineures (MPC) utilisent ce cadre de coordonnées, qui est
essentiellement équivalent aux coordonnées Écliptiques J2000. Des outils de conversion sont disponibles dans
kete qui permettent la conversion vers le cadre Équatorial et vers diverses variantes du temps.

### Répertoire de cache

De nombreuses opérations dans kete entraînent le téléchargement de divers fichiers. Ces fichiers sont mis en cache
automatiquement, le répertoire où ce cache est stocké peut être défini en réglant la
variable d'environnement `KETE_CACHE_DIR`. Le répertoire par défaut est `~/.kete/`.


``` bash
export KETE_CACHE_DIR="~/.kete/"
```

### Utilisation avec des conteneurs - Docker/Podman

Notez que kete télécharge plusieurs gros fichiers de noyau SPICE lors de la première utilisation, qui sont
enregistrés dans un répertoire cache.

**Important pour Docker/Podman :**
- Si vous déclenchez le téléchargement **pendant la construction Docker** (par ex.,
  `RUN python -c "import kete"`), les fichiers seront intégrés dans l'image.
- Si vous sautez cette étape, les fichiers seront téléchargés à la première exécution du conteneur mais
  **seront perdus lorsque le conteneur s'arrête** à moins d'utiliser un montage de volume pour le répertoire cache.

**Approche recommandée pour le Dockerfile :**

```dockerfile
RUN pip install kete && \
    python -c "import kete"  # Triggers kernel downloads during build
```
Cela garantit que les noyaux SPICE font partie de votre image et n'ont pas besoin d'être retéléchargés.

# Informations pour les développeurs :

Les informations ci-dessous sont destinées aux développeurs et ne sont pas nécessaires pour les utilisateurs finaux.

## Installation - Depuis les sources

Si kete est compilé depuis les sources, le compilateur Rust doit être installé. Les instructions d'installation
peuvent être trouvées ici :

https://www.rust-lang.org/learn/get-started

Assurez-vous que votre Python est à jour, ce code fonctionne avec Python 3.9+.

``` bash
python --version
```

Assurez-vous que votre pip est à jour, il doit être au minimum en version `22.0.0`.
``` bash
pip --version
```

Cela peut être mis à jour en utilisant :
``` bash
python -m pip install "pip>=22.0.0" --upgrade
pip install setuptools --upgrade
```

### Développement

Si vous envisagez de faire du développement, il est recommandé d’installer avec ce qui suit :
``` bash
pip install '.[dev]'
```
Le `[dev]` dans cette ligne a pip installé un certain nombre de dépendances optionnelles qui
sont utiles pour le développement. Y compris pytest et les outils de documentation.

### Construction de la documentation

Pour que la documentation soit construite, certaines bibliothèques Python supplémentaires sont nécessaires.
Celles-ci peuvent être installées avec :
``` bash
pip install sphinx sphinx_gallery autodoc
```
Une fois cela installé, la documentation peut être générée en exécutant à l’intérieur du  
répertoire kete.
``` bash
(cd docs && make html && open html/index.html&)
```
Une fois que cela a terminé de s'exécuter, ouvrez le fichier `kete/docs/html/index.html` pour accéder
à la documentation HTML.

Pour nettoyer la précédente construction des docs :
``` bash
(cd docs && make clean)
```

Les tests de documentation peuvent être exécutés avec :
``` bash
(cd docs && make doctest)
```

### Exécution des tests

L'exécution des tests nécessite que les paquets `pytest` et `pytest-cov` soient installés.

Ouvrez un terminal à la racine de ce dossier et exécutez la commande suivante :
``` bash
pytest --cov-report term-missing --cov=kete   
```

Un autre type de rapport de couverture est HTML, cela générera un dossier appelé `htmlcov`
dans le répertoire où la commande a été exécutée, puis vous pourrez ouvrir le fichier `htmlcov/index.html`.
Il s'agit d'une représentation conviviale du site web de la couverture du code.
``` bash
pytest --cov-report html --cov=kete   
```

### Exécution des tutoriels

Les tutoriels sont des exemples coûteux en calcul qui sont plus représentatifs de l'utilisation typique attendue.  
Étant donné que ces exemples sont très coûteux à exécuter, ils ne sont pas lancés sauf  
manuellement. Un script python pratique a été fourni pour faire exactement cela.

``` bash
cd docs
python utils.py
```

### Exécution des Benchmarks

Il existe une suite de tests de micro-benchmarks dans le backend Rust de kete. Ceux-ci nécessitent
l'installation de `gnuplot`, et peuvent être exécutés avec la commande suivante :

``` bash
cargo bench
open target/criterion/report/index.html
```

De plus, des Flamegraphs peuvent être produits en utilisant ce qui suit :

``` bash
cargo bench --bench propagation -- --profile-time=5
cargo bench --bench spice -- --profile-time=5
cargo bench --bench thermal -- --profile-time=5
```

Ces flamegraphs seront placés dans `target/criterion/*/profile/flamegraph.svg`. Ouvrir
ces fichiers dans un navigateur web affichera quelles fonctions sont utilisées pendant le bench.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-27

---