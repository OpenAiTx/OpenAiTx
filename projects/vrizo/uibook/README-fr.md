
<a href="https://www.facebook.com/amplifr/">
  <img width="80" height="80" align="right"
    alt="Sponsorisé par Amplifr" src="https://raw.githubusercontent.com/vrizo/uibook/master/./amplifr-logo.png" style="border-radius: 100%; margin: 10px;"/>
</a>


# Uibook

Uibook est un outil de test visuel pour les composants React. Il vous permet de vérifier rapidement
la vue desktop et mobile de vos composants avec de vraies media queries
et différentes combinaisons de props.

Les fonctionnalités clés :
- Test responsive pour les développeurs pour jouer avec de **vraies media queries**
- Édition de texte en direct pour les designers et éditeurs pour vérifier leur contenu
- Installé en tant que plugin Webpack, il ne nécessite aucun builder supplémentaire.

<img src="/docs/uibook.gif" align="center" alt="Fonctionnalités clés de Uibook" >

:triangular_flag_on_post: Découvrez le projet démo Uibook ici :
[https://uibook.vrizo.net/](https://uibook.vrizo.net/#Presets:ru).

## Utilisation

### Installation rapide :hatching_chick:

Nous avons conçu Uibook pour une intégration fluide à votre projet.
Installez-le comme un plugin webpack, et vous êtes prêt :
Uibook ne nécessite aucun bundler séparé.

_webpack.config.js_
```js
const UibookPlugin = require('uibook/plugin')

module.exports = {
  …
  plugins: [
    new UibookPlugin({
      outputPath: '/uibook',
      controller: path.join(__dirname, '../src/uibook-controller.js'),
      hot: true
    })
  ],
}
```

[En savoir plus sur l'installation →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install.md)
[Installer dans Create React App avec CRACO →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install_craco.md)

### Décrire les composants dans Pages :hatched_chick:

Vous devez définir uniquement deux choses :

1. La Page — objet simple avec le nom du composant test et les cas ;
2. Le Cas — ensemble de props et de callbacks pour le composant.

_button.uibook.js_
```js
import UibookCase from 'uibook/case'
import Button from '../src/button'

export default {
  component: Button,
  cases: [
    () => <UibookCase>Button</UibookCase>,
    () => <UibookCase props={{ isSmall: true }}>Small button</UibookCase>
  ]
}
```
[En savoir plus sur la configuration →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/configure.md)

### Passer les Pages au Contrôleur :baby_chick:

Dès que vous avez terminé votre première Page Uibook, vous êtes prêt
à écrire le Contrôleur Uibook. C’est un endroit où toutes les
Pages sont incluses et transmises à UibookStarter :sparkles:

_uibook-controller.js_

```js
import UibookStarter from 'uibook/starter'
import ButtonUibook from './button.uibook'

export default UibookStarter({
  pages: {
    Button: ButtonUibook
  }
})
```
[En savoir plus sur le Contrôleur →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/controller.md)

### Lancement :rocket:

Aucun besoin de serveurs supplémentaires ou d’instances webpack.
Uibook s’intègre à votre projet, il suffit donc de lancer votre bundler
et d’ouvrir `/uibook` (ou votre adresse personnalisée — `outputPath`) dans un navigateur.

### Plus d’informations

- **[Dépannage](https://raw.githubusercontent.com/vrizo/uibook/master/docs/troubleshooting.md)**
- [Exemples](https://raw.githubusercontent.com/vrizo/uibook/master/docs/examples.md)
- [Contactez-moi](https://twitter.com/vitaliirizo)

## Édition de texte en direct

Ce mode active `contentEditable` pour chaque cas, permettant aux managers,
designers et éditeurs d’interface de prévisualiser le contenu dans les composants.

<img src="/docs/text-edit-mode.gif" align="center" alt="Mode d’édition de texte" >

## Remerciements spéciaux

- [@ai](https://github.com/ai)
- [@demiazz](https://github.com/demiazz)
- [@marfitsin](https://github.com/marfitsin)
- [@iadramelk](https://github.com/iadramelk)
- [@ikowalsker](https://www.facebook.com/ikowalsker)
- [@antiflasher](https://github.com/antiflasher)
- [@HellSquirrel](https://github.com/HellSquirrel)

Toute personne est invitée à contribuer, vous pouvez consulter les tâches en cours
dans [PLAN.md](https://raw.githubusercontent.com/vrizo/uibook/master/PLAN.md). Je serai heureux de répondre à vos questions
sur le projet.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---