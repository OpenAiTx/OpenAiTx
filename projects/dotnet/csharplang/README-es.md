# Diseño del Lenguaje C#

[![Únete al chat en https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Chat en Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Bienvenido al repositorio oficial para el diseño del lenguaje C#. Aquí es donde se desarrollan, adoptan y especifican las nuevas características del lenguaje C#.

C# es diseñado por el Equipo de Diseño del Lenguaje C# (LDT) en estrecha coordinación con el proyecto [Roslyn](https://github.com/dotnet/roslyn), que implementa el lenguaje.

Puedes encontrar:

- Propuestas activas de características del lenguaje C# en la [carpeta de propuestas](proposals)
- Notas de las reuniones de diseño del lenguaje C# en la [carpeta de reuniones](meetings)
- Resumen del [historial de versiones del lenguaje aquí](Language-Version-History.md).

Si descubres errores o deficiencias en lo anterior, por favor deja un issue para señalarlos, o mejor aún: un pull request para corregirlos.

Sin embargo, para *nuevas propuestas de características*, por favor preséntalas para su [discusión](https://github.com/dotnet/csharplang/labels/Discussion), y *solo* envía una propuesta como un issue o pull request si un miembro del Equipo de Diseño del Lenguaje (un "champion") te invita a hacerlo.

El proceso de diseño completo se describe [aquí](Design-Process.md). Un resumen más corto se encuentra a continuación.

## Discusiones

El debate sobre las características del lenguaje tiene lugar en forma de [Discusiones](https://github.com/dotnet/csharplang/discussions) en este repositorio.

Si deseas sugerir una característica, discutir notas de diseño actuales o propuestas, etc., por favor [abre un nuevo tema de Discusión](https://github.com/dotnet/csharplang/discussions/new).

Las discusiones que son breves y se mantienen en el tema tienen muchas más probabilidades de ser leídas. Si dejas el comentario número cincuenta, es probable que solo unas pocas personas lo lean. Para que las discusiones sean más fáciles de navegar y aprovechar, por favor sigue algunas reglas básicas:

- La discusión debe ser relevante para el diseño del lenguaje C#. Si no lo es, será cerrada sumariamente.
- Elige un tema descriptivo que comunique claramente el alcance de la discusión.
- Mantente en el tema de la discusión. Si un comentario es tangencial, o entra en detalle sobre un subtema, inicia una nueva discusión y enlaza de regreso.
- ¿Tu comentario es útil para que otros lo lean, o puede expresarse adecuadamente con una reacción de emoji a un comentario existente?

Las propuestas de lenguaje que evitan que ocurra una sintaxis específica pueden lograrse con un [analizador de Roslyn](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Las propuestas que solo hacen que la sintaxis existente sea opcionalmente ilegal serán rechazadas por el comité de diseño del lenguaje para evitar aumentar la complejidad del lenguaje.

## Propuestas

Cuando un miembro del LDM de C# considera que una propuesta merece ser considerada por el equipo más amplio, puede [Patrocinarla](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22), lo que significa que la llevará a la Reunión de Diseño del Lenguaje C#. Las propuestas siempre se discuten en discusiones enlazadas, no en el issue del champion. No siempre seguimos esta política, por lo que muchos issues de champion tendrán discusión en ellos; ahora bloqueamos los issues para evitar que se produzcan nuevas discusiones en ellos. Cada issue de champion tendrá un enlace a la discusión correspondiente.

## Proceso de Diseño

Las [propuestas](proposals) evolucionan como resultado de decisiones en las [Reuniones de Diseño del Lenguaje](meetings), que se informan por [discusiones](https://github.com/dotnet/csharplang/discussions), experimentos y trabajo de diseño offline.

En muchos casos será necesario implementar y compartir un prototipo de una característica para llegar al diseño correcto y, en última instancia, decidir si se adopta la característica. Los prototipos ayudan a descubrir tanto problemas de implementación como de usabilidad de una característica. Un prototipo debe implementarse en un fork del [repositorio de Roslyn](https://github.com/dotnet/roslyn) y cumplir con los siguientes requisitos:

- El análisis sintáctico (si corresponde) debe ser resistente a la experimentación: la escritura no debe causar bloqueos.
- Incluir pruebas mínimas que demuestren la característica de extremo a extremo.
- Incluir soporte mínimo en el IDE (coloreado de palabras clave, formato, autocompletado).

Una vez aprobada, una característica debe implementarse completamente en [Roslyn](https://github.com/dotnet/roslyn), y estar completamente especificada en la [especificación del lenguaje](spec), tras lo cual la propuesta se mueve a la carpeta correspondiente para una característica completada, por ejemplo, [Propuestas de C# 7.1](proposals/csharp-7.1).

**AVISO LEGAL**: Una propuesta activa está bajo consideración activa para ser incluida en una versión futura del lenguaje de programación C#, pero no se garantiza de ninguna manera que finalmente se incluya en la siguiente o en cualquier versión del lenguaje. Una propuesta puede posponerse o rechazarse en cualquier momento durante cualquier fase del proceso anterior, según los comentarios del equipo de diseño, la comunidad, los revisores de código o las pruebas.

### Hitos

Tenemos diferentes hitos para los issues en el repositorio:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) es el conjunto de propuestas patrocinadas que se están trabajando activamente en este momento. No todo en este hito llegará a la próxima versión de C#, pero recibirá tiempo de diseño durante el próximo lanzamiento.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) es el conjunto de propuestas patrocinadas que han sido clasificadas, pero no se están trabajando activamente. Aunque se da la bienvenida a discusiones e ideas de la comunidad sobre estas propuestas, el costo del trabajo de diseño y la revisión de implementación en estas características es demasiado alto para considerar la implementación comunitaria hasta que estemos listos para ello.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) es el conjunto de propuestas patrocinadas que han sido clasificadas, pero no se están trabajando activamente y están abiertas a la implementación de la comunidad. Los issues aquí pueden estar en uno de 2 estados: necesita especificación aprobada y necesita implementación. Aquellos que necesitan una especificación aún deben presentarse durante el LDM para la aprobación de la especificación, pero estamos dispuestos a tomarnos el tiempo para hacerlo a la brevedad posible.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) es el conjunto de propuestas que el LDM ha rechazado para el lenguaje. Sin una fuerte necesidad o retroalimentación de la comunidad, estas propuestas no serán consideradas en el futuro.
* Los hitos numerados son el conjunto de características que se han implementado para esa versión particular del lenguaje. Para los hitos cerrados, este es el conjunto de cosas que se enviaron con esa versión. Para los hitos abiertos, las características pueden eliminarse potencialmente más adelante si descubrimos problemas de compatibilidad u otros a medida que se acerca el lanzamiento.

## Reuniones de Diseño del Lenguaje

Las Reuniones de Diseño del Lenguaje (LDMs) son realizadas por el LDT y ocasionalmente invitados especiales, y se documentan en las Notas de Reuniones de Diseño en la carpeta [meetings](meetings), organizadas en carpetas por año. La vida útil de una nota de reunión de diseño se describe en [meetings/README.md](meetings/README.md). En los LDMs se toman decisiones sobre futuras versiones de C#, incluyendo qué propuestas trabajar, cómo evolucionarlas y si adoptarlas y cuándo hacerlo.

## Especificación del Lenguaje

La especificación actual ECMA-334 se puede encontrar en formato markdown en el repositorio [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Implementación

La implementación de referencia del lenguaje C# se puede encontrar en el [repositorio de Roslyn](https://github.com/dotnet/roslyn). Este repositorio también rastrea el [estado de implementación de las características del lenguaje](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Hasta hace poco, allí también se rastreaban los artefactos de diseño del lenguaje. Por favor, ten paciencia mientras trasladamos las propuestas activas.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---