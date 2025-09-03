# kanjiapi.dev：现代化的汉字 JSON API

超过 13,000 个汉字，访问地址 [https://kanjiapi.dev](https://kanjiapi.dev)

## 链接
- API 文档：https://kanjiapi.dev/#!/documentation
- 了解为何某些汉字出现在特定列表的帮助：https://onlyskin.dev/official-kanji-list-diffs/

## 请我喝杯咖啡

https://buymeacoffee.com/onlyskin

## 示例

### 汉字 `/v1/kanji/{character}`
```
$ curl https://kanjiapi.dev/v1/kanji/猫
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/kanji/猫').then(r => r.json()).then(console.log);
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```
#### 所有支持的汉字列表

`$ curl https://kanjiapi.dev/v1/kanji/all`

#### 常用汉字列表

`$ curl https://kanjiapi.dev/v1/kanji/joyo`（也支持 `/jouyou`）

常用汉字是日本政府规定的一般使用汉字。
Unihan 数据库将另外四个汉字标注为常用汉字，使总数达到2140个编码点。
这是因为四个常用汉字在 JIS X 0208 编码中缺失，所以历史上使用了另一个存在于 JIS X 0208 中的汉字。
因此，在 Unihan 数据库中，官方的四个汉字和四个兼容 JIS X 0208 的汉字都被标记为常用汉字。
这也反映在 kanjiapi.dev 提供的 `/joyo` 列表中。

受影响的字符如下：
| 官方常用汉字 | 历史 JIS X 0208 兼容 |
| --- | --- |
|𠮟 U+20B9F |叱 U+53F1|
|塡 U+5861  |填 U+586B|
|剝 U+525D  |剥 U+5265|
|頰 U+9830  |頬 U+982C|

#### 人名用汉字列表

`$ curl https://kanjiapi.dev/v1/kanji/jinmeiyo`（也支持 `/jinmeiyou`）

注意，人在用汉字列表中有82个汉字的编码点位于 Unicode CJK 兼容区块。
因此，它们有时会被视为与另一个字符“相同的汉字”，这由 Unicode 在 Unihan 数据库中指定。

`kanjiapi.dev` 为这些 CJK 兼容编码点提供了 `/kanji/{character}` 接口，但为方便访问该字符的统一版本，增加了一个特殊字段。
此外，这些兼容字符在对应的 `/words/{character}` 接口文件中大多没有列出单词，且在 `/kanji/{character}` 接口字段中的信息也更加有限。
这反映了所提供数据的情况。








在 `KANJIDIC` 文件中。

例如，姓名用汉字 海 (U+FA45) 被 Unicode 视为与常用汉字 海 (U+6d77) 相同。  
因此，姓名用版本存在于 CJK 兼容区块中。

这是一个问题，因为任何软件层（例如浏览器缓存、URL 编码）都可能执行 Unicode 规范化，  
这会将姓名用字符转换为不同的字符。如果你期望看到姓名用字符，  
但看到的是常用字符，这很可能就是原因。

如果需要，可以使用 CSS 属性 `font-variant-east-asian: traditional;`  
告诉浏览器以传统方式显示统一的等价字符，  
这应该意味着常用字符的代码点显示为其姓名用对应字符。

#### Heisig 汉字列表

`$ curl https://kanjiapi.dev/v1/kanji/heisig`

列出被分配了 Heisig 关键词的字符。注意，heisig 列表中有四个带有 “[alt]” 标签的额外汉字，  
这些是缺失的 JIS X 0208 汉字的四个官方常用变体（Heisig 书系将这些关键词分配给 JIS 兼容字符，  
但查找者可能来自 JIS 兼容版本或官方版本）。详见上文的 “常用汉字列表” 部分。

#### 指定年级的汉字列表

`$ curl https://kanjiapi.dev/v1/kanji/grade-1` （学校年级 1-6，年级 8 表示剩余高中年级）

### 读取 `/v1/reading/{reading}`






```
$ curl https://kanjiapi.dev/v1/reading/クウ
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

### 词语 `/v1/words/{character}`
```
$ curl https://kanjiapi.dev/v1/words/猫
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

## 开发：

### 需求：

假设系统已安装 `python 3`、`make` 和 `node`。

### 设置：

使用 requirements.txt 安装 Python 库。

使用 `yarn` 或 `npm install` 安装 node 依赖。

将来自 [EDRDG](http://www.edrdg.org/wiki/index.php/KANJIDIC_Project) 的汉字词典文件 `kanjidic2.xml` 保存并解压到项目根目录。

将来自 [EDRDG](http://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project) 的 jmdict 词典文件 `JMdict` 保存并解压到项目根目录。

将来自 [Unicode](https://www.unicode.org/versions/components-15.0.0.html) 的 Unihan.zip 中的文件 Unihan_OtherMappings.txt 保存并解压到项目根目录。

将来自 [Unicode](https://www.unicode.org/versions/components-15.0.0.html) 的 Unihan.zip 中的文件 Unihan_IRGSources.txt 保存并解压到项目根目录。

确保系统中有 `System/Library/Fonts/ヒラギノ丸ゴ\ ProN\ W4.ttc` 字体（用于生成网站图标）。

### 构建：

运行 `make` 构建网站和 API 端点为静态资源。

运行 `python -m pytest tests` 运行测试。

注意：为了从本地构建的 API 获取数据并由本地构建的网站访问，可以将文件服务器的根目录设置为 out/site（例如，使用 `serveit`：`serveit -s out/site make`）。在 `out/site` 中有一个指向 `out/v1` 的符号链接以支持此操作。

注意：Unicode CJK 兼容区块中的字符端点文件会写入到一个单独的目录，因为某些文件系统会将它们与非兼容等价字符进行归一化。这意味着在本地开发时，一些 `/kanji/{character}` 和 `/words/{character}` 端点不会出现在 API 的正常路径下。








### 部署（需要 Google Cloud 账户凭证）：

#### 版本控制

部署的 API 版本硬编码在 `api_data.py` 和 `makefile` 中。

#### 上传到存储桶

构建完成后，运行以下命令将构建好的资源同步到网站存储桶：

注意：建议先使用 `rsync -n` 进行模拟运行，检查命令效果。

将构建好的站点目录（`out/site`）非递归同步到存储桶根目录：
`gsutil -m rsync -c -d -x ".*\.map$" out/site gs://kanjiapi.dev`

递归根据文件哈希将构建好的 API 目录（`out/{version}`）同步到存储桶中的对应版本目录 `/{version}`：
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/kanji gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/kanji_cjk gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/words gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/words_cjk gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/reading gs://kanjiapi.dev/v1/reading/`

#### 设置 CORS 策略：

CORS 策略保存在 `cors.json` 文件中，可以通过编辑该文件并运行 `gsutil cors set cors.json gs://kanjiapi.dev` 来更新。

### 日志记录：

API 的日志文件由云存储桶生成，当写入使用日志时，会触发云函数。

该云函数读取日志文件，聚合一些有用的信息，并显示在 [日志页面](https://kanjiapi.dev/#!/logs) 上。

云函数位于 `popularity-contest` 目录下。

部署命令为：运行 `gcloud functions deploy popularity-contest --gen2 --region=us-west1 --runtime=python310 --source popularity-contest --entry-point handle --trigger-bucket=kanjiapi-dev-logging --trigger-location=us` 从终端执行。





项目根目录。（需要凭证）

要在本地运行云函数，进入 `popularity-contest` 目录，
根据该子目录中的 `requirements.txt` 文件创建和/或激活虚拟环境，
然后运行 `python main.py`。这对于手动（重新）处理一些日志文件而无需部署或触发云
函数非常有用。（需要凭证）



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-03

---