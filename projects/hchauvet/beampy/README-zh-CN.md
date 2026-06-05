# Beampy [![Build Status](https://travis-ci.com/hchauvet/beampy.svg)](https://travis-ci.com/hchauvet/beampy) [![codecov](https://codecov.io/gh/hchauvet/beampy/graph/badge.svg)](https://codecov.io/gh/hchauvet/beampy) ![pypi python version](https://img.shields.io/pypi/pyversions/beampy-slideshow.svg) ![pypi licence](https://img.shields.io/pypi/l/beampy-slideshow.svg) ![pypi download](https://img.shields.io/pypi/dm/beampy-slideshow.svg) ![pypi beampy version](https://img.shields.io/pypi/v/beampy-slideshow.svg)

**主分支的开发目前被冻结，（只会推送紧急错误修复），beampy的新版本目前在dev分支开发，该分支尚不够稳定，不建议使用……**

Beampy 是一个用Python创建SVG幻灯片放映的工具，可通过HTML5显示
（已在Firefox和Chromium上测试）
幻灯片的大小固定，类似于Latex Beamer文档。

Beampy演示输出仅生成一个包含所有内容的html文件。

* [查看Beampy文档](https://hchauvet.github.io/beampy/)
* [查看Beampy测试演示](https://rawgit.com/hchauvet/beampy/master/examples/beampy_tests.html)（源代码在*examples/beampy_tests_modules.py*）

## 安装：

从Python包索引安装：

```bash
pip install beampy-slideshow
```

[See full installation documentation](https://hchauvet.github.io/beampy/install.html#beampy-install)

## A quick example :

```python
from beampy import *

doc = document()

with slide():
    maketitle('Beampy a tool to make simple presentation', ['H. Chauvet'])

with slide('Beampy test'):
    text(r'\href{#0}{Go to Title}')
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')

with slide('Beampy test with animated layers'):
    text(r'\href{#0}{Go to Title}')[:]
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')[1]

save('./simple_one.html')

#To save in pdf just change the above command to the following
#save('./simple_one.pdf')
```
[beampy_presentation.html](https://cdn.rawgit.com/hchauvet/beampy/master/examples/simple_one.html)



## 更新日志：

### 0.5.5
* 修复了针对 Python 2 和 3 的编码重要问题。
* 修复了 dvisvgm 生成的 svg 中缺失引用的问题
  （种子问题详见 [#18](https://github.com/hchauvet/beampy/issues/18)），
  导致 svg 中缺失部分 LaTeX 内容。
* 更好地管理临时文件
* 更新 scour（svg 优化器）到最新版本

### 0.5.4

* Beampy 现已兼容 Python 3 和 2（至少支持 2.7 和 3.7）！
* 引入基于 pytest 框架的集成测试（核心函数仍无单元测试）
* 修复同时保存多种格式时的错误，不再重复文本 [问题 #13](https://github.com/hchauvet/beampy/issues/13)
* 增加 logging.debug 模式输出
* 增加指定演示源文件位置的选项（doc = document(source_filename=__name__)）

### 0.5.3

一些小修复：
* 修复 box 层传播的错误
* 修复当最后一层设置为 [n:] 时的错误
* 开始在模块中使用 logging.debug

### 0.5.2

* 修复 tikz dvi 的 dvisvgm 输出错误（latex2svg 函数现增加写入 dvisvgm 生成 svg 的选项）。
* 添加目录模块 [参见文档](https://hchauvet.github.io/beampy/auto_examples/plot_TOC.html)。
* 添加 BeamerFrankfurt 主题 [参见文档](https://hchauvet.github.io/beampy/auto_themes/theme_BeamerFrankfurt.html)。
* 图形模块支持动画 gif。
* 可通过 "extra_packages" 参数向文本模块添加额外的 LaTeX 宏包。




* 计算 svg 矩形和圆的尺寸以提升渲染速度（无需调用 Inkscape）。
* 改进 box 模块（现在是 group 的子类）[参见文档](https://hchauvet.github.io/beampy/auto_examples/plot_box.html)。
* 修正 convert_unit 函数中的某些缩放因子。
* 宽度和高度现在是 Length 对象，并支持复杂的
  运算，如：


  ```python

  # 50% of the currentwidth 
  a = rectangle(width='50%', height=10)

  # width/height relative to the a element
  b = rectangle(width=a.width/2+'2cm', height=a.height/'10pt')
  ```

* 模块位置 (x,y) 操作现在接受长度对象（宽度/高度）：

  ```python

  a = rectangle(width='50%', height=10)

  b = rectangle(x=a.width+'2cm', y=a.height+5)
  ```
  
* 更改 beampy 的核心，使其仅在需要时渲染元素以便对位置或长度进行操作（即当你对未知的元素宽度或高度进行操作时，元素将被渲染以获取其尺寸并允许操作）
* 为模块添加“zorder”操作（above/below/last/first），以改变它们的叠放顺序：





  ```python

  a = rectangle(x='center', y='center', width=50, height=50)
  b = rectangle(x='center', y='center', width=a.height+100,
                height=a.height+100, color='red')

  # Make b appears below a
  b.below(a)
  
  # equivalent to a.above(b) or a.last() or b.first()
  ```

### 0.5.1

* 修复了 bokeh 图形中的多个错误（感谢 [Silmathoron](https://github.com/Silmathoron)）
* 修复了 bokeh 图形的大小调整，现在使用 bokeh 的 "sizing_mode = scale_both" 并恢复 bokeh div 的 css 变换缩放。
* 修复了 bokeh 的 javascript 加载器（新版本 bokeh (>0.12.6) 将其主 div 命名为 "bk_root"）
* 在 beampy 缓存类中添加缓存文件的功能
* 缓存 bokeh 的 javascript 外部库文件（从其 CDN 下载，如果 "doc = document(cache=False)"）


### 0.5.0
* 添加用于装饰组的 box 函数
* 使用上下文管理器在演示文稿中编写文本的新实验性方法

  ```python
  with text(width=400):
       """
       Any comment inside the context manager will be passed to the
       text function as input argument. This allows clearer source
       when writing long texts.

       No more need to add an *r* before to protect the text passed to
       latex, it's now automatically added.
       """
  ```
  
* 修正仅幻灯片中存在 html 对象时的错误  
* 修正文档安装部分的小错别字  

### 0.4.9

* [Beampy 文档](https://hchauvet.github.io/beampy/)的初稿  
* 在 Beampy 模块中添加文档  
* 在位置字典中添加 'anchor' 键，用于定义沿模块边界框的锚点以放置模块。  
* 添加 utils.py 存储调用 beampy 模块的函数。  
* 在 utils.py 中添加函数 **bounding_box(module)**，用于绘制带锚点的 Beampy 模块边界框。同时添加在幻灯片上绘制坐标轴的函数，**draw_axes()**  

### 0.4.8

* 部分修复问题 #12。  
* 清理代码语法。  

### 0.4.7

* 引入图层机制。幻灯片元素可以通过图层进行动画，实现类似 beamer “\only”的机制。  
  图层作为 python 切片在 Beampy 模块中管理。




  ```python 
  with slide('Test layers'):
    text('First printed on layer 0')
    text('Secondly printed on layer 1')[1]
    text('Printed from layer 2 to 3')[2,3]
    text('Printed on all layers')[:]
    text('Printed on layer 4')[4]
    
    with group(width=300)[2:]:
        text('Printed inside group')
        text('for layers 2 to end')
  ```
  

### 0.4.6

* The core of Beampy slide processor has been rewritten and now allows recursive group of elements.

  ```python
  with group():
    text('toto')
    with group(width=300):
        text('tata')

        with group(width=200):
            figure('./niceplot.pdf')
            text('nice legend')
  ```
* 如果指定了组宽度，则所有未指定宽度的组内元素将采用该组的宽度


  ```python
  with group(width=200):
    figure('./niceplot.pdf')
    text('nice legend')
    # Figure and text width will be automatically set to 200 px
  ```
* 现在可以对自动定位的元素进行相对放置


  ```python
  t0 = text('toto')
  text('tata', x=t0.center + center(0), t0.bottom + 0.1)
  ```
* 视频现在可以使用外部链接（带 *embedded=True*）而不是包含在html文件中。  
  当幻灯片显示在屏幕上时，视频从磁盘加载（注意文件路径）。  

### 0.4.5  

* 所有文本在一个latex文件中预处理（仅调用一次Latex：提高编译速度）  
* 缓存错误修复：视频和svg现在正确缓存  

### 0.4.4  

* 改进缓存：每个元素缓存一个文件（避免重复写缓存！）  
* Svg：添加线条和矩形命令，方便绘制线条和矩形  
* 相对定位：添加快捷方式 center(shift)、right(shift) 和 bottom(shift)  
  用于更改当前元素的锚点。  


  ```python 
    e1 = text('Somthing', x=0.2, y=0.4)
    e2 = text('An other thing', 
              x=e1.left + right(0.1), 
              y=e1.center + center(0))
  ```


### 0.4.3

* Matplotlib 图形现在可以直接传递给 *figure()*，或者一组 matplotlib 图形可以用 *animatesvg()* 动画显示
* 缓存大小稍作改进（内容不再存储在缓存文件中）
* 更新 scour 版本（svg 优化器）

### 0.4.2
* Latex 中的字形路径现在是唯一的（减少文档中的 svg 行数）
* 添加 *svg* 命令以在幻灯片中包含原始 svg
* 提升主题灵活性，现在可以创建带有交互元素的背景！

### 0.4.1
* 所有幻灯片现在都加载到内存中，提高速度
* 模块现在是继承自 modules/core.py 中基类 "beampy_module" 的类
* 缓存现在对所有格式（pdf、svg、html）都是唯一的，并且可以向模块添加特殊键以创建它们的缓存 ID

## 安装

[请参见 Beampy 文档安装页面](https://hchauvet.github.io/beampy/install.html)







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---