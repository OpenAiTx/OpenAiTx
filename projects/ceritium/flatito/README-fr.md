# Flatito : Grep pour les fichiers YAML et JSON

Une sorte de grep pour les fichiers YAML et JSON. Il vous permet de rechercher une clé et d’obtenir la valeur ainsi que le numéro de ligne où elle se trouve.

![Exemple](https://raw.githubusercontent.com/ceritium/flatito/master/docs/screenshot.png)

## Signification

[Espéranto](https://en.wiktionary.org/wiki/flatito) : participe passé nominal passif singulier de flati (« flatter »).

## Installation

Installez la gem et ajoutez-la au Gemfile de l’application en exécutant :

    $ bundle add flatito

Si bundler n’est pas utilisé pour gérer les dépendances, installez la gem en exécutant :

    $ gem install flatito

### Package Nixpkgs

Il est également disponible comme [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=flatito) grâce à [@Rucadi](https://github.com/Rucadi)

    $ nix run nixpkgs#flatito


## Utilisation

```sh
Usage:    flatito PATH [options]
Example:  flatito . -k "search string" -e "json,yaml"
Example:  cat file.yaml | flatito -k "search string"

    -h, --help                       Prints this help
    -V, --version                    Show version
    -k, --search-key=SEARCH          Search string
        --no-color                   Disable color output
    -e, --extensions=EXTENSIONS      File extensions to search, separated by comma, default: (json,yaml,yaml)
        --no-skipping                Do not skip hidden files
```

## Développement

Après avoir cloné le dépôt, exécutez `bin/setup` pour installer les dépendances. Ensuite, lancez `rake test` pour exécuter les tests. Vous pouvez également exécuter `bin/console` pour un prompt interactif qui vous permettra d’expérimenter.

Pour installer cette gemme sur votre machine locale, exécutez `bundle exec rake install`. Pour publier une nouvelle version, mettez à jour le numéro de version dans `version.rb`, puis exécutez `bundle exec rake release`, ce qui créera un tag git pour la version, poussera les commits git et le tag créé, et poussera le fichier `.gem` vers [rubygems.org](https://rubygems.org).

## Contribution

Les rapports de bugs et les pull requests sont les bienvenus sur GitHub à l’adresse https://github.com/ceritium/flatito. Ce projet se veut un espace sûr et accueillant pour la collaboration, et les contributeurs sont invités à respecter le [code de conduite](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md).

## Licence

La gemme est disponible en open source sous les termes de la [Licence MIT](https://opensource.org/licenses/MIT).

## Code de conduite

Toute personne interagissant dans les bases de code, les suivis d’incidents, les salons de discussion et les listes de diffusion du projet Flatito est tenue de suivre le [code de conduite](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---