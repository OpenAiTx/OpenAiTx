## 关于
TextMeshPro 动态字体资源有一个非常恼人的习惯，就是将其动态生成的二进制数据保存在
与其配置数据相同的文本文件中。这给版本控制带来了极大的麻烦。

本包中的脚本解决了上述问题。它在项目中任何资源即将保存时运行。如果这些
资源是 TMP 动态字体资源，它们的动态生成数据将在保存前被清除，从而防止这些数据污染版本控制。

感谢 @cxode 提出的这个精彩解决方案：<br>
`https://forum.unity.com/threads/tmpro-dynamic-font-asset-constantly-changes-in-source-control.1227831/#post-8934711`

我的贡献是将脚本制作成一个兼容 upm 的包，便于安装。<br>
对性能进行了改进，并增加了对边缘情况的额外检查。<br>
此外，我创建了一个测试，用于快速检测脚本在您的项目/Unity 版本中是否正常工作。<br>

## 安装
通过 git URL 安装：
`https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm`

或者通过在您的 **`manifest.json`** 中添加新条目安装。

```json
{
  "dependencies": {
    "com.starasgames.tmpro-dynamic-data-cleaner": "https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm",
    ...
  },
  "testables" : ["com.starasgames.tmpro-dynamic-data-cleaner"]
}
```
要使集成测试在 TestRunner 窗口中可见，您需要添加 `"testables"` 属性，但这是可选的。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---