# Panel Web de Gestión de Servidor Minecraft

**[Versión en Chino (中文版本)](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/README_CN.md)**

Un panel web de gestión de servidor Minecraft **ligero** con interfaz moderna y funciones completas de administración de servidor.

**Servidores actualmente compatibles:**
- ✅ Servidor Minecraft Bedrock
- Servidor Minecraft Java

## 🚀 Características

### 🌍 Descarga del Servidor Minecraft
- **Descarga del Servidor** Soporte para descargar versiones específicas del servidor directamente desde la página de gestión
- **Cambio de Versión del Servidor** Soporte para cambiar la versión del servidor con un solo clic

### 🎮 Control del Servidor
- **Inicio/Detención/Reinicio con un solo clic** del servidor Minecraft Bedrock
- **Monitoreo de Estado en Tiempo Real** Muestra el estado de ejecución del servidor

### ⚙️ Gestión de Configuración
- **Soporte para todas las opciones principales de configuración**:
  - Nombre y descripción del servidor
  - Modo de juego (Supervivencia/Creativo/Aventura)
  - Configuración de dificultad (Pacífico/Fácil/Normal/Difícil)
  - Número máximo de jugadores
  - Configuración del puerto del servidor
  - Alternar trucos y lista blanca
- **Gestión del Archivo de Configuración del Servidor** Mantiene automáticamente el archivo `server.properties`

### 👥 Gestión de Lista Blanca
- **Añadir/Eliminar Jugadores** Gestiona la lista de jugadores permitidos para unirse al servidor
- **Gestión del Archivo de Lista Blanca** Mantiene automáticamente el archivo `allowlist.json`

### 🛡️ Gestión de Permisos
- **Sistema de Permisos de Tres Niveles**:
  - **Visitante** - Permisos básicos de juego
  - **Miembro** - Permisos estándar de jugador
  - **Operador** - Permisos administrativos completos
- **Configuración de Permisos de Jugadores** Asigna niveles de permiso a jugadores específicos
- **Gestión de Archivos de Permisos** Mantiene automáticamente el archivo `permissions.json`

### 🌍 Gestión de Mundos
- **Carga de Archivos de Mundo** Soporte para formatos `.zip` y `.mcworld` con extracción automática
- **Cambio de Mundo** Activación con un clic de diferentes mundos
- **Eliminación de Mundo** Eliminación segura de archivos de mundo no deseados
- **Identificación del Mundo Actual** Visualización clara del mundo activo actualmente

### 🌍 Gestión de Paquetes de Recursos
- **Carga de Archivos de Recursos** Soporte para formatos `.zip` y `.mcpack`
- **Activación de Recursos** Activación con un clic de diferentes paquetes de recursos
- **Eliminación de Recursos** Eliminación segura de paquetes de recursos no deseados

### 📋 Registros del Servidor
- **Visualización de Registros en Tiempo Real** Monitoriza los registros del servidor Minecraft en tiempo real a través de la interfaz web
- **Auto-desplazamiento** Opción para desplazarse automáticamente a las últimas entradas del registro

### 💻 Ejecución de Comandos
- **Entrada Directa de Comandos** Ejecuta comandos del servidor Minecraft directamente desde la interfaz web
- **Historial de Comandos** Ver y reutilizar comandos ejecutados previamente
- **Comandos Rápidos** Acceso a comandos usados frecuentemente mediante botones de acceso rápido categorizados

### 🔐 Autenticación y Seguridad
- **Sistema de Inicio de Sesión** Acceso seguro al panel de gestión con autenticación por contraseña
- **Gestión de Sesiones** Manejo automático de sesiones con autenticación segura basada en tokens
- **Control de Acceso** Protege las funciones de gestión del servidor contra accesos no autorizados



## 📋 Requisitos del Sistema

### Entorno del Servidor
- **Sistema Operativo**: Windows 10+ o Ubuntu 18.04+ (Linux)
- **Memoria**: Al menos 2GB de RAM
- **Almacenamiento**: Al menos 10GB de espacio disponible
- **Red**: Puertos abiertos 8080 (panel de gestión) y 19132 (servidor Minecraft)

## 🛠️ Guía de Instalación

