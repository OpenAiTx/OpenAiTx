[![MOBAIcons](https://mobaicons.com/about)](https://mobaicons.com/)
[![MOBAIcons](https://raw.githubusercontent.com/Artist-MOBAI/MOBAIcons/main/./src/docs/image/author.svg)](https://mobaicons.com/)

<!-- [![API 状态](https://img.shields.io/badge/API-在线-green)](https://mobaicons.com)
[![许可证](https://img.shields.io/badge/许可证-MIT-blue.svg)](./LICENSE)
[![GitHub 星标](https://img.shields.io/github/stars/Artist-MOBAI/MOBAIcons)](https://github.com/Artist-MOBAI/MOBAIcons) -->

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
[![MOBA图标](https://mobaicons.com/search/vue)](https://mobaicons.com/)

| 方法   | 端点                         | 返回值                      | 描述                                               |
| ------ | ---------------------------- | --------------------------- | -------------------------------------------------- |
| `GET`  | `/count`                     | 纯文本数字                  | 可用图标的总数量                                    |
| `GET`  | `/all`                       | SVG 网格组合                | 包含所有可用图标的完整网格                          |
| `GET`  | `/list`                      | 逗号分隔文本                | 所有图标名称的纯文本格式                            |
| `GET`  | `/list?json`                 | 字符串的 JSON 数组          | 以结构化 JSON 数据形式的所有图标名称               |
| `GET`  | `/search?q=term`             | 匹配结果的 JSON 数组        | 匹配搜索查询的图标名称                              |
| `GET`  | `/search/term`               | SVG 网格组合                | 匹配搜索词的图标视觉网格                            |
| `GET`  | `/search/term?perline=N`     | SVG 网格组合                | 搜索结果每行 N 个图标（默认：15）                   |
| `GET`  | `/icons`                     | SVG 网格组合                | 所有图标的视觉表示                                  |
| `GET`  | `/icons?q=term`              | 匹配结果的 JSON 数组        | JSON 格式的搜索结果                                 |
| `GET`  | `/icons/name1,name2`         | SVG 网格组合                | 仅包含指定图标的自定义网格                          |
| `GET`  | `/icons/name1,name2?sort`    | SVG 网格组合                | 按字母顺序排序的自定义图标网格                      |
| `GET`  | `/icons/name1,name2?perline=N` | SVG 网格组合              | 每行 N 个图标的自定义网格（默认：15）               |
| `GET`  | `/icons/name1,name2?duplicate` | SVG 网格组合              | 允许列表中重复图标的自定义网格                      |
| `GET`  | `/i/*`                       | 多样（与 `/icons/*` 相同）  | `/icons/` 所有端点的简写别名                        |

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