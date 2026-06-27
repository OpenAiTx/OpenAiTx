<p align="center">
<img src="https://github.com/dahlend/kete/blob/main/docs/_static/kete.svg" style="width:20%">
</p> 

# *Kete*

Predict orbits of asteroids and comets at large scales.

See the [arXiv paper](http://arxiv.org/abs/2509.04666).

![Github Actions](https://github.com/dahlend/kete/actions/workflows/test-lint.yml/badge.svg?branch=main)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.15259732.svg)](https://doi.org/10.5281/zenodo.15259732)
[![arXiv](https://img.shields.io/badge/arXiv-2509.04666-00ff00.svg)](http://arxiv.org/abs/2509.04666)

The kete tools are intended to enable the simulation of all-sky surveys of minor
planets. This includes multi-body physics orbital dynamics, orbit determination and
fitting, thermal and optical modeling of the objects, as well as field of view and light
delay corrections. These tools in conjunction with the Minor Planet Centers (MPC) and
JPL's databases of known asteroids can be used to not only plan surveys but can also be
used to predict what objects are visible for existing or past surveys.

The primary goal for kete is to enable a set of tools that can operate on the entire
MPC catalog at once, without having to do queries on specific objects. It has been
used to simulate over 10 years of survey time for the NEO Surveyor mission using 10
million main-belt and near-Earth asteroids.

[Documentation](https://dahlend.github.io/kete/)  
   - [Examples](https://dahlend.github.io/kete/auto_examples/index.html)
   - [Tutorials](https://dahlend.github.io/kete/tutorials/index.html)


https://github.com/user-attachments/assets/a48491d8-9c15-4659-9022-1767a3aa1e94

Here is a simulation of what the ZTF survey would observe during the entirety of 2023.
This is every position of every numbered asteroid, along with a calculation of the
expected V-band magnitudes. If the expected magnitude is less than ZTF's reported
magnitude limit for the specific frame, then the object will flash light grey.

This took about 50 minutes on a desktop computer to compute, and about 40 minutes
to generate the movie.

Kete can be used to answer many questions, for example, identifying all known asteroids
inside of a [given image](https://dahlend.github.io/kete/tutorials/kona.html).

Kete can also be used as a backend for more fun visualizations, such as:  

[Ketev](https://dahlend.github.io/ketev/) - Solar System Visualizer in your browser


## Installation

Kete may be installed using pip:

``` bash
pip install kete
```

## Example of Code

Here is a small example showing off what programming with kete looks like.
This calculates the closest distance that the asteroid Apophis will be at
during its *very* close approach to Earth in April of 2029.

A more in-depth look at this example can be found
[here](https://dahlend.github.io/kete/auto_examples/plot_close_approach.html).

```python

      import kete
      import numpy as np

      # Date of impact +- 1 day in Julian Date
      jd_center = kete.Time.from_ymd(2029, 4, 13.9066).jd

      # Step the orbit every 1 minute for +- 1 day.
      step_size = 1 / 24 / 60
      jd_range = np.arange(-1, 1, step_size) + jd_center

      # load Apophis from JPL Horizons
      obj = kete.HorizonsProperties.fetch("Apophis")
      cur_state = obj.state

      # keep track the the closest approach
      closest_approach = [np.inf, 0]
      for jd in jd_range:
            # propagate the object, and include the massive main belt asteroids
            cur_state = kete.propagate_n_body(cur_state, jd, include_asteroids=True)

            # calculate position relative to earth
            earth_vec = cur_state.pos - kete.spice.get_state("Earth", cur_state.jd).pos
            earth_dist = earth_vec.r * kete.constants.AU_KM
            if earth_dist < closest_approach[0]:
                  closest_approach = [earth_dist, cur_state.jd]

      print("Closest approach is on:")
      print(kete.Time(closest_approach[1]).iso)
      print(f"At a distance of about {closest_approach[0]:0.0f} km")
      #  Closest approach is on:
      #  2029-04-13T21:45:30.239+00:00
      #  At a distance of about 38015 km

```
## Name

'Kete' comes from ancient Greek mythology, meaning sea monsters, and is the root word
for Cetaceans (Whales).

## Licensing:

The original version of this code was developed while the original author (Dar Dahlen)
was working at Caltech IPAC. This is a fork of that repo where the work will continue as
a personal project. Difference between this fork and previous code is licensed as
BSD 3-Clause but copyright to Dar Dahlen & future collaborators.

### Units and Reference Frame

Kete uses the ICRF Reference frame as the base coordinate frame, with units of AU,
with time in JD with Barycentric Dynamical Time (TDB) scaling. Internally this frame
converted to an Ecliptic coordinate system which is defined by the Obliquity Angle
definition used by JPL Horizons, which is the defined IAU76/80 model in the J2000 frame.

      - https://en.wikipedia.org/wiki/Axial_tilt#Short_term
      - https://ssd.jpl.nasa.gov/horizons/manual.html#defs

Both JPL Horizons and the Minor Planet Center (MPC) use this coordinate frame, which is
essentially equivalent to J2000 Ecliptic coordinates. Conversion tools are available in
kete which enable conversion to the Equatorial frame and to various flavors of time.

### Cache directory

Many operations in kete result in downloading various files. These files are cached
automatically, the directory where this cache is stored may be set by setting the
environment variable `KETE_CACHE_DIR`. The default directory is `~/.kete/`.


``` bash
export KETE_CACHE_DIR="~/.kete/"
```

### Use with Containers - Docker/Podman

Be aware that kete downloads several large SPICE kernel files on first use, which are
saved to a cache directory.

**Important for Docker/Podman:**
- If you trigger the download **during the Docker build** (e.g.,
  `RUN python -c "import kete"`), the files will be baked into the image.
- If you skip this step, the files will download on first container run but
  **will be lost when the container stops** unless you use a volume mount for the cache
  directory.

**Recommended Dockerfile approach:**
```dockerfile
RUN pip install kete && \
    python -c "import kete"  # Triggers kernel downloads during build
```

This ensures the SPICE kernels are part of your image and don't need re-downloading.

# Developer information:

Information below is aimed for developers, and is not necessary for end users.

## Installation - From Source

If kete is built from source, the rust compiler must be installed. Installation
instructions may be found here: 

https://www.rust-lang.org/learn/get-started

Ensure that your Python is up to date, this code runs on Python 3.9+.
``` bash
python --version
```

Ensure that your pip is up to date, this should be at least version `22.0.0`.
``` bash
pip --version
```

This can be updated using:
``` bash
python -m pip install "pip>=22.0.0" --upgrade
pip install setuptools --upgrade
```

### Development

If you plan on doing development, it is recommended to install with the following:
``` bash
pip install '.[dev]'
```
The `[dev]` in that line has pip install a number of optional dependencies which  
are useful for development. Including pytest and documentation tools.  

### Building Documentation  

In order for documentation to be built, some additional Python libraries are needed.  
These can be installed with:
``` bash
pip install sphinx sphinx_gallery autodoc
```
After this has been installed, the documentation can be built by running inside the
kete directory.
``` bash
(cd docs && make html && open html/index.html&)
```
Once this has completed running, open the file `kete/docs/html/index.html` for access  
to the HTML documentation.

To clean the previous docs build:
``` bash
(cd docs && make clean)
```

Documentation tests may be run with:
``` bash
(cd docs && make doctest)
```

### Running tests

Running tests require that the `pytest` and `pytest-cov` packages be installed.

Open a terminal in the base of this folder and run the following command:
``` bash
pytest --cov-report term-missing --cov=kete   
```

Another coverage report type is HTML, this will generate a folder called `htmlcov`
in the directory where the command was run, then you can open the `htmlcov/index.html`
file. This is a user-friendly website representation of the code coverage.
``` bash
pytest --cov-report html --cov=kete   
```

### Running Tutorials

Tutorials are computationally expensive examples which are more indicative of typical
expected use. Since these examples are so expensive to run, they are not run unless
manually performed. A convenience python script has been provided to do just this.

``` bash
cd docs
python utils.py
```

### Running Benchmarks

There are a test suite of micro-benchmarks in the rust backend of kete. These require
`gnuplot` to be installed, and may be run using the following command:

``` bash
cargo bench
open target/criterion/report/index.html
```
Additionally, Flamegraphs may be produced using the following:


``` bash
cargo bench --bench propagation -- --profile-time=5
cargo bench --bench spice -- --profile-time=5
cargo bench --bench thermal -- --profile-time=5
```

These flamegraphs will be placed in `target/criterion/*/profile/flamegraph.svg`. Opening
these files in a web browser will display which functions are being used during the benchmark.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-27

---