### Inicio Rápido (Recomendado)
1. **Descargar la Versión Precompilada**:
   - Descargue la versión adecuada para su sistema operativo desde la página de [Releases](https://github.com/ckfanzhe/bedrock-easy-server/releases)
   - `minecraft-server-manager-windows.exe` para Windows
   - `minecraft-server-manager-linux` para Linux

2. **Ejecutar la Aplicación**:

   ```bash
   # For Linux
   chmod +x minecraft-server-manager-linux
   ./minecraft-server-manager-linux
   
   # For Windows
   minecraft-server-manager-windows.exe
   ```

### Despliegue con Docker

1. **Usando Docker directamente (Recomendado)**:
   ```bash
   # Create data directory for persistent storage
   mkdir -p data
   
   # Run the container using the published image
   docker run -d \
     --name minecraft-easyserver \
     -p 8080:8080 \
     -p 19132:19132/udp \
     -p 19133:19133/udp \
     -v ./data:/data/bedrock-server \
     -v ./config:/data/config \
     ifanzhe/minecraft-easyserver:latest
   ```
2. **Uso de Docker Compose**:

   ```bash
   # Create docker-compose.yml file
   cat > docker-compose.yml << EOF
   version: '3.8'
   services:
     minecraft-server-manager:
       image: ifanzhe/minecraft-easyserver:latest
       container_name: minecraft-easyserver
       ports:
         - "8080:8080"
         - "19132:19132/udp"
         - "19133:19133/udp"
       volumes:
         - ./data:/data/bedrock-server
         - ./config:/data/config
       environment:
         - TZ=Asia/Shanghai
       restart: unless-stopped
       healthcheck:
         test: ["CMD", "curl", "-f", "http://localhost:8080"]
         interval: 30s
         timeout: 10s
         retries: 3
   EOF
   
   # Start with Docker Compose
   docker-compose up -d
   ```

3. **Acceder a la aplicación**:
   - Abra el navegador y visite: `http://localhost:8080`
   - Los datos del servidor se guardarán en el directorio `./data`

### Construir desde el código fuente (Para desarrolladores)

1. **Requisitos previos**:
   - Go 1.21 o superior
   - Node.js 16+ y npm (para la compilación del frontend)

2. **Clonar repositorio**:
   ```bash
   git clone https://github.com/ckfanzhe/bedrock-easy-server.git
   cd minecraft-easy-server
   ```
3. **Compilar Todas las Plataformas (Recomendado)**:**

   ```bash
   chmod +x build.sh
   ./build.sh
   ```
   Este script hará:
   - Instalar dependencias del frontend (`npm install`)
   - Compilar el frontend de Vue.js (`npm run build`)
   - Copiar los archivos compilados al directorio embed
   - Compilar binarios Go para todas las plataformas con el frontend embebido

4. **Pasos Manuales de Compilación** (si prefieres paso a paso):
   ```bash
   # Build frontend first
   cd minecraft-easyserver-web
   npm install
   npm run build
   cd ..
   
   # Copy frontend build output
   rm -rf web/*
   cp -r minecraft-easyserver-web/dist/* web/
   
   # Build Go binary
   go build -o minecraft-server-manager
   ```

**Nota**: El proceso de compilación ahora incluye la compilación del frontend usando webpack, que agrupa todos los componentes Vue.js, estilos y recursos en archivos optimizados que luego se incrustan en el binario de Go para un despliegue en un solo archivo.

## 🚀 Guía de Uso

### Iniciar el Panel de Gestión

1. **Ejecutar la Aplicación**:
   ```bash
   # For Linux
   ./minecraft-server-manager-linux
   
   # For Windows double-click to run
   minecraft-server-manager-windows.exe
   ```

2. **Interfaz de Gestión de Acceso**:
   - Abra el navegador y visite: `http://localhost:8080`
   - El panel de gestión se cargará automáticamente

## 🔥 Configuración del Cortafuegos

### Cortafuegos de Windows
En algunos sistemas, cuando desee conectarse al servidor usando un cliente que se ejecuta en la misma máquina donde está el servidor, necesitará eximir al cliente de Minecraft de las restricciones de loopback UWP:

```powershell
CheckNetIsolation.exe LoopbackExempt -a -p=S-1-15-2-1958404141-86561845-1752920682-3514627264-368642714-62675701-733520436
```
Asegúrese de que los siguientes puertos estén abiertos en el firewall:  
- **8080**: Puerto de acceso al panel de administración  
- **19132**: Puerto predeterminado del servidor Minecraft Bedrock  
- **19133**: Puerto IPv6 del servidor Minecraft Bedrock  

## 📝 Información Adicional  

### Funciones Planeadas TODO  
- ✅ Soporte para importación de mods mcpackage con un solo clic  
- ✅ Soporte para sistema operativo Linux  
- ✅ Visualización en tiempo real del registro del servidor Bedrock  
- ✅ Ejecución directa de comandos al servidor Bedrock a través de la interfaz web  
- 🔄 Monitoreo del estado en línea de los jugadores  
- ✅ Monitoreo del rendimiento del servidor  
- 🔄 Funcionalidad automática de respaldo del mundo  
- ✅ Soporte de interfaz multilenguaje  
- 🔄 Soporte para servidor Java - Soporte para servidores Minecraft Java Edition  
- ✅ Soporte Docker - Soporte para despliegue en contenedores  

## 🤝 Contribuir  

¡Bienvenido a enviar reportes de problemas, sugerencias de funciones y contribuciones de código!  

### Configuración del entorno de desarrollo  
1. Haz un fork del repositorio del proyecto  
2. Crea una rama para la característica: `git checkout -b feature/new-feature`  
3. Realiza un commit de los cambios: `git commit -am 'Add new feature'`  
4. Empuja la rama: `git push origin feature/new-feature`  
5. Crea una Pull Request  

### Estándares de código  
- Usa el formato estándar de código de Go  
- Añade comentarios y documentación apropiados  
- Asegúrate de que el código pase las pruebas  
- Sigue los patrones arquitectónicos del proyecto  

## 📄 Licencia  

Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.


## 🙏 Agradecimientos

- [Gin Web Framework](https://gin-gonic.com/) - Framework web Go de alto rendimiento
- [Tailwind CSS](https://tailwindcss.com/) - Framework CSS basado en utilidades
- [Font Awesome](https://fontawesome.com/) - Biblioteca de iconos
- [Minecraft Bedrock](https://www.minecraft.net/) - Servidor de juego

## 👀 Vista previa del panel de gestión
> Capturas de pantalla de algunas funciones, se invita a experimentar más funciones en persona.

![Login Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-login.png)
![Dashboard Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-dashboard.png)
![Performance Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-performance.png)
![Server Download Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-version.png)
![Resource Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-resource.png)
![Worlds Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-worlds.png)
![Cmd Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-cmd.png)
![Server Config Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-server-config.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---