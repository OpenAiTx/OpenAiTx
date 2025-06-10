<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Haz que tu frontend brille</strong> ✨
</div>

<div align="center">
  ¡Un framework para construir aplicaciones web en Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Disponible en Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentación" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Sitio web
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Inicio rápido
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Referencia
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Construido con ❤︎ por
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> y
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    colaboradores
  </a>
</div>

---

## Tabla de contenidos

- [Características](#features)
- [Ejemplo](#example)
- [Filosofía](#philosophy)
- [Instalación](#installation)
- [¿Dónde seguir?](#where-next)
- [Soporte](#support)

## Características {#features}

- Una API **declarativa** y funcional para construir HTML. Sin plantillas, sin macros,
  solo Gleam.

- Una arquitectura inspirada en Erlang y Elm para **gestionar el estado**.

- **Efectos secundarios gestionados** para un código predecible y comprobable.

- Componentes universales. **Escribe una vez, ejecuta en cualquier lugar**. Elm se encuentra con Phoenix LiveView.

- Una **CLI todo incluido** que hace que la creación de esqueletos y la construcción de apps sea muy sencilla.

- **Renderizado del lado del servidor** para plantillas HTML estáticas.

## Ejemplo {#example}

¡Lustre viene con [más de 20 ejemplos](https://hexdocs.pm/lustre/reference/examples.html)!
Así es como se ve:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## Filosofía {#philosophy}

Lustre es un framework _opinado_ para construir aplicaciones web de tamaño pequeño a mediano. El desarrollo frontend moderno es difícil y complejo. Parte de esa complejidad es necesaria, pero mucha es accidental o proviene de tener demasiadas opciones. Lustre tiene la misma filosofía de diseño que Gleam: cuando sea posible,
debería haber solo una forma de hacer las cosas.

Eso significa incluir desde el principio un único sistema de gestión de estado, modelado
tras Elm y Erlang/OTP. Abre cualquier aplicación Lustre y deberías sentirte
como en casa.

También significa que fomentamos enfoques simples para construir vistas sobre opciones complejas. Lustre _sí_ tiene una forma de crear componentes encapsulados con estado (algo
que extrañamos mucho en Elm) pero no debería ser la opción por defecto. Prefiere funciones simples antes que componentes con estado.

Donde los componentes _son_ necesarios, aprovecha el hecho de que los componentes de Lustre pueden
ejecutarse _en cualquier lugar_. Lustre te da las herramientas para escribir componentes que pueden ejecutarse dentro de una aplicación Lustre existente, exportarlos como un Web Component independiente, o ejecutarlos en el servidor con un runtime mínimo para modificar el DOM. Lustre llama a estos **componentes universales** y están escritos pensando en los múltiples targets de Gleam.

## Instalación {#installation}

¡Lustre está publicado en [Hex](https://hex.pm/packages/lustre)! Puedes agregarlo a
tus proyectos Gleam desde la línea de comandos:

```sh
gleam add lustre
```

Lustre también tiene un paquete complementario que contiene herramientas de desarrollo que podrías querer instalar:

> **Nota**: el servidor de desarrollo lustre_dev_tools vigila tu sistema de archivos para
> detectar cambios en tu código gleam y puede recargar el navegador automáticamente. Para usuarios de Linux, esto requiere que [inotify-tools]() esté instalado.

```sh
gleam add --dev lustre_dev_tools
```

## ¿Dónde seguir? {#where-next}

Para ponerte al día con Lustre, consulta la [guía de inicio rápido](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Si prefieres ver código, el directorio [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
contiene varias pequeñas aplicaciones que demuestran diferentes
aspectos del framework.

También puedes leer la documentación y la referencia de la API en
[HexDocs](https://hexdocs.pm/lustre).

## Soporte {#support}

Lustre está construido principalmente por mí, [Hayleigh](https://github.com/hayleigh-dot-dev),
mientras trabajo en dos empleos. Si quieres apoyar mi trabajo, puedes [patrocinarme en GitHub](https://github.com/sponsors/hayleigh-dot-dev).

¡Las contribuciones también son muy bienvenidas! Si has encontrado un bug, o quieres
sugerir una funcionalidad, por favor abre un issue o un pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---