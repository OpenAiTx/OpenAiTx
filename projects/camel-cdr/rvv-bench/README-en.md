# RISC-V Vector benchmark

A collection of RISC-V Vector (RVV) benchmarks to help developers write portably performant RVV code.

Benchmark results can be found at: https://camel-cdr.github.io/rvv-bench-results

## Benchmarks ([./bench/](./bench/))

Contains a bunch of benchmark of different implementations of certain algorithms.

## Instruction cycle count ([./instructions/](./instructions/))

Measures the cycle count of RVV instructions by unrolling and looping over the given instruction repeatedly.

## Getting started

Start by configuring [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk), such that `make` works and optionally [./run.sh](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./run.sh), which allows you to compile and run using `make run`.

The default configuration should work with all recent clang builds and doesn't require a full cross compilation toolchain, because it builds in freestanding mode.
This means it will only work on linux, or linux syscall compatible OS.

On recent linux versions, the performance counters aren't exposed by default, you may have to execute `echo 2 >/proc/sys/kernel/perf_user_access` and append `-DUSE_PERF_EVENT` to the `CFLAGS=...` line in [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) (if that doesn't work, try `-DUSE_PERF_EVENT_SLOW` instead).

You can configure [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) to build a hosted build or configure it with your custom toolchain, add the `-DCUSTOM_HOST` define, and implement the unimplemented functions under `#ifdef CUSTOM_HOST` in [./nolibc.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./nolibc.h).

XTheadVector isn't supported anymore.

### Running benchmarks ([./bench/](./bench/))

To run the benchmarks, first look through ([./bench/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./bench/config.h)) and adjust it to your processor (e.g. set `HAS_E64`). If it takes too long to execute, try lowering `MAX_MEM`, which is used to scale the benchmark, and play around with the other constants until it executes in a reasonable amount of time and gives a relatively smooth graph.

Now you can just run the benchmarks using `make run` in the ([./bench/](./bench/)) directory, or `make` to just build the executables.

### Measuring cycle count ([./instructions/](./instructions/))

To run the cycle count measurement, first configure [instructions/rvv/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/instructions/rvv/config.h) to your processor.

Now you can run the measurement using `make run` in the ([./instructions/rvv/](./instructions/rvv/)) directory, or `make` to just build the executables.

For XTheadVector use the ([./instructions/xtheadvector/](./instructions/xtheadvector/)) directory instead. (this isn't maintained anymore)
## Contributing

Here are some suggestions of things that still need to be done.

* contribute a measurement of a new CPU to: https://github.com/camel-cdr/rvv-bench-results \
  You can just create an issue with a single json file, which contains all concatenated [./bench/](./bench/) results. (after proper setup, `make run > out.json` should do the trick). \
* implement non memory bound benchmarks
* implement more benchmarks
* better cycle count measurements: throughput vs latency (also: can we figure out the execution port configuration?)
* cycle count for load/stores
* cycle count for vsetvl

## License

This repository is licensed under the MIT [LICENSE](LICENSE).




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---