# ECS-IAUS-sytstem
Sistema de Utilidad de Ejes Infinitos para Unity
El sistema de utilidad funciona identificando las opciones disponibles para la IA y seleccionando la mejor opción al puntuar cada opción según las circunstancias. Esto ha demostrado ser un método notablemente eficaz por varias razones.

Fácil de Diseñar - La IA de utilidad a menudo puede diseñarse en lenguaje natural, lo que facilita que el programador de IA hable con los diseñadores de juegos. No es necesario hablar sobre conceptos arcanos como condiciones, estados, secuencias y decoradores. En su lugar, puedes explicar el comportamiento deseado de la IA en términos como “Si la IA está bajo fuego, prioriza encontrar cobertura”. Nota cómo se pueden usar términos difusos, como “prioriza”, que son naturales en la conversación humana.

Fácilmente Extensible - Las reglas, a menudo llamadas evaluadores, pueden añadirse fácilmente sobre la IA existente. A diferencia de, por ejemplo, las máquinas de estados finitos, no existen relaciones importantes que romper. En cambio, los evaluadores se añaden simplemente sobre los evaluadores existentes, lo que facilita extender la funcionalidad y fidelidad de la IA.

Mejor Calidad - La simplicidad del diseño y la facilidad con la que se puede extender la IA reducen enormemente los errores y mejoran drásticamente la productividad. Esto a su vez deja más espacio para desarrollar IA más compleja y con mejor comportamiento dentro del presupuesto y plazo dados, lo que en general mejora la calidad de la IA.

Este es mi intento de crear el Sistema de Utilidad de Ejes Infinitos de Dave Mark en Unity3d usando DOTS.

¿Qué es un Sistema de Utilidad de Ejes Infinitos?

En resumen, es un sistema que devuelve una Acción para realizar con el valor más alto. Básicamente es una lista de Acciones y cada Acción tiene una lista de “Ejes”. Dave Mark dio una charla sobre esto en GDC hace un par de años y ahí fue donde lo escuché. Creo que también mencionó un juego de Gato y puntero láser en la misma charla, que fue la idea inicial de Lol Cats I Can Has Lazer, aunque nuestro juego siguió su propia dirección de diseño.

Aquí hay un enlace a las charlas:

http://intrinsicalgorithm.com/IAonAI/2013/02/both-my-gdc-lectures-on-utility-theory-free-on-gdc-vault/

https://www.gdcvault.com/play/1018040/Architecture-Tricks-Managing-Behaviors-in empieza en el minuto 33

Este repositorio está principalmente destinado para aprender y documentar mi viaje con DOTS y la IA de Utilidad. Si buscas un asset que pueda usarse directamente en el estado actual, revisa el enlace a continuación.
https://gitlab.com/lclemens/lightweightdotsutilityai

Actualizado para soportar Unity 6 Beta
Añadiendo planificación GOAP para estados


Copyright 2019 - 2024 Dreamers Inc Studios Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---