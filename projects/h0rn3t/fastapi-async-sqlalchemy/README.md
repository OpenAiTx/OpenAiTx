# SQLAlchemy FastAPI middleware

[![ci](https://img.shields.io/badge/Support-Ukraine-FFD500?style=flat&labelColor=005BBB)](https://img.shields.io/badge/Support-Ukraine-FFD500?style=flat&labelColor=005BBB)
[![ci](https://github.com/h0rn3t/fastapi-async-sqlalchemy/workflows/ci/badge.svg)](https://github.com/h0rn3t/fastapi-async-sqlalchemy/workflows/ci/badge.svg)
[![codecov](https://codecov.io/gh/h0rn3t/fastapi-async-sqlalchemy/branch/main/graph/badge.svg?token=F4NJ34WKPY)](https://codecov.io/gh/h0rn3t/fastapi-async-sqlalchemy)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![pip](https://img.shields.io/pypi/v/fastapi_async_sqlalchemy?color=blue)](https://pypi.org/project/fastapi-async-sqlalchemy/)
[![Downloads](https://static.pepy.tech/badge/fastapi-async-sqlalchemy)](https://pepy.tech/project/fastapi-async-sqlalchemy)
[![Updates](https://pyup.io/repos/github/h0rn3t/fastapi-async-sqlalchemy/shield.svg)](https://pyup.io/repos/github/h0rn3t/fastapi-async-sqlalchemy/)

### Description

Provides SQLAlchemy middleware for FastAPI using AsyncSession and async engine.

### Install

```bash
      pip install fastapi-async-sqlalchemy
```


It also works with ```sqlmodel```


### Examples

Note that the session object provided by ``db.session`` is based on the Python3.7+ ``ContextVar``. This means that
each session is linked to the individual request context in which it was created.

```python

from fastapi import FastAPI
from fastapi_async_sqlalchemy import SQLAlchemyMiddleware
from fastapi_async_sqlalchemy import db  # provide access to a database session
from sqlalchemy import column
from sqlalchemy import table

app = FastAPI()
app.add_middleware(
    SQLAlchemyMiddleware,
    db_url="postgresql+asyncpg://user:user@192.168.88.200:5432/primary_db",
    engine_args={              # engine arguments example
        "echo": True,          # print all SQL statements
        "pool_pre_ping": True, # feature will normally emit SQL equivalent to “SELECT 1” each time a connection is checked out from the pool
        "pool_size": 5,        # number of connections to keep open at a time
        "max_overflow": 10,    # number of connections to allow to be opened above pool_size
    },
)
# once the middleware is applied, any route can then access the database session
# from the global ``db``

foo = table("ms_files", column("id"))

# Usage inside of a route
@app.get("/")
async def get_files():
    result = await db.session.execute(foo.select())
    return result.fetchall()

async def get_db_fetch():
    # It uses the same ``db`` object and use it as a context manager:
    async with db():
        result = await db.session.execute(foo.select())
        return result.fetchall()

# Usage inside of a route using a db context
@app.get("/db_context")
async def db_context():
    return await get_db_fetch()

# Usage outside of a route using a db context
@app.on_event("startup")
async def on_startup():
    # We are outside of a request context, therefore we cannot rely on ``SQLAlchemyMiddleware``
    # to create a database session for us.
    result = await get_db_fetch()


if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="0.0.0.0", port=8002)

```

#### Usage of multiple databases

databases.py

```python
from fastapi import FastAPI
from fastapi_async_sqlalchemy import create_middleware_and_session_proxy

FirstSQLAlchemyMiddleware, first_db = create_middleware_and_session_proxy()
SecondSQLAlchemyMiddleware, second_db = create_middleware_and_session_proxy()
```

main.py

```python
from fastapi import FastAPI

from databases import FirstSQLAlchemyMiddleware, SecondSQLAlchemyMiddleware
from routes import router

app = FastAPI()

app.include_router(router)

app.add_middleware(
    FirstSQLAlchemyMiddleware,
    db_url="postgresql+asyncpg://user:user@192.168.88.200:5432/primary_db",
    engine_args={
        "pool_size": 5,
        "max_overflow": 10,
    },
)
app.add_middleware(
    SecondSQLAlchemyMiddleware,
    db_url="mysql+aiomysql://user:user@192.168.88.200:5432/primary_db",
    engine_args={
        "pool_size": 5,
        "max_overflow": 10,
    },
)
```

routes.py

```python
import asyncio

from fastapi import APIRouter
from sqlalchemy import column, table, text

from databases import first_db, second_db

router = APIRouter()

foo = table("ms_files", column("id"))

@router.get("/first-db-files")
async def get_files_from_first_db():
    result = await first_db.session.execute(foo.select())
    return result.fetchall()


@router.get("/second-db-files")
async def get_files_from_second_db():
    result = await second_db.session.execute(foo.select())
    return result.fetchall()


@router.get("/concurrent-queries")
async def parallel_select():
    async with first_db(multi_sessions=True):
        async def execute_query(query):
            return await first_db.session.execute(text(query))

        tasks = [
            asyncio.create_task(execute_query("SELECT 1")),
            asyncio.create_task(execute_query("SELECT 2")),
            asyncio.create_task(execute_query("SELECT 3")),
            asyncio.create_task(execute_query("SELECT 4")),
            asyncio.create_task(execute_query("SELECT 5")),
            asyncio.create_task(execute_query("SELECT 6")),
        ]

        await asyncio.gather(*tasks)
```
