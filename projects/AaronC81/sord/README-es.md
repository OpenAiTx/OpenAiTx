# Sord

## Descripción general

Sord es un cruce entre [**So**rbet](https://sorbet.org) y [YA**RD**](https://yardoc.org/).
Puede **generar automáticamente archivos de firmas de tipo RBI y RBS**
mirando los **tipos especificados en los comentarios de documentación YARD**.

¡Si tu proyecto ya está documentado con YARD, entonces esto puede generar la mayoría de las
firmas de tipo que necesitas!

Sord es la manera perfecta de iniciar la adopción de tipos en tu proyecto,
ya sea que planees usar el formato RBI de Sorbet o el formato RBS de Ruby 3/Steep.

**Prueba Sord en línea en: [sord.aaronc.cc](https://sord.aaronc.cc)**

Sord tiene las siguientes características:
  - Genera automáticamente firmas para módulos, clases y métodos
  - Soporte para múltiples tipos de parámetros o de retorno (`T.any`/`|`)
  - Maneja de forma elegante tipos YARD faltantes (`T.untyped`/`untyped`)
  - Puede inferir el tipo del parámetro setter desde el tipo de retorno del getter correspondiente
  - Reconoce mixins (`include` y `extend`)
  - Soporte para tipos genéricos como `Array<T>` y `Hash<K, V>`
  - Puede inferir clases con espacios de nombres (`[Bar]` puede convertirse en `GemName::Foo::Bar`)
  - Maneja tipos de retorno que pueden ser `nil` (`T.nilable`/`untyped`)
  - Maneja tipos duck (`T.untyped`/`untyped`)
  - Soporte para tipos de listas ordenadas (`[Array(Integer, Symbol)]` se convierte en `[Integer, Symbol]`)
  - Soporte para tipos booleanos (`[true, false]` se convierte en `T::Boolean`/`bool`)
  - Soporte para parámetros `&block` documentados con `@yieldparam` y `@yieldreturn`

## Uso

Instala Sord con `gem install sord`.

Sord es una herramienta de línea de comandos. Para usarla, abre una terminal en el directorio raíz
de tu proyecto e invoca `sord`, pasando una ruta donde quieras guardar tu
archivo (este archivo será sobrescrito):

```
sord defs.rbi
```
Sord generará documentación YARD y luego imprimirá información sobre lo que ha inferido  
mientras se ejecuta. Es mejor corregir cualquier problema en la documentación YARD, ya que  
cualquier edición realizada en el archivo resultante será reemplazada si vuelves a ejecutar Sord.  

El tipo de salida se infiere por la extensión del archivo que uses, pero también puedes  
especificarlo explícitamente con `--rbi` o `--rbs`.  

## Envío de Tipos RBI  

Los archivos RBI generados por Sord pueden usarse de dos maneras principales:  

- [Incluidos en la gema misma](https://sorbet.org/docs/rbi#rbis-within-gems).  
- Contribuidos a [sorbet-typed](https://github.com/sorbet/sorbet-typed).  

Generalmente, deberías incluir las firmas de tipo con tu gema si es posible.  
sorbet-typed está pensado para ser un lugar para gemas que ya no se actualizan o  
donde el mantenedor no quiere incluir firmas de tipo con la gema misma.  

### Opciones  

Sord también acepta algunas opciones para modificar el archivo generado:  

  - `--rbi`/`--rbs`: Sobrescribe el formato de salida inferido a partir de la  
    extensión del archivo.  
  - `--no-sord-comments`: Genera el archivo sin ningún comentario de Sord sobre  
    advertencias/inferencias/errores. (Los comentarios del archivo original seguirán  
    incluidos.)  
  - `--no-regenerate`: Por defecto, Sord volverá a generar la documentación YARD  
    de un repositorio por ti. Esta opción evita regenerar la documentación YARD.  
  - `--break-params`: Determina cuántos parámetros son necesarios antes de que  
    la firma cambie de una línea única a un bloque multilínea.  
    (Por defecto: 4)  
  - `--replace-errors-with-untyped`: Usa `T.untyped` en lugar de constantes  
    `SORD_ERROR_*`.  
  - `--replace-unresolved-with-untyped`: Usa `T.untyped` cuando Sord no puede  
    resolver una constante.  
  - `--include-messages` y `--exclude-messages`: Se usan para filtrar los mensajes  
    de registro proporcionados por Sord. `--include-messages` actúa como una lista  
    blanca, imprimiendo solo mensajes de los tipos de registro especificados, mientras que `--exclude-messages`

    actúa como una lista negra y suprime los tipos de registro especificados. Ambas opciones
    toman una lista separada por comas de tipos de registro, por ejemplo `omit,infer`.
    Al usar `--include-messages`, el tipo `done` se incluye por defecto.
    (No puede especificar ambos `--include-messages` y `--exclude-messages`.)
  - `--exclude-untyped`: Excluir métodos y atributos con valores de retorno no tipados.
  - `--tags TAGS`: Proporciona una lista de etiquetas separadas por comas según entiende el
    comando `yard`. Por ejemplo, `--tags 'mytag:My Description,mytag2:My New Description'

## Ejemplo

Supongamos que tenemos este archivo, llamado `test.rb`:


```ruby
module Example
  class Person
    # @param name [String] The name of the Person to create.
    # @param age [Integer] The age of the Person to create.
    # @return [Example::Person]
    def initialize(name, age)
      @name = name
      @age = age
    end

    # @return [String]
    attr_accessor :name

    # @return [Integer]
    attr_accessor :age

    # @param possible_names [Array<String>] An array of potential names to choose from.
    # @param possible_ages [Array<Integer>] An array of potential ages to choose from.
    # @return [Example::Person]
    def self.construct_randomly(possible_names, possible_ages)
      Person.new(possible_names.sample, possible_ages.sample)
    end
  end
end
```

Primero, genere un registro YARD ejecutando `yardoc test.rb`. Luego, podemos ejecutar
`sord test.rbi` para generar el archivo RBI. (¡Cuidado de no sobrescribir sus archivos de código!
Note la extensión de archivo `.rbi`.) Al hacer esto, Sord imprime:

```
[INFER] Assuming from filename you wish to generate in RBI format
[DONE ] Processed 8 objects (2 namespaces and 6 methods)
```

El archivo `test.rbi` contiene entonces un archivo RBI completo para `test.rb`:

```ruby
# typed: strong
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    sig { params(name: String, age: Integer).void }
    def initialize(name, age); end

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    sig { params(possible_names: T::Array[String], possible_ages: T::Array[Integer]).returns(Example::Person) }
    def self.construct_randomly(possible_names, possible_ages); end

    sig { returns(String) }
    attr_accessor :name

    sig { returns(Integer) }
    attr_accessor :age
  end
end
```

Si en su lugar hubiéramos generado `test.rbs`, obtendríamos este archivo en formato RBS:

```ruby
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    def initialize: (String name, Integer age) -> void

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    def self.construct_randomly: (Array[String] possible_names, Array[Integer] possible_ages) -> Example::Person

    attr_accessor name: String

    attr_accessor age: Integer
  end
end
```

## Cosas a tener en cuenta

La regla general para las conversiones de tipos es:

  - Si Sord entiende el tipo YARD, entonces se convierte en el tipo RBI o RBS.
  - Si el tipo YARD falta, Sord rellena con `T.untyped`.
  - Si el tipo YARD no se puede entender, Sord crea una constante Ruby indefinida
    con un nombre similar al tipo YARD desconocido. Por ejemplo, el tipo YARD
    obviamente inválido `A%B` se convertirá en una constante llamada `SORD_ERROR_AB`.
    Debe buscar en su archivo resultante para encontrar y corregir cualquier
    `SORD_ERROR`.

## Contribuir

Los informes de errores y las solicitudes de extracción son bienvenidos en GitHub en https://github.com/AaronC81/sord. Este proyecto está destinado a ser un espacio seguro y acogedor para la colaboración, y se espera que los contribuyentes respeten el código de conducta [Contributor Covenant](http://contributor-covenant.org).

Mientras contribuye, si desea ver los resultados de sus cambios en Sord puede usar la tarea Rake `examples:seed`. La tarea usa Sord para generar tipos para varios gems de Ruby de código abierto, incluyendo Bundler, Haml, Rouge y RSpec. `rake examples:seed` (y `rake examples:reseed` para regenerar los archivos) clonará los repositorios de estos gems en `sord_examples/` y luego generará los archivos en el mismo directorio.

## Licencia

El gem está disponible como código abierto bajo los términos de la [Licencia MIT](https://opensource.org/licenses/MIT).

## Código de Conducta

Se espera que todos los que interactúen en las bases de código, rastreadores de problemas, salas de chat y listas de correo del proyecto Sord sigan el [código de conducta](https://github.com/AaronC81/sord/blob/master/CODE_OF_CONDUCT.md).








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---