# BeamerQt
BeamerQT 是一个用户友好的图形界面，旨在帮助用户创建 Beamer 演示文稿，无需手动编辑与幻灯片相关的 LaTeX 代码。它提供了一整套功能，允许用户定义布局、插入内容（包括文本、块和图像），并配置主题的一些高级设置。BeamerQT 为初学者和高级 LaTeX 用户提供了创建精彩演示文稿的能力，使用户能够专注于内容而非代码。

### 库需求：
* PyQt6

* PyMuPDF

<img src="https://github.com/user-attachments/assets/b123f050-dff5-4584-b40d-c2fd581c2f16" width="600">


# 功能
BeamerQT 拥有图形用户界面，提供了轻松访问大多数所需 Beamer/LaTeX 功能的途径，无需添加 LaTeX 代码。

## 主题编辑器（新功能！）
编辑模板的源代码。

* 支持附加包含的文件。
* 在生成 LaTeX 时提取附加文件。
* 轻松共享自定义的 .xml 文件。
* 未来将有新功能。

## 布局选择
BeamerQT 提供了一系列预定义的布局方案，灵感来自常见的演示工具，如 PowerPoint 或 LibreOffice Impress。用户无需手动编写列和块的 LaTeX 代码，只需选择布局，BeamerQT 会自动插入和管理所需的 Beamer 列和块。

主要功能包括：

* 根据所选布局自动创建列和块。
* 使用滑块控件动态调整列宽，无需手动修改代码。
* 以最小的用户干预无缝重新配置幻灯片布局。

<img src="https://github.com/user-attachments/assets/1c313ed2-337c-4925-aaef-b18aa718bd0e" width="600">

<img src="https://github.com/user-attachments/assets/305af2c5-7726-43bd-b457-fe68d8ff3fd9" width="600">


## 幻灯片

每张幻灯片可以包含标题、副标题以及一组内容块。此外，幻灯片可以配置为新章节或子章节，从而实现自动插入相应章节或子章节标题到演示文稿中。

关键特性：

* 轻松输入幻灯片标题和副标题。
* 将幻灯片标记为章节或小节，以构建演示结构。
* 自动调整幻灯片级别的格式选项。

## 幻灯片列表

幻灯片列表提供整个演示文稿的概览，显示每张幻灯片的位置、编号和标题。章节和小节被清晰标记，便于导航和组织。用户可以根据需要重新排序、复制、粘贴或删除幻灯片，确保幻灯片管理的高效。

## 块

块是 BeamerQT 中内容的基本单元。该工具支持多种块类型——如块（Block）、警示块（Alert）、示例块（Example）或纯文本块——通过简单的单选按钮界面选择。这种方式免去了手动编写 LaTeX 命令的需求。

块的核心功能包括：

* 选择块类型（块、警示、示例或纯文本）。
* 位置控制，用于在布局中重新排列块。
* 专用按钮，用于从幻灯片中移除块。
* 每个块都有标题字段和文本输入区域，支持多行输入。
* 根据用户输入自动换行或保留手动换行。
* 多个子块
<img src="https://github.com/user-attachments/assets/5b914c96-e691-4fdf-af42-faba89b2c8f4" width="600">


## 子块

子块允许在块内进行更细粒度的内容组织。每个块至少包含一个子块（通常是基于文本的），用户可以根据需要添加多个子块。

子块功能包括：

* 最多排列为四列，配备水平导航按钮以重新排序子块。
* 调节列宽的滑块，提供灵活的布局定制。
* 每个子块的对齐控制（左对齐、居中、右对齐或默认）。

## 图片子块

图片子块是用于插入图片的专用子块类型。BeamerQT 支持位图文件（如 .jpg、.png）、矢量图像（.svg）和 .pdf 文件。对于 .svg 图片，BeamerQT 利用 Inkscape 将其转换为 .pdf 格式，确保无缝集成到最终演示文稿中（仅在测试的 Linux 系统上）。

图片子块功能：
* 可调节图像大小，按子块宽度的百分比设置。  
* 自动适应布局变化，实现视觉元素的一致缩放。  
* 兼容多种图像格式，确保展示设计的灵活性。  

## Front-matter  

Front-matter 部分允许轻松配置整个演示文稿的设置。用户可以定义演示标题、作者姓名，并自定义 LaTeX 前导代码。此外，还可以启用高级功能，进一步优化演示文稿的整体外观和结构，例如：  

* 更改宽高比（从 4:3 到 16:9）。  
* 为每个章节创建标题页。  
* 自动为每个章节生成大纲页。  
<img src="https://github.com/user-attachments/assets/07629d96-ba38-4e5b-87ff-c1648598ad9f" width="600">  

<img src="https://github.com/user-attachments/assets/bb47ffe5-7d92-408e-a42d-1cd734f53d51" width="600">  

<img src="https://github.com/user-attachments/assets/9149eb46-020a-4f02-b3fe-9959fb231fd3" width="600">  

## LaTeX 生成  

当用户对内容和布局满意后，点击 **Generate LaTeX** 按钮即可将演示文稿导出为 LaTeX 并运行 pdflatex 编译生成 PDF。生成的 PDF 会立即显示，方便用户即时查看。  

**LaTeX folder** 按钮则会打开输出目录，方便用户进行进一步定制或与其他工具集成。请注意，每次生成 LaTeX 都会覆盖输出文件夹中的文件。  

## 文件格式  

BeamerQT 使用 .bqt 文件格式，本质上是一个压缩目录，包含所有必要的元数据，例如：  

* 含有演示文稿详细信息的 XML 文件。  
* 幻灯片的预览图像。  
* （未来功能）嵌入图像和自定义主题，确保文件的可移植性。  

这种方式确保 .bqt 文件可以轻松共享、备份，并在不同系统间编辑而不会丢失重要数据。  

## 安装







* Windows

  安装 MikTex：
  
  https://miktex.org/download

  安装 BeamerQT：
  
  https://sourceforge.net/projects/beamerqt/

* Linux
  根据您的发行版安装 python3、TexLive 和 Inkscape：
  

  基于 Debian：
  ```
  apt-get install python3 texlive-beamer inkscape 
  ```
  安装 PyQt6 和 PyMuPDF：
  ```
  pip install pyqt6 pymupdf
  ```
  

  运行 BeamerQT：

  从此仓库下载 BeamerQT 的源代码。
  
  在包含文件 main.py 的目录中打开终端
  ```
  python3 main.py
  ```


## 示例视频：

https://www.youtube.com/watch?v=XQKJbuT8q1g

## 截图：
### BeamerQT 界面
<img src="https://github.com/user-attachments/assets/cf332d4e-9962-4251-9619-67e146af9851" width="600">

### PDF 输出
<img src="https://github.com/user-attachments/assets/be7b2e0c-20a4-41f0-b09d-93131973c4d4" width="600">


## 捐赠
请捐赠以帮助我开发此软件。Paypal 捐赠链接：

https://www.paypal.com/donate/?business=2PP5H8Z8L5E8E&no_recurring=0&item_name=Support+the+development+of+BeamerQT&currency_code=USD


## 科幻书籍
如果你喜欢这个，你可能也会喜欢我的科幻书籍，《突触：秩序的混沌》。

http://synapsesbook.wordpress.com/

Jorge Guerrero


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-22

---