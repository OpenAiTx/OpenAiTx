# 🚀 AndroBuster

<div align="center">
  <img width="2808" height="699" alt="bannerfinal" src="https://github.com/user-attachments/assets/7f74539f-0af6-40d9-bafb-9207afd80af8" />

</div> 

<div align="center">

**🔒 Pentesting Hecho Fácil**  
*Una poderosa herramienta de enumeración de directorios y subdominios construida con Flutter*

[![Download APK](https://img.shields.io/badge/Download-APK-blue?style=for-the-badge&logo=android)](https://github.com/BlackHatDevX/androbuster/releases)
[![GitHub stars](https://img.shields.io/github/stars/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub forks](https://img.shields.io/github/forks/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub issues](https://img.shields.io/github/issues/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster/issues)

</div>

---

## 📖 Resumen

AndroBuster es una **herramienta de seguridad de código abierto** inspirada en GoBuster, que ofrece una interfaz moderna y multiplataforma para la enumeración de directorios y subdominios. Construida con Flutter, ofrece una experiencia de usuario limpia e intuitiva mientras mantiene la potencia y flexibilidad esperadas de herramientas de seguridad profesionales.

### 🎯 ¿Qué Hace Especial a AndroBuster?
- 🚀 **Multiplataforma**: Funciona en Android, iOS y Escritorio
- 🔒 **Enfocado en Seguridad**: Construido específicamente para testers de penetración
- 💻 **Interfaz Moderna**: Hermosa interfaz basada en Flutter
- ⚡ **Alto Rendimiento**: Gestión eficiente de hilos y memoria
- 📱 **Móvil Primero**: Optimizado para pruebas de seguridad móvil

---

## 🖼️ Capturas de Pantalla

<div align="center">

<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 24 AM" src="https://github.com/user-attachments/assets/e12ed93e-876f-408b-9e3d-4a849e8fe2a1" />
<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 34 AM" src="https://github.com/user-attachments/assets/17850561-cef9-46e2-8203-8ba29c223fe7" />
</div>

---



## ✨ Características

### 🗂️ Modo de Enumeración de Directorios
- **Entrada de URL Objetivo**: Manejo limpio de URL con eliminación automática de barra diagonal final
- **Códigos de Estado Negativos**: Filtrar códigos de estado HTTP no deseados (por defecto: 404)
- **Tamaños de Página Negativos**: Excluir respuestas basadas en la longitud del contenido
- **Soporte para Listas de Palabras**: Entrada de texto grande con capacidad de importación de archivos
- **Control de Hilos**: Cantidad configurable de hilos para rendimiento óptimo
- **Configuración de Tiempo de Espera**: Tiempo de espera personalizable para solicitudes en milisegundos

### 🌐 Modo de Enumeración de Subdominios
- **Entrada de Dominio**: Manejo limpio del dominio (no se requiere http/https)
- **Listas de Palabras para Subdominios**: Gestión dedicada de listas para descubrimiento de subdominios
- **Pruebas de Protocolo**: Pruebas automáticas de HTTPS/HTTP como respaldo
- **Validación de Subdominios**: Validación de nombres de subdominios conforme a RFC 1123
- **Filtros Dedicados**: Códigos de estado negativos y tamaños de página separados para subdominios
- **Hilos y Tiempo de Espera**: Configuración independiente del modo de directorios

### 📋 Gestión de Resultados
- **Pestaña Unificada de Resultados**: Visualización de resultados de escaneo de directorios y subdominios
- **Formato de Resultados**: Visualización clara de ruta, código de estado, tamaño y URL
- **Copiar al Portapapeles**: Exportar resultados para análisis externo
- **Limpiar Resultados**: Limpieza sencilla entre escaneos
- **Conteo de Resultados**: Seguimiento separado para resultados de directorios y subdominios

### 📁 Gestión de Archivos
- **Importación de Listas de Palabras**: Soporte para archivos .txt de hasta 50MB
- **Vista Previa Inteligente**: Visualización del contenido considerando el tamaño del archivo
- **Manejo de Archivos Grandes**: Procesamiento eficiente de listas de palabras masivas
- **Soporte de Formato**: Maneja automáticamente comentarios (#) y líneas vacías

### 🚀 Rendimiento y Confiabilidad
- **Ejecución en Segundo Plano**: La aplicación continúa funcionando durante escaneos en segundo plano

- **Optimización de Memoria**: Manejo eficiente de grandes listas de palabras  
- **Manejo de Errores**: Mecanismos de recuperación y retroceso elegante  
- **Multiplataforma**: Construido con Flutter para Android e iOS  

---

## 📱 Instalación

### 📦 Versión de Lanzamiento  
Actualmente, solo están disponibles las versiones APK para Android. Descargue el APK más reciente desde la página de lanzamientos.  

<div align="center">

[![Descargar Última Versión](https://img.shields.io/badge/📥%20Download%20Latest%20Release-blue?style=for-the-badge)](https://github.com/BlackHatDevX/androbuster/releases)

</div>

### 🔧 Construcción desde Código Fuente  
El código fuente ahora es público y está disponible para que todos lo usen, modifiquen y contribuyan.  

---

## 📖 Guía de Uso

### 🗂️ Enumeración de Directorios  
1. Navegue a la pestaña "Dir"  
2. Ingrese la URL objetivo  
3. Configure los códigos de estado negativos y tamaños de página  
4. Pegue o importe su lista de palabras  
5. Establezca el número de hilos y el tiempo de espera  
6. Inicie el escaneo y monitoree el progreso  

### 🌐 Enumeración de Subdominios  
1. Navegue a la pestaña "Subdomain"  
2. Ingrese el dominio objetivo (sin http/https)  
3. Configure filtros específicos para subdominios  
4. Importe o pegue la lista de palabras de subdominios  
5. Ajuste la configuración de hilos y tiempo de espera


6. Comenzar el descubrimiento de subdominios

### 📋 Gestión de Resultados
- Ver todos los resultados en la pestaña "Resultados"
- Copiar resultados al portapapeles para análisis externo
- Borrar resultados entre diferentes escaneos
- Monitorizar el progreso y la finalización del escaneo

---

## ⚙️ Configuración

### ⚡ Número de Hilos
- **Recomendado**: 10-20 hilos para la mayoría de escenarios
- **Advertencia de Hilos Altos**: Alerta al exceder los 20 hilos
- **Consideraciones**: Más hilos pueden activar limitación de tasa

### ⏱️ Configuración de Tiempo de Espera
- **Por defecto**: 5000ms (5 segundos)
- **Ajuste**: Aumentar para redes lentas, disminuir para respuestas rápidas
- **Rango**: Soporta de 1000ms a 30000ms

### 🚫 Filtros Negativos
- **Códigos de Estado**: Lista separada por comas (ej., 404,403,500)
- **Tamaños de Página**: Lista separada por comas (ej., 0,1234,5678)
- **Propósito**: Excluir respuestas no deseadas de los resultados

---

## 🤝 Contribuyendo

¡Este proyecto es **código abierto** y acepta contribuciones! El código fuente ahora es público y está disponible para todos.

<div align="center">

[![Estrella en el Repositorio](https://img.shields.io/badge/⭐%20Star%20Repository-yellow?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)

</div>

### 📋 Cómo Contribuir
1. **⭐ Estrella** el repositorio (¡opcional pero apreciado!)
2. **🍴 Haz fork** del repositorio
3. **🌿 Crea** una rama de características
4. **📤 Envía** una solicitud de extracción

---

## 🙏 Créditos y Reconocimientos

- **🎯 Inspirado por**: [GoBuster](https://github.com/OJ/gobuster) - La herramienta original de enumeración de directorios
- **🛠️ Construido con**: [Flutter](https://flutter.dev/) - El kit de herramientas de UI de Google para construir aplicaciones compiladas nativamente
- **🔒 Enfoque de seguridad**: Diseñado para testers de penetración e investigadores de seguridad
- **🌍 Comunidad**: Gracias a todos los colaboradores y partidarios

---

## 📄 Licencia

Este proyecto es **código abierto** y está disponible bajo la Licencia MIT.

---

## ⚠️ Descargo de responsabilidad

Esta herramienta está diseñada para **pruebas de seguridad autorizadas** y **fines exclusivos de pruebas de penetración**. Los usuarios son responsables de asegurarse de tener la autorización adecuada antes de probar cualquier sistema. Los desarrolladores no se responsabilizan por el uso indebido de esta herramienta.

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---