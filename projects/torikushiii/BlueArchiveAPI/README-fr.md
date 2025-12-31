
# Blue Archive API

## *Cette API fournit des données pour les versions globale et japonaise de Blue Archive.*

- [Blue Archive EN](https://bluearchive.nexon.com/home) : Site officiel EN
- [Blue Archive JP](https://bluearchive.jp/) : Site officiel JP

API qui fournit diverses données du jeu Blue Archive. Si vous souhaitez contribuer à ce projet, n’hésitez pas à ouvrir une pull request ou un ticket. Si vous souhaitez me soutenir, vous pouvez faire un don sur mon [Ko-Fi](https://ko-fi.com/torikushiii).

**API hébergée sur https://api.ennead.cc/buruaka**

## Prérequis

- [Go](https://go.dev/dl/) : version 1.24 ou supérieure
- Instance MongoDB accessible par l’API (l’URI par défaut est `mongodb://localhost:27017`)

## Configuration

Les options d’exécution sont chargées depuis un fichier YAML. Par défaut, le serveur lit `config.yaml` à la racine du projet. Définissez la variable d’environnement `CONFIG_PATH` pour pointer vers un fichier de configuration alternatif si nécessaire.

Voir `config.yaml` pour un exemple correspondant aux valeurs locales par défaut.

## Exécution de l’API

Compilez les dépendances et lancez le serveur avec Go :

```bash
go run ./cmd/server
```

L'adresse d'écoute est contrôlée via la configuration (par défaut `0.0.0.0:9999`). Tous les points de terminaison REST sont servis sous le chemin de base `/buruaka` (par exemple `/buruaka/character`), et le serveur se connecte à MongoDB en utilisant l'URI configuré pour fournir les données de personnage, de raid et de bannière.

Pour produire un binaire autonome :

```bash
go build -o server ./cmd/server
```

Exécuter les tests avec :

```bash
go test ./...
```

## Documentation de l'API REST

Les détails des points de terminaison se trouvent dans le dossier [docs](https://github.com/torikushiii/BlueArchiveAPI/tree/main/docs).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---