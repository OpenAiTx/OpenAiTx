# Un traceur de rayons en pur SQL

Tout le monde écrit un traceur de rayons tôt ou tard. Voici le mien.

## Exemples de résultats

<img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/dielectricparty.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onemirrorball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/glassmatrix.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/airy.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onediamondball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneantiglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/adjacentballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreyball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/reflectiontest.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twodiffuseballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreenball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/threemirrors.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twomirrorballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/busyday.png" width=200>

## Utilisation

```shell
sh create.sh
```

```postgres_connection.sh``` contient l’hôte/base de données/utilisateur/mot de passe/etc.  
Il n’y a pas de besoins exotiques autres que « postgres, comme la version 10 et plus  
ou quelque chose du genre »  

Pour ce que ça vaut, j’ai créé le mien ainsi sur mon bureau Ubuntu :  
```shell
sudo su - postgres
createuser --pwprompt raytracer
createdb -O raytracer raytracer
```

### Leviers pour le développement et le rendu

Lors du développement, évidemment un temps de rendu de quelques minutes est un temps de cycle assez
long. Il y a plusieurs leviers que vous pouvez actionner pour accélérer les choses
et réduire la qualité. Ils se trouvent sur "camera" et "img" dans setup.sql :

* *samples\_per\_px* - C'est le nombre de rayons/sous-échantillons par pixel.
  - 1 ou 2 convient pendant le débogage
  - 15-20 donne des images "acceptables"
  - Au-delà de 50, il n'y a pas beaucoup d'amélioration visible
* *max\_ray\_depth* - Le nombre maximal de rebonds de rayons
  - Pour les scènes simples, cela ne dépasse généralement pas 5 rebonds environ
* *res\_x* et *res\_y* - Résolution finale de l'image
  - Plus petit est plus rapide

Le CTE principal contient beaucoup d'éléments inutiles pour la sortie finale.
C'est pour que je puisse examiner les rayons rebondissant dans la scène avec :
```sql
SELECT * FROM rays WHERE img_x=100 AND img_y=250
```

Il existe un script pour obtenir une vue rapide et approximative d'une scène avec gnuplot ;
le script ```show_scene.sh``` doit générer un dossier de sorties.

## Base de données

Ceci est implémenté en SQL pur. Il ne fait rien comme CREATE
FUNCTION ou autres éléments non portables, sauf pour le trigger pour faire de l'animation,
ce qui évidemment ne compte pas.

En même temps, il y a quelques fonctionnalités SQL pas tout à fait courantes
dont il a besoin :

* JOIN LATERAL
* PARTITION BY à l'intérieur d'un CTE RECURSIF
* Fonctions mathématiques comme SIN()

Donc bien que j'aie commencé à développer cela dans SQLite, j'ai fini par m'appuyer
sur PostgreSQL. Au moment où j'écris ceci, ça fonctionne sous postgres et n'a pas été
testé ailleurs.

## Éléments d'implémentation intéressants

Telle qu'elle est, je me suis retrouvé à résoudre certains problèmes de façon intéressante.

### JOIN LATERAL

JOIN LATERAL est une façon de faire une sous-requête corrélée dans un JOIN, au lieu de
juste dans une clause WHERE. Je l'utilise comme moyen de remonter des calculs et
d'en faire beaucoup une seule fois et, dans certains cas, d'éviter une duplication excessive.

### Diffusion diffuse

Cela nécessite d'échantillonner une sphère uniforme. Je génère beaucoup d'échantillons aléatoires
à l'avance [échantillonnage avec rejet -> mise à l'échelle des points sur la surface de la sphère],
et je les numérote.

Trouver une façon de joindre chaque rayon à une seule ligne aléatoire parmi ces
diffusions précalculées était étrange ; on ne peut pas simplement joindre à RANDOM() parce que
chaque rayon serait joint à la même diffusion aléatoire. On ne peut pas non plus sélectionner
avec un calcul typique sur une normale car cela mène à des bandes
dans l'image. Donc, à la place, je sors quelques décimales tardives d'une
dimension d'une normale, puis je rejoins dessus. C'est « aléatoire » mais aussi
suffisamment unique par rayon.

### CTE récursifs

Le lancer de rayons suit très naturellement le fonctionnement des CTE récursifs. Une des
choses que j'ai rencontrées était une façon propre d'identifier quel rayon est celui à
prendre en compte. L'utilisation d'une fonction fenêtrée ordonnant par l'interception (t) a bien marché.
À chaque itération, cette requête intersecte un rayon avec *tout*
ce qui est devant lui et effectue tous les calculs associés, mais ensuite dans
la clause WHERE rejette tout sauf la chose que le rayon
a réellement touchée.

Aussi, il y a quelque chose de vraiment beau dans la simplicité
du cœur du rollup final [édité pour la clarté] :
```sql

 SELECT img_x, img_y,
         SUM(POW(color_mult * ray_col_r/samples_per_px, gamma)) col_r,
         SUM(POW(color_mult * ray_col_g/samples_per_px, gamma)) col_g,
         SUM(POW(color_mult * ray_col_b/samples_per_px, gamma)) col_b
    FROM rays
    GROUP BY img_y, img_x
```

### Scènes, matériaux, etc.

Parce que c'est en SQL, je peux stocker plusieurs scènes dans la base de données. Celle
qui est réellement rendue est sélectionnée dans la table "camera".

## Se tenir sur les épaules des géants

Deux ans avant que j'écrive ceci, "Le traceur de rayons MySQL le plus avancé
du marché actuellement" a circulé sur les réseaux sociaux :
https://www.pouet.net/prod.php?which=83222

J'avais quelques idées en tête que je voulais faire différemment [pire ?] :

* La démoscene est une forme d'art. Je ne fais pas de golf, ce n'est pas minifié
* Pas une seule requête ; cela peut être fait avec des CTE, mais euhhhhhhh
* Animation comme objectif final [voir ```anim.sh```]
* Principalement, je m'amuse juste avec le mauvais outil pour le travail

### J'ai demandé l'avis de Claude

*"Pourquoi quelqu'un écrirait-il quelque chose comme ça en premier lieu ?"*

> C'est un exemple fascinant de SQL en tant que langage de programmation général poussé à l'extrême. Quelqu'un a écrit un traceur de rayons complet en SQL PostgreSQL, ce qui est à la fois impressionnant et... discutable.
> 
> [...]
> 
> Cela ressemble soit à un brillant projet de thèse d'un étudiant en informatique, à l'expérience d'un ingénieur senior pendant un week-end, ou à quelqu'un piégé dans un environnement strictement limité aux bases de données qui a refusé d'abandonner ses rêves de lancer de rayons.
> 
> C'est l'équivalent en programmation de construire une voiture de course en Lego - techniquement impressionnant, mais vous ne devriez probablement pas vraiment la conduire.

Je ne sais pas si je suis flatté ou offensé.

## Références

La plupart de ceci est construit en suivant la série "Ray Tracing in One Weekend"
: https://raytracing.github.io/ , puis en tenant compte de la manière délibérément obtuse dont je le code.


Gary <chunky@icculus.org>

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---