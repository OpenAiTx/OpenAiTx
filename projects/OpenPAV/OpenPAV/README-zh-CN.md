# Open-PAV

OpenPAV（开放生产自动驾驶车辆）是一个开放平台，旨在促进**数据收集、行为建模和性能评估**生产自动驾驶车辆（PAV）。它整合了多样的数据集和校准的车辆模型，是研究人员和开发人员研究PAV动力学及其影响的关键工具。该项目鼓励研究社区的贡献，并提供即用型模型参数，便于与仿真工具无缝集成。详情请访问 [OpenPAV 网站](https://openpav.github.io/OpenPAV)。

![Framework](https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Framework.png)

## 数据来源与贡献者

### 原始数据来源：

目前数据集已审查来自7个提供者的14个开源数据集，每个数据集提供了关于自动驾驶车辆在不同驾驶条件和场景下行为的独特见解。它们包括：

- **Argoverse 2 运动预测数据集**。由Argo AI与卡内基梅隆大学及佐治亚理工学院的研究人员合作，在德克萨斯州奥斯汀、密歇根州底特律、佛罗里达州迈阿密、宾夕法尼亚州匹兹堡、加利福尼亚州帕洛阿尔托及华盛顿特区采集。可在此获取 -  [Argoverse 2 运动预测数据集](https://www.argoverse.org/av2.html)。
- **CATS 开放数据集**。由CATS实验室在佛罗里达州坦帕和威斯康星州麦迪逊采集的三个数据集。可在此获取 - [CATS Lab](https://github.com/CATS-Lab)。
- **中俄亥俄ACC数据集**。由UCLA移动实验室和交通研究中心在俄亥俄州收集的两个数据集。可在此获取 - [中俄亥俄高级驾驶辅助系统（ADAS）装备单车数据](https://catalog.data.gov/dataset/advanced-driver-assistance-system-adas-equipped-single-vehicle-data-for-central-ohio)。
- **MircoSimACC数据集**。由佛罗里达大西洋大学研究小组在佛罗里达州四个城市（德尔雷海滩、洛哈切奇、博卡拉顿和帕克兰）采集。可在此获取 - [microSIM-ACC](https://github.com/microSIM-ACC)。
- **OpenACC数据库**。由欧盟委员会联合研究中心在意大利、瑞典和匈牙利采集的四个数据集。可在此获取 - [data.europa.eu](https://data.europa.eu/data/datasets/9702c950-c80f-4d2f-982f-44d06ea0009f?locale=en)。
- **范德堡ACC数据集**。由范德堡大学研究小组在田纳西州纳什维尔采集。可在此获取 - [自适应巡航控制数据集](https://acc-dataset.github.io/)。
- **Waymo开放数据集**。由Waymo在六个城市（加利福尼亚州旧金山、山景城和洛杉矶，亚利桑那州凤凰城，密歇根州底特律，华盛顿州西雅图）采集的两个数据集。可在此获取 - [Waymo运动数据集](https://waymo.com/open/data/motion/) 和 [Waymo开放数据集处理的车辆轨迹数据](https://data.mendeley.com/datasets/wfn2c3437n/2)。

<img src="https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Dataset.png" alt="Major Components" width="600">

### 处理后的数据来源：

通过整理上述数据集的数据，我们处理了一个统一的轨迹数据集ULTra-AV，所有数据均采用标准化格式表示。可在此获取 -  [用于自动驾驶车辆的统一纵向轨迹数据集](https://www.nature.com/articles/s41597-024-03795-y) 和 [ULTra-AV](https://github.com/CATS-Lab/Filed-Experiment-Data-ULTra-AV)。

## 最新动态

- **2026年3月：** 项目发布了新界面。
- **2024年11月：** 项目初始启动，发布安装及用户指南。

## 主要组成部分

Open-PAV包括以下组成部分：

- **数据处理：** 以原始自动驾驶车辆数据（激光雷达、图像、视频、轨迹）为输入，该模块将同类型数据转换为统一格式并执行初步数据清理。
- **行为建模：** 利用处理后的自动驾驶车辆数据，校准自动驾驶车辆的运动学模型并导出用于仿真。用户也可直接输入其自动驾驶软件堆栈，在此模块中测试其开发的自动驾驶系统。
- **加速评估：** 该模块旨在生成针对特定自动驾驶车辆模型的定制安全关键驾驶场景，以评估其安全性能。


## 贡献者

### 贡献团队

[CATS 实验室](https://catslab.engr.wisc.edu/)（负责人：[李晓鹏](https://catslab.engr.wisc.edu/staff/xiaopengli/)）

[CAT 实验室](http://www.connectedandautonomoustransport.com/dr-zhengs-research.html)（负责人：[郑祖铎](https://civil.uq.edu.au/profile/857/zuduo-zheng)）

[SHINE 实验室](https://sites.google.com/site/danjuechen/)（负责人：陈丹觉）

NextGen-ITS 实验室（负责人：David Kan）

### 技术贡献者：

- [周航](https://catslab.engr.wisc.edu/staff/zhou-hang/)，[马柯](https://markmaaaaa.github.io/KeMa.github.io/)，龙可可，马成元。

### 相关出版物：

- Zhou, H., Ma, K., Liang, S., Li, X., and Qu, X. (2024). *自动驾驶车辆的统一纵向轨迹数据集*. *Scientific Data*, 11, 1123.

### 致谢：

本项目部分由国家科学基金会（NSF）支持，资助项目为“[NSF CPS: Small: NSF-DST：通过元学习将‘公地悲剧（ToC）’转变为‘自动驾驶车辆交叉口的涌现合作行为（ECB）’](https://www.nsf.gov/awardsearch/show-award?AWD_ID=2343167)”（编号 2343167）。我们还感谢[IEEE智能交通系统协会（ITSS）新兴交通技术测试（ET3）技术委员会](https://ieee-itss.org/chapters-committees/emerging-transportation-technology-testing)的支持。

我们也衷心感谢所有数据集提供者和贡献者，使本工作得以实现。

## 许可证

Open-PAV 采用[MIT 许可证](LICENSE)发布。详情请参见 LICENSE 文件。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---