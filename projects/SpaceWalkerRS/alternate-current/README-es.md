# Corriente Alterna

Corriente Alterna es una implementación eficiente y no localizada del polvo de redstone. Su enfoque principal radica en reducir el retraso causado por el polvo de redstone, optimizando los cálculos de potencia y reduciendo el número de actualizaciones de forma y bloque emitidas. Como efecto secundario de estos cambios, el orden de actualización de bloques en las redes de polvo de redstone es predecible e intuitivo en lugar de localizado y caótico.

## Rendimiento

Las contribuciones de MSPT del polvo de redstone son hasta 20 veces menores con Corriente Alterna, manteniendo al mismo tiempo un alto nivel de paridad con Vanilla. Su bajo número de modificaciones de código lo hace mínimamente invasivo, por lo que es un reemplazo fácil y directo para el polvo de redstone Vanilla.

## ¿Cómo funciona?

El algoritmo que usa Corriente Alterna fue diseñado con los siguientes objetivos en mente:
1. Minimizar el número de veces que un cable revisa sus alrededores para determinar su nivel de potencia.
2. Minimizar el número de actualizaciones de bloque y forma emitidas.
3. Emitir actualizaciones de bloque y forma en un orden determinista, no localizado, solucionando el error MC-11193.

En Vanilla, el cable de redstone es lento porque falla en los puntos 1 y 2.

El cable de redstone se actualiza recursivamente y cada cable calcula su nivel de potencia en aislamiento en lugar de en el contexto de la red de la que forma parte. Esto significa que un cable en una cuadrícula puede cambiar su nivel de potencia más de media docena de veces antes de establecer su valor final. Este problema solía ser peor en la versión 1.13 y anteriores, donde un cable solo disminuía su nivel de potencia en 1 a la vez.

Además de esto, un cable emite 42 actualizaciones de bloque y hasta 22 actualizaciones de forma cada vez que cambia su nivel de potencia.

De esas 42 actualizaciones de bloque, 6 son para sí mismo, lo que no solo es redundante, sino una gran fuente de retraso, ya que estas causan que el cable recalcule innecesariamente su nivel de potencia. Un bloque solo tiene 24 vecinos dentro de una distancia Manhattan de 2, lo que significa que 12 de las 36 actualizaciones de bloque restantes son duplicadas y por tanto también redundantes.

De las 22 actualizaciones de forma, solo 6 son estrictamente necesarias. Las otras 16 se envían a bloques diagonalmente arriba y abajo. Estas son necesarias si un cable cambia sus conexiones, pero no cuando cambia su nivel de potencia.

El cable de redstone en Vanilla también falla en el punto 3, aunque esto es más un problema de calidad de vida que de retraso. La naturaleza recursiva en la que se actualiza, combinada con el orden dependiente de la ubicación en la que cada cable actualiza a sus vecinos, hace que el orden en que se actualizan los vecinos de una red de cables sea increíblemente inconsistente y aparentemente aleatorio.

Corriente Alterna soluciona cada uno de estos problemas de la siguiente manera.

(1)
Para asegurar que un cable calcule su nivel de potencia la menor cantidad de veces posible, eliminamos la naturaleza recursiva con la que se actualiza el cable de redstone en Vanilla. En su lugar, construimos una red de cables conectados, encontramos aquellos cables que reciben potencia de redstone desde "fuera" de la red, y propagamos la potencia desde allí. Esto tiene algunas ventajas:

- Cada cable verifica la potencia de componentes no cables como máximo una vez, y de cables cercanos solo dos veces.
- Cada cable solo establece su nivel de potencia en el mundo una vez. Esto es importante porque las llamadas a Level.setBlock son incluso más costosas que las llamadas a Level.getBlockState.

(2)
Hay 2 formas obvias en las que podemos reducir el número de actualizaciones de bloque y forma.

- Eliminar las 18 actualizaciones de bloque redundantes y las 16 actualizaciones de forma redundantes, de modo que cada cable solo emita 24 actualizaciones de bloque y 6 de forma cada vez que cambia su nivel de potencia.
- Solo emitir actualizaciones de bloque y forma una vez que un cable alcanza su nivel final de potencia, en lugar de en cada etapa intermedia.

Para un solo cable, estas dos optimizaciones son lo mejor que se puede hacer, ¡pero para una red completa, se puede hacer mejor!

Dado que calculamos la potencia de toda la red, enviar actualizaciones de bloques y formas a los cables dentro de ella es redundante. Eliminar esas actualizaciones puede reducir el número de actualizaciones de bloques y formas hasta en un 20%.

(3)
Para hacer que el orden de las actualizaciones de bloques a los vecinos de una red sea determinista, lo primero que debemos hacer es reemplazar el orden dependiente de la ubicación en que un cable actualiza a sus vecinos. En su lugar, lo basamos en la dirección del flujo de energía. Esta parte del algoritmo fue fuertemente inspirada por 'RedstoneWireTurbo' de theosib, del cual puedes leer más en el comentario de theosib en Mojira [aquí](https://bugs.mojang.com/browse/MC-81098?focusedCommentId=420777&page=com.atlassian.jira.plugin.system.issuetabpanels%3Acomment-tabpanel#comment-420777) o revisando su implementación en el mod carpet [aquí](https://github.com/gnembon/fabric-carpet/blob/master/src/main/java/carpet/helpers/RedstoneWireTurbo.java).

La idea es determinar la dirección del flujo de energía a través de un cable basándose en la potencia que recibe de cables vecinos. Por ejemplo, si la única potencia que un cable recibe es de un cable vecino al oeste, se puede decir que la dirección del flujo de energía a través del cable es hacia el este.

Hacemos que el orden de las actualizaciones de bloques a los vecinos de un cable dependa de lo que se determina como la dirección del flujo de energía. Esto no solo elimina completamente la localización, sino que también elimina la direccionalidad en un gran número de casos. Sin embargo, a diferencia de 'RedstoneWireTurbo', he decidido mantener un elemento direccional en casos ambiguos, en lugar de introducir aleatoriedad, aunque esto es trivial de cambiar.

Mientras este cambio corrige el orden de actualización de bloques de cables individuales, todavía debemos abordar el orden general de actualización de bloques de una red. Esto resulta ser una solución sencilla, debido a un cambio que hicimos anteriormente: buscamos en la red cables que reciben energía desde fuera, y propagamos la energía desde allí. Si hacemos que cada cable transmita su energía a cables vecinos en un orden dependiente de la dirección del flujo de energía, terminamos con un orden de actualización de cables no localizado y en gran medida no direccional.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-27

---