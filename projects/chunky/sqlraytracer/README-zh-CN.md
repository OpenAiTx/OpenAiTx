# 一个纯 SQL 光线追踪器

每个人迟早都会写一个光线追踪器。这是我的版本。

## 示例输出

<img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/dielectricparty.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onemirrorball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/glassmatrix.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/airy.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onediamondball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneantiglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/adjacentballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreyball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/reflectiontest.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twodiffuseballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreenball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/threemirrors.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twomirrorballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/busyday.png" width=200>

## 使用方法

```shell
sh create.sh
```

```postgres_connection.sh``` 包含主机/数据库/用户/密码等信息。  
除了“postgres，比如版本10及以上或类似的东西”之外，没有其他特殊需求。  
仅供参考，我在我的Ubuntu桌面上是这样创建的：  
```shell


sudo su - postgres
createuser --pwprompt raytracer
createdb -O raytracer raytracer
```

### 开发和渲染的杠杆

在开发过程中，显然几分钟的渲染时间是相当差的循环时间。你可以拉动几个杠杆来加快速度并降低质量。它们在 setup.sql 的“camera”和“img”中：

* *samples\_per\_px* - 每个像素的光线/子采样数量。
  - 调试时 1 或 2 就足够了
  - 15-20 可以得到“可用”的图像
  - 超过 50 则没有太大可见改善
* *max\_ray\_depth* - 最大光线反弹次数
  - 对于简单场景，通常不会超过 5 次反弹
* *res\_x* 和 *res\_y* - 最终图像分辨率
  - 越小越快

主 CTE 包含了许多对最终输出不必要的内容。
这是为了让我能够用以下方式检查光线在场景中的反弹：
```sql


SELECT * FROM rays WHERE img_x=100 AND img_y=250
```

有一个脚本可以用gnuplot快速粗略地查看场景；
脚本```show_scene.sh```应该会生成一个输出文件夹。

## 数据库

这是用纯SQL实现的。它没有做CREATE
FUNCTION或其他不可移植的操作，除了用来做动画的触发器，
显然这不算。

同时，它需要一些不太常见的SQL特性：

* JOIN LATERAL
* 递归CTE中的PARTITION BY
* 数学函数如SIN()

所以虽然我最初在SQLite中开发，最终还是依赖了PostgreSQL。
写这段话时，它在PostgreSQL中可用，尚未在其他数据库测试。

## 有趣的实现部分

虽说如此，我确实发现自己用一些有趣的方式解决了问题。

### JOIN LATERAL

JOIN LATERAL是一种在JOIN中执行相关子查询的方法，而不仅仅是在WHERE子句中。
我用它来提升计算，很多计算只做一次，有时避免了过度重复。

### 漫反射散射

这需要采样均匀球面。我提前生成大量随机样本[拒绝采样 -> 将点缩放到球面]，并为它们编号。

找出一种方法，将每条光线与这些预先计算的散射中的单个随机行连接起来很奇怪；
不能仅仅连接到RANDOM()，因为每条光线都会连接到相同的随机散射。
不能仅用对法线的典型计算选择，因为那会导致图片有条纹。
所以，我取出法线某一维度的后几位小数，然后用它连接。
这既“随机”又对每条光线足够唯一。

### 递归CTE

光线追踪非常自然地契合递归CTE的工作方式。我遇到的一个问题是如何干净地识别哪条光线需要处理。
使用按照截距（t）排序的窗口函数效果很好。
每次迭代，这个查询与它前面的*所有*物体相交，并做所有相关计算，
但在WHERE子句中只接受光线实际击中的那个物体。

此外，最终汇总的核心部分有一种非常美妙的简洁性[为清晰起见编辑]：
```sql
```











 SELECT img_x, img_y,
         SUM(POW(color_mult * ray_col_r/samples_per_px, gamma)) col_r,
         SUM(POW(color_mult * ray_col_g/samples_per_px, gamma)) col_g,
         SUM(POW(color_mult * ray_col_b/samples_per_px, gamma)) col_b
    FROM rays
    GROUP BY img_y, img_x
```

### 场景、材质等

因为这是用 SQL 编写的，我可以在数据库中存储多个场景。实际渲染的是在 “camera” 表中选择的那个。

## 站在巨人的肩膀上

两年前，在我写这个之前，“目前市场上最先进的 MySQL 光线追踪器”在社交媒体上流传：
https://www.pouet.net/prod.php?which=83222

我有一些想法想做得不同一些 [更差？]：

* Demoscene 是一种艺术形式。我不是在搞代码高尔夫，这不是最小化的代码
* 不是单一查询；那可以用 CTE 实现，但呃呃呃呃呃
* 动画作为终极目标 [见 ```anim.sh```]
* 主要是，我只是在用错误的工具玩弄这个东西

### 我问了 Claude 的意见

*“为什么有人一开始会写这种东西？”*

> 这是一个极端使用 SQL 作为通用编程语言的有趣例子。有人用 PostgreSQL SQL 写了一个完整的光线追踪器，这既令人印象深刻又……值得怀疑。
> 
> [...]
> 
> 这感觉像是一个聪明的计算机科学学生的毕业论文项目，一个资深工程师的周末实验，或者是被困在极其受限的仅数据库环境中却拒绝放弃光线追踪梦想的人。
> 
> 这相当于用乐高搭建一辆赛车——技术上令人赞叹，但你可能不应该真的开它。

我不知道我是应该感到受宠若惊还是被冒犯。

## 参考资料

大部分内容是基于 “周末光线追踪” 系列构建的：https://raytracing.github.io/ ，然后针对我故意晦涩的编码方式做了调整。

Gary <chunky@icculus.org>

```






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---