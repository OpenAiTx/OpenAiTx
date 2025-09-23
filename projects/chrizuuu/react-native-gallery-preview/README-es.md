  
 # react-native-gallery-preview
  
  <div>
    <img align="right" height="720" src="https://raw.githubusercontent.com/chrizuuu/react-native-gallery-preview/main/example.gif">
  </div>

  **GalleryPreview** es un componente modal flexible para vistas previas de galerías con soporte completo de gestos. Usando `Reanimated` y `React Native Gesture Handler`, ofrece una experiencia de usuario fluida y sencilla tanto para iOS como para Android.
  
  ### Características
  
  * ⚡  **Interacciones y Animaciones de Gestos Suaves:** Experimenta animaciones y gestos fluidos y receptivos para una interfaz de usuario agradable.
  * 🔍 **Doble toque y pellizcar para hacer zoom:** Los usuarios pueden hacer zoom fácilmente en las imágenes con gestos simples de doble toque y pellizcar.
  * 👆 **Deslizar hacia abajo para cerrar:** Gestos intuitivos de deslizar hacia abajo para cerrar la vista previa de la galería, facilitando la navegación.
  *  ↔️ **Soporte RTL**
  * 📱 **Compatible con `iOS` y `Android`:** Totalmente compatible con dispositivos iOS y Android, garantizando una experiencia consistente en ambas plataformas.
  * 📱 **Compatible con `Expo`**
  ### Comenzar
  Antes de usar GalleryPreview, debes configurar react-native-reanimated y react-native-gesture-handler. Sigue los enlaces a continuación para guías detalladas de instalación:
  
  * [Configuración de Reanimated](https://docs.swmansion.com/react-native-reanimated/docs/fundamentals/getting-started/#installation)
  * [Configuración de React Native Gesture Handler](ht↔️tps://docs.swmansion.com/react-native-gesture-handler/docs/fundamentals/installation)

  Una vez instaladas las dependencias, puedes agregar react-native-gallery-preview a tu proyecto:
  



  ```sh
  npm install react-native-gallery-preview
  # or
  yarn add react-native-gallery-preview
  
  ```

### Ejemplo

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

| Nombre de Propiedad        | Tipo                                      | Descripción                                                                                                                      | Predeterminado                                                                                                    |
|----------------------------|-------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------|
| `isVisible`                | `boolean`                                 | Controla la visibilidad del modal del visor de imágenes.                                                                         | -                                                                                                                |
| `onRequestClose`           | `() => void`                              | Función para cerrar el modal del visor de imágenes.                                                                              | -                                                                                                                |
| `images`                   | `ImageItemURI[]`                          | Array de URIs de imágenes que se mostrarán.                                                                                      | -                                                                                                                |
| `initialIndex?`             | `number`                                  | El índice inicial de la imagen que se mostrará al abrir el visor.                                                                | `0`                                                                                                              |
| `gap?`                      | `number`                                  | El espacio entre imágenes en el visor.                                                                                           | `24`                                                                                                             |
| `simultaneousRenderedImages?` | `number`                                  | Número de imágenes renderizadas simultáneamente para optimización.                                                               | `6`                                                                                                              |                                                                                                         |
| `OverlayComponent?`          | `(props: GalleryOverlayProps) => React.ReactNode` | Componente opcional para renderizar sobre el visor de imágenes.                                                   | -                                                                                                                |
| `ImageComponent?`           | `(props: GalleryImageComponentProps) => React.JSX.Element` | Componente personalizado opcional para renderizar cada imagen.                                                                    | -                                                                                                                |
| `springConfig?`             | `SpringConfig`                            | Configuración de resorte para las animaciones.                                                                                   | `{ damping: 1000, mass: 1, stiffness: 250, restDisplacementThreshold: 0.02, restSpeedThreshold: 4 }`              |
| `doubleTabEnabled?`           | `boolean`                                        | Habilitar o deshabilitar la función de zoom con doble toque.                                                                      | `true`                                                                                                           |
| `pinchEnabled?`               | `boolean`                                        | Habilitar o deshabilitar la función de zoom por pellizco.                                                                        | `true`                                                                                                           |
| `swipeToCloseEnabled?`        | `boolean`                                        | Habilitar o deshabilitar la función de deslizar para cerrar.                                                                     | `true`                                                                                                           |
| `backgroundColor?`        | `string`                                        | El color de fondo del modal, DefaultHeader y StatusBar.                                                                            | `#000`                                                                                                           |
| `headerTextColor?`        | `string`                                        | Color del texto en el encabezado.                                                                                                 | `#fff`                                                                                                           |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---