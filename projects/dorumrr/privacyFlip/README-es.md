# PrivacyFlip

**Control automático de privacidad con bloqueo/desbloqueo para dispositivos Android 🔐📱✨**

**PrivacyFlip** gestiona automáticamente las funciones de privacidad de tu dispositivo Android según el estado de bloqueo/desbloqueo. Cuando bloqueas tu dispositivo, puede desactivar **Wi-Fi**, **Bluetooth**, **datos móviles**, servicios de **ubicación**, **NFC** e incluso los **sensores de cámara/micrófono**. Cuando lo desbloqueas, restaura inteligentemente las funciones que deseas volver a activar.

**Funciona con Shizuku o Root** - ¡Elige tu método de privilegios preferido!

<div>
  <a href="https://f-droid.org/en/packages/io.github.dorumrr.privacyflip/" target="_blank" rel="noopener"><img height="50" src="https://f-droid.org/badge/get-it-on.png"></a> 
  <a href="https://apt.izzysoft.de/fdroid/index/apk/io.github.dorumrr.privacyflip" target="_blank" rel="noopener"><img height="50" src="https://gitlab.com/IzzyOnDroid/repo/-/raw/master/assets/IzzyOnDroid.png"></a> 
  <a href="https://www.buymeacoffee.com/ossdev"><img height="50" src="https://cdn.buymeacoffee.com/buttons/v2/arial-yellow.png" /></a>
</div>

## 📸 Capturas de pantalla

<div align="center">
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
</div>

## 🔒 Funciones

### **Control automático de privacidad**
- **Detección de bloqueo**: Desactiva instantáneamente funciones de privacidad cuando la pantalla se bloquea
- **Detección de desbloqueo**: Espera la autenticación adecuada (no solo encendido de pantalla)
- **Restauración inteligente**: Rehabilitación configurable de funciones al desbloquear

### **Funciones de privacidad controladas**
- 📶 **Wi-Fi** - Desactivar/activar conectividad inalámbrica
- 📱 **Bluetooth** - Controlar radio Bluetooth
- 📡 **Datos móviles** - Gestionar conexión de datos celulares
- 📍 **Servicios de ubicación** - Controlar GPS y rastreo de ubicación
- 📳 **NFC** - Controlar sensor de comunicación de campo cercano
- 📷 **Cámara** - Desactivar/activar privacidad del sensor de cámara (Android 12+)
- 🎤 **Micrófono** - Desactivar/activar privacidad del sensor de micrófono (Android 12+)
- ✈️ **Modo avión** - Activar modo avión al bloquear (optativo, desactiva todas las radios)
- 🔋 **Ahorro de batería** - Activar modo ahorro de batería al bloquear (optativo)

### **Funciones avanzadas**
- **Opciones de Desactivación Inteligente**:
  - **"Solo si no está en uso/no conectado"** - No desactivar WiFi, Bluetooth o Ubicación si están en uso activo
  - **"Solo si no está ya habilitado"** - Evitar reinicios de conexión no reactivando funciones que ya están activas
  - **"Solo si no está configurado manualmente"** - Respetar modos de protección habilitados manualmente al desbloquear

- **Exenciones de Aplicaciones** - Excluir aplicaciones específicas de acciones de privacidad cuando están en primer plano
- **Reintento Automático NFC Samsung** - Función opcional para combatir la anulación NFC del marco de pagos Samsung (para Galaxy S, Note, serie Z)
- **Servicio de Accesibilidad** - Soporte experimental para bloqueo instantáneo con botón lateral/de encendido (opcional, requiere permiso de Accesibilidad)
- **Detección Avanzada** - Detección de conexión Bluetooth en múltiples niveles para evitar desconexiones no deseadas de auriculares

### **Temporización Personalizable**
- **Retraso de Bloqueo**: 0-60 segundos (detallado), 2 minutos o 5 minutos antes de activar las acciones de privacidad
- **Retraso de Desbloqueo**: 0-60 segundos (detallado), 2 minutos o 5 minutos antes de restaurar funciones
- **Modo Instantáneo**: Establecer retrasos en 0 para acción inmediata
- **Nota**: Cámara y micrófono ignoran los retrasos personalizados y se activan inmediatamente, debido a limitaciones de Android

## 📱 Requisitos

**Mínimo:** Android 7.0+ (nivel API 24)
**Funciones de Cámara/Micrófono:** Android 12+ (nivel API 31)

**Elija su método de privilegios:**

### **Opción 1: Shizuku** (¡No requiere root!)
- Aplicación **Shizuku** instalada y en ejecución
- **Privilegios ADB** mediante depuración USB o ADB inalámbrico
- **No requiere root** - funciona con permisos a nivel ADB

### **Opción 2: Acceso Root** (Recomendado para dispositivos rooteados)
- **Acceso root** vía Magisk, SuperSU o similar
- **Mejor rendimiento** con privilegios UID 0

### **Opción 3: Dhizuku** (Método Device Owner)
- Estado de **Device Owner** o **Profile Owner**
- **No requiere root**, no necesita ADB tras configuración inicial
- **Privilegios persistentes** - sobreviven reinicios
- **Ideal para**: dispositivos empresariales, perfiles de trabajo, configuraciones enfocadas en privacidad

### **Opción 4: Sui** (Lo mejor de ambos mundos)
- Dispositivo rooteado con Magisk instalado
- Módulo **Sui Magisk** instalado  
- **Mejor experiencia de usuario** - sin solicitudes de permisos, inicio automático  

### **Prioridad de Detección de Privilegios**  
1. **Sui** - Módulo Magisk que proporciona API Shizuku con root (mejor UX)  
2. **Root** - Acceso root tradicional vía Magisk/SuperSU  
3. **Dhizuku** - Método Device Owner (sin root ni ADB tras la configuración)  
4. **Shizuku** - Privilegios ADB vía la app Shizuku  

## 🤝 Contribuyendo  

Ayuda a mejorar esta app. ¡Ninguna contribución es demasiado pequeña!  

### Cómo Contribuir  

1. **Haz un fork del repositorio**  
2. **Crea una rama para la función** (`git checkout -b feature/amazing-feature`)  
3. **Realiza tus cambios**  
4. **Confirma tus cambios** (`git commit -m 'Añadir función asombrosa'`)  
5. **Sube la rama** (`git push origin feature/amazing-feature`)  
6. **Abre un Pull Request**  

¡Todas las contribuciones son **valiosas** y **agradecidas**!  

## 📄 Licencia  

Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.  

## 💖 Apoya el Desarrollo  

PrivacyFlip protege tu privacidad. ¡Puedes proteger su futuro!  

[![DONAR](https://img.shields.io/badge/DONATE-FFD700?style=for-the-badge&logoColor=white)](https://buymeacoffee.com/ossdev)  

---  

*Noches largas para días más brillantes*  

Creado por Doru Moraru  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-17

---