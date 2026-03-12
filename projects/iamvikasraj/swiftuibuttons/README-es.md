# jordansingerbutton

Un hermoso componente de contador interactivo para SwiftUI que presenta botones de flecha con efecto glassmorphic y animaciones suaves.

## 📱 Demostración



## 🌿 Ramas

### `main` - Aplicación Completa
La aplicación jordansingerbutton completa con funcionalidad de contador.

### `tutorial` - Componente de Botón de Flecha
Una versión limpia y autónoma que se centra solo en el hermoso componente de botón de flecha. ¡Perfecto para aprender y compartir!

**Para ver la versión tutorial:**
```bash
git checkout tutorial
```

## 🚀 Inicio Rápido

### Uso del Componente Botón de Flecha

El `ArrowButton` es un componente reutilizable de SwiftUI que crea un hermoso botón glassmórfico con:
- Apariencia metálica de acero con trazos de múltiples capas
- Efecto de reflejo difuminado
- Animaciones suaves
- Rotación personalizable

```swift
import SwiftUI

ArrowButton(rotation: .degrees(0))  // Pointing down
ArrowButton(rotation: .degrees(180)) // Pointing up
ArrowButton(rotation: .degrees(90))  // Pointing left
ArrowButton(rotation: .degrees(270)) // Pointing right
```

### Uso Completo de la Aplicación

La aplicación completa incluye navegación de fechas con etiquetas "Hoy", "Mañana", "Ayer" y transiciones suaves de fecha.

## 📁 Estructura del Proyecto

```
jordansingerbutton/
├── CounterView.swift          # Counter with arrow buttons (includes ArrowButton)
├── JordanSingerButtonApp.swift  # App entry point
└── Assets.xcassets/            # Arrow image asset
```

## 🎨 Características

- **Diseño Glassmórfico**: Hermosa apariencia metálica de acero
- **Animaciones Suaves**: Animaciones basadas en resorte para interacciones
- **Accesibilidad**: Soporte completo para VoiceOver
- **Personalizable**: Fácil de modificar colores, tamaños y rotaciones

## 📝 Licencia

¡Gratis para usar y modificar en tus proyectos!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-12

---