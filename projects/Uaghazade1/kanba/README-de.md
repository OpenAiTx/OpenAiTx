<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Open-Source, leichtgewichtige Trello-Alternative für Macher und Indie-Hacker.

Fokus auf Einfachheit, Geschwindigkeit und Skalierbarkeit.
Gebaut mit modernem Stack: Tailwind CSS, shadcn/ui, Supabase, Stripe-Integration.
Unterstützt unbegrenzte Projekte, Teamzusammenarbeit, Dunkel-/Hellmodus und nahtloses Benutzererlebnis.
Perfekt für Einzelentwickler und kleine Teams, die volle Kontrolle ohne unnötige Komplexität wünschen.

## 🌟 Wenn dir dieses Projekt gefällt, gib ihm gerne einen Stern! So können es auch andere entdecken.

# Bereitstellungsanleitung

## Übersicht
Diese Anwendung verwendet nun lokale Next.js API-Routen statt Supabase Edge Functions für die Stripe-Integration. Dadurch wird die Bereitstellung vereinfacht und du kannst Standard-.env-Dateien für die Konfiguration nutzen.

## Einrichtung der Umgebungsvariablen

### 1. Erstelle die Datei .env.local
Kopiere `.env.example` zu `.env.local` und trage deine tatsächlichen Werte ein:


```bash
cp .env.example .env.local
```
### 2. Erforderliche Umgebungsvariablen

#### Supabase-Konfiguration
- `NEXT_PUBLIC_SUPABASE_URL` - Die URL Ihres Supabase-Projekts
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Ihr Supabase-Anonym-Schlüssel
- `SUPABASE_SERVICE_ROLE_KEY` - Ihr Supabase-Service-Rollen-Schlüssel (nur serverseitig)

#### Stripe-Konfiguration (optional)
- `STRIPE_SECRET_KEY` - Ihr Stripe-Geheimschlüssel (nur serverseitig)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Ihr Stripe-Publishable-Key
- `STRIPE_WEBHOOK_SECRET` - Ihr Stripe-Webhook-Geheimnis

#### Seitenkonfiguration
- `NEXT_PUBLIC_SITE_URL` - Ihre Seiten-URL (für Produktion)
- `NEXTAUTH_URL` - Ihre Seiten-URL (wie oben)
- `NEXTAUTH_SECRET` - Ein zufälliges Geheimnis für NextAuth

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

1. **Auf Vercel bereitstellen:**

```bash
npx vercel
```
2. **Umgebungsvariablen:**
   Fügen Sie alle Umgebungsvariablen über das Vercel-Dashboard oder die CLI hinzu

3. **Stripe Webhook-Einrichtung:**
   - Weisen Sie den Webhook auf: `https://your-domain.vercel.app/api/stripe/webhook`

## API-Endpunkte

Die Anwendung nutzt nun diese lokalen API-Routen:

- `POST /api/stripe/checkout` - Erstellt Stripe-Checkout-Sitzungen
- `POST /api/stripe/webhook` - Verarbeitet Stripe-Webhooks

## Vorteile lokaler API-Routen

1. **Einfachere Bereitstellung** - Kein separates Deployment von Edge-Funktionen erforderlich
2. **Umgebungsvariablen** - Standardmäßige .env-Datei-Unterstützung
3. **Besseres Debugging** - Einfacheres Debuggen lokal möglich
4. **Framework-Integration** - Bessere Integration mit Next.js
5. **Kein Vendor-Lock-in** - Kann auf jeder Plattform eingesetzt werden, die Next.js unterstützt

## Fehlerbehebung

1. **Webhook-Probleme:**
   - Stellen Sie sicher, dass `STRIPE_WEBHOOK_SECRET` mit Ihrem Stripe-Webhook-Endpunkt übereinstimmt
   - Überprüfen Sie die Webhook-Protokolle im Stripe-Dashboard
   - Prüfen Sie, ob die Webhook-URL korrekt ist

2. **Umgebungsvariablen:**
   - Stellen Sie sicher, dass alle erforderlichen Variablen gesetzt sind
   - Überprüfen Sie Tippfehler in Variablennamen
   - Prüfen Sie, ob der Supabase Service Role Key die richtigen Berechtigungen hat

3. **CORS-Probleme:**
   - Die API-Routen enthalten korrekte CORS-Header
   - Stellen Sie sicher, dass Ihre Domain ggf. auf der Whitelist steht

## Sicherheitshinweise

- Geben Sie niemals `STRIPE_SECRET_KEY` oder `SUPABASE_SERVICE_ROLE_KEY` an den Client weiter
- Verwenden Sie das Präfix `NEXT_PUBLIC_` nur für clientseitige Variablen
- Rotieren Sie regelmäßig Ihre Webhook-Secrets
- Überwachen Sie die Zustellung der Webhooks im Stripe-Dashboard



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---