<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" height=170 srcset="docs/images/icon-dark.svg">
    <source media="(prefers-color-scheme: light)" height=170 srcset="docs/images/icon-light.svg">
    <img alt="venator logo" height=170 src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/icon-light.svg">
  </picture>
</p>

Venator es una aplicación para registrar, visualizar y filtrar logs y spans
de programas instrumentados con la crate tracing de Rust o usando OpenTelemetry.
Está diseñada específicamente para un desarrollo local rápido.

<picture>
  <img alt="demo" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-demo.gif">
</picture>

## Instalación

### Con Binarios Precompilados:

Los binarios están precompilados y disponibles en la [página de lanzamientos](https://github.com/kmdreko/venator/releases) para:
- Windows (x64)
- MacOS (Intel, Apple silicon)

### Con Cargo:

Compilación e instalación de `venator` desde el código fuente con Cargo (requiere Rust 1.76 o
más reciente):

```
cargo install venator-app
```

## Uso

### Uso de OpenTelemetry:

Configure el SDK de OpenTelemetry de su programa para exportar registros y trazas a
`127.0.0.1:8362` (el puerto de escucha predeterminado de Venator) y usar `grpc` o
`http/protobuf`.

### Uso de Rust Tracing:

En su programa instrumentado:

```toml
[dependencies]
venator = "1.1.0"
```

```rust
use venator::Venator;

Venator::default().install();
```

Consulte la [documentación](https://docs.rs/venator/latest/venator/) para más información.

## Características

Los eventos se pueden ver acotados por intervalo de tiempo y filtrados por atributos, nivel y
otras propiedades. La tabla de registros puede incluir columnas de propiedades personalizadas.
El gráfico muestra los conteos por nivel en cada barra.

<picture>
  <img alt="capturas de pantalla de la pantalla de eventos" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-events.png">
</picture>

Los intervalos también se pueden acotar por intervalo de tiempo y filtro. Un panel de detalles puede mostrar
todas las propiedades de eventos e intervalos seleccionados. El gráfico muestra intervalos en capas
jerárquicamente.

<picture>
  <img alt="capturas de pantalla de la pantalla de intervalos" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-spans.png">
</picture>

Se pueden ver trazas que muestran tanto eventos como intervalos dentro de una sola ejecución.

<picture>
  <img alt="capturas de pantalla de la pantalla de trazas" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-traces.png">
</picture>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---