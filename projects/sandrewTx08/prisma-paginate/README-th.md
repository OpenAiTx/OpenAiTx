# 📖 prisma-paginate

| [![npm version](https://badge.fury.io/js/prisma-paginate.svg)](https://badge.fury.io/js/prisma-paginate) | [![CI](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/ci.yaml/badge.svg)](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/ci.yaml) | [![pages-build-deployment](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/pages/pages-build-deployment/badge.svg)](https://github.com/sandrewTx08/prisma-paginate/actions/workflows/pages/pages-build-deployment) |
| -------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |

# การติดตั้ง

```shell
npm i prisma @prisma/client prisma-paginate@latest
yarn add prisma @prisma/client prisma-paginate@latest
```

# เอกสารและการใช้งาน

สำหรับรายละเอียดเพิ่มเติมและ type definitions ดูได้ที่:

http://sandrewtx08.github.io/prisma-paginate/

## การนำเข้า

```js
// ESM
import { PrismaClient } from "@prisma/client";
import { extension } from "prisma-paginate";

// Commonjs
const { PrismaClient } = require("@prisma/client");
const { extension } = require("prisma-paginate");
```

## การใช้งาน extension

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

## การแบ่งหน้า 100 แถว

```js
// บนฐานข้อมูล = [ { id: 1 }, { id: 2 }, {...}, { id: 100 } ]
xprisma.model1
	.paginate(
		{
			where: {
				// query stuff...
			},
		},
		{ page: 1, limit: 50 },
	)
	.then((result) => {
		console.log(result.result); // [ {...}, { id: 48 }, { id: 49 }, { id: 50 } ]
	});
```

## การแบ่งหน้าคำสั่ง SQL

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

## พารามิเตอร์

- `findManyArgs` {Object}
- `paginationArgs` {Pagination&onCount?(pagination) => void}

---

- `findManyPaginationArgs` {Object&Pagination}

## ค่าที่ส่งกลับ

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