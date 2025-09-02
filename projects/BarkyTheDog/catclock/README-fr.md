<p align="center">
  <img src="https://raw.githubusercontent.com/BarkyTheDog/catclock/master/catclock.gif">
</p>

catclock
========

Ceci est une version du programme xclock du système X Window, qui a été améliorée avec un « mode chat ». À l'origine un programme X10 par Tony Della Fera (MIT-Athena, DEC), Dave Mankins (MIT-Athena, BBN) et Ed Moy (UC Berkeley), Deanna Hohn et moi-même (chez Digital Equipment Corporation) l'avons conçu pour notre propre divertissement à la fin des années 1980. Les graphismes ont été inspirés par la célèbre, en effet emblématique, horloge Kit-Cat (R), dont une pendule est toujours accrochée dans ma cuisine. J'ai mis cela sur GitHub en l'honneur de la 30e anniversaire de l'introduction de X10 cette année, et parce que c'est un jouet de bureau amusant.

Depuis le temps de nos améliorations, le code a très peu changé, principalement pour se conformer à des compilateurs désormais plus stricts. Actuellement, il compile et fonctionne sur diverses distributions Linux, Cygwin et OS X (XQuartz), avec des modifications du Makefile seulement nécessaires à cause de l'installation par défaut de Macport des fichiers liés à X dans /opt/local. L'Imakefile est assez ancien, et je n'ai pas encore tenté de le faire fonctionner – il est seulement inclus pour des raisons « historiques ». Le fichier readme original, maintenant nommé readme_original, est également inclus pour des raisons historiques.

En plus du mode chat, cette version de xclock inclut une fonction d'alarme et une sonnerie horaire (voir la page de manuel pour les détails). Divers paramètres X par défaut et options en ligne de commande peuvent être utilisés pour contrôler les couleurs du chat. Il se peut que vous deviez modifier les chemins d'en-tête et de bibliothèque dans le Makefile pour la configuration X de votre machine. La seule dépendance « non standard » est Motif, qui est facilement obtenable via votre gestionnaire de paquets préféré.

## Suivi du Tempo

Cette version est capable de suivre le tempo musical et de synchroniser les mouvements des yeux et de la queue du chat avec la musique.  
Pour le compiler avec le suivi du tempo activé, vous aurez besoin d'une bibliothèque supplémentaire qui alimente le suivi du tempo :

```bash
sudo apt install libaubio5 libaubio-dev
```

Utilisez l'option `WITH_TEMPO_TRACKER=1` pour compiler avec le suivi du tempo activé :

```bash
make WITH_TEMPO_TRACKER=1
```
Après avoir lancé clock en mode "cat", lancez un mélangeur PulseAudio (par exemple - `pavucontrol`) et sélectionnez la source audio souhaitée pour l'analyse dans l'onglet "Enregistrement".

## Usage


```
xclock [toolkitoptions]
       [-mode <analog, digital, cat>]
       [-alarm]  [-bell]  [-chime]
       [-file <alarm file>]  [-period <seconds>]
       [-hl <color>]  [-hd <color>]
       [-catcolor <color>]
       [-detailcolor <color>]
       [-tiecolor <color>]
       [-padding <pixels>]
       [-update <seconds>]
       [-ntails <number>]
       [-help]
```

Profitez-en !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---