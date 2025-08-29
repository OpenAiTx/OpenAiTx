# Flatito: Grep para archivos YAML y JSON

Una especie de grep para archivos YAML y JSON. Te permite buscar una clave y obtener el valor y el número de línea donde se encuentra.

![Ejemplo](https://raw.githubusercontent.com/ceritium/flatito/master/docs/screenshot.png)

## Significado

[Esperanto](https://en.wiktionary.org/wiki/flatito): participio pasivo nominal pasado singular de flati ('adular').

## Instalación

Instala la gema y añádela al Gemfile de la aplicación ejecutando:

    $ bundle add flatito

Si no se usa bundler para gestionar dependencias, instala la gema ejecutando:

    $ gem install flatito

### Paquete Nixpkgs

También está disponible como [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=flatito) gracias a [@Rucadi](https://github.com/Rucadi)

    $ nix run nixpkgs#flatito


## Uso

```sh
Usage:    flatito PATH [options]
Example:  flatito . -k "search string" -e "json,yaml"
Example:  cat file.yaml | flatito -k "search string"

    -h, --help                       Prints this help
    -V, --version                    Show version
    -k, --search-key=SEARCH          Search string
        --no-color                   Disable color output
    -e, --extensions=EXTENSIONS      File extensions to search, separated by comma, default: (json,yaml,yaml)
        --no-skipping                Do not skip hidden files
```

## Desarrollo

Después de clonar el repositorio, ejecuta `bin/setup` para instalar las dependencias. Luego, ejecuta `rake test` para correr las pruebas. También puedes ejecutar `bin/console` para un prompt interactivo que te permitirá experimentar.

Para instalar esta gema en tu máquina local, ejecuta `bundle exec rake install`. Para lanzar una nueva versión, actualiza el número de versión en `version.rb`, y luego ejecuta `bundle exec rake release`, lo que creará una etiqueta git para la versión, subirá los commits y la etiqueta creada, y subirá el archivo `.gem` a [rubygems.org](https://rubygems.org).

## Contribuciones

Los reportes de errores y pull requests son bienvenidos en GitHub en https://github.com/ceritium/flatito. Este proyecto está destinado a ser un espacio seguro y acogedor para la colaboración, y se espera que los contribuyentes respeten el [código de conducta](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md).

## Licencia

La gema está disponible como código abierto bajo los términos de la [Licencia MIT](https://opensource.org/licenses/MIT).

## Código de Conducta

Se espera que todos los que interactúan en las bases de código del proyecto Flatito, rastreadores de incidencias, salas de chat y listas de correo sigan el [código de conducta](https://github.com/ceritium/flatito/blob/master/CODE_OF_CONDUCT.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---