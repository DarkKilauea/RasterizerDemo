cmake_minimum_required(VERSION 3.7)
project(RasterizerDemo)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_MODULE_PATH ${CMAKE_MODULE_PATH} "${CMAKE_SOURCE_DIR}/cmake_modules/")

set(SOURCE_FILES main.cpp src/renderer.cpp)

add_executable(RasterizerDemo ${SOURCE_FILES})

# SDL2
find_package(SDL2 REQUIRED)
include_directories(${SDL2_INCLUDE_DIRS})
target_link_libraries(RasterizerDemo ${SDL2_LIBRARIES})

# SDL Image
find_package(SDL2_image REQUIRED)
include_directories(${SDL2_IMAGE_INCLUDE_DIRS})
target_link_libraries(RasterizerDemo ${SDL2_IMAGE_LIBRARIES})
