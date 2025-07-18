<a href="https://www.usebillsplit.com/">
<img alt="Self" src="https://raw.githubusercontent.com/Nutlope/billsplit/main/./public/og.png">
</a>

<div align="center">
    <h1 >BillSplit</h1>
    <p>
        一个现代的账单分摊应用。由 Together.ai 提供技术支持。
    </p>
</div>

## 技术栈

- 使用 App Router 的 Next.js 15 进行现代网页开发
- Together.ai 提供先进的 LLM 功能
- Helicone 用于 LLM 的可观察性和监控
- Amazon S3 用于安全的图片存储
- Vercel 实现无缝部署和托管

## 工作原理

1. 用户上传账单图片
2. 应用使用带有视觉模型和 Json 模式的 Together.ai 处理 PDF
3. 应用让用户选择如何分摊项目并添加人员姓名
4. 应用展示账单分摊的最终汇总

## 克隆与运行

1. Fork 或克隆该仓库
2. 在 https://togetherai.link 创建 LLM 账户
3. 在 https://aws.amazon.com/ 创建 S3 存储桶账户
4. 创建 `.env` 文件（参考 `.example.env`）并替换 API 密钥
5. 运行 `pnpm install` 和 `pnpm run dev` 以安装依赖并本地运行


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---