# ./dops - mejor `docker ps`  
Un reemplazo para el docker-ps predeterminado que intenta ajustarse realmente al ancho de tu terminal.

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/main.png)

## Justificación

Por defecto, la salida de mi `docker ps` es realmente ancha y cada línea se divide en tres.  
Esto (obviamente) rompe la visualización tabular y hace que todo sea caótico.  
*(Esto se vuelve especialmente malo si un contenedor tiene múltiples asignaciones de puertos, y todas se muestran en una sola fila)*  
No parece que vayamos a tener una salida mejorada en el futuro previsible (ver [moby#7477](https://github.com/moby/moby/issues/7477)), así que decidí hacer mi propio reemplazo directo.  

## Características

 - Todas las opciones/banderas normales de la línea de comandos de docker-ps funcionan *(casi)* igual.  
 - Escribe datos de múltiples valores (como múltiples asignaciones de puertos, múltiples redes, etc.) en múltiples líneas en lugar de concatenarlos.  
 - Añade color a la columna STATE y STATUS (verde / amarillo / rojo).  
 - Elimina automáticamente columnas en la salida hasta que encaje en el ancho actual del terminal.  
 - Ordena la salida con el argumento `--sort`  
 - Entra en modo watch con el argumento `--watch`  

Más cambios respecto al docker-ps por defecto:  
 - Muestra (por defecto) el comando del contenedor sin argumentos.  
 - Muestra el Nombre de Imagen (por defecto) sin el prefijo del registro, y divide Nombre de Imagen y Etiqueta en dos columnas.  
 - Añadidas las columnas IP y NETWORK al conjunto de columnas por defecto (si caben)  
 - Añadido soporte para algunas columnas nuevas (vía --format):  
   `{{.ImageName}`, `{{.ImageTag}`, `{{.Tag}`, `{{.ImageRegistry}`, `{{.Registry}`, `{{.ShortCommand}`, `{{.LabelKeys}`, `{{.IP}`                         
 - Añadidas opciones para controlar la salida en color, el socket usado, la zona horaria y formato de tiempo, etc (ver `./dops --help`)  

## Empezando

### Linux genérico (p.ej. Debian/Fedora/...)  
 - Descarga el binario más reciente desde la [página de lanzamientos](https://github.com/Mikescher/better-docker-ps/releases) y colócalo en tu PATH (ej. /usr/local/bin)  
 - También puedes usar la siguiente línea única (después puedes usar el comando `dops` en cualquier lugar):
```
$> sudo wget "https://github.com/Mikescher/better-docker-ps/releases/latest/download/dops_linux-amd64-static" -O "/usr/local/bin/dops" && sudo chmod +x "/usr/local/bin/dops"
```
### ArchLinux
 - Alternativamente, puedes usar uno de los paquetes AUR (en Arch Linux):
    * https://aur.archlinux.org/packages/dops-bin (instala `dops` en tu PATH)
    * https://aur.archlinux.org/packages/dops-git (instala `dops` en tu PATH)
 - o el paquete homebrew:
    * `brew tap mikescher/tap && brew install dops`

### Pasos opcionales
 - Alias al comando docker ps como `dops` (ver [sección abajo](#usage-as-drop-in-replacement))

## Capturas de pantalla

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/fullsize.png)  
Todas las columnas (por defecto) visibles

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/default.png)  
Salida en una terminal de tamaño mediano

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/small.png)  
Salida en una terminal pequeña

&nbsp;

## Uso como reemplazo directo

Puedes reemplazar completamente docker ps creando una función shell en tu `.bashrc` / `.zshrc`...

~~~sh
docker() {
  case $1 in
    ps)
      shift
      command dops "$@"
      ;;
    *)

      command docker "$@";;
  esac
}
~~~

Esto aliasará cada llamada a `docker ps ...` con `dops ...` (asegúrate de tener el binario dops en tu PATH).

Si usas fish-shell tienes que crear una función (similar):

~~~fish
function docker
    if test -n "$argv[1]"
        switch $argv[1]
            case ps
                dops $argv[2..-1]
            case '*'
                command docker $argv[1..-1]
        end
    end
end
~~~

## Cambiar el formato de salida

