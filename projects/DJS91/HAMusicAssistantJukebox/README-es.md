# <img src="https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/logo.png" width="25" height="25"> Integración Music Assistant Jukebox (Obsoleta)

## Aviso: esta integración ya no se mantiene activamente.

Music Assistant ahora tiene un Plugin que debe usarse en su lugar y ofrece muchas de las mismas funciones.  
Vea https://beta.music-assistant.io/plugins/party-mode/

---

Una integración de Home Assistant que proporciona un sistema de solicitud de canciones basado en la web que se integra con Music Assistant para crear una experiencia de jukebox interactiva para los invitados.

![Interfaz Jukebox](https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/showcase.avifs)

## Funciones
- Búsqueda de canciones en tiempo real en todos los proveedores de Music Assistant conectados  
- Diseño minimalista y responsive con visualización de la portada del álbum  
- Consulta lo que se está reproduciendo y lo siguiente en tiempo real.  
- No se requiere inicio de sesión para los invitados, solo comparte la URL  
- Gestión de la cola mediante entidades de Home Assistant  
- Cola automática de una lista de reproducción predeterminada para la fiesta cuando la cola de solicitudes está vacía  
- Control de la frecuencia de las colas (limita el spam en la cola)  
- Control de acceso a través de Home Assistant  
- Revocación/creación automática de tokens de acceso por seguridad

Dirígete a [Discusiones / Solicitudes de Funciones](https://github.com/DJS91/HAMusicAssistantJukebox/discussions) si quieres solicitar nuevas funciones o para discusión general.

## Requisitos previos

Antes de instalar esta integración, asegúrate de tener:  
- Instancia de Home Assistant con la integración [Music Assistant](https://github.com/music-assistant/hass-music-assistant)  
- Complemento Music Assistant Server en Home Assistant (Instancias HA/MA alojadas por separado pueden no funcionar)  
- Un proveedor de música compatible configurado en Music Assistant (por ejemplo, Spotify, Apple Music, etc.)  
- Entidad de reproductor multimedia configurada en Home Assistant

## Instalación

### HACS (Recomendado)  
[![Abre tu instancia de Home Assistant y abre un repositorio dentro de la Tienda Comunitaria de Home Assistant.](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=DJS91&repository=HAMusicAssistantJukebox&category=Integration)

o
1. Añade este repositorio a HACS como un repositorio personalizado  
   - HACS > Menú > Repositorios personalizados  
   - URL: `https://github.com/DJS91/HAMusicAssistantJukebox`  
   - Categoría: Integración  
2. Haz clic en Instalar  
3. Reinicia Home Assistant  

### Instalación Manual  
1. Descarga la última versión  
2. Copia la carpeta `custom_components/music_assistant_jukebox` en la carpeta `custom_components` de tu Home Assistant  
3. Reinicia Home Assistant  

## Configuración  

1. Ve a Configuración > Dispositivos y Servicios  
2. Haz clic en "Agregar Integración"  
3. Busca "Music Assistant Jukebox"  
4. Selecciona tu instancia de Music Assistant y la entidad del reproductor multimedia  
5. Ve a Configuración > Automatizaciones y Escenas > + Crear Automatización  
6. Selecciona "Controlador Music Assistant Jukebox" de la lista.  
7. Introduce la misma entidad del reproductor multimedia del Paso 4 e ingresa el nombre de tu lista de reproducción predeterminada de Music Assistant y haz clic en Guardar.  

## Uso  
Enciende el jukebox usando el interruptor "JukeBox: Permitir acceso".  

Accede al jukebox a través del nuevo Panel Lateral "Music Assistant Jukebox" O  

Escanea la entidad del Código QR que prefieras O  

Accede directamente a la interfaz del jukebox en:
```
http://homeassistant:8123/local/jukebox/jukebox.html
```

## Entidades
La integración añade estas entidades a Home Assistant:

### Interruptores
- `switch.jukebox_queue`: Activar/desactivar la cola de canciones (No se requiere control manual. Gestionado por automatización.)
- `switch.jukebox_allow_access`: Activar/desactivar el acceso a la interfaz del jukebox
- `switch.music_assistant_jukebox_jukebox_play_music_on_start`: Activar/desactivar si la lista de reproducción predeterminada se reproduce automáticamente al encender el jukebox.
  
### Número
- `number.jukebox_queue_length`: Muestra la longitud actual de la cola (No se requiere ajuste manual, gestionado por automatización)
- `number.music_assistant_jukebox_jukebox_queuing_delay`: Establece un retraso entre las solicitudes de canciones para invitados (segundos) (0 = desactivado)
  
### Sensor
- `music_assistant_jukebox_external_qr_code`: Código QR de acceso a la interfaz externa del Jukebox para compartir fácilmente en paneles con usuarios que no estén en tu red
- `music_assistant_jukebox_internal_qr_code`: Código QR de acceso a la interfaz interna del Jukebox para compartir fácilmente con usuarios en tu red

## Plano de Automatización

La integración incluye un plano de automatización que gestiona:
- Seguimiento de la longitud de la cola
- Reproducción de lista predeterminada como respaldo
- Control de acceso
- Control del reproductor multimedia

Para usar el plano:
1. Ve a Configuración > Automatizaciones y Escenas
2. Haz clic en "+ Crear Automatización"
3. Selecciona "Controlador de Jukebox de Music Assistant"
4. Configura:
   - Reproductor Multimedia: Selecciona tu reproductor multimedia de Music Assistant
   - Lista Predeterminada: Ingresa el nombre de tu lista de reproducción de respaldo

## Créditos
Un gran agradecimiento a:
- [OddPirate](https://github.com/TheOddPirate) por sus contribuciones para convertir esto en una integración.

- [PilaScat](https://github.com/PilaScat) por sus contribuciones en limpieza, pulido y mejoras de la interfaz.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---