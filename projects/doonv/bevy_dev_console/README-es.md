# bevy_dev_console

`bevy_dev_console` es un complemento de consola para desarrolladores inspirado en Source para el [Bevy Game Engine](https://github.com/bevyengine/bevy).

![Imagen de la consola para desarrolladores](https://raw.githubusercontent.com/doonv/bevy_dev_console/master/doc/console.png)

> [!ADVERTENCIA]  
>
> `bevy_dev_console` está actualmente en sus primeras etapas de desarrollo. Espere cambios importantes en un futuro cercano (especialmente al usar el analizador de comandos incorporado). Por esta razón, solo está disponible como un paquete git por el momento.

## Características

- Visualización de registros
  - Vea todos los datos ocultos de cualquier mensaje de registro pasando el cursor sobre él.
- Lenguaje de análisis incorporado potente, construido específicamente para `bevy_dev_console`. ([Documentación](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser))
  - Cálculos
  - Variables
    - Utiliza una versión simplificada de propiedad y préstamo
  - Biblioteca estándar (No tiene mucho por el momento)
  - [Funciones nativas personalizadas](https://github.com/doonv/bevy_dev_console/blob/master/examples/custom_functions.rs) (¡Incluye acceso a `World`!)
  - [Muchos tipos](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser#types)
  - Visualización y modificación de recursos
    - Enums
    - Estructuras
  - ~~Consultas de entidades~~ [*Próximamente...*](https://github.com/doonv/bevy_dev_console/issues/3) (¡Se agradecerían sugerencias de sintaxis!)
  - ...¡y más!

## Uso

1. Agregue el paquete git `bevy_dev_console`.

    ```bash
    cargo add --git https://github.com/doonv/bevy_dev_console.git
    ```
2. Importa el `prelude`.


    ```rust
    use bevy_dev_console::prelude::*;
    ```
3. Agregue los complementos.


    ```rust,no_run
    use bevy::{prelude::*, log::LogPlugin};
    use bevy_dev_console::prelude::*;

    App::new()
        .add_plugins((
            // Add the log plugin with the custom log layer
            DefaultPlugins.set(LogPlugin {
                custom_layer: custom_log_layer,
                ..default()
            }),
            // Add the dev console plugin itself.
            DevConsolePlugin,
        ))
        .run();
    ```

4. ¡Eso debería ser todo! Ahora puedes presionar la tecla `` ` `` / `~` en tu teclado y debería abrirse la consola.

## Funciones Activables

**(por defecto)** `builtin-parser` incluye el analizador predeterminado. Desactivarlo te permite eliminar el analizador incorporado y reemplazarlo por el tuyo propio (o podrías no hacer nada y convertir la consola en un lector de registros).

## Compatibilidad con Bevy

| bevy   | bevy_dev_console |
| ------ | ---------------- |
| 0.14.* | git (master)     |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---