# 🌐 OnionHoster v2.2

> **La herramienta definitiva para alojar servicios ocultos Tor** - ¡Despliega tus proyectos web en la dark web en minutos!

[![Versión](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Plataforma](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Licencia](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

---

## 🚀 ¿Qué es OnionHoster?

OnionHoster es un potente script bash multiplataforma que transforma cualquier proyecto web en un servicio oculto Tor con un solo comando. Ya sea que alojes una app Next.js, un backend Flask o un sitio estático, OnionHoster gestiona toda la compleja configuración de Tor automáticamente.

### ✨ ¿Por qué elegir OnionHoster?

- **🔧 Cero configuración** - Funciona al instante con cualquier proyecto web
- **🌍 Multiplataforma** - Soporta Linux, macOS y las principales distribuciones
- **⚡ Configuración con un clic** - De cero a servicio oculto en menos de 2 minutos
- **🔄 Actualizaciones automáticas** - Verificador de actualizaciones integrado para mantenerte al día
- **💾 Copia de seguridad y restauración** - Nunca pierdas tus direcciones onion
- **🎯 Interfaz profesional** - Interfaz coloreada y hermosa con menús intuitivos

---
## Vista previa

https://github.com/user-attachments/assets/b8fe44e8-2b1f-4fdc-bb52-7c4a5ee2c67e


# ⚠️ Advertencia: OnionHoster NO es una herramienta mágica de anonimato — sigue las mejores prácticas o arriesga la desanonimización

**Endurecimiento del sistema**

* Ejecuta el servicio dentro de una VM o contenedor para aislamiento.
* Mantén el sistema operativo y los paquetes actualizados.
* Deshabilita servicios/puertos innecesarios para que solo el tráfico Tor entre/salga.

**Prácticas de OpSec**

* No uses la misma máquina para cuentas o actividades personales.
* Evita exponer metadatos identificativos (nombres de archivos, encabezados, mensajes de error).
* Ten cuidado con los registros — qué registras, cuánto tiempo los conservas y si filtran información.

**Higiene de Red**

* No vincules tu servicio oculto con tu identidad o dominio en la red clara.
* Usa un firewall para asegurar que no haya fugas accidentales fuera de Tor.
* Considera proxies inversos para un aislamiento adicional.

**Pruebas y Monitoreo**

* Usa torsocks o el Navegador Tor para verificar que tu servicio solo sea accesible vía su dirección `.onion`.
* Realiza pruebas regulares para detectar fugas (por ejemplo, si tu app intenta obtener datos de la red clara).

**Conciencia del Caso de Uso**

* Para uso hobby/pruebas/educativo: lo anterior suele ser suficiente.
* Para anonimato real y de alto riesgo (periodistas, denunciantes, activistas): requiere una seguridad operacional más profunda y modelado de amenazas, ya que un solo error puede desanonimizarte.


---
## 🎯 Perfecto Para

- **Desarrolladores** que quieran probar sus apps en Tor
- **Defensores de la Privacidad** que alojan servicios anónimos
- **Investigadores** que estudian tecnologías de la web oscura
- **Empresas** que requieren soluciones de alojamiento anónimo
- **Aficionados** que exploran la red Tor

---

## 🚀 Inicio Rápido

### Requisitos Previos
- Acceso root/sudo
- Conexión a Internet
- Cualquier proyecto web (HTML, Next.js, Flask, etc.)

### Instalación y Uso

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```
**¡Eso es todo!** 🎉

Obtendrás el proyecto completo OnionHoster que incluye:
- El script principal `onionhoster.sh`
- Una plantilla profesional `index.html` para alojar
- Toda la documentación y ejemplos

El script automáticamente:
- Detecta tu sistema operativo
- Instala todas las dependencias necesarias (Tor, Apache, etc.)
- Configura los servicios Tor
- Te presenta un menú intuitivo

---

## 🎮 Resumen de Funcionalidades

### 🌐 Opciones de Alojamiento
- **HTML Estático** - Aloja cualquier archivo `index.html`
- **Redirección de Puertos** - Redirige a cualquier puerto de aplicación local
- **Apps Dinámicas** - Soporta Next.js, Flask, Node.js y más

### 🛠️ Herramientas de Gestión
- **Control de Servicios** - Inicia, detiene y administra tu servicio oculto
- **Backup y Restauración** - Realiza copias seguras y restaura tus dominios onion
- **Actualización de URL** - Genera nuevas direcciones onion cuando sea necesario
- **Monitoreo de Estado** - Revisa la salud y estado del servicio

### 🔄 Actualizaciones Inteligentes
- **Auto-Detección** - Encuentra automáticamente la última versión
- **Actualización con Un Clic** - Actualiza con una sola opción en el menú
- **Actualizaciones Seguras** - Sin riesgo de perder tu configuración

---

## 📱 Sistemas Operativos Soportados

| SO | Gestor de Paquetes | Estado |
|----|----------------|---------|

| **Ubuntu/Debian** | `apt-get` | ✅ Soporte Completo |
| **CentOS/RHEL** | `yum` | ✅ Soporte Completo |
| **Fedora** | `dnf` | ✅ Soporte Completo |
| **Arch Linux** | `pacman` | ✅ Soporte Completo |
| **macOS** | `brew` | ✅ Soporte Completo |

---

## 🎯 Casos de Uso

### 🏠 Proyectos Personales
- Hospeda tu portafolio de forma anónima
- Prueba aplicaciones web de forma privada
- Comparte contenido sin revelar tu identidad

### 🏢 Aplicaciones Empresariales
- Portales de soporte al cliente anónimos
- Sistemas de comunicación interna seguros
- Sitios web empresariales enfocados en la privacidad

### 🔬 Investigación y Desarrollo
- Investigación de tecnología en la web oscura
- Desarrollo de herramientas de privacidad
- Pruebas de servicios anónimos

---

## 📖 Uso Detallado

### Opciones del Menú Principal

1. **Hospedar index.html** - Servir un archivo HTML estático
2. **Redirigir al Puerto de Aplicación** - Proxy a cualquier servicio local
3. **Respaldar dominio tor** - Guardar tu configuración onion
4. **Restaurar dominio tor** - Restaurar desde respaldo
5. **Ver dominio tor actual** - Ver tu dirección onion activa
6. **Actualizar dominio tor** - Generar una nueva dirección onion
7. **Buscar actualizaciones** - Actualizar a la última versión
8. **Estado del Servidor Web** - Monitorear la salud del servicio
9. **Acerca de OnionHoster** - Información de versión y características

### Ejemplo de flujo de trabajo

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Configuración Avanzada

### Reenvío de Puertos Personalizado
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Gestión de Copias de Seguridad
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ Características de Seguridad

- **Configuración Automática de Tor** - Configuraciones seguras desde el inicio
- **Permisos Correctos de Archivos** - Propiedad y acceso seguro a archivos
- **Aislamiento del Servicio** - Cada servicio oculto funciona de manera independiente
- **Sin Registro de Datos** - Tus actividades permanecen privadas

---

## 🚨 Notas Importantes

- **Acceso Root Requerido** - Los servicios Tor necesitan configuración a nivel del sistema
- **Red Tor** - Tu servicio será accesible vía Tor Browser
- **Direcciones Onion** - Cada servicio obtiene una dirección `.onion` única
- **Respaldo Regular** - Las direcciones Onion cambian al actualizar

---

## 🤝 Contribuyendo

¡Aceptamos contribuciones! Ya sea:
- 🐛 Reportes de errores
- 💡 Solicitudes de funciones
- 📝 Mejoras en la documentación
- 🔧 Contribuciones de código

**Comienza por:**
1. Hacer un fork del repositorio
2. Crear una rama para la función
3. Realizar tus cambios
4. Enviar un pull request

---

## 📄 Licencia

Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.

---

## 🙏 Agradecimientos

- **Proyecto Tor** - Por la increíble red de anonimato  
- **Comunidad de Código Abierto** - Por las mejoras continuas  
- **Usuarios y Colaboradores** - Por sus comentarios y sugerencias  

---

## 🔗 Enlaces

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)  
- **Issues**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)  
- **Discusiones**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)  

---

## ⭐ Da una estrella a este proyecto

Si OnionHoster te ayuda, ¡por favor dale una estrella! Nos motiva a seguir mejorando y ayuda a otros a descubrir esta herramienta.  

---

**¿Listo para ser anónimo?** 🕵️‍♂️  

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```
*¡Tu viaje hacia el alojamiento anónimo comienza ahora!* 🚀



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-18

---