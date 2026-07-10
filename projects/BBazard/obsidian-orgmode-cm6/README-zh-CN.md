# Obsidian Orgmode CM6

[Orgmode](https://orgmode.org) 适用于 [Obsidian](https://obsidian.md)。

![截图](https://raw.githubusercontent.com/BBazard/obsidian-orgmode-cm6/master/./screenshot.png)

## 使用方法

默认情况下，侧边栏不显示 org 文件。
要显示它们，您需要进入 Obsidian 设置，找到“文件和链接”部分，勾选“检测所有文件扩展名”。

![detect-all-file-extensions](https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/e6a91e66-295d-4057-bf80-e43dcdb8e3e7)

要在您的库中创建 org 文件，目前必须在 Obsidian 外部创建，因为 Obsidian 不允许创建非 Markdown 文件。

如果您还没有 org 文件，试着创建一个名为 `todo.org` 的文件，内容如下：

```org
* TODO [#A] A task with *high* priority

The description of the task

* A collapsed section

You cannot see the description when collapsed

* DONE something done already :sometag:
SCHEDULED: <2023-12-08 Fri 11:13>
:PROPERTIES:
:CREATED: [2023-12-03 Sun 10:48]
:END:

a [[https://github.com/BBazard/obsidian-orgmode-cm6][link]]

#+begin_src javascript
const block = "highlighted"
#+end_src
```
## 支持的功能

### Orgmode 编辑器

- 实时预览
- 语法高亮（支持可覆盖的 css 类）
- 设置中可自定义待办关键词
- 折叠（点击元素首行的左侧空白区域即可折叠）
- 维基链接（`[[unicorn]]` 会打开 vault 中的 unicorn.org 文件，若无则回退到 unicorn.md）
- 内联图片（`[[myimage.png]]` 会显示 vault 中存在的图片）
- ID 链接（`[[id:12345]]` 会跳转到 vault 中任意 org 文件中属性抽屉内匹配 :ID: 的标题）
- Vim 支持（若在 Obsidian 中激活）
- 代码块高亮（支持：c、c++、css、html、java、javascript、json、php、python、rust、sass、xml）

### Orgmode 解析器（语法高亮）

遵循 [Org 语法](https://orgmode.org/worg/org-syntax.html)

- [x] 标题（支持嵌套，不支持 COMMENT 标题）
- [x] 区块（包括第零区块）
- [x] 文本标记（加粗、斜体、下划线等）
- [x] 链接（普通链接、尖括号链接、纯文本链接）
- [x] 标记与链接组合
- [x] 注释行
- [x] 关键词行
- [x] 计划行
- [x] 属性抽屉
- [x] 较小的区块（除代码块外无格式）
- [ ] 动态区块（因 Obsidian 不允许插件任意执行，故不可用）
- [ ] 抽屉
- [ ] 列表与复选框
- [ ] 分隔线
- [ ] 时间戳
- [ ] 计时器
- [ ] 日记 Sexp
- [ ] 脚注
- [ ] 表格
- [ ] Latex
- [ ] : 固定宽度行（可改用区块实现）

## 实现细节

- orgmode 文件由一个独立于 markdown 文件使用的 [codemirror 6](https://codemirror.net) 实例处理。这意味着插件必须重新实现所有适用于 markdown 文件的功能。

- 解析器通过使用带有自定义分词器的 [lezer](https://lezer.codemirror.net) 语法读取 orgmode 文件并构建语法节点树。这种方法比 Emacs 的基于正则表达式的方法更能精确匹配标记。例如，计划行只会在标题之后匹配，而不会在章节中间匹配。

- 不允许标记重叠。例如：`*one _two three* four_`。Emacs 使用正则表达式会将 `*one _two three*` 识别为加粗，将 `_two three* four_` 识别为下划线。而 lezer 解析器则将 `*one _two three*` 识别为加粗，将 ` four_` 识别为普通文本，这使得文本标记范围可以作为其自身的语法节点。

- 标题级别无限制（因此没有 Inlinetask），文本标记的行数也没有限制。

## 在 markdown 文件中显示 orgmode 任务

此功能尚不稳定，未来可能会有重大更改。

当前仅支持 TODO 和 DONE。

https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/b071b2c8-b56e-4050-8fcf-02a922fdd1c0

支持过滤，[orgzly 搜索表达式](https://www.orgzly.com/docs#search)（已实现：s, d, c, i, it, ad）。


```orgmode-tasks
filepath: Orgmode/Orgmode file.org
query: it.todo or it.done
```

## 开发

```
git clone https://github.com/bbazard/obsidian-orgmode-cm6
cd obsidian-orgmode-cm6
npm install
npm run build
npm test
cp main.js styles.css manifest.json "$OBSIDIAN_VAULT"/.obsidian/plugins/obsidian-orgmode-cm6/
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---