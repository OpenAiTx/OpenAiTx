# RemoteVideoCam

Remote Video Cam es una aplicación de código abierto para Android que permite a dos dispositivos transmitir video y audio de alta calidad entre sí a través de una conexión local. Ya sea que la uses como monitor para bebés, una cámara de seguridad casera o un walkie-talkie, RemoteVideoCam ofrece una solución segura, offline y sin necesidad de acceso a internet ni servidores externos.

## ✨ Características

- **Configuración Cero**: Los dispositivos se descubren y conectan automáticamente.
- **Conexión Robusta**: Negocia automáticamente el mejor método de conexión disponible:
  - **Red Local (LAN)**: Usa tu red Wi-Fi existente.
  - **Wi-Fi Aware / Wi-Fi Direct**: Conecta dispositivos directamente sin punto de acceso (offline).
- **Seguro y Privado**: Sin servidores externos. Sin nube. Los flujos de video y audio nunca salen de tu entorno local.
- **Interfaz Moderna**: Construida con **Jetpack Compose** y **Material 3**, ofreciendo una interfaz hermosa, responsiva e intuitiva con colores dinámicos.
- **Dos Modos**:
  - **Modo Cámara**: Actúa como el transmisor.
  - **Modo Pantalla**: Muestra la transmisión del otro dispositivo.
    - *Incluye opción "Espejo" para voltear el video horizontalmente.*
  - *Nota: Ambos dispositivos pueden estar en Modo Pantalla para verse entre sí (bidireccional).*
- **Soporte de Audio**: Escucha lo que sucede en el otro extremo.

## ⚠️ Nota Importante

**No es un Dispositivo Médico**: Aunque RemoteVideoCam puede ser útil para monitoreo (por ejemplo, como monitor para bebés), **no** es un dispositivo médico certificado. 
- Las transmisiones de video pueden congelarse debido a interferencias en la red.
- Siempre ten un método de monitoreo de respaldo.
- **Consejo**: Coloca un objeto en movimiento (como un reloj con segundero) en el encuadre para verificar fácilmente que el video está en vivo.

## 🛠️ Tecnología

- **Lenguaje**: Kotlin
- **Framework UI**: Jetpack Compose (Material 3)
- **Video/Audio**: WebRTC (Negociación local)
- **Visión por Computadora**: OpenCV (usado para tareas específicas de procesamiento de imagen)
- **Arquitectura**: MVVM con flujos de datos reactivos (RxJava/RxAndroid)

## 📥 distinct

[<img src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png"
     alt="Get it on F-Droid"
     height="80">](https://f-droid.org/packages/org.avmedia.remotevideocam/)
[<img src="https://play.google.com/intl/en_us/badges/images/generic/en-play-badge.png"
     alt="Consíguelo en Google Play"
     height="80">](https://play.google.com/store/apps/details?id=org.avmedia.remotevideocam)

## 🤝 Contribuyendo

¡Se aceptan contribuciones! Si eres desarrollador y quieres ayudar a mejorar RemoteVideoCam, no dudes en bifurcar el repositorio y enviar una solicitud de extracción.

Para cambios importantes o preguntas, por favor contacta al mantenedor en `izivkov@gmail.com`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---