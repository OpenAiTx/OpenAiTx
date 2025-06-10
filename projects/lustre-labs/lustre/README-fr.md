<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Faites briller votre frontend</strong> ✨
</div>

<div align="center">
  Un framework pour créer des applications Web en Gleam !
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Disponible sur Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentation" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Site web
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Démarrage rapide
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Référence
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Développé avec ❤︎ par
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> et
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    les contributeurs
  </a>
</div>

---

## Table des matières

- [Fonctionnalités](#features)
- [Exemple](#example)
- [Philosophie](#philosophy)
- [Installation](#installation)
- [Et après](#where-next)
- [Support](#support)

## Fonctionnalités {#features}

- Une API **déclarative** et fonctionnelle pour construire du HTML. Pas de templates, pas de macros,
  juste Gleam.

- Une architecture inspirée par Erlang et Elm pour **gérer l’état**.

- **Effets secondaires gérés** pour un code prévisible et testable.

- Composants universels. **Écrivez une fois, exécutez partout**. Elm rencontre Phoenix LiveView.

- Une **CLI complète** qui facilite la création de structures et la construction d’applications.

- **Rendu côté serveur** pour du templating HTML statique.

## Exemple {#example}

Lustre propose [plus de 20 exemples](https://hexdocs.pm/lustre/reference/examples.html) !
Voici à quoi cela ressemble :

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## Philosophie {#philosophy}

Lustre est un framework _opinioné_ pour créer des applications Web de petite à moyenne taille. Le développement frontend moderne est difficile et complexe. Une partie de cette complexité est nécessaire, mais beaucoup est accidentelle ou provient d’un trop grand nombre d’options. Lustre partage la même philosophie de conception que Gleam : autant que possible, il ne doit y avoir qu’une seule façon de faire les choses.

Cela signifie que Lustre propose par défaut un système unique de gestion d’état, inspiré d’Elm et Erlang/OTP. Ouvrez n’importe quelle application Lustre et vous devriez vous y sentir chez vous.

Cela signifie aussi que nous privilégions les approches simples pour la construction des vues plutôt que les complexes. Lustre _permet_ de créer des composants à état encapsulé (ce qui nous manquait cruellement dans Elm) mais cela ne devrait pas être le choix par défaut. Préférez les fonctions simples aux composants à état.

Lorsque des composants _sont_ nécessaires, profitez du fait que les composants Lustre peuvent s’exécuter _partout_. Lustre vous donne les outils pour écrire des composants qui peuvent s’exécuter dans une application Lustre existante, être exportés comme Web Component autonome, ou tourner côté serveur avec un runtime minimal pour la mise à jour du DOM. Lustre appelle cela des **composants universels** et ils sont écrits en gardant à l’esprit les multiples cibles de Gleam.

## Installation {#installation}

Lustre est publié sur [Hex](https://hex.pm/packages/lustre) ! Vous pouvez l’ajouter à vos projets Gleam depuis la ligne de commande :

```sh
gleam add lustre
```

Lustre propose aussi un paquet compagnon contenant des outils de développement que vous pouvez installer :

> **Remarque** : le serveur de développement lustre_dev_tools surveille votre système de fichiers pour
> détecter les modifications de votre code gleam et peut recharger automatiquement le navigateur. Sous Linux,
> cela nécessite que [inotify-tools]() soit installé.

```sh
gleam add --dev lustre_dev_tools
```

## Et après {#where-next}

Pour démarrer rapidement avec Lustre, consultez le [guide de démarrage rapide](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Si vous préférez voir du code, le dossier [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
contient plusieurs petites applications qui illustrent différents aspects du framework.

Vous pouvez également lire la documentation et la référence de l’API sur
[HexDocs](https://hexdocs.pm/lustre).

## Support {#support}

Lustre est principalement développé par moi seul, [Hayleigh](https://github.com/hayleigh-dot-dev),
en plus de deux emplois. Si vous souhaitez soutenir mon travail, vous pouvez [me sponsoriser sur GitHub](https://github.com/sponsors/hayleigh-dot-dev).

Les contributions sont également les bienvenues ! Si vous avez repéré un bug, ou souhaitez
suggérer une fonctionnalité, ouvrez une issue ou une pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---