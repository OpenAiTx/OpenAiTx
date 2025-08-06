
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# winjs-plugin-security

Un plugin qui fournit des fonctionnalités de sécurité renforcées pour les projets WinJS, principalement utilisé pour générer des attributs SRI (Subresource Integrity).

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## Fonctionnalités

- Génération automatique d'attributs SRI pour les balises `<script>` et `<link>` dans les fichiers HTML
- Prise en charge des algorithmes de hachage SHA-256, SHA-384, SHA-512 (configurables)
- Ajout automatique de l'attribut `crossorigin="anonymous"` pour garantir le bon fonctionnement du SRI
- N'est actif qu'en environnement de production, ignoré automatiquement en environnement de développement

## Installation

```bash
pnpm add @winner-fed/plugin-security
```
## Méthode d'utilisation

Ajoutez la configuration du plugin dans votre fichier de configuration `.winrc.ts` :


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Options de configuration

### `sri`

- **Type** : `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Valeur par défaut** : doit être définie manuellement
- **Description** : Active ou non la fonctionnalité SRI (Subresource Integrity) et permet de configurer l’algorithme de hachage en option

Lorsque la valeur est `true` ou `{}`, le plugin va :

1. Scanner les fichiers HTML générés après la compilation
2. Ajouter l’attribut `integrity` à toutes les balises `<script>` ayant un attribut `src`
3. Ajouter l’attribut `integrity` à toutes les balises `<link>` ayant un attribut `href`
4. Ajouter automatiquement l’attribut `crossorigin="anonymous"` (s’il n’existe pas)

Vous pouvez également spécifier l’algorithme de hachage sous forme d’objet :


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### Sortie HTML (après activation de SRI)


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## Consignes de sécurité

SRI (Intégrité des sous-ressources) est une fonctionnalité de sécurité qui permet au navigateur de vérifier que les ressources récupérées (par exemple celles provenant d'un CDN) n'ont pas été modifiées de manière malveillante. Lorsque le navigateur charge une ressource, il calcule la valeur de hachage de celle-ci et la compare avec la valeur de hachage spécifiée dans l'attribut `integrity`. Si les valeurs de hachage ne correspondent pas, le navigateur refusera de charger cette ressource.

Pour les balises `<script>`, cela signifie que le code contenu ne sera pas exécuté ; pour les liens CSS, cela signifie que les styles ne seront pas chargés.

Pour plus d'informations sur SRI, vous pouvez consulter [Intégrité des sous-ressources - MDN](https://developer.mozilla.org/fr/docs/Web/Security/Subresource_Integrity).

## Remarques

1. Ce plugin n'est effectif que lors de la construction en production, il sera automatiquement ignoré en environnement de développement
2. Il faut s'assurer que les fichiers de ressources soient accessibles dans le répertoire de sortie de la construction
3. L'attribut `integrity` doit être utilisé conjointement avec l'attribut `crossorigin` pour fonctionner correctement

## Licence

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---