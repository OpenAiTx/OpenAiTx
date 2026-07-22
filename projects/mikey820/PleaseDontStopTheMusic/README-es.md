# PleaseDontStopTheMusic

Un tweak de iOS que permite que múltiples fuentes de audio se reproduzcan simultáneamente al prevenir interrupciones en la sesión de audio.

## ❤️ Apoya el Proyecto

Si encuentras este proyecto útil y deseas apoyar el desarrollo, se agradecen las donaciones.

### Litecoin
**Red:** Litecoin (LTC)  
**Dirección:** `ltc1qaz2zqcc5usl4ueg7w5m8kqcmvrfqurpn6wqyfa`

Por favor, verifica dos veces que estés enviando en la red **Litecoin**.

¡Gracias por tu apoyo!

---

## Visión General

**PleaseDontStopTheMusic** es un tweak que se engancha en `AVAudioSession` de iOS para habilitar la mezcla de audio. Esto permite que tu audio actualmente en reproducción (música, podcasts, etc.) continúe sin interrupciones cuando otras apps solicitan reproducir audio, en lugar del comportamiento habitual donde el sistema pausa tu audio y reproduce sólo la nueva fuente.

## Características

- **Reproducción Continua** - Tu audio sigue reproduciéndose incluso cuando otras apps quieren reproducir sonido.
- **Mezcla de Audio** - Múltiples fuentes de audio se combinan usando la opción `MixWithOthers`.
- **Soporte Universal** - Funciona con instalaciones rootful, rootless y con jailbreak.
- **Ligero** - Sobrecarga mínima, implementación basada puramente en hooks.

## Cómo Funciona

El tweak intercepta las llamadas de configuración de `AVAudioSession` y, **solo cuando otra app ya está reproduciendo audio** (`isOtherAudioPlaying`), aplica la opción `AVAudioSessionCategoryOptionMixWithOthers` a la sesión de la app entrante. Esto indica a iOS que mezcle el nuevo audio con la reproducción existente en lugar de interrumpirla.

Es crucial que **no** fuerza la mezcla en la app que es la fuente principal de música. Una app que opta por `MixWithOthers` es tratada por iOS como una fuente *secundaria* y pierde los controles de transporte "Ahora Reproduciendo" en la pantalla de bloqueo / Centro de Control. Al dejar intacta la primera app/principal, esa app mantiene el control completo de saltar y pausar en la pantalla de bloqueo, mientras que las apps posteriores (TikTok, juegos, etc.) se ven forzadas a mezclarse discretamente sin interrumpirla.

### Métodos Enganchados

- `setCategory:error:`
- `setCategory:mode:options:error:`
- `setCategory:mode:routeSharingPolicy:options:error:` *(la API moderna usada por TikTok y la mayoría de apps actuales)*
- `setCategory:withOptions:error:`
- `setActive:error:`
- `setActive:withOptions:error:`

Las sesiones `SoloAmbient` (que no pueden mezclarse) se cambian transparentemente a `Ambient` cuando otra aplicación está reproduciendo, por lo que ya no silenciarán tu música.

---

## Guía de Instalación

Elige el método a continuación que se aplique a la configuración de tu dispositivo.

### Método 1: Sin Jailbreak (Sideloading)
Usa este método si tu dispositivo no está jailbreak. Necesitarás inyectar el tweak `.dylib` de los releases en el archivo IPA de la aplicación objetivo.

1. **Preparar:** Asegúrate de tener el archivo `PleaseDontStopTheMusic.dylib`.
2. **Seleccionar Herramienta:** Usa una herramienta de sideloading como **Esign**, **Feather** o **Sideloadly**.
3. **Inyectar:** Importa el IPA de la aplicación objetivo (la app en la que quieres escuchar media, por ejemplo, si quiero escuchar Spotify mientras juego Roblox, lo inyectaría en Roblox) en la herramienta, selecciona el `.dylib` para inyección y firma la app.
4. **Instalar:** Instala el IPA modificado resultante en tu dispositivo.

### Método 2: Jailbreak
Usa este método si tu dispositivo tiene jailbreak.

1. **Agregar Repo:** Abre https://repo.chariz.com/ y presiona el botón para agregarlo a tu gestor de paquetes preferido (esto debería ser un repo por defecto, pero si no lo tienes, agrégalo).
2. **Instalar:** Navega hasta el repo en tu lista para obtenerlo, o busca "PleaseDontStopTheMusic".
3. **Finalizar:** Realiza un **respring** de tu dispositivo para aplicar los hooks.

---

Si tienes problemas o preguntas, ¡no dudes en enviarme un dm por Discord! dc: fuseegelee

```bash
make all
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---