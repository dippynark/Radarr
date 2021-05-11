DOCKER_IMAGE = radarr-build

all: build package

build:
	find . -name '*.csproj' -exec dotnet restore {} \;
	bash build.sh

package:
	rm -rf Radarr.linux.tar.gz Radarr
	cp -r ./_artifacts/linux-x64/netcoreapp3.1/Radarr Radarr
	tar -zcvf Radarr.linux.tar.gz ./Radarr/*

docker_image:
	docker build \
		-t $(DOCKER_IMAGE) $(CURDIR)

docker_%: docker_image
	docker run -it \
		-v $(CURDIR):/workspace \
		$(DOCKER_IMAGE) \
		make $*
