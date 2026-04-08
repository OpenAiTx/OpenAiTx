<div align="center">

<img src="https://media.giphy.com/media/Pt2yOXUALOhpB5dpiM/giphy.gif" alt="Meteor Devtool Evolved Gif" />

<p style="font-size: 30px">
Extension Meteor Devtools
</p>
Voici l'évolution de Meteor DevTools.</p>

Meteor Devtools Evolved est actuellement disponible pour Google Chrome et Mozilla Firefox.

</div>

<p align="center" >
    <a href="https://chrome.google.com/webstore/detail/meteor-devtools-evolved/ibniinmoafhgbifjojidlagmggecmpgf">
    <img width="120" src="https://img.shields.io/badge/%20-Chrome-orange?logo=google-chrome&logoColor=white" alt="Télécharger pour Chrome" />
    </a>
    <a href="https://addons.mozilla.org/en-US/firefox/addon/meteor-devtools-evolved/">
    <img width="110" src="https://img.shields.io/badge/%20-Firefox-red?logo=mozilla&logoColor=white" alt="Télécharger pour Firefox" />
    </a>
</p>

[Plus dur, meilleur, plus vite, plus fort](https://www.youtube.com/watch?v=gAjR4_CbPpQ) :rocket:

Vous débutez avec Meteor ? Voulez-vous comprendre "ce qui se passe" ou même optimiser votre application Meteor ? C'est l'outil qu'il vous faut.

:point_right: [Changelog](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CHANGELOG.md)

### Protocole de Données Distribuées (DDP)

Tout ce dont vous avez besoin pour suivre et comprendre ce qui se passe sous le capot de votre application Meteor. L'extension vous permet de filtrer et rechercher n'importe quel message DDP, capable de gérer des milliers et des milliers de messages sans aucun accroc.

### Signets

L'inspection DDP est éphémère, mais vous pouvez sauvegarder autant de messages DDP que vous voulez pour une recherche et récupération ultérieure, depuis n'importe quel hôte. Attention toutefois, ils sont sauvegardés dans IndexedDB.

### Minimongo

Vous ne savez pas quelles données appartiennent à quoi ? Vous pouvez rapidement rechercher n'importe quoi dans vos données Minimongo et visualiser facilement les documents avec notre Object Treerinator personnalisé ultra-rapide.

---

## Développement

> AVERTISSEMENT : Ce travail est basé en partie sur l’extension [Meteor DevTools](https://github.com/bakery/meteor-devtools) de The Bakery. Qui malheureusement n’est plus maintenue. Bien qu’il ne s’agisse pas nécessairement d’un fork, j’ai utilisé certaines connaissances et décisions architecturales utiles, et certaines choses ont naturellement convergé vers la même solution la plus pratique. D’où le terme « évolué ».

L’extension est presque entièrement écrite en TypeScript, tandis que certains codes spécifiques à Chrome ont été laissés de côté pour des raisons pratiques. Elle utilise MobX pour gérer l’état, et SASS pour ses styles. Nous utilisons également des composants de la bibliothèque [Blueprint](https://github.com/palantir/blueprint) de Palantir. Le tout est assemblé avec Webpack.

> Toute personne est bienvenue pour contribuer, plus d’infos [ici](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CONTRIBUTING.md).

## Firefox

Le port de l’extension pour Firefox a été une contribution de [@nilooy](https://github.com/nilooy). Merci !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---