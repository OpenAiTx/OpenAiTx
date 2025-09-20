# kubectl-tmux-exec

![GitHub release version](https://img.shields.io/github/v/release/predatorray/kubectl-tmux-exec)
![License](https://img.shields.io/github/license/predatorray/kubectl-tmux-exec)
![Build Status](https://img.shields.io/github/actions/workflow/status/predatorray/kubectl-tmux-exec/ci.yml?branch=master)
![GitHub all releases](https://img.shields.io/github/downloads/predatorray/kubectl-tmux-exec/total)

A **kubectl** plugin for executing commands interactively across multiple pods or containers using [**tmux**](https://github.com/tmux/tmux),
like `csshX` or `pssh` but for **Kubernetes**.

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot.png?raw=true)

To execute command across all the Nginx containers using `bash` for example, run:

```sh
kubectl tmux-exec -l app=nginx /bin/bash
```
## Installation 

### Homebrew

> **Note** : Ceci est uniquement pour les utilisateurs Mac.

1. Installez [Homebrew](https://brew.sh/).

2. `brew install predatorray/brew/kubectl-tmux-exec`

Enfin, assurez-vous que `/usr/local/bin/kubectl-tmux_exec` est dans votre `$PATH`.

### Krew

> **Note** : Il est recommandé pour les utilisateurs Linux.
> 
> Bien que cela fonctionne à la fois sur Mac et Linux, ce n’est pas recommandé pour les utilisateurs Mac, car vous pourriez encore avoir besoin d’installer la dépendance `gnu-getopt` avec l’aide de Homebrew.

1. Installez [Krew](https://krew.sigs.k8s.io/) en suivant [le guide utilisateur](https://krew.sigs.k8s.io/docs/user-guide/setup/install/).

2. `kubectl krew install tmux-exec`

3. Installez les dépendances. ([Wiki : Comment-Installer-les-Dépendances](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

### Manuellement

1. Téléchargez la [dernière version](https://github.com/predatorray/kubectl-tmux-exec/releases/latest).

2. Décompressez le fichier kubectl-tmux-exec-*.tar.gz et copiez tous les fichiers dans un répertoire, par exemple `/usr/local/kubectl-tmux-exec`.

3. Ajoutez le répertoire `bin/` à votre `$PATH`. Par exemple, ajoutez cette ligne à votre fichier rc : `export PATH="$PATH:/usr/local/kubectl-tmux-exec/bin"`.

4. Installez les dépendances. ([Wiki : Comment-Installer-les-Dépendances](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

## Utilisation

Assurez-vous d’avoir `kubectl` ≥ 1.12 ([support des plugins]), idéalement la dernière version.

Sinon, exécutez le script directement : `kubectl-tmux_exec [...ARGS]`.


Vérifiez si le script a été ajouté avec succès en :

```sh
kubectl plugin list
```
La sortie devrait être comme


```txt
The following compatible plugins are available:

/usr/local/bin/kubectl-tmux_exec
```

Si cela n'apparaît pas dans la liste, vérifiez à nouveau la variable d'environnement `$PATH`.

Vous pouvez utiliser la commande ci-dessous pour obtenir l'utilisation du script.

```sh
kubectl tmux-exec --help

# or
kubectl-tmux_exec --help
```

### Options

| Drapeau                         | Utilisation                                                                                                                                                 |
|---------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `-V`<br>`--version`             | Affiche les informations de version                                                                                                                        |
| `-l`<br>`--selector`            | Sélecteur (requête d’étiquette) pour filtrer, prend en charge '=', '==', et '!='. (ex. -l key1=value1,key2=value2)<br>Vous devez utiliser soit `--selector` soit `--file`. |
| `-f`<br>`--file`                | Lit les noms des pods ligne par ligne depuis un fichier.<br>Vous devez utiliser soit `--selector` soit `--file`.                                            |
| `-c`<br>`--container`           | Nom du conteneur. Si omis, le premier conteneur dans le pod sera choisi                                                                                     |
| `-i`<br>`--stdin`               | Passe stdin au conteneur (**obsolète**, car activé par défaut)                                                                                               |
| `-t`<br>`--tty`                 | Stdin est un TTY (**obsolète**, car activé par défaut)                                                                                                      |
| `-d`<br>`--detach`              | Détache la session Tmux                                                                                                                                     |
| `-n`<br>`--namespace=`          | Le scope du namespace pour cette requête CLI (peut être appliqué plusieurs fois)                                                                            |
| `--context`                     | Le nom du contexte kubeconfig à utiliser (peut être appliqué plusieurs fois)                                                                                |
| `-A`<br>`--all-namespaces`      | Si présent, liste et exécute l’objet demandé à travers tous les namespaces. Le namespace dans le contexte actuel est ignoré même s’il est spécifié avec --namespace. |
| `-C`<br>`--enable-control-mode` | Démarre tmux en mode contrôle et l’écho est désactivé. (Voir : [Intégration iTerm2](#iterm2-integration))                                                    |
| `--remain-on-exit`              | Laisse la fenêtre Tmux ouverte à la sortie                                                                                                                  |
| `--select-layout`               | L’un des cinq agencements prédéfinis Tmux : even-horizontal, even-vertical, main-horizontal, main-vertical, ou tiled.                                      |
| `--session-mode`                | Où tmux est ouvert : auto, new-session, current-session                                                                                                    |

L’utilisation de ces options est également disponible via `--help`.

### Exemple

Le `tmux-exec` est similaire à `exec`, sauf qu’il nécessite des sélecteurs d’étiquettes tandis que `exec` nécessite un nom de pod.

Pour lancer `bash` dans tous les conteneurs de pods qui partagent certaines étiquettes communes, `foo=bar` par exemple.

```sh
kubectl tmux-exec -l foo=bar /bin/bash
```

Après avoir réussi à `bash` dans vos conteneurs sélectionnés, une fenêtre Tmux s'ouvre en fait, où chaque volet affiche le résultat d'exécution de chaque conteneur de pod. Vos entrées clavier seront synchronisées sur tous ces volets.

Si vous n'êtes pas familier avec Tmux, vous pouvez consulter la page de manuel de tmux ou des tutoriels en ligne. Ou vous pouvez voir la [feuille de référence](#tmux-cheatsheet) ci-dessous, ce qui sera suffisant je pense.

### Intégration iTerm2

Avec `-C` ou `--enable-control-mode`, il fonctionne en mode contrôle et délègue l'entrée des volets à la fonction "Broadcast Input" de [iTerm2],
pas besoin de raccourcis tmux.

Utilisez <kbd>⌘</kbd> + <kbd>⌥</kbd> + <kbd>i</kbd> pour activer ou désactiver la diffusion dans iTerm2. (`synchronize-panes` sera désactivé automatiquement dans ce mode.)

(voir : [Intégration tmux](https://iterm2.com/documentation-tmux-integration.html) pour plus d'informations)

#### Exemple

```sh
kubectl tmux-exec -C -l app=nginx /bin/bash
```

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot-iterm2-integration.png?raw=true)

### Auto-complétion du Shell

Veuillez consulter [ce wiki](https://github.com/predatorray/kubectl-tmux-exec/wiki/Shell-Auto-completion) pour plus d'informations.

### Rappel des commandes Tmux

Toutes les commandes Tmux commencent par un `PREFIX`. Par défaut, le `PREFIX` est <kbd>Ctrl</kbd> + <kbd>b</kbd>. J'utiliserai `C-b` ci-dessous pour le représenter.

`C-b d`, détacher de la session. Après cela, Tmux continuera de fonctionner en arrière-plan. Vous pouvez taper `tmux a` pour vous rattacher.

`C-b :setw synchronize-panes off`, désactive la synchronisation des entrées sur tous les volets.

`C-b :setw synchronize-panes on`, active la synchronisation des entrées sur tous les volets.

`C-b <TOUCHE-FLÈCHE>`, déplacer le curseur entre les volets.

`C-b xy`, fermer le volet actuel.

`C-b &y`, fermer la fenêtre incluant tous les volets.

## Communauté & Support

- Signaler des problèmes ou demander des fonctionnalités via [GitHub Issues]((https://github.com/predatorray/kubectl-tmux-exec/issues/new))
- Rejoignez le [Groupe Google](https://groups.google.com/g/kubectl-tmux-exec) pour les discussions

## Autres plugins

[kubectl-alias](https://github.com/predatorray/kubectl-alias) : la commande alias manquante pour kubectl.

## Offrez-moi un café

Si cela vous fait gagner du temps, n’hésitez pas à [m’offrir un café] 🙌

[![](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)][offrez-moi un café]

[offrez-moi un café]: https://buymeacoffee.com/predatorray
[iTerm2]: https://iterm2.com/index.html
[support des plugins] : https://kubernetes.io/docs/tasks/extend-kubectl/kubectl-plugins/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---