# shimmer - encantador userchrome de firefox con soporte para sidebery (v2.37)
![BOTÓN DE ESTRELLA](https://github.com/user-attachments/assets/227bfd9e-ce3a-4d76-b8b7-24ad55dc128a)[![ISSUE](https://github.com/user-attachments/assets/648d41c3-4812-47fd-9696-38d76a2a0a5a)](https://github.com/nuclearcodecat/shimmer/issues)[![BOTÓN DE DINERO](https://github.com/user-attachments/assets/18d7f816-f784-46b2-97b1-89173f68e227)](https://ko-fi.com/nuclearcodecat)

consulta el [registro de cambios](https://raw.githubusercontent.com/nuclearcodecat/shimmer/main/CHANGELOG.md) para un historial de cambios

### hola, considero este proyecto mayormente completo. no planeo nuevas funciones ya que simplemente no tengo ganas de trabajar en esto y estoy enfocado en algunos proyectos GRANDES ahora mismo. shimmer se ve genial y lo dejo así. siéntete libre de pedir algo aún, aunque no prometo que lo añadiré. gracias por todas las palabras amables y estrellas :333

## demostración
<!--
![sidebarcollapse](https://github.com/user-attachments/assets/be8cb062-19f6-40b5-b26d-6a4fe8ceff7b)
-->
![out](https://github.com/user-attachments/assets/41ca27e6-701b-4049-8e38-76bcb300cd85)


| usando sidebery                                                                                   | pestañas nativas                                                                                              |
|---------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------|
| ![y](https://github.com/user-attachments/assets/6c8ce4d2-a9a8-478c-b427-77417f6a27a5) | ![x](https://github.com/user-attachments/assets/7b523c33-bec6-482a-9f01-3e478e75902e) |
<!-- | ![lightsidebery](https://github.com/user-attachments/assets/dd26f273-438e-42be-b77a-5d0df96b70bf) | ![greennative](https://github.com/user-attachments/assets/a60e6432-c919-4766-8353-609f1296315d)              | -->



| menús                                                                                         | urlbar emergente                                                                           |
|-----------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|
| ![ctxmenu](https://github.com/user-attachments/assets/7da9bdff-d247-4680-ad20-70d12c886272) | ![urlbar](https://github.com/user-attachments/assets/8b328ecf-0297-4e8c-8cb6-8826040c7916) |

### barra lateral plegable
como se ve en la demostración

### barra de búsqueda compacta
![findbar](https://github.com/user-attachments/assets/198c5ec8-6e59-46fb-8624-0baa90506c86)

### mejoras en la calidad de vida
![longtab](https://github.com/user-attachments/assets/6ab029f9-1b67-4545-a898-bd680bd40000)

### botones compactos de control de ventana, al estilo macos
![winctr](https://github.com/user-attachments/assets/934849bd-19ba-4617-8bfe-f5b41508a872)

## características
 - barra lateral plegable
 - barra de url emergente (ver imagen animada de la demo)
 - funciona con temas personalizados  
 - esquinas redondeadas en navegador/barra lateral  
 - menús contextuales minimizados  
 - transiciones sutiles y no obstructivas  
 - barra de búsqueda minimizada  
 - configuración disponible para mover la barra lateral al lado derecho  
 - propiedades de configuración para personalización  
 - compatible con Firefox Nightly  
 - semi compatible con pestañas verticales nativas  
 - panel de estado flotante  

## instalación  
 - clona o descarga el código desde GitHub (botón verde "code") y descomprímelo  
 - descarga Sidebery desde los complementos de Mozilla si lo deseas  
 - abre la configuración de Sidebery, desplázate hasta el final (sección de ayuda)  
 - haz clic en "importar datos del complemento"  
 - selecciona "sidebery.json" del archivo descargado  
 - deja los interruptores en su valor predeterminado y haz clic en "importar"  
 - ve a about:config  
 - activa `toolkit.legacyUserProfileCustomizations.stylesheets` en true  
 - activa `svg.context-properties.content.enabled` en true  
 - activa `sidebar.revamp` en false  
 - abre about:profiles, encuentra tu perfil y abre la carpeta raíz  
 - crea una carpeta `chrome` si no existe  
 - mueve los archivos `userChrome.css`, `userContent.css` y la carpeta `assets` dentro del directorio `chrome`  
 - vuelve a abrir Firefox  
 - ¡listo! :3  
 - por favor, por favor, POR FAVOR visita esta página de GitHub de vez en cuando para descargar la última versión, consulta la sección "actualización" de este README  
 - consulta la sección "personalización" de este README para opciones de personalización  

## actualización  
 revisa esta página de GitHub de vez en cuando para ver si hay una nueva versión disponible. La versión de tu instalación es visible junto al botón de cierre del menú de configuración de la nueva pestaña (abajo a la derecha en la nueva pestaña).  
### cómo actualizar:  
 sigue las instrucciones de instalación, permite que tu explorador de archivos reemplace los archivos si se te solicita (recuerda actualizar los estilos de Sidebery)  

## personalización  
 en la parte superior de `userChrome.css`, hay variables CSS personalizables. Entre ellas están opciones de tamaño de pestañas, redondeo, espaciamiento entre ciertos elementos, etc. Debajo de estas variables también existen exclusiones del menú contextual al hacer clic derecho. Comenta y descomenta las opciones que quieras habilitar o deshabilitar.  

 también he implementado algunos valores booleanos personalizados de `about:config` para que los modifiques  
 - `shimmer.disable-collapsing-sidebar` – activa en true para deshabilitar la barra lateral colapsable (desafortunadamente esto también requiere comentar algunos estilos de Sidebery, están marcados en el editor de estilos dentro de la configuración de Sidebery)
 - `shimmer.remove-winctr-buttons` – activa verdadero para eliminar los botones de control de ventana  
 - `shimmer.remove-firefox-view-button` – activa verdadero para eliminar el botón de vista de Firefox  
 - `shimmer.disable-popover-transition` – activa verdadero para eliminar la transición del popover de la barra de URL  
 - `shimmer.disable-urlbar-background-transition` – activa verdadero para eliminar la sutil transición del fondo de la barra de URL que ocurre durante la animación del popover  
 - `shimmer.disable-popover-urlbar` – activa verdadero para eliminar el efecto popover en la barra de URL  
 - `shimmer.native-vertical-tabs` – activa verdadero si usas las pestañas verticales de Firefox en lugar de Sidebery. no actives si usas pestañas *horizontales*, desaparecerán  
 - `shimmer.show-sidebar-header` – activa verdadero para mostrar el encabezado de la barra lateral  
 - `shimmer.show-sidebar-header-close-button` - aunque actives el encabezado, el botón de cerrar se oculta automáticamente. activa esto en verdadero para que reaparezca  
 - `shimmer.sidebar-right-side` – activa verdadero si usas Sidebery en el lado derecho. primero debes mover la barra lateral en Firefox usando el encabezado de la barra lateral, que debe reactivarse en la configuración  
 - `shimmer.reverse-winctr-buttons-side` – activa verdadero para mover los botones de control de ventana al lado izquierdo  
 - `shimmer.taller-tabs` – activa verdadero para hacer que las pestañas sean tan altas como las pestañas predeterminadas de Firefox  
 - `shimmer.shorter-navbar` – activa verdadero para que la barra de navegación tenga la altura que tiene Firefox sin modificaciones (puede requerir reiniciar Firefox)  
 - `shimmer.disable-compact-winctr-buttons` – activa verdadero para revertir los botones compactos de control de ventana a los predeterminados  
 - `shimmer.dont-expand-selected-tab` – activa verdadero para desactivar el efecto de expandir la pestaña activa cuando hay muchas pestañas abiertas  
 - `shimmer.enable-theme-aware-wallpapers` – activa verdadero para ordenar a Firefox mostrar los fondos de pantalla seleccionados por el usuario. para cambiar los fondos, abre el directorio chrome, reemplaza los archivos *light* y *dark* en el directorio *walls* con tus imágenes deseadas, y ejecuta `makewalls.sh`. ten en cuenta que es un script bash. si un fondo no funciona, intenta hacerlo más pequeño, lamentablemente los archivos grandes fallan – un límite seguro es < 1MiB.  

## mantenimiento  
 por favor ten en cuenta que no siempre tendré tiempo para arreglar un problema causado por una nueva versión de Firefox en un día. si deseas crear un pull request, siéntete libre de hacerlo. si encuentras algún problema, repórtalo en la pestaña "issues" en GitHub.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---