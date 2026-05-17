# fastcompmgr

__fastcompmgr__ est un compositeur _rapide_ pour X, un fork d'une version précoce
de __Compton__ qui est un fork de __xcompmgr-dana__ qui est un fork
de __xcompmgr__.

J'utilisais xcompmgr depuis longtemps, car compton semblait toujours
un peu lent lors du déplacement/redimensionnement des fenêtres ou du défilement
cinétique d'une page web. Après avoir testé la dernière version picom-10.2, il semble que les choses se soient encore
empirées (voir le benchmark ci-dessous). Cependant, xcompmgr ne dessine pas d'ombres
sur les fenêtres argb (par exemple certains terminaux) et
présente plusieurs autres défauts. C'est pourquoi je suis remonté en 2011, à l'époque
où cette fonctionnalité venait d'être ajoutée, j'ai sélectionné quelques commits plus récents de compton
pour éliminer les segfaults et fuites de mémoire intempestives, et j'ai rendu cette version encore
plus rapide, basée sur le profiling.
Par exemple, les événements de déplacement et redimensionnement de fenêtres sont limités
en nombre d'événements et rendus à un taux de rafraîchissement fixé, tandis que
le défilement est toujours effectué aussi rapidement que possible. Les fenêtres occultées ne sont pas
peintes et les allocations/désallocations de mémoire sont largement évitées,
permettant des repeints plus rapides de l'écran.
En contrepartie, le fondu est actuellement cassé (je ne l'utilise pas). Désolé
pour cela (;

## Benchmark
Sur mon Dell Latitude E5570, le déplacement, redimensionnement et défilement des fenêtres
semble clairement plus rapide, mais il existe aussi des chiffres pour étayer cette
observation. Avec un certain nombre de fenêtres chromium empilées, où aucune fenêtre
n'est totalement occultée, j'ai effectué les opérations respectives *à la main*,
donc veuillez noter que le benchmark n'est pas très sophistiqué. Le pilote de pavé tactile
`xserver-xorg-input-synaptics` a été utilisé, ce qui active le défilement cinétique (Wayland quelqu'un ?). Les usages CPU suivants ont été mesurés :

| Compositeur   | déplacement | redimensionnement | défilement |
| ------------- | ----------- | ----------------- | ---------- |
| fastcompmgr   | 6.7%        | 4.4%              | 1.5%       |
| xcompmgr      | 7.8%        | 4.9%              | 1.6%       |
| compton       | 26.4%       | 6.8%              | 17.1%      |
| picom         | 29.3%       | 8.1%              | 23.1%      |



Les outils ont été utilisés avec les options suivantes :
~~~
(v0.1) fastcompmgr -o 0.4 -r 12 -c -C
(v1.1.8 de Debian 11) xcompmgr -o 0.4 -r 12 -c -C
(v1 de Debian 11) compton --config /dev/null --backend xrender -o 0.4 -r 12 -c -C
(v10.2) picom --config /dev/null --backend xrender -o 0.4 -r 12 -c

# Calcul de la moyenne avec
$ fastcompmgr -o 0.4 -r 12 -c -C &  pid=$!; sleep 4; \
    top -b -n 20 -d 0.5 -p $pid | LC_ALL=C awk -v pid=$pid \
    '$1==PID {++PIDCOUNT} $1==pid && PIDCOUNT>1 {print $9}' |  \
    datamash mean 1; kill $pid
~~~



## Installation
Si vous êtes paresseux, téléchargez simplement le binaire depuis la [page des releases](https://github.com/tycho-kirchner/fastcompmgr/releases).

Sinon, installez les versions de développement des bibliothèques suivantes :
### Dépendances :

* libx11
* libxcomposite
* libxdamage
* libxfixes
* libxrender
* pkg-config
* make

Pour compiler :

~~~ bash
$ make
$ make install
~~~

## Utilisation

~~~ bash
$ fastcompmgr -o 0.4 -r 12 -c -C
~~~
Toutes les options (actuellement le fondu ne fonctionne pas) :
~~~
   -d affichage
    Quel affichage doit être géré.
   -r rayon
    Le rayon de flou pour les ombres. (par défaut 12)
   -o opacité
    La translucidité des ombres. (par défaut 0,75)
   -l décalage-gauche
    Le décalage à gauche des ombres. (par défaut -15)
   -t décalage-haut
    Le décalage en haut des ombres. (par défaut -15)
   -m opacité
    L’opacité des menus. (par défaut 1,0)
   -c
    Active les ombres côté client sur les fenêtres.
   -C
    Évite de dessiner les ombres sur les fenêtres dock/panneau.
   -i opacité
    Opacité des fenêtres inactives. (0,1 - 1,0)
   -e opacité
    Opacité des barres de titre et des bordures des fenêtres. (0,1 - 1,0)
    --shadow-red valeur
    Valeur de la couleur rouge de l’ombre (0,0 - 1,0, par défaut 0).
    --shadow-green valeur
    Valeur de la couleur verte de l’ombre (0,0 - 1,0, par défaut 0).
    --shadow-blue valeur
    Valeur de la couleur bleue de l’ombre (0,0 - 1,0, par défaut 0).

~~~


## Licence

xcompmgr a beaucoup voyagé. Autant que je puisse en juger, la lignée pour cet
arbre particulier est quelque chose comme :

* Keith Packard (auteur original)
* Matthew Hawn
* ...
* Dana Jansens
* Christopher Jeffrey
* Tycho Kirchner

Sans compter les dizaines de personnes qui l'ont forké entre-temps.

Voir LICENSE pour plus d'informations.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-17

---