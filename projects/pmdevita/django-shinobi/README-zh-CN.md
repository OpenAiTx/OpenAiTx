<p align="center">
  <a href="https://pmdevita.github.io/django-shinobi/"><img src="https://pmdevita.github.io/django-shinobi/img/logo-big.png"></a>
</p>
<p align="center">
    <em>快速学习，快速编码，快速运行</em>
</p>


![Test](https://github.com/pmdevita/django-shinobi/actions/workflows/test_full.yml/badge.svg)
![Coverage](https://img.shields.io/codecov/c/github/pmdevita/django-shinobi)
[![PyPI version](https://badge.fury.io/py/django-shinobi.svg)](https://badge.fury.io/py/django-shinobi)
[![Downloads](https://static.pepy.tech/personalized-badge/django-shinobi?period=month&units=international_system&left_color=black&right_color=brightgreen&left_text=downloads/month)](https://pepy.tech/project/django-shinobi)
[![Discord](https://dcbadge.limes.pink/api/server/ntFTXu7NNv?style=flat-square)](https://discord.gg/ntFTXu7NNv)

# Django Shinobi - 快速的 Django REST 框架

[文档](https://pmdevita.github.io/django-shinobi)

**Django Shinobi** 是一个使用 **Django** 和 Python 3.6+ **类型提示** 构建 API 的网络框架。

它是出色的 **[Django Ninja](https://github.com/vitalik/django-ninja)** 库的一个分支，专注于社区期望的功能和修复。  
如果你来自 Ninja，请查看[差异列表](https://pmdevita.github.io/django-shinobi/differences/)以及[路线图](https://github.com/pmdevita/django-shinobi/discussions/6)！


 **主要特性：**

  - **简单易用**：设计易于使用且直观。
  - **高速执行**：得益于 **<a href="https://pydantic-docs.helpmanual.io" target="_blank">Pydantic</a>** 和 **<a href="/docs/docs/guides/async-support.md">异步支持</a>**，性能非常高。
  - **快速编码**：类型提示和自动文档让你只需专注于业务逻辑。
  - **基于标准**：基于 API 开放标准：**OpenAPI**（前称 Swagger）和 **JSON Schema**。
  - **Django 友好**：（显而易见）与 Django 核心和 ORM 有良好集成。
  - **生产就绪**：原 Ninja 项目被多家公司用于生产项目。



![Django Shinobi REST Framework](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/benchmark.png)

**文档**: https://pmdevita.github.io/django-shinobi


---

## 安装

在您的 Django 项目中，添加 Django Shinobi。

```
pip install django-shinobi
```
或开始一个新项目。


```shell
pip install django django-shinobi
django-admin startproject apidemo
```

## 使用方法


在你的 Django 项目中，在 urls.py 文件旁边，创建一个名为 `api.py` 的新文件。

```Python
from ninja import NinjaAPI

api = NinjaAPI()


@api.get("/add")
def add(request, a: int, b: int):
    return {"result": a + b}
```


Now go to `urls.py` and add the following:


```Python hl_lines="3 7"
...
from .api import api

urlpatterns = [
    path("admin/", admin.site.urls),
    path("api/", api.urls),  # <---------- !
]
```

**就是这样！**

现在你已经创建了一个 API，它：

 - 接收 `/api/add` 的 HTTP GET 请求
 - 获取、验证并类型转换 GET 参数 `a` 和 `b`
 - 将结果解码为 JSON
 - 为定义的操作生成 OpenAPI 模式

### 交互式 API 文档

运行你的 Django 项目

```shell
python manage.py runsever
```
现在访问 <a href="http://127.0.0.1:8000/api/docs" target="_blank">http://127.0.0.1:8000/api/docs</a>

您将看到自动交互式 API 文档（由 <a href="https://github.com/swagger-api/swagger-ui" target="_blank">Swagger UI</a> 或 <a href="https://github.com/Redocly/redoc" target="_blank">Redoc</a> 提供）：

![Swagger UI](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/index-swagger-ui.png)

## 接下来做什么？

 - 在此阅读完整文档 - https://pmdevita.github.io/django-shinobi
 - 若要支持此项目，请在 Github 上给它点赞。 ![github star](https://raw.githubusercontent.com/pmdevita/django-shinobi/master/docs/docs/img/github-star.png)
 - 通过 [Twitter 分享](https://twitter.com/intent/tweet?text=Check%20out%20Django%20Shinobi%20-%20Fast%20Django%20REST%20Framework%20-%20https%3A%2F%2Fpmdevita.github.io/django-shinobi)
 - 在 Discord 上分享您的反馈并讨论开发 https://discord.gg/ntFTXu7NNv




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-13

---