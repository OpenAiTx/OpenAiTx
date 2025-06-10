# Cheating Daddy

> [!NOTE]  
> Usa la versión más reciente de MacOS y Windows, las versiones antiguas tienen soporte limitado

> [!NOTE]  
> Durante las pruebas no responderá si le preguntas algo, necesitas simular que el entrevistador hace la pregunta, la cual sí responderá

Un asistente de IA en tiempo real que proporciona ayuda contextual durante videollamadas, entrevistas, presentaciones y reuniones utilizando captura de pantalla y análisis de audio.

## Funciones

- **Asistencia IA en Vivo**: Ayuda en tiempo real impulsada por Google Gemini 2.0 Flash Live
- **Captura de Pantalla y Audio**: Analiza lo que ves y escuchas para respuestas contextuales
- **Múltiples Perfiles**: Entrevista, Llamada de Ventas, Reunión de Negocios, Presentación, Negociación
- **Superposición Transparente**: Ventana siempre visible que puede posicionarse en cualquier lugar
- **Modo Click-through**: Haz la ventana transparente a los clics cuando sea necesario
- **Multiplataforma**: Funciona en macOS, Windows y Linux (más o menos, no usar, solo para pruebas por ahora)

## Configuración

1. **Obtén una clave API de Gemini**: Visita [Google AI Studio](https://aistudio.google.com/apikey)
2. **Instala las dependencias**: `npm install`
3. **Ejecuta la aplicación**: `npm start`

## Uso

1. Ingresa tu clave API de Gemini en la ventana principal
2. Elige tu perfil e idioma en la configuración
3. Haz clic en "Iniciar Sesión" para comenzar
4. Posiciona la ventana usando los atajos de teclado
5. La IA proporcionará asistencia en tiempo real basada en tu pantalla y en lo que pregunte el entrevistador

## Atajos de Teclado

- **Mover Ventana**: `Ctrl/Cmd + Flechas` - Mueve la ventana
- **Click-through**: `Ctrl/Cmd + M` - Alterna eventos del mouse
- **Cerrar/Volver**: `Ctrl/Cmd + \` - Cierra la ventana o regresa
- **Enviar Mensaje**: `Enter` - Envía texto a la IA

## Captura de Audio

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) para audio del sistema
- **Windows**: Captura de audio por loopback
- **Linux**: Entrada del micrófono

## Requisitos

- Sistema operativo compatible con Electron (macOS, Windows, Linux)
- Clave API de Gemini
- Permisos de grabación de pantalla
- Permisos de micrófono/audio

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---