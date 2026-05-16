<table><tr width=64px><td><img height=64px src="https://user-images.githubusercontent.com/526829/169241046-3087a41d-9606-43ab-90ae-ee0055bef039.png"/></td><td><h1>godot-version-manager</h1></td></tr></table>
  
Descarga, instala y gestiona cualquier versión de Godot Engine desde una aplicación simple. 

<img alt="captura de pantalla con tema claro" src="https://github.com/user-attachments/assets/5b504fa3-59ea-46c8-bb78-6a743759d984" />
<img alt="captura de pantalla con tema oscuro" src="https://github.com/user-attachments/assets/08ff0100-fbd5-40be-a8a4-80bbb186d37e" />

## Instalación
### Windows:
Descomprime y haz doble clic. (En Windows XP asegúrate de que Powershell esté instalado)
### Linux:
Descomprime y haz doble clic. La extracción de versiones descargadas requiere `unzip` que, si no está instalado, debería estar disponible en el repositorio de tu distribución
### OSX:
- Debería extraerse automáticamente después de la descarga
- Necesitas ejecutar `sudo xattr -r -d com.apple.quarantine path/to/Godot Version Manager.app` ya que los binarios no firmados se marcan como no confiables de otra manera. Si no confías en los binarios precompilados, siéntete libre de compilar el proyecto tú mismo
- Haz doble clic en Godot Version Manager.app

## Características
- Descarga e instala automáticamente cualquier versión de Godot desde un menú desplegable. (requiere powershell para la extracción)
- Mostrar u ocultar versiones alfa, beta, rc y dev en el menú desplegable de descarga. 
- Añade tus propios binarios en cualquier lugar de tu sistema de archivos. 
- Iconos coloridos para distinguir fácilmente las compilaciones estables, rc, beta, alfa y master. 
- Clic derecho para eliminar cualquier entrada de la lista
- Arrastrar y soltar para reordenar las entradas
- Arrastrar y soltar un archivo project.godot o carpeta de proyecto Godot para añadir un proyecto y lanzarlo con una versión específica
- Feed de noticias desde godotengine.org./news

## Preguntas frecuentes
**P: ¿Dónde se guardan los binarios descargados?**

R: Se guardan en `user://versions` que varía según tu plataforma. En Windows está en %appdata%/Godot/app_userdata/Godot Version Manager/versions

**P: ¿En qué se diferencia esto de Hourglass o Godot Manager?**

R:
 - [Hourglass](https://hourglass.jwestman.net/) es un proyecto mucho más maduro y con más funciones que ofrece mejor soporte para la gestión de proyectos. Quizás la única ventaja que tiene GVM es que también descarga fragmentos de noticias del sitio oficial :)
 - [Godot Manager](https://github.com/eumario/godot-manager) parece ser también una alternativa bastante madura y con muchas funciones.
 - [Godots](https://github.com/MakovWait/godots) es una alternativa nueva (agosto 2023) que a mucha gente parece gustarle.
 - [GodotEnv](https://github.com/chickensoft-games/GodotEnv) y [godot-version-manager](https://github.com/gaheldev/godot-version-manager) son alternativas solo CLI.
 - [Godot Launcher](https://github.com/sebastianoboem/godot-launcher) es una alternativa basada en python con soporte para extensión y gestión de caché.
 - [gdvm](https://github.com/adalinesimonian/gdvm) es otro gestor de versiones basado en CLI construido con Rust.

## LICENCIA
Licenciado bajo MIT (ver LICENSE.md)
Copyright ©️2022 Lisandro Lorea y colaboradores

Fuente Lilita One ©️2011 Juan Montoreano
<a href="https://www.flaticon.com/free-icons/exe" title="exe icons">Iconos Exe creados por Freepik - Flaticon</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---