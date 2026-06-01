<br />
<br />
<p align="center">
  <a href="https://github.com/mixxorz/DSLR">
    <img width="281" height="84" src="https://user-images.githubusercontent.com/3102758/181914025-44bff27e-aac1-4d1b-a037-9fa98f9fed65.png" alt="Le logo DSLR">
  </a>
</p>
<br />

<p align="center">
  <a href=""><img src="" alt=""></a>
  <a href="https://badge.fury.io/py/dslr"><img src="https://badge.fury.io/py/dslr.svg" alt="Version PyPI"></a>
  <a href="https://pypi.python.org/pypi/dslr/"><img src="https://img.shields.io/pypi/pyversions/dslr.svg" alt="Versions Python supportées par PyPI"></a>
  <a href="https://github.com/mixxorz/dslr"><img src="https://github.com/mixxorz/dslr/actions/workflows/tests.yml/badge.svg" alt="GitHub Actions (Qualité du code et tests)"></a>

</p>

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/190845105-dd2ec4e6-286b-431d-a33d-490805852b68.png" alt="Un terminal montrant l'interface en ligne de commande de DSLR.">
</p>

---

Instantané, Liste et Restauration de Base de Données

Prenez des instantanés ultra rapides de vos bases de données Postgres locales.

## Qu'est-ce que c'est ?

DSLR est un outil qui vous permet de prendre et restaurer rapidement des instantanés
de base de données lorsque vous écrivez des migrations de base de données, changez de branche ou manipulez
du SQL.

