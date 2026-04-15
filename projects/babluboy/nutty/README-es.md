# Nutty [![Estado de la traducción](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Estado de la compilación](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Estado Snap](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donar](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Una utilidad de red

Autor: Siddhartha Das

Una aplicación simple hecha para elementary OS para proporcionar información esencial sobre aspectos relacionados con la red. La información se presenta en las siguientes pestañas.<br>
1. Mi Info: Proporciona información básica y detallada de la tarjeta de red del dispositivo<br>
2. Uso: Proporciona el uso de datos de red en dos vistas - uso histórico y uso actual<br>
3. Velocidad: Verifica velocidades de subida y bajada y obtiene tiempos de ruta a un host<br>
4. Puertos: Proporciona información sobre puertos activos y aplicaciones que los usan en el dispositivo local<br>
5. Dispositivos: Monitorea, alerta y proporciona información sobre otros dispositivos conectados en la red<br>

Consulta el sitio web de Nutty para detalles sobre características, atajos, guías de instalación para Ubuntu y otras distribuciones soportadas, etc.: <br>
https://babluboy.github.io/nutty/

## Compilación, Pruebas e Instalación desde el Código Fuente

Necesitarás las siguientes dependencias para compilar:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Y estas dependencias para ejecutar:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

A veces vnstat no se inicia tras la instalación, usa el comando apropiado del sistema init para iniciar el demonio vnstat, es decir, `sudo systemctl enable vnstat`

Ejecute `meson build` para configurar el entorno de compilación y ejecute `ninja test` para compilar

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

Para instalar, use `sudo ninja install`, luego ejecute con `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```

Para desinstalar, vaya al directorio de compilación y ejecute
```
sudo ninja uninstall
```

### Instalación desde paquete Deb

Para instalar Nutty desde el paquete `.deb`, asegúrese de haber instalado todas las dependencias de ejecución anteriores de Nutty (no es necesario instalar las dependencias de compilación). Luego ejecute el siguiente comando
```bash
sudo dpkg -i <deb-package-name>.deb
```

Y para desinstalar Nutty instalado mediante paquete `.deb` ejecute
```bash
sudo apt autoremove com.github.babluboy.nutty
```

Si desea compilar directamente el paquete `.deb` de Nutty usted mismo, instale las dependencias de compilación mencionadas arriba y luego ejecute
```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---