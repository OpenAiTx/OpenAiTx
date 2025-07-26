
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# OpenSpot Music 🎶

<p align="center">
 <img width="100" alt="OpenSpot Logo" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">Tu puerta de entrada a música ilimitada - Streaming de música multiplataforma</h3>

<p align="center">
  <strong>Escucha y descarga música de alta calidad gratis en todos tus dispositivos, sin anuncios y sin necesidad de iniciar sesión.</strong>
</p>

<p align="center">
  <a href="https://github.com/BlackHatDevX/openspot-music-app/stargazers">
    <img src="https://img.shields.io/github/stars/BlackHatDevX/openspot-music-app?style=for-the-badge&color=ffd700" alt="Stars">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/network/members">
    <img src="https://img.shields.io/github/forks/BlackHatDevX/openspot-music-app?style=for-the-badge&color=84b4a3" alt="Forks">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/issues">
    <img src="https://img.shields.io/github/issues/BlackHatDevX/openspot-music-app?style=for-the-badge&color=f38ba8" alt="Issues">
  </a>
</p>

---

## 📱📺 Dos increíbles aplicaciones, un solo repositorio

Este repositorio contiene **dos aplicaciones completas de streaming de música**:

### 🎵 **OpenSpot Mobile** (React Native + Expo)
- **Plataformas**: Android, iOS
- **Ubicación**: `openspot-music-mobile/`
- **Características**: Experiencia móvil nativa con descargas offline, reproducción en segundo plano y estado persistente

### 🖥️ **OpenSpot Desktop** (Electron + React)
- **Plataformas**: macOS, Windows, Linux
- **Ubicación**: `openspot-music-electron/`
- **Características**: Interfaz optimizada para escritorio con controles globales de audio, gestión de ventanas y almacenamiento local

---

### 📢 Únete a nuestro canal de Telegram

Mantente al día con **lanzamientos de versiones** y **anuncios importantes** en el canal oficial de Openspot en Telegram.

[![Únete a nosotros en Telegram](https://img.shields.io/badge/Join%20Us%20on-Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/openspot_music)


---


## 📱 Aplicación móvil (React Native + Expo)

### Capturas de pantalla

![WhatsApp Image 2025-07-26 at 00 52 14](https://github.com/user-attachments/assets/cc7b262d-ccfe-4899-bd86-56d0e3e90be7)



### Enlaces de descarga

- **Android APK**: [OpenSpot-2.0.3-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.3/OpenSpot-2.0.3-release.apk)
- **iOS**: Se necesita mantenedor

### Configuración de desarrollo

```bash
cd openspot-music-app
cd openspot-music-mobile/
npm install
npx expo start
```
### Compilar para producción


```bash
cd openspot-music-app/

# Development Build
eas build --platform android --profile development

# Preview Build (APK)
eas build --platform android --profile preview

# Production Build
eas build --platform android --profile production
```

---

## 🖥️ Aplicación de Escritorio (Electron + React)

### Capturas de pantalla

![Aplicación macOS](https://github.com/user-attachments/assets/1cb18d3f-4986-4eb2-9cd2-1b606fbf31db)

### Enlaces de descarga

- **macOS DMG**: [OpenSpot.Music-2.0.2-arm64.zip](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64-mac.zip)
- Ejecuta esto si tienes problemas de aplicación dañada después de la instalación.
  ```bash
  xattr -rd com.apple.quarantine /Applications/OpenSpot\ Music.app
- **Windows EXE**: ¡Próximamente!
- **Linux DEB**: ¡Próximamente!

### Configuración de desarrollo

```bash
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```

### Compilar para Producción

```bash
cd openspot-music-app/
cd openspot-music-electron/
npm run build
npm run electron-pack
```

---

## ✨ Características clave (Ambas aplicaciones)

- **🎵 Streaming de alta calidad**: Escucha tus pistas favoritas con la mejor calidad posible
- **💾 Descargas sin conexión**: Guarda música directamente en tu dispositivo para escuchar sin conexión
- **❤️ Me gusta y colecciona**: Construye tu colección personal marcando canciones como favoritas
- **🔄 Reproducción en segundo plano**: Sigue escuchando mientras usas otras apps
- **🚫 No requiere inicio de sesión**: ¡Entra directamente! No necesitas cuentas ni registros
- **💾 Estado persistente**: Tus canciones favoritas y pistas reproducidas recientemente se guardan entre reinicios de la app
- **🎨 Interfaz hermosa**: Interfaz limpia y moderna diseñada para cada plataforma
- **🆓 Totalmente gratis y sin anuncios**: Disfruta de música sin interrupciones, sin costo ni publicidad

---


## 💻 Stack Tecnológico

### Aplicación Móvil
- **Framework**: [React Native](https://reactnative.dev/) con [Expo](https://expo.dev/)
- **Navegación**: [Expo Router](https://expo.github.io/router/)
- **Audio**: [Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **Compilación**: [EAS Build](https://docs.expo.dev/build/introduction/)
- **Obtención de ubicación**: [IPinfo API](https://github.com/ipinfo)

### Aplicación de Escritorio
- **Framework**: [Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **Interfaz de usuario**: [Material-UI](https://mui.com/)
- **Estado**: React Context + useReducer
- **Almacenamiento**: [electron-store](https://github.com/sindresorhus/electron-store)
- **Compilación**: [electron-builder](https://www.electron.build/)

### Compartido
- **Lenguaje**: [TypeScript](https://www.typescriptlang.org/)
- **Gestor de paquetes**: npm/yarn

---

### Configuración de entorno

Este proyecto requiere una sola variable de entorno para funcionar correctamente.

- Se proporciona una plantilla en el archivo [`.env.template`](https://github.com/BlackHatDevX/openspot-music-app/blob/main/openspot-mobile/.env.template).
- El **valor** requerido para completar tu archivo `.env` se comparte en el **mensaje fijado** de nuestro **canal oficial de Telegram**: [@openspot_music](https://t.me/openspot_music).


---

## 🚀 Inicio rápido

### Para desarrollo móvil
```bash

git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-mobile/
npm install
npx expo start
```

### Para el desarrollo de escritorio
```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```

---

## 🤝 Contribuciones

¡Damos la bienvenida a contribuciones para ambas aplicaciones!
## 📞 Comunidad y Soporte

- **Telegram**: [Openspot Music](https://telegram.dog/Openspot_Music)
- **Problemas**: [GitHub Issues](https://github.com/BlackHatDevX/openspot-music-app/issues)

## 👤 Autor y Contacto

**Jash Gro**

- **LinkedIn**: [https://linkedin.com/in/jash-gro/](https://linkedin.com/in/jash-gro/)
- **Portafolio**: [https://bit.ly/jashgro](https://bit.ly/jashgro)
- **Telegram**: [https://telegram.dog/deveIoper_x](https://telegram.dog/deveIoper_x)
- **GitHub**: [https://github.com/BlackHatDevX](https://github.com/BlackHatDevX)

## 📄 Licencia

Este proyecto es de código abierto y está licenciado bajo la Licencia MIT. Consulta el archivo `LICENSE` para más información.

---

<p align="center">
  <strong>⭐ ¡Si te gusta este proyecto, por favor dale una estrella! ⭐</strong>
  <br />
  <em>Tu apoyo nos ayuda a seguir desarrollando increíbles aplicaciones de música gratuitas para todos.</em>
</p> 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---