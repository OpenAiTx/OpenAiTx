<samp>
  
<h1>Открытый видеоредактор</h1>
<p>Необычное приложение для видеомонтажа на базе React, Remotion и TypeScript.</p>
<br />

> [!NOTE]  
> Приложение находится в активной разработке. Это ранний MVP. Пожалуйста, присоединяйтесь к [Discord серверу](https://discord.gg/GSknuxubZK), если собираетесь его запускать.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Скриншот React Video Editor">
</p>
<p align="center">Открытая альтернатива Capcut, Canva и RVE.</p>
</samp>

## ✨Возможности

- 🎬Нелинейный видеомонтаж
- 🔀Поддержка нескольких дорожек
- 👀Живой предпросмотр
- 📤Экспорт видео
- 📜Лицензия MIT

## 🐋Деплой

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Разработка

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
flip `isProduction` to `false` in `/app/utils/api.ts`

Вам также потребуется GEMINI_API_KEY, если вы хотите использовать ИИ.
```

## 📃TODO

Нам предстоит много работы! Для начала мы планируем интегрировать все API Remotion. Скоро я добавлю подробную дорожную карту. Присоединяйтесь к [Discord серверу](https://discord.com/invite/GSknuxubZK) для получения обновлений и поддержки.

## ❤️Вклад

Мы будем рады вашему участию! ❤️ Ознакомьтесь с [руководством по вкладу](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Лицензия

Этот проект распространяется под лицензией MIT. [Лицензия Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) также применяется к соответствующим частям проекта.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---