# ECSCombat

Una simulación de batalla de ciencia ficción, utilizando el framework ECS de Unity.

[![Una imagen de vista previa](https://img.youtube.com/vi/S2RJfbJly_A/0.jpg)](https://www.youtube.com/watch?v=S2RJfbJly_A)

Un video de una batalla infinita se puede ver [aquí](https://www.youtube.com/watch?v=S2RJfbJly_A).

## Sugerencias sobre qué revisar:

* Diferentes comportamientos de IA se encuentran en `Battle/AI`.
* Los sistemas de combate están en `Battle/Combat`. Esto incluye diferentes tipos de arma (proyectil/instantáneo), efectividad del arma basada en el alcance, interceptación de ataques con escudos.
* El equipo y armamento están en `Battle/Equipment`. Las naves pueden tener diferentes equipos adjuntos, y estos pueden tener efectos como cambiar la velocidad o la tasa de giro de las naves. El equipo puede ser dañado y deshabilitado cuando una nave es atacada, por ejemplo, motores dañados resultan en naves paralizadas.

## Detalles técnicos:

* Unity 2020.1.0b7
* Universal Render Pipeline (shaders de naves en shader graph)

## ¡Una palabra de precaución!

Este proyecto fue iniciado originalmente como una forma para que yo practicara programación en el estilo ECS (Entity-Component-System), cuando el paquete Unity Entities aún era muy joven.
Desde entonces, ha habido cambios sustanciales tanto en la API de Unity Entities como en lo que se considera la mejor práctica.
He hecho un esfuerzo para mantener todo actualizado cuando puedo, pero dado mi tiempo libre limitado, inevitablemente habrá algunos lugares que necesiten trabajo.
Así que, por supuesto, tómalo como inspiración, pero ten en cuenta que puede haber una mejor manera de hacer algunas cosas.

## Agradecimientos finales

Algunos de los sprites los hice yo, pero los que se ven bien fueron tomados de [aquí](https://opengameart.org/content/spaceships-1) donde están acreditados a [Wuhu](https://opengameart.org/users/wuhu).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---