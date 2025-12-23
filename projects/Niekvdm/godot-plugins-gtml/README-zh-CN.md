# GTML - Godot 标记语言

一个适用于 Godot 4.x 的插件，允许你使用 HTML 和 CSS 构建 UI。使用熟悉的网页技术创建游戏菜单、HUD 和面板。

## 功能

- 基于 HTML 的 UI 结构，包含 20 多种元素类型
- 外部 CSS 样式，支持 80 多种属性
- 编辑器内实时重载
- Flexbox 布局系统
- 支持 SVG 渲染
- 带信号的表单元素
- CSS 过渡和伪类 (:hover、:active、:focus)
- 渐变背景和自定义字体

## 快速开始

### 1. 安装

将 `addons/gtml/` 复制到你的项目中，并在 **项目设置 → 插件** 中启用。

### 2. 创建文件

**menu.html:**
```html
<div class="menu">
    <h1>My Game</h1>
    <button @click="on_play">Play</button>
    <button @click="on_quit">Quit</button>
</div>
```

**menu.css:**
```css
.menu {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 16px;
    padding: 32px;
    background-color: #1a1a2e;
}

h1 {
    font-size: 32px;
    color: #ffffff;
}

button {
    padding: 12px 24px;
    background-color: #00d4ff;
    border-radius: 4px;
    color: #000000;
    transition: background-color 200ms ease;
}

button:hover {
    background-color: #00a8cc;
}
```

### 3. 添加 GmlView 节点

添加一个 `GmlView` 节点，并在检查器中设置 **Html 路径** 和 **Css 路径**。

### 4. 连接信号

```gdscript
func _ready():
    $GmlView.button_clicked.connect(_on_button_clicked)

func _on_button_clicked(method_name: String):
    match method_name:
        "on_play":
            get_tree().change_scene_to_file("res://game.tscn")
        "on_quit":
            get_tree().quit()
```
## 文档

- [入门指南](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/getting-started.md) - 安装和基本使用  
- [HTML 元素](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/html-elements.md) - 支持的标签和属性  
- [CSS 属性](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-properties.md) - 完整属性参考  
- [CSS 选择器](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/css-selectors.md) - 选择器和伪类  
- [表单与输入](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/forms-and-inputs.md) - 表单元素和事件  
- [SVG 支持](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/svg-support.md) - 矢量图形  
- [布局与 Flexbox](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/layout-and-flexbox.md) - 布局系统  
- [过渡效果](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/transitions.md) - CSS 过渡  
- [字体与排版](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/fonts-and-typography.md) - 自定义字体  
- [扩展 GTML](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/extending-gtml.md) - 添加新功能  
- [限制](https://raw.githubusercontent.com/Niekvdm/godot-plugins-gtml/master/docs/limitations.md) - 已知限制  

## 示例

查看 `addons/gtml/examples/` 获取可运行演示：  
- `basic` - 简单菜单  
- `all_elements` - 所有 HTML 元素  
- `css_features` - CSS 属性展示  
- `flex_layout` - Flexbox 布局  
- `transitions` - CSS 过渡  

## 许可

MIT 许可协议



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---