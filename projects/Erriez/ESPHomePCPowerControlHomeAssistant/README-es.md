# Control de Encendido de PC con ESPHome vía Home Assistant

Este proyecto contiene control remoto del encendido de PC vía HomeAssistant y placas ESPHome ESP8266/ESP32.

Uso este proyecto para encender y apagar remotamente mi NAS basado en PC vía Home Assistant como alternativa a Wake-On-Lan (WOL) que tiene limitaciones conocidas.

## Características

* Control del botón físico de encendido del PC (panel frontal) conectado a la placa base:
  * Encender el PC desde cualquier estado de energía como `apagado/suspendido/hibernación` (Comportamiento de pulsación corta del botón de encendido).
  * Apagado/suspensión/hibernación ordenado del sistema operativo (Comportamiento de pulsación corta del botón de encendido).
  * Apagado forzado (Comportamiento de pulsación larga del botón de encendido).
* Leer el estado de encendido/apagado del PC desde la placa base.
* Sin dependencia del sistema operativo.
* Los botones de encendido/reset del panel frontal permanecen totalmente funcionales.
* Autorización de usuario vía Homeassistant.
* Uso con cualquier placa base (micro/mini)-ATX.

Video de Youtube:

[![Video de Youtube](https://img.youtube.com/vi/rAcvqaPf830/0.jpg)](https://www.youtube.com/watch?v=rAcvqaPf830)

Captura de pantalla de Homeassistant:

![Captura de pantalla Home Assistant](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ScreenshotHomeAssistant.jpg)

## Diferencias con el paquete mágico Wake-On-Lan (WOL)

[Wake-On-Lan (WOL)](https://es.wikipedia.org/wiki/Wake-on-LAN) está diseñado para encender la energía del ordenador remotamente vía Ethernet enviando un llamado `paquete mágico`. Esto tiene varias limitaciones conocidas que no aplican con este proyecto ESP:

* Wake-On-Lan (WOL) **no tiene autorización**! El protocolo WOL no tiene funcionalidad para proveer contraseña ni permitir que un equipo específico despierte el PC. Cualquier dispositivo en la misma LAN puede despertar un PC enviando un paquete mágico. El ESP está protegido con contraseña vía Homeassistant.
* Wake-On-Lan (WOL) solo puede `despertar` un PC desde estado suspendido o apagado. No hay funcionalidad para apagar/suspender.
* Para poner una máquina Linux en estado de `suspensión`, se puede hacer una conexión SSH al PC remoto, por ejemplo ejecutando el comando `pm-suspend` (Instalar vía `sudo apt install pm-utils`), referencia [documentación Ubuntu pm-action](https://manpages.ubuntu.com/manpages/jammy/man8/pm-action.8.html). Desventajas:
  * Requiere inicio de sesión SSH.
  * Requiere derechos sudo.
* Los paquetes mágicos Wake-On-Lan son ignorados al conectar la fuente de alimentación por primera vez, incluso cuando WOL está activado en la BIOS. La razón es que WOL está desactivado en la mayoría de los ordenadores al primer encendido y requiere activación por un sistema operativo en ejecución antes de que el PC responda a un paquete mágico para despertar el equipo. Referencia: [Ubuntu Wake-On-Lan](https://help.ubuntu.com/community/WakeOnLan).
* Ejecutar Wake-On-Lan de Homeassistant [Wake-On-Lan](https://www.home-assistant.io/integrations/wake_on_lan) en un contenedor Docker no puede reenviar paquetes mágicos broadcast con una configuración de red en puente. Requiere un contenedor Docker externo como puente para reenviar paquetes mágicos y está fuera del alcance de Homeassistant. Actualmente esto no está incluido en la documentación de Homeassistant.

## Hardware

El hardware consiste en un ESP8266 o ESP32 y dos pines IO, montados en una placa metálica PCI (ver imagen abajo). En mi caso utilicé una placa ESP8266 NodeMCU. Teóricamente, cualquier placa ESP8266 o ESP32 puede usarse para este proyecto.

* Un pin controla el botón de encendido generando una pulsación larga o corta
* Un segundo pin lee el estado de encendido de la placa base.

![Hardware](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/NodeMCU.jpg)

## Esquemático

Mi NAS está basado en una placa base Intel Core I7 ASRock Z97 ATX y contiene conectores macho estándar 2.5mm 2x5:

![Esquemático](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Schematic.png)

**Conector ATX USB 2.0:**

El pin 1 del conector `J1` es alimentación constante +5V en el pin 1, incluso cuando el PC está apagado y se usa para alimentar el NodeMCU. El ESP8266 o ESP32 se alimenta a través de un regulador 3V3 integrado en la placa.

**Conector ATX Panel del sistema:**

El conector `J2` contiene los pines de encendido, reset y GND:

* Pin 6 del botón de encendido.
  * Pulsación corta: Enciende el PC o genera un apagado ordenado.
  * Pulsación larga: Genera un apagado forzado.
* Pin 7 del botón de reset.
  * Se usa para leer el estado de encendido mediante el pin del botón reset:
    * Alto: encendido
    * Bajo: apagado
* Pin 5 GND.

* El pin `D1` se usa para leer el estado de encendido desde el pin de reset: Alto es encendido, Bajo es apagado. La resistencia `R1` se usa para minimizar la corriente cuando el pin IO se configura accidentalmente como salida.
* El pin `D2` se usa para poner el botón de encendido a nivel bajo para generar una pulsación corta o larga. El transistor `Q1` se usa para un aislamiento seguro entre el ESP8266 y la placa base.

Advertencia: Todos los pines ATX y ESP deben operar a 3V3.

## Descargas

* [Esquemático KiCad .SCH](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/kicad/ESP8266-ESPHome-PC-Power-HomeAssistant.pro)

## Cableado

![Wiring](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Wiring.jpg)

Se puede montar una PCB DIY de breakout en el conector del panel del sistema para conectar el botón de encendido `SW1` y el botón de reinicio `SW2`.

## Estabilidad de WiFi

Hay suficiente espacio en una caja de computadora ATX para montar la placa ESP. Sin embargo, la caja de la computadora está protegida con metal, por lo que la distancia del WiFi a la estación base se reduce. Se recomienda colocar el ESP fuera de la caja de la computadora cuando la conexión WiFi sea inestable o la distancia sea demasiado baja. Un ESP32 puede resultar en una estabilidad de conexión WiFi diferente, pero en general depende del entorno.

PCB ESP8266 montada en la parte trasera de la caja del PC:

![ESP PC mount](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ESPMount.jpg)

## Actualizaciones de software

El firmware de la aplicación ESPHome se puede actualizar vía conexión USB (puerto serial virtual) o por WiFi OTA (actualización Over The Air).

La actualización del firmware vía WiFi se habilita configurando `ota` en el archivo .yaml. Esto requiere una conexión WiFi entre el computador anfitrión y el ESP. La actualización OTA no funciona cuando el inicio de sesión del ESP a la estación base WiFi falla debido a credenciales WiFi incorrectas. En este caso, se requiere una actualización por serial o vía fallback `ap` como está configurado en el archivo .yaml.

## ESPHome

La aplicación ESPHome consta de dos archivos Yaml. Un archivo de configuración y un segundo `secrets.yaml` para almacenar contraseñas.

Documentación:

* [ESPHome GPIO Switch](https://esphome.io/components/switch/gpio.html)
* [ESPHome Binary Sensor](https://esphome.io/components/binary_sensor/gpio.html)

### Configuración del proyecto

Configure los siguientes archivos:
- [pc-power.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/pc-power.yaml): Configure `platform` y `board`.
- [secrets.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/secrets.yaml): Configure el SSID y las contraseñas de WiFi.

Por favor, consulte la [documentación de ESPHome](https://esphome.io/components/esphome.html) para más información sobre la configuración YAML de ESPHome.


### Programar ESP8266 o ESP32

Conecte el cable USB a la placa ESP8266 o ESP32 y ejecute los siguientes comandos. (Los ejemplos se probaron en Ubuntu). Para más información, consulte [ESPHome.io](https://esphome.io/guides/getting_started_command_line.html).

```bash
# Clone this repository
$ git clone git@github.com:Erriez/ESPHomePCPowerControlHomeAssistant.git

# Install Python3 virtualenv
$ sudo apt install python3-virtualenv

# Create virtualenv
$ virtualenv venv

# Activate virtualenv
$ source venv/bin/activate

# Install ESPHome
$ pip install esphome

# Optional: Install platformio updates
$ platformio platform update
$ platformio upgrade

# Optional: Add user permission serial port
$ sudo usermod -a -G dialout <USERNAME>
$ sudo reboot now

# Check ESPHome installation
$ esphome --help

# Optional: Compile program without upload
$ esphome compile pc-power.yaml

# Upload program to ESP8266 or ESP32
$ esphome run pc-power.yaml

# Select serial port or WiFi to upload application

# Check logs
$ esphome logs pc-power.yaml
```

## Configuración de Home Assistant

Esta sección describe la configuración de Home Assistant.

### Registrar dispositivo ESP

* `Configuración | Integraciones: Añadir Integración: ESPHome`
* Seleccione el nombre de host o la dirección IP del dispositivo ESP.
* Ingrese la contraseña configurada en `secrets.yml` | `esphome_api_password`.

### Homeassistant | Editar Panel | Editor de Configuración RAW

Agregue la integración de energía del PC a un panel mediante edición RAW:

```yaml
title: Home
views:
  - title: PC
    path: pc
    badges: []
    cards:
      - type: button
        entity: switch.pc_power_toggle
        show_name: true
      - type: button
        tap_action:
          action: none
        entity: binary_sensor.pc_power_state
        hold_action:
          action: none
      - type: button
        tap_action:
          action: toggle
        entity: switch.pc_hard_power_off
        icon_height: 40px
        show_state: false
        show_name: true
        show_icon: true
```

## Historial de versiones

¡Reinicie Home Assistant y listo para usar!

### Actualización 11 de octubre de 2024

El formato del archivo YAML de ESPHome cambió con [ESPHome versión 2024.6.0](https://esphome.io/changelog/2024.6.0.html#). El formato antiguo genera errores como:

```
$ esphome compile ESPHomePCPowerControlHomeAssistant/pc-power.yaml
INFO ESPHome 2024.9.2
INFO Reading configuration ESPHomePCPowerControlHomeAssistant/pc-power.yaml...
Failed config

ota.unknown: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:27]

  'ota' requires a 'platform' key but it was not specified.

and:

Failed config

switch.gpio: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:30]

  Pin 4 is used in multiple places.
```

En este caso, actualice al nuevo formato de archivo en este proyecto.

### Actualización 13 de febrero de 2022

* El tiempo del pin del botón controlado mediante scripts de Homeassistant no era estable. El control del pin de alimentación se ha trasladado al firmware ESP, que genera un tiempo mucho más preciso.
* Renombrados los siguientes nombres:
  * Renombrar `switch.pc_power_button` a `switch.pc_power_toggle`.
  * Renombrar `switch.pc_power_button_long_press` a `switch.pc_hard_power_off`.
  * Renombrar `switch.pc_power_sense` a `switch.pc_power_state`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---