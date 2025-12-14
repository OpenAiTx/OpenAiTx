<div align="center">
    <h1>GitQuill</h1>
    <img alt="Logo" src="https://raw.githubusercontent.com/adamsol/GitQuill/master/img/logo.jpg" width="200" />
    <h2>跨平台的 Git 图形界面。</h2>
</div>

| ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/commit-history.png) | ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/file-diff.png) |
|-----------------------------------------|------------------------------------|


独特功能
---------------

* 在差异视图中直接编辑文件。
* 为文件扩展名选择特定的语法高亮。
* 使用变基工具快速修改历史提交。
* 配置从提交信息链接到你的问题跟踪器。
* 配置按钮，一键执行任何 Git 命令。


要求
------------

* [Git](https://git-scm.com/) 2.23+
* [Node.js](https://nodejs.org/) 18+


安装
-----------

```sh
npm install
npm run build
npm start
```
备注
-----

* GitQuill 使用自定义机制通过分支保存/恢复工作进度（WIP），而非传统的暂存；这是因为 Git 的暂存存在技术上的怪癖，难以在 UI 中一致地集成。
* 如果在选中文件时启动变基，GitQuill 会将索引中的整个提交内容还原，但保持在工作区，以便您无需离开应用即可编辑文件。
* 检测到冲突时，GitQuill 会自动重置未合并的文件，以避免特殊的仓库状态带来的复杂处理。冲突标记仍需手动解决。
* GitQuill 不会监视仓库文件的变更。状态会在应用获得焦点或执行相关 UI 操作时刷新。
* GitQuill 直接调用 `git` 命令。您可以在每个仓库的日志文件中查看所有执行的操作：`.git/.quill/app.log`。


配置
-------------

* 每个仓库的配置文件：`.git/.quill/config.json5`。示例：



  ```js
  {
      autolinks: [
          ['#(\\d+)', 'https://github.com/adamsol/GitQuill/issues/$1'],
      ],
      custom_actions: [
          { icon: 'mdi-download-outline', label: 'Pull', command: ['pull'] },
          { icon: 'mdi-upload-outline', label: 'Push', command: ['push'], click_twice: true },
      ],
  }
  ```

* 全局自动配置文件（打开仓库、UI布局等）：Windows系统位于 `%AppData%/GitQuill/config.json`；其他平台请参见 https://electronjs.org/docs/api/app#appgetpathname。


贡献
------------

感谢您对本项目的关注！我通常不接受拉取请求。最好的贡献方式是通过[问题](https://github.com/adamsol/GitQuill/issues)报告错误或建议新功能。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---