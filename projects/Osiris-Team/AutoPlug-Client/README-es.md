<div align="center">
   <img src="https://i.imgur.com/BMpvtWP.png">
</div>

 AutoPlug-Client es un programa Java ejecutable e independiente que tiene múltiples modos de ejecución: Server-Wrapper, CLI-Tool, Background-Service. Su propósito principal es automatizar la actualización de cualquier software relacionado con servidores y simplificar el mantenimiento de servidores en general. Aunque todos los tipos de servidores son compatibles (incluidos los servidores de juegos Steam), la mayoría de sus funciones están diseñadas específicamente para Minecraft, que es reconocido como el juego más vendido del mundo y cuenta con una comunidad de modding excepcionalmente extensa.
 
## Enlaces

- Descarga versiones estables/beta en el repositorio [AutoPlug-Releases](https://github.com/Osiris-Team/AutoPlug-Releases).
- Sigue el desarrollo en [AutoPlug-Client-Development](https://bit.ly/acprogress) y ve en qué estamos trabajando actualmente.
- Apoya el desarrollo mediante [donaciones](https://www.paypal.com/donate?hosted_button_id=JNXQCWF2TF9W4).
- ¿Problemas o preguntas? Consulta el [FAQ](/docs/FAQ.md) y/o únete a nuestro [Discord](https://discord.com/invite/GGNmtCC), para soporte en chat/voz en vivo.

## ¿Qué puede hacer?

- Actualización automatizada del propio programa, software del servidor, plugins, mods y JRE (Java Runtime Environment)
- Reinicios programados del servidor
- Creación automatizada y modularizada de copias de seguridad
- Ejecución rápida, asincrónica y multihilo de tareas
- Carpetas sincronizadas (compartidas)
- Panel web para iniciar, detener, reiniciar el servidor y ver resúmenes de los últimos resultados de actualización

Características Premium de [AutoPlug-Web](https://autoplug.one):

- [Consola en línea](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/online-console.gif)
- [Administrador de archivos en línea](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/file-manager.gif)
- Acceso para el personal
- Base de datos de detalles de plugins

## Estado
Estable y completo en funciones, por lo que el desarrollo es comunitario, lo que significa que el desarrollador principal no desarrollará nuevas funciones y dependerá de pull requests de otros, excepto para problemas de seguridad y errores críticos.

## Proyectos comunitarios

- Soporte Docker: https://github.com/lkkuma/AutoPlug-Client-Docker
- Soporte para panel Pterodactly: https://github.com/ImLunaUwU/PteroPlug

Desarrolladores: 


También puedes usar AutoPlug en tus proyectos agregándolo como una dependencia  
a través de [Maven/Gradle/Sbt/Leinigen](https://jitpack.io/#Osiris-Team/AutoPlug-Client/-SNAPSHOT). Algunas clases útiles serían  
AutoPlugConsole, por ejemplo, que te permite ejecutar comandos de AutoPlug de forma programática:  

```java
AutoPlugConsole.executeCommand(".check plugins");
AutoPlugConsole.executeCommand(".check server");
// etc...
```
## Contribuir ![Build test](https://github.com/Osiris-Team/AutoPlug-Client/workflows/build/badge.svg)

Gracias por considerar contribuir, ¡la comunidad 💙 eso! Solo ten en cuenta estas cosas:
- Crea un issue primero si quieres hacer grandes cambios, para que podamos discutirlo.
- Recuerda que los grandes cambios también requieren que escribas pruebas.
- Puedes elegir y trabajar en cualquier issue abierto. Avísanos que estás trabajando en él.
- Evita usar y escribir métodos/campos/clases estáticos para asegurar un uso mínimo de memoria.

Principiantes:

- [contribute-to-projects](https://www.jetbrains.com/help/idea/contribute-to-projects.html)
- [clone-a-project-from-github](https://blog.jetbrains.com/idea/2020/10/clone-a-project-from-github/)

Recompensas:

Algunos issues abiertos están marcados con una etiqueta/label como esta: `bounty: 15€` (ver la [lista](https://github.com/Osiris-Team/AutoPlug-Client/labels/bounty%3A%2015%E2%82%AC)), lo que significa que la primera persona
que cree un pull request para arreglar/cerrar ese issue recibirá la recompensa (15€). Ten en cuenta que tu código debe tener
al menos una prueba que demuestre que la solución/funcionalidad implementada funciona. También ten en cuenta que los pagos solo se hacen vía PayPal, así que asegúrate
de que la página pública de Github de tu perfil, con el que haces el commit del pull request, contenga tu dirección de correo electrónico de PayPal en algún lugar.
Al comprometerte con un issue con la etiqueta de recompensa aceptas estos términos.

Detalles:

- Escrito en [Java](https://java.com/), con [JDK 8](https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html), dentro de [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- Construido con [1JPM](https://github.com/Osiris-Team/1JPM), comando: `java ./src/main/java/JPM.java`
(si quieres ejecutarlo directamente también añade `andRun` al final).

## Bibliotecas

Ten en cuenta que esta lista puede estar desactualizada. Revisa el archivo [build.gradle](/build.gradle) para nuestras dependencias actuales.
- [AutoPlug-Core](https://github.com/Osiris-Team/AutoPlug-Core) contiene código frecuentemente usado en todos los proyectos AutoPlug
  en un solo jar.
- [Dream-Yaml](https://github.com/Osiris-Team/Dream-Yaml) se usa para manejar archivos YAML.
- [Better-Thread](https://github.com/Osiris-Team/Better-Thread) permite mostrar 'tareas en vivo'.
- Para el coloreado de consola y visualización de tareas se usan [Jansi](https://github.com/fusesource/jansi) y [Jline](https://github.com/jline/jline3).
- [Zip4j](https://github.com/srikanth-lingala/zip4j) para descomprimir y manejar jar/zip.
- Los reinicios de servidor se programan con [Quartz](http://www.quartz-scheduler.org/).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---