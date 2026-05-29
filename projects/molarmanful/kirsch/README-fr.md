<div align="center">

![kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/header.png)

</div>

## Table des matières

- [Table des matières](#table-des-matières)
- [Aperçu](#aperçu)
- [Galerie](#galerie)
- [Installation/Utilisation](#installation/utilisation)
  - [Nerd Fonts](#nerd-fonts)
  - [Propo](#propo)
  - [Nixpkgs](#nixpkgs)
  - [Nix Flakes](#nix-flakes)
  - [Web](#web)
- [Notes de conception](#notes-de-conception)
  - [Ornements](#ornements)
  - [Espaces](#espaces)
- [Contribuer](#contribuer)
- [Crédits](#crédits)
- [Licences](#licences)

## Aperçu

**kirsch** /ˈkɪərʃ/ _n._

1. _(Allemand)_ cerise.

1. _(Russell A. Kirsch, 1929 - 2020)_ Ingénieur américain reconnu comme le
   développeur du premier scanner d’images numérique et l’inventeur du pixel.

1. Une police bitmap monospace avec une boîte englobante de 6x16 (largeur moyenne 5px, descente 4px,
   montée 12px, hauteur x 5px, hauteur capitale 9px). Elle puise dans une variété de
   formes de lettres et motifs pour créer une sensation humaniste distincte à une taille compacte.

   Certains glyphes proviennent de [Cozette](https://github.com/slavfox/Cozette), souvent
   modifiés pour respecter le design de kirsch.

## Galerie

<details>
<summary><strong>Glyphes</strong></summary>
<div align="center">

![glyphes kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/chars.png)

</div>
</details>

<details>
<summary><strong>Carte des Glyphes</strong></summary>
<div align="center">

![carte des glyphes kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/map.png)

</div>
</details>

<details open>
<summary><strong>Exemples</strong></summary>
<div align="center">

![exemple kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/sample.png)

</div>
</details>

## Installation/Utilisation

Téléchargez depuis [Releases](https://github.com/molarmanful/kirsch/releases).
Sont inclus les formats bitmap - OTB, BDF, PCF, DFONT (pour les utilisateurs Mac) - ainsi que
TTF. Des versions 2x sont disponibles pour les écrans HiDPI. Notez que PCF ne contient pas
de glyphes au-delà de U+FFFF.

Pour une expérience visuelle la plus nette possible, essayez d’utiliser les formats bitmap lorsque
c’est possible. Si les polices bitmap ne sont pas supportées sur votre plateforme (ex. Windows,
VSCode), alors utilisez le TTF à des tailles de police qui sont des multiples de 16px.

> [!ASTUCE]  
> Si vous avez besoin de la taille de police en pt, utilisez la conversion suivante :  
>  
> `pt = px * 72 / dpi`  
>  
> par exemple 16px sur un écran 96dpi correspond à `16px * 72 / 96dpi = 12pt`.  
>  
### Nerd Fonts  
kirsch est livré avec des glyphes Nerd Fonts personnalisés. Le support est encore en cours de développement.  
Pour plus de clarté visuelle, les glyphes Nerd Fonts de kirsch ont tendance à déborder fortement au-delà de leur  
largeur. J'ai dessiné ces glyphes en partant du principe qu'ils seront mieux mis en valeur  
lorsqu'ils seront entourés d'un espace avant et après.  
Les Nerd Fonts patchées qui couvrent le reste des Nerd Fonts sont disponibles. La  
variante "Mono" utilise des glyphes plus petits (à largeur simple au lieu de double) et fonctionne  
pour les terminaux qui ne peuvent pas mélanger les largeurs.  
### Propo  
Pour les terminaux comme foot avec débord partiel, une variante Propo de kirsch est  
disponible. Cette variante ajuste les glyphes de sorte que leurs cellules ne soient pas tronquées  
par le moteur de rendu de police du terminal.  
### Nixpkgs  
Grâce à [@ejiektpobehuk](https://github.com/ejiektpobehuk), kirsch est  
disponible sur Nixpkgs sous le nom `kirsch`.  
### Nix Flakes  
Les versions de kirsch sont également poussées sur  
[FlakeHub](https://flakehub.com/flake/molarmanful/kirsch). `kirsch` (alias  
`default`) est le paquet de base, tandis que `kirsch-nerd` inclut les patchs Nerd Fonts.  
### Web  
Je déconseille généralement l'utilisation de kirsch sur le web en raison de l'absence de  
support bitmap. Mais pour les plus obstinés et courageux, le format WOFF2 est disponible. Il existe également une  
[feuille de style hébergée sur CDN](https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css)










pour plus de commodité.

```html
<link
  rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css"
/>
```

## Notes de conception

Contrairement à ma police précédente [eldur](https://github.com/molarmanful/eldur), qui avait
une largeur moyenne de caractère de seulement 4px, kirsch a une largeur moyenne de caractère de 5px. Ce
1px de largeur supplémentaire offre une marge de manœuvre surprenante pour la conception. Beaucoup
plus de glyphes tiennent confortablement dans une largeur de 5px - par exemple "m" et "w" - ce qui signifie que
ces glyphes ne perturbent pas le crénage et n’empiètent pas sur les espaces des glyphes voisins.
Les glyphes qui ne tiennent pas dans une largeur de 5px peuvent maintenant utiliser une largeur de 7px, ce qui
maintient l’équilibre et la lisibilité sans affecter trop négativement le crénage.

### Ornements

![xylophone fijien rogue](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-flourishes.png)

Les ornements - par exemple dans "i" ou "f" - sont un choix stylistique, mais ils ont aussi
une fonction pratique. Sans les ornements, le "i" occuperait 1px de
largeur, laissant 4px d’espace gênant. Les ornements de 2px de chaque côté du "i" lui donnent
une largeur de 5px, résolvant ainsi le problème de crénage de façon élégante.

Dans le cas du "l", les ornements de style script le distinguent davantage des autres
caractères verticaux comme `1I|`.

### Espaces

![mauvais roi peg 69](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-gaps.png)

Une des caractéristiques distinctives de kirsch est la présence d’un espace dans les courbes des
lettres. Combler cet espace rendrait les lettres soit trop carrées soit trop
serrées, tandis que laisser l’espace ouvert désencombre les formes des lettres. Ces espaces évoquent aussi
les terminaisons de traits de style script.

## Contribution

Les problèmes, demandes de fonctionnalités/glyphes et pull requests sont tous les bienvenus ! Les fichiers de police
sont modifiés via [bited](https://github.com/molarmanful/bited).

## Crédits

Ce sont des projets qui m’ont inspiré/aidé à créer kirsch et qui valent à 100% la peine
vérification.

- [Bits'n'Picas](https://github.com/kreativekorp/bitsnpicas)
- [Cozette](https://github.com/slavfox/Cozette)
- [Page de test de police Cyreal](http://www.cyreal.org/Font-Testing-Page/)
- [Démo UTF-8 W3](https://www.w3.org/2001/06/utf-8-test/UTF-8-demo.html) /
  [Démo UTF-8 Markus Kuhn](https://antofthy.gitlab.io/info/data/utf8-demo.txt)
- [APL386](https://abrudz.github.io/APL386)

## Licence

Fait avec ♥ par [les auteurs du projet kirsch](AUTHORS). Distribué sous la licence OFL-1.1.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---