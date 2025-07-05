# TeamSpeak 6 Server - Beta Release README

¡Bienvenido a la versión Beta del Servidor de TeamSpeak 6! Estamos emocionados de tenerte a bordo mientras exploras la próxima generación de TeamSpeak. Este documento te guiará para comenzar y destacará detalles importantes sobre la Beta actual.

Dado que esta es una versión Beta, algunas funciones aún están en desarrollo y puedes encontrar errores. Tu retroalimentación es importante y nos ayudará a crear una versión final más estable y completa.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;Acerca de TeamSpeak</h2>

Probado y comprobado durante casi 25 años, tenemos una solución que se adapta a las necesidades de todos. TeamSpeak ofrece la comunicación de voz ideal para juegos, educación y formación, comunicación interna empresarial, y para mantenerte en contacto con amigos y familiares. Nuestro enfoque principal es ofrecer una solución fácil de usar, con altos estándares de seguridad, excelente calidad de voz, y bajo consumo de sistema y ancho de banda.

## ℹ️ Estado Beta & Problemas Conocidos
**Esta es una versión beta. El objetivo principal es recopilar comentarios diversos e identificar posibles problemas antes del lanzamiento de la versión estable.**

**Archivos del Servidor Autohospedado:** El software de servidor dedicado para TeamSpeak 6 sigue en desarrollo activo y aún no está completamente terminado en cuanto a funciones. Estamos comprometidos a ofrecer la experiencia completa de TS6 para servidores autohospedados.

**Inestabilidad de Funciones:** Algunas de las nuevas funciones pueden ser inestables o estar sujetas a cambios mientras continuamos perfeccionándolas.

**La Retroalimentación es Esencial:** Tu experiencia es invaluable y tu opinión es crucial para nosotros. Por favor, reporta cualquier problema o comparte tus sugerencias en nuestro [Foro de la Comunidad](https://community.teamspeak.com/c/teamspeak-6-server/45) o directamente aquí en [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Limitaciones:** Ten en cuenta que **las licencias del Servidor TeamSpeak 3 no son compatibles** con los Servidores TeamSpeak 6, y actualmente, **no hay una ruta de migración disponible entre las dos versiones**.

**Licencia de Vista Previa:** En respuesta a tus comentarios, el servidor ahora viene con una **licencia de vista previa temporal** de 32 slots para ofrecer mayor flexibilidad durante el período de evaluación. Ten en cuenta que esta licencia **solo es válida por dos meses**.

Además, **aún no es posible obtener o actualizar a una licencia más grande para TeamSpeak 6**.

Realmente apreciamos tu paciencia y comprensión mientras seguimos trabajando en soluciones para apoyar mejor tus necesidades en el futuro.

## 👇 Comenzando con TS6
Para comenzar con el Cliente TeamSpeak 6, por favor visita nuestra página de [Descargas](https://teamspeak.com/en/downloads/).

Para información sobre autohospedaje, consulta la breve guía a continuación. Para las últimas actualizaciones, anuncios y para interactuar con la comunidad de TeamSpeak, asegúrate de visitar nuestro [Foro de la Comunidad](https://community.teamspeak.com/) y síguenos en [Twitter](https://x.com/teamspeak).

¿No quieres autohospedar, o simplemente necesitas una forma más sencilla de comenzar con TeamSpeak 6? Puedes alquilar servidores confiables y Oficiales de TeamSpeak 6 directamente con nosotros en [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Configuración
### Puedes configurar tu servidor de tres maneras principales:

1. **Argumentos de Línea de Comandos:** Pasa opciones directamente al iniciar el servidor (por ejemplo, ./tsserver --default-voice-port 9987). Esto es útil para cambios temporales o para scripting.

2. **Variables de Entorno:** Define variables de entorno antes de iniciar el servidor. Esto es útil para Docker o cuando quieres evitar saturar la línea de comandos.

3. **Archivo de Configuración YAML:** Para una configuración persistente, se recomienda encarecidamente usar un archivo tsserver.yaml. Puedes generar un archivo de configuración predeterminado usando el parámetro --write-config-file.

Las configuraciones clave que puedes controlar incluyen puertos de red (voz, transferencia de archivos), conexiones de base de datos (compatible con SQLite y MariaDB), enlaces de IP y opciones de registro.

Para una lista completa de opciones disponibles, ejecuta el servidor con el parámetro `--help` o consulta el [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Ejecutar el Servidor con Binarios
Si no usas Docker, puedes ejecutar el servidor directamente en tu sistema operativo.

<h2><img width="22" src="/icons/linux.svg">&nbsp;En Linux:</h2>

Haz que el binario del servidor sea ejecutable:
```sh
chmod +x tsserver
```

Ejecuta el servidor desde tu terminal, asegurándote de aceptar la licencia:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;En Windows:</h2>

Abre el Símbolo del sistema o PowerShell y navega hasta el directorio donde extrajiste los archivos del servidor.

Ejecuta el ejecutable del servidor, asegurándote de aceptar la licencia:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Ejecutar el Servidor con Docker (Recomendado):</h2>
Docker es la manera más sencilla de ejecutar el servidor de TeamSpeak 6 en un entorno aislado y manejable.

### 1. Comando simple de docker run:

Para empezar rápidamente, puedes usar el comando docker run.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Usando docker-compose.yaml (para configuraciones persistentes):
Esta es la mejor práctica para un servidor que planeas mantener en funcionamiento. Crea un archivo docker-compose.yaml:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Puerto de Voz
      - "30033:30033/tcp" # Transferencia de Archivos
      # - "10080:10080/tcp" # Web Query
    environment:
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volúmenes:
  teamspeak-data:
```

## 🔗 Enlaces útiles
[Sitio web oficial](https://teamspeak.com/en/)<br>
[Foro de la comunidad](https://community.teamspeak.com)<br>
[Problemas en GitHub](https://github.com/teamspeak/teamspeak6-server/issues)<br>

¡Tu participación y comentarios nos ayudarán a dar forma al futuro de TeamSpeak! 💙<br>
¡Gracias por ser parte del programa Beta de TeamSpeak 6 y contribuir a su progreso! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---