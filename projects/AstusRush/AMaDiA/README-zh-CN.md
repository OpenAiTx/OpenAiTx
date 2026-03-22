# AMaDiA
Astus的数学显示应用程序<br/><br/>
当前功能：<br/>
 * 使用 (Shift+)AltGr+键 来输入数学符号（参考 AMaDiA_ReplacementTables）<br/>
 * 选项卡 1 ：科学计算器<br/>
   * 使用 +,-,±,×,÷,√,^,°, 积分 f(x) dx, 导数 d(f(x))/dx, y'(x), 复数, sin(), cos(), tan(), exp(), log() , π , E 等进行计算<br/>
   * 解含未知变量的方程<br/>
   * 解微分方程（包括特解）<br/>
   * 测试两个表达式是否相等<br/>
   * 使用数学Unicode符号更快输入！<br/>
   * 在选项中开启单位支持以执行如 convert_to(7foot+3inch,m) 的操作<br/>
   * 更多详细用法请查看帮助/示例，并将示例复制粘贴到相应的选项卡输入栏<br/>
 * 选项卡 2 ：将输入转换为LaTeX并显示<br/>
 * 选项卡 3 ：绘制二维图形（3D和复数图形正在开发中）<br/>
 * 选项卡 4 ：包含矩阵和向量的方程，以及线性方程组<br/>
 * 系统控制窗口 ：系统控制相关功能（开发中）<br/>
 * 局域网聊天程序（需重构）<br/>
   * 用于在同一网络内用户之间共享方程，方便协作工作<br/>
   * 独立的服务器和客户端应用<br/>
   * 支持发送文本和文本文件<br/>
   * 通过拖放文本文件到输入框与网络内所有用户共享<br/>
   * 服务器具备部分管理工具（禁言/踢出/封禁）<br/>
   * 警告：消息当前未加密！请勿发送敏感数据！！！<br/>
 * 自定义窗口框架<br/>
<br/>
欢迎反馈<br/>
欢迎建议<br/>
欢迎请求<br/>
<br/><br/>

# 安装方法
在Windows上：<br/>
 * 安装 https://gitforwindows.org/<br/>
 * 安装 https://www.anaconda.com/distribution/<br/>
 * 创建两个文件 "AMaDiA.bat" 和 "AMaDiA_INSTALL.bat"，并从 WINDOWS-INSTALL 文件夹中将相应文件的内容复制到这两个文件中，右键点击选择“编辑”即可<br/>
 * 双击 "AMaDiA_INSTALL.bat" 安装 AMaDiA（安装位置为用户文件夹，可通过编辑这两个文件更改）<br/>
 * 以后双击 AMaDiA.bat 将会更新并运行 AMaDiA<br/>
 
（免责声明：使用这些 .bat 文件请自行承担风险。我怀疑它们会造成任何损害，但我不是批处理文件专家，无法预见所有情况）<br/>
<br/>
   在 Linux 上 [进行中]:<br/>
 * sudo apt-install git<br/>
 * 安装 https://www.anaconda.com/distribution/ 或 sudo apt-install ...<br/>
 * [安装和更新/启动的控制台命令即将推出（大概？）]<br/>
<br/>

   在 OSX 上 [???]:<br/>
 * 我无法访问 OSX，也不确定 AMaDiA 在其上的运行情况（应该能完美运行？）……抱歉，我无法提供帮助……<br/>
 * 如果有人有关于如何在 OSX 上轻松安装/更新+运行 python 脚本的好说明，请告诉我，以便我添加到这里<br/>
 * 这里 https://github.com/AstusRush/AMaDiA/issues/2 有一个人在 OSX 上安装的说明

<br/><br/>
# 截图
版本 0.15.7.1 的截图<br/>
<img src="/AMaDiA v0.15.7.1 Demo.png" alt="演示图片"/>
<br/><br/>
# “短期”路线图
近期计划功能（顺序反映优先级）（注意“短期”一词相当相对）:<br/>
- 绘制 3D 和复数函数<br/>
- 改进系统控制窗口<br/>
- （持续进行中：）更好的解析器以允许更灵活的输入<br/>
<br/><br/>
# 长期路线图
未来计划功能（顺序反映优先级）:<br/>
- 使标签4更易用<br/>
- 简易文本编辑器<br/>
- 更好的单位处理（如自动化简）<br/>
- 自动识别偏微分方程，用户无需再放入“pdsolve(...)”中<br/>
- 保存/加载历史记录<br/>
- PDF 查看器<br/>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-22

---