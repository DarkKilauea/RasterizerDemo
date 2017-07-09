#ifndef RENDERER_H_
#define RENDERER_H_

#include "SDL.h"

class Renderer
{
public:
	/**
	 * \brief Create a renderer to draw to a target window
	 * \param window Window to draw to
	 */
	explicit Renderer(SDL_Window* window);
	~Renderer();

	void Begin();
	void End();

private:
	SDL_Renderer* _renderer;
};

#endif
