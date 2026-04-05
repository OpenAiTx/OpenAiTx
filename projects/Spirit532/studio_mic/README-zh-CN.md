# 简单且高品质的100美元以下电容麦克风

我需要一个高质量的麦克风，但所有可选方案要么价格稍高，要么性能不佳，所以我决定自己动手制作。

该麦克风采用了克隆版RK12/CK12电容胶囊（Aliexpress/Ebay等售价40-50美元，搜索“edge terminated capsule”），一个U87捐赠机身（15-30美元，同样在Aliexpress，搜索“U87 mic”），以及一个定制的前置放大板（20-30美元，本项目）。

电路板非常简单，但性能优越——它使用单封装的双FET输入运放，既转换了电容胶囊的阻抗，又提供了差分信号，而偏置则由一个略显怪异的六反相施密特触发器反相器电荷泵提供。

使用下图所示的配置，结果对非发烧友的耳朵来说几乎完美。由于电路简洁和所选运放性能，几乎没有自噪声，动态范围充足，且无信号失真或“着色”。你通过XLR连接器获得的信号正是电容胶囊所捕获的。

#### 关于元件选择的说明
  1. 你几乎可以使用任何FET输入运放，**但是**必须密切关注静态电流。该电路采用较高阻抗的电源路径，而幻象电源标准本身提供的电流有限。两个运放的总功耗不应超过约7-8mA（每个3.5-4mA）。

  2. 六反相器的功耗也需注意，但其他方面则无特别限制。你可以用任何功能相似的40106克隆件替代。

  3. 购买指定位置的高压电容时要格外注意——这非常重要！陶瓷电容在高电压下会失去电容值，因此建议使用额定100V或更高的X7R类电容（这不能完全解决降额问题，但有帮助）。所有数值均有0805封装可选，不成问题。

  4. 如果预算允许，选择NP0/C0G陶瓷电容。它们能稍微提升性能，但提升幅度不大。（这能解决降额问题，但成本较高）
  
本设计采用MIT许可证授权。如果你想制作，尽管动手；如果想出售，也可以，但请注明本页面或类似来源。这些设计几乎都非原创，已被多人多次实现（例如Instructables上的DJJules/Sound Sleuth电路是我的灵感来源），我只是做了一些个人改进。

#### 关于廉价捐赠机身的重要提示
大多数廉价捐赠机身预先阳极氧化甚至预涂漆，包括分离点的接触面（电路盖、头篮、螺母、垫片等），__务必打磨露出金属__，否则会拾取大量工频嗡嗡声和其他外部电磁噪声！


## 获取电路板
如果你自己不能制作或组装电路板……嗯，好吧，祝你好运，但中国的大多数贴片厂都乐意以不高的价格帮你制作。
我之前这里放了PCBWay的推广链接，但现在不推荐他们了。

## 电路原理图
（也提供pdf和KiCad 7源文件，见附件）

![Schematic](https://raw.githubusercontent.com/Spirit532/studio_mic/main/sch_img.png)

## PCB效果图
![Render](https://raw.githubusercontent.com/Spirit532/studio_mic/main/render.png)

## 组装完成的电路板，DIY单层版本（自制）
![Build](https://raw.githubusercontent.com/Spirit532/studio_mic/main/build.jpg)

## 胶囊安装在供体机身上
![胶囊](https://raw.githubusercontent.com/Spirit532/studio_mic/main/capsule.png)

## U87 克隆供体机身
![供体](https://raw.githubusercontent.com/Spirit532/studio_mic/main/donor.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---