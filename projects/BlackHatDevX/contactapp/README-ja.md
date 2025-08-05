# Contacts App

React、TypeScript、Tailwind CSSで構築された連絡先アプリケーション。

## 🌐 ライブデモ

**[ライブアプリを見る](https://contactapp-pi.vercel.app/)**

## 🛠️ 技術スタック

> VITE、React、TypeScript、Tailwind CSS、React Router DOM

## 🚀 ルート（react-router-dom使用）

```
<Route path="/" element={<Home />} />
<Route path="/about" element={<About />} />
```

## 📦 このプロジェクトをローカルで実行する方法

```bash
git clone https://github.com/BlackHatDevX/contactapp
cd contactapp
yarn install
yarn dev
```

## 🏗️ 本番用アプリのビルド方法

```bash
yarn build
(app will be available in dist)
```

## 📁 プロジェクト構成

```
.
├── eslint.config.js
├── index.html
├── package.json
├── public
│   └── vite.svg
├── readme.md
├── src
│   ├── App.tsx
│   ├── assets
│   │   └── react.svg
│   ├── components
│   │   └── ContactDataRenderer.tsx
│   ├── index.css
│   ├── main.tsx
│   ├── pages
│   │   └── home.tsx
│   └── vite-env.d.ts
├── tsconfig.app.json
├── tsconfig.json
├── tsconfig.node.json
├── vite.config.ts
└── yarn.lock
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---