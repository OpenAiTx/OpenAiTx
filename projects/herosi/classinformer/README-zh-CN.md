# 类信息器  
使用原始的 classinformer（见以下网址）。  
https://github.com/kweatherman/IDA_ClassInformer_PlugIn  

原作者 Kevin Weatherman，也称为“Sirmabus”，现已在上述网址发布了适用于 IDA 9 的插件。  
因此，本仓库的目的已完成！  
现在是归档此仓库的时候了。  
---------------------------------  

IDA Class Informer 插件，适用于 IDA Pro 9 和 8。它只是[原始 classinformer](https://sourceforge.net/projects/classinformer/)的移植版本，支持 IDA 8 和 9。因此，我不会积极开发它。如果你想改进它，请向我发送 PR。不要为改进请求打开 issue。  

 - 该插件已在 IDA Pro `9.1`、`9.0 SP1`、`9.0`、`8.4 SP2`、`8.2 SP1` 和 `8.0` 的 32 位和 64 位版本上进行了测试。  
   - ***重要！！！*** IDA Pro 9.0 ***beta*** 不支持。请使用正式发布版本。  
   - IDA Pro 7.x 无法加载该插件。请使用[原始版本](https://sourceforge.net/projects/classinformer/)。  
 - **该插件仅支持解析 Windows 平台上 PE 格式二进制文件中 MSVC++ 的 RTTI，支持 x86、x64、ARM 和 ARM64 架构。**我不会支持 GCC 的 RTTI 和其他架构。  
 - 对于 IDA 9，只需安装 `ClassInformer64.dll`。  
 - 对于 IDA 8，需要安装 `ClassInformer_IDA8x64.dll` 和 `ClassInformer_IDA8x.dll` 两个文件。  
 - 如果你的机器上同时安装了 IDA 8 和 9，请根据版本将它们复制到 IDA 的相应目录，或将所有 dll 复制到 `%IDAUSR%\plugins`。  
   - 如果你不了解 IDAUSR，请参阅[这篇博客文章](https://hex-rays.com/blog/igors-tip-of-the-week-33-idas-user-directory-idausr)。  

## 下载  
- 你可以从[Releases](../../releases)部分下载编译好的二进制文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---