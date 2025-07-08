<samp>
  
<h1>Éditeur Vidéo Open-Source</h1>
<p>Pas une application d’édition vidéo ordinaire, utilisant React, Remotion & TypeScript.</p>
<br />

> [!NOTE]  
> L’application est en cours de développement actif. Ceci est une version MVP précoce. Rejoignez le [serveur Discord](https://discord.gg/GSknuxubZK) si vous souhaitez l’exécuter.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Capture d’écran de l’Éditeur Vidéo React">
</p>
<p align="center">Une alternative open-source à Capcut, Canva et RVE.</p>
</samp>

## ✨Fonctionnalités

- 🎬Édition vidéo non linéaire
- 🔀Prise en charge multi-pistes
- 👀Aperçu en direct
- 📤Exportation vidéo
- 📜Sous licence MIT

## 🐋Déploiement

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Développement

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
mettez `isProduction` sur `false` dans `/app/utils/api.ts`

Vous aurez également besoin d’une GEMINI_API_KEY si vous souhaitez utiliser l’IA.
```

## 📃À FAIRE

Nous avons beaucoup de travail ! Pour commencer, nous prévoyons d’intégrer toutes les API Remotion. J’ajouterai bientôt une feuille de route appropriée. Rejoignez le [serveur Discord](https://discord.com/invite/GSknuxubZK) pour les mises à jour et le support.

## ❤️Contribution

Nous serions ravis de recevoir vos contributions ! ❤️ Consultez le [guide de contribution](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Licence

Ce projet est sous licence MIT. La [licence Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) s’applique également aux parties concernées du projet.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---