# gnome-gamma-tool

Un outil en ligne de commande qui vous permet de modifier la gamma, le contraste et la luminosité dans GNOME et Cinnamon de manière persistante en créant un profil couleur avec la table VCGT.

## Avertissement
**Cela ne fonctionne qu'avec GNOME et Cinnamon**. Testé sur Fedora avec GNOME 42-48 et Cinnamon, cela pourrait ne pas fonctionner avec des versions plus anciennes/nouvelles, bien que les profils déjà générés devraient continuer à fonctionner.

C'est plutôt bricolé, les profils couleur n'étaient pas conçus pour être utilisés ainsi. Mais je pense que le cas d'utilisation est assez rare pour le justifier. Après tout, si votre moniteur ne vous permet pas de changer la gamma, n'est-ce pas un problème du moniteur ?

Voir [Comment ça marche](#how-it-works) pour une description plus détaillée.

**Note :** il n'est pas possible de changer la saturation ou la teinte de l'écran (en raison des limitations de VCGT), mais vous pouvez essayer d'utiliser [gnome-saturation-extension](https://github.com/zb3/gnome-saturation-extension) (qui a néanmoins ses inconvénients).

## Utilisation
Il n'est pas nécessaire d'installer ceci, il suffit de cloner ce dépôt :
```
git clone https://github.com/zb3/gnome-gamma-tool
cd gnome-gamma-tool
```
**Si** vous utilisez Debian/Ubuntu, vous devrez peut-être également installer d'abord le paquet `gir1.2-colord-1.0` :

```
sudo apt install gir1.2-colord-1.0
```
pour OpenSUSE, vous devrez peut-être installer le paquet `typelib-1_0-Colord-1_0` à la place :
```
sudo zypper install typelib-1_0-Colord-1_0
```
si vous utilisez NixOS, consultez [ce commentaire](https://github.com/zb3/gnome-gamma-tool/issues/28#issuecomment-3112277504)

Ensuite, vous pouvez lancer l'outil ainsi :
```
./gnome-gamma-tool.py
```
(si cela ne fonctionne pas, veuillez ouvrir un nouveau ticket [ici](https://github.com/zb3/gnome-gamma-tool/issues/new))

Une fois le nouveau profil installé, cet outil peut être supprimé en toute sécurité.


### Ajustement du gamma de l'écran
L'argument `-g` vous permet de spécifier le facteur de correction gamma. Vous pouvez également utiliser la forme `R:G:B` pour le régler pour chaque canal.

Par exemple :
```
./gnome-gamma-tool.py -g 0.8
```
or
```
./gnome-gamma-tool.py -g 0.8:0.8:0.8
```

### Ajustement du contraste (ou inversion des couleurs)
Vous pouvez également modifier le contraste en utilisant le paramètre `-c`. `1` est la valeur par défaut, tandis que `-1` inversera effectivement les couleurs. Assurez-vous de ne pas utiliser la valeur `0` ici car cela rendra votre affichage tout gris...

Par exemple :
```
./gnome-gamma-tool.py -c -1
```

Notez qu'il commence toujours à partir de l'état initial, donc la commande ci-dessus annulera tous les ajustements gamma précédents, mais vous pouvez combiner différentes options :

```
./gnome-gamma-tool.py -g 0.8 -c 0.5
```

Les réglages par canal fonctionnent aussi ici, il est donc possible, par exemple, d'inverser le canal bleu tout en conservant le rouge et le vert intacts. Pouvez-vous deviner à quoi cela ressemblerait ? Essayez :
```
./gnome-gamma-tool.py -c=1:1:-1
```
Était-ce ce à quoi vous vous attendiez ? :)

### Changer la température de couleur
La température de couleur peut également être modifiée, utilisez l'option `-t` pour spécifier la température. Les valeurs fonctionnent comme dans `redshift` où `6500` est la valeur neutre. Notez que cela n'empêche pas la fonction lumière nocturne de fonctionner, c'est juste que les ajustements de la lumière nocturne sont faits « par-dessus » ce que fait gnome-gamma-tool.
```
./gnome-gamma-tool.py -t 5000
```

### Ajuster la luminosité (en quelque sorte)
Vous pouvez également ajuster la luminosité avec cet outil, mais il n'est pas possible d'augmenter la luminosité physique de l'écran, il est seulement possible de la diminuer en réduisant la valeur maximale de luminosité. Utilisez l'option `-b` pour cela, elle accepte des valeurs de `0` à `1`, où `1` est la valeur neutre :
```
./gnome-gamma-tool.py -b 0.7
```

Il y a une autre option ici qui vous permet d'*augmenter* la valeur de luminosité *minimale*. C'est l'option `-bm` qui accepte également des valeurs de `0` à `1`, cette fois `0` étant la valeur neutre. Après avoir fait :
```
./gnome-gamma-tool.py -bm 0.3
```
la valeur de sortie ne sera jamais inférieure à `0.3` donc le noir ne sera pas noir mais en fait gris, tandis que le blanc restera blanc et les couleurs intermédiaires seront multipliées en conséquence. Il est également possible d'inverser les couleurs en utilisant la combinaison de `-b` et `-bm` :
```
./gnome-gamma-tool.py -b 0 -bm 1
```

Et... ce n’est pas tout, car ceux-ci fonctionnent également par canaux individuels, grâce à la notation `R:G:B`. Cela ouvre de nouvelles possibilités, comme... rendre votre écran plus vert (ce que vous ne pouviez pas obtenir avec la température de couleur) :
```
./gnome-gamma-tool.py -b 1:2:1
```
Ce qui précède est d'abord transformé en `0.5:1:0.5` et techniquement cela rend votre écran moins rouge et moins bleu, mais en pratique cela fait paraître l'écran plus vert. Quelle fonctionnalité utile, n'est-ce pas ?


### Si vous avez plusieurs écrans
Vous pouvez spécifier l'*index* de l'écran en utilisant l'option `-d` (le premier a l'index `0` mais c'est celui par défaut donc vous n'avez pas besoin d'utiliser cet argument dans ce cas...). L'ordre des écrans est le même que dans le panneau `Paramètres -> Couleur`. Voici un exemple :
```
./gnome-gamma-tool.py -d 1 -g 0.7
```
Vous pouvez également appliquer des modifications à tous les affichages en utilisant l’option `-a` :

```
./gnome-gamma-tool.py -a -g 0.7
```

### Exportation vers un fichier

Si vous souhaitez simplement créer un profil ICC avec la table VCGT appropriée sans interagir avec votre configuration actuelle, vous pouvez utiliser l'argument `-o`/`--out-file`. Notez qu'il ne chargera pas votre profil actuel, donc la sortie sera un profil sRGB à moins que vous n'utilisiez l'argument `-i`/`--in-file` pour spécifier le profil de base.

Vous pouvez ensuite l'importer et l'appliquer à l'aide d'un outil comme `colormgr`.

```
# Create myprofile.icc file
python3 ./gnome-gamma-tool.py --min-brightness 0.05 --brightness 0.95 --out-file myprofile.icc

# This command will print Device ID, save it
colormgr get-devices

# This command will print Profile ID, save it
colormgr import-profile myprofile.icc

# This command will affect colors immediately
colormgr device-add-profile $displayId $profileId

# This command will remove imported profile and revert colors to original state immediately.
colormgr delete-profile $profileId
```
## Comment ça fonctionne

Mutter (le compositeur de GNOME) n’implémente aucun protocole Wayland pouvant aider, donc des outils comme `gammastep` ou `wl-gammactl` ne fonctionnent pas. Mutter expose cependant la méthode `SetCrtcGamma` via D-Bus, et cette méthode fonctionne vraiment. Pourtant, ce n’est pas ainsi que gnome-gamma-tool atteint son but parce que :
* la valeur n’est enregistrée nulle part donc l’effet n’est pas persistant
* cette méthode est déjà appelée par un autre démon, donc l’effet n’est que temporaire.

Cette méthode est normalement appelée par le démon `gsd-color` (indirectement), et actuellement deux choses peuvent influencer ses arguments :
* table VCGT du profil de couleur actuellement activé (récupérée via colord)
* température de couleur dérivée des réglages « lumière nocturne »
(ces deux éléments sont combinés ensemble)

Il pourrait sembler que la solution évidente ici soit de patcher `gsd-color` pour prendre aussi en compte d’autres éléments (comme une propriété GSettings), afin de pouvoir ajuster la gamma via la commande `gsettings`. Cela ouvrirait aussi la possibilité d’ajouter une interface graphique au panneau Affichage plus tard.

Pourtant encore une fois, ce n’est pas ainsi que fonctionne gnome-gamma-tool, car patcher `gsd-color` n’a de sens que si ce patch est intégré en amont. Sinon, il est totalement inacceptable pour moi (et probablement pour vous aussi) de devoir appliquer des patchs personnalisés et recompiler des parties de GNOME. C’est pourquoi gnome-gamma-tool installe un profil de couleur avec la table "VCGT" correctement configurée.

`gsd-color` ne gère pas les profils de couleur, il les observe en utilisant l’API fournie par colord. Pour qu’un profil soit reconnu par `gsd-color`, les étapes suivantes doivent être respectées :
* les profils de couleur doivent être activés pour un appareil donné
* ce profil doit être installé (dans la base de données de colord)
* ce profil doit être associé à l’appareil
* ce profil doit être activé

Toutes ces étapes sont réalisées via l’API exposée par colord via D-Bus. gnome-gamma-tool ne crée pas un nouveau profil depuis zéro (sauf si vous spécifiez `-o`/`--out-file`), mais clone le profil actuel et ne modifie que la table VCGT. Par défaut, le profil actuel est celui généré par `gsd-color` à partir des données EDID.

`gsd-color` écoute les changements d’appareil/profil via les signaux D-Bus, il détecte donc notre changement de profil puis appelle éventuellement `SetCrtcGamma`. Voilà !

Qu’est-ce que ce "VCGT" alors ? La VCGT (Video Card Gamma Table) mappe essentiellement les valeurs des canaux de couleur (R, G et B). Par exemple, si un canal a la valeur `X` alors la VCGT spécifie que cela doit être transformé en `Y`. Bien sûr, toutes les valeurs d’entrée n’ont pas une entrée dans la VCGT, cette table contient juste 256 entrées et les valeurs sont interpolées (mais ce n’est pas fait par gnome-gamma-tool).

VCGT permet de modifier la gamma (via exponentiation), le contraste et la luminosité, mais il n’est pas possible de changer la teinte de cette manière, car un canal ne peut pas affecter un autre.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---