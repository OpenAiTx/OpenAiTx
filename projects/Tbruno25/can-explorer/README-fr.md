<h1 align="center">
  <a href="https://github.com/tbruno25/can-explorer">
    <!-- Veuillez fournir le chemin vers votre logo ici -->
    <img src="https://github.com/Tbruno25/can-explorer/raw/main/docs/images/logo.png" alt="Logo" width="200" height="200">
  </a>
</h1>

<div align="center">
  can-explorer
  <br />
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=bug&template=01_BUG_REPORT.md&title=bug%3A+">Signaler un bug</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=enhancement&template=02_FEATURE_REQUEST.md&title=feature%3A+">Demander une fonctionnalité</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+">Poser une question</a>
</div>

<div align="center">
<br/>


[![Version PyPI](https://img.shields.io/pypi/v/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Versions Python](https://img.shields.io/pypi/pyversions/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Étoiles](https://img.shields.io/github/stars/tbruno25/can-explorer?color=mediumseagreen)](https://github.com/Tbruno25/can-explorer/stargazers)
</div>

---

## À propos

`can-explorer` est un outil de visualisation de bus CAN conçu pour aider à l'ingénierie inverse.

![Démo](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/demo.gif)

### En quoi cela m'aide-t-il ?
En affichant en continu toutes les charges utiles pour chaque ID CAN, repérer des tendances correspondant à une action spécifique peut devenir beaucoup plus facile à identifier.

Veuillez vous référer à cet [article précédent](https://tbruno25.medium.com/car-hacking-faster-reverse-engineering-using-canopy-be1955843d57) que j'ai écrit pour un exemple concret d'utilisation de cette approche afin de trouver quel ID contient les données du compteur de vitesse.


### Construit avec


[![DearPyGui](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/dearpygui-logo.png)](https://github.com/hoffstadt/DearPyGui)
[![PythonCan](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/pythoncan-logo.png)](https://github.com/hardbyte/python-can)

## Pour commencer

### Installation

[pipx](https://pypa.github.io/pipx/) est recommandé bien que tout gestionnaire de paquets supportant les fichiers `pyproject.toml` puisse être utilisé.

```sh
pipx install can-explorer
``` 

## Utilisation

L'interface graphique peut être lancée en exécutant l'une des commandes ci-dessous depuis un terminal.
```sh 
can-explorer
``` 

```sh 
python3 -m can_explorer
``` 

Avant de démarrer le visualiseur, vous ***devez*** naviguer vers l’onglet des paramètres et saisir la configuration de votre adaptateur d’interface pour créer une instance de bus. Veuillez consulter la [documentation python-can](https://python-can.readthedocs.io/en/stable/index.html) pour plus d’informations sur les différentes interfaces prises en charge.

L’interface graphique peut également être lancée avec un drapeau de démonstration qui sélectionnera automatiquement l’option d’interface virtuelle et commencera à diffuser des données CAN simulées dans un processus en arrière-plan.

```sh 
can-explorer --demo
``` 

## Support

Contactez le mainteneur à l’un des endroits suivants :
- [Problèmes GitHub](https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+)
- Options de contact listées sur [ce profil GitHub](https://github.com/tbruno25)

Si vous souhaitez dire **merci** ou/et soutenir le développement actif de can-explorer, envisagez d’ajouter une [étoile GitHub](https://github.com/tbruno25/can-explorer) au projet.


## Contribution

Veuillez lire [nos directives de contribution](https://raw.githubusercontent.com/Tbruno25/can-explorer/main/docs/CONTRIBUTING.md)

Pour une liste complète de tous les auteurs et contributeurs, voir [la page des contributeurs](https://github.com/tbruno25/can-explorer/contributors).

## Licence

Ce projet est sous licence **GNU General Public License v3**.

Voir [LICENSE](LICENSE) pour plus d’informations.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---