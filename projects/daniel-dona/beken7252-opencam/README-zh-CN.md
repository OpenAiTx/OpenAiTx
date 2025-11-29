# Beken7252 OpenCam
RT-Thread 替代项目，针对 A9 摄像头

# 更新
## 25/09/25
我已经完成了硕士学位，现在有更多的空闲时间，这些摄像头仍然很多。是时候为该项目规划第一个正式版本了。我已经工作了几个星期，目前有一个早期版本，可以启动、连接 Wi-Fi、读写 SD 卡、支持 MQTT，最重要的是，至少支持三种不同的摄像头传感器：GC0311、HI704 和 GC0328。包括存储图片和使用 HTTP（multipart/x-mixed-replace）进行流式传输。

它仍然需要额外的稳定性测试，并改进 SDK 和项目的整体状态。

请查看[此工单](https://github.com/daniel-dona/beken7252-opencam/issues/21)了解 1.0.0 版本的详细计划。

## 20/11/2023
上个月，我一直在等待一些额外的 A9 摄像头到货，因为我只有一个，我担心频繁焊接和拆焊测试线会毁坏 PCB。
结果并非预期。我在 Aliexpress 上买了大约 12 个不同的摄像头，因为它们只要 3 欧元左右，我得到了：

~6 个带有 Beken 芯片的

~3 个带有未知芯片的，看起来像某种定制的 XRadio/Allwinner

~1 个来自其他厂商的，我记不得了

~1 个芯片上没有任何标记的

是的，数量不太对；重要的是我得到了更多带 Beken 芯片的……还是说不是？

芯片标记为 BK7252，但引脚排列不同。已记录并至少有数据手册的芯片有 68 个引脚；这个是 48 引脚，型号为 BK7252UQN48。

详情见：https://github.com/daniel-dona/beken7252-opencam/wiki/BK7252-SoC-variations

目前我不会使用这个芯片。我尝试上传可运行代码到这个芯片，但其表现不符合预期。肯定是他们移除了一些功能，或者复用方式不同。也许某些寄存器的内存区域不同，可能是我笨，上传代码错了……

无论如何，我觉得先在已知芯片上做出可用的东西比较好，然后再探索这个新芯片。

# 已知 SDK
- FreeRTOS: https://github.com/YanMinge/beken_freertos_sdk_release
- RT-Thread: https://github.com/YangAlex66/bdk_rtt 和 https://github.com/biemster/bdk_rtt_v3

# 相关源码和帖子：
- [TODO]


# 待办事项

- 记录PCB和传感器的变体
- 记录摄像头变体的引脚定义
- 记录刷机流程（及解砖方法）
- 清理Beken SDK
- 将SDK代码迁移到更现代的GCC和Scons
- 其他（？）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-29

---