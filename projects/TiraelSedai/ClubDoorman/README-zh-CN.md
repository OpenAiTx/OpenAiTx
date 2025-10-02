## Telegram反垃圾系统

最初开发是为了解决Vastrik.Club聊天室中的垃圾信息问题，但也可以用于其他分叉的聊天室，甚至任何大型聊天室。

### 工作原理
- 绑定了机器人账号的俱乐部用户自动加入信任名单
- 当事件“用户加入聊天室”发生时，会发出简单的验证码
- 如果用户已在信任名单中，则跳过所有检查
- 如果用户在已知垃圾用户名单中——直接拒绝
- 如果消息中表情符号过多——直接拒绝
- 如果消息中包含伪装成俄语但含有英文字母的词——直接拒绝。此功能目前主要针对俄语聊天室调优，可能会误判使用西里尔字母的其他语言中的正常词汇，但目前所有已知案例均已添加到测试中。
- 如果消息包含“网络赚钱”等禁用词汇——直接拒绝
- 接着消息会去除表情符号、标点符号、变音符号并交给机器学习模型判断。如果机器学习模型判定为垃圾——直接拒绝。
- 如果用户发送了几条正常消息，则被加入信任名单——垃圾用户极少“混入信任”，通常会在第一、第二条消息暴露身份
- 机器人自动只删除消息，用户封禁仅通过管理员后台手动执行，以减少误判造成的损失
- - 黑名单用户除外，此类用户会被立即封禁，但此功能可关闭
- 如果聊天室中某人被非机器人封禁，管理员后台会收到通知，说明机器人可能漏判了垃圾信息，该用户应被加入数据集

### 管理命令
所有命令通过回复目标消息调用
- /spam - 将消息添加到垃圾数据集中
- /ham - 将消息添加到非垃圾数据集中
- /check - 让消息通过所有检查流程

### 配置
创建管理员聊天，记录ID。
环境变量：
- DOORMAN_BOT_API：Telegram机器人令牌，必填
- DOORMAN_ADMIN_CHAT：管理员聊天ID，必填
- DOORMAN_CLUB_SERVICE_TOKEN：俱乐部服务令牌，创建地址：https://vas3k.club/apps/。未设置时，自动批准俱乐部用户功能关闭。
- DOORMAN_CLUB_URL：俱乐部分叉基础URL，例如 https://rationalanswer.club/
- DOORMAN_BLACKLIST_AUTOBAN_DISABLE：设置为true或1时，机器人不会自动封禁非俱乐部、未批准且在黑名单中的用户
- DOORMAN_LOW_CONFIDENCE_HAM_ENABLE：设置为true或1时，将低置信度的非垃圾消息发送到管理员后台，适用于垃圾用户频繁测试机器学习准确性的聊天室
- DOORMAN_CHANNELS_AUTOBAN_DISABLE：设置为true或1时，机器人不会封禁来自频道的消息（除绑定到当前群组的频道外）
- DOORMAN_APPROVE_BUTTON：设置为true或1时，每条被删除的消息会附带“这是自己人、熟人、常客”的选项
- DOORMAN_LOOKALIKE_AUTOBAN_DISABLE：设置为true或1时，机器人不会封禁包含伪装成俄语词汇的消息
- DOORMAN_BUTTON_AUTOBAN_DISABLE：设置为true或1时，机器人不会封禁包含按钮的消息
- DOORMAN_HIGH_CONFIDENCE_AUTOBAN_DISABLE：设置为true或1时，机器人不会封禁机器学习模型高度确定为垃圾的消息
- DOORMAN_CHANNEL_AUTOBAN_EXCLUSION：以逗号分隔的群组列表，指定这些群组内频道消息不被封禁

#### 谢谢
- https://lols.bot/ 感谢对抗垃圾邮件者和提供黑名单API
- https://github.com/umputun/tg-spam/ 感谢提供一些想法和四分之三的数据集

### 翻译
如果您愿意承担将此机器人所有文本翻译成其他语言的重任，请先告知我，再着手进行并创建PR。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---