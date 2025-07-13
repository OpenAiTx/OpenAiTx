# 3D可按压按钮

一个使用HTML、CSS和SVG构建的逼真3D按钮组件，能够模拟按下实体按钮的手感。该按钮具有流畅的动画效果、可自定义的颜色以及响应式的交互体验。

由 [@BalintFerenczy](https://x.com/BalintFerenczy) 创建

灵感来源于 [Resend](https://resend.com/) 的杰出作品

## 功能特性

- **逼真的3D外观**，采用分层SVG图形
- **流畅的动画效果**，使用自定义缓动函数
- **交互状态** —— 悬停和按下效果
- **可自定义颜色**，通过CSS变量实现
- **响应式设计**，可随容器尺寸自适应缩放

## 演示
按钮根据用户交互会有三种不同的状态响应：
- **正常**：按钮处于静止状态
- **悬停**：鼠标悬停时按钮略微下移
- **激活**：按下/点击时按钮明显下移

## 用法

### 自定义

按钮可以通过 CSS 自定义属性轻松进行自定义：

```css
.frame {
    /* 按钮尺寸 */
    width: 400px; 
    height: 400px; 

    /* 移动距离 */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* 颜色自定义 */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* 过渡设置 */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### 更改按钮文本

只需修改文本内容：

```html
<p class="text">点击我！</p>
```

#### 更改按钮大小

调整框架尺寸：

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## 许可证

本项目为开源项目，采用 MIT 许可证。

## 贡献

欢迎自由分叉本项目，并提交拉取请求以改进或添加新功能！

## 作者

由 [@BalintFerenczy](https://x.com/BalintFerenczy) 创建

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---