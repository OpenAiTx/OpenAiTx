# gig

Gig est un compilateur gleam écrit en gleam.

## Comment utiliser

### Compiler et exécuter un fichier exemple :

```bash
# clone the repository
git clone https://github.com/schurhammer/gig
cd gig

# compile a sample
gleam run samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```
- Cela compilera le fichier `samples/hello_world.gleam` en `samples/hello_world.c` puis utilisera un compilateur C pour créer le binaire `samples/hello_world.exe`.  
- Gig ajoute l'extension `.exe` pour éviter les conflits de noms courants avec les répertoires sources.  

### Compiler gig :


```bash
# compile gig into a binary
gleam run src/gig.gleam --gc --release

# compile a sample using the gig binary
src/gig.exe samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```

### Compilez votre projet en utilisant le binaire gig :

- Ajoutez l'exécutable `gig` à votre chemin ou copiez-le dans votre projet.
- Copiez le répertoire `patch` dans votre projet.

```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your main module
gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```
- Vous devez exécuter gig depuis le répertoire racine du projet.  
- Gig inclura les fichiers sources du répertoire du module principal, du répertoire `patch` et de chaque répertoire source des dépendances téléchargées (c’est-à-dire `build/packages/<nom_du_package>/src`).  
- Téléchargez les dépendances en utilisant `gleam deps download`.  
- Votre module principal doit être non imbriqué, c’est-à-dire directement dans le répertoire `src`.  

### Compilez votre projet en utilisant gig comme dépendance de chemin  

- Ajoutez gig comme dépendance de chemin dans votre fichier `gleam.toml` `gig = { path = "../gig" }`.  
- Copiez le répertoire `patch` dans votre projet.


```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your project using gig as a path dependency
gleam run -m gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```

### Options facultatives :

- `--release` : activer l’optimisation.
- `--gc` : activer la collecte des déchets (sinon pas de collecte des déchets).
- `--debug` : inclure les symboles de débogage.
- `--headers` : générer les fichiers d’en-tête pour les fonctions FFI.
- `--compiler=name` : le nom/chemin du compilateur C.
- `-c` : générer uniquement le fichier C (pas le binaire).

> [!IMPORTANT]
> Dans le cas probable où vous rencontrez des dépassements de pile, augmentez la taille de votre pile. Ceux-ci se manifestent souvent par des erreurs de segmentation.
>
> ```
> ulimit -s unlimited
> ```

## Dépendances requises :

- Compilateur C (clang semble fonctionner le mieux)
- Boehm GC est nécessaire pour `--gc` (alias `libgc`)

## Bibliothèque standard

Puisqu’une grande partie de la bibliothèque standard est implémentée avec des appels `@external`, toutes les fonctions ne sont pas encore disponibles.
Certaines fonctions ont déjà été réimplémentées avec des correctifs, voir le répertoire `patch`. Le compilateur affichera un avertissement si une fonction non implémentée est utilisée, et un "todo" sera utilisé comme corps de fonction.

## Système de correctifs

Puisque gig est un projet tiers, la plupart des bibliothèques gleam existantes
ne sont probablement pas compatibles avec lui. Pour ces cas, nous avons un système de correctifs qui
vous permet de remplacer certains modules qui ne fonctionneraient pas autrement. Pour cela, créez simplement
un module appelé `x.patch.gleam` où `x` est le nom du module
que vous souhaitez corriger. Le correctif sera fusionné avec le module original, donc vous
n’avez qu’à implémenter les fonctions qui sont défectueuses.
Les correctifs peuvent être placés dans le répertoire `patch` ou dans n’importe quel répertoire source.

Pour un meilleur support du langage C dans votre éditeur, vous pouvez ajouter un fichier `.clangd` et
`compile_flags.txt` à votre projet.

`.clangd` :

```
CompileFlags:
  Add: [-Ipatch]
```

`compile_flags.txt` : (fichier vide)

## FFI

Vous pouvez utiliser l'annotation `@external(c, "", "function_name")` pour définir des fonctions C, similaire à la FFI dans gleam normal.  
Après cela, lancez le compilateur avec l'option `--headers` pour générer un fichier d'en-tête  
avec les déclarations de fonctions et de types nécessaires pour implémenter la fonction externe.  
Votre fichier d'implémentation C doit `#include` le fichier d'en-tête et porter le même nom que celui-ci.  
De préférence, vos fonctions devraient être dans un espace de noms, par exemple `module_name_function_name()`.

## Liste des fonctionnalités / À faire

### Bases

- [x] Booléen  
- [x] Entier  
- [x] Flottant  
- [x] Formats de nombres (autres que décimal)  
- [x] Chaîne de caractères  
- [x] Liste  
- [x] Égalité  
- [x] Affectations  
- [x] Modèles de rejet  
- [x] Inférence de type  
- [x] Annotations de type  
- [x] Modules (note : les modules sont résolus par rapport au fichier cible)  
- [x] Dépendances  
- [x] Importations non qualifiées  
- [x] Alias de type  
- [x] Blocs  
- [x] Constantes  
- [x] Gestion de mémoire (GC/RC)

### Fonctions

- [x] Fonctions  
- [x] Fonctions d'ordre supérieur


- [x] Fonctions anonymes  
- [x] Captures de fonctions  
- [x] Fonctions génériques  
- [x] Pipelines  
- [x] Arguments nommés  
- [ ] Commentaires de documentation (ignorés)  
- [ ] Dépréciations (ignorées)  

### Contrôle de flux  

- [x] Expressions case  
- [x] Motifs variables  
- [x] Motifs constructeurs  
- [x] Motifs chaîne de caractères  
- [x] Motifs listes  
- [x] Récursion  
- [ ] Appels en queue (note : le compilateur C peut le faire pour nous)  
- [x] Sujets multiples  
- [x] Motifs alternatifs  
- [x] Alias de motifs  
- [x] Gardes  
- [ ] Vérification d'exhaustivité  

### Autres types de données  

- [x] Tuples  
- [x] Types personnalisés  
- [x] Enregistrements  
- [x] Accesseurs d'enregistrements  
- [x] Mises à jour d'enregistrements  
- [x] Types personnalisés génériques  
- [x] Résultats  
- [ ] Tableaux de bits (support partiel)  

### Fonctionnalités avancées  

- [ ] Types opaques  
- [x] Utilisation  
- [x] Todo  
- [x] Panic
- [x] Laisser assert
- [x] Externes

## Contribution

Je n'accepte pas les contributions de code pour le moment. N'hésitez pas à créer des issues, des suggestions ou des discussions cependant.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---