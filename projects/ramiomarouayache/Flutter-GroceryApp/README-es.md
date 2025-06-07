# GroceryApp Starter

Plantilla de aplicación de comestibles optimizada para una experiencia de compra sencilla. 🛒✨

No dudes en marcar con una estrella ⭐ el repositorio si lo encuentras valioso.

## Diseño

**Haz clic en la imagen a continuación para ver el diseño en Figma:**

[![Vista previa del diseño](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨Requisitos

1. **Entorno de desarrollo:**
   - Cualquier IDE con el SDK de Flutter instalado (por ejemplo, VSCode, Android Studio, IntelliJ, etc.)

2. **Base de conocimientos:**
   - Conocimientos básicos o intermedios de Dart y Flutter
   - Entendimiento de la arquitectura MVVM
   - Familiaridad con la gestión de APIs
   - Nociones básicas de gestión de estado usando GetX

## Prueba
* Puedes descargar la versión preliminar para dispositivos Android desde aquí [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## Configuración
* Comienza configurando el endpoint de producto, credenciales y parámetros en `lib\constants\AppConstants`.
* **Alternativamente**, utiliza el endpoint gratuito proporcionado a continuación (vigente a la fecha de publicación) para realizar pruebas exitosas.
```dart
class AppConstants {
  // Reemplaza "YOUR_API_PREFIX" con la URL base de tu propia API.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //SI_EXISTE

  // Para pruebas, utiliza la URL base gratuita de la versión publicada
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Nombre completo del propietario del proyecto.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Aviso
* Para utilizar tus propios endpoints de API, personaliza las capas lógicas siguiendo las pautas de la arquitectura MVVM según la documentación de tu API.
* Algunas imágenes en la versión preliminar fueron eliminadas debido a restricciones de derechos de autor.

## Contribuciones

Por favor, haz un fork de este repositorio y contribuye mediante
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Cualquier contribución, grande o pequeña, nuevas funcionalidades, corrección de errores, son bienvenidas y apreciadas,
pero serán revisadas exhaustivamente.


## Primeros pasos
Este proyecto es un punto de partida para una aplicación Flutter.

Algunos recursos para comenzar si este es tu primer proyecto en Flutter:

- [Laboratorio: Escribe tu primera aplicación Flutter](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Ejemplos útiles de Flutter](https://flutter.io/docs/cookbook)

## Contador de visitas

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Cargando">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---