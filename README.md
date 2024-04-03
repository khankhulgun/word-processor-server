docker build --platform linux/amd64 --build-arg ARCH=x64 -t docx .
docker build -t document .




name: Docker Image CI

on:
push:
branches: [ "main" ]
pull_request:
branches: [ "main" ]

jobs:

build:

    runs-on: ubuntu-latest

    steps:
    - uses: actions/checkout@v3
    - name: Use Node.js 20
      uses: actions/setup-node@v3
      with:
        node-version: '20'
    - name: Build the Docker image
      run: docker build . --file Dockerfile --target prod -t ghcr.io/khankhulgun/word-processor-server
    - name: Push the Docker image
      run: docker push ghcr.io/khankhulgun/word-processor-server:latest