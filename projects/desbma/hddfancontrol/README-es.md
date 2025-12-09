# Control del ventilador del HDD

[![Estado de CI](https://img.shields.io/github/actions/workflow/status/desbma/hddfancontrol/ci.yml)](https://github.com/desbma/hddfancontrol/actions)
[![Versión en crates.io](https://img.shields.io/crates/v/hddfancontrol)](https://crates.io/crates/hddfancontrol)
[![Versión en AUR](https://img.shields.io/aur/version/hddfancontrol.svg?style=flat)](https://aur.archlinux.org/packages/hddfancontrol/)
[![Licencia](https://img.shields.io/github/license/desbma/hddfancontrol.svg?style=flat)](https://github.com/desbma/hddfancontrol/blob/master/LICENSE)

---

Desde la versión 2.0, esta herramienta ha sido reescrita en Rust. La versión anterior en Python se puede encontrar en la [rama v1](https://github.com/desbma/hddfancontrol/tree/v1). Consulte [Migración desde v1.x](#migrating-from-v1x) para la migración.

---

HDD Fan control es una herramienta de línea de comandos para controlar dinámicamente la velocidad del ventilador según la temperatura del disco duro en Linux.

Esto tiene 3 beneficios:

- permite mantener sus discos duros en el rango de temperatura ideal para tener la máxima longevidad y evitar el sobrecalentamiento

Porque los ventiladores disminuirán la velocidad o se detendrán cuando no sean necesarios:

- minimiza el ruido generado por los ventiladores
- minimiza el consumo de energía al mismo tiempo

## Tabla de contenido

- [¿Cuándo es útil esto?](#when-is-this-useful)
- [Características](#features)
- [Requisitos previos](#prerequisites)
- [Instalación](#installation)
  - [Paquetes de la distribución](#distribution-packages)
  - [Desde el código fuente](#from-source)
- [Configuración](#configuration)
  - [Una palabra de precaución](#a-word-of-caution)
  - [Configuración del ventilador](#fan-configuration)
- [Registro de cambios](#changelog)
  - [Migración desde v1.x](#migrating-from-v1x)
- [Uso desde la línea de comandos](#command-line-usage)
- [Servicio systemd](#systemd-service)
- [Licencia](#license)

## ¿Cuándo es útil esto?

El control de ventiladores para discos duros es útil cuando tienes uno o varios discos duros con uno o varios ventiladores cerca de ellos, y no quieres que la placa base controle la velocidad del ventilador, porque lo hace de forma estática o usando un sensor de temperatura no relacionado con la temperatura real del disco (ya sea en la CPU o en otro lugar de la placa base).

El caso de uso ideal es para un NAS con varios discos duros, una CPU de bajo consumo (por ejemplo, ARM o Intel Atom) con refrigeración pasiva (sin ventiladores), y un chasis con ventiladores cerca del disco duro. En ese caso, la CPU generará menos calor que los discos duros y tiene sentido controlar la velocidad del ventilador según la fuente principal de calor.

## Características

- Puede controlar varios ventiladores y/o varios discos con una sola invocación
- Soporta 6 diferentes formas de consultar la temperatura:
  - Invocación de `hddtemp`
  - Consulta al demonio `hddtemp`
  - Invocación de `hdparm`
  - Invocación de `smartctl` (SCT)
  - Invocación de `smartctl` (atributos SMART)
  - hwmon nativo del kernel `drivetemp`
- Puede adaptarse a diferentes características de ventiladores
- Se puede personalizar según tus necesidades:
  - para detener los ventiladores o hacerlos funcionar a máxima velocidad a temperaturas personalizables
  - para nunca establecer los ventiladores por debajo de cierta velocidad (útil si los ventiladores controlados por HDD Fan control son los únicos disponibles en el chasis)
- También puede opcionalmente monitorear la temperatura de la CPU y controlar la velocidad del ventilador en consecuencia

## Requisitos previos

- Una distribución Linux
- Al menos un disco duro SATA/SAS\* que soporte:
  - Consulta de temperatura
  - Consulta de estado de energía
- Una placa base que:
  - exponga al sistema operativo un PWM para controlar la velocidad del ventilador
  - exponga al sistema operativo un sensor para consultar la velocidad del ventilador

La mayoría de las placas base y discos SATA cumplen estos requisitos.

\* Ha habido varios informes de que `hddfancontrol` funciona bien con discos SAS, sin embargo, esto ha sido menos probado que con SATA.

## Instalación

### Paquetes de la distribución

Algunas distribuciones de Linux tienen un paquete hddfancontrol disponible en su repositorio:

- Alpine Linux (testing): [hddfancontrol](https://pkgs.alpinelinux.org/package/edge/testing/x86_64/hddfancontrol)
- Arch Linux (AUR): [hddfancontrol](https://aur.archlinux.org/packages/hddfancontrol/)
- Fedora: [hddfancontrol](https://packages.fedoraproject.org/pkgs/hddfancontrol/hddfancontrol/)

Consulte [GitHub releases](https://github.com/desbma/hddfancontrol/releases) para otros paquetes/binarios compilados para cada versión etiquetada.

### Desde el código fuente

Necesita un entorno de compilación de Rust, por ejemplo de [rustup](https://rustup.rs/).

Ejecute en el repositorio actual:

```
cargo build --release
install -Dm 755 -t /usr/local/bin target/release/hddfancontrol
```

También instale [hdparm](http://sourceforge.net/projects/hdparm/), [smartctl](https://www.smartmontools.org/), [sdparm](https://sg.danny.cz/sg/sdparm.html) (para soporte de unidades SAS), y opcionalmente [hddtemp](http://www.guzu.net/linux/hddtemp.php).
En Ubuntu reciente y otras derivadas de Debian: `sudo apt install hdparm sdparm smartmontools`.

Consulte [servicio systemd](#systemd-service) para gestionar fácilmente el demonio.

### Desde [`crates.io`](https://crates.io/)

```
sudo cargo install --root /usr/local
```

## Configuración

### Una palabra de precaución

Los parámetros predeterminados harán que los ventiladores funcionen al 100% de velocidad a temperaturas > 50°C, y funcionen al 20% de velocidad si < 30°C, lo que corresponde a la temperatura de funcionamiento recomendada habitual para el disco. Si está seguro de que no hay otros componentes en su sistema que generen calor significativo, si tiene otros ventiladores para enfriar su sistema, o si tiene una caja optimizada para enfriamiento pasivo, puede establecer la velocidad mínima en 0%, lo que detendrá los ventiladores si la temperatura está por debajo del umbral mínimo.

**Tenga en cuenta que una configuración incorrecta de esta herramienta puede provocar un fallo en el enfriamiento adecuado de su sistema, lo que puede dañar los componentes o reducir su vida útil.**

Antes de usar el control de ventiladores HDD sin supervisión durante un período prolongado, recomiendo mantener una velocidad mínima del ventilador por seguridad y verificar que la temperatura de su sistema se mantenga en un rango razonable como se espera.

### Configuración del ventilador

Para obtener los valores de inicio/parada para el parámetro `--pwm`, puede:

- Usar el comando `pwm-test` (`hddfancontrol pwm-test ...`), que ejecutará algunas pruebas y detectará los valores a los que los ventiladores arrancan y se detienen. Sin embargo, necesita haber identificado previamente el archivo PWM (el parámetro `--pwm`)
- usar la herramienta [pwmconfig](http://www.lm-sensors.org/wiki/man/pwmconfig).

## Registro de cambios

Consulte el [registro de cambios detallado](https://raw.githubusercontent.com/desbma/hddfancontrol/master/./CHANGELOG.md) para todos los cambios desde la versión inicial 2.

### Migración desde v1.x

Con la versión 2, `hddfancontrol` ha sido completamente reescrito en el lenguaje Rust. Los principales cambios respecto a la versión 1 son:

- `hddfancontrol` es un binario compilado y ya no requiere un intérprete de Python.
- Los argumentos de línea de comandos han cambiado ligeramente y requerirán ajustes manuales, ya sea en sus invocaciones de `hddfancontrol` o en el archivo `/etc/conf.d/hddfancontrol` si lo usa a través del servicio systemd. Consulte `hddfancontrol daemon -h` para referencia.
- Se eliminó la función de parada automática de giro del disco. Si la necesita, recomiendo usar [hd-idle](https://github.com/adelolmo/hd-idle) (tenga cuidado, hay varios proyectos con nombres similares), que funciona bien junto con `hddfancontrol`.

## Uso en línea de comandos

Ejecute `hddfancontrol -h` para obtener la referencia completa de línea de comandos.

Como ejemplo, la siguiente línea de comandos instruirá a HDD Fan control para:

- monitorear la temperatura de los discos `/dev/sda` y `/dev/sdb`
- controlar la velocidad del ventilador usando PWM 2 y 3 en `/sys/class/hwmon/hwmon1/device/`
- arrancar ambos ventiladores usando el valor PWM 200
- considerar que los ventiladores se detendrán con valor PWM 75
- nunca haga funcionar los ventiladores por debajo del 10% de su velocidad máxima
- controle la temperatura al menos cada minuto

`hddfancontrol daemon -d /dev/sda /dev/sdb -p /sys/class/hwmon/hwmon1/device/pwm2:200:75 /sys/class/hwmon/hwmon1/device/pwm3:200:75 --min-fan-speed-prct 10 -i 1min`

## servicio systemd

Se proporciona un archivo de servicio systemd para controlar el demonio fácilmente.
Si instaló hddfancontrol desde un paquete de distribución, probablemente ya lo tenga instalado, de lo contrario puede instalarlo desde las fuentes de este repositorio con:

```
sudo install -Dm 644 ./systemd/hddfancontrol.service /etc/systemd/system/hddfancontrol.service
sudo install -Dm 644 ./systemd/hddfancontrol.conf /etc/conf.d/hddfancontrol
```

Luego debe editar la variable `HDDFANCONTROL_DAEMON_ARGS` en `/etc/conf.d/hddfancontrol` para establecer los parámetros (discos, rango de temperatura...).

Luego puede iniciar el demonio con `sudo systemctl start hddfancontrol`, ver su estado con `sudo systemctl status hddfancontrol` y habilitar el inicio automático al arrancar con `sudo systemctl enable hddfancontrol`.

## Licencia

[GPLv3](https://www.gnu.org/licenses/gpl-3.0-standalone.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-09

---