<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# Otwarta, lekka alternatywa dla Trello zaprojektowana dla twórców i niezależnych programistów.

Skupienie na prostocie, szybkości i skalowalności.
Zbudowane na nowoczesnym stosie: Tailwind CSS, shadcn/ui, Supabase, integracja ze Stripe.
Obsługuje nieograniczoną liczbę projektów, współpracę zespołową, tryb jasny/ciemny i płynne doświadczenie użytkownika.
Idealne dla samotnych deweloperów i małych zespołów, którzy chcą mieć pełną kontrolę bez zbędnej złożoności.

## 🌟 Jeśli projekt jest dla Ciebie przydatny, daj mu gwiazdkę! Dzięki temu inni również mogą go odkryć.

# Przewodnik wdrożeniowy

## Przegląd
Ta aplikacja używa teraz lokalnych tras API Next.js zamiast funkcji Supabase Edge do integracji ze Stripe. Upraszcza to wdrożenie i pozwala używać standardowych plików .env do konfiguracji.

## Konfiguracja zmiennych środowiskowych

### 1. Utwórz plik .env.local
Skopiuj `.env.example` do `.env.local` i uzupełnij rzeczywistymi wartościami:


```bash
cp .env.example .env.local
```

### 2. Wymagane zmienne środowiskowe

#### Konfiguracja Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - Adres URL projektu Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Anonimowy klucz Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - Klucz roli serwisowej Supabase (tylko po stronie serwera)

#### Konfiguracja Stripe (opcjonalnie)
- `STRIPE_SECRET_KEY` - Twój tajny klucz Stripe (tylko po stronie serwera)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Klucz publiczny Stripe
- `STRIPE_WEBHOOK_SECRET` - Tajny klucz webhook Stripe

#### Konfiguracja strony
- `NEXT_PUBLIC_SITE_URL` - Adres URL Twojej strony (dla produkcji)
- `NEXTAUTH_URL` - Adres URL Twojej strony (taki sam jak wyżej)
- `NEXTAUTH_SECRET` - Losowy sekret dla NextAuth

## Lokalny rozwój

1. Zainstaluj zależności:
```bash
npm install
```

2. Skonfiguruj swoje zmienne środowiskowe w pliku `.env.local`

3. Uruchom serwer deweloperski:
```bash
npm run dev
```

4. Przetestuj webhooki Stripe lokalnie za pomocą Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Wdrożenie produkcyjne


### Wdrażanie na Vercel

1. **Wdróż na Vercel:**
```bash
npx vercel
```

2. **Zmienne środowiskowe:**
   Dodaj wszystkie zmienne środowiskowe przez dashboard Vercel lub CLI

3. **Konfiguracja Stripe Webhook:**
   - Skieruj webhook na: `https://twoja-domena.vercel.app/api/stripe/webhook`

## Punkty końcowe API

Aplikacja korzysta teraz z tych lokalnych tras API:

- `POST /api/stripe/checkout` - Tworzy sesje Stripe checkout
- `POST /api/stripe/webhook` - Obsługuje zdarzenia Stripe webhook

## Zalety lokalnych tras API

1. **Prostsze wdrożenie** - Brak potrzeby wdrażania osobnych funkcji edge
2. **Zmienne środowiskowe** - Standardowe wsparcie pliku .env
3. **Lepsze debugowanie** - Łatwiejsze debugowanie lokalnie
4. **Integracja z frameworkiem** - Lepsza integracja z Next.js
5. **Brak uzależnienia od dostawcy** - Możesz wdrożyć na dowolnej platformie obsługującej Next.js

## Rozwiązywanie problemów

1. **Problemy z webhookiem:**
   - Upewnij się, że `STRIPE_WEBHOOK_SECRET` odpowiada Twojemu endpointowi Stripe webhook
   - Sprawdź logi webhooków w dashboardzie Stripe
   - Zweryfikuj poprawność adresu URL webhooka

2. **Zmienne środowiskowe:**
   - Upewnij się, że wszystkie wymagane zmienne są ustawione
   - Sprawdź literówki w nazwach zmiennych
   - Zweryfikuj, czy klucz roli serwisowej Supabase ma odpowiednie uprawnienia

3. **Problemy z CORS:**
   - Trasy API zawierają odpowiednie nagłówki CORS
   - Upewnij się, że Twoja domena jest umieszczona na białej liście, jeśli to konieczne

## Uwagi dotyczące bezpieczeństwa

- Nigdy nie udostępniaj `STRIPE_SECRET_KEY` ani `SUPABASE_SERVICE_ROLE_KEY` klientowi
- Używaj prefiksu `NEXT_PUBLIC_` tylko dla zmiennych po stronie klienta
- Regularnie zmieniaj swoje sekrety webhooków
- Monitoruj dostarczanie webhooków w dashboardzie Stripe


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---