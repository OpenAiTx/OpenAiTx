# 📖 prisma-paginate

| [![npm version](https://badge.fury.io/js/prisma-paginate.svg)](https://badge.fury.io/js/prisma-paginate) | [![CI](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/ci.yaml/badge.svg)](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/ci.yaml) | [![pages-build-deployment](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/pages/pages-build-deployment/badge.svg)](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/pages/pages-build-deployment) |
| -------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |

# Cài đặt

```shell
npm i prisma @prisma/client prisma-paginate@latest
yarn add prisma @prisma/client prisma-paginate@latest
```

# Tài liệu và cách sử dụng

Để biết thêm chi tiết và định nghĩa kiểu, xem tại:

http://sandrewtx08.github.io/prisma-paginate/

## Import

```js
// ESM
import { PrismaClient } from "@prisma/client";
import { extension } from "prisma-paginate";

// Commonjs
const { PrismaClient } = require("@prisma/client");
const { extension } = require("prisma-paginate");
```

## Áp dụng extension

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

## Phân trang 100 dòng

```js
// trên cơ sở dữ liệu = [ { id: 1 }, { id: 2 }, {...}, { id: 100 } ]
xprisma.model1
	.paginate(
		{
			where: {
				// các điều kiện truy vấn...
			},
		},
		{ page: 1, limit: 50 },
	)
	.then((result) => {
		console.log(result.result); // [ {...}, { id: 48 }, { id: 49 }, { id: 50 } ]
	});
```

## Phân trang truy vấn SQL

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

## Tham số

- `findManyArgs` {Object}
- `paginationArgs` {Pagination&onCount?(pagination) => void}

---

- `findManyPaginationArgs` {Object&Pagination}

## Giá trị trả về

- `result` {Array}
- `totalPages` {Number}
- `hasNextPage` {Boolean}
- `hasPrevPage` {Boolean}
- `count` {Number}
- `nextPage` {() => Promise}
- `exceedCount` {Boolean}
- `exceedTotalPages` {Boolean}


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---