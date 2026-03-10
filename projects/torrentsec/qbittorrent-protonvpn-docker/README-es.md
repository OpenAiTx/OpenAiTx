# 🏰️ qBittorrent + ProtonVPN (WireGuard) en Docker (macOS)

**Ejecute qBittorrent de forma segura en Docker con ProtonVPN (WireGuard) usando Gluetun, asegurando un enrutamiento completo por VPN y reenvío de puertos automático para mejorar el rendimiento del torrenting.**

&#x20;

---

## 📌 Tabla de Contenidos

1. [Resumen](#overview)
2. [Características](#features)
3. [Requisitos Previos](#prerequisites)
4. [Guía de Instalación](#installation-guide)
   - [Instalar Docker](#install-docker)
   - [Clonar el Repositorio](#clone-the-repository)
   - [Configurar el ](#set-up-the-env-file)[archivo `.env`](#set-up-the-env-file)
   - [Configurar la Autenticación](#configure-authentication)
   - [Iniciar los Contenedores](#start-the-containers)
5. [Acceso a la Interfaz Web de qBittorrent](#accessing-qbittorrent-web-ui)
6. [Seguridad y Mejores Prácticas](#security--best-practices)
7. [Solución de Problemas](#troubleshooting)
8. [Licencia](#license)
9. [Contribuciones](#contributing)
10. [Soporte y Comentarios](#support--feedback)

---

## 🔹 Resumen

Esta configuración garantiza que **qBittorrent solo se conecte a través de ProtonVPN (WireGuard)** usando **Gluetun**, evitando fugas y mejorando la seguridad.\
También **automatiza el reenvío de puertos** para mejores velocidades de torrent y **ejecuta todo dentro de Docker** para facilitar la gestión.

---

## ✅ Características

- **🔒 Torrenting forzado por VPN** – Sin fugas, todo el tráfico se ejecuta **dentro** de la VPN.
- **⚡ Reenvío automático de puertos** – Asegura mejores velocidades y conexiones mejoradas con pares.
- **🌐 Acceso local a la interfaz web** – Controle fácilmente los torrents via [`http://localhost:8080`](http://localhost:8080).
- **📺 Totalmente Contenerizado** – Usa Docker para una implementación, actualizaciones y aislamiento fáciles.  
- **🔄 Configuración Resiliente** – Los contenedores **se reinician automáticamente** si algo falla.  
- Usa **almacenamiento separado** para torrents incompletos y completos  
- **Actualiza automáticamente los contenedores usando Watchtower** 🛠️  

---  

## 🛠️ Requisitos Previos  

- **Docker Desktop** (macOS/Windows/Linux)  
- **Docker Compose** (incluido con Docker Desktop)  
- **Cuenta ProtonVPN** (se requiere Plus o Visionary para soporte WireGuard)  

---  

## 📂 Guía de Instalación  

### **1️⃣ Instalar Docker**  

Descargue e instale **Docker Desktop** desde [aquí](https://www.docker.com/products/docker-desktop/).\
Asegúrese de que Docker esté **en ejecución** antes de continuar.  

---  

### **2️⃣ Clonar el Repositorio**  

```sh
git clone https://github.com/torrentsec/qbittorrent-protonvpn-docker.git
cd qbittorrent-protonvpn-docker
```

---

### **3️⃣ Configurar el archivo **`.env`**

Este proyecto utiliza un archivo `.env` para almacenar **valores de configuración sensibles** (que Git ignora por seguridad).

#### **Crea tu archivo **`.env`**  

```sh
cp .env.example .env
nano .env
```

#### **Complete las siguientes variables**

```ini
WIREGUARD_PRIVATE_KEY=your_private_key_here
SERVER_COUNTRIES="United Kingdom"
SERVER_CITIES="London"

PUID=1000
PGID=1000
TZ=Europe/London

GLUETUN_USER=your_admin_username
GLUETUN_PASS=your_admin_password

GSP_GTN_API_KEY=your_random_api_key_here
GSP_QBITTORRENT_PORT=your_forwarded_port_here
```

Save and close (`CTRL + X`, then `Y`, then `ENTER`).

---

### **4️⃣ Start the Containers**

```sh
docker-compose up -d
```

🚀 **¡qBittorrent ahora funciona de forma segura a través de ProtonVPN!**

---

## 📚 Accediendo a la interfaz web de qBittorrent

Una vez en funcionamiento, abra:\
📌 [**http://localhost:8080**](http://localhost:8080)\
*(Usuario por defecto: admin, contraseña: consulte la consola para la contraseña temporal)*

Asegúrese de cambiar su contraseña de la interfaz web después del primer inicio de sesión. De lo contrario, la contraseña se generará aleatoriamente tras cada reinicio del contenedor.

---

## 🛡️ Seguridad y mejores prácticas

1. **Mantenga el archivo **`.env`** privado**

   - El archivo `.gitignore` **ya evita que **`.env`** se suba a GitHub.**

2. **Use una contraseña fuerte para la API de Gluetun**

   - **Modifique **`GLUETUN_PASS`** en el archivo **`.env` para evitar accesos no autorizados a la API.

3. **Verifique la conexión VPN antes de descargar torrents**

   - Ejecute `curl ifconfig.me` dentro del contenedor:
     ```sh
     docker exec -it qbittorrent curl ifconfig.me
     ```
   - ✅ **Si la IP coincide con ProtonVPN**, está funcionando.
   - ❌ **Si muestra tu IP real, algo está mal.**

---

## 🛠️ Solución de problemas

### **Verificar si la VPN está activa**

```sh
docker ps
```
Si Gluetun no está en funcionamiento, reinicia todo:


```sh
docker-compose down && docker-compose up -d
```

### **Verificar que qBittorrent esté usando VPN**

```sh
docker exec -it qbittorrent curl ifconfig.me
```

🟢 Si la IP coincide con ProtonVPN, está funcionando.\
🔴 Si muestra tu IP real, hay un problema.

### **Revisar registros para errores**

```sh
docker logs -f gluetun
```

Busca **AUTH\_FAILED** o problemas de conexión.

---

## 💎 Licencia

Este proyecto está licenciado bajo la **Licencia MIT** – consulta el archivo LICENSE para más detalles.

---

## 💪 Contribuciones

¡Las contribuciones son bienvenidas! Si tienes mejoras o comentarios, no dudes en enviar un issue o pull request.

---

## 💬 Soporte y Comentarios

- Si te fue útil, ¡dale una ⭐ estrella en GitHub!
- Los comentarios y sugerencias siempre son bienvenidos.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---