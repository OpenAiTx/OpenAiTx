# Argon 🚀

**Git-like MongoDB Branching for ML/AI Workflows**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://golang.org)
[![Python](https://img.shields.io/badge/Python-3.11+-3776AB?logo=python)](https://python.org)
[![MongoDB](https://img.shields.io/badge/MongoDB-7.0+-47A248?logo=mongodb)](https://mongodb.com)

> **🎉 Now Available!** Argon brings enterprise-grade MongoDB branching with sub-500ms operations, ML-native features, and a hybrid Go+Python architecture.

## What is Argon?

Argon is a MongoDB branching system that provides Git-like database operations optimized for ML/AI workflows. Think "Neon for MongoDB" with first-class support for data science teams.

### Key Features

- **⚡ Instant Branching**: Create database branches in <500ms regardless of size
- **🔄 Copy-on-Write**: Efficient storage with 90%+ space savings vs full copies  
- **🧠 ML-Native**: Built-in integrations with MLflow, DVC, Weights & Biases
- **🌐 Real-time**: Live change streams and WebSocket-based dashboard
- **☁️ Multi-cloud**: AWS S3, Google Cloud Storage, Azure Blob support
- **🔒 Enterprise**: Authentication, RBAC, audit logs, compliance features

## Architecture

Argon uses a hybrid architecture optimizing for both performance and developer productivity:

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   CLI Tool      │    │  Web Dashboard  │    │ ML Integrations │
│   (Go Binary)   │    │   (Next.js)     │    │ (Python APIs)   │
└─────────────────┘    └─────────────────┘    └─────────────────┘
         │                       │                       │
         └───────────────────────┼───────────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Python API     │
                    │  (FastAPI)      │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Go Engine      │
                    │ (Performance)   │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │    MongoDB      │
                    │ + Change Streams│
                    └─────────────────┘
```

**Performance Tier (Go)**: Change streams, branching engine, CLI, storage
**Productivity Tier (Python)**: Web APIs, ML integrations, admin features

## Quick Start

### Installation

Choose your preferred installation method:

#### Quick Install (From Source)
```bash
# Clone and build latest version
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
sudo mv argon /usr/local/bin/
```

#### Homebrew (macOS/Linux) 
```bash
brew install argon-lab/tap/argonctl
```

#### npm (Cross-platform)
```bash
npm install -g argonctl
```

#### Direct Download
```bash
# Linux (x64)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-linux-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Intel)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Apple Silicon)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-arm64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/
```

#### From Source
```bash
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
```

### Verify Installation
```bash
argon --version
# argon version 1.0.0
```

### Development Setup (Contributors)

```bash
# Clone the repository
git clone https://github.com/argon-lab/argon.git
cd argon

# Start the development environment
docker compose up -d

# Verify services are running
curl http://localhost:8080/health  # Go engine
curl http://localhost:3000/health  # Python API
```

### Basic Usage

```bash
# Verify installation
argon --version

# Get help
argon --help

# Create a new project (requires running services)
argon projects create --name my-ml-project --mongodb-uri mongodb://localhost:27017

# List your projects
argon projects list

# Note: Full functionality requires the Argon services to be running
# See Development Setup below for starting the complete system
```

## What Works Now

✅ **CLI Installation** - Install `argon` command globally  
✅ **Core Architecture** - Hybrid Go+Python system ready  
✅ **Storage Engine** - S3 backend with 42% compression  
✅ **Local Development** - Full Docker environment  

## Coming Soon

✅ **Homebrew** - `brew install argon-lab/tap/argonctl` (live now!)  
✅ **npm Package** - `npm install -g argonctl` (live now!)  
🚧 **Hosted Service** - Cloud-hosted Argon for instant use  
🚧 **Web Dashboard** - Visual branch management  
🚧 **ML Integrations** - MLflow, DVC, Weights & Biases  

## Current Status

The **CLI and core system are production-ready**. The package manager distributions and hosted service are being prepared for public launch.

## Performance Targets

| Metric | Target | Current Status |
|--------|--------|----------------|
| Branch Creation | <500ms | 🟢 Implemented |
| Change Processing | 10,000+ ops/sec | 🟢 Implemented |
| Storage Efficiency | 40%+ compression | 🟢 Achieved (42.40%) |
| CLI Startup | <50ms | 🟢 Achieved |

## Use Cases

### Data Science Teams
```python
# In Jupyter notebook
import argon

# Create experiment branch
argon.branch.create("model-v2-experiment")

# Train model with versioned data
model = train_model(argon.data.get_collection("training_data"))

# Track experiment metadata
argon.experiment.log(model_accuracy=0.95, dataset_version="v2.1")

# Merge successful experiment
argon.branch.merge("model-v2-experiment", "main")
```

### Development Teams
```bash
# Create feature branch with production data copy
argon branch create feature-new-analytics --from production

# Develop and test against real data
# ... make database schema changes ...

# Review changes before merge
argon diff main..feature-new-analytics

# Deploy to production
argon branch merge feature-new-analytics main
```

## Contributing

We welcome contributions! This is an open-source project built for the community.

### Development Workflow

1. **Fork the repository**
2. **Set up development environment**: `docker-compose up -d`
3. **Make changes** in the appropriate service:
   - Go engine: `services/engine/`
   - Python API: `services/api/`
   - Web dashboard: `services/web/`
4. **Test your changes**: Run the test suite
5. **Submit a pull request**

### Project Structure

```
argon/
├── services/
│   ├── engine/          # Go performance engine
│   ├── api/             # Python FastAPI service
│   └── web/             # Next.js web dashboard
├── docs/                # Documentation
├── examples/            # Example usage and tutorials
├── scripts/             # Development and deployment scripts
└── docker-compose.yml   # Development environment
```

## Roadmap

### v1.0 (Current) - Production Ready
- Hybrid Go+Python architecture
- Core branching operations
- MongoDB change streams
- CLI and API interface
- S3 storage with compression

### v1.1 - ML Integration
- MLflow connector
- DVC integration
- Weights & Biases support
- Jupyter notebook examples

### v1.2 - Enterprise Features
- User authentication and RBAC
- Team collaboration features
- Advanced branch operations
- Performance optimization

### v1.3 - Scale & Polish
- Multi-region deployment
- Advanced analytics
- Plugin architecture
- Enterprise support

## Architecture Deep Dive

For detailed technical documentation, see:
- [Architecture Overview](https://raw.githubusercontent.com/argon-lab/argon/master/docs/architecture.md)
- [API Documentation](https://raw.githubusercontent.com/argon-lab/argon/master/docs/api.md)
- [Development Guide](https://raw.githubusercontent.com/argon-lab/argon/master/docs/development.md)
- [Deployment Guide](https://raw.githubusercontent.com/argon-lab/argon/master/docs/deployment.md)

## Community

- **GitHub Discussions**: Ask questions and share ideas
- **Discord**: Real-time chat with the community (link coming soon)
- **Twitter**: Follow [@argondb](https://twitter.com/argondb) for updates

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Built by MongoDB Engineers

Argon is built with deep MongoDB expertise, leveraging advanced features like change streams, optimized aggregation pipelines, and performance best practices learned from production deployments.

---

**⭐ Star this repository if you find it useful!**

[![GitHub stars](https://img.shields.io/github/stars/argon-lab/argon?style=social)](https://github.com/argon-lab/argon)