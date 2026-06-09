# Convertisseur Tailwind vers styles en ligne

Convertit les classes Tailwind CSS en styles en ligne pour des modèles HTML prêts pour les emails.

### [Essayez-le en ligne](https://tailwind-to-inline.vercel.app)

### Installation
`npm install tailwind-to-inline`


### Utilisation

#### À partir d’un chemin de fichier

```js
import { makeStylesInline } from 'tailwind-to-inline';

const htmlTemplate = await makeStylesInline('templates/welcome-email.html', {
  name: 'John',
  cta_text: 'Complete Profile'
});
```

**Paramètres :**

- `templatePath` — Chemin vers le fichier modèle.
- `placeholderValues` *(optionnel)* — Un objet paire clé-valeur pour remplacer le contenu dynamique dans le modèle.

#### À partir d'une chaîne HTML brute

```js
import { makeStylesInlineFromString } from 'tailwind-to-inline';

const html = `<div class="pt-10 text-yellow-300">Hello, {{name}}</div>`;
const htmlTemplate = await makeStylesInlineFromString(html, {
  name: 'John',
});
```

**Paramètres :**

- `templateString` — Une chaîne HTML brute contenant des classes Tailwind CSS.
- `data` *(optionnel)* — Un objet clé-valeur pour remplacer le contenu dynamique dans le modèle.


### Exemple
#### Modèle original `welcome-email.html` :

```html
<html>
  <body class="bg-gray-800">
    <div class="pt-10 mb-4 pl-4 max-w-[512px] relative z-20">
      <span class="mr-5 text-yellow-300">Welcome, {{name}}</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" class="bg-blue-500">
        {{cta_text}}
      </a>
    </div>
  </body>
</html>
```

#### Résultat converti :

```html
<html>
  <body style="background-color: #1f2937;">
    <div style="position: relative; z-index: 20; max-width: 512px; margin-bottom: 1rem; padding-left: 1rem; padding-top: 2.5rem;">
      <span style="margin-right: 1.25rem; color: #fde047;">Welcome, John</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" style="background-color: #3b82f6;">
        Complete Profile
      </a>
    </div>
  </body>
</html>
```
### Contribution

Les contributions, problèmes et demandes de fonctionnalités sont les bienvenus !

### Contributeurs

<a href="https://github.com/vardan-arm"><img src="https://github.com/vardan-arm.png" width="50" height="50" alt="vardan-arm" /></a>
<a href="https://github.com/diogomoretti"><img src="https://github.com/diogomoretti.png" width="50" height="50" alt="diogomoretti" /></a>
<a href="https://github.com/markosmk"><img src="https://github.com/markosmk.png" width="50" height="50" alt="markosmk" /></a>

### Licence

Ce projet est sous licence MIT.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---