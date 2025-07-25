<div align="right">
  <details>
    <summary >🌐 其他语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

经典 2048 游戏的增强版，现在有更多有趣的功能！这是我在业余时间做的一个小项目——希望它能为你带来快乐！

## 🎯 游戏简介

2048 是一个简单却令人上瘾的数字合并游戏。在 4x4 的方格中，向上、下、左、右滑动来合并相同数字的方块。目标？达到 2048（当然你也可以继续挑战更高分数）！

**玩法说明：**
- 使用方向键或 WASD 移动方块。
- 当两个相同数字的方块碰撞时，它们会合并成一个。
- 每次移动后，一个新的 2 或 4 会随机出现在空白处。
- 当没有可移动的空间时，游戏结束。

## ✨ 特别功能

### 1. 撤销功能
- 走错一步？别担心！
- 只需点击“撤销”按钮即可回退一步。
- 你可以无限次撤销，直到回到起点。
- 再也不用担心手滑毁掉好局！

### 2. 神秘作弊模式
- 输入魔法序列：←←→→ →→←←（左、左、右、右、右、右、左、左）
- 所有方块都会神奇地变成 128！
- 这是一个彩蛋，只为乐趣而设。
- 温馨提示：偶尔作弊很有趣，但别太上头哦！😉

## 🎯 演示体验

🎯 在线试玩：[2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 项目结构
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**文件说明：**
- `2048.py`：使用 Flask 编写的后端服务器，处理游戏逻辑和 API 请求。
- `script.js`：前端游戏逻辑，包括移动、动画和特殊功能。
- `styles.css`：游戏样式，确保界面美观且响应式。
- `index.html`：整合所有内容的主页面。

## 🚀 快速开始

**方法一：下载发行版**
1. 下载最新的发行版。
2. 确保已安装 Python 3.x。
3. 安装依赖项：`pip install flask`
4. 运行：`python 2048.py`
5. 打开浏览器并访问：[http://localhost:9969](http://localhost:9969)

**方法二：从 GitHub 克隆**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 自定义

想让它变成你自己的作品吗？修改 `styles.css` 以获得全新外观，或者深入 `script.js` 来改变游戏玩法。所有代码都有详细注释，便于你随意修改！

## 📝 许可证

GPL-2.0 许可证

## 🤝 贡献

仍在持续更新中！欢迎提交 Issue 和 Pull Request——让我们一起让这个游戏变得更棒吧！


## 🙏 致谢

感谢以下赞助商对本项目的支持：
- [IDC.REST](https://idc.rest/) 提供服务器
- [Serv00](https://www.serv00.com/) 提供服务器

---
_最后更新：2025年6月_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---