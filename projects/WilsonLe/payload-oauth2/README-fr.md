# Plugin Payload OAuth2

<a href="LICENSE">
  <img src="https://img.shields.io/badge/license-MIT-brightgreen.svg" alt="Licence du logiciel" />
</a>
<a href="https://github.com/wilsonle/payload-oauth2/issues">
  <img src="https://img.shields.io/github/issues/wilsonle/payload-oauth2.svg" alt="Problèmes" />
</a>
<a href="https://npmjs.org/package/payload-oauth2">
  <img src="https://img.shields.io/npm/v/payload-oauth2.svg?style=flat-squar" alt="NPM" />
</a>

# Fonctionnalités

- ✅ Compatible avec Payload v3
- 🔐 Configure OAuth2 avec tous les fournisseurs
- ✨ Zéro dépendance
- ⚙ Hautement personnalisable

# Intégrations

Techniquement, ce plugin devrait fonctionner avec tous les fournisseurs OAuth2 génériques. Voici la liste des fournisseurs testés :

| Fournisseur | Statut                                                                                                                                                                                                      | Exemple                         |
| ----------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| Google      | [![Test Google OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml)    | [Config](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/google.ts)  |
| Zitadel     | [![Test Zitadel OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml) | [Config](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/zitadel.ts) |
| Apple       | Test non implémenté                                                                                                                                                                                        | [Config](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/apple.ts)   |

# Installation

```
npm install payload-oauth2
yarn install payload-oauth2
pnpm install payload-oauth2
```

Si vous vous sentez aventureux et souhaitez gérer le plugin vous-même, vous pouvez copier le répertoire `src` dans vos projets payload.

# Contribution

Les contributions et les retours sont les bienvenus.

Pour le faire fonctionner :

1. Clonez le projet.
2. `pnpm install`
3. `pnpm dev`

# Licence

La licence MIT (MIT). Veuillez consulter le [fichier de licence](LICENSE) pour plus d'informations.

# Remerciements

Ce package a été inspiré par [Payload Plugin OAuth](https://github.com/thgh/payload-plugin-oauth).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---