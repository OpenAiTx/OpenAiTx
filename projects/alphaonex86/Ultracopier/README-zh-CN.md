
# 关于

[Ultracopier](https://ultracopier.herman-brule.com/) 是一款免费且开源的软件，遵循 GPLv3 许可协议，作为文件复制对话框的替代品。

主要功能包括：
- 任务队列
- 暂停 / 继续
- 继续未完成的任务
- 动态速度限制
- 冲突管理
- 插件支持

# 依赖
- make
- gcc
- C++17 编译器（由于 Qt6.7）

例如在基于 Debian 的发行版上：




```bash
sudo apt install make gcc build-essential libssl-dev qtbase6-dev qtchooser qt6-qmake qtbase6-dev-tools qttools6-dev-tools
```
# 构建

构建一个一体化版本就像编译主 Qt 项目一样简单：


```bash
find ./ -name '*.ts' -exec lrelease {} \;
qmake ultracopier.pro
make -j$(nproc)
```

# Run

```bash
./ultracopier
```


# 翻译

翻译通过 [Qt Linguist](http://doc.qt.io/qt-6/qtlinguist-index.html) 提供。

1. 运行 `lupdate ultracopier.pro` 更新翻译文件
2. 将您的翻译放入 `(plugins|resources)/Languages/XX/translation.ts`
3. 运行 `lrelease ultracopier.pro` 编译文件
4. 替换您的 Ultracopier 版本中的 `.qm` 文件


# 插件

也可以通过 [插件](https://raw.githubusercontent.com/alphaonex86/Ultracopier/master/plugins/README.md) 形式进行自定义。


# 贡献
该项目托管在 [Github](https://github.com/alphaonex86/Ultracopier)。
在那里添加问题和合并请求！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---