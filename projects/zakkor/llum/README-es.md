# llum

### Una interfaz de chat rápida, ligera y abierta

![image](https://github.com/user-attachments/assets/38cc47cf-06a3-4dca-8ee5-d9c9edf57903)

### Características clave:

- 🔌 Múltiples proveedores, conecta tus claves API (almacenadas completamente localmente) y listo

  - Modelos locales (a través de Ollama)
  - OpenRouter (que te permite usar TODOS los modelos de muchos proveedores: OpenAI, Anthropic, OSS, más de 50 otros)
  - OpenAI
  - Anthropic
  - Mistral
  - Groq

- 🛠️ Uso de herramientas
  - Revisa `server/toolfns/toolfns.go`. Solo necesitas escribir funciones. El comentario de la función es la descripción que recibe el modelo, para saber qué usar. Haz clic en el botón `Sync` en la interfaz web para actualizar tus herramientas.
- 🖼️ Entrada multimodal: sube, pega o comparte enlaces a imágenes
- 🎨 Generación de imágenes usando DALL-E 3
- 📝 Prompts multi-disparo. También edita, elimina, regenera mensajes, lo que quieras. El mundo es tuyo
- ⚡ Respuestas prellenadas (donde el proveedor lo soporte)
- 🌐 Soporte para todos los modelos disponibles en todos los proveedores
- 🔄 Cambia de modelo en medio de la conversación
- 🔐 Sincroniza chats y claves entre dispositivos, cifrado de extremo a extremo. Autoalojado, o usa nuestra instancia alojada.
- 🔗 Compartir conversación (si eliges compartir, tu conversación debe almacenarse en un servidor externo para que el enlace de compartición esté disponible. Próximamente opciones de compartir autoalojadas. No, no veré nada de tu contenido.)
- 🌿 Historial de conversación ramificado (como las flechas izquierda-derecha de ChatGPT que puedes clicar para volver a una respuesta anterior)

### Privacidad:

- Completamente privada y transparente. Todo tu historial de conversación y claves se almacenan completamente localmente, y solo en tu navegador, en tu dispositivo.

## ¿Cómo instalar?

Si no quieres usar herramientas, no necesitas instalar nada. Hay una instancia alojada disponible en: https://llum.chat

Si quieres usar herramientas, continúa a continuación.

## Binario único:

El servidor de herramientas llum está disponible precompilado como un binario único. [Descarga el paquete precompilado desde la página de lanzamientos.](https://github.com/zakkor/llum/releases)

Descarga el binario para tu plataforma, luego ejecútalo, lo que iniciará el servidor de herramientas:

```
./llum-darwin-amd64
Tool server running at http://localhost:8081
```

Vuelve a https://llum.chat, dirígete a Configuración -> Llamada de herramientas, y haz clic en el botón "Actualizar herramientas". ¡Deberías estar listo para continuar!

### Construcción del cliente y servidor localmente:

1. Clona el repositorio
2. Instala y arranca el cliente: `npm i && npm run dev`. El cliente será accesible en http://localhost:5173
3. Instala y arranca el servidor: `cd server && go generate ./... && go build && ./server -password foobar`. El servidor será accesible en http://localhost:8081. Puedes conectar esto en la dirección del servidor en la interfaz de chat junto con la contraseña que seleccionaste.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---