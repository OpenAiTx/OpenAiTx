
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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
# Open-Source, leichtgewichtige Trello-Alternative für Macher und Indie Hacker.

Fokus auf Einfachheit, Geschwindigkeit und Skalierbarkeit.
Gebaut mit modernem Stack: Tailwind CSS, shadcn/ui, Supabase, Stripe-Integration.
Unterstützt unbegrenzte Projekte, Teamzusammenarbeit, Dark-/Light-Mode und nahtloses Benutzererlebnis.
Perfekt für Solo-Entwickler und kleine Teams, die volle Kontrolle ohne unnötige Komplexität möchten.

## 🌟 Wenn du dieses Projekt nützlich findest, gib ihm gerne einen Stern! Das hilft auch anderen, es zu entdecken.

# Bereitstellungsanleitung

## Übersicht
Diese Anwendung nutzt nun lokale Next.js API-Routen anstelle von Supabase Edge Functions für die Stripe-Integration. Das vereinfacht die Bereitstellung und ermöglicht die Verwendung von Standard-.env-Dateien für die Konfiguration.

## Einrichtung der Umgebungsvariablen

### 1. Erstelle die Datei .env.local
Kopiere `.env.example` zu `.env.local` und trage deine echten Werte ein:

```bash
cp .env.example .env.local
```

### 2. Erforderliche Umgebungsvariablen

#### Supabase-Konfiguration
- `NEXT_PUBLIC_SUPABASE_URL` - Deine Supabase-Projekt-URL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Dein Supabase-anonymer Schlüssel
- `SUPABASE_SERVICE_ROLE_KEY` - Dein Supabase-Service-Role-Schlüssel (nur serverseitig)

#### Stripe-Konfiguration (optional)
- `STRIPE_SECRET_KEY` - Dein Stripe-Secret-Key (nur serverseitig)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Dein Stripe-Publishable-Key
- `STRIPE_WEBHOOK_SECRET` - Dein Stripe-Webhook-Secret

#### Seitenkonfiguration
- `NEXT_PUBLIC_SITE_URL` - Deine Seiten-URL (für Produktion)
- `NEXTAUTH_URL` - Deine Seiten-URL (wie oben)
- `NEXTAUTH_SECRET` - Ein zufälliges Secret für NextAuth

## Lokale Entwicklung

1. Abhängigkeiten installieren:
```bash
npm install
```

2. Richten Sie Ihre Umgebungsvariablen in `.env.local` ein

3. Starten Sie den Entwicklungsserver:
```bash
npm run dev
```

4. Testen Sie Stripe-Webhooks lokal mit der Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Produktionsbereitstellung


### Vercel-Bereitstellung

1. **Bei Vercel bereitstellen:**
```bash
npx vercel
```
2. **Umgebungsvariablen:**
   Fügen Sie alle Umgebungsvariablen über das Vercel-Dashboard oder die CLI hinzu

3. **Stripe Webhook Einrichtung:**
   - Webhook zeigen auf: `https://your-domain.vercel.app/api/stripe/webhook`

## API-Endpunkte

Die Anwendung verwendet jetzt diese lokalen API-Routen:

- `POST /api/stripe/checkout` - Erstellt Stripe-Checkout-Sitzungen
- `POST /api/stripe/webhook` - Verarbeitet Stripe-Webhook-Ereignisse

## Vorteile der lokalen API-Routen

1. **Einfachere Bereitstellung** - Keine separaten Edge-Funktionen erforderlich
2. **Umgebungsvariablen** - Standardmäßige .env-Datei-Unterstützung
3. **Besseres Debugging** - Einfacheres Debugging lokal
4. **Framework-Integration** - Bessere Integration mit Next.js
5. **Kein Vendor-Lock-in** - Kann auf jeder Plattform bereitgestellt werden, die Next.js unterstützt

## Fehlerbehebung

1. **Webhook-Probleme:**
   - Stellen Sie sicher, dass `STRIPE_WEBHOOK_SECRET` mit Ihrem Stripe-Webhook-Endpunkt übereinstimmt
   - Überprüfen Sie die Webhook-Protokolle im Stripe-Dashboard
   - Vergewissern Sie sich, dass die Webhook-URL korrekt ist

2. **Umgebungsvariablen:**
   - Stellen Sie sicher, dass alle erforderlichen Variablen gesetzt sind
   - Überprüfen Sie Tippfehler in den Variablennamen
   - Vergewissern Sie sich, dass der Supabase-Service-Role-Key die richtigen Berechtigungen hat

3. **CORS-Probleme:**
   - API-Routen enthalten die richtigen CORS-Header
   - Stellen Sie sicher, dass Ihre Domain bei Bedarf auf der Whitelist steht

## Sicherheitshinweise

- Geben Sie niemals `STRIPE_SECRET_KEY` oder `SUPABASE_SERVICE_ROLE_KEY` an den Client weiter
- Verwenden Sie das Präfix `NEXT_PUBLIC_` nur für clientseitige Variablen
- Rotieren Sie regelmäßig Ihre Webhook-Secrets
- Überwachen Sie die Webhook-Zustellung im Stripe-Dashboard



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---