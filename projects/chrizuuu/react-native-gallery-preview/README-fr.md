  
 # react-native-gallery-preview
  
  <div>
    <img align="right" height="720" src="https://raw.githubusercontent.com/chrizuuu/react-native-gallery-preview/main/example.gif">
  </div>

  **GalleryPreview** est un composant modal flexible pour des aperçus de galerie faciles avec un support complet des gestes. Utilisant `Reanimated` et `React Native Gesture Handler`, il offre une expérience utilisateur fluide et simple pour iOS et Android.
  
  ### Fonctionnalités
  
  * ⚡  **Interactions et animations gestuelles fluides :** Profitez d’animations et de gestes fluides et réactifs pour une interface utilisateur agréable.
  * 🔍 **Double tapotement et pincement pour zoomer :** Les utilisateurs peuvent facilement zoomer avant et arrière sur les images avec de simples gestes de double tapotement et pincement.
  * 👆 **Tirer vers le bas pour fermer :** Geste intuitif de tirage vers le bas pour fermer l’aperçu de la galerie, rendant la navigation fluide.
  *  ↔️ **Support RTL**
  * 📱 **Compatible avec `iOS` et `Android` :** Entièrement compatible avec les appareils iOS et Android, garantissant une expérience cohérente sur toutes les plateformes.
  * 📱 **Compatible avec `Expo`**
  ### Commencer
  Avant de pouvoir utiliser GalleryPreview, vous devez configurer react-native-reanimated et react-native-gesture-handler. Suivez les liens ci-dessous pour des guides d’installation détaillés :
  
  * [Configurer Reanimated](https://docs.swmansion.com/react-native-reanimated/docs/fundamentals/getting-started/#installation)
  * [Configurer React Native Gesture Handler](ht↔️tps://docs.swmansion.com/react-native-gesture-handler/docs/fundamentals/installation)

  Une fois les dépendances installées, vous pouvez ajouter react-native-gallery-preview à votre projet :
  



  ```sh
  npm install react-native-gallery-preview
  # or
  yarn add react-native-gallery-preview
  
  ```

### Exemple

```tsx
import React, { useState } from 'react';
import { Button, View } from 'react-native';
import GalleryPreview from 'react-native-gallery-preview';

export const App = () => {
  const [isVisible, setIsVisible] = useState(false);

  const images = [
    { uri: 'https://example.com/image1.jpg' },
    { uri: 'https://example.com/image2.jpg' },
    // Add more images here
  ];

  return (
    <View>
      <Button title="Open Gallery Preview" onPress={() => setIsVisible(true)} />
      <GalleryPreview
        isVisible={isVisible}
        onRequestClose={() => setIsVisible(false)}
        images={images}
      />
    </View>
  );
};
```
### Props

| Nom de la prop             | Type                                      | Description                                                                                                                      | Défaut                                                                                                             |
|----------------------------|-------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------|
| `isVisible`                | `boolean`                                 | Contrôle la visibilité de la fenêtre modale du visualiseur d'images.                                                            | -                                                                                                                  |
| `onRequestClose`           | `() => void`                              | Fonction pour fermer la fenêtre modale du visualiseur d'images.                                                                 | -                                                                                                                  |
| `images`                   | `ImageItemURI[]`                          | Tableau d'URI d'images à afficher.                                                                                               | -                                                                                                                  |
| `initialIndex?`             | `number`                                  | L'index initial de l'image à afficher lors de l'ouverture du visualiseur.                                                        | `0`                                                                                                                |
| `gap?`                      | `number`                                  | L'espacement entre les images dans le visualiseur.                                                                               | `24`                                                                                                               |
| `simultaneousRenderedImages?` | `number`                                  | Le nombre d'images rendues simultanément pour l'optimisation.                                                                    | `6`                                                                                                                |                                                                                                           |
| `OverlayComponent?`          | `(props: GalleryOverlayProps) => React.ReactNode` | Composant optionnel à afficher au-dessus du visualiseur d'images.                                                                | -                                                                                                                  |
| `ImageComponent?`           | `(props: GalleryImageComponentProps) => React.JSX.Element` | Composant personnalisé optionnel pour rendre chaque image.                                                                       | -                                                                                                                  |
| `springConfig?`             | `SpringConfig`                            | Configuration de ressort pour les animations.                                                                                     | `{ damping: 1000, mass: 1, stiffness: 250, restDisplacementThreshold: 0.02, restSpeedThreshold: 4 }`                |
| `doubleTabEnabled?`           | `boolean`                                        | Activer ou désactiver la fonctionnalité de double-tap pour zoomer.                                                               | `true`                                                                                                             |
| `pinchEnabled?`               | `boolean`                                        | Activer ou désactiver la fonctionnalité de pincement pour zoomer.                                                                | `true`                                                                                                             |
| `swipeToCloseEnabled?`        | `boolean`                                        | Activer ou désactiver la fonctionnalité de balayage pour fermer.                                                                 | `true`                                                                                                             |
| `backgroundColor?`        | `string`                                        | La couleur de fond de la fenêtre modale, DefaultHeader et StatusBar.                                                             | `#000`                                                                                                             |
| `headerTextColor?`        | `string`                                        | Couleur du texte dans l'en-tête.                                                                                                 | `#fff`                                                                                                             |




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---