Por defecto dops intenta ser "inteligente" y encontrar el mejor formato de salida para el ancho de tu terminal.
Los formatos de salida actuales (= columnas de la tabla) están definidos en el [options.go](https://github.com/Mikescher/better-docker-ps/blob/master/cli/options.go).
Se usa el primer formato que quepa en el ancho de tu terminal.

Pero también puedes sobrescribirlo suministrando un parámetro `--format`. Si proporcionas más de un parámetro `--format`, se usa el primero que quepa en tu terminal (misma lógica que con los formatos por defecto...)

Normalmente solo se soportan columnas simples, es decir, `{{.Status}}`.  
Pero también puedes usar la sintaxis completa de plantillas golang (p.ej. `{{ printf "%.15s" .Command }}`).
En este caso puede ser útil especificar el encabezado de la columna anteponiéndolo con dos puntos (`NOMBRE ACORTADO:{{ printf "%.10s" (join .Names ";") }}`)

Las siguientes funciones están definidas en estas plantillas (además de las [funciones go por defecto](https://pkg.go.dev/text/template)):
 - `join`: strings.Join
 - `array_last`: v\[-1\]
 - `array_slice`: v\[a..b\] 
 - `in_array`: v1.contains(v2)
 - `json`: json.Marshal(v)
 - `json_indent`: json.MarshalIndent(v, "", "  ")
 - `json_pretty`:  json.Indent(v, "", "  ")
 - `coalesce`: v1 ?? v2
 - `to_string`: fmt.Sprintf("%v", v)
 - `deref`: *v
 - `now`: time.Now()
 - `uniqid`: UUID

Examples:
~~~~
$ ./dops --format "table {{.ID}}"
$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"

$ ./dops --format "idlist"

$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"  --format "table {{.ID}}\\t{{.Names}}" --format "table {{.ID}}"

$ ./dops --format "ID: {{.ID}}; Name: {{.Names}}"

$ ./dops -aq

$ ./dops --sort "IP" --sort-direction "ASC"

$ ./dops --format "table {{.ID}}\\tCMD:{{ printf \"%.15s\" .Command }}"
$ ./dops --format "table {{.ID}}\\tNAME:{{ printf \"%.10s\" (join .Names \";\") }}"

~~~~

## Configuración persistente

También puedes configurar algunas/la mayoría de las opciones mediante un archivo de configuración.  
Coloca un archivo con formato TOML en `$HOME/.config/dops.conf` / `$XDG_CONFIG_HOME/dops.conf`.

Las siguientes claves son compatibles:
 - verbose
 - silent
 - timezone
 - timeformat
 - timeformat-header
 - color
 - socket
 - todos
 - tamaño
 - filtro (= arreglo de cadenas)
 - formato (= arreglo de cadenas)
 - último
 - más reciente
 - truncar
 - encabezado (= verdadero / falso / simple)
 - ordenar (= arreglo de cadenas)
 - dirección-orden (= arreglo de cadenas)

Ejemplo:
```toml
verbose = 0

timezone = "Europe/Berlin"

format = [
   "table {{.ID}}\t{{.Names}}\t{{.State}}\t{{.Status}}",
   "table {{.ID}}\t{{.Names}}\t{{.State}}",
   "table {{.ID}}\t{{.Names}}",
   "table {{.ID}}",
]

header = "simple"
```

## Manual

Salida de `./dops --help`:

~~~~~~
better-docker-ps

Uso:
  dops [OPCIONES]                    Listar contenedores de docker

Opciones (por defecto):
  -h, --help                         Mostrar esta pantalla.
  --version                          Mostrar versión.
  --all , -a                         Mostrar todos los contenedores (por defecto muestra solo los en ejecución)
  --filter <ftr>, -f <ftr>           Filtrar salida según las condiciones proporcionadas
  --format <fmt>                     Imprimir contenedores formateados usando una plantilla Go
  --last , -n                        Mostrar los n últimos contenedores creados (incluye todos los estados)
  --latest , -l                      Mostrar el contenedor creado más reciente (incluye todos los estados)
  --no-trunc                         No truncar la salida (ej. IDs de contenedor, referencias de imagen Sha256, línea de comandos)
  --quiet , -q                       Mostrar solo los IDs de los contenedores
  --size , -s                        Mostrar el tamaño total de archivos

Opciones (extra | no existen en `docker ps`):
  --silent                           No imprimir ninguna salida
  --timezone                         Especificar la zona horaria para salidas de fecha
  --color <true|false>               Activar/Desactivar color en la terminal
  --no-color                         Desactivar color en la terminal
  --socket <ruta-de-archivo>         Especificar la ubicación del socket docker (Por defecto: `auto` - que llama al cli de docker para determinar el socket)
  --timeformat <formato-go-time>     Especificar el formato de fecha/hora de salida (sintaxis golang)
  --no-header                        No imprimir el encabezado de la tabla
  --simple-header                    No imprimir las líneas debajo del encabezado
  --format <fmt>                     Puede especificar múltiples formatos y se usará el primero que se ajuste al ancho de su terminal
  --sort <col>                       Ordenar la salida por una columna específica, use el mismo identificador que en --format, útil solo con formatos de tabla
  --sort-direction <ASC|DESC>        Dirección del ordenamiento, útil solo en combinación con --sort
  --watch <interval>, -w <interval>  Refrescar la salida automáticamente periódicamente (intervalo es opcional, por defecto: 2s)

Claves disponibles para --format (por defecto):
  {{.ID}}                            ID del contenedor
  {{.Image}}                         ID de la imagen
  {{.Command}}                       Comando entrecomillado
  {{.CreatedAt}}                     Hora en que se creó el contenedor.
  {{.RunningFor}}                    Tiempo transcurrido desde que se inició el contenedor.
  {{.Ports}}                         Puertos publicados. ([!] difiere de docker CLI, estos son solo los puertos publicados)
  {{.State}}                         Estado del contenedor
  {{.Status}}                        Estado del contenedor con detalles
  {{.Size}}                          Tamaño en disco del contenedor.
  {{.Names}}                         Nombres del contenedor.
  {{.Labels}}                        Todas las etiquetas asignadas al contenedor.
  {{.Label}}                         [!] No soportado
  {{.Mounts}}                        Nombres de los volúmenes montados en este contenedor.
  {{.Networks}}                      Nombres de las redes conectadas a este contenedor.

Claves disponibles para --format (extra | no existen en `docker ps`):
  {{.ImageName}}                     ID de la imagen (sin etiqueta ni registro)
  {{.ImageTag}}, {{.Tag}}            Etiqueta de la imagen
  {{.ImageRegistry}}, {{.Registry}}  Registro de la imagen
  {{.ShortCommand}}                  Comando sin argumentos
  {{.LabelKeys}}                     Todas las etiquetas asignadas al contenedor (solo claves)
  {{.ShortPublishedPorts}}           Puertos publicados, salida más corta que {{.Ports}}
  {{.LongPublishedPorts}}            Puertos publicados, salida completa con IP
  {{.ExposedPorts}}                  Puertos expuestos
  {{.PublishedPorts}}                Puertos publicados
  {{.NotPublishedPorts}}             Puertos expuestos pero no publicados
  {{.PublicPorts}}                   Solo la parte pública de los puertos publicados
  {{.IP}}                            Dirección IP interna
~~~~~~


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-16

---