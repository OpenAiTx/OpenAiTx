<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## 简介

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) 是一个生产环境就绪的后台前端解决方案。它基于 [vue](https://github.com/vuejs/vue)，使用了 UI 组件库 [element-ui](https://github.com/ElemeFE/element)。

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) 基于最新版的 vue 开发栈，内置 i18n 国际化解决方案，包含企业级应用常用模板和诸多优秀特性，助力你快速搭建大型复杂的单页应用。无论你的需求是什么，这个项目都能帮到你。

- [在线预览](https://panjiachen.github.io/vue-element-admin)

- [文档](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [捐赠](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) 国内用户可访问该地址在线预览

- 基础模板推荐使用：[vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- 桌面端：[electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript：[vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (鸣谢: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**`v4.1.0+` 版本起，默认 master 分支不再支持 i18n，请使用 [i18n 分支](https://github.com/PanJiaChen/vue-element-admin/tree/i18n)，该分支会保持与 master 分支同步更新。**

**当前版本为 `v4.0+`，基于 `vue-cli` 构建。如果发现问题请提 [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new)。如果你需要旧版本，可以切换到 [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0) 分支，该版本不依赖 `vue-cli`。**

**本项目不支持低版本浏览器（如 IE），如需兼容请自行添加 polyfill。**

## 准备工作

你需要在本地安装 [node](https://nodejs.org/) 和 [git](https://git-scm.com/)。本项目基于 [ES2015+](https://es6.ruanyifeng.com/)、[vue](https://cn.vuejs.org/index.html)、[vuex](https://vuex.vuejs.org/zh-cn/)、[vue-router](https://router.vuejs.org/zh-cn/)、[vue-cli](https://github.com/vuejs/vue-cli)、[axios](https://github.com/axios/axios) 以及 [element-ui](https://github.com/ElemeFE/element)，所有请求数据使用 [Mock.js](https://github.com/nuysoft/Mock) 模拟。提前了解并学习这些知识将大大有助于你使用本项目。

[![在 CodeSandbox 上编辑](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## 赞助商

成为赞助商，在我们的 GitHub README 上展示你的 Logo，并链接到你的网站。[[成为赞助商]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>为 Vue 后台管理获取 Java 后端，使用优惠码 SWB0RAZPZR1M 立享 20% 折扣，仅需 39 美元
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>使用 Vue、React 和 Angular 制作的管理后台模板。</p>

## 功能

```
- 登录 / 注销

- 权限认证
  - 页面权限
  - 指令权限
  - 权限配置页面
  - 两步登录

- 多环境构建
  - 开发（dev）
  - 测试（sit）
  - 预发布（stage）
  - 生产（prod）

- 全局功能
  - 国际化（I18n）
  - 多动态主题
  - 动态侧边栏（支持多级路由）
  - 动态面包屑
  - 标签视图（Tab 页支持右键操作）
  - Svg 雪碧图
  - Mock 数据
  - 全屏
  - 响应式侧边栏

- 编辑器
  - 富文本编辑器
  - Markdown 编辑器
  - JSON 编辑器

- Excel
  - 导出 Excel
  - 上传 Excel
  - 可视化 Excel
  - 导出 zip

- 表格
  - 动态表格
  - 拖拽表格
  - 内联编辑表格

- 错误页面
  - 401
  - 404

- 组件
  - 头像上传
  - 返回顶部
  - 拖拽 Dialog
  - 拖拽选择
  - 拖拽看板
  - 拖拽列表
  - 分割面板
  - Dropzone
  - 粘性
  - CountTo

- 高级示例
- 错误日志
- 仪表盘
- 引导页
- ECharts
- 剪贴板
- Markdown 转 html
```

## 快速上手

```bash
# 克隆项目
git clone https://github.com/PanJiaChen/vue-element-admin.git

# 进入项目目录
cd vue-element-admin

# 安装依赖
npm install

# 启动开发环境
npm run dev
```

这将自动打开 http://localhost:9527

## 构建

```bash
# 构建测试环境
npm run build:stage

# 构建生产环境
npm run build:prod
```

## 进阶

```bash
# 预览发布环境效果
npm run preview

# 预览发布环境效果 + 静态资源分析
npm run preview -- --report

# 代码格式检查
npm run lint

# 代码格式检查并自动修复
npm run lint -- --fix
```

更多信息请参考 [文档](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html)

## 更新日志

每个版本的详细更改记录在 [发布说明](https://github.com/PanJiaChen/vue-element-admin/releases)。

## 在线演示

[在线预览](https://panjiachen.github.io/vue-element-admin)

## 捐赠

如果你觉得这个项目有用，可以请作者喝一杯果汁 :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## 浏览器支持

现代浏览器及 Internet Explorer 10+。

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 最近 2 个版本 | 最近 2 个版本 | 最近 2 个版本 |

## 许可证

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

版权所有 (c) 2017-present PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---