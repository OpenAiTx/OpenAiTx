
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 Controlador MT7902 como Subparte del Controlador MT7921 (✅ Funcionando)
Chip Mediatek mt7902 wifi 6E Soporte para Bluetooth y WiFi

> [!IMPORTANTE]
> El kernel de Linux 7.1 soporta oficialmente el chip WIFI 6E MT7902


## 📁 Clonar el repositorio
Clona el repositorio en tu PC local
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Si no quieres clonar el historial pasado entonces 
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Instalación


### 🚀 Guía de Instalación con Script (Recomendado para Sistemas Basados en Ubuntu)
Haga el script ejecutable si aún no lo está
```
chmod +x ./install_guide.sh
```
Ahora ejecuta este script
```
./install_guide.sh
```
Se solicitará automáticamente la contraseña cuando sea necesario  
* Este script te pedirá que instales el firmware, el controlador de bluetooth y wifi uno por uno  
* Probado en Ubuntu con kernel linux 7.0  

### 🚀 Corrección Automática Fácil (Recomendado para sistemas basados en Arch)  
Si quieres arreglar rápidamente tu WiFi y Bluetooth en cualquier kernel moderno, sigue estos pasos:  

Haz que el script sea ejecutable si aún no lo es
```
chmod +x ./fix_my_wifi.sh
```

**Ejecute el script de corrección automática** con sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Qué hace este script:
* **Verifica dependencias:** Asegura que tengas instalado `gcc`/`clang`, `make`, `bc` y los `kernel-headers` actuales. Si no, los instala con tu gestor de paquetes preferido.
* **Compila Drivers:** Construye automáticamente los drivers de WiFi y Bluetooth para la versión exacta de tu kernel.
* **Corrección Persistente:** Instala un servicio del sistema que asegura que tu WiFi permanezca activo incluso después de reiniciar tu computadora.
* **Seguridad:** Instala los módulos en un directorio personalizado (`/lib/modules/mt7902_custom`) para evitar alterar los archivos del sistema por defecto.

> [!NOTE]
> Necesitarás conexión a internet (vía Ethernet o anclaje USB desde tu teléfono) la primera vez que ejecutes esto para descargar las herramientas necesarias de compilación. (Como compilador, linux-headers, etc)


## ✅ Probado en (Verificado funcionando)
Esta corrección ha sido verificada y confirmada funcionando en:

* **Marca:** ASUS
* **Modelo:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset:** MediaTek MT7902 (WiFi 6E)
* **Versión del Kernel:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **Sistemas Operativos:** Arch, Ubuntu
* **Gestor de Paquetes:** pacman, apt

## Disponible para:
* **SO**: Cualquier sistema que soporte uno de los gestores de paquetes mencionados
* **Gestores de paquetes preferidos**: apt, pacman, dnf, zypper, nix-shell
* **Versiones del Kernel**: 6.14-7.0.7


## 🔧 Firmwares usados
Los firmwares están almacenados en la carpeta `firmware`.


## 📱 Bluetooth ✅ (Funcional)
> [!WARNING]
> Si el driver de bluetooth entra en conflicto con `gen4-mt7902`, por favor elimina el firmware de bluetooth para que no interfiera con este driver
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Este proyecto usa el firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Para habilitar bluetooth ve al directorio de tu versión actual del kernel. ``
Si tienes el kernel linux-6.16, entonces ve al directorio `./linux-6.16/drivers/bluetooth` .
Abra la terminal en este directorio y compile con el comando `make`.  
Se compilan dos módulos del kernel `btusb.ko` y `btmtk.ko`.  
Para habilitar el bluetooth en su dispositivo, elimine btusb y btmtk de su sistema e instale estos dos archivos, use los comandos  
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Ahora verifica si tu bluetooth está funcionando.

## 💻 WiFi ✅ (Funciona)
> [!IMPORTANTE]
> Un repositorio funcional con algunas limitaciones está [aquí](https://github.com/hmtheboy154/gen4-mt7902)

El controlador WiFi para el mt7902, recientemente lanzado por mediatek, está dentro de la carpeta `latest`.

Si estás usando Ubuntu, simplemente ve a la carpeta `latest` y ejecuta el siguiente comando en la terminal.
```
make
```
Compilará todos los módulos, los comprimirá y los instalará (reemplazando el módulo del kernel original con el módulo modificado). Si usas otra distro o no quieres todos los pasos y solo deseas compilar el código, entonces ejecuta en la terminal

```
make module_compile
```
Para comprimir el módulo que compilaste, luego ejecútalo en la terminal
```
make module_compress
```
Para instalar el módulo comprimido en el módulo del kernel del sistema, ejecute en la terminal
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---