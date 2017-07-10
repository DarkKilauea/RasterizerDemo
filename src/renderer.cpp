#include "renderer.h"

Renderer::Renderer(SDL_Window* window)
{
	_renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_SOFTWARE);
}

Renderer::~Renderer()
{

}

void Renderer::Begin()
{
	SDL_SetRenderDrawColor(_renderer, 128, 0, 0, SDL_ALPHA_OPAQUE);
	SDL_RenderClear(_renderer);
}

void Renderer::End()
{
	SDL_RenderPresent(_renderer);
}

