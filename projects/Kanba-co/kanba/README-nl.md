
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Vietnamees</a>
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
  <img alt="Vercel OSS Programma" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# Open-source, lichtgewicht Trello-alternatief ontworpen voor makers en indie hackers.

Focus op eenvoud, snelheid en schaalbaarheid.
Gebouwd met moderne stack: Tailwind CSS, shadcn/ui, Supabase, Stripe-integratie.
Ondersteunt onbeperkte projecten, team samenwerking, donker/licht modus, en een naadloze gebruikerservaring.
Perfect voor solo-ontwikkelaars en kleine teams die volledige controle willen zonder onnodige complexiteit.

## 🌟 Als je dit project nuttig vindt, overweeg dan om het een ster te geven! Zo help je anderen het ook te ontdekken.

# Deploy Handleiding

## Overzicht
Deze applicatie gebruikt nu lokale Next.js API-routes in plaats van Supabase Edge Functions voor Stripe-integratie. Dit maakt implementatie eenvoudiger en stelt je in staat om standaard .env-bestanden te gebruiken voor configuratie.

## Instellen van Omgevingsvariabelen

### 1. Maak een .env.local bestand aan
Kopieer `.env.example` naar `.env.local` en vul je daadwerkelijke waarden in:

```bash
cp .env.example .env.local
```

### 2. Vereiste Omgevingsvariabelen

#### Supabase Configuratie
- `NEXT_PUBLIC_SUPABASE_URL` - De URL van je Supabase-project
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Je anonieme Supabase-sleutel
- `SUPABASE_SERVICE_ROLE_KEY` - Je Supabase service role key (alleen server-side)

#### Stripe Configuratie (optioneel)
- `STRIPE_SECRET_KEY` - Je Stripe geheime sleutel (alleen server-side)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Je Stripe publiceerbare sleutel
- `STRIPE_WEBHOOK_SECRET` - Je Stripe webhook-geheim

#### Site Configuratie
- `NEXT_PUBLIC_SITE_URL` - De URL van je site (voor productie)
- `NEXTAUTH_URL` - De URL van je site (dezelfde als hierboven)
- `NEXTAUTH_SECRET` - Een willekeurig geheim voor NextAuth

## Lokale Ontwikkeling

1. Installeer afhankelijkheden:
```bash
npm install
```

2. Stel je omgevingsvariabelen in in `.env.local`

3. Start de ontwikkelserver:
```bash
npm run dev
```

4. Test Stripe-webhooks lokaal met behulp van Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Productie-uitrol


### Vercel-implementatie

1. **Implementeer op Vercel:**
```bash
npx vercel
```
2. **Omgevingsvariabelen:**
   Voeg alle omgevingsvariabelen toe via het Vercel dashboard of de CLI

3. **Stripe Webhook Instellen:**
   - Wijs webhook naar: `https://your-domain.vercel.app/api/stripe/webhook`

## API Eindpunten

De applicatie gebruikt nu deze lokale API-routes:

- `POST /api/stripe/checkout` - Maakt Stripe checkout-sessies aan
- `POST /api/stripe/webhook` - Verwerkt Stripe webhook-events

## Voordelen van Lokale API-Routes

1. **Eenvoudigere Deploy** - Geen aparte edge-functies nodig
2. **Omgevingsvariabelen** - Standaard .env-bestand ondersteuning
3. **Betere Debugging** - Makkelijker lokaal te debuggen
4. **Framework Integratie** - Betere integratie met Next.js
5. **Geen Vendor Lock-in** - Kan worden uitgerold op elk platform dat Next.js ondersteunt

## Problemen Oplossen

1. **Webhook Problemen:**
   - Zorg dat `STRIPE_WEBHOOK_SECRET` overeenkomt met je Stripe webhook endpoint
   - Controleer webhook logs in het Stripe dashboard
   - Verifieer dat de webhook URL juist is

2. **Omgevingsvariabelen:**
   - Zorg dat alle vereiste variabelen zijn ingesteld
   - Controleer op typfouten in variabelenamen
   - Verifieer dat de Supabase service role key de juiste rechten heeft

3. **CORS Problemen:**
   - API-routes bevatten de juiste CORS headers
   - Zorg dat je domein op de whitelist staat indien nodig

## Beveiligingsnotities

- Stel nooit `STRIPE_SECRET_KEY` of `SUPABASE_SERVICE_ROLE_KEY` bloot aan de client
- Gebruik het voorvoegsel `NEXT_PUBLIC_` alleen voor client-side variabelen
- Draai regelmatig je webhook secrets om
- Monitor de webhook-levering in het Stripe dashboard



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---