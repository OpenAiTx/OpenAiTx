# Une collection de modèles `.gitignore`

Ceci est la collection de modèles de fichiers [`.gitignore`][man] de GitHub.
Nous utilisons cette liste pour alimenter les sélecteurs de modèles `.gitignore` disponibles
dans l’interface GitHub.com lors de la création de nouveaux dépôts et fichiers.

Pour plus d’informations sur le fonctionnement des fichiers `.gitignore` et leur utilisation,
les ressources suivantes sont d’excellents points de départ :

- Le [chapitre Ignorer des fichiers][chapter] du livre [Pro Git][progit].
- L’[article Ignorer des fichiers][help] sur le site d’aide de GitHub.
- La page du manuel [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Structure des dossiers

Nous proposons une collection de modèles, organisés de la manière suivante :

- Le dossier racine contient les modèles les plus courants, pour aider les utilisateurs à démarrer
  avec les langages de programmation et technologies populaires. Ceux-ci définissent un ensemble significatif
  de règles pour bien commencer et éviter de commettre des fichiers non importants dans votre dépôt.
- [`Global`](./Global) contient des modèles pour divers éditeurs, outils et
  systèmes d’exploitation qui peuvent être utilisés dans différentes situations. Il est recommandé
  soit [d’ajouter ces règles à votre modèle global](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  soit de les fusionner dans vos modèles spécifiques au projet si vous souhaitez les utiliser
  de manière permanente.
- [`community`](./community) contient des modèles spécialisés pour d’autres langages,
  outils et projets populaires, qui n’ont pas encore leur place dans les modèles principaux.
  Ceux-ci doivent être ajoutés à vos modèles spécifiques au projet lorsque vous décidez
  d’adopter le framework ou l’outil concerné.

## Qu’est-ce qu’un bon modèle ?

Un modèle doit contenir un ensemble de règles pour aider les dépôts Git à fonctionner avec un
langage de programmation, framework, outil ou environnement spécifique.

S’il n’est pas possible de sélectionner un petit ensemble de règles utiles pour cette situation,
alors le modèle n’est pas adapté à cette collection.

Si un modèle est essentiellement une liste de fichiers installés par une version particulière
d’un logiciel (par exemple un framework PHP), il peut être placé dans le dossier `community`.
Voir la section [modèles versionnés](#modèles-versionnés) pour plus de détails.

Si vous avez un petit ensemble de règles, ou souhaitez prendre en charge une technologie peu
répandue, et pensez que cela sera utile à d’autres, veuillez lire la section sur les
[modèles spécialisés](#modèles-spécialisés) pour plus de détails.

Incluez des détails lors de l’ouverture d’une pull request si le modèle est important et visible.
Nous ne l’accepterons peut-être pas immédiatement, mais nous pouvons le promouvoir à la racine plus tard
en fonction de l’intérêt suscité.

Veuillez aussi comprendre que nous ne pouvons pas lister tous les outils ayant jamais existé.
Notre objectif est de proposer une collection des modèles _les plus courants et utiles_,
et non de couvrir tous les projets possibles. Si nous choisissons de ne pas inclure votre
langage, outil ou projet, ce n’est pas parce qu’il n’est pas excellent.

## Directives de contribution

Nous serions ravis que vous nous aidiez à améliorer ce projet. Pour nous aider à maintenir cette collection
de haute qualité, nous demandons que les contributions respectent les directives suivantes.

- **Fournissez un lien vers la page d’accueil de l’application ou du projet**. À moins qu’il ne soit
  extrêmement populaire, il est possible que les mainteneurs ne connaissent pas ou n’utilisent pas
  le langage, le framework, l’éditeur, l’application ou le projet auquel s’applique votre modification.

- **Fournissez des liens vers la documentation** soutenant la modification proposée.
  La documentation officielle et à jour mentionnant les fichiers à ignorer est l’idéal.
  Si aucune documentation n’est disponible, faites de votre mieux pour expliquer à quoi servent les fichiers ignorés.

- **Expliquez pourquoi vous effectuez une modification**. Même si cela paraît évident, veuillez
  prendre une ou deux phrases pour expliquer pourquoi votre changement ou ajout est nécessaire.
  Il est particulièrement utile d’indiquer pourquoi ce changement concerne _tous_ les utilisateurs
  de la technologie concernée, et pas seulement vous ou votre équipe.

- **Considérez la portée de votre modification**. Si votre changement est spécifique à un
  certain langage ou framework, assurez-vous de le faire sur le modèle correspondant à ce langage ou framework,
  et non sur celui d’un éditeur, outil ou système d’exploitation.

- **Veuillez ne modifier _qu’un seul modèle_ par pull request**. Cela permet de garder les demandes
  de fusion et les retours concentrés sur un projet ou une technologie spécifique.

De manière générale, plus vous nous aiderez à comprendre votre modification,
plus nous pourrons accepter rapidement votre contribution.

## Modèles versionnés

Certains modèles peuvent évoluer considérablement entre les versions, et si vous souhaitez contribuer
à ce dépôt, nous devons suivre ce processus spécifique :

- le modèle à la racine doit correspondre à la version actuellement prise en charge
- le modèle à la racine ne doit pas avoir de numéro de version dans le nom du fichier (c’est-à-dire
  “evergreen”)
- les versions précédentes des modèles doivent se trouver dans `community/`
- les versions précédentes du modèle doivent inclure la version dans le nom du fichier,
  pour plus de lisibilité

Cela garantit que les utilisateurs obtiennent la dernière version (car ils utiliseront celle à la racine)
tout en permettant aux mainteneurs de prendre en charge les anciennes versions encore utilisées.

## Modèles spécialisés

Si vous avez un modèle à proposer, mais qu’il n’est pas vraiment courant, pensez à l’ajouter
au dossier `community` dans un sous-dossier adapté.

Les règles de votre modèle spécialisé doivent être spécifiques au framework ou à l’outil concerné,
et tout modèle additionnel pertinent doit être mentionné dans un commentaire en en-tête du modèle.

Par exemple, ce modèle pourrait se trouver à `community/DotNet/InforCRM.gitignore` :

```
# Modèle gitignore pour InforCRM (anciennement SalesLogix)
# site web : https://www.infor.com/product-summary/cx/infor-crm/
#
# Recommandé : VisualStudio.gitignore

# Ignorer les fichiers de modèle générés automatiquement
ModelIndex.xml
ExportedFiles.xml

# Ignorer les fichiers de déploiement
[Mm]odel/[Dd]eployment

# Forcer l’inclusion des SupportFiles du portail
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Processus de contribution

Voici comment nous vous suggérons de proposer une modification à ce projet :

1. [Forkez ce projet][fork] sur votre compte.
2. [Créez une branche][branch] pour la modification que vous souhaitez apporter.
3. Apportez vos modifications sur votre fork.
4. [Envoyez une pull request][pr] depuis la branche de votre fork vers notre branche `main`.

Utiliser l’interface web pour effectuer les modifications est également possible, et cela
vous aidera en forkant automatiquement le projet et en vous invitant à envoyer une pull request.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Licence

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---