# 🚀 MCP AI개발 도우미

> AI 개발자를 위한 지능형 요구 분석 및 아키텍처 설계 보조 MCP 툴

## ✨ 핵심 기능

- **지능형 요구 명확화**: 프로젝트 유형 자동 인식, 맞춤형 질문 생성
- **분기 인식 관리**: 프로젝트 목표, 기능 설계, 기술 선호, UI 설계 등 다양한 차원 추적
- **아키텍처 자동 생성**: 완전한 요구 기반 기술 아키텍처 방안 생성
- **영속적 저장**: 분석 결과 자동 저장, 문서 내보내기 지원

## 📁 빠른 설정

### 구버전 설정
1. **코드 클론**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **가상 환경 권장**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **의존성 설치**
   ```bash
   pip install -r requirements.txt
   ```

4. **설정 파일 위치**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **설정 추가**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Claude Desktop 재시작**

### 신버전 설정
#### 🔧 핵심 도구
1. **start_new_project** - 새 프로젝트 시작
2. **create_requirement_blueprint** - 요구 블루프린트 생성
3. **requirement_clarifier** - 요구 명확화 프롬프트 획득
4. **save_clarification_tasks** - 명확화 작업 저장
5. **update_branch_status** - 분기 상태 업데이트
6. **requirement_manager** - 요구 문서 관리자
7. **check_architecture_prerequisites** - 아키텍처 전제 조건 확인
8. **get_architecture_design_prompt** - 아키텍처 설계 프롬프트 획득
9. **save_generated_architecture** - 생성된 아키텍처 설계 저장
10. **export_final_document** - 완성 문서 내보내기
11. **view_requirements_status** - 요구 상태 보기

#### 설정(원격 직결 복사하여 도구에 붙여넣고, MCP_STORAGE_DIR을 본인 로컬 디렉토리로 변경)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 사용 절차

### 기본 단계

1. **요구 명확화**
   ```
   requirement_clarifier("온라인 교육 플랫폼을 만들고 싶어요")
   ```

2. **요구 관리**
   ```
   requirement_manager("목표 사용자: 학생과 교사", "프로젝트 개요")
   ```

3. **상태 보기**
   ```
   view_requirements_status()
   ```

4. **아키텍처 설계**
   ```
   architecture_designer("온라인 교육 플랫폼 아키텍처")
   ```

5. **문서 내보내기**
   ```
   export_final_document()
   ```

## 🚀 시작하기

### 빠른 시작
1. **Claude Desktop 구성** (위의 구성 방법 참고)
2. **Claude Desktop 재시작**
3. **지능형 요구사항 분석 시작**：
   ```
   requirement_clarifier("프로젝트 아이디어를 설명하세요")
   ```
4. **AI의 지능형 안내를 따라** 각 요구사항 분기를 단계별로 완성
5. **전체 문서 내보내기**：
   ```
   export_final_document()
   ```

### 모범 사례
- 💬 **AI의 분기 관리를 신뢰하세요**: AI가 모든 요구사항 분기를 완성하도록 안내하게 하세요
- 🎯 **선호도를 명확히 표현하세요**: 기술 스택, UI 스타일 등에 대한 선호를 명확히 표현하세요
- 📊 **정기적으로 상태를 확인하세요**: `view_requirements_status`를 사용해 진행 상황을 확인하세요
- 🤖 **AI에 적절히 권한을 부여하세요**: 불확실한 부분은 "일반적인 방안 사용"이라고 말할 수 있습니다

---

**🎯 이제 당신은 모든 세부사항을 기억하고 완전한 요구사항 분석을 안내하는 진정한 지능형 AI 개발 어시스턴트를 갖게 되었습니다!**

## 💬 커뮤니티 그룹

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="커뮤니티 그룹">
<br>
커뮤니티 그룹
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---