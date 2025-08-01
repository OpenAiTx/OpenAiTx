![Logo](https://raw.githubusercontent.com/TA2k/ioBroker.vw-connect/master/admin/vw-connect.png)

# ioBroker.vw-connect

[![NPM version](http://img.shields.io/npm/v/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Downloads](https://img.shields.io/npm/dm/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Dependency Status](https://img.shields.io/david/ta2k/iobroker.vw-connect.svg)](https://david-dm.org/ta2k/iobroker.vw-connect)
[![Known Vulnerabilities](https://snyk.io/test/github/ta2k/ioBroker.vw-connect/badge.svg)](https://snyk.io/test/github/ta2k/ioBroker.vw-connect)

[![NPM](https://nodei.co/npm/iobroker.vw-connect.png?downloads=true)](https://nodei.co/npm/iobroker.vw-connect/)

**测试:**: [![Travis-CI](http://img.shields.io/travis/ta2k/ioBroker.vw-connect/master.svg)](https://travis-ci.org/ta2k/ioBroker.vw-connect)

## ioBroker 的 vw-connect 适配器

适用于 VW We Connect、We Connect ID、We Charge、myAudi、Skoda Connect、Seat Connect 和 We Connect Go 的适配器

请将您的系统更新到 Node 10。
<https://forum.iobroker.net/topic/22867/how-to-node-js-f%C3%BCr-iobroker-richtig-updaten>

## 使用方法

使用 remote control 下的状态远程控制您的汽车。
普通刷新是从 VAG 云接收数据的轮询间隔
强制刷新用于非电动车，强制刷新次数由 VAG 限制，直到汽车再次启动。
行程数据仅对非电动车可用。

您可以在
.climater.settings.targetTemperature.content
设置空调温度

## 讨论与问题

<https://forum.iobroker.net/topic/26438/test-adapter-vw-connect-für-vw-id-audi-seat-skoda>

## 状态字段说明

### 条目列表
```

```
## 更新日志

### 0.7.12 (2025-05-05)

- 修复斯柯达刷新令牌问题
- 修复通风激活问题
- 添加新的不支持端点

### 0.7.9 (2025-03-20)

- 修复ID壁式充电器问题

### 0.7.7 (2025-03-02)

- 修复斯柯达辅助加热及持续时间问题
- 修复斯柯达锁定/解锁问题

### 0.7.6 (2025-02-28)

- 修复充电状态仅在启动时更新的问题
- 修复斯柯达isMoving状态

### 0.7.3 (2025-02-26)

- 修复设置温度问题
- 修复斯柯达解锁锁定问题

### 0.7.0 (2025-02-25)

- 修复斯柯达和西雅特相关问题
- 状态结构完全更改，请删除对象下的旧状态

### 0.6.1 (2024-10-01)

- 修复斯柯达登录问题

### 0.6.0 (2024-04-11)

- 添加额外的Cupra状态

### 0.5.4 (2024-03-17)

- 修复车门窗状态

### 0.4.1

- 修复大众状态更新

### 0.0.65

- 修复Cupra登录

### 0.0.63

- 修复大众/斯柯达e-tron登录

### 0.0.62

- 修复奥迪e-tron登录

### 0.0.61

- 修复ID登录

### 0.0.60

- 小幅改进。WeCharge最小间隔现为15分钟

### 0.0.55

- 修复ID状态更新

### 0.0.51

- 修复奥迪e-tron登录

### 0.0.48

- 修复登录，修复奥迪更新，添加壁盒限制

### 0.0.43

- 增加刷新令牌超时时间

### 0.0.42

- 修复斯柯达登录

### 0.0.40

- 为较新车辆添加气候控制v3。添加Powerpass和西雅特Elli

### 0.0.39

- 修复ID登录

### 0.0.36

- 添加斯柯达Enyaq支持

### 0.0.35

- 添加对 nodeJS v10 的兼容性

### 0.0.34

- 添加自动接受新的隐私同意

### 0.0.32

- 修正最近行程的最后选择

### 0.0.31

- 启用多选行程类型

### 0.0.30

- 修复多车问题，目前VW和VWv2模式无差异

### 0.0.29

- 修复斯柯达刷新令牌，进行小幅改进

### 0.0.26

- 错误修复

### 0.0.25

- 添加 we charge 支持

### 0.0.24

- 添加远程状态更新

### 0.0.23

- 添加 Seat 和新版气候控制 v2

### 0.0.22

- 计算斯柯达和奥迪的外部温度，单位为摄氏度

### 0.0.21

- 添加 id 远程控制支持

### 0.0.20

- 修复奥迪登录，添加 ID 登录

### 0.0.19

- 通过 id 而非连续数字保存状态对象

### 0.0.18

- 修正 2020 年车型的电池状态

### 0.0.17

- 添加对 2020 年车型的支持

### 0.0.16

- 修复 js.controller 3 的问题

### 0.0.11

- 修复奥迪多车错误
- 如果功能不可用，隐藏状态更新错误

## 许可证

MIT 许可证

版权所有 (c) 2019-2030 ta2k <tombox2020@gmail.com>

特此免费授予任何获得本软件及相关文档文件（以下简称“软件”）副本的人无限制权利，包括但不限于使用、复制、修改、合并、发布、分发、再许可及/或出售软件副本的权利，并允许向其提供软件的人这样做，须遵守以下条件：

上述版权声明和本许可声明应包含在软件的所有副本或重要部分中。

本软件按“原样”提供，不附带任何明示或暗示的保证，包括但不限于对适销性、特定用途适用性及非侵权的保证。在任何情况下，作者或版权持有人均不对因软件或软件的使用或其他交易而产生的任何索赔、损害或其他责任负责，无论是在合同诉讼、侵权或其他方面。















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---