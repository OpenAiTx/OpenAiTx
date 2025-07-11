# eBAF - Cortafuegos de Anuncios Basado en eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - Banner del Cortafuegos de Anuncios eBPF" width="600"/>
</p>

## "No Descargarías un Anuncio"
### ¡Pero Sí lo Bloquearías!
 
Spotify ha construido un imperio con una fórmula sencilla: monetizar tu atención, pagar poco a los artistas y venderte tu propio tiempo como una función premium.
En su mundo, tu experiencia de escucha no es tuya. Es un mercado cuidadosamente curado: tus oídos son el producto, tu paciencia es la moneda.

A esto les gusta llamarlo una capa "gratuita".
Pero seamos honestos: no es gratis si estás pagando con tu tiempo.

Mientras tanto, los artistas que amas —las personas cuyo trabajo mantiene viva la plataforma— a menudo ganan apenas fracciones de centavos por reproducción. Spotify obtiene grandes ganancias, los anunciantes obtienen su exposición, ¿y los creadores? Ellos reciben migajas.

Esto no se trata solo de saltarse algunos anuncios molestos.
Se trata de negarse a participar en un sistema que se beneficia de la explotación, la distracción y la mercantilización de tu atención.

#### ¿Qué es esto?
Un pequeño y elegante acto de resistencia digital: un bloqueador de anuncios limpio y de código abierto para Spotify que detiene el ruido — literalmente.

Sin mods dudosos, sin clientes crackeados, sin malware disfrazado de libertad. Solo un objetivo: dejar que la música suene sin ser rehén de los anuncios.

Spotify no es gratis — pagas con tu paciencia.

Te bombardean con los mismos anuncios irritantes, una y otra vez, hasta que te rindes y te suscribes. No porque ames Premium. Sino porque te han desgastado. Eso no es freemium — es guerra psicológica con una playlist.

¿Mientras tanto, los artistas? Siguen mal pagados.
¿Los anuncios? Más ruidosos. Más frecuentes. A veces, literalmente más ruidosos.
¿Tú? Solo intentando disfrutar.

Ellos se benefician de tu paciencia y del pago insuficiente a los creadores, mientras pretenden que es la única forma sostenible. Spoiler: no lo es. Tenían una opción — pero eligieron los márgenes de ganancia sobre las personas.

Spotify quiere que creas que este es el costo de acceso.
Nosotros creemos que eso es una mentira.

No somos piratas. No somos criminales. Solo somos personas que piensan que está bien trazar un límite.

Este proyecto no trata de saltarse unos cuantos anuncios. Se trata de rechazar un sistema que dice que tu silencio se puede vender, que tu experiencia se puede interrumpir y que tu valor comienza solo cuando abres la billetera.

Bloquear anuncios no es robar.<br>
Robar tu tiempo sí lo es.<br>
No estamos aquí para piratear. Estamos aquí para salirnos.<br>
<br>
**No descargarías un anuncio. Pero sí lo bloquearías.**
## ¿Cómo funciona eBAF?

eBAF (eBPF Ad Firewall) aprovecha el poder de eBPF (Extended Berkeley Packet Filter) para bloquear anuncios no deseados a nivel del kernel. Aquí tienes una visión general de su funcionamiento:

## ¿Cómo funciona eBAF?

eBAF (eBPF Ad Firewall) utiliza eBPF (Extended Berkeley Packet Filter) para bloquear anuncios de manera eficiente a nivel del kernel. Aquí tienes una visión simplificada:

1. **Filtrado de paquetes**:
   - Inspecciona los paquetes de red entrantes y bloquea aquellos que coinciden con una lista negra de direcciones IP utilizando XDP (eXpress Data Path).

2. **Actualizaciones dinámicas**:
   - Resuelve nombres de dominio en direcciones IP y actualiza la lista negra dinámicamente para mantenerse efectivo ante los cambios en los servidores de anuncios.

3. **Panel web**:
   - Proporciona estadísticas en tiempo real y monitoreo a través de una interfaz fácil de usar.

4. **Alto rendimiento**:
   - Opera directamente a nivel de la interfaz de red, omitiendo la pila de red del kernel para un procesamiento más rápido y un uso mínimo de recursos.

eBAF combina eficiencia, transparencia y facilidad de uso para ofrecer una solución potente de bloqueo de anuncios.
## Instalación Simple (Recomendada)
Asegúrate de tener git y curl instalados
```bash
git --version
curl --version
```
### Instalación
#### Habilitar integración con Spotify (Recomendado)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Deshabilitar explícitamente
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Desinstalar
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Instalación para Desarrollo
Ejecute los siguientes comandos para instalar las dependencias requeridas:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Corregir el error asm/types.h al ejecutar código eBPF
Verifica el enlace actual  
`ls -l /usr/include/asm`  
Encuentra el enlace correcto  
`find /usr/include -name "types.h" | grep asm`  
Corrige el enlace simbólico  
```bash
sudo rm /usr/include/asm
sudo ln -s <enlace_actual> /usr/include/asm
```

### Compilando el proyecto

Para compilar el Adblocker eBPF, sigue estos pasos:

1. Clona el repositorio:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Construya el proyecto:
   ```bash
   make
   ```

3. (Opcional) Instale a nivel de sistema:
   ```bash
   sudo make install
   ```

4. Otras opciones de instalación (ayuda)
    ```bash
    make help
    ````

5. Desinstalar
    ```bash
    make uninstall
    ````
## Uso

### Ejecutando el Adblocker
    Usa spotify-stable.txt como Lista Negra predeterminada.
    Uso: ebaf [OPCIONES] [INTERFAZ...]
    OPCIONES:
    -a, --all               Ejecutar en todas las interfaces activas
    -d, --default           Ejecutar solo en la interfaz predeterminada (con acceso a internet)
    -i, --interface IFACE   Especificar una interfaz a usar
    -D, --dash              Iniciar el panel web (http://localhost:8080)
    -q, --quiet             Suprimir salida (modo silencioso)
    -h, --help              Mostrar este mensaje de ayuda


### Configuración de la Lista Negra
Edita las listas para agregar o eliminar dominios. Cada dominio debe estar en una línea separada. Los comentarios comienzan con `#`.

## Agradecimientos

Un agradecimiento especial a ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

por proporcionar una lista de bloqueo de Spotify
## ⭐️ Apoya el Proyecto

Si encuentras útil eBAF, ¡por favor considera darle una estrella al repositorio en GitHub! Tu apoyo ayuda a aumentar la visibilidad y fomenta el desarrollo continuo.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---