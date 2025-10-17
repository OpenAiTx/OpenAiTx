# Winger - 一个窗口管理器

命名窗口，切换窗口，在窗口之间移动标签页，等等。一个 Firefox 网络扩展，用于流畅操作多个窗口并组织标签页。

从这里安装 Winger：https://addons.mozilla.org/firefox/addon/winger/

## 代码和文档约定

### 术语

- `active` 标签页是“聚焦”的
- `highlighted` 标签页是“选中的”

### 变量命名

- 大多数变量和函数采用 camelCase 风格
- 类、模块和命名空间对象（将相关函数组合在一起，硬编码）通常采用 PascalCase
- 硬编码常量通常采用 UPPER_SNAKE_CASE
- 存储键通常采用 lower_snake_case
- 数组通常是复数形式
- 对象通常是单数形式
- 用于组合事物的对象（而非表示单一事物）通常以 `Dict` 结尾
- 仅在其对象内部引用的对象属性通常以 `_` 前缀
- 映射通常以 `Map` 结尾
- 集合通常以 `Set` 结尾
- 布尔值通常以 `is` 和 `has` 等词前缀
- DOM 节点及其集合通常以 `$` 前缀
- 标准内置对象（如数组、DOM 节点）中的自定义属性（又称 expandos）以 `_` 前缀，若引用 DOM 节点则以 `$` 前缀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---