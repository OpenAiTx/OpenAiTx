# F2C MCP 서버 
![MCP Server](https://badge.mcpx.dev?type=server 'MCP Server')
[![smithery badge](https://smithery.ai/badge/@f2c-ai/f2c-mcp)](https://smithery.ai/server/@f2c-ai/f2c-mcp)
[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![github][github-src]][github-href]
[![node][node-src]][node-href]


[npm-version-src]: https://img.shields.io/npm/v/@f2c/mcp?style=flat&colorA=18181B&colorB=F0DB4F
[npm-version-href]: https://npmjs.com/package/@f2c/mcp
[npm-downloads-src]: https://img.shields.io/npm/dm/@f2c/mcp?style=flat&colorA=18181B&colorB=F0DB4F
[npm-downloads-href]: https://npmjs.com/package/@f2c/mcp
[github-src]: https://img.shields.io/badge/github-@f2c/mcp-blue?style=flat&colorA=18181B&colorB=F0DB4F
[github-href]: https://github.com/f2c-ai/f2c-mcp
[node-src]: https://img.shields.io/node/v/@f2c/mcp?style=flat&colorA=18181B&colorB=F0DB4F
[node-href]: https://nodejs.org/en/about/previous-releases

English | [简体中文](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/./README-zh-CN.md)

[F2C](https://f2c.yy.com/)를 이용한 Figma Design to Code를 위한 모델 컨텍스트 프로토콜 서버입니다.

<a href="https://glama.ai/mcp/servers/@f2c-ai/f2c-mcp">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/@f2c-ai/f2c-mcp/badge" alt="f2c-mcp-server MCP server" />
</a>

## 특징
<img alt="f2c" src="https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/bannerv3.png" />

- 🎨 픽셀-퍼펙트 HTML/CSS: F2C는 Figma 디자인을 정밀하게 픽셀-퍼펙트 HTML/CSS로 변환합니다.
- ⚛️ 멀티 프레임워크 지원: F2C는 React, CSS Modules, Tailwind CSS 코드를 빠르게 생성합니다.
- 🧠 Figma 디자인 컨텍스트: F2C는 디자인 컨텍스트를 통합하여 Cursor와 같은 AI 도구와의 호환성을 보장합니다.
- 🔗 Figma 파일 URL 파싱: F2C는 Figma URL을 통해 디자인 노드를 변환하여 워크플로우를 간소화합니다.
- 🖼️ 원격 이미지 로컬라이제이션: F2C는 Figma 이미지를 자동으로 로컬 에셋으로 다운로드하여 효율성을 높입니다.

## 동작 방식
1. MCP를 지원하는 IDE(예: Cursor, Trae)에서 [서버 구성](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/GettingStarted.md)을 완료합니다.
2. IDE에서 채팅을 엽니다(예: Cursor의 agent 모드).
3. Figma Layer 패널에서 원하는 노드를 우클릭하여 링크를 복사한 후 붙여넣습니다.
4. 노드 데이터 가져오기, 이미지 다운로드, 코드 변환 등 원하는 요구사항을 채팅에 입력합니다.

## 구성 및 개발

[구성 및 개발](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/GettingStarted.md) 문서를 참고하세요.

## FAQ
[FAQ](https://raw.githubusercontent.com/f2c-ai/f2c-mcp/main/docs/en/FAQ.md) 문서를 참고하세요.

## 크레딧

감사의 말씀:

+ [Framelink Figma MCP Server](https://github.com/GLips/Figma-Context-MCP) 이 모델 컨텍스트 프로토콜 서버로 Cursor 및 기타 AI 기반 코딩 도구에서 Figma 파일에 접근할 수 있습니다.
+ [Cursor Talk to Figma MCP](https://github.com/sonnylazuardi/cursor-talk-to-figma-mcp) Cursor가 Figma와 통신하여 디자인을 읽고 프로그래밍 방식으로 수정할 수 있도록 지원합니다.
+ [Figma MCP Server](https://github.com/MatthewDailey/figma-mcp) 이 서버는 ModelContextProtocol을 통해 Figma 디자인을 직접 보고, 댓글을 달고, 분석할 수 있는 도구를 제공합니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---