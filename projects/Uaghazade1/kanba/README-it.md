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

# Alternativa open-source e leggera a Trello, progettata per maker e indie hacker.

Focalizzata su semplicità, velocità e scalabilità.
Realizzata con stack moderno: Tailwind CSS, shadcn/ui, Supabase, integrazione Stripe.
Supporta progetti illimitati, collaborazione in team, modalità scura/chiara e un'esperienza utente fluida.
Perfetta per sviluppatori singoli e piccoli team che vogliono pieno controllo senza complessità inutili.

## 🌟 Se trovi utile questo progetto, considera di lasciargli una stella! Aiuta anche altri a scoprirlo.

# Guida al Deployment

## Panoramica
Questa applicazione ora utilizza le rotte API locali di Next.js invece delle Supabase Edge Functions per l'integrazione con Stripe. Questo rende il deployment più semplice e permette di usare i normali file .env per la configurazione.

## Configurazione delle variabili d'ambiente

### 1. Crea il file .env.local
Copia `.env.example` in `.env.local` e inserisci i tuoi valori reali:


```bash
cp .env.example .env.local
```
### 2. Variabili d'Ambiente Richieste

#### Configurazione Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - L’URL del tuo progetto Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - La tua chiave anonima Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - La chiave del ruolo di servizio Supabase (solo lato server)

#### Configurazione Stripe (opzionale)
- `STRIPE_SECRET_KEY` - La tua chiave segreta Stripe (solo lato server)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - La tua chiave pubblicabile Stripe
- `STRIPE_WEBHOOK_SECRET` - Il tuo segreto del webhook Stripe

#### Configurazione del Sito
- `NEXT_PUBLIC_SITE_URL` - L’URL del tuo sito (per la produzione)
- `NEXTAUTH_URL` - L’URL del tuo sito (come sopra)
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
4. Testa i webhook di Stripe localmente usando Stripe CLI:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## Distribuzione in Produzione


### Distribuzione su Vercel

1. **Distribuire su Vercel:**

```bash
npx vercel
```
2. **Variabili d'Ambiente:**
   Aggiungi tutte le variabili d'ambiente tramite la dashboard di Vercel o CLI

3. **Configurazione Webhook Stripe:**
   - Punta il webhook a: `https://your-domain.vercel.app/api/stripe/webhook`

## Endpoint API

L'applicazione ora utilizza queste route API locali:

- `POST /api/stripe/checkout` - Crea sessioni di checkout Stripe
- `POST /api/stripe/webhook` - Gestisce gli eventi webhook di Stripe

## Vantaggi delle Route API Locali

1. **Deployment più Semplice** - Non serve distribuire funzioni edge separate
2. **Variabili d'Ambiente** - Supporto standard al file .env
3. **Debug Migliorato** - Più facile eseguire il debug in locale
4. **Integrazione con Framework** - Migliore integrazione con Next.js
5. **Nessun Vendor Lock-in** - Puoi distribuire su qualsiasi piattaforma che supporta Next.js

## Risoluzione dei Problemi

1. **Problemi con Webhook:**
   - Assicurati che `STRIPE_WEBHOOK_SECRET` corrisponda all'endpoint webhook di Stripe
   - Controlla i log dei webhook nella dashboard Stripe
   - Verifica che l'URL del webhook sia corretto

2. **Variabili d'Ambiente:**
   - Assicurati che tutte le variabili richieste siano impostate
   - Controlla eventuali errori nei nomi delle variabili
   - Verifica che la chiave service role di Supabase abbia i permessi corretti

3. **Problemi CORS:**
   - Le route API includono gli header CORS corretti
   - Assicurati che il tuo dominio sia nella whitelist se necessario

## Note di Sicurezza

- Non esporre mai `STRIPE_SECRET_KEY` o `SUPABASE_SERVICE_ROLE_KEY` al client
- Usa il prefisso `NEXT_PUBLIC_` solo per le variabili lato client
- Ruota regolarmente i tuoi segreti webhook
- Monitora la consegna dei webhook nella dashboard Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---