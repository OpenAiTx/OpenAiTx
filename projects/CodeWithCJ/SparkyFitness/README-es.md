<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Una alternativa autoalojada y centrada en la privacidad a MyFitnessPal. Realiza un seguimiento de la nutrición, el ejercicio, las métricas corporales y los datos de salud manteniendo el control total de tus datos.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness es una plataforma de seguimiento de fitness autoalojada compuesta por:

- Un servidor backend (API + almacenamiento de datos)
- Una interfaz web
- Aplicaciones móviles nativas para iOS y Android

Almacena y gestiona datos de salud en la infraestructura que controlas, sin depender de servicios de terceros.

## Características principales

- Seguimiento de nutrición, ejercicio, hidratación, sueño, ayuno, estado de ánimo y mediciones corporales
- Establecimiento de objetivos y registros diarios
- Gráficas interactivas e informes a largo plazo
- Múltiples perfiles de usuario y acceso familiar
- Temas claro y oscuro
- OIDC, TOTP, Passkey, MFA, etc.

## Integraciones de salud y dispositivos

SparkyFitness puede sincronizar datos de múltiples plataformas de salud y fitness:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (probado parcialmente)
- **Hevy** (no probado)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (probado parcialmente)

Las integraciones sincronizan automáticamente datos de actividad como pasos, entrenamientos y sueño, junto con métricas de salud como peso y medidas corporales, en tu servidor SparkyFitness.

## Funciones opcionales de IA (Beta)

SparkyAI proporciona una interfaz conversacional para registrar datos y revisar el progreso.

- Registra alimentos, ejercicios, estadísticas corporales y pasos a través del chat
- Sube imágenes de alimentos para registro automático de comidas
- Conserva el historial de conversaciones para seguimientos

Nota: Las funciones de IA están actualmente en beta.

## Inicio Rápido (Servidor)

Ponga en marcha un servidor SparkyFitness en minutos usando Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 Tutorial en video

[![Ver el video](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Rápido tutorial de 2 minutos mostrando cómo instalar SparkyFitness (rastreador de fitness autoalojado).


## Documentación

Para guías completas de instalación, opciones de configuración y documentación de desarrollo, por favor visita nuestro [Sitio de Documentación](https://codewithcj.github.io/SparkyFitness/).

### Enlaces rápidos

- **[Guía de instalación](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Despliegue y configuraciones
- **[Descripción de funciones](https://codewithcj.github.io/SparkyFitness/features)** - Documentación completa de funciones
- **[Flujo de desarrollo](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Guía para desarrolladores y proceso de contribución
- **[Info de la app iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** y **[Info de la app Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### ¿Necesitas ayuda?

- Publica en los issues/discusiones de Github.
- Para una respuesta más rápida y ayuda de otros miembros de la comunidad **[Únete a nuestro Discord](https://discord.gg/vcnMT5cPEA)**

## Historial de estrellas

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefiere el modo oscuro)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefiere el modo claro)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Gráfica de historial de estrellas" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Traducciones

**[Traducciones Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Estado de traducción" />
</a>

## Actividad del repositorio

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Imagen de análisis Repobeats")

## Contribuidores

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Problemas conocidos / Funciones Beta ⚠️

SparkyFitness está en desarrollo activo.
Pueden ocurrir cambios importantes entre versiones.

- No se recomienda la actualización automática de contenedores
- Revise siempre las notas de la versión antes de actualizar

Las siguientes funciones están actualmente en beta y pueden no haber sido probadas exhaustivamente. Espere posibles errores o funcionalidad incompleta:

- Chatbot de IA
- Acceso para Familia y Amigos
- Documentación de la API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---