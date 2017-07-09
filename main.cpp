#include "SDL.h" 
#include "src/renderer.h"

int main(int argc, char *argv[])
{
	SDL_Init(SDL_INIT_VIDEO);

	auto window = SDL_CreateWindow(
		"SDL2Test",
		SDL_WINDOWPOS_UNDEFINED,
		SDL_WINDOWPOS_UNDEFINED,
		640,
		480,
		0
	);

	auto renderer = Renderer(window);
	renderer.Begin();

	// TODO: Invoke draw calls

	renderer.End();

	SDL_Delay(3000);

	SDL_DestroyWindow(window);
	SDL_Quit();

	return 0;
}
