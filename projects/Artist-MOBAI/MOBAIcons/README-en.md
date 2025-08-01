﻿
[![MOBAIcons](https://mobaicons.com/about)](https://mobaicons.com/)
[![MOBAIcons](https://raw.githubusercontent.com/Artist-MOBAI/MOBAIcons/main/./src/docs/image/author.svg)](https://mobaicons.com/)

<!-- [![API Status](https://img.shields.io/badge/API-Online-green)](https://mobaicons.com)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](./LICENSE)
[![GitHub Stars](https://img.shields.io/github/stars/Artist-MOBAI/MOBAIcons)](https://github.com/Artist-MOBAI/MOBAIcons) -->

### `GET` `/icons/name1,name2`

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare)](https://mobaicons.com/)

### `GET` `/icons/name1,name2?sort`

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare?sort)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare?sort)](https://mobaicons.com/)

### `GET` `/icons/name1,name2?duplicate`

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/icons/ts,bun,hono,go,go,go,go,go?duplicate)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/icons/ts,bun,hono,go,go,go,go,go?duplicate)](https://mobaicons.com/)

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/icons/ts,bun,hono,go,go,go,go,go)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/icons/ts,bun,hono,go,go,go,go,go)](https://mobaicons.com/)

### `GET` `/icons/name1,name2?perline=N`

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare,bun,js,astro,preact,react,vue,trpc?perline=7)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare,bun,js,astro,preact,react,vue,trpc?perline=7)](https://mobaicons.com/)

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare,bun,js,astro,preact,react,vue,trpc?perline=10)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/icons/html,css,ts,hono,go,grpc,cloudflare,bun,js,astro,preact,react,vue,trpc?perline=10)](https://mobaicons.com/)

### `GET` `/search/term`

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/search/react)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/search/react)](https://mobaicons.com/)

```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/search/vue)](https://mobaicons.com/)
```
[![MOBAIcons](https://mobaicons.com/search/vue)](https://mobaicons.com/)

| Method | Endpoint                       | Returns                     | Description                                       |
| ------ | ------------------------------ | --------------------------- | ------------------------------------------------- |
| `GET`  | `/count`                       | Plain text number           | Total count of available icons                    |
| `GET`  | `/all`                         | SVG grid composition        | Complete grid containing all available icons      |
| `GET`  | `/list`                        | Comma-separated text        | All icon names in plain text format               |
| `GET`  | `/list?json`                   | JSON array of strings       | All icon names as structured JSON data            |
| `GET`  | `/search?q=term`               | JSON array of matches       | Icon names matching the search query              |
| `GET`  | `/search/term`                 | SVG grid composition        | Visual grid of icons matching the search term     |
| `GET`  | `/search/term?perline=N`       | SVG grid composition        | Search results with N icons per row (default: 15) |
| `GET`  | `/icons`                       | SVG grid composition        | Visual representation of all icons                |
| `GET`  | `/icons?q=term`                | JSON array of matches       | Search results in JSON format                     |
| `GET`  | `/icons/name1,name2`           | SVG grid composition        | Custom grid with specified icons only             |
| `GET`  | `/icons/name1,name2?sort`      | SVG grid composition        | Custom grid with icons sorted alphabetically      |
| `GET`  | `/icons/name1,name2?perline=N` | SVG grid composition        | Custom grid with N icons per row (default: 15)    |
| `GET`  | `/icons/name1,name2?duplicate` | SVG grid composition        | Custom grid allowing duplicate icons in the list  |
| `GET`  | `/i/*`                         | Varies (same as `/icons/*`) | Shorthand alias for all `/icons/` endpoints       |

### `GET` `/count`


```text
386
```
### `GET` `/list`


```text
adobe,after-effects,amp,android,angular,animate,animejs,ant,anthropic,apple,arc,arch,asana,astro,auk-browser,aws,axios,azure,babel,baseui,basewell,bash,binance,bing,biome,bitwarden,blender,blitz,bluesky,bolt,bootstrap,brave,build-ship,builder,bun,burning-hacker,c,canva,carrd,centos,chartjs,chrome,chromium,class-widgets,classisland,clerk,cloudflare,cobol,codesandbox,codium,cody,cohere,color4bg,convex,cpp,crossplane,csharp,css,cursor,cypress,dailydev,daisyui,dart,debian,deepin,deepseek,dify,dioxus,directus,django,docker,docusaurus,dotenv,dotenvx,drizzle,dropbox,duckduckgo,eclipse-ide,edge,electron-vite,electron,elysiajs,ember,esbuild,eslint,excalidraw,expo,expressjs,facebook,fastapi,fastify,fedora,figma,firebase-studio,firefox,flashlist,flask,fleet,flowbite,flowith,flutter,fortran,foundation-agents,framermotion,fresh,front,fumadocs,fusionapp,gatsby,gemini,gimp,gin,git,github-copilot,github,gitlab,gleam,gmail,go,google-palm,graphql,grok,groq,grpc,gsap,hashnode,haskell,hcaptcha,headlessui,heroui,home-assistant,homebrew,hono,hoppscotch,html,huggingface,hume,i18next,idea,illustrator,indesign,inflection,infojobs,inlang,inspira-ui,instagram,jasmine,java,javascript,jest,jetbrains,jquery,json,julia,jwt,kernelsu,klpbbs,kortix,kotlin,krakenjs,kubernetes,labelstudio,laravel,legend,lightroom,linkedin,linux,lit,lmstudio,locofy,loom,lovart,lsposed,lua,lunacy,lynx,magisk,mantine,manus,mariadb,markdown,mastodon,matlab,matrix,mattermost,mcp,mdn,mediawiki,mermaid,messenger,mgx,microsoft-sql-server,microsoft-todo,midday,mintlify,mistral,mongodb,monica,motion,mui,mysql,neon,neovim,nestjs,netlify,nextjs,nextra,nitro,nodejs,notion,npm,nuxtjs,obs,obsidian,ollama,open-webui,openai,openhands,openmanus,openrouter,opensuse,opera,outlook,oxc,pandacss,parcel,payload,perplexity,photo-editor,photoshop,php,phpstorm,pinia-plugin-persistedstate,pinia,planetscale,playstation,playwright,pnpm,pocketbase,polar,poper,popos,postgresql,postman,powershell,powertoys,preact,premiere,prettier,prisma,pycharm,python,qt,qwen,qwik,r,radixui,railway,rapid-api,raspberry-pi,raycast,react-query,react-router,react,reactbits,reactnavigation,redhat,redis,redux,refine,reflex,refly,remix,remotion,replit,rider,rolldown,rowy,rspeedy,ruby,rubymine,rust,rxjs,safari,salvo,sass,scala,sequelize,shadcn,shiki,shopify,slack,smartteach-union,socket,solidity,solidjs,soybean-sec,space,spark-lab,spring,sqlite,sst,stack-overflow,stackblitz,steam,stimulus,storyblok,storybook,strapi,sublime-text,suno,supabase,surrealdb,svelte,svg,swagger,swift,swr,tabby,tailwindcss,tamagui,tanstack,taro,tauri,tensorflow,terraform,threejs,tina,tldraw,tor,trpc,turbo,turbopack,turso,twilio,typegpu,typeorm,typescript,typesense,ubuntu,udacity,uiverse,unity,unocss,unreal-engine,upstash,v0,vastsea,vb,vercel,vim,visual-studio-code,visual-studio,visx,vite,vitest,vivaldi,void,vscodium,vue-data-ui,vue-vine,vue,vuetify,vueuse,warp,web-components,webflow,webkit,webstorm,windicss,windows,windsurf,wordpress,workos,xai,xcode,xbox,xd,yarn,ygeeker,zed,zen-browser,zig,zod,zoom,zustand
```
### `GET` `/all`


```md
<!-- Github Profile -->

[![MOBAIcons](https://mobaicons.com/all)](https://mobaicons.com/)
```

[![MOBAIcons](https://mobaicons.com/all)](https://mobaicons.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---