# Jimmy's Blog

Next.js 15+ をベースに構築されたシンプルな個人ブログシステム。

## 技術スタック

- **フレームワーク**: Next.js 13+ (App Router)
- **スタイル**: Tailwind CSS
- **アイコン**: Lucide Icons
- **テーマ**: ダークモード / ライトモード切替対応
- **デプロイ**: Vercel

## 機能特徴

- 📝 Markdown 記事対応
- 🌓 ダーク / ライトテーマ切替
- 📱 レスポンシブデザイン
- ⚡ 高速読み込み
- 📅 記事タイムライン表示

## プロジェクト構成

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

## インストールと実行

1. プロジェクトをクローンする

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```
2. 依存関係のインストール


```bash
npm install
```
3. 開発サーバーの起動


```bash
npm run dev
```
4. プロダクションビルドの作成


```bash
npm run build
```

## 新しい記事を追加する

1. `content/posts` ディレクトリに新しい Markdown ファイルを作成する
2. ファイル命名規則：xxx.md
3. ファイルの先頭にメタデータを追加する：

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## 随筆を追加する

1. `content/notes` ディレクトリに新しいMarkdownファイルを作成する
2. ファイル命名形式：`YYYY-MM-DD-title.md`
3. ファイルの先頭にメタデータを追加する：

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