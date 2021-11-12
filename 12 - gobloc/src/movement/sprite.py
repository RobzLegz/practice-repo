from src.checks.collision import *

right = False
left = False
up = False
down = False

def move(rect, movement, tiles):
    rect.x += movement[0]
    collisions = collision_test(rect,tiles)
    for tile in collisions:
        if movement[0] > 0:
            rect.right = tile.left
        if movement[0] < 0:
            rect.left = tile.right
    rect.y += movement[1]
    collisions = collision_test(rect,tiles)
    for tile in collisions:
        if movement[1] > 0:
            rect.bottom = tile.top
        if movement[1] < 0:
            rect.top = tile.bottom
    return rect

def jump():
    pass