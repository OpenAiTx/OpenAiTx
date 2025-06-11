# Containerization

Le package Containerization permet aux applications d'utiliser des conteneurs Linux.  
Containerization est écrit en [Swift](https://www.swift.org) et utilise [Virtualization.framework](https://developer.apple.com/documentation/virtualization) sur Apple silicon.

Containerization fournit des API pour :

- [Gérer les images OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Interagir avec les registres distants](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Créer et remplir des systèmes de fichiers ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Interagir avec la famille de sockets Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Créer un noyau Linux optimisé pour des temps de démarrage rapides](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Lancer des machines virtuelles légères et gérer l’environnement d’exécution](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Lancer et interagir avec des processus conteneurisés](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Utiliser Rosetta 2 pour exécuter des conteneurs linux/amd64 sur Apple silicon.

Veuillez consulter la [documentation API](https://apple.github.io/containerization/documentation/) pour des informations sur les packages Swift fournis par Containerization.

## Conception

Containerization exécute chaque conteneur Linux dans sa propre machine virtuelle légère. Les clients peuvent créer des adresses IP dédiées pour chaque conteneur afin de supprimer le besoin de redirections de ports individuelles. Les conteneurs atteignent des temps de démarrage inférieurs à la seconde grâce à une [configuration optimisée du noyau Linux](https://raw.githubusercontent.com/apple/containerization/main/kernel) et un système de fichiers racine minimal avec un système init léger.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) est un petit système init, qui est un sous-projet de Containerization.  
`vminitd` est lancé comme premier processus à l'intérieur de la machine virtuelle et fournit une API GRPC via vsock.  
L'API permet de configurer l'environnement d'exécution et de lancer des processus conteneurisés.  
`vminitd` fournit des entrées/sorties, signaux et événements au processus appelant lorsqu'un processus est lancé.

## Exigences

Vous avez besoin d’un Mac Apple silicon pour construire et exécuter Containerization.

Pour construire le package Containerization, votre système doit avoir soit :

- macOS 15 ou plus récent et Xcode 26 beta  
- macOS 26 beta ou plus récent

Les applications construites avec ce package fonctionneront sur macOS 15 ou version ultérieure, mais les fonctionnalités suivantes ne sont pas disponibles sur macOS 15 :

- Réseau de conteneurs non isolé – avec macOS 15, les conteneurs sur le même réseau vmnet ne peuvent pas communiquer entre eux

## Exemple d’utilisation

Pour des exemples sur la manière d’utiliser certaines des bibliothèques, l’exécutable cctl est un bon point de départ. Cet outil sert principalement de terrain d’essai pour l’API. Il contient des commandes qui exploitent certaines des fonctionnalités principales des différents produits, telles que :

1. [Manipulation d’images OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Connexion aux registres de conteneurs](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Création de blocs de système de fichiers racine](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Exécution de conteneurs Linux simples](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Noyau Linux

Un noyau Linux est nécessaire pour lancer des machines virtuelles légères sur macOS.  
Containerization fournit une configuration de noyau optimisée située dans le répertoire [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Ce répertoire comprend un environnement de build conteneurisé pour compiler facilement un noyau utilisable avec Containerization.

La configuration du noyau est un ensemble minimal de fonctionnalités pour supporter des temps de démarrage rapides et un environnement léger.

Bien que cette configuration fonctionne pour la majorité des charges de travail, nous comprenons que certaines nécessiteront des fonctionnalités supplémentaires.  
Pour résoudre cela, Containerization fournit des API de première classe pour utiliser différentes configurations et versions de noyau selon chaque conteneur.  
Cela permet de développer et valider des conteneurs sur différentes versions de noyau.

Consultez le [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) dans le répertoire kernel pour les instructions de compilation du noyau optimisé.

### Noyau précompilé

Si vous souhaitez utiliser un noyau précompilé, il doit comporter les pilotes `VIRTIO` compilés dans le noyau, pas en modules.

Le projet [Kata Containers](https://github.com/kata-containers/kata-containers) fournit un noyau optimisé pour les conteneurs avec toutes les options de configuration requises activées, disponible sur la page des [releases](https://github.com/kata-containers/kata-containers/releases/).

Une image de noyau nommée `vmlinux.container` se trouve dans le répertoire `/opt/kata/share/kata-containers/` des artefacts de release.

## Préparation à la compilation du package

Installez Swiftly, [Swift](https://www.swift.org), et le [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html) :

```bash
make cross-prep
```

Si vous utilisez une application terminal personnalisée, vous devrez peut-être déplacer cette commande de `.zprofile` vers `.zshrc` (remplacez `<USERNAME>`) :

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Redémarrez l’application terminal. Assurez-vous que cette commande retourne `/Users/<USERNAME>/.swiftly/bin/swift` (remplacez `<USERNAME>`) :

```bash
which swift
```

Si vous avez installé ou utilisé un Static Linux SDK précédemment, vous devrez peut-être supprimer les anciennes versions du SDK du système (remplacez `<SDK-ID>`) :

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Compilation du package

Compilez Containerization depuis les sources :

```bash
make all
```

## Tests du package

Après compilation, lancez les tests basiques et d’intégration :

```bash
make test integration
```

Un noyau est nécessaire pour exécuter les tests d’intégration.  
Si vous n’avez pas de noyau localement, un noyau par défaut peut être récupéré avec la cible `make fetch-default-kernel`.

La récupération du noyau par défaut ne doit se faire qu’après une compilation initiale ou après un `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization dépend de versions spécifiques de `grpc-swift` et `swift-protobuf`. Vous pouvez les installer et régénérer les interfaces RPC avec :

```bash
make protos
```

## Documentation

Générez la documentation API pour consultation locale avec :

```bash
make docs
make serve-docs
```

Prévisualisez la documentation en lançant dans un autre terminal :

```bash
open http://localhost:8000/documentation/
```

## Contribution

Les contributions à Containerization sont les bienvenues et encouragées. Veuillez consulter [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) pour plus d’informations.

## État du projet

La version 0.1.0 est la première version officielle de Containerization. Les versions antérieures ne garantissent pas la stabilité du code source.

Comme la bibliothèque Containerization est en développement actif, la stabilité du code source est garantie uniquement entre versions mineures (par exemple entre 0.1.1 et 0.1.2). Si vous ne souhaitez pas de mises à jour du package pouvant casser le code, vous pouvez spécifier votre dépendance de package avec `.upToNextMinorVersion(from: "0.1.0")` à la place.

Les futures versions mineures du package pourront introduire des modifications de ces règles selon les besoins.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---