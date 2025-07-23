<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


![serajs (2)](https://github.com/user-attachments/assets/7ccff260-491d-420b-8e22-4579f9bad50a)

## 📖 **Introduction**

> 📚 Projets  —  seraJs

🔗(Portfolio)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(Démo blog)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** est une **bibliothèque JavaScript réactive basée sur les signaux** et légère
pour construire des interfaces utilisateur dynamiques.

Avec seulement **969 octets gzippés** et à peine **135 lignes de code**, il s'agit d'une bibliothèque d'interface utilisateur réactive remarquablement légère — offrant une réactivité puissante avec un minimum de surcharge.

> ⚡️ _SeraJS met l'accent sur la **minimalisme** et la **performance** sans sacrifier
> l'expérience développeur._


*Comparaison de la taille des bundles (Minifié + Gzippé)*

| Bibliothèque | Taille (gzippé) | Étape de build requise | But principal | Fonctionnalités clés |
|--------------|------------------|-------------------------|---------------|----------------------|
| SeraJS | 1,25kb | Optionnelle 😎 | UI réactive | 135 lignes de code, ultra léger |
| React | ~40kb | Oui | Composants UI | Virtual DOM, architecture basée sur les composants, JSX |
| Vue | ~33kb | Optionnelle | Framework progressif | Liaison de données réactive, système de composants, composants monofichier |
| Solid.js | ~7kb | Oui | UI réactive | Pas de virtual DOM, templates compilés, réactivité fine |
| Alpine.js | ~7,1kb | Non | Framework léger | Manipulation minimale du DOM, syntaxe déclarative, fonctionne avec HTML existant |
| Preact | ~4kb | Oui | Alternative à React | API compatible React, taille réduite, performances accrues |
| htmx | ~14kb | Non | Extensions AJAX | Attributs HTML pour AJAX, JavaScript minimal, compatible rendu serveur |



---

## ⚙️ **Concepts de base**

### 🔄 **Réactivité basée sur les signaux**

SeraJS utilise un **système réactif basé sur les signaux**, une approche moderne de la gestion d'état
qui permet des mises à jour efficaces :

- 🧠 **Signaux**  
  Valeurs réactives autonomes qui notifient les abonnés lors des modifications.

- 🌀 **Effets**  
  Fonctions qui se ré-exécutent automatiquement lorsque leurs dépendances (signaux)  
  changent.

- 🧭 **Memo**  
  Un utilitaire de mémoïsation similaire à `useMemo` de React, utilisé pour mettre en cache le résultat  
  d'un calcul basé sur des dépendances réactives afin d'éviter des recalculs inutiles.

- 🔬 **Mises à jour fine-grain**  
  Seuls les éléments DOM spécifiques affectés par les changements d'état sont mis à jour,  
  ce qui minimise les re-rendus et offre de hautes performances.

> 💡 **SeraJS est conçu pour être intuitif, rapide et facile à intégrer à n'importe quel
> projet — en faisant un choix parfait pour le développement frontend moderne.**


## Pourquoi SeraJS ?

SeraJS réunit le meilleur de bibliothèques comme React, Solid et Lit — associant des schémas familiers à une approche minimale et innovante.

Avec seulement 1,25KB gzippé et 135 lignes de code, cette bibliothèque UI réactive reste ultra-légère tout en offrant une réactivité puissante.

Que vous souhaitiez un système de build ou préfériez un workflow sans build, SeraJS répond à vos besoins. Il est suffisamment flexible pour s'adapter à votre style de développement — utilisez-le comme *vous* le souhaitez.


## 🌱 **Exemple de base avec Sera.js**

Un exemple minimal affichant un message Hello World avec Sera.js.

### 📄 App.jsx



```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## Pas de compilation, pas de dépendances


```html
<!DOCTYPE html>
<html>
  <head>
    <title>Sera js 😎</title>
  </head>
  <body>
    <script type="module">
      import { h, setSignal, setEffect } from "//unpkg.com/serajs";

      function Hello() {
        const [count, setCount] = setSignal(0);

        setEffect(() => {
          console.log(count());
        });

        return h(
          "div",
          null,
          h("h1", null, "Hello World!"),
          h("p", { style: { color: "red" } }, "Do you Like Serajs?"),
          h("h1", null, () => `Count: ${count()}`),
          h(
            "button",
            { onclick: () => setCount(count() + 1) },
            "Increase Count"
          )
        );
      }

      const root = document.body;
      root.appendChild(Hello());
    </script>
  </body>
</html>
```





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---