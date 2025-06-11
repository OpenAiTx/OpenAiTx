# RSS-Master

针对 RSS 源的自定义过滤、筛选，使用 AI 总结、概括、打分等。性能优化版本，支持异步处理和并行 AI 总结。

### 前言

9 月初旬，我开始使用 Inoreader + RSSHub 来聚合、订阅我感兴趣的 RSS，配合 Reeder 阅读，试图完全掌控每日输入的信息源头，一个月下来，逐渐增多的 RSS 源，日益增加的未读信息，给我增添了不少阅读焦虑，于是想着是否有方式可以自定义一些过滤规则的，最好能加入 AI 来辅助我阅读，减少我阅读的负担。

Inoreader 自带有过滤器，但仅仅为这个功能买单感觉有点不划算; NewsBlur 有「Intelligence Trainer」来做智能分类，但我简单尝试了下感觉反馈不明显，短时间内体现不出智能；Feedly 既有筛选还有 AI 功能，听起来很满足我的需求，正当我踌躇要不要从 Inoreader 转到 Feedly 的付费用户的时候，我看到了这两个项目

- [让 ChatGPT 帮我们总结 Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT 使用指南](http://yinan.me/rss-gpt-manual-zh.html)

这两个项目的总体思路都是通过 GitAction 去执行一个脚本，获取信息后使用 Open AI 的 API 进行翻译、总结，然后渲染成模板，部署到 GitHub Page 上。RSS-GPT 中的方式会更加满足我的需求，通过定时执行脚本直接获取 RSS 的 xml 文件，处理后把 xml 部署到 GitHub Page 上后，就可以得到这个 xml 文件的访问链接，最后让阅读器直接订阅这个链接即可。

我对 Inoreader 的多端同步有强需求,对于在 config 配置文件中新增的 RSS 源,需要及时通知到 Inoreader 去同步,于是我在[RSS-GPT](https://github.com/yinan-c/)的思路上做了扩展，叫做 RSS-Master。

### 功能特点

- **支持并行处理**：使用异步和线程池实现 RSS 源和 AI 总结的并行处理，显著提升处理速度
- **增强的缓存机制**：更稳定的缓存系统，防止数据丢失和提高重复访问性能
- **更好的错误处理**：所有操作都有完整的错误处理和日志记录，提高稳定性
- **HTML 内容优化提取**：智能提取文章内容，忽略无关信息，提高 AI 总结质量
- **支持最新的 OpenAI API**：完全兼容最新版本的 OpenAI API
- **详细统计信息**：处理完成后提供运行时间、成功率和成本统计
- **支持 opml 文件的生成**：以及和 config.yml 的相互转换：[https://raw.githubusercontent.com/TD21forever/RSS-Master/main/script/convert_opml_to_yaml.sh](https://raw.githubusercontent.com/TD21forever/RSS-Master/main/script/convert_opml_to_yaml.sh) [https://raw.githubusercontent.com/TD21forever/RSS-Master/main/script/convert_yaml_to_opml.sh](https://raw.githubusercontent.com/TD21forever/RSS-Master/main/script/convert_yaml_to_opml.sh)
- **支持自定义筛选规则**：支持 include、exclude 两种类型，title 和 article 两种作用域
- **可自定义 AI 模型**：通过环境变量配置使用不同的 OpenAI 模型
- **可自定义基础 URL**：可配置 RSS 文件的基础访问 URL，便于在不同环境中部署
- **交互式测试笔记本**：提供 Jupyter 笔记本用于测试各项功能

### 环境变量配置

项目支持通过 `.env` 文件配置以下参数：

```
# 必需参数
OPENAI_API_KEY=your_openai_api_key_here

# 可选参数
RSS_BASE_URL=https://example.com/rss-feeds/  # RSS 基础 URL
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAI 模型
LOG_LEVEL=INFO                               # 日志级别
PARALLEL_WORKERS=5                           # 并行处理数量
```

可以复制 `.env.example` 文件并重命名为 `.env`，然后修改相应的参数值。

### 性能改进

本版本相比原始版本有以下性能改进：

1. **RSS 源并行处理**：使用`asyncio`同时处理多个 RSS 源
2. **AI 总结并行化**：使用线程池并发处理多篇文章的 AI 总结
3. **文本处理优化**：改进了 HTML 内容提取算法，更智能地提取文章关键内容
4. **安全的文件处理**：采用了安全的文件写入机制，避免因程序崩溃导致的数据丢失
5. **内存使用优化**：优化数据结构和处理流程，减少内存占用

### 使用说明

1. 克隆项目到本地
2. 安装依赖：`pip install -r requirements.txt`
3. 创建`.env`文件并设置 OpenAI API 密钥：`OPENAI_API_KEY=你的密钥`
4. 修改`resource/config.yml`配置你的 RSS 源
5. 运行`python main.py`开始处理

### 测试与调试

项目提供了一个交互式测试笔记本 `test.ipynb`，可以用于测试各项功能：

1. RSS 源获取与解析
2. 筛选器功能
3. AI 摘要功能
4. 缓存机制
5. 自定义基础 URL
6. 性能测试

使用方法：

```bash
# 安装 Jupyter
pip install jupyter

# 启动笔记本
jupyter notebook https://raw.githubusercontent.com/TD21forever/RSS-Master/main/test.ipynb
```

### 自定义筛选规则示例

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### 使用截图

- AI 概括、摘要功能

<div style="display: flex;">
    <img src="https://qiniu.dcts.top/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://qiniu.dcts.top/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- 自定义筛选：过滤「什么值得买」的好价频道，只推荐近期想屯的货，如汽水

<img src="https://qiniu.dcts.top/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---