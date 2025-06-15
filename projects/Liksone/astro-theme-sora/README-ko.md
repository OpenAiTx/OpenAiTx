<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Astro 블로그 테마</p>
<p>Sora는 「穹」을 의미하며, 무한한 가능성과 넓은 창의력을 상징합니다</p>
<p>이 테마가 마음에 드신다면 🌟Star를 눌러주세요!</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# 미리보기

[My Blog](https://blog.liks.space)

## 누가 사용하고 있나요

[Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml)를 제출하여 본인의 사이트를 소개해 주세요.

# 시작하기

1. 테마 설치

   - [pnpm](https://pnpm.io/installation) 설치
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - 프로젝트 디렉터리로 이동 후, `pnpm dev`를 실행하여 프로젝트 시작

2. 테마 설정

   설정 파일 `theme.config.ts`를 수정하여 테마를 커스터마이즈합니다. 자세한 내용은 [설정](#설정) 참고.

3. 글 작성

   `src/content/` 디렉터리에서 작성, Markdown 형식 지원.

4. 사이트 배포

   `pnpm build`를 실행하여 사이트를 빌드하면, 결과물이 `dist/` 디렉터리에 생성됩니다. `pnpm preview`로 로컬에서 미리보기 가능.

   서버에 직접 배포하거나, [Astro 문서](https://docs.astro.build/en/guides/deploy/)를 참고하여 Vercel, Netlify, GitHub Pages 등 호스팅 플랫폼에 배포할 수 있습니다.

<!-- # 문서 -->

# 설정

설정 파일은 `theme.config.ts`입니다.

## 사이트 정보

```typescript
site: {
  // 사이트 주소
  url: "https://blog.liks.space",
  // 사이트 제목
  title: "Sora",
  // 사이트 관리자 이름
  author: "Liks",
  // 사이트 소개
  description: "A blog theme built with Astro",
  // 사이트 아이콘
  // SVG, PNG, ICO 형식 지원
  // public/ 디렉터리 내의 로컬 파일 경로
  favicon: "/images/favicon.ico",
}
```

## 글로벌 설정

```typescript
global: {
  // 아바타
  // src/images/ 디렉터리 내의 로컬 파일 경로
  avatar: "avatar.jpg",
  // RSS 활성화
  rss: true,
  // 다국어 지원 활성화 (개발 중)
  i18n: true,
}
```

## 네비게이션 바

```typescript
nav: [
  {
    // 페이지 이름
    name: "归档",
    // 페이지 주소
    url: "/archives",
  },
  {
    name: "分类",
    url: "/categories",
  },
  {
    name: "标签",
    url: "/tags",
  },
  {
    name: "关于",
    url: "/about",
  },
  ...
];
```

## 푸터

```typescript
footer: {
  // 저작권
  copyright: {
    // 사이트 개설 연도
    time: "2024 - 2025",
    // 저작권 소유자
    owner: "Liks",
  },
  // 등록(중국 전용)
  beian: {
    // ICP 등록
    icp: {
      // 활성화
      enabled: false,
      // 등록번호
      number: "京 ICP 备 12345678 号",
    },
    // 공안 등록
    police: {
      // 활성화
      enabled: false,
      // 등록번호
      number: "京公网安备 12345678901234 号",
      // 등록 사이트
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## 메인 페이지

```typescript
index: {
  // 소셜 미디어
  social: [
    {
      // 이름
      name: "GitHub",
      // 활성화
      enabled: true,
      // 주소
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, 웨이보, 샤오홍슈, 즈후 지원.

## 글 페이지

```typescript
post: {
  // 저작권 라이선스
  copyright: {
    // CC 라이선스
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // 라이선스 주소
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## 후원

```typescript
sponsor: {
  // 활성화
  enabled: true,
  // 알리페이 QR코드
  alipay: {
    // 활성화
    enabled: true,
    // src/images/ 디렉터리 내의 로컬 파일 경로
    image: "alipay.png",
  },
  // 위챗 QR코드
  wechat: {
    enabled: false,
  },
  // 후원자 명단 표시
  list: true,
}
```

## 댓글

```typescript
comment: {
  // 활성화
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // 백엔드 서버 주소
    server: "https://artalk.example.com",
    // 사이트 이름
    site: "Sora",
  },
}
```

## 도구

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // 활성화
    enabled: false,
    // 서버 주소
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# 라이선스

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# 감사의 글

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---