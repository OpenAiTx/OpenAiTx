# Panel de Alarma Hornet Nest para ESPHome

Este repositorio alberga los archivos de configuración de firmware **ESPHome** oficialmente soportados para el **Panel de Alarma Hornet Nest**, desarrollado por **Technology Automation Consulting LLC**. El Panel de Alarma Hornet Nest es una solución IoT escalable y personalizable diseñada para integrar sistemas de alarma cableados tradicionales en tu hogar inteligente usando **Home Assistant**. Con 42 zonas optoaisladas, 3 salidas de relé y opciones flexibles de alimentación PoE o 12V, está diseñado para flexibilidad y fiabilidad.

<div style="display: flex; justify-content: space-between;">
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/3D_AlarmPanel_2024-10-06.png" alt="Modelo 3D" width="400"/>
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/hornet-nest-operational.jpg" alt="Instalado" width="400"/>
</div>

## Inicio Rápido

Comienza rápidamente adoptando y flasheando tu Panel de Alarma Hornet Nest con el último firmware ESPHome:

1. Conecta un cable ethernet alimentado por PoE al Panel de Alarma Hornet Nest.
2. Abre el **Panel de Control ESPHome** y localiza el dispositivo "hornet-nest-XXXXXX" (donde XXXXXX es un identificador hexadecimal único).
3. Haz clic en la opción **Adoptar** en el dispositivo.
4. Se abrirá el diálogo **Adoptar Dispositivo**. Puedes renombrar tu dispositivo si lo deseas y luego hacer clic nuevamente en la opción **Adoptar**.
5. Se abrirá el diálogo **Configuración Creada** que indicará que se debe instalar una nueva configuración en el dispositivo, haz clic en el botón **Instalar**.
6. ESPHome comenzará a compilar el nuevo firmware. Cuando aparezca la línea **"INFO Sucessfully uploaded program."**, haz clic en **DETENER** para cerrar la ventana.
4. Descubre el Panel de Alarma Hornet Nest en **Home Assistant** > **Configuración** > **Dispositivos y Servicios**.
5. Haz clic en **Configurar** en el nuevo dispositivo para añadirlo a Home Assistant.

## Cambios y Notas de Lanzamiento

Consulta **Releases** para notas de lanzamiento y firmware precompilado descargable.

## Diseñado para ESPHome

El **Panel de Alarma Hornet Nest** usa el microcontrolador **wESP32 PoE** y es totalmente compatible con el firmware **ESPHome**. Es un producto de código abierto, diseñado para una fácil personalización por parte del usuario, ideal para usuarios de Home Assistant que necesitan una solución de alarma escalable y flexible. Los **archivos de configuración YAML de ESPHome** incluidos están completamente documentados, permitiendo a usuarios avanzados personalizar, construir y actualizar su dispositivo con unas pocas modificaciones simples.

## Funciona con Home Assistant

Estas configuraciones de firmware **ESPHome** permiten una configuración simple y plug-and-play dentro de **Home Assistant**. La integración es local, rápida y completamente personalizable, brindando a los usuarios control total sobre su sistema de seguridad doméstico.
<img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/esphome-integrated.png" alt="Dispositivo ESPHome" width="600">

## En Este Repositorio

Este repositorio contiene **plantillas completas de configuración de firmware YAML** para el **Panel de Alarma Hornet Nest** en el nivel superior. Estas plantillas están listas para ser importadas usando el **Panel de Control ESPHome**, donde pueden ser personalizadas y desplegadas.

## Manual de Usuario
Para instrucciones detalladas, por favor consulte el manual de usuario oficial [aquí.](https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/hnap-user-manual.pdf)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---