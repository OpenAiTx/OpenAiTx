<samp>
  
<h1>Open-Source Video Editor</h1>
<p>Nicht deine gewöhnliche Video-Editor-Anwendung, entwickelt mit React, Remotion & TypeScript.</p>
<br />

> [!HINWEIS]  
> Die Anwendung befindet sich in aktiver Entwicklung. Dies ist ein frühes MVP. Trete dem [Discord-Server](https://discord.gg/GSknuxubZK) bei, wenn du sie ausführen möchtest.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React Video Editor Screenshot">
</p>
<p align="center">Eine Open-Source-Alternative zu Capcut, Canva und RVE.</p>
</samp>

## ✨Funktionen

- 🎬Nicht-lineares Video-Editing
- 🔀Multi-Track-Unterstützung
- 👀Live-Vorschau
- 📤Video exportieren
- 📜Lizenziert unter MIT

## 🐋Deployment

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Entwicklung

```
pnpm i
pnpm run dev (Frontend)
pnpm dlx tsx app/videorender/videorender.ts (Backend)
uv run backend/main.py
Setze `isProduction` auf `false` in `/app/utils/api.ts`

Du benötigst außerdem einen GEMINI_API_KEY, wenn du KI nutzen möchtest.
```

## 📃TODO

Wir haben viel zu tun! Zu Beginn planen wir, alle Remotion-APIs zu integrieren. Ich werde bald eine richtige Roadmap hinzufügen. Tritt dem [Discord-Server](https://discord.com/invite/GSknuxubZK) für Updates und Support bei.

## ❤️Beitrag

Wir freuen uns über deine Beiträge! ❤️ Sieh dir den [Beitragsleitfaden](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md) an.

## 📜Lizenz

Dieses Projekt ist unter der MIT-Lizenz lizenziert. Die [Remotion-Lizenz](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) gilt ebenfalls für die entsprechenden Teile des Projekts.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---