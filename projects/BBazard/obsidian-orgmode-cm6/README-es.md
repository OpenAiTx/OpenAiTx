# Obsidian Orgmode CM6

[Orgmode](https://orgmode.org) para [Obsidian](https://obsidian.md).

![Captura de pantalla](https://raw.githubusercontent.com/BBazard/obsidian-orgmode-cm6/master/./screenshot.png)

## Uso

Por defecto, los archivos org no se muestran en la barra lateral.
Para mostrarlos, necesitas ir a la configuración de Obsidian, sección `Archivos y enlaces` y marcar `Detectar todas las extensiones de archivo`.

![detect-all-file-extensions](https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/e6a91e66-295d-4057-bf80-e43dcdb8e3e7)

Para crear un archivo org en tu bóveda, actualmente debes crearlo fuera de Obsidian, ya que Obsidian no permite crear un archivo que no sea markdown.

Si aún no tienes un archivo org, intenta crear un archivo llamado `todo.org` con el siguiente contenido:

```org
* TODO [#A] A task with *high* priority

The description of the task

* A collapsed section

You cannot see the description when collapsed

* DONE something done already :sometag:
SCHEDULED: <2023-12-08 Fri 11:13>
:PROPERTIES:
:CREATED: [2023-12-03 Sun 10:48]
:END:

a [[https://github.com/BBazard/obsidian-orgmode-cm6][link]]

#+begin_src javascript
const block = "highlighted"
#+end_src
```
## Funciones compatibles

### Editor Orgmode

- Vista previa en vivo  
- Resaltado de sintaxis (con clases css que se pueden sobreescribir)  
- Palabras clave de tareas personalizables en la configuración  
- Plegado (clic en la margen a la izquierda en la primera línea del elemento para plegarlo)  
- Enlaces wiki (`[[unicornio]]` abrirá el archivo unicornio.org en cualquier lugar de la bóveda o usará unicornio.md como respaldo)  
- Imágenes en línea (`[[miimagen.png]]` mostrará la imagen si existe en la bóveda)  
- Enlaces ID (`[[id:12345]]` redirigirá al encabezado con el :ID: correspondiente en un cajón de propiedades ubicado en cualquier archivo org de la bóveda)  
- Soporte Vim (si está activado en Obsidian)  
- Resaltado de bloques de código fuente (soportados: c, c++, css, html, java, javascript, json, php, python, rust, sass, xml)  

### Analizador Orgmode (resaltado de sintaxis)  

Siguiendo la [Sintaxis Org](https://orgmode.org/worg/org-syntax.html)  

- [x] Encabezado (anidado, sin soporte para encabezado COMENTARIO)  
- [x] Sección (incluyendo sección cero)  
- [x] Marcado de texto (negrita, cursiva, subrayado, etc...)  
- [x] Enlace (enlace regular, enlace con ángulo, enlace simple)  
- [x] Combinación de marcado y enlace  
- [x] Línea de comentario  
- [x] Línea de palabra clave  
- [x] Línea de planificación  
- [x] Cajón de propiedades  
- [x] Bloque menor (sin formato excepto bloques fuente)  
- [ ] Bloque dinámico (no es posible ya que obsidian no permite ejecución arbitraria en plugins)  
- [ ] Cajón  
- [ ] Lista y casilla de verificación  
- [ ] Regla horizontal  
- [ ] Marca de tiempo  
- [ ] Reloj  
- [ ] Sexp de diario  
- [ ] Nota al pie  
- [ ] Tabla  
- [ ] Latex  
- [ ] : Línea de ancho fijo (puede usar un bloque en su lugar)


## Detalles de la implementación

- Los archivos orgmode se manejan con una instancia de [codemirror 6](https://codemirror.net) que es independiente de la usada para los archivos markdown. Eso significa que el complemento debe reimplementar todas las funciones que funcionan para archivos markdown.

- El analizador lee un archivo orgmode y construye un árbol de nodos de sintaxis usando una gramática [lezer](https://lezer.codemirror.net) con tokenizadores personalizados. Este enfoque permite coincidir con los tokens con mayor precisión que el enfoque basado en regex de Emacs. Por ejemplo, las líneas de planificación solo se corresponden después de un encabezado y no en medio de una sección.

- Los tokens superpuestos no se consideran válidos. Por ejemplo: `*one _two three* four_`. Emacs, usando regex, tendría `*one _two three*` como negrita y `_two three* four_` como subrayado. El analizador lezer en cambio considera `*one _two three*` como negrita y ` four_` como texto normal, lo que permite que el rango de marcado de texto sea su propio nodo de sintaxis.

- No hay límites en el nivel de los encabezados (por lo que no hay Inlinetask) ni en el número de líneas de un marcado de texto.

## Mostrar tareas orgmode en archivos markdown

Esta función es inestable y probablemente cambiará de manera incompatible en el futuro.

Actualmente solo se manejan TODO y DONE.

https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/b071b2c8-b56e-4050-8fcf-02a922fdd1c0

Para filtrar, se soportan expresiones de búsqueda [orgzly](https://www.orgzly.com/docs#search) (implementadas: s, d, c, i, it, ad).

```orgmode-tasks
filepath: Orgmode/Orgmode file.org
query: it.todo or it.done
```

## Desarrollo

```
git clone https://github.com/bbazard/obsidian-orgmode-cm6
cd obsidian-orgmode-cm6
npm install
npm run build
npm test
cp main.js styles.css manifest.json "$OBSIDIAN_VAULT"/.obsidian/plugins/obsidian-orgmode-cm6/
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---