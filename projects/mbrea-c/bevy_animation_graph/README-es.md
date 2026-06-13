_Crate de biblioteca:_  
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)  
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)  

_Crate de editor:_  
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)  
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)  

[![CI](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml/badge.svg)](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml)  

# Bevy Animation Graph  

> **_AVISO:_** Si actualmente usas la versión `0.8.0` o inferior, ten en cuenta que  
> `0.9.0` ha introducido varios cambios incompatibles. Consulta la  
> [guía de migración](https://mbrea-c.github.io/bevy_animation_graph/migration_guides/0.8_to_0.9.html)  
> para actualizar.  

## Motivación  

Los gráficos de animación son una herramienta esencial para gestionar la complejidad presente en  
las tuberías de animación para juegos 3D modernos. Cuando tu juego tiene decenas de  
animaciones con mezclas y transiciones complejas, o quieres generar tus  
animaciones de forma procedural a partir de muy pocos fotogramas clave, la simple reproducción de clips de animación  
no es suficiente.  

Este crate funciona como una alternativa a la mayoría de `bevy_animation`, y tiene como objetivo  
proporcionar un sistema completo de animación y flujo de trabajo de desarrollo que incluye gráficos de animación,  
máquinas de estados de animación (es decir, controladores de animación) y un editor gráfico  
para crear tus gráficos de animación y máquinas de estados.  

_NOTA: Este proyecto es independiente de los gráficos de animación introducidos en  
`bevy_animation` en la versión 0.14._  

![captura de pantalla de uso ejemplo](https://raw.githubusercontent.com/mbrea-c/bevy_animation_graph/master/locomotion_graph.png)  

## Características actuales  

- Los gráficos de animación son activos. Pueden ser cargados desde archivos de activos, o creados  
  en código con una API ergonómica.  
- Editor visual de gráficos.
- Máquinas de estado de animación:  
  - Las máquinas de estado de animación están integradas como nodos en los gráficos de animación.  
  - Cada estado en una máquina de estados reproduce su propio gráfico de animación bajo demanda.  
  - Las transiciones también tienen su propio gráfico de animación, y pueden consultar los gráficos de animación de los estados fuente  
    y destino.  
- Soporte para ragdoll:  
  - Edición visual de ragdoll en el editor.  
  - Soporte para _ragdolls parciales_, donde algunos huesos son simulados y otros  
    están dirigidos cinemáticamente por una pose de animación objetivo.  
- Soporte para nodos personalizados escritos en Rust.  
  - Los usuarios pueden crear su propio binario del editor añadiendo el plugin del editor y  
    registrando sus nodos personalizados adicionales en el registro de tipos de Bevy. El  
    editor detectará automáticamente todos los nodos registrados.  
- Nodos integrados disponibles incluyen:  
  - Encadenamiento de animaciones (es decir, reproducir un nodo después de otro).  
  - Cinemática inversa de dos huesos.  
  - Bucle.  
  - Mezcla lineal (en espacio óseo).  
  - Nodo de espacio de mezcla 2D.  
  - Espejado de animación respecto al plano YZ.  
  - Reproducción de clip de animación.  
  - Aplicar una rotación dada a algunos huesos en una pose usando una máscara ósea.  
  - Acelerar o ralentizar la reproducción de la animación.  
  - Nodo de gráfico de animación.  
  - Nodo de máquina de estado de animación.  
  - Nodos aritméticos: una variedad de operaciones comunes sobre f32, Vec3, Quat, etc.  
- Anidamiento de gráficos de animación como nodos dentro de otros gráficos.  
- Sincronización de animación usando pistas de eventos.  
- La salida de los nodos del gráfico se almacena en caché para evitar cálculos innecesarios.  

## Características Planeadas  

1. Modos de "seguimiento de pose" para ragdoll, donde los huesos simulados del ragdoll intentan  
   coincidir con una pose objetivo usando fuerzas físicas:  
   - Modo de coincidencia _absoluta_, donde la posición/rotación en espacio mundial del  
     hueso objetivo se rastrea y se usa como ancla para una fuerza de resorte sobre el  
     hueso ragdoll.  
   - Modo de coincidencia _relativa_, donde el hueso ragdoll intenta igualar la  
     posición/rotación del objetivo relativa a su hueso padre. Puede que necesitemos soporte para motores de articulaciones en Avian para implementar este modo correctamente.


## Instalación

### Biblioteca

[bevy_animation_graph](https://crates.io/crates/bevy_animation_graph) es la
parte de biblioteca de este proyecto. Esto debe añadirse como dependencia a su
proyecto para usar gráficos de animación. Para instalar la última versión publicada
desde crates.io ejecute

```bash
cargo add bevy_animation_graph
```

o agregue manualmente la última versión a su `Cargo.toml`.

Para instalar la última versión del repositorio git maestro, agregue lo siguiente a `Cargo.toml`:

```toml
# ...
[dependencies]
# ...
bevy_animation_graph = { git = "https://github.com/mbrea-c/bevy_animation_graph.git" }
# ...
```

### Editor

[bevy_animation_graph_editor](https://crates.io/crates/bevy_animation_graph_editor)
es el editor. Puedes instalarlo como instalarías cualquier otro binario de Rust:

```bash
# for the latest crates.io version
cargo install bevy_animation_graph_editor
# for the latest master
cargo install --git https://github.com/mbrea-c/bevy_animation_graph bevy_animation_graph_editor
# for the version from a local workspace
cargo install --path <PATH_TO_WORKSPACE> bevy_animation_graph_editor

# use the --force flag to force reinstall
```
Alternativamente, recomiendo echar un vistazo al  
[editor como ejemplo de plugin](https://github.com/mbrea-c/bevy_animation_graph/blob/master/examples/editor_as_a_plugin/examples/editor_as_a_plugin.rs)  
para configurar tu propio binario de editor en tu crate/espacio de trabajo, consumiendo la  
misma versión de la biblioteca que tu juego. Esto te permitirá registrar nodos personalizados de  
gráficos de animación, que son una característica poderosa de este crate.  

## Comenzando  

Consulta los tutoriales en el  
[libro en progreso](https://sarahihme.github.io/initial_book_bevy_animation_graph/)  
(muchas gracias a @SarahIhme por iniciar esto!).  

Adicionalmente, ejemplos actualizados están incluidos en el  
[directorio de ejemplos](https://github.com/mbrea-c/bevy_animation_graph/tree/master/examples).  

Los siguientes recursos también pueden ser útiles, pero están algo desactualizados:  

- La documentación en [docs.rs](https://docs.rs/bevy_animation_graph) contiene  
  una introducción de la biblioteca y editor y una explicación de un ejemplo simple  
  de gráfico de animación. Ver también el video abajo para una demostración del  
  uso del editor.  
- Hay un  
  [video de uso desactualizado](https://www.youtube.com/watch?v=q-JBSQJIcX0).  

## Contribuir o solicitar ayuda  

Si encuentras un error o quieres discutir posibles nuevas características, siéntete libre de  
publicar un issue, abrir un PR o contactarme en Discord (@mbreac en el Discord de Bevy, hay una publicación de ayuda para `bevy_animation_graph` allí:  
[enlace](https://discord.com/channels/691052431525675048/1202998277482479616)).  

## Preguntas frecuentes  

### ¿Está listo para producción?  

Depende.  

Ya puede ser útil para proyectos pequeños, pero no puedo garantizar la API



estabilidad entre diferentes versiones `0.x` (es una biblioteca grande, es
relativamente joven y no tengo experiencia previa con la programación de animación,
así que todavía estoy descubriendo las mejores formas de hacer las cosas). Esto
significa que probablemente será necesario entrar en tus activos de gráficos de animación
y migrarlos manualmente entre versiones, al menos hasta que encuentre una mejor forma
de manejar las migraciones.

Además, habrá errores y otros problemas. Trato de corregirlos
a medida que surgen.

### ¿Implementarás la característica X?

Si es una característica pequeña (por ejemplo, algún nodo adicional de aritmética de vectores o punto flotante) probablemente simplemente no he tenido tiempo de implementarla. Si abres
un issue, probablemente la implementaré rápidamente. También se aceptan PRs.

Para características más grandes, es mejor empezar abriendo un issue para discusión o
mencionándome en el discord de Bevy.

## Tabla de versiones

| `bevy` | `bevy_animation_graph` | 
| ------ | ---------------------- | 
| 0.18 | master | 
| 0.18 | 0.10 | 
| 0.17 | 0.9 | 
| 0.17 | 0.8 | 
| 0.16 | 0.7 | 
| 0.15 | 0.6 | 
| 0.14 | 0.5 | 
| 0.13 | 0.4 | 
| 0.13 | 0.3 | 
| 0.12 | 0.2 |

## Agradecimientos

Muchas gracias a [Bobby Anguelov](https://www.youtube.com/@BobbyAnguelov) por sus
conferencias sobre programación de animación.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---