> Ce dépôt est uniquement pour la v1 et prend en charge Bilibil et YouTube !

# 🤖 BibiGPT : résumé IA en un clic pour audio/vidéo & chat avec contenu d’apprentissage [https://bibigpt.co](https://bibigpt.co)

🎉 Résumez facilement les vidéos YouTube et Bilibili avec notre Résumeur Vidéo piloté par IA. Il fonctionne aussi pour les podcasts, Twitter, réunions, conférences, vidéos Tiktok, et plus encore. Découvrez une façon plus brillante d’apprendre avec ChatGPT, votre meilleur compagnon d’étude alimenté par IA ! (anciennement BiliGPT) « artefact d’économie de flux & délégué de classe ».

Adresse alternative : https://b.jimmylv.cn
Extension navigateur : https://bibigpt.co/extension

---

## 🤖 BibiGPT · AI 音视频内容一键总结 & 对话 [https://bibigpt.co](https://bibigpt.co)

🎉 ChatGPT AI 音视频一键总结，轻松学习哔哩哔哩丨 YouTube 丨本地视频丨本地音频丨播客丨小红书丨抖音丨会议丨讲座丨网页等任意内容。BibiGPT 助力于成为最好的 AI 学习助理，支持免费试用！(原 BiliGPT 省流神器 & AI 课代表)（支持 iOS 快捷指令 & 微信服务号）。

备用地址：https://b.jimmylv.cn
浏览器插件: https://bibigpt.co/extension

---

🎬 Ce projet résume pour vous des vidéos ou audios YouTube/Bilibili/Twitter/TikTok/Podcast/Conférence/Réunion/... grâce à l’IA.

🤯 Inspiré par [Nutlope/news-summarizer](https://github.com/Nutlope/news-summarizer) & [zhengbangbo/chat-simplifier](https://github.com/zhengbangbo/chat-simplifier/) & [lxfater/BilibiliSummary](https://github.com/lxfater/BilibiliSummary)

[![BibiGPT音视频总结神器](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/BibiGPT.gif)](https://twitter.com/Jimmy_JingLv/status/1630137750572728320?s=20)

🚀 Première sortie : [【BibiGPT】AI 自动总结 B 站视频内容，GPT-3 智能提取并总结字幕](https://www.bilibili.com/video/BV1fX4y1Q7Ux/?vd_source=dd5a650b0ad84edd0d54bb18196ecb86)

## Comment ça marche

Ce projet utilise l’[API OpenAI ChatGPT](https://openai.com/api/) (plus précisément, gpt-3.5-turbo) et les [fonctions Edge Vercel](https://vercel.com/features/edge-functions) avec streaming et [Upstash](https://console.upstash.com/) pour le cache Redis et la limitation de débit. Il récupère le contenu d’une vidéo Bilibili, l’envoie dans une invite à l’API GPT-3 pour le résumer via une fonction Edge Vercel, puis transmet la réponse en streaming à l’application.

## Économiser les coûts

Des projets comme celui-ci peuvent devenir coûteux, donc pour économiser si vous voulez faire votre propre version et la partager publiquement, je recommande trois choses :

- [x] 1. Mettre en place une limitation de débit pour éviter les abus sur votre site
- [x] 2. Mettre en cache pour éviter des régénérations IA coûteuses
- [x] 3. Utiliser `text-curie-001` au lieu de `text-dacinci-003` dans la fonction edge `summarize`

## Exécution locale

Après avoir cloné le dépôt, allez sur [OpenAI](https://beta.openai.com/account/api-keys) pour créer un compte et mettez votre clé API dans un fichier nommé `.env`.

Ensuite, lancez l'application en ligne de commande et elle sera disponible à l'adresse `http://localhost:3000`.

[la procédure d'exécution spécifique est décrite dans ce document - version chinoise](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./deploy-ch.md)

```bash
npm run dev
```

## Déploiement

Déployez l'exemple en utilisant [Vercel](https://vercel.com?utm_source=github&utm_medium=readme&utm_campaign=vercel-examples)

Configurez les variables d'environnement, en suivant le fichier `./example.env`.

## Support Docker

https://github.com/JimmyLv/BibiGPT/pull/133

```shell
# make sure setup .env file firstly
docker compose up -d
```

## Support -> Contact Me

![](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/wechat.jpg)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=JimmyLv/BibiGPT&type=Date)](https://star-history.com/#JimmyLv/BibiGPT&Date)

## Contributors

This project exists thanks to all the people who contribute.

 <a href="https://github.com/JimmyLv/BibiGPT/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=JimmyLv/BibiGPT" />
 </a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---