<p align="center">
  <img src="https://raw.githubusercontent.com/toddmaustin/mojo-v/main/./docs/MojoV-logo1.png" alt="Mojo-V Logo" width="550"/>
</p>

# Mojo-V: Secret Computation for RISC-V

**Mojo-V** (pronounced *“mojo-five”*) is a new RISC-V extension that introduces privacy-oriented programming capabilities for RISC-V. Mojo-V implements secret computation, enabling secure, efficient, and data-oblivious execution without reliance on fragile software and programmer trust. By sequestering sensitive data in dedicated secret registers and encrypting memory under a third-party key, Mojo-V prevents disclosures and enforces computation that is both blind (no direct disclosures) and silent (no side channel leakage). The design integrates seamlessly into the existing RISC-V ISA with only a mode bit and four new instructions, enforced entirely at decode. Early results show near-native execution speeds while offering over 5-7 orders of magnitude performance improvement compared to fully homomorphic encryption (FHE), with a clear roadmap for integration into CPUs, GPUs, and specialized accelerators.

To learn more...
- Here is an intro video describing Mojo-V: https://www.youtube.com/watch?v=HUT46TcNyyM
- Slides that give an overview of the Mojo-V project:  https://drive.google.com/file/d/1VVzZqYHvQgnKMgXZjg7I_cX2GzF7awSN

The current Mojo-V ISA Extension Specification (release 0.92):
- [In PDF format.] (https://drive.google.com/file/d/1pargKATFoQdy94i6bI3P_9mfNA_GsYSw)

To contact the developers of Mojo-V:
- Email: [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

# 🧩 Mojo-V Reference Platform — Release 0.92

## 🚧 Project Status

The Mojo-V reference platform release 0.92 implements secret integer and floating-point computation using a fixed symmetric key cipher. Mojo-V supports three encryption modes: fast, strong, and proof-carrying. As of this release, 64-bit secret computation is fully secretized and this early reference platform can be used for software development and red-teaming. Additional capabilities will be rolled out in future releases, including PKI support, LLVM compiler support, 32-bit RISC-V support, VIP-Bench benchmarks support, etc.

**Specification Version:** 0.92  (November 2025)  
**Contact:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

## Current components

1. **Mojo-V ISA Spec v0.92**
   - released in `doc/`
2. **Spike (Instruction Set Simulator) Implementation**
   - Mojo-V integrated into `riscv-isa-sim`, nearly feature-complete
   - Missing only: Public-Key Infrastructure (PKI) support (currently uses fixed keys with a Simon-128 cipher)
   - To run Spike with Mojo-V extensions enabled, add the `--isa=rv64gc_zicond_zkmojov_zicntr` flag when running `spike`
3. **Mojo-V Bringup-Bench Benchmarks**
   - Hand-coded examples (e.g., bubble-sort) showing Mojo-V working secret computation
   - Full battery of security tests for RV64GC+Mojo-V

Note, the remainder of the Bringup-bench benchmarks have NOT been ported to Mojo-V, as yet.

## ⚙️ Building and Running the Mojo-V Reference Platform

### A. Install a RISC-V LLVM Compiler
You’ll need an LLVM-based RISC-V cross-compiler capable of producing `RV64GC` binaries.

Here is a good place to start: https://clang.llvm.org/get_started.html

### B. Clone the Mojo-V Repository
```bash
git clone https://github.com/toddmaustin/mojo-v.git
cd mojo-v
```

### C. Build the RISC-V Spike simulator with Mojo-V Support
```bash
sudo apt-get install device-tree-compiler libboost-regex-dev libboost-system-dev
cd riscv-isa-sim
mkdir build
cd build
../configure --prefix=$RISCV
make
```

### D. Build and Run Mojo-V Bringup-Bench Benchmark Tests

1. **Build the Spike device driver**

   ```bash
   cd bringup-bench/target
   make
   ```

2. **Configure your compiler**

   Edit `../Makefile` and set `TARGET_CC` for the `mojov` target to the location of your LVM Clang-based RISC-V compiler.

3. **Build and test**

   ```bash
   cd ..                # go to the top-level bringup-bench directory
   make mojov-tests     # run all Mojo-V tests
   ```
作为替代方案，您可以进入其目录并运行以下命令来运行单个基准测试。


   ```bash
   cd ../mojov-test
   make TARGET=mojov clean build test
   ```

## 🧪 Mojo-V Bringup-Bench Benchmarks Overview

| Program | Description |
|:---------|:-------------|
| `mojov-test` | Intro example from slides |
| `mojov-test1` | Secret-register and encrypted-memory semantics tests |
| `mojov-test2` | Hand-coded data-oblivious integer bubble-sort benchmark with Mojo-V fast encryption (int,fast) |
| `mojov-test3` | Hand-coded data-oblivious floating-point bubble-sort benchmark with Mojo-V fast encryption (fp,fast) |
| `mojov-test4` | Hand-coded data-oblivious integer bubble-sort benchmark with Mojo-V strong encryption (int,strong) |
| `mojov-test5` | Hand-coded data-oblivious floating-point bubble-sort benchmark with Mojo-V strong encryption (fp,strong) |
| `mojov-pctests` | Hand-coded integrity checking test suite for RV64GC+Mojo-V that includes positive and negative tests for Mojo-V's proof-carrying encryption format (proofcarrying) |
| `mojov-sectests` | Hand-coded security test suite for RV64GC+Mojo-V that includes 130 pos + 245 neg tests == 375 total (int,fp,fast,strong) |

All test benchmarks are hand-coded assembly programs demonstrating Mojo-V ISA rules and security semantics. The other Bringup-Bench benchmarks have not yet been ported to Mojo-V.

---
## Code Licensing
All of the Mojo-V related code in this repo is released under the license of the tool it modified (e.g., Spike, LLVM, Bringup-Bench). Please see the tools' respective directories for licensing details.

---

## 💬 Questions & Feedback
We welcome contributions, bug reports, and suggestions!

📧 **Email:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)  
🌐 **Project Home:** [https://github.com/toddmaustin/mojo-v](https://github.com/toddmaustin/mojo-v)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---