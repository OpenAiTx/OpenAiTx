# Jimmy's Blog

Next.js 15+를 기반으로 구축된 간결한 개인 블로그 시스템입니다.

## 기술 스택

- **프레임워크**: Next.js 13+ (App Router)
- **스타일**: Tailwind CSS
- **아이콘**: Lucide Icons
- **테마**: 다크/라이트 모드 지원
- **배포**: Vercel

## 기능 특징

- 📝 Markdown 문서 지원
- 🌓 다크/라이트 테마 전환
- 📱 반응형 디자인
- ⚡ 빠른 로딩
- 📅 글 타임라인 표시

## 프로젝트 구조

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```
## 설치 및 실행

1. 프로젝트 클론하기


```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. 의존성 설치

```bash
npm install
```
3. 개발 서버 실행


```bash
npm run dev
```

4. 프로덕션 빌드 생성

```bash
npm run build
```

## 새 글 추가

1. `content/posts` 디렉토리에 새로운 Markdown 파일 생성
2. 파일 이름 형식: xxx.md`
3. 파일 상단에 메타데이터 추가:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## 에세이 추가

1. `content/notes` 디렉토리에 새로운 Markdown 파일 생성
2. 파일 이름 형식: `YYYY-MM-DD-title.md`
3. 파일 상단에 메타데이터 추가:

```markdown
---
date: YYYY-MM-DD
---
```

## 部署

项目已配置 Vercel 部署，支持自动部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建和部署。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---