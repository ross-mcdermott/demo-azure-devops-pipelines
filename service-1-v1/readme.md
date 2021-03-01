# Run As Container

Build the container, with the docker context set to the root of the repo.

```bash
# run from root of repo
docker build --tag service-1-v1:local -f ./Dockerfile .
```

to run

```bash
# run from root of repo
docker run -p 8000:8000 service-1-v1:local 
```
