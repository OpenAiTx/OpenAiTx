
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Estado de traducción](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Estado de la compilación](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Estado Snap](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donar](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Una utilidad de red

Autor: Siddhartha Das

Una aplicación sencilla creada para elementary OS para proporcionar información esencial sobre aspectos relacionados con la red. La información se presenta en las siguientes pestañas.<br>
1. Mi Información: Proporciona información básica y detallada de la tarjeta de red del dispositivo<br>
2. Uso: Proporciona el uso de datos de red en dos vistas: uso histórico y uso actual<br>
3. Velocidad: Verifica las velocidades de subida y descarga y obtiene los tiempos de ruta hacia un host<br>
4. Puertos: Proporciona información sobre los puertos activos y la aplicación que los utiliza en el dispositivo local<br>
5. Dispositivos: Monitorea, alerta y proporciona información sobre otros dispositivos conectados en la red<br>

Consulta el sitio web de Nutty para detalles sobre funciones, atajos, guías de instalación para Ubuntu y otras distros soportadas, etc.: <br>
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

A veces vnstat no se inicia tras la instalación, usa el comando del sistema init apropiado para iniciar el demonio vnstat, es decir, `sudo systemctl enable vnstat`

Ejecuta `meson build` para configurar el entorno de compilación y ejecuta `ninja test` para compilar

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---