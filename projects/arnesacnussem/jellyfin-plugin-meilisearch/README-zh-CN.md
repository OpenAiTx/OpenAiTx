# Jellyfin 的 Meilisearch 插件

一个为 Jellyfin 设计的插件，尝试通过利用 Meilisearch 作为搜索引擎来提升搜索速度和结果。

该插件将搜索逻辑卸载到 Meilisearch，并修改 Jellyfin 的响应。

只要你的客户端使用 `/Items` 端点进行搜索，我猜应该可以无缝支持。

灵感来自 [JellySearch](https://gitlab.com/DomiStyle/jellysearch)。

---

### 使用方法

1. 搭建一个 Meilisearch 实例（云端托管的可能也能用，但我不推荐）。
2. 添加以下仓库并安装 Meilisearch 插件。
    ```
    https://raw.githubusercontent.com/arnesacnussem/jellyfin-plugin-meilisearch/refs/heads/master/manifest.json
    ```
3. 在插件设置中填写你的 Meilisearch 实例的 URL，根据你的 Meilisearch 配置，可能还需要填写 API 密钥。  
4. 如果你想在多个 Jellyfin 实例之间共享一个 Meilisearch 实例，可以填写 `Meilisearch Index Name`，如果留空，则使用服务器名称。  
5. 记得点击 `保存` 并确保状态显示为 `ok`。  
6. 尝试在搜索页面输入内容。  

    ---  

索引将在以下事件发生时更新：  
- 服务器启动  
- 配置更改  
- 库扫描完成  
- 触发更新索引任务  

---  

### 工作原理  

核心功能，即修改搜索请求，是通过注入一个 [`ActionFilter`](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-8.0#action-filters) 实现的。  
因此它可能只支持部分版本的 Jellyfin。目前我使用的是 `Jellyfin 10.10.0`，  
但只要 `/Items` 端点所需的参数名称不变，应该也能在其他版本上工作。  

---  
###  

我见过 JellySearch，这是一个很棒的项目，但我不太喜欢设置反向代理或类似的麻烦。  

所以我写了这个，但它仍然需要一个 Meilisearch 实例。  

目前，只有 `/Items` 端点受此插件影响，但它仍然极大地提升了我 20 万条目图书馆的搜索体验。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---