<a href="https://www.usebillsplit.com/">
<img alt="Self" src="https://raw.githubusercontent.com/Nutlope/billsplit/main/./public/og.png">
</a>

<div align="center">
    <h1 >BillSplit</h1>
    <p>
        현대적인 계산서 분할 앱입니다. Together.ai가 지원합니다.
    </p>
</div>

## 기술 스택

- 현대 웹 개발을 위한 App Router가 포함된 Next.js 15
- 고급 LLM 기능을 위한 Together.ai
- LLM 관찰 및 모니터링을 위한 Helicone
- 안전한 이미지 저장을 위한 Amazon S3
- 원활한 배포 및 호스팅을 위한 Vercel

## 작동 원리

1. 사용자가 계산서 사진을 업로드합니다
2. 앱이 Vision 모델과 Json 모드를 사용하여 Together.ai로 PDF를 처리합니다
3. 사용자가 항목 분할 방법과 사람 이름을 선택할 수 있도록 앱이 안내합니다
4. 앱이 계산서 분할 최종 요약을 표시합니다

## 복제 및 실행

1. 저장소를 포크하거나 클론합니다
2. LLM을 위해 https://togetherai.link 에서 계정을 만듭니다
3. S3 버킷을 위해 https://aws.amazon.com/ 에서 계정을 만듭니다
4. `.env` 파일을 생성합니다 (`.example.env`를 참조) 및 API 키를 교체합니다
5. `pnpm install` 및 `pnpm run dev`를 실행하여 의존성을 설치하고 로컬에서 실행합니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---