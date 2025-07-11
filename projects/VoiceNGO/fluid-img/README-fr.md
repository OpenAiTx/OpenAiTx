# Composant Web Image Fluide

Des images qui s’adaptent intelligemment à n’importe quelle taille souhaitée (dans des limites raisonnables).

![Images Fluides](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Tout petit ! :** 7 ko minifié et compressé (gzip)

## Utilisation

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

C’est tout. Redimensionnez les images comme vous le souhaitez, elles s’ajusteront automatiquement.

## Démo

[Démo ici](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Un espace de test est également disponible pour [expérimenter avec vos propres images](https://voicengo.github.io/fluid-img/public).
## Installation

### Bibliothèque cliente

```sh
npm install fluid-img
```

Importez ensuite `fluid-img` dans votre projet, ce qui fournit et enregistre le composant web :

```ts
import 'fluid-img';
```

Ou incluez le script depuis jsdelivr ou unpkg :

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- ou -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Avertissements

Le composant d’image fluide fonctionne le mieux pour des images mises à l’échelle horizontalement ou verticalement dans une plage d’environ 0,5x à 1,5x leur taille d’origine. Bien qu’il puisse gérer des échelles plus grandes ou plus petites, la qualité visuelle peut se détériorer rapidement. Il n’est pas recommandé pour les images où l’intégrité des pixels est cruciale, comme les portraits, les graphiques ou les dessins techniques détaillés, car la découpe de coutures introduit des distorsions. Il est fortement conseillé de tester vos images à différentes tailles pour s’assurer qu’elles répondent à vos attentes visuelles.

#### CORS

En raison des restrictions de sécurité des navigateurs, les images chargées à partir d’une origine différente (domaine, protocole ou port) de celle de la page web déclencheront une erreur de partage des ressources entre origines (CORS). Ce composant nécessite l’accès aux données brutes des pixels de l’image, ce qui est restreint par le CORS.

Pour utiliser des images provenant d’une origine différente, le serveur hébergeant les images doit être configuré pour envoyer les bons en-têtes CORS (par exemple, `Access-Control-Allow-Origin: *` ou `Access-Control-Allow-Origin: your-domain.com`). Sans ces en-têtes, le composant ne pourra pas traiter l’image.

(À titre d’information, pour les tests, toute image hébergée sur imgur possède les en-têtes CORS nécessaires)

#### Repli

Si le composant ne parvient pas à charger ou à traiter l’image, ou s’il déclenche une erreur interne, il se dégradera gracieusement en injectant une balise `<img>` standard dans le composant `<fluid-img>`, avec une largeur et une hauteur à 100 %, garantissant ainsi que l’image reste affichée.

## Options

Utilisation : `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Par défaut, le générateur `random` est utilisé car il est le plus rapide.

| Option                         | Valeurs                          | Par défaut   | Description                                                                                                            |
| ------------------------------ | -------------------------------- | ------------ | ---------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | L’URL de l’image à traiter.                                                                                            |
| `generator`                    | `random`, `predictive`           | `predictive` | Le générateur de découpe à utiliser. `random` est plus rapide mais de moindre qualité.                                 |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | L’axe de mise à l’échelle. `auto` choisit horizontal ou vertical selon les changements de ratio d’aspect.              |
| `mask`                         | URL                              |              | L’URL d’une image de masque. Les zones noires du masque ont une énergie plus faible et sont plus susceptibles d’être préservées. |
| `carving-priority`             | Nombre (0-1, ex. `0.5`)          | `1`          | Pourcentage de la mise à l’échelle réalisé par découpe de couture vs. redimensionnement traditionnel.                  |
| `max-carve-up-seam-percentage` | Nombre (0-1, ex. `0.5`)          | `0.6`        | Pourcentage maximal de coutures à insérer lors de l’agrandissement. Limite la création de nouvelles coutures pour préserver la qualité. |
| `max-carve-up-scale`           | Nombre (ex. `3`)                 | `3`          | Facteur maximal d’agrandissement utilisant la découpe de couture. Au-delà, la mise à l’échelle traditionnelle est utilisée. |
| `max-carve-down-scale`         | Nombre (0-1, ex. `0.7`)          | `0.7`        | Pourcentage maximal de l’image à retirer par découpe de couture lors de la réduction.                                  |
### Options spécifiques au générateur

Les options spécifiques au générateur sont ajoutées au composant `<fluid-img>`, mais ne sont valides que lorsque l’attribut
`generator` correspondant est également défini.

#### Options du générateur Aléatoire & Prédictif

| Option               | Valeurs                 | Par défaut | Description                                           |
| -------------------- | ---------------------- | ---------- | ----------------------------------------------------- |
| `batch-percentage`   | Nombre (0-1, ex. 0.1)  | 0.1        | Pourcentage de coutures à générer par lot             |
| `min-batch-size`     | Nombre (ex. `10`)      | 10         | Nombre minimum de coutures à générer par lot          |

## Fonctionnement

Le seam carving est une technique de redimensionnement d’image sensible au contenu, qui supprime ou ajoute intelligemment des pixels, permettant ainsi de redimensionner une image sans déformer son contenu important. Pour plus d’informations, consultez l’[article Wikipédia](https://fr.wikipedia.org/wiki/Seam_carving) sur le sujet.

Historiquement, le seam carving était trop intensif en calcul pour une utilisation en temps réel dans les navigateurs web. Cependant, cette limitation peut être surmontée en utilisant des algorithmes alternatifs moins exigeants et efficaces dans de nombreux scénarios.

Il existe deux implémentations du générateur de seam carving :
### Découpe Aléatoire

L'approche de découpe de couture aléatoire abandonne l'algorithme traditionnel de découpe de couture, qui est trop lent pour une exécution en temps réel dans le navigateur.

À la place, elle génère un ensemble de coutures aléatoires qui assurent une couverture à 100 % de l'image en reliant chaque pixel d'une ligne à un pixel voisin dans la suivante. Elle parcourt ensuite chaque couture, calcule son énergie et élimine un lot de coutures à la plus faible énergie. Ce processus se répète jusqu'à obtenir le nombre souhaité de coutures. Cette méthode produit des résultats étonnamment bons pour de nombreuses images.

### Découpe Prédictive

Similaire à la découpe aléatoire, cette méthode génère une carte d'énergie et crée des coutures par lots. Elle génère également une carte d'énergie minimale pour chaque lot. L'idée principale est de créer à la fois des coutures "bonnes" et "mauvaises". Les bonnes coutures ont une faible énergie et sont conservées. Les mauvaises coutures incorporent des pixels à haute énergie, ce qui permet de les éliminer par la suite.

En partant de la première ligne, elle relie des paires de pixels à des paires correspondantes dans la ligne suivante. La couture à plus faible énergie issue du calcul en cours est reliée à la couture à plus faible énergie de la carte d'énergie minimale.

Le résultat est une couture vraiment optimale, de nombreuses coutures "très bonnes", de nombreuses "très mauvaises" et beaucoup de coutures médiocres. Nous sélectionnons un lot de "bonnes" coutures, éliminons le reste et répétons le processus.

##

## À FAIRE

### Haute Priorité

- [x] Composant web
- [x] Rendu prenant les données des générateurs et s'adaptant à toute taille
- [x] Générateur aléatoire
- [x] Découpe verticale
- [x] Générateur prédictif
- [ ] Web workers pour tous les générateurs
### Priorité basse

- [x] Masquage
- [ ] Reconnaissance faciale

### Rêve impossible

- [ ] Gravure 2D

## Licence

Ce logiciel est sous licence Fluid-Img Revenue-Limited.

**Utilisation gratuite** pour les particuliers et organisations ayant un chiffre d'affaires annuel inférieur à 10 000 000 $ USD.

**Licence commerciale requise** pour les organisations avec un chiffre d'affaires annuel de 10 M$ ou plus. Contactez [licensing@voice.ngo] pour les conditions de licence commerciale.

Voir le fichier [LICENSE](./LICENSE) pour les conditions complètes.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---