# Meilisearch Plugin for Jellyfin

A plugin for Jellyfin that tries to improve search speed and results by utilizing Meilisearch as the search engine.

This plugin offloads search logic to Meilisearch, and modifies the response from Jellyfin.

As long as your client uses the `/Items` endpoint for search, it should be supported seamlessly I guess.

Inspired by [JellySearch](https://gitlab.com/DomiStyle/jellysearch).

---

### Usage

1. Setup a Meilisearch instance (maybe a hosted one in the cloud will also work, but I don't recommend).
2. Add following repository and install the Meilisearch plugin.
    ```
    https://raw.githubusercontent.com/arnesacnussem/jellyfin-plugin-meilisearch/refs/heads/master/manifest.json
    ```
3. Fill in the URL to your Meilisearch instance in the plugin settings, and an API key may also be required depending on your Meilisearch setup.  
4. If you want to share one Meilisearch instance across multiple Jellyfin instances, you can fill in the `Meilisearch Index Name`; if left empty, it will use the server name.  
5. Remember to click `Save` and make sure the status reports `ok`.  
6. Try typing something on the search page.  

    ---  

Index will update on the following events:  
- Server start  
- Configuration change  
- Library scan complete  
- Update index task being triggered  

---  

### How it works  

The core feature, which is to mutate the search request, is done by injecting an [`ActionFilter`](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-8.0#action-filters).  
So it may only support a few versions of Jellyfin. At the moment I'm using `Jellyfin 10.10.0`,  
but it should work on other versions as long as the required parameter name of the `/Items` endpoint doesn't change.  

---  
###  

I've seen JellySearch, which is a wonderful project, but I don't really like setting up a reverse proxy or any of that hassle.  

So I am writing this, but it still requires a Meilisearch instance.  

At this moment, only the `/Items` endpoint is affected by this plugin, but it still improves a lot on my 200k items library.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---