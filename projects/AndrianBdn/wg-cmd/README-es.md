# WG Commander 

también conocido como "wg-cmd" — TUI para gestionar archivos de configuración de WireGuard

<a href="https://github.com/andrianbdn/wg-cmd/releases/latest"><img src="https://img.shields.io/github/v/release/andrianbdn/wg-cmd" /></a>
<a href="./LICENSE"><img src="https://img.shields.io/github/license/andrianbdn/wg-cmd" /></a>
<a href="./go.mod"><img src="https://img.shields.io/github/go-mod/go-version/andrianbdn/wg-cmd" /></a>
[![Go Report Card](https://goreportcard.com/badge/github.com/andrianbdn/wg-cmd)](https://goreportcard.com/report/github.com/andrianbdn/wg-cmd)

![captura de pantalla](https://user-images.githubusercontent.com/994900/218720566-e5b3ab22-d7fc-4df7-a777-ad9b6280ada8.png)

# Características
- no requiere navegador ni puerto HTTP - funciona en la terminal, también por SSH
- incluye un asistente de configuración agradable
- interfaz de usuario basada en texto para gestionar peers
- ver código QR en la terminal
- copiar configuración al portapapeles (OSC 52)
- configura automáticamente sysctl, systemd, NAT

## Limitaciones actuales
- soporta configuración simple cliente-servidor de WireGuard
- mayormente para Linux (asume que iptables, systemd, sysctl están disponibles) — ver sección [Otros SO](#other-os-besides-linux)
- no puede gestionar configuraciones existentes de WireGuard (pero puede crear nuevas interfaces WireGuard en el mismo host)

# Instalación 

Asegúrese de tener instalados WireGuard e iptables 
(`apt install wireguard-tools` en Ubuntu / Debian, `dnf install wireguard-tools iptables` en Rocky/Alma 9). 

Para descargar usando curl ejecute:
```shell
# for x86_64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-amd64 -o /usr/local/bin/wg-cmd

# for arm64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-arm64 -o /usr/local/bin/wg-cmd
```

Establezca los permisos adecuados y ejecute la herramienta: 
```
chmod 755 /usr/local/bin/wg-cmd
wg-cmd
```
Si no tienes `/usr/local/bin` en $PATH tendrás que  
ejecutar el comando `/usr/local/bin/wg-cmd` usando la ruta completa.  

WG Commander requiere permisos de root para ajustar automáticamente sysctl,  
crear unidades systemd y escribir en /etc/wireguard.  

# Uso  

En la primera ejecución WG Commander mostrará el asistente de configuración,  
que permite configurar una nueva interfaz WireGuard de forma interactiva.  

En ejecuciones posteriores (si el asistente fue exitoso) simplemente mostrará la TUI de gestión.  

Nota sobre el código QR: algunos dispositivos (¿Android?) pueden requerir un código QR de mayor calidad.  
WG Commander aumentará automáticamente la calidad cuando aumentes la resolución de la ventana del Terminal  
(fuente más pequeña, ventana más grande).  

## Uso avanzado  

Puedes ejecutar WG Commander como usuario no root si cambias los permisos en  
/etc/wireguard y configuras sysctl/systemd manualmente.  

WG Commander guarda su propia configuración de UI en `~/.config/wg-cmd/wg-cmd.toml`  

Las opciones más importantes son:
```toml
WireguardDir = "/etc/wireguard"
# directory for WireGuard configuration files 

DatabaseDir = "/etc/wireguard"
# directory for WG Commander database files (wgc-<interface-name>)
```

Puede cambiar estas opciones para que apunten a directorios a los que tenga acceso de escritura.

### Opciones especiales 

Ejecute `wg-cmd new` para iniciar el asistente para la configuración de una nueva interfaz.

Ejecute `wg-cmd <wg-interface>` para cambiar a una interfaz específica (debe haberse creado antes con wg-cmd).

Ejecute `wg-cmd <wg-interface> make` para generar la configuración de Wireguard sin mostrar la interfaz gráfica.

### Configuración 

WG Commander utiliza directorios como su "base de datos". 
Almacena la configuración de la interfaz en el directorio /etc/wireguard/wgc-<nombre-de-la-interfaz>. 

La configuración se almacena utilizando el formato de archivo [TOML](https://toml.io).

La mayoría de las claves de configuración son similares a las de WireGuard. 

#### configuración del servidor (0001-server.toml)
Algunas claves en este archivo de configuración se utilizarán realmente para generar 
archivos de configuración del cliente. 

`ClientRoute` - AllowedIPs para la configuración del cliente

`ClientDNS` - Valor de configuración DNS para todos los clientes

`ClientServerEndpoint` - Endpoint para la configuración del cliente

`ClientPersistentKeepalive` - PersistentKeepalive para la configuración del cliente 

`MTU` - MTU para el servidor y el cliente (0 — hacer que WireGuard lo elija)

#### configuración del cliente (nnnn-%client%.toml)

`ClientRoute` - reemplaza completamente el `ClientRoute` de la configuración del servidor

`AddServerRoute` - añade una red adicional a AllowedIPs para el cliente en el lado del servidor (útil 
cuando desea enrutar el tráfico de un cliente a la red de otro cliente a través del servidor)
`MTU` - Sobrescribir el MTU del servidor con un valor diferente para este cliente. Establecer en -1 para omitir el MTU en esta configuración del cliente WireGuard.

`DNS` - Sobrescribir la configuración `ClientDNS` del servidor para todos los clientes. Especificar una lista de IPs separadas por comas.  
Establecer en `no` o `none` para omitir DNS en esta configuración del cliente WireGuard.

Los archivos de configuración del cliente contienen el campo `PrivateKey`.  
Si lo considera inaceptable, puede eliminarlo del archivo después de exportar  
la configuración (o código QR) al cliente.

### Otros sistemas operativos además de Linux

WG Commander está diseñado para funcionar en Linux, porque utiliza procfs, systemd, iptables, sysctl.  
Sin embargo, está escrito en Go puro, por lo que debería funcionar en cualquier sistema operativo que soporte Go.

- Necesitará compilar el binario usted mismo.  
- Establezca la variable de entorno `WG_CMD_NO_DEPS` a 1 para deshabilitar cualquier verificación específica de Linux al inicio.  
- Edite 0001-server.toml y configure sus comandos del sistema operativo en los campos PostUp4/PostUp6/PostDown4/PostDown6.  
- Necesitará recargar la configuración de WireGuard: manualmente cuando cambie algo  
o monitorear los archivos /etc/wireguard/wg*.conf para detectar cambios y recargar WireGuard automáticamente.

Se aceptan PRs para añadir soporte para otros sistemas operativos.

### Ejecución en Docker

Aunque es posible, no se recomienda ejecutar WG Commander en Docker.

El asistente de configuración no funcionará correctamente, porque necesita crear unidades systemd y modificar sysctl.

### Desinstalación

Para desinstalar WG Commander, simplemente elimine el binario de /usr/local/bin/wg-cmd.  
También puede eliminar los directorios /etc/wireguard/wgc-* y ~/.config/wg-cmd

Si ha creado unidades systemd, deberá eliminarlas manualmente.

A continuación, un ejemplo de cómo eliminar la interfaz wg7 gestionada por WG Commander  
(cámbiela por la interfaz que necesite eliminar):



```sh
systemctl stop wgc-wg7.{path,service}
systemctl disable wgc-wg7.{path,service}
rm /etc/systemd/system/wgc-wg7.{path,service}
systemctl stop wg-quick@wg7.service
systemctl disable wg-quick@wg7.service
rm /etc/wireguard/wg7.conf
rm -Rf /etc/wireguard/wgc-wg7
```

# Probado
WG Commander debería funcionar bien en cualquier distribución Linux basada en systemd
con WireGuard, iptables, sysctl, procfs disponibles.

Se probó en:
- Ubuntu 24.04 (v0.1.7 probado el 9 de abril de 2026)
- Ubuntu 20.04
- Ubuntu 22.04
- Rocky Linux 9
- Debian 11
- Debian 12

# Contribuciones

Las contribuciones son bienvenidas. Por favor, consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/AndrianBdn/wg-cmd/main/CONTRIBUTING.md) para las directrices, incluyendo nuestra política de divulgación de IA.

# Notas 
No hay un propósito comercial detrás de WG Commander. 
El proyecto está licenciado bajo 
la [Licencia MIT](https://github.com/andrianbdn/wg-cmd/blob/master/LICENSE).

Este proyecto NO está relacionado con el creador de WireGuard®.
El proyecto WG Commander NO está aprobado, patrocinado, ni afiliado 
con WireGuard® ni con la comunidad de WireGuard®.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---