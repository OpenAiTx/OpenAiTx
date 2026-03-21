# suppress-eslint-errors

![Release](https://github.com/amanda-mitchell/suppress-eslint-errors/workflows/Release/badge.svg)

¿Alguna vez has intentado activar una nueva regla de eslint solo para desanimarte por cientos o miles de errores en una base de código existente?  
Nosotros también.

A veces, no hay un buen argumento comercial para actualizar todo el código existente (¡que funciona!), especialmente en una base de código heredada y grande.  
Para esos momentos, `suppress-eslint-errors` te cubre.

## Cómo funciona

`suppress-eslint-errors` es un codemod para [jscodeshift](https://github.com/facebook/jscodeshift) que ejecuta eslint contra tu código existente.  
Por cada error de eslint que encuentra, añade un pequeño fragmento:

```javascript
// TODO: Fix this the next time the file is edited.
// eslint-disable-next-line cool-new-rule
```

De esta manera, puedes obtener los beneficios de la regla en código nuevo sin tener que trabajar inmediatamente en una gran acumulación.

## Uso

`suppress-eslint-errors` viene con un script envoltorio para que puedas llamarlo directamente sin instalar nada adicional:

```bash
npx suppress-eslint-errors [jscodeshift options] PATH...
```

El envoltorio llamará a `jscodeshift` con el transformador y cualquier otro argumento que le pases.
Si detecta un `.gitignore` en el directorio local, también lo especificará como el `--ignore-config`.

`supress-eslint-errors` debe usarse con una copia local instalada de `eslint`.
Si no puede encontrar una, se detendrá temprano.

_NOTA:_ `jscodeshift` tiene algunos errores respecto a cómo maneja los archivos `.gitignore` que a veces hacen que ignore todos los archivos.
Si esta herramienta detecta que tu `.gitignore` contiene patrones problemáticos, la opción `--ignore-config` será omitida.

En algunos casos, el código producido por este codemod tomará decisiones desafortunadas de indentación.
¡Asegúrate de volver a ejecutar cualquier herramienta de formateo de código que uses antes de hacer commit!

## Opciones

**--message**: Establece el comentario para añadir sobre los comentarios eslint-disable-next-line.

**--rules**: Lista separada por comas de IDs de reglas ESLint para deshabilitar. Cuando se especifica, las violaciones de reglas que no estén en este conjunto se dejarán en su lugar.

## Ejemplos

Suprimir todos los errores en el archivo `index.js`, usando un comentario personalizado:

```bash
npx suppress-eslint-errors ./index.js --message="TODO: Issue #123"
```

Suprimir las violaciones de las reglas `eqeqeq` y `@typescript-eslint/no-explicit-any` en archivos .ts y .tsx en el directorio `src`:

```bash
npx suppress-eslint-errors ./src --extensions=ts,tsx --parser=tsx --rules=eqeqeq,@typescript-eslint/no-explicit-any
```

## Matices

Como dice el nombre de la herramienta, esto solo suprime los _errores_ de eslint.
Si tienes advertencias que deseas suprimir, cambia tu configuración de eslint para convertirlas en errores antes de ejecutar la herramienta o especifica las reglas usando la bandera `--rules`.

## ¿Es perfecto?

Definitivamente no. Se aceptan PR para cualquier caso límite que encuentres.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---