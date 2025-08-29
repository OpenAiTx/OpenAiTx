![el mod que convertirá tu Minecraft en estrategia en tiempo real](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/main-banner.png)
# MineFortress
[![Apoya el proyecto](https://img.shields.io/badge/PATREON-SUPPORT_THE_PROJECT-f96854?style=for-the-badge&logo=patreon&logoColor=f96854&labelColor=052d49&color=f96854)](https://www.patreon.com/minefortress)
[![Únete a Discord](https://img.shields.io/discord/906943962659561515?style=for-the-badge&logo=discord&label=discord&color=5865F2)](https://discord.gg/6rt7VJxPcq)
[![Sitio web](https://img.shields.io/badge/website-minefortress-CC9966?style=for-the-badge)](https://minefortress.net/)

El mod que convierte tu Minecraft en RTS. Asume el rol de líder de una aldea, recolecta recursos, construye casas, contrata profesionales para hacer crecer y expandir tu aldea ¡y hasta conquistar a tus vecinos! Olvídate de la vista en primera persona y controla todo con el puntero del ratón como en los juegos RTS clásicos.
## Enlaces
* **[Sitio web](https://minecraftfortress.org/)**
* **[Patreon](https://www.patreon.com/minefortress)**
* **[Modrinth](https://modrinth.com/mod/minefortress)**
* **[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)**
## Para jugadores
Este repositorio está destinado a desarrolladores. Si quieres jugar el mod, por favor descárgalo desde [CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts) o [Modrinth](https://modrinth.com/mod/minefortress).

El mod requiere Fabric Loader y Fabric API para funcionar.
Sigue las instrucciones detalladas de instalación en nuestra [wiki](https://wiki.minecraftfortress.org/wiki/Installation:Curseforge_Launcher).

## Para desarrolladores
### Requisitos previos
Asumo que todos los que quieran contribuir al proyecto están familiarizados con el desarrollo en Java/Kotlin en general.
No entraré en detalles sobre la instalación del entorno básico de desarrollo, pero listaré todas las herramientas necesarias para trabajar con el proyecto:
* Java 17 - Prefiero usar compilaciones de [Adoptium](https://adoptium.net/)
* IntelliJ IDEA - Para la experiencia de desarrollo más cómoda y para obtener resultados que coincidan con los míos, recomiendo usar IntelliJ IDEA. Puedes descargarlo [aquí](https://www.jetbrains.com/idea/download/).
* Git - Para clonar el repositorio y para hacer commits de tus cambios. Puedes descargarlo [aquí](https://git-scm.com/downloads).

Si necesitas apoyo para configurar tu entorno de desarrollo, por favor lee los artículos ubicados aquí: [Desarrollo en Java con IntelliJ IDEA](https://www.jetbrains.com/help/idea/getting-started.html)

No dudes en pedir ayuda en nuestro [servidor de Discord](https://discord.gg/6rt7VJxPcq).
### Comenzando / Instalación
1. Clona el repositorio usando Git.
2. Asegúrate de que el proyecto esté clonado en un directorio llamado `minefortress`. Esto es necesario para que Gradle funcione correctamente con IDEA.
3. Abre el proyecto en IntelliJ IDEA.
4. Espera a que Gradle termine de importar el proyecto.
5. Todavía necesitamos hacer que las Configuraciones de Ejecución funcionen. El plugin de Fabric lo hará automáticamente, pero necesitamos cerrar el proyecto.
6. Cierra el proyecto y ábrelo de nuevo.
7. Deberían aparecer nuevas Configuraciones de Ejecución. Si no aparecen, intenta reiniciar IDEA.
8. La Configuración de Ejecución puede tener una pequeña cruz cerca. Esto significa que el plugin de Fabric usó el módulo incorrecto al configurar la configuración.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-1.png)
9. Para arreglarlo, edita la configuración y selecciona `minefortress.main` en el menú desplegable del classpath del módulo.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-2.png)
10. Ahora puedes ejecutar el proyecto usando la configuración `Minecraft Client`.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-3.png)

### Contribuir
¡Cualquier ayuda es muy apreciada! Si quieres contribuir al proyecto, por favor sigue estos pasos:
1. Haz un fork del repositorio.
2. Crea una nueva rama desde la rama `master`.
3. Realiza tus cambios.
4. Haz commit de tus cambios y súbelos a tu fork.
5. Crea un pull request hacia la rama `master` de este repositorio.

Aún no hay una guía de contribución, pero puedes revisar los [issues](https://github.com/remmintan/minefortress/issues) para encontrar algo en lo que trabajar.
Intentaré recopilar bugs y solicitudes de funciones en los issues, pero si tienes alguna pregunta, no dudes en hacerla en nuestro [servidor de Discord](https://discord.gg/6rt7VJxPcq).

También siéntete libre de crear issues si encuentras algún bug o tienes solicitudes de funciones.

Con el tiempo, intentaré crear una guía de contribución y una lista de issues que sean adecuados para principiantes.

## Licencia
Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.

## Donar
Apoya el desarrollo de código abierto donando al proyecto. Puedes donar usando los siguientes métodos:
* **[Patreon](https://www.patreon.com/minefortress)**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---