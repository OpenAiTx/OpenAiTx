<samp>
  
<h1>Editor de Video de Código Abierto</h1>
<p>No es tu aplicación de edición de video ordinaria: utiliza React, Remotion y TypeScript.</p>
<br />

> [!NOTA]  
> La aplicación está en desarrollo activo. Esto es un MVP temprano. Por favor, únete al [servidor de Discord](https://discord.gg/GSknuxubZK) si vas a ejecutarla.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Captura de pantalla del Editor de Video en React">
</p>
<p align="center">Una alternativa de código abierto a Capcut, Canva y RVE.</p>
</samp>

## ✨Características

- 🎬Edición de video no lineal
- 🔀Soporte para múltiples pistas
- 👀Vista previa en vivo
- 📤Exportar video
- 📜Licencia MIT

## 🐋Despliegue

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Desarrollo

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
cambia `isProduction` a `false` en `/app/utils/api.ts`

También necesitarás una GEMINI_API_KEY si deseas usar IA.
```

## 📃POR HACER

¡Tenemos mucho trabajo! Para empezar, planeamos integrar todas las APIs de Remotion. Pronto agregaré una hoja de ruta adecuada. Únete al [servidor de Discord](https://discord.com/invite/GSknuxubZK) para actualizaciones y soporte.

## ❤️Contribución

¡Nos encantaría contar con tus contribuciones! ❤️ Consulta la [guía de contribución](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Licencia

Este proyecto está licenciado bajo la Licencia MIT. La [licencia de Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) también se aplica a las partes relevantes del proyecto.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---