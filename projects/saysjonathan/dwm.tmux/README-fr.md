dwm.tmux
===
[dwm](http://dwm.suckless.org/)-inspiré gestionnaire de fenêtres et de panneaux en mosaïque pour Tmux.

![](https://raw.githubusercontent.com/saysjonathan/dwm.tmux/master/screenshot.png)

## Dépendances
dwm.tmux nécessite tmux >= 3.2.

## Installation
### Via TPM (recommandé)
Ajouter à `~/.tmux.conf` :

```sh
set -g @plugin 'saysjonathan/dwm.tmux'
```

Rechargez et exécutez `prefix-I` pour récupérer.

### Installation manuelle (héritage)
Pour installer, utilisez le `Makefile` fourni :

```sh
git clone https://github.com/saysjonathan/dwm.tmux.git
cd dwm.tmux
make
```
Par défaut, `dwm.tmux` utilise `/usr/local` comme préfixe. Pour changer le préfixe :


```sh
make PREFIX=$HOME
```

Assurez-vous que `$PREFIX/bin` est dans votre `PATH`.

Pour utiliser, sourcez la configuration tmux `dwm.tmux` :

```sh
echo 'source-file /usr/local/lib/dwm.tmux' >> $HOME/.tmux.conf
```

## Utilisation
`dwm.tmux` définit les alias de commande suivants, chacun avec un raccourci clavier par défaut :

- `newpane` `Meta-n` Créer un nouveau panneau et le placer dans le panneau principal
- `newpanecurdir` `Meta-w` Créer un nouveau panneau démarrant dans le même répertoire et le placer dans le panneau principal
- `killpane` `Meta-c` Fermer le panneau courant. Si le panneau est dans le panneau principal, fermer le panneau et promouvoir le premier panneau de la pile en panneau principal
- `movepane[0-9]` `Meta-Shift-[0-9]` Déplacer le panneau courant vers la fenêtre spécifiée
- `nextpane` `Meta-j` Sélectionner le panneau suivant (sens horaire) ; échange le panneau en plein écran en mode monocle
- `prevpane` `Meta-k` Sélectionner le panneau précédent (sens antihoraire) ; échange le panneau en plein écran en mode monocle
- `stackup` `Meta-J` Déplacer le panneau focalisé vers le haut de la pile
- `stackdown` `Meta-K` Déplacer le panneau focalisé vers le bas de la pile
- `rotateccw` `Meta-<` Faire pivoter les panneaux dans le sens antihoraire
- `rotatecw` `Meta->` Faire pivoter les panneaux dans le sens horaire
- `tile` `Meta-t` Revenir au mode mosaïque, sortir du mode monocle si actif
- `monocle` `Meta-Espace` Basculer en mode monocle (plein écran sur le panneau courant)
- `zoom` `Meta-Entrée` Placer le panneau sélectionné dans le panneau principal
- `decmfact` `Meta-h` Diminuer le facteur d’espace du panneau principal
- `incmfact` `Meta-l` Augmenter le facteur d’espace du panneau principal
- `window[0-9]` `Meta-[0-9]` Sélectionner la fenêtre cible par ID
- `newwindow` `Meta-N` Créer une nouvelle fenêtre démarrant dans le même répertoire que le panneau courant
- `killwindow` `Meta-X` Supprimer la fenêtre active courante
- `popup` `Meta-p` Afficher une fenêtre flottante popup dans le répertoire du panneau courant
- `incpfact` `Meta-.` Augmenter la taille du panneau focalisé dans la pile, par rapport aux autres panneaux
- `decpfact` `Meta-,` Diminuer la taille du panneau focalisé dans la pile, par rapport aux autres panneaux
- `resetpfact` `Meta-=` Réinitialiser le pfact du panneau focalisé

Des raccourcis supplémentaires pour la navigation entre fenêtres sont également inclus :
- `Meta-[` Fenêtre précédente
- `Meta-]` Fenêtre suivante

Sont aussi définies des options globales pour ajuster le comportement :

- `mfact` Facteur d’espace du panneau principal, taille du panneau principal en pourcentage de la taille totale de la fenêtre
- `killlast` Si la valeur est supérieure à `0`, fermer un panneau même s’il est le dernier dans une fenêtre
- `monocle` Suit le mode de disposition actif ; 0 pour mosaïque, 1 pour monocle. Défini automatiquement mais peut être lu pour inspecter l’état courant.
- `pfact` Facteur de taille par panneau dans la pile, échelle 1-9, défaut 5. Des valeurs plus élevées donnent plus de hauteur relative au panneau dans la pile

### Personnalisations
Les raccourcis clavier et valeurs par défaut peuvent être définis dans un fichier de configuration. Lors de l’utilisation de TPM, ces réglages doivent être faits après la ligne `run '~/.tmux/plugins/tpm/tpm'` dans `~/.tmux.conf`.
Exemples :


```
setenv -g killlast 1 # kill pane even if it's the last
set-option -wg @mfact 60
set-option -wg @pfact 4
bind -n M-q killpane
bind -n M-w newpanecurdir
```

## Détails

Similaire à dwm, les fenêtres sont toujours organisées comme suit :

```
 ====================================
|                 |        S1        |
|                 |==================
|      M(0)       |        S2        |
|                 |==================
|                 |        S3        |
 ====================================
```

Un grand panneau principal est placé sur le côté gauche de l'écran tandis qu'une pile de panneaux plus petits est placée à droite. Le panneau principal est toujours le panneau 0, tandis que la pile de panneaux est numérotée séquentiellement dans l'ordre croissant.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---