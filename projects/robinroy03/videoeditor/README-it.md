<samp>
  
<h1>Editor Video Open-Source</h1>
<p>Non la solita applicazione di editing video, ma una realizzata con React, Remotion & TypeScript.</p>
<br />

> [!NOTE]  
> L'applicazione è in fase di sviluppo attivo. Questa è una prima versione MVP. Unisciti al [server Discord](https://discord.gg/GSknuxubZK) se vuoi provarla.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Screenshot Editor Video React">
</p>
<p align="center">Un'alternativa open-source a Capcut, Canva e RVE.</p>
</samp>

## ✨Funzionalità

- 🎬Editing Video Non Lineare
- 🔀Supporto Multitraccia
- 👀Anteprima Live
- 📤Esportazione Video
- 📜Licenza MIT

## 🐋Deployment

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Sviluppo

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
imposta `isProduction` su `false` in `/app/utils/api.ts`

Avrai anche bisogno di una GEMINI_API_KEY se vuoi usare l’IA.
```

## 📃TODO

Abbiamo molto lavoro da fare! Per cominciare, prevediamo di integrare tutte le API Remotion. A breve aggiungerò una roadmap dettagliata. Unisciti al [Server Discord](https://discord.com/invite/GSknuxubZK) per aggiornamenti e supporto.

## ❤️Contributi

Amiamo i contributi! ❤️ Consulta la [guida ai contributi](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Licenza

Questo progetto è distribuito sotto licenza MIT. La [licenza Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) si applica anche alle parti pertinenti del progetto.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---