Il est destiné à être un successeur spirituel de
[Stellar](https://github.com/fastmonkeys/stellar).

**Important :** DSLR est destiné uniquement à un usage en développement. Il n'est pas conseillé d’utiliser
DSLR sur des bases de données de production.

## Performance

DSLR est beaucoup plus rapide que l'approche standard `pg_dump`/`pg_restore` pour les instantanés.

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/182014327-1b13da6e-63ad-4bbe-817e-7d6c66befc98.png" alt="Un graphique comparant le temps d'exécution entre DSLR et pg_dump/pg_restore. Pour la capture et la restauration, DSLR a pris respectivement 4,125 secondes et 4,431 secondes. pg_dump/pg_restore a pris respectivement 36,602 secondes et 13,257 secondes.">
</p>

DSLR est 8 fois plus rapide pour prendre des instantanés et 3 fois plus rapide pour restaurer des instantanés comparé à l'approche `pg_dump`/`pg_restore`.

<details>
  <summary>Méthodologie de test</summary>
  
  J'ai lancé Postgres 12.3 avec Docker, créé une base de données de test, et l'ai remplie avec 1 Go de données aléatoires en utilisant ce script :
  
  ```SQL
  CREATE TABLE large_test (num1 bigint, num2 double precision, num3 double precision);

INSERT INTO large*test (num1, num2, num3)
SELECT round(random() * 10), random(), random() \_ 142
FROM generate_series(1, 20000000) s(i);

```

J'ai utilisé les commandes suivantes pour mesurer le temps d'exécution :

```

time dslr snapshot my-snapshot
time dslr restore my-snapshot
time pg_dump -Fc -f export.dump
time pg_restore --no-acl --no-owner export.dump

```

J'ai exécuté chaque commande trois fois et tracé la moyenne dans le graphique.

Voici les données brutes :

| Commande      | Exécution | Temps d'exécution (secondes) |
| ------------- | --------- | ---------------------------- |
| dslr snapshot | 1         | 4,797                        |
|               | 2         | 4,650                        |
|               | 3         | 2,927                        |
| dslr restore  | 1         | 5,840                        |
|               | 2         | 4,122                        |
|               | 3         | 3,331                        |
| pg_dump       | 1         | 37,345                       |
|               | 2         | 36,227                       |
|               | 3         | 36,233                       |
| pg_restore    | 1         | 13,304                       |
|               | 2         | 13,148                       |
|               | 3         | 13,320                       |
</details>

## Installation

```

pip install DSLR psycopg2 # or psycopg2-binary, or psycopg

```

**Installer avec pipx**

```

pipx install DSLR[psycopg2] # or psycopg2-binary, or psycopg

````

**Installer en utilisant uv**

```

uv tool install 'DSLR[psycopg2]' # or psycopg2-binary, or psycopg

```

Note : Les commandes DSLR `export` et `import` de snapshot nécessitent que `pg_dump` et
`pg_restore` soient présents dans votre `PATH`, vous aurez donc besoin des utilitaires CLI Postgres
si vous souhaitez utiliser ces commandes.

<details>
  <summary><strong>Complétion Shell</strong></summary>

**Bash**

Ajoutez ceci à `~/.bashrc` :

```
eval "$(_DSLR_COMPLETE=bash_source dslr)"
```

**Zsh**

Add this to `~/.zshrc`:

```
eval "$(_DSLR_COMPLETE=zsh_source dslr)"
```

**Fish**

Ajoutez ceci à `~/.config/fish/completions/dslr.fish` :

```
eval (env _DSLR_COMPLETE=fish_source dslr)
```

Ceci est le même fichier utilisé pour la méthode du script d'activation ci-dessous. Pour Fish, il est probablement toujours plus facile d'utiliser cette méthode.

Utiliser eval signifie que la commande est invoquée et évaluée à chaque démarrage d'un shell, ce qui peut retarder la réactivité du shell. Pour accélérer cela, écrivez le script généré dans un fichier, puis sourcez-le.

**Bash**

Enregistrez le script quelque part.

```
_DSLR_COMPLETE=bash_source dslr > ~/.dslr-complete.bash
```

Sourcez le fichier dans ~/.bashrc.

```
. ~/.dslr-complete.bash
```

**Zsh**

Save the script somewhere.

```
_DSLR_COMPLETE=zsh_source dslr > ~/.dslr-complete.zsh
```

Sourcez le fichier dans ~/.zshrc.

```
. ~/.dslr-complete.zsh
```

**Fish**

Enregistrez le script dans ~/.config/fish/completions/foo-bar.fish :

```
_DSLR_COMPLETE=fish_source dslr > ~/.config/fish/completions/dslr.fish
```

</details>



## Configuration

Vous pouvez indiquer à DSLR de quelle base de données prendre des instantanés de plusieurs façons :

**DATABASE_URL**

Si la variable d'environnement `DATABASE_URL` est définie, DSLR l'utilisera pour se connecter
à votre base de données cible.

```bash
export DATABASE_URL=postgres://username:password@host:port/database_name
````

**dslr.toml**

Si un fichier `dslr.toml` existe dans le répertoire courant, DSLR en lira les
paramètres à partir de celui-ci. DSLR privilégiera ce fichier par rapport à la variable d'environnement.

```toml
url = 'postgres://username:password@host:port/database_name'
```

**Option `--url`**

Enfin, vous pouvez passer explicitement la chaîne de connexion via l'option `--url`.  
Cela remplacera toutes les autres configurations ci-dessus.

## Utilisation

```
$ dslr snapshot my-first-snapshot
Created new snapshot my-first-snapshot

$ dslr restore my-first-snapshot
Restored database from snapshot my-first-snapshot

$ dslr list

  Name                Created            Size
 ─────────────────────────────────────────────
  my-first-snapshot   2 minutes ago   3253 kB

$ dslr rename my-first-snapshot fresh-db
Renamed snapshot my-first-snapshot to fresh-db

$ dslr delete some-old-snapshot
Deleted some-old-snapshot

$ dslr export my-feature-test
Exported snapshot my-feature-test to my-feature-test_20220730-075650.dump

$ dslr import snapshot-from-a-friend_20220730-080632.dump friend-snapshot
Imported snapshot friend-snapshot from snapshot-from-a-friend_20220730-080632.dump
```

Pour forcer l’écrasement d’un instantané existant dans un shell non interactif, utilisez le drapeau `-y` :

```
$ dslr snapshot my-first-snapshot -y
Updated snapshot my-first-snapshot
```

## Comment cela fonctionne-t-il ?

DSLR prend des instantanés en clonant des bases de données en utilisant la fonctionnalité des bases de données [Modèles](https://www.postgresql.org/docs/current/manage-ag-templatedbs.html) de Postgres.  
C'est la principale source de la rapidité de DSLR.

Cela signifie que prendre un instantané revient simplement à créer une nouvelle base de données en utilisant la base de données principale comme modèle.  
Restaurer un instantané consiste simplement à supprimer la base de données principale et à créer une nouvelle base de données en utilisant la base de données instantanée comme modèle.  
Et ainsi de suite.

## Contributeurs

[![Contributeurs](https://contrib.rocks/image?repo=mixxorz/DSLR)](https://github.com/mixxorz/DSLR/graphs/contributors)

## Licence

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---