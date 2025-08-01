<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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
# Alternative open-source et légère à Trello conçue pour les makers et les indie hackers.

Axée sur la simplicité, la rapidité et la scalabilité.
Construite avec des technologies modernes : Tailwind CSS, shadcn/ui, Supabase, intégration Stripe.
Prend en charge des projets illimités, la collaboration en équipe, le mode sombre/clair et une expérience utilisateur fluide.
Parfait pour les développeurs solo et les petites équipes qui souhaitent un contrôle total sans complexité inutile.

## 🌟 Si vous trouvez ce projet utile, pensez à lui donner une étoile ! Cela aide aussi d'autres personnes à le découvrir.

# Guide de Déploiement

## Aperçu
Cette application utilise désormais des routes API locales Next.js au lieu des Edge Functions Supabase pour l'intégration Stripe. Cela simplifie le déploiement et permet d'utiliser les fichiers .env standard pour la configuration.

## Configuration des variables d'environnement

### 1. Créez le fichier .env.local
Copiez `.env.example` en `.env.local` et renseignez vos valeurs réelles :


```bash
cp .env.example .env.local
```

### 2. Variables d'environnement requises

#### Configuration Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - L’URL de votre projet Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Votre clé anonyme Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - Votre clé de rôle de service Supabase (uniquement côté serveur)

#### Configuration Stripe (optionnel)
- `STRIPE_SECRET_KEY` - Votre clé secrète Stripe (uniquement côté serveur)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Votre clé publique Stripe
- `STRIPE_WEBHOOK_SECRET` - Votre secret de webhook Stripe

#### Configuration du site
- `NEXT_PUBLIC_SITE_URL` - L’URL de votre site (pour la production)
- `NEXTAUTH_URL` - L’URL de votre site (identique à ci-dessus)
- `NEXTAUTH_SECRET` - Un secret aléatoire pour NextAuth

## Développement local

1. Installer les dépendances :
```bash
npm install
```

2. Configurez vos variables d'environnement dans `.env.local`

3. Lancez le serveur de développement :
```bash
npm run dev
```

4. Testez les webhooks Stripe localement à l'aide du Stripe CLI :
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Déploiement en Production


### Déploiement sur Vercel

1. **Déployer sur Vercel :**
```bash
npx vercel
```

2. **Variables d'environnement :**
   Ajoutez toutes les variables d'environnement via le tableau de bord Vercel ou le CLI

3. **Configuration du webhook Stripe :**
   - Pointez le webhook vers : `https://your-domain.vercel.app/api/stripe/webhook`

## Points de terminaison API

L'application utilise désormais ces routes API locales :

- `POST /api/stripe/checkout` - Crée des sessions de paiement Stripe
- `POST /api/stripe/webhook` - Gère les événements webhook Stripe

## Avantages des routes API locales

1. **Déploiement simplifié** - Pas besoin de déployer des fonctions edge séparées
2. **Variables d'environnement** - Prise en charge standard du fichier .env
3. **Meilleur débogage** - Plus facile à déboguer en local
4. **Intégration au framework** - Meilleure intégration avec Next.js
5. **Pas de verrouillage fournisseur** - Peut être déployé sur toute plateforme supportant Next.js

## Dépannage

1. **Problèmes de webhook :**
   - Vérifiez que `STRIPE_WEBHOOK_SECRET` correspond à votre endpoint webhook Stripe
   - Consultez les journaux du webhook dans le tableau de bord Stripe
   - Vérifiez que l'URL du webhook est correcte

2. **Variables d'environnement :**
   - Vérifiez que toutes les variables requises sont définies
   - Vérifiez les fautes de frappe dans les noms de variables
   - Vérifiez que la clé de rôle de service Supabase a les permissions appropriées

3. **Problèmes CORS :**
   - Les routes API incluent les bons en-têtes CORS
   - Vérifiez que votre domaine est sur liste blanche si nécessaire

## Notes de sécurité

- Ne jamais exposer `STRIPE_SECRET_KEY` ou `SUPABASE_SERVICE_ROLE_KEY` au client
- Utilisez le préfixe `NEXT_PUBLIC_` uniquement pour les variables côté client
- Faites régulièrement tourner vos secrets de webhook
- Surveillez la livraison des webhooks dans le tableau de bord Stripe


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---