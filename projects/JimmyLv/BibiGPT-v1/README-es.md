> ¡Este repositorio es solo para la versión 1 y soporta Bilibil y YouTube!

# 🤖 BibiGPT: Resumen AI con un clic para Audio/Video y Chat con Contenido de Aprendizaje [https://bibigpt.co](https://bibigpt.co)

🎉 Resume fácilmente videos de YouTube y Bilibili con nuestro Resumidor de Video impulsado por IA. También funciona para Podcasts, Twitter, Reuniones, Conferencias, videos de Tiktok y más. ¡Descubre una forma más brillante de aprender con ChatGPT, tu mejor compañero de estudio potenciado por IA! (anteriormente BiliGPT) "artefacto para ahorro de datos y representante de clase".

Dirección alterna: https://b.jimmylv.cn
Extensión para navegador: https://bibigpt.co/extension

---

## 🤖 BibiGPT · AI 音视频内容一键总结 & 对话 [https://bibigpt.co](https://bibigpt.co)

🎉 ChatGPT AI 音视频一键总结，轻松学习哔哩哔哩丨 YouTube 丨本地视频丨本地音频丨播客丨小红书丨抖音丨会议丨讲座丨网页等任意内容。BibiGPT 助力于成为最好的 AI 学习助理，支持免费试用！(原 BiliGPT 省流神器 & AI 课代表)（支持 iOS 快捷指令 & 微信服务号）。

备用地址：https://b.jimmylv.cn
浏览器插件: https://bibigpt.co/extension

---

🎬 Este proyecto resume videos o audios de YouTube/Bilibili/Twitter/TikTok/Podcast/Conferencia/Reunión/... para ti usando IA.

🤯 Inspirado en [Nutlope/news-summarizer](https://github.com/Nutlope/news-summarizer) & [zhengbangbo/chat-simplifier](https://github.com/zhengbangbo/chat-simplifier/) & [lxfater/BilibiliSummary](https://github.com/lxfater/BilibiliSummary)

[![BibiGPT音视频总结神器](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/BibiGPT.gif)](https://twitter.com/Jimmy_JingLv/status/1630137750572728320?s=20)

🚀 Lanzamiento inicial: [【BibiGPT】AI 自动总结 B 站视频内容，GPT-3 智能提取并总结字幕](https://www.bilibili.com/video/BV1fX4y1Q7Ux/?vd_source=dd5a650b0ad84edd0d54bb18196ecb86)

## Cómo funciona

Este proyecto utiliza la [API ChatGPT de OpenAI](https://openai.com/api/) (específicamente, gpt-3.5-turbo) y [funciones Edge de Vercel](https://vercel.com/features/edge-functions) con streaming y [Upstash](https://console.upstash.com/) para caché Redis y limitación de tasa. Obtiene el contenido de un video de Bilibili, lo envía en un prompt a la API GPT-3 para resumirlo mediante una función Edge de Vercel, luego transmite la respuesta de vuelta a la aplicación.

## Ahorro de costos

Proyectos como este pueden ser costosos, por lo que para ahorrar costos si quieres hacer tu propia versión y compartirla públicamente, recomiendo tres cosas:

- [x] 1. Implementar limitación de tasa para que la gente no abuse de tu sitio
- [x] 2. Implementar caché para evitar regeneraciones costosas de IA
- [x] 3. Usar `text-curie-001` en lugar de `text-dacinci-003` en la función edge `summarize`

## Ejecutar localmente

Después de clonar el repositorio, ve a [OpenAI](https://beta.openai.com/account/api-keys) para crear una cuenta y coloca tu clave API en un archivo llamado `.env`.

Luego, ejecuta la aplicación en la línea de comandos y estará disponible en `http://localhost:3000`.

[el procedimiento específico para ejecutar está descrito en este documento - versión en chino](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./deploy-ch.md)

```bash
npm run dev
```

## Despliegue

Despliega el ejemplo usando [Vercel](https://vercel.com?utm_source=github&utm_medium=readme&utm_campaign=vercel-examples)

Configura las variables de entorno, siguiendo el archivo `./example.env`.

## Soporte para Docker

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