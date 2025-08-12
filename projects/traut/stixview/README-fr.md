# Stixview

[![npm version](https://badge.fury.io/js/stixview.svg)](https://badge.fury.io/js/stixview)

[Stixview](https://github.com/traut/stixview) est une bibliothèque JS pour des graphes STIX2 interactifs intégrables.

> [!NOTE]  
> Une version hébergée de Stixview est disponible sur [CTIChef.com](https://ctichef.com)

![Graphique Stixview](https://raw.githubusercontent.com/traut/stixview/master/.github/stixview-graph.png)

## Motivation

CTI (Cyber Threat Intelligence) consiste beaucoup à raconter des histoires. L'information devient renseignement lorsqu'elle est complétée par un contexte et placée dans une histoire. Ces histoires sont généralement cristallisées dans des rapports par un fournisseur de renseignements et diffusées aux clients.

Si le fournisseur de renseignements s'intéresse à un CTI structuré et lisible par machine, les rapports produits seront complétés par des bundles [STIX2](https://oasis-open.github.io/cti-documentation/). Il existe un écart entre une histoire, racontée dans un rapport, et un instantané CTI structuré, représenté par un bundle STIX2.

L'objectif de la bibliothèque [Stixview](https://github.com/traut/stixview) est de fournir des graphes STIX2 facilement intégrables avec un niveau d'interactivité nécessaire, afin que la communauté CTI puisse créer des histoires informatives et engageantes.

## Démonstrations

Pour voir Stixview en action, consultez ces pages de démonstration :

* [Démonstration STIX2.1](https://traut.github.io/stixview/dist/demos/stix21-demo.html) — graphe d'exemple avec tous les objets STIX 2.1.
* [Storyline](https://traut.github.io/stixview/dist/demos/story.html) — plusieurs graphes par page, affichant des entités sélectionnées du même bundle STIX.
* [Visionneuse](https://traut.github.io/stixview/dist/demos/viewer.html) — visualiseur de graphes avec contrôles personnalisés.
* [Glisser-déposer](https://traut.github.io/stixview/dist/demos/drag-n-drop.html) — vues de graphes avec glisser-déposer activé.
* [Graphe thème sombre à partir de données intégrées](https://traut.github.io/stixview/dist/demos/load-data.html) — rendu d’un graphe à partir d’un bundle STIX2 intégré et de styles personnalisés.
* [Marques TLP et rendu personnalisé de la barre latérale](https://traut.github.io/stixview/dist/demos/tags-and-custom-sidebar.html) — définitions de marquage TLP affichées comme tags et barre latérale rendue via une fonction fournie.
* [Exemples de divers paramètres de configuration](https://traut.github.io/stixview/dist/demos/misc.html)

## Utilisation

Pour utiliser Stixview dans un navigateur, téléchargez la dernière version depuis le répertoire `dist` (`stixview.bundle.js`) et référencez-la dans votre fichier HTML :

```html
<script src="stixview.bundle.js" type="text/javascript"></script>
```

ou utilisez le service CDN [unpkg](https://unpkg.com) :

```html
<script src="https://unpkg.com/stixview/dist/stixview.bundle.js" type="text/javascript"></script>
```

## API

La bibliothèque s'appuie fortement sur les [attributs de données](https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Use_data_attributes).
Au chargement de la page, Stixview trouvera tous les éléments HTML avec `data-stix-gist-id`, `data-stix-url` ou `data-stix-allow-dragdrop` définis et utilisera ces éléments comme conteneurs de graphes.

Exemple d'un div conteneur de graphe :

```html
<div data-stix-gist-id="6a0fbb0f6e7faf063c748b23f9c7dc62"
     data-show-sidebar=true
     data-enable-mouse-zoom=false
     data-graph-width=500
     data-graph-height=300>
</div>
```
### Attributs de données

Chaque élément conteneur _doit avoir_ un des attributs `data-stix-gist-id`, `data-stix-url` ou `data-stix-allow-dragdrop` défini, sinon il ne sera pas détecté par la bibliothèque.

Stixview supporte ces attributs `data-` :

* `stix-gist-id` — identifiant d'un gist contenant un bundle STIX2. si `gist-file` n'est pas spécifié, le premier fichier sera utilisé.
* `gist-file` — nom d'un fichier du gist à utiliser comme bundle STIX2. Utilisé uniquement si `stix-gist-id` est défini.
* `stix-url` — URL pointant vers un fichier JSON distant de bundle STIX2.
* `stix-allow-dragdrop` (`false` par défaut) — active la possibilité de glisser-déposer un bundle STIX2 dans l'élément graphique. Si cette propriété est réglée à `true` et que `stix-gist-id` et `stix-url` ne sont pas spécifiés, un graphe vide sera rendu.
* `caption` — un titre pour le graphe. L'en-tête n'est pas affiché si `caption` n'est pas défini.
* `show-footer` (`true` par défaut) — affiche un pied de page avec les liens de téléchargement vers le bundle STIX2 et le fichier PNG.
* `show-sidebar` (`true` par défaut) — active une barre latérale avec les détails des objets, ouverte lors d'un clic sur un objet.
* `show-tlp-as-tags` (`true` par défaut) — affiche les objets de définition de marquage TLP connectés comme étiquettes sur les entités.
* `show-marking-nodes` (`true` par défaut) — affiche les nœuds de définition de marquage.
* `show-labels` (`true` par défaut) — affiche les étiquettes des nœuds.
* `show-idrefs` (`false` par défaut) — affiche des objets de substitution pour les identifiants mentionnés dans les relations mais absents du bundle.
* `graph-layout` (`cola` par défaut) — nom de l'algorithme de disposition du graphe. Les algorithmes supportés sont `cola`, `klay`, `cose-bilkent`, `cise`, `grid` et `dagre`.
* `enable-mouse-zoom` (`true` par défaut) — active le zoom avec la molette de la souris.
* `enable-panning` (`true` par défaut) — active le panoramique dans le graphe. Si `false`, le graphe a une vue fixe. Les utilisateurs pourront toujours déplacer les nœuds.
* `highlighted-objects` — une chaîne avec des identifiants STIX2 séparés par des virgules. Si défini, le graphe contiendra _seulement les objets avec les identifiants listés_.
* `hidden-objects` — une chaîne avec des identifiants STIX2 séparés par des virgules. Si défini, les objets avec les identifiants listés seront ignorés et non rendus dans le graphe.
* `min-zoom` (`0.3` par défaut) — zoom minimum autorisé.
* `max-zoom` (`2.5` par défaut) — zoom maximum autorisé.
* `graph-width` (toute la largeur disponible par défaut) — largeur de l'élément graphe. Les valeurs en pixels et en % sont supportées (voir la page de démo misc pour un exemple).
* `graph-height` (`600` pixels par défaut) — hauteur de l'élément graphe. Les valeurs en pixels et en % sont supportées (voir la page de démo misc pour un exemple).

### Objet navigateur

La bibliothèque, lorsqu'elle est utilisée dans un navigateur, enregistrera la variable `stixview` sur l'objet `window` avec ces propriétés :

* `registry` — un registre des graphes initiés sur une page.
* `onInit(selector, callback)` – hook d'écoute pour l'événement d'initiation d'un graphe sur un élément DOM correspondant au `selector` fourni (voir [démo](https://traut.github.io/stixview/dist/demos/viewer.html) pour un exemple d'utilisation). Le callback reçoit une instance de l'interface de graphe.
* `onLoad(selector, callback)` – hook d'écoute pour l'événement de chargement d'un graphe sur un élément DOM correspondant au `selector` fourni (voir [démo](https://traut.github.io/stixview/dist/demos/viewer.html) pour un exemple d'utilisation). Le callback reçoit une instance de l'interface de graphe.
* `init(element, properties, initCallback, loadCallback)` — méthode qui initie une vue de graphe dans l'`element` spécifié avec les `properties` fournies qui remplacent les valeurs par défaut (voir [démo](https://traut.github.io/stixview/dist/demos/load-data.html) pour un exemple d'utilisation).

### Objet graphe

Le graphe est un objet avec les propriétés :


* `cy` – objet de graphe [cytoscape.js](http://js.cytoscape.org).
* `element` — élément DOM qui contient un graphe.
* `dataProps` – propriétés configurées pour le filtrage des données.
* `viewProps` – propriétés configurées pour la vue.
* `runLayout(name)` — exécuter une mise en page spécifique sur un graphe.
* `reloadData()` — recharger les données du graphe avec de nouvelles propriétés de filtrage des données.
* `fit()` — ajuster le graphe entièrement dans la vue du graphe.
* `toggleLabels(<bool-value>)` — afficher / masquer les étiquettes des nœuds.
* `toggleLoading(<bool-value>)` — afficher / masquer la superposition de chargement.
* `loadData(data)` — charger un bundle STIX2 à partir de l’objet JSON `data` et l’afficher sur un graphe.
* `loadDataFromFile(file)` — charger un bundle STIX2 à partir de l’objet fichier `file` et l’afficher sur un graphe.
* `loadDataFromUrl(url)` — charger un bundle STIX2 à partir d’une URL distante et l’afficher sur un graphe.
* `loadDataFromParamUrl(paramName)` — charger un bundle STIX2 à partir d’une URL distante, configurée dans le paramètre HTTP GET nommé `paramName` et l’afficher sur un graphe.

## Build

```shell
yarn build
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---