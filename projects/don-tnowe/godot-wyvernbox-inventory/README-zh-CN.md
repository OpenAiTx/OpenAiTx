# Wyvernbox

一个多功能库存系统的插件。

你可能需要的场景位于 `addons/wyvernbox_prefabs` 目录中。只需拖放即可！

`example/wyvernbox` 文件夹包含一些初始物品和装备属性。别忘了查看示例场景！

## 你需要的全部：

- 一个 `InventoryView` 对象，
- 一个 `InventoryTooltip` 用于检查物品（*可能附带一些 `TooltipProperty` 脚本*），
- 一个 `GrabbedItemStackView` 用于用鼠标移动物品，
- 以及几个 `ItemType` 资源来定义物品类型。

## 工作原理：

- `InventoryView` 提供与匹配类型的 `Inventory` 的用户交互；
- Inventory 保存 `ItemStack`；
- ItemStack 由 `ItemType` 创建。
- ItemType 存储默认数据，并用于合成配方和物品生成器。

## 特性：

- 多种库存类型，均兼容 GUI 容器，如：
  - 基本型
  - 网格型（*物品占据一个矩形格子*）
  - 限制型（*只能放入带有特定标记的物品，如装备或弹药*）
  - 货币型（*自定义最大堆叠数量，但只限指定物品*）

- 合成与商店：
  - 自动售货是库存的内置功能，若需更多配置，请使用 `InventoryVendor` 类！
  - 合成配方通过 `ItemConversion` 定义——可提供预设结果、随机数量，或来自 `ItemGenerator` 的全新物品！
  - 使用 `ItemPattern` 匹配多种物品，用于过滤或配方，比如不同燃料类型对应不同效率！

- **手势操作**：快速转移（Shift-点击），收集/转移所有同类型物品（双击），拆分一件/一半（右击）
- 通过多功能的 `ItemPattern` 类过滤地面和库存物品！用它们控制库存插入和合成输入。
- 自定义检视面板表格，映射物品到你自己的类的数值——用于 ShopManager、ItemGenerator 和 ItemPattern 对象！包含物品浏览弹窗，方便从项目中拖放物品类型、生成器和模式。
- 工具提示可通过 `TooltipProperty` 类扩展！只需附加一堆脚本即可。

#
由 Don Tnowe 于 2022 年制作。

[我的网站](https://redbladegames.netlify.app)

[Itch](https://don-tnowe.itch.io)

[推特](https://twitter.com/don_tnowe)

**需要帮助或想聊天？联系我！** [Telegram](https://t.me/don_tnowe), [Discord](https://discord.com/channels/@me/726139164566880426)

**这个工具帮到了你，想回馈一下？** [通过 PayPal 捐赠！](https://redbladegames.netlify.app/tip/index.html)

#

允许复制和修改，遵循 MIT 许可证，除非另有说明。许可证文本包含其中。

示例中的字体为 [Abaddon，基于知识共享署名 3.0 许可。](https://caffinate.itch.io/abaddon)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---