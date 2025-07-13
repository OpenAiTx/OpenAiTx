# Bouton 3D Pressable

Un composant de bouton 3D réaliste construit avec HTML, CSS et SVG, qui simule la sensation d'appuyer sur un bouton physique. Le bouton propose des animations fluides, des couleurs personnalisables et des interactions réactives.

Créé par [@BalintFerenczy](https://x.com/BalintFerenczy)

Inspiré par le travail remarquable de [Resend](https://resend.com/)

## Fonctionnalités

- **Apparence 3D réaliste** grâce à des graphiques SVG superposés
- **Animations fluides** avec des fonctions d’interpolation personnalisées
- **États interactifs** - effets au survol et à l’appui
- **Couleurs personnalisables** via des variables CSS
- **Design réactif** qui s’adapte à la taille du conteneur

## Démonstration
Le bouton réagit aux interactions de l'utilisateur avec trois états distincts :
- **Normal** : Le bouton dans sa position de repos
- **Survol** : Mouvement subtil vers le bas lorsque la souris survole
- **Actif** : Mouvement significatif vers le bas lorsqu'il est pressé/cliqué

## Utilisation

### Personnalisation

Le bouton peut être facilement personnalisé en utilisant des propriétés personnalisées CSS :

```css
.frame {
    /* Dimensions du bouton */
    width: 400px; 
    height: 400px; 

    /* Distances de déplacement */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Personnalisation des couleurs */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Paramètres de transition */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Changer le texte du bouton

Modifiez simplement le contenu du texte :

```html
<p class="text">Cliquez-moi&nbsp;!</p>
```

#### Changer la taille du bouton

Ajustez les dimensions du cadre&nbsp;:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Licence

Ce projet est open source et disponible sous la licence MIT.

## Contribution

N'hésitez pas à forker ce projet et à soumettre des pull requests pour des améliorations ou de nouvelles fonctionnalités !

## Auteur

Créé par [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---