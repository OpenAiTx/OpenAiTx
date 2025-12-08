# Wrapper dégradé de fondu React Native

<p align="center">
  <img src="https://raw.githubusercontent.com/pioner92/rn-fade-wrapper/main/./assets/img.png" width="700" alt="Démo du wrapper dégradé de fondu React Native" />
</p>

**`rn-fade-wrapper`** est un composant React Native simple et très performant qui ajoute des **dégradés de fondu** fluides et personnalisables aux bords de tout contenu. Parfait pour améliorer l'expérience utilisateur dans les conteneurs défilables, listes, carrousels, modaux ou toute vue avec contenu débordant.

<div align="center" style="max-width: 400px; margin: auto;">
  <a href="https://www.npmjs.com/package/rn-fade-wrapper">
    <img src="https://img.shields.io/npm/v/rn-fade-wrapper.svg" alt="version npm" />
  </a>
  <img src="https://img.shields.io/badge/platform-iOS-blue?logo=apple" alt="iOS" />
  <img src="https://img.shields.io/badge/platform-Android-green?logo=android" alt="Android" />
  <img src="https://img.shields.io/badge/types-TypeScript-blue?logo=typescript" alt="TypeScript" />
  <img src="https://img.shields.io/badge/license-MIT-yellow.svg" alt="Licence MIT" />
  <a href="https://bundlephobia.com/result?p=rn-fade-wrapper">
    <img src="https://img.shields.io/bundlephobia/minzip/rn-fade-wrapper" alt="Taille du bundle" />
  </a>
</div>

---

## ✨ Fonctionnalités

- ⚡ Rendu natif pour **iOS** et **Android**
- 🔁 Supporte les directions de dégradé **verticale** et **horizontale**
- 🎨 Taille et couleur de fondu **entièrement personnalisables** (par côté ou uniforme)
- ↕️ Mode `inward` optionnel pour un fondu **vers le contenu** au lieu de vers l'extérieur
- 🧩 API simple : wrapper prêt à l’emploi avec des props intuitives
- 💪 Excellente performance avec faible surcharge — idéal pour vues défilables et animations

---

## 📦 Installation

```bash
yarn add rn-fade-wrapper
```

or

```bash
npm install rn-fade-wrapper
```

### Expo

Cette bibliothèque fonctionne dans Expo (avec `expo prebuild`) sans configuration supplémentaire.

---

## 📱 Support des plateformes

| Plateforme | Ancienne Arch | Fabric |
|------------|---------------|--------|
| iOS        | ✅             | ✅      |
| Android    | ✅             | ✅      |

---

## 🚀 Démarrage rapide

```tsx
import { FadeWrapper } from 'rn-fade-wrapper';

const MyComponent = () => {
  return (
    <FadeWrapper
      color="#ffffff"
      size={24}
      orientation="vertical"
    >
      <ScrollView>
        <Text>Fading edges example</Text>
      </ScrollView>
    </FadeWrapper>
  );
};
```

---

## 🧩 Propriétés

| Propriété    | Type                       | Par défaut              | Description |
|--------------|----------------------------|------------------------|-------------|
| `color`      | `string`                   | `"#ffffff"`            | Couleur du dégradé (peut être toute chaîne de couleur valide) |
| `size`       | `number`                   | `20`                   | Taille uniforme du dégradé en points |
| `style`      | `ViewStyle`                | `{ zIndex: 2 }`        | Style personnalisé appliqué à la vue wrapper |
| `inward`     | `boolean`                  | `false`                | Fait que le dégradé s’estompe vers l’intérieur (vers le centre) au lieu de l’extérieur |
| `sizes`      | `{ top?: number, right?: number, bottom?: number, left?: number }` | `undefined` | Tailles spécifiques du dégradé par bordure (remplace `size` et `orientation`) |
| `orientation`| `'horizontal' \| 'vertical'` | `'vertical'`          | Préréglage de direction : applique `size` en haut/bas ou gauche/droite |
| `children`   | `React.ReactNode`          | —                      | Votre contenu encapsulé |

> **Note :** `sizes` a la priorité sur `size` et `orientation`.

---

## 🎛 Exemples

### 🎯 Côtés personnalisés + dégradé vers l’intérieur :
```tsx
<FadeWrapper
  color="black"
  inward
  sizes={{ top: 20, bottom: 30 }}
>
  <FlatList ... />
</FadeWrapper>
```

### 📜 Fondu de défilement horizontal :
```tsx
<FadeWrapper
  color="rgba(0,0,0,0.5)"
  size={16}
  orientation="horizontal"
>
  <ScrollView horizontal>
    {/* content */}
  </ScrollView>
</FadeWrapper>
```

---

## 🛠 Sous le capot

- **iOS :** Utilise `CAGradientLayer` à l’intérieur de la `UIView` native  
- **Android :** Dessine un `LinearGradient` sur un `ViewGroup` personnalisé en utilisant Canvas  
- Gère la mise en page et les re-rendus avec une logique spécifique à chaque plateforme pour la cohérence  

---

## 💡 Astuce UX

Utilisez `rn-fade-wrapper` pour indiquer subtilement un débordement de contenu — particulièrement dans les carrousels, vues défilantes et curseurs horizontaux. Les dégradés aident à suggérer à l’utilisateur qu’il y a plus à faire défiler, améliorant ainsi l’engagement.  

---

## 📘 Licence

MIT — libre d’utilisation, d’amélioration et de contribution 🎉



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-08

---