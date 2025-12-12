[![Contribuidores](https://img.shields.io/github/contributors/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/graphs/contributors)
[![Bifurcaciones](https://img.shields.io/github/forks/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/metworks/members)
[![Estrellas](https://img.shields.io/github/stars/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/stargazers)
[![Problemas](https://img.shields.io/github/issues/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/Wladefant/mshdabiola/Play_NotePad/issues)
[![Licencia](https://img.shields.io/github/license/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/master/LICENSE)

# NotePad

[<img src="/images/ic_launcher-playstore.png" align="left"
width="200" hspace="10" vspace="10">](/images/ic_launcher-playstore.png)

Notepad es una aplicación versátil para tomar notas que te permite capturar y organizar fácilmente tus
pensamientos, ideas y tareas. Con una variedad de funciones, Play Notepad facilita mantenerse al día con
tus notas y mantenerte organizado.

Play NotePad está disponible en Google Play Store:

<p align="left">
<a href="https://play.google.com/store/apps/details?id=com.mshdabiola.playnotepad">
    <img alt="Consíguelo en Google Play"
        height="70"
        src="https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png" />
</a>

<a href="https://f-droid.org/packages/com.mshdabiola.playnotepad.foss/">
    <img alt="Consíguelo en F-Droid"
        height="70"
        src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png" />
</a>

<a href="https://github.com/mshdabiola/NotePad/releases">
    <img alt="Consíguelo en GitHub"
        height="70"
        src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/github_image.png" />
</a>  



<a href="https://github.com/mshdabiola/Play_NotePad">Ver Demo</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">Reportar error</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">Solicitar característica</a>
  </p>

## Acerca del Proyecto

[<img src="/images/screenshot1.png" align="left"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot1.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png)

Algunas características destacadas:

- Modo perezoso: El desplazamiento automático de las publicaciones te permite disfrutar de increíbles publicaciones sin mover el pulgar
- Crear y editar notas de texto fácilmente.
- Tomar una foto o elegir una de tu carrete para adjuntarla a una nota.
- Dibujar bocetos y diagramas a mano alzada para anotar tus notas.
- Grabar notas de audio y reproducirlas más tarde.
- Mantener las notas importantes en la parte superior de tu lista para un acceso fácil.
- Crear listas de verificación y llevar un control de tus tareas con casillas de verificación.
- Organizar tus notas etiquetándolas con etiquetas.
- Duplicar notas para una referencia fácil.
- Compartir tus notas con otros por correo electrónico o mensajería.
- Establecer recordatorios para las notas para que nunca olvides tareas o eventos importantes.
- Eliminar notas que ya no necesitas.
- Mantener tus notas organizadas archivando tareas antiguas o completadas.
- Añadir color a tus notas para hacerlas más atractivas visualmente.
- Añadir una imagen al fondo de tus notas para un aspecto más personalizado.
- Ver tus notas en formato de lista o columna para una lectura y edición fácil.
- Buscar tus notas por palabra clave, etiqueta y tipo.
- Usar la aplicación sin conexión y acceder a tus notas en cualquier momento.

## Construido con


## Arquitectura limpia con 3 módulos principales

[//]: # (<img src="/images/AndroidTemplate-CleanArchitecture.jpeg" alt="ArchiTecture logo"/>)

- UI declarativa (con [Jetpack Compose](https://developer.android.com/jetpack/compose))
    - Navegación Compose (
      con [Soporte Hilt](https://developer.android.com/jetpack/compose/libraries#hilt-navigation)
      y Ejemplo de Inyección Asistida)
- Datos (para base de datos, API y código de preferencias)
- Dominio (para lógica de negocio y modelos)
- AndroidApp (para lógica de UI, con MVVM)
- Esta versión trae [Modularización](https://developer.android.com/topic/modularization)
- Gestión de versiones (
  con [Catálogo de versiones](https://docs.gradle.org/current/userguide/platforms.html))
- Lógica de compilación compartida (
  con [Plugins de convención](https://docs.gradle.org/current/samples/sample_convention_plugins.html))
- Inyección de dependencias (con [Hilt](http://google.github.io/hilt/))
- Programación reactiva (
  con [Kotlin Flows](https://kotlinlang.org/docs/reference/coroutines/flow.html))
- Componentes de arquitectura Android para compartir ViewModels durante cambios de configuración
- Soporte de [Pantalla de bienvenida](https://developer.android.com/develop/ui/views/launch/splash-screen)
- Biblioteca Google Material 3 de [Material Design](https://material.io/blog/android-material-theme-color)

- Configuración Edge To Edge

[//]: # (## Pruebas)

[//]: # (- Biblioteca [Mockk]&#40;https://mockk.io/&#41;)

[//]: # (- Pruebas unitarias)

[//]: # (- Pruebas de aplicación)

[//]: # (    - ejemplo de cómo trabajar con pruebas)

[//]: # (- Pruebas de actividad &#40;con [Compose Testing]&#40;https://developer.android.com/jetpack/compose/testing&#41;&#41;)

[//]: # (    - ejemplo de cómo trabajar con ámbitos de corrutinas en pruebas)

## Contribución

1. Las contribuciones son lo que hacen que la comunidad de código abierto sea un lugar increíble para aprender, inspirar,
   y crear. Cualquier contribución que hagas es **muy apreciada**.

2. Ya sea que nos ayudes a corregir errores, mejorar la documentación o difundir el proyecto, ¡nos encantaría tenerte
   como parte de la comunidad de Gatsby!

3. ¡Gracias por tu interés en contribuir! Hay muchas maneras de contribuir a este proyecto. Comienza
   aquí (enlace a Contributing.md)

### Retroalimentación

¡No olvides darle una estrella al proyecto! ¡Gracias nuevamente!

Puedes usar [Github Discussions](https://github.com/mshdabiola/Play_NotePad/discussions) para
discusiones sobre la aplicación o simplemente preguntas en general. Allí también puedes enviar solicitudes de funciones (
¡por favor lee las instrucciones sobre cómo enviar una solicitud de función primero!) o si eres desarrollador,
haz un fork de este proyecto y crea un pull request

1. Haz un Fork del Proyecto
2. Crea tu Rama de Funcionalidad (`git checkout -b feature/AmazingFeature`)
3. Confirma tus Cambios (`git commit -m 'Add some AmazingFeature'`)
4. Sube la Rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

Aquí hay otras formas en que puedes ayudar:

* [Reportar errores](https://github.com/mshdabiola/Play_NotePad/issues)

* [Traducir la aplicación](https://poeditor.com/join/project/rdWI3SpnSW)

## Desarrollo

## Licencia

Play Notepad está licenciado bajo la Licencia Pública General de GNU (GPL-3.0). Puedes encontrar el texto
de la licencia en el archivo `LICENSE`.

## Contacto

mshdabiola - [@Mshdabiola](https://twitter.com/mshdabiola) - mshdabiola@gmail.com

## Agradecimientos


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---