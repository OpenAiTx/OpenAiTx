# ![jsii](https://raw.githubusercontent.com/aws/jsii-rosetta/main/logo/png/128.png)

[![Únete al chat en https://cdk.Dev](https://img.shields.io/static/v1?label=Slack&message=cdk.dev&color=brightgreen&logo=slack)](https://cdk.dev)
[![Todos los colaboradores](https://img.shields.io/github/all-contributors/aws/jsii-rosetta/main?label=%E2%9C%A8%20All%20Contributors)](#contributors-)
[![Estado de la compilación](https://github.com/aws/jsii-rosetta/workflows/build/badge.svg)](https://github.com/aws/jsii-rosetta/actions?query=workflow%3Abuild+branch%3Amain)
[![npm](https://img.shields.io/npm/v/jsii-rosetta?logo=npm)](https://www.npmjs.com/package/jsii-rosetta)

## Visión general

`jsii-rosetta` traduce ejemplos de código contenidos en bibliotecas jsii de TypeScript a los lenguajes objetivo *jsii* soportados.  
¡Esto es lo que permite que el [AWS Cloud Development Kit][cdk] entregue documentación poliglota desde una única base de código!

`jsii-rosetta` aprovecha el conocimiento sobre las convenciones de traducción de lenguaje jsii para producir traducciones. Solo  
soporta un conjunto limitado de características del lenguaje TypeScript (que pueden representarse de manera fiable en otros lenguajes).

[cdk]: https://github.com/aws/aws-cdk

## :question: Documentación

¡Visita nuestro [sitio web de documentación](https://aws.github.io/jsii)!

La cadena de herramientas jsii se extiende en múltiples repositorios:

- [aws/jsii-compiler](https://github.com/aws/jsii-compiler) es donde se mantiene el compilador `jsii` (excepto las versiones  
  de la línea `1.x`)
- [aws/jsii-rosetta](https://github.com/aws/jsii-rosetta) es donde se mantiene la herramienta de transliteración de ejemplos `jsii-rosetta`  
  (excepto las versiones de la línea `1.x`)
- [aws/jsii](https://github.com/aws/jsii) es donde se mantiene el resto de la cadena de herramientas, incluyendo:
  - `@jsii/spec`, el paquete que define la especificación del *ensamblado `.jsii`*
  - `jsii-config`, una herramienta interactiva para ayudar a configurar tu paquete jsii
  - `jsii-pacmak`, el generador de enlaces para paquetes jsii
  - `jsii-reflect`, una forma de nivel superior para procesar ensamblados *`.jsii`*
  - Las bibliotecas de tiempo de ejecución jsii para los lenguajes objetivo jsii soportados
  - Las líneas de lanzamiento `1.x` de `jsii` y `jsii-rosetta`

## :gear: Mantenimiento y soporte

La *política de Mantenimiento y Soporte* aplicable puede revisarse en [SUPPORT.md](https://raw.githubusercontent.com/aws/jsii-rosetta/main/SUPPORT.md).

El estado actual de las versiones de `jsii-rosetta` es:

| Versión  | Estado      | Fin de soporte | Comentario                                                                                              |
| -------- | ----------- | -------------- | ----------------------------------------------------------------------------------------------------- |
| `5.8.x`  | Actual      | Por determinar | ![npm](https://img.shields.io/npm/v/jsii-rosetta/v5.8-latest?label=jsii-rosetta%40v5.8-latest&logo=npm) |
| `5.7.x`  | Mantenimiento | 15-09-2025   | ![npm](https://img.shields.io/npm/v/jsii-rosetta/v5.7-latest?label=jsii-rosetta%40v5.7-latest&logo=npm) |
| `5.6.x`  | Mantenimiento | 01-07-2025   | ![npm](https://img.shields.io/npm/v/jsii-rosetta/v5.6-latest?label=jsii-rosetta%40v5.6-latest&logo=npm) |
| `5.5.x`  | Mantenimiento | 15-05-2025   | ![npm](https://img.shields.io/npm/v/jsii-rosetta/v5.5-latest?label=jsii-rosetta%40v5.5-latest&logo=npm) |

## :gear: Contribuir

Consulta [CONTRIBUTING](https://raw.githubusercontent.com/aws/jsii-rosetta/main/CONTRIBUTING.md).

## :school_satchel: Primeros pasos

## Rosetta para autores de ejemplos

Esta sección describe qué tener en cuenta al escribir ejemplos que serán convertidos  
por Rosetta.

### Hacer que los ejemplos compilen

El traductor puede traducir tanto código que compila y pasa verificación de tipos completamente, como código que no lo hace.

En caso de ejemplos que no compilan, las traducciones se basarán solo en el análisis gramatical. Esto tiene la desventaja  
de que no disponemos de la información de tipos exacta en todas las instancias. Específicamente,  
no se podrán inferir tipos struct a partir de literales de objetos. Observa el siguiente fragmento de código:

```ts
someObject.someMethod('foo', {
  bar: 3,
});
```

En lenguajes que no son TypeScript, es importante conocer el tipo del segundo  
argumento del método aquí. Sin embargo, sin acceso a la definición de  
`someMethod()`, es imposible para Rosetta conocer el tipo, y por ende  
no puede traducir el ejemplo. Por lo tanto, es importante incluir las  
importaciones necesarias, declaraciones de variables, etc., para darle a Rosetta  
suficiente información para entender qué está pasando en este código, y el ejemplo debería leerse así:

```ts
import * as myLib from 'some-library';

declare const someObject: myLib.SomeClass;

someObject.someMethod('foo', {
  bar: 3,
});
```

### Forzar ejemplos correctos

Por defecto, Rosetta aceptará ejemplos que no compilen. Si configuras  
`jsiiRosetta.strict` a `true` en tu `package.json`,  
el comando Rosetta fallará si algún ejemplo contiene un error:

```js
/// package.json
{
  "jsiiRosetta": {
    "strict": true
  }
}
```

### Fixtures

Para evitar repetir configuraciones comunes cada vez, los ejemplos de código pueden usar  
"fixtures": una plantilla fuente donde se inserta el ejemplo. Un fixture debe  
contener el texto `/// here` y típicamente luce así:

```ts
const * as module from '@some/dependency';

class MyClass {
  constructor() {
    const obj = new MyObject();

    /// here
  }
}
```

El ejemplo será insertado en la ubicación marcada como `/// here` y tendrá  
acceso a `module`, `obj` y `this`. Cualquier declaración `import` encontrada en el  
ejemplo será automáticamente promovida al principio del fixture, donde  
se garantiza que sea sintácticamente válida.

El archivo predeterminado cargado como fixture se llama `rosetta/default.ts-fixture` en  
el directorio del paquete (si existe).

Los ejemplos pueden solicitar un fixture alternativo especificando un parámetro `fixture`  
como parte del bloque de código:

````text
```ts fixture=some-fixture
````

O pueden optar por no usar un fixture especificando `nofixture`:

````text
```ts nofixture
````

Para especificar fixtures en un bloque `@example`, usa una etiqueta acompañante `@exampleMetadata`:

````text
/**
 * Mi clase genial
 *
 * @exampleMetadata fixture=with-setup
 * @example
 *
 * new MyCoolClass();
 */
````

### Dependencias

Al compilar ejemplos, Rosetta se asegurará de que tu paquete y todas sus  
`dependencies` y `peerDependencies` estén disponibles en el cierre de dependencias  
donde se compilarán tus ejemplos.

Si hay paquetes que quieres usar en un ejemplo que *no* deberían ser parte  
de las dependencias de tu paquete, decláralos en `jsiiRosetta.exampleDependencies`  
en tu `package.json`:

```js
/// package.json
{
  "jsiiRosetta": {
    "exampleDependencies": {
      "@some-other/package": "^1.2.3",
      "@yet-another/package": "*",
    }
  }
}
```

También puedes configurar un directorio con las dependencias correctas tú mismo, y pasar  
`--directory` al ejecutar `jsii-rosetta extract`. Sin embargo, recomendamos usar el  
mecanismo automático de construcción de cierre y especificar `exampleDependencies`.

## Rosetta para publicadores de paquetes

Esta sección describe cómo Rosetta se integra en tu proceso de compilación.

### Extract

Rosetta tiene varios subcomandos. El más importante es `jsii-rosetta extract`.

El comando `jsii-rosetta extract` tomará uno o más ensamblados jsii,  
extraerá los fragmentos de ellos, intentará compilarlos con respecto a un directorio raíz dado, y finalmente almacenará todas las traducciones en algo llamado  
"tablet".

Algunas cosas a tener en cuenta aquí:

- Los fragmentos siempre se leen del ensamblado jsii. Eso significa que si haces  
  cambios en los ejemplos en archivos fuente, primero debes volver a ejecutar `jsii` para
  regenere el ensamblado, antes de volver a ejecutar `jsii-rosetta extract`.
- El directorio de compilación se usará para resolver los `import`s. Actualmente, usted
  es responsable de construir un directorio con los directorios correctos de `node_modules`
  para que un paso de compilación de TypeScript encuentre todas
  las bibliotecas referenciadas en los ejemplos. Esto es especialmente relevante si sus
  ejemplos incluyen bibliotecas que dependen de la *biblioteca actual*: no es
  raro escribir ejemplos en la biblioteca `A` mostrando cómo usarla en combinación
  con la biblioteca `B`, donde `B` depende de `A`. Sin embargo, dado que por definición `B`
  *no puede* estar en el conjunto de dependencias de `A`, debe construir un directorio con
  ambos `B` y `A` en algún lugar de su sistema de archivos y ejecutar Rosetta en ese
  directorio.
- "Extract" compilará las muestras en paralelo. Cuantos más ensamblados le dé
  al mismo tiempo, más eficiente será el trabajo que podrá hacer.

El comando extract escribirá un archivo llamado `.jsii.tabl.json` junto a cada
ensamblado, que contiene traducciones para todas las muestras encontradas en el ensamblado. Usted
debería incluir este archivo en su paquete NPM cuando publique, para que
los consumidores descendentes del paquete tengan acceso a las traducciones.

Una invocación de ejemplo de `jsii-rosetta extract` se ve así:

```sh
jsii-rosetta extract --directory some/dir $(find . -name .jsii)
```

#### Ejecución en paralelo

Dado que la compilación de TypeScript consume mucho tiempo, se puede ganar mucho tiempo
usando eficazmente las CPUs de su sistema. `jsii-rosetta extract` ejecutará las
compilaciones en paralelo.

`jsii-rosetta` usará un número de trabajadores igual a la mitad del número de núcleos de CPU,
hasta un máximo de 16 trabajadores. Este máximo predeterminado puede ser modificado
estableciendo la variable de entorno `JSII_ROSETTA_MAX_WORKER_COUNT`.

Si obtiene errores de memoria insuficiente al ejecutar demasiados trabajadores, ejecute un comando como
este para aumentar la memoria permitida para sus trabajadores:

```sh
/sbin/sysctl -w vm.max_map_count=2251954
```

#### Caché

Rosetta extract traducirá todos los ejemplos encontrados en `.jsii` y escribirá las
traducciones en `.jsii.tabl.json`. De compilación a compilación, muchos de estos
ejemplos no habrán cambiado. Dado que la compilación de TypeScript es un proceso bastante costoso,
queremos evitar hacer trabajo innecesario tanto como sea posible.

Para ello, rosetta puede reutilizar traducciones de una caché y escribir
nuevas traducciones en la misma caché:

```sh
jsii-rosetta extract \
  --directory some/dir \
  --cache https://raw.githubusercontent.com/aws/jsii-rosetta/main/cache.json \
  [--trim-cache] \
  $(find . -name .jsii)
```

La opción `--trim-cache` eliminará cualquier traducción antigua de la caché que
ya no exista en ninguno de los ensamblados dados. Esto previene que la caché
crezca indefinidamente con el tiempo (un comando equivalente `jsii-rosetta trim-cache` está
disponible si su flujo de trabajo implica ejecutar `extract` en múltiples invocaciones distintas
y desea conservar la caché entre ellas).

### Infuse

El comando `jsii-rosetta infuse` aumenta la cobertura de ejemplos para clases
en el ensamblado.

Encuentra clases en el ensamblado que aún no tienen un ejemplo asociado
(según se especifica mediante la etiqueta `@example` en los comentarios de documentación), pero que se usan
en otro ejemplo encontrado en otro lugar — ya sea en un `README` o un ejemplo de otra
clase — y copiará el ejemplo a todas las clases involucradas. Esto asegurará que
sus ejemplos escritos a mano se extiendan lo más posible.

Tenga en cuenta que para hacer esto, `infuse` *modificará* los ensamblados que se le
proporcionen.

`rosetta infuse` depende del análisis realizado por `rosetta extract`, y por lo tanto debe
ejecutarse después de `extract`. También puede ejecutarse como parte de `extract`, pasando
la opción `--infuse`:

```sh
jsii-rosetta extract \
  --directory some/dir \
  --infuse \
  $(find . -name .jsii)
```

### Traducciones y pacmak

`jsii-pacmak` leerá traducciones de las tablets para sustituir ejemplos traducidos
en los bindings de fuente generados. `pacmak` leerá automáticamente archivos individuales
`.jsii.tabl.json` si están presentes, y además puede leer desde un archivo global
de tablet.

Cuando no se encuentra una traducción para una muestra de código, `pacmak` puede configurarse
para hacer una de las siguientes acciones:

- Dejar la muestra sin traducir (por defecto)
- Traducir la muestra en el lugar (esto ralentizará mucho la generación, y usted
  no tendrá el control detallado sobre el entorno de compilación que tendría
  si usara el comando `extract`)
- Fallar

Ejemplo:

```sh
jsii-pacmak \
  [--rosetta-tablet=https://raw.githubusercontent.com/aws/jsii-rosetta/main/global.json] \
  [--rosetta-unknown-snippets=verbatim|translate|fail]
```

### Flujo de datos

El siguiente diagrama muestra cómo fluye la información a través de las herramientas jsii cuando se usan juntas:

```text
┌───────────┐
│           │
│  Fuente   ├───┐
│           │   │    ╔══════════╗    ┌────────────┐     ╔═══════════════╗    ┌──────────┐
└───────────┘   │    ║          ║    │            │     ║    rosetta    ║    │          │
                ├───▶║   jsii   ║───▶│  ensamblado│────▶║    extract    ║───▶│  tablet  │
┌───────────┐   │    ║          ║    │            │     ║               ║    │          │
│           │   │    ╚══════════╝    └────────────┘     ╚═══════════════╝    └──────────┘
│  README   │───┘                           │                                      │
│           │                               │                                      │
└───────────┘                               │           ╔═══════════════╗          │
                                            │           ║    rosetta    ║          │
                                            └──────────▶║    infuse     ║◀─────────┘
                                                        ║               ║
                                                        ╚═══════════════╝
                                                                │
                                            ┌───────────────────┴───────────────────┐
                                            │                                       │
                                            ▼                                       ▼
                                     ┌────────────┐                           ┌──────────┐
                                     │            │                           │          │
                                     │ ensamblado'│                           │ tablet'  │
                                     │            │                           │          │
                                     └────────────┘                           └──────────┘
                                            │                                       │
                                            │                                       │
                                            │                                       ▼              ┌─────────────┐
                                            │                               ╔═══════════════╗     ┌┴────────────┐│
                                            │                               ║               ║     │             ││
                                            └──────────────────────────────▶║    pacmak     ║────▶│  paquetes   ││
                                                                            ║               ║     │             ├┘
                                                                            ╚═══════════════╝     └─────────────┘
                                                                               (potencialmente
                                                                             traduce en vivo)
```

## Temas avanzados

### Ocultar código de los ejemplos

Para hacer que los ejemplos compilen, puede ser necesario agregar código repetitivo que
distrae del ejemplo en cuestión (como declaraciones de variables e importaciones).

Este paquete soporta ocultar partes del código fuente original después de la traducción.

Para marcar ubicaciones especiales en el árbol fuente, podemos usar uno de tres mecanismos:

- Usar una sentencia de expresión `void` para marcar ubicaciones de sentencias en el AST.
- Usar el operador `coma` combinado con una expresión `void` para marcar ubicaciones de expresiones en el AST.
- Usar comentarios directivos especiales (`/// !hide`, `/// !show`) para marcar ubicaciones que abarcan nodos AST. Esto es menos fiable
  (porque a veces la ubicación fuente de la sintaxis traducida tendrá que ser estimada) pero es la única opción si desea
  marcar nodos no contiguos (como ocultar parte de una declaración de clase pero mostrar sentencias dentro del constructor).

La palabra clave de expresión `void` y/o la característica del operador `coma` son características poco usadas de JavaScript que son analizadas
fiablemente por TypeScript y no afectan la semántica de la aplicación en la que aparecen (por lo que el programa se ejecuta
igual con o sin ellas).

Un nemotécnico útil para esta característica es que puede usarla para "enviar su código al vacío".

#### Ocultar sentencias

Ocultar sentencias se ve así:

```ts
before(); // se mostrará

void 0; // comenzar a ocultar (el argumento de 'void' no importa)
middle(); // no se mostrará
void 'show'; // dejar de ocultar

after(); // se mostrará de nuevo
```

#### Ocultar expresiones

Para ocultar expresiones, usamos expresiones `coma` para adjuntar una sentencia `void` a un valor de expresión sin cambiar
el significado del código.

Ejemplo:
(Parte 3 de 4)

```ts
foo(1, 2, (void 1, 3));
```

Se renderizará como

```ts
foo(1, 2)
```

También soporta una elipsis visible:

```ts
const x = (void '...', 3);
```

Se renderiza como:

```ts
x = ...
```

#### Ocultar a través de nodos AST

Use directivas de comentarios especiales:

```ts
before();
/// !hide
notShown();
/// !show
after();
```

## Contribuidores ✨

Gracias a estas maravillosas personas ([clave de emoji](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - No elimine ni modifique esta sección -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/costleya"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars2.githubusercontent.com/u/1572163?v=4?s=100" width="100px;" alt="Aaron Costley"/><br /><sub><b>Aaron Costley</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Acostleya+label%3Abug" title="Informes de errores">🐛</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=costleya" title="Código">💻</a> <a href="https://github.com/aws/jsii/issues?q=author%3Acostleya+label%3Afeature-request" title="Solicitudes de funciones">🤔</a> <a href="https://github.com/aws/jsii-rosetta/pulls?q=is%3Apr+reviewed-by%3Acostleya" title="Pull Requests revisados">👀</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/ahodieb"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars1.githubusercontent.com/u/835502?v=4?s=100" width="100px;" alt="Abdallah Hodieb"/><br /><sub><b>Abdallah Hodieb</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aahodieb+label%3Abug" title="Informes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://endoflineblog.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars2.githubusercontent.com/u/460937?v=4?s=100" width="100px;" alt="Adam Ruka"/><br /><sub><b>Adam Ruka</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Askinny85+label%3Abug" title="Informes de errores">🐛</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=skinny85" title="Código">💻</a> <a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Askinny85" title="Mantenimiento">🚧</a> <a href="https://github.com/aws/jsii-rosetta/pulls?q=is%3Apr+reviewed-by%3Askinny85" title="Pull Requests revisados">👀</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/agdimech"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars.githubusercontent.com/u/51220968?v=4?s=100" width="100px;" alt="Adrian Dimech"/><br /><sub><b>Adrian Dimech</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=agdimech" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://adrianhesketh.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars.githubusercontent.com/u/1029947?v=4?s=100" width="100px;" alt="Adrian Hesketh"/><br /><sub><b>Adrian Hesketh</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=a-h" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://softwhat.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars0.githubusercontent.com/u/4362270?v=4?s=100" width="100px;" alt="Alex Pulver"/><br /><sub><b>Alex Pulver</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aalexpulver+label%3Abug" title="Informes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://aws.amazon.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars.githubusercontent.com/u/54958958?v=4?s=100" width="100px;" alt="Amazon GitHub Automation"/><br /><sub><b>Amazon GitHub Automation</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=amazon-auto" title="Código">💻</a></td>
    </tr>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/andipabst"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars.githubusercontent.com/u/9639382?v=4?s=100" width="100px;" alt="Andi Pabst"/><br /><sub><b>Andi Pabst</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aandipabst+label%3Abug" title="Informes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/rectalogic"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars.githubusercontent.com/u/11581?v=4?s=100" width="100px;" alt="Andrew Wason"/><br /><sub><b>Andrew Wason</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Arectalogic+label%3Abug" title="Informes de errores">🐛</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=rectalogic" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://www.aslezak.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars2.githubusercontent.com/u/6944605?v=4?s=100" width="100px;" alt="Andy Slezak"/><br /><sub><b>Andy Slezak</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=amslezak" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://ansgar.dev"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars.githubusercontent.com/u/1112056?v=4?s=100" width="100px;" alt="Ansgar Mertens"/><br /><sub><b>Ansgar Mertens</b></sub></a><br /><a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Aansgarm" title="Mantenimiento">🚧</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=ansgarm" title="Código">💻</a> <a href="https://github.com/aws/jsii/issues?q=author%3Aansgarm+label%3Abug" title="Informes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/anshulguleria"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars3.githubusercontent.com/u/993508?v=4?s=100" width="100px;" alt="Anshul Guleria"/><br /><sub><b>Anshul Guleria</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aanshulguleria+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://www.linkedin.com/in/aripalo/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars0.githubusercontent.com/u/679146?v=4?s=100" width="100px;" alt="Ari Palo"/><br /><sub><b>Ari Palo</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aaripalo+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://armaan.tobaccowalla.com"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/avatars.githubusercontent.com/u/13340433?v=4?s=100" width="100px;" alt="Armaan Tobaccowalla"/><br /><sub><b>Armaan Tobaccowalla</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3AArmaanT+label%3Abug" title="Informes de errores">🐛</a></td>
    </tr>
<!-- ALL-CONTRIBUTORS-LIST:END -->
      <td align="center" valign="top" width="14.28%"><a href="https://punch.dev/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars1.githubusercontent.com/u/38672686?v=4?s=100" width="100px;" alt="Sam Goodwin"/><br /><sub><b>Sam Goodwin</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/pulls?q=is%3Apr+reviewed-by%3Asam-goodwin" title="Pull Requests revisados">👀</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://skorfmann.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars1.githubusercontent.com/u/136789?v=4?s=100" width="100px;" alt="Sebastian Korfmann"/><br /><sub><b>Sebastian Korfmann</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Askorfmann+label%3Abug" title="Reportes de errores">🐛</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=skorfmann" title="Código">💻</a> <a href="https://github.com/aws/jsii/issues?q=author%3Askorfmann+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://sepehrlaal.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/5657848?v=4?s=100" width="100px;" alt="Sepehr Laal"/><br /><sub><b>Sepehr Laal</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3A3p3r+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://digitalsanctum.com/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars3.githubusercontent.com/u/30923?v=4?s=100" width="100px;" alt="Shane Witbeck"/><br /><sub><b>Shane Witbeck</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Adigitalsanctum+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
    </tr>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/shivlaks"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars0.githubusercontent.com/u/32604953?v=4?s=100" width="100px;" alt="Shiv Lakshminarayan"/><br /><sub><b>Shiv Lakshminarayan</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=shivlaks" title="Código">💻</a> <a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Ashivlaks" title="Mantenimiento">🚧</a> <a href="https://github.com/aws/jsii-rosetta/pulls?q=is%3Apr+reviewed-by%3Ashivlaks" title="Pull Requests revisados">👀</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/SomayaB"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars3.githubusercontent.com/u/23043132?v=4?s=100" width="100px;" alt="Somaya"/><br /><sub><b>Somaya</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=SomayaB" title="Código">💻</a> <a href="https://github.com/aws/jsii/issues?q=author%3ASomayaB+label%3Afeature-request" title="Solicitudes de funciones">🤔</a> <a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3ASomayaB" title="Mantenimiento">🚧</a> <a href="https://github.com/aws/jsii-rosetta/pulls?q=is%3Apr+reviewed-by%3ASomayaB" title="Pull Requests revisados">👀</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/skuenzli"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/869201?v=4?s=100" width="100px;" alt="Stephen Kuenzli"/><br /><sub><b>Stephen Kuenzli</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=skuenzli" title="Documentación">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/touchez-du-bois"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/434017?v=4?s=100" width="100px;" alt="Takahiro Sugiura"/><br /><sub><b>Takahiro Sugiura</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=touchez-du-bois" title="Documentación">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://gitter.im/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars2.githubusercontent.com/u/8518239?v=4?s=100" width="100px;" alt="The Gitter Badger"/><br /><sub><b>The Gitter Badger</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=gitter-badger" title="Código">💻</a> <a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Agitter-badger" title="Mantenimiento">🚧</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://medium.com/@thomaspoignant"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars2.githubusercontent.com/u/17908063?v=4?s=100" width="100px;" alt="Thomas Poignant"/><br /><sub><b>Thomas Poignant</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Athomaspoignant+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/ThomasSteinbach"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars0.githubusercontent.com/u/1683246?v=4?s=100" width="100px;" alt="Thomas Steinbach"/><br /><sub><b>Thomas Steinbach</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3AThomasSteinbach+label%3Abug" title="Reportes de errores">🐛</a></td>
    </tr>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/hoegertn"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars2.githubusercontent.com/u/1287829?v=4?s=100" width="100px;" alt="Thorsten Hoeger"/><br /><sub><b>Thorsten Hoeger</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=hoegertn" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/serverlessunicorn"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars1.githubusercontent.com/u/54867311?v=4?s=100" width="100px;" alt="Tim Wagner"/><br /><sub><b>Tim Wagner</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aserverlessunicorn+label%3Abug" title="Reportes de errores">🐛</a> <a href="https://github.com/aws/jsii/issues?q=author%3Aserverlessunicorn+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/tobli"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars3.githubusercontent.com/u/540266?v=4?s=100" width="100px;" alt="Tobias Lidskog"/><br /><sub><b>Tobias Lidskog</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=tobli" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/TomBonnerAtDerivitec"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/83637254?v=4?s=100" width="100px;" alt="Tom Bonner"/><br /><sub><b>Tom Bonner</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3ATomBonnerAtDerivitec+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://ty.coghlan.dev/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars2.githubusercontent.com/u/15920577?v=4?s=100" width="100px;" alt="Ty Coghlan"/><br /><sub><b>Ty Coghlan</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3AOphirr33+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/tvanhens"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars1.githubusercontent.com/u/5342795?v=4?s=100" width="100px;" alt="Tyler van Hensbergen"/><br /><sub><b>Tyler van Hensbergen</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Atvanhens+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://ultidev.com/Products/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars1.githubusercontent.com/u/757185?v=4?s=100" width="100px;" alt="Vlad Hrybok"/><br /><sub><b>Vlad Hrybok</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Avgribok+label%3Abug" title="Reportes de errores">🐛</a></td>
    </tr>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/Lanayx"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars2.githubusercontent.com/u/3329606?v=4?s=100" width="100px;" alt="Vladimir Shchur"/><br /><sub><b>Vladimir Shchur</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3ALanayx+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/Ragnoroct"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/19155205?v=4?s=100" width="100px;" alt="Will Bender"/><br /><sub><b>Will Bender</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3ARagnoroct+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://yanex.org/"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars2.githubusercontent.com/u/95996?v=4?s=100" width="100px;" alt="Yan Zhulanow"/><br /><sub><b>Yan Zhulanow</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=yanex" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/yglcode"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/11893614?v=4?s=100" width="100px;" alt="Yigong Liu"/><br /><sub><b>Yigong Liu</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Ayglcode+label%3Abug" title="Reportes de errores">🐛</a> <a href="https://github.com/aws/jsii/issues?q=author%3Ayglcode+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/ZachBien"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/1245628?v=4?s=100" width="100px;" alt="Zach Bienenfeld"/><br /><sub><b>Zach Bienenfeld</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3AZachBien+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/ajnarang"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars3.githubusercontent.com/u/52025281?v=4?s=100" width="100px;" alt="ajnarang"/><br /><sub><b>ajnarang</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aajnarang+label%3Afeature-request" title="Solicitudes de funciones">🤔</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/aniljava"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/412569?v=4?s=100" width="100px;" alt="aniljava"/><br /><sub><b>aniljava</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=aniljava" title="Código">💻</a></td>
    </tr>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/arnogeurts-sqills"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/79304871?v=4?s=100" width="100px;" alt="arnogeurts-sqills"/><br /><sub><b>arnogeurts-sqills</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aarnogeurts-sqills+label%3Abug" title="Reportes de errores">🐛</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=arnogeurts-sqills" title="Código">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/cn-cit"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/27255477?v=4?s=100" width="100px;" alt="cn-cit"/><br /><sub><b>cn-cit</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Acn-cit+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/deccy-mcc"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars0.githubusercontent.com/u/45844893?v=4?s=100" width="100px;" alt="deccy-mcc"/><br /><sub><b>deccy-mcc</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Adeccy-mcc+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/apps/dependabot-preview"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars3.githubusercontent.com/in/2141?v=4?s=100" width="100px;" alt="dependabot-preview[bot]"/><br /><sub><b>dependabot-preview[bot]</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Adependabot-preview[bot]+label%3Abug" title="Reportes de errores">🐛</a> <a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Adependabot-preview[bot]" title="Mantenimiento">🚧</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/apps/dependabot"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars0.githubusercontent.com/in/29110?v=4?s=100" width="100px;" alt="dependabot[bot]"/><br /><sub><b>dependabot[bot]</b></sub></a><br /><a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Adependabot[bot]" title="Mantenimiento">🚧</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/dheffx"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars0.githubusercontent.com/u/22029918?v=4?s=100" width="100px;" alt="dheffx"/><br /><sub><b>dheffx</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Adheffx+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/gregswdl"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars0.githubusercontent.com/u/47365273?v=4?s=100" width="100px;" alt="gregswdl"/><br /><sub><b>gregswdl</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Agregswdl+label%3Abug" title="Reportes de errores">🐛</a></td>
    </tr>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/guyroberts21"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/47118902?v=4?s=100" width="100px;" alt="guyroberts21"/><br /><sub><b>guyroberts21</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=guyroberts21" title="Documentación">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/mattBrzezinski"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/4356074?v=4?s=100" width="100px;" alt="mattBrzezinski"/><br /><sub><b>mattBrzezinski</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=mattBrzezinski" title="Documentación">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/mergify"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/18240476?v=4?s=100" width="100px;" alt="mergify"/><br /><sub><b>mergify</b></sub></a><br /><a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Amergify" title="Mantenimiento">🚧</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/apps/mergify"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars1.githubusercontent.com/in/10562?v=4?s=100" width="100px;" alt="mergify[bot]"/><br /><sub><b>mergify[bot]</b></sub></a><br /><a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Amergify[bot]" title="Mantenimiento">🚧</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/nathannaveen"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/42319948?v=4?s=100" width="100px;" alt="nathannaveen"/><br /><sub><b>nathannaveen</b></sub></a><br /><a href="https://github.com/aws/jsii/pulls?q=is%3Apr+author%3Anathannaveen" title="Mantenimiento">🚧</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/seiyashima"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars2.githubusercontent.com/u/4947101?v=4?s=100" width="100px;" alt="seiyashima42"/><br /><sub><b>seiyashima42</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Aseiyashima+label%3Abug" title="Reportes de errores">🐛</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=seiyashima" title="Código">💻</a> <a href="https://github.com/aws/jsii-rosetta/commits?author=seiyashima" title="Documentación">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/sullis"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars3.githubusercontent.com/u/30938?v=4?s=100" width="100px;" alt="sullis"/><br /><sub><b>sullis</b></sub></a><br /><a href="https://github.com/aws/jsii-rosetta/commits?author=sullis" title="Código">💻</a></td>
    </tr>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/vaneek"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars1.githubusercontent.com/u/8113305?v=4?s=100" width="100px;" alt="vaneek"/><br /><sub><b>vaneek</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Avaneek+label%3Abug" title="Reportes de errores">🐛</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/wendysophie"><img src="https://raw.githubusercontent.com/aws/jsii-rosetta/main/https://avatars.githubusercontent.com/u/54415551?v=4?s=100" width="100px;" alt="wendysophie"/><br /><sub><b>wendysophie</b></sub></a><br /><a href="https://github.com/aws/jsii/issues?q=author%3Awendysophie+label%3Abug" title="Reportes de errores">🐛</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

Este proyecto sigue la especificación [all-contributors](https://github.com/all-contributors/all-contributors).
¡Se agradecen contribuciones de cualquier tipo!

## :balance_scale: Licencia

**jsii** se distribuye bajo la [Licencia Apache, Versión 2.0][apache-2.0].

Consulte [LICENSE](https://raw.githubusercontent.com/aws/jsii-rosetta/main/LICENSE) y [NOTICE](https://raw.githubusercontent.com/aws/jsii-rosetta/main/NOTICE) para obtener más información.

[apache-2.0]: https://www.apache.org/licenses/LICENSE-2.0

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---