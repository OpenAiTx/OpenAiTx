<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Italiano</a>
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
# Alternativa open-source e leggera a Trello, progettata per makers e indie hacker.

Focus su semplicità, velocità e scalabilità.
Realizzato con uno stack moderno: Tailwind CSS, shadcn/ui, Supabase, integrazione Stripe.
Supporta progetti illimitati, collaborazione in team, modalità scura/chiara ed esperienza utente fluida.
Perfetto per sviluppatori singoli e piccoli team che vogliono il pieno controllo senza complessità inutili.

## 🌟 Se trovi utile questo progetto, considera di lasciargli una stella! Aiuta anche altri a scoprirlo.

# Guida al Deployment

## Panoramica
Questa applicazione ora utilizza le route API locali di Next.js invece delle Edge Functions di Supabase per l'integrazione con Stripe. Questo rende il deployment più semplice e ti permette di usare i file .env standard per la configurazione.

## Configurazione delle variabili d'ambiente

### 1. Crea il file .env.local
Copia `.env.example` in `.env.local` e inserisci i tuoi valori reali:


```bash
cp .env.example .env.local
```

### 2. Variabili d'Ambiente Richieste

#### Configurazione Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - L'URL del tuo progetto Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - La tua chiave anonima Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - La tua chiave di ruolo di servizio Supabase (solo lato server)

#### Configurazione Stripe (opzionale)
- `STRIPE_SECRET_KEY` - La tua chiave segreta Stripe (solo lato server)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - La tua chiave pubblicabile Stripe
- `STRIPE_WEBHOOK_SECRET` - Il tuo segreto webhook Stripe

#### Configurazione Sito
- `NEXT_PUBLIC_SITE_URL` - L'URL del tuo sito (per la produzione)
- `NEXTAUTH_URL` - L'URL del tuo sito (uguale a sopra)
- `NEXTAUTH_SECRET` - Un segreto casuale per NextAuth

## Sviluppo Locale

1. Installa le dipendenze:
```bash
npm install
```

2. Configura le variabili d'ambiente in `.env.local`

3. Avvia il server di sviluppo:
```bash
npm run dev
```

4. Testa i webhook di Stripe localmente utilizzando Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Distribuzione in Produzione


### Distribuzione su Vercel

1. **Distribuisci su Vercel:**
```bash
npx vercel
```
2. **Variabili d'Ambiente:**
   Aggiungi tutte le variabili d'ambiente tramite la dashboard di Vercel o CLI

3. **Configurazione Webhook Stripe:**
   - Punta il webhook a: `https://your-domain.vercel.app/api/stripe/webhook`

## Endpoint API

L'applicazione ora utilizza queste rotte API locali:

- `POST /api/stripe/checkout` - Crea sessioni di checkout Stripe
- `POST /api/stripe/webhook` - Gestisce eventi webhook Stripe

## Vantaggi delle Rotte API Locali

1. **Deployment più semplice** - Nessuna necessità di distribuire funzioni edge separate
2. **Variabili d'Ambiente** - Supporto standard per file .env
3. **Debug Migliorato** - Più facile da fare debug in locale
4. **Integrazione Framework** - Migliore integrazione con Next.js
5. **Nessun Vendor Lock-in** - Può essere distribuito su qualsiasi piattaforma che supporta Next.js

## Risoluzione dei Problemi

1. **Problemi con i Webhook:**
   - Assicurati che `STRIPE_WEBHOOK_SECRET` corrisponda al tuo endpoint webhook di Stripe
   - Controlla i log dei webhook nella dashboard di Stripe
   - Verifica che l’URL del webhook sia corretto

2. **Variabili d'Ambiente:**
   - Assicurati che tutte le variabili richieste siano impostate
   - Controlla la presenza di errori nei nomi delle variabili
   - Verifica che la chiave service role di Supabase abbia i permessi corretti

3. **Problemi CORS:**
   - Le rotte API includono gli header CORS corretti
   - Assicurati che il tuo dominio sia inserito nella whitelist se necessario

## Note di Sicurezza

- Non esporre mai `STRIPE_SECRET_KEY` o `SUPABASE_SERVICE_ROLE_KEY` al client
- Usa il prefisso `NEXT_PUBLIC_` solo per variabili lato client
- Ruota regolarmente i tuoi segreti webhook
- Monitora la consegna dei webhook nella dashboard di Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---