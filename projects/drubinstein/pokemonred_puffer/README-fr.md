# Pokemon Red (Édition RL)

![Tests](https://github.com/thatguy11325/pokemonred_puffer/actions/workflows/workflow.yml/badge.svg)

Ce dépôt est conçu comme une bibliothèque à utiliser pour le développement de Pokemon Red RL. Il contient quelques fonctions pratiques qui ne devraient pas être utilisées dans un cadre de bibliothèque et devraient être forkées. À l'avenir, ces fonctions pratiques seront migrées pour qu'aucun fork ne soit nécessaire.

## Démarrage rapide

### Installation

Pour installer la bibliothèque, vous pouvez soit

1. Cloner le dépôt sur votre machine locale et l'installer.
2. Forker le dépôt et cloner votre fork sur votre machine locale.

Par exemple,

```sh
pip3 install -e . 
```

### Exécution

Ci-dessous les commandes qui utilisent des arguments par défaut dans certains cas. Veuillez exécuter `python3 -m pokemonred_puffer.train --help` si vous ne savez pas comment utiliser les actions en ligne de commande associées à ce dépôt. Certaines commandes n'ont peut-être pas été testées récemment, veuillez donc créer une issue si vous en avez une.

Après l'installation, vous pouvez commencer l'entraînement en exécutant :

```sh
# Run before training to test what num_envs value you should use
python3 -m pokemonred_puffer.train autotune
# Default
python3 -m pokemonred_puffer.train train
```

### Balayages d'hyperparamètres multinœuds (en cours)

Si vous souhaitez effectuer des balayages d'hyperparamètres, vous pouvez le faire en installant les packages associés et en lançant deux commandes :

```sh
pip3 install -e '.[sweep]'
python3 -m pokemonred_puffer.sweep launch-sweep
python3 -m pokemonred_puffer.sweep launch-agent <sweep-id>
```

L’identifiant du balayage sera affiché lors du lancement du balayage. Pour reprendre un balayage, vous pouvez relancer votre balayage avec

```sh
python3 -m pokemonred_puffer.sweep launch-sweep --sweep-id <sweep-id>
```

Les balayages peuvent être configurés avec une configuration de balayage (par défaut `sweep-config.yaml`) et une configuration de base (par défaut `config.yaml`). Le balayage des hyperparamètres définit des bornes à l'aide de la configuration de balayage et centre les hyperparamètres sur les paramètres de la configuration de base. Pour en savoir plus sur l'algorithme des hyperparamètres, vous pouvez visiter [le dépôt CARBS d'Imbue](https://github.com/imbue-ai/carbs/tree/main).

N.B. Actuellement, les balayages sur un seul nœud ne sont pas pris en charge. Si cette fonctionnalité est souhaitée, veuillez créer une issue.

### Modification pour l'entraînement

Vous avez un run en cours, mais vous voulez le modifier, que faire ?

Vous avez plusieurs options :

1. Commencer à modifier les paramètres dans `config.yaml`
2. Commencer à modifier le code directement (plus d'infos plus tard).
3. Utiliser ce dépôt comme une bibliothèque et créer vos propres wrappers.

### Débogage
Si vous voulez tester vos modifications, vous pouvez exécuter 

```sh
python3 -m pokemonred_puffer.train --config config.yaml --debug
```

En cas d'urgence, il est conseillé de retirer les appels à la fonction `send_input` dans `environment.py` afin de pouvoir tester les récompenses selon votre propre rythme et non celui du modèle.

## Structure du Répertoire

Ce dépôt est destiné à être utilisé éventuellement comme une bibliothèque. Tous les fichiers source doivent être sous le répertoire `pokemonred_puffer`. Si vous souhaitez ajouter un module avec un `__main__`, n’hésitez pas, mais sous le répertoire `pokemonred_puffer`. Par la suite, vous devriez pouvoir exécuter votre main avec `python3 -m pokemonred_puffer.<votre-module>`

Dans le répertoire `pokemonred_puffer`, on trouve les fichiers et répertoires suivants :

- `policies` : Un répertoire pour différentes politiques pour exécuter le modèle.
- `rewards` : Un répertoire de classes `gym.Env` qui suivent les récompenses pour un objet `RedGymEnv` (environnement gym pour Pokemon Red).
- `wrappers` : Un répertoire de wrappers que vous pouvez vouloir utiliser, par exemple la journalisation vers le [Pokemon Red Map Visualizer](https://pwhiddy.github.io/pokerl-map-viz/).
- `cleanrl_puffer.py` - Responsable de l’exécution de la logique d’entraînement réelle
- `environment.py` - La logique centrale de l’environnement Pokemon Red Gym.
- `eval.py` - Pour générer des visualisations pour la journalisation durant l’entraînement.
- `kanto_map_dsv.png` - Une carte haute résolution de la région de Kanto.
- `train.py` - Un script et point d’entrée pour démarrer l’entraînement.

## Faire des Modifications

Pour des modifications simples, vous pouvez mettre à jour `config.yaml` directement. `config.yaml` a quelques règles importantes. Pour `wrappers`, `rewards` et `policies`, le wrapper, la récompense ou la politique _doit_ être indexé par `module_name.class_name`. Ces sections peuvent contenir plusieurs types de `wrappers`, `rewards` ou `policies`. La structure générale est `étiquette : arguments pour la classe`. Ceci est en place jusqu’à ce qu’une meilleure méthode avec moins d’indirections soit trouvée.

### Ajouter des Wrappers

Pour ajouter des wrappers, ajoutez une nouvelle classe héritant de `gym.Wrapper` dans le répertoire `wrappers`. Puis mettez à jour la section `wrappers` de `config.yaml`. Les wrappers enveloppent l’environnement de base dans l’ordre, de haut en bas. La liste des wrappers n’est _pas_ indexée par le chemin de classe. C’est un nom unique qui distingue la collection de wrappers.

### Ajouter des Récompenses

Pour ajouter des récompenses, ajoutez une nouvelle classe dans le répertoire `rewards`. Puis mettez à jour la section `rewards` de `config.yaml`. Une section de récompenses est indexée par le chemin de classe.

### Ajouter des Politiques

Pour ajouter des politiques, ajoutez une nouvelle classe dans le répertoire `policies`. Puis mettez à jour la section `policies` de `config.yaml`. Une section de politique est indexée par le chemin de classe. Il est supposé qu’une politique récurrente vivra dans le même module que la politique qu’elle enveloppe.

## Développement

Ce dépôt utilise [pre-commit](https://pre-commit.com/) pour appliquer le formatage et le linting. Pour le développement, veuillez installer ce dépôt avec :

```sh
pip3 install -e '.[dev]'
pre-commit install
```
Pour toute modification, veuillez soumettre une PR.

## Auteurs

[David Rubinstein](https://github.com/drubinstein), [Keelan Donovan](https://github.com/leanke), [Daniel Addis](https://github.com/xinpw8), Kyoung Whan Choe, [Joseph Suarez](https://puffer.ai/), [Peter Whidden](https://peterwhidden.webflow.io/)

<a href="https://star-history.com/#drubinstein/pokemonred_puffer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
   <img alt="Graphique de l'historique des étoiles" src="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
 </picture>
</a>

[![](https://raw.githubusercontent.com/drubinstein/pokemonred_puffer/main/assets/puffer.png)](https://puffer.ai)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-26

---