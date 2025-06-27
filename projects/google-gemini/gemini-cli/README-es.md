# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Este repositorio contiene Gemini CLI, una herramienta de línea de comandos para flujos de trabajo de IA que se conecta con tus herramientas, entiende tu código y acelera tus flujos de trabajo.

Con Gemini CLI puedes:

- Consultar y editar grandes bases de código dentro y más allá de la ventana de contexto de 1M tokens de Gemini.
- Generar nuevas aplicaciones a partir de PDFs o bocetos, utilizando las capacidades multimodales de Gemini.
- Automatizar tareas operativas, como consultar pull requests o gestionar rebases complejos.
- Usar herramientas y servidores MCP para conectar nuevas capacidades, incluyendo [generación de medios con Imagen,
  Veo o Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Fundamentar tus consultas con la herramienta [Google Search](https://ai.google.dev/gemini-api/docs/grounding),
  integrada en Gemini.

## Inicio rápido

1. **Requisitos previos:** Asegúrate de tener instalada la [versión 18 de Node.js](https://nodejs.org/en/download) o superior.
2. **Ejecuta el CLI:** Ejecuta el siguiente comando en tu terminal:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   O instálalo con:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Elige un tema de color**
4. **Autentícate:** Cuando se te solicite, inicia sesión con tu cuenta personal de Google. Esto te dará hasta 60 solicitudes de modelo por minuto y 1,000 solicitudes de modelo por día usando Gemini.

¡Ahora estás listo para usar Gemini CLI!

### Para uso avanzado o límites aumentados:

Si necesitas usar un modelo específico o requieres una mayor capacidad de solicitudes, puedes usar una clave de API:

1. Genera una clave desde [Google AI Studio](https://aistudio.google.com/apikey).
2. Configúrala como una variable de entorno en tu terminal. Sustituye `YOUR_API_KEY` por tu clave generada.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Para otros métodos de autenticación, incluidas cuentas de Google Workspace, consulta la guía de [autenticación](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Ejemplos

Una vez que el CLI esté en ejecución, puedes comenzar a interactuar con Gemini desde tu terminal.

Puedes iniciar un proyecto desde un nuevo directorio:

```sh
cd new-project/
gemini
> Escríbeme un bot de Discord con Gemini que responda preguntas usando un archivo FAQ.md que proporcionaré
```

O trabajar con un proyecto existente:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Dame un resumen de todos los cambios que se realizaron ayer
```

### Siguientes pasos

- Aprende cómo [contribuir o compilar desde el código fuente](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Explora los **[Comandos CLI disponibles](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Si tienes algún problema, revisa la **[Guía de resolución de problemas](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Para una documentación más completa, consulta la [documentación completa](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Revisa algunas [tareas populares](#popular-tasks) para más inspiración.

### Resolución de problemas

Dirígete a la [guía de resolución de problemas](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) si tienes inconvenientes.

## Tareas populares

### Explora una nueva base de código

Comienza haciendo `cd` a un repositorio existente o recién clonado y ejecuta `gemini`.

```text
> Describe las principales piezas de la arquitectura de este sistema.
```

```text
> ¿Qué mecanismos de seguridad existen?
```

### Trabaja con tu código existente

```text
> Implementa un primer borrador para el issue #123 de GitHub.
```

```text
> Ayúdame a migrar esta base de código a la última versión de Java. Empieza con un plan.
```

### Automatiza tus flujos de trabajo

Utiliza servidores MCP para integrar las herramientas locales de tu sistema con tu suite de colaboración empresarial.

```text
> Hazme una presentación de diapositivas mostrando el historial de git de los últimos 7 días, agrupado por función y miembro del equipo.
```

```text
> Crea una aplicación web de pantalla completa para un display mural que muestre nuestros issues de GitHub con más interacciones.
```

### Interactúa con tu sistema

```text
> Convierte todas las imágenes de este directorio a png y renómbralas usando fechas de los datos exif.
```

```text
> Organiza mis facturas PDF por mes de gasto.
```

## Términos de servicio y Aviso de privacidad

Para más detalles sobre los términos de servicio y el aviso de privacidad aplicables al uso de Gemini CLI, consulta los [Términos de servicio y Aviso de privacidad](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---