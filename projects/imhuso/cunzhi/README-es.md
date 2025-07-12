# 寸止 🛑

> **El "terminador de eyaculación precoz" en diálogos con IA, para que la comunicación siga hasta el final**

¿Sigues frustrado porque tu asistente de IA siempre termina la conversación antes de tiempo? Cuando aún tienes mucho de qué hablar, pero te pregunta "¿Hay algo más en lo que pueda ayudarte?" ¡**寸止** es la solución definitiva para este problema!

Cuando la IA quiera "terminar rápidamente", 寸止 mostrará oportunamente un cuadro de diálogo para que puedas continuar la conversación en profundidad hasta resolver realmente el problema.

## 🌟 Características principales

- 🛑 **Intercepción inteligente**: Opción de continuar automáticamente cuando la IA quiera terminar
- 🧠 **Gestión de memoria**: Guarda normas y preferencias de desarrollo por proyecto
- 🎨 **Interacción elegante**: Soporte Markdown y múltiples métodos de entrada
- ⚡ **Listo para usar**: Instalación en 3 segundos, soporte multiplataforma

## 📸 Mira cómo funciona

### 🛑 Ventana emergente de intercepción inteligente
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Cuando la IA quiera terminar la conversación, la ventana emergente inteligente de 寸止 aparece a tiempo, ofreciendo opciones predefinidas para elegir rápidamente y mantener la comunicación fluida y profunda*
### ⚙️ Interfaz de gestión de configuración
![Interfaz de configuración de Cunzhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Interfaz de configuración elegante, soporta gestión de memoria, interruptores de funciones, cambio de tema y generación inteligente de prompts*

## 🚀 Comenzar a usar

### Método 1: Instalación rápida (recomendado)

**Usuarios de macOS:**
```bash
# Instalación en 3 segundos, sin necesidad de esperar compilación
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Solución de problemas**: Si te encuentras con un error 404 al descargar, realiza los siguientes pasos:
>
> ```bash
> # Limpiar la caché antigua de tap
> brew untap imhuso/cunzhi
> # Reinstalar
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Ejemplo de error común:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Esto normalmente se debe a un problema de caché de versiones anteriores, lo que provoca una incompatibilidad de versiones. Limpiar el tap y reinstalar lo solucionará.

**Usuarios de Windows/Linux:**
¡Se recomienda utilizar el método 2 para descarga manual, rápido y sencillo!
### Método 2: Descarga manual

1. Visita la [página de Releases](https://github.com/imhuso/cunzhi/releases)
2. Descarga la versión adecuada para tu sistema:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Después de descomprimir, añade `寸止` y `等一下` al PATH del sistema

## ⚡ Comenzar rápidamente

### Paso 1: Configurar el cliente MCP

Agrega lo siguiente al archivo de configuración de tu cliente MCP (como Claude Desktop):

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Segundo paso: Abrir la interfaz de configuración

```bash
# Ejecutar el comando de configuración
Espera un momento
```

### Tercer paso: Configurar las palabras clave de referencia

En la pestaña "Palabras clave de referencia" de la interfaz de configuración:
1. Revisa las palabras clave generadas automáticamente
2. Haz clic en el botón de copiar
3. Añade las palabras clave a tu asistente de IA

### Cuarto paso: Comenzar a usar

¡Ahora tu asistente de IA cuenta con funciones de interceptación inteligente, gestión de memoria e interacción mediante ventanas emergentes!

> 💡 **Consejo**: Puedes personalizar las palabras clave generadas para crear una experiencia de interacción con IA exclusiva para ti.
## 🤝 Participa y contribuye

Cunzhi es un proyecto de código abierto, ¡damos la bienvenida a todo tipo de contribuciones!

### 🐛 ¿Has encontrado un problema?
- [Enviar un Issue](https://github.com/imhuso/cunzhi/issues) para describir el problema
- Proporciona los pasos para reproducirlo y la información del entorno

### 💡 ¿Tienes una buena idea?
- [Inicia una discusión](https://github.com/imhuso/cunzhi/discussions) para compartir tu idea
- Envía un Pull Request para implementar nuevas funciones

### 🛠️ Desarrollo local
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Contáctanos

- 🐛 **Reportar problemas**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Discusión de funcionalidades**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **¿Te gusta el proyecto?**: ¡Apóyanos con una estrella!

## 📄 Licencia de código abierto

MIT License - Uso libre, ¡bienvenidas las contribuciones!

---

<div align="center">

**Despídete de la “eyaculación precoz” en diálogos con IA | Haz que cada conversación dure hasta el final**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Reportar bug](https://github.com/imhuso/cunzhi/issues) · [💡 Solicitar función](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---