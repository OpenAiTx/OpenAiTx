# PSFree version 1.5.1

PSFree est une collection d’exploits pour la console PS4. L’objectif principal du dépôt est la PS4, mais nous essayons de rendre les choses portables sur PS5.

## Fonctionnalités

- **Détection automatique :** Détecte automatiquement le type de console et la version du firmware (via [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **Exploit WebKit (PSFree) :** Point d’entrée via le navigateur web de la console.
- **Exploit Kernel (Lapse) :** Escalade les privilèges au niveau kernel.
- **Chargeur de payload :** Après une exploitation kernel réussie, attend un payload sur le port 9020.

## Portée des vulnérabilités

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Pris en charge par ce dépôt

Ce tableau indique les versions de firmware pour lesquelles la _version actuelle_ de ce dépôt fournit une chaîne d’exploit fonctionnelle et testée.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_Note : Le support pour d’autres firmwares listés dans le tableau "Portée des vulnérabilités" peut, ou non, être en cours de développement ou avoir été pris en charge dans des versions précédentes de ce dépôt. Veuillez consulter [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) pour l’historique du support._

## Liste TODO

- [ ] Problème d’écran noir/sauvegarde avec certains jeux
- [ ] `lapse.mjs` : Juste définir les bits pour les privilèges JIT
- [ ] `view.mjs` : Suppose PS4, ajouter la prise en charge PS5 également
- [ ] Ajouter le support PS5

## Copyright et auteurs :

AGPL-3.0-ou-supérieure (voir [`LICENSE`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Ce dépôt appartient au groupe `anonymous`. Nous désignons également les contributeurs anonymes par "anonymous".

## Remerciements :

- anonymous pour les dumps kernel du firmware PS4
- Consultez les fichiers appropriés pour d’autres contributeurs **supplémentaires**. Sauf indication contraire, tout ce qui se trouve ici peut aussi nous être attribué.

## Dons

(Monero/XMR) : **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---