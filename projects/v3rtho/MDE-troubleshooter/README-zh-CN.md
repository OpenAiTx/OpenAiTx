# MDE-troubleshooter
# 信息

此工具旨在帮助您分析本地端点上与端点防护相关的问题。它提供安全配置、日志文件、更新的集中视图，并可访问性能分析器。

请注意，这是工具的初始版本。如果您遇到任何错误或有改进建议，欢迎在我的GitHub页面提交。非常感谢您的反馈和报告。

<img width="1482" height="1041" alt="2026-03-09 10_40_30-MDE Troubleshooter v3 0" src="https://github.com/user-attachments/assets/34d80bab-525d-4bf2-ae10-ae8b0c62358d" />



# 先决条件

脚本需以管理员身份运行以查看所有设置。

# 免责声明

脚本按原样提供。风险自负。不提供任何保证或担保。

# 联系方式
linkedin: https://www.linkedin.com/in/thomasvrhydn/
twitter:  @thomasvrhydn

# 功能  

Defender AV  
版本信息 — AM引擎、AM产品、AM服务、NIS引擎版本，AM运行模式，计算机状态  
服务状态 — AM服务、杀毒、反间谍软件、NIS启用状态、虚拟机检测、计算机ID  
实时保护 — 实时保护、访问时保护、行为监控、IOAV保护、防篡改状态及来源  
扫描信息 — 全面和快速扫描时间间隔，开始/结束时间  
保护设置 — 云阻止级别、首次发现阻止、云超时、隔离清理天数、文件哈希计算、设备控制状态  
附加信息 — 签名回退顺序、NIS签名最后更新时间、上次快速扫描来源  

攻击面缩减  
ASR规则状态 — 查看所有19条ASR规则及其当前状态（启用/审核/警告/未启用），支持状态过滤和可排序DataGrid弹出窗口  
ASR单规则排除 — 查看注册表中读取的按规则及全局ASR排除项（HKLM:\...\Windows Defender Exploit Guard\ASR），支持规则名称过滤  
利用防护 — 导出并打开利用防护XML配置  

排除项  
Defender AV排除项 — 查看所有配置的排除项（路径、扩展名、进程、IP地址），在弹出DataGrid中支持搜索和类型过滤  
注册表项信息 — 显示 ManagedDefenderProductType、EnrollmentStatus、HideExclusionsFromLocalAdmins、DisableLocalAdminMerge，并通过篡改保护验证确定管理状态（仅限 Intune、ConfigMgr、联合管理场景）  

更新  
当前签名信息 — AV 签名版本/年龄/最后更新，反间谍软件签名版本/年龄，NIS 签名版本  
最新微软版本 — 从微软网站获取最新引擎、平台和签名版本以供比较  
更新操作 — 通过 UI 直接触发 MpCmdRun.exe 进行签名更新  

日志  
SENSE 日志 — 查看 EDR 传感器事件日志（Microsoft-Windows-SENSE/Operational），支持按文本和级别（信息/警告/错误）过滤，及选中条目的详细面板  
Defender AV 日志 — 查看杀毒事件日志（Microsoft-Windows-Windows Defender/Operational），具备相同的过滤和详细功能  

性能  
性能录制 — 启动 Defender AV 性能录制会话（New-MpPerformanceRecording），将扫描活动捕获到 ETL 文件  
性能报告 — 从 ETL 录制生成报告，支持选择报告类型：概览、十大文件、十大扩展名、十大进程、十大扫描（多个报告可同时在独立窗口打开）  
估计影响（MPlog） — 解析最新 MPlog 文件中的 EstimatedImpact 条目，按影响值排序，以识别高影响扫描目标  
客户端分析器下载 — 下载官方 Microsoft Defender 客户端分析器工具（MDEClientAnalyzer.zip）到指定文件夹  

代理  
代理配置 — 显示 Defender 当前配置的代理 URL 和代理 PAC  

防火墙  
配置文件状态 — 查看域、专用和公共防火墙配置文件设置（启用状态、默认入站/出站动作、允许日志）  
防火墙规则浏览器 — 在可筛选的数据网格中查看所有 Windows 防火墙规则，支持搜索、方向、动作、启用状态和配置文件过滤。显示规则名称、端口、协议和程序路径  


# 参考资料

https://github.com/ugurkocde/Intune/blob/main/Defender%20for%20Endpoint/MDE%20-%20Update%20Tool/MDE_Update_Tool.ps1

https://github.com/directorcia/Office365/blob/master/win10-asr-get.ps1

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/overview-attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction-faq





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---