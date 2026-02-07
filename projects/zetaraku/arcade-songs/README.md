# arcade-songs

[![Coding Style](https://img.shields.io/badge/code_style-airbnb-%234B32C3)](https://github.com/airbnb/javascript) [![Gitmoji](https://img.shields.io/badge/commit_style-%20😜%20😍-%23FFDD67)](https://gitmoji.dev) [![Translation status](https://hosted.weblate.org/widgets/arcade-songs/-/svg-badge.svg)](https://hosted.weblate.org/engage/arcade-songs/) [![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs?ref=badge_shield)

A utility site that provides a search interface for arcade games songs and sheets.

## Prerequisites

- [Node.js](https://nodejs.org/) (LTS version or above)
- [Yarn](https://yarnpkg.com/)

## Setup

```sh
# install dependencies
yarn install
```

- Make a copy of the `.env.example` file as `.env` and fill out the required fields.

## Development

```sh
# serve with hot reload at localhost
yarn run dev

# serve with hot reload on local network
yarn run dev:host
```

- For a detailed explanation of each directory, check out the [Nuxt documentation](https://nuxtjs.org).

## Build for production

### Static hosting with SSG (recommended)

```sh
# Build the application (if needed), generate every route as a HTML file and statically export to dist/ directory (used for static hosting).
yarn run generate

# serve the dist/ directory like your static hosting would do (Netlify, Vercel, Surge, etc), great for testing before deploying.
yarn run serve
```

### Server hosting with SSR

```sh
# Build and optimize your application with webpack for production.
yarn run build

# Start the production server (after running nuxt build). Use it for Node.js hosting like Heroku, Digital Ocean, etc.
yarn run start
```

## Data Source

See: <https://github.com/zetaraku/arcade-songs-fetch>

## Contributing

[![Translation status](https://hosted.weblate.org/widgets/arcade-songs/-/287x66-grey.png)](https://hosted.weblate.org/engage/arcade-songs/)

**arcade-songs** is now being translated using [Weblate](https://weblate.org/), a web tool designed to ease translating for both developers and translators.

If you found any problem in the translation, you can help improve it by any of:

- [Editing on Weblate](https://hosted.weblate.org/projects/arcade-songs/arcade-songs/) directly.
- [Opening an issue](https://github.com/zetaraku/arcade-songs/issues) to point out the problem.
- [Creating a pull request](https://github.com/zetaraku/arcade-songs/pulls) to submit your edit.

The translation files are located in `locales/`.

If you have any ideas or suggestions, you can [open an issue](https://github.com/zetaraku/arcade-songs/issues) or [use the ask form](https://arcade-songs-report.zetaraku.dev/).

## Contributors ✨

- **Korean** translation
  - [Sungsoo Han (lomotos10)](https://github.com/lomotos10)
  - [DDinghoya (DDinghoya)](https://github.com/DDinghoya)
- **Spanish** translation
  - [gallegonovato (gallegonovato)](https://github.com/gallegonovato)
  - [Onyx (VendettaCalls)](https://github.com/VendettaCalls)
- **Indonesian** translation
  - [Echo (echocentrical)](https://github.com/echocentrical)

## Special Thanks ✨

- Internal level information for **maimai**
  - [maimai譜面定数ちほー🏖☀️ (@maiLv_Chihooooo)](https://twitter.com/maiLv_Chihooooo)
- Internal level information for **CHUNITHM**
  - [CHUNITHM譜面定数メインフレーム (@RCMF_chunithm)](https://twitter.com/RCMF_chunithm)
  - [chunirec チュウニズム非公式スコア管理ツール (@chunirec)](https://twitter.com/chunirec)
- Internal level information for **オンゲキ**
  - [オンゲキ譜面定数部 (@ongeki_level)](https://twitter.com/ongeki_level)
  - [OngekiScoreLog - オンゲキ非公式スコアツール (@ongeki_score)](https://twitter.com/ongeki_score)
- Internal level information for **ノスタルジア**
  - [EXP? (@exponent_iidx)](https://twitter.com/exponent_iidx)
  - [Nosdata (@nosdata)](https://twitter.com/nosdata)
- Sheet information for **maimai China ver. (舞萌DX)**
  - [CrazyKid (@CrazyKidCN)](https://github.com/CrazyKidCN)
- *... and all the players contributing sheet data and reporting issues!*

## License

Copyright © 2022 Raku Zeta.

Licensed under the [MIT License](./LICENSE).

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Fzetaraku%2Farcade-songs?ref=badge_large)
