![Vista previa de GitHub Cards](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike es una aplicación de entrega de comida simple y fácil de usar. Está construida usando Android-Jetpack Compose y se basa en el principio MVVM con Componentes Modernos de Arquitectura Android.

## Demo 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## Capturas de pantalla 📱 
Introducción | Inicio de sesión | Inicio | Detalles | Historial | Carrito | Perfil
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Construido con 🛠

- [Kotlin](https://kotlinlang.org/) - Lenguaje de programación oficial y de primera clase para el desarrollo Android.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose es el kit de herramientas moderno de Android para construir interfaces nativas.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Una coroutine es un patrón de diseño de concurrencia que puedes usar en Android para simplificar el código que se ejecuta de forma asíncrona.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow es una versión asíncrona de una Secuencia, un tipo de colección cuyos valores se producen de forma perezosa.
- [Componentes de Arquitectura Android](https://developer.android.com/topic/libraries/architecture) -
  Colección de bibliotecas que te ayudan a diseñar aplicaciones robustas, testables y mantenibles.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow es un flujo observable que mantiene estado y emite actualizaciones del estado actual y nuevo a sus recolectores.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow es una versión asíncrona de una Secuencia, un tipo de colección cuyos valores se producen de forma perezosa.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Almacena datos relacionados con la UI que no se destruyen en cambios de UI.
  - [Navegación con Jetpack Compose](https://developer.android.com/jetpack/compose/navigation) - El componente de Navegación proporciona soporte para aplicaciones Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore es una solución de almacenamiento de datos que te permite guardar pares clave-valor u objetos tipados con protocolos de buffers. DataStore usa coroutines de Kotlin y Flow para almacenar datos de forma asíncrona, consistente y transaccional.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt es una biblioteca de inyección de dependencias para Android que reduce el código repetitivo de hacer inyección de dependencias manual en tu proyecto. Hacer inyección de dependencias manual requiere construir cada clase y sus dependencias a mano, y usar contenedores para reutilizar y gestionar dependencias.












  
- [API de Splash](https://developer.android.com/develop/ui/views/launch/splash-screen) - A partir de Android 12, la API SplashScreen permite que las aplicaciones se inicien con animación, incluyendo un movimiento dentro de la aplicación al lanzar, una pantalla de bienvenida que muestra el ícono de tu aplicación y una transición hacia la propia aplicación. Un SplashScreen es una Ventana y por lo tanto cubre una Actividad.
- [Componentes de Material para Android](https://github.com/material-components/material-components-android)
  - Componentes de interfaz de usuario de Material Design modulares y personalizables para Android.
- [Figma](https://figma.com/) - Figma es un editor de gráficos vectoriales y herramienta de prototipado que es
  principalmente basado en la web.

## Arquitectura 🗼

Esta aplicación utiliza la arquitectura [***MVVM (Modelo Vista
Modelo-Vista)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Herramienta de construcción 🧰
Necesitas tener [Android Studio Beta 3 o superior](https://developer.android.com/studio/preview) para compilar este proyecto.

## Contacto 📩

¿Quieres contactarme? Envíame un mensaje directo a 👇

Envía un correo a:- gautamhazarika01@gmail.com

Mi Portafolio:- www.gautamhz.com

## Donación 💰

Si este proyecto te ayuda a reducir el tiempo de desarrollo, puedes invitarme a un café :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Licencia 🔖

```

MIT License

Copyright (c) 2026 Gautam Hazarika

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



```

## Backend:

Estoy construyendo el backend completamente en Kotlin usando ktor [aquí](https://github.com/gautam84/foodike-backend).


## Próximos pasos:

- Integrar el backend con la aplicación Android.
- Actualizar cada fragmento de código a la versión más reciente.
- Escribir pruebas unitarias, pruebas de integración y pruebas de UI/End-to-End.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---