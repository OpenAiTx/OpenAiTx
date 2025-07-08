<samp>
  
<h1>Editor de Vídeo Open Source</h1>
<p>Não é o seu aplicativo comum de edição de vídeo, utilizando React, Remotion & TypeScript.</p>
<br />

> [!NOTA]  
> O aplicativo está em desenvolvimento ativo. Esta é uma MVP inicial. Por favor, entre no [servidor Discord](https://discord.gg/GSknuxubZK) se você pretende executá-lo.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Captura de Tela do Editor de Vídeo React">
</p>
<p align="center">Uma alternativa open source ao Capcut, Canva e RVE.</p>
</samp>

## ✨Recursos

- 🎬Edição de Vídeo Não Linear
- 🔀Suporte a Múltiplas Trilhas
- 👀Pré-visualização em Tempo Real
- 📤Exportar Vídeo
- 📜Licenciado sob MIT

## 🐋Implantação

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Desenvolvimento

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
altere `isProduction` para `false` em `/app/utils/api.ts`

Você também precisará de uma GEMINI_API_KEY se quiser usar IA.
```

## 📃A FAZER

Temos muito trabalho! Para começar, planejamos integrar todas as APIs do Remotion. Em breve adicionarei um roadmap adequado. Entre no [Servidor Discord](https://discord.com/invite/GSknuxubZK) para atualizações e suporte.

## ❤️Contribuição

Adoraríamos as suas contribuições! ❤️ Confira o [guia de contribuição](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Licença

Este projeto está licenciado sob a Licença MIT. A [licença do Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) também se aplica às partes relevantes do projeto.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---