## Introducción

**Grupo de QQ para comunicación: 528735636**

Componente de Home Assistant

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg?style=for-the-badge)](https://github.com/hacs/integration)

Este componente de Home Assistant permite que Tmall Genie, Xiao Ai y Xiaodu se conecten con los dispositivos de la plataforma HomeAssistant, controlando dispositivos y consultando el estado reportado de los mismos.

Nota: Este plugin solo se encarga de controlar y enviar el estado de los dispositivos; la adición de dispositivos debe configurarse en la plataforma [HassLife](https://hass.blear.cn).

## Instalación

### 1. Instalar el plugin

##### Método 1: instalación vía hacs【Recomendado！】
>> Barra lateral HACS -> Integraciones -> buscar hasslife y hacer clic en descargar

##### Método 2: descarga manual [Descargar plugin](https://gitee.com/blear/HassLife)
>> Descargar la carpeta `hasslife`, guardarla en el directorio `<homeassistant_configuración>/custom_components/`, si no existe el directorio `custom_components` créelo, luego reinicie HomeAssistant.
- ¿Dónde está el directorio de configuración de homeassistant?

>>**Usuarios Windows:** `%APPDATA%\.homeassistant`

>>**Usuarios Linux:** Puede encontrar la carpeta `.homeassistant` ejecutando el comando `locate .homeassistant/configuration.yaml`; la carpeta `.homeassistant` encontrada es el directorio de configuración.

>>**Usuarios Docker en Synology:** Acceda a Docker - Imágenes - homeassistant - Configuración avanzada - Volúmenes, la ruta correspondiente a `/config` es el directorio de configuración.


### 2. Configurar el plugin
##### Método 1: configuración vía interfaz UI de integración
>> **Haga clic en Configuración en la barra lateral de HomeAssistant -> Integraciones -> botón Añadir integración en la esquina inferior derecha -> buscar hasslife y hacer clic -> ingresar la cuenta y contraseña registrada de hasslife y enviar. El plugin tarda un tiempo en iniciar por primera vez, por favor sea paciente.**

Si encuentra que esta integración no soporta configuración vía UI, y si vino desde el enlace en la página de Home Assistant, asegúrese de estar ejecutando la versión más reciente de Home Assistant.
Puede agregar la configuración de la cuenta manualmente y luego reiniciar HomeAssistant.

## Pasos para usar:
	1. Registre una cuenta en HassLife abriendo https://hass.blear.cn, cree una cuenta y inicie sesión
	2. Instale el plugin: después de instalar, reinicie HomeAssistant, luego vaya a la página de añadir integración, agregue la integración HassLife e inicie sesión con la cuenta HassLife.
	3. Continúa volviendo a la página del sitio web HassLife, si la configuración de tu complemento está bien, la página del centro personal mostrará el estado del complemento como `en línea`
	4. Haz clic en el menú de gestión de dispositivos, haz clic en el botón verde `Agregar dispositivo Homeassistant` a la derecha, selecciona los dispositivos que deseas agregar y envía
	5. En la lista de dispositivos, selecciona el dispositivo que deseas configurar, haz clic en `Configurar` y elige según sea necesario la plataforma de altavoz inteligente que deseas conectar, además de configurar el tipo de dispositivo y el nombre de control por voz
	6. Ve a la página de vinculación de habilidades de la plataforma correspondiente, vincula tu cuenta HassLife, y si todo va bien, podrás ver el dispositivo agregado.

## Ejemplo de configuración de Tmall Genie
* Instala la última versión de la APP `Tmall Genie`
* Usa el navegador del móvil para acceder a [HassLife https://hass.blear.cn](https://hass.blear.cn) e inicia sesión en la cuenta hasslife
* En la página del centro personal, haz clic para acceder a la `entrada de habilidades de Tmall Genie`
* Haz clic en `Vincular cuenta de plataforma`
* Inicia sesión en la cuenta HassLife
* Confirma la autorización, vuelve a la pestaña del asistente y podrás ver los dispositivos añadidos

## Ejemplo de configuración de Xiao Ai
* Entra en la página de lista de dispositivos HassLife, añade los dispositivos necesarios y configura el tipo de dispositivo y el nombre correspondiente
* Instala la última versión de la APP `Mi Home`
* Abre la APP `Mi Home`
* Haz clic en la pestaña `Yo`
* Haz clic en `Dispositivos de otras plataformas`
* Haz clic en el `botón de añadir en la esquina superior derecha`
* Busca `HassLife` y haz clic
* Haz clic en `Vincular cuenta`
* Inicia sesión en la cuenta HassLife
* Confirma la autorización y sincroniza los dispositivos

## Ejemplo de configuración de Xiao Du
* Entra en la página de lista de dispositivos HassLife, añade los dispositivos necesarios y configura el tipo de dispositivo y el nombre correspondiente
* Instala la última versión de la APP `Xiao Du`
* Abre la APP `Xiao Du`
* Haz clic en el `signo más en la esquina superior derecha`
* Haz clic en `Agregar dispositivo`
* Busca `HassLife` y haz clic
* Inicia sesión en la cuenta HassLife
* Confirma la autorización y sincroniza los dispositivos

## Dispositivos y atributos soportados por Tmall Genie

Actualmente los tipos de dispositivos soportados son: luz, interruptor, tendedero, cortina, televisor, calentador de agua, ventilador, sensor, aire acondicionado, selector binario.

    Los dispositivos que soportan estado de encendido/apagado incluyen: luz, interruptor, tendedero, cortina, televisor, calentador de agua, ventilador, sensor, aire acondicionado, selector binario.
    
    Soporte de ajuste de la luz: color, brillo, temperatura de color
    
    Aire acondicionado soporta cambio de modo: refrigeración, calefacción, ventilación, deshumidificación, automático, ajuste de temperatura. Velocidad del viento soportada: baja, media, alta, automática
    
    Soporte para tendedero: control de barra de secado, control de encendido/apagado
    
    Soporte para cortinas: abrir y cerrar cortinas
    
    Soporte para ventilador: control de energía (encender/apagar ventilador), control de velocidad (1-100 niveles (velocidad en porcentaje), nivel máximo, nivel alto, nivel medio-bajo, nivel medio-alto, nivel alto, nivel súper fuerte, nivel brisa, modo automático), rotación izquierda/derecha / oscilación / balanceo



## Dispositivos y atributos soportados por Xiao Ai

Actualmente los tipos de dispositivos soportados son: luz, interruptor, cortina, ventilador, aire acondicionado.

    El estado de encendido/apagado del dispositivo es soportado por: luz, interruptor, cortina, ventilador, aire acondicionado.
    
    La luz soporta ajuste: color, brillo, temperatura de color
    
    El aire acondicionado soporta cambio de modo: refrigeración, calefacción, ventilación, deshumidificación, automático, ajuste de temperatura. Velocidad del viento soportada: baja, media, alta, automática
    
    La cortina soporta: abrir y cerrar cortinas
    
    El ventilador soporta: control de energía (encender/apagar ventilador), control de velocidad (1-100 niveles (velocidad en porcentaje)), rotación izquierda/derecha / oscilación / balanceo
	

	
## Dispositivos y atributos soportados por el altavoz Xiaodu

    El estado de encendido/apagado del dispositivo es soportado por: luz, interruptor, cortina, ventilador, aire acondicionado.
    
    La luz soporta ajuste: encendido/apagado
    
    El aire acondicionado soporta cambio de modo: refrigeración, calefacción, ventilación, deshumidificación, automático, ajuste de temperatura. Velocidad del viento soportada: baja, media, alta, automática
    
    La cortina soporta: abrir y cerrar cortinas
    
    El ventilador soporta: control de energía (encender/apagar ventilador), control de velocidad (1-10 niveles)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---