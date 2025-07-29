# httpc
httpc는 최소한의 코드와 종단 간 타입 안전성으로 함수 기반 API를 구축하기 위한 자바스크립트/타입스크립트 프레임워크입니다.
- [문서 및 튜토리얼](https://httpc.dev/docs)
- [커뮤니티](https://httpc.dev/discord)
- [이슈 및 기능 요청](https://httpc.dev/issues)

## 빠른 개요
함수를 작성하고 내보내기만 하면 됩니다. 서버가 이를 어떻게 실행할지 걱정할 필요가 없습니다.
```ts
function add(a: number, b: number) {
    return a + b;
}

function greet(name: string) {
    return `Hello ${name}`;
}

export default {
    add,
    greet,
}
```
클라이언트에서는 자연스러운 문법으로 일반 자바스크립트 함수처럼 서버 함수를 호출할 수 있습니다.

```ts
import createClient from "@your-package/api-client";

const client = createClient({
    endpoint: "http://api.domain.com"
});

let result = await client.add(1, 2);
// result: 3

let message = await client.greet("Edith");
// message: "Hello Edith"
```
## 핵심 원칙
**httpc**는 표준 HTTP 프로토콜 위에 구축된 추상화입니다. **httpc**를 사용하면 HTTP 동사, 헤더, 리소스 경로, 데이터 직렬화가 아닌 함수, 인수 및 반환 값을 사용하는 API를 구축할 수 있습니다.

**httpc** 프레임워크는 기본 HTTP의 모든 복잡성을 숨기면서 중요한 것에 집중할 수 있게 합니다: 함수 로직입니다.


## 주요 기능
### 미들웨어
미들웨어를 통해 공통 로직을 실행합니다.

```ts
import { httpCall } from "@httpc/server";

const getPostById = httpCall(
    Authenticated(),    // <-- authentication check
    Validate(String),   // <-- parameters validation
    Cache("5m"),        // <-- result caching
    async (postId: string) => {
        const post = await db.select("posts").where("id", postId);
        if (!post) {
            throw new NotFoundError();
        }

        return post;
    }
);
```
### 컨텍스트의 편재성
애플리케이션 어디에서나 요청 컨텍스트에 접근할 수 있습니다. 핸들러, 미들웨어 또는 서비스 로직에 있든지 간에, 컨텍스트는 매개변수를 전달할 필요 없이 항상 사용할 수 있습니다.

```ts
async function getPosts() {
    const { user } = useContext();

    let category = "news";
    if (user) {
        category = user.preferredCategory;
        trace("Getting user preferred posts");
    }
    
    return await db.select("posts").where("category", category);
}

function trace(message: string) {
    const { requestId } = useContext();
    console.log(`[req:${requestId}] ${message}`);
}
```

### 훅(Hooks)
훅은 요청 컨텍스트 주변의 공통 로직을 캡슐화합니다. 관례적으로 훅은 `use` 접두사를 사용합니다.
```ts
async function addNewComment(postId: string, message: string) {
    const user = useUser();

    if (!useIsAuthorized("comment:create")) {
        throw new ForbiddenError("Cannot add comments");
    }

    return await db.createComment({
        userId: user.id,
        postId,
        message
    });
}
```
**@httpc/kit**는 데이터를 캐시하고, 권한 검사를 수행하며, 트랜잭션을 처리하기 위한 여러 내장 훅을 제공합니다…

### 서버리스
Vercel, AWS Lambda 또는 Netlify 함수와 같은 서버리스 환경 내에 전체 **httpc** API를 호스팅할 수 있습니다.
이는 전체 API를 처리하는 단일 서버리스 함수를 배포하는 이점을 제공합니다.

예를 들어 Vercel을 사용하면 모든 API 함수를 노출할 수 있습니다:
```ts
//file: api/index.ts

import { createHttpCVercelAdapter } from "@httpc/adapter-vercel";
import calls from "../calls";

export default createHttpCVercelAdapter({
    calls,
    log: "info"
});
```

그런 다음, 전체 타입 검사를 통해 페이지에서 API 함수를 호출할 수 있습니다:
```ts
//file: pages/home.tsx

import { createClient, ClientDef } from "@httpc/client";
import { useQuery, useMutation } from "react-query";
import type calls from "../calls"; // <-- import calls definition

// create a typed client
const client = createClient<ClientDef<typeof calls>>();

export default function Home() {
  const posts = useQuery(["posts"], () => client.posts.getLatest());

  return (
    <div class="container">
      {posts.data.map(post =>
        <div class="post">
          <h2>{post.title}</h2>
          <p>{post.text}</p>
        </div>
      )}
    </div>
  );
}
```    

### 광범위한 타입 안전성
자동 완성과 타입 검사를 유지하면서 내장 객체를 필요에 맞게 사용자 정의하세요.

요청 컨텍스트를 확장할 수 있습니다:
```ts
/// <reference types="@httpc/kit/env" />

interface IHttpCContext {
    // example custom property
    environment: string

    // other custom properties here
    // ...
}
```
확장할 수 있는 엔터티가 많이 있습니다. 예를 들어 사용자 객체를 사용자 정의 속성으로 재정의할 수 있습니다:
```ts
interface IUser {
    firstName: string
    lastName: string
}
```
내장 함수 및 훅은 사용자 정의를 받아 타입 검사를 통해 사용할 수 있습니다.
```ts
const { firstName } = useUser();
```

### 맞춤 클라이언트 생성
**@httpc/cli**를 사용하면 API에 맞는 특정 클라이언트를 생성할 수 있습니다. 생성된 클라이언트는 타입 안전성을 보장하며 개발자가 익숙한 자연스러운 문법으로 원활한 사용 경험을 제공합니다.
```ts
const user = await client.users.search("some@email.com");
const posts = await client.posts.getByUser(user.id);
const newComment = await client.posts.addComment(posts[0].id, {
    text: "Hello",
    userId: user.id
});
```
### httpc를 넘어서  
httpc 서버는 함수 호출에 국한되지 않습니다. 브라우저 폼 제출, 웹훅 콜백, 표준 리디렉션 등 일반적으로 모든 http 요청을 처리할 수 있습니다. `Parsers` (내장된 것이 많음)를 사용하여 서버가 요청을 처리하는 방식을 사용자 정의할 수 있습니다.  

표준 http 요청 처리는 클라이언트를 제어할 수 없는 시나리오에서 필수적입니다. **httpc 서버**는 함수 호출과 일반 http 요청 모두에 응답할 수 있습니다.  

## httpc 패밀리  
**@httpc/server**: 표준 http 프로토콜을 통한 함수 호출을 가능하게 하는 httpc 핵심 컴포넌트  

**@httpc/client**: httpc 서버가 노출한 함수와 안전하게 상호작용하기 위해 소비자가 사용하는 타입화된 인터페이스  

**@httpc/kit**: 인증, 검증, 캐싱, 로깅 같은 일반적인 사용 사례와 비즈니스 문제를 관리하기 위한 풍부한 내장 컴포넌트 툴박스  

**@httpc/cli**: 프로젝트 설정, 클라이언트 생성, 버전 관리 및 일반 작업 지원을 위한 명령어 집합  

**@httpc/adapter-\***: vercel, netlify functions, aws lambda 등 환경 내에서 httpc API를 호스팅하기 위한 다양한 [어댑터](https://httpc.dev/docs/adapters)  

## 프로젝트 상태  
**httpc**는 실험 단계입니다. 아직 초기 단계입니다. 시도해보고, 개인 프로젝트에 적용할 수 있습니다. 하지만 프로덕션용으로는 준비되지 않았습니다.  
<br />  
API는 아직 안정적이지 않습니다. 파괴적 변경이 발생할 수 있습니다.  
<br />  
**httpc**는 활발히 개발 중입니다. 향후 기능에 대해서는 [변경 로그](https://httpc.dev/changelog)와 [로드맵](https://httpc.dev/roadmap)을 확인할 수 있습니다.  

## 참여  
### 커뮤니티  
[Discord](https://httpc.dev/discord)에서 참여하여 개발 상황을 팔로우하고, 기여를 논의하며, 지원을 받거나 도움을 요청할 수 있습니다. [Github 토론](https://httpc.dev/discuss) 참여도 가능합니다.  

### 이슈 제기  
버그, 기능 요청 또는 제안 사항이 있으면 [이슈를 등록](https://httpc.dev/issues/new)할 수 있습니다. 모든 이슈는 [Github](https://httpc.dev/issues)에서 확인할 수 있습니다.  

### 기여  
모든 기여를 환영합니다. 모든 PR, 이슈, 피드백은 소중히 다룹니다. [기여 가이드](https://httpc.dev/contribute)를 확인하세요.  

## 라이선스  
MIT © [Giuseppe La Torre](https://github.com/giuseppelt)








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---