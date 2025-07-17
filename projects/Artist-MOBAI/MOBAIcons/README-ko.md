<translate-content>[![MOBAIcons](https://mobaicons.com/about)](https://mobaicons.com/)
[![MOBAIcons](https://raw.githubusercontent.com/Artist-MOBAI/MOBAIcons/main/./src/docs/image/author.svg)](https://mobaicons.com/)

<!-- [![API 상태](https://img.shields.io/badge/API-Online-green)](https://mobaicons.com)
[![라이선스](https://img.shields.io/badge/License-MIT-blue.svg)](./LICENSE)
[![GitHub 별](https://img.shields.io/github/stars/Artist-MOBAI/MOBAIcons)](https://github.com/Artist-MOBAI/MOBAIcons) -->

### `GET` `/icons/name1,name2`
</translate-content>
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

| 메서드 | 엔드포인트                     | 반환값                      | 설명                                              |
| ------ | ------------------------------ | --------------------------- | ------------------------------------------------- |
| `GET`  | `/count`                       | 일반 텍스트 숫자            | 사용 가능한 아이콘의 총 개수                        |
| `GET`  | `/all`                         | SVG 그리드 구성             | 사용 가능한 모든 아이콘을 포함한 전체 그리드        |
| `GET`  | `/list`                        | 쉼표로 구분된 텍스트        | 모든 아이콘 이름을 일반 텍스트 형식으로 제공        |
| `GET`  | `/list?json`                   | 문자열의 JSON 배열          | 구조화된 JSON 데이터로 모든 아이콘 이름 제공        |
| `GET`  | `/search?q=term`               | 일치하는 항목의 JSON 배열   | 검색어와 일치하는 아이콘 이름                        |
| `GET`  | `/search/term`                 | SVG 그리드 구성             | 검색어와 일치하는 아이콘의 시각적 그리드             |
| `GET`  | `/search/term?perline=N`       | SVG 그리드 구성             | 행당 N개의 아이콘이 표시된 검색 결과 (기본값: 15)    |
| `GET`  | `/icons`                       | SVG 그리드 구성             | 모든 아이콘의 시각적 표현                           |
| `GET`  | `/icons?q=term`                | 일치하는 항목의 JSON 배열   | JSON 형식의 검색 결과                               |
| `GET`  | `/icons/name1,name2`           | SVG 그리드 구성             | 지정된 아이콘만 포함하는 맞춤 그리드                  |
| `GET`  | `/icons/name1,name2?sort`      | SVG 그리드 구성             | 알파벳 순서로 정렬된 맞춤 아이콘 그리드               |
| `GET`  | `/icons/name1,name2?perline=N` | SVG 그리드 구성             | 행당 N개의 아이콘이 표시된 맞춤 그리드 (기본값: 15)   |
| `GET`  | `/icons/name1,name2?duplicate` | SVG 그리드 구성             | 리스트에 중복 아이콘이 허용된 맞춤 그리드               |
| `GET`  | `/i/*`                         | 다양 ( `/icons/*`와 동일)   | 모든 `/icons/` 엔드포인트의 축약 별칭                 |

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