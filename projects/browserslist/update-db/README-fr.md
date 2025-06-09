# Mettre à jour la base de données Browserslist

<img width="120" height="120" alt="Logo Browserslist par Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

Outil CLI pour mettre à jour `caniuse-lite` avec la base de données des navigateurs
à partir de la configuration [Browserslist](https://github.com/browserslist/browserslist/).

Certaines requêtes comme `last 2 versions` ou `>1%` dépendent des données réelles
de `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsorisé par Evil Martians" width="236" height="54">
</a>

## Pourquoi vous devez l'exécuter régulièrement

`npx update-browserslist-db@latest` met à jour la version de `caniuse-lite`
dans votre fichier lock npm, yarn ou pnpm.

Cette mise à jour apportera des données sur les nouveaux navigateurs aux outils de polyfill
comme Autoprefixer ou Babel et réduira les polyfills déjà inutiles.

Vous devez le faire régulièrement pour trois raisons :

1. Utiliser les dernières versions de navigateurs et statistiques dans les requêtes comme
   `last 2 versions` ou `>1%`. Par exemple, si vous avez créé votre projet
   il y a 2 ans et que vous n'avez pas mis à jour vos dépendances, `last 1 version`
   renverra des navigateurs datant de 2 ans.
2. Des données réelles sur les navigateurs conduiront à utiliser moins de polyfills. Cela réduira
   la taille des fichiers JS et CSS et améliorera les performances du site web.
3. Déduplication de `caniuse-lite` : pour synchroniser les versions dans différents outils.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---