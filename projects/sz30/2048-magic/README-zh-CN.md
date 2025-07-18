[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

经典2048游戏的增强版，现在拥有更多有趣的功能！这是我在闲暇时间做的一个小项目——希望它能给你带来乐趣！

## 🎯 游戏介绍

2048是一款简单却让人上瘾的数字合并游戏。在4x4的网格上，向上、下、左、右滑动合并相同数字的方块。目标？达到2048（不过你也可以继续追求更高分数）！

**怎么玩：**
- 使用方向键或WASD移动方块。
- 当两个相同数字的方块碰撞时，它们会合并成一个。
- 每次移动后，空白位置会随机出现一个2或4。
- 当没有更多移动时，游戏结束。

## ✨ 特别功能

### 1. 撤销功能
- 操作失误？别担心！
- 只需点击“撤销”按钮，回到上一步。
- 你可以无限次撤销，直到游戏开始。
- 再也不用担心手滑毁了游戏！

### 2. 秘密作弊模式
- 输入魔法序列：←←→→ →→←←（左、左、右、右、右、右、左、左）
- 所有方块神奇地变成128！
- 这是一个彩蛋，仅供娱乐。
- 小贴士：作弊很有趣，但别太过哦！😉

## 🎯 演示

🎯 试玩地址：[http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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
- `index.html`：将所有内容整合在一起的主页。

## 🚀 快速开始

**方法一：下载发布版本**
1. 下载最新发布版本。
2. 确保已安装 Python 3.x。
3. 安装依赖：`pip install flask`
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

想要打造属于你自己的风格？调整 `styles.css` 以获得新外观，或者深入 `script.js` 改变游戏玩法。所有代码都有详细注释，方便修改！

## 📝 许可证

GPL-2.0 许可证

## 🤝 贡献

仍在更新中！非常欢迎提交问题和拉取请求——让我们一起让这款游戏变得更棒！


## 🙏 致谢

感谢以下赞助商对本项目的支持：
- [Serv00](https://www.serv00.com/) 提供服务器

---
_最后更新：2025年6月_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---