# OpenFile
OpenFile is a free tax tool forked from IRS Direct File. More information at https://docs.openfile.tax/en/latest/reference.html.

# Running
OpenFile uses Docker. To run the entirety of OpenFile:

```
git clone https://github.com/openfiletax/openfile.git --recurse-submodules
docker compose up -d
```

The OpenFile client will start at `localhost:3000/df/file`.