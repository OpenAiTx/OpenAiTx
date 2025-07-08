<samp>
  
<h1>Open-Source Video Editor</h1>
<p>Nie jest to zwykła aplikacja do edycji wideo, lecz używa React, Remotion & TypeScript.</p>
<br />

> [!NOTE]  
> Aplikacja jest aktywnie rozwijana. To wczesna wersja MVP. Dołącz do [serwera Discord](https://discord.gg/GSknuxubZK), jeśli zamierzasz jej używać.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Zrzut ekranu edytora wideo React">
</p>
<p align="center">Otwarta alternatywa dla Capcut, Canva i RVE.</p>
</samp>

## ✨Funkcje

- 🎬Nieliniowa edycja wideo
- 🔀Wsparcie dla wielu ścieżek
- 👀Podgląd na żywo
- 📤Eksport wideo
- 📜Licencja MIT

## 🐋Wdrażanie

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Rozwój

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
flip `isProduction` to `false` in `/app/utils/api.ts`

Będziesz także potrzebować GEMINI_API_KEY, jeśli chcesz korzystać ze sztucznej inteligencji.
```

## 📃TODO

Mamy dużo pracy! Na początek planujemy zintegrować wszystkie API Remotion. Wkrótce dodam szczegółową roadmapę. Dołącz do [serwera Discord](https://discord.com/invite/GSknuxubZK) po aktualizacje i wsparcie.

## ❤️Wkład

Chętnie przyjmiemy Twój wkład! ❤️ Sprawdź [przewodnik po kontrybucji](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Licencja

Projekt jest objęty licencją MIT. [Licencja Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) dotyczy również odpowiednich części projektu.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---