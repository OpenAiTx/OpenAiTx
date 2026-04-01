# Typst-live
Ceci est un utilitaire simple pour surveiller les modifications de votre fichier [typst](https://github.com/typst/typst) et les
recompiler automatiquement pour un retour en temps réel. `typst-live` vous permet d’ouvrir un onglet dans votre navigateur avec le pdf généré par typst et de le recharger automatiquement
chaque fois que vos fichiers source `.typ` sont modifiés.

## Différence avec le flag `--watch`
`typst-live` héberge un serveur web qui actualise automatiquement la page afin que vous n’ayez pas à la recharger manuellement avec `typst --watch`

## Installation
Si vous avez [rust](https://www.rust-lang.org) installé, utilisez la commande suivante :
```
cargo install typst-live
```

Si vous utilisez Nix, vous pouvez exécuter typst-live directement depuis le dépôt GitHub en utilisant la commande suivante :
```
nix run github:ItsEthra/typst-live
```

## Utilisation
### 1. Avec recompilation automatique
* Lancez `typst-live` depuis votre terminal :
```
$ typst-live <file.typ>
Server is listening on http://127.0.0.1:5599/
```
* Allez à `http://127.0.0.1:5599/` dans votre navigateur.
* Modifiez maintenant votre `file.typ` et regardez les changements apparaître dans l’onglet du navigateur.

### 2. Avec recompilation manuelle
Vous pouvez utiliser `typst-live` pour recharger les fichiers pdf sans recompilation des fichiers sources.
Pour cela, vous devez utiliser l’option `--no-recompile` qui désactive la recompilation et héberge simplement
votre fichier pdf dans un onglet du navigateur, vous devrez spécifier le `filename` en tant que pdf au lieu du fichier source `.typ`.
Chaque fois que le fichier pdf change, l’onglet du navigateur sera rafraîchi.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-01

---