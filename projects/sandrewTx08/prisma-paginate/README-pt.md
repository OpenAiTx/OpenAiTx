# 📖 prisma-paginate

| [![npm version](https://badge.fury.io/js/prisma-paginate.svg)](https://badge.fury.io/js/prisma-paginate) | [![CI](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/ci.yaml/badge.svg)](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/ci.yaml) | [![pages-build-deployment](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/pages/pages-build-deployment/badge.svg)](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/pages/pages-build-deployment) |
| -------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |

# Instalação

```shell
npm i prisma @prisma/client prisma-paginate@latest
yarn add prisma @prisma/client prisma-paginate@latest
```

# Documentação e uso

Para mais detalhes e definições de tipos veja:

http://sandrewtx08.github.io/prisma-paginate/

## Importação

```js
// ESM
import { PrismaClient } from "@prisma/client";
import { extension } from "prisma-paginate";

// Commonjs
const { PrismaClient } = require("@prisma/client");
const { extension } = require("prisma-paginate");
```

## Aplicando a extensão

```js
const prisma = new PrismaClient();
const xprisma = prisma.$extends(extension);

xprisma.model2
	.paginate({ limit: 10, page: 1, select: { id: true } })
	.then((result) => {
		console.log(result);
	});

xprisma.table1
	.paginate({ where: { id: 5 } }, { limit: 10, page: 1 })
	.then((result) => {
		console.log(result);
	});
```

## Paginando 100 linhas

```js
// no banco de dados = [ { id: 1 }, { id: 2 }, {...}, { id: 100 } ]
xprisma.model1
	.paginate(
		{
			where: {
				// parâmetros da consulta...
			},
		},
		{ page: 1, limit: 50 },
	)
	.then((result) => {
		console.log(result.result); // [ {...}, { id: 48 }, { id: 49 }, { id: 50 } ]
	});
```

## Paginando consultas SQL

```ts
const [{ count }] = await prisma.$queryRawUnsafe<[{ count: bigint }]>(
	'SELECT COUNT(*) FROM "Model3";',
);

const pagination = new Pagination(limit, page, Number(count));
```

```ts
const data = await prisma.$queryRawUnsafe<unknown[]>(
	'SELECT name FROM "Model3" LIMIT $1 OFFSET $2;',
	limit,
	Pagination.offset(limit, page),
);
```

## Parâmetros

- `findManyArgs` {Object}
- `paginationArgs` {Pagination&onCount?(pagination) => void}

---

- `findManyPaginationArgs` {Object&Pagination}

## Retorno

- `result` {Array}
- `totalPages` {Number}
- `hasNextPage` {Boolean}
- `hasPrevPage` {Boolean}
- `count` {Número}
- `nextPage` {() => Promessa}
- `exceedCount` {Booleano}
- `exceedTotalPages` {Booleano}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---