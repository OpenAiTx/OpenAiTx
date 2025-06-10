# TypeScript 7

[¿No estás seguro de qué es esto? ¡Lee el anuncio!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Vista Previa

Una compilación de vista previa está disponible en npm como `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Úsalo como usarías tsc.
```

Una extensión de vista previa para VS Code está [disponible en el marketplace de VS Code](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Para usar esto, añade lo siguiente en la configuración de VS Code:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Cómo Construir y Ejecutar

Este repositorio usa [Go 1.24 o superior](https://go.dev/dl/), [Rust 1.85 o superior](https://www.rust-lang.org/tools/install), [Node.js con npm](https://nodejs.org/) y [`hereby`](https://www.npmjs.com/package/hereby).

Para pruebas y generación de código, este repositorio contiene un submódulo git al repositorio principal de TypeScript apuntando al commit que se está portando.
Al clonar, querrás clonar con submódulos:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Si ya has clonado el repositorio, puedes inicializar el submódulo con:

```sh
git submodule update --init --recursive
```

Con el submódulo en su lugar y `npm ci`, puedes ejecutar tareas mediante `hereby`, de forma similar al repositorio de TypeScript:

```sh
hereby build          # Verifica que el proyecto se construya
hereby test           # Ejecuta todas las pruebas
hereby install-tools  # Instala herramientas adicionales como linters
hereby lint           # Ejecuta todos los linters
hereby format         # Formatea todo el código
hereby generate       # Genera todo el código Go (por ejemplo, diagnósticos, comprometido en el repo)
```

Las tareas adicionales están en desarrollo.

`hereby` no es obligatorio para trabajar en el repositorio; las herramientas normales de `go` (por ejemplo, `go build`, `go test ./...`) funcionarán como se espera.
Las tareas de `hereby` se ofrecen como una comodidad para quienes están familiarizados con el repositorio de TypeScript.

### Ejecutando `tsgo`

Después de ejecutar `hereby build`, puedes ejecutar `built/local/tsgo`, que se comporta casi igual que `tsc`.

### Ejecutando el Prototipo LSP

Para depurar y ejecutar la extensión de VS Code sin instalarla globalmente:

* Ejecuta VS Code en el espacio de trabajo del repositorio (`code .`)
* Copia `.vscode/launch.template.json` a `.vscode/launch.json`
* <kbd>F5</kbd> (o `Debug: Start Debugging` desde la paleta de comandos)

Esto lanzará una nueva instancia de VS Code que usa Corsa LS como backend. Si está correctamente configurado, deberías ver "tsgo" en la barra de estado cuando un archivo TypeScript o JavaScript esté abierto:

![Captura de pantalla del Prototipo LSP](.github/ls-screenshot.png)


## ¿Qué Funciona Hasta Ahora?

Esto sigue siendo un trabajo en progreso y aún no tiene paridad total de características con TypeScript. Pueden existir errores. Por favor, revisa esta lista cuidadosamente antes de reportar un nuevo problema o asumir un cambio intencional.

| Característica | Estado | Notas |
|----------------|--------|-------|
| Creación de programa | hecho | Mismos archivos y resolución de módulos que TS5.8. No todos los modos de resolución soportados todavía. |
| Análisis/escaneo | hecho | Exactamente los mismos errores de sintaxis que TS5.8 |
| Línea de comandos y análisis de `tsconfig.json` | casi hecho | Punto de entrada ligeramente diferente por ahora |
| Resolución de tipos | hecho | Mismos tipos que TS5.8 |
| Comprobación de tipos | hecho | Mismos errores, ubicaciones y mensajes que TS5.8. La impresión de tipos en errores puede mostrarse diferente (en progreso) |
| Inferencia específica de JavaScript y JS Doc | no listo | - |
| JSX | hecho | - |
| Emisión de declaraciones | en progreso | La mayoría de las características comunes están implementadas, pero algunos casos límite y banderas de características aún no están manejados |
| Emisión (salida JS) | en progreso | `target: esnext` bien soportado, otros objetivos pueden tener carencias |
| Modo watch | prototipo | Observa archivos y reconstruye, pero sin re-chequeo incremental |
| Modo build / referencias de proyecto | no listo | - |
| Compilación incremental | no listo | - |
| Servicio de lenguaje (LSP) | prototipo | Funcionalidad mínima (errores, hover, ir a definición). Pronto más características |
| API | no listo | - |

Definiciones:

 * **hecho** aka "creído hecho": Actualmente no estamos al tanto de déficits o trabajo mayor pendiente. Se pueden reportar bugs
 * **en progreso**: actualmente en desarrollo; algunas funciones pueden funcionar y otras no. Se pueden reportar pánicos, pero nada más por favor
 * **prototipo**: solo prueba de concepto; no reportar bugs
 * **no listo**: aún no se ha empezado, o está lo suficientemente lejos de estar listo como para no molestarse con ello todavía

## Otras Notas

A largo plazo, esperamos que este repositorio y su contenido se fusionen en `microsoft/TypeScript`.
Como resultado, el repositorio y el rastreador de issues de typescript-go eventualmente se cerrarán, así que trata las discusiones/issues en consecuencia.

Para una lista de cambios intencionales respecto a TypeScript 5.7, consulta CHANGES.md.

## Contribuyendo

Este proyecto da la bienvenida a contribuciones y sugerencias.  La mayoría de las contribuciones requieren que aceptes un
Acuerdo de Licencia de Contribuyente (CLA) declarando que tienes el derecho y, de hecho, nos concedes
los derechos para usar tu contribución. Para más detalles, visita [Acuerdos de Licencia de Contribuyente](https://cla.opensource.microsoft.com).

Cuando envíes un pull request, un bot CLA determinará automáticamente si necesitas proporcionar
un CLA y decorará el PR apropiadamente (por ejemplo, verificación de estado, comentario). Simplemente sigue las instrucciones
proporcionadas por el bot. Solo tendrás que hacer esto una vez en todos los repos utilizando nuestro CLA.

Este proyecto ha adoptado el [Código de Conducta de Microsoft Open Source](https://opensource.microsoft.com/codeofconduct/).
Para más información, consulta las [Preguntas Frecuentes sobre el Código de Conducta](https://opensource.microsoft.com/codeofconduct/faq/) o
contacta a [opencode@microsoft.com](mailto:opencode@microsoft.com) para cualquier pregunta o comentario adicional.

## Marcas Registradas

Este proyecto puede contener marcas registradas o logotipos de proyectos, productos o servicios. El uso autorizado de las
marcas registradas o logotipos de Microsoft está sujeto y debe cumplir
[las Directrices de Marca y Marcas Registradas de Microsoft](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
El uso de marcas registradas o logotipos de Microsoft en versiones modificadas de este proyecto no debe causar confusión ni implicar patrocinio de Microsoft.
Cualquier uso de marcas registradas o logotipos de terceros está sujeto a las políticas de dichos terceros.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---