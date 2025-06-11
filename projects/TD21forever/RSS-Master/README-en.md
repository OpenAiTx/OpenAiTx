# RSS-Master

Custom filtering and screening for RSS feeds, using AI for summarization, abstraction, scoring, etc. Performance-optimized version, supporting asynchronous processing and parallel AI summarization.

### Preface

In early September, I started using Inoreader + RSSHub to aggregate and subscribe to RSS feeds I’m interested in, paired with Reeder for reading. Trying to fully control the daily input information sources, after a month, the increasing number of RSS feeds and the growing unread information caused me quite a bit of reading anxiety. So I wondered if there was a way to customize some filtering rules, preferably with AI to assist my reading and reduce my reading burden.

Inoreader comes with filters, but paying just for this feature felt a bit not cost-effective; NewsBlur has an "Intelligence Trainer" for intelligent classification, but I tried it briefly and felt the feedback was not obvious, and it didn’t show intelligence in a short time; Feedly has both filtering and AI features, which sounded very satisfying to my needs. Just as I was hesitating whether to switch from Inoreader to a paid Feedly user, I saw these two projects:

- [Let ChatGPT help us summarize Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT User Guide](http://yinan.me/rss-gpt-manual-zh.html)

The overall idea of these two projects is to use GitAction to execute a script, fetch information, then use OpenAI’s API for translation and summarization, render it into a template, and deploy it on GitHub Pages. The approach in RSS-GPT better meets my needs: by periodically executing a script to directly fetch the RSS XML files, process them, and deploy the XML on GitHub Pages, you get an access link to the XML file, which the reader can directly subscribe to.

I have a strong demand for Inoreader multi-device sync. For RSS feeds added in the config file, I need timely notification to Inoreader for syncing. So I extended the idea from [RSS-GPT](https://github.com/yinan-c/) and created RSS-Master.

### Features

- **Supports parallel processing**: Uses async and thread pools to process RSS feeds and AI summarizations in parallel, significantly improving speed
- **Enhanced caching mechanism**: More stable caching system to prevent data loss and improve repeated access performance
- **Improved error handling**: Complete error handling and logging for all operations, increasing stability
- **HTML content optimized extraction**: Intelligently extracts article content, ignoring irrelevant info, improving AI summarization quality
- **Supports the latest OpenAI API**: Fully compatible with the latest OpenAI API versions
- **Detailed statistics**: Provides runtime, success rate, and cost statistics after processing
- **Supports OPML file generation**: And mutual conversion with `config.yml`: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **Supports custom filtering rules**: Supports include and exclude types, with title and article scopes
- **Customizable AI model**: Configure different OpenAI models via environment variables
- **Customizable base URL**: Configure the base access URL for RSS files, convenient for deployment in different environments
- **Interactive test notebook**: Provides a Jupyter notebook for testing various features

### Environment Variable Configuration

The project supports configuring the following parameters via a `.env` file:

```
# Required parameters
OPENAI_API_KEY=your_openai_api_key_here

# Optional parameters
RSS_BASE_URL=https://example.com/rss-feeds/  # RSS base URL
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAI model
LOG_LEVEL=INFO                               # Log level
PARALLEL_WORKERS=5                           # Number of parallel workers
```

You can copy the `.env.example` file, rename it to `.env`, and then modify the parameter values accordingly.

### Performance Improvements

Compared to the original version, this version has the following performance improvements:

1. **Parallel RSS feed processing**: Uses `asyncio` to handle multiple RSS feeds simultaneously
2. **Parallel AI summarization**: Uses thread pools to concurrently process AI summaries of multiple articles
3. **Text processing optimization**: Improved HTML content extraction algorithm to more intelligently capture key article content
4. **Safe file handling**: Uses safe file writing mechanisms to avoid data loss due to program crashes
5. **Memory usage optimization**: Optimized data structures and processing flow to reduce memory footprint

### Usage Instructions

1. Clone the project locally
2. Install dependencies: `pip install -r requirements.txt`
3. Create `.env` file and set your OpenAI API key: `OPENAI_API_KEY=your_key`
4. Modify `resource/config.yml` to configure your RSS feeds
5. Run `python main.py` to start processing

### Testing and Debugging

The project provides an interactive test notebook `test.ipynb` for testing various features:

1. RSS feed fetching and parsing
2. Filter function
3. AI summarization function
4. Caching mechanism
5. Custom base URL
6. Performance testing

Usage:

```bash
# Install Jupyter
pip install jupyter

# Launch notebook
jupyter notebook test.ipynb
```

### Custom Filtering Rule Example

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

### Usage Screenshots

- AI summarization and abstraction features

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/https://qiniu.dcts.top/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/https://qiniu.dcts.top/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Custom filtering: filtering the "什么值得买" good deals channel, only recommending recent items I want to stock up, such as soda

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/https://qiniu.dcts.top